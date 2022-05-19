Public Class Rotation

    Private name As String
    Private item_ids As New List(Of String)
    Private item_types As New List(Of String)
    Private rotation_id As Integer

    Public Property item_id() As List(Of String)
        Get
            Return item_ids
        End Get
        Set(ByVal value As List(Of String))
            item_ids = value
        End Set
    End Property
    Public Property item_type() As List(Of String)
        Get
            Return item_types
        End Get
        Set(ByVal value As List(Of String))
            item_types = value
        End Set
    End Property
    Public ReadOnly Property rotation_name() As String
        Get
            Return name
        End Get
    End Property
    Public ReadOnly Property id() As Integer
        Get
            Return rotation_id
        End Get
    End Property
    Public ReadOnly Property rotation_length() As Integer
        Get
            Return item_ids.Count
        End Get
    End Property

    ' Save the rotation to the database

    Public Sub saveToDb()

        Dim db As New Database(ProgramSettings.parts_db_location)
        Dim item_string As String = ""
        Dim counter As Integer

        ' Create item string

        For counter = 0 To (item_ids.Count - 1)
            item_string = item_string & item_ids(counter) & "-" & item_types(counter) & ";"
        Next

        item_string = item_string.Remove(item_string.Length - 1, 1)

        ' Now write the data to the database

        db.execute("UPDATE rotations SET rotation = """ & item_string & """, name = """ & Me.name & """ WHERE rotationid = " & Me.rotation_id)

        ' Close the connection

        db.disconnect()
        db = Nothing

    End Sub

    ' Save a new rotation to the database

    Public Sub saveNewRotationToDb()

        Dim db As New Database(ProgramSettings.parts_db_location)
        Dim rs As OleDb.OleDbDataReader
        Dim item_string As String = ""
        Dim counter As Integer

        ' Create item string

        For counter = 0 To (item_ids.Count - 1)
            item_string = item_string & item_ids(counter) & "-" & item_types(counter) & ";"
        Next

        If (item_string.Length > 0) Then
            item_string = item_string.Remove(item_string.Length - 1, 1)
        End If

        ' Now write the data to the database obtaining the spotid

        db.execute("INSERT INTO rotations (rotation, name) VALUES (""" & item_string & """, """ & Me.name & """)")
        rs = db.executeRS("SELECT rotationid FROM rotations WHERE name = """ & Me.name & """")

        While rs.Read
            Me.rotation_id = rs(0)
        End While

        ' Close the connection

        rs.Close()
        db.disconnect()
        rs = Nothing
        db = Nothing

    End Sub

    ' Constructors (without and with database connection respectivly)

    Public Sub New(ByVal rotation_id As Integer, ByRef name As String, ByRef item_string As String)

        Dim rot_temp As String()
        Dim item_temp As String()
        Dim semi_colon As Char() = ";"
        Dim dash As Char() = "-"
        Dim counter As Integer

        ' Load the variables

        Me.rotation_id = rotation_id
        Me.name = name

        ' Load the playlist

        rot_temp = item_string.Split(semi_colon, StringSplitOptions.RemoveEmptyEntries)
        For counter = 0 To (rot_temp.Length - 1)
            item_temp = rot_temp(counter).Split(dash, StringSplitOptions.RemoveEmptyEntries)
            Me.item_ids.Add(item_temp(0))
            Me.item_types.Add(item_temp(1))
        Next

    End Sub

    Public Sub New(ByVal rotation_id As Integer, ByRef name As String)

        Dim rot_temp As String()
        Dim item_temp As String()
        Dim semi_colon As Char() = ";"
        Dim dash As Char() = "-"
        Dim counter As Integer
        Dim item_string As String = Nothing

        ' Get the item string from the database
        ' Connect

        Dim db As Database = New Database(ProgramSettings.parts_db_location)
        Dim rs As OleDb.OleDbDataReader = db.executeRS("SELECT rotation FROM rotations WHERE rotationid = " & rotation_id)

        ' Retrieve

        While rs.Read
            item_string = rs(0)
        End While

        ' Disconnect

        rs.Close()
        db.disconnect()
        rs = Nothing
        db = Nothing

        ' Load the variables

        Me.rotation_id = rotation_id
        Me.name = name

        ' Load the playlist

        If (item_string Is Nothing) Then
            Exit Sub
        End If

        rot_temp = item_string.Split(semi_colon, StringSplitOptions.RemoveEmptyEntries)
        For counter = 0 To (rot_temp.Length - 1)
            item_temp = rot_temp(counter).Split(dash, StringSplitOptions.RemoveEmptyEntries)
            Me.item_ids.Add(item_temp(0))
            Me.item_types.Add(item_temp(1))
        Next

    End Sub

End Class

Public Class Spot

    Private name As String
    Private items As Playlist
    Private spot_id As Integer
    Private play_in_order As Boolean

    Public Property playlist() As Playlist
        Get
            Return Me.items
        End Get
        Set(ByVal value As Playlist)
            Me.items = value
        End Set
    End Property
    Public ReadOnly Property spot_name() As String
        Get
            Return name
        End Get
    End Property
    Public ReadOnly Property id() As Integer
        Get
            Return Me.spot_id
        End Get
    End Property
    Public Property play_as_list() As Boolean
        Get
            Return play_in_order
        End Get
        Set(ByVal value As Boolean)
            play_in_order = value
        End Set
    End Property

    ' Save the spot to the database

    Public Sub saveToDb()

        Dim db As New Database(ProgramSettings.parts_db_location)
        Dim item_string As String = ""
        Dim counter As Integer

        ' Create item string

        For counter = 0 To (items.getPlaylistLength - 1)
            item_string = item_string & items.getItem(counter).getTrackId & "-" & items.getItem(counter).getDbTable & ";"
        Next

        If item_string.Length > 0 Then
            item_string = item_string.Remove(item_string.Length - 1, 1)
        End If


        ' Now write the data to the database

        db.execute("UPDATE spots SET spot = """ & item_string & """, play_in_order = " & Me.play_in_order & ", name = """ & Me.name & """ WHERE spotid = " & Me.spot_id)

        ' Close the connection

        db.disconnect()
        db = Nothing

    End Sub

    ' Save a new spot to the database

    Public Sub saveNewSpotToDb()

        Dim db As New Database(ProgramSettings.parts_db_location)
        Dim rs As OleDb.OleDbDataReader
        Dim item_string As String = ""
        Dim counter As Integer

        ' Create item string

        For counter = 0 To (items.getPlaylistLength - 1)
            item_string = item_string & items.getItem(counter).getTrackId & "-" & items.getItem(counter).getDbTable
        Next

        If (Not item_string.Length = 0) Then
            item_string = item_string.Remove(item_string.Length - 1, 1)
        End If

        ' Now write the data to the database obtaining the spotid

        db.execute("INSERT INTO spots (spot, play_in_order, name) VALUES (""" & item_string & """, " & Me.play_in_order & ", """ & Me.name & """)")
        rs = db.executeRS("SELECT spotid FROM spots WHERE name = """ & Me.name & """")

        While rs.Read
            Me.spot_id = rs.GetInt32(0)
        End While

        ' Close the connection

        rs.Close()
        db.disconnect()
        rs = Nothing
        db = Nothing

    End Sub

    ' Constructors (without and with database connection respectivly)

    Public Sub New(ByVal spot_id As Integer, ByRef name As String, ByRef item_string As String, Optional ByRef play_in_order As Boolean = False)

        Dim pl_temp As String()
        Dim item_temp As String()
        Dim semi_colon As Char() = ";"
        Dim dash As Char() = "-"
        Dim counter As Integer

        ' Load the variables

        Me.spot_id = spot_id
        Me.name = name
        Me.items = New Playlist(Nothing, name)
        Me.play_in_order = play_in_order

        ' Load the playlist

        pl_temp = item_string.Split(semi_colon, StringSplitOptions.RemoveEmptyEntries)
        For counter = 0 To (pl_temp.Length - 1)
            item_temp = pl_temp(counter).Split(dash, StringSplitOptions.RemoveEmptyEntries)
            Me.items.addToPlaylist(New AudioItem(item_temp(0), item_temp(1), False))
        Next

    End Sub

    Public Sub New(ByVal spot_id As Integer, ByRef name As String)

        Dim pl_temp As String()
        Dim item_temp As String()
        Dim semi_colon As Char() = ";"
        Dim dash As Char() = "-"
        Dim counter As Integer
        Dim item_string As String = ""

        'Try

        ' Get the item string from the database
        ' Connect

        Dim db As Database = New Database(ProgramSettings.parts_db_location)
        Dim rs As OleDb.OleDbDataReader = db.executeRS("SELECT spot, play_in_order FROM spots WHERE spotid = " & spot_id)

        ' Retrieve

        While rs.Read
            item_string = rs.GetString(0)
            play_in_order = rs.GetBoolean(1)
        End While

        ' Disconnect

        rs.Close()
        db.disconnect()
        rs = Nothing
        db = Nothing

        ' Load the variables

        Me.spot_id = spot_id
        Me.name = name
        Me.items = New Playlist(Nothing, name)

        ' Load the playlist

        If (item_string Is Nothing) Then
            Exit Sub
        End If

        pl_temp = item_string.Split(semi_colon, StringSplitOptions.RemoveEmptyEntries)
        For counter = 0 To (pl_temp.Length - 1)
            item_temp = pl_temp(counter).Split(dash, StringSplitOptions.RemoveEmptyEntries)
            Me.items.addToPlaylist(New AudioItem(item_temp(0), item_temp(1), False))
        Next

        'Catch ex As Exception
        '   ErrorHandler.errorHandler(ex)
        'End Try

    End Sub

End Class

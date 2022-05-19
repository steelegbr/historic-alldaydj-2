Public Class ScheduledEvent

    Private scheduled_time As New Date(Now.Ticks)
    Private scheduled_id As New List(Of String)
    Private scheduled_type As New List(Of String)
    Private event_name As String
    Private event_id As Integer
    Private event_regularity As String
    Private event_force As Boolean = False
    Private scheduled_playlist As Playlist

    Public Property time() As Date
        Get
            Return scheduled_time
        End Get
        Set(ByVal value As Date)
            scheduled_time = value
        End Set
    End Property
    Public Property id_list() As List(Of String)
        Get
            Return scheduled_id
        End Get
        Set(ByVal value As List(Of String))

        End Set
    End Property
    Public Property type_list() As List(Of String)
        Get
            Return scheduled_type
        End Get
        Set(ByVal value As List(Of String))
            scheduled_type = value
        End Set
    End Property
    Public Property regularity() As String
        Get
            Return event_regularity
        End Get
        Set(ByVal value As String)
            event_regularity = value
        End Set
    End Property
    Public Property id() As Integer
        Get
            Return event_id
        End Get
        Set(ByVal value As Integer)
            event_id = value
        End Set
    End Property
    Public Property name() As String
        Get
            Return event_name
        End Get
        Set(ByVal value As String)
            event_name = value
        End Set
    End Property
    Public Property force() As Boolean
        Get
            Return event_force
        End Get
        Set(ByVal value As Boolean)
            event_force = value
        End Set
    End Property
    Public Property playlist() As Playlist
        Get
            Return scheduled_playlist
        End Get
        Set(ByVal value As Playlist)
            scheduled_playlist = value
        End Set
    End Property

    ' Save the event to the database

    Public Sub saveToDb()

        Dim db As New Database(ProgramSettings.parts_db_location)
        Dim item_string As String = ""
        Dim counter As Integer

        ' Create item string

        For counter = 0 To (scheduled_id.Count - 1)
            item_string = item_string & scheduled_id(counter) & "-" & scheduled_type(counter) & ";"
        Next

        item_string = item_string.Remove(item_string.Length - 1, 1)

        ' Now write the data to the database

        db.execute("UPDATE [events] SET event = """ & item_string & """, name = """ & Me.event_name & """, [time] = """ & Me.time & """, regularity = """ & Me.event_regularity & """, force = " & Me.event_force & " WHERE eventid = " & Me.event_id)

        ' Close the connection

        db.disconnect()
        db = Nothing

    End Sub

    ' Save a new event to the database

    Public Sub saveNewEventToDb()

        Dim db As New Database(ProgramSettings.parts_db_location)
        Dim rs As OleDb.OleDbDataReader
        Dim item_string As String = ""
        Dim counter As Integer

        ' Create item string

        For counter = 0 To (scheduled_id.Count - 1)
            item_string = item_string & scheduled_id(counter) & "-" & scheduled_type(counter) & ";"
        Next

        If (item_string.Length > 0) Then
            item_string = item_string.Remove(item_string.Length - 1, 1)
        End If

        ' Now write the data to the database obtaining the spotid

        db.execute("INSERT INTO [events] (event, name, [time], regularity, force) VALUES (""" & item_string & """, """ & Me.event_name & """, """ & Me.time & """, """ & Me.event_regularity & """, FALSE)")
        rs = db.executeRS("SELECT eventid FROM [events] WHERE name = """ & Me.event_name & """")

        While rs.Read
            Me.event_id = rs.GetInt32(0)
        End While

        ' Close the connection

        rs.Close()
        db.disconnect()
        rs = Nothing
        db = Nothing

    End Sub

    ' Save to the schedule database

    Public Sub saveNewEventToDbScheduled()

        Dim db As New Database(ProgramSettings.schedule_db_location)
        Dim item_string As String = ""
        Dim counter As Integer

        ' Create item string

        If (Not playlist Is Nothing) Then
            For counter = 0 To (playlist.getPlaylistLength - 1)
                item_string = item_string & playlist.getItem(counter).getTrackId & "-" & playlist.getItem(counter).getDbTable & ";"
            Next

            If (item_string.Length > 0) Then
                item_string = item_string.Remove(item_string.Length - 1, 1)
            End If
        End If

        ' Now write the data to the database obtaining the spotid

        db.execute("INSERT INTO [events] (event, name, [time], regularity, force) VALUES (""" & item_string & """, """ & Me.event_name & """, """ & Me.time & """, """ & Me.event_regularity & """, " & Me.force & ")")

        ' Close the connection

        db.disconnect()
        db = Nothing

    End Sub

    ' Constructors (without and with database connection respectivly)

    Public Sub New(ByVal event_id As Integer, ByRef name As String, ByRef item_string As String, ByRef regularity As String)

        Dim pl_temp As String()
        Dim item_temp As String()
        Dim semi_colon As Char() = ";"
        Dim dash As Char() = "-"
        Dim counter As Integer

        ' Load the variables

        Me.event_id = event_id
        Me.event_name = name
        Me.event_regularity = regularity

        ' Load the playlist

        pl_temp = item_string.Split(semi_colon, StringSplitOptions.RemoveEmptyEntries)
        For counter = 0 To (pl_temp.Length - 1)
            item_temp = pl_temp(counter).Split(dash, StringSplitOptions.RemoveEmptyEntries)
            Me.scheduled_id.Add(item_temp(0))
            Me.scheduled_type.Add(item_temp(1))
        Next

    End Sub

    Public Sub New(ByVal event_id As Integer, ByRef name As String)

        Dim pl_temp As String()
        Dim item_temp As String()
        Dim semi_colon As Char() = ";"
        Dim dash As Char() = "-"
        Dim counter As Integer
        Dim item_string As String

        ' Get the item string from the database
        ' Connect

        Dim db As Database = New Database(ProgramSettings.parts_db_location)
        Dim rs As OleDb.OleDbDataReader = db.executeRS("SELECT event, time, regularity, force FROM [events] WHERE eventid = " & event_id)

        ' Retrieve

        While rs.Read
            item_string = rs(0)
            time = rs(1)
            regularity = rs(2)
            event_force = rs(3)
        End While

        ' Disconnect

        rs.Close()
        db.disconnect()
        rs = Nothing
        db = Nothing

        ' Load the variables

        Me.event_id = event_id
        Me.event_name = name

        ' Load the playlist

        If (item_string Is Nothing) Then
            Exit Sub
        ElseIf (item_string.Length = 0) Then
            Exit Sub
        End If

        pl_temp = item_string.Split(semi_colon, StringSplitOptions.RemoveEmptyEntries)
        For counter = 0 To (pl_temp.Length - 1)
            item_temp = pl_temp(counter).Split(dash, StringSplitOptions.RemoveEmptyEntries)
            Me.scheduled_id.Add(item_temp(0))
            Me.scheduled_type.Add(item_temp(1))
        Next

    End Sub

    ' Delete the event

    Public Sub DeleteEvent()

        ' Connect

        Dim db As New Database(ProgramSettings.parts_db_location)

        ' Do the delete

        db.execute("DELETE FROM [events] WHERE [eventid] = """ & Me.event_id & """")

        ' Disconnect

        db.disconnect()
        db = Nothing

    End Sub

End Class
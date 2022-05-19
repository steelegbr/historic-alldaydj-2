Public Class ScheduledEvent

    Private scheduled_time As New Date(Now.Ticks)
    Private scheduled_id As New List(Of String)
    Private scheduled_type As New List(Of String)
    Private event_name As String
    Private event_id As Integer
    Private event_regularity As String
    Private event_force As Boolean = False
    Private scheduled_playlist As New Playlist(Nothing, "SCHEDULED")

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

    ' Constructor

    Public Sub New(ByVal event_id As Integer, ByRef name As String)

        Dim pl_temp As String()
        Dim item_temp As String()
        Dim split_temp As String()
        Dim semi_colon As Char() = ";"
        Dim dash As Char() = "-"
        Dim counter As Integer
        Dim item_string As String

        ' Get the item string from the database
        ' Connect

        Dim db As Database = New Database(General.program_settings.getScheduleLocation)
        Dim rs As OleDb.OleDbDataReader = db.executeRS("SELECT event, time, regularity, force FROM [events] WHERE eventid = " & event_id)

        ' Retrieve

        If Not rs Is Nothing Then
            While rs.Read
                item_string = rs(0)
                time = rs(1)
                regularity = rs(2)
                event_force = rs(3)
            End While
        End If

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
            If (item_temp(1).Equals("HARDWARE")) Then
                split_temp = item_temp(0).Split(":")
                Me.playlist.addToPlaylist(New AudioItem(Integer.Parse(split_temp(0)), Integer.Parse(split_temp(1)), Integer.Parse(split_temp(2))))
            Else
                Me.playlist.addToPlaylist(New AudioItem(item_temp(0), item_temp(1), False))
            End If
        Next

    End Sub

End Class
Public Class ProgramSettings

    Shared schedule_location As String
    Shared parts_location As String
    Shared playlist_list As List(Of Playlist)
    Shared spots_list As List(Of Spot)
    Shared rotations_list As List(Of Rotation)
    Shared events_list As List(Of ScheduledEvent)
    Shared record_collection_file_name As String

    ' Getters and setters

    Public Shared Property schedule_db_location() As String
        Get
            Return schedule_location
        End Get
        Set(ByVal value As String)
            schedule_location = value
        End Set
    End Property
    Public Shared Property parts_db_location() As String
        Get
            Return parts_location
        End Get
        Set(ByVal value As String)
            parts_location = value
        End Set
    End Property
    Public Shared Property playlists() As List(Of Playlist)
        Get
            Return playlist_list
        End Get
        Set(ByVal value As List(Of Playlist))
            playlist_list = value
        End Set
    End Property
    Public Shared Property spots() As List(Of Spot)
        Get
            Return spots_list
        End Get
        Set(ByVal value As List(Of Spot))
            spots_list = value
        End Set
    End Property
    Public Shared Property rotations() As List(Of Rotation)
        Get
            Return rotations_list
        End Get
        Set(ByVal value As List(Of Rotation))
            rotations_list = value
        End Set
    End Property
    Public Shared Property events() As List(Of ScheduledEvent)
        Get
            Return events_list
        End Get
        Set(ByVal value As List(Of ScheduledEvent))
            events_list = value
        End Set
    End Property
    Public Shared Property record_collection_location() As String
        Get
            Return record_collection_file_name
        End Get
        Set(ByVal value As String)
            record_collection_file_name = value
        End Set
    End Property

End Class

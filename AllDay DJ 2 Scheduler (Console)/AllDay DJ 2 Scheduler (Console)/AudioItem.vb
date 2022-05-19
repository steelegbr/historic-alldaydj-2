Imports Bass = Un4seen.Bass.Bass    ' Bass sound system reference

Public Class AudioItem

    ' Fields

    Private track_id As String
    Private db_table As String = ""
    Private artist As String = ""
    Private track_name As String = ""
    Private album As String = ""
    Private tunecode As String = ""
    Private composer As String = ""
    Private writer As String = ""
    Private info As String = ""
    Private file_name As String = ""
    Private playout_channel As Integer = 0
    Private time_start_track As Double = 0
    Private time_start_intro As Double = 0
    Private time_end_intro As Double = 0
    Private time_extro_start As Double = 0
    Private time_end_track As Double = 0
    Private end_type As Integer = 0
    Private allow_play_over As Boolean = False
    Private player_tag As Integer = -1
    Private hardware As Boolean = False

    ' Constructors

    Public Sub New(ByVal track_id As String, ByVal db_table As String, ByVal load_channel As Boolean)

        Dim split_temp() As String

        On Error Resume Next

        ' Load values into object

        Me.track_id = track_id
        Me.db_table = db_table

        ' Hardware events

        If (Me.db_table.Equals("HARDWARE")) Then
            split_temp = Me.track_id.Split(":")
            Me.db_table = "HARDWARE"
            Me.time_end_track = split_temp(2)
            Me.artist = "HARDWARE EVENT"
            Me.track_name = "SOUND CARD"
            Exit Sub
        End If

        ' Access the database

        Dim db As New Database(ProgramSettings.record_collection_location)
        Dim rs As System.Data.OleDb.OleDbDataReader
        Dim query As String

        query = "SELECT * FROM [" & Me.db_table & "] WHERE [trackid] = " & Me.track_id
        rs = db.executeRS(query)

        ' Now load the db values into this object

        If Not rs Is Nothing Then
            While rs.Read
                Me.artist = rs.GetString(1)
                Me.track_name = rs.GetString(2)
                Me.album = rs.GetString(3)
                Me.tunecode = rs.GetString(4)
                Me.composer = rs.GetString(5)
                Me.writer = rs.GetString(6)
                Me.info = rs.GetString(7)
                Me.file_name = rs.GetString(8)
                Me.time_start_track = rs.GetDecimal(9)
                Me.time_start_intro = rs.GetDecimal(10)
                Me.time_end_intro = rs.GetDecimal(11)
                Me.time_extro_start = rs.GetDecimal(12)
                Me.time_end_track = rs.GetDecimal(13)
                Me.end_type = rs.GetInt32(14)
                Me.allow_play_over = rs.GetString(15)
            End While
        End If

        ' Now close and destroy the connection

        rs.Close()
        db.disconnect()
        rs = Nothing
        db = Nothing

    End Sub

    Public Sub New(ByVal sound_card As Integer, ByVal input As Integer, ByVal length As Double)

        Me.db_table = "HARDWARE"
        Me.track_id = sound_card & ":" & input & ":" & length
        Me.time_end_track = length
        Me.artist = "HARDWARE EVENT"
        Me.track_name = "SOUND CARD"

    End Sub

    ' Getters for all of the info

    Public Function getTrackId() As String
        Return Me.track_id
    End Function

    Public Function getDbTable() As String
        Return Me.db_table
    End Function

    Public Function getArtist() As String
        Return Me.artist
    End Function

    Public Function getAlbum() As String
        Return Me.album
    End Function

    Public Function getTunecode() As String
        Return Me.tunecode
    End Function

    Public Function getComposer() As String
        Return Me.composer
    End Function

    Public Function getWriter() As String
        Return Me.writer
    End Function

    Public Function getFileName() As String
        Return Me.file_name
    End Function

    Public Function getPlayoutChannel() As Long
        Return Me.playout_channel
    End Function

    Public Function getTimeStartTrack() As Double
        Return Me.time_start_track
    End Function

    Public Function getTimeStartIntro() As Double
        Return Me.time_start_intro
    End Function

    Public Function getTimeEndIntro() As Double
        Return Me.time_end_intro
    End Function

    Public Function getTimeExtroStart() As Double
        Return Me.time_extro_start
    End Function

    Public Function getTimeEndTrack() As Double
        Return Me.time_end_track
    End Function

    Public Function getEndType() As Integer
        Return Me.end_type
    End Function

    Public Function getInfo() As String
        Return Me.info
    End Function

    Public Function getTrackName() As String
        Return Me.track_name
    End Function

    Public Function getPlayOver() As Boolean
        Return Me.allow_play_over
    End Function

End Class

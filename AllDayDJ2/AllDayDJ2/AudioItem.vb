Imports Bass = Un4seen.Bass.Bass    ' Bass sound system reference

Public Class AudioItem

    ' For hardware item

    Private SP As New Un4seen.Bass.STREAMPROC(AddressOf RecLoop.stream)

    ' Fields

    Private track_id As String = ""
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
    Private played As Boolean = False
    Private is_automated_track As Boolean = False

    ' Constructors
    ' Hardware

    Public Sub New(ByVal sound_card As Integer, ByVal input As Integer, ByVal length As Double, Optional ByVal ducker As Boolean = False)

        ' Set the hardware

        If (Not Bass.BASS_RecordSetDevice(General.program_settings.getSoundCard)) Then
            'MsgBox("Bass error " & Bass.BASS_ErrorGetCode & ".", MsgBoxStyle.Exclamation, "Error")
        End If

        ' Create the recording channel

        If (Not Bass.BASS_RecordSetInput(General.program_settings.getSoundInput, Un4seen.Bass.BASSInput.BASS_INPUT_ON)) Then
            'MsgBox("Bass error " & Bass.BASS_ErrorGetCode & ".", MsgBoxStyle.Exclamation, "Error")
        End If

        If (Not Bass.BASS_RecordSetInputVolume(General.program_settings.getSoundInput, 100)) Then
            'MsgBox("Bass error " & Bass.BASS_ErrorGetCode & ".", MsgBoxStyle.Exclamation, "Error")
        End If

        Me.playout_channel = Bass.BASS_RecordStart(44100, 2, Un4seen.Bass.BASSRecord.BASS_DEFAULT, Nothing, 0)
        RecLoop.setPlayout(Me.playout_channel)
        Me.playout_channel = 0

        ' Remember we are a hardware item

        Me.setAttributes("Hardware Event", "Soundcard Input", "Nothing", "000000", "N/A", "N/A", "N/A", 2, ducker, 0, 0, 0, length, length)
        Me.hardware = True

    End Sub

    ' Audio file

    Public Sub New(ByVal file_name As String)

        Dim channel As Long

        ' Use the sound system to get the data

        Bass.BASS_SetDevice(General.program_settings.getPFLSoundCard)
        channel = Bass.BASS_StreamCreateFile(file_name, 0, 0, 0)
        Me.time_extro_start = Bass.BASS_ChannelBytes2Seconds(channel, Bass.BASS_ChannelGetLength(channel))
        Me.time_end_track = Me.time_extro_start
        'Bass.BASS_StreamFree(channel)

        ' All other data 

        Me.file_name = file_name

    End Sub

    ' Retrieve info from database

    Public Sub New(ByVal track_id As String, ByVal db_table As String, ByVal load_channel As Boolean)

        On Error Resume Next

        ' Load values into object

        Me.track_id = track_id
        Me.db_table = db_table

        ' Access the database

        Dim db As New Database(General.program_settings.getDbLocation)
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

    ' Generates a new item with all parameters supplied

    Public Sub New(ByVal track_id As Integer, ByVal playlist As String, ByVal artist As String, ByVal track_name As String, ByVal album As String, ByVal tunecode As String, ByVal composer As String, ByVal writer As String, ByVal info As String, ByVal file_name As String, ByVal time_start_track As Decimal, ByVal time_start_intro As Decimal, ByVal time_end_intro As Decimal, ByVal time_extro_start As Decimal, ByVal time_end_track As Decimal, ByVal end_type As Integer, ByVal allow_play_over As Boolean)

        Me.track_id = track_id
        Me.artist = artist
        Me.track_name = track_name
        Me.album = album
        Me.tunecode = tunecode
        Me.composer = composer
        Me.writer = writer
        Me.info = info
        Me.file_name = file_name
        Me.time_start_track = time_start_intro
        Me.time_start_intro = time_start_intro
        Me.time_end_intro = time_end_intro
        Me.time_extro_start = time_extro_start
        Me.time_end_track = time_end_track
        Me.end_type = end_type
        Me.allow_play_over = allow_play_over
        Me.db_table = playlist

    End Sub

    ' Getters for all of the info

    Public Function getTrackId() As Integer
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

    Public Function getHardware() As Boolean
        Return Me.hardware
    End Function

    Public Function getPlayed() As Boolean
        Return Me.played
    End Function

    ' Setters

    Private Sub setPlayoutChannel(ByVal channel As Long)
        Me.playout_channel = channel
    End Sub

    Public Sub setTimeEndTrack(ByVal time As Double)
        Me.time_end_track = time
    End Sub

    ' This subroutine allows the loading of a track

    Public Function loadTrack(ByVal sound_card As Integer, ByVal pan As Integer, ByVal volume As Integer, Optional ByVal auto_unload As Boolean = True) As Boolean

        Dim channel As Long
        Dim lc_file_name As String

        ' Set the sound card

        If (Not Bass.BASS_SetDevice(sound_card)) Then
            'MsgBox("Bass error " & Bass.BASS_ErrorGetCode & ".", MsgBoxStyle.Exclamation, "Error")
        End If

        ' Check for already loaded

        If (Me.playout_channel <> 0) Then
            If (Me.hardware) Then
                Return True
                Exit Function
            Else
                Bass.BASS_StreamFree(Me.playout_channel)
            End If
        End If

        ' Load the actual track
        ' Different loading method for WMA

        lc_file_name = Me.file_name.ToLower()

        If (pan = 0) Then
            If (Me.hardware) Then
                Me.playout_channel = Bass.BASS_StreamCreate(44100, 2, Un4seen.Bass.BASSStream.BASS_DEFAULT, SP, 0)
            Else
                If (auto_unload) Then
                    If (lc_file_name.EndsWith("wma")) Then
                        channel = Un4seen.Bass.AddOn.Wma.BassWma.BASS_WMA_StreamCreateFile(file_name, 0, 0, 262144)
                    Else
                        channel = Bass.BASS_StreamCreateFile(file_name, 0, 0, 262144)
                    End If
                Else
                    If (lc_file_name.EndsWith("wma")) Then
                        channel = Un4seen.Bass.AddOn.Wma.BassWma.BASS_WMA_StreamCreateFile(file_name, 0, 0, 0)
                    Else
                        channel = Bass.BASS_StreamCreateFile(file_name, 0, 0, 0)
                    End If
                End If
            End If
        Else
            If (Me.hardware) Then
                Me.playout_channel = Bass.BASS_StreamCreate(44100, 1, Un4seen.Bass.BASSStream.BASS_DEFAULT, SP, 0)
            Else
                If (auto_unload) Then
                    If (lc_file_name.EndsWith("wma")) Then
                        channel = Un4seen.Bass.AddOn.Wma.BassWma.BASS_WMA_StreamCreateFile(file_name, 0, 0, 262144 Or Un4seen.Bass.BASSStream.BASS_SAMPLE_MONO)
                    Else
                        channel = Bass.BASS_StreamCreateFile(file_name, 0, 0, 262144)
                    End If
                Else
                    If (lc_file_name.EndsWith("wma")) Then
                        channel = Un4seen.Bass.AddOn.Wma.BassWma.BASS_WMA_StreamCreateFile(file_name, 0, 0, Un4seen.Bass.BASSStream.BASS_SAMPLE_MONO)
                    Else
                        channel = Bass.BASS_StreamCreateFile(file_name, 0, 0, 0)
                    End If
                End If
            End If
        End If

        ' Error checking

        If (channel = 0) Then
            'MsgBox("Error loading audio item." & Chr(13) & Chr(10) & "Bass error " & Bass.BASS_ErrorGetCode & ".", MsgBoxStyle.Exclamation, "Error")
            Return False
            Exit Function
        End If

        ' Set pan and volume

        If (Bass.BASS_ChannelSetAttributes(channel, -1, volume, pan) = False) Then
            Return False
            Exit Function
        End If

        ' Set the sound card

        If (channel = 0) Then
            Return False
            Exit Function
        End If

        Me.playout_channel = channel

        Return True

    End Function

    ' This subroutine unloads a track

    Public Sub unloadTrack()
        Bass.BASS_StreamFree(Me.playout_channel)
    End Sub

    ' This subroutine saves any changes to an item

    Public Sub save()

        Dim db As Database

        ' Make the database connection

        db = New Database(General.program_settings.getDbLocation)

        ' Make the change

        If (Not db.execute("UPDATE [" & Me.getDbTable & "] SET artist = """ & Me.getArtist & """,  track_name = """ & Me.getTrackName & """, album = """ & Me.getAlbum & """, tunecode = """ & Me.getTunecode & """, composer = """ & Me.getComposer & """, writer = """ & Me.getWriter & """, info = """ & Me.getInfo & """, file_name = """ & Me.getFileName & """, time_start_track = """ & Me.getTimeStartTrack & """, time_start_intro = """ & Me.getTimeStartIntro & """, time_end_intro = """ & Me.getTimeEndIntro & """, time_extro_start = """ & Me.getTimeExtroStart & """, time_end_track = """ & Me.getTimeEndTrack & """, end_type = " & Me.getEndType & ", allow_play_over = """ & Me.getPlayOver & """ WHERE trackid = " & Me.getTrackId)) Then
            MsgBox("Could not save changes to the item.", MsgBoxStyle.Exclamation, "Error")
        End If

        ' Close the connection

        db.disconnect()
        db = Nothing

    End Sub

    ' Save a NEW item to the database

    Public Sub saveNew()

        Dim db As Database
        Dim rs As OleDb.OleDbDataReader

        ' Make the database connection

        db = New Database(General.program_settings.getDbLocation)

        ' Make the change

        Dim query As String = "INSERT INTO [" & Me.getDbTable & "] (artist, track_name, album, tunecode, composer, writer, info, file_name, time_start_track, time_start_intro, time_end_intro, time_extro_start, time_end_track, end_type, allow_play_over) VALUES (""" & Me.getArtist & """, """ & Me.getTrackName & """, """ & Me.getAlbum & """, """ & Me.getTunecode & """, """ & Me.getComposer & """, """ & Me.getWriter & """, """ & Me.getInfo & """, """ & Me.getFileName & """, """ & Me.getTimeStartTrack.ToString & """, """ & Me.getTimeStartIntro & """, """ & Me.getTimeEndIntro & """, """ & Me.getTimeExtroStart & """, """ & Me.getTimeEndTrack & """, " & Me.getEndType & ", " & Me.getPlayOver & ")"
        'MsgBox(query)
        If (Not db.execute(query)) Then
            MsgBox("Could not save changes to the item.", MsgBoxStyle.Exclamation, "Error")
        End If

        ' Now get the new id number

        rs = db.executeRS("SELECT trackid FROM [" & Me.db_table & "] WHERE file_name = """ & Me.file_name & """")

        While rs.Read
            Me.track_id = rs.GetInt32(0)
        End While

        rs.Close()
        db.disconnect()
        rs = Nothing
        db = Nothing

    End Sub

    ' Set the attributes of the item

    Public Sub setAttributes(ByRef artist As String, ByRef track_name As String, ByRef album As String, ByRef tunecode As String, ByRef composer As String, ByRef writer As String, ByRef info As String, ByRef end_type As Integer, ByRef allow_play_over As Boolean, Optional ByRef time_start_track As Decimal = -1, Optional ByRef time_start_intro As Decimal = -1, Optional ByRef time_end_intro As Decimal = -1, Optional ByRef time_extro_start As Decimal = -1, Optional ByRef time_end_track As Decimal = -1)

        ' The data we will always get

        Me.artist = artist
        Me.track_name = track_name
        Me.album = album
        Me.tunecode = tunecode
        Me.composer = composer
        Me.writer = writer
        Me.info = info
        Me.end_type = end_type
        Me.allow_play_over = allow_play_over

        ' We either get all times or nada

        If (time_start_track.Equals(-1)) Then
            Exit Sub
        End If

        ' Load the times

        Me.time_start_track = time_start_track
        Me.time_start_intro = time_start_intro
        Me.time_end_intro = time_end_intro
        Me.time_extro_start = time_extro_start
        Me.time_end_track = time_end_track

    End Sub

    ' Set the db table

    Public Sub setDBTable(ByRef table As String)
        Me.db_table = table
    End Sub

    ' Get and set the player tag

    Public Function getPlayerTag() As Integer
        Return Me.player_tag
    End Function

    Public Sub setPlayerTag(ByVal tag As Integer)
        Me.player_tag = tag
    End Sub

    ' Add to the output log

    Public Sub addToLog(ByVal start_time As Date)

        Dim db_log As New Database(General.program_settings.getLogsLocation)

        ' Do not log hardware items

        If (Me.hardware) Then
            Exit Sub
        End If

        ' Do not log items not played

        If (Not Me.played) Then
            Exit Sub
        End If

        ' Do not log if in training mode

        If (Not frmMain.getMode) Then
            Exit Sub
        End If

        ' Write the item to the log table

        db_log.execute("INSERT INTO [log] VALUES (" & Me.track_id & ",""" & Me.artist & """, """ & Me.track_name & """, """ & Me.album & """, """ & Me.tunecode & """, """ & Me.composer & """, """ & Me.writer & """, """ & General.timeToString(Me.time_end_track - Me.time_start_track) & """, """ & start_time & """, """ & General.timeToString(DateDiff(DateInterval.Second, Now, start_time)) & """, """ & Me.db_table & """)")
        db_log.disconnect()
        db_log = Nothing

        ' Update display

        frmMain.doPrevious(Me.artist, Me.track_name)

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        'Bass.BASS_StreamFree(Me.playout_channel)
    End Sub

    Public Sub setPlayed(ByRef played As Boolean)
        Me.played = played
    End Sub

    ' Get and set automated flag

    Public Sub setAutomatedTrack(ByRef is_automated_track As Boolean)
        Me.is_automated_track = is_automated_track
    End Sub

    Public Function getAutomatedTrack() As Boolean
        Return Me.is_automated_track
    End Function

    ' Deletes the item from the database

    Public Sub deleteFromDatabase()

        Try

            Dim db As New Database(program_settings.getDbLocation)
            db.execute("DELETE FROM [" & Me.getDbTable & "] WHERE [trackid] = " & Me.getTrackId)
            db.disconnect()
            db = Nothing

        Catch ex As Exception

            ' Silent failure

        End Try

    End Sub

End Class

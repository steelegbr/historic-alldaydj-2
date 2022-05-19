Imports System.IO                   ' File handling
Imports FX = Un4seen.Bass.AddOn.Fx  ' BASS FX Formats

Public Class Settings

    Private db_location As String
    Private logs_location As String
    Private main_players(0 To 3, 0 To 1) As Integer
    Private pfl_player(0 To 1) As Integer
    Private instant_players(0 To 1) As Integer
    Private agc As FX.BASS_FX_DSPDAMP
    Private compressor As FX.BASS_FX_DSPCOMPRESSOR
    Private apply_agc As Boolean
    Private apply_compressor As Boolean
    Private rotation As New List(Of String)
    Private fit_in_hour As Boolean
    Private schedule_location As String
    Private ducker As Boolean
    Private ducker_trigger_level As Integer
    Private ducker_fade_level As Integer
    Private ducker_attack As Integer
    Private ducker_release As Integer
    Private sound_card As Integer
    Private sound_input As Integer
    Private schedule_m3u As Boolean
    Private m3u_folder As String
    Private m3u_file_name As String

    ' Setter

    Public Sub setSettings(ByVal db_location As String, ByVal logs_location As String, ByRef main_players(,) As Integer, ByRef pfl_player() As Integer, ByRef instant_players() As Integer, ByVal ducker_fade_level As Integer, ByRef agc As FX.BASS_FX_DSPDAMP, ByVal apply_agc As Boolean, ByRef compressor As FX.BASS_FX_DSPCOMPRESSOR, ByVal apply_compressor As Boolean, ByVal fit_in_hour As Boolean, ByVal schedule_location As String, ByVal ducker As Boolean, ByVal ducker_trigger_level As Integer, ByVal ducker_attack As Integer, ByVal ducker_release As Integer, ByVal sound_card As Integer, ByVal sound_input As Integer, ByVal schedule_m3u As Boolean, ByVal m3u_folder As String, ByVal m3u_file_name As String)
        Me.db_location = db_location
        Me.logs_location = logs_location
        Me.main_players = main_players
        Me.pfl_player = pfl_player
        Me.ducker_fade_level = ducker_fade_level
        Me.instant_players = instant_players
        Me.agc = agc
        Me.apply_agc = apply_agc
        Me.compressor = compressor
        Me.apply_compressor = apply_compressor
        Me.fit_in_hour = fit_in_hour
        Me.schedule_location = schedule_location
        Me.ducker = ducker
        Me.ducker_trigger_level = ducker_trigger_level
        Me.ducker_attack = ducker_attack
        Me.ducker_release = ducker_release
        Me.sound_card = sound_card
        Me.sound_input = sound_input
        Me.schedule_m3u = schedule_m3u
        Me.m3u_folder = m3u_folder
        Me.m3u_file_name = m3u_file_name
    End Sub

    ' Allow the saving of settings into a file

    Public Sub saveSettings(ByVal file As String)

        Dim fs As IO.FileStream
        Dim sw As IO.StreamWriter
        Dim counter As Integer

        Try

            ' Open the file

            fs = New IO.FileStream(file, FileMode.OpenOrCreate)
            sw = New IO.StreamWriter(fs)
            sw.BaseStream.Seek(0, SeekOrigin.Begin)

            ' Begin writing

            sw.WriteLine(Me.db_location)
            sw.WriteLine(Me.logs_location)
            For counter = 0 To 3
                sw.WriteLine(main_players(counter, 0))
                sw.WriteLine(main_players(counter, 1))
            Next counter
            sw.WriteLine(pfl_player(0))
            sw.WriteLine(pfl_player(1))
            sw.WriteLine(instant_players(0))
            sw.WriteLine(instant_players(1))
            sw.WriteLine(agc.fGain)
            sw.WriteLine(agc.fDelay)
            sw.WriteLine(agc.fQuiet)
            sw.WriteLine(agc.fRate)
            sw.WriteLine(agc.fTarget)
            sw.WriteLine(apply_agc)
            sw.WriteLine(compressor.fAttacktime)
            sw.WriteLine(compressor.fReleasetime)
            sw.WriteLine(compressor.fThreshold)
            sw.WriteLine(apply_compressor)
            sw.WriteLine(fit_in_hour)
            sw.WriteLine(schedule_location)
            sw.WriteLine(ducker)
            sw.WriteLine(ducker_trigger_level)
            sw.WriteLine(ducker_fade_level)
            sw.WriteLine(ducker_attack)
            sw.WriteLine(ducker_release)
            sw.WriteLine(sound_card)
            sw.WriteLine(sound_input)
            sw.WriteLine(schedule_m3u)
            sw.WriteLine(m3u_folder)
            sw.WriteLine(m3u_file_name)

            ' Close the file

            sw.Close()
            fs.Close()

        Catch ex As Exception

            ' Produce an error and quit

            MsgBox("Could not save settings. Will now exit.", MsgBoxStyle.Critical, "Error")
            End

        End Try

    End Sub

    ' Getters

    Public Function getDbLocation() As String
        Return Me.db_location
    End Function

    Public Function getLogsLocation() As String
        Return Me.logs_location
    End Function

    Public Function getMainPlayerSoundCard(ByVal player As Integer) As Integer
        Return Me.main_players(player, 0)
    End Function

    Public Function getMainPlayerPan(ByVal player As Integer) As Integer
        Return Me.main_players(player, 1)
    End Function

    Public Function getPFLSoundCard() As Integer
        Return Me.pfl_player(0)
    End Function

    Public Function getPFLPan() As Integer
        Return Me.pfl_player(1)
    End Function

    Public Function getIPSoundCard() As Integer
        Return Me.instant_players(0)
    End Function

    Public Function getIPPan() As Integer
        Return Me.instant_players(1)
    End Function

    Public Function getAGC() As FX.BASS_FX_DSPDAMP
        Return Me.agc
    End Function

    Public Function getApplyAGC() As Boolean
        Return Me.apply_agc
    End Function

    Public Function getCompressor() As FX.BASS_FX_DSPCOMPRESSOR
        Return Me.compressor
    End Function

    Public Function getApplyCompressor() As Boolean
        Return Me.apply_compressor
    End Function

    Public Function getFitInHour() As Boolean
        Return Me.fit_in_hour
    End Function

    Public Function getScheduleLocation() As String
        Return Me.schedule_location
    End Function

    Public Function getDucker() As Boolean
        Return Me.ducker
    End Function

    Public Function getDuckerTriggerLevel() As Integer
        Return Me.ducker_trigger_level
    End Function

    Public Function getDuckerAttack() As Integer
        Return Me.ducker_attack
    End Function

    Public Function getDuckerRelease() As Integer
        Return Me.ducker_release
    End Function

    Public Function getDuckerFadeLevel() As Integer
        Return Me.ducker_fade_level
    End Function

    Public Function getSoundCard() As Integer
        Return sound_card
    End Function

    Public Function getSoundInput() As Integer
        Return sound_input
    End Function

    Public Function getScheduleM3U() As Boolean
        Return Me.schedule_m3u
    End Function

    Public Function getM3UFolder() As String
        Return Me.m3u_folder
    End Function

    Public Function getM3UFileName() As String
        Return Me.m3u_file_name
    End Function

    ' Get and set the rotation

    Public Function getRotation() As List(Of String)
        Return Me.rotation
    End Function

    Public Sub setRotation(ByVal rotation As List(Of String))
        Me.rotation = rotation
    End Sub

End Class

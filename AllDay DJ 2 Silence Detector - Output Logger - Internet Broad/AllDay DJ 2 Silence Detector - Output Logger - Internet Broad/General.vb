Imports System.IO
Imports Bass = Un4seen.Bass.Bass

Module General

    ' Checks if a file exists

    Public Function fileExists(ByVal file_name As String) As Boolean

        If File.Exists(file_name) Then
            Return True
        Else
            Return False
        End If

    End Function

    ' Closes a screen properly

    Public Sub closeScreen(ByVal screen As Form)

        screen.Close()
        screen.Dispose()

    End Sub

    ' Starts the encoder

    Public Function startEncoder() As Integer

        Dim channel As Integer

        ' Set the recording device

        Bass.BASS_RecordSetDevice(Settings.SoundCard)
        Bass.BASS_RecordSetInput(Settings.SoundInput, Un4seen.Bass.BASSInput.BASS_INPUT_ON)

        ' Start the channel

        channel = Bass.BASS_RecordStart(EncoderSettings.SampleRate, EncoderSettings.EncoderChannels, Un4seen.Bass.BASSRecord.BASS_DEFAULT, Nothing, 0)
        MsgBox(Bass.BASS_ErrorGetCode)
        Bass.BASS_ChannelPlay(channel, False)
        MsgBox(Bass.BASS_ErrorGetCode)

        If (channel = 0) Then
            MsgBox("Could not start recording. Please check the settings and try again.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Error")
        End If

        Return channel

    End Function

    ' Create the encoders

    Public Function createLameEncoder(ByVal channel As Integer) As Un4seen.Bass.Misc.EncoderLAME

        Dim lame As Un4seen.Bass.Misc.EncoderLAME

        ' Set the parameters

        lame = New Un4seen.Bass.Misc.EncoderLAME(channel)
        lame.LAME_Bitrate = EncoderSettings.QualityBitrate
        'lame.LAME_Bitrate = Un4seen.Bass.Misc.EncoderLAME.BITRATE.kbps_320
        lame.LAME_TargetSampleRate = EncoderSettings.SampleRate
        lame.LAME_Quality = Un4seen.Bass.Misc.EncoderLAME.LAMEQuality.Quality

        ' Channels

        If (EncoderSettings.EncoderChannels = 1) Then
            lame.LAME_Mode = Un4seen.Bass.Misc.EncoderLAME.LAMEMode.Mono
        Else
            lame.LAME_Mode = Un4seen.Bass.Misc.EncoderLAME.LAMEMode.Stereo
        End If

        ' Directory

        lame.EncoderDirectory = EncoderSettings.LAMELocation.Substring(0, EncoderSettings.LAMELocation.LastIndexOf("\") + 1)

        ' Return

        Return lame

    End Function

    Public Function createOggEncoder(ByVal channel As Integer) As Un4seen.Bass.Misc.EncoderOGG

        Dim ogg As Un4seen.Bass.Misc.EncoderOGG

        ' Set the parameters

        ogg = New Un4seen.Bass.Misc.EncoderOGG(channel)
        ogg.OGG_Quality = EncoderSettings.QualityBitrate
        ogg.OGG_TargetSampleRate = EncoderSettings.SampleRate
        ogg.EncoderDirectory = EncoderSettings.OGGEncLocation.Substring(0, EncoderSettings.OGGEncLocation.LastIndexOf("\") + 1)

        ' Return

        Return ogg

    End Function

End Module

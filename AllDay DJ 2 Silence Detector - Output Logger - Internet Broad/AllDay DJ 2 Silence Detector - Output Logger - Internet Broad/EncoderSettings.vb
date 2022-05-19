Imports System.IO

Public Class EncoderSettings

    Private Shared lame_bitrates() As Integer = {320, 256, 128, 64}
    Private Shared ogg_qualities() As Integer = {-1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
    Private Shared sample_rates() As Integer = {44100, 22050}
    Private Shared sample_rate As Integer
    Private Shared format As Integer
    Private Shared channels As Integer
    Private Shared quality_bitrate As Integer
    Private Shared LAME_location As String
    Private Shared OGGEnc_location As String

    Public Shared ReadOnly Property LAMEBitrates(ByVal index As Integer) As Integer
        Get
            Return EncoderSettings.lame_bitrates(index)
        End Get
    End Property

    Public Shared ReadOnly Property OGGQualities(ByVal index As Integer) As Integer
        Get
            Return EncoderSettings.ogg_qualities(index)
        End Get
    End Property

    Public Shared ReadOnly Property SampleRates(ByVal index As Integer) As Integer
        Get
            Return EncoderSettings.sample_rates(index)
        End Get
    End Property

    Public Shared ReadOnly Property SampleRate() As Integer
        Get
            Return sample_rate
        End Get
    End Property

    Public Shared ReadOnly Property EncoderChannels() As Integer
        Get
            Return EncoderSettings.channels
        End Get
    End Property

    Public Shared ReadOnly Property QualityBitrate() As Integer
        Get
            Return EncoderSettings.quality_bitrate
        End Get
    End Property

    Public Shared ReadOnly Property LAMELocation() As String
        Get
            Return EncoderSettings.LAME_location
        End Get
    End Property

    Public Shared ReadOnly Property OGGEncLocation() As String
        Get
            Return EncoderSettings.OGGEnc_location
        End Get
    End Property

    Public Shared ReadOnly Property EncoderFormat() As Integer
        Get
            Return EncoderSettings.format
        End Get
    End Property

    ' Set the encoder settings

    Public Shared Sub setSettings(ByVal sample_rate As Integer, ByVal format As Integer, ByVal channels As Integer, ByVal quality_bitrate As Integer, ByVal LAME_location As String, ByVal OGGEnc_location As String)

        Dim counter As Integer
        Dim valid As Boolean = False

        ' Check the settings are valid

        If (sample_rate <> EncoderSettings.SampleRates(0) And sample_rate <> EncoderSettings.SampleRates(1)) Then
            Throw New Exception("Invalid sample rate detected. Please select a valid sample rate from the drop-down menu.")
        End If

        If (channels < 1 And channels > 2) Then
            Throw New Exception("Invalid number of channels selected. Please choose 1 (Mono) or 2 (Stereo).")
        End If

        If (format = Settings.SHOUTCAST) Then

            ' Check SHOUTCAST valid bitrates

            For counter = 0 To (EncoderSettings.lame_bitrates.Length - 1)
                If (EncoderSettings.LAMEBitrates(counter) = quality_bitrate) Then
                    valid = True
                End If
            Next

            ' Check

            If (Not valid) Then
                Throw New Exception("Invalid bitrate selected. Please select a valid bitrate from the drop-down menu.")
            End If

            ' LAME location

            If (Not fileExists(LAME_location)) Then
                Throw New Exception("Invalid LAME location selected. Please select a valid copy of LAME.")
            End If

        ElseIf (format = Settings.ICECAST) Then

            ' Check ICECAST valid bitrates

            For counter = 0 To (EncoderSettings.ogg_qualities.Length - 1)
                If (EncoderSettings.OGGQualities(counter) = quality_bitrate) Then
                    valid = True
                End If
            Next

            ' Check

            If (Not valid) Then
                Throw New Exception("Invalid quality selected. Please select a valid quality from the drop-down menu.")
            End If

            ' OGGEnc location

            If (Not fileExists(OGGEnc_location)) Then
                Throw New Exception("Invalid OGGEnc location selected. Please select a valid copy of OGGEnc.")
            End If

        Else

            Throw New Exception("Invalid streaming format selected. Please select either MP3 or OGG from the drop-down menu.")

        End If

        ' If we got this far we are valid. Update the settings

        EncoderSettings.sample_rate = sample_rate
        EncoderSettings.format = format
        EncoderSettings.channels = channels
        EncoderSettings.quality_bitrate = quality_bitrate
        EncoderSettings.LAME_location = LAME_location
        EncoderSettings.OGGEnc_location = OGGEnc_location

    End Sub

    ' Save the settings

    Public Shared Sub saveSettings()

        Dim file As File
        Dim writer As StreamWriter

        ' Open the file for writing

        writer = file.CreateText(Windows.Forms.Application.StartupPath & "\encoder.dat")

        ' Write the data

        writer.WriteLine(EncoderSettings.sample_rate)
        writer.WriteLine(EncoderSettings.format)
        writer.WriteLine(EncoderSettings.channels)
        writer.WriteLine(EncoderSettings.quality_bitrate)
        writer.WriteLine(EncoderSettings.LAME_location)
        writer.WriteLine(EncoderSettings.OGGEnc_location)

        ' Close the file

        writer.Close()

    End Sub

    ' Load the settings

    Public Shared Sub loadSettings()

        ' Check to see if the settings file exists

        If (fileExists(Windows.Forms.Application.StartupPath & "\encoder.dat")) Then

            ' Load the data

            Dim file As File
            Dim reader As StreamReader

            reader = file.OpenText(Windows.Forms.Application.StartupPath & "\encoder.dat")

            ' Read the data in

            EncoderSettings.sample_rate = reader.ReadLine()
            EncoderSettings.format = reader.ReadLine()
            EncoderSettings.channels = reader.ReadLine()
            EncoderSettings.quality_bitrate = reader.ReadLine()
            EncoderSettings.LAME_location = reader.ReadLine()
            EncoderSettings.OGGEnc_location = reader.ReadLine()

            ' Close the file

            reader.Close()

        Else

            ' Create a new file

            EncoderSettings.sample_rate = 44100
            EncoderSettings.format = Settings.SHOUTCAST
            EncoderSettings.channels = 2
            EncoderSettings.quality_bitrate = 256
            EncoderSettings.LAME_location = System.Windows.Forms.Application.StartupPath & "\encoders\lame_enc.exe"
            EncoderSettings.OGGEnc_location = System.Windows.Forms.Application.StartupPath & "\encoders\oggenc.exe"

            EncoderSettings.saveSettings()

        End If

    End Sub

End Class

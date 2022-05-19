Imports Bass = Un4seen.Bass.Bass
Imports Misc = Un4seen.Bass.Misc

Public Class frmMain

    Private silence_detector As Boolean = False
    Private output_logger As Boolean = False
    Private internet_broadcaster As Boolean = False
    Private channel As Integer = 0
    'Private lame_encoder As Misc.EncoderLAME = Nothing
    'Private ogg_encoder As Misc.EncoderOGG = Nothing
    Private server As Un4seen.Bass.Misc.StreamingServer

    ' Initial load

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim counter As Integer

        ' Init the audio system

        For counter = 0 To (Bass.BASS_GetDeviceCount)
            Bass.BASS_Init(counter, 44100, 0, 0, 0)
            Bass.BASS_RecordInit(counter)
        Next

        ' Load all settings

        EncoderSettings.loadSettings()
        IcecastSettings.loadSettings()
        LoggerSettings.loadSettings()
        Settings.loadSettings()
        ShoutcastSettings.loadSettings()
        SilenceSettings.loadSettings()

        ' Start the encoder

        Me.channel = startEncoder()
        Me.tmrVolume.Enabled = True

        'If (EncoderSettings.EncoderFormat = 0) Then

        ' LAME

        'Me.lame_encoder = createLameEncoder(Me.channel)
        'Me.lame_encoder.Start(Nothing, 0)

        'ElseIf (EncoderSettings.EncoderFormat = 1) Then

        ' Ogg

        'Me.ogg_encoder = createOggEncoder(Me.channel)
        'Me.ogg_encoder.Start(Nothing, 0)

        'Else

        'MsgBox("Invalid encoder format detected. Please check the format and re-launch this program.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Error")

        'End If

    End Sub

    ' Menu options

    Private Sub EncoderToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EncoderToolStripMenuItem.Click

        frmSettingsEncoder.Show()

    End Sub

    Private Sub GeneralToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GeneralToolStripMenuItem.Click

        frmSettings.Show()

    End Sub

    Private Sub IcecastToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles IcecastToolStripMenuItem.Click

        frmSettingsIcecast.Show()

    End Sub

    Private Sub LoggerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoggerToolStripMenuItem.Click

        frmSettingsLogger.Show()

    End Sub

    Private Sub ShoutcastToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShoutcastToolStripMenuItem.Click

        frmSettingsShoutcast.Show()

    End Sub

    Private Sub SilenceDetectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SilenceDetectorToolStripMenuItem.Click

        frmSettingsSilence.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        End

    End Sub

    ' Internet broadcaster

    Private Sub btnInternetBroadcast_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInternetBroadcast.Click

        Try

            ' Start or stop

            If (Me.internet_broadcaster) Then

                ' Stop

                Me.server.Disconnect()
                Me.server.Dispose()
                Me.server = Nothing
                Me.btnInternetBroadcast.BackColor = Color.Red
                Me.internet_broadcaster = False
                Me.btnInternetBroadcast.Text = "Internet Broadcaster (ON)"

            Else

                ' Start

                Dim server As Un4seen.Bass.Misc.StreamingServer

                ' Server type

                If (Settings.InternetOutput = Settings.SHOUTCAST) Then

                    ' Shoutcast

                    Dim sc_server As Misc.SHOUTcast
                    Dim encoder As Misc.EncoderLAME

                    encoder = createLameEncoder(Me.channel)

                    sc_server = New Misc.SHOUTcast(encoder, True)
                    sc_server.ServerAddress = ShoutcastSettings.ServerAddress
                    sc_server.ServerPort = ShoutcastSettings.ServerPort
                    sc_server.Password = ShoutcastSettings.Password
                    sc_server.StationName = ShoutcastSettings.StationName
                    sc_server.Genre = ShoutcastSettings.Genre
                    sc_server.Aim = ShoutcastSettings.AIM
                    sc_server.Icq = ShoutcastSettings.ICQ
                    sc_server.Irc = ShoutcastSettings.IRC
                    sc_server.Url = ShoutcastSettings.URL
                    sc_server.PublicFlag = ShoutcastSettings.AppearInDirectory

                    ' Assign and connect

                    server = sc_server
                    server.Connect()

                Else

                    ' Icecast

                    Dim ic_server As Misc.ICEcast

                    ' Use correct encoder

                    If (EncoderSettings.EncoderFormat = 0) Then
                        ic_server = New Misc.ICEcast(createLameEncoder(Me.channel))
                    Else
                        ic_server = New Misc.ICEcast(createOggEncoder(Me.channel))
                    End If

                    ' Other settings

                    ic_server.ServerAddress = IcecastSettings.ServerAddress
                    ic_server.MountPoint = IcecastSettings.MountPoint
                    ic_server.ServerPort = IcecastSettings.PortNumber
                    ic_server.Password = IcecastSettings.Password
                    ic_server.StreamName = IcecastSettings.StationName
                    ic_server.StreamGenre = IcecastSettings.Genre
                    ic_server.StreamDescription = IcecastSettings.Description
                    ic_server.StreamUrl = IcecastSettings.URL
                    ic_server.PublicFlag = IcecastSettings.AppearInDirectory

                    ' Assign and connect

                    server = ic_server
                    server.Connect()

                End If

                ' Update display

                Me.server = server
                Me.btnInternetBroadcast.BackColor = Color.Green
                Me.internet_broadcaster = True
                Me.btnInternetBroadcast.Text = "Internet Broadcaster (ON)"

            End If

        Catch ex As Exception

            MsgBox("Could not start streaming for the following reason:" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Error")

        End Try

    End Sub

    ' Retrieve the volume

    Private Sub tmrVolume_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrVolume.Tick

        Try

            Dim vol_l As Integer
            Dim vol_r As Integer
            Dim vol_both As Integer

            ' Get

            vol_both = Bass.BASS_ChannelGetLevel(Me.channel)
            vol_r = Un4seen.Bass.Utils.HighWord(vol_both)
            vol_l = Un4seen.Bass.Utils.LowWord(vol_both)

            ' Display

            Me.pbLeft.Value = (vol_l * 100) / 32767
            Me.pbRight.Value = (vol_r * 100) / 32767

        Catch ex As Exception

            ' Silent death

        End Try

    End Sub

End Class

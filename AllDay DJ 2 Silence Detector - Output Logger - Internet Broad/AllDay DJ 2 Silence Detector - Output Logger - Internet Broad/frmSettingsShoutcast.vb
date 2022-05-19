Public Class frmSettingsShoutcast

    ' Initial load

    Private Sub frmSettingsShoutcast_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Get values from memory

        Me.tbServer.Text = ShoutcastSettings.ServerAddress
        Me.nudPort.Value = ShoutcastSettings.ServerPort
        Me.tbPassword.Text = ShoutcastSettings.Password
        Me.tbStationName.Text = ShoutcastSettings.StationName
        Me.tbGenre.Text = ShoutcastSettings.Genre
        Me.tbAIM.Text = ShoutcastSettings.AIM
        Me.tbICQ.Text = ShoutcastSettings.ICQ
        Me.tbIRC.Text = ShoutcastSettings.IRC
        Me.tbURL.Text = ShoutcastSettings.URL
        Me.cbDirectory.Checked = ShoutcastSettings.AppearInDirectory

    End Sub

    ' Save and close

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Try

            ' Save

            ShoutcastSettings.setSettings(Me.tbServer.Text, Me.nudPort.Value, Me.tbPassword.Text, Me.tbStationName.Text, Me.tbGenre.Text, Me.tbAIM.Text, Me.tbICQ.Text, Me.tbIRC.Text, Me.tbURL.Text, Me.cbDirectory.Checked)
            ShoutcastSettings.saveSettings()

            ' Close

            closeScreen(Me)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Error")

        End Try

    End Sub

    ' Close

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        closeScreen(Me)

    End Sub

End Class
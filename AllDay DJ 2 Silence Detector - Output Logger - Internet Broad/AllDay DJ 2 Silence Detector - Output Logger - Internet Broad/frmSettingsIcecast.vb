Public Class frmSettingsIcecast

    ' Initial load

    Private Sub frmSettingsIcecast_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Grab settings from memory

        Me.tbServer.Text = IcecastSettings.ServerAddress
        Me.tbMountPoint.Text = IcecastSettings.MountPoint
        Me.nudPort.Value = IcecastSettings.PortNumber
        Me.tbPassword.Text = IcecastSettings.Password
        Me.tbStationName.Text = IcecastSettings.StationName
        Me.tbGenre.Text = IcecastSettings.Genre
        Me.tbDescription.Text = IcecastSettings.Description
        Me.tbURL.Text = IcecastSettings.URL
        Me.cbDirectory.Checked = IcecastSettings.AppearInDirectory

    End Sub

    ' Attempt to save and close

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Try

            ' Save

            IcecastSettings.setSettings(Me.tbServer.Text, Me.tbMountPoint.Text, Me.nudPort.Value, Me.tbPassword.Text, Me.tbStationName.Text, Me.tbGenre.Text, Me.tbDescription.Text, Me.tbURL.Text, Me.cbDirectory.Checked)
            IcecastSettings.saveSettings()

            ' Close

            closeScreen(Me)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Error")

        End Try

    End Sub

    ' Just close

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        closeScreen(Me)

    End Sub

End Class
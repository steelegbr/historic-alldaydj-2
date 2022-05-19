Public Class frmSettingsSilence

    ' Initial settings

    Private Sub frmSettingsSilence_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Load from memory

        Me.nudSilenceLength.Value = SilenceSettings.SilenceLength
        Me.chkUseSMTP.Checked = SilenceSettings.SMTP
        Me.tbSMTPServer.Text = SilenceSettings.SMTPServer
        Me.tbSMTPUsername.Text = SilenceSettings.SMTPUsername
        Me.tbSMTPPassword.Text = SilenceSettings.SMTPPassword
        Me.tbSMTPFromAddress.Text = SilenceSettings.SMTPFromAddress
        Me.tbSMTPToAddress.Text = SilenceSettings.SMTPToAddress
        Me.chkAudio.Checked = SilenceSettings.M3U
        Me.tbPlaylist.Text = SilenceSettings.M3UPlaylist
        Me.chkExecute.Checked = SilenceSettings.Execute
        Me.tbCommand.Text = SilenceSettings.ExecuteCommand

    End Sub

    ' Move focus

    Private Sub tbPlaylist_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbPlaylist.GotFocus

        Me.btnPlaylistBrowse.Focus()

    End Sub

    ' Save and close

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try

            ' Save

            SilenceSettings.setSettings(Me.nudSilenceLength.Value, Me.chkUseSMTP.Checked, Me.tbSMTPServer.Text, Me.tbSMTPUsername.Text, Me.tbSMTPPassword.Text, Me.tbSMTPFromAddress.Text, Me.tbSMTPToAddress.Text, Me.chkAudio.Checked, Me.tbPlaylist.Text, Me.chkExecute.Checked, Me.tbCommand.Text)
            SilenceSettings.saveSettings()

            ' Close

            closeScreen(Me)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Error")

        End Try

    End Sub

    ' Command from browse

    Private Sub btnCommandBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCommandBrowse.Click

        Dim file_name As String

        ' Let the user select a file

        Me.ofdCommand.ShowDialog()
        file_name = Me.ofdCommand.FileName

        ' Check the file name

        If (file_name = Nothing Or file_name.Length = 0) Then
            Exit Sub
        End If

        If (Not fileExists(file_name)) Then
            MsgBox("The command you selected does not exist.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Error")
        End If

        ' Update

        Me.tbCommand.Text = file_name

    End Sub

    ' Playlist Browse

    Private Sub btnPlaylistBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlaylistBrowse.Click

        Dim file_name As String

        ' Let the user select a file

        Me.ofdM3U.ShowDialog()
        file_name = Me.ofdM3U.FileName

        ' Check the file name

        If (file_name = Nothing Or file_name.Length = 0) Then
            Exit Sub
        End If

        If (Not fileExists(file_name)) Then
            MsgBox("The playlist you selected does not exist.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Error")
        End If

        ' Update

        Me.tbPlaylist.Text = file_name

    End Sub

    ' Activate / Disactivate controls

    Private Sub chkAudio_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAudio.CheckedChanged

        Dim value As Boolean

        ' Get the state and make the changes

        value = Me.chkAudio.Checked
        Me.tbPlaylist.Enabled = value

    End Sub

    Private Sub chkExecute_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkExecute.CheckedChanged

        Dim value As Boolean

        ' Get the state and make the changes

        value = Me.chkExecute.Checked
        Me.tbCommand.Enabled = value

    End Sub

    Private Sub chkUseSMTP_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUseSMTP.CheckedChanged

        Dim value As Boolean

        ' Get the state and make the changes

        value = Me.chkUseSMTP.Checked
        Me.tbSMTPFromAddress.Enabled = value
        Me.tbSMTPPassword.Enabled = value
        Me.tbSMTPServer.Enabled = value
        Me.tbSMTPToAddress.Enabled = value
        Me.tbSMTPUsername.Enabled = value

    End Sub

End Class
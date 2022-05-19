Public Class frmSettingsLogger

    ' Initial load

    Private Sub frmSettingsLogger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Load from memory

        Me.nudLogLength.Value = LoggerSettings.KeepFilesFor
        Me.tbOutput.Text = LoggerSettings.OuputDirectory

    End Sub

    ' Move focus

    Private Sub tbOutput_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbOutput.GotFocus

        Me.btnOutputBrowse.Focus()

    End Sub

    ' Attempt to close and save

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try

            ' Save

            LoggerSettings.setSettings(Me.nudLogLength.Value, Me.tbOutput.Text)
            LoggerSettings.saveSettings()

            ' Close

            closeScreen(Me)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Error")

        End Try

    End Sub

    ' Select a folder

    Private Sub btnOutputBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOutputBrowse.Click

        Dim folder_name As String

        ' Select the folder

        Me.fbdLogger.ShowDialog()
        folder_name = Me.fbdLogger.SelectedPath

        ' Check

        If (folder_name = Nothing Or folder_name.Length = 0) Then
            Exit Sub
        End If

        ' Update and notify

        Me.tbOutput.Text = folder_name
        MsgBox("Please note that any MP3 or OGG files in the selected folder older " & Me.nudLogLength.Value & " days will be DELETED.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Notice")

    End Sub

End Class
Imports Bass = Un4seen.Bass.Bass

Public Class frmSettings

    ' Initial load

    Private Sub frmSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            Dim counter As Integer

            ' Load the soundcards

            Me.cmbSoundCard.Items.Clear()

            For counter = 1 To (Bass.BASS_GetDeviceCount - 1)
                Me.cmbSoundCard.Items.Add(Bass.BASS_GetDeviceDescription(counter))
            Next

            Me.cmbSoundCard_SelectedIndexChanged(Nothing, Nothing)

            ' Grab the settings from the settings object

            Me.cmbSoundCard.SelectedIndex = Settings.SoundCard - 1
            Me.cmbInput.SelectedIndex = Settings.SoundInput
            Me.tbNowNextFile.Text = Settings.NowAndNextFile
            Me.cmbInternetPreference.SelectedIndex = Settings.InternetOutput

        Catch ex As Exception

            ' Alert the user to a problem

            MsgBox(ex.Message, MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Error")

        End Try

    End Sub

    ' Close the screen

    Public Sub closeScreen()

        Me.Close()
        Me.Dispose()

    End Sub

    ' Save the settings

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Try

            ' Attempt to save the settings

            Settings.setSettings(Me.cmbSoundCard.SelectedIndex + 1, Me.cmbInput.SelectedIndex, Me.tbNowNextFile.Text, Me.cmbInternetPreference.SelectedIndex)
            Settings.saveSettings()

            ' Close the screen

            Me.closeScreen()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Error")

        End Try

    End Sub

    ' Close the screeen

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.closeScreen()

    End Sub

    ' Change in sound card

    Private Sub cmbSoundCard_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSoundCard.SelectedIndexChanged

        Dim recording_device As Integer
        Dim counter As Integer

        ' Make note and change device

        recording_device = Bass.BASS_RecordGetDevice
        Bass.BASS_RecordSetDevice(Me.cmbSoundCard.SelectedIndex + 1)

        ' List the inputs

        Me.cmbInput.Items.Clear()

        For counter = 0 To (Bass.BASS_RecordGetInputNames.Length - 1)
            Me.cmbInput.Items.Add(Bass.BASS_RecordGetInputName(counter))
        Next

        Me.cmbInput.SelectedIndex = 0

        ' Return to normal

        Bass.BASS_RecordSetDevice(recording_device)

    End Sub

    ' Now and next file

    Private Sub btnNowNextBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNowNextBrowse.Click

        Dim file_name As String

        ' Get the file

        Me.ofdNowAndNext.ShowDialog()
        file_name = Me.ofdNowAndNext.FileName

        ' Check

        If (file_name = Nothing Or file_name.Length = 0) Then
            Exit Sub
        End If

        If (Not fileExists(file_name)) Then
            MsgBox("The file you selected does not exist.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If

        ' Update

        Me.tbNowNextFile.Text = file_name

    End Sub

End Class
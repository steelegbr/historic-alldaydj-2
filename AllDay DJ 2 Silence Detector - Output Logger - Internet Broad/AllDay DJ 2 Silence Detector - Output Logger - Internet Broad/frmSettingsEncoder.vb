Imports Bass = Un4seen.Bass

Public Class frmSettingsEncoder

    ' Inital load

    Private Sub frmSettingsEncoder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim counter As Integer

        ' Sample rates

        Me.cmbSampleRate.Items.Clear()

        For counter = 0 To 1
            Me.cmbSampleRate.Items.Add(EncoderSettings.SampleRates(counter))
        Next

        ' Load the values from memory

        ' Sample rate

        For counter = 0 To 1
            If (EncoderSettings.SampleRate.Equals(EncoderSettings.SampleRates(counter))) Then
                Me.cmbSampleRate.SelectedIndex = counter
            End If
        Next

        ' Format

        Me.cmbFormat.SelectedIndex = EncoderSettings.EncoderFormat
        Me.cmbFormat_SelectedIndexChanged(Nothing, Nothing)

        ' Quality / Bitrate

        For counter = 0 To 3
            If (EncoderSettings.LAMEBitrates(counter).Equals(EncoderSettings.QualityBitrate)) Then
                Me.cmbQualityBitrate.SelectedIndex = counter
            End If
        Next

        For counter = 0 To 11
            If (EncoderSettings.OGGQualities(counter).Equals(EncoderSettings.QualityBitrate)) Then
                Me.cmbQualityBitrate.SelectedIndex = counter
            End If
        Next

        ' File locations

        Me.tbLAME.Text = EncoderSettings.LAMELocation
        Me.tbOGGEnc.Text = EncoderSettings.OGGEncLocation

        ' Channels

        Me.cmbChannels.SelectedIndex = EncoderSettings.EncoderChannels - 1

    End Sub

    ' Move focus by 1

    Private Sub moreFocusByOne(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbLAME.GotFocus, tbOGGEnc.GotFocus

        Dim tb As TextBox = sender

        ' Move to the appropriate control

        If (tb.Equals(Me.tbLAME)) Then
            Me.btnLAMEBrowse.Focus()
        ElseIf (tb.Equals(Me.tbOGGEnc)) Then
            Me.btnOGGEncBrowse.Focus()
        Else
            MsgBox("Huh, an error ocurred that was not supposed to ever happen. It's supposed to be impossible!")
        End If

    End Sub

    ' Closes the screen

    Private Sub closeScreen()

        Me.Close()
        Me.Dispose()

    End Sub

    ' Attempt to save the settings

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Try

            ' Save

            EncoderSettings.setSettings(Me.cmbSampleRate.Text, Me.cmbFormat.SelectedIndex, Me.cmbChannels.SelectedIndex + 1, Me.cmbQualityBitrate.Text, Me.tbLAME.Text, Me.tbOGGEnc.Text)
            EncoderSettings.saveSettings()

            ' Close the screen

            Me.closeScreen()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Error")

        End Try

    End Sub

    ' Change in format

    Private Sub cmbFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFormat.SelectedIndexChanged

        Dim counter As Integer

        ' Clear

        Me.cmbQualityBitrate.Items.Clear()

        ' Check the format

        If (Me.cmbFormat.SelectedIndex = Settings.SHOUTCAST) Then
            For counter = 0 To 3
                Me.cmbQualityBitrate.Items.Add(EncoderSettings.LAMEBitrates(counter))
            Next
        ElseIf (Me.cmbFormat.SelectedIndex = Settings.ICECAST) Then
            For counter = 0 To 11
                Me.cmbQualityBitrate.Items.Add(EncoderSettings.OGGQualities(counter))
            Next
        End If

        ' Select default

        Me.cmbQualityBitrate.SelectedIndex = 0

    End Sub

    ' LAME

    Private Sub btnLAMEBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLAMEBrowse.Click

        Dim file_name As String

        ' Open the file

        Me.ofdLAMEEnc.ShowDialog()
        file_name = Me.ofdLAMEEnc.FileName

        ' Check it

        If (Not file_name.EndsWith("lame.exe")) Then
            MsgBox("The file you selected is not the LAME encoder. Please select the LAME encoder.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If

        If (Not fileExists(file_name)) Then
            MsgBox("The files selected does not exist!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Error")
            Exit Sub
        End If

        ' Update it

        Me.tbLAME.Text = file_name

    End Sub

    ' OGGEnc

    Private Sub btnOGGEncBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOGGEncBrowse.Click

        Dim file_name As String

        ' Open the file

        Me.ofdOggEnc.ShowDialog()
        file_name = Me.ofdOggEnc.FileName

        ' Check it

        If (Not file_name.Contains("oggenc")) Then
            MsgBox("The file you selected is not the OGG encoder. Please select the OGG encoder.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If

        If (Not fileExists(file_name)) Then
            MsgBox("The files selected does not exist!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Error")
            Exit Sub
        End If

        ' Update it

        Me.tbOGGEnc.Text = file_name

    End Sub

    ' Close

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        closeScreen()

    End Sub

End Class
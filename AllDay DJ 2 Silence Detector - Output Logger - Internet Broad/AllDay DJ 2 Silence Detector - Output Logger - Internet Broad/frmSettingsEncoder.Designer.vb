<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsEncoder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSampleRate = New System.Windows.Forms.Label
        Me.cmbSampleRate = New System.Windows.Forms.ComboBox
        Me.cmbFormat = New System.Windows.Forms.ComboBox
        Me.lblFormat = New System.Windows.Forms.Label
        Me.cmbChannels = New System.Windows.Forms.ComboBox
        Me.lblChannels = New System.Windows.Forms.Label
        Me.cmbQualityBitrate = New System.Windows.Forms.ComboBox
        Me.lblQualityBitrate = New System.Windows.Forms.Label
        Me.lblEncoders = New System.Windows.Forms.Label
        Me.lblMP3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbLAME = New System.Windows.Forms.TextBox
        Me.btnLAMEBrowse = New System.Windows.Forms.Button
        Me.btnOGGEncBrowse = New System.Windows.Forms.Button
        Me.tbOGGEnc = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.ofdLAMEEnc = New System.Windows.Forms.OpenFileDialog
        Me.ofdOggEnc = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'lblSampleRate
        '
        Me.lblSampleRate.AutoSize = True
        Me.lblSampleRate.Location = New System.Drawing.Point(46, 22)
        Me.lblSampleRate.Name = "lblSampleRate"
        Me.lblSampleRate.Size = New System.Drawing.Size(71, 13)
        Me.lblSampleRate.TabIndex = 0
        Me.lblSampleRate.Text = "Sample Rate:"
        '
        'cmbSampleRate
        '
        Me.cmbSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSampleRate.FormattingEnabled = True
        Me.cmbSampleRate.Location = New System.Drawing.Point(123, 19)
        Me.cmbSampleRate.Name = "cmbSampleRate"
        Me.cmbSampleRate.Size = New System.Drawing.Size(106, 21)
        Me.cmbSampleRate.TabIndex = 1
        '
        'cmbFormat
        '
        Me.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormat.FormattingEnabled = True
        Me.cmbFormat.Items.AddRange(New Object() {"MP3", "OGG"})
        Me.cmbFormat.Location = New System.Drawing.Point(123, 46)
        Me.cmbFormat.Name = "cmbFormat"
        Me.cmbFormat.Size = New System.Drawing.Size(62, 21)
        Me.cmbFormat.TabIndex = 3
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.Location = New System.Drawing.Point(78, 49)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(39, 13)
        Me.lblFormat.TabIndex = 2
        Me.lblFormat.Text = "Format"
        '
        'cmbChannels
        '
        Me.cmbChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChannels.FormattingEnabled = True
        Me.cmbChannels.Items.AddRange(New Object() {"1 (MONO)", "2 (STEREO)"})
        Me.cmbChannels.Location = New System.Drawing.Point(123, 73)
        Me.cmbChannels.Name = "cmbChannels"
        Me.cmbChannels.Size = New System.Drawing.Size(106, 21)
        Me.cmbChannels.TabIndex = 5
        '
        'lblChannels
        '
        Me.lblChannels.AutoSize = True
        Me.lblChannels.Location = New System.Drawing.Point(66, 76)
        Me.lblChannels.Name = "lblChannels"
        Me.lblChannels.Size = New System.Drawing.Size(51, 13)
        Me.lblChannels.TabIndex = 4
        Me.lblChannels.Text = "Channels"
        '
        'cmbQualityBitrate
        '
        Me.cmbQualityBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQualityBitrate.FormattingEnabled = True
        Me.cmbQualityBitrate.Location = New System.Drawing.Point(123, 100)
        Me.cmbQualityBitrate.Name = "cmbQualityBitrate"
        Me.cmbQualityBitrate.Size = New System.Drawing.Size(106, 21)
        Me.cmbQualityBitrate.TabIndex = 7
        '
        'lblQualityBitrate
        '
        Me.lblQualityBitrate.AutoSize = True
        Me.lblQualityBitrate.Location = New System.Drawing.Point(34, 103)
        Me.lblQualityBitrate.Name = "lblQualityBitrate"
        Me.lblQualityBitrate.Size = New System.Drawing.Size(83, 13)
        Me.lblQualityBitrate.TabIndex = 6
        Me.lblQualityBitrate.Text = "Quality / Bitrate:"
        '
        'lblEncoders
        '
        Me.lblEncoders.AutoSize = True
        Me.lblEncoders.Location = New System.Drawing.Point(44, 165)
        Me.lblEncoders.Name = "lblEncoders"
        Me.lblEncoders.Size = New System.Drawing.Size(67, 13)
        Me.lblEncoders.TabIndex = 8
        Me.lblEncoders.Text = "ENCODERS"
        '
        'lblMP3
        '
        Me.lblMP3.AutoSize = True
        Me.lblMP3.Location = New System.Drawing.Point(47, 202)
        Me.lblMP3.Name = "lblMP3"
        Me.lblMP3.Size = New System.Drawing.Size(70, 13)
        Me.lblMP3.TabIndex = 9
        Me.lblMP3.Text = "MP3 (LAME):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "OGG (OGGEnc):"
        '
        'tbLAME
        '
        Me.tbLAME.Location = New System.Drawing.Point(123, 199)
        Me.tbLAME.Name = "tbLAME"
        Me.tbLAME.Size = New System.Drawing.Size(171, 20)
        Me.tbLAME.TabIndex = 11
        '
        'btnLAMEBrowse
        '
        Me.btnLAMEBrowse.Location = New System.Drawing.Point(300, 199)
        Me.btnLAMEBrowse.Name = "btnLAMEBrowse"
        Me.btnLAMEBrowse.Size = New System.Drawing.Size(50, 20)
        Me.btnLAMEBrowse.TabIndex = 12
        Me.btnLAMEBrowse.Text = "Browse"
        Me.btnLAMEBrowse.UseVisualStyleBackColor = True
        '
        'btnOGGEncBrowse
        '
        Me.btnOGGEncBrowse.Location = New System.Drawing.Point(300, 225)
        Me.btnOGGEncBrowse.Name = "btnOGGEncBrowse"
        Me.btnOGGEncBrowse.Size = New System.Drawing.Size(50, 20)
        Me.btnOGGEncBrowse.TabIndex = 14
        Me.btnOGGEncBrowse.Text = "Browse"
        Me.btnOGGEncBrowse.UseVisualStyleBackColor = True
        '
        'tbOGGEnc
        '
        Me.tbOGGEnc.Location = New System.Drawing.Point(123, 225)
        Me.tbOGGEnc.Name = "tbOGGEnc"
        Me.tbOGGEnc.Size = New System.Drawing.Size(171, 20)
        Me.tbOGGEnc.TabIndex = 13
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(287, 275)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 24)
        Me.btnCancel.TabIndex = 43
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(218, 275)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(63, 24)
        Me.btnOK.TabIndex = 42
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'ofdLAMEEnc
        '
        Me.ofdLAMEEnc.Filter = "LAME Encoder|lame.exe"
        '
        'ofdOggEnc
        '
        Me.ofdOggEnc.Filter = "OGG Encoder|oggenc*.exe"
        '
        'frmSettingsEncoder
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(373, 311)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnOGGEncBrowse)
        Me.Controls.Add(Me.tbOGGEnc)
        Me.Controls.Add(Me.btnLAMEBrowse)
        Me.Controls.Add(Me.tbLAME)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMP3)
        Me.Controls.Add(Me.lblEncoders)
        Me.Controls.Add(Me.cmbQualityBitrate)
        Me.Controls.Add(Me.lblQualityBitrate)
        Me.Controls.Add(Me.cmbChannels)
        Me.Controls.Add(Me.lblChannels)
        Me.Controls.Add(Me.cmbFormat)
        Me.Controls.Add(Me.lblFormat)
        Me.Controls.Add(Me.cmbSampleRate)
        Me.Controls.Add(Me.lblSampleRate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettingsEncoder"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encoder Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSampleRate As System.Windows.Forms.Label
    Friend WithEvents cmbSampleRate As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFormat As System.Windows.Forms.ComboBox
    Friend WithEvents lblFormat As System.Windows.Forms.Label
    Friend WithEvents cmbChannels As System.Windows.Forms.ComboBox
    Friend WithEvents lblChannels As System.Windows.Forms.Label
    Friend WithEvents cmbQualityBitrate As System.Windows.Forms.ComboBox
    Friend WithEvents lblQualityBitrate As System.Windows.Forms.Label
    Friend WithEvents lblEncoders As System.Windows.Forms.Label
    Friend WithEvents lblMP3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbLAME As System.Windows.Forms.TextBox
    Friend WithEvents btnLAMEBrowse As System.Windows.Forms.Button
    Friend WithEvents btnOGGEncBrowse As System.Windows.Forms.Button
    Friend WithEvents tbOGGEnc As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents ofdLAMEEnc As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofdOggEnc As System.Windows.Forms.OpenFileDialog
End Class

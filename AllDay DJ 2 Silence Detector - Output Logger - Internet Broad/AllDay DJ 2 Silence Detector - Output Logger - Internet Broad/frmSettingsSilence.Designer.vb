<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsSilence
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
        Me.lblTime = New System.Windows.Forms.Label
        Me.nudSilenceLength = New System.Windows.Forms.NumericUpDown
        Me.lblSMTP = New System.Windows.Forms.Label
        Me.chkUseSMTP = New System.Windows.Forms.CheckBox
        Me.lblSMTPServer = New System.Windows.Forms.Label
        Me.tbSMTPServer = New System.Windows.Forms.TextBox
        Me.tbSMTPUsername = New System.Windows.Forms.TextBox
        Me.lblSMTPUserName = New System.Windows.Forms.Label
        Me.tbSMTPPassword = New System.Windows.Forms.TextBox
        Me.lblSMTPPassword = New System.Windows.Forms.Label
        Me.tbSMTPFromAddress = New System.Windows.Forms.TextBox
        Me.lblSMTPFromAddress = New System.Windows.Forms.Label
        Me.tbSMTPToAddress = New System.Windows.Forms.TextBox
        Me.lblSMTPToAddress = New System.Windows.Forms.Label
        Me.tbPlaylist = New System.Windows.Forms.TextBox
        Me.lblPlaylist = New System.Windows.Forms.Label
        Me.chkAudio = New System.Windows.Forms.CheckBox
        Me.lblAudio = New System.Windows.Forms.Label
        Me.btnPlaylistBrowse = New System.Windows.Forms.Button
        Me.btnCommandBrowse = New System.Windows.Forms.Button
        Me.tbCommand = New System.Windows.Forms.TextBox
        Me.lblCommand = New System.Windows.Forms.Label
        Me.chkExecute = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.ofdM3U = New System.Windows.Forms.OpenFileDialog
        Me.ofdCommand = New System.Windows.Forms.OpenFileDialog
        CType(Me.nudSilenceLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(32, 25)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(81, 13)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "Silence Length:"
        '
        'nudSilenceLength
        '
        Me.nudSilenceLength.Location = New System.Drawing.Point(119, 23)
        Me.nudSilenceLength.Name = "nudSilenceLength"
        Me.nudSilenceLength.Size = New System.Drawing.Size(42, 20)
        Me.nudSilenceLength.TabIndex = 1
        '
        'lblSMTP
        '
        Me.lblSMTP.AutoSize = True
        Me.lblSMTP.Location = New System.Drawing.Point(12, 75)
        Me.lblSMTP.Name = "lblSMTP"
        Me.lblSMTP.Size = New System.Drawing.Size(37, 13)
        Me.lblSMTP.TabIndex = 2
        Me.lblSMTP.Text = "SMTP"
        '
        'chkUseSMTP
        '
        Me.chkUseSMTP.AutoSize = True
        Me.chkUseSMTP.Checked = True
        Me.chkUseSMTP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUseSMTP.Location = New System.Drawing.Point(35, 106)
        Me.chkUseSMTP.Name = "chkUseSMTP"
        Me.chkUseSMTP.Size = New System.Drawing.Size(106, 17)
        Me.chkUseSMTP.TabIndex = 3
        Me.chkUseSMTP.Text = "Use SMTP alerts"
        Me.chkUseSMTP.UseVisualStyleBackColor = True
        '
        'lblSMTPServer
        '
        Me.lblSMTPServer.AutoSize = True
        Me.lblSMTPServer.Location = New System.Drawing.Point(72, 136)
        Me.lblSMTPServer.Name = "lblSMTPServer"
        Me.lblSMTPServer.Size = New System.Drawing.Size(41, 13)
        Me.lblSMTPServer.TabIndex = 4
        Me.lblSMTPServer.Text = "Server:"
        '
        'tbSMTPServer
        '
        Me.tbSMTPServer.Location = New System.Drawing.Point(119, 136)
        Me.tbSMTPServer.Name = "tbSMTPServer"
        Me.tbSMTPServer.Size = New System.Drawing.Size(170, 20)
        Me.tbSMTPServer.TabIndex = 5
        '
        'tbSMTPUsername
        '
        Me.tbSMTPUsername.Location = New System.Drawing.Point(119, 162)
        Me.tbSMTPUsername.Name = "tbSMTPUsername"
        Me.tbSMTPUsername.Size = New System.Drawing.Size(170, 20)
        Me.tbSMTPUsername.TabIndex = 7
        '
        'lblSMTPUserName
        '
        Me.lblSMTPUserName.AutoSize = True
        Me.lblSMTPUserName.Location = New System.Drawing.Point(55, 162)
        Me.lblSMTPUserName.Name = "lblSMTPUserName"
        Me.lblSMTPUserName.Size = New System.Drawing.Size(58, 13)
        Me.lblSMTPUserName.TabIndex = 6
        Me.lblSMTPUserName.Text = "Username:"
        '
        'tbSMTPPassword
        '
        Me.tbSMTPPassword.Location = New System.Drawing.Point(119, 188)
        Me.tbSMTPPassword.Name = "tbSMTPPassword"
        Me.tbSMTPPassword.Size = New System.Drawing.Size(170, 20)
        Me.tbSMTPPassword.TabIndex = 9
        '
        'lblSMTPPassword
        '
        Me.lblSMTPPassword.AutoSize = True
        Me.lblSMTPPassword.Location = New System.Drawing.Point(57, 188)
        Me.lblSMTPPassword.Name = "lblSMTPPassword"
        Me.lblSMTPPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblSMTPPassword.TabIndex = 8
        Me.lblSMTPPassword.Text = "Password:"
        '
        'tbSMTPFromAddress
        '
        Me.tbSMTPFromAddress.Location = New System.Drawing.Point(119, 214)
        Me.tbSMTPFromAddress.Name = "tbSMTPFromAddress"
        Me.tbSMTPFromAddress.Size = New System.Drawing.Size(170, 20)
        Me.tbSMTPFromAddress.TabIndex = 11
        '
        'lblSMTPFromAddress
        '
        Me.lblSMTPFromAddress.AutoSize = True
        Me.lblSMTPFromAddress.Location = New System.Drawing.Point(39, 214)
        Me.lblSMTPFromAddress.Name = "lblSMTPFromAddress"
        Me.lblSMTPFromAddress.Size = New System.Drawing.Size(74, 13)
        Me.lblSMTPFromAddress.TabIndex = 10
        Me.lblSMTPFromAddress.Text = "From Address:"
        '
        'tbSMTPToAddress
        '
        Me.tbSMTPToAddress.Location = New System.Drawing.Point(119, 240)
        Me.tbSMTPToAddress.Name = "tbSMTPToAddress"
        Me.tbSMTPToAddress.Size = New System.Drawing.Size(170, 20)
        Me.tbSMTPToAddress.TabIndex = 13
        '
        'lblSMTPToAddress
        '
        Me.lblSMTPToAddress.AutoSize = True
        Me.lblSMTPToAddress.Location = New System.Drawing.Point(49, 240)
        Me.lblSMTPToAddress.Name = "lblSMTPToAddress"
        Me.lblSMTPToAddress.Size = New System.Drawing.Size(64, 13)
        Me.lblSMTPToAddress.TabIndex = 12
        Me.lblSMTPToAddress.Text = "To Address:"
        '
        'tbPlaylist
        '
        Me.tbPlaylist.Location = New System.Drawing.Point(119, 336)
        Me.tbPlaylist.Name = "tbPlaylist"
        Me.tbPlaylist.Size = New System.Drawing.Size(170, 20)
        Me.tbPlaylist.TabIndex = 17
        '
        'lblPlaylist
        '
        Me.lblPlaylist.AutoSize = True
        Me.lblPlaylist.Location = New System.Drawing.Point(71, 336)
        Me.lblPlaylist.Name = "lblPlaylist"
        Me.lblPlaylist.Size = New System.Drawing.Size(42, 13)
        Me.lblPlaylist.TabIndex = 16
        Me.lblPlaylist.Text = "Playlist:"
        '
        'chkAudio
        '
        Me.chkAudio.AutoSize = True
        Me.chkAudio.Checked = True
        Me.chkAudio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAudio.Location = New System.Drawing.Point(35, 306)
        Me.chkAudio.Name = "chkAudio"
        Me.chkAudio.Size = New System.Drawing.Size(106, 17)
        Me.chkAudio.TabIndex = 15
        Me.chkAudio.Text = "Play M3U playlist"
        Me.chkAudio.UseVisualStyleBackColor = True
        '
        'lblAudio
        '
        Me.lblAudio.AutoSize = True
        Me.lblAudio.Location = New System.Drawing.Point(12, 275)
        Me.lblAudio.Name = "lblAudio"
        Me.lblAudio.Size = New System.Drawing.Size(34, 13)
        Me.lblAudio.TabIndex = 14
        Me.lblAudio.Text = "Audio"
        '
        'btnPlaylistBrowse
        '
        Me.btnPlaylistBrowse.Location = New System.Drawing.Point(295, 336)
        Me.btnPlaylistBrowse.Name = "btnPlaylistBrowse"
        Me.btnPlaylistBrowse.Size = New System.Drawing.Size(58, 20)
        Me.btnPlaylistBrowse.TabIndex = 18
        Me.btnPlaylistBrowse.Text = "Browse"
        Me.btnPlaylistBrowse.UseVisualStyleBackColor = True
        '
        'btnCommandBrowse
        '
        Me.btnCommandBrowse.Location = New System.Drawing.Point(295, 434)
        Me.btnCommandBrowse.Name = "btnCommandBrowse"
        Me.btnCommandBrowse.Size = New System.Drawing.Size(58, 20)
        Me.btnCommandBrowse.TabIndex = 23
        Me.btnCommandBrowse.Text = "Browse"
        Me.btnCommandBrowse.UseVisualStyleBackColor = True
        '
        'tbCommand
        '
        Me.tbCommand.Location = New System.Drawing.Point(119, 434)
        Me.tbCommand.Name = "tbCommand"
        Me.tbCommand.Size = New System.Drawing.Size(170, 20)
        Me.tbCommand.TabIndex = 22
        '
        'lblCommand
        '
        Me.lblCommand.AutoSize = True
        Me.lblCommand.Location = New System.Drawing.Point(57, 437)
        Me.lblCommand.Name = "lblCommand"
        Me.lblCommand.Size = New System.Drawing.Size(57, 13)
        Me.lblCommand.TabIndex = 21
        Me.lblCommand.Text = "Command:"
        '
        'chkExecute
        '
        Me.chkExecute.AutoSize = True
        Me.chkExecute.Checked = True
        Me.chkExecute.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExecute.Location = New System.Drawing.Point(35, 404)
        Me.chkExecute.Name = "chkExecute"
        Me.chkExecute.Size = New System.Drawing.Size(123, 17)
        Me.chkExecute.TabIndex = 20
        Me.chkExecute.Text = "Execute a command"
        Me.chkExecute.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Execute Command"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(295, 483)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(58, 20)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ofdM3U
        '
        Me.ofdM3U.Filter = "M3U Playlist|*.m3u"
        '
        'ofdCommand
        '
        Me.ofdCommand.Filter = "All Files|*.*"
        '
        'frmSettingsSilence
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 515)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCommandBrowse)
        Me.Controls.Add(Me.tbCommand)
        Me.Controls.Add(Me.lblCommand)
        Me.Controls.Add(Me.chkExecute)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPlaylistBrowse)
        Me.Controls.Add(Me.tbPlaylist)
        Me.Controls.Add(Me.lblPlaylist)
        Me.Controls.Add(Me.chkAudio)
        Me.Controls.Add(Me.lblAudio)
        Me.Controls.Add(Me.tbSMTPToAddress)
        Me.Controls.Add(Me.lblSMTPToAddress)
        Me.Controls.Add(Me.tbSMTPFromAddress)
        Me.Controls.Add(Me.lblSMTPFromAddress)
        Me.Controls.Add(Me.tbSMTPPassword)
        Me.Controls.Add(Me.lblSMTPPassword)
        Me.Controls.Add(Me.tbSMTPUsername)
        Me.Controls.Add(Me.lblSMTPUserName)
        Me.Controls.Add(Me.tbSMTPServer)
        Me.Controls.Add(Me.lblSMTPServer)
        Me.Controls.Add(Me.chkUseSMTP)
        Me.Controls.Add(Me.lblSMTP)
        Me.Controls.Add(Me.nudSilenceLength)
        Me.Controls.Add(Me.lblTime)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettingsSilence"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Silence Detector Settings"
        CType(Me.nudSilenceLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents nudSilenceLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSMTP As System.Windows.Forms.Label
    Friend WithEvents chkUseSMTP As System.Windows.Forms.CheckBox
    Friend WithEvents lblSMTPServer As System.Windows.Forms.Label
    Friend WithEvents tbSMTPServer As System.Windows.Forms.TextBox
    Friend WithEvents tbSMTPUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblSMTPUserName As System.Windows.Forms.Label
    Friend WithEvents tbSMTPPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblSMTPPassword As System.Windows.Forms.Label
    Friend WithEvents tbSMTPFromAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblSMTPFromAddress As System.Windows.Forms.Label
    Friend WithEvents tbSMTPToAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblSMTPToAddress As System.Windows.Forms.Label
    Friend WithEvents tbPlaylist As System.Windows.Forms.TextBox
    Friend WithEvents lblPlaylist As System.Windows.Forms.Label
    Friend WithEvents chkAudio As System.Windows.Forms.CheckBox
    Friend WithEvents lblAudio As System.Windows.Forms.Label
    Friend WithEvents btnPlaylistBrowse As System.Windows.Forms.Button
    Friend WithEvents btnCommandBrowse As System.Windows.Forms.Button
    Friend WithEvents tbCommand As System.Windows.Forms.TextBox
    Friend WithEvents lblCommand As System.Windows.Forms.Label
    Friend WithEvents chkExecute As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ofdM3U As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofdCommand As System.Windows.Forms.OpenFileDialog
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.lblInput = New System.Windows.Forms.Label
        Me.lblSoundCard = New System.Windows.Forms.Label
        Me.lblSoundInput = New System.Windows.Forms.Label
        Me.cmbSoundCard = New System.Windows.Forms.ComboBox
        Me.cmbInput = New System.Windows.Forms.ComboBox
        Me.lblNowNext = New System.Windows.Forms.Label
        Me.lblNowNextFile = New System.Windows.Forms.Label
        Me.tbNowNextFile = New System.Windows.Forms.TextBox
        Me.btnNowNextBrowse = New System.Windows.Forms.Button
        Me.lblInternet = New System.Windows.Forms.Label
        Me.lblPreference = New System.Windows.Forms.Label
        Me.cmbInternetPreference = New System.Windows.Forms.ComboBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ofdNowAndNext = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(21, 21)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(40, 13)
        Me.lblInput.TabIndex = 0
        Me.lblInput.Text = "INPUT"
        '
        'lblSoundCard
        '
        Me.lblSoundCard.AutoSize = True
        Me.lblSoundCard.Location = New System.Drawing.Point(41, 50)
        Me.lblSoundCard.Name = "lblSoundCard"
        Me.lblSoundCard.Size = New System.Drawing.Size(62, 13)
        Me.lblSoundCard.TabIndex = 1
        Me.lblSoundCard.Text = "Soundcard:"
        '
        'lblSoundInput
        '
        Me.lblSoundInput.AutoSize = True
        Me.lblSoundInput.Location = New System.Drawing.Point(69, 82)
        Me.lblSoundInput.Name = "lblSoundInput"
        Me.lblSoundInput.Size = New System.Drawing.Size(34, 13)
        Me.lblSoundInput.TabIndex = 2
        Me.lblSoundInput.Text = "Input:"
        '
        'cmbSoundCard
        '
        Me.cmbSoundCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSoundCard.FormattingEnabled = True
        Me.cmbSoundCard.Location = New System.Drawing.Point(109, 47)
        Me.cmbSoundCard.Name = "cmbSoundCard"
        Me.cmbSoundCard.Size = New System.Drawing.Size(262, 21)
        Me.cmbSoundCard.TabIndex = 3
        '
        'cmbInput
        '
        Me.cmbInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInput.FormattingEnabled = True
        Me.cmbInput.Location = New System.Drawing.Point(109, 74)
        Me.cmbInput.Name = "cmbInput"
        Me.cmbInput.Size = New System.Drawing.Size(262, 21)
        Me.cmbInput.TabIndex = 4
        '
        'lblNowNext
        '
        Me.lblNowNext.AutoSize = True
        Me.lblNowNext.Location = New System.Drawing.Point(21, 161)
        Me.lblNowNext.Name = "lblNowNext"
        Me.lblNowNext.Size = New System.Drawing.Size(92, 13)
        Me.lblNowNext.TabIndex = 5
        Me.lblNowNext.Text = "NOW AND NEXT"
        '
        'lblNowNextFile
        '
        Me.lblNowNextFile.AutoSize = True
        Me.lblNowNextFile.Location = New System.Drawing.Point(41, 193)
        Me.lblNowNextFile.Name = "lblNowNextFile"
        Me.lblNowNextFile.Size = New System.Drawing.Size(156, 13)
        Me.lblNowNextFile.TabIndex = 6
        Me.lblNowNextFile.Text = "AllDay DJ 2 Now And Next File:"
        '
        'tbNowNextFile
        '
        Me.tbNowNextFile.Location = New System.Drawing.Point(46, 213)
        Me.tbNowNextFile.Name = "tbNowNextFile"
        Me.tbNowNextFile.Size = New System.Drawing.Size(258, 20)
        Me.tbNowNextFile.TabIndex = 7
        '
        'btnNowNextBrowse
        '
        Me.btnNowNextBrowse.Location = New System.Drawing.Point(310, 212)
        Me.btnNowNextBrowse.Name = "btnNowNextBrowse"
        Me.btnNowNextBrowse.Size = New System.Drawing.Size(61, 20)
        Me.btnNowNextBrowse.TabIndex = 8
        Me.btnNowNextBrowse.Text = "Browse"
        Me.btnNowNextBrowse.UseVisualStyleBackColor = True
        '
        'lblInternet
        '
        Me.lblInternet.AutoSize = True
        Me.lblInternet.Location = New System.Drawing.Point(21, 277)
        Me.lblInternet.Name = "lblInternet"
        Me.lblInternet.Size = New System.Drawing.Size(110, 13)
        Me.lblInternet.TabIndex = 9
        Me.lblInternet.Text = "INTERNET OUTPUT"
        '
        'lblPreference
        '
        Me.lblPreference.AutoSize = True
        Me.lblPreference.Location = New System.Drawing.Point(41, 309)
        Me.lblPreference.Name = "lblPreference"
        Me.lblPreference.Size = New System.Drawing.Size(62, 13)
        Me.lblPreference.TabIndex = 10
        Me.lblPreference.Text = "Preference:"
        '
        'cmbInternetPreference
        '
        Me.cmbInternetPreference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInternetPreference.FormattingEnabled = True
        Me.cmbInternetPreference.Items.AddRange(New Object() {"SHOUTCAST", "ICECAST"})
        Me.cmbInternetPreference.Location = New System.Drawing.Point(109, 306)
        Me.cmbInternetPreference.Name = "cmbInternetPreference"
        Me.cmbInternetPreference.Size = New System.Drawing.Size(262, 21)
        Me.cmbInternetPreference.TabIndex = 11
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(239, 375)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(63, 24)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(308, 375)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 24)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ofdNowAndNext
        '
        Me.ofdNowAndNext.Filter = "Now And Next|nownext.txt"
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(405, 422)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cmbInternetPreference)
        Me.Controls.Add(Me.lblPreference)
        Me.Controls.Add(Me.lblInternet)
        Me.Controls.Add(Me.btnNowNextBrowse)
        Me.Controls.Add(Me.tbNowNextFile)
        Me.Controls.Add(Me.lblNowNextFile)
        Me.Controls.Add(Me.lblNowNext)
        Me.Controls.Add(Me.cmbInput)
        Me.Controls.Add(Me.cmbSoundCard)
        Me.Controls.Add(Me.lblSoundInput)
        Me.Controls.Add(Me.lblSoundCard)
        Me.Controls.Add(Me.lblInput)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents lblSoundCard As System.Windows.Forms.Label
    Friend WithEvents lblSoundInput As System.Windows.Forms.Label
    Friend WithEvents cmbSoundCard As System.Windows.Forms.ComboBox
    Friend WithEvents cmbInput As System.Windows.Forms.ComboBox
    Friend WithEvents lblNowNext As System.Windows.Forms.Label
    Friend WithEvents lblNowNextFile As System.Windows.Forms.Label
    Friend WithEvents tbNowNextFile As System.Windows.Forms.TextBox
    Friend WithEvents btnNowNextBrowse As System.Windows.Forms.Button
    Friend WithEvents lblInternet As System.Windows.Forms.Label
    Friend WithEvents lblPreference As System.Windows.Forms.Label
    Friend WithEvents cmbInternetPreference As System.Windows.Forms.ComboBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ofdNowAndNext As System.Windows.Forms.OpenFileDialog
End Class

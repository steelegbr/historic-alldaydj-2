<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNowNext
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbDefaultText = New System.Windows.Forms.TextBox
        Me.tbOutputFile = New System.Windows.Forms.TextBox
        Me.lblOutput = New System.Windows.Forms.Label
        Me.btnBrowseOuputFile = New System.Windows.Forms.Button
        Me.lblIgnore = New System.Windows.Forms.Label
        Me.clbIgnore = New System.Windows.Forms.CheckedListBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.sfdOutputFile = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Default Text:"
        '
        'tbDefaultText
        '
        Me.tbDefaultText.Location = New System.Drawing.Point(107, 10)
        Me.tbDefaultText.Name = "tbDefaultText"
        Me.tbDefaultText.Size = New System.Drawing.Size(298, 20)
        Me.tbDefaultText.TabIndex = 1
        '
        'tbOutputFile
        '
        Me.tbOutputFile.Location = New System.Drawing.Point(107, 36)
        Me.tbOutputFile.Name = "tbOutputFile"
        Me.tbOutputFile.ReadOnly = True
        Me.tbOutputFile.Size = New System.Drawing.Size(298, 20)
        Me.tbOutputFile.TabIndex = 3
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(12, 39)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(61, 13)
        Me.lblOutput.TabIndex = 2
        Me.lblOutput.Text = "Output File:"
        '
        'btnBrowseOuputFile
        '
        Me.btnBrowseOuputFile.Location = New System.Drawing.Point(418, 36)
        Me.btnBrowseOuputFile.Name = "btnBrowseOuputFile"
        Me.btnBrowseOuputFile.Size = New System.Drawing.Size(67, 22)
        Me.btnBrowseOuputFile.TabIndex = 4
        Me.btnBrowseOuputFile.Text = "Browse"
        Me.btnBrowseOuputFile.UseVisualStyleBackColor = True
        '
        'lblIgnore
        '
        Me.lblIgnore.AutoSize = True
        Me.lblIgnore.Location = New System.Drawing.Point(12, 62)
        Me.lblIgnore.Name = "lblIgnore"
        Me.lblIgnore.Size = New System.Drawing.Size(80, 13)
        Me.lblIgnore.TabIndex = 5
        Me.lblIgnore.Text = "Ignore Playlists:"
        '
        'clbIgnore
        '
        Me.clbIgnore.FormattingEnabled = True
        Me.clbIgnore.Location = New System.Drawing.Point(107, 62)
        Me.clbIgnore.Name = "clbIgnore"
        Me.clbIgnore.Size = New System.Drawing.Size(298, 79)
        Me.clbIgnore.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(418, 151)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(67, 22)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'sfdOutputFile
        '
        Me.sfdOutputFile.FileName = "nownext.txt"
        Me.sfdOutputFile.Filter = "All Files|*.*"
        '
        'frmNowNext
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 185)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.clbIgnore)
        Me.Controls.Add(Me.lblIgnore)
        Me.Controls.Add(Me.btnBrowseOuputFile)
        Me.Controls.Add(Me.tbOutputFile)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.tbDefaultText)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNowNext"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Now And Next"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbDefaultText As System.Windows.Forms.TextBox
    Friend WithEvents tbOutputFile As System.Windows.Forms.TextBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnBrowseOuputFile As System.Windows.Forms.Button
    Friend WithEvents lblIgnore As System.Windows.Forms.Label
    Friend WithEvents clbIgnore As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents sfdOutputFile As System.Windows.Forms.SaveFileDialog
End Class

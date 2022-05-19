<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsLogger
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
        Me.lblKeepFilesFor = New System.Windows.Forms.Label
        Me.nudLogLength = New System.Windows.Forms.NumericUpDown
        Me.lblDays = New System.Windows.Forms.Label
        Me.lblOuput = New System.Windows.Forms.Label
        Me.tbOutput = New System.Windows.Forms.TextBox
        Me.btnOutputBrowse = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.fbdLogger = New System.Windows.Forms.FolderBrowserDialog
        CType(Me.nudLogLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKeepFilesFor
        '
        Me.lblKeepFilesFor.AutoSize = True
        Me.lblKeepFilesFor.Location = New System.Drawing.Point(21, 25)
        Me.lblKeepFilesFor.Name = "lblKeepFilesFor"
        Me.lblKeepFilesFor.Size = New System.Drawing.Size(68, 13)
        Me.lblKeepFilesFor.TabIndex = 0
        Me.lblKeepFilesFor.Text = "Keep files for"
        '
        'nudLogLength
        '
        Me.nudLogLength.Location = New System.Drawing.Point(95, 23)
        Me.nudLogLength.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.nudLogLength.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLogLength.Name = "nudLogLength"
        Me.nudLogLength.Size = New System.Drawing.Size(49, 20)
        Me.nudLogLength.TabIndex = 1
        Me.nudLogLength.Value = New Decimal(New Integer() {42, 0, 0, 0})
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(150, 25)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(32, 13)
        Me.lblDays.TabIndex = 2
        Me.lblDays.Text = "days."
        '
        'lblOuput
        '
        Me.lblOuput.AutoSize = True
        Me.lblOuput.Location = New System.Drawing.Point(15, 63)
        Me.lblOuput.Name = "lblOuput"
        Me.lblOuput.Size = New System.Drawing.Size(74, 13)
        Me.lblOuput.TabIndex = 3
        Me.lblOuput.Text = "Output Folder:"
        '
        'tbOutput
        '
        Me.tbOutput.Location = New System.Drawing.Point(95, 60)
        Me.tbOutput.Name = "tbOutput"
        Me.tbOutput.Size = New System.Drawing.Size(175, 20)
        Me.tbOutput.TabIndex = 4
        '
        'btnOutputBrowse
        '
        Me.btnOutputBrowse.Location = New System.Drawing.Point(276, 60)
        Me.btnOutputBrowse.Name = "btnOutputBrowse"
        Me.btnOutputBrowse.Size = New System.Drawing.Size(55, 19)
        Me.btnOutputBrowse.TabIndex = 5
        Me.btnOutputBrowse.Text = "Browse"
        Me.btnOutputBrowse.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(276, 101)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(54, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmSettingsLogger
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 139)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOutputBrowse)
        Me.Controls.Add(Me.tbOutput)
        Me.Controls.Add(Me.lblOuput)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.nudLogLength)
        Me.Controls.Add(Me.lblKeepFilesFor)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettingsLogger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logger Settings"
        CType(Me.nudLogLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblKeepFilesFor As System.Windows.Forms.Label
    Friend WithEvents nudLogLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDays As System.Windows.Forms.Label
    Friend WithEvents lblOuput As System.Windows.Forms.Label
    Friend WithEvents tbOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnOutputBrowse As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents fbdLogger As System.Windows.Forms.FolderBrowserDialog
End Class

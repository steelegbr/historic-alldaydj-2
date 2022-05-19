<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddToSpotHardware
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
        Me.lblLength = New System.Windows.Forms.Label
        Me.tbLength = New System.Windows.Forms.NumericUpDown
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        CType(Me.tbLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(23, 9)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(43, 13)
        Me.lblLength.TabIndex = 2
        Me.lblLength.Text = "Length:"
        Me.lblLength.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbLength
        '
        Me.tbLength.Location = New System.Drawing.Point(81, 7)
        Me.tbLength.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.tbLength.Name = "tbLength"
        Me.tbLength.Size = New System.Drawing.Size(45, 20)
        Me.tbLength.TabIndex = 3
        Me.tbLength.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 33)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(54, 25)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(72, 33)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(54, 25)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmAddToSpotHardware
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(141, 73)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.tbLength)
        Me.Controls.Add(Me.lblLength)
        Me.Name = "frmAddToSpotHardware"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hardware Event"
        CType(Me.tbLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents tbLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class

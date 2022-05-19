<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMultaple
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
        Me.lblImport = New System.Windows.Forms.Label
        Me.btnOneItem = New System.Windows.Forms.Button
        Me.btnWholeDirectory = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblImport
        '
        Me.lblImport.AutoSize = True
        Me.lblImport.Location = New System.Drawing.Point(12, 9)
        Me.lblImport.Name = "lblImport"
        Me.lblImport.Size = New System.Drawing.Size(261, 13)
        Me.lblImport.TabIndex = 0
        Me.lblImport.Text = "Do you wish to add just one item or a whole directory?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnOneItem
        '
        Me.btnOneItem.Location = New System.Drawing.Point(15, 25)
        Me.btnOneItem.Name = "btnOneItem"
        Me.btnOneItem.Size = New System.Drawing.Size(258, 26)
        Me.btnOneItem.TabIndex = 1
        Me.btnOneItem.Text = "Just One Item"
        Me.btnOneItem.UseVisualStyleBackColor = True
        '
        'btnWholeDirectory
        '
        Me.btnWholeDirectory.Location = New System.Drawing.Point(15, 57)
        Me.btnWholeDirectory.Name = "btnWholeDirectory"
        Me.btnWholeDirectory.Size = New System.Drawing.Size(258, 26)
        Me.btnWholeDirectory.TabIndex = 2
        Me.btnWholeDirectory.Text = "A Whole Directory"
        Me.btnWholeDirectory.UseVisualStyleBackColor = True
        '
        'dlgMultaple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 95)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnWholeDirectory)
        Me.Controls.Add(Me.btnOneItem)
        Me.Controls.Add(Me.lblImport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMultaple"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Whole directory or one item?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblImport As System.Windows.Forms.Label
    Friend WithEvents btnOneItem As System.Windows.Forms.Button
    Friend WithEvents btnWholeDirectory As System.Windows.Forms.Button

End Class

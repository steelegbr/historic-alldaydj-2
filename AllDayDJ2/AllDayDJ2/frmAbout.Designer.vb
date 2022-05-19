<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblProductName = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.pbAllDayDJ = New System.Windows.Forms.PictureBox
        CType(Me.pbAllDayDJ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(261, 9)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(53, 13)
        Me.lblProductName.TabIndex = 0
        Me.lblProductName.Text = "AllDay DJ"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(261, 33)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(42, 13)
        Me.lblVersion.TabIndex = 1
        Me.lblVersion.Text = "Version"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Location = New System.Drawing.Point(261, 59)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(51, 13)
        Me.lblCopyright.TabIndex = 2
        Me.lblCopyright.Text = "Copyright"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(261, 86)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(261, 13)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "Powered by BASS Audio Library (www.un4seen.com)."
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(456, 113)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(66, 24)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pbAllDayDJ
        '
        Me.pbAllDayDJ.Image = CType(resources.GetObject("pbAllDayDJ.Image"), System.Drawing.Image)
        Me.pbAllDayDJ.Location = New System.Drawing.Point(25, 23)
        Me.pbAllDayDJ.Name = "pbAllDayDJ"
        Me.pbAllDayDJ.Size = New System.Drawing.Size(208, 66)
        Me.pbAllDayDJ.TabIndex = 6
        Me.pbAllDayDJ.TabStop = False
        '
        'frmAbout
        '
        Me.AcceptButton = Me.btnClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(537, 149)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbAllDayDJ)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblProductName)
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About AllDay DJ"
        CType(Me.pbAllDayDJ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents pbAllDayDJ As System.Windows.Forms.PictureBox
End Class

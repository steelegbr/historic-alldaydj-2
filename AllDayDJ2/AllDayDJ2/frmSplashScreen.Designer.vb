<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashScreen))
        Me.pbAllDayDJLogo = New System.Windows.Forms.PictureBox
        Me.lblAllDayDJ = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.pnlLoading = New System.Windows.Forms.Panel
        Me.lblLoading = New System.Windows.Forms.Label
        CType(Me.pbAllDayDJLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoading.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbAllDayDJLogo
        '
        Me.pbAllDayDJLogo.Image = CType(resources.GetObject("pbAllDayDJLogo.Image"), System.Drawing.Image)
        Me.pbAllDayDJLogo.Location = New System.Drawing.Point(12, 12)
        Me.pbAllDayDJLogo.Name = "pbAllDayDJLogo"
        Me.pbAllDayDJLogo.Size = New System.Drawing.Size(224, 86)
        Me.pbAllDayDJLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAllDayDJLogo.TabIndex = 0
        Me.pbAllDayDJLogo.TabStop = False
        '
        'lblAllDayDJ
        '
        Me.lblAllDayDJ.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAllDayDJ.AutoSize = True
        Me.lblAllDayDJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllDayDJ.Location = New System.Drawing.Point(318, 12)
        Me.lblAllDayDJ.Name = "lblAllDayDJ"
        Me.lblAllDayDJ.Size = New System.Drawing.Size(157, 37)
        Me.lblAllDayDJ.TabIndex = 1
        Me.lblAllDayDJ.Text = "AllDay DJ"
        Me.lblAllDayDJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(347, 52)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(102, 20)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Version 2.0.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Tag = "-1"
        '
        'pnlLoading
        '
        Me.pnlLoading.Controls.Add(Me.lblLoading)
        Me.pnlLoading.Location = New System.Drawing.Point(242, 70)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(313, 36)
        Me.pnlLoading.TabIndex = 3
        '
        'lblLoading
        '
        Me.lblLoading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLoading.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.Location = New System.Drawing.Point(0, 0)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(313, 36)
        Me.lblLoading.TabIndex = 4
        Me.lblLoading.Text = "Loading...."
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(555, 107)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlLoading)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblAllDayDJ)
        Me.Controls.Add(Me.pbAllDayDJLogo)
        Me.Name = "frmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbAllDayDJLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoading.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbAllDayDJLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblAllDayDJ As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents pnlLoading As System.Windows.Forms.Panel
    Friend WithEvents lblLoading As System.Windows.Forms.Label
End Class

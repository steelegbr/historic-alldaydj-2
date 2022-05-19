<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents MainLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DetailsLayoutPanel As System.Windows.Forms.TableLayoutPanel

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashScreen))
        Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel
        Me.DetailsLayoutPanel = New System.Windows.Forms.TableLayoutPanel
        Me.Version = New System.Windows.Forms.Label
        Me.Copyright = New System.Windows.Forms.Label
        Me.ApplicationTitle = New System.Windows.Forms.Label
        Me.pnlProgress = New System.Windows.Forms.Panel
        Me.lblLoading = New System.Windows.Forms.Label
        Me.pbLoading = New System.Windows.Forms.ProgressBar
        Me.pnlImage = New System.Windows.Forms.Panel
        Me.pbAllDayDJLogo = New System.Windows.Forms.PictureBox
        Me.MainLayoutPanel.SuspendLayout()
        Me.DetailsLayoutPanel.SuspendLayout()
        Me.pnlProgress.SuspendLayout()
        Me.pnlImage.SuspendLayout()
        CType(Me.pbAllDayDJLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainLayoutPanel
        '
        Me.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MainLayoutPanel.ColumnCount = 2
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainLayoutPanel.Controls.Add(Me.DetailsLayoutPanel, 1, 1)
        Me.MainLayoutPanel.Controls.Add(Me.ApplicationTitle, 1, 0)
        Me.MainLayoutPanel.Controls.Add(Me.pnlProgress, 0, 1)
        Me.MainLayoutPanel.Controls.Add(Me.pnlImage, 0, 0)
        Me.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainLayoutPanel.Size = New System.Drawing.Size(496, 150)
        Me.MainLayoutPanel.TabIndex = 0
        '
        'DetailsLayoutPanel
        '
        Me.DetailsLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.DetailsLayoutPanel.ColumnCount = 1
        Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247.0!))
        Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.DetailsLayoutPanel.Controls.Add(Me.Version, 0, 0)
        Me.DetailsLayoutPanel.Controls.Add(Me.Copyright, 0, 1)
        Me.DetailsLayoutPanel.Location = New System.Drawing.Point(251, 78)
        Me.DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.Size = New System.Drawing.Size(242, 69)
        Me.DetailsLayoutPanel.TabIndex = 1
        '
        'Version
        '
        Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(3, 7)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(241, 20)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Version {0}.{1:00}"
        '
        'Copyright
        '
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.Location = New System.Drawing.Point(3, 34)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(241, 35)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "Copyright"
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.Location = New System.Drawing.Point(251, 0)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(242, 75)
        Me.ApplicationTitle.TabIndex = 0
        Me.ApplicationTitle.Text = "ApplicationTitle"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'pnlProgress
        '
        Me.pnlProgress.Controls.Add(Me.lblLoading)
        Me.pnlProgress.Controls.Add(Me.pbLoading)
        Me.pnlProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProgress.Location = New System.Drawing.Point(3, 78)
        Me.pnlProgress.Name = "pnlProgress"
        Me.pnlProgress.Size = New System.Drawing.Size(242, 69)
        Me.pnlProgress.TabIndex = 3
        '
        'lblLoading
        '
        Me.lblLoading.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.Location = New System.Drawing.Point(9, 36)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(220, 27)
        Me.lblLoading.TabIndex = 1
        Me.lblLoading.Text = "Loading..."
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pbLoading
        '
        Me.pbLoading.Location = New System.Drawing.Point(9, 17)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(220, 10)
        Me.pbLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbLoading.TabIndex = 0
        '
        'pnlImage
        '
        Me.pnlImage.Controls.Add(Me.pbAllDayDJLogo)
        Me.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlImage.Location = New System.Drawing.Point(3, 3)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Size = New System.Drawing.Size(242, 69)
        Me.pnlImage.TabIndex = 4
        '
        'pbAllDayDJLogo
        '
        Me.pbAllDayDJLogo.Image = CType(resources.GetObject("pbAllDayDJLogo.Image"), System.Drawing.Image)
        Me.pbAllDayDJLogo.Location = New System.Drawing.Point(22, 3)
        Me.pbAllDayDJLogo.Name = "pbAllDayDJLogo"
        Me.pbAllDayDJLogo.Size = New System.Drawing.Size(207, 69)
        Me.pbAllDayDJLogo.TabIndex = 3
        Me.pbAllDayDJLogo.TabStop = False
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 150)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplashScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MainLayoutPanel.ResumeLayout(False)
        Me.DetailsLayoutPanel.ResumeLayout(False)
        Me.pnlProgress.ResumeLayout(False)
        Me.pnlImage.ResumeLayout(False)
        CType(Me.pbAllDayDJLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlProgress As System.Windows.Forms.Panel
    Friend WithEvents pbLoading As System.Windows.Forms.ProgressBar
    Friend WithEvents lblLoading As System.Windows.Forms.Label
    Friend WithEvents pnlImage As System.Windows.Forms.Panel
    Friend WithEvents pbAllDayDJLogo As System.Windows.Forms.PictureBox

End Class

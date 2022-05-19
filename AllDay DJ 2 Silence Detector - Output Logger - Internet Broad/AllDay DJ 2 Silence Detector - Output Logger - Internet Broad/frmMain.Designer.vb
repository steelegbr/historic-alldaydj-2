<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Me.MSMain = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EncoderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShoutcastToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IcecastToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SilenceDetectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoggerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pbLeft = New System.Windows.Forms.ProgressBar
        Me.pbRight = New System.Windows.Forms.ProgressBar
        Me.btnSilence = New System.Windows.Forms.Button
        Me.btnOutputLogger = New System.Windows.Forms.Button
        Me.btnInternetBroadcast = New System.Windows.Forms.Button
        Me.tmrVolume = New System.Windows.Forms.Timer(Me.components)
        Me.MSMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMain
        '
        Me.MSMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MSMain.Location = New System.Drawing.Point(0, 0)
        Me.MSMain.Name = "MSMain"
        Me.MSMain.Size = New System.Drawing.Size(530, 24)
        Me.MSMain.TabIndex = 0
        Me.MSMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralToolStripMenuItem, Me.EncoderToolStripMenuItem, Me.ShoutcastToolStripMenuItem, Me.IcecastToolStripMenuItem, Me.SilenceDetectorToolStripMenuItem, Me.LoggerToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = " &Settings"
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'EncoderToolStripMenuItem
        '
        Me.EncoderToolStripMenuItem.Name = "EncoderToolStripMenuItem"
        Me.EncoderToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EncoderToolStripMenuItem.Text = "Encoder"
        '
        'ShoutcastToolStripMenuItem
        '
        Me.ShoutcastToolStripMenuItem.Name = "ShoutcastToolStripMenuItem"
        Me.ShoutcastToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ShoutcastToolStripMenuItem.Text = "Shoutcast"
        '
        'IcecastToolStripMenuItem
        '
        Me.IcecastToolStripMenuItem.Name = "IcecastToolStripMenuItem"
        Me.IcecastToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IcecastToolStripMenuItem.Text = "Icecast"
        '
        'SilenceDetectorToolStripMenuItem
        '
        Me.SilenceDetectorToolStripMenuItem.Name = "SilenceDetectorToolStripMenuItem"
        Me.SilenceDetectorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SilenceDetectorToolStripMenuItem.Text = "Silence Detector"
        '
        'LoggerToolStripMenuItem
        '
        Me.LoggerToolStripMenuItem.Name = "LoggerToolStripMenuItem"
        Me.LoggerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoggerToolStripMenuItem.Text = "Logger"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'pbLeft
        '
        Me.pbLeft.Location = New System.Drawing.Point(12, 46)
        Me.pbLeft.Name = "pbLeft"
        Me.pbLeft.Size = New System.Drawing.Size(506, 34)
        Me.pbLeft.TabIndex = 1
        '
        'pbRight
        '
        Me.pbRight.Location = New System.Drawing.Point(12, 86)
        Me.pbRight.Name = "pbRight"
        Me.pbRight.Size = New System.Drawing.Size(506, 34)
        Me.pbRight.TabIndex = 2
        '
        'btnSilence
        '
        Me.btnSilence.BackColor = System.Drawing.Color.Red
        Me.btnSilence.Location = New System.Drawing.Point(12, 126)
        Me.btnSilence.Name = "btnSilence"
        Me.btnSilence.Size = New System.Drawing.Size(506, 39)
        Me.btnSilence.TabIndex = 3
        Me.btnSilence.Text = "SILENCE DETECTOR (OFF)"
        Me.btnSilence.UseVisualStyleBackColor = False
        '
        'btnOutputLogger
        '
        Me.btnOutputLogger.BackColor = System.Drawing.Color.Red
        Me.btnOutputLogger.Location = New System.Drawing.Point(12, 171)
        Me.btnOutputLogger.Name = "btnOutputLogger"
        Me.btnOutputLogger.Size = New System.Drawing.Size(506, 39)
        Me.btnOutputLogger.TabIndex = 4
        Me.btnOutputLogger.Text = "OUTPUT LOGGER (OFF)"
        Me.btnOutputLogger.UseVisualStyleBackColor = False
        '
        'btnInternetBroadcast
        '
        Me.btnInternetBroadcast.BackColor = System.Drawing.Color.Red
        Me.btnInternetBroadcast.Location = New System.Drawing.Point(12, 216)
        Me.btnInternetBroadcast.Name = "btnInternetBroadcast"
        Me.btnInternetBroadcast.Size = New System.Drawing.Size(506, 39)
        Me.btnInternetBroadcast.TabIndex = 5
        Me.btnInternetBroadcast.Text = "INTERENT BROADCAST (OFF)"
        Me.btnInternetBroadcast.UseVisualStyleBackColor = False
        '
        'tmrVolume
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 282)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnInternetBroadcast)
        Me.Controls.Add(Me.btnOutputLogger)
        Me.Controls.Add(Me.btnSilence)
        Me.Controls.Add(Me.pbRight)
        Me.Controls.Add(Me.pbLeft)
        Me.Controls.Add(Me.MSMain)
        Me.MainMenuStrip = Me.MSMain
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AllDay DJ Silence Detector - Output Logger - Internet Broacaster"
        Me.MSMain.ResumeLayout(False)
        Me.MSMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MSMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncoderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShoutcastToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IcecastToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbLeft As System.Windows.Forms.ProgressBar
    Friend WithEvents pbRight As System.Windows.Forms.ProgressBar
    Friend WithEvents btnSilence As System.Windows.Forms.Button
    Friend WithEvents btnOutputLogger As System.Windows.Forms.Button
    Friend WithEvents btnInternetBroadcast As System.Windows.Forms.Button
    Friend WithEvents SilenceDetectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoggerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrVolume As System.Windows.Forms.Timer

End Class

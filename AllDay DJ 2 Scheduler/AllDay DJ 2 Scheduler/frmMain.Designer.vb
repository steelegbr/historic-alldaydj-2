<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuMain = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GeneratePlaylistsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PurgePlaylistsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TopicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pnlLayoutControl = New System.Windows.Forms.TableLayoutPanel
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnSpots = New System.Windows.Forms.Button
        Me.ilMain = New System.Windows.Forms.ImageList(Me.components)
        Me.btnWeek = New System.Windows.Forms.Button
        Me.btnEvents = New System.Windows.Forms.Button
        Me.btnRotations = New System.Windows.Forms.Button
        Me.lvData = New System.Windows.Forms.ListView
        Me.btnAdd = New System.Windows.Forms.Button
        Me.mnuMain.SuspendLayout()
        Me.pnlLayoutControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(792, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneratePlaylistsToolStripMenuItem, Me.PurgePlaylistsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'GeneratePlaylistsToolStripMenuItem
        '
        Me.GeneratePlaylistsToolStripMenuItem.Name = "GeneratePlaylistsToolStripMenuItem"
        Me.GeneratePlaylistsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.GeneratePlaylistsToolStripMenuItem.Text = "&Generate Playlists"
        '
        'PurgePlaylistsToolStripMenuItem
        '
        Me.PurgePlaylistsToolStripMenuItem.Name = "PurgePlaylistsToolStripMenuItem"
        Me.PurgePlaylistsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PurgePlaylistsToolStripMenuItem.Text = "&Purge Playlists"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TopicsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TopicsToolStripMenuItem
        '
        Me.TopicsToolStripMenuItem.Name = "TopicsToolStripMenuItem"
        Me.TopicsToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.TopicsToolStripMenuItem.Text = "&Topics"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'pnlLayoutControl
        '
        Me.pnlLayoutControl.ColumnCount = 4
        Me.pnlLayoutControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlLayoutControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlLayoutControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlLayoutControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlLayoutControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.pnlLayoutControl.Controls.Add(Me.btnDelete, 3, 0)
        Me.pnlLayoutControl.Controls.Add(Me.btnEdit, 2, 0)
        Me.pnlLayoutControl.Controls.Add(Me.btnSpots, 0, 0)
        Me.pnlLayoutControl.Controls.Add(Me.btnWeek, 0, 4)
        Me.pnlLayoutControl.Controls.Add(Me.btnEvents, 0, 3)
        Me.pnlLayoutControl.Controls.Add(Me.btnRotations, 0, 2)
        Me.pnlLayoutControl.Controls.Add(Me.lvData, 1, 1)
        Me.pnlLayoutControl.Controls.Add(Me.btnAdd, 1, 0)
        Me.pnlLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLayoutControl.Location = New System.Drawing.Point(0, 24)
        Me.pnlLayoutControl.Name = "pnlLayoutControl"
        Me.pnlLayoutControl.RowCount = 5
        Me.pnlLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.pnlLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.pnlLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlLayoutControl.Size = New System.Drawing.Size(792, 542)
        Me.pnlLayoutControl.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(597, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(192, 61)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(399, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(192, 61)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSpots
        '
        Me.btnSpots.BackColor = System.Drawing.Color.White
        Me.btnSpots.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSpots.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpots.ImageKey = "groups.bmp"
        Me.btnSpots.ImageList = Me.ilMain
        Me.btnSpots.Location = New System.Drawing.Point(3, 3)
        Me.btnSpots.Name = "btnSpots"
        Me.pnlLayoutControl.SetRowSpan(Me.btnSpots, 2)
        Me.btnSpots.Size = New System.Drawing.Size(192, 128)
        Me.btnSpots.TabIndex = 0
        Me.btnSpots.Text = "Spots"
        Me.btnSpots.UseVisualStyleBackColor = False
        '
        'ilMain
        '
        Me.ilMain.ImageStream = CType(resources.GetObject("ilMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilMain.TransparentColor = System.Drawing.Color.Transparent
        Me.ilMain.Images.SetKeyName(0, "groups.bmp")
        Me.ilMain.Images.SetKeyName(1, "rotation.bmp")
        Me.ilMain.Images.SetKeyName(2, "clock.bmp")
        Me.ilMain.Images.SetKeyName(3, "schedule.bmp")
        '
        'btnWeek
        '
        Me.btnWeek.BackColor = System.Drawing.Color.White
        Me.btnWeek.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeek.ForeColor = System.Drawing.Color.White
        Me.btnWeek.ImageIndex = 3
        Me.btnWeek.ImageList = Me.ilMain
        Me.btnWeek.Location = New System.Drawing.Point(3, 407)
        Me.btnWeek.Name = "btnWeek"
        Me.btnWeek.Size = New System.Drawing.Size(192, 132)
        Me.btnWeek.TabIndex = 3
        Me.btnWeek.Text = "Week"
        Me.btnWeek.UseVisualStyleBackColor = False
        '
        'btnEvents
        '
        Me.btnEvents.BackColor = System.Drawing.Color.White
        Me.btnEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEvents.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvents.ForeColor = System.Drawing.Color.Yellow
        Me.btnEvents.ImageIndex = 2
        Me.btnEvents.ImageList = Me.ilMain
        Me.btnEvents.Location = New System.Drawing.Point(3, 272)
        Me.btnEvents.Name = "btnEvents"
        Me.btnEvents.Size = New System.Drawing.Size(192, 129)
        Me.btnEvents.TabIndex = 2
        Me.btnEvents.Text = "Events"
        Me.btnEvents.UseVisualStyleBackColor = False
        '
        'btnRotations
        '
        Me.btnRotations.BackColor = System.Drawing.Color.White
        Me.btnRotations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRotations.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRotations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRotations.ImageIndex = 1
        Me.btnRotations.ImageList = Me.ilMain
        Me.btnRotations.Location = New System.Drawing.Point(3, 137)
        Me.btnRotations.Name = "btnRotations"
        Me.btnRotations.Size = New System.Drawing.Size(192, 129)
        Me.btnRotations.TabIndex = 1
        Me.btnRotations.Text = "Rotations"
        Me.btnRotations.UseVisualStyleBackColor = False
        '
        'lvData
        '
        Me.pnlLayoutControl.SetColumnSpan(Me.lvData, 3)
        Me.lvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvData.LargeImageList = Me.ilMain
        Me.lvData.Location = New System.Drawing.Point(201, 70)
        Me.lvData.Name = "lvData"
        Me.pnlLayoutControl.SetRowSpan(Me.lvData, 4)
        Me.lvData.Size = New System.Drawing.Size(588, 469)
        Me.lvData.TabIndex = 5
        Me.lvData.UseCompatibleStateImageBehavior = False
        Me.lvData.View = System.Windows.Forms.View.List
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(201, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(192, 61)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.pnlLayoutControl)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AllDay DJ 2 Scheduler"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.pnlLayoutControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneratePlaylistsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopicsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlLayoutControl As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSpots As System.Windows.Forms.Button
    Friend WithEvents btnRotations As System.Windows.Forms.Button
    Friend WithEvents btnEvents As System.Windows.Forms.Button
    Friend WithEvents btnWeek As System.Windows.Forms.Button
    Friend WithEvents ilMain As System.Windows.Forms.ImageList
    Friend WithEvents lvData As System.Windows.Forms.ListView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents PurgePlaylistsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

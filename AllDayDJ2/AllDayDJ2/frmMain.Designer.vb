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
        Me.msMain = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ReloadDatabaseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TrainingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BacktimeCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NowAndNextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MixerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TopicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tmrDoStuff = New System.Windows.Forms.Timer(Me.components)
        Me.ttPlaylist = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrFlasher = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnInstantPlayer_1 = New System.Windows.Forms.ToolStripButton
        Me.btnInstantPlayer_2 = New System.Windows.Forms.ToolStripButton
        Me.btnInstantPlayer_3 = New System.Windows.Forms.ToolStripButton
        Me.btnInstantPlayer_4 = New System.Windows.Forms.ToolStripButton
        Me.btnInstantPlayer_5 = New System.Windows.Forms.ToolStripButton
        Me.btnInstantPlayer_6 = New System.Windows.Forms.ToolStripButton
        Me.btnInstantPlayer_7 = New System.Windows.Forms.ToolStripButton
        Me.btnInstantPlayer_8 = New System.Windows.Forms.ToolStripButton
        Me.btnInstantPlayer_9 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnLoad = New System.Windows.Forms.ToolStripButton
        Me.scMain = New System.Windows.Forms.SplitContainer
        Me.tableTopBar = New System.Windows.Forms.TableLayoutPanel
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblToHour = New System.Windows.Forms.Label
        Me.lblPlaylistRemain = New System.Windows.Forms.Label
        Me.lblToHourTitle = New System.Windows.Forms.Label
        Me.lblTrackRemain = New System.Windows.Forms.Label
        Me.gbMaster = New System.Windows.Forms.GroupBox
        Me.tableMaster = New System.Windows.Forms.TableLayoutPanel
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnPlay = New System.Windows.Forms.Button
        Me.btnAutomate = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.lblPlaylistRemainTitle = New System.Windows.Forms.Label
        Me.lblTimeTitle = New System.Windows.Forms.Label
        Me.lblTrackRemainTitle = New System.Windows.Forms.Label
        Me.tableMainLayout = New System.Windows.Forms.TableLayoutPanel
        Me.tableLeftPanel = New System.Windows.Forms.TableLayoutPanel
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnUp = New System.Windows.Forms.Button
        Me.btnDown = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnBreakAfter = New System.Windows.Forms.Button
        Me.btnPlayToHour = New System.Windows.Forms.Button
        Me.tablePlaylist = New System.Windows.Forms.TableLayoutPanel
        Me.tablePlaylist4 = New System.Windows.Forms.TableLayoutPanel
        Me.pbPlaylist4 = New System.Windows.Forms.ProgressBar
        Me.lblRemain4 = New System.Windows.Forms.Label
        Me.lblPlaylistPlayed4 = New System.Windows.Forms.Label
        Me.lblLength4 = New System.Windows.Forms.Label
        Me.lblPlaylistNumber4 = New System.Windows.Forms.Label
        Me.lblPlaylistArtistTitleInfo4 = New System.Windows.Forms.Label
        Me.scrollPlaylist = New System.Windows.Forms.VScrollBar
        Me.tablePlaylist1 = New System.Windows.Forms.TableLayoutPanel
        Me.lblRemain1 = New System.Windows.Forms.Label
        Me.lblPlaylistPlayed1 = New System.Windows.Forms.Label
        Me.lblLength1 = New System.Windows.Forms.Label
        Me.lblPlaylistNumber1 = New System.Windows.Forms.Label
        Me.lblPlaylistArtistTitleInfo1 = New System.Windows.Forms.Label
        Me.pbPlaylist1 = New System.Windows.Forms.ProgressBar
        Me.tablePlaylist2 = New System.Windows.Forms.TableLayoutPanel
        Me.pbPlaylist2 = New System.Windows.Forms.ProgressBar
        Me.lblRemain2 = New System.Windows.Forms.Label
        Me.lblPlaylistPlayed2 = New System.Windows.Forms.Label
        Me.lblLength2 = New System.Windows.Forms.Label
        Me.lblPlaylistNumber2 = New System.Windows.Forms.Label
        Me.lblPlaylistArtistTitleInfo2 = New System.Windows.Forms.Label
        Me.tablePlaylist3 = New System.Windows.Forms.TableLayoutPanel
        Me.pbPlaylist3 = New System.Windows.Forms.ProgressBar
        Me.lblRemain3 = New System.Windows.Forms.Label
        Me.lblPlaylistPlayed3 = New System.Windows.Forms.Label
        Me.lblLength3 = New System.Windows.Forms.Label
        Me.lblPlaylistNumber3 = New System.Windows.Forms.Label
        Me.lblPlaylistArtistTitleInfo3 = New System.Windows.Forms.Label
        Me.tabDisplay = New System.Windows.Forms.TabControl
        Me.tabPlayedItems = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.lbPlayedItems = New System.Windows.Forms.ListBox
        Me.btnClearPlayed = New System.Windows.Forms.Button
        Me.tabPlayers = New System.Windows.Forms.TabPage
        Me.tablePlayers = New System.Windows.Forms.TableLayoutPanel
        Me.gbPlayer4 = New System.Windows.Forms.GroupBox
        Me.tablePlayer4 = New System.Windows.Forms.TableLayoutPanel
        Me.btnStop4 = New System.Windows.Forms.Button
        Me.lblArtist4 = New System.Windows.Forms.Label
        Me.btnPlay4 = New System.Windows.Forms.Button
        Me.lblTitle4 = New System.Windows.Forms.Label
        Me.prgPlayer4 = New System.Windows.Forms.ProgressBar
        Me.lblTimeLeft4 = New System.Windows.Forms.Label
        Me.tbPlayed4 = New System.Windows.Forms.TextBox
        Me.tbTitle4 = New System.Windows.Forms.TextBox
        Me.tbTimeLeft4 = New System.Windows.Forms.TextBox
        Me.lblPlayed4 = New System.Windows.Forms.Label
        Me.tbArtist4 = New System.Windows.Forms.TextBox
        Me.gbPlayer2 = New System.Windows.Forms.GroupBox
        Me.tablePlayer2 = New System.Windows.Forms.TableLayoutPanel
        Me.btnStop2 = New System.Windows.Forms.Button
        Me.lblArtist2 = New System.Windows.Forms.Label
        Me.btnPlay2 = New System.Windows.Forms.Button
        Me.lblTitle2 = New System.Windows.Forms.Label
        Me.prgPlayer2 = New System.Windows.Forms.ProgressBar
        Me.lblTimeLeft2 = New System.Windows.Forms.Label
        Me.tbPlayed2 = New System.Windows.Forms.TextBox
        Me.tbTitle2 = New System.Windows.Forms.TextBox
        Me.tbTimeLeft2 = New System.Windows.Forms.TextBox
        Me.lblPlayed2 = New System.Windows.Forms.Label
        Me.tbArtist2 = New System.Windows.Forms.TextBox
        Me.gbPlayer1 = New System.Windows.Forms.GroupBox
        Me.tablePlayer1 = New System.Windows.Forms.TableLayoutPanel
        Me.prgPlayer1 = New System.Windows.Forms.ProgressBar
        Me.btnStop1 = New System.Windows.Forms.Button
        Me.lblArtist1 = New System.Windows.Forms.Label
        Me.btnPlay1 = New System.Windows.Forms.Button
        Me.tbArtist1 = New System.Windows.Forms.TextBox
        Me.tbTitle1 = New System.Windows.Forms.TextBox
        Me.tbPlayed1 = New System.Windows.Forms.TextBox
        Me.lblTitle1 = New System.Windows.Forms.Label
        Me.lblPlayed1 = New System.Windows.Forms.Label
        Me.lblTimeLeft1 = New System.Windows.Forms.Label
        Me.tbTimeLeft1 = New System.Windows.Forms.TextBox
        Me.gbPlayer3 = New System.Windows.Forms.GroupBox
        Me.tablePlayer3 = New System.Windows.Forms.TableLayoutPanel
        Me.prgPlayer3 = New System.Windows.Forms.ProgressBar
        Me.btnStop3 = New System.Windows.Forms.Button
        Me.lblArtist3 = New System.Windows.Forms.Label
        Me.tbArtist3 = New System.Windows.Forms.TextBox
        Me.tbTitle3 = New System.Windows.Forms.TextBox
        Me.lblPlayed3 = New System.Windows.Forms.Label
        Me.lblTitle3 = New System.Windows.Forms.Label
        Me.lblTimeLeft3 = New System.Windows.Forms.Label
        Me.tbTimeLeft3 = New System.Windows.Forms.TextBox
        Me.tbPlayed3 = New System.Windows.Forms.TextBox
        Me.btnPlay3 = New System.Windows.Forms.Button
        Me.msMain.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        Me.tableTopBar.SuspendLayout()
        Me.gbMaster.SuspendLayout()
        Me.tableMaster.SuspendLayout()
        Me.tableMainLayout.SuspendLayout()
        Me.tableLeftPanel.SuspendLayout()
        Me.tablePlaylist.SuspendLayout()
        Me.tablePlaylist4.SuspendLayout()
        Me.tablePlaylist1.SuspendLayout()
        Me.tablePlaylist2.SuspendLayout()
        Me.tablePlaylist3.SuspendLayout()
        Me.tabDisplay.SuspendLayout()
        Me.tabPlayedItems.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tabPlayers.SuspendLayout()
        Me.tablePlayers.SuspendLayout()
        Me.gbPlayer4.SuspendLayout()
        Me.tablePlayer4.SuspendLayout()
        Me.gbPlayer2.SuspendLayout()
        Me.tablePlayer2.SuspendLayout()
        Me.gbPlayer1.SuspendLayout()
        Me.tablePlayer1.SuspendLayout()
        Me.gbPlayer3.SuspendLayout()
        Me.tablePlayer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ModeToolStripMenuItem, Me.ExtrasToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(1016, 24)
        Me.msMain.TabIndex = 1
        Me.msMain.Text = "Menu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LogsToolStripMenuItem
        '
        Me.LogsToolStripMenuItem.Name = "LogsToolStripMenuItem"
        Me.LogsToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.LogsToolStripMenuItem.Text = "Logs"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripSeparator1, Me.DatabaseToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.ToolStripSeparator2, Me.ReloadDatabaseToolStripMenuItem1})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LoginToolStripMenuItem.Text = "&Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LogoutToolStripMenuItem.Text = "Log&out"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DatabaseToolStripMenuItem.Text = "&Database"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "&Change Password"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(168, 6)
        '
        'ReloadDatabaseToolStripMenuItem1
        '
        Me.ReloadDatabaseToolStripMenuItem1.Name = "ReloadDatabaseToolStripMenuItem1"
        Me.ReloadDatabaseToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.ReloadDatabaseToolStripMenuItem1.Text = "&Reload Database"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem, Me.TrainingToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ModeToolStripMenuItem.Text = "&Mode"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Enabled = False
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.NormalToolStripMenuItem.Text = "&Normal"
        '
        'TrainingToolStripMenuItem
        '
        Me.TrainingToolStripMenuItem.Name = "TrainingToolStripMenuItem"
        Me.TrainingToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.TrainingToolStripMenuItem.Text = "&Training"
        '
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BacktimeCalculatorToolStripMenuItem, Me.NowAndNextToolStripMenuItem, Me.MixerToolStripMenuItem})
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ExtrasToolStripMenuItem.Text = "&Extras"
        '
        'BacktimeCalculatorToolStripMenuItem
        '
        Me.BacktimeCalculatorToolStripMenuItem.Name = "BacktimeCalculatorToolStripMenuItem"
        Me.BacktimeCalculatorToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.BacktimeCalculatorToolStripMenuItem.Text = "Backtime Calculator"
        '
        'NowAndNextToolStripMenuItem
        '
        Me.NowAndNextToolStripMenuItem.Name = "NowAndNextToolStripMenuItem"
        Me.NowAndNextToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.NowAndNextToolStripMenuItem.Text = "Now And Next"
        '
        'MixerToolStripMenuItem
        '
        Me.MixerToolStripMenuItem.Name = "MixerToolStripMenuItem"
        Me.MixerToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MixerToolStripMenuItem.Text = "Mixer"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TopicsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'TopicsToolStripMenuItem
        '
        Me.TopicsToolStripMenuItem.Name = "TopicsToolStripMenuItem"
        Me.TopicsToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.TopicsToolStripMenuItem.Text = "Topics"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'tmrDoStuff
        '
        '
        'ttPlaylist
        '
        Me.ttPlaylist.IsBalloon = True
        Me.ttPlaylist.ShowAlways = True
        '
        'tmrFlasher
        '
        Me.tmrFlasher.Enabled = True
        Me.tmrFlasher.Interval = 500
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnInstantPlayer_1, Me.btnInstantPlayer_2, Me.btnInstantPlayer_3, Me.btnInstantPlayer_4, Me.btnInstantPlayer_5, Me.btnInstantPlayer_6, Me.btnInstantPlayer_7, Me.btnInstantPlayer_8, Me.btnInstantPlayer_9, Me.ToolStripSeparator3, Me.btnLoad})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1016, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnInstantPlayer_1
        '
        Me.btnInstantPlayer_1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnInstantPlayer_1.Image = CType(resources.GetObject("btnInstantPlayer_1.Image"), System.Drawing.Image)
        Me.btnInstantPlayer_1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInstantPlayer_1.Name = "btnInstantPlayer_1"
        Me.btnInstantPlayer_1.Size = New System.Drawing.Size(23, 22)
        Me.btnInstantPlayer_1.Text = "1"
        '
        'btnInstantPlayer_2
        '
        Me.btnInstantPlayer_2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnInstantPlayer_2.Image = CType(resources.GetObject("btnInstantPlayer_2.Image"), System.Drawing.Image)
        Me.btnInstantPlayer_2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInstantPlayer_2.Name = "btnInstantPlayer_2"
        Me.btnInstantPlayer_2.Size = New System.Drawing.Size(23, 22)
        Me.btnInstantPlayer_2.Text = "2"
        '
        'btnInstantPlayer_3
        '
        Me.btnInstantPlayer_3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnInstantPlayer_3.Image = CType(resources.GetObject("btnInstantPlayer_3.Image"), System.Drawing.Image)
        Me.btnInstantPlayer_3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInstantPlayer_3.Name = "btnInstantPlayer_3"
        Me.btnInstantPlayer_3.Size = New System.Drawing.Size(23, 22)
        Me.btnInstantPlayer_3.Text = "3"
        '
        'btnInstantPlayer_4
        '
        Me.btnInstantPlayer_4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnInstantPlayer_4.Image = CType(resources.GetObject("btnInstantPlayer_4.Image"), System.Drawing.Image)
        Me.btnInstantPlayer_4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInstantPlayer_4.Name = "btnInstantPlayer_4"
        Me.btnInstantPlayer_4.Size = New System.Drawing.Size(23, 22)
        Me.btnInstantPlayer_4.Text = "4"
        '
        'btnInstantPlayer_5
        '
        Me.btnInstantPlayer_5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnInstantPlayer_5.Image = CType(resources.GetObject("btnInstantPlayer_5.Image"), System.Drawing.Image)
        Me.btnInstantPlayer_5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInstantPlayer_5.Name = "btnInstantPlayer_5"
        Me.btnInstantPlayer_5.Size = New System.Drawing.Size(23, 22)
        Me.btnInstantPlayer_5.Text = "5"
        '
        'btnInstantPlayer_6
        '
        Me.btnInstantPlayer_6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnInstantPlayer_6.Image = CType(resources.GetObject("btnInstantPlayer_6.Image"), System.Drawing.Image)
        Me.btnInstantPlayer_6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInstantPlayer_6.Name = "btnInstantPlayer_6"
        Me.btnInstantPlayer_6.Size = New System.Drawing.Size(23, 22)
        Me.btnInstantPlayer_6.Text = "6"
        '
        'btnInstantPlayer_7
        '
        Me.btnInstantPlayer_7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnInstantPlayer_7.Image = CType(resources.GetObject("btnInstantPlayer_7.Image"), System.Drawing.Image)
        Me.btnInstantPlayer_7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInstantPlayer_7.Name = "btnInstantPlayer_7"
        Me.btnInstantPlayer_7.Size = New System.Drawing.Size(23, 22)
        Me.btnInstantPlayer_7.Text = "7"
        '
        'btnInstantPlayer_8
        '
        Me.btnInstantPlayer_8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnInstantPlayer_8.Image = CType(resources.GetObject("btnInstantPlayer_8.Image"), System.Drawing.Image)
        Me.btnInstantPlayer_8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInstantPlayer_8.Name = "btnInstantPlayer_8"
        Me.btnInstantPlayer_8.Size = New System.Drawing.Size(23, 22)
        Me.btnInstantPlayer_8.Text = "8"
        '
        'btnInstantPlayer_9
        '
        Me.btnInstantPlayer_9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnInstantPlayer_9.Image = CType(resources.GetObject("btnInstantPlayer_9.Image"), System.Drawing.Image)
        Me.btnInstantPlayer_9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInstantPlayer_9.Name = "btnInstantPlayer_9"
        Me.btnInstantPlayer_9.Size = New System.Drawing.Size(23, 22)
        Me.btnInstantPlayer_9.Text = "9"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnLoad
        '
        Me.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(34, 22)
        Me.btnLoad.Text = "Load"
        '
        'scMain
        '
        Me.scMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMain.Location = New System.Drawing.Point(0, 49)
        Me.scMain.Name = "scMain"
        Me.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scMain.Panel1
        '
        Me.scMain.Panel1.Controls.Add(Me.tableTopBar)
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.tableMainLayout)
        Me.scMain.Size = New System.Drawing.Size(1016, 685)
        Me.scMain.SplitterDistance = 104
        Me.scMain.TabIndex = 3
        '
        'tableTopBar
        '
        Me.tableTopBar.ColumnCount = 5
        Me.tableTopBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tableTopBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tableTopBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tableTopBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tableTopBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tableTopBar.Controls.Add(Me.lblTime, 4, 1)
        Me.tableTopBar.Controls.Add(Me.lblToHour, 3, 1)
        Me.tableTopBar.Controls.Add(Me.lblPlaylistRemain, 1, 1)
        Me.tableTopBar.Controls.Add(Me.lblToHourTitle, 3, 0)
        Me.tableTopBar.Controls.Add(Me.lblTrackRemain, 2, 1)
        Me.tableTopBar.Controls.Add(Me.gbMaster, 0, 0)
        Me.tableTopBar.Controls.Add(Me.lblPlaylistRemainTitle, 1, 0)
        Me.tableTopBar.Controls.Add(Me.lblTimeTitle, 4, 0)
        Me.tableTopBar.Controls.Add(Me.lblTrackRemainTitle, 2, 0)
        Me.tableTopBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableTopBar.Location = New System.Drawing.Point(0, 0)
        Me.tableTopBar.Name = "tableTopBar"
        Me.tableTopBar.RowCount = 2
        Me.tableTopBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tableTopBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tableTopBar.Size = New System.Drawing.Size(1016, 104)
        Me.tableTopBar.TabIndex = 0
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Black
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Red
        Me.lblTime.Location = New System.Drawing.Point(865, 31)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(148, 73)
        Me.lblTime.TabIndex = 7
        Me.lblTime.Text = "00:00:00"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblToHour
        '
        Me.lblToHour.AutoSize = True
        Me.lblToHour.BackColor = System.Drawing.Color.Black
        Me.lblToHour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblToHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToHour.ForeColor = System.Drawing.Color.Red
        Me.lblToHour.Location = New System.Drawing.Point(713, 31)
        Me.lblToHour.Name = "lblToHour"
        Me.lblToHour.Size = New System.Drawing.Size(146, 73)
        Me.lblToHour.TabIndex = 8
        Me.lblToHour.Text = "00:00"
        Me.lblToHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlaylistRemain
        '
        Me.lblPlaylistRemain.AutoSize = True
        Me.lblPlaylistRemain.BackColor = System.Drawing.Color.Black
        Me.lblPlaylistRemain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlaylistRemain.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaylistRemain.ForeColor = System.Drawing.Color.Red
        Me.lblPlaylistRemain.Location = New System.Drawing.Point(409, 31)
        Me.lblPlaylistRemain.Name = "lblPlaylistRemain"
        Me.lblPlaylistRemain.Size = New System.Drawing.Size(146, 73)
        Me.lblPlaylistRemain.TabIndex = 9
        Me.lblPlaylistRemain.Text = "00:00"
        Me.lblPlaylistRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblToHourTitle
        '
        Me.lblToHourTitle.AutoSize = True
        Me.lblToHourTitle.BackColor = System.Drawing.Color.Black
        Me.lblToHourTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblToHourTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToHourTitle.ForeColor = System.Drawing.Color.Red
        Me.lblToHourTitle.Location = New System.Drawing.Point(713, 0)
        Me.lblToHourTitle.Name = "lblToHourTitle"
        Me.lblToHourTitle.Size = New System.Drawing.Size(146, 31)
        Me.lblToHourTitle.TabIndex = 3
        Me.lblToHourTitle.Text = "To Hour"
        Me.lblToHourTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTrackRemain
        '
        Me.lblTrackRemain.AutoSize = True
        Me.lblTrackRemain.BackColor = System.Drawing.Color.Black
        Me.lblTrackRemain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTrackRemain.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrackRemain.ForeColor = System.Drawing.Color.Red
        Me.lblTrackRemain.Location = New System.Drawing.Point(561, 31)
        Me.lblTrackRemain.Name = "lblTrackRemain"
        Me.lblTrackRemain.Size = New System.Drawing.Size(146, 73)
        Me.lblTrackRemain.TabIndex = 6
        Me.lblTrackRemain.Text = "00:00"
        Me.lblTrackRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbMaster
        '
        Me.gbMaster.Controls.Add(Me.tableMaster)
        Me.gbMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbMaster.Location = New System.Drawing.Point(3, 3)
        Me.gbMaster.Name = "gbMaster"
        Me.tableTopBar.SetRowSpan(Me.gbMaster, 2)
        Me.gbMaster.Size = New System.Drawing.Size(400, 98)
        Me.gbMaster.TabIndex = 0
        Me.gbMaster.TabStop = False
        Me.gbMaster.Text = "Master"
        '
        'tableMaster
        '
        Me.tableMaster.ColumnCount = 4
        Me.tableMaster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tableMaster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tableMaster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tableMaster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tableMaster.Controls.Add(Me.btnStop, 0, 0)
        Me.tableMaster.Controls.Add(Me.btnPlay, 0, 0)
        Me.tableMaster.Controls.Add(Me.btnAutomate, 0, 0)
        Me.tableMaster.Controls.Add(Me.btnNext, 3, 0)
        Me.tableMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableMaster.Location = New System.Drawing.Point(3, 16)
        Me.tableMaster.Name = "tableMaster"
        Me.tableMaster.RowCount = 1
        Me.tableMaster.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableMaster.Size = New System.Drawing.Size(394, 79)
        Me.tableMaster.TabIndex = 0
        '
        'btnStop
        '
        Me.btnStop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStop.Location = New System.Drawing.Point(199, 3)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(92, 73)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Stop"
        Me.btnStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPlay.Image = CType(resources.GetObject("btnPlay.Image"), System.Drawing.Image)
        Me.btnPlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPlay.Location = New System.Drawing.Point(101, 3)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(92, 73)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "Play"
        Me.btnPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnAutomate
        '
        Me.btnAutomate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAutomate.Image = CType(resources.GetObject("btnAutomate.Image"), System.Drawing.Image)
        Me.btnAutomate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAutomate.Location = New System.Drawing.Point(3, 3)
        Me.btnAutomate.Name = "btnAutomate"
        Me.btnAutomate.Size = New System.Drawing.Size(92, 73)
        Me.btnAutomate.TabIndex = 1
        Me.btnAutomate.Text = "Automate"
        Me.btnAutomate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAutomate.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNext.Location = New System.Drawing.Point(297, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(94, 73)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next Item"
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblPlaylistRemainTitle
        '
        Me.lblPlaylistRemainTitle.AutoSize = True
        Me.lblPlaylistRemainTitle.BackColor = System.Drawing.Color.Black
        Me.lblPlaylistRemainTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlaylistRemainTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaylistRemainTitle.ForeColor = System.Drawing.Color.Red
        Me.lblPlaylistRemainTitle.Location = New System.Drawing.Point(409, 0)
        Me.lblPlaylistRemainTitle.Name = "lblPlaylistRemainTitle"
        Me.lblPlaylistRemainTitle.Size = New System.Drawing.Size(146, 31)
        Me.lblPlaylistRemainTitle.TabIndex = 1
        Me.lblPlaylistRemainTitle.Text = "Playlist Remain"
        Me.lblPlaylistRemainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeTitle
        '
        Me.lblTimeTitle.AutoSize = True
        Me.lblTimeTitle.BackColor = System.Drawing.Color.Black
        Me.lblTimeTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTimeTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTimeTitle.Location = New System.Drawing.Point(865, 0)
        Me.lblTimeTitle.Name = "lblTimeTitle"
        Me.lblTimeTitle.Size = New System.Drawing.Size(148, 31)
        Me.lblTimeTitle.TabIndex = 5
        Me.lblTimeTitle.Text = "Mon, 1 Sep 2007"
        Me.lblTimeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTrackRemainTitle
        '
        Me.lblTrackRemainTitle.AutoSize = True
        Me.lblTrackRemainTitle.BackColor = System.Drawing.Color.Black
        Me.lblTrackRemainTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTrackRemainTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrackRemainTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTrackRemainTitle.Location = New System.Drawing.Point(561, 0)
        Me.lblTrackRemainTitle.Name = "lblTrackRemainTitle"
        Me.lblTrackRemainTitle.Size = New System.Drawing.Size(146, 31)
        Me.lblTrackRemainTitle.TabIndex = 4
        Me.lblTrackRemainTitle.Text = "Track Remain"
        Me.lblTrackRemainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tableMainLayout
        '
        Me.tableMainLayout.ColumnCount = 3
        Me.tableMainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableMainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tableMainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tableMainLayout.Controls.Add(Me.tableLeftPanel, 0, 0)
        Me.tableMainLayout.Controls.Add(Me.tablePlaylist, 1, 0)
        Me.tableMainLayout.Controls.Add(Me.tabDisplay, 2, 0)
        Me.tableMainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableMainLayout.Location = New System.Drawing.Point(0, 0)
        Me.tableMainLayout.Name = "tableMainLayout"
        Me.tableMainLayout.RowCount = 1
        Me.tableMainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableMainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableMainLayout.Size = New System.Drawing.Size(1016, 577)
        Me.tableMainLayout.TabIndex = 0
        '
        'tableLeftPanel
        '
        Me.tableLeftPanel.ColumnCount = 3
        Me.tableLeftPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLeftPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tableLeftPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLeftPanel.Controls.Add(Me.btnClear, 1, 4)
        Me.tableLeftPanel.Controls.Add(Me.btnUp, 1, 0)
        Me.tableLeftPanel.Controls.Add(Me.btnDown, 1, 1)
        Me.tableLeftPanel.Controls.Add(Me.btnAdd, 1, 2)
        Me.tableLeftPanel.Controls.Add(Me.btnRemove, 1, 3)
        Me.tableLeftPanel.Controls.Add(Me.btnBreakAfter, 1, 5)
        Me.tableLeftPanel.Controls.Add(Me.btnPlayToHour, 1, 6)
        Me.tableLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLeftPanel.Location = New System.Drawing.Point(3, 3)
        Me.tableLeftPanel.Name = "tableLeftPanel"
        Me.tableLeftPanel.RowCount = 7
        Me.tableLeftPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tableLeftPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tableLeftPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tableLeftPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tableLeftPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tableLeftPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tableLeftPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tableLeftPanel.Size = New System.Drawing.Size(95, 571)
        Me.tableLeftPanel.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClear.Location = New System.Drawing.Point(12, 327)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(70, 75)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUp.Location = New System.Drawing.Point(12, 3)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(70, 75)
        Me.btnUp.TabIndex = 11
        Me.btnUp.Text = "Up"
        Me.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDown.Location = New System.Drawing.Point(12, 84)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(70, 75)
        Me.btnDown.TabIndex = 12
        Me.btnDown.Text = "Down"
        Me.btnDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdd.Location = New System.Drawing.Point(12, 165)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 75)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemove.Location = New System.Drawing.Point(12, 246)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(70, 75)
        Me.btnRemove.TabIndex = 14
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnBreakAfter
        '
        Me.btnBreakAfter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBreakAfter.Location = New System.Drawing.Point(12, 408)
        Me.btnBreakAfter.Name = "btnBreakAfter"
        Me.btnBreakAfter.Size = New System.Drawing.Size(70, 75)
        Me.btnBreakAfter.TabIndex = 16
        Me.btnBreakAfter.Text = "Break After"
        Me.btnBreakAfter.UseVisualStyleBackColor = True
        '
        'btnPlayToHour
        '
        Me.btnPlayToHour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPlayToHour.Image = CType(resources.GetObject("btnPlayToHour.Image"), System.Drawing.Image)
        Me.btnPlayToHour.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPlayToHour.Location = New System.Drawing.Point(12, 489)
        Me.btnPlayToHour.Name = "btnPlayToHour"
        Me.btnPlayToHour.Size = New System.Drawing.Size(70, 79)
        Me.btnPlayToHour.TabIndex = 18
        Me.btnPlayToHour.Text = "Backtime"
        Me.btnPlayToHour.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPlayToHour.UseVisualStyleBackColor = True
        '
        'tablePlaylist
        '
        Me.tablePlaylist.ColumnCount = 2
        Me.tablePlaylist.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablePlaylist.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tablePlaylist.Controls.Add(Me.tablePlaylist4, 0, 3)
        Me.tablePlaylist.Controls.Add(Me.scrollPlaylist, 1, 0)
        Me.tablePlaylist.Controls.Add(Me.tablePlaylist1, 0, 0)
        Me.tablePlaylist.Controls.Add(Me.tablePlaylist2, 0, 1)
        Me.tablePlaylist.Controls.Add(Me.tablePlaylist3, 0, 2)
        Me.tablePlaylist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablePlaylist.Location = New System.Drawing.Point(104, 3)
        Me.tablePlaylist.Name = "tablePlaylist"
        Me.tablePlaylist.RowCount = 4
        Me.tablePlaylist.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlaylist.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlaylist.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlaylist.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlaylist.Size = New System.Drawing.Size(603, 571)
        Me.tablePlaylist.TabIndex = 2
        '
        'tablePlaylist4
        '
        Me.tablePlaylist4.BackColor = System.Drawing.Color.White
        Me.tablePlaylist4.ColumnCount = 5
        Me.tablePlaylist4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tablePlaylist4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist4.Controls.Add(Me.pbPlaylist4, 0, 1)
        Me.tablePlaylist4.Controls.Add(Me.lblRemain4, 4, 0)
        Me.tablePlaylist4.Controls.Add(Me.lblPlaylistPlayed4, 3, 0)
        Me.tablePlaylist4.Controls.Add(Me.lblLength4, 2, 0)
        Me.tablePlaylist4.Controls.Add(Me.lblPlaylistNumber4, 0, 0)
        Me.tablePlaylist4.Controls.Add(Me.lblPlaylistArtistTitleInfo4, 1, 0)
        Me.tablePlaylist4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablePlaylist4.Location = New System.Drawing.Point(3, 429)
        Me.tablePlaylist4.Name = "tablePlaylist4"
        Me.tablePlaylist4.RowCount = 2
        Me.tablePlaylist4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tablePlaylist4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tablePlaylist4.Size = New System.Drawing.Size(577, 139)
        Me.tablePlaylist4.TabIndex = 4
        '
        'pbPlaylist4
        '
        Me.pbPlaylist4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbPlaylist4.Location = New System.Drawing.Point(60, 114)
        Me.pbPlaylist4.Name = "pbPlaylist4"
        Me.pbPlaylist4.Size = New System.Drawing.Size(340, 22)
        Me.pbPlaylist4.TabIndex = 6
        Me.pbPlaylist4.Visible = False
        '
        'lblRemain4
        '
        Me.lblRemain4.AutoSize = True
        Me.lblRemain4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemain4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRemain4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemain4.Location = New System.Drawing.Point(520, 0)
        Me.lblRemain4.Name = "lblRemain4"
        Me.tablePlaylist4.SetRowSpan(Me.lblRemain4, 2)
        Me.lblRemain4.Size = New System.Drawing.Size(54, 139)
        Me.lblRemain4.TabIndex = 4
        Me.lblRemain4.Text = "00:00"
        Me.lblRemain4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlaylistPlayed4
        '
        Me.lblPlaylistPlayed4.AutoSize = True
        Me.lblPlaylistPlayed4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlaylistPlayed4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlaylistPlayed4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaylistPlayed4.Location = New System.Drawing.Point(463, 0)
        Me.lblPlaylistPlayed4.Name = "lblPlaylistPlayed4"
        Me.tablePlaylist4.SetRowSpan(Me.lblPlaylistPlayed4, 2)
        Me.lblPlaylistPlayed4.Size = New System.Drawing.Size(51, 139)
        Me.lblPlaylistPlayed4.TabIndex = 3
        Me.lblPlaylistPlayed4.Text = "00:00"
        Me.lblPlaylistPlayed4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLength4
        '
        Me.lblLength4.AutoSize = True
        Me.lblLength4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLength4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLength4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength4.Location = New System.Drawing.Point(406, 0)
        Me.lblLength4.Name = "lblLength4"
        Me.tablePlaylist4.SetRowSpan(Me.lblLength4, 2)
        Me.lblLength4.Size = New System.Drawing.Size(51, 139)
        Me.lblLength4.TabIndex = 2
        Me.lblLength4.Text = "00:00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:00"
        Me.lblLength4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlaylistNumber4
        '
        Me.lblPlaylistNumber4.AutoSize = True
        Me.lblPlaylistNumber4.BackColor = System.Drawing.Color.White
        Me.lblPlaylistNumber4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlaylistNumber4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlaylistNumber4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaylistNumber4.Location = New System.Drawing.Point(3, 0)
        Me.lblPlaylistNumber4.Name = "lblPlaylistNumber4"
        Me.tablePlaylist4.SetRowSpan(Me.lblPlaylistNumber4, 2)
        Me.lblPlaylistNumber4.Size = New System.Drawing.Size(51, 139)
        Me.lblPlaylistNumber4.TabIndex = 0
        Me.lblPlaylistNumber4.Text = "1"
        Me.lblPlaylistNumber4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlaylistArtistTitleInfo4
        '
        Me.lblPlaylistArtistTitleInfo4.AutoSize = True
        Me.lblPlaylistArtistTitleInfo4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlaylistArtistTitleInfo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaylistArtistTitleInfo4.Location = New System.Drawing.Point(60, 0)
        Me.lblPlaylistArtistTitleInfo4.Name = "lblPlaylistArtistTitleInfo4"
        Me.lblPlaylistArtistTitleInfo4.Size = New System.Drawing.Size(340, 111)
        Me.lblPlaylistArtistTitleInfo4.TabIndex = 1
        Me.lblPlaylistArtistTitleInfo4.Text = "Artist" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Title" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Info"
        Me.lblPlaylistArtistTitleInfo4.UseMnemonic = False
        '
        'scrollPlaylist
        '
        Me.scrollPlaylist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scrollPlaylist.LargeChange = 1
        Me.scrollPlaylist.Location = New System.Drawing.Point(583, 0)
        Me.scrollPlaylist.Maximum = 0
        Me.scrollPlaylist.Name = "scrollPlaylist"
        Me.tablePlaylist.SetRowSpan(Me.scrollPlaylist, 4)
        Me.scrollPlaylist.Size = New System.Drawing.Size(20, 571)
        Me.scrollPlaylist.TabIndex = 0
        '
        'tablePlaylist1
        '
        Me.tablePlaylist1.BackColor = System.Drawing.Color.White
        Me.tablePlaylist1.ColumnCount = 5
        Me.tablePlaylist1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tablePlaylist1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist1.Controls.Add(Me.lblRemain1, 4, 0)
        Me.tablePlaylist1.Controls.Add(Me.lblPlaylistPlayed1, 3, 0)
        Me.tablePlaylist1.Controls.Add(Me.lblLength1, 2, 0)
        Me.tablePlaylist1.Controls.Add(Me.lblPlaylistNumber1, 0, 0)
        Me.tablePlaylist1.Controls.Add(Me.lblPlaylistArtistTitleInfo1, 1, 0)
        Me.tablePlaylist1.Controls.Add(Me.pbPlaylist1, 1, 1)
        Me.tablePlaylist1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablePlaylist1.Location = New System.Drawing.Point(3, 3)
        Me.tablePlaylist1.Name = "tablePlaylist1"
        Me.tablePlaylist1.RowCount = 2
        Me.tablePlaylist1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tablePlaylist1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tablePlaylist1.Size = New System.Drawing.Size(577, 136)
        Me.tablePlaylist1.TabIndex = 1
        '
        'lblRemain1
        '
        Me.lblRemain1.AutoSize = True
        Me.lblRemain1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemain1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRemain1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemain1.Location = New System.Drawing.Point(520, 0)
        Me.lblRemain1.Name = "lblRemain1"
        Me.tablePlaylist1.SetRowSpan(Me.lblRemain1, 2)
        Me.lblRemain1.Size = New System.Drawing.Size(54, 136)
        Me.lblRemain1.TabIndex = 4
        Me.lblRemain1.Text = "00:00"
        Me.lblRemain1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlaylistPlayed1
        '
        Me.lblPlaylistPlayed1.AutoSize = True
        Me.lblPlaylistPlayed1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlaylistPlayed1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlaylistPlayed1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaylistPlayed1.Location = New System.Drawing.Point(463, 0)
        Me.lblPlaylistPlayed1.Name = "lblPlaylistPlayed1"
        Me.tablePlaylist1.SetRowSpan(Me.lblPlaylistPlayed1, 2)
        Me.lblPlaylistPlayed1.Size = New System.Drawing.Size(51, 136)
        Me.lblPlaylistPlayed1.TabIndex = 3
        Me.lblPlaylistPlayed1.Text = "00:00"
        Me.lblPlaylistPlayed1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLength1
        '
        Me.lblLength1.AutoSize = True
        Me.lblLength1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLength1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLength1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength1.Location = New System.Drawing.Point(406, 0)
        Me.lblLength1.Name = "lblLength1"
        Me.tablePlaylist1.SetRowSpan(Me.lblLength1, 2)
        Me.lblLength1.Size = New System.Drawing.Size(51, 136)
        Me.lblLength1.TabIndex = 2
        Me.lblLength1.Text = "00:00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:00"
        Me.lblLength1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlaylistNumber1
        '
        Me.lblPlaylistNumber1.AutoSize = True
        Me.lblPlaylistNumber1.BackColor = System.Drawing.Color.White
        Me.lblPlaylistNumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlaylistNumber1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlaylistNumber1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaylistNumber1.Location = New System.Drawing.Point(3, 0)
        Me.lblPlaylistNumber1.Name = "lblPlaylistNumber1"
        Me.tablePlaylist1.SetRowSpan(Me.lblPlaylistNumber1, 2)
        Me.lblPlaylistNumber1.Size = New System.Drawing.Size(51, 136)
        Me.lblPlaylistNumber1.TabIndex = 0
        Me.lblPlaylistNumber1.Text = "1"
        Me.lblPlaylistNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlaylistArtistTitleInfo1
        '
        Me.lblPlaylistArtistTitleInfo1.AutoSize = True
        Me.lblPlaylistArtistTitleInfo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlaylistArtistTitleInfo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaylistArtistTitleInfo1.Location = New System.Drawing.Point(60, 0)
        Me.lblPlaylistArtistTitleInfo1.Name = "lblPlaylistArtistTitleInfo1"
        Me.lblPlaylistArtistTitleInfo1.Size = New System.Drawing.Size(340, 108)
        Me.lblPlaylistArtistTitleInfo1.TabIndex = 1
        Me.lblPlaylistArtistTitleInfo1.Text = "Artist" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Title" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Info"
        Me.lblPlaylistArtistTitleInfo1.UseMnemonic = False
        '
        'pbPlaylist1
        '
        Me.pbPlaylist1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbPlaylist1.Location = New System.Drawing.Point(60, 111)
        Me.pbPlaylist1.Name = "pbPlaylist1"
        Me.pbPlaylist1.Size = New System.Drawing.Size(340, 22)
        Me.pbPlaylist1.TabIndex = 5
        Me.pbPlaylist1.Visible = False
        '
        'tablePlaylist2
        '
        Me.tablePlaylist2.BackColor = System.Drawing.Color.White
        Me.tablePlaylist2.ColumnCount = 5
        Me.tablePlaylist2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tablePlaylist2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist2.Controls.Add(Me.pbPlaylist2, 0, 1)
        Me.tablePlaylist2.Controls.Add(Me.lblRemain2, 4, 0)
        Me.tablePlaylist2.Controls.Add(Me.lblPlaylistPlayed2, 3, 0)
        Me.tablePlaylist2.Controls.Add(Me.lblLength2, 2, 0)
        Me.tablePlaylist2.Controls.Add(Me.lblPlaylistNumber2, 0, 0)
        Me.tablePlaylist2.Controls.Add(Me.lblPlaylistArtistTitleInfo2, 1, 0)
        Me.tablePlaylist2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablePlaylist2.Location = New System.Drawing.Point(3, 145)
        Me.tablePlaylist2.Name = "tablePlaylist2"
        Me.tablePlaylist2.RowCount = 2
        Me.tablePlaylist2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tablePlaylist2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tablePlaylist2.Size = New System.Drawing.Size(577, 136)
        Me.tablePlaylist2.TabIndex = 2
        '
        'pbPlaylist2
        '
        Me.pbPlaylist2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbPlaylist2.Location = New System.Drawing.Point(60, 111)
        Me.pbPlaylist2.Name = "pbPlaylist2"
        Me.pbPlaylist2.Size = New System.Drawing.Size(340, 22)
        Me.pbPlaylist2.TabIndex = 6
        Me.pbPlaylist2.Visible = False
        '
        'lblRemain2
        '
        Me.lblRemain2.AutoSize = True
        Me.lblRemain2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemain2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRemain2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemain2.Location = New System.Drawing.Point(520, 0)
        Me.lblRemain2.Name = "lblRemain2"
        Me.tablePlaylist2.SetRowSpan(Me.lblRemain2, 2)
        Me.lblRemain2.Size = New System.Drawing.Size(54, 136)
        Me.lblRemain2.TabIndex = 4
        Me.lblRemain2.Text = "00:00"
        Me.lblRemain2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlaylistPlayed2
        '
        Me.lblPlaylistPlayed2.AutoSize = True
        Me.lblPlaylistPlayed2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlaylistPlayed2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlaylistPlayed2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaylistPlayed2.Location = New System.Drawing.Point(463, 0)
        Me.lblPlaylistPlayed2.Name = "lblPlaylistPlayed2"
        Me.tablePlaylist2.SetRowSpan(Me.lblPlaylistPlayed2, 2)
        Me.lblPlaylistPlayed2.Size = New System.Drawing.Size(51, 136)
        Me.lblPlaylistPlayed2.TabIndex = 3
        Me.lblPlaylistPlayed2.Text = "00:00"
        Me.lblPlaylistPlayed2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLength2
        '
        Me.lblLength2.AutoSize = True
        Me.lblLength2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLength2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLength2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength2.Location = New System.Drawing.Point(406, 0)
        Me.lblLength2.Name = "lblLength2"
        Me.tablePlaylist2.SetRowSpan(Me.lblLength2, 2)
        Me.lblLength2.Size = New System.Drawing.Size(51, 136)
        Me.lblLength2.TabIndex = 2
        Me.lblLength2.Text = "00:00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:00"
        Me.lblLength2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlaylistNumber2
        '
        Me.lblPlaylistNumber2.AutoSize = True
        Me.lblPlaylistNumber2.BackColor = System.Drawing.Color.White
        Me.lblPlaylistNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlaylistNumber2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlaylistNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaylistNumber2.Location = New System.Drawing.Point(3, 0)
        Me.lblPlaylistNumber2.Name = "lblPlaylistNumber2"
        Me.tablePlaylist2.SetRowSpan(Me.lblPlaylistNumber2, 2)
        Me.lblPlaylistNumber2.Size = New System.Drawing.Size(51, 136)
        Me.lblPlaylistNumber2.TabIndex = 0
        Me.lblPlaylistNumber2.Text = "1"
        Me.lblPlaylistNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlaylistArtistTitleInfo2
        '
        Me.lblPlaylistArtistTitleInfo2.AutoSize = True
        Me.lblPlaylistArtistTitleInfo2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlaylistArtistTitleInfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaylistArtistTitleInfo2.Location = New System.Drawing.Point(60, 0)
        Me.lblPlaylistArtistTitleInfo2.Name = "lblPlaylistArtistTitleInfo2"
        Me.lblPlaylistArtistTitleInfo2.Size = New System.Drawing.Size(340, 108)
        Me.lblPlaylistArtistTitleInfo2.TabIndex = 1
        Me.lblPlaylistArtistTitleInfo2.Text = "Artist" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Title" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Info"
        Me.lblPlaylistArtistTitleInfo2.UseMnemonic = False
        '
        'tablePlaylist3
        '
        Me.tablePlaylist3.BackColor = System.Drawing.Color.White
        Me.tablePlaylist3.ColumnCount = 5
        Me.tablePlaylist3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tablePlaylist3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tablePlaylist3.Controls.Add(Me.pbPlaylist3, 0, 1)
        Me.tablePlaylist3.Controls.Add(Me.lblRemain3, 4, 0)
        Me.tablePlaylist3.Controls.Add(Me.lblPlaylistPlayed3, 3, 0)
        Me.tablePlaylist3.Controls.Add(Me.lblLength3, 2, 0)
        Me.tablePlaylist3.Controls.Add(Me.lblPlaylistNumber3, 0, 0)
        Me.tablePlaylist3.Controls.Add(Me.lblPlaylistArtistTitleInfo3, 1, 0)
        Me.tablePlaylist3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablePlaylist3.Location = New System.Drawing.Point(3, 287)
        Me.tablePlaylist3.Name = "tablePlaylist3"
        Me.tablePlaylist3.RowCount = 2
        Me.tablePlaylist3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tablePlaylist3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tablePlaylist3.Size = New System.Drawing.Size(577, 136)
        Me.tablePlaylist3.TabIndex = 3
        '
        'pbPlaylist3
        '
        Me.pbPlaylist3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbPlaylist3.Location = New System.Drawing.Point(60, 111)
        Me.pbPlaylist3.Name = "pbPlaylist3"
        Me.pbPlaylist3.Size = New System.Drawing.Size(340, 22)
        Me.pbPlaylist3.TabIndex = 6
        Me.pbPlaylist3.Visible = False
        '
        'lblRemain3
        '
        Me.lblRemain3.AutoSize = True
        Me.lblRemain3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemain3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRemain3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemain3.Location = New System.Drawing.Point(520, 0)
        Me.lblRemain3.Name = "lblRemain3"
        Me.tablePlaylist3.SetRowSpan(Me.lblRemain3, 2)
        Me.lblRemain3.Size = New System.Drawing.Size(54, 136)
        Me.lblRemain3.TabIndex = 4
        Me.lblRemain3.Text = "00:00"
        Me.lblRemain3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlaylistPlayed3
        '
        Me.lblPlaylistPlayed3.AutoSize = True
        Me.lblPlaylistPlayed3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlaylistPlayed3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlaylistPlayed3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaylistPlayed3.Location = New System.Drawing.Point(463, 0)
        Me.lblPlaylistPlayed3.Name = "lblPlaylistPlayed3"
        Me.tablePlaylist3.SetRowSpan(Me.lblPlaylistPlayed3, 2)
        Me.lblPlaylistPlayed3.Size = New System.Drawing.Size(51, 136)
        Me.lblPlaylistPlayed3.TabIndex = 3
        Me.lblPlaylistPlayed3.Text = "00:00"
        Me.lblPlaylistPlayed3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLength3
        '
        Me.lblLength3.AutoSize = True
        Me.lblLength3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLength3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLength3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength3.Location = New System.Drawing.Point(406, 0)
        Me.lblLength3.Name = "lblLength3"
        Me.tablePlaylist3.SetRowSpan(Me.lblLength3, 2)
        Me.lblLength3.Size = New System.Drawing.Size(51, 136)
        Me.lblLength3.TabIndex = 2
        Me.lblLength3.Text = "00:00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:00"
        Me.lblLength3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlaylistNumber3
        '
        Me.lblPlaylistNumber3.AutoSize = True
        Me.lblPlaylistNumber3.BackColor = System.Drawing.Color.White
        Me.lblPlaylistNumber3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlaylistNumber3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlaylistNumber3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaylistNumber3.Location = New System.Drawing.Point(3, 0)
        Me.lblPlaylistNumber3.Name = "lblPlaylistNumber3"
        Me.tablePlaylist3.SetRowSpan(Me.lblPlaylistNumber3, 2)
        Me.lblPlaylistNumber3.Size = New System.Drawing.Size(51, 136)
        Me.lblPlaylistNumber3.TabIndex = 0
        Me.lblPlaylistNumber3.Text = "1"
        Me.lblPlaylistNumber3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlaylistArtistTitleInfo3
        '
        Me.lblPlaylistArtistTitleInfo3.AutoSize = True
        Me.lblPlaylistArtistTitleInfo3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlaylistArtistTitleInfo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaylistArtistTitleInfo3.Location = New System.Drawing.Point(60, 0)
        Me.lblPlaylistArtistTitleInfo3.Name = "lblPlaylistArtistTitleInfo3"
        Me.lblPlaylistArtistTitleInfo3.Size = New System.Drawing.Size(340, 108)
        Me.lblPlaylistArtistTitleInfo3.TabIndex = 1
        Me.lblPlaylistArtistTitleInfo3.Text = "Artist" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Title" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Info"
        Me.lblPlaylistArtistTitleInfo3.UseMnemonic = False
        '
        'tabDisplay
        '
        Me.tabDisplay.Controls.Add(Me.tabPlayedItems)
        Me.tabDisplay.Controls.Add(Me.tabPlayers)
        Me.tabDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabDisplay.Location = New System.Drawing.Point(713, 3)
        Me.tabDisplay.Name = "tabDisplay"
        Me.tabDisplay.SelectedIndex = 0
        Me.tabDisplay.Size = New System.Drawing.Size(300, 571)
        Me.tabDisplay.TabIndex = 3
        '
        'tabPlayedItems
        '
        Me.tabPlayedItems.Controls.Add(Me.TableLayoutPanel1)
        Me.tabPlayedItems.Location = New System.Drawing.Point(4, 25)
        Me.tabPlayedItems.Name = "tabPlayedItems"
        Me.tabPlayedItems.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPlayedItems.Size = New System.Drawing.Size(292, 542)
        Me.tabPlayedItems.TabIndex = 1
        Me.tabPlayedItems.Text = "Played Items"
        Me.tabPlayedItems.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbPlayedItems, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClearPlayed, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(286, 536)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbPlayedItems
        '
        Me.lbPlayedItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbPlayedItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPlayedItems.FormattingEnabled = True
        Me.lbPlayedItems.ItemHeight = 16
        Me.lbPlayedItems.Location = New System.Drawing.Point(3, 3)
        Me.lbPlayedItems.Name = "lbPlayedItems"
        Me.lbPlayedItems.Size = New System.Drawing.Size(280, 468)
        Me.lbPlayedItems.TabIndex = 0
        '
        'btnClearPlayed
        '
        Me.btnClearPlayed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClearPlayed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearPlayed.Location = New System.Drawing.Point(3, 485)
        Me.btnClearPlayed.Name = "btnClearPlayed"
        Me.btnClearPlayed.Size = New System.Drawing.Size(280, 48)
        Me.btnClearPlayed.TabIndex = 1
        Me.btnClearPlayed.Text = "Clear Played Items"
        Me.btnClearPlayed.UseVisualStyleBackColor = True
        '
        'tabPlayers
        '
        Me.tabPlayers.Controls.Add(Me.tablePlayers)
        Me.tabPlayers.Location = New System.Drawing.Point(4, 25)
        Me.tabPlayers.Name = "tabPlayers"
        Me.tabPlayers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPlayers.Size = New System.Drawing.Size(292, 542)
        Me.tabPlayers.TabIndex = 0
        Me.tabPlayers.Text = "Players"
        Me.tabPlayers.UseVisualStyleBackColor = True
        '
        'tablePlayers
        '
        Me.tablePlayers.ColumnCount = 1
        Me.tablePlayers.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablePlayers.Controls.Add(Me.gbPlayer4, 0, 3)
        Me.tablePlayers.Controls.Add(Me.gbPlayer2, 0, 1)
        Me.tablePlayers.Controls.Add(Me.gbPlayer1, 0, 0)
        Me.tablePlayers.Controls.Add(Me.gbPlayer3, 0, 2)
        Me.tablePlayers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablePlayers.Location = New System.Drawing.Point(3, 3)
        Me.tablePlayers.Name = "tablePlayers"
        Me.tablePlayers.RowCount = 4
        Me.tablePlayers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tablePlayers.Size = New System.Drawing.Size(286, 536)
        Me.tablePlayers.TabIndex = 1
        '
        'gbPlayer4
        '
        Me.gbPlayer4.BackColor = System.Drawing.Color.Red
        Me.gbPlayer4.Controls.Add(Me.tablePlayer4)
        Me.gbPlayer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbPlayer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPlayer4.Location = New System.Drawing.Point(3, 405)
        Me.gbPlayer4.Name = "gbPlayer4"
        Me.gbPlayer4.Size = New System.Drawing.Size(280, 128)
        Me.gbPlayer4.TabIndex = 16
        Me.gbPlayer4.TabStop = False
        Me.gbPlayer4.Text = "Player 4"
        '
        'tablePlayer4
        '
        Me.tablePlayer4.ColumnCount = 4
        Me.tablePlayer4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer4.Controls.Add(Me.btnStop4, 3, 2)
        Me.tablePlayer4.Controls.Add(Me.lblArtist4, 0, 0)
        Me.tablePlayer4.Controls.Add(Me.btnPlay4, 2, 2)
        Me.tablePlayer4.Controls.Add(Me.lblTitle4, 0, 1)
        Me.tablePlayer4.Controls.Add(Me.prgPlayer4, 0, 4)
        Me.tablePlayer4.Controls.Add(Me.lblTimeLeft4, 0, 2)
        Me.tablePlayer4.Controls.Add(Me.tbPlayed4, 1, 3)
        Me.tablePlayer4.Controls.Add(Me.tbTitle4, 1, 1)
        Me.tablePlayer4.Controls.Add(Me.tbTimeLeft4, 1, 2)
        Me.tablePlayer4.Controls.Add(Me.lblPlayed4, 0, 3)
        Me.tablePlayer4.Controls.Add(Me.tbArtist4, 1, 0)
        Me.tablePlayer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablePlayer4.Location = New System.Drawing.Point(3, 16)
        Me.tablePlayer4.Name = "tablePlayer4"
        Me.tablePlayer4.RowCount = 5
        Me.tablePlayer4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tablePlayer4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tablePlayer4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5!))
        Me.tablePlayer4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5!))
        Me.tablePlayer4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tablePlayer4.Size = New System.Drawing.Size(274, 109)
        Me.tablePlayer4.TabIndex = 35
        '
        'btnStop4
        '
        Me.btnStop4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStop4.Image = CType(resources.GetObject("btnStop4.Image"), System.Drawing.Image)
        Me.btnStop4.Location = New System.Drawing.Point(207, 45)
        Me.btnStop4.Name = "btnStop4"
        Me.tablePlayer4.SetRowSpan(Me.btnStop4, 2)
        Me.btnStop4.Size = New System.Drawing.Size(64, 42)
        Me.btnStop4.TabIndex = 52
        Me.btnStop4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStop4.UseVisualStyleBackColor = True
        '
        'lblArtist4
        '
        Me.lblArtist4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblArtist4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtist4.Location = New System.Drawing.Point(3, 0)
        Me.lblArtist4.Name = "lblArtist4"
        Me.lblArtist4.Size = New System.Drawing.Size(62, 21)
        Me.lblArtist4.TabIndex = 12
        Me.lblArtist4.Text = "Artist:"
        Me.lblArtist4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnPlay4
        '
        Me.btnPlay4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPlay4.Image = CType(resources.GetObject("btnPlay4.Image"), System.Drawing.Image)
        Me.btnPlay4.Location = New System.Drawing.Point(139, 45)
        Me.btnPlay4.Name = "btnPlay4"
        Me.tablePlayer4.SetRowSpan(Me.btnPlay4, 2)
        Me.btnPlay4.Size = New System.Drawing.Size(62, 42)
        Me.btnPlay4.TabIndex = 51
        Me.btnPlay4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPlay4.UseVisualStyleBackColor = True
        '
        'lblTitle4
        '
        Me.lblTitle4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle4.Location = New System.Drawing.Point(3, 21)
        Me.lblTitle4.Name = "lblTitle4"
        Me.lblTitle4.Size = New System.Drawing.Size(62, 21)
        Me.lblTitle4.TabIndex = 14
        Me.lblTitle4.Text = "Title:"
        Me.lblTitle4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'prgPlayer4
        '
        Me.tablePlayer4.SetColumnSpan(Me.prgPlayer4, 4)
        Me.prgPlayer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prgPlayer4.Location = New System.Drawing.Point(3, 93)
        Me.prgPlayer4.Name = "prgPlayer4"
        Me.prgPlayer4.Size = New System.Drawing.Size(268, 13)
        Me.prgPlayer4.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgPlayer4.TabIndex = 53
        '
        'lblTimeLeft4
        '
        Me.lblTimeLeft4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTimeLeft4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft4.Location = New System.Drawing.Point(3, 42)
        Me.lblTimeLeft4.Name = "lblTimeLeft4"
        Me.lblTimeLeft4.Size = New System.Drawing.Size(62, 24)
        Me.lblTimeLeft4.TabIndex = 8
        Me.lblTimeLeft4.Text = "Time Left:"
        Me.lblTimeLeft4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbPlayed4
        '
        Me.tbPlayed4.BackColor = System.Drawing.Color.Black
        Me.tbPlayed4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbPlayed4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPlayed4.ForeColor = System.Drawing.Color.Red
        Me.tbPlayed4.Location = New System.Drawing.Point(71, 69)
        Me.tbPlayed4.Name = "tbPlayed4"
        Me.tbPlayed4.Size = New System.Drawing.Size(62, 20)
        Me.tbPlayed4.TabIndex = 50
        Me.tbPlayed4.Text = "00:00"
        '
        'tbTitle4
        '
        Me.tablePlayer4.SetColumnSpan(Me.tbTitle4, 3)
        Me.tbTitle4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbTitle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTitle4.Location = New System.Drawing.Point(71, 24)
        Me.tbTitle4.Name = "tbTitle4"
        Me.tbTitle4.Size = New System.Drawing.Size(200, 20)
        Me.tbTitle4.TabIndex = 48
        '
        'tbTimeLeft4
        '
        Me.tbTimeLeft4.BackColor = System.Drawing.Color.Black
        Me.tbTimeLeft4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbTimeLeft4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTimeLeft4.ForeColor = System.Drawing.Color.Red
        Me.tbTimeLeft4.Location = New System.Drawing.Point(71, 45)
        Me.tbTimeLeft4.Name = "tbTimeLeft4"
        Me.tbTimeLeft4.Size = New System.Drawing.Size(62, 20)
        Me.tbTimeLeft4.TabIndex = 49
        Me.tbTimeLeft4.Text = "00:00"
        '
        'lblPlayed4
        '
        Me.lblPlayed4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlayed4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayed4.Location = New System.Drawing.Point(3, 66)
        Me.lblPlayed4.Name = "lblPlayed4"
        Me.lblPlayed4.Size = New System.Drawing.Size(62, 24)
        Me.lblPlayed4.TabIndex = 10
        Me.lblPlayed4.Text = "Played:"
        Me.lblPlayed4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbArtist4
        '
        Me.tablePlayer4.SetColumnSpan(Me.tbArtist4, 3)
        Me.tbArtist4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbArtist4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbArtist4.Location = New System.Drawing.Point(71, 3)
        Me.tbArtist4.Name = "tbArtist4"
        Me.tbArtist4.Size = New System.Drawing.Size(200, 20)
        Me.tbArtist4.TabIndex = 47
        '
        'gbPlayer2
        '
        Me.gbPlayer2.BackColor = System.Drawing.Color.Yellow
        Me.gbPlayer2.Controls.Add(Me.tablePlayer2)
        Me.gbPlayer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPlayer2.Location = New System.Drawing.Point(3, 137)
        Me.gbPlayer2.Name = "gbPlayer2"
        Me.gbPlayer2.Size = New System.Drawing.Size(280, 128)
        Me.gbPlayer2.TabIndex = 14
        Me.gbPlayer2.TabStop = False
        Me.gbPlayer2.Text = "Player 2"
        '
        'tablePlayer2
        '
        Me.tablePlayer2.ColumnCount = 4
        Me.tablePlayer2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer2.Controls.Add(Me.btnStop2, 3, 2)
        Me.tablePlayer2.Controls.Add(Me.lblArtist2, 0, 0)
        Me.tablePlayer2.Controls.Add(Me.btnPlay2, 2, 2)
        Me.tablePlayer2.Controls.Add(Me.lblTitle2, 0, 1)
        Me.tablePlayer2.Controls.Add(Me.prgPlayer2, 0, 4)
        Me.tablePlayer2.Controls.Add(Me.lblTimeLeft2, 0, 2)
        Me.tablePlayer2.Controls.Add(Me.tbPlayed2, 1, 3)
        Me.tablePlayer2.Controls.Add(Me.tbTitle2, 1, 1)
        Me.tablePlayer2.Controls.Add(Me.tbTimeLeft2, 1, 2)
        Me.tablePlayer2.Controls.Add(Me.lblPlayed2, 0, 3)
        Me.tablePlayer2.Controls.Add(Me.tbArtist2, 1, 0)
        Me.tablePlayer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablePlayer2.Location = New System.Drawing.Point(3, 16)
        Me.tablePlayer2.Name = "tablePlayer2"
        Me.tablePlayer2.RowCount = 5
        Me.tablePlayer2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tablePlayer2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tablePlayer2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5!))
        Me.tablePlayer2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5!))
        Me.tablePlayer2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tablePlayer2.Size = New System.Drawing.Size(274, 109)
        Me.tablePlayer2.TabIndex = 35
        '
        'btnStop2
        '
        Me.btnStop2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStop2.Image = CType(resources.GetObject("btnStop2.Image"), System.Drawing.Image)
        Me.btnStop2.Location = New System.Drawing.Point(207, 45)
        Me.btnStop2.Name = "btnStop2"
        Me.tablePlayer2.SetRowSpan(Me.btnStop2, 2)
        Me.btnStop2.Size = New System.Drawing.Size(64, 42)
        Me.btnStop2.TabIndex = 38
        Me.btnStop2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStop2.UseVisualStyleBackColor = True
        '
        'lblArtist2
        '
        Me.lblArtist2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblArtist2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtist2.Location = New System.Drawing.Point(3, 0)
        Me.lblArtist2.Name = "lblArtist2"
        Me.lblArtist2.Size = New System.Drawing.Size(62, 21)
        Me.lblArtist2.TabIndex = 12
        Me.lblArtist2.Text = "Artist:"
        Me.lblArtist2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnPlay2
        '
        Me.btnPlay2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPlay2.Image = CType(resources.GetObject("btnPlay2.Image"), System.Drawing.Image)
        Me.btnPlay2.Location = New System.Drawing.Point(139, 45)
        Me.btnPlay2.Name = "btnPlay2"
        Me.tablePlayer2.SetRowSpan(Me.btnPlay2, 2)
        Me.btnPlay2.Size = New System.Drawing.Size(62, 42)
        Me.btnPlay2.TabIndex = 37
        Me.btnPlay2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPlay2.UseVisualStyleBackColor = True
        '
        'lblTitle2
        '
        Me.lblTitle2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.Location = New System.Drawing.Point(3, 21)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(62, 21)
        Me.lblTitle2.TabIndex = 14
        Me.lblTitle2.Text = "Title:"
        Me.lblTitle2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'prgPlayer2
        '
        Me.tablePlayer2.SetColumnSpan(Me.prgPlayer2, 4)
        Me.prgPlayer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prgPlayer2.Location = New System.Drawing.Point(3, 93)
        Me.prgPlayer2.Name = "prgPlayer2"
        Me.prgPlayer2.Size = New System.Drawing.Size(268, 13)
        Me.prgPlayer2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgPlayer2.TabIndex = 39
        '
        'lblTimeLeft2
        '
        Me.lblTimeLeft2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTimeLeft2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft2.Location = New System.Drawing.Point(3, 42)
        Me.lblTimeLeft2.Name = "lblTimeLeft2"
        Me.lblTimeLeft2.Size = New System.Drawing.Size(62, 24)
        Me.lblTimeLeft2.TabIndex = 8
        Me.lblTimeLeft2.Text = "Time Left:"
        Me.lblTimeLeft2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbPlayed2
        '
        Me.tbPlayed2.BackColor = System.Drawing.Color.Black
        Me.tbPlayed2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbPlayed2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPlayed2.ForeColor = System.Drawing.Color.Red
        Me.tbPlayed2.Location = New System.Drawing.Point(71, 69)
        Me.tbPlayed2.Name = "tbPlayed2"
        Me.tbPlayed2.Size = New System.Drawing.Size(62, 20)
        Me.tbPlayed2.TabIndex = 36
        Me.tbPlayed2.Text = "00:00"
        '
        'tbTitle2
        '
        Me.tablePlayer2.SetColumnSpan(Me.tbTitle2, 3)
        Me.tbTitle2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTitle2.Location = New System.Drawing.Point(71, 24)
        Me.tbTitle2.Name = "tbTitle2"
        Me.tbTitle2.Size = New System.Drawing.Size(200, 20)
        Me.tbTitle2.TabIndex = 34
        '
        'tbTimeLeft2
        '
        Me.tbTimeLeft2.BackColor = System.Drawing.Color.Black
        Me.tbTimeLeft2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbTimeLeft2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTimeLeft2.ForeColor = System.Drawing.Color.Red
        Me.tbTimeLeft2.Location = New System.Drawing.Point(71, 45)
        Me.tbTimeLeft2.Name = "tbTimeLeft2"
        Me.tbTimeLeft2.Size = New System.Drawing.Size(62, 20)
        Me.tbTimeLeft2.TabIndex = 35
        Me.tbTimeLeft2.Text = "00:00"
        '
        'lblPlayed2
        '
        Me.lblPlayed2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlayed2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayed2.Location = New System.Drawing.Point(3, 66)
        Me.lblPlayed2.Name = "lblPlayed2"
        Me.lblPlayed2.Size = New System.Drawing.Size(62, 24)
        Me.lblPlayed2.TabIndex = 10
        Me.lblPlayed2.Text = "Played:"
        Me.lblPlayed2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbArtist2
        '
        Me.tablePlayer2.SetColumnSpan(Me.tbArtist2, 3)
        Me.tbArtist2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbArtist2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbArtist2.Location = New System.Drawing.Point(71, 3)
        Me.tbArtist2.Name = "tbArtist2"
        Me.tbArtist2.Size = New System.Drawing.Size(200, 20)
        Me.tbArtist2.TabIndex = 33
        '
        'gbPlayer1
        '
        Me.gbPlayer1.BackColor = System.Drawing.Color.Lime
        Me.gbPlayer1.Controls.Add(Me.tablePlayer1)
        Me.gbPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPlayer1.Location = New System.Drawing.Point(3, 3)
        Me.gbPlayer1.Name = "gbPlayer1"
        Me.gbPlayer1.Size = New System.Drawing.Size(280, 128)
        Me.gbPlayer1.TabIndex = 12
        Me.gbPlayer1.TabStop = False
        Me.gbPlayer1.Text = "Player 1"
        '
        'tablePlayer1
        '
        Me.tablePlayer1.ColumnCount = 4
        Me.tablePlayer1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer1.Controls.Add(Me.prgPlayer1, 0, 4)
        Me.tablePlayer1.Controls.Add(Me.btnStop1, 3, 2)
        Me.tablePlayer1.Controls.Add(Me.lblArtist1, 0, 0)
        Me.tablePlayer1.Controls.Add(Me.btnPlay1, 2, 2)
        Me.tablePlayer1.Controls.Add(Me.tbArtist1, 1, 0)
        Me.tablePlayer1.Controls.Add(Me.tbTitle1, 1, 1)
        Me.tablePlayer1.Controls.Add(Me.tbPlayed1, 1, 3)
        Me.tablePlayer1.Controls.Add(Me.lblTitle1, 0, 1)
        Me.tablePlayer1.Controls.Add(Me.lblPlayed1, 0, 3)
        Me.tablePlayer1.Controls.Add(Me.lblTimeLeft1, 0, 2)
        Me.tablePlayer1.Controls.Add(Me.tbTimeLeft1, 1, 2)
        Me.tablePlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablePlayer1.Location = New System.Drawing.Point(3, 16)
        Me.tablePlayer1.Name = "tablePlayer1"
        Me.tablePlayer1.RowCount = 5
        Me.tablePlayer1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tablePlayer1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tablePlayer1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5!))
        Me.tablePlayer1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5!))
        Me.tablePlayer1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tablePlayer1.Size = New System.Drawing.Size(274, 109)
        Me.tablePlayer1.TabIndex = 33
        '
        'prgPlayer1
        '
        Me.tablePlayer1.SetColumnSpan(Me.prgPlayer1, 4)
        Me.prgPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prgPlayer1.Location = New System.Drawing.Point(3, 93)
        Me.prgPlayer1.Name = "prgPlayer1"
        Me.prgPlayer1.Size = New System.Drawing.Size(268, 13)
        Me.prgPlayer1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgPlayer1.TabIndex = 32
        '
        'btnStop1
        '
        Me.btnStop1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStop1.Image = CType(resources.GetObject("btnStop1.Image"), System.Drawing.Image)
        Me.btnStop1.Location = New System.Drawing.Point(207, 45)
        Me.btnStop1.Name = "btnStop1"
        Me.tablePlayer1.SetRowSpan(Me.btnStop1, 2)
        Me.btnStop1.Size = New System.Drawing.Size(64, 42)
        Me.btnStop1.TabIndex = 31
        Me.btnStop1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStop1.UseVisualStyleBackColor = True
        '
        'lblArtist1
        '
        Me.lblArtist1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblArtist1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtist1.Location = New System.Drawing.Point(3, 0)
        Me.lblArtist1.Name = "lblArtist1"
        Me.lblArtist1.Size = New System.Drawing.Size(62, 21)
        Me.lblArtist1.TabIndex = 12
        Me.lblArtist1.Text = "Artist:"
        Me.lblArtist1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnPlay1
        '
        Me.btnPlay1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPlay1.Image = CType(resources.GetObject("btnPlay1.Image"), System.Drawing.Image)
        Me.btnPlay1.Location = New System.Drawing.Point(139, 45)
        Me.btnPlay1.Name = "btnPlay1"
        Me.tablePlayer1.SetRowSpan(Me.btnPlay1, 2)
        Me.btnPlay1.Size = New System.Drawing.Size(62, 42)
        Me.btnPlay1.TabIndex = 30
        Me.btnPlay1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPlay1.UseVisualStyleBackColor = True
        '
        'tbArtist1
        '
        Me.tablePlayer1.SetColumnSpan(Me.tbArtist1, 3)
        Me.tbArtist1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbArtist1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbArtist1.Location = New System.Drawing.Point(71, 3)
        Me.tbArtist1.Name = "tbArtist1"
        Me.tbArtist1.Size = New System.Drawing.Size(200, 20)
        Me.tbArtist1.TabIndex = 13
        '
        'tbTitle1
        '
        Me.tablePlayer1.SetColumnSpan(Me.tbTitle1, 3)
        Me.tbTitle1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTitle1.Location = New System.Drawing.Point(71, 24)
        Me.tbTitle1.Name = "tbTitle1"
        Me.tbTitle1.Size = New System.Drawing.Size(200, 20)
        Me.tbTitle1.TabIndex = 27
        '
        'tbPlayed1
        '
        Me.tbPlayed1.BackColor = System.Drawing.Color.Black
        Me.tbPlayed1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbPlayed1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPlayed1.ForeColor = System.Drawing.Color.Red
        Me.tbPlayed1.Location = New System.Drawing.Point(71, 69)
        Me.tbPlayed1.Name = "tbPlayed1"
        Me.tbPlayed1.Size = New System.Drawing.Size(62, 20)
        Me.tbPlayed1.TabIndex = 29
        Me.tbPlayed1.Text = "00:00"
        '
        'lblTitle1
        '
        Me.lblTitle1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.Location = New System.Drawing.Point(3, 21)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(62, 21)
        Me.lblTitle1.TabIndex = 14
        Me.lblTitle1.Text = "Title:"
        Me.lblTitle1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPlayed1
        '
        Me.lblPlayed1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlayed1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayed1.Location = New System.Drawing.Point(3, 66)
        Me.lblPlayed1.Name = "lblPlayed1"
        Me.lblPlayed1.Size = New System.Drawing.Size(62, 24)
        Me.lblPlayed1.TabIndex = 10
        Me.lblPlayed1.Text = "Played:"
        Me.lblPlayed1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTimeLeft1
        '
        Me.lblTimeLeft1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTimeLeft1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft1.Location = New System.Drawing.Point(3, 42)
        Me.lblTimeLeft1.Name = "lblTimeLeft1"
        Me.lblTimeLeft1.Size = New System.Drawing.Size(62, 24)
        Me.lblTimeLeft1.TabIndex = 8
        Me.lblTimeLeft1.Text = "Time Left:"
        Me.lblTimeLeft1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbTimeLeft1
        '
        Me.tbTimeLeft1.BackColor = System.Drawing.Color.Black
        Me.tbTimeLeft1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbTimeLeft1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTimeLeft1.ForeColor = System.Drawing.Color.Red
        Me.tbTimeLeft1.Location = New System.Drawing.Point(71, 45)
        Me.tbTimeLeft1.Name = "tbTimeLeft1"
        Me.tbTimeLeft1.Size = New System.Drawing.Size(62, 20)
        Me.tbTimeLeft1.TabIndex = 28
        Me.tbTimeLeft1.Text = "00:00"
        '
        'gbPlayer3
        '
        Me.gbPlayer3.BackColor = System.Drawing.Color.Cyan
        Me.gbPlayer3.Controls.Add(Me.tablePlayer3)
        Me.gbPlayer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbPlayer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPlayer3.Location = New System.Drawing.Point(3, 271)
        Me.gbPlayer3.Name = "gbPlayer3"
        Me.gbPlayer3.Size = New System.Drawing.Size(280, 128)
        Me.gbPlayer3.TabIndex = 15
        Me.gbPlayer3.TabStop = False
        Me.gbPlayer3.Text = "Player 3"
        '
        'tablePlayer3
        '
        Me.tablePlayer3.ColumnCount = 4
        Me.tablePlayer3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tablePlayer3.Controls.Add(Me.prgPlayer3, 0, 4)
        Me.tablePlayer3.Controls.Add(Me.btnStop3, 3, 2)
        Me.tablePlayer3.Controls.Add(Me.lblArtist3, 0, 0)
        Me.tablePlayer3.Controls.Add(Me.tbArtist3, 1, 0)
        Me.tablePlayer3.Controls.Add(Me.tbTitle3, 1, 1)
        Me.tablePlayer3.Controls.Add(Me.lblPlayed3, 0, 3)
        Me.tablePlayer3.Controls.Add(Me.lblTitle3, 0, 1)
        Me.tablePlayer3.Controls.Add(Me.lblTimeLeft3, 0, 2)
        Me.tablePlayer3.Controls.Add(Me.tbTimeLeft3, 1, 2)
        Me.tablePlayer3.Controls.Add(Me.tbPlayed3, 1, 3)
        Me.tablePlayer3.Controls.Add(Me.btnPlay3, 2, 2)
        Me.tablePlayer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablePlayer3.Location = New System.Drawing.Point(3, 16)
        Me.tablePlayer3.Name = "tablePlayer3"
        Me.tablePlayer3.RowCount = 5
        Me.tablePlayer3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tablePlayer3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tablePlayer3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5!))
        Me.tablePlayer3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5!))
        Me.tablePlayer3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tablePlayer3.Size = New System.Drawing.Size(274, 109)
        Me.tablePlayer3.TabIndex = 35
        '
        'prgPlayer3
        '
        Me.tablePlayer3.SetColumnSpan(Me.prgPlayer3, 4)
        Me.prgPlayer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prgPlayer3.Location = New System.Drawing.Point(3, 93)
        Me.prgPlayer3.Name = "prgPlayer3"
        Me.prgPlayer3.Size = New System.Drawing.Size(268, 13)
        Me.prgPlayer3.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgPlayer3.TabIndex = 46
        '
        'btnStop3
        '
        Me.btnStop3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStop3.Image = CType(resources.GetObject("btnStop3.Image"), System.Drawing.Image)
        Me.btnStop3.Location = New System.Drawing.Point(207, 45)
        Me.btnStop3.Name = "btnStop3"
        Me.tablePlayer3.SetRowSpan(Me.btnStop3, 2)
        Me.btnStop3.Size = New System.Drawing.Size(64, 42)
        Me.btnStop3.TabIndex = 45
        Me.btnStop3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStop3.UseVisualStyleBackColor = True
        '
        'lblArtist3
        '
        Me.lblArtist3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblArtist3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtist3.Location = New System.Drawing.Point(3, 0)
        Me.lblArtist3.Name = "lblArtist3"
        Me.lblArtist3.Size = New System.Drawing.Size(62, 21)
        Me.lblArtist3.TabIndex = 12
        Me.lblArtist3.Text = "Artist:"
        Me.lblArtist3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbArtist3
        '
        Me.tablePlayer3.SetColumnSpan(Me.tbArtist3, 3)
        Me.tbArtist3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbArtist3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbArtist3.Location = New System.Drawing.Point(71, 3)
        Me.tbArtist3.Name = "tbArtist3"
        Me.tbArtist3.Size = New System.Drawing.Size(200, 20)
        Me.tbArtist3.TabIndex = 40
        '
        'tbTitle3
        '
        Me.tablePlayer3.SetColumnSpan(Me.tbTitle3, 3)
        Me.tbTitle3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbTitle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTitle3.Location = New System.Drawing.Point(71, 24)
        Me.tbTitle3.Name = "tbTitle3"
        Me.tbTitle3.Size = New System.Drawing.Size(200, 20)
        Me.tbTitle3.TabIndex = 41
        '
        'lblPlayed3
        '
        Me.lblPlayed3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlayed3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayed3.Location = New System.Drawing.Point(3, 66)
        Me.lblPlayed3.Name = "lblPlayed3"
        Me.lblPlayed3.Size = New System.Drawing.Size(62, 24)
        Me.lblPlayed3.TabIndex = 10
        Me.lblPlayed3.Text = "Played:"
        Me.lblPlayed3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitle3
        '
        Me.lblTitle3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle3.Location = New System.Drawing.Point(3, 21)
        Me.lblTitle3.Name = "lblTitle3"
        Me.lblTitle3.Size = New System.Drawing.Size(62, 21)
        Me.lblTitle3.TabIndex = 14
        Me.lblTitle3.Text = "Title:"
        Me.lblTitle3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTimeLeft3
        '
        Me.lblTimeLeft3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTimeLeft3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft3.Location = New System.Drawing.Point(3, 42)
        Me.lblTimeLeft3.Name = "lblTimeLeft3"
        Me.lblTimeLeft3.Size = New System.Drawing.Size(62, 24)
        Me.lblTimeLeft3.TabIndex = 8
        Me.lblTimeLeft3.Text = "Time Left:"
        Me.lblTimeLeft3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbTimeLeft3
        '
        Me.tbTimeLeft3.BackColor = System.Drawing.Color.Black
        Me.tbTimeLeft3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbTimeLeft3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTimeLeft3.ForeColor = System.Drawing.Color.Red
        Me.tbTimeLeft3.Location = New System.Drawing.Point(71, 45)
        Me.tbTimeLeft3.Name = "tbTimeLeft3"
        Me.tbTimeLeft3.Size = New System.Drawing.Size(62, 20)
        Me.tbTimeLeft3.TabIndex = 42
        Me.tbTimeLeft3.Text = "00:00"
        '
        'tbPlayed3
        '
        Me.tbPlayed3.BackColor = System.Drawing.Color.Black
        Me.tbPlayed3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbPlayed3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPlayed3.ForeColor = System.Drawing.Color.Red
        Me.tbPlayed3.Location = New System.Drawing.Point(71, 69)
        Me.tbPlayed3.Name = "tbPlayed3"
        Me.tbPlayed3.Size = New System.Drawing.Size(62, 20)
        Me.tbPlayed3.TabIndex = 43
        Me.tbPlayed3.Text = "00:00"
        '
        'btnPlay3
        '
        Me.btnPlay3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPlay3.Image = CType(resources.GetObject("btnPlay3.Image"), System.Drawing.Image)
        Me.btnPlay3.Location = New System.Drawing.Point(139, 45)
        Me.btnPlay3.Name = "btnPlay3"
        Me.tablePlayer3.SetRowSpan(Me.btnPlay3, 2)
        Me.btnPlay3.Size = New System.Drawing.Size(62, 42)
        Me.btnPlay3.TabIndex = 44
        Me.btnPlay3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPlay3.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.scMain)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.msMain)
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AllDay DJ 2 - Monday 1st January 2006 - 00:00:00"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.scMain.Panel1.ResumeLayout(False)
        Me.scMain.Panel2.ResumeLayout(False)
        Me.scMain.ResumeLayout(False)
        Me.tableTopBar.ResumeLayout(False)
        Me.tableTopBar.PerformLayout()
        Me.gbMaster.ResumeLayout(False)
        Me.tableMaster.ResumeLayout(False)
        Me.tableMainLayout.ResumeLayout(False)
        Me.tableLeftPanel.ResumeLayout(False)
        Me.tablePlaylist.ResumeLayout(False)
        Me.tablePlaylist4.ResumeLayout(False)
        Me.tablePlaylist4.PerformLayout()
        Me.tablePlaylist1.ResumeLayout(False)
        Me.tablePlaylist1.PerformLayout()
        Me.tablePlaylist2.ResumeLayout(False)
        Me.tablePlaylist2.PerformLayout()
        Me.tablePlaylist3.ResumeLayout(False)
        Me.tablePlaylist3.PerformLayout()
        Me.tabDisplay.ResumeLayout(False)
        Me.tabPlayedItems.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tabPlayers.ResumeLayout(False)
        Me.tablePlayers.ResumeLayout(False)
        Me.gbPlayer4.ResumeLayout(False)
        Me.tablePlayer4.ResumeLayout(False)
        Me.tablePlayer4.PerformLayout()
        Me.gbPlayer2.ResumeLayout(False)
        Me.tablePlayer2.ResumeLayout(False)
        Me.tablePlayer2.PerformLayout()
        Me.gbPlayer1.ResumeLayout(False)
        Me.tablePlayer1.ResumeLayout(False)
        Me.tablePlayer1.PerformLayout()
        Me.gbPlayer3.ResumeLayout(False)
        Me.tablePlayer3.ResumeLayout(False)
        Me.tablePlayer3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopicsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrDoStuff As System.Windows.Forms.Timer
    Friend WithEvents ttPlaylist As System.Windows.Forms.ToolTip
    Friend WithEvents tmrFlasher As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReloadDatabaseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BacktimeCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NowAndNextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MixerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnInstantPlayer_1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnInstantPlayer_2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnInstantPlayer_3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnInstantPlayer_4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnInstantPlayer_5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnInstantPlayer_6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnInstantPlayer_7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnInstantPlayer_8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnInstantPlayer_9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnLoad As System.Windows.Forms.ToolStripButton
    Friend WithEvents scMain As System.Windows.Forms.SplitContainer
    Friend WithEvents tableTopBar As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbMaster As System.Windows.Forms.GroupBox
    Friend WithEvents tableMaster As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnAutomate As System.Windows.Forms.Button
    Friend WithEvents lblPlaylistRemainTitle As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblToHour As System.Windows.Forms.Label
    Friend WithEvents lblPlaylistRemain As System.Windows.Forms.Label
    Friend WithEvents lblToHourTitle As System.Windows.Forms.Label
    Friend WithEvents lblTrackRemain As System.Windows.Forms.Label
    Friend WithEvents lblTimeTitle As System.Windows.Forms.Label
    Friend WithEvents lblTrackRemainTitle As System.Windows.Forms.Label
    Friend WithEvents tableMainLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableLeftPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnBreakAfter As System.Windows.Forms.Button
    Friend WithEvents btnPlayToHour As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents tablePlaylist As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents scrollPlaylist As System.Windows.Forms.VScrollBar
    Friend WithEvents tablePlaylist1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblRemain1 As System.Windows.Forms.Label
    Friend WithEvents lblPlaylistPlayed1 As System.Windows.Forms.Label
    Friend WithEvents lblLength1 As System.Windows.Forms.Label
    Friend WithEvents lblPlaylistNumber1 As System.Windows.Forms.Label
    Friend WithEvents lblPlaylistArtistTitleInfo1 As System.Windows.Forms.Label
    Friend WithEvents tablePlaylist4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblRemain4 As System.Windows.Forms.Label
    Friend WithEvents lblPlaylistPlayed4 As System.Windows.Forms.Label
    Friend WithEvents lblLength4 As System.Windows.Forms.Label
    Friend WithEvents lblPlaylistNumber4 As System.Windows.Forms.Label
    Friend WithEvents lblPlaylistArtistTitleInfo4 As System.Windows.Forms.Label
    Friend WithEvents tablePlaylist2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblRemain2 As System.Windows.Forms.Label
    Friend WithEvents lblPlaylistPlayed2 As System.Windows.Forms.Label
    Friend WithEvents lblLength2 As System.Windows.Forms.Label
    Friend WithEvents lblPlaylistNumber2 As System.Windows.Forms.Label
    Friend WithEvents lblPlaylistArtistTitleInfo2 As System.Windows.Forms.Label
    Friend WithEvents tablePlaylist3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblRemain3 As System.Windows.Forms.Label
    Friend WithEvents lblPlaylistPlayed3 As System.Windows.Forms.Label
    Friend WithEvents lblLength3 As System.Windows.Forms.Label
    Friend WithEvents lblPlaylistNumber3 As System.Windows.Forms.Label
    Friend WithEvents lblPlaylistArtistTitleInfo3 As System.Windows.Forms.Label
    Friend WithEvents pbPlaylist4 As System.Windows.Forms.ProgressBar
    Friend WithEvents pbPlaylist1 As System.Windows.Forms.ProgressBar
    Friend WithEvents pbPlaylist2 As System.Windows.Forms.ProgressBar
    Friend WithEvents pbPlaylist3 As System.Windows.Forms.ProgressBar
    Friend WithEvents tabDisplay As System.Windows.Forms.TabControl
    Friend WithEvents tabPlayers As System.Windows.Forms.TabPage
    Friend WithEvents tablePlayers As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbPlayer4 As System.Windows.Forms.GroupBox
    Friend WithEvents tablePlayer4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnStop4 As System.Windows.Forms.Button
    Friend WithEvents lblArtist4 As System.Windows.Forms.Label
    Friend WithEvents btnPlay4 As System.Windows.Forms.Button
    Friend WithEvents lblTitle4 As System.Windows.Forms.Label
    Friend WithEvents prgPlayer4 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblTimeLeft4 As System.Windows.Forms.Label
    Friend WithEvents tbPlayed4 As System.Windows.Forms.TextBox
    Friend WithEvents tbTitle4 As System.Windows.Forms.TextBox
    Friend WithEvents tbTimeLeft4 As System.Windows.Forms.TextBox
    Friend WithEvents lblPlayed4 As System.Windows.Forms.Label
    Friend WithEvents tbArtist4 As System.Windows.Forms.TextBox
    Friend WithEvents gbPlayer2 As System.Windows.Forms.GroupBox
    Friend WithEvents tablePlayer2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnStop2 As System.Windows.Forms.Button
    Friend WithEvents lblArtist2 As System.Windows.Forms.Label
    Friend WithEvents btnPlay2 As System.Windows.Forms.Button
    Friend WithEvents lblTitle2 As System.Windows.Forms.Label
    Friend WithEvents prgPlayer2 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblTimeLeft2 As System.Windows.Forms.Label
    Friend WithEvents tbPlayed2 As System.Windows.Forms.TextBox
    Friend WithEvents tbTitle2 As System.Windows.Forms.TextBox
    Friend WithEvents tbTimeLeft2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPlayed2 As System.Windows.Forms.Label
    Friend WithEvents tbArtist2 As System.Windows.Forms.TextBox
    Friend WithEvents gbPlayer1 As System.Windows.Forms.GroupBox
    Friend WithEvents tablePlayer1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents prgPlayer1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnStop1 As System.Windows.Forms.Button
    Friend WithEvents lblArtist1 As System.Windows.Forms.Label
    Friend WithEvents btnPlay1 As System.Windows.Forms.Button
    Friend WithEvents tbArtist1 As System.Windows.Forms.TextBox
    Friend WithEvents tbTitle1 As System.Windows.Forms.TextBox
    Friend WithEvents tbPlayed1 As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayed1 As System.Windows.Forms.Label
    Friend WithEvents lblTimeLeft1 As System.Windows.Forms.Label
    Friend WithEvents tbTimeLeft1 As System.Windows.Forms.TextBox
    Friend WithEvents gbPlayer3 As System.Windows.Forms.GroupBox
    Friend WithEvents tablePlayer3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents prgPlayer3 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnStop3 As System.Windows.Forms.Button
    Friend WithEvents lblArtist3 As System.Windows.Forms.Label
    Friend WithEvents tbArtist3 As System.Windows.Forms.TextBox
    Friend WithEvents tbTitle3 As System.Windows.Forms.TextBox
    Friend WithEvents lblPlayed3 As System.Windows.Forms.Label
    Friend WithEvents lblTitle3 As System.Windows.Forms.Label
    Friend WithEvents lblTimeLeft3 As System.Windows.Forms.Label
    Friend WithEvents tbTimeLeft3 As System.Windows.Forms.TextBox
    Friend WithEvents tbPlayed3 As System.Windows.Forms.TextBox
    Friend WithEvents btnPlay3 As System.Windows.Forms.Button
    Friend WithEvents tabPlayedItems As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbPlayedItems As System.Windows.Forms.ListBox
    Friend WithEvents btnClearPlayed As System.Windows.Forms.Button
End Class

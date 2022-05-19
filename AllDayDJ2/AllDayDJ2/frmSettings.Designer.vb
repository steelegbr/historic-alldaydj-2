<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.tcSettings = New System.Windows.Forms.TabControl
        Me.tabGeneral = New System.Windows.Forms.TabPage
        Me.btnScheduleBrowse = New System.Windows.Forms.Button
        Me.tbScheduleLocation = New System.Windows.Forms.TextBox
        Me.lblScheduleLocation = New System.Windows.Forms.Label
        Me.btnLogsBrowse = New System.Windows.Forms.Button
        Me.tbLogsLocation = New System.Windows.Forms.TextBox
        Me.lblLogs = New System.Windows.Forms.Label
        Me.btnBrowseSettingsFile = New System.Windows.Forms.Button
        Me.tbSettingsFile = New System.Windows.Forms.TextBox
        Me.lblSettings = New System.Windows.Forms.Label
        Me.btnDbBrowse = New System.Windows.Forms.Button
        Me.tbDbLocation = New System.Windows.Forms.TextBox
        Me.lblDbLocation = New System.Windows.Forms.Label
        Me.tabSchedule = New System.Windows.Forms.TabPage
        Me.btnScheduleHelp = New System.Windows.Forms.Button
        Me.lblScheduleFileName = New System.Windows.Forms.Label
        Me.tbScheduleFileName = New System.Windows.Forms.TextBox
        Me.btnScheduleFolderBrowse = New System.Windows.Forms.Button
        Me.tbScheduleFolder = New System.Windows.Forms.TextBox
        Me.lblScheduleFolder = New System.Windows.Forms.Label
        Me.radScheduleM3U = New System.Windows.Forms.RadioButton
        Me.radScheduleAllDayDJ = New System.Windows.Forms.RadioButton
        Me.tabAudioHardware = New System.Windows.Forms.TabPage
        Me.cmbIPPan = New System.Windows.Forms.ComboBox
        Me.cmbIP = New System.Windows.Forms.ComboBox
        Me.lblIP = New System.Windows.Forms.Label
        Me.cmbPanPFL = New System.Windows.Forms.ComboBox
        Me.cmbPFL = New System.Windows.Forms.ComboBox
        Me.lblPreFade = New System.Windows.Forms.Label
        Me.cmbPan4 = New System.Windows.Forms.ComboBox
        Me.cmbCards4 = New System.Windows.Forms.ComboBox
        Me.cmbPan3 = New System.Windows.Forms.ComboBox
        Me.cmbCards3 = New System.Windows.Forms.ComboBox
        Me.cmbPan2 = New System.Windows.Forms.ComboBox
        Me.cmbCards2 = New System.Windows.Forms.ComboBox
        Me.cmbPan1 = New System.Windows.Forms.ComboBox
        Me.cmbCards1 = New System.Windows.Forms.ComboBox
        Me.lbl4 = New System.Windows.Forms.Label
        Me.lbl3 = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.lblPlayers = New System.Windows.Forms.Label
        Me.tabAudioSettings = New System.Windows.Forms.TabPage
        Me.gbOther = New System.Windows.Forms.GroupBox
        Me.chkFitInHour = New System.Windows.Forms.CheckBox
        Me.gbDucker = New System.Windows.Forms.GroupBox
        Me.nudRelease = New System.Windows.Forms.NumericUpDown
        Me.nudAttack = New System.Windows.Forms.NumericUpDown
        Me.lblRelease = New System.Windows.Forms.Label
        Me.lblAttack = New System.Windows.Forms.Label
        Me.lblFadePercent = New System.Windows.Forms.Label
        Me.lblTriggerPercent = New System.Windows.Forms.Label
        Me.tbFadeVolume = New System.Windows.Forms.TrackBar
        Me.lblFadeVolume = New System.Windows.Forms.Label
        Me.tbTriggerVolume = New System.Windows.Forms.TrackBar
        Me.lblTrigger = New System.Windows.Forms.Label
        Me.chkDucker = New System.Windows.Forms.CheckBox
        Me.tabAGC = New System.Windows.Forms.TabPage
        Me.lblGainValue = New System.Windows.Forms.Label
        Me.sldGain = New System.Windows.Forms.TrackBar
        Me.lblGain = New System.Windows.Forms.Label
        Me.lblDelayMs = New System.Windows.Forms.Label
        Me.lblRateMs = New System.Windows.Forms.Label
        Me.lblMinPercent = New System.Windows.Forms.Label
        Me.lblTargetPercent = New System.Windows.Forms.Label
        Me.lblEnable = New System.Windows.Forms.Label
        Me.sldDelay = New System.Windows.Forms.TrackBar
        Me.lblDelay = New System.Windows.Forms.Label
        Me.sldRate = New System.Windows.Forms.TrackBar
        Me.lblAdjust = New System.Windows.Forms.Label
        Me.sldMin = New System.Windows.Forms.TrackBar
        Me.lblMin = New System.Windows.Forms.Label
        Me.sldTarget = New System.Windows.Forms.TrackBar
        Me.lblTarget = New System.Windows.Forms.Label
        Me.chkEnableAGC = New System.Windows.Forms.CheckBox
        Me.tabCompressor = New System.Windows.Forms.TabPage
        Me.lblThresholdValue = New System.Windows.Forms.Label
        Me.lblReleaseTimeValue = New System.Windows.Forms.Label
        Me.lblAttackTimeValue = New System.Windows.Forms.Label
        Me.lblEnableCompressor = New System.Windows.Forms.Label
        Me.tbThreshold = New System.Windows.Forms.TrackBar
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbReleaseTime = New System.Windows.Forms.TrackBar
        Me.lblReleaseTime = New System.Windows.Forms.Label
        Me.tbAttackTime = New System.Windows.Forms.TrackBar
        Me.lblAttackTime = New System.Windows.Forms.Label
        Me.chkCompressor = New System.Windows.Forms.CheckBox
        Me.tabRotation = New System.Windows.Forms.TabPage
        Me.btnDown = New System.Windows.Forms.Button
        Me.btnUp = New System.Windows.Forms.Button
        Me.lbRotation = New System.Windows.Forms.ListBox
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.cmbPlaylists = New System.Windows.Forms.ComboBox
        Me.tabInput = New System.Windows.Forms.TabPage
        Me.cmbInput = New System.Windows.Forms.ComboBox
        Me.lblInput = New System.Windows.Forms.Label
        Me.cmbSoundCard = New System.Windows.Forms.ComboBox
        Me.lblSoundCard = New System.Windows.Forms.Label
        Me.tabDisplay = New System.Windows.Forms.TabPage
        Me.cbDisplayAlwaysMixer = New System.Windows.Forms.CheckBox
        Me.cbDisplayAlwaysLibrary = New System.Windows.Forms.CheckBox
        Me.cmbScreenMixer = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbScreenLibrary = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbScreenMain = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ofdDBLocation = New System.Windows.Forms.OpenFileDialog
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ofdSettingsFile = New System.Windows.Forms.OpenFileDialog
        Me.ofdLogsLocation = New System.Windows.Forms.OpenFileDialog
        Me.tmrSliderChange = New System.Windows.Forms.Timer(Me.components)
        Me.ofdScheduleLocation = New System.Windows.Forms.OpenFileDialog
        Me.fbdM3U = New System.Windows.Forms.FolderBrowserDialog
        Me.tcSettings.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.tabSchedule.SuspendLayout()
        Me.tabAudioHardware.SuspendLayout()
        Me.tabAudioSettings.SuspendLayout()
        Me.gbOther.SuspendLayout()
        Me.gbDucker.SuspendLayout()
        CType(Me.nudRelease, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAttack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFadeVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTriggerVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAGC.SuspendLayout()
        CType(Me.sldGain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sldDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sldRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sldMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sldTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCompressor.SuspendLayout()
        CType(Me.tbThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbReleaseTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAttackTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRotation.SuspendLayout()
        Me.tabInput.SuspendLayout()
        Me.tabDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcSettings
        '
        Me.tcSettings.Controls.Add(Me.tabGeneral)
        Me.tcSettings.Controls.Add(Me.tabSchedule)
        Me.tcSettings.Controls.Add(Me.tabAudioHardware)
        Me.tcSettings.Controls.Add(Me.tabAudioSettings)
        Me.tcSettings.Controls.Add(Me.tabAGC)
        Me.tcSettings.Controls.Add(Me.tabCompressor)
        Me.tcSettings.Controls.Add(Me.tabRotation)
        Me.tcSettings.Controls.Add(Me.tabInput)
        Me.tcSettings.Controls.Add(Me.tabDisplay)
        Me.tcSettings.Location = New System.Drawing.Point(3, 2)
        Me.tcSettings.Name = "tcSettings"
        Me.tcSettings.SelectedIndex = 0
        Me.tcSettings.Size = New System.Drawing.Size(404, 310)
        Me.tcSettings.TabIndex = 0
        '
        'tabGeneral
        '
        Me.tabGeneral.Controls.Add(Me.btnScheduleBrowse)
        Me.tabGeneral.Controls.Add(Me.tbScheduleLocation)
        Me.tabGeneral.Controls.Add(Me.lblScheduleLocation)
        Me.tabGeneral.Controls.Add(Me.btnLogsBrowse)
        Me.tabGeneral.Controls.Add(Me.tbLogsLocation)
        Me.tabGeneral.Controls.Add(Me.lblLogs)
        Me.tabGeneral.Controls.Add(Me.btnBrowseSettingsFile)
        Me.tabGeneral.Controls.Add(Me.tbSettingsFile)
        Me.tabGeneral.Controls.Add(Me.lblSettings)
        Me.tabGeneral.Controls.Add(Me.btnDbBrowse)
        Me.tabGeneral.Controls.Add(Me.tbDbLocation)
        Me.tabGeneral.Controls.Add(Me.lblDbLocation)
        Me.tabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Size = New System.Drawing.Size(396, 284)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        Me.tabGeneral.UseVisualStyleBackColor = True
        '
        'btnScheduleBrowse
        '
        Me.btnScheduleBrowse.Location = New System.Drawing.Point(336, 93)
        Me.btnScheduleBrowse.Name = "btnScheduleBrowse"
        Me.btnScheduleBrowse.Size = New System.Drawing.Size(50, 20)
        Me.btnScheduleBrowse.TabIndex = 20
        Me.btnScheduleBrowse.Text = "Browse"
        Me.btnScheduleBrowse.UseVisualStyleBackColor = True
        '
        'tbScheduleLocation
        '
        Me.tbScheduleLocation.Location = New System.Drawing.Point(123, 93)
        Me.tbScheduleLocation.Name = "tbScheduleLocation"
        Me.tbScheduleLocation.Size = New System.Drawing.Size(208, 20)
        Me.tbScheduleLocation.TabIndex = 19
        Me.tbScheduleLocation.TabStop = False
        '
        'lblScheduleLocation
        '
        Me.lblScheduleLocation.AutoSize = True
        Me.lblScheduleLocation.Location = New System.Drawing.Point(18, 93)
        Me.lblScheduleLocation.Name = "lblScheduleLocation"
        Me.lblScheduleLocation.Size = New System.Drawing.Size(99, 13)
        Me.lblScheduleLocation.TabIndex = 18
        Me.lblScheduleLocation.Text = "Schedule Location:"
        Me.lblScheduleLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnLogsBrowse
        '
        Me.btnLogsBrowse.Location = New System.Drawing.Point(336, 67)
        Me.btnLogsBrowse.Name = "btnLogsBrowse"
        Me.btnLogsBrowse.Size = New System.Drawing.Size(50, 20)
        Me.btnLogsBrowse.TabIndex = 17
        Me.btnLogsBrowse.Text = "Browse"
        Me.btnLogsBrowse.UseVisualStyleBackColor = True
        '
        'tbLogsLocation
        '
        Me.tbLogsLocation.Location = New System.Drawing.Point(123, 67)
        Me.tbLogsLocation.Name = "tbLogsLocation"
        Me.tbLogsLocation.Size = New System.Drawing.Size(208, 20)
        Me.tbLogsLocation.TabIndex = 16
        Me.tbLogsLocation.TabStop = False
        '
        'lblLogs
        '
        Me.lblLogs.AutoSize = True
        Me.lblLogs.Location = New System.Drawing.Point(40, 71)
        Me.lblLogs.Name = "lblLogs"
        Me.lblLogs.Size = New System.Drawing.Size(77, 13)
        Me.lblLogs.TabIndex = 15
        Me.lblLogs.Text = "Logs Location:"
        Me.lblLogs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBrowseSettingsFile
        '
        Me.btnBrowseSettingsFile.Location = New System.Drawing.Point(336, 41)
        Me.btnBrowseSettingsFile.Name = "btnBrowseSettingsFile"
        Me.btnBrowseSettingsFile.Size = New System.Drawing.Size(50, 20)
        Me.btnBrowseSettingsFile.TabIndex = 14
        Me.btnBrowseSettingsFile.Text = "Browse"
        Me.btnBrowseSettingsFile.UseVisualStyleBackColor = True
        '
        'tbSettingsFile
        '
        Me.tbSettingsFile.Location = New System.Drawing.Point(123, 41)
        Me.tbSettingsFile.Name = "tbSettingsFile"
        Me.tbSettingsFile.Size = New System.Drawing.Size(208, 20)
        Me.tbSettingsFile.TabIndex = 13
        Me.tbSettingsFile.TabStop = False
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Location = New System.Drawing.Point(50, 45)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(67, 13)
        Me.lblSettings.TabIndex = 12
        Me.lblSettings.Text = "Settings File:"
        Me.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDbBrowse
        '
        Me.btnDbBrowse.Location = New System.Drawing.Point(336, 15)
        Me.btnDbBrowse.Name = "btnDbBrowse"
        Me.btnDbBrowse.Size = New System.Drawing.Size(50, 20)
        Me.btnDbBrowse.TabIndex = 11
        Me.btnDbBrowse.Text = "Browse"
        Me.btnDbBrowse.UseVisualStyleBackColor = True
        '
        'tbDbLocation
        '
        Me.tbDbLocation.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.tbDbLocation.Location = New System.Drawing.Point(123, 15)
        Me.tbDbLocation.Name = "tbDbLocation"
        Me.tbDbLocation.Size = New System.Drawing.Size(208, 20)
        Me.tbDbLocation.TabIndex = 10
        Me.tbDbLocation.TabStop = False
        '
        'lblDbLocation
        '
        Me.lblDbLocation.AutoSize = True
        Me.lblDbLocation.Location = New System.Drawing.Point(17, 18)
        Me.lblDbLocation.Name = "lblDbLocation"
        Me.lblDbLocation.Size = New System.Drawing.Size(100, 13)
        Me.lblDbLocation.TabIndex = 9
        Me.lblDbLocation.Text = "Database Location:"
        Me.lblDbLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabSchedule
        '
        Me.tabSchedule.Controls.Add(Me.btnScheduleHelp)
        Me.tabSchedule.Controls.Add(Me.lblScheduleFileName)
        Me.tabSchedule.Controls.Add(Me.tbScheduleFileName)
        Me.tabSchedule.Controls.Add(Me.btnScheduleFolderBrowse)
        Me.tabSchedule.Controls.Add(Me.tbScheduleFolder)
        Me.tabSchedule.Controls.Add(Me.lblScheduleFolder)
        Me.tabSchedule.Controls.Add(Me.radScheduleM3U)
        Me.tabSchedule.Controls.Add(Me.radScheduleAllDayDJ)
        Me.tabSchedule.Location = New System.Drawing.Point(4, 22)
        Me.tabSchedule.Name = "tabSchedule"
        Me.tabSchedule.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSchedule.Size = New System.Drawing.Size(396, 284)
        Me.tabSchedule.TabIndex = 8
        Me.tabSchedule.Text = "Schedule"
        Me.tabSchedule.UseVisualStyleBackColor = True
        '
        'btnScheduleHelp
        '
        Me.btnScheduleHelp.Location = New System.Drawing.Point(328, 96)
        Me.btnScheduleHelp.Name = "btnScheduleHelp"
        Me.btnScheduleHelp.Size = New System.Drawing.Size(27, 20)
        Me.btnScheduleHelp.TabIndex = 7
        Me.btnScheduleHelp.Text = "?"
        Me.btnScheduleHelp.UseVisualStyleBackColor = True
        '
        'lblScheduleFileName
        '
        Me.lblScheduleFileName.AutoSize = True
        Me.lblScheduleFileName.Location = New System.Drawing.Point(27, 99)
        Me.lblScheduleFileName.Name = "lblScheduleFileName"
        Me.lblScheduleFileName.Size = New System.Drawing.Size(89, 13)
        Me.lblScheduleFileName.TabIndex = 6
        Me.lblScheduleFileName.Text = "File Name Format"
        '
        'tbScheduleFileName
        '
        Me.tbScheduleFileName.Location = New System.Drawing.Point(123, 96)
        Me.tbScheduleFileName.Name = "tbScheduleFileName"
        Me.tbScheduleFileName.Size = New System.Drawing.Size(190, 20)
        Me.tbScheduleFileName.TabIndex = 5
        '
        'btnScheduleFolderBrowse
        '
        Me.btnScheduleFolderBrowse.Location = New System.Drawing.Point(326, 62)
        Me.btnScheduleFolderBrowse.Name = "btnScheduleFolderBrowse"
        Me.btnScheduleFolderBrowse.Size = New System.Drawing.Size(54, 20)
        Me.btnScheduleFolderBrowse.TabIndex = 4
        Me.btnScheduleFolderBrowse.Text = "Browse"
        Me.btnScheduleFolderBrowse.UseVisualStyleBackColor = True
        '
        'tbScheduleFolder
        '
        Me.tbScheduleFolder.Location = New System.Drawing.Point(122, 63)
        Me.tbScheduleFolder.Name = "tbScheduleFolder"
        Me.tbScheduleFolder.ReadOnly = True
        Me.tbScheduleFolder.Size = New System.Drawing.Size(192, 20)
        Me.tbScheduleFolder.TabIndex = 3
        '
        'lblScheduleFolder
        '
        Me.lblScheduleFolder.AutoSize = True
        Me.lblScheduleFolder.Location = New System.Drawing.Point(45, 66)
        Me.lblScheduleFolder.Name = "lblScheduleFolder"
        Me.lblScheduleFolder.Size = New System.Drawing.Size(71, 13)
        Me.lblScheduleFolder.TabIndex = 2
        Me.lblScheduleFolder.Text = "Playlist Folder"
        '
        'radScheduleM3U
        '
        Me.radScheduleM3U.AutoSize = True
        Me.radScheduleM3U.Location = New System.Drawing.Point(17, 38)
        Me.radScheduleM3U.Name = "radScheduleM3U"
        Me.radScheduleM3U.Size = New System.Drawing.Size(121, 17)
        Me.radScheduleM3U.TabIndex = 1
        Me.radScheduleM3U.Text = "Use M3U Scheduler"
        Me.radScheduleM3U.UseVisualStyleBackColor = True
        '
        'radScheduleAllDayDJ
        '
        Me.radScheduleAllDayDJ.AutoSize = True
        Me.radScheduleAllDayDJ.Checked = True
        Me.radScheduleAllDayDJ.Location = New System.Drawing.Point(17, 15)
        Me.radScheduleAllDayDJ.Name = "radScheduleAllDayDJ"
        Me.radScheduleAllDayDJ.Size = New System.Drawing.Size(144, 17)
        Me.radScheduleAllDayDJ.TabIndex = 0
        Me.radScheduleAllDayDJ.TabStop = True
        Me.radScheduleAllDayDJ.Text = "Use AllDay DJ Scheduler"
        Me.radScheduleAllDayDJ.UseVisualStyleBackColor = True
        '
        'tabAudioHardware
        '
        Me.tabAudioHardware.Controls.Add(Me.cmbIPPan)
        Me.tabAudioHardware.Controls.Add(Me.cmbIP)
        Me.tabAudioHardware.Controls.Add(Me.lblIP)
        Me.tabAudioHardware.Controls.Add(Me.cmbPanPFL)
        Me.tabAudioHardware.Controls.Add(Me.cmbPFL)
        Me.tabAudioHardware.Controls.Add(Me.lblPreFade)
        Me.tabAudioHardware.Controls.Add(Me.cmbPan4)
        Me.tabAudioHardware.Controls.Add(Me.cmbCards4)
        Me.tabAudioHardware.Controls.Add(Me.cmbPan3)
        Me.tabAudioHardware.Controls.Add(Me.cmbCards3)
        Me.tabAudioHardware.Controls.Add(Me.cmbPan2)
        Me.tabAudioHardware.Controls.Add(Me.cmbCards2)
        Me.tabAudioHardware.Controls.Add(Me.cmbPan1)
        Me.tabAudioHardware.Controls.Add(Me.cmbCards1)
        Me.tabAudioHardware.Controls.Add(Me.lbl4)
        Me.tabAudioHardware.Controls.Add(Me.lbl3)
        Me.tabAudioHardware.Controls.Add(Me.lbl2)
        Me.tabAudioHardware.Controls.Add(Me.lbl1)
        Me.tabAudioHardware.Controls.Add(Me.lblPlayers)
        Me.tabAudioHardware.Location = New System.Drawing.Point(4, 22)
        Me.tabAudioHardware.Name = "tabAudioHardware"
        Me.tabAudioHardware.Size = New System.Drawing.Size(396, 284)
        Me.tabAudioHardware.TabIndex = 1
        Me.tabAudioHardware.Text = "Audio Hardware"
        Me.tabAudioHardware.UseVisualStyleBackColor = True
        '
        'cmbIPPan
        '
        Me.cmbIPPan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIPPan.FormattingEnabled = True
        Me.cmbIPPan.Items.AddRange(New Object() {"Centre", "Left", "Right"})
        Me.cmbIPPan.Location = New System.Drawing.Point(294, 224)
        Me.cmbIPPan.Name = "cmbIPPan"
        Me.cmbIPPan.Size = New System.Drawing.Size(95, 21)
        Me.cmbIPPan.TabIndex = 32
        '
        'cmbIP
        '
        Me.cmbIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIP.FormattingEnabled = True
        Me.cmbIP.Location = New System.Drawing.Point(59, 225)
        Me.cmbIP.Name = "cmbIP"
        Me.cmbIP.Size = New System.Drawing.Size(229, 21)
        Me.cmbIP.TabIndex = 31
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(5, 200)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(76, 13)
        Me.lblIP.TabIndex = 30
        Me.lblIP.Text = "Instant Players"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPanPFL
        '
        Me.cmbPanPFL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPanPFL.FormattingEnabled = True
        Me.cmbPanPFL.Items.AddRange(New Object() {"Centre", "Left", "Right"})
        Me.cmbPanPFL.Location = New System.Drawing.Point(294, 170)
        Me.cmbPanPFL.Name = "cmbPanPFL"
        Me.cmbPanPFL.Size = New System.Drawing.Size(95, 21)
        Me.cmbPanPFL.TabIndex = 29
        '
        'cmbPFL
        '
        Me.cmbPFL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPFL.FormattingEnabled = True
        Me.cmbPFL.Location = New System.Drawing.Point(59, 171)
        Me.cmbPFL.Name = "cmbPFL"
        Me.cmbPFL.Size = New System.Drawing.Size(229, 21)
        Me.cmbPFL.TabIndex = 28
        '
        'lblPreFade
        '
        Me.lblPreFade.AutoSize = True
        Me.lblPreFade.Location = New System.Drawing.Point(5, 153)
        Me.lblPreFade.Name = "lblPreFade"
        Me.lblPreFade.Size = New System.Drawing.Size(50, 13)
        Me.lblPreFade.TabIndex = 27
        Me.lblPreFade.Text = "Pre Fade"
        Me.lblPreFade.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPan4
        '
        Me.cmbPan4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPan4.FormattingEnabled = True
        Me.cmbPan4.Items.AddRange(New Object() {"Centre", "Left", "Right"})
        Me.cmbPan4.Location = New System.Drawing.Point(294, 114)
        Me.cmbPan4.Name = "cmbPan4"
        Me.cmbPan4.Size = New System.Drawing.Size(95, 21)
        Me.cmbPan4.TabIndex = 25
        '
        'cmbCards4
        '
        Me.cmbCards4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCards4.FormattingEnabled = True
        Me.cmbCards4.Location = New System.Drawing.Point(59, 115)
        Me.cmbCards4.Name = "cmbCards4"
        Me.cmbCards4.Size = New System.Drawing.Size(229, 21)
        Me.cmbCards4.TabIndex = 24
        '
        'cmbPan3
        '
        Me.cmbPan3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPan3.FormattingEnabled = True
        Me.cmbPan3.Items.AddRange(New Object() {"Centre", "Left", "Right"})
        Me.cmbPan3.Location = New System.Drawing.Point(294, 87)
        Me.cmbPan3.Name = "cmbPan3"
        Me.cmbPan3.Size = New System.Drawing.Size(95, 21)
        Me.cmbPan3.TabIndex = 23
        '
        'cmbCards3
        '
        Me.cmbCards3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCards3.FormattingEnabled = True
        Me.cmbCards3.Location = New System.Drawing.Point(59, 88)
        Me.cmbCards3.Name = "cmbCards3"
        Me.cmbCards3.Size = New System.Drawing.Size(229, 21)
        Me.cmbCards3.TabIndex = 22
        '
        'cmbPan2
        '
        Me.cmbPan2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPan2.FormattingEnabled = True
        Me.cmbPan2.Items.AddRange(New Object() {"Centre", "Left", "Right"})
        Me.cmbPan2.Location = New System.Drawing.Point(294, 60)
        Me.cmbPan2.Name = "cmbPan2"
        Me.cmbPan2.Size = New System.Drawing.Size(95, 21)
        Me.cmbPan2.TabIndex = 21
        '
        'cmbCards2
        '
        Me.cmbCards2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCards2.FormattingEnabled = True
        Me.cmbCards2.Location = New System.Drawing.Point(59, 61)
        Me.cmbCards2.Name = "cmbCards2"
        Me.cmbCards2.Size = New System.Drawing.Size(229, 21)
        Me.cmbCards2.TabIndex = 20
        '
        'cmbPan1
        '
        Me.cmbPan1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPan1.FormattingEnabled = True
        Me.cmbPan1.Items.AddRange(New Object() {"Centre", "Left", "Right"})
        Me.cmbPan1.Location = New System.Drawing.Point(294, 33)
        Me.cmbPan1.Name = "cmbPan1"
        Me.cmbPan1.Size = New System.Drawing.Size(95, 21)
        Me.cmbPan1.TabIndex = 19
        '
        'cmbCards1
        '
        Me.cmbCards1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCards1.FormattingEnabled = True
        Me.cmbCards1.Location = New System.Drawing.Point(59, 34)
        Me.cmbCards1.Name = "cmbCards1"
        Me.cmbCards1.Size = New System.Drawing.Size(229, 21)
        Me.cmbCards1.TabIndex = 18
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(40, 117)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(13, 13)
        Me.lbl4.TabIndex = 17
        Me.lbl4.Text = "4"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(40, 89)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(13, 13)
        Me.lbl3.TabIndex = 16
        Me.lbl3.Text = "3"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(40, 63)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(13, 13)
        Me.lbl2.TabIndex = 15
        Me.lbl2.Text = "2"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(40, 36)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(13, 13)
        Me.lbl1.TabIndex = 14
        Me.lbl1.Text = "1"
        '
        'lblPlayers
        '
        Me.lblPlayers.AutoSize = True
        Me.lblPlayers.Location = New System.Drawing.Point(3, 9)
        Me.lblPlayers.Name = "lblPlayers"
        Me.lblPlayers.Size = New System.Drawing.Size(67, 13)
        Me.lblPlayers.TabIndex = 13
        Me.lblPlayers.Text = "Main Players"
        '
        'tabAudioSettings
        '
        Me.tabAudioSettings.Controls.Add(Me.gbOther)
        Me.tabAudioSettings.Controls.Add(Me.gbDucker)
        Me.tabAudioSettings.Location = New System.Drawing.Point(4, 22)
        Me.tabAudioSettings.Name = "tabAudioSettings"
        Me.tabAudioSettings.Size = New System.Drawing.Size(396, 284)
        Me.tabAudioSettings.TabIndex = 2
        Me.tabAudioSettings.Text = "Audio Settings"
        Me.tabAudioSettings.UseVisualStyleBackColor = True
        '
        'gbOther
        '
        Me.gbOther.Controls.Add(Me.chkFitInHour)
        Me.gbOther.Location = New System.Drawing.Point(5, 237)
        Me.gbOther.Name = "gbOther"
        Me.gbOther.Size = New System.Drawing.Size(390, 44)
        Me.gbOther.TabIndex = 0
        Me.gbOther.TabStop = False
        Me.gbOther.Text = "Other"
        '
        'chkFitInHour
        '
        Me.chkFitInHour.AutoSize = True
        Me.chkFitInHour.Location = New System.Drawing.Point(6, 19)
        Me.chkFitInHour.Name = "chkFitInHour"
        Me.chkFitInHour.Size = New System.Drawing.Size(200, 17)
        Me.chkFitInHour.TabIndex = 500
        Me.chkFitInHour.Text = "Fit Items In The Hour? (Experimental)"
        Me.chkFitInHour.UseVisualStyleBackColor = True
        '
        'gbDucker
        '
        Me.gbDucker.Controls.Add(Me.nudRelease)
        Me.gbDucker.Controls.Add(Me.nudAttack)
        Me.gbDucker.Controls.Add(Me.lblRelease)
        Me.gbDucker.Controls.Add(Me.lblAttack)
        Me.gbDucker.Controls.Add(Me.lblFadePercent)
        Me.gbDucker.Controls.Add(Me.lblTriggerPercent)
        Me.gbDucker.Controls.Add(Me.tbFadeVolume)
        Me.gbDucker.Controls.Add(Me.lblFadeVolume)
        Me.gbDucker.Controls.Add(Me.tbTriggerVolume)
        Me.gbDucker.Controls.Add(Me.lblTrigger)
        Me.gbDucker.Controls.Add(Me.chkDucker)
        Me.gbDucker.Location = New System.Drawing.Point(2, 0)
        Me.gbDucker.Name = "gbDucker"
        Me.gbDucker.Size = New System.Drawing.Size(393, 231)
        Me.gbDucker.TabIndex = 10
        Me.gbDucker.TabStop = False
        Me.gbDucker.Text = "Ducker"
        '
        'nudRelease
        '
        Me.nudRelease.Location = New System.Drawing.Point(96, 183)
        Me.nudRelease.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.nudRelease.Name = "nudRelease"
        Me.nudRelease.Size = New System.Drawing.Size(46, 20)
        Me.nudRelease.TabIndex = 23
        Me.nudRelease.Value = New Decimal(New Integer() {5000, 0, 0, 0})
        '
        'nudAttack
        '
        Me.nudAttack.Location = New System.Drawing.Point(96, 157)
        Me.nudAttack.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.nudAttack.Name = "nudAttack"
        Me.nudAttack.Size = New System.Drawing.Size(46, 20)
        Me.nudAttack.TabIndex = 22
        Me.nudAttack.Value = New Decimal(New Integer() {5000, 0, 0, 0})
        '
        'lblRelease
        '
        Me.lblRelease.AutoSize = True
        Me.lblRelease.Location = New System.Drawing.Point(19, 185)
        Me.lblRelease.Name = "lblRelease"
        Me.lblRelease.Size = New System.Drawing.Size(68, 13)
        Me.lblRelease.TabIndex = 21
        Me.lblRelease.Text = "Release (ms)"
        Me.lblRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAttack
        '
        Me.lblAttack.AutoSize = True
        Me.lblAttack.Location = New System.Drawing.Point(27, 159)
        Me.lblAttack.Name = "lblAttack"
        Me.lblAttack.Size = New System.Drawing.Size(60, 13)
        Me.lblAttack.TabIndex = 20
        Me.lblAttack.Text = "Attack (ms)"
        Me.lblAttack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFadePercent
        '
        Me.lblFadePercent.AutoSize = True
        Me.lblFadePercent.Location = New System.Drawing.Point(217, 125)
        Me.lblFadePercent.Name = "lblFadePercent"
        Me.lblFadePercent.Size = New System.Drawing.Size(36, 13)
        Me.lblFadePercent.TabIndex = 19
        Me.lblFadePercent.Text = "XXX%"
        Me.lblFadePercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTriggerPercent
        '
        Me.lblTriggerPercent.AutoSize = True
        Me.lblTriggerPercent.Location = New System.Drawing.Point(217, 74)
        Me.lblTriggerPercent.Name = "lblTriggerPercent"
        Me.lblTriggerPercent.Size = New System.Drawing.Size(36, 13)
        Me.lblTriggerPercent.TabIndex = 18
        Me.lblTriggerPercent.Text = "XXX%"
        Me.lblTriggerPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbFadeVolume
        '
        Me.tbFadeVolume.Location = New System.Drawing.Point(96, 93)
        Me.tbFadeVolume.Maximum = 100
        Me.tbFadeVolume.Name = "tbFadeVolume"
        Me.tbFadeVolume.Size = New System.Drawing.Size(278, 42)
        Me.tbFadeVolume.TabIndex = 17
        Me.tbFadeVolume.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblFadeVolume
        '
        Me.lblFadeVolume.AutoSize = True
        Me.lblFadeVolume.Location = New System.Drawing.Point(18, 109)
        Me.lblFadeVolume.Name = "lblFadeVolume"
        Me.lblFadeVolume.Size = New System.Drawing.Size(69, 13)
        Me.lblFadeVolume.TabIndex = 16
        Me.lblFadeVolume.Text = "Fade Volume"
        Me.lblFadeVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbTriggerVolume
        '
        Me.tbTriggerVolume.Location = New System.Drawing.Point(96, 42)
        Me.tbTriggerVolume.Maximum = 100
        Me.tbTriggerVolume.Name = "tbTriggerVolume"
        Me.tbTriggerVolume.Size = New System.Drawing.Size(278, 42)
        Me.tbTriggerVolume.TabIndex = 15
        Me.tbTriggerVolume.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblTrigger
        '
        Me.lblTrigger.AutoSize = True
        Me.lblTrigger.Location = New System.Drawing.Point(9, 56)
        Me.lblTrigger.Name = "lblTrigger"
        Me.lblTrigger.Size = New System.Drawing.Size(78, 13)
        Me.lblTrigger.TabIndex = 14
        Me.lblTrigger.Text = "Trigger Volume"
        Me.lblTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkDucker
        '
        Me.chkDucker.AutoSize = True
        Me.chkDucker.Location = New System.Drawing.Point(12, 19)
        Me.chkDucker.Name = "chkDucker"
        Me.chkDucker.Size = New System.Drawing.Size(89, 17)
        Me.chkDucker.TabIndex = 0
        Me.chkDucker.Text = "Use Ducker?"
        Me.chkDucker.UseVisualStyleBackColor = True
        '
        'tabAGC
        '
        Me.tabAGC.Controls.Add(Me.lblGainValue)
        Me.tabAGC.Controls.Add(Me.sldGain)
        Me.tabAGC.Controls.Add(Me.lblGain)
        Me.tabAGC.Controls.Add(Me.lblDelayMs)
        Me.tabAGC.Controls.Add(Me.lblRateMs)
        Me.tabAGC.Controls.Add(Me.lblMinPercent)
        Me.tabAGC.Controls.Add(Me.lblTargetPercent)
        Me.tabAGC.Controls.Add(Me.lblEnable)
        Me.tabAGC.Controls.Add(Me.sldDelay)
        Me.tabAGC.Controls.Add(Me.lblDelay)
        Me.tabAGC.Controls.Add(Me.sldRate)
        Me.tabAGC.Controls.Add(Me.lblAdjust)
        Me.tabAGC.Controls.Add(Me.sldMin)
        Me.tabAGC.Controls.Add(Me.lblMin)
        Me.tabAGC.Controls.Add(Me.sldTarget)
        Me.tabAGC.Controls.Add(Me.lblTarget)
        Me.tabAGC.Controls.Add(Me.chkEnableAGC)
        Me.tabAGC.Location = New System.Drawing.Point(4, 22)
        Me.tabAGC.Name = "tabAGC"
        Me.tabAGC.Size = New System.Drawing.Size(396, 284)
        Me.tabAGC.TabIndex = 3
        Me.tabAGC.Text = "AGC"
        Me.tabAGC.UseVisualStyleBackColor = True
        '
        'lblGainValue
        '
        Me.lblGainValue.AutoSize = True
        Me.lblGainValue.Location = New System.Drawing.Point(224, 56)
        Me.lblGainValue.Name = "lblGainValue"
        Me.lblGainValue.Size = New System.Drawing.Size(28, 13)
        Me.lblGainValue.TabIndex = 25
        Me.lblGainValue.Text = "XXX"
        '
        'sldGain
        '
        Me.sldGain.Location = New System.Drawing.Point(104, 24)
        Me.sldGain.Maximum = 100
        Me.sldGain.Name = "sldGain"
        Me.sldGain.Size = New System.Drawing.Size(278, 42)
        Me.sldGain.TabIndex = 24
        Me.sldGain.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblGain
        '
        Me.lblGain.AutoSize = True
        Me.lblGain.Location = New System.Drawing.Point(69, 40)
        Me.lblGain.Name = "lblGain"
        Me.lblGain.Size = New System.Drawing.Size(29, 13)
        Me.lblGain.TabIndex = 23
        Me.lblGain.Text = "Gain"
        Me.lblGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDelayMs
        '
        Me.lblDelayMs.AutoSize = True
        Me.lblDelayMs.Location = New System.Drawing.Point(224, 260)
        Me.lblDelayMs.Name = "lblDelayMs"
        Me.lblDelayMs.Size = New System.Drawing.Size(41, 13)
        Me.lblDelayMs.TabIndex = 22
        Me.lblDelayMs.Text = "XXXms"
        '
        'lblRateMs
        '
        Me.lblRateMs.AutoSize = True
        Me.lblRateMs.Location = New System.Drawing.Point(224, 209)
        Me.lblRateMs.Name = "lblRateMs"
        Me.lblRateMs.Size = New System.Drawing.Size(28, 13)
        Me.lblRateMs.TabIndex = 21
        Me.lblRateMs.Text = "XXX"
        '
        'lblMinPercent
        '
        Me.lblMinPercent.AutoSize = True
        Me.lblMinPercent.Location = New System.Drawing.Point(224, 158)
        Me.lblMinPercent.Name = "lblMinPercent"
        Me.lblMinPercent.Size = New System.Drawing.Size(36, 13)
        Me.lblMinPercent.TabIndex = 20
        Me.lblMinPercent.Text = "XXX%"
        '
        'lblTargetPercent
        '
        Me.lblTargetPercent.AutoSize = True
        Me.lblTargetPercent.Location = New System.Drawing.Point(224, 107)
        Me.lblTargetPercent.Name = "lblTargetPercent"
        Me.lblTargetPercent.Size = New System.Drawing.Size(36, 13)
        Me.lblTargetPercent.TabIndex = 19
        Me.lblTargetPercent.Text = "XXX%"
        '
        'lblEnable
        '
        Me.lblEnable.AutoSize = True
        Me.lblEnable.Location = New System.Drawing.Point(33, 9)
        Me.lblEnable.Name = "lblEnable"
        Me.lblEnable.Size = New System.Drawing.Size(65, 13)
        Me.lblEnable.TabIndex = 18
        Me.lblEnable.Text = "Enable AGC"
        Me.lblEnable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sldDelay
        '
        Me.sldDelay.Location = New System.Drawing.Point(104, 228)
        Me.sldDelay.Maximum = 500
        Me.sldDelay.Name = "sldDelay"
        Me.sldDelay.Size = New System.Drawing.Size(278, 42)
        Me.sldDelay.TabIndex = 17
        Me.sldDelay.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblDelay
        '
        Me.lblDelay.AutoSize = True
        Me.lblDelay.Location = New System.Drawing.Point(48, 240)
        Me.lblDelay.Name = "lblDelay"
        Me.lblDelay.Size = New System.Drawing.Size(34, 13)
        Me.lblDelay.TabIndex = 16
        Me.lblDelay.Text = "Delay"
        Me.lblDelay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sldRate
        '
        Me.sldRate.Location = New System.Drawing.Point(104, 177)
        Me.sldRate.Maximum = 500
        Me.sldRate.Name = "sldRate"
        Me.sldRate.Size = New System.Drawing.Size(278, 42)
        Me.sldRate.TabIndex = 15
        Me.sldRate.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblAdjust
        '
        Me.lblAdjust.AutoSize = True
        Me.lblAdjust.Location = New System.Drawing.Point(13, 194)
        Me.lblAdjust.Name = "lblAdjust"
        Me.lblAdjust.Size = New System.Drawing.Size(85, 13)
        Me.lblAdjust.TabIndex = 14
        Me.lblAdjust.Text = "Adjustment Rate"
        Me.lblAdjust.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sldMin
        '
        Me.sldMin.Location = New System.Drawing.Point(104, 126)
        Me.sldMin.Maximum = 100
        Me.sldMin.Name = "sldMin"
        Me.sldMin.Size = New System.Drawing.Size(278, 42)
        Me.sldMin.TabIndex = 13
        Me.sldMin.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(12, 141)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(86, 13)
        Me.lblMin.TabIndex = 12
        Me.lblMin.Text = "Minimum Volume"
        Me.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sldTarget
        '
        Me.sldTarget.Location = New System.Drawing.Point(104, 75)
        Me.sldTarget.Maximum = 100
        Me.sldTarget.Name = "sldTarget"
        Me.sldTarget.Size = New System.Drawing.Size(278, 42)
        Me.sldTarget.TabIndex = 11
        Me.sldTarget.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblTarget
        '
        Me.lblTarget.AutoSize = True
        Me.lblTarget.Location = New System.Drawing.Point(22, 91)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(76, 13)
        Me.lblTarget.TabIndex = 10
        Me.lblTarget.Text = "Target Volume"
        Me.lblTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkEnableAGC
        '
        Me.chkEnableAGC.AutoSize = True
        Me.chkEnableAGC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEnableAGC.Location = New System.Drawing.Point(104, 8)
        Me.chkEnableAGC.Name = "chkEnableAGC"
        Me.chkEnableAGC.Size = New System.Drawing.Size(15, 14)
        Me.chkEnableAGC.TabIndex = 1
        Me.chkEnableAGC.UseVisualStyleBackColor = True
        '
        'tabCompressor
        '
        Me.tabCompressor.Controls.Add(Me.lblThresholdValue)
        Me.tabCompressor.Controls.Add(Me.lblReleaseTimeValue)
        Me.tabCompressor.Controls.Add(Me.lblAttackTimeValue)
        Me.tabCompressor.Controls.Add(Me.lblEnableCompressor)
        Me.tabCompressor.Controls.Add(Me.tbThreshold)
        Me.tabCompressor.Controls.Add(Me.Label5)
        Me.tabCompressor.Controls.Add(Me.tbReleaseTime)
        Me.tabCompressor.Controls.Add(Me.lblReleaseTime)
        Me.tabCompressor.Controls.Add(Me.tbAttackTime)
        Me.tabCompressor.Controls.Add(Me.lblAttackTime)
        Me.tabCompressor.Controls.Add(Me.chkCompressor)
        Me.tabCompressor.Location = New System.Drawing.Point(4, 22)
        Me.tabCompressor.Name = "tabCompressor"
        Me.tabCompressor.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCompressor.Size = New System.Drawing.Size(396, 284)
        Me.tabCompressor.TabIndex = 4
        Me.tabCompressor.Text = "Compressor"
        Me.tabCompressor.UseVisualStyleBackColor = True
        '
        'lblThresholdValue
        '
        Me.lblThresholdValue.AutoSize = True
        Me.lblThresholdValue.Location = New System.Drawing.Point(225, 194)
        Me.lblThresholdValue.Name = "lblThresholdValue"
        Me.lblThresholdValue.Size = New System.Drawing.Size(36, 13)
        Me.lblThresholdValue.TabIndex = 32
        Me.lblThresholdValue.Text = "XXX%"
        '
        'lblReleaseTimeValue
        '
        Me.lblReleaseTimeValue.AutoSize = True
        Me.lblReleaseTimeValue.Location = New System.Drawing.Point(225, 143)
        Me.lblReleaseTimeValue.Name = "lblReleaseTimeValue"
        Me.lblReleaseTimeValue.Size = New System.Drawing.Size(41, 13)
        Me.lblReleaseTimeValue.TabIndex = 31
        Me.lblReleaseTimeValue.Text = "XXXms"
        '
        'lblAttackTimeValue
        '
        Me.lblAttackTimeValue.AutoSize = True
        Me.lblAttackTimeValue.Location = New System.Drawing.Point(225, 92)
        Me.lblAttackTimeValue.Name = "lblAttackTimeValue"
        Me.lblAttackTimeValue.Size = New System.Drawing.Size(41, 13)
        Me.lblAttackTimeValue.TabIndex = 30
        Me.lblAttackTimeValue.Text = "XXXms"
        '
        'lblEnableCompressor
        '
        Me.lblEnableCompressor.AutoSize = True
        Me.lblEnableCompressor.Location = New System.Drawing.Point(1, 40)
        Me.lblEnableCompressor.Name = "lblEnableCompressor"
        Me.lblEnableCompressor.Size = New System.Drawing.Size(98, 13)
        Me.lblEnableCompressor.TabIndex = 29
        Me.lblEnableCompressor.Text = "Enable Compressor"
        Me.lblEnableCompressor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbThreshold
        '
        Me.tbThreshold.Location = New System.Drawing.Point(105, 162)
        Me.tbThreshold.Maximum = 100
        Me.tbThreshold.Name = "tbThreshold"
        Me.tbThreshold.Size = New System.Drawing.Size(278, 42)
        Me.tbThreshold.TabIndex = 28
        Me.tbThreshold.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Threshold"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbReleaseTime
        '
        Me.tbReleaseTime.Location = New System.Drawing.Point(105, 111)
        Me.tbReleaseTime.Maximum = 5000
        Me.tbReleaseTime.Name = "tbReleaseTime"
        Me.tbReleaseTime.Size = New System.Drawing.Size(278, 42)
        Me.tbReleaseTime.TabIndex = 26
        Me.tbReleaseTime.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblReleaseTime
        '
        Me.lblReleaseTime.AutoSize = True
        Me.lblReleaseTime.Location = New System.Drawing.Point(27, 127)
        Me.lblReleaseTime.Name = "lblReleaseTime"
        Me.lblReleaseTime.Size = New System.Drawing.Size(72, 13)
        Me.lblReleaseTime.TabIndex = 25
        Me.lblReleaseTime.Text = "Release Time"
        Me.lblReleaseTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbAttackTime
        '
        Me.tbAttackTime.Location = New System.Drawing.Point(105, 60)
        Me.tbAttackTime.Maximum = 1000
        Me.tbAttackTime.Name = "tbAttackTime"
        Me.tbAttackTime.Size = New System.Drawing.Size(278, 42)
        Me.tbAttackTime.TabIndex = 24
        Me.tbAttackTime.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblAttackTime
        '
        Me.lblAttackTime.AutoSize = True
        Me.lblAttackTime.Location = New System.Drawing.Point(35, 76)
        Me.lblAttackTime.Name = "lblAttackTime"
        Me.lblAttackTime.Size = New System.Drawing.Size(64, 13)
        Me.lblAttackTime.TabIndex = 23
        Me.lblAttackTime.Text = "Attack Time"
        Me.lblAttackTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkCompressor
        '
        Me.chkCompressor.AutoSize = True
        Me.chkCompressor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCompressor.Location = New System.Drawing.Point(105, 40)
        Me.chkCompressor.Name = "chkCompressor"
        Me.chkCompressor.Size = New System.Drawing.Size(15, 14)
        Me.chkCompressor.TabIndex = 22
        Me.chkCompressor.UseVisualStyleBackColor = True
        '
        'tabRotation
        '
        Me.tabRotation.Controls.Add(Me.btnDown)
        Me.tabRotation.Controls.Add(Me.btnUp)
        Me.tabRotation.Controls.Add(Me.lbRotation)
        Me.tabRotation.Controls.Add(Me.btnRemove)
        Me.tabRotation.Controls.Add(Me.btnAdd)
        Me.tabRotation.Controls.Add(Me.cmbPlaylists)
        Me.tabRotation.Location = New System.Drawing.Point(4, 22)
        Me.tabRotation.Name = "tabRotation"
        Me.tabRotation.Size = New System.Drawing.Size(396, 284)
        Me.tabRotation.TabIndex = 5
        Me.tabRotation.Text = "Rotation"
        Me.tabRotation.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(345, 133)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(22, 21)
        Me.btnDown.TabIndex = 5
        Me.btnDown.Text = "v"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(345, 106)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(22, 21)
        Me.btnUp.TabIndex = 4
        Me.btnUp.Text = "^"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'lbRotation
        '
        Me.lbRotation.FormattingEnabled = True
        Me.lbRotation.Location = New System.Drawing.Point(37, 72)
        Me.lbRotation.Name = "lbRotation"
        Me.lbRotation.Size = New System.Drawing.Size(302, 134)
        Me.lbRotation.TabIndex = 3
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(301, 45)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(38, 21)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "-"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(257, 45)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(38, 21)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cmbPlaylists
        '
        Me.cmbPlaylists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlaylists.FormattingEnabled = True
        Me.cmbPlaylists.Location = New System.Drawing.Point(37, 45)
        Me.cmbPlaylists.Name = "cmbPlaylists"
        Me.cmbPlaylists.Size = New System.Drawing.Size(214, 21)
        Me.cmbPlaylists.TabIndex = 0
        '
        'tabInput
        '
        Me.tabInput.Controls.Add(Me.cmbInput)
        Me.tabInput.Controls.Add(Me.lblInput)
        Me.tabInput.Controls.Add(Me.cmbSoundCard)
        Me.tabInput.Controls.Add(Me.lblSoundCard)
        Me.tabInput.Location = New System.Drawing.Point(4, 22)
        Me.tabInput.Name = "tabInput"
        Me.tabInput.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInput.Size = New System.Drawing.Size(396, 284)
        Me.tabInput.TabIndex = 6
        Me.tabInput.Text = "Soundcard Input"
        Me.tabInput.UseVisualStyleBackColor = True
        '
        'cmbInput
        '
        Me.cmbInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInput.FormattingEnabled = True
        Me.cmbInput.Location = New System.Drawing.Point(41, 85)
        Me.cmbInput.Name = "cmbInput"
        Me.cmbInput.Size = New System.Drawing.Size(312, 21)
        Me.cmbInput.TabIndex = 3
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(17, 69)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(31, 13)
        Me.lblInput.TabIndex = 2
        Me.lblInput.Text = "Input"
        '
        'cmbSoundCard
        '
        Me.cmbSoundCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSoundCard.FormattingEnabled = True
        Me.cmbSoundCard.Location = New System.Drawing.Point(41, 31)
        Me.cmbSoundCard.Name = "cmbSoundCard"
        Me.cmbSoundCard.Size = New System.Drawing.Size(312, 21)
        Me.cmbSoundCard.TabIndex = 1
        '
        'lblSoundCard
        '
        Me.lblSoundCard.AutoSize = True
        Me.lblSoundCard.Location = New System.Drawing.Point(17, 15)
        Me.lblSoundCard.Name = "lblSoundCard"
        Me.lblSoundCard.Size = New System.Drawing.Size(63, 13)
        Me.lblSoundCard.TabIndex = 0
        Me.lblSoundCard.Text = "Sound Card"
        '
        'tabDisplay
        '
        Me.tabDisplay.Controls.Add(Me.cbDisplayAlwaysMixer)
        Me.tabDisplay.Controls.Add(Me.cbDisplayAlwaysLibrary)
        Me.tabDisplay.Controls.Add(Me.cmbScreenMixer)
        Me.tabDisplay.Controls.Add(Me.Label3)
        Me.tabDisplay.Controls.Add(Me.cmbScreenLibrary)
        Me.tabDisplay.Controls.Add(Me.Label2)
        Me.tabDisplay.Controls.Add(Me.cmbScreenMain)
        Me.tabDisplay.Controls.Add(Me.Label1)
        Me.tabDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tabDisplay.Name = "tabDisplay"
        Me.tabDisplay.Size = New System.Drawing.Size(396, 284)
        Me.tabDisplay.TabIndex = 7
        Me.tabDisplay.Text = "Display"
        Me.tabDisplay.UseVisualStyleBackColor = True
        '
        'cbDisplayAlwaysMixer
        '
        Me.cbDisplayAlwaysMixer.AutoSize = True
        Me.cbDisplayAlwaysMixer.Location = New System.Drawing.Point(172, 184)
        Me.cbDisplayAlwaysMixer.Name = "cbDisplayAlwaysMixer"
        Me.cbDisplayAlwaysMixer.Size = New System.Drawing.Size(102, 17)
        Me.cbDisplayAlwaysMixer.TabIndex = 11
        Me.cbDisplayAlwaysMixer.Text = "Display Always?"
        Me.cbDisplayAlwaysMixer.UseVisualStyleBackColor = True
        '
        'cbDisplayAlwaysLibrary
        '
        Me.cbDisplayAlwaysLibrary.AutoSize = True
        Me.cbDisplayAlwaysLibrary.Location = New System.Drawing.Point(172, 109)
        Me.cbDisplayAlwaysLibrary.Name = "cbDisplayAlwaysLibrary"
        Me.cbDisplayAlwaysLibrary.Size = New System.Drawing.Size(102, 17)
        Me.cbDisplayAlwaysLibrary.TabIndex = 10
        Me.cbDisplayAlwaysLibrary.Text = "Display Always?"
        Me.cbDisplayAlwaysLibrary.UseVisualStyleBackColor = True
        '
        'cmbScreenMixer
        '
        Me.cmbScreenMixer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbScreenMixer.FormattingEnabled = True
        Me.cmbScreenMixer.Location = New System.Drawing.Point(37, 182)
        Me.cmbScreenMixer.Name = "cmbScreenMixer"
        Me.cmbScreenMixer.Size = New System.Drawing.Size(114, 21)
        Me.cmbScreenMixer.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mixer"
        '
        'cmbScreenLibrary
        '
        Me.cmbScreenLibrary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbScreenLibrary.FormattingEnabled = True
        Me.cmbScreenLibrary.Location = New System.Drawing.Point(37, 107)
        Me.cmbScreenLibrary.Name = "cmbScreenLibrary"
        Me.cmbScreenLibrary.Size = New System.Drawing.Size(114, 21)
        Me.cmbScreenLibrary.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Record Library"
        '
        'cmbScreenMain
        '
        Me.cmbScreenMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbScreenMain.FormattingEnabled = True
        Me.cmbScreenMain.Location = New System.Drawing.Point(37, 38)
        Me.cmbScreenMain.Name = "cmbScreenMain"
        Me.cmbScreenMain.Size = New System.Drawing.Size(114, 21)
        Me.cmbScreenMain.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Main Screen"
        '
        'ofdDBLocation
        '
        Me.ofdDBLocation.DefaultExt = "mdb"
        Me.ofdDBLocation.Filter = "AllDay DJ Record Collection|record_collection.mdb"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(297, 318)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(50, 20)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(353, 318)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(50, 20)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ofdSettingsFile
        '
        Me.ofdSettingsFile.DefaultExt = "dat"
        Me.ofdSettingsFile.Filter = "AllDay DJ Settings|alldaydj.dat"
        '
        'ofdLogsLocation
        '
        Me.ofdLogsLocation.DefaultExt = "dat"
        Me.ofdLogsLocation.Filter = "AllDay DJ Logs|logs.mdb"
        '
        'tmrSliderChange
        '
        '
        'ofdScheduleLocation
        '
        Me.ofdScheduleLocation.DefaultExt = "dat"
        Me.ofdScheduleLocation.Filter = "AllDay DJ  Scheudle|schedule.mdb"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tcSettings)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.tcSettings.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.tabSchedule.ResumeLayout(False)
        Me.tabSchedule.PerformLayout()
        Me.tabAudioHardware.ResumeLayout(False)
        Me.tabAudioHardware.PerformLayout()
        Me.tabAudioSettings.ResumeLayout(False)
        Me.gbOther.ResumeLayout(False)
        Me.gbOther.PerformLayout()
        Me.gbDucker.ResumeLayout(False)
        Me.gbDucker.PerformLayout()
        CType(Me.nudRelease, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAttack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFadeVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTriggerVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAGC.ResumeLayout(False)
        Me.tabAGC.PerformLayout()
        CType(Me.sldGain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sldDelay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sldRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sldMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sldTarget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCompressor.ResumeLayout(False)
        Me.tabCompressor.PerformLayout()
        CType(Me.tbThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbReleaseTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAttackTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRotation.ResumeLayout(False)
        Me.tabInput.ResumeLayout(False)
        Me.tabInput.PerformLayout()
        Me.tabDisplay.ResumeLayout(False)
        Me.tabDisplay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcSettings As System.Windows.Forms.TabControl
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabAudioHardware As System.Windows.Forms.TabPage
    Friend WithEvents tabAudioSettings As System.Windows.Forms.TabPage
    Friend WithEvents ofdDBLocation As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnLogsBrowse As System.Windows.Forms.Button
    Friend WithEvents tbLogsLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblLogs As System.Windows.Forms.Label
    Friend WithEvents btnBrowseSettingsFile As System.Windows.Forms.Button
    Friend WithEvents tbSettingsFile As System.Windows.Forms.TextBox
    Friend WithEvents lblSettings As System.Windows.Forms.Label
    Friend WithEvents btnDbBrowse As System.Windows.Forms.Button
    Friend WithEvents tbDbLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblDbLocation As System.Windows.Forms.Label
    Friend WithEvents cmbPan4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCards4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPan3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCards3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPan2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCards2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPan1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCards1 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayers As System.Windows.Forms.Label
    Friend WithEvents cmbPanPFL As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPFL As System.Windows.Forms.ComboBox
    Friend WithEvents lblPreFade As System.Windows.Forms.Label
    Friend WithEvents ofdSettingsFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofdLogsLocation As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmbIPPan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIP As System.Windows.Forms.ComboBox
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents tabAGC As System.Windows.Forms.TabPage
    Friend WithEvents sldDelay As System.Windows.Forms.TrackBar
    Friend WithEvents lblDelay As System.Windows.Forms.Label
    Friend WithEvents sldRate As System.Windows.Forms.TrackBar
    Friend WithEvents lblAdjust As System.Windows.Forms.Label
    Friend WithEvents sldMin As System.Windows.Forms.TrackBar
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents sldTarget As System.Windows.Forms.TrackBar
    Friend WithEvents lblTarget As System.Windows.Forms.Label
    Friend WithEvents chkEnableAGC As System.Windows.Forms.CheckBox
    Friend WithEvents lblEnable As System.Windows.Forms.Label
    Friend WithEvents lblTargetPercent As System.Windows.Forms.Label
    Friend WithEvents lblDelayMs As System.Windows.Forms.Label
    Friend WithEvents lblRateMs As System.Windows.Forms.Label
    Friend WithEvents lblMinPercent As System.Windows.Forms.Label
    Friend WithEvents tmrSliderChange As System.Windows.Forms.Timer
    Friend WithEvents tabCompressor As System.Windows.Forms.TabPage
    Friend WithEvents tabRotation As System.Windows.Forms.TabPage
    Friend WithEvents lblThresholdValue As System.Windows.Forms.Label
    Friend WithEvents lblReleaseTimeValue As System.Windows.Forms.Label
    Friend WithEvents lblAttackTimeValue As System.Windows.Forms.Label
    Friend WithEvents lblEnableCompressor As System.Windows.Forms.Label
    Friend WithEvents tbThreshold As System.Windows.Forms.TrackBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbReleaseTime As System.Windows.Forms.TrackBar
    Friend WithEvents lblReleaseTime As System.Windows.Forms.Label
    Friend WithEvents tbAttackTime As System.Windows.Forms.TrackBar
    Friend WithEvents lblAttackTime As System.Windows.Forms.Label
    Friend WithEvents chkCompressor As System.Windows.Forms.CheckBox
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents lbRotation As System.Windows.Forms.ListBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cmbPlaylists As System.Windows.Forms.ComboBox
    Friend WithEvents lblGainValue As System.Windows.Forms.Label
    Friend WithEvents sldGain As System.Windows.Forms.TrackBar
    Friend WithEvents lblGain As System.Windows.Forms.Label
    Friend WithEvents btnScheduleBrowse As System.Windows.Forms.Button
    Friend WithEvents tbScheduleLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblScheduleLocation As System.Windows.Forms.Label
    Friend WithEvents ofdScheduleLocation As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gbOther As System.Windows.Forms.GroupBox
    Friend WithEvents chkFitInHour As System.Windows.Forms.CheckBox
    Friend WithEvents gbDucker As System.Windows.Forms.GroupBox
    Friend WithEvents chkDucker As System.Windows.Forms.CheckBox
    Friend WithEvents tbFadeVolume As System.Windows.Forms.TrackBar
    Friend WithEvents lblFadeVolume As System.Windows.Forms.Label
    Friend WithEvents tbTriggerVolume As System.Windows.Forms.TrackBar
    Friend WithEvents lblTrigger As System.Windows.Forms.Label
    Friend WithEvents lblFadePercent As System.Windows.Forms.Label
    Friend WithEvents lblTriggerPercent As System.Windows.Forms.Label
    Friend WithEvents nudRelease As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAttack As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblRelease As System.Windows.Forms.Label
    Friend WithEvents lblAttack As System.Windows.Forms.Label
    Friend WithEvents tabInput As System.Windows.Forms.TabPage
    Friend WithEvents lblSoundCard As System.Windows.Forms.Label
    Friend WithEvents tabDisplay As System.Windows.Forms.TabPage
    Friend WithEvents cmbInput As System.Windows.Forms.ComboBox
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents cmbSoundCard As System.Windows.Forms.ComboBox
    Friend WithEvents cmbScreenLibrary As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbScreenMain As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbDisplayAlwaysMixer As System.Windows.Forms.CheckBox
    Friend WithEvents cbDisplayAlwaysLibrary As System.Windows.Forms.CheckBox
    Friend WithEvents cmbScreenMixer As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tabSchedule As System.Windows.Forms.TabPage
    Friend WithEvents radScheduleM3U As System.Windows.Forms.RadioButton
    Friend WithEvents radScheduleAllDayDJ As System.Windows.Forms.RadioButton
    Friend WithEvents tbScheduleFolder As System.Windows.Forms.TextBox
    Friend WithEvents lblScheduleFolder As System.Windows.Forms.Label
    Friend WithEvents btnScheduleFolderBrowse As System.Windows.Forms.Button
    Friend WithEvents tbScheduleFileName As System.Windows.Forms.TextBox
    Friend WithEvents lblScheduleFileName As System.Windows.Forms.Label
    Friend WithEvents btnScheduleHelp As System.Windows.Forms.Button
    Friend WithEvents fbdM3U As System.Windows.Forms.FolderBrowserDialog
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditTrack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditTrack))
        Me.pnlTrackFile = New System.Windows.Forms.Panel
        Me.lblFile = New System.Windows.Forms.Label
        Me.tbPosition = New System.Windows.Forms.TrackBar
        Me.lblTrackTime = New System.Windows.Forms.Label
        Me.pnlTrackStart = New System.Windows.Forms.Panel
        Me.lblTime1 = New System.Windows.Forms.Label
        Me.btnTest1 = New System.Windows.Forms.Button
        Me.btnStart = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblTime2 = New System.Windows.Forms.Label
        Me.btnTest2 = New System.Windows.Forms.Button
        Me.btnIntroStart = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblTime3 = New System.Windows.Forms.Label
        Me.btnTest3 = New System.Windows.Forms.Button
        Me.btnIntroEnd = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblTime4 = New System.Windows.Forms.Label
        Me.btnTest4 = New System.Windows.Forms.Button
        Me.btnExtro = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lblTime5 = New System.Windows.Forms.Label
        Me.btnTest5 = New System.Windows.Forms.Button
        Me.btnTrackEnd = New System.Windows.Forms.Button
        Me.lblArtist = New System.Windows.Forms.Label
        Me.tbArtist = New System.Windows.Forms.TextBox
        Me.tbTrack = New System.Windows.Forms.TextBox
        Me.lblTrack = New System.Windows.Forms.Label
        Me.tbAlbum = New System.Windows.Forms.TextBox
        Me.lblAlbum = New System.Windows.Forms.Label
        Me.tbTunecode = New System.Windows.Forms.TextBox
        Me.lblTunecode = New System.Windows.Forms.Label
        Me.tbComposer = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbWriter = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbInfo = New System.Windows.Forms.TextBox
        Me.lblInfo = New System.Windows.Forms.Label
        Me.lblEndType = New System.Windows.Forms.Label
        Me.cbEndType = New System.Windows.Forms.ComboBox
        Me.lblPlayOver = New System.Windows.Forms.Label
        Me.cbPlayOver = New System.Windows.Forms.CheckBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnPause = New System.Windows.Forms.Button
        Me.btnPlay = New System.Windows.Forms.Button
        Me.tmrPosition = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTrackFile.SuspendLayout()
        CType(Me.tbPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTrackStart.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTrackFile
        '
        Me.pnlTrackFile.Controls.Add(Me.lblFile)
        Me.pnlTrackFile.Location = New System.Drawing.Point(12, 12)
        Me.pnlTrackFile.Name = "pnlTrackFile"
        Me.pnlTrackFile.Size = New System.Drawing.Size(472, 34)
        Me.pnlTrackFile.TabIndex = 0
        '
        'lblFile
        '
        Me.lblFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFile.Location = New System.Drawing.Point(0, 0)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(472, 34)
        Me.lblFile.TabIndex = 0
        Me.lblFile.Text = "file.name"
        '
        'tbPosition
        '
        Me.tbPosition.Location = New System.Drawing.Point(12, 52)
        Me.tbPosition.Maximum = 100
        Me.tbPosition.Name = "tbPosition"
        Me.tbPosition.Size = New System.Drawing.Size(472, 45)
        Me.tbPosition.TabIndex = 1
        Me.tbPosition.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblTrackTime
        '
        Me.lblTrackTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTrackTime.AutoSize = True
        Me.lblTrackTime.Location = New System.Drawing.Point(400, 83)
        Me.lblTrackTime.Name = "lblTrackTime"
        Me.lblTrackTime.Size = New System.Drawing.Size(72, 13)
        Me.lblTrackTime.TabIndex = 2
        Me.lblTrackTime.Text = "00:00 / 00:00"
        Me.lblTrackTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlTrackStart
        '
        Me.pnlTrackStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTrackStart.Controls.Add(Me.lblTime1)
        Me.pnlTrackStart.Controls.Add(Me.btnTest1)
        Me.pnlTrackStart.Controls.Add(Me.btnStart)
        Me.pnlTrackStart.Location = New System.Drawing.Point(70, 139)
        Me.pnlTrackStart.Name = "pnlTrackStart"
        Me.pnlTrackStart.Size = New System.Drawing.Size(63, 70)
        Me.pnlTrackStart.TabIndex = 3
        '
        'lblTime1
        '
        Me.lblTime1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTime1.Location = New System.Drawing.Point(0, 46)
        Me.lblTime1.Name = "lblTime1"
        Me.lblTime1.Size = New System.Drawing.Size(63, 23)
        Me.lblTime1.TabIndex = 8
        Me.lblTime1.Text = "00:00.0"
        Me.lblTime1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnTest1
        '
        Me.btnTest1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTest1.Location = New System.Drawing.Point(0, 23)
        Me.btnTest1.Name = "btnTest1"
        Me.btnTest1.Size = New System.Drawing.Size(63, 23)
        Me.btnTest1.TabIndex = 7
        Me.btnTest1.Text = "Test"
        Me.btnTest1.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStart.Location = New System.Drawing.Point(0, 0)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(63, 23)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lblTime2)
        Me.Panel1.Controls.Add(Me.btnTest2)
        Me.Panel1.Controls.Add(Me.btnIntroStart)
        Me.Panel1.Location = New System.Drawing.Point(139, 139)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(63, 70)
        Me.Panel1.TabIndex = 4
        '
        'lblTime2
        '
        Me.lblTime2.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTime2.Location = New System.Drawing.Point(0, 46)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.Size = New System.Drawing.Size(63, 23)
        Me.lblTime2.TabIndex = 8
        Me.lblTime2.Text = "00:00.0"
        Me.lblTime2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnTest2
        '
        Me.btnTest2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTest2.Location = New System.Drawing.Point(0, 23)
        Me.btnTest2.Name = "btnTest2"
        Me.btnTest2.Size = New System.Drawing.Size(63, 23)
        Me.btnTest2.TabIndex = 7
        Me.btnTest2.Text = "Test"
        Me.btnTest2.UseVisualStyleBackColor = True
        '
        'btnIntroStart
        '
        Me.btnIntroStart.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIntroStart.Location = New System.Drawing.Point(0, 0)
        Me.btnIntroStart.Name = "btnIntroStart"
        Me.btnIntroStart.Size = New System.Drawing.Size(63, 23)
        Me.btnIntroStart.TabIndex = 6
        Me.btnIntroStart.Text = "Intro Start"
        Me.btnIntroStart.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.lblTime3)
        Me.Panel2.Controls.Add(Me.btnTest3)
        Me.Panel2.Controls.Add(Me.btnIntroEnd)
        Me.Panel2.Location = New System.Drawing.Point(208, 139)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(63, 70)
        Me.Panel2.TabIndex = 5
        '
        'lblTime3
        '
        Me.lblTime3.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTime3.Location = New System.Drawing.Point(0, 46)
        Me.lblTime3.Name = "lblTime3"
        Me.lblTime3.Size = New System.Drawing.Size(63, 23)
        Me.lblTime3.TabIndex = 8
        Me.lblTime3.Text = "00:00.0"
        Me.lblTime3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnTest3
        '
        Me.btnTest3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTest3.Location = New System.Drawing.Point(0, 23)
        Me.btnTest3.Name = "btnTest3"
        Me.btnTest3.Size = New System.Drawing.Size(63, 23)
        Me.btnTest3.TabIndex = 7
        Me.btnTest3.Text = "Test"
        Me.btnTest3.UseVisualStyleBackColor = True
        '
        'btnIntroEnd
        '
        Me.btnIntroEnd.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIntroEnd.Location = New System.Drawing.Point(0, 0)
        Me.btnIntroEnd.Name = "btnIntroEnd"
        Me.btnIntroEnd.Size = New System.Drawing.Size(63, 23)
        Me.btnIntroEnd.TabIndex = 6
        Me.btnIntroEnd.Text = "Intro End"
        Me.btnIntroEnd.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.lblTime4)
        Me.Panel3.Controls.Add(Me.btnTest4)
        Me.Panel3.Controls.Add(Me.btnExtro)
        Me.Panel3.Location = New System.Drawing.Point(277, 139)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(63, 70)
        Me.Panel3.TabIndex = 6
        '
        'lblTime4
        '
        Me.lblTime4.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTime4.Location = New System.Drawing.Point(0, 46)
        Me.lblTime4.Name = "lblTime4"
        Me.lblTime4.Size = New System.Drawing.Size(63, 23)
        Me.lblTime4.TabIndex = 8
        Me.lblTime4.Text = "00:00.0"
        Me.lblTime4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnTest4
        '
        Me.btnTest4.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTest4.Location = New System.Drawing.Point(0, 23)
        Me.btnTest4.Name = "btnTest4"
        Me.btnTest4.Size = New System.Drawing.Size(63, 23)
        Me.btnTest4.TabIndex = 7
        Me.btnTest4.Text = "Test"
        Me.btnTest4.UseVisualStyleBackColor = True
        '
        'btnExtro
        '
        Me.btnExtro.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExtro.Location = New System.Drawing.Point(0, 0)
        Me.btnExtro.Name = "btnExtro"
        Me.btnExtro.Size = New System.Drawing.Size(63, 23)
        Me.btnExtro.TabIndex = 6
        Me.btnExtro.Text = "Extro"
        Me.btnExtro.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.lblTime5)
        Me.Panel4.Controls.Add(Me.btnTest5)
        Me.Panel4.Controls.Add(Me.btnTrackEnd)
        Me.Panel4.Location = New System.Drawing.Point(346, 139)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(63, 70)
        Me.Panel4.TabIndex = 7
        '
        'lblTime5
        '
        Me.lblTime5.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTime5.Location = New System.Drawing.Point(0, 46)
        Me.lblTime5.Name = "lblTime5"
        Me.lblTime5.Size = New System.Drawing.Size(63, 23)
        Me.lblTime5.TabIndex = 8
        Me.lblTime5.Text = "00:00.0"
        Me.lblTime5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnTest5
        '
        Me.btnTest5.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTest5.Location = New System.Drawing.Point(0, 23)
        Me.btnTest5.Name = "btnTest5"
        Me.btnTest5.Size = New System.Drawing.Size(63, 23)
        Me.btnTest5.TabIndex = 7
        Me.btnTest5.Text = "Test"
        Me.btnTest5.UseVisualStyleBackColor = True
        '
        'btnTrackEnd
        '
        Me.btnTrackEnd.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTrackEnd.Location = New System.Drawing.Point(0, 0)
        Me.btnTrackEnd.Name = "btnTrackEnd"
        Me.btnTrackEnd.Size = New System.Drawing.Size(63, 23)
        Me.btnTrackEnd.TabIndex = 6
        Me.btnTrackEnd.Text = "End"
        Me.btnTrackEnd.UseVisualStyleBackColor = True
        '
        'lblArtist
        '
        Me.lblArtist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Location = New System.Drawing.Point(72, 218)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(33, 13)
        Me.lblArtist.TabIndex = 8
        Me.lblArtist.Text = "Artist:"
        Me.lblArtist.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbArtist
        '
        Me.tbArtist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbArtist.Location = New System.Drawing.Point(111, 215)
        Me.tbArtist.Name = "tbArtist"
        Me.tbArtist.Size = New System.Drawing.Size(339, 20)
        Me.tbArtist.TabIndex = 9
        '
        'tbTrack
        '
        Me.tbTrack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTrack.Location = New System.Drawing.Point(111, 241)
        Me.tbTrack.Name = "tbTrack"
        Me.tbTrack.Size = New System.Drawing.Size(339, 20)
        Me.tbTrack.TabIndex = 11
        '
        'lblTrack
        '
        Me.lblTrack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTrack.AutoSize = True
        Me.lblTrack.Location = New System.Drawing.Point(67, 244)
        Me.lblTrack.Name = "lblTrack"
        Me.lblTrack.Size = New System.Drawing.Size(38, 13)
        Me.lblTrack.TabIndex = 10
        Me.lblTrack.Text = "Track:"
        Me.lblTrack.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbAlbum
        '
        Me.tbAlbum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbAlbum.Location = New System.Drawing.Point(111, 267)
        Me.tbAlbum.Name = "tbAlbum"
        Me.tbAlbum.Size = New System.Drawing.Size(339, 20)
        Me.tbAlbum.TabIndex = 13
        '
        'lblAlbum
        '
        Me.lblAlbum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlbum.AutoSize = True
        Me.lblAlbum.Location = New System.Drawing.Point(66, 270)
        Me.lblAlbum.Name = "lblAlbum"
        Me.lblAlbum.Size = New System.Drawing.Size(39, 13)
        Me.lblAlbum.TabIndex = 12
        Me.lblAlbum.Text = "Album:"
        Me.lblAlbum.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbTunecode
        '
        Me.tbTunecode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTunecode.Location = New System.Drawing.Point(111, 293)
        Me.tbTunecode.Name = "tbTunecode"
        Me.tbTunecode.Size = New System.Drawing.Size(339, 20)
        Me.tbTunecode.TabIndex = 15
        '
        'lblTunecode
        '
        Me.lblTunecode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTunecode.AutoSize = True
        Me.lblTunecode.Location = New System.Drawing.Point(46, 296)
        Me.lblTunecode.Name = "lblTunecode"
        Me.lblTunecode.Size = New System.Drawing.Size(59, 13)
        Me.lblTunecode.TabIndex = 14
        Me.lblTunecode.Text = "Tunecode:"
        Me.lblTunecode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbComposer
        '
        Me.tbComposer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbComposer.Location = New System.Drawing.Point(111, 319)
        Me.tbComposer.Name = "tbComposer"
        Me.tbComposer.Size = New System.Drawing.Size(339, 20)
        Me.tbComposer.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Composer / Writer:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbWriter
        '
        Me.tbWriter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbWriter.Location = New System.Drawing.Point(111, 345)
        Me.tbWriter.Name = "tbWriter"
        Me.tbWriter.Size = New System.Drawing.Size(339, 20)
        Me.tbWriter.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Record Company:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbInfo
        '
        Me.tbInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbInfo.Location = New System.Drawing.Point(111, 371)
        Me.tbInfo.Multiline = True
        Me.tbInfo.Name = "tbInfo"
        Me.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbInfo.Size = New System.Drawing.Size(339, 67)
        Me.tbInfo.TabIndex = 21
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(77, 374)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(28, 13)
        Me.lblInfo.TabIndex = 20
        Me.lblInfo.Text = "Info:"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEndType
        '
        Me.lblEndType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEndType.AutoSize = True
        Me.lblEndType.Location = New System.Drawing.Point(49, 447)
        Me.lblEndType.Name = "lblEndType"
        Me.lblEndType.Size = New System.Drawing.Size(56, 13)
        Me.lblEndType.TabIndex = 22
        Me.lblEndType.Text = "End Type:"
        Me.lblEndType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbEndType
        '
        Me.cbEndType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEndType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEndType.FormattingEnabled = True
        Me.cbEndType.Items.AddRange(New Object() {"End", "Sustain", "Fade"})
        Me.cbEndType.Location = New System.Drawing.Point(111, 444)
        Me.cbEndType.Name = "cbEndType"
        Me.cbEndType.Size = New System.Drawing.Size(108, 21)
        Me.cbEndType.TabIndex = 23
        '
        'lblPlayOver
        '
        Me.lblPlayOver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPlayOver.AutoSize = True
        Me.lblPlayOver.Location = New System.Drawing.Point(49, 471)
        Me.lblPlayOver.Name = "lblPlayOver"
        Me.lblPlayOver.Size = New System.Drawing.Size(56, 13)
        Me.lblPlayOver.TabIndex = 24
        Me.lblPlayOver.Text = "Play Over:"
        Me.lblPlayOver.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbPlayOver
        '
        Me.cbPlayOver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPlayOver.AutoSize = True
        Me.cbPlayOver.Location = New System.Drawing.Point(111, 471)
        Me.cbPlayOver.Name = "cbPlayOver"
        Me.cbPlayOver.Size = New System.Drawing.Size(15, 14)
        Me.cbPlayOver.TabIndex = 25
        Me.cbPlayOver.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Location = New System.Drawing.Point(410, 499)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(62, 23)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.Location = New System.Drawing.Point(346, 73)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(31, 31)
        Me.btnStop.TabIndex = 32
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Image = CType(resources.GetObject("btnPause.Image"), System.Drawing.Image)
        Me.btnPause.Location = New System.Drawing.Point(309, 73)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(31, 31)
        Me.btnPause.TabIndex = 31
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Image = CType(resources.GetObject("btnPlay.Image"), System.Drawing.Image)
        Me.btnPlay.Location = New System.Drawing.Point(272, 73)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(31, 31)
        Me.btnPlay.TabIndex = 30
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'tmrPosition
        '
        '
        'frmEditTrack
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSave
        Me.ClientSize = New System.Drawing.Size(500, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbPlayOver)
        Me.Controls.Add(Me.lblPlayOver)
        Me.Controls.Add(Me.cbEndType)
        Me.Controls.Add(Me.lblEndType)
        Me.Controls.Add(Me.tbInfo)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.tbWriter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbComposer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbTunecode)
        Me.Controls.Add(Me.lblTunecode)
        Me.Controls.Add(Me.tbAlbum)
        Me.Controls.Add(Me.lblAlbum)
        Me.Controls.Add(Me.tbTrack)
        Me.Controls.Add(Me.lblTrack)
        Me.Controls.Add(Me.tbArtist)
        Me.Controls.Add(Me.lblArtist)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlTrackStart)
        Me.Controls.Add(Me.lblTrackTime)
        Me.Controls.Add(Me.tbPosition)
        Me.Controls.Add(Me.pnlTrackFile)
        Me.Name = "frmEditTrack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Track - [FILE TITLE.EXT]"
        Me.pnlTrackFile.ResumeLayout(False)
        CType(Me.tbPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTrackStart.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTrackFile As System.Windows.Forms.Panel
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents tbPosition As System.Windows.Forms.TrackBar
    Friend WithEvents lblTrackTime As System.Windows.Forms.Label
    Friend WithEvents pnlTrackStart As System.Windows.Forms.Panel
    Friend WithEvents lblTime1 As System.Windows.Forms.Label
    Friend WithEvents btnTest1 As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTime2 As System.Windows.Forms.Label
    Friend WithEvents btnTest2 As System.Windows.Forms.Button
    Friend WithEvents btnIntroStart As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTime3 As System.Windows.Forms.Label
    Friend WithEvents btnTest3 As System.Windows.Forms.Button
    Friend WithEvents btnIntroEnd As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblTime4 As System.Windows.Forms.Label
    Friend WithEvents btnTest4 As System.Windows.Forms.Button
    Friend WithEvents btnExtro As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblTime5 As System.Windows.Forms.Label
    Friend WithEvents btnTest5 As System.Windows.Forms.Button
    Friend WithEvents btnTrackEnd As System.Windows.Forms.Button
    Friend WithEvents lblArtist As System.Windows.Forms.Label
    Friend WithEvents tbArtist As System.Windows.Forms.TextBox
    Friend WithEvents tbTrack As System.Windows.Forms.TextBox
    Friend WithEvents lblTrack As System.Windows.Forms.Label
    Friend WithEvents tbAlbum As System.Windows.Forms.TextBox
    Friend WithEvents lblAlbum As System.Windows.Forms.Label
    Friend WithEvents tbTunecode As System.Windows.Forms.TextBox
    Friend WithEvents lblTunecode As System.Windows.Forms.Label
    Friend WithEvents tbComposer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbWriter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbInfo As System.Windows.Forms.TextBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblEndType As System.Windows.Forms.Label
    Friend WithEvents cbEndType As System.Windows.Forms.ComboBox
    Friend WithEvents lblPlayOver As System.Windows.Forms.Label
    Friend WithEvents cbPlayOver As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents tmrPosition As System.Windows.Forms.Timer
End Class

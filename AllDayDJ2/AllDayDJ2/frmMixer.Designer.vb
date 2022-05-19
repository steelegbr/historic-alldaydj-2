<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMixer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMixer))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.lblData2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnStop1 = New System.Windows.Forms.Button
        Me.btnPlay1 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnStop2 = New System.Windows.Forms.Button
        Me.btnPlay2 = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnStop3 = New System.Windows.Forms.Button
        Me.btnPlay3 = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnStop4 = New System.Windows.Forms.Button
        Me.btnPlay4 = New System.Windows.Forms.Button
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.VerticalProgressBar2 = New VerticalProgressBar.VerticalProgressBar
        Me.VerticalProgressBar1 = New VerticalProgressBar.VerticalProgressBar
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.VerticalProgressBar7 = New VerticalProgressBar.VerticalProgressBar
        Me.VerticalProgressBar8 = New VerticalProgressBar.VerticalProgressBar
        Me.TrackBar4 = New System.Windows.Forms.TrackBar
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.VerticalProgressBar3 = New VerticalProgressBar.VerticalProgressBar
        Me.VerticalProgressBar4 = New VerticalProgressBar.VerticalProgressBar
        Me.TrackBar2 = New System.Windows.Forms.TrackBar
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.VerticalProgressBar5 = New VerticalProgressBar.VerticalProgressBar
        Me.VerticalProgressBar6 = New VerticalProgressBar.VerticalProgressBar
        Me.TrackBar3 = New System.Windows.Forms.TrackBar
        Me.lblData1 = New System.Windows.Forms.Label
        Me.lblData3 = New System.Windows.Forms.Label
        Me.lblData4 = New System.Windows.Forms.Label
        Me.tmrUpdateLevels = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblData2, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel9, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel7, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel8, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblData1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblData3, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblData4, 6, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(792, 566)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblData2
        '
        Me.lblData2.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblData2, 2)
        Me.lblData2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblData2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData2.Location = New System.Drawing.Point(201, 452)
        Me.lblData2.Name = "lblData2"
        Me.lblData2.Size = New System.Drawing.Size(192, 114)
        Me.lblData2.TabIndex = 46
        Me.lblData2.Text = "Artist:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Title:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Played: 00:00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remaining: 00:00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lime
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player 1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label4, 2)
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(597, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 56)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Player 4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Cyan
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label3, 2)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(399, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 56)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Player 3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label2, 2)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 56)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Player 2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnStop1)
        Me.Panel1.Controls.Add(Me.btnPlay1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(102, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(93, 390)
        Me.Panel1.TabIndex = 10
        '
        'btnStop1
        '
        Me.btnStop1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStop1.Image = CType(resources.GetObject("btnStop1.Image"), System.Drawing.Image)
        Me.btnStop1.Location = New System.Drawing.Point(0, 67)
        Me.btnStop1.Name = "btnStop1"
        Me.btnStop1.Size = New System.Drawing.Size(93, 67)
        Me.btnStop1.TabIndex = 37
        Me.btnStop1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStop1.UseVisualStyleBackColor = True
        '
        'btnPlay1
        '
        Me.btnPlay1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPlay1.Image = CType(resources.GetObject("btnPlay1.Image"), System.Drawing.Image)
        Me.btnPlay1.Location = New System.Drawing.Point(0, 0)
        Me.btnPlay1.Name = "btnPlay1"
        Me.btnPlay1.Size = New System.Drawing.Size(93, 67)
        Me.btnPlay1.TabIndex = 36
        Me.btnPlay1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPlay1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnStop2)
        Me.Panel2.Controls.Add(Me.btnPlay2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(300, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(93, 390)
        Me.Panel2.TabIndex = 11
        '
        'btnStop2
        '
        Me.btnStop2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStop2.Image = CType(resources.GetObject("btnStop2.Image"), System.Drawing.Image)
        Me.btnStop2.Location = New System.Drawing.Point(0, 67)
        Me.btnStop2.Name = "btnStop2"
        Me.btnStop2.Size = New System.Drawing.Size(93, 67)
        Me.btnStop2.TabIndex = 39
        Me.btnStop2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStop2.UseVisualStyleBackColor = True
        '
        'btnPlay2
        '
        Me.btnPlay2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPlay2.Image = CType(resources.GetObject("btnPlay2.Image"), System.Drawing.Image)
        Me.btnPlay2.Location = New System.Drawing.Point(0, 0)
        Me.btnPlay2.Name = "btnPlay2"
        Me.btnPlay2.Size = New System.Drawing.Size(93, 67)
        Me.btnPlay2.TabIndex = 38
        Me.btnPlay2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPlay2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnStop3)
        Me.Panel3.Controls.Add(Me.btnPlay3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(498, 59)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(93, 390)
        Me.Panel3.TabIndex = 12
        '
        'btnStop3
        '
        Me.btnStop3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStop3.Image = CType(resources.GetObject("btnStop3.Image"), System.Drawing.Image)
        Me.btnStop3.Location = New System.Drawing.Point(0, 67)
        Me.btnStop3.Name = "btnStop3"
        Me.btnStop3.Size = New System.Drawing.Size(93, 67)
        Me.btnStop3.TabIndex = 39
        Me.btnStop3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStop3.UseVisualStyleBackColor = True
        '
        'btnPlay3
        '
        Me.btnPlay3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPlay3.Image = CType(resources.GetObject("btnPlay3.Image"), System.Drawing.Image)
        Me.btnPlay3.Location = New System.Drawing.Point(0, 0)
        Me.btnPlay3.Name = "btnPlay3"
        Me.btnPlay3.Size = New System.Drawing.Size(93, 67)
        Me.btnPlay3.TabIndex = 38
        Me.btnPlay3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPlay3.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnStop4)
        Me.Panel4.Controls.Add(Me.btnPlay4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(696, 59)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(93, 390)
        Me.Panel4.TabIndex = 13
        '
        'btnStop4
        '
        Me.btnStop4.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStop4.Image = CType(resources.GetObject("btnStop4.Image"), System.Drawing.Image)
        Me.btnStop4.Location = New System.Drawing.Point(0, 67)
        Me.btnStop4.Name = "btnStop4"
        Me.btnStop4.Size = New System.Drawing.Size(93, 67)
        Me.btnStop4.TabIndex = 39
        Me.btnStop4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStop4.UseVisualStyleBackColor = True
        '
        'btnPlay4
        '
        Me.btnPlay4.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPlay4.Image = CType(resources.GetObject("btnPlay4.Image"), System.Drawing.Image)
        Me.btnPlay4.Location = New System.Drawing.Point(0, 0)
        Me.btnPlay4.Name = "btnPlay4"
        Me.btnPlay4.Size = New System.Drawing.Size(93, 67)
        Me.btnPlay4.TabIndex = 38
        Me.btnPlay4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPlay4.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.VerticalProgressBar2)
        Me.Panel6.Controls.Add(Me.VerticalProgressBar1)
        Me.Panel6.Controls.Add(Me.TrackBar1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 59)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(93, 390)
        Me.Panel6.TabIndex = 40
        '
        'VerticalProgressBar2
        '
        Me.VerticalProgressBar2.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.VerticalProgressBar2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VerticalProgressBar2.Dock = System.Windows.Forms.DockStyle.Right
        Me.VerticalProgressBar2.Location = New System.Drawing.Point(24, 0)
        Me.VerticalProgressBar2.Maximum = 32767
        Me.VerticalProgressBar2.Minimum = 0
        Me.VerticalProgressBar2.Name = "VerticalProgressBar2"
        Me.VerticalProgressBar2.Size = New System.Drawing.Size(12, 390)
        Me.VerticalProgressBar2.Step = 10
        Me.VerticalProgressBar2.Style = VerticalProgressBar.Styles.Classic
        Me.VerticalProgressBar2.TabIndex = 43
        Me.VerticalProgressBar2.Value = 0
        '
        'VerticalProgressBar1
        '
        Me.VerticalProgressBar1.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.VerticalProgressBar1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VerticalProgressBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VerticalProgressBar1.Location = New System.Drawing.Point(36, 0)
        Me.VerticalProgressBar1.Maximum = 32767
        Me.VerticalProgressBar1.Minimum = 0
        Me.VerticalProgressBar1.Name = "VerticalProgressBar1"
        Me.VerticalProgressBar1.Size = New System.Drawing.Size(12, 390)
        Me.VerticalProgressBar1.Step = 10
        Me.VerticalProgressBar1.Style = VerticalProgressBar.Styles.Classic
        Me.VerticalProgressBar1.TabIndex = 42
        Me.VerticalProgressBar1.Value = 0
        '
        'TrackBar1
        '
        Me.TrackBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TrackBar1.Location = New System.Drawing.Point(48, 0)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TrackBar1.Size = New System.Drawing.Size(45, 390)
        Me.TrackBar1.TabIndex = 5
        Me.TrackBar1.TickFrequency = 10
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.VerticalProgressBar7)
        Me.Panel9.Controls.Add(Me.VerticalProgressBar8)
        Me.Panel9.Controls.Add(Me.TrackBar4)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(597, 59)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(93, 390)
        Me.Panel9.TabIndex = 43
        '
        'VerticalProgressBar7
        '
        Me.VerticalProgressBar7.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.VerticalProgressBar7.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VerticalProgressBar7.Dock = System.Windows.Forms.DockStyle.Right
        Me.VerticalProgressBar7.Location = New System.Drawing.Point(24, 0)
        Me.VerticalProgressBar7.Maximum = 32767
        Me.VerticalProgressBar7.Minimum = 0
        Me.VerticalProgressBar7.Name = "VerticalProgressBar7"
        Me.VerticalProgressBar7.Size = New System.Drawing.Size(12, 390)
        Me.VerticalProgressBar7.Step = 10
        Me.VerticalProgressBar7.Style = VerticalProgressBar.Styles.Classic
        Me.VerticalProgressBar7.TabIndex = 45
        Me.VerticalProgressBar7.Value = 0
        '
        'VerticalProgressBar8
        '
        Me.VerticalProgressBar8.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.VerticalProgressBar8.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VerticalProgressBar8.Dock = System.Windows.Forms.DockStyle.Right
        Me.VerticalProgressBar8.Location = New System.Drawing.Point(36, 0)
        Me.VerticalProgressBar8.Maximum = 32767
        Me.VerticalProgressBar8.Minimum = 0
        Me.VerticalProgressBar8.Name = "VerticalProgressBar8"
        Me.VerticalProgressBar8.Size = New System.Drawing.Size(12, 390)
        Me.VerticalProgressBar8.Step = 10
        Me.VerticalProgressBar8.Style = VerticalProgressBar.Styles.Classic
        Me.VerticalProgressBar8.TabIndex = 44
        Me.VerticalProgressBar8.Value = 0
        '
        'TrackBar4
        '
        Me.TrackBar4.Dock = System.Windows.Forms.DockStyle.Right
        Me.TrackBar4.Location = New System.Drawing.Point(48, 0)
        Me.TrackBar4.Maximum = 100
        Me.TrackBar4.Name = "TrackBar4"
        Me.TrackBar4.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TrackBar4.Size = New System.Drawing.Size(45, 390)
        Me.TrackBar4.TabIndex = 8
        Me.TrackBar4.TickFrequency = 10
        Me.TrackBar4.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.VerticalProgressBar3)
        Me.Panel7.Controls.Add(Me.VerticalProgressBar4)
        Me.Panel7.Controls.Add(Me.TrackBar2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(201, 59)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(93, 390)
        Me.Panel7.TabIndex = 41
        '
        'VerticalProgressBar3
        '
        Me.VerticalProgressBar3.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.VerticalProgressBar3.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VerticalProgressBar3.Dock = System.Windows.Forms.DockStyle.Right
        Me.VerticalProgressBar3.Location = New System.Drawing.Point(24, 0)
        Me.VerticalProgressBar3.Maximum = 32767
        Me.VerticalProgressBar3.Minimum = 0
        Me.VerticalProgressBar3.Name = "VerticalProgressBar3"
        Me.VerticalProgressBar3.Size = New System.Drawing.Size(12, 390)
        Me.VerticalProgressBar3.Step = 10
        Me.VerticalProgressBar3.Style = VerticalProgressBar.Styles.Classic
        Me.VerticalProgressBar3.TabIndex = 45
        Me.VerticalProgressBar3.Value = 0
        '
        'VerticalProgressBar4
        '
        Me.VerticalProgressBar4.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.VerticalProgressBar4.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VerticalProgressBar4.Dock = System.Windows.Forms.DockStyle.Right
        Me.VerticalProgressBar4.Location = New System.Drawing.Point(36, 0)
        Me.VerticalProgressBar4.Maximum = 32767
        Me.VerticalProgressBar4.Minimum = 0
        Me.VerticalProgressBar4.Name = "VerticalProgressBar4"
        Me.VerticalProgressBar4.Size = New System.Drawing.Size(12, 390)
        Me.VerticalProgressBar4.Step = 10
        Me.VerticalProgressBar4.Style = VerticalProgressBar.Styles.Classic
        Me.VerticalProgressBar4.TabIndex = 44
        Me.VerticalProgressBar4.Value = 0
        '
        'TrackBar2
        '
        Me.TrackBar2.Dock = System.Windows.Forms.DockStyle.Right
        Me.TrackBar2.Location = New System.Drawing.Point(48, 0)
        Me.TrackBar2.Maximum = 100
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TrackBar2.Size = New System.Drawing.Size(45, 390)
        Me.TrackBar2.TabIndex = 6
        Me.TrackBar2.TickFrequency = 10
        Me.TrackBar2.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.VerticalProgressBar5)
        Me.Panel8.Controls.Add(Me.VerticalProgressBar6)
        Me.Panel8.Controls.Add(Me.TrackBar3)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(399, 59)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(93, 390)
        Me.Panel8.TabIndex = 42
        '
        'VerticalProgressBar5
        '
        Me.VerticalProgressBar5.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.VerticalProgressBar5.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VerticalProgressBar5.Dock = System.Windows.Forms.DockStyle.Right
        Me.VerticalProgressBar5.Location = New System.Drawing.Point(24, 0)
        Me.VerticalProgressBar5.Maximum = 32767
        Me.VerticalProgressBar5.Minimum = 0
        Me.VerticalProgressBar5.Name = "VerticalProgressBar5"
        Me.VerticalProgressBar5.Size = New System.Drawing.Size(12, 390)
        Me.VerticalProgressBar5.Step = 10
        Me.VerticalProgressBar5.Style = VerticalProgressBar.Styles.Classic
        Me.VerticalProgressBar5.TabIndex = 45
        Me.VerticalProgressBar5.Value = 0
        '
        'VerticalProgressBar6
        '
        Me.VerticalProgressBar6.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.VerticalProgressBar6.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VerticalProgressBar6.Dock = System.Windows.Forms.DockStyle.Right
        Me.VerticalProgressBar6.Location = New System.Drawing.Point(36, 0)
        Me.VerticalProgressBar6.Maximum = 32767
        Me.VerticalProgressBar6.Minimum = 0
        Me.VerticalProgressBar6.Name = "VerticalProgressBar6"
        Me.VerticalProgressBar6.Size = New System.Drawing.Size(12, 390)
        Me.VerticalProgressBar6.Step = 10
        Me.VerticalProgressBar6.Style = VerticalProgressBar.Styles.Classic
        Me.VerticalProgressBar6.TabIndex = 44
        Me.VerticalProgressBar6.Value = 0
        '
        'TrackBar3
        '
        Me.TrackBar3.Dock = System.Windows.Forms.DockStyle.Right
        Me.TrackBar3.Location = New System.Drawing.Point(48, 0)
        Me.TrackBar3.Maximum = 100
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TrackBar3.Size = New System.Drawing.Size(45, 390)
        Me.TrackBar3.TabIndex = 7
        Me.TrackBar3.TickFrequency = 10
        Me.TrackBar3.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lblData1
        '
        Me.lblData1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblData1, 2)
        Me.lblData1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData1.Location = New System.Drawing.Point(3, 452)
        Me.lblData1.Name = "lblData1"
        Me.lblData1.Size = New System.Drawing.Size(192, 114)
        Me.lblData1.TabIndex = 45
        Me.lblData1.Text = "Artist:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Title:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Played: 00:00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remaining: 00:00"
        '
        'lblData3
        '
        Me.lblData3.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblData3, 2)
        Me.lblData3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblData3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData3.Location = New System.Drawing.Point(399, 452)
        Me.lblData3.Name = "lblData3"
        Me.lblData3.Size = New System.Drawing.Size(192, 114)
        Me.lblData3.TabIndex = 47
        Me.lblData3.Text = "Artist:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Title:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Played: 00:00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remaining: 00:00"
        '
        'lblData4
        '
        Me.lblData4.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblData4, 2)
        Me.lblData4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblData4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData4.Location = New System.Drawing.Point(597, 452)
        Me.lblData4.Name = "lblData4"
        Me.lblData4.Size = New System.Drawing.Size(192, 114)
        Me.lblData4.TabIndex = 48
        Me.lblData4.Text = "Artist:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Title:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Played: 00:00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remaining: 00:00"
        '
        'tmrUpdateLevels
        '
        Me.tmrUpdateLevels.Enabled = True
        '
        'frmMixer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "frmMixer"
        Me.Text = "AllDay DJ Mixer"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TrackBar4 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar3 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnStop1 As System.Windows.Forms.Button
    Friend WithEvents btnPlay1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnStop2 As System.Windows.Forms.Button
    Friend WithEvents btnPlay2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnStop3 As System.Windows.Forms.Button
    Friend WithEvents btnPlay3 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnStop4 As System.Windows.Forms.Button
    Friend WithEvents btnPlay4 As System.Windows.Forms.Button
    Friend WithEvents tmrUpdateLevels As System.Windows.Forms.Timer
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents VerticalProgressBar2 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents VerticalProgressBar1 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents VerticalProgressBar7 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents VerticalProgressBar8 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents VerticalProgressBar3 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents VerticalProgressBar4 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents VerticalProgressBar5 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents VerticalProgressBar6 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents lblData1 As System.Windows.Forms.Label
    Friend WithEvents lblData2 As System.Windows.Forms.Label
    Friend WithEvents lblData3 As System.Windows.Forms.Label
    Friend WithEvents lblData4 As System.Windows.Forms.Label
End Class

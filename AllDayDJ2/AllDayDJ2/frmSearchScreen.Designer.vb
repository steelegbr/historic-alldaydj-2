<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchScreen))
        Me.tableLayoutControl = New System.Windows.Forms.TableLayoutPanel
        Me.panelSearchBar = New System.Windows.Forms.FlowLayoutPanel
        Me.lblSearch = New System.Windows.Forms.Label
        Me.tbSearch = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.pbLoading = New System.Windows.Forms.ProgressBar
        Me.lbPlaylists = New System.Windows.Forms.ListBox
        Me.lvResults = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.panelPFLPlayer = New System.Windows.Forms.FlowLayoutPanel
        Me.lblPFLInfo = New System.Windows.Forms.Label
        Me.panelPFLControls = New System.Windows.Forms.Panel
        Me.lblTrackPosition = New System.Windows.Forms.Label
        Me.tbTrackPosition = New System.Windows.Forms.TrackBar
        Me.btnPFLStop = New System.Windows.Forms.Button
        Me.btnPFLPlay = New System.Windows.Forms.Button
        Me.btnAddToPlaylist = New System.Windows.Forms.Button
        Me.tmrPFL = New System.Windows.Forms.Timer(Me.components)
        Me.tableLayoutControl.SuspendLayout()
        Me.panelSearchBar.SuspendLayout()
        Me.panelPFLPlayer.SuspendLayout()
        Me.panelPFLControls.SuspendLayout()
        CType(Me.tbTrackPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableLayoutControl
        '
        Me.tableLayoutControl.ColumnCount = 2
        Me.tableLayoutControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tableLayoutControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.tableLayoutControl.Controls.Add(Me.panelSearchBar, 1, 0)
        Me.tableLayoutControl.Controls.Add(Me.lbPlaylists, 0, 1)
        Me.tableLayoutControl.Controls.Add(Me.lvResults, 1, 1)
        Me.tableLayoutControl.Controls.Add(Me.panelPFLPlayer, 1, 2)
        Me.tableLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutControl.Name = "tableLayoutControl"
        Me.tableLayoutControl.RowCount = 3
        Me.tableLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778!))
        Me.tableLayoutControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.tableLayoutControl.Size = New System.Drawing.Size(792, 566)
        Me.tableLayoutControl.TabIndex = 0
        '
        'panelSearchBar
        '
        Me.panelSearchBar.Controls.Add(Me.lblSearch)
        Me.panelSearchBar.Controls.Add(Me.tbSearch)
        Me.panelSearchBar.Controls.Add(Me.btnClear)
        Me.panelSearchBar.Controls.Add(Me.pbLoading)
        Me.panelSearchBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSearchBar.Location = New System.Drawing.Point(201, 3)
        Me.panelSearchBar.Name = "panelSearchBar"
        Me.panelSearchBar.Size = New System.Drawing.Size(588, 34)
        Me.panelSearchBar.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(3, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(64, 20)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search:"
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(73, 3)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(240, 20)
        Me.tbSearch.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(319, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(64, 20)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'pbLoading
        '
        Me.pbLoading.Location = New System.Drawing.Point(389, 3)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(190, 20)
        Me.pbLoading.TabIndex = 3
        Me.pbLoading.Visible = False
        '
        'lbPlaylists
        '
        Me.lbPlaylists.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbPlaylists.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPlaylists.FormattingEnabled = True
        Me.lbPlaylists.ItemHeight = 16
        Me.lbPlaylists.Location = New System.Drawing.Point(3, 43)
        Me.lbPlaylists.Name = "lbPlaylists"
        Me.lbPlaylists.Size = New System.Drawing.Size(192, 388)
        Me.lbPlaylists.TabIndex = 1
        '
        'lvResults
        '
        Me.lvResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5})
        Me.lvResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvResults.FullRowSelect = True
        Me.lvResults.Location = New System.Drawing.Point(201, 43)
        Me.lvResults.MultiSelect = False
        Me.lvResults.Name = "lvResults"
        Me.lvResults.Size = New System.Drawing.Size(588, 403)
        Me.lvResults.TabIndex = 2
        Me.lvResults.UseCompatibleStateImageBehavior = False
        Me.lvResults.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Artist"
        Me.ColumnHeader1.Width = 110
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Title"
        Me.ColumnHeader2.Width = 148
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Album"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Length"
        Me.ColumnHeader4.Width = 64
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Playlist"
        Me.ColumnHeader6.Width = 98
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Extra Information"
        Me.ColumnHeader5.Width = 190
        '
        'panelPFLPlayer
        '
        Me.panelPFLPlayer.Controls.Add(Me.lblPFLInfo)
        Me.panelPFLPlayer.Controls.Add(Me.panelPFLControls)
        Me.panelPFLPlayer.Controls.Add(Me.btnAddToPlaylist)
        Me.panelPFLPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPFLPlayer.Location = New System.Drawing.Point(201, 452)
        Me.panelPFLPlayer.Name = "panelPFLPlayer"
        Me.panelPFLPlayer.Size = New System.Drawing.Size(588, 111)
        Me.panelPFLPlayer.TabIndex = 3
        '
        'lblPFLInfo
        '
        Me.lblPFLInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFLInfo.Location = New System.Drawing.Point(3, 0)
        Me.lblPFLInfo.Name = "lblPFLInfo"
        Me.lblPFLInfo.Size = New System.Drawing.Size(235, 105)
        Me.lblPFLInfo.TabIndex = 0
        Me.lblPFLInfo.Text = "Artist:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Title:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Length: 00:00/00:00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Playlist:"
        '
        'panelPFLControls
        '
        Me.panelPFLControls.Controls.Add(Me.lblTrackPosition)
        Me.panelPFLControls.Controls.Add(Me.tbTrackPosition)
        Me.panelPFLControls.Controls.Add(Me.btnPFLStop)
        Me.panelPFLControls.Controls.Add(Me.btnPFLPlay)
        Me.panelPFLControls.Location = New System.Drawing.Point(244, 3)
        Me.panelPFLControls.Name = "panelPFLControls"
        Me.panelPFLControls.Size = New System.Drawing.Size(266, 99)
        Me.panelPFLControls.TabIndex = 1
        '
        'lblTrackPosition
        '
        Me.lblTrackPosition.AutoSize = True
        Me.lblTrackPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrackPosition.Location = New System.Drawing.Point(166, 15)
        Me.lblTrackPosition.Name = "lblTrackPosition"
        Me.lblTrackPosition.Size = New System.Drawing.Size(93, 20)
        Me.lblTrackPosition.TabIndex = 37
        Me.lblTrackPosition.Text = "00:00/00:00"
        Me.lblTrackPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbTrackPosition
        '
        Me.tbTrackPosition.Location = New System.Drawing.Point(8, 75)
        Me.tbTrackPosition.Name = "tbTrackPosition"
        Me.tbTrackPosition.Size = New System.Drawing.Size(251, 45)
        Me.tbTrackPosition.TabIndex = 36
        '
        'btnPFLStop
        '
        Me.btnPFLStop.Image = CType(resources.GetObject("btnPFLStop.Image"), System.Drawing.Image)
        Me.btnPFLStop.Location = New System.Drawing.Point(3, 3)
        Me.btnPFLStop.Name = "btnPFLStop"
        Me.btnPFLStop.Size = New System.Drawing.Size(69, 67)
        Me.btnPFLStop.TabIndex = 35
        Me.btnPFLStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPFLStop.UseVisualStyleBackColor = True
        '
        'btnPFLPlay
        '
        Me.btnPFLPlay.Image = CType(resources.GetObject("btnPFLPlay.Image"), System.Drawing.Image)
        Me.btnPFLPlay.Location = New System.Drawing.Point(78, 3)
        Me.btnPFLPlay.Name = "btnPFLPlay"
        Me.btnPFLPlay.Size = New System.Drawing.Size(69, 67)
        Me.btnPFLPlay.TabIndex = 34
        Me.btnPFLPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPFLPlay.UseVisualStyleBackColor = True
        '
        'btnAddToPlaylist
        '
        Me.btnAddToPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToPlaylist.Location = New System.Drawing.Point(516, 3)
        Me.btnAddToPlaylist.Name = "btnAddToPlaylist"
        Me.btnAddToPlaylist.Size = New System.Drawing.Size(63, 59)
        Me.btnAddToPlaylist.TabIndex = 2
        Me.btnAddToPlaylist.Text = "Add"
        Me.btnAddToPlaylist.UseVisualStyleBackColor = True
        '
        'tmrPFL
        '
        '
        'frmSearchScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.tableLayoutControl)
        Me.KeyPreview = True
        Me.Name = "frmSearchScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record Library"
        Me.tableLayoutControl.ResumeLayout(False)
        Me.panelSearchBar.ResumeLayout(False)
        Me.panelSearchBar.PerformLayout()
        Me.panelPFLPlayer.ResumeLayout(False)
        Me.panelPFLControls.ResumeLayout(False)
        Me.panelPFLControls.PerformLayout()
        CType(Me.tbTrackPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableLayoutControl As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panelSearchBar As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lbPlaylists As System.Windows.Forms.ListBox
    Friend WithEvents lvResults As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents panelPFLPlayer As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblPFLInfo As System.Windows.Forms.Label
    Friend WithEvents panelPFLControls As System.Windows.Forms.Panel
    Friend WithEvents lblTrackPosition As System.Windows.Forms.Label
    Friend WithEvents tbTrackPosition As System.Windows.Forms.TrackBar
    Friend WithEvents btnPFLStop As System.Windows.Forms.Button
    Friend WithEvents btnPFLPlay As System.Windows.Forms.Button
    Friend WithEvents btnAddToPlaylist As System.Windows.Forms.Button
    Friend WithEvents tmrPFL As System.Windows.Forms.Timer
    Friend WithEvents pbLoading As System.Windows.Forms.ProgressBar
End Class

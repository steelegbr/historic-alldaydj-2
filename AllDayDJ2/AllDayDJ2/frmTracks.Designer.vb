<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTracks
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
        Me.lvItems = New System.Windows.Forms.ListView
        Me.chTrackID = New System.Windows.Forms.ColumnHeader
        Me.chArtist = New System.Windows.Forms.ColumnHeader
        Me.chTrack = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.fbdMain = New System.Windows.Forms.FolderBrowserDialog
        Me.ofdMain = New System.Windows.Forms.OpenFileDialog
        Me.btnMove = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lvItems
        '
        Me.lvItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chTrackID, Me.chArtist, Me.chTrack})
        Me.lvItems.Location = New System.Drawing.Point(12, 43)
        Me.lvItems.MultiSelect = False
        Me.lvItems.Name = "lvItems"
        Me.lvItems.ShowItemToolTips = True
        Me.lvItems.Size = New System.Drawing.Size(608, 374)
        Me.lvItems.TabIndex = 0
        Me.lvItems.UseCompatibleStateImageBehavior = False
        Me.lvItems.View = System.Windows.Forms.View.Details
        '
        'chTrackID
        '
        Me.chTrackID.Text = "Track ID"
        '
        'chArtist
        '
        Me.chArtist.Text = "Artist"
        Me.chArtist.Width = 266
        '
        'chTrack
        '
        Me.chTrack.Text = "Track"
        Me.chTrack.Width = 277
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(527, 427)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(93, 22)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(94, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(49, 25)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(53, 12)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(35, 25)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "-"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(12, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(35, 25)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'fbdMain
        '
        Me.fbdMain.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'ofdMain
        '
        Me.ofdMain.Filter = "All Supported Formats|;*.wav;*.ogg;*.mp1;*.mp2;*.mp3;*.aif;*.wma|WAVE Audio|*.wav" & _
            "|Ogg Vorbis|*.ogg|MPEG layer 1|*.mp1|MPEG layer 2|*.mp2|MPEG layer 3|*.mp3|Audio" & _
            " IFF|*.aif|Windows Media Audio|*.wma"
        '
        'btnMove
        '
        Me.btnMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMove.Location = New System.Drawing.Point(149, 12)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(49, 25)
        Me.btnMove.TabIndex = 8
        Me.btnMove.Text = "Move"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'frmTracks
        '
        Me.AcceptButton = Me.btnClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(632, 459)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lvItems)
        Me.MinimizeBox = False
        Me.Name = "frmTracks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[PLAYLIST]"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvItems As System.Windows.Forms.ListView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents chTrackID As System.Windows.Forms.ColumnHeader
    Friend WithEvents chArtist As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTrack As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents fbdMain As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ofdMain As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnMove As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMoveToPlaylist
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
        Me.cmbPlaylists = New System.Windows.Forms.ComboBox
        Me.btnMove = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbPlaylists
        '
        Me.cmbPlaylists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlaylists.FormattingEnabled = True
        Me.cmbPlaylists.Location = New System.Drawing.Point(12, 12)
        Me.cmbPlaylists.Name = "cmbPlaylists"
        Me.cmbPlaylists.Size = New System.Drawing.Size(228, 21)
        Me.cmbPlaylists.TabIndex = 0
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(246, 12)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(73, 21)
        Me.btnMove.TabIndex = 1
        Me.btnMove.Text = "Move"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'frmMoveToPlaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 47)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.cmbPlaylists)
        Me.Name = "frmMoveToPlaylist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Move To..."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbPlaylists As System.Windows.Forms.ComboBox
    Friend WithEvents btnMove As System.Windows.Forms.Button
End Class

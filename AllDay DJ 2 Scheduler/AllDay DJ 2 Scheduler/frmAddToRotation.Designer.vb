<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddToRotation
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
        Me.rbSpot = New System.Windows.Forms.RadioButton
        Me.rbPlaylist = New System.Windows.Forms.RadioButton
        Me.cmbSpot = New System.Windows.Forms.ComboBox
        Me.cmbPlaylists = New System.Windows.Forms.ComboBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'rbSpot
        '
        Me.rbSpot.AutoSize = True
        Me.rbSpot.Location = New System.Drawing.Point(12, 29)
        Me.rbSpot.Name = "rbSpot"
        Me.rbSpot.Size = New System.Drawing.Size(14, 13)
        Me.rbSpot.TabIndex = 0
        Me.rbSpot.TabStop = True
        Me.rbSpot.UseVisualStyleBackColor = True
        '
        'rbPlaylist
        '
        Me.rbPlaylist.AutoSize = True
        Me.rbPlaylist.Location = New System.Drawing.Point(12, 60)
        Me.rbPlaylist.Name = "rbPlaylist"
        Me.rbPlaylist.Size = New System.Drawing.Size(14, 13)
        Me.rbPlaylist.TabIndex = 1
        Me.rbPlaylist.TabStop = True
        Me.rbPlaylist.UseVisualStyleBackColor = True
        '
        'cmbSpot
        '
        Me.cmbSpot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSpot.FormattingEnabled = True
        Me.cmbSpot.Location = New System.Drawing.Point(32, 26)
        Me.cmbSpot.Name = "cmbSpot"
        Me.cmbSpot.Size = New System.Drawing.Size(380, 21)
        Me.cmbSpot.TabIndex = 2
        '
        'cmbPlaylists
        '
        Me.cmbPlaylists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlaylists.FormattingEnabled = True
        Me.cmbPlaylists.Location = New System.Drawing.Point(32, 57)
        Me.cmbPlaylists.Name = "cmbPlaylists"
        Me.cmbPlaylists.Size = New System.Drawing.Size(380, 21)
        Me.cmbPlaylists.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(358, 84)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(54, 25)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmAddToRotation
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 121)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cmbPlaylists)
        Me.Controls.Add(Me.cmbSpot)
        Me.Controls.Add(Me.rbPlaylist)
        Me.Controls.Add(Me.rbSpot)
        Me.Name = "frmAddToRotation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add To Rotation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbSpot As System.Windows.Forms.RadioButton
    Friend WithEvents rbPlaylist As System.Windows.Forms.RadioButton
    Friend WithEvents cmbSpot As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPlaylists As System.Windows.Forms.ComboBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class

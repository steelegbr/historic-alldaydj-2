<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAddFromPlaylists
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
        Me.OK_Button = New System.Windows.Forms.Button
        Me.cmbPlaylists = New System.Windows.Forms.ComboBox
        Me.lbItems = New System.Windows.Forms.ListBox
        Me.tbSearch = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Location = New System.Drawing.Point(356, 308)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 4
        Me.OK_Button.Text = "OK"
        '
        'cmbPlaylists
        '
        Me.cmbPlaylists.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPlaylists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlaylists.FormattingEnabled = True
        Me.cmbPlaylists.Location = New System.Drawing.Point(12, 10)
        Me.cmbPlaylists.Name = "cmbPlaylists"
        Me.cmbPlaylists.Size = New System.Drawing.Size(411, 21)
        Me.cmbPlaylists.TabIndex = 1
        '
        'lbItems
        '
        Me.lbItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbItems.FormattingEnabled = True
        Me.lbItems.Location = New System.Drawing.Point(12, 64)
        Me.lbItems.Name = "lbItems"
        Me.lbItems.ScrollAlwaysVisible = True
        Me.lbItems.Size = New System.Drawing.Size(411, 238)
        Me.lbItems.TabIndex = 3
        '
        'tbSearch
        '
        Me.tbSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSearch.Location = New System.Drawing.Point(12, 37)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(411, 20)
        Me.tbSearch.TabIndex = 2
        '
        'dlgAddFromPlaylists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 343)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.lbItems)
        Me.Controls.Add(Me.cmbPlaylists)
        Me.Controls.Add(Me.OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAddFromPlaylists"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add From Playlist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents cmbPlaylists As System.Windows.Forms.ComboBox
    Friend WithEvents lbItems As System.Windows.Forms.ListBox
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox

End Class

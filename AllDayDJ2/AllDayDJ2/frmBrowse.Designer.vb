<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowse
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbPlaylists = New System.Windows.Forms.ComboBox
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbPlaylists
        '
        Me.cmbPlaylists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlaylists.FormattingEnabled = True
        Me.cmbPlaylists.Location = New System.Drawing.Point(12, 12)
        Me.cmbPlaylists.Name = "cmbPlaylists"
        Me.cmbPlaylists.Size = New System.Drawing.Size(314, 21)
        Me.cmbPlaylists.TabIndex = 0
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(332, 12)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(61, 22)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'frmBrowse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 43)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.cmbPlaylists)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBrowse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Browse Playlist"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbPlaylists As System.Windows.Forms.ComboBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
End Class

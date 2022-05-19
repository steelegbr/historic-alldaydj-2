<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadingPlaylists
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
        Me.pbLoading = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'pbLoading
        '
        Me.pbLoading.Location = New System.Drawing.Point(12, 1)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(335, 21)
        Me.pbLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbLoading.TabIndex = 0
        '
        'frmLoadingPlaylists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 28)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbLoading)
        Me.Name = "frmLoadingPlaylists"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading Playlist [NAME]"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbLoading As System.Windows.Forms.ProgressBar
End Class

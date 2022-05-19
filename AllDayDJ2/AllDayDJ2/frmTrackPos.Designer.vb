<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrackPos
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
        Me.pbPosition = New System.Windows.Forms.ProgressBar
        Me.tmrGetPosition = New System.Windows.Forms.Timer(Me.components)
        Me.pnlFileName = New System.Windows.Forms.Panel
        Me.lblFileName = New System.Windows.Forms.Label
        Me.pnlFileName.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbPosition
        '
        Me.pbPosition.Location = New System.Drawing.Point(12, 53)
        Me.pbPosition.Name = "pbPosition"
        Me.pbPosition.Size = New System.Drawing.Size(384, 17)
        Me.pbPosition.TabIndex = 1
        '
        'tmrGetPosition
        '
        '
        'pnlFileName
        '
        Me.pnlFileName.Controls.Add(Me.lblFileName)
        Me.pnlFileName.Location = New System.Drawing.Point(12, 12)
        Me.pnlFileName.Name = "pnlFileName"
        Me.pnlFileName.Size = New System.Drawing.Size(384, 34)
        Me.pnlFileName.TabIndex = 2
        '
        'lblFileName
        '
        Me.lblFileName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFileName.Location = New System.Drawing.Point(0, 0)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(384, 34)
        Me.lblFileName.TabIndex = 1
        Me.lblFileName.Text = "A:\b\c\d.efg"
        '
        'frmTrackPos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 82)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlFileName)
        Me.Controls.Add(Me.pbPosition)
        Me.Name = "frmTrackPos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[TRACK FILE NAME]"
        Me.pnlFileName.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbPosition As System.Windows.Forms.ProgressBar
    Friend WithEvents tmrGetPosition As System.Windows.Forms.Timer
    Friend WithEvents pnlFileName As System.Windows.Forms.Panel
    Friend WithEvents lblFileName As System.Windows.Forms.Label
End Class

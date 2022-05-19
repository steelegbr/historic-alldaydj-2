<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackTimer
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
        Me.lblLastSong = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.lblPlayAt = New System.Windows.Forms.Label
        Me.nudSongMins = New System.Windows.Forms.NumericUpDown
        Me.nudSongSeconds = New System.Windows.Forms.NumericUpDown
        Me.nudJingleSeconds = New System.Windows.Forms.NumericUpDown
        Me.lblColon = New System.Windows.Forms.Label
        CType(Me.nudSongMins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSongSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudJingleSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLastSong
        '
        Me.lblLastSong.AutoSize = True
        Me.lblLastSong.Location = New System.Drawing.Point(42, 30)
        Me.lblLastSong.Name = "lblLastSong"
        Me.lblLastSong.Size = New System.Drawing.Size(94, 13)
        Me.lblLastSong.TabIndex = 0
        Me.lblLastSong.Text = "Last Song Length:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "News Jingle Length:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(26, 102)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(235, 49)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblPlayAt
        '
        Me.lblPlayAt.AutoSize = True
        Me.lblPlayAt.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayAt.Location = New System.Drawing.Point(88, 176)
        Me.lblPlayAt.Name = "lblPlayAt"
        Me.lblPlayAt.Size = New System.Drawing.Size(117, 42)
        Me.lblPlayAt.TabIndex = 5
        Me.lblPlayAt.Text = "00:00"
        Me.lblPlayAt.Visible = False
        '
        'nudSongMins
        '
        Me.nudSongMins.Location = New System.Drawing.Point(151, 26)
        Me.nudSongMins.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudSongMins.Name = "nudSongMins"
        Me.nudSongMins.Size = New System.Drawing.Size(41, 20)
        Me.nudSongMins.TabIndex = 6
        '
        'nudSongSeconds
        '
        Me.nudSongSeconds.Location = New System.Drawing.Point(215, 26)
        Me.nudSongSeconds.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudSongSeconds.Name = "nudSongSeconds"
        Me.nudSongSeconds.Size = New System.Drawing.Size(41, 20)
        Me.nudSongSeconds.TabIndex = 7
        '
        'nudJingleSeconds
        '
        Me.nudJingleSeconds.Location = New System.Drawing.Point(151, 63)
        Me.nudJingleSeconds.Name = "nudJingleSeconds"
        Me.nudJingleSeconds.Size = New System.Drawing.Size(41, 20)
        Me.nudJingleSeconds.TabIndex = 8
        '
        'lblColon
        '
        Me.lblColon.AutoSize = True
        Me.lblColon.Location = New System.Drawing.Point(199, 30)
        Me.lblColon.Name = "lblColon"
        Me.lblColon.Size = New System.Drawing.Size(10, 13)
        Me.lblColon.TabIndex = 9
        Me.lblColon.Text = ":"
        '
        'frmBackTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.lblColon)
        Me.Controls.Add(Me.nudJingleSeconds)
        Me.Controls.Add(Me.nudSongSeconds)
        Me.Controls.Add(Me.nudSongMins)
        Me.Controls.Add(Me.lblPlayAt)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLastSong)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackTimer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Back Timer Calculator"
        CType(Me.nudSongMins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSongSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudJingleSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLastSong As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblPlayAt As System.Windows.Forms.Label
    Friend WithEvents nudSongMins As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSongSeconds As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudJingleSeconds As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblColon As System.Windows.Forms.Label
End Class

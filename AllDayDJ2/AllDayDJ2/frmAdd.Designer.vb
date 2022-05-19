<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
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
        Me.gbDatabase = New System.Windows.Forms.GroupBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.gbHardware = New System.Windows.Forms.GroupBox
        Me.btnSoundCard = New System.Windows.Forms.Button
        Me.gbDatabase.SuspendLayout()
        Me.gbHardware.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatabase
        '
        Me.gbDatabase.Controls.Add(Me.btnSearch)
        Me.gbDatabase.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbDatabase.Location = New System.Drawing.Point(0, 0)
        Me.gbDatabase.Name = "gbDatabase"
        Me.gbDatabase.Size = New System.Drawing.Size(367, 56)
        Me.gbDatabase.TabIndex = 0
        Me.gbDatabase.TabStop = False
        Me.gbDatabase.Text = "Database"
        '
        'btnSearch
        '
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSearch.Location = New System.Drawing.Point(3, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(361, 32)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search / Browse"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'gbHardware
        '
        Me.gbHardware.Controls.Add(Me.btnSoundCard)
        Me.gbHardware.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbHardware.Location = New System.Drawing.Point(0, 56)
        Me.gbHardware.Name = "gbHardware"
        Me.gbHardware.Size = New System.Drawing.Size(367, 56)
        Me.gbHardware.TabIndex = 1
        Me.gbHardware.TabStop = False
        Me.gbHardware.Text = "Hardware"
        '
        'btnSoundCard
        '
        Me.btnSoundCard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSoundCard.Location = New System.Drawing.Point(3, 16)
        Me.btnSoundCard.Name = "btnSoundCard"
        Me.btnSoundCard.Size = New System.Drawing.Size(361, 32)
        Me.btnSoundCard.TabIndex = 1
        Me.btnSoundCard.Text = "Soundcard Input"
        Me.btnSoundCard.UseVisualStyleBackColor = True
        '
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 117)
        Me.Controls.Add(Me.gbHardware)
        Me.Controls.Add(Me.gbDatabase)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add To Playlist"
        Me.gbDatabase.ResumeLayout(False)
        Me.gbHardware.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbDatabase As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents gbHardware As System.Windows.Forms.GroupBox
    Friend WithEvents btnSoundCard As System.Windows.Forms.Button
End Class

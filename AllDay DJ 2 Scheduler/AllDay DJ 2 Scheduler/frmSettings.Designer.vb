<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.lblPartsDb = New System.Windows.Forms.Label
        Me.tbPartsLocation = New System.Windows.Forms.TextBox
        Me.btnPartsBrowse = New System.Windows.Forms.Button
        Me.btnScheduleBrowse = New System.Windows.Forms.Button
        Me.tbScheduleLocation = New System.Windows.Forms.TextBox
        Me.lblScheduleDb = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.ofdParts = New System.Windows.Forms.OpenFileDialog
        Me.ofdSchedule = New System.Windows.Forms.OpenFileDialog
        Me.btnAllDayDj2Browse = New System.Windows.Forms.Button
        Me.tbAllDayDj2Location = New System.Windows.Forms.TextBox
        Me.lblAllDayDJ2Database = New System.Windows.Forms.Label
        Me.ofdAllDayDJ2Database = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'lblPartsDb
        '
        Me.lblPartsDb.AutoSize = True
        Me.lblPartsDb.Location = New System.Drawing.Point(33, 15)
        Me.lblPartsDb.Name = "lblPartsDb"
        Me.lblPartsDb.Size = New System.Drawing.Size(83, 13)
        Me.lblPartsDb.TabIndex = 0
        Me.lblPartsDb.Text = "Parts Database:"
        '
        'tbPartsLocation
        '
        Me.tbPartsLocation.Location = New System.Drawing.Point(122, 12)
        Me.tbPartsLocation.Name = "tbPartsLocation"
        Me.tbPartsLocation.Size = New System.Drawing.Size(256, 20)
        Me.tbPartsLocation.TabIndex = 1
        '
        'btnPartsBrowse
        '
        Me.btnPartsBrowse.Location = New System.Drawing.Point(384, 12)
        Me.btnPartsBrowse.Name = "btnPartsBrowse"
        Me.btnPartsBrowse.Size = New System.Drawing.Size(52, 20)
        Me.btnPartsBrowse.TabIndex = 2
        Me.btnPartsBrowse.Text = "Browse"
        Me.btnPartsBrowse.UseVisualStyleBackColor = True
        '
        'btnScheduleBrowse
        '
        Me.btnScheduleBrowse.Location = New System.Drawing.Point(384, 38)
        Me.btnScheduleBrowse.Name = "btnScheduleBrowse"
        Me.btnScheduleBrowse.Size = New System.Drawing.Size(52, 20)
        Me.btnScheduleBrowse.TabIndex = 5
        Me.btnScheduleBrowse.Text = "Browse"
        Me.btnScheduleBrowse.UseVisualStyleBackColor = True
        '
        'tbScheduleLocation
        '
        Me.tbScheduleLocation.Location = New System.Drawing.Point(122, 38)
        Me.tbScheduleLocation.Name = "tbScheduleLocation"
        Me.tbScheduleLocation.Size = New System.Drawing.Size(256, 20)
        Me.tbScheduleLocation.TabIndex = 4
        '
        'lblScheduleDb
        '
        Me.lblScheduleDb.AutoSize = True
        Me.lblScheduleDb.Location = New System.Drawing.Point(12, 38)
        Me.lblScheduleDb.Name = "lblScheduleDb"
        Me.lblScheduleDb.Size = New System.Drawing.Size(104, 13)
        Me.lblScheduleDb.TabIndex = 3
        Me.lblScheduleDb.Text = "Schedule Database:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(384, 90)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(52, 20)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ofdParts
        '
        Me.ofdParts.FileName = "parts.mdb"
        Me.ofdParts.Filter = "Parts Database|parts.mdb"
        '
        'ofdSchedule
        '
        Me.ofdSchedule.FileName = "schedule.mdb"
        Me.ofdSchedule.Filter = "AllDay DJ Schedule|schedule.mdb"
        '
        'btnAllDayDj2Browse
        '
        Me.btnAllDayDj2Browse.Location = New System.Drawing.Point(384, 64)
        Me.btnAllDayDj2Browse.Name = "btnAllDayDj2Browse"
        Me.btnAllDayDj2Browse.Size = New System.Drawing.Size(52, 20)
        Me.btnAllDayDj2Browse.TabIndex = 9
        Me.btnAllDayDj2Browse.Text = "Browse"
        Me.btnAllDayDj2Browse.UseVisualStyleBackColor = True
        '
        'tbAllDayDj2Location
        '
        Me.tbAllDayDj2Location.Location = New System.Drawing.Point(122, 64)
        Me.tbAllDayDj2Location.Name = "tbAllDayDj2Location"
        Me.tbAllDayDj2Location.Size = New System.Drawing.Size(256, 20)
        Me.tbAllDayDj2Location.TabIndex = 8
        '
        'lblAllDayDJ2Database
        '
        Me.lblAllDayDJ2Database.AutoSize = True
        Me.lblAllDayDJ2Database.Location = New System.Drawing.Point(2, 64)
        Me.lblAllDayDJ2Database.Name = "lblAllDayDJ2Database"
        Me.lblAllDayDJ2Database.Size = New System.Drawing.Size(114, 13)
        Me.lblAllDayDJ2Database.TabIndex = 7
        Me.lblAllDayDJ2Database.Text = "AllDay DJ 2 Database:"
        '
        'ofdAllDayDJ2Database
        '
        Me.ofdAllDayDJ2Database.FileName = "record_collection.mdb"
        Me.ofdAllDayDJ2Database.Filter = "AllDay DJ 2 Database|record_collection.mdb"
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 144)
        Me.Controls.Add(Me.btnAllDayDj2Browse)
        Me.Controls.Add(Me.tbAllDayDj2Location)
        Me.Controls.Add(Me.lblAllDayDJ2Database)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnScheduleBrowse)
        Me.Controls.Add(Me.tbScheduleLocation)
        Me.Controls.Add(Me.lblScheduleDb)
        Me.Controls.Add(Me.btnPartsBrowse)
        Me.Controls.Add(Me.tbPartsLocation)
        Me.Controls.Add(Me.lblPartsDb)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPartsDb As System.Windows.Forms.Label
    Friend WithEvents tbPartsLocation As System.Windows.Forms.TextBox
    Friend WithEvents btnPartsBrowse As System.Windows.Forms.Button
    Friend WithEvents btnScheduleBrowse As System.Windows.Forms.Button
    Friend WithEvents tbScheduleLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblScheduleDb As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ofdParts As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofdSchedule As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnAllDayDj2Browse As System.Windows.Forms.Button
    Friend WithEvents tbAllDayDj2Location As System.Windows.Forms.TextBox
    Friend WithEvents lblAllDayDJ2Database As System.Windows.Forms.Label
    Friend WithEvents ofdAllDayDJ2Database As System.Windows.Forms.OpenFileDialog
End Class

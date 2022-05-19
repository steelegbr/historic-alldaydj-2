<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogs))
        Me.pdMain = New System.Drawing.Printing.PrintDocument
        Me.pnlDate = New System.Windows.Forms.Panel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnSetDates = New System.Windows.Forms.Button
        Me.lblThrough = New System.Windows.Forms.Label
        Me.calendarEnd = New System.Windows.Forms.MonthCalendar
        Me.calendarStart = New System.Windows.Forms.MonthCalendar
        Me.pnlLayout = New System.Windows.Forms.TableLayoutPanel
        Me.dgLog = New System.Windows.Forms.DataGrid
        Me.ppdMain = New System.Windows.Forms.PrintPreviewDialog
        Me.pnlDate.SuspendLayout()
        Me.pnlLayout.SuspendLayout()
        CType(Me.dgLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlDate
        '
        Me.pnlDate.Controls.Add(Me.btnClose)
        Me.pnlDate.Controls.Add(Me.btnClear)
        Me.pnlDate.Controls.Add(Me.btnPrint)
        Me.pnlDate.Controls.Add(Me.btnSetDates)
        Me.pnlDate.Controls.Add(Me.lblThrough)
        Me.pnlDate.Controls.Add(Me.calendarEnd)
        Me.pnlDate.Controls.Add(Me.calendarStart)
        Me.pnlDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDate.Location = New System.Drawing.Point(3, 251)
        Me.pnlDate.Name = "pnlDate"
        Me.pnlDate.Size = New System.Drawing.Size(681, 167)
        Me.pnlDate.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(509, 121)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(138, 29)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(509, 86)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(138, 29)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(509, 51)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(138, 29)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnSetDates
        '
        Me.btnSetDates.Location = New System.Drawing.Point(509, 16)
        Me.btnSetDates.Name = "btnSetDates"
        Me.btnSetDates.Size = New System.Drawing.Size(138, 29)
        Me.btnSetDates.TabIndex = 5
        Me.btnSetDates.Text = "Set Dates"
        Me.btnSetDates.UseVisualStyleBackColor = True
        '
        'lblThrough
        '
        Me.lblThrough.AutoSize = True
        Me.lblThrough.Location = New System.Drawing.Point(215, 79)
        Me.lblThrough.Name = "lblThrough"
        Me.lblThrough.Size = New System.Drawing.Size(22, 13)
        Me.lblThrough.TabIndex = 4
        Me.lblThrough.Text = "--->"
        '
        'calendarEnd
        '
        Me.calendarEnd.Location = New System.Drawing.Point(259, 6)
        Me.calendarEnd.MaxSelectionCount = 1
        Me.calendarEnd.Name = "calendarEnd"
        Me.calendarEnd.TabIndex = 3
        Me.calendarEnd.TodayDate = New Date(2007, 1, 16, 0, 0, 0, 0)
        '
        'calendarStart
        '
        Me.calendarStart.Location = New System.Drawing.Point(15, 6)
        Me.calendarStart.MaxSelectionCount = 1
        Me.calendarStart.Name = "calendarStart"
        Me.calendarStart.TabIndex = 2
        Me.calendarStart.TodayDate = New Date(2007, 1, 1, 0, 0, 0, 0)
        '
        'pnlLayout
        '
        Me.pnlLayout.ColumnCount = 1
        Me.pnlLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlLayout.Controls.Add(Me.pnlDate, 0, 1)
        Me.pnlLayout.Controls.Add(Me.dgLog, 0, 0)
        Me.pnlLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLayout.Location = New System.Drawing.Point(0, 0)
        Me.pnlLayout.Name = "pnlLayout"
        Me.pnlLayout.RowCount = 3
        Me.pnlLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173.0!))
        Me.pnlLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.pnlLayout.Size = New System.Drawing.Size(687, 441)
        Me.pnlLayout.TabIndex = 0
        '
        'dgLog
        '
        Me.dgLog.DataMember = ""
        Me.dgLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLog.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgLog.Location = New System.Drawing.Point(3, 3)
        Me.dgLog.Name = "dgLog"
        Me.dgLog.Size = New System.Drawing.Size(681, 242)
        Me.dgLog.TabIndex = 2
        '
        'ppdMain
        '
        Me.ppdMain.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppdMain.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppdMain.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppdMain.Document = Me.pdMain
        Me.ppdMain.Enabled = True
        Me.ppdMain.Icon = CType(resources.GetObject("ppdMain.Icon"), System.Drawing.Icon)
        Me.ppdMain.Name = "ppdMain"
        Me.ppdMain.Visible = False
        '
        'frmLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 441)
        Me.Controls.Add(Me.pnlLayout)
        Me.Name = "frmLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logs"
        Me.pnlDate.ResumeLayout(False)
        Me.pnlDate.PerformLayout()
        Me.pnlLayout.ResumeLayout(False)
        CType(Me.dgLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pdMain As System.Drawing.Printing.PrintDocument
    Friend WithEvents pnlDate As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSetDates As System.Windows.Forms.Button
    Friend WithEvents lblThrough As System.Windows.Forms.Label
    Friend WithEvents calendarEnd As System.Windows.Forms.MonthCalendar
    Friend WithEvents calendarStart As System.Windows.Forms.MonthCalendar
    Friend WithEvents pnlLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ppdMain As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents dgLog As System.Windows.Forms.DataGrid
End Class

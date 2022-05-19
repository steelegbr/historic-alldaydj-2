<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditEvent
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
        Me.lblRunEvent = New System.Windows.Forms.Label
        Me.rbOnceAt = New System.Windows.Forms.RadioButton
        Me.dtpRunOnceDate = New System.Windows.Forms.DateTimePicker
        Me.dtpRunOnceTime = New System.Windows.Forms.DateTimePicker
        Me.rbRepeat = New System.Windows.Forms.RadioButton
        Me.cmbRegularity = New System.Windows.Forms.ComboBox
        Me.dtpRepeatTime = New System.Windows.Forms.DateTimePicker
        Me.dtpRepeatDate = New System.Windows.Forms.DateTimePicker
        Me.lblEventDetails = New System.Windows.Forms.Label
        Me.lbItems = New System.Windows.Forms.ListBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.chkForce = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'lblRunEvent
        '
        Me.lblRunEvent.AutoSize = True
        Me.lblRunEvent.Location = New System.Drawing.Point(12, 9)
        Me.lblRunEvent.Name = "lblRunEvent"
        Me.lblRunEvent.Size = New System.Drawing.Size(67, 13)
        Me.lblRunEvent.TabIndex = 0
        Me.lblRunEvent.Text = "Run Event..."
        '
        'rbOnceAt
        '
        Me.rbOnceAt.AutoSize = True
        Me.rbOnceAt.Location = New System.Drawing.Point(42, 25)
        Me.rbOnceAt.Name = "rbOnceAt"
        Me.rbOnceAt.Size = New System.Drawing.Size(64, 17)
        Me.rbOnceAt.TabIndex = 1
        Me.rbOnceAt.TabStop = True
        Me.rbOnceAt.Text = "Once At"
        Me.rbOnceAt.UseVisualStyleBackColor = True
        '
        'dtpRunOnceDate
        '
        Me.dtpRunOnceDate.Location = New System.Drawing.Point(112, 25)
        Me.dtpRunOnceDate.Name = "dtpRunOnceDate"
        Me.dtpRunOnceDate.Size = New System.Drawing.Size(132, 20)
        Me.dtpRunOnceDate.TabIndex = 2
        '
        'dtpRunOnceTime
        '
        Me.dtpRunOnceTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpRunOnceTime.Location = New System.Drawing.Point(250, 25)
        Me.dtpRunOnceTime.Name = "dtpRunOnceTime"
        Me.dtpRunOnceTime.Size = New System.Drawing.Size(82, 20)
        Me.dtpRunOnceTime.TabIndex = 3
        '
        'rbRepeat
        '
        Me.rbRepeat.AutoSize = True
        Me.rbRepeat.Location = New System.Drawing.Point(42, 51)
        Me.rbRepeat.Name = "rbRepeat"
        Me.rbRepeat.Size = New System.Drawing.Size(52, 17)
        Me.rbRepeat.TabIndex = 4
        Me.rbRepeat.TabStop = True
        Me.rbRepeat.Text = "Every"
        Me.rbRepeat.UseVisualStyleBackColor = True
        '
        'cmbRegularity
        '
        Me.cmbRegularity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRegularity.FormattingEnabled = True
        Me.cmbRegularity.Items.AddRange(New Object() {"--Please Select One--", "Year", "--Month--", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "--Day--", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "--More Regularly--", "Day", "Hour"})
        Me.cmbRegularity.Location = New System.Drawing.Point(112, 51)
        Me.cmbRegularity.Name = "cmbRegularity"
        Me.cmbRegularity.Size = New System.Drawing.Size(132, 21)
        Me.cmbRegularity.TabIndex = 5
        '
        'dtpRepeatTime
        '
        Me.dtpRepeatTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpRepeatTime.Location = New System.Drawing.Point(250, 78)
        Me.dtpRepeatTime.Name = "dtpRepeatTime"
        Me.dtpRepeatTime.Size = New System.Drawing.Size(82, 20)
        Me.dtpRepeatTime.TabIndex = 7
        '
        'dtpRepeatDate
        '
        Me.dtpRepeatDate.Location = New System.Drawing.Point(250, 52)
        Me.dtpRepeatDate.Name = "dtpRepeatDate"
        Me.dtpRepeatDate.Size = New System.Drawing.Size(132, 20)
        Me.dtpRepeatDate.TabIndex = 6
        '
        'lblEventDetails
        '
        Me.lblEventDetails.AutoSize = True
        Me.lblEventDetails.Location = New System.Drawing.Point(12, 129)
        Me.lblEventDetails.Name = "lblEventDetails"
        Me.lblEventDetails.Size = New System.Drawing.Size(75, 13)
        Me.lblEventDetails.TabIndex = 8
        Me.lblEventDetails.Text = "Events Details"
        '
        'lbItems
        '
        Me.lbItems.FormattingEnabled = True
        Me.lbItems.Location = New System.Drawing.Point(42, 145)
        Me.lbItems.Name = "lbItems"
        Me.lbItems.Size = New System.Drawing.Size(340, 160)
        Me.lbItems.TabIndex = 9
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(42, 313)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(85, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(175, 313)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(85, 23)
        Me.btnRemove.TabIndex = 11
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(297, 313)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkForce
        '
        Me.chkForce.AutoSize = True
        Me.chkForce.Location = New System.Drawing.Point(42, 100)
        Me.chkForce.Name = "chkForce"
        Me.chkForce.Size = New System.Drawing.Size(122, 17)
        Me.chkForce.TabIndex = 8
        Me.chkForce.Text = "Force run at set time"
        Me.chkForce.UseVisualStyleBackColor = True
        '
        'frmEditEvent
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 348)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkForce)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lbItems)
        Me.Controls.Add(Me.lblEventDetails)
        Me.Controls.Add(Me.dtpRepeatTime)
        Me.Controls.Add(Me.dtpRepeatDate)
        Me.Controls.Add(Me.cmbRegularity)
        Me.Controls.Add(Me.rbRepeat)
        Me.Controls.Add(Me.dtpRunOnceTime)
        Me.Controls.Add(Me.dtpRunOnceDate)
        Me.Controls.Add(Me.rbOnceAt)
        Me.Controls.Add(Me.lblRunEvent)
        Me.Name = "frmEditEvent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Event - [Event Name]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRunEvent As System.Windows.Forms.Label
    Friend WithEvents rbOnceAt As System.Windows.Forms.RadioButton
    Friend WithEvents dtpRunOnceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRunOnceTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbRepeat As System.Windows.Forms.RadioButton
    Friend WithEvents cmbRegularity As System.Windows.Forms.ComboBox
    Friend WithEvents dtpRepeatTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRepeatDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEventDetails As System.Windows.Forms.Label
    Friend WithEvents lbItems As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents chkForce As System.Windows.Forms.CheckBox
End Class

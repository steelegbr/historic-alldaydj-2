<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsShoutcast
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
        Me.tbServer = New System.Windows.Forms.TextBox
        Me.lblServer = New System.Windows.Forms.Label
        Me.lblPort = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.tbPassword = New System.Windows.Forms.TextBox
        Me.lblStationName = New System.Windows.Forms.Label
        Me.tbStationName = New System.Windows.Forms.TextBox
        Me.lblGenre = New System.Windows.Forms.Label
        Me.tbGenre = New System.Windows.Forms.TextBox
        Me.lblAIM = New System.Windows.Forms.Label
        Me.tbAIM = New System.Windows.Forms.TextBox
        Me.lblICQ = New System.Windows.Forms.Label
        Me.tbICQ = New System.Windows.Forms.TextBox
        Me.lblIRC = New System.Windows.Forms.Label
        Me.tbIRC = New System.Windows.Forms.TextBox
        Me.lblURL = New System.Windows.Forms.Label
        Me.tbURL = New System.Windows.Forms.TextBox
        Me.nudPort = New System.Windows.Forms.NumericUpDown
        Me.cbDirectory = New System.Windows.Forms.CheckBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        CType(Me.nudPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbServer
        '
        Me.tbServer.Location = New System.Drawing.Point(94, 23)
        Me.tbServer.Name = "tbServer"
        Me.tbServer.Size = New System.Drawing.Size(205, 20)
        Me.tbServer.TabIndex = 0
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(47, 26)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(41, 13)
        Me.lblServer.TabIndex = 1
        Me.lblServer.Text = "Server:"
        Me.lblServer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(59, 52)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(29, 13)
        Me.lblPort.TabIndex = 3
        Me.lblPort.Text = "Port:"
        Me.lblPort.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(32, 78)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(94, 75)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(205, 20)
        Me.tbPassword.TabIndex = 4
        Me.tbPassword.UseSystemPasswordChar = True
        '
        'lblStationName
        '
        Me.lblStationName.AutoSize = True
        Me.lblStationName.Location = New System.Drawing.Point(14, 104)
        Me.lblStationName.Name = "lblStationName"
        Me.lblStationName.Size = New System.Drawing.Size(74, 13)
        Me.lblStationName.TabIndex = 7
        Me.lblStationName.Text = "Station Name:"
        Me.lblStationName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbStationName
        '
        Me.tbStationName.Location = New System.Drawing.Point(94, 101)
        Me.tbStationName.Name = "tbStationName"
        Me.tbStationName.Size = New System.Drawing.Size(205, 20)
        Me.tbStationName.TabIndex = 6
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(49, 130)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(39, 13)
        Me.lblGenre.TabIndex = 9
        Me.lblGenre.Text = "Genre:"
        Me.lblGenre.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbGenre
        '
        Me.tbGenre.Location = New System.Drawing.Point(94, 127)
        Me.tbGenre.Name = "tbGenre"
        Me.tbGenre.Size = New System.Drawing.Size(205, 20)
        Me.tbGenre.TabIndex = 8
        '
        'lblAIM
        '
        Me.lblAIM.AutoSize = True
        Me.lblAIM.Location = New System.Drawing.Point(59, 156)
        Me.lblAIM.Name = "lblAIM"
        Me.lblAIM.Size = New System.Drawing.Size(29, 13)
        Me.lblAIM.TabIndex = 11
        Me.lblAIM.Text = "AIM:"
        Me.lblAIM.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbAIM
        '
        Me.tbAIM.Location = New System.Drawing.Point(94, 153)
        Me.tbAIM.Name = "tbAIM"
        Me.tbAIM.Size = New System.Drawing.Size(205, 20)
        Me.tbAIM.TabIndex = 10
        '
        'lblICQ
        '
        Me.lblICQ.AutoSize = True
        Me.lblICQ.Location = New System.Drawing.Point(60, 182)
        Me.lblICQ.Name = "lblICQ"
        Me.lblICQ.Size = New System.Drawing.Size(28, 13)
        Me.lblICQ.TabIndex = 13
        Me.lblICQ.Text = "ICQ:"
        Me.lblICQ.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbICQ
        '
        Me.tbICQ.Location = New System.Drawing.Point(94, 179)
        Me.tbICQ.Name = "tbICQ"
        Me.tbICQ.Size = New System.Drawing.Size(205, 20)
        Me.tbICQ.TabIndex = 12
        '
        'lblIRC
        '
        Me.lblIRC.AutoSize = True
        Me.lblIRC.Location = New System.Drawing.Point(60, 208)
        Me.lblIRC.Name = "lblIRC"
        Me.lblIRC.Size = New System.Drawing.Size(28, 13)
        Me.lblIRC.TabIndex = 15
        Me.lblIRC.Text = "IRC:"
        Me.lblIRC.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbIRC
        '
        Me.tbIRC.Location = New System.Drawing.Point(94, 205)
        Me.tbIRC.Name = "tbIRC"
        Me.tbIRC.Size = New System.Drawing.Size(205, 20)
        Me.tbIRC.TabIndex = 14
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.Location = New System.Drawing.Point(56, 231)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(32, 13)
        Me.lblURL.TabIndex = 17
        Me.lblURL.Text = "URL:"
        Me.lblURL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbURL
        '
        Me.tbURL.Location = New System.Drawing.Point(94, 231)
        Me.tbURL.Name = "tbURL"
        Me.tbURL.Size = New System.Drawing.Size(205, 20)
        Me.tbURL.TabIndex = 16
        '
        'nudPort
        '
        Me.nudPort.Location = New System.Drawing.Point(94, 49)
        Me.nudPort.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudPort.Name = "nudPort"
        Me.nudPort.Size = New System.Drawing.Size(65, 20)
        Me.nudPort.TabIndex = 1
        Me.nudPort.Value = New Decimal(New Integer() {8000, 0, 0, 0})
        '
        'cbDirectory
        '
        Me.cbDirectory.AutoSize = True
        Me.cbDirectory.Location = New System.Drawing.Point(94, 257)
        Me.cbDirectory.Name = "cbDirectory"
        Me.cbDirectory.Size = New System.Drawing.Size(168, 17)
        Me.cbDirectory.TabIndex = 18
        Me.cbDirectory.Text = "Appear In Shoutcast Directory"
        Me.cbDirectory.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(236, 280)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 24)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(167, 280)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(63, 24)
        Me.btnOK.TabIndex = 19
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmSettingsShoutcast
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(311, 313)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cbDirectory)
        Me.Controls.Add(Me.nudPort)
        Me.Controls.Add(Me.lblURL)
        Me.Controls.Add(Me.tbURL)
        Me.Controls.Add(Me.lblIRC)
        Me.Controls.Add(Me.tbIRC)
        Me.Controls.Add(Me.lblICQ)
        Me.Controls.Add(Me.tbICQ)
        Me.Controls.Add(Me.lblAIM)
        Me.Controls.Add(Me.tbAIM)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.tbGenre)
        Me.Controls.Add(Me.lblStationName)
        Me.Controls.Add(Me.tbStationName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.tbServer)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettingsShoutcast"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SHOUTCAST Settings"
        CType(Me.nudPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbServer As System.Windows.Forms.TextBox
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblStationName As System.Windows.Forms.Label
    Friend WithEvents tbStationName As System.Windows.Forms.TextBox
    Friend WithEvents lblGenre As System.Windows.Forms.Label
    Friend WithEvents tbGenre As System.Windows.Forms.TextBox
    Friend WithEvents lblAIM As System.Windows.Forms.Label
    Friend WithEvents tbAIM As System.Windows.Forms.TextBox
    Friend WithEvents lblICQ As System.Windows.Forms.Label
    Friend WithEvents tbICQ As System.Windows.Forms.TextBox
    Friend WithEvents lblIRC As System.Windows.Forms.Label
    Friend WithEvents tbIRC As System.Windows.Forms.TextBox
    Friend WithEvents lblURL As System.Windows.Forms.Label
    Friend WithEvents tbURL As System.Windows.Forms.TextBox
    Friend WithEvents nudPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbDirectory As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class

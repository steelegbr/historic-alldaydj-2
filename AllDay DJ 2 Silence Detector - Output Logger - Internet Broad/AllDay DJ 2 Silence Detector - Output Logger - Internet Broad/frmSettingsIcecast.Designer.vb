<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsIcecast
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
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.cbDirectory = New System.Windows.Forms.CheckBox
        Me.nudPort = New System.Windows.Forms.NumericUpDown
        Me.lblURL = New System.Windows.Forms.Label
        Me.tbURL = New System.Windows.Forms.TextBox
        Me.lblDescription = New System.Windows.Forms.Label
        Me.tbDescription = New System.Windows.Forms.TextBox
        Me.lblGenre = New System.Windows.Forms.Label
        Me.tbGenre = New System.Windows.Forms.TextBox
        Me.lblStationName = New System.Windows.Forms.Label
        Me.tbStationName = New System.Windows.Forms.TextBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.tbPassword = New System.Windows.Forms.TextBox
        Me.lblPort = New System.Windows.Forms.Label
        Me.lblServer = New System.Windows.Forms.Label
        Me.tbServer = New System.Windows.Forms.TextBox
        Me.lblMountPoint = New System.Windows.Forms.Label
        Me.tbMountPoint = New System.Windows.Forms.TextBox
        CType(Me.nudPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(236, 257)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 24)
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(167, 257)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(63, 24)
        Me.btnOK.TabIndex = 40
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cbDirectory
        '
        Me.cbDirectory.AutoSize = True
        Me.cbDirectory.Location = New System.Drawing.Point(94, 234)
        Me.cbDirectory.Name = "cbDirectory"
        Me.cbDirectory.Size = New System.Drawing.Size(155, 17)
        Me.cbDirectory.TabIndex = 39
        Me.cbDirectory.Text = "Appear In Icecast Directory"
        Me.cbDirectory.UseVisualStyleBackColor = True
        '
        'nudPort
        '
        Me.nudPort.Location = New System.Drawing.Point(94, 78)
        Me.nudPort.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudPort.Name = "nudPort"
        Me.nudPort.Size = New System.Drawing.Size(65, 20)
        Me.nudPort.TabIndex = 22
        Me.nudPort.Value = New Decimal(New Integer() {8000, 0, 0, 0})
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.Location = New System.Drawing.Point(56, 208)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(32, 13)
        Me.lblURL.TabIndex = 38
        Me.lblURL.Text = "URL:"
        Me.lblURL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbURL
        '
        Me.tbURL.Location = New System.Drawing.Point(94, 208)
        Me.tbURL.Name = "tbURL"
        Me.tbURL.Size = New System.Drawing.Size(205, 20)
        Me.tbURL.TabIndex = 37
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(25, 185)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 13)
        Me.lblDescription.TabIndex = 32
        Me.lblDescription.Text = "Description:"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbDescription
        '
        Me.tbDescription.Location = New System.Drawing.Point(94, 182)
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.Size = New System.Drawing.Size(205, 20)
        Me.tbDescription.TabIndex = 31
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(49, 159)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(39, 13)
        Me.lblGenre.TabIndex = 30
        Me.lblGenre.Text = "Genre:"
        Me.lblGenre.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbGenre
        '
        Me.tbGenre.Location = New System.Drawing.Point(94, 156)
        Me.tbGenre.Name = "tbGenre"
        Me.tbGenre.Size = New System.Drawing.Size(205, 20)
        Me.tbGenre.TabIndex = 29
        '
        'lblStationName
        '
        Me.lblStationName.AutoSize = True
        Me.lblStationName.Location = New System.Drawing.Point(14, 133)
        Me.lblStationName.Name = "lblStationName"
        Me.lblStationName.Size = New System.Drawing.Size(74, 13)
        Me.lblStationName.TabIndex = 28
        Me.lblStationName.Text = "Station Name:"
        Me.lblStationName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbStationName
        '
        Me.tbStationName.Location = New System.Drawing.Point(94, 130)
        Me.tbStationName.Name = "tbStationName"
        Me.tbStationName.Size = New System.Drawing.Size(205, 20)
        Me.tbStationName.TabIndex = 27
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(32, 107)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 26
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(94, 104)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(205, 20)
        Me.tbPassword.TabIndex = 25
        Me.tbPassword.UseSystemPasswordChar = True
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(59, 81)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(29, 13)
        Me.lblPort.TabIndex = 24
        Me.lblPort.Text = "Port:"
        Me.lblPort.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(47, 29)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(41, 13)
        Me.lblServer.TabIndex = 23
        Me.lblServer.Text = "Server:"
        Me.lblServer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbServer
        '
        Me.tbServer.Location = New System.Drawing.Point(94, 26)
        Me.tbServer.Name = "tbServer"
        Me.tbServer.Size = New System.Drawing.Size(205, 20)
        Me.tbServer.TabIndex = 21
        '
        'lblMountPoint
        '
        Me.lblMountPoint.AutoSize = True
        Me.lblMountPoint.Location = New System.Drawing.Point(21, 52)
        Me.lblMountPoint.Name = "lblMountPoint"
        Me.lblMountPoint.Size = New System.Drawing.Size(67, 13)
        Me.lblMountPoint.TabIndex = 43
        Me.lblMountPoint.Text = "Mount Point:"
        Me.lblMountPoint.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbMountPoint
        '
        Me.tbMountPoint.Location = New System.Drawing.Point(94, 52)
        Me.tbMountPoint.Name = "tbMountPoint"
        Me.tbMountPoint.Size = New System.Drawing.Size(205, 20)
        Me.tbMountPoint.TabIndex = 22
        '
        'frmSettingsIcecast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 301)
        Me.Controls.Add(Me.lblMountPoint)
        Me.Controls.Add(Me.tbMountPoint)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cbDirectory)
        Me.Controls.Add(Me.nudPort)
        Me.Controls.Add(Me.lblURL)
        Me.Controls.Add(Me.tbURL)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.tbDescription)
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
        Me.Name = "frmSettingsIcecast"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Icecast Settings"
        CType(Me.nudPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents cbDirectory As System.Windows.Forms.CheckBox
    Friend WithEvents nudPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblURL As System.Windows.Forms.Label
    Friend WithEvents tbURL As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents tbDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblGenre As System.Windows.Forms.Label
    Friend WithEvents tbGenre As System.Windows.Forms.TextBox
    Friend WithEvents lblStationName As System.Windows.Forms.Label
    Friend WithEvents tbStationName As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents tbServer As System.Windows.Forms.TextBox
    Friend WithEvents lblMountPoint As System.Windows.Forms.Label
    Friend WithEvents tbMountPoint As System.Windows.Forms.TextBox
End Class

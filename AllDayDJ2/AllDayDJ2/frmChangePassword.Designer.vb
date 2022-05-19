<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.lblUsername = New System.Windows.Forms.Label
        Me.tbUsername = New System.Windows.Forms.TextBox
        Me.tbOldPassword = New System.Windows.Forms.TextBox
        Me.lblOldPassword = New System.Windows.Forms.Label
        Me.tbNewPassword1 = New System.Windows.Forms.TextBox
        Me.lblPassword1 = New System.Windows.Forms.Label
        Me.tbNewPassword2 = New System.Windows.Forms.TextBox
        Me.lblPassword2 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(311, 129)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(74, 15)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username:"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(138, 12)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(319, 20)
        Me.tbUsername.TabIndex = 2
        '
        'tbOldPassword
        '
        Me.tbOldPassword.Location = New System.Drawing.Point(138, 38)
        Me.tbOldPassword.Name = "tbOldPassword"
        Me.tbOldPassword.Size = New System.Drawing.Size(319, 20)
        Me.tbOldPassword.TabIndex = 4
        Me.tbOldPassword.UseSystemPasswordChar = True
        '
        'lblOldPassword
        '
        Me.lblOldPassword.AutoSize = True
        Me.lblOldPassword.Location = New System.Drawing.Point(57, 41)
        Me.lblOldPassword.Name = "lblOldPassword"
        Me.lblOldPassword.Size = New System.Drawing.Size(75, 13)
        Me.lblOldPassword.TabIndex = 3
        Me.lblOldPassword.Text = "Old Password:"
        Me.lblOldPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbNewPassword1
        '
        Me.tbNewPassword1.Location = New System.Drawing.Point(138, 64)
        Me.tbNewPassword1.Name = "tbNewPassword1"
        Me.tbNewPassword1.Size = New System.Drawing.Size(319, 20)
        Me.tbNewPassword1.TabIndex = 6
        Me.tbNewPassword1.UseSystemPasswordChar = True
        '
        'lblPassword1
        '
        Me.lblPassword1.AutoSize = True
        Me.lblPassword1.Location = New System.Drawing.Point(51, 67)
        Me.lblPassword1.Name = "lblPassword1"
        Me.lblPassword1.Size = New System.Drawing.Size(81, 13)
        Me.lblPassword1.TabIndex = 5
        Me.lblPassword1.Text = "New Password:"
        Me.lblPassword1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbNewPassword2
        '
        Me.tbNewPassword2.Location = New System.Drawing.Point(138, 90)
        Me.tbNewPassword2.Name = "tbNewPassword2"
        Me.tbNewPassword2.Size = New System.Drawing.Size(319, 20)
        Me.tbNewPassword2.TabIndex = 8
        Me.tbNewPassword2.UseSystemPasswordChar = True
        '
        'lblPassword2
        '
        Me.lblPassword2.AutoSize = True
        Me.lblPassword2.Location = New System.Drawing.Point(15, 93)
        Me.lblPassword2.Name = "lblPassword2"
        Me.lblPassword2.Size = New System.Drawing.Size(117, 13)
        Me.lblPassword2.TabIndex = 7
        Me.lblPassword2.Text = "New Password (Again):"
        Me.lblPassword2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmChangePassword
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(469, 170)
        Me.Controls.Add(Me.tbNewPassword2)
        Me.Controls.Add(Me.lblPassword2)
        Me.Controls.Add(Me.tbNewPassword1)
        Me.Controls.Add(Me.lblPassword1)
        Me.Controls.Add(Me.tbOldPassword)
        Me.Controls.Add(Me.lblOldPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePassword"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents tbUsername As System.Windows.Forms.TextBox
    Friend WithEvents tbOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblOldPassword As System.Windows.Forms.Label
    Friend WithEvents tbNewPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword1 As System.Windows.Forms.Label
    Friend WithEvents tbNewPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword2 As System.Windows.Forms.Label

End Class

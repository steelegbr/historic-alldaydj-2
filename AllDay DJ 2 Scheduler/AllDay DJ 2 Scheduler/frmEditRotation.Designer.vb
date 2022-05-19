<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditRotation
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
        Me.pnlLayout = New System.Windows.Forms.TableLayoutPanel
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.lbItems = New System.Windows.Forms.ListBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.pnlLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLayout
        '
        Me.pnlLayout.ColumnCount = 2
        Me.pnlLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.pnlLayout.Controls.Add(Me.btnAdd, 0, 1)
        Me.pnlLayout.Controls.Add(Me.btnRemove, 0, 2)
        Me.pnlLayout.Controls.Add(Me.lbItems, 1, 0)
        Me.pnlLayout.Controls.Add(Me.btnSave, 0, 3)
        Me.pnlLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLayout.Location = New System.Drawing.Point(0, 0)
        Me.pnlLayout.Name = "pnlLayout"
        Me.pnlLayout.RowCount = 5
        Me.pnlLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.pnlLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.pnlLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.pnlLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.pnlLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.pnlLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.pnlLayout.Size = New System.Drawing.Size(446, 332)
        Me.pnlLayout.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdd.Location = New System.Drawing.Point(3, 119)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 27)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRemove.Location = New System.Drawing.Point(3, 152)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(105, 27)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lbItems
        '
        Me.lbItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbItems.FormattingEnabled = True
        Me.lbItems.Location = New System.Drawing.Point(114, 3)
        Me.lbItems.Name = "lbItems"
        Me.pnlLayout.SetRowSpan(Me.lbItems, 5)
        Me.lbItems.Size = New System.Drawing.Size(329, 316)
        Me.lbItems.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Location = New System.Drawing.Point(3, 185)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 27)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmEditRotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 332)
        Me.Controls.Add(Me.pnlLayout)
        Me.Name = "frmEditRotation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Rotation - [NAME]"
        Me.pnlLayout.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lbItems As System.Windows.Forms.ListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.tbQuery = New System.Windows.Forms.TextBox
        Me.btnGo = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblSortBy = New System.Windows.Forms.Label
        Me.cmbSortBy = New System.Windows.Forms.ComboBox
        Me.cmbAscDesc = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'tbQuery
        '
        Me.tbQuery.Location = New System.Drawing.Point(12, 12)
        Me.tbQuery.Name = "tbQuery"
        Me.tbQuery.Size = New System.Drawing.Size(274, 20)
        Me.tbQuery.TabIndex = 0
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(288, 12)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(54, 19)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(344, 12)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(54, 19)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblSortBy
        '
        Me.lblSortBy.AutoSize = True
        Me.lblSortBy.Location = New System.Drawing.Point(13, 37)
        Me.lblSortBy.Name = "lblSortBy"
        Me.lblSortBy.Size = New System.Drawing.Size(40, 13)
        Me.lblSortBy.TabIndex = 3
        Me.lblSortBy.Text = "Sort by"
        '
        'cmbSortBy
        '
        Me.cmbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSortBy.FormattingEnabled = True
        Me.cmbSortBy.Items.AddRange(New Object() {"Artist", "Title", "Length"})
        Me.cmbSortBy.Location = New System.Drawing.Point(59, 34)
        Me.cmbSortBy.Name = "cmbSortBy"
        Me.cmbSortBy.Size = New System.Drawing.Size(76, 21)
        Me.cmbSortBy.TabIndex = 4
        '
        'cmbAscDesc
        '
        Me.cmbAscDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAscDesc.FormattingEnabled = True
        Me.cmbAscDesc.Items.AddRange(New Object() {"Ascending", "Decending"})
        Me.cmbAscDesc.Location = New System.Drawing.Point(141, 34)
        Me.cmbAscDesc.Name = "cmbAscDesc"
        Me.cmbAscDesc.Size = New System.Drawing.Size(119, 21)
        Me.cmbAscDesc.TabIndex = 5
        '
        'frmSearch
        '
        Me.AcceptButton = Me.btnGo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(410, 66)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbAscDesc)
        Me.Controls.Add(Me.cmbSortBy)
        Me.Controls.Add(Me.lblSortBy)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.tbQuery)
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbQuery As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblSortBy As System.Windows.Forms.Label
    Friend WithEvents cmbSortBy As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAscDesc As System.Windows.Forms.ComboBox
End Class

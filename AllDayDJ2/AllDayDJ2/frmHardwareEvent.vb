Imports Bass = Un4seen.Bass.Bass

Public Class frmHardwareEvent

    ' Reset display

    Public Sub resetDisplay()

        Me.tbLength.Value = 30

    End Sub

    ' Cancel was clicked

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Hide()

    End Sub

    ' OK was clicked

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim item As AudioItem
        Dim length As Integer

        ' Now create the item

        length = Me.tbLength.Value
        item = New AudioItem(0, 0, Double.Parse(length), Me.chkDucker.Checked)

        ' And add to the playlist

        frmMain.addToMainPL(item, True)

        ' Close this screen

        Me.Hide()

    End Sub

End Class
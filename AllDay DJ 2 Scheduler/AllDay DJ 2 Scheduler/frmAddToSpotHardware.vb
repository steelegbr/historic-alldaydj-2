Public Class frmAddToSpotHardware

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

        Dim length As Integer
        Dim item As AudioItem

        ' Get the values

        length = Me.tbLength.Value

        ' Now create the item

        item = New AudioItem(0, 0, Double.Parse(length))

        ' And add to the playlist

        frmEditSpot.addToSpot(item)

        ' Close this screen

        Me.Hide()

    End Sub

End Class
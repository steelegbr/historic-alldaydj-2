Imports System.Windows.Forms

Public Class dlgMultaple

    ' Yes for multiple, no for one

    Private Sub singleItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOneItem.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub wholeDirectory(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWholeDirectory.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

End Class

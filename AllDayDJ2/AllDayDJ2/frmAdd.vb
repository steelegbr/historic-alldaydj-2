Public Class frmAdd

    ' Search

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        frmSearchScreen.Show()
        frmSearchScreen.BringToFront()
        Me.Close()

    End Sub

    ' Hardware

    Private Sub btnSoundCard_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSoundCard.Click

        frmHardwareEvent.Show()
        frmHardwareEvent.BringToFront()
        Me.Close()

    End Sub

End Class
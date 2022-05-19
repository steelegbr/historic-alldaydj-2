Public Class frmAbout

    ' Load the display

    Private Sub frmAbout_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.lblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.lblCopyright.Text = My.Application.Info.Copyright

    End Sub

    ' Close the screen

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
Public Class frmSplashScreen

    Delegate Sub SetTextCallback(ByVal [text] As String)

    ' Load the system up

    Private Sub frmSplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Set initial variables

        Me.lblVersion.Text = "Version " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.MajorRevision & "." & My.Application.Info.Version.MinorRevision

    End Sub

    Public Sub setText(ByVal [Text] As String)

        If Me.lblLoading.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf setText)
            Me.Invoke(d, New Object() {[Text]})
        Else
            Me.lblLoading.Text = [Text]
        End If

    End Sub

End Class
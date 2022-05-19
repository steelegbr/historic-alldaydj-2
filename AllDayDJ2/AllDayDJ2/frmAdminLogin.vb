Public Class frmAdminLogin

    ' Check the credentials before allowing access to the admin system

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If (My.Settings.Item("username") = Me.UsernameTextBox.Text And My.Settings.Item("password") = Me.PasswordTextBox.Text) Then
            frmMain.setMenu(True)
        Else
            MsgBox("Username or password incorrect." & Chr(13) & Chr(10) & "ACCESS DENIED", MsgBoxStyle.Exclamation, "Access Denied")
        End If

        Me.Close()

    End Sub

    ' Hide the screen

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class

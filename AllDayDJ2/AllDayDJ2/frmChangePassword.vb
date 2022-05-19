Imports System.Windows.Forms

Public Class frmChangePassword

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim username As String
        Dim old_password As String
        Dim new_password(0 To 1) As String
        Dim change_username As Boolean

        username = Me.tbUsername.Text
        old_password = Me.tbOldPassword.Text
        new_password(0) = Me.tbNewPassword1.Text
        new_password(1) = Me.tbNewPassword2.Text

        ' Check for a username change

        If (username.Length > 0) Then
            change_username = True
        Else
            change_username = False
        End If

        ' Check the old password

        If (old_password <> My.Settings.Item("password")) Then
            MsgBox("The current password you entered was incorrect." & Chr(10) & Chr(13) & "Plase check the password and try again.", MsgBoxStyle.Information, "Error")
            Exit Sub
        End If

        ' Change the username if it is valid

        If change_username Then
            My.Settings.Item("username") = username
            My.Settings.Save()
        End If

        ' Check if the user wishes to change the password

        If (new_password(0).Length > 0) Then
            If (new_password(0) <> new_password(1)) Then
                MsgBox("The new password entries do not match." & Chr(10) & Chr(13) & "Please check them and try again.", MsgBoxStyle.Information, "Error")
                Exit Sub
            End If
            My.Settings.Item("password") = new_password(0)
        End If

        ' If we got this far we can hide this screen

        My.Settings.Save()
        Me.Close()

    End Sub

    ' Exit

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

End Class

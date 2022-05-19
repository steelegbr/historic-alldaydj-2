Public Class ErrorHandler

    Shared Sub errorHandler(ByVal ex As Exception)

        ' This routine will quit or attempt to continue

        If (MsgBox("An error has ocurred. You can either click yes to try to ignore the error (not advised!) or no to quit." & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "Error message: " & ex.Message & Chr(13) & Chr(10) & "Stack Trace: " & ex.StackTrace & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "Do you wish to try to ignore this error?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Error") = MsgBoxResult.No) Then
            End
        End If

    End Sub

End Class

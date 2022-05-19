Public Class frmSearch

    ' Perform the search

    Private Sub btnGo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGo.Click

        Dim query As String
        Dim sr As New SearchResults

        ' Get and perform the search

        query = Me.tbQuery.Text

        If (Me.cmbAscDesc.SelectedIndex = 0) Then
            sr.performSearch(query, Me.cmbSortBy.SelectedIndex, True)
        Else
            sr.performSearch(query, Me.cmbSortBy.SelectedIndex, False)
        End If

        ' Return number of results

        If (sr.getResults.getPlaylistLength = 0) Then
            MsgBox("No results found." & Chr(13) & Chr(10) & "Please try another, broader search.", MsgBoxStyle.Information, "Search Results")
            Exit Sub
        Else
            MsgBox(sr.getResults.getPlaylistLength & " results.", MsgBoxStyle.Information, "Search Results")
            frmSearchResults.Show()
            frmSearchResults.loadSR(sr)
        End If

    End Sub

    ' Clear the display

    Public Sub clearDisplay()
        Me.tbQuery.Text = ""
        Me.cmbSortBy.SelectedIndex = 0
        Me.cmbAscDesc.SelectedIndex = 0
    End Sub

    ' Quit

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

End Class
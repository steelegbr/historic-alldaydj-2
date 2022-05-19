Public Class frmBrowse

    ' Load playlists

    Private Sub frmBrowse_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim playlists As List(Of Playlist)
        Dim counter As Integer

        ' Clear old list

        Me.cmbPlaylists.Items.Clear()

        ' Get the playlists

        playlists = frmMain.getPlaylists

        ' Cycle and add

        For counter = 0 To (playlists.Count - 1)
            Me.cmbPlaylists.Items.Add(playlists(counter).getName)
        Next

        ' Select first one

        Me.cmbPlaylists.SelectedIndex = 0

    End Sub

    ' Browse the playlist

    Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        Dim selected As Integer
        Dim sr As New SearchResults

        ' Get and check the selected

        selected = Me.cmbPlaylists.SelectedIndex

        If (selected < 0) Then
            MsgBox("No playlist selected. Please select a playlist to browse and try again.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If

        ' Load the "search results"

        sr.performSearch(selected)
        frmSearchResults.Show()
        frmSearchResults.loadSR(sr)
        Me.Close()

    End Sub

End Class
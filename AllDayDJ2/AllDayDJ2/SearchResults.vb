Public Class SearchResults

    Private playlist As Playlist
    Private channel As Long
    Private pfl_player As New Player(General.program_settings.getPFLSoundCard, General.program_settings.getPFLPan, 100)
    Private pfl_item As Integer = -1
    Private query As String

    ' Preform the actual search

    Public Sub performSearch(ByRef query As String, Optional ByRef by As Integer = PlaylistSorter.EnumSortBy.Artist, Optional ByRef ascending As Boolean = True)

        Dim playlists As List(Of Playlist)
        Dim outer As Integer
        Dim inner As Integer
        Dim item As AudioItem

        ' Save the query

        Me.query = query

        ' Reset the playlist

        Me.playlist = New Playlist(Nothing, "Search Results")

        ' Lower case query

        query = query.ToLower

        ' Now get the complete array of playlists

        playlists = frmMain.getPlaylists

        ' We will now go through each result

        For outer = 0 To (playlists.Count - 1)
            For inner = 0 To (playlists.Item(outer).getPlaylistLength - 1)
                item = playlists.Item(outer).getItem(inner)

                ' If the string is contained in any field then add to results

                If (item.getAlbum.ToLower.Contains(query) Or item.getArtist.ToLower.Contains(query) Or item.getComposer.ToLower.Contains(query) Or item.getFileName.ToLower.Contains(query) Or item.getInfo.ToLower.Contains(query) Or item.getTimeEndIntro.ToString.ToLower.Contains(query) Or item.getTimeEndTrack.ToString.ToLower.Contains(query) Or item.getTimeExtroStart.ToString.ToLower.Contains(query) Or item.getTimeStartIntro.ToString.ToLower.Contains(query) Or item.getTimeStartTrack.ToString.ToLower.Contains(query) Or item.getTrackName.ToLower.Contains(query) Or item.getTunecode.ToLower.Contains(query) Or item.getWriter.ToLower.Contains(query) Or item.getDbTable.ToLower.Contains(query)) Then
                    Me.playlist.addToPlaylist(item)
                End If

            Next
        Next

        ' Perform the sort

        Me.playlist.orderBy(by, ascending)

    End Sub

    ' Performs a search on a specific playlist

    Public Sub performSearch(ByVal playlist_number As Integer, ByRef query As String)

        Dim playlists As List(Of Playlist)
        Dim inner As Integer
        Dim item As AudioItem

        ' Save the query

        Me.query = query

        ' Reset the playlist

        Me.playlist = New Playlist(Nothing, "Search Results")

        ' Lower case query

        query = query.ToLower

        ' Now get the complete array of playlists

        playlists = frmMain.getPlaylists

        ' We will now go through each result

        For inner = 0 To (playlists.Item(playlist_number).getPlaylistLength - 1)
            item = playlists.Item(playlist_number).getItem(inner)

            ' If the string is contained in any field then add to results

            If (item.getAlbum.ToLower.Contains(query) Or item.getArtist.ToLower.Contains(query) Or item.getComposer.ToLower.Contains(query) Or item.getFileName.ToLower.Contains(query) Or item.getInfo.ToLower.Contains(query) Or item.getTimeEndIntro.ToString.ToLower.Contains(query) Or item.getTimeEndTrack.ToString.ToLower.Contains(query) Or item.getTimeExtroStart.ToString.ToLower.Contains(query) Or item.getTimeStartIntro.ToString.ToLower.Contains(query) Or item.getTimeStartTrack.ToString.ToLower.Contains(query) Or item.getTrackName.ToLower.Contains(query) Or item.getTunecode.ToLower.Contains(query) Or item.getWriter.ToLower.Contains(query) Or item.getDbTable.ToLower.Contains(query)) Then
                Me.playlist.addToPlaylist(item)
            End If

        Next

        ' Perform the sort

        Me.playlist.orderBy(PlaylistSorter.EnumSortBy.Artist, True)

    End Sub

    ' Browses a playlist

    Public Sub performSearch(ByVal playlist_number As Integer)

        Dim playlists As List(Of Playlist)

        ' Get and load the playlist

        playlists = frmMain.getPlaylists
        Me.playlist = playlists(playlist_number)

        ' Sort

        Me.playlist.orderBy(PlaylistSorter.EnumSortBy.Artist, True)

    End Sub

    ' Get an item

    Public Function getItem(ByVal item_number As Integer) As AudioItem

        ' Don't bother if there is nothing

        If (Me.playlist Is Nothing) Then
            Return Nothing
            Exit Function
        End If

        ' Return the itme

        Return Me.playlist.getItem(item_number)

    End Function

    ' Perform a PFL

    Public Sub startPFL(ByVal item_number As Integer)

        ' Check if there is an item loaded

        If (Me.channel <> 0) Then
            Me.stopPFL()
        End If

        ' Now load and the selected item

        Me.pfl_player.loadItem(Me.playlist.getItem(item_number))
        Me.pfl_player.play(True)
        Me.channel = Me.pfl_player.getItem.getPlayoutChannel
        Me.pfl_item = item_number

    End Sub

    ' Stop a PFL

    Public Sub stopPFL()

        ' Stop and unload the item

        Me.pfl_player.stopPlayback(100, False)
        Me.pfl_player.unloadItem()
        Me.channel = 0
        Me.pfl_item = -1

    End Sub

    ' Get the search results

    Public Function getResults() As Playlist

        Return Me.playlist

    End Function

    ' On destruction routine

    Public Sub destroy()

        Me.pfl_player.unloadItem()

    End Sub

    ' Toggle the PFL

    Public Sub togglePFL(ByVal item_number As Integer)

        ' Stop the item if already on PFL

        If (Me.pfl_item.Equals(item_number)) Then
            Me.stopPFL()
        Else
            Me.startPFL(item_number)
        End If

    End Sub

End Class

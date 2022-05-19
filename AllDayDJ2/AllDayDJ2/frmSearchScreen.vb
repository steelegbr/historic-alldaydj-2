Imports Bass = Un4seen.Bass.Bass

Public Class frmSearchScreen

    Private sr_playlist As Playlist = New Playlist(Nothing, "Search Results")
    Private pfl_player As New Player(General.program_settings.getPFLSoundCard, General.program_settings.getPFLPan, 100)
    Private selected_item As AudioItem = Nothing

    ' Refresh display

    Public Sub refreshDisplay()

        On Error Resume Next

        Me.frmSearchScreen_Load(Nothing, Nothing)

    End Sub

    ' Close time events

    Private Sub frmSearchScreen_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        ' Stop PFL

        Me.pfl_player.stopPlayback(100, True)
        Me.pfl_player.unloadItem()

    End Sub

    ' Check for persistance

    Private Sub frmSearchScreen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If (General.screen_settings.PersistLibrary) Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If

    End Sub

    ' Control of main screen

    Private Sub frmSearchScreen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If (Not Me.tbSearch.Focused) Then
            frmMain.frmMain_KeyDown(sender, e)
            Me.BringToFront()
            Me.Focus()
        End If

    End Sub

    ' Load time events

    Private Sub frmSearchScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        On Error Resume Next

        Dim playlists As List(Of Playlist) = frmMain.getPlaylists()
        Dim counter As Integer

        ' Load the list of playlists

        Me.lbPlaylists.Items.Clear()
        Me.lbPlaylists.Items.Add("All Playlists")
        For counter = 0 To (playlists.Count - 1)
            Me.lbPlaylists.Items.Add(playlists(counter).getName)
        Next

        ' Select default

        Me.lbPlaylists.SelectedIndex = 0
        Me.lvResults.Items(0).Selected = True

        ' Set screen location

        Dim boundarys As Rectangle = Screen.AllScreens(General.screen_settings.ScreenLibrary).Bounds
        Me.SetBounds(boundarys.X, boundarys.Y, boundarys.Width, boundarys.Height)

    End Sub

    ' Performs a search

    Private Sub doSearch()

        On Error Resume Next

        Dim search_text As String
        Dim sr As SearchResults = New SearchResults()
        Dim counter As Integer
        Dim lvi As ListViewItem = Nothing
        Dim selected_playlist As Integer = 0

        ' Obtain the results

        search_text = Me.tbSearch.Text
        selected_playlist = Me.lbPlaylists.SelectedIndex

        ' Search all or search just one

        If (selected_playlist <= 0) Then
            sr.performSearch(search_text)
        Else
            sr.performSearch(selected_playlist - 1, search_text)
        End If

        Me.sr_playlist = sr.getResults()

        ' Display

        Me.lvResults.BeginUpdate()
        Me.pbLoading.Show()
        Dim lvi_array As New ListView.ListViewItemCollection(Me.lvResults)

        Me.lvResults.Items.Clear()
        For counter = 0 To (Me.sr_playlist.getPlaylistLength - 1)
            Me.pbLoading.Value = ((counter * 100) / (Me.sr_playlist.getPlaylistLength - 1))
            lvi = New ListViewItem(Me.sr_playlist.getItem(counter).getArtist)
            lvi.SubItems.Add(Me.sr_playlist.getItem(counter).getTrackName)
            lvi.SubItems.Add(Me.sr_playlist.getItem(counter).getAlbum)
            lvi.SubItems.Add(General.timeToString(Me.sr_playlist.getItem(counter).getTimeEndIntro - Me.sr_playlist.getItem(counter).getTimeStartIntro) & "/" & General.timeToString(Me.sr_playlist.getItem(counter).getTimeEndTrack - Me.sr_playlist.getItem(counter).getTimeStartTrack))
            lvi.SubItems.Add(Me.sr_playlist.getItem(counter).getDbTable)
            lvi.SubItems.Add(Me.sr_playlist.getItem(counter).getInfo)
            'Me.lvResults.Items.Add(lvi)
            lvi_array.Add(lvi)
            'My.Application.DoEvents()
        Next

        Me.lvResults.Items.AddRange(lvi_array)
        Me.pbLoading.Hide()
        Me.lvResults.EndUpdate()

        ' Auto width

        For counter = 0 To (Me.lvResults.Columns.Count - 1)
            Me.lvResults.Columns(counter).Width = -2
        Next

    End Sub

    ' Search box and button

    Private Sub tbSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbSearch.TextChanged

        Me.doSearch()

    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click

        Me.tbSearch.Text = ""
        Me.tbSearch.Focus()

    End Sub

    ' Playlists

    Private Sub lbPlaylists_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbPlaylists.SelectedIndexChanged

        doSearch()

    End Sub

    ' Items

    Private Sub lvResults_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvResults.SelectedIndexChanged

        On Error GoTo Exiter

        Dim selected_index As Integer = Me.lvResults.SelectedIndices(0)
        Dim selected_item As AudioItem = Nothing

        ' Check

        If (selected_index >= 0) Then
            selected_item = Me.sr_playlist.getItem(selected_index)
            Me.selected_item = selected_item
            Me.loadPFLPlayer()
        End If

Exiter:

    End Sub

    ' Load the PFL player

    Private Sub loadPFLPlayer()

        ' Check

        If (Me.selected_item Is Nothing) Then
            Exit Sub
        End If

        ' Unload / load

        Me.pfl_player.unloadItem()
        Me.pfl_player.loadItem(Me.selected_item, False)
        Me.tmrPFL.Enabled = True

    End Sub

    ' Update PFL player

    Private Sub tmrPFL_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrPFL.Tick

        On Error Resume Next

        Dim info_string As String
        Dim intro_length As Integer = 0
        Dim track_length As Integer = 0
        Dim current_position As Integer = 0
        Dim start_pos As Integer

        ' Get data

        intro_length = Me.selected_item.getTimeEndIntro - Me.selected_item.getTimeStartIntro
        track_length = Me.selected_item.getTimeEndTrack - Me.selected_item.getTimeStartTrack
        start_pos = Me.selected_item.getTimeStartTrack
        current_position = Bass.BASS_ChannelBytes2Seconds(Me.selected_item.getPlayoutChannel, Bass.BASS_ChannelGetPosition(Me.selected_item.getPlayoutChannel))

        ' Track bar

        Me.tbTrackPosition.Minimum = 0
        Me.tbTrackPosition.Maximum = track_length
        Me.tbTrackPosition.Value = current_position - start_pos

        ' Text

        info_string = "Artist: " & Me.selected_item.getArtist & vbCrLf
        info_string += "Title: " & Me.selected_item.getTrackName & vbCrLf
        info_string += "Length: " & General.timeToString(intro_length) & "/" & General.timeToString(track_length) & vbCrLf
        info_string += "Playlist: " & Me.selected_item.getDbTable
        Me.lblPFLInfo.Text = info_string

        Me.lblTrackPosition.Text = General.timeToString(current_position - start_pos) & "/" & General.timeToString(track_length)

    End Sub

    ' PFL Player
    ' PLAY

    Private Sub btnPFLPlay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPFLPlay.Click

        Me.pfl_player.play(False)

    End Sub

    Private Sub btnPFLStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPFLStop.Click

        Me.pfl_player.stopPlayback(2000, True)

    End Sub

    ' Slider

    Private Sub tbTrackPosition_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbTrackPosition.MouseDown

        Me.tmrPFL.Enabled = False

    End Sub

    Private Sub tbTrackPosition_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbTrackPosition.MouseUp

        If (Not Me.selected_item Is Nothing) Then
            Bass.BASS_ChannelSetPosition(Integer.Parse(Me.selected_item.getPlayoutChannel), Bass.BASS_ChannelSeconds2Bytes(Long.Parse(Me.selected_item.getPlayoutChannel), Me.tbTrackPosition.Value + Me.selected_item.getTimeStartTrack))
            Me.tmrPFL.Enabled = True
        End If

    End Sub

    ' Add to the playlist

    Private Sub btnAddToPlaylist_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddToPlaylist.Click

        frmMain.addToMainPL(Me.selected_item, False, False)

    End Sub

End Class
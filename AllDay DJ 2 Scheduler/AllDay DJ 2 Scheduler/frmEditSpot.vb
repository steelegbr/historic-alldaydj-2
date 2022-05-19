Public Class frmEditSpot

    Private spot As Spot
    Private start_pos As Integer = 0

    ' Load the spot

    Public Sub showEditSpot(ByVal spot As Spot)

        Dim counter As Integer
        Dim item As AudioItem

        Try

            ' Load the spot

            Me.spot = spot

            ' And the oncreen version

            Me.Text = "Edit Spot - " & Me.spot.spot_name
            Me.chkPlayAsList.Checked = Me.spot.play_as_list
            Me.lbItems.Items.Clear()

            For counter = 0 To (spot.playlist.getPlaylistLength - 1)
                item = spot.playlist.getItem(counter)
                Me.lbItems.Items.Add(item.getArtist & " - " & item.getTrackName & "[" & item.getDbTable & "]")
            Next

        Catch ex As Exception
            ErrorHandler.errorHandler(ex)
        End Try

    End Sub

    ' Add an item to the spot

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim playlist As Playlist
        Dim item_selecter As New dlgAddFromPlaylists

        ' Get the item

        item_selecter.setSender(Me)
        item_selecter.Show()
        playlist = item_selecter.selected_playlist

    End Sub

    ' Add an item to the spot

    Public Sub addToSpot(ByRef item As AudioItem)

        Me.spot.playlist.addToPlaylist(item)
        Me.updateDisplay()

    End Sub

    ' Show the spot onscreen

    Private Sub updateDisplay()

        Dim counter As Integer
        Dim item As AudioItem

        Me.lbItems.Items.Clear()

        For counter = 0 To (spot.playlist.getPlaylistLength - 1)
            item = spot.playlist.getItem(counter)
            Me.lbItems.Items.Add(item.getArtist & " - " & item.getTrackName & "[" & item.getDbTable & "]")
        Next

    End Sub

    ' Remove an item from the spot

    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        Dim selected_item As Integer

        ' Get the selected item

        selected_item = Me.lbItems.SelectedIndex
        If (selected_item < 0) Then
            Exit Sub
        End If

        ' Remove the item

        Me.spot.playlist.removeByIndex(selected_item)
        Me.updateDisplay()

    End Sub

    ' Save and close

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Me.spot.saveToDb()
        Me.Close()
        frmMain.updateDisplay()

    End Sub

    ' Checkbox change

    Private Sub chkPlayAsList_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPlayAsList.CheckedChanged

        Me.spot.play_as_list = Me.chkPlayAsList.Checked

    End Sub

    ' Right-click add

    Private Sub btnAdd_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAdd.MouseDown

        If (e.Button = Windows.Forms.MouseButtons.Right) Then
            frmAddToSpotHardware.Show()
        End If

    End Sub

End Class
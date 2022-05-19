Public Class frmTracks

    Private playlist_number As Integer
    Private playlist As Playlist

    ' Constructor

    Public Sub new_pl(ByRef playlist_number As Integer, ByRef playlist As Playlist)

        ' Load playlist name

        Me.playlist = playlist
        Me.Text = playlist.getName
        Me.playlist_number = playlist_number

        ' Update the display

        Me.updateDisplay()

    End Sub

    ' Update the display

    Public Sub updateDisplay()

        Dim counter As Integer
        Dim lv_item As ListViewItem
        Dim lv_item_artist As ListViewItem.ListViewSubItem
        Dim lv_item_track As ListViewItem.ListViewSubItem
        Dim item As AudioItem

        ' Clear the old list

        Me.lvItems.Items.Clear()

        ' Get the latest version

        Me.playlist = frmMain.getPlaylists(playlist_number)

        ' Now add to the onscreen list

        For counter = 0 To (Me.playlist.getPlaylistLength - 1)

            ' Get the item

            item = Me.playlist.getItem(counter)
            lv_item = New ListViewItem(item.getTrackId)

            ' Load the subitems

            lv_item_artist = New ListViewItem.ListViewSubItem(lv_item, item.getArtist)
            lv_item_track = New ListViewItem.ListViewSubItem(lv_item, item.getTrackName)
            lv_item.SubItems.Add(lv_item_artist)
            lv_item.SubItems.Add(lv_item_track)

            ' Load the actual item

            Me.lvItems.Items.Add(lv_item)

        Next

    End Sub

    ' Edit a track

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Dim index_collection As ListView.SelectedIndexCollection
        Dim track_number As Integer

        ' Get the track number

        index_collection = Me.lvItems.SelectedIndices
        If (index_collection.Count = 0) Then
            Exit Sub
        End If

        track_number = index_collection.Item(0)

        ' Load the editing screen

        frmEditTrack.loadData(Me, Me.playlist.getItem(track_number))
        frmEditTrack.Show()

    End Sub

    ' Close this screen

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click

        ' Update the display on the other screen

        frmMain.updatePlaylist(Me.playlist_number, Me.playlist)
        'frmDatabase.updateFromDB()
        frmDatabase.updateDisplay()

        ' Hide this form and show the database one

        frmDatabase.Show()
        Me.Hide()

    End Sub

    ' Add an item to this playlist

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        ' Import one or many

        If (dlgMultaple.ShowDialog = System.Windows.Forms.DialogResult.No) Then
            Me.addSingleItem()
        Else
            Me.addFolder()
        End If

    End Sub

    ' Add a single item

    Private Sub addSingleItem()

        Dim file_name As String
        Dim item As AudioItem

        Try

            Me.ofdMain.ShowDialog()
            file_name = Me.ofdMain.FileName

            ' Confirm a file was selected

            If (file_name.Length = 0) Then
                Exit Sub
            End If

            ' Check the file exists (the ofd should do this anyway)

            If (Not General.fileExists(file_name)) Then
                MsgBox("The file you selected does not exist!", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If

            ' Now load the item

            item = General.autoImport(file_name, Me.playlist.getName, "Item 1 of 1...")

            If (item Is Nothing) Then
                Exit Sub
            End If

            ' Add the item to the playlist

            Me.playlist.addToPlaylist(item)

            ' Update the playlist

            'frmDatabase.updateFromDB()
            Me.updateDisplay()

        Catch ex As Exception

            MsgBox("An error ocurred when trying to add an item to the database." & Chr(13) & Chr(10) & "The error is " & ex.Message & "." & Chr(13) & Chr(10) & "Bass error code " & Un4seen.Bass.Bass.BASS_ErrorGetCode & ".", MsgBoxStyle.Exclamation, "Error")

        End Try

    End Sub

    ' Add a folder of tracks

    Private Sub addFolder()

        Dim diBase As System.IO.DirectoryInfo
        Dim files() As System.IO.FileInfo
        Dim folder As String
        Dim ie As IEnumerator
        Dim total_files As Integer = 0
        Dim successful_files As Integer = 0
        Dim current As Integer = 0
        Dim item As AudioItem

        Try

            ' Get and check the folder name

            Me.fbdMain.ShowDialog()
            folder = Me.fbdMain.SelectedPath
            If (folder.Length = 0) Then
                Exit Sub
            End If

            ' List the files

            diBase = New System.IO.DirectoryInfo(folder)
            files = diBase.GetFiles("*.*", IO.SearchOption.AllDirectories)
            ie = files.GetEnumerator

            ' Get total

            While ie.MoveNext
                total_files += 1
            End While

            ie.Reset()

            While ie.MoveNext
                current += 1
                item = General.autoImport(DirectCast(ie.Current, System.IO.FileInfo).FullName, Me.playlist.getName, "Importing file " & current & "/" & total_files)
                If (Not item Is Nothing) Then
                    successful_files += 1
                    Me.playlist.addToPlaylist(item)
                End If
            End While

            ' Message to end user

            MsgBox(successful_files & " successful files." & Chr(13) & Chr(10) & total_files & " total.", MsgBoxStyle.Information, "Import complete")

            ' Update the screen

            'frmDatabase.updateFromDB()
            Me.updateDisplay()

        Catch ex As Exception
            'MsgBox("An error ocurred when trying to import a directory." & Chr(13) & Chr(10) & "The error is " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try

    End Sub

    ' Remove an item

    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        Dim index_collection As ListView.SelectedIndexCollection
        Dim track_number As Integer
        Dim item As AudioItem
        Dim db As Database

        ' Get the track number

        index_collection = Me.lvItems.SelectedIndices
        If (index_collection.Count = 0) Then
            Exit Sub
        End If

        track_number = index_collection.Item(0)
        item = Me.playlist.getItem(track_number)

        ' Check that the user wishes to delete

        If (MsgBox("Are you sure you wish to delete the entry for " & item.getArtist & " - " & item.getTrackName & "?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No) Then
            Exit Sub
        End If

        ' Remove the item

        db = New Database(General.program_settings.getDbLocation)
        If (Not db.execute("DELETE FROM [" & Me.playlist.getName & "] WHERE trackid = " & item.getTrackId)) Then
            MsgBox("An error ocurred when trying to delete the item.", MsgBoxStyle.Exclamation, "Error")
        End If
        db.disconnect()
        db = Nothing

        'frmDatabase.updateFromDB()
        Me.playlist.removeByItem(item)
        Me.updateDisplay()

    End Sub

    ' Move an item to another playlist

    Private Sub btnMove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMove.Click

        Dim selected_item As Integer

        ' Get the selected item

        selected_item = Me.lvItems.SelectedItems(0).Index
        If (selected_item < 0) Then
            Exit Sub
        End If

        ' And show the possible new playlists

        frmMoveToPlaylist.Show()
        frmMoveToPlaylist.BringToFront()
        frmMoveToPlaylist.loadItem(Me.playlist.getItem(selected_item), Me.playlist.getName, selected_item)

    End Sub

End Class
Public Class Playlist

    Private playlist As New List(Of AudioItem)
    Private onscreen As ListBox
    Private current_position As Integer = 0
    Private name As String
    Private current_selected_item As Integer = -1

    ' Constructor

    Public Sub New(ByVal list_view As ListBox, ByVal name As String)

        Me.onscreen = list_view
        Me.name = name

    End Sub

    ' Add an item to the playlist

    Public Sub addToPlaylist(ByRef item As AudioItem)

        playlist.Add(item)

    End Sub

    ' Remove an item from the playlist
    ' By index

    Public Sub removeByIndex(ByVal index As Integer)

        'playlist.Item(index).unloadTrack()
        Try
            playlist.RemoveAt(index)
        Catch ex As Exception
            ' Do nada
        End Try

    End Sub

    ' By the actual entry

    Public Sub removeByItem(ByRef item As AudioItem)

        On Error Resume Next

        'item.unloadTrack()
        If (Not playlist.Remove(item)) Then
            'MsgBox("Could not remove item from playlist!", MsgBoxStyle.Exclamation, "Error")
        End If

    End Sub

    ' Getters

    Public Function getPlaylistLength() As Integer

        Return playlist.Count

    End Function

    Public Function getItem(ByVal index As Integer) As AudioItem

        Try
            Return playlist.Item(index)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    ' Update the display

    Public Sub updateDisplay()

        On Error Resume Next

        Exit Sub

        Dim looper As Integer
        Dim looper_2 As Integer
        Dim display As String
        Dim current_selected As Integer

        ' Get selected

        current_selected = Me.onscreen.SelectedIndex

        ' Check for a zero length list first

        If (Me.playlist.Count = 0) Then
            Me.onscreen.Items.Clear()
            Exit Sub
        End If

        ' Clear the current display

        Me.onscreen.Items.Clear()

        ' Load all of the item

        For looper = 0 To (Me.playlist.Count - 1)

            Dim break_item As BreakItem = Nothing
            break_item = Me.playlist.Item(looper)

            If (Not break_item Is Nothing) Then
                display = "<<< BREAK >>>"
                Dim display_item As New ListViewItem(display)
                display_item.ForeColor = Color.Red
                Me.onscreen.Items.Add(display)
            Else
                display = "Artist: " & Me.playlist.Item(looper).getArtist & vbCrLf
                display += "Title: " & Me.playlist.Item(looper).getTrackName() & vbCrLf
                display += "Length: " & General.timeToString(Me.playlist.Item(looper).getTimeEndIntro - Me.playlist.Item(looper).getTimeStartIntro) & "/" & General.timeToString(Me.playlist.Item(looper).getTimeEndTrack - Me.playlist.Item(looper).getTimeStartTrack) & vbCrLf
                display += "Album: " & Me.playlist.Item(looper).getAlbum & vbCrLf
                display += "Info: " & Me.playlist.Item(looper).getInfo & vbCrLf
                display += "Playlist: " & Me.playlist.Item(looper).getDbTable & vbCrLf

                If (looper <= 3) Then

                    ' Main players

                    For looper_2 = 0 To 3
                        If (Me.playlist.Item(looper).Equals(frmMain.getPlayerArray(looper_2).getItem)) Then
                            display += "<< Player " & (looper_2 + 1) & " >>"
                        End If
                    Next

                End If

                Me.onscreen.Items.Add(display)

            End If
        Next

        ' Selected

        Me.onscreen.SelectedIndex = current_selected

    End Sub

    ' Randomises this playlist

    Public Sub randomise()

        On Error Resume Next

        Dim selected_item As Integer
        Dim new_playlist As New List(Of AudioItem)

        ' Do the randomisation

        While Me.playlist.Count > 0
            selected_item = Rnd() * Me.playlist.Count
            new_playlist.Add(Me.playlist(selected_item))
            Me.playlist.RemoveAt(selected_item)
        End While

        ' Copy over

        Me.playlist = new_playlist

    End Sub

    ' Get the next item from the randomized playlist

    Public Function getNextRandomItem() As AudioItem

        Dim selected_item As AudioItem

        ' Check length

        If (Me.getPlaylistLength = 0) Then
            Return Nothing
        End If

        ' Next item number

        Me.current_selected_item += 1
        If (Me.current_selected_item >= Me.playlist.Count) Then
            Me.current_selected_item = 0
        End If

        ' Get the item

        Return Me.playlist(Me.current_selected_item)

    End Function

    ' Returns the name of the playlist

    Public Function getName() As String
        Return Me.name
    End Function

    ' Clears the playlist

    Public Sub clear()
        Try
            Me.playlist.Clear()
        Catch ex As Exception
        End Try
    End Sub

    ' Clear all bar one

    Public Sub clearBarOne()
        Try
            Me.playlist.RemoveRange(1, (Me.playlist.Count - 1))
        Catch ex As Exception

        End Try
    End Sub

    ' Append another playlist

    Public Sub appendPlaylist(ByVal playlist As Playlist)

        Dim counter As Integer

        ' Copy all items

        For counter = 0 To (playlist.getPlaylistLength - 1)
            Me.addToPlaylist(playlist.getItem(counter))
        Next

    End Sub

    ' Add another playlist at a certain point

    Public Sub insertPlaylist(ByVal playlist As Playlist, ByVal index As Integer)

        ' Add in

        Me.playlist.InsertRange(index, playlist.playlist)

    End Sub

    ' Insert an item to the playlist

    Public Sub insertItem(ByVal item As AudioItem, ByVal index As Integer)

        Me.playlist.Insert(index, item)

    End Sub

    ' Set the name

    Public Sub setName(ByRef name As String)
        Me.name = name
    End Sub

    ' Update an item

    Public Sub updateItem(ByVal item_number As Integer, ByRef item As AudioItem)

        Me.playlist.Item(item_number) = item

    End Sub

    ' Move an item

    Public Sub moveUpOne(ByVal item_number As Integer)

        Dim temp_item As AudioItem

        ' Get the item we are going to move up

        temp_item = Me.playlist.Item(item_number)

        ' Swap the other one down

        Me.playlist.Item(item_number) = Me.playlist.Item(item_number - 1)
        Me.playlist.Item(item_number - 1) = temp_item

    End Sub

    Public Sub moveDownOne(ByVal item_number As Integer)

        Dim temp_item As AudioItem

        ' Get the item we are going to move down

        temp_item = Me.playlist.Item(item_number)

        ' Swap the other one up

        Me.playlist.Item(item_number) = Me.playlist.Item(item_number + 1)
        Me.playlist.Item(item_number + 1) = temp_item

    End Sub

    ' Search the playlist

    Public Function search(ByVal query As String) As Playlist

        Dim search_results As New Playlist(Nothing, "Search Results")
        Dim counter As Integer
        Dim item As AudioItem

        query = query.ToLower

        ' Go through every item
        ' make the comparisons

        For counter = 0 To (Me.playlist.Count - 1)
            item = Me.playlist.Item(counter)
            If (item.getAlbum.ToLower.Contains(query) Or item.getArtist.ToLower.Contains(query) Or item.getComposer.ToLower.Contains(query) Or item.getFileName.ToLower.Contains(query) Or item.getInfo.ToLower.Contains(query) Or item.getTimeEndIntro.ToString.ToLower.Contains(query) Or item.getTimeEndTrack.ToString.ToLower.Contains(query) Or item.getTimeExtroStart.ToString.ToLower.Contains(query) Or item.getTimeStartIntro.ToString.ToLower.Contains(query) Or item.getTimeStartTrack.ToString.ToLower.Contains(query) Or item.getTrackName.ToLower.Contains(query) Or item.getTunecode.ToLower.Contains(query) Or item.getWriter.ToLower.Contains(query) Or item.getDbTable.ToLower.Contains(query)) Then
                search_results.addToPlaylist(item)
            End If
        Next

        ' Send the results back

        Return search_results

    End Function

    ' Sorts a playlist

    Public Sub orderBy(ByRef by As Integer, ByRef ascending As Boolean)

        Dim pls As PlaylistSorter

        ' Setup

        If (ascending) Then
            pls = New PlaylistSorter(by, PlaylistSorter.EnumSortOrder.Ascending)
        Else
            pls = New PlaylistSorter(by, PlaylistSorter.EnumSortOrder.Descending)
        End If

        ' Sort

        'Me.playlist = pls.sort(Me.playlist)

    End Sub

End Class
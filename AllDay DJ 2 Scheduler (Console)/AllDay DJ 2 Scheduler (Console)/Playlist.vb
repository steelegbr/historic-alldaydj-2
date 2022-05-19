Public Class Playlist

    Private playlist As New List(Of AudioItem)
    Private onscreen As String
    Private current_position As Integer = 0
    Private name As String
    Private current_selected_item As Integer

    ' Constructor

    Public Sub New(ByVal list_view As String, ByVal name As String)

        Me.onscreen = list_view
        Me.name = name

    End Sub

    Public Sub New(ByVal old_pl As Playlist)

        Dim counter As Integer

        ' Default values

        Me.onscreen = old_pl.onscreen
        Me.name = old_pl.name

        ' Load the playlist up

        If (old_pl.getPlaylistLength > 0) Then
            For counter = 0 To (old_pl.getPlaylistLength - 1)
                Me.playlist.Add(old_pl.getItem(counter))
            Next
        End If


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
            MsgBox("Could not remove item from playlist!", MsgBoxStyle.Exclamation, "Error")
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

    ' Get the playlist length

    Public Function getPlaylistLengthTime() As Double

        Dim counter As Integer
        Dim length As Double = 0.0
        Dim item_length As Double

        ' Work thorugh each of the items

        If (Me.playlist.Count > 0) Then
            For counter = 0 To (Me.playlist.Count - 1)

                ' Get the item length

                item_length = (Me.playlist.Item(counter).getTimeEndTrack - Me.playlist.Item(counter).getTimeStartTrack)

                ' Adjust for playover

                If (Me.playlist.Item(counter).getPlayOver) Then

                    ' Do not cut from front if we are at the first item

                    If (counter > 0) Then

                        item_length -= (Me.playlist.Item(counter - 1).getTimeEndTrack - Me.playlist.Item(counter - 1).getTimeExtroStart)

                    End If

                    ' Again but rear and last item

                    If (counter < (Me.playlist.Count - 1)) Then

                        If (Me.playlist.Item(counter + 1).getTimeStartTrack = Me.playlist.Item(counter + 1).getTimeStartIntro) Then
                            item_length -= (Me.playlist.Item(counter + 1).getTimeEndIntro - Me.playlist.Item(counter + 1).getTimeStartIntro)
                        End If

                    End If

                End If

                ' We can't have negative lengths

                If (item_length < 0) Then
                    item_length = 0
                End If

                ' Now add to the count

                length += item_length

            Next

        End If

        ' And back to the studio :)

        Return length

    End Function

    ' Average length

    Public Function getAverageItemLength() As Integer

        Return (Me.getPlaylistLengthTime / Me.getPlaylistLength)

    End Function

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

End Class

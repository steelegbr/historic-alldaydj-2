Public Class Playlist

    Private playlist As New List(Of AudioItem)
    Private onscreen As ListBox
    Private current_position As Integer = 0
    Private name As String

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

End Class

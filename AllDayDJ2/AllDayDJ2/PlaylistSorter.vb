Public Class PlaylistSorter

    Public Enum EnumSortOrder As Integer
        Ascending = 0
        Descending = 1
    End Enum

    Public Enum EnumSortBy As Integer
        Artist = 0
        Track = 1
        Length = 2
    End Enum

    Public Enum EnumSortResult As Integer
        FirstBeforeSecond = -1
        BothEqual = 0
        SecondBeforeFirst = 1
    End Enum

    Public sort_order As EnumSortOrder = EnumSortOrder.Ascending
    Public sort_by As EnumSortBy = EnumSortBy.Artist

    ' Constructor

    Public Sub New(ByVal sort_by As Integer, ByVal sort_order As EnumSortOrder)

        Me.sort_order = sort_order
        Me.sort_by = sort_by

    End Sub

    ' Do a comparison between two items

    Private Function Compare(ByVal ai1 As AudioItem, ByVal ai2 As AudioItem) As Integer

        ' Convert the items

        Dim value1
        Dim value2

        ' Obtain the appropriate value

        Select Case Me.sort_by
            Case EnumSortBy.Artist
                value1 = ai1.getArtist
                value2 = ai2.getArtist
            Case EnumSortBy.Track
                value1 = ai1.getTrackName
                value2 = ai2.getTrackName
            Case EnumSortBy.Length
                value1 = (ai1.getTimeEndTrack - ai1.getTimeStartTrack)
                value2 = (ai2.getTimeEndTrack - ai2.getTimeStartTrack)
        End Select

        ' Make the comparison

        If (Me.sort_order = EnumSortOrder.Ascending) Then
            If (value1 = value2) Then
                Compare = EnumSortResult.BothEqual
            ElseIf (value1 < value2) Then
                Compare = EnumSortResult.FirstBeforeSecond
            ElseIf (value1 > value2) Then
                Compare = EnumSortResult.SecondBeforeFirst
            End If
        Else
            If (value1 = value2) Then
                Compare = EnumSortResult.BothEqual
            ElseIf (value1 < value2) Then
                Compare = EnumSortResult.SecondBeforeFirst
            ElseIf (value1 > value2) Then
                Compare = EnumSortResult.FirstBeforeSecond
            End If
        End If

    End Function

    ' Performs the sort

    Public Function sort(ByVal playlist As List(Of AudioItem)) As List(Of AudioItem)

        Dim swap_made As Boolean = True
        Dim counter As Integer

        ' Abort if null or empty

        If (playlist Is Nothing) Then
            Return playlist
        End If

        If (playlist.Count <= 1) Then
            Return playlist
        End If

        ' Loop while swaps are being made

        While swap_made

            ' Reset

            swap_made = False

            ' Loop

            For counter = 0 To (playlist.Count - 2)
                If (Compare(playlist(counter), playlist(counter + 1)) = EnumSortResult.SecondBeforeFirst) Then

                    ' Make a swap

                    swap_made = True
                    playlist = makeSwap(playlist, counter, (counter + 1))

                End If
            Next

        End While

        ' Return results

        Return playlist

    End Function

    ' Swaps two items

    Private Function makeSwap(ByRef playlist As List(Of AudioItem), ByVal index_1 As Integer, ByVal index_2 As Integer)

        Dim temp_item As AudioItem

        ' Check both integers

        If ((index_1 < 0) Or (index_1 > (playlist.Count - 1)) Or (index_2 < 0) Or (index_2 > (playlist.Count - 1))) Then
            Return playlist
        End If

        ' Perform the actual swap

        temp_item = playlist(index_1)
        playlist(index_1) = playlist(index_2)
        playlist(index_2) = temp_item

        ' Clear the temp

        temp_item = Nothing

        ' Return

        Return playlist

    End Function

End Class

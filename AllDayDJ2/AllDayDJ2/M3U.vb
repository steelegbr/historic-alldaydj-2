Public Class M3U

    Private Function m3uToPlaylist(ByVal file_name As String) As Playlist

        Dim playlist As New Playlist(Nothing, file_name)

        Try

            ' Open M3U file

            Dim fs As New IO.FileStream(file_name, IO.FileMode.Open, IO.FileAccess.Read)
            Dim sr As New IO.StreamReader(fs)

            ' Read line by line

            Dim line As String = sr.ReadLine

            While Not line Is Nothing

                ' Check line type

                If line.StartsWith("#") Then

                    ' Comment

                    If line.StartsWith("#break") Then

                        ' Break after

                        playlist.addToPlaylist(New BreakItem)

                    ElseIf line.StartsWith("#feed") Then

                        ' Audio feed

                        Dim split As String() = line.Split("|")
                        If (split.Length = 2) Then
                            playlist.addToPlaylist(New AudioItem(0, 0, Double.Parse(split(2)), False))
                        End If

                    End If

                Else

                    ' Normal item

                    If IO.File.Exists(line) Then

                        Dim item As AudioItem = Nothing

                        ' Grab from playlist otherwise create a new item

                        item = Me.getByFileName(line.Trim)
                        If item Is Nothing Then
                            item = New AudioItem(line.Trim)
                            item.setTimeEndTrack(item.getTimeEndTrack - 2)
                            item.setAttributes("Unknown Artist", "Unknown Track", "Unknown Album", "000000", "Unknown Composer", "Unknown Writer", "", item.getEndType, item.getPlayOver)
                        End If

                        ' Add to playlist

                        playlist.addToPlaylist(item)

                    End If

                End If

                ' Next line

                line = sr.ReadLine

            End While

        Catch e As Exception

            If playlist.getPlaylistLength > 0 Then
                Return playlist
            Else
                Return Nothing
            End If

        End Try

        ' Close file

        Return playlist

    End Function

    Private Function getByFileName(ByVal file_name As String) As AudioItem

        'On Error Resume Next

        Dim playlists As List(Of Playlist) = frmMain.getPlaylists
        Dim item As AudioItem
        Dim playlist As Playlist
        Dim i As Integer

        ' Cycle through playlists

        For Each playlist In playlists
            For i = 0 To (playlist.getPlaylistLength - 1)
                If playlist.getItem(i).getFileName.Equals(file_name) Then
                    Return playlist.getItem(i)
                End If
            Next
        Next


        ' Default

        Return Nothing

    End Function

    Public Function getCurrentlyScheduledPlaylist(ByVal folder As String, ByVal format_string As String, ByVal force As Boolean, ByVal previous_playlist As String) As Playlist

        Dim file_name As String

        ' Calculate file name

        file_name = folder + "\" + Format(Now, format_string)

        If force Then
            file_name += "-FORCE"
        End If

        file_name += ".M3U"

        ' Compare to previous

        If Not previous_playlist Is Nothing Then
            If file_name.Equals(previous_playlist) Then
                Return Nothing
            End If
        End If

        ' Check and open the file

        If IO.File.Exists(file_name) Then
            Return Me.m3uToPlaylist(file_name)
        Else
            Return Nothing
        End If

    End Function

End Class

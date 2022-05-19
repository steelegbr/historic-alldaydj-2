Imports sql = Npgsql

Public Class ConvertToPostgre

    Public Sub doConvert()

        Dim playlists As List(Of Playlist) = frmMain.getPlaylists()
        Dim i, j As Integer
        Dim item As AudioItem

        ' Connect

        Dim command As New Sql.NpgsqlCommand
        With command
            .Connection = New Sql.NpgsqlConnection("Server=localhost;Port=5432;Database=alldaydj;User Id=audio;password=audiopass")
            .Connection.Open()
        End With

        ' Enter data

        For i = 0 To (playlists.Count - 1)
            For j = 0 To (playlists(i).getPlaylistLength - 1)
                If Not playlists(i).getItem(j).getFileName.ToLower.EndsWith("wma") Then
                    item = playlists(i).getItem(j)
                    command.CommandText = "INSERT INTO audio VALUES ('" & sanitiser(item.getFileName) & "', '" & sanitiser(playlists(i).getName) & "', '" & sanitiser(item.getArtist) & "', '" & sanitiser(item.getTrackName) & "', '" & sanitiser(item.getAlbum) & "', '" & sanitiser(item.getTunecode) & "', '" & sanitiser(item.getComposer & vbCrLf & item.getWriter) & "', '" & sanitiser("NO RECORD COMPANY") & "', '" & sanitiser(item.getInfo) & "', 'NONE', " & (item.getTimeStartTrack * 1000) & ", " & (item.getTimeEndTrack * 1000) & ", " & ((item.getTimeEndTrack - item.getTimeStartTrack) * 1000) & ", " & (item.getTimeStartIntro * 1000) & ", " & (item.getTimeEndIntro * 1000) & ", " & ((item.getTimeEndIntro - item.getTimeStartIntro) * 1000) & ", " & (item.getTimeExtroStart * 1000) & ", " & (item.getTimeEndTrack * 1000) & ", " & ((item.getTimeEndTrack - item.getTimeExtroStart) * 1000) & ", " & item.getPlayOver & ", " & doesTrackFade(item) & ")"
                    command.ExecuteNonQuery()
                    Console.WriteLine("Converted item number " & j & " of playlist " & playlists(i).getName & ".")
                End If
            Next
        Next

        ' Close

        command.Connection.Close()

    End Sub

    Private Function doesTrackFade(ByVal track As AudioItem)

        If (track.getEndType = 2) Then
            Return "TRUE"
        Else
            Return "FALSE"
        End If

    End Function

    Private Function sanitiser(ByRef text As String)

        text = text.Replace("\", "\\")
        text = text.Replace("'", "\'")
        Return text

    End Function

End Class

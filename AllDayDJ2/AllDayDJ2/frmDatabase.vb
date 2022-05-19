Public Class frmDatabase

    Private db As Database
    Private playlists As New List(Of Playlist)

    ' Update the onscreen details

    Public Sub updateDisplay()

        Dim counter As Integer

        ' Clear current display and playlistd

        Me.lstPlaylists.Items.Clear()
        Me.playlists = frmMain.getPlaylists

        ' Display the playlists

        For counter = 0 To (playlists.Count - 1)
            Me.lstPlaylists.Items.Add(playlists.Item(counter).getName & Chr(13) & Chr(10) & playlists.Item(counter).getPlaylistLength & " items.")
        Next

    End Sub

    ' Update and exit

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click

        On Error Resume Next

        Me.Close()
        Me.updateFromDB()
        frmMain.setPlaylists(Me.playlists)

    End Sub

    ' Add a new playlist

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim playlist_name As String
        Dim is_valid As Boolean
        Dim counter As Integer

        ' Playlist name

        While (Not is_valid)

            playlist_name = InputBox("Please enter a name for the new playlist.", "Add A New Playlist", , , )
            is_valid = True

            ' Check validity

            If (playlist_name.Length) = 0 Then
                MsgBox("No name entered!" & Chr(13) & Chr(10) & "Please enter a name and try again.", MsgBoxStyle.Exclamation, "Error")
                is_valid = False
            End If

            For counter = 0 To (Me.playlists.Count - 1)
                If (playlist_name = Me.playlists.Item(counter).getName) Then
                    MsgBox("The name you entered already exists." & Chr(13) & Chr(10) & "Please enter another name and try again.", MsgBoxStyle.Exclamation, "Error")
                    is_valid = False
                End If
            Next

        End While

        ' Now create the playlist

        If (Me.db Is Nothing) Then
            db = New Database(General.program_settings.getDbLocation)
        End If

        If (Not db.execute("CREATE TABLE [" & playlist_name & "] (trackid INT IDENTITY(1,1) PRIMARY KEY, artist MEMO, track_name MEMO, album MEMO, tunecode MEMO, composer MEMO, writer MEMO, info MEMO, file_name MEMO, time_start_track DECIMAL, time_start_intro DECIMAL, time_end_intro DECIMAL, time_extro_start DECIMAL, time_end_track DECIMAL, end_type INT, allow_play_over VARCHAR(255))")) Then
            MsgBox("Could not create the new playlist." & Chr(13) & Chr(10) & "A database error occurred.", MsgBoxStyle.Exclamation, "Error")
        End If

        db.disconnect()
        db = Nothing

        ' Update the list

        Me.playlists.Add(New Playlist(Nothing, playlist_name))
        'Me.updateFromDB()
        Me.updateDisplay()

    End Sub

    ' Remove a playlist

    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        Dim playlist_name As String
        Dim playlist_no As Integer
        Dim counter As Integer
        Dim target As Integer
        Dim allow_reload As Boolean

        Try

            ' Get the name

            playlist_no = Me.lstPlaylists.SelectedIndex

            If (playlist_no.Equals(-1)) Then
                Exit Sub
            End If

            playlist_name = Me.playlists.Item(playlist_no).getName

            ' Check we are not deleting the UNSORTED playlist

            If (playlist_name.Equals("Unsorted Items")) Then
                MsgBox("Cannot remove this playlist." & Chr(13) & Chr(10) & "Please select another playlist and try again.", MsgBoxStyle.Information, "Error")
                Exit Sub
            End If

            ' Confirm the user wishes to delete this playlist

            If (MsgBox("Are you sure you wish to remove the " & playlist_name & " playlist?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm") = MsgBoxResult.No) Then
                Exit Sub
            End If

            ' Check what action the user wishes to take over any items in this list

            If (MsgBox("Do you wish to move the items in the " & playlist_name & " playlist to the Unsorted Items list?" & Chr(13) & Chr(10) & "If no is selected then the items will just be deleted!", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes) Then
                allow_reload = Me.copyPlaylist(playlist_name, "Unsorted Items", True)

                ' Find the target

                For counter = 0 To (Me.playlists.Count - 1)
                    If Me.playlists.Item(counter).getName.Equals("Unsorted Items") Then
                        target = counter
                    End If
                Next

                ' Copy to it

                'Me.playlists.Item(target).appendPlaylist(Me.playlists.Item(playlist_no))

            End If

            ' Delete the table

            db = New Database(General.program_settings.getDbLocation)
            db.execute("DROP TABLE [" & playlist_name & "]")
            db.disconnect()
            db = Nothing

            ' Update

            Me.playlists.Remove(Me.playlists.Item(playlist_no))
            frmMain.setPlaylists(Me.playlists)

            ' Reload only as appropriate

            If (allow_reload) Then
                Me.updateFromDB()
            End If

            Me.updateDisplay()

        Catch ex As Exception
            MsgBox("An error occurred." & Chr(13) & Chr(10) & "Details: " & ex.Message & ".", MsgBoxStyle.Exclamation, "Error")
        End Try

    End Sub

    ' Edit the playlist name

    Private Sub editPLName(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click

        Dim current_name As String
        Dim new_name As String = ""
        Dim pl_number As Integer
        Dim counter As Integer
        Dim db As New Database(General.program_settings.getDbLocation)

        ' Get the current playlist name

        Try

            pl_number = Me.lstPlaylists.SelectedIndex
            If (pl_number = -1) Then
                Exit Sub
            End If

            current_name = Me.playlists.Item(pl_number).getName

            ' Get new name

            While (new_name.Equals(""))

                new_name = InputBox("Please enter a new name for the " & current_name & " playlist." & Chr(13) & Chr(10) & "Note that leaving the name the same will prevent changes.", "Name Change", current_name)

                ' Check for null entry

                If (new_name.Length = 0) Then
                    MsgBox("No new name was entered for this playlist." & Chr(13) & Chr(10) & "Please enter a name and try again.", MsgBoxStyle.Exclamation, "Error")
                    new_name = ""
                End If

                ' Check for the same name

                If (new_name.Equals(current_name)) Then
                    Exit Sub
                End If

                ' Check for name of another playlist

                For counter = 0 To (Me.playlists.Count - 1)
                    If (new_name.Equals(Me.playlists.Item(counter).getName)) Then
                        MsgBox("The name you entered is already in use." & Chr(13) & Chr(10) & "Please enter another name and try again.", MsgBoxStyle.Exclamation, "Error")
                        new_name = ""
                    End If
                Next

            End While

            ' Create the new playlist

            If (Not db.execute("CREATE TABLE [" & new_name & "] (trackid INT IDENTITY(1,1) PRIMARY KEY, artist MEMO, track_name MEMO, album MEMO, tunecode MEMO, composer MEMO, writer MEMO, info MEMO, file_name MEMO, time_start_track DECIMAL, time_start_intro DECIMAL, time_end_intro DECIMAL, time_extro_start DECIMAL, time_end_track DECIMAL, end_type INT, allow_play_over VARCHAR(255))")) Then
                MsgBox("Could not rename playlist!", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If

            Me.playlists.Add(New Playlist(Nothing, new_name))

            ' Now we can do the actual copy

            Me.copyPlaylist(current_name, new_name, True)

            ' Remove the old one

            For counter = 0 To Me.playlists.Count
                If (Me.playlists.Item(counter).getName.Equals(current_name)) Then
                    Me.playlists.RemoveAt(counter)
                End If
            Next

            ' Update codes from DB

            'Me.updateFromDB()

        Catch ex As Exception

        End Try

        ' Do and update

        Me.updateDisplay()

    End Sub

    ' Copy one playlist to another (with destroy option)

    Private Function copyPlaylist(ByRef old_pl As String, ByRef new_pl As String, ByVal delete_old As Boolean) As Boolean

        Dim is_there As Boolean = False
        Dim counter As Integer
        Dim items As OleDb.OleDbDataReader
        Dim db2 As Database
        Dim pl_number As Integer
        Dim old_pl_number As Integer

        ' Check for a connection

        If (Me.db Is Nothing) Then
            db = New Database(General.program_settings.getDbLocation)
        End If

        ' Check if the new playlist is there

        For counter = 0 To (Me.playlists.Count - 1)
            If (Me.playlists.Item(counter).getName.Equals(new_pl)) Then
                is_there = True
                pl_number = counter
            End If
        Next

        ' Get the old playlist number

        For counter = 0 To (Me.playlists.Count - 1)
            If (Me.playlists.Item(counter).getName.Equals(old_pl)) Then
                old_pl_number = counter
            End If
        Next

        ' Create the playlist

        If (Not is_there) Then
            If (Not db.execute("CREATE TABLE [" & new_pl & "] (trackid INT IDENTITY(1,1) PRIMARY KEY, artist MEMO, track_name MEMO, album MEMO, tunecode MEMO, composer MEMO, writer MEMO, info MEMO, file_name MEMO, time_start_track DECIMAL, time_start_intro DECIMAL, time_end_intro DECIMAL, time_extro_start DECIMAL, time_end_track DECIMAL, end_type INT, allow_play_over VARCHAR(255))")) Then
                MsgBox("Could not copy playlist!", MsgBoxStyle.Exclamation, "Error")
                Exit Function
            End If
        End If

        ' Make a second connection

        db2 = New Database(General.program_settings.getDbLocation)

        ' Now copy the items over

        items = db.executeRS("SELECT * FROM [" & old_pl & "]")
        counter = 0

        While items.Read

            ' Add to an existing playlist and prevent reload
            ' Otherwise just add directly

            If (is_there) Then
                Me.playlists(old_pl_number).getItem(counter).setDBTable(new_pl)
                Me.playlists(old_pl_number).getItem(counter).saveNew()
                Me.playlists(pl_number).addToPlaylist(Me.playlists(old_pl_number).getItem(counter))
                counter += 1
            Else
                db2.execute("INSERT INTO [" & new_pl & "] (artist, track_name, album, tunecode, composer, writer, info, file_name, time_start_track, time_start_intro, time_end_intro, time_extro_start, time_end_track, end_type, allow_play_over) VALUES (""" & items.GetString(1) & """, """ & items.GetString(2) & """, """ & items.GetString(3) & """, """ & items.GetString(4) & """, """ & items.GetString(5) & """, """ & items.GetString(6) & """, """ & items.GetString(7) & """, " & items.GetString(8) & ", " & items.GetDecimal(9) & ", " & items.GetDecimal(10) & ", " & items.GetDecimal(11) & ", " & items.GetDecimal(12) & ", " & items.GetDecimal(13) & ", " & items.GetInt32(14) & ", """ & items.GetString(15) & """)")
            End If

        End While

        ' Close the database 2 connection

        db2.disconnect()
        items.Close()
        db2 = Nothing

        ' Delete the old table if we are told to

        If (delete_old) Then
            db.execute("DROP TABLE [" & old_pl & "]")
        End If

        db.disconnect()
        db = Nothing

        ' Do we allow reload

        If (is_there) Then
            Return False
        Else
            Return True
        End If

    End Function

    ' Edit the track list

    Private Sub btnTracks_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTracks.Click

        Dim playlist_number As Integer

        ' Get the playlist

        playlist_number = Me.lstPlaylists.SelectedIndex
        If (playlist_number = -1) Then
            Exit Sub
        End If

        ' Pass it on

        frmTracks.new_pl(playlist_number, Me.playlists.Item(playlist_number))
        frmTracks.Show()

    End Sub

    ' Update the playlists from the database

    Public Sub updateFromDB()

        Dim counter As Integer

        ' Clear the old playlists list

        Me.playlists = frmMain.getTables

        ' Load the playlists

        frmLoadingPlaylists.Show()

        For counter = 0 To (playlists.Count - 1)
            frmLoadingPlaylists.Text = "Loading Playlist" & Me.playlists.Item(counter).getName
            General.loadPlaylist(Me.playlists.Item(counter))
        Next

        frmLoadingPlaylists.Hide()

    End Sub

    Private Sub frmDatabase_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

        If (Not Me.db Is Nothing) Then
            db.disconnect()
        End If
        db = Nothing

    End Sub

End Class
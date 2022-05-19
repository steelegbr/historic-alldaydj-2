Imports Bass = Un4seen.Bass.Bass    ' Audio library

Public Class MasterControl

    Private current_player As Integer = 0
    Private state As Integer = 0
    Private faded As Boolean = False
    Private rot_pos As Integer = -1
    Private rot_playlists As List(Of Playlist)
    Public play_over As Boolean

    ' 0 - Stopped
    ' 1 - Playing
    ' 3 - Automated
    ' 4 - Stopping

    ' Play through the playlist

    Public Sub play(ByVal form As frmMain)

        Dim playlist As Playlist

        ' Check we are not already playing

        If (Me.state = 1 Or Me.state = 3) Then
            Exit Sub
        End If

        ' Now check we have something to play

        playlist = form.getCurrentPlaylist
        If (playlist.getPlaylistLength = 0) Then
            Exit Sub
        End If

        ' Start the playing

        Me.state = 1

        frmMain.setCurrentPlayer(Me.current_player)
        If (Not frmMain.getPlayerArray(Me.current_player).playItem()) Then
            frmMain.getPlayerArray(Me.current_player).stopItem(2000)
            'Me.playNextItem()
        End If

    End Sub

    ' Update any info

    Public Sub update()

        Dim item As AudioItem
        Dim current_position As Double
        Dim next_item As AudioItem
        Dim next_item_number As Integer = 0
        Dim volume As New Integer()

        ' Don't bother if we are -1 state

        If (Me.current_player = -1) Then
            Exit Sub
        End If

        ' Onscreen for current player

        item = frmMain.getPlayerArray(Me.current_player).getItem
        If (Not item Is Nothing) Then
            frmMain.lblTrackRemain.Text = frmMain.player_time_left(Me.current_player).Text
            frmMain.lblTrackRemain.BackColor = frmMain.player_time_left(Me.current_player).BackColor
            frmMain.lblTrackRemain.ForeColor = frmMain.player_time_left(Me.current_player).ForeColor
            frmMain.lblTrackRemainTitle.BackColor = frmMain.player_time_left(Me.current_player).BackColor
            frmMain.lblTrackRemainTitle.ForeColor = frmMain.player_time_left(Me.current_player).ForeColor
        Else
            frmMain.lblTrackRemain.Text = "00:00"
            frmMain.lblTrackRemain.BackColor = Color.Black
            frmMain.lblTrackRemain.ForeColor = Color.Red
            frmMain.lblTrackRemainTitle.BackColor = Color.Black
            frmMain.lblTrackRemainTitle.ForeColor = Color.Red
        End If

        ' Instant player fading

        If (Me.faded) Then
            If (Not Me.ipPlaying) Then
                frmMain.ip_playing = False
                Me.fadeUp()
            End If
        End If

        ' Playing over

        If (Not item Is Nothing And Me.state <> 0 And Me.state <> 4 And Not frmMain.getBreakAfter) Then
            current_position = Bass.BASS_ChannelBytes2Seconds(item.getPlayoutChannel, Bass.BASS_ChannelGetPosition(item.getPlayoutChannel))

            If (current_position >= item.getTimeExtroStart And current_position < item.getTimeEndTrack) Then

                ' Get the item number

                next_item_number = Me.current_player + 1
                If next_item_number > 3 Then
                    next_item_number = 0
                End If

                ' Check there is something to play

                If (Not frmMain.getPlayerArray(next_item_number).getItem Is Nothing) Then
                    If (frmMain.getPlayerArray(next_item_number).getItem.getPlayOver) Then
                        frmMain.getPlayerArray(next_item_number).playItem()
                        'Bass.BASS_ChannelSlideAttributes(item.getPlayoutChannel, -1, General.program_settings.getFadeLevel, -101, 2000)
                        General.main_channel = frmMain.getPlayerArray(Me.current_player).getItem.getPlayoutChannel
                        General.play_over_channel = frmMain.getPlayerArray(next_item_number).getItem.getPlayoutChannel
                        Me.play_over = True
                    End If
                End If

            ElseIf (item.getPlayOver) Then

                ' Get the next item

                next_item_number = Me.current_player + 1
                If next_item_number > 3 Then
                    next_item_number = 0
                End If

                ' Check the intro

                If (Not frmMain.getPlayerArray(next_item_number).getItem Is Nothing) Then
                    next_item = frmMain.getPlayerArray(next_item_number).getItem
                    If (next_item.getTimeStartTrack = next_item.getTimeStartIntro) Then
                        If ((next_item.getTimeEndIntro - next_item.getTimeStartIntro) >= (item.getTimeEndTrack - current_position)) Then
                            frmMain.getPlayerArray(next_item_number).playItem()
                            'Bass.BASS_ChannelSlideAttributes(next_item.getPlayoutChannel, -1, General.program_settings.getFadeLevel, -101, 2000)
                            General.play_over_channel = frmMain.getPlayerArray(Me.current_player).getItem.getPlayoutChannel
                            General.main_channel = frmMain.getPlayerArray(next_item_number).getItem.getPlayoutChannel
                            Me.play_over = True
                        End If
                    End If
                End If

            End If
        End If

        ' Perform play over checks

        If (Me.play_over) Then
            General.doDucker()
        End If

    End Sub

    ' Play the next item

    Public Sub playNextItem()

        Dim playlist As Playlist

        ' Check player state

        If (Me.state = 0) Then
            Exit Sub
        End If

        ' Check for a zero length playlist

        playlist = frmMain.getCurrentPlaylist
        If (playlist.getPlaylistLength = 0) Then
            Me.state = 0
            Me.current_player = 0
            frmMain.setCurrentPlayer(-1)
            Exit Sub
        End If

        ' Get the next current player

        Me.current_player += 1
        If (Me.current_player > 3) Then
            Me.current_player = 0
        End If

        ' Set the current player

        frmMain.setCurrentPlayer(Me.current_player)

        ' Check for break after

        If (frmMain.getBreakAfter) Then
            Me.state = 0
            frmMain.toggleBreakAfter()
            Exit Sub
        End If

        ' Cancel play over

        Me.play_over = False

        ' Play the item

        frmMain.getPlayerArray(Me.current_player).playItem()

        ' Fade back up

        If (Not Me.faded) Then
            Bass.BASS_ChannelSlideAttributes(frmMain.getPlayerArray(Me.current_player).getItem.getPlayoutChannel, -1, 100, -101, 2000)
        End If

        ' Automatic rotation

        If (Not Me.rot_playlists Is Nothing) Then
            While (frmMain.getCurrentPlaylist.getPlaylistLength < 5)
                Me.automatedAddToPl()
            End While
        End If

    End Sub

    ' Get the state

    Public Function getState() As Integer

        Dim state As Integer

        ' Get state

        state = Me.state

        ' Adjust as reqd

        If (Not Me.rot_playlists Is Nothing) Then
            state = 3
        End If

        ' And return it

        Return state

    End Function

    ' Stop playback

    Public Sub stopPlayback()

        Me.play_over = False

        Me.state = 0
        frmMain.getPlayerArray(Me.current_player).stopItem(2000)

        ' Stop automatic rotation

        If (Not Me.rot_playlists Is Nothing) Then
            Me.automate()
        End If

        ' Get the next current player

        Me.current_player += 1
        If (Me.current_player > 3) Then
            Me.current_player = 0
        End If

        ' But change this if there is nothing after this item

        If (frmMain.getCurrentPlaylist.getPlaylistLength = 0) Then
            Me.current_player = 0
            frmMain.setCurrentPlayer(-1)
            Exit Sub
        End If

        ' Set the current player

        frmMain.setCurrentPlayer(Me.current_player)

    End Sub

    ' Fade the tracks down

    Public Sub fadeDown()

        Dim counter As Integer

        ' Check each player can be faded and fade them down

        For counter = 0 To 3
            If (frmMain.getPlayerArray(counter).getState <> 0 And frmMain.getPlayerArray(counter).getState <> 4) Then
                Un4seen.Bass.Bass.BASS_ChannelSlideAttributes(frmMain.getPlayerArray(counter).getItem.getPlayoutChannel, -1, General.program_settings.getDuckerFadeLevel, -101, 2000)
            End If
        Next

        ' Adjust faded flag

        Me.faded = True

    End Sub

    ' Fade the tracks up

    Private Sub fadeUp()

        Dim counter As Integer

        ' Check each player can be faded and fade them up

        For counter = 0 To 3
            If (frmMain.getPlayerArray(counter).getState <> 0 And frmMain.getPlayerArray(counter).getState <> 4) Then
                Un4seen.Bass.Bass.BASS_ChannelSlideAttributes(frmMain.getPlayerArray(counter).getItem.getPlayoutChannel, -1, 100, -101, 2000)
            End If
        Next

        ' Adjust faded flag

        Me.faded = False

    End Sub

    ' Check the instant players

    Private Function ipPlaying() As Boolean

        Dim counter As Integer

        ' Check each of the players

        For counter = 0 To 8
            If (Un4seen.Bass.Bass.BASS_ChannelIsActive(frmMain.getIPs(counter).getItem.getPlayoutChannel)) Then
                Return True
                Exit Function
            End If
        Next

        Return False

    End Function

    ' Do the automation

    Public Sub automate()

        Dim playlists As List(Of Playlist) = frmMain.getPlaylists
        Dim counter As Integer
        Dim sub_counter As Integer
        Dim rotation As List(Of String) = General.program_settings.getRotation
        Dim possible_item_count As Integer = 0

        On Error Resume Next

        ' Check the state

        If (Not Me.rot_playlists Is Nothing) Then
            frmMain.btnAutomate.BackColor = frmMain.btnNext.BackColor
            Me.rot_playlists = Nothing
            Me.rot_pos = -1
            Exit Sub
        End If

        ' Setup the defaults

        frmMain.btnAutomate.BackColor = Color.LightGreen
        Me.rot_playlists = New List(Of Playlist)

        ' Now load the rotation

        For counter = 0 To (rotation.Count - 1)
            For sub_counter = 0 To (playlists.Count - 1)
                If (playlists.Item(sub_counter).getName.Equals(rotation(counter))) Then
                    Me.rot_playlists.Add(playlists.Item(sub_counter))
                End If
            Next
        Next

        ' Check the item count

        For counter = 0 To (Me.rot_playlists.Count - 1)
            possible_item_count += Me.rot_playlists(counter).getPlaylistLength
        Next

        If (possible_item_count = 0) Then
            MsgBox("The rotation playlists are empty." & vbCrLf & vbCrLf & "Please fill the rotation playlists or set active playlists for rotation.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Automation")
            Me.automate()
            Exit Sub
        End If

        ' Now add automated items to the playlist

        While (frmMain.getCurrentPlaylist.getPlaylistLength < 5)
            Me.automatedAddToPl()
        End While

        ' Start playback

        My.Application.DoEvents()
        Me.play(frmMain)

        ' Change the state

        Me.state = 3

    End Sub

    ' Add an automated item to the playlist

    Public Sub automatedAddToPl()

        Dim rot_pos As Integer
        Dim random_item_number As Integer
        Dim valid As Boolean = False
        Dim iter_count As Integer = 0
        Dim selected_item As AudioItem = Nothing

        ' Get next rotation item

        rot_pos = Me.rot_pos + 1
        If (rot_pos > (Me.rot_playlists.Count - 1)) Then
            rot_pos = 0
        End If

        ' Loop until we get something

        While Not valid

            valid = True

            ' Get

            selected_item = Me.rot_playlists(rot_pos).getNextRandomItem

            ' Legal checks

            iter_count += 1
            If (iter_count <= 10) Then
                valid = do2hrCheck(Me.rot_playlists(rot_pos).getItem(random_item_number))
            End If

        End While

        ' Load the item

        frmMain.addToMainPL(selected_item, False, True)

        ' Update the rot pos

        Me.rot_pos = rot_pos

    End Sub

    ' Do the 2 hr check

    Private Function do2hrCheck(ByRef item As AudioItem) As Boolean

        Dim db As Database
        Dim rs As OleDb.OleDbDataReader
        Dim count As Integer = 0

        If (item Is Nothing) Then
            Return True
            Exit Function
        End If

        ' Don't bother with blank or unknown artists

        If (item.getArtist.ToLower.Equals("unknown") Or item.getArtist.ToLower.Equals("")) Then
            Return True
            Exit Function
        End If

        ' Make the query

        db = New Database(General.program_settings.getLogsLocation)
        rs = db.executeRS("SELECT * FROM log WHERE [Time Started] >= """ & Now.AddHours(-2) & """ AND [Artist] = """ & item.getArtist & """")

        ' Count the number of results

        While rs.Read
            count += 1
        End While

        ' Close the connection

        rs.Close()
        db.disconnect()
        rs = Nothing
        db = Nothing

        ' Make the decision

        If (count >= 2) Then
            Return False
        Else
            Return True
        End If

    End Function

    ' Set the current player

    Public Sub setCurrentPlayer(ByVal player_number As Integer)
        Me.current_player = player_number
    End Sub

End Class

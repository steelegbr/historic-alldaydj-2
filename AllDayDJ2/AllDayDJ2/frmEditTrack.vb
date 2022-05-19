Imports Bass = Un4seen.Bass.Bass    ' Audio system

Public Class frmEditTrack

    Private parent_form As Form
    Private item As AudioItem
    Private is_paused As Boolean = False

    ' Pre-load any required data

    Public Function loadData(ByRef parent As Form, ByRef item As AudioItem) As Boolean

        Dim right_slash As Integer

        Try

            ' Get the data

            Me.parent_form = parent
            Me.item = item

            ' Load the item

            If (Not Me.item.loadTrack(General.program_settings.getPFLSoundCard, General.program_settings.getPFLPan, 100, False)) Then
                MsgBox("Could not load item." & Chr(13) & Chr(10) & "Bass error code " & Bass.BASS_ErrorGetCode & ".", MsgBoxStyle.Exclamation, "Error")
                Return False
            End If

            ' Load the values

            Me.tbPosition.Maximum = Bass.BASS_ChannelBytes2Seconds(Me.item.getPlayoutChannel, Bass.BASS_ChannelGetLength(Me.item.getPlayoutChannel))
            Me.tbPosition.Value = 0

            ' Load the title

            right_slash = Me.item.getFileName.LastIndexOf("\")
            Me.Text = "Edit Track - " & Me.item.getFileName.Substring(right_slash + 1)

            ' Load the times

            Me.lblTime1.Text = General.timeToString(Me.item.getTimeStartTrack)
            Me.lblTime2.Text = General.timeToString(Me.item.getTimeStartIntro)
            Me.lblTime3.Text = General.timeToString(Me.item.getTimeEndIntro)
            Me.lblTime4.Text = General.timeToString(Me.item.getTimeExtroStart)
            Me.lblTime5.Text = General.timeToString(Me.item.getTimeEndTrack)

            ' Load all other data

            Me.tbAlbum.Text = Me.item.getAlbum
            Me.tbArtist.Text = Me.item.getArtist
            Me.tbComposer.Text = Me.item.getComposer
            Me.tbInfo.Text = Me.item.getInfo
            Me.tbTrack.Text = Me.item.getTrackName
            Me.tbTunecode.Text = Me.item.getTunecode
            Me.tbWriter.Text = Me.item.getWriter
            Me.cbEndType.SelectedIndex = Me.item.getEndType
            Me.cbPlayOver.Checked = Me.item.getPlayOver
            Me.lblFile.Text = Me.item.getFileName

            ' Enable the timer

            Me.tmrPosition.Enabled = True

        Catch ex As Exception

            ' Error occurred

            MsgBox("An error has ocurred when trying to load a track for editing." & Chr(13) & Chr(10) & "The error type is " & ex.Message & ".", MsgBoxStyle.Critical, "Error")
            Return False

        End Try

        ' All OK

        Return True

    End Function

    Private Sub saveAndClose(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim playlist As Playlist
        Dim playlists As List(Of Playlist)
        Dim pl_number As Integer
        Dim item_number As Integer
        Dim counter As Integer
        Dim item As AudioItem

        ' Update the item

        Me.item.setAttributes(Me.tbArtist.Text, Me.tbTrack.Text, Me.tbAlbum.Text, Me.tbTunecode.Text, Me.tbComposer.Text, Me.tbWriter.Text, Me.tbInfo.Text, Me.cbEndType.SelectedIndex, Me.cbPlayOver.Checked)

        ' Save all changes, close and update the parent's display

        Me.tmrPosition.Enabled = False
        Me.item.save()
        Me.item.unloadTrack()

        If (Me.parent_form.Equals(frmTracks)) Then
            frmTracks.updateDisplay()
            frmTracks.Show()
        Else

            ' EDIT NO LONGER ALLOWED FROM SEARCH

        End If

        Me.Close()

    End Sub

    ' Play, pause and stop routines

    Private Sub btnPlay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlay.Click

        Bass.BASS_ChannelPlay(Me.item.getPlayoutChannel, True)

    End Sub

    Private Sub btnPause_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPause.Click

        ' Pause or play as appropriate

        If (Not Me.is_paused) Then
            Bass.BASS_ChannelPause(Me.item.getPlayoutChannel)
        Else
            Bass.BASS_ChannelPlay(Me.item.getPlayoutChannel, False)
        End If

        ' Update the info

        Me.is_paused = Not Me.is_paused

    End Sub

    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStop.Click

        ' Pause (prevents errors over stop)

        Bass.BASS_ChannelPause(Me.item.getPlayoutChannel)
        Bass.BASS_ChannelSetPosition(Integer.Parse(Me.item.getPlayoutChannel), 0)

        ' Update the info

        Me.is_paused = False

    End Sub

    ' Time update timer

    Private Sub tmrPosition_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrPosition.Tick

        Dim track_length As Double
        Dim current_position As Double

        ' Get the current position

        track_length = Bass.BASS_ChannelBytes2Seconds(Me.item.getPlayoutChannel, Bass.BASS_ChannelGetLength(Me.item.getPlayoutChannel))
        current_position = Bass.BASS_ChannelBytes2Seconds(Me.item.getPlayoutChannel, Bass.BASS_ChannelGetPosition(Me.item.getPlayoutChannel))

        ' Update the progress bar

        If (current_position <> -1) Then
            Me.tbPosition.Value = current_position
        End If


        ' Update the textbox

        Me.lblTrackTime.Text = General.timeToString(current_position) & " / " & General.timeToString(track_length)

    End Sub

    ' Mouse down and up for the progress bar

    Private Sub tbPosition_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbPosition.MouseDown

        Me.tmrPosition.Enabled = False

    End Sub

    Private Sub tbPosition_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbPosition.MouseUp

        Bass.BASS_ChannelSetPosition(Integer.Parse(Me.item.getPlayoutChannel), Single.Parse(Me.tbPosition.Value))
        Me.tmrPosition.Enabled = True

    End Sub

    ' Time editing

    Private Sub timeEdit(ByVal sender As Object, ByVal e As EventArgs) Handles btnExtro.Click, btnIntroEnd.Click, btnIntroStart.Click, btnTrackEnd.Click, btnStart.Click

        Dim time_start_track As Double = Me.item.getTimeStartTrack
        Dim time_start_intro As Double = Me.item.getTimeStartIntro
        Dim time_end_intro As Double = Me.item.getTimeEndIntro
        Dim time_extro_start As Double = Me.item.getTimeExtroStart
        Dim time_end_track As Double = Me.item.getTimeEndTrack

        ' Update the appropriate time

        If (sender.Equals(Me.btnStart)) Then
            time_start_track = Bass.BASS_ChannelBytes2Seconds(Me.item.getPlayoutChannel, Bass.BASS_ChannelGetPosition(Me.item.getPlayoutChannel))
        End If

        If (sender.Equals(Me.btnIntroStart)) Then
            time_start_intro = Bass.BASS_ChannelBytes2Seconds(Me.item.getPlayoutChannel, Bass.BASS_ChannelGetPosition(Me.item.getPlayoutChannel))
        End If

        If (sender.Equals(Me.btnIntroEnd)) Then
            time_end_intro = Bass.BASS_ChannelBytes2Seconds(Me.item.getPlayoutChannel, Bass.BASS_ChannelGetPosition(Me.item.getPlayoutChannel))
        End If

        If (sender.Equals(Me.btnExtro)) Then
            time_extro_start = Bass.BASS_ChannelBytes2Seconds(Me.item.getPlayoutChannel, Bass.BASS_ChannelGetPosition(Me.item.getPlayoutChannel))
        End If

        If (sender.Equals(Me.btnTrackEnd)) Then
            time_end_track = Bass.BASS_ChannelBytes2Seconds(Me.item.getPlayoutChannel, Bass.BASS_ChannelGetPosition(Me.item.getPlayoutChannel))
        End If

        ' Check that the times work out

        If (time_start_track > time_start_intro) Then
            time_start_intro = time_start_track
        End If

        If (time_start_intro > time_end_intro) Then
            time_end_intro = time_start_intro
        End If

        If (time_end_intro > time_extro_start) Then
            time_extro_start = time_end_intro
        End If

        If (time_extro_start > time_end_track) Then
            time_end_track = time_extro_start
        End If

        ' Now send the changes to the item

        Me.item.setAttributes(Me.tbArtist.Text, Me.tbTrack.Text, Me.tbAlbum.Text, Me.tbTunecode.Text, Me.tbComposer.Text, Me.tbWriter.Text, Me.tbInfo.Text, Me.cbEndType.SelectedIndex, Me.cbPlayOver.Checked, time_start_track, time_start_intro, time_end_intro, time_extro_start, time_end_track)

        ' Update the display

        Me.lblTime1.Text = General.timeToString(time_start_track)
        Me.lblTime2.Text = General.timeToString(time_start_intro)
        Me.lblTime3.Text = General.timeToString(time_end_intro)
        Me.lblTime4.Text = General.timeToString(time_extro_start)
        Me.lblTime5.Text = General.timeToString(time_end_track)

    End Sub

    ' Test buttons

    Private Sub btnTest1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTest1.Click
        Bass.BASS_ChannelSetPosition(Integer.Parse(Me.item.getPlayoutChannel), Single.Parse(Me.item.getTimeStartTrack))
    End Sub

    Private Sub btnTest2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTest2.Click
        Bass.BASS_ChannelSetPosition(Integer.Parse(Me.item.getPlayoutChannel), Single.Parse(Me.item.getTimeStartIntro))
    End Sub

    Private Sub btnTest3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTest3.Click
        Bass.BASS_ChannelSetPosition(Integer.Parse(Me.item.getPlayoutChannel), Single.Parse(Me.item.getTimeEndIntro))
    End Sub

    Private Sub btnTest4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTest4.Click
        Bass.BASS_ChannelSetPosition(Integer.Parse(Me.item.getPlayoutChannel), Single.Parse(Me.item.getTimeExtroStart))
    End Sub

    Private Sub btnTest5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTest5.Click
        Bass.BASS_ChannelSetPosition(Integer.Parse(Me.item.getPlayoutChannel), Single.Parse(Me.item.getTimeEndTrack))
    End Sub

End Class
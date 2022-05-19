Imports Bass = Un4seen.Bass.Bass

Public Class MainPlayer

    Inherits Player

    ' Control properties

    Private player_number As Integer
    Private state As Integer = 0
    Private time_started As Date

    ' Player STATES

    ' 0 - Stopped (not loaded)
    ' 1 - Stopped (loaded)
    ' 2 - Playing
    ' 3 - Fading out

    ' Constructor

    Public Sub New(ByVal sound_card As Integer, ByVal pan As Integer, ByVal volume As Integer, ByVal player_number As Integer)

        MyBase.New(sound_card, pan, volume)
        Me.player_number = player_number

    End Sub

    ' Update the onscreen data

    Private Sub updateOnscreen()

        Dim current_position As Double

        On Error Resume Next

        ' Current position data

        current_position = Bass.BASS_ChannelBytes2Seconds(Me.getItem.getPlayoutChannel, Bass.BASS_ChannelGetPosition(Me.getItem.getPlayoutChannel))
        If (current_position < 0) Then
            current_position = 0
        End If

        ' Display the raw data

        frmMain.player_artist(Me.player_number).Text = Me.getItem.getArtist
        frmMain.player_progress(Me.player_number).Maximum = Me.getItem.getTimeEndTrack
        frmMain.player_progress(Me.player_number).Minimum = Me.getItem.getTimeStartTrack
        frmMain.player_progress(Me.player_number).Value = current_position
        frmMain.player_time_left(Me.player_number).Text = General.timeToString(Me.getItem.getTimeEndTrack - current_position)
        frmMain.player_time_played(Me.player_number).Text = General.timeToString(current_position - Me.getItem.getTimeStartTrack)
        frmMain.player_title(Me.player_number).Text = Me.getItem.getTrackName

        ' Adjust any colours on displays

        If (current_position < Me.getItem.getTimeEndIntro And current_position >= Me.getItem.getTimeStartIntro) Then
            frmMain.player_time_left(Me.player_number).Text = General.timeToString(Me.getItem.getTimeEndIntro - current_position)
            frmMain.player_time_left(Me.player_number).BackColor = Color.Green
            frmMain.player_time_left(Me.player_number).ForeColor = Color.Black
        ElseIf ((Me.getItem.getTimeEndTrack - current_position) <= 10 And (Me.getItem.getTimeEndTrack - current_position) > 0 And Me.state > 0) Then
            Exit Sub
        ElseIf (current_position > Me.getItem.getTimeExtroStart) Then
            frmMain.player_time_left(Me.player_number).BackColor = Color.Red
            frmMain.player_time_left(Me.player_number).ForeColor = Color.Black
        Else
            frmMain.player_time_left(Me.player_number).BackColor = Color.Black
            frmMain.player_time_left(Me.player_number).ForeColor = Color.Red
        End If

    End Sub

    ' Get the player state

    Public Function getState() As Integer
        Return Me.state
    End Function

    ' Blank view

    Private Sub blankView()

        frmMain.player_artist(Me.player_number).Text = ""
        frmMain.player_progress(Me.player_number).Minimum = 0
        frmMain.player_progress(Me.player_number).Maximum = 100
        frmMain.player_progress(Me.player_number).Value = 0
        frmMain.player_time_left(Me.player_number).Text = "00:00"
        frmMain.player_time_played(Me.player_number).Text = "00:00"
        frmMain.player_title(Me.player_number).Text = ""
        frmMain.player_time_left(Me.player_number).BackColor = Color.Black
        frmMain.player_time_left(Me.player_number).ForeColor = Color.Red


    End Sub

    ' Play override

    Public Function playItem() As Boolean

        On Error Resume Next

        ' Break check

        Dim bi As BreakItem = Nothing
        bi = Me.getItem

        If (Not bi Is Nothing) Then
            frmMain.getMC.stopPlayback()
            Return True
        End If

        ' Check if the item is loaded

        If (Me.state = 0) Then
            Return False
            Exit Function
        End If

        ' Check we are not already playing

        If (Me.state = 2 Or Me.state = 3) Then
            Return False
            Exit Function
        End If

        ' File existance

        If (Not Me.getItem.getHardware And Not General.fileExists(Me.getItem.getFileName)) Then
            Me.state = 2
            Me.stopItem(0)
            'frmMain.getMC.playNextItem()
            Return False
            Exit Function
        End If

        ' Now actually play

        MyBase.play(True)
        Me.state = 2
        Me.time_started = Now
        frmMain.getCurrentPlaylist.updateDisplay()
        Return True

    End Function

    ' Stop the item

    Public Function stopItem(ByVal fade_length As Integer) As Boolean

        Dim mc As MasterControl

        ' Stop any play over

        frmMain.getMC.play_over = False

        ' Reset display

        frmMain.resetSelected()

        ' Check we are playing something

        If (Me.state = 0) Then
            Return False
            Exit Function
        End If

        ' Don't bother if we don't have an item

        If (Me.getItem Is Nothing) Then
            Return False
            Exit Function
        End If

        ' Remove from the playlist

        frmMain.removeFromPL(Me.getItem)

        ' Play next item as reqd

        If (Me.player_number = frmMain.getCurrentPlayer) Then
            mc = frmMain.getMC
            mc.playNextItem()
        End If

        ' Add to the log

        Me.getItem.addToLog(Me.time_started)

        ' Stop the current item

        Me.state = 3
        MyBase.stopPlayback(fade_length, False)

        ' Unload the item and change state

        Me.state = 0
        Me.setItem(Nothing, 0, False)
        Return True

    End Function

    ' Update the item

    Public Sub updateItem()

        ' Don't bother if there is nothing loaded

        If (Me.state = 0 Or Me.getItem Is Nothing) Then
            Me.blankView()
            Exit Sub
        End If

        ' Check for the end of a track

        If (Bass.BASS_ChannelBytes2Seconds(Me.getItem.getPlayoutChannel, Bass.BASS_ChannelGetPosition(Me.getItem.getPlayoutChannel)) > Me.getItem.getTimeEndTrack) Then
            If (Me.getItem.getEndType = 0) Then
                Me.stopItem(0)
            Else
                Me.stopItem(2000)
            End If
        End If

        ' Update the onscreen data

        If (Me.state = 0 Or Me.getItem Is Nothing) Then
            Exit Sub
        End If

        Me.updateOnscreen()

    End Sub

    ' Load an item

    Public Sub loadAnItem(ByRef item As AudioItem)

        ' Do nothing if there is nothing to load

        If (item Is Nothing) Then
            Exit Sub
        End If

        ' Abort if the state is not unloaded

        If (Me.state <> 0 And (Not Me.getItem Is Nothing)) Then
            Exit Sub
        End If

        ' Load the item

        MyBase.loadItem(item)
        Me.state = 1
        Me.getItem.setPlayerTag(Me.player_number)

    End Sub

    ' Move a player

    Public Sub movePlayer(ByVal target As Integer)

        Dim players() As MainPlayer

        players = frmMain.getPlayerArray()
        players(target).acceptItem(Me.getItem)
        Me.setItem(Nothing)
        Me.state = 0
        
    End Sub

    ' Accept an item

    Public Sub acceptItem(ByRef item As AudioItem)

        Me.setItem(item, Me.player_number, Bass.BASS_ChannelIsActive(item.getPlayoutChannel))
        Bass.BASS_ChannelSetDevice(item.getPlayoutChannel, General.program_settings.getMainPlayerSoundCard(Me.player_number))
        Bass.BASS_ChannelSetAttributes(item.getPlayoutChannel, -1, 100, General.program_settings.getMainPlayerPan(Me.player_number))

        If (Bass.BASS_ChannelIsActive(Me.getItem.getPlayoutChannel)) Then
            Me.state = 2
        Else
            Me.state = 1
        End If

        frmMain.getCurrentPlaylist.updateDisplay()

    End Sub

End Class

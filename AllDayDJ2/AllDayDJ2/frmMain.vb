Imports bass = Un4seen.Bass.Bass        ' Audio system

Public Class frmMain

    Private player_array(0 To 3) As MainPlayer
    Private instant_players(0 To 8) As InstantPlayer
    Public player_artist(0 To 3) As System.Windows.Forms.TextBox
    Public player_title(0 To 3) As System.Windows.Forms.TextBox
    Public player_time_left(0 To 3) As System.Windows.Forms.TextBox
    Public player_time_played(0 To 3) As System.Windows.Forms.TextBox
    Public player_play(0 To 3) As System.Windows.Forms.Button
    Public player_stop(0 To 3) As System.Windows.Forms.Button
    Public player_progress(0 To 3) As System.Windows.Forms.ProgressBar
    Public player_border(0 To 3) As System.Windows.Forms.GroupBox
    Private ip_buttons(0 To 8) As System.Windows.Forms.ToolStripButton
    Private playlist_numbers(0 To 3) As Label
    Private playlist_artist_title(0 To 3) As Label
    Private playlist_length(0 To 3) As Label
    Private playlist_played(0 To 3) As Label
    Private playlist_remain(0 To 3) As Label
    Private playlist_progress(0 To 3) As ProgressBar
    Private playlist_table(0 To 3) As TableLayoutPanel
    Private logged_in As Boolean = False
    Private playlists As List(Of Playlist)
    Private main_playlist As Playlist
    Private current_x As Integer = 800
    Private current_y As Integer = 600
    Private log_items As Boolean = True
    Private current_player As Integer = -1
    Private mc As New MasterControl
    Private break_after As Boolean = False
    Public ip_playing As Boolean = False
    Private last_schedule As Date = New Date(2006, 1, 1, 0, 0, 0)
    Private last_event As Date = New Date(2006, 1, 1, 0, 0, 0)
    Private last_do_event As Date = New Date(2006, 1, 1, 0, 0, 0)
    Private event_list As New List(Of ScheduledEvent)
    Private day_of_week As String() = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}
    Private play_to_hour As Boolean = False
    Private previous_second As String = ""
    Private disable_refresh As Boolean = False
    Private selected_item = -1
    Private black_on_red As Boolean = False
    Private last_m3u_file As String = Nothing

    ' Constructor

    Public Sub New()

        Dim looper As Integer
        Dim num_form As System.Globalization.NumberFormatInfo

        ' This call is required by the Windows Form Designer.

        InitializeComponent()

        ' Bring some randomness to the world

        Randomize()

        ' Not everyone is in the UK

        General.internationalise()

        ' Create the control arrays

        Me.creareControlArrays()

        ' Set the menu to disabled

        Me.setMenu(False)

        ' Create the main playlist

        Me.main_playlist = New Playlist(Nothing, "MAIN")

        ' Load the settings

        Me.loadSettings()

        ' Get the list of playlists

        playlists = Me.getTables

        ' Now load the playlists up

        For looper = 0 To (playlists.Count - 1)
            General.loadPlaylist(playlists.Item(looper))
            playlists.Item(looper).randomise()
        Next

        ' Load the sound system

        General.initSound()

        ' Station notepad

        'Me.tbNotepad.Text = General.station_notepad.getContent

        ' Rotation

        General.loadRotation(Me.playlists)

        ' Now and next

        modNowNext.loadNowNext()

        ' Enable update timers

        Me.tmrDoStuff.Enabled = True

    End Sub

    ' Get the list of tables

    Public Function getTables() As List(Of Playlist)

        Dim db As New Database(General.recordCollectionLocation)
        Dim tables As DataTable
        Dim dr As DataRow
        Dim playlists As New List(Of Playlist)

        tables = db.getTableList

        For Each dr In tables.Rows
            Try
                playlists.Add(New Playlist(Nothing, dr("TABLE_NAME")))
            Catch ex As Exception
                ErrorHandler.errorHandler(ex)
            End Try
        Next

        db.disconnect()
        db = Nothing

        Return playlists

    End Function

    ' Menu settings

    Public Sub setMenu(ByVal value As Boolean)

        Me.LogoutToolStripMenuItem.Enabled = value
        Me.DatabaseToolStripMenuItem.Enabled = value
        Me.SettingsToolStripMenuItem.Enabled = value
        Me.LoginToolStripMenuItem.Enabled = Not value
        Me.ChangePasswordToolStripMenuItem.Enabled = value

    End Sub

    ' This subroutine creates the required control arrays

    Private Sub creareControlArrays()

        ' Artist

        player_artist(0) = Me.tbArtist1
        player_artist(1) = Me.tbArtist2
        player_artist(2) = Me.tbArtist3
        player_artist(3) = Me.tbArtist4

        ' Track title

        player_title(0) = Me.tbTitle1
        player_title(1) = Me.tbTitle2
        player_title(2) = Me.tbTitle3
        player_title(3) = Me.tbTitle4

        ' Time left

        player_time_left(0) = Me.tbTimeLeft1
        player_time_left(1) = Me.tbTimeLeft2
        player_time_left(2) = Me.tbTimeLeft3
        player_time_left(3) = Me.tbTimeLeft4

        ' Time Player

        player_time_played(0) = Me.tbPlayed1
        player_time_played(1) = Me.tbPlayed2
        player_time_played(2) = Me.tbPlayed3
        player_time_played(3) = Me.tbPlayed4

        ' Play button

        player_play(0) = Me.btnPlay1
        player_play(1) = Me.btnPlay2
        player_play(2) = Me.btnPlay3
        player_play(3) = Me.btnPlay4

        ' Stop button

        player_stop(0) = Me.btnStop1
        player_stop(1) = Me.btnStop2
        player_stop(2) = Me.btnStop3
        player_stop(3) = Me.btnStop4

        ' Progress

        player_progress(0) = Me.prgPlayer1
        player_progress(1) = Me.prgPlayer2
        player_progress(2) = Me.prgPlayer3
        player_progress(3) = Me.prgPlayer4

        ' Button grouper

        player_border(0) = Me.gbPlayer1
        player_border(1) = Me.gbPlayer2
        player_border(2) = Me.gbPlayer3
        player_border(3) = Me.gbPlayer4

        ' Instant players

        ip_buttons(0) = Me.btnInstantPlayer_1
        ip_buttons(1) = Me.btnInstantPlayer_2
        ip_buttons(2) = Me.btnInstantPlayer_3
        ip_buttons(3) = Me.btnInstantPlayer_4
        ip_buttons(4) = Me.btnInstantPlayer_5
        ip_buttons(5) = Me.btnInstantPlayer_6
        ip_buttons(6) = Me.btnInstantPlayer_7
        ip_buttons(7) = Me.btnInstantPlayer_8
        ip_buttons(8) = Me.btnInstantPlayer_9

        ' Playlist controls

        playlist_numbers(0) = Me.lblPlaylistNumber1
        playlist_numbers(1) = Me.lblPlaylistNumber2
        playlist_numbers(2) = Me.lblPlaylistNumber3
        playlist_numbers(3) = Me.lblPlaylistNumber4

        playlist_artist_title(0) = Me.lblPlaylistArtistTitleInfo1
        playlist_artist_title(1) = Me.lblPlaylistArtistTitleInfo2
        playlist_artist_title(2) = Me.lblPlaylistArtistTitleInfo3
        playlist_artist_title(3) = Me.lblPlaylistArtistTitleInfo4

        playlist_length(0) = Me.lblLength1
        playlist_length(1) = Me.lblLength2
        playlist_length(2) = Me.lblLength3
        playlist_length(3) = Me.lblLength4

        playlist_played(0) = Me.lblPlaylistPlayed1
        playlist_played(1) = Me.lblPlaylistPlayed2
        playlist_played(2) = Me.lblPlaylistPlayed3
        playlist_played(3) = Me.lblPlaylistPlayed4

        playlist_remain(0) = Me.lblRemain1
        playlist_remain(1) = Me.lblRemain2
        playlist_remain(2) = Me.lblRemain3
        playlist_remain(3) = Me.lblRemain4

        playlist_progress(0) = Me.pbPlaylist1
        playlist_progress(1) = Me.pbPlaylist2
        playlist_progress(2) = Me.pbPlaylist3
        playlist_progress(3) = Me.pbPlaylist4

        playlist_table(0) = Me.tablePlaylist1
        playlist_table(1) = Me.tablePlaylist2
        playlist_table(2) = Me.tablePlaylist3
        playlist_table(3) = Me.tablePlaylist4

    End Sub

    ' Uodates the title bar with the date and time

    Private Sub dateTimeUpdate()

        Dim date_time As String

        date_time = Format(Now, "dddd, d MMMM yyyy - HH:mm:ss")
        Me.Text = "AllDay DJ 2 - " & date_time

    End Sub

    ' Exit the program

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Dispose()

    End Sub

    ' Show the settings

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        If (frmSettings.Visible = False) Then
            frmSettings.Show(Me)
            frmSettings.updateDisplay()
        End If
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        frmAdminLogin.Show()
    End Sub

    ' Load the latest settings

    Public Sub loadSettings()

        Dim counter As Integer

        General.loadSettings()

        For counter = 0 To 3
            Me.player_array(counter) = New MainPlayer(General.program_settings.getMainPlayerSoundCard(counter), General.program_settings.getMainPlayerPan(counter), 100, counter)
        Next

        For counter = 0 To 8
            Me.instant_players(counter) = New InstantPlayer(General.program_settings.getIPSoundCard, General.program_settings.getIPPan, 100)
        Next

    End Sub

    ' Change password interface launcher

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmChangePassword.Show()
    End Sub

    ' Log out of the admin interface

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click

        Me.setMenu(False)
        frmSettings.Close()
        frmChangePassword.Close()
        frmAdminLogin.Close()

    End Sub

    ' Show the about screen

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        frmAbout.Show()

    End Sub

    ' Smooth exit

    Private Sub frmMain_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

        Dim counter As Integer
        Dim can_exit As Boolean = False
        Dim item As AudioItem

        ' Start the fade

        For counter = 0 To 8
            Me.instant_players(counter).stopPlayback(2000, False)
        Next

        For counter = 0 To 3
            Me.player_array(counter).stopPlayback(2000, False)
        Next

        On Error Resume Next

        ' Check we can exit

        While Not can_exit

            can_exit = True

            For counter = 0 To 8
                If (Not Me.instant_players(counter).getItem Is Nothing) Then
                    If (bass.BASS_ChannelIsSliding(Me.instant_players(counter).getItem.getPlayoutChannel, Un4seen.Bass.BASSSlide.BASS_SLIDE_VOL)) Then
                        can_exit = False
                    End If
                End If
            Next

            For counter = 0 To 3
                If (Not Me.player_array(counter).getItem Is Nothing) Then
                    If (bass.BASS_ChannelIsSliding(Me.player_array(counter).getItem.getPlayoutChannel, Un4seen.Bass.BASSSlide.BASS_SLIDE_VOL)) Then
                        can_exit = False
                    End If
                End If
            Next

        End While

        ' Close down the sound system

        bass.BASS_Free()
        End

    End Sub

    ' Confirm quit

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If (MsgBox("Are you sure you wish to close AllDay DJ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes) Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    ' Keyboard shortcuts

    Public Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Dim skip_focus As Boolean = False

        Select Case e.KeyCode
            Case Keys.F1
                Me.playIP(Me.ip_buttons(0), Nothing)
            Case Keys.F2
                Me.playIP(Me.ip_buttons(1), Nothing)
            Case Keys.F3
                Me.playIP(Me.ip_buttons(2), Nothing)
            Case Keys.F4
                Me.playIP(Me.ip_buttons(3), Nothing)
            Case Keys.F5
                Me.playIP(Me.ip_buttons(4), Nothing)
            Case Keys.F6
                Me.playIP(Me.ip_buttons(5), Nothing)
            Case Keys.F7
                Me.playIP(Me.ip_buttons(6), Nothing)
            Case Keys.F8
                Me.playIP(Me.ip_buttons(7), Nothing)
            Case Keys.F9
                Me.playIP(Me.ip_buttons(8), Nothing)
            Case Keys.NumPad5
                Me.playIP(Me.ip_buttons(4), Nothing)
            Case Keys.NumPad6
                Me.playIP(Me.ip_buttons(5), Nothing)
            Case Keys.NumPad7
                Me.playIP(Me.ip_buttons(6), Nothing)
            Case Keys.NumPad8
                Me.playIP(Me.ip_buttons(7), Nothing)
            Case Keys.NumPad9
                Me.playIP(Me.ip_buttons(8), Nothing)
            Case Keys.Divide
                Me.btnAutomate_Click(Nothing, Nothing)
            Case Keys.Multiply
                skip_focus = True
                frmSearchScreen.Show()
                frmSearchScreen.BringToFront()
            Case Keys.Subtract
                Me.btnBreakAfter_Click(Nothing, Nothing)
            Case Keys.Add
                Me.getMC.stopPlayback()
            Case Keys.Enter
                Me.pressedSpace()
                e.SuppressKeyPress = True
            Case Keys.Decimal
                Me.btnNext_Click(Nothing, Nothing)
            Case Keys.Space
                Me.pressedSpace()
                e.SuppressKeyPress = True
            Case Else

                ' Numeric (1-4)

                If e.Control Then

                    ' Start players

                    Select Case e.KeyCode
                        Case Keys.NumPad1
                            Me.getPlayerArray(0).playItem()
                        Case Keys.NumPad2
                            Me.getPlayerArray(1).playItem()
                        Case Keys.NumPad3
                            Me.getPlayerArray(2).playItem()
                        Case Keys.NumPad4
                            Me.getPlayerArray(3).playItem()
                    End Select
                ElseIf (e.Alt) Then

                    ' Stop players

                    Select Case e.KeyCode
                        Case Keys.NumPad1
                            Me.getPlayerArray(0).stopItem(2000)
                        Case Keys.NumPad2
                            Me.getPlayerArray(1).stopItem(2000)
                        Case Keys.NumPad3
                            Me.getPlayerArray(2).stopItem(2000)
                        Case Keys.NumPad4
                            Me.getPlayerArray(3).stopItem(2000)
                    End Select

                Else

                    ' Instant players

                    Select Case e.KeyCode
                        Case Keys.NumPad1
                            Me.getIPs(0).play(True)
                        Case Keys.NumPad2
                            Me.getIPs(1).play(True)
                        Case Keys.NumPad3
                            Me.getIPs(2).play(True)
                        Case Keys.NumPad4
                            Me.getIPs(3).play(True)
                    End Select

                End If

        End Select

        ' Move highlight

        'If (Not skip_focus) Then
        'Me.lvPlaylist.Focus()
        'End If

    End Sub

    ' Set screen location

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim boundarys As Rectangle = Screen.AllScreens(General.screen_settings.ScreenMain).Bounds
        Me.SetBounds(boundarys.X, boundarys.Y, boundarys.Width, boundarys.Height)

        ' Show required screens

        If (General.screen_settings.PersistLibrary) Then
            frmSearchScreen.Show()
        End If

        If (General.screen_settings.PersistMixer) Then
            frmMixer.Show()
        End If

    End Sub

    ' Load the instant players

    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLoad.Click

        frmInstantPlayers.Show()
        frmInstantPlayers.loadCurrent(Me.instant_players)

    End Sub

    ' Load the items into the instant players

    Public Sub loadIPs(ByRef audio_items() As AudioItem)

        Dim counter As Integer

        For counter = 0 To 8
            Me.instant_players(counter).unloadItem()
            Me.instant_players(counter).loadItem(audio_items(counter))
        Next

        ' Player buttons

        Me.btnInstantPlayer_1.Text = "1"
        Me.btnInstantPlayer_2.Text = "2"
        Me.btnInstantPlayer_3.Text = "3"
        Me.btnInstantPlayer_4.Text = "4"
        Me.btnInstantPlayer_5.Text = "5"
        Me.btnInstantPlayer_6.Text = "6"
        Me.btnInstantPlayer_7.Text = "7"
        Me.btnInstantPlayer_8.Text = "8"
        Me.btnInstantPlayer_9.Text = "9"

        Me.btnInstantPlayer_1.ToolTipText = "1"
        Me.btnInstantPlayer_2.ToolTipText = "2"
        Me.btnInstantPlayer_3.ToolTipText = "3"
        Me.btnInstantPlayer_4.ToolTipText = "4"
        Me.btnInstantPlayer_5.ToolTipText = "5"
        Me.btnInstantPlayer_6.ToolTipText = "6"
        Me.btnInstantPlayer_7.ToolTipText = "7"
        Me.btnInstantPlayer_8.ToolTipText = "8"
        Me.btnInstantPlayer_9.ToolTipText = "9"

        ' Fill buttons

        On Error Resume Next

        Me.btnInstantPlayer_1.ToolTipText = "1 - " + (audio_items(0).getFileName().Substring(audio_items(0).getFileName().LastIndexOf("\") + 1, (audio_items(0).getFileName().LastIndexOf(".") - audio_items(0).getFileName().LastIndexOf("\") - 1)))
        Me.btnInstantPlayer_2.ToolTipText = "2 - " + (audio_items(1).getFileName().Substring(audio_items(1).getFileName().LastIndexOf("\") + 1, (audio_items(1).getFileName().LastIndexOf(".") - audio_items(1).getFileName().LastIndexOf("\") - 1)))
        Me.btnInstantPlayer_3.ToolTipText = "3 - " + (audio_items(2).getFileName().Substring(audio_items(2).getFileName().LastIndexOf("\") + 1, (audio_items(2).getFileName().LastIndexOf(".") - audio_items(2).getFileName().LastIndexOf("\") - 1)))
        Me.btnInstantPlayer_4.ToolTipText = "4 - " + (audio_items(3).getFileName().Substring(audio_items(3).getFileName().LastIndexOf("\") + 1, (audio_items(3).getFileName().LastIndexOf(".") - audio_items(3).getFileName().LastIndexOf("\") - 1)))
        Me.btnInstantPlayer_5.ToolTipText = "5 - " + (audio_items(4).getFileName().Substring(audio_items(4).getFileName().LastIndexOf("\") + 1, (audio_items(4).getFileName().LastIndexOf(".") - audio_items(4).getFileName().LastIndexOf("\") - 1)))
        Me.btnInstantPlayer_6.ToolTipText = "6 - " + (audio_items(5).getFileName().Substring(audio_items(5).getFileName().LastIndexOf("\") + 1, (audio_items(5).getFileName().LastIndexOf(".") - audio_items(5).getFileName().LastIndexOf("\") - 1)))
        Me.btnInstantPlayer_7.ToolTipText = "7 - " + (audio_items(6).getFileName().Substring(audio_items(6).getFileName().LastIndexOf("\") + 1, (audio_items(6).getFileName().LastIndexOf(".") - audio_items(6).getFileName().LastIndexOf("\") - 1)))
        Me.btnInstantPlayer_8.ToolTipText = "8 - " + (audio_items(7).getFileName().Substring(audio_items(7).getFileName().LastIndexOf("\") + 1, (audio_items(7).getFileName().LastIndexOf(".") - audio_items(7).getFileName().LastIndexOf("\") - 1)))
        Me.btnInstantPlayer_9.ToolTipText = "9 - " + (audio_items(8).getFileName().Substring(audio_items(8).getFileName().LastIndexOf("\") + 1, (audio_items(8).getFileName().LastIndexOf(".") - audio_items(8).getFileName().LastIndexOf("\") - 1)))

    End Sub

    ' Instant player buttons

    Private Sub playIP(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInstantPlayer_1.Click, btnInstantPlayer_2.Click, btnInstantPlayer_3.Click, btnInstantPlayer_4.Click, btnInstantPlayer_5.Click, btnInstantPlayer_6.Click, btnInstantPlayer_7.Click, btnInstantPlayer_8.Click, btnInstantPlayer_9.Click

        Dim counter As Integer

        For counter = 0 To 8
            If (sender.Equals(Me.ip_buttons(counter))) Then
                If (Not Me.instant_players(counter).getItem Is Nothing) Then
                    Me.instant_players(counter).play(True)
                End If
            End If
        Next

    End Sub

    ' Display playlist editing

    Private Sub DatabaseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DatabaseToolStripMenuItem.Click

        frmDatabase.updateDisplay()
        frmDatabase.Show()

    End Sub

    ' Set the playlists

    Public Sub setPlaylists(ByRef playlists As List(Of Playlist))

        Me.playlists = playlists

    End Sub

    ' Allow the playlists to be read

    Public Function getPlaylists() As List(Of Playlist)
        Return Me.playlists
    End Function

    ' Update a single playlist

    Public Sub updatePlaylist(ByVal playlist_number As Integer, ByRef playlist As Playlist)

        Me.playlists.RemoveAt(playlist_number)
        Me.playlists.Insert(playlist_number, playlist)

    End Sub

    ' Set the log items (training mode)

    Private Sub logItems(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrainingToolStripMenuItem.Click, NormalToolStripMenuItem.Click

        Me.log_items = Not Me.log_items
        Me.TrainingToolStripMenuItem.Enabled = Me.log_items
        Me.NormalToolStripMenuItem.Enabled = Not Me.log_items

    End Sub

    ' Add to the main playlist

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As Windows.Forms.MouseEventArgs) Handles btnAdd.MouseDown

        If (e.Button = Windows.Forms.MouseButtons.Left) Then

            frmSearchScreen.Show()
            frmSearchScreen.BringToFront()

        ElseIf (e.Button = Windows.Forms.MouseButtons.Right) Then

            frmHardwareEvent.Show()
            frmHardwareEvent.BringToFront()

        End If

    End Sub

    ' Assign the players as reqd

    Private Sub assignPlayers()

        Dim counter As Integer
        Dim change_made As Boolean = False

        On Error Resume Next

        ' Current player

        If ((Me.main_playlist.getPlaylistLength > 0) And Me.getMC.getState = 0) Then
            Me.player_array(Me.current_player).setItem(Me.main_playlist.getItem(0))
        End If

        ' Load the items into the players

        Select Case Me.current_player
            Case -1

                ' Move any items

                If ((Not Me.player_array(3).getItem Is Nothing) And (Me.player_array(2).getItem Is Nothing)) Then
                    Me.player_array(3).movePlayer(2)
                    change_made = True
                End If

                If ((Not Me.player_array(2).getItem Is Nothing) And (Me.player_array(1).getItem Is Nothing)) Then
                    Me.player_array(2).movePlayer(1)
                    change_made = True
                End If

                If ((Not Me.player_array(1).getItem Is Nothing) And (Me.player_array(0).getItem Is Nothing)) Then
                    Me.player_array(1).movePlayer(0)
                    change_made = True
                End If

                ' Now load into players

                If Me.player_array(0).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(0) Is Nothing) Then
                        Me.player_array(0).loadAnItem(Me.main_playlist.getItem(0))
                    End If
                Else
                    If (Not Me.main_playlist.getItem(0).Equals(Me.player_array(0).getItem)) Then
                        Me.player_array(0).acceptItem(Me.main_playlist.getItem(0))
                    End If
                End If

                If Me.player_array(1).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(1) Is Nothing) Then
                        ' If (Me.main_playlist.getItem(1).getPlayerTag = -1) Then
                        Me.player_array(1).loadAnItem(Me.main_playlist.getItem(1))
                        'End If
                    End If
                Else
                    If (Not Me.main_playlist.getItem(1).Equals(Me.player_array(1).getItem)) Then
                        Me.player_array(1).acceptItem(Me.main_playlist.getItem(1))
                    End If
                End If

                If Me.player_array(2).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(2) Is Nothing) Then
                        'If (Me.main_playlist.getItem(2).getPlayerTag = -1) Then
                        Me.player_array(2).loadAnItem(Me.main_playlist.getItem(2))
                        'End If
                    End If
                Else
                    If (Not Me.main_playlist.getItem(2).Equals(Me.player_array(2).getItem)) Then
                        Me.player_array(2).acceptItem(Me.main_playlist.getItem(2))
                    End If
                End If

                If Me.player_array(3).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(3) Is Nothing) Then
                        'If (Me.main_playlist.getItem(3).getPlayerTag = -1) Then
                        Me.player_array(3).loadAnItem(Me.main_playlist.getItem(3))
                        'End If
                    End If
                Else
                    If (Not Me.main_playlist.getItem(3).Equals(Me.player_array(3).getItem)) Then
                        Me.player_array(3).acceptItem(Me.main_playlist.getItem(3))
                    End If
                End If

            Case 0

                ' Move any items

                If ((Not Me.player_array(3).getItem Is Nothing) And (Me.player_array(2).getItem Is Nothing)) Then
                    Me.player_array(3).movePlayer(2)
                    change_made = True
                End If

                If ((Not Me.player_array(2).getItem Is Nothing) And (Me.player_array(1).getItem Is Nothing)) Then
                    Me.player_array(2).movePlayer(1)
                    change_made = True
                End If

                ' Now load into players

                If Me.player_array(1).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(1) Is Nothing) Then
                        ' If (Me.main_playlist.getItem(1).getPlayerTag = -1) Then
                        Me.player_array(1).loadAnItem(Me.main_playlist.getItem(1))
                        'End If
                    End If
                Else
                    If (Not Me.main_playlist.getItem(1).Equals(Me.player_array(1).getItem)) Then
                        Me.player_array(1).acceptItem(Me.main_playlist.getItem(1))
                    End If
                End If

                If Me.player_array(2).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(2) Is Nothing) Then
                        'If (Me.main_playlist.getItem(2).getPlayerTag = -1) Then
                        Me.player_array(2).loadAnItem(Me.main_playlist.getItem(2))
                        'End If
                    End If
                Else
                    If (Not Me.main_playlist.getItem(2).Equals(Me.player_array(2).getItem)) Then
                        Me.player_array(2).acceptItem(Me.main_playlist.getItem(2))
                    End If
                End If

                If Me.player_array(3).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(3) Is Nothing) Then
                        'If (Me.main_playlist.getItem(3).getPlayerTag = -1) Then
                        Me.player_array(3).loadAnItem(Me.main_playlist.getItem(3))
                        'End If
                    End If
                Else
                    If (Not Me.main_playlist.getItem(3).Equals(Me.player_array(3).getItem)) Then
                        Me.player_array(3).acceptItem(Me.main_playlist.getItem(3))
                    End If
                End If

            Case 1

                ' Move any items

                If ((Not Me.player_array(0).getItem Is Nothing) And (Me.player_array(3).getItem Is Nothing)) Then
                    Me.player_array(0).movePlayer(3)
                    change_made = True
                End If

                If ((Not Me.player_array(3).getItem Is Nothing) And (Me.player_array(2).getItem Is Nothing)) Then
                    Me.player_array(3).movePlayer(2)
                    change_made = True
                End If

                ' Now load into players

                If Me.player_array(2).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(1) Is Nothing) Then
                        ' If (Me.main_playlist.getItem(1).getPlayerTag = -1) Then
                        Me.player_array(2).loadAnItem(Me.main_playlist.getItem(1))
                        'End If
                    End If
                Else
                    If (Not Me.main_playlist.getItem(1).Equals(Me.player_array(2).getItem)) Then
                        Me.player_array(2).acceptItem(Me.main_playlist.getItem(1))
                    End If
                End If

                If Me.player_array(3).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(2) Is Nothing) Then
                        ' If (Me.main_playlist.getItem(2).getPlayerTag = -1) Then
                        Me.player_array(3).loadAnItem(Me.main_playlist.getItem(2))
                        'End If
                    End If
                Else
                    If (Not Me.main_playlist.getItem(2).Equals(Me.player_array(3).getItem)) Then
                        Me.player_array(3).acceptItem(Me.main_playlist.getItem(2))
                    End If
                End If

                If Me.player_array(0).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(3) Is Nothing) Then
                        'If (Me.main_playlist.getItem(3).getPlayerTag = -1) Then
                        Me.player_array(0).loadAnItem(Me.main_playlist.getItem(3))
                        'End If
                    End If
                Else
                    If (Not Me.main_playlist.getItem(3).Equals(Me.player_array(0).getItem)) Then
                        Me.player_array(0).acceptItem(Me.main_playlist.getItem(3))
                    End If
                End If

            Case 2

                ' Move any items

                If ((Not Me.player_array(1).getItem Is Nothing) And (Me.player_array(0).getItem Is Nothing)) Then
                    Me.player_array(1).movePlayer(0)
                    change_made = True
                End If

                If ((Not Me.player_array(0).getItem Is Nothing) And (Me.player_array(3).getItem Is Nothing)) Then
                    Me.player_array(0).movePlayer(3)
                    change_made = True
                End If

                ' Now load into players


                If Me.player_array(3).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(1) Is Nothing) Then
                        'If (Me.main_playlist.getItem(1).getPlayerTag = -1) Then
                        Me.player_array(3).loadAnItem(Me.main_playlist.getItem(1))
                        'End If
                    End If
                Else
                    If (Not Me.main_playlist.getItem(1).Equals(Me.player_array(3).getItem)) Then
                        Me.player_array(3).acceptItem(Me.main_playlist.getItem(1))
                    End If
                End If


                If Me.player_array(0).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(2) Is Nothing) Then
                        'If (Me.main_playlist.getItem(2).getPlayerTag = -1) Then
                        Me.player_array(0).loadAnItem(Me.main_playlist.getItem(2))
                        'End If
                    End If
                Else
                    If (Not Me.main_playlist.getItem(2).Equals(Me.player_array(0).getItem)) Then
                        Me.player_array(0).acceptItem(Me.main_playlist.getItem(2))
                    End If
                End If

                If Me.player_array(1).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(3) Is Nothing) Then
                        'If (Me.main_playlist.getItem(3).getPlayerTag = -1) Then
                        Me.player_array(1).loadAnItem(Me.main_playlist.getItem(3))
                        'End If
                    End If
                Else
                    If (Not Me.main_playlist.getItem(3).Equals(Me.player_array(1).getItem)) Then
                        Me.player_array(1).acceptItem(Me.main_playlist.getItem(3))
                    End If
                End If


            Case 3

                ' Move any items

                If ((Not Me.player_array(2).getItem Is Nothing) And (Me.player_array(1).getItem Is Nothing)) Then
                    Me.player_array(2).movePlayer(1)
                    change_made = True
                End If

                If ((Not Me.player_array(1).getItem Is Nothing) And (Me.player_array(0).getItem Is Nothing)) Then
                    Me.player_array(1).movePlayer(0)
                    change_made = True
                End If

                ' Now load into players

                If Me.player_array(0).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(1) Is Nothing) Then
                        ' If (Me.main_playlist.getItem(1).getPlayerTag = -1) Then
                        Me.player_array(0).loadAnItem(Me.main_playlist.getItem(1))
                        'End If
                    End If
                Else
                    If (Not Me.main_playlist.getItem(1).Equals(Me.player_array(0).getItem)) Then
                        Me.player_array(0).acceptItem(Me.main_playlist.getItem(1))
                    End If
                End If

                If Me.player_array(1).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(2) Is Nothing) Then
                        'If (Me.main_playlist.getItem(2).getPlayerTag = -1) Then
                        Me.player_array(1).loadAnItem(Me.main_playlist.getItem(2))
                        'End If
                    End If
                Else
                    If (Not Me.main_playlist.getItem(2).Equals(Me.player_array(1).getItem)) Then
                        Me.player_array(1).acceptItem(Me.main_playlist.getItem(2))
                    End If
                End If

                If Me.player_array(2).getItem Is Nothing Then
                    If (Not Me.main_playlist.getItem(3) Is Nothing) Then
                        ' If (Me.main_playlist.getItem(3).getPlayerTag = -1) Then
                        Me.player_array(2).loadAnItem(Me.main_playlist.getItem(3))
                        'End If
                    End If
                Else
                    If (Not Me.main_playlist.getItem(3).Equals(Me.player_array(2).getItem)) Then
                        Me.player_array(2).acceptItem(Me.main_playlist.getItem(3))
                    End If
                End If

        End Select

        For counter = 0 To 3
            Me.player_array(counter).updateItem()
        Next

        ' Update the display

        If (change_made And Not Me.disable_refresh) Then
            Me.main_playlist.updateDisplay()
        End If

    End Sub

    ' Update all stuff

    Private Sub tmrDoStuff_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrDoStuff.Tick

        ' For conversion only

        'Me.tmrDoStuff.Enabled = False
        'Dim ctpg As New ConvertToPostgre
        'ctpg.doConvert()

        On Error Resume Next

        Me.dateTimeUpdate()                 ' Date and time
        Me.assignPlayers()                  ' Check the player assignments
        Me.mc.update()                      ' Update onscreen for player
        Me.timeUpdater()                    ' Onscreen playlist and top of hour timer
        Me.updateEvents()                   ' Update the events (will only be active hourly)

        If Not General.program_settings.getScheduleM3U Then

            Me.doEvents()                       ' Make any events happen
            Me.doSchedule()                     ' Make scheduling happen (again, hourly)

        Else

            Me.scheduleM3U()                    ' Schedule M3U playlists

        End If

        Me.playToHour()                     ' Check and act upon a play to hour event
        Me.doNowNext()                      ' Updates the now and next files
        'Me.main_playlist.updateDisplay()    ' Updates the onscreen playlist
        Me.updatePlaylistDisplay()          ' Updates the playlist display

    End Sub

    ' Player play button click

    Private Sub playMainPlayer(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlay1.Click, btnPlay2.Click, btnPlay3.Click, btnPlay4.Click

        Dim counter As Integer
        Dim player_number As Integer

        ' Get the player number

        For counter = 0 To 3
            If (Me.player_play(counter).Equals(sender)) Then
                player_number = counter
            End If
        Next

        ' Play the item

        If (Not Me.player_array(player_number).getItem Is Nothing) Then
            Me.player_array(player_number).playItem()
        End If

    End Sub

    Private Sub stopMainPlayer(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStop1.Click, btnStop2.Click, btnStop3.Click, btnStop4.Click

        Dim counter As Integer
        Dim player_number As Integer

        ' Get the player number

        For counter = 0 To 3
            If (Me.player_stop(counter).Equals(sender)) Then
                player_number = counter
            End If
        Next

        ' Stop the item

        If (Not Me.player_array(player_number).getItem Is Nothing) Then
            Me.player_array(player_number).stopItem(2000)
        End If

    End Sub

    ' Add to the main playlist

    Public Sub addToMainPL(ByVal item As AudioItem, Optional ByVal hardware As Boolean = False, Optional ByVal automated_item As Boolean = False)

        ' Add as is for hardware
        ' Create unique object for files

        If (hardware) Then
            Me.main_playlist.addToPlaylist(item)
        Else
            Dim a_item As AudioItem
            a_item = New AudioItem(item.getTrackId.ToString, item.getDbTable, True)
            a_item.setAutomatedTrack(automated_item)
            Me.main_playlist.addToPlaylist(a_item)
        End If

        ' Refresh

        Me.main_playlist.updateDisplay()

    End Sub

    ' Remove from the main playlist

    Public Sub removeFromPL(ByVal item_number As Integer)
        Me.main_playlist.removeByIndex(item_number)
        Me.main_playlist.updateDisplay()
    End Sub

    Public Sub removeFromPL(ByRef item As AudioItem)
        Me.main_playlist.removeByItem(item)
        Me.main_playlist.updateDisplay()
    End Sub

    ' Get the player array

    Public Function getPlayerArray() As MainPlayer()
        Return Me.player_array
    End Function

    ' Get and set the current player

    Public Sub setCurrentPlayer(ByVal player As Integer)
        Me.current_player = player
    End Sub

    Public Function getCurrentPlayer() As Integer
        Return Me.current_player
    End Function

    ' Get the current playlist

    Public Function getCurrentPlaylist() As Playlist
        Return Me.main_playlist
    End Function

    ' Master play

    Private Sub btnPlay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlay.Click

        Me.mc.play(Me)

    End Sub

    ' Get the mastercontrol

    Public Function getMC() As MasterControl
        Return Me.mc
    End Function

    ' Break after

    Private Sub btnBreakAfter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBreakAfter.Click

        'Me.break_after = Not Me.break_after

        'If (Me.break_after) Then
        'Me.btnBreakAfter.BackColor = Color.Red
        'Else
        'Me.btnBreakAfter.BackColor = Me.btnNext.BackColor
        'End If

        Dim highlighted_item As Integer
        Dim counter As Integer

        ' Get item

        highlighted_item = Me.selected_item
        If (highlighted_item <= 0) Then
            highlighted_item = 0
        End If

        ' Direct insert

        Me.main_playlist.insertItem(New BreakItem, highlighted_item + 1)
        Me.main_playlist.updateDisplay()
        Exit Sub

        ' Insert

        Me.main_playlist.addToPlaylist(New BreakItem)
        Me.main_playlist.updateDisplay()
        'Me.lvPlaylist.SelectedIndex = Me.main_playlist.getPlaylistLength - 1
        'While Not Me.lvPlaylist.SelectedIndex = highlighted_item + 1
        'Me.btnUp_Click(Nothing, Nothing)
        'End While

    End Sub

    Public Function getBreakAfter() As Boolean
        Return Me.break_after
    End Function

    Public Sub toggleBreakAfter()

        Me.btnBreakAfter_Click(Nothing, Nothing)

    End Sub

    ' Stop the master control

    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStop.Click

        Me.mc.stopPlayback()

    End Sub

    ' Next item

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click

        If (Me.main_playlist.getPlaylistLength > 1 And Me.mc.getState <> 0) Then
            Me.player_array(Me.current_player).stopItem(2000)
        End If

    End Sub

    ' Get the instant players

    Public Function getIPs() As InstantPlayer()
        Return Me.instant_players
    End Function

    ' Removes something from the playlist

    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        Try

            Dim item_number As Integer
            Dim item As AudioItem
            Dim counter As Integer

            ' Get the item number

            item_number = Me.selected_item
            If (item_number < 0) Then
                MsgBox("Could not remove item." & Chr(13) & Chr(10) & "No item selected!", MsgBoxStyle.Information, "Error")
                Exit Sub
            End If

            ' Now check if the item is playing

            item = Me.main_playlist.getItem(item_number)
            If (Not item Is Nothing) Then

                ' Cycle through all of the players

                For counter = 0 To 3
                    If (Not Me.getPlayerArray(counter).getItem Is Nothing) Then
                        If (Me.getPlayerArray(counter).getItem.Equals(item)) Then ' (Not counter = Me.current_player Or Me.mc.getState = 0)
                            'MsgBox("The item you selected has been loaded into one of the main players (and is ready to play or currently playing)." & Chr(13) & Chr(10) & "Unfortunately this means that you cannot remove the item.", MsgBoxStyle.Information, "Sorry!")

                            Me.removeFromPL(Me.getPlayerArray(counter).getItem)
                            If (Not Me.getPlayerArray(counter).stopItem(2000)) Then
                                Me.getPlayerArray(counter).setItem(Nothing)
                            End If

                            ' Automation check

                            If (Me.mc.getState = 3) Then
                                While Me.main_playlist.getPlaylistLength < 5
                                    Me.mc.automatedAddToPl()
                                End While
                            End If

                            Me.main_playlist.updateDisplay()

                            ' Set the current player

                            If (counter = Me.current_player) Then
                                If (Me.main_playlist.getPlaylistLength = 0) Then
                                    Me.current_player = -1
                                    Me.mc.setCurrentPlayer(0)
                                Else
                                    Select Case Me.current_player
                                        Case 0
                                            Me.current_player = 1
                                            Me.mc.setCurrentPlayer(1)
                                        Case 1
                                            Me.current_player = 2
                                            Me.mc.setCurrentPlayer(2)
                                        Case 2
                                            Me.current_player = 3
                                            Me.mc.setCurrentPlayer(3)
                                        Case 3
                                            Me.current_player = 0
                                            Me.mc.setCurrentPlayer(0)
                                    End Select
                                End If
                            End If

                            Exit Sub

                        End If
                    End If
                Next

                ' Now remove from the playlist

                Me.removeFromPL(item)

            End If

        Catch ex As Exception

            ' ERROR - Do nowt

        End Try

        Me.main_playlist.updateDisplay()

    End Sub

    Private Sub tbNotepad_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        ' Update the notepad and save

        'General.station_notepad.setContent(Me.tbNotepad.Text)
        'General.station_notepad.writeContent()

    End Sub

    ' Clears all items (bar the active one)

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click

        Dim counter As Integer

        ' Stop the main players that are not the main, active one

        For counter = 0 To 3
            If (Not counter = Me.current_player) Then
                If (Not Me.getPlayerArray(counter).stopItem(2000)) Then
                    Me.getPlayerArray(counter).setItem(Nothing)
                End If
            End If
        Next

        ' Remove all items (bar the first one (if active) from the playlist

        If (Me.current_player = -1) Then
            Me.main_playlist.clear()
        Else
            Me.main_playlist.clearBarOne()
        End If

        ' Update the display

        Me.main_playlist.updateDisplay()

        ' Automation check

        If (Me.btnAutomate.BackColor = Color.LightGreen) Then
            While Me.main_playlist.getPlaylistLength < 5
                Me.mc.automatedAddToPl()
            End While
        End If

    End Sub

    ' Update the tooltip

    Private Sub lvPlaylist_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim item_number As Integer
        Dim message As String
        Dim item As AudioItem

        ' Use the selected item

        'item_number = Me.lvPlaylist.selectedindex
        If (item_number < 0) Then
            message = ""
        Else
            item = Me.main_playlist.getItem(item_number)
            message = "Artist: " & item.getArtist & Chr(13) & Chr(10)
            message = message & "Title: " & item.getTrackName & Chr(13) & Chr(10)
            message = message & "Intro: " & General.timeToString(item.getTimeStartIntro - item.getTimeStartTrack) & Chr(13) & Chr(10)
            message = message & "Length: " & General.timeToString(item.getTimeEndTrack - item.getTimeStartTrack) & Chr(13) & Chr(10)
            message = message & "Info: " & item.getInfo
        End If

        Me.ttPlaylist.SetToolTip(Nothing, message)

    End Sub

    ' Load the logs screen

    Private Sub LogsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LogsToolStripMenuItem.Click

        frmLogs.Show()

    End Sub

    ' Get the mode

    Public Function getMode() As Boolean
        Return Me.log_items
    End Function

    ' Move items up and down the playlist

    Private Sub btnUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp.Click

        On Error Resume Next

        Dim selected_item As Integer
        Dim counter As Integer

        ' Get the item number

        selected_item = Me.selected_item
        If (selected_item < 1) Then
            Exit Sub
        End If

        ' If it is item one we wish to switch, make sure we can

        If (selected_item = 1) Then
            If (Me.mc.getState = 1 Or Me.mc.getState = 3) Then
                Exit Sub
            End If
        End If

        ' Swap the items on the actual playlist

        Me.main_playlist.moveUpOne(selected_item)

        ' Assignment

        If (Me.mc.getState = 0 Or selected_item = 1) Then

            For counter = 0 To 3
                Me.player_array(counter).setItem(Nothing)
            Next

            'Me.player_array(Me.current_player).loadAnItem(Me.main_playlist.getItem(0))

        End If


        Me.assignPlayers()
        Me.main_playlist.updateDisplay()

        ' Select the item

        Me.selected_item -= 1
        'Me.lvPlaylist.SelectedIndex = selected_item - 1
        'Me.lvPlaylist.Focus()

    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click

        Dim selected_item As Integer
        Dim counter As Integer

        ' Get the item number

        selected_item = Me.selected_item
        If (selected_item < 0) Then
            Exit Sub
        End If

        ' Don't bother if the last item on the playlist

        If (selected_item >= (Me.main_playlist.getPlaylistLength - 1)) Then
            Exit Sub
        End If

        ' If it is the first item check the state

        If (selected_item = 0) Then
            If (Me.mc.getState = 1 Or Me.mc.getState = 3) Then
                Exit Sub
            End If
        End If

        ' Swap the items

        Me.main_playlist.moveDownOne(selected_item)
        Me.main_playlist.updateDisplay()

        ' Reset players if first item

        If (selected_item = 0) Then
            For counter = 0 To 3
                Me.player_array(counter).setItem(Nothing)
            Next
        End If

        Me.assignPlayers()

        ' Select the item

        Me.selected_item += 1
        'Me.lvPlaylist.SelectedIndex = selected_item + 1
        'Me.lvPlaylist.Focus()

    End Sub

    ' Force a player refresh

    Public Sub forceRefresh(ByVal player_number As Integer, ByVal item_number As Integer)

        Me.player_array(player_number).acceptItem(Me.main_playlist.getItem(item_number))

    End Sub

    ' Automatic rotation

    Private Sub btnAutomate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAutomate.Click

        Me.mc.automate()

    End Sub

    ' Time label updater

    Private Sub timeUpdater()

        Dim top_of_the_hour As New Date(Now.Year, Now.Month, Now.Day, Now.Hour, 0, 0)
        Dim label As String = ""
        Dim counter As Integer
        Dim total_time As Double = 0
        Dim item_time As Double
        Dim played_time As Integer

        On Error Resume Next

        ' Calculate playlist time

        For counter = 0 To (Me.main_playlist.getPlaylistLength - 1)

            ' Get the current item time

            item_time = Me.main_playlist.getItem(counter).getTimeEndTrack - Me.main_playlist.getItem(counter).getTimeStartTrack

            ' If it is the current item then adjust for played time

            If (counter = 0 And Me.current_player > -1) Then

                played_time = bass.BASS_ChannelBytes2Seconds(Me.player_array(Me.current_player).getItem.getPlayoutChannel, bass.BASS_ChannelGetPosition(Me.player_array(Me.current_player).getItem.getPlayoutChannel))
                If (played_time > 0) Then
                    played_time = played_time - Me.player_array(Me.current_player).getItem.getTimeStartTrack
                End If

                item_time -= played_time

            End If

            ' Adjust for play over items

            If (Me.main_playlist.getItem(counter).getPlayOver) Then

                ' Remove the time for the extro

                If (counter > 0) Then
                    item_time -= Me.main_playlist.getItem(counter - 1).getTimeEndTrack - Me.main_playlist.getItem(counter - 1).getTimeExtroStart
                End If

                ' Adjust for the intro of the next one

                If (counter < (Me.main_playlist.getPlaylistLength - 1)) Then
                    If (Me.main_playlist.getItem(counter + 1).getTimeStartTrack = Me.main_playlist.getItem(counter + 1).getTimeStartIntro) Then
                        item_time -= Me.main_playlist.getItem(counter + 1).getTimeEndIntro - Me.main_playlist.getItem(counter + 1).getTimeStartIntro
                    End If
                End If

                ' Zero the length if negative

                If (item_time < 0) Then
                    item_time = 0
                End If

            End If

            ' Add the time to the counter

            total_time += item_time

        Next

        ' Set the label for the playlist time

        Me.lblPlaylistRemain.Text = General.timeToString(total_time)

        ' Set the top of the hour

        top_of_the_hour = top_of_the_hour.AddHours(1)
        Me.lblToHour.Text = General.timeToString(DateDiff(DateInterval.Second, Now, top_of_the_hour))

        ' Fit items to the hour

        Me.fitInHour(total_time, DateDiff(DateInterval.Second, Now, top_of_the_hour))

        ' Now display time

        Me.lblTimeTitle.Text = Format(Now, "ddd, dd MMM yyyy")
        Me.lblTime.Text = Format(Now, "HH:mm:ss")

    End Sub

    Private Sub fitInHour(ByVal time_on_playlist As Double, ByVal time_to_hour As Double)

        Dim counter As Integer = 0
        Dim items_in_this_hour As Integer = 0
        Dim adjustable_in_this_hour As Integer = 0
        Dim time_counter As Double = time_to_hour
        Dim item_time As Double
        Dim adjustment As Double

        ' Work out if we need to shrink items

        If (time_on_playlist < time_to_hour) Then
            Exit Sub
        End If

        ' Don't bother if the user told us not to

        If (Not General.program_settings.getFitInHour) Then
            Exit Sub
        End If

        ' Or if there are no items!

        If (Me.main_playlist.getPlaylistLength = 0) Then
            Exit Sub
        End If

        ' Figure out which item is the first to run over the hour

        While Int(time_counter) > 0

            ' Calculate the item time

            item_time = Me.main_playlist.getItem(counter).getTimeEndTrack - Me.main_playlist.getItem(counter).getTimeStartTrack

            ' Adjust if first item

            If (counter = 0) Then
                item_time -= (bass.BASS_ChannelBytes2Seconds(Me.main_playlist.getItem(0).getPlayoutChannel, bass.BASS_ChannelGetPosition(Me.main_playlist.getItem(0).getPlayoutChannel)) - Me.main_playlist.getItem(0).getTimeStartTrack)
            End If

            ' And for play over

            If (Me.main_playlist.getItem(counter).getPlayOver) Then

                ' Remove the time for the extro

                If (counter > 0) Then
                    item_time -= Me.main_playlist.getItem(counter - 1).getTimeEndTrack - Me.main_playlist.getItem(counter - 1).getTimeExtroStart
                End If

                ' Adjust for the intro of the next one

                If (counter < (Me.main_playlist.getPlaylistLength - 1)) Then
                    If (Me.main_playlist.getItem(counter + 1).getTimeStartTrack = Me.main_playlist.getItem(counter + 1).getTimeStartIntro) Then
                        item_time -= Me.main_playlist.getItem(counter + 1).getTimeEndIntro - Me.main_playlist.getItem(counter + 1).getTimeStartIntro
                    End If
                End If

                ' Zero the length if negative

                If (item_time < 0) Then
                    item_time = 0
                End If

            End If

            ' Subtract the item time

            time_counter -= item_time

            ' Is the item less than 30 seconds long

            If ((Me.main_playlist.getItem(counter).getTimeEndTrack - Me.main_playlist.getItem(counter).getTimeStartTrack) > 30) Then
                adjustable_in_this_hour += 1
            End If

            ' Total item count

            items_in_this_hour += 1

            ' Up the counter

            counter += 1

        End While

        ' Now we can work out the adjustment value

        adjustment = (time_counter * (-1.0)) / adjustable_in_this_hour

        ' And apply the adjustment

        For counter = 0 To (items_in_this_hour - 1)


            ' Check for longer than 30 seconds

            If ((Me.main_playlist.getItem(counter).getTimeEndTrack - Me.main_playlist.getItem(counter).getTimeStartTrack) > 30) Then
                Me.main_playlist.getItem(counter).setTimeEndTrack(Me.main_playlist.getItem(counter).getTimeEndTrack - adjustment)
            End If

        Next

    End Sub

    ' Get the events

    Private Sub updateEvents()

        Dim temp_list As List(Of ScheduledEvent)
        Dim event_list As New List(Of ScheduledEvent)
        Dim counter As Integer

        ' Check if we have already loaded

        If ((DateDiff(DateInterval.Second, Me.last_event, Now) > 3600) Or (Now.Minute = 0 And Now.Second = 0 And DateDiff(DateInterval.Second, Me.last_event, Now) > 1)) Then

            ' Set last event time

            Me.last_event = Now

            ' Load all events from the database

            temp_list = General.getListOfEvents

            ' Filter through the events list

            For counter = 0 To (temp_list.Count - 1)
                If (temp_list.Item(counter).regularity = "Hour" Or (temp_list.Item(counter).regularity = "Day" And temp_list.Item(counter).time.Hour = Now.Hour) Or (temp_list.Item(counter).regularity = "Week" And day_of_week(temp_list.Item(counter).time.DayOfWeek) = day_of_week(Now.DayOfWeek)) Or (temp_list.Item(counter).regularity = "Month" And temp_list.Item(counter).time.Day = Now.Day And temp_list.Item(counter).time.Hour = Now.Hour) Or DateDiff(DateInterval.Hour, New Date(temp_list.Item(counter).time.Year, temp_list.Item(counter).time.Month, temp_list.Item(counter).time.Day, temp_list.Item(counter).time.Hour, 0, 0), Now) = 0) Then
                    event_list.Add(temp_list.Item(counter))
                End If
            Next

            ' And update

            Me.event_list = event_list

        End If

    End Sub

    ' Do the events

    Private Sub doEvents()

        Dim counter As Integer
        Dim sub_counter As Integer
        Dim sub_sub_counter As Integer
        Dim removal_list As New List(Of Integer)

        ' Don't do more than once per second

        If (DateDiff(DateInterval.Second, Me.last_do_event, Now) < 1) Then
            Exit Sub
        End If

        ' Check the events

        If (Me.event_list.Count > 0) Then
            For counter = 0 To (Me.event_list.Count - 1)

                ' Do the time check

                If (DateDiff(DateInterval.Second, Now, New Date(Now.Year, Now.Month, Now.Day, Now.Hour, event_list.Item(counter).time.Minute, event_list.Item(counter).time.Second)) = 0) Then

                    Me.last_do_event = Now

                    ' Add to the playlist

                    'Me.main_playlist.appendPlaylist(event_list.Item(counter).playlist)

                    Try
                        Me.main_playlist.insertPlaylist(event_list.Item(counter).playlist, 1)
                    Catch ex As Exception
                        Me.main_playlist.insertPlaylist(event_list.Item(counter).playlist, 0)
                    End Try

                    Me.main_playlist.updateDisplay()

                    ' Move the items up the playlist
                    ' For every item in the list

                    'For sub_counter = 0 To (Me.event_list.Item(counter).playlist.getPlaylistLength - 1)

                    'Me.disable_refresh = True

                    ' Select the item

                    'Me.lvPlaylist.SelectedIndex = (Me.main_playlist.getPlaylistLength - Me.event_list.Item(counter).playlist.getPlaylistLength) + sub_counter

                    ' Move it up

                    'For sub_sub_counter = 0 To (Me.main_playlist.getPlaylistLength - Me.event_list.Item(counter).playlist.getPlaylistLength - 2)
                    'Me.btnUp_Click(Nothing, Nothing)
                    'Next

                    'Me.disable_refresh = False

                    'Next

                    ' Play now if appropriate

                    If (event_list.Item(counter).force) Then
                        Me.assignPlayers()
                        If (Me.mc.getState = 0) Then
                            Me.btnPlay_Click(Nothing, Nothing)
                        Else
                            Me.btnNext_Click(Nothing, Nothing)
                        End If
                    End If

                    ' Add to the removal list

                    removal_list.Add(counter)

                End If

            Next
        End If

        ' Remove any events performed

        If (removal_list.Count > 0) Then
            For counter = (removal_list.Count - 1) To 0 Step -1
                Me.event_list.RemoveAt(removal_list.Item(counter))
            Next
        End If

    End Sub

    ' Do the schedule

    Private Sub doSchedule()

        Dim db As Database
        Dim rs As OleDb.OleDbDataReader
        Dim pl_string As String
        Dim pl_items As String()
        Dim item_parts As String()
        Dim hardware_split As String()
        Dim playlist As New Playlist(Nothing, "Temp")
        Dim counter As Integer
        Dim temp_item As AudioItem

        ' Less than a second ago, don't bother

        If (DateDiff(DateInterval.Second, Me.last_schedule, Now) < 1) Then
            Exit Sub
        End If

        ' Only bother if top of the hour

        If (Now.Minute = 0 And Now.Second = 0) Then

            Me.last_schedule = Now

            ' Make the database connection

            db = New Database(General.program_settings.getScheduleLocation)

            ' Get the recordset (datareader)

            If (Now.Hour < 10) Then
                rs = db.executeRS("SELECT [0" & Now.Hour & "00] FROM [schedule] WHERE [date] = """ & Format(Now, "dd/MM/yyyy") & """")
            Else
                rs = db.executeRS("SELECT [" & Now.Hour & "00] FROM [schedule] WHERE [date] = """ & Format(Now, "dd/MM/yyyy") & """")
            End If

            ' Read the data

            If (Not rs Is Nothing) Then

                ' Obtain the string

                While rs.Read
                    pl_string = rs(0)
                End While

                ' Build the playlist

                If (Not pl_string Is Nothing) Then
                    If (pl_string.Length > 0) Then

                        ' Remove automated programming

                        removeAutomatedProgramming()

                        ' Split into items on the playlist

                        pl_items = pl_string.Split(";")

                        ' And put the items onto the playlist
                        ' Special treatment for hardware items

                        For counter = 0 To (pl_items.Length - 1)
                            item_parts = pl_items(counter).Split("-")

                            temp_item = Nothing
                            On Error Resume Next

                            If (item_parts(1).Equals("HARDWARE")) Then
                                hardware_split = item_parts(1).Split(":")
                                temp_item = New AudioItem(Integer.Parse(hardware_split(0)), Integer.Parse(hardware_split(1)), Integer.Parse(hardware_split(2)))
                                temp_item.setAutomatedTrack(True)
                                playlist.addToPlaylist(temp_item)
                            Else
                                temp_item = New AudioItem(item_parts(0), item_parts(1), False)
                                temp_item.setAutomatedTrack(True)
                                playlist.addToPlaylist(temp_item)
                            End If

                        Next

                    End If

                End If

                ' Close the rs

                rs.Close()
                rs = Nothing

            End If

            ' Close the connection

            db.disconnect()
            db = Nothing

            If (playlist.getPlaylistLength > 0) Then

                ' Now add the playlist

                Me.main_playlist.appendPlaylist(playlist)
                Me.main_playlist.updateDisplay()

            End If

        End If

    End Sub

    ' Display the last 5 items

    Public Sub doPrevious(ByVal artist As String, ByVal track As String)

        ' Add to beginning of list

        Me.lbPlayedItems.Items.Insert(0, artist & " - " & track)

        ' MAGIC NUMBER 30 - Keep 30 items onscreen
        ' Prevents memory leak

        While (lbPlayedItems.Items.Count > 30)
            lbPlayedItems.Items.RemoveAt(lbPlayedItems.Items.Count - 1)
        End While

    End Sub

    ' Help topics
    ' Alternative supplied for now

    Private Sub TopicsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TopicsToolStripMenuItem.Click

        frmHelp.Show()
        frmHelp.wbHelp.Url = New Uri(System.AppDomain.CurrentDomain.BaseDirectory & "Manual\Index.html")
        frmHelp.WindowState = FormWindowState.Maximized

    End Sub

    ' Reload the database

    Private Sub ReloadDatabaseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReloadDatabaseToolStripMenuItem1.Click

        Dim counter As Integer
        Dim playlists As List(Of Playlist)

        ' Clear the old playlists list

        playlists = Me.getTables

        ' Load the playlists

        frmLoadingPlaylists.Show()

        For counter = 0 To (playlists.Count - 1)
            frmLoadingPlaylists.Text = "Loading Playlist " & playlists.Item(counter).getName
            General.loadPlaylist(playlists.Item(counter))
        Next

        frmLoadingPlaylists.Hide()

        ' And into working memory

        Me.playlists = playlists

        ' Refresh display

        If (frmSearchScreen.Visible) Then
            frmSearchScreen.refreshDisplay()
        End If

    End Sub

    ' Play to hour (button)

    Private Sub btnPlayToHour_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayToHour.Click

        ' Adjust

        Me.play_to_hour = Not Me.play_to_hour

        ' Display

        If (Me.play_to_hour) Then
            Me.btnPlayToHour.BackColor = Color.Red
        Else
            Me.btnPlayToHour.BackColor = Me.btnStop.BackColor
        End If

    End Sub

    ' Play to hour (action)

    Private Sub playToHour()

        ' Check

        If (Me.play_to_hour) Then

            If (Me.lblPlaylistRemain.Text.Equals(Me.lblToHour.Text)) Then
                Me.btnPlay_Click(Nothing, Nothing)
                Me.btnPlayToHour_Click(Nothing, Nothing)
            End If

        End If

    End Sub

    ' Flash a textbox

    Private Sub tmrFlasher_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrFlasher.Tick

        Dim counter As Integer
        Dim fg As Color
        Dim bg As Color

        ' Change

        Me.black_on_red = Not Me.black_on_red

        On Error Resume Next

        ' For each main player

        For counter = 0 To 3

            If (Not Me.getPlayerArray(counter).getItem Is Nothing) Then
                If (Me.getPlayerArray(counter).getTimeLeft <= 10 And Me.getPlayerArray(counter).getTimeLeft > 0 And Me.getPlayerArray(counter).getIsPlaying) Then
                    If (Me.black_on_red) Then
                        fg = Color.Black
                        bg = Color.Red
                    Else
                        fg = Color.Red
                        bg = Color.Black
                    End If
                    Me.player_time_left(counter).ForeColor = fg
                    Me.player_time_left(counter).BackColor = bg
                End If
            End If

        Next

    End Sub

    ' Spacebar has been pressed

    Private Sub pressedSpace()

        ' Check focus

        'If (Me.tbNotepad.Focused) Then
        'Exit Sub
        'End If

        ' Check for play

        If (Me.mc.getState > 0) Then
            Me.btnNext_Click(Nothing, Nothing)
        Else
            Me.btnPlay_Click(Nothing, Nothing)
        End If

        ' Replace focus

        Me.Focus()

    End Sub

    ' Backtime Calculator

    Private Sub BacktimeCalculatorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BacktimeCalculatorToolStripMenuItem.Click

        frmBackTimer.Show()

    End Sub

    ' Now and next

    Private Sub doNowNext()

        ' Time Check

        If (previous_second.Equals(Format(Now, "HH:mm:ss"))) Then
            Exit Sub
        Else
            previous_second = Format(Now, "HH:mm:ss")
        End If

        ' Check playlist length

        If (Me.getCurrentPlaylist.getPlaylistLength = 0) Then

            ' Both default text

            modNowNext.setNowNext(modNowNext.DefaultText, modNowNext.DefaultText)

        ElseIf (Me.getCurrentPlaylist.getPlaylistLength = 1) Then

            ' Just one item in playlist

            If (Me.getMC.getState > 0) Then

                ' One item in playlist is playing

                If (modNowNext.checkIgnore(Me.getCurrentPlaylist.getItem(0))) Then
                    modNowNext.setNowNext(modNowNext.DefaultText, modNowNext.DefaultText)
                Else
                    modNowNext.setNowNext(Me.getCurrentPlaylist.getItem(0).getArtist + " - " + Me.getCurrentPlaylist.getItem(0).getTrackName, modNowNext.DefaultText)
                End If


            Else

                ' One item in playlist not playing

                If (modNowNext.checkIgnore(Me.getCurrentPlaylist.getItem(0))) Then
                    modNowNext.setNowNext(modNowNext.DefaultText, modNowNext.DefaultText)
                Else
                    modNowNext.setNowNext(modNowNext.DefaultText, Me.getCurrentPlaylist.getItem(0).getArtist + " - " + Me.getCurrentPlaylist.getItem(0).getTrackName)
                End If

            End If

        Else

            ' Multiple items in playlist

            Dim ignore_now As Boolean = modNowNext.checkIgnore(Me.getCurrentPlaylist.getItem(0))
            Dim ignore_next As Boolean = modNowNext.checkIgnore(Me.getCurrentPlaylist.getItem(1))

            If (Me.getMC.getState > 0) Then

                ' Playing

                If (ignore_now) Then
                    If (ignore_next) Then
                        modNowNext.setNowNext(modNowNext.DefaultText, modNowNext.DefaultText)
                    Else
                        modNowNext.setNowNext(modNowNext.DefaultText, Me.getCurrentPlaylist.getItem(1).getArtist + " - " + Me.getCurrentPlaylist.getItem(1).getTrackName)
                    End If
                Else
                    If (ignore_next) Then
                        modNowNext.setNowNext(Me.getCurrentPlaylist.getItem(0).getArtist + " - " + Me.getCurrentPlaylist.getItem(0).getTrackName, modNowNext.DefaultText)
                    Else
                        modNowNext.setNowNext(Me.getCurrentPlaylist.getItem(0).getArtist + " - " + Me.getCurrentPlaylist.getItem(0).getTrackName, Me.getCurrentPlaylist.getItem(1).getArtist + " - " + Me.getCurrentPlaylist.getItem(1).getTrackName)
                    End If
                End If


            Else

                ' Stopped

                If (ignore_next) Then
                    modNowNext.setNowNext(modNowNext.DefaultText, modNowNext.DefaultText)
                Else
                    modNowNext.setNowNext(modNowNext.DefaultText, Me.getCurrentPlaylist.getItem(1).getArtist + " - " + Me.getCurrentPlaylist.getItem(1).getTrackName)
                End If

            End If

        End If

    End Sub

    ' Now and next settings

    Private Sub NowAndNextToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NowAndNextToolStripMenuItem.Click

        frmNowNext.Show()

    End Sub

    ' Removes automated items from the playlist

    Private Sub removeAutomatedProgramming()

        Dim removal_list As New List(Of AudioItem)
        Dim counter As Integer
        Dim temp_item As AudioItem

        ' Check all items in current playlist

        For counter = 0 To (Me.main_playlist.getPlaylistLength - 1)
            temp_item = Me.main_playlist.getItem(counter)
            If (temp_item.getAutomatedTrack And Not temp_item.getPlayed) Then
                removal_list.Add(temp_item)
            End If
        Next

        ' Now remove the items

        For counter = 0 To (removal_list.Count - 1)
            Me.main_playlist.removeByItem(removal_list.Item(counter))
        Next

        ' Refresh the list

        Me.main_playlist.updateDisplay()

    End Sub

    ' Show mixer screen

    Private Sub MixerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MixerToolStripMenuItem.Click

        frmMixer.Show()

    End Sub

    ' Playlist click

    Private Sub playlistClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRemain1.Click, lblRemain2.Click, lblRemain3.Click, lblRemain4.Click, lblPlaylistArtistTitleInfo1.Click, lblPlaylistArtistTitleInfo2.Click, lblPlaylistArtistTitleInfo3.Click, lblPlaylistArtistTitleInfo4.Click, lblPlaylistNumber1.Click, lblPlaylistNumber2.Click, lblPlaylistNumber3.Click, lblPlaylistNumber4.Click, lblPlaylistPlayed1.Click, lblPlaylistPlayed2.Click, lblPlaylistPlayed3.Click, lblPlaylistPlayed4.Click, pbPlaylist1.Click, pbPlaylist2.Click, pbPlaylist3.Click, pbPlaylist4.Click

        Dim counter As Integer
        Dim temp_value As Integer

        ' Check with item sent

        For counter = 0 To 3
            If (sender.Equals(Me.playlist_artist_title(counter)) Or sender.Equals(Me.playlist_length(counter)) Or sender.Equals(Me.playlist_numbers(counter)) Or sender.Equals(Me.playlist_played(counter)) Or sender.Equals(Me.playlist_progress(counter)) Or sender.Equals(Me.playlist_remain(counter))) Then
                temp_value = counter + Me.scrollPlaylist.Value
                If (temp_value >= Me.main_playlist.getPlaylistLength) Then
                    Me.selected_item = -1
                Else
                    Me.selected_item = temp_value
                End If
            End If
        Next

    End Sub

    ' Updates the playlist display

    Private Sub updatePlaylistDisplay()

        On Error Resume Next

        Dim scroll_bar_position As Integer
        Dim counter As Integer
        Dim sub_counter As Integer
        Dim in_main_player As Boolean
        Dim display_number As Integer = -1

        ' Scroll bar

        If (Me.main_playlist.getPlaylistLength <= 4) Then
            Me.scrollPlaylist.Maximum = 0
        Else
            Me.scrollPlaylist.Maximum = Me.main_playlist.getPlaylistLength - 4
        End If

        ' Blank all players

        If (Me.main_playlist.getPlaylistLength < 4) Then
            For counter = (Me.main_playlist.getPlaylistLength) To 3
                Me.playlist_numbers(counter).Text = ""
                Me.playlist_numbers(counter).BackColor = Color.White
                Me.playlist_artist_title(counter).Text = ""
                Me.playlist_length(counter).Text = ""
                Me.playlist_played(counter).Text = ""
                Me.playlist_remain(counter).Text = ""
                Me.playlist_length(counter).BorderStyle = BorderStyle.None
                Me.playlist_played(counter).BorderStyle = BorderStyle.None
                Me.playlist_remain(counter).BorderStyle = BorderStyle.None
                Me.playlist_numbers(counter).BorderStyle = BorderStyle.None
                Me.playlist_remain(counter).BackColor = Color.White
                Me.playlist_progress(counter).Visible = False
                Me.playlist_progress(counter).Maximum = 100
                Me.playlist_progress(counter).Minimum = 0
                Me.playlist_progress(counter).Value = 0
            Next
        End If

        ' Get scroll bar position

        scroll_bar_position = Me.scrollPlaylist.Value
        If (scroll_bar_position < 0) Then
            scroll_bar_position = 0
        End If

        ' Display

        For counter = scroll_bar_position To (scroll_bar_position + 3)

            display_number += 1

            ' Reset

            in_main_player = False

            ' Check if still in playlist

            If (Not Me.main_playlist.getItem(counter) Is Nothing) Then

                ' Find if in main player

                For sub_counter = 0 To 3
                    If (Me.main_playlist.getItem(counter).Equals(Me.getPlayerArray(sub_counter).getItem())) Then
                        If (Not in_main_player) Then

                            ' Flag

                            in_main_player = True

                            ' Display

                            If (General.checkBreakItem(Me.main_playlist.getItem(counter))) Then

                                Me.playlist_numbers(display_number).Text = ""
                                Me.playlist_numbers(display_number).BackColor = Color.Gray
                                Me.playlist_artist_title(display_number).Text = "<< BREAK >>"
                                Me.playlist_length(display_number).Text = ""
                                Me.playlist_played(display_number).Text = ""
                                Me.playlist_remain(display_number).Text = ""
                                Me.playlist_remain(display_number).BackColor = Color.White
                                Me.playlist_progress(display_number).Visible = False
                                Me.playlist_progress(display_number).Maximum = 100
                                Me.playlist_progress(display_number).Minimum = 0
                                Me.playlist_progress(display_number).Value = 0
                                Me.playlist_length(counter).BorderStyle = BorderStyle.None
                                Me.playlist_played(counter).BorderStyle = BorderStyle.None
                                Me.playlist_remain(counter).BorderStyle = BorderStyle.None
                                Me.playlist_numbers(counter).BorderStyle = BorderStyle.None

                            Else

                                Me.playlist_numbers(display_number).Text = sub_counter + 1
                                Me.playlist_numbers(display_number).BackColor = Me.player_border(sub_counter).BackColor
                                Me.playlist_artist_title(display_number).Text = "Artist: " & Me.main_playlist.getItem(counter).getArtist & vbCrLf & "Title: " & Me.main_playlist.getItem(counter).getTrackName & vbCrLf & "Info: " & Me.main_playlist.getItem(counter).getInfo
                                Me.playlist_length(display_number).Text = General.timeToString(Me.main_playlist.getItem(counter).getTimeEndIntro - Me.main_playlist.getItem(counter).getTimeStartIntro) & vbCrLf & General.timeToString(Me.main_playlist.getItem(counter).getTimeEndTrack - Me.main_playlist.getItem(counter).getTimeStartTrack)
                                Me.playlist_played(display_number).Text = Me.player_time_played(sub_counter).Text
                                Me.playlist_remain(display_number).Text = Me.player_time_left(sub_counter).Text
                                Me.playlist_remain(display_number).BackColor = Me.player_time_left(sub_counter).BackColor
                                Me.playlist_remain(display_number).ForeColor = Me.player_time_left(sub_counter).ForeColor
                                Me.playlist_progress(display_number).Visible = True
                                Me.playlist_progress(display_number).Maximum = Me.player_progress(sub_counter).Maximum
                                Me.playlist_progress(display_number).Minimum = Me.player_progress(sub_counter).Minimum
                                Me.playlist_progress(display_number).Value = Me.player_progress(sub_counter).Value
                                Me.playlist_length(counter).BorderStyle = BorderStyle.FixedSingle
                                Me.playlist_played(counter).BorderStyle = BorderStyle.FixedSingle
                                Me.playlist_remain(counter).BorderStyle = BorderStyle.FixedSingle
                                Me.playlist_numbers(counter).BorderStyle = BorderStyle.FixedSingle

                            End If

                        End If
                    End If
                Next

                ' If not display normally

                If (Not in_main_player) Then

                    If (General.checkBreakItem(Me.main_playlist.getItem(counter))) Then

                        Me.playlist_numbers(display_number).Text = ""
                        Me.playlist_numbers(display_number).BackColor = Color.Gray
                        Me.playlist_artist_title(display_number).Text = "<< BREAK >>"
                        Me.playlist_length(display_number).Text = ""
                        Me.playlist_played(display_number).Text = ""
                        Me.playlist_remain(display_number).Text = ""
                        Me.playlist_remain(display_number).BackColor = Color.White
                        Me.playlist_progress(display_number).Visible = False
                        Me.playlist_progress(display_number).Maximum = 100
                        Me.playlist_progress(display_number).Minimum = 0
                        Me.playlist_progress(display_number).Value = 0
                        Me.playlist_length(counter).BorderStyle = BorderStyle.None
                        Me.playlist_played(counter).BorderStyle = BorderStyle.None
                        Me.playlist_remain(counter).BorderStyle = BorderStyle.None
                        Me.playlist_numbers(counter).BorderStyle = BorderStyle.None

                    Else

                        Me.playlist_numbers(display_number).Text = ""
                        Me.playlist_numbers(display_number).BackColor = Color.Gray
                        Me.playlist_artist_title(display_number).Text = "Artist: " & Me.main_playlist.getItem(counter).getArtist & vbCrLf & "Title: " & Me.main_playlist.getItem(counter).getTrackName & vbCrLf & "Info: " & Me.main_playlist.getItem(counter).getInfo
                        Me.playlist_length(display_number).Text = General.timeToString(Me.main_playlist.getItem(counter).getTimeEndIntro - Me.main_playlist.getItem(counter).getTimeStartIntro) & vbCrLf & General.timeToString(Me.main_playlist.getItem(counter).getTimeEndTrack - Me.main_playlist.getItem(counter).getTimeStartTrack)
                        Me.playlist_played(display_number).Text = ""
                        Me.playlist_remain(display_number).Text = ""
                        Me.playlist_remain(display_number).BackColor = Color.White
                        Me.playlist_progress(display_number).Visible = False
                        Me.playlist_progress(display_number).Maximum = 100
                        Me.playlist_progress(display_number).Minimum = 0
                        Me.playlist_progress(display_number).Value = 0
                        Me.playlist_length(counter).BorderStyle = BorderStyle.FixedSingle
                        Me.playlist_played(counter).BorderStyle = BorderStyle.FixedSingle
                        Me.playlist_remain(counter).BorderStyle = BorderStyle.FixedSingle
                        Me.playlist_numbers(counter).BorderStyle = BorderStyle.FixedSingle

                    End If

                End If

                    ' Selected item

                    If (counter = Me.selected_item) Then
                        Me.playlist_table(display_number).BackColor = Color.Blue
                    Else
                        Me.playlist_table(display_number).BackColor = Color.White
                    End If

                End If

        Next

    End Sub

    ' Resets the selected item

    Public Sub resetSelected()
        Me.selected_item = -1
    End Sub

    ' Clear the played items

    Private Sub btnClearPlayed_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClearPlayed.Click
        Me.lbPlayedItems.Items.Clear()
    End Sub

    ' Schedule playlists

    Private Sub scheduleM3U()

        Dim playlist As Playlist
        Dim counter As Integer

        ' Get the playlist forced playlist

        playlist = New M3U().getCurrentlyScheduledPlaylist(General.program_settings.getM3UFolder, General.program_settings.getM3UFileName, True, Me.last_m3u_file)

        If Not playlist Is Nothing Then
            If Me.last_m3u_file Is Nothing Then

                ' Set every item to auto scheduled

                For counter = 0 To (playlist.getPlaylistLength - 1)
                    playlist.getItem(counter).setAutomatedTrack(False)
                Next

                ' Add to playlist

                Me.getCurrentPlaylist.insertPlaylist(playlist, 1)

                ' Get to a playling state

                Me.assignPlayers()
                Me.btnPlay_Click(Nothing, Nothing)
                If Me.getCurrentPlaylist.getPlaylistLength > playlist.getPlaylistLength Then
                    Me.mc.playNextItem()
                End If

                ' Prevent further processing

                Me.last_m3u_file = playlist.getName
                Exit Sub

            ElseIf Not Me.last_m3u_file.Equals(playlist.getName) Then

                ' Set every item to auto scheduled

                For counter = 0 To (playlist.getPlaylistLength - 1)
                    playlist.getItem(counter).setAutomatedTrack(False)
                Next

                ' Add to playlist

                Me.getCurrentPlaylist.insertPlaylist(playlist, 1)

                ' Get to a playling state

                Me.assignPlayers()
                Me.btnPlay_Click(Nothing, Nothing)
                If Me.getCurrentPlaylist.getPlaylistLength > playlist.getPlaylistLength Then
                    Me.mc.playNextItem()
                End If

                ' Prevent further processing

                Me.last_m3u_file = playlist.getName
                Exit Sub

            End If
        End If

        ' Try non-forced playlist

        playlist = New M3U().getCurrentlyScheduledPlaylist(General.program_settings.getM3UFolder, General.program_settings.getM3UFileName, False, Me.last_m3u_file)

        If Not playlist Is Nothing Then
            If Me.last_m3u_file Is Nothing Then

                ' Set every item to auto scheduled

                For counter = 0 To (playlist.getPlaylistLength - 1)
                    playlist.getItem(counter).setAutomatedTrack(True)
                Next

                ' Remove automated and add to playlist

                Me.removeAutomatedProgramming()
                Me.getCurrentPlaylist.appendPlaylist(playlist)
                Me.assignPlayers()
                Me.btnPlay_Click(Nothing, Nothing)

                ' Prevent further processing

                Me.last_m3u_file = playlist.getName
                Exit Sub

            ElseIf Not Me.last_m3u_file.Equals(playlist.getName) Then

                ' Set every item to auto scheduled

                For counter = 0 To (playlist.getPlaylistLength - 1)
                    playlist.getItem(counter).setAutomatedTrack(True)
                Next

                ' Remove automated and add to playlist

                Me.removeAutomatedProgramming()
                Me.getCurrentPlaylist.appendPlaylist(playlist)
                Me.assignPlayers()
                Me.btnPlay_Click(Nothing, Nothing)

                ' Prevent further processing

                Me.last_m3u_file = playlist.getName
                Exit Sub

            End If
        End If

    End Sub

End Class
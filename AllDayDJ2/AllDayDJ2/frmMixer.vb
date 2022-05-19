Public Class frmMixer

    Private sliders(0 To 4) As TrackBar
    Private play_buttons(0 To 3) As Button
    Private stop_buttons(0 To 3) As Button
    Private selected_slider As Integer = -1
    Private level_left(0 To 3) As VerticalProgressBar.VerticalProgressBar
    Private level_right(0 To 3) As VerticalProgressBar.VerticalProgressBar
    Private data_lbls(0 To 3) As Label

    ' Check for persistance

    Private Sub frmMixer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If (General.screen_settings.PersistMixer) Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If

    End Sub

    ' Key presses

    Private Sub frmMixer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        frmMain.frmMain_KeyDown(sender, e)
        Me.BringToFront()
        Me.Focus()

    End Sub

    ' Assign

    Private Sub frmMixer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        On Error Resume Next

        ' Track bars

        sliders(0) = Me.TrackBar1
        sliders(1) = Me.TrackBar2
        sliders(2) = Me.TrackBar3
        sliders(3) = Me.TrackBar4

        ' Play

        play_buttons(0) = Me.btnPlay1
        play_buttons(1) = Me.btnPlay2
        play_buttons(2) = Me.btnPlay3
        play_buttons(3) = Me.btnPlay4

        ' Stop

        stop_buttons(0) = Me.btnStop1
        stop_buttons(1) = Me.btnStop2
        stop_buttons(2) = Me.btnStop3
        stop_buttons(3) = Me.btnStop4

        ' Level meters

        level_left(0) = Me.VerticalProgressBar1
        level_left(1) = Me.VerticalProgressBar4
        level_left(2) = Me.VerticalProgressBar6
        level_left(3) = Me.VerticalProgressBar8

        level_right(0) = Me.VerticalProgressBar2
        level_right(1) = Me.VerticalProgressBar3
        level_right(2) = Me.VerticalProgressBar5
        level_right(3) = Me.VerticalProgressBar7

        ' Data labels

        data_lbls(0) = Me.lblData1
        data_lbls(1) = Me.lblData2
        data_lbls(2) = Me.lblData3
        data_lbls(3) = Me.lblData4

        ' Screen location

        Dim boundarys As Rectangle = Screen.AllScreens(General.screen_settings.ScreenMixer).Bounds
        Me.SetBounds(boundarys.X, boundarys.Y, boundarys.Width, boundarys.Height)
        'Me.WindowState = FormWindowState.Maximized

    End Sub

    ' Update display

    Private Sub tmrUpdateLevels_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrUpdateLevels.Tick

        On Error Resume Next
        Dim counter As Integer
        Dim data_string As String
        Dim max As Integer = 0

        ' Every main player

        For counter = 0 To 3

            ' Slider

            If (Me.selected_slider <> counter) Then
                Me.sliders(counter).Value = frmMain.getPlayerArray(counter).getVolume
            Else
                frmMain.getPlayerArray(counter).setVolume(Me.sliders(counter).Value)
            End If

            ' Levels

            Me.level_left(counter).Value = (frmMain.getPlayerArray(counter).getLeftVolumeLevel * frmMain.getPlayerArray(counter).getVolume) / 100
            Me.level_right(counter).Value = (frmMain.getPlayerArray(counter).getRightVolumeLevel * frmMain.getPlayerArray(counter).getVolume) / 100

            ' Data

            data_string = "Artist: " & frmMain.player_artist(counter).Text & vbCrLf
            data_string += "Title: " & frmMain.player_title(counter).Text & vbCrLf
            data_string += "Played: " & frmMain.player_time_played(counter).Text & vbCrLf
            data_string += "Remaining: " & frmMain.player_time_left(counter).Text & vbCrLf
            data_lbls(counter).Text = data_string
            data_lbls(counter).BackColor = frmMain.player_time_left(counter).BackColor
            data_lbls(counter).ForeColor = frmMain.player_time_left(counter).ForeColor

        Next

    End Sub

    ' Click play

    Private Sub play_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlay1.Click, btnPlay2.Click, btnPlay3.Click, btnPlay4.Click

        Dim counter As Integer
        Dim btn_sender As Button = sender

        On Error Resume Next

        ' Play appropriate player

        For counter = 0 To 3
            If (Me.play_buttons(counter).Equals(btn_sender)) Then
                frmMain.getPlayerArray(counter).play(False)
            End If
        Next

    End Sub

    ' Click stop

    Private Sub stop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStop1.Click, btnStop2.Click, btnStop3.Click, btnStop4.Click

        Dim counter As Integer
        Dim btn_sender As Button = sender

        On Error Resume Next

        ' Play appropriate player

        For counter = 0 To 3
            If (Me.stop_buttons(counter).Equals(btn_sender)) Then
                frmMain.getPlayerArray(counter).stopItem(2000)
            End If
        Next

    End Sub

    ' Disable refresh to allow volume change

    Private Sub TrackBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrackBar1.MouseDown, TrackBar2.MouseDown, TrackBar3.MouseDown, TrackBar4.MouseDown

        Dim counter As Integer

        ' Check and set variable

        For counter = 0 To 3
            If (Me.sliders(counter).Equals(sender)) Then
                Me.selected_slider = counter
            End If
        Next

    End Sub

    ' Enable again (after volume change)

    Private Sub TrackBar1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrackBar1.MouseUp, TrackBar2.MouseUp, TrackBar3.MouseUp, TrackBar4.MouseUp

        Dim counter As Integer

        ' Check

        If (Me.selected_slider < 0) Then
            Exit Sub
        End If

        ' Do

        For counter = 0 To 3
            If (Me.selected_slider = counter) Then
                frmMain.getPlayerArray(counter).setVolume(Me.sliders(counter).Value)
            End If
        Next

        ' Reset

        Me.selected_slider = -1

    End Sub

End Class
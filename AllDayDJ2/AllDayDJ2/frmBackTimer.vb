Public Class frmBackTimer

    ' Back time calculation

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim song_mins As Integer
        Dim song_secs As Integer
        Dim jingle_secs As Integer
        Dim total_secs As Integer
        Dim total_mins As Integer
        Dim time_string As String

        ' Get the times

        song_mins = Me.nudSongMins.Value
        song_secs = Me.nudSongSeconds.Value
        jingle_secs = Me.nudJingleSeconds.Value

        ' Calcualte the total

        total_secs = Me.nudJingleSeconds.Value + Me.nudSongSeconds.Value + (Me.nudSongMins.Value * 60)

        ' Time to hour

        total_secs = 3600 - total_secs
        total_mins = Int(total_secs / 60)
        total_secs -= total_mins * 60

        ' Display

        If (total_mins < 10) Then
            time_string = "0" + total_mins.ToString + ":"
        Else
            time_string = total_mins.ToString + ":"
        End If

        If (total_secs < 10) Then
            time_string += "0" + total_secs.ToString
        Else
            time_string += total_secs.ToString
        End If

        Me.lblPlayAt.Text = time_string
        Me.lblPlayAt.Visible = True

    End Sub

End Class
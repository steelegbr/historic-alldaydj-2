Imports Bass = Un4seen.Bass.Bass    ' Audio library

Public Class frmTrackPos

    Private channel As Long

    ' Load the item up

    Public Sub loadItem(ByVal channel As Long, ByRef file_name As String, ByRef title As String)

        ' Show data onscreen

        Me.channel = channel
        Me.Text = title
        Me.lblFileName.Text = file_name

        ' Set the progress bar limits

        Me.pbPosition.Maximum = Bass.BASS_ChannelGetLength(channel)

        ' Activate the timer

        Me.tmrGetPosition.Enabled = True

    End Sub

    ' Unload the item

    Public Sub unloadItem()

        Me.tmrGetPosition.Enabled = False
        Me.channel = 0

    End Sub

    ' Update progress

    Private Sub tmrGetPosition_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrGetPosition.Tick

        Me.pbPosition.Value = Bass.BASS_ChannelGetPosition(Me.channel)

    End Sub

End Class
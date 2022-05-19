Public Class frmAddToEvent

    Private Sub frmAddToEvent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim counter As Integer

        On Error Resume Next

        ' Load the spots

        Me.cmbSpot.Items.Clear()

        For counter = 0 To (ProgramSettings.spots.Count - 1)
            Me.cmbSpot.Items.Add(ProgramSettings.spots(counter).spot_name)
        Next

        Me.cmbSpot.SelectedIndex = 0

        ' And the playlists

        Me.cmbPlaylists.Items.Clear()

        For counter = 0 To (ProgramSettings.playlists.Count - 1)
            Me.cmbPlaylists.Items.Add(ProgramSettings.playlists(counter).getName)
        Next

        Me.cmbPlaylists.SelectedIndex = 0

        ' Radio buttons

        Me.rbSpot.Checked = True

    End Sub

    ' Radio buttons

    Private Sub rbPlaylist_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPlaylist.CheckedChanged

        Dim value As Boolean

        ' Check the state

        value = Me.rbPlaylist.Checked

        ' Now update the screen

        Me.rbSpot.Checked = Not value
        Me.cmbPlaylists.Enabled = value
        Me.cmbSpot.Enabled = Not value

    End Sub

    Private Sub rbSpot_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSpot.CheckedChanged

        Dim value As Boolean

        ' Check the state

        value = Me.rbSpot.Checked

        ' Now update the screen

        Me.rbSpot.Checked = value
        Me.cmbPlaylists.Enabled = Not value
        Me.cmbSpot.Enabled = value

    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim selected_item As Integer

        ' Get the item type

        If (Me.rbSpot.Checked) Then

            ' Spot

            selected_item = Me.cmbSpot.SelectedIndex
            If (selected_item < 0) Then
                Exit Sub
            End If

            ' Add the spot to the rotation

            frmEditEvent.addToEvent(ProgramSettings.spots(selected_item))

        Else

            ' Playlist

            selected_item = Me.cmbPlaylists.SelectedIndex
            If (selected_item < 0) Then
                Exit Sub
            End If

            ' Add the playlist to the rotation

            frmEditEvent.addToEvent(ProgramSettings.playlists(selected_item))

        End If

        ' Close the screen

        Me.Close()
        Me.Dispose()

    End Sub

End Class
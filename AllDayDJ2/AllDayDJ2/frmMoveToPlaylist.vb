Public Class frmMoveToPlaylist

    Private item As AudioItem
    Private old_pl_number As Integer
    Private playlists As List(Of Playlist)
    Private item_number As Integer

    ' Load the item

    Sub loadItem(ByRef item As AudioItem, ByVal old_pl As String, ByVal item_number As Integer)

        Dim counter As Integer

        ' Get the old playlist number

        For counter = 0 To (Me.cmbPlaylists.Items.Count - 1)
            If (Me.cmbPlaylists.Items.Item(counter).Equals(old_pl)) Then
                Me.old_pl_number = counter
            End If
        Next

        ' Load the item

        Me.item = item
        Me.item_number = item_number

        ' Refresh the options

        Me.frmMoveToPlaylist_Shown(Nothing, Nothing)

    End Sub

    ' Load the options

    Private Sub frmMoveToPlaylist_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Dim counter As Integer

        ' Get the playlists and load them in

        Me.cmbPlaylists.Items.Clear()
        Me.playlists = frmMain.getPlaylists
        For counter = 0 To (playlists.Count - 1)
            Me.cmbPlaylists.Items.Add(playlists(counter).getName)
        Next
        Me.cmbPlaylists.SelectedIndex = 0

    End Sub

    ' Actually move the item

    Private Sub btnMove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMove.Click

        Dim new_pl_number As Integer

        ' Get the new playlist number

        new_pl_number = Me.cmbPlaylists.SelectedIndex
        If (new_pl_number < 0) Then
            MsgBox("No playlist selected!" & Chr(13) & Chr(10) & "Please select a playlist and try again.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        ' Don't do anything if it is the same playlist

        If (new_pl_number = old_pl_number) Then
            Me.Hide()
        End If

        ' Otherwise do the copy

        frmMain.getPlaylists(old_pl_number).removeByItem(item)

        ' Removing from the old playlist

        Dim db As New Database(General.program_settings.getDbLocation)
        db.executeRS("DELETE FROM [" & item.getDbTable & "] WHERE trackid = " & item.getTrackId)
        db.disconnect()
        db = Nothing
        item.setDBTable(frmMain.getPlaylists(new_pl_number).getName)

        ' And entering into the new

        item.saveNew()
        frmMain.getPlaylists(new_pl_number).addToPlaylist(item)
        frmTracks.updateDisplay()
        Me.Hide()

    End Sub

End Class
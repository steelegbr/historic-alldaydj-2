Public Class frmEditRotation

    Private rotation As Rotation

    ' Load the rotation

    Public Sub showEditRotation(ByVal rotation As Rotation)

        Dim temp_spot As Spot = Nothing
        Dim temp_playlist As Playlist = Nothing
        Dim item_id As String = ""
        Dim item_type As String = ""

        Try

            ' Load the spot

            Me.rotation = rotation

            ' And the oncreen version

            Me.Text = "Edit Rotation - " & Me.rotation.rotation_name
            Me.lbItems.Items.Clear()

            Me.updateDisplay()

        Catch ex As Exception
            ErrorHandler.errorHandler(ex)
        End Try

    End Sub

    ' Add an item to the spot

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        frmAddToRotation.Show()

    End Sub

    ' Add an item to the rotatiob

    Public Sub addToRotation(ByVal playlist As Playlist)

        Me.rotation.item_id.Add(playlist.getName)
        Me.rotation.item_type.Add("playlist")
        Me.updateDisplay()

    End Sub

    Public Sub addToRotation(ByVal spot As Spot)

        Me.rotation.item_id.Add(spot.spot_name)
        Me.rotation.item_type.Add("spot")
        Me.updateDisplay()

    End Sub

    ' Show the spot onscreen

    Private Sub updateDisplay()

        Dim counter As Integer
        Dim sub_counter As Integer
        Dim item As AudioItem
        Dim item_id As String
        Dim item_type As String
        Dim temp_spot As Spot
        Dim temp_playlist As Playlist

        Me.lbItems.Items.Clear()

        For counter = 0 To (rotation.item_id.Count - 1)
            item_id = rotation.item_id(counter)
            item_type = rotation.item_type(counter)

            ' Spot or playlist

            If (item_type.Equals("spot")) Then

                ' Get the spot from memory

                For sub_counter = 0 To (ProgramSettings.spots.Count - 1)
                    If (item_id.Equals(ProgramSettings.spots(sub_counter).spot_name.Trim)) Then
                        temp_spot = ProgramSettings.spots(sub_counter)
                        Me.lbItems.Items.Add(temp_spot.spot_name & " [SPOT]")
                    End If
                Next

            ElseIf (item_type.Equals("playlist")) Then

                ' Get the playlist from memory

                For sub_counter = 0 To (ProgramSettings.playlists.Count - 1)
                    If (item_id.Equals(ProgramSettings.playlists(sub_counter).getName.Trim)) Then
                        temp_playlist = ProgramSettings.playlists(sub_counter)
                        Me.lbItems.Items.Add(temp_playlist.getName & " [PLAYLIST]")
                    End If
                Next

            End If
        Next

    End Sub

    ' Remove an item from the rotation

    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        Dim selected_item As Integer
        Dim counter As Integer

        ' Get the selected item

        selected_item = Me.lbItems.SelectedIndex
        If (selected_item < 0) Then
            Exit Sub
        End If

        ' Remove the item

        Me.rotation.item_id.RemoveAt(selected_item)
        Me.rotation.item_type.RemoveAt(selected_item)

        ' Display changes

        Me.updateDisplay()

    End Sub

    ' Save and close

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Me.rotation.saveToDb()
        Me.Close()
        frmMain.updateDisplay()

    End Sub

End Class
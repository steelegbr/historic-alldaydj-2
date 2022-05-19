Public Class frmMain

    Private display As Integer = 0

    ' 0 - Spots
    ' 1 - Rotations
    ' 2 - Events
    ' 3 - Calendar (other screen)

    Private display_single() As String = {"spot", "rotation", "event", "calendar"}
    Private display_multiple() As String = {"spots", "rotations", "events", "calendars"}
    Private days_of_the_week() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}

    ' Load time events

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim counter As Integer

        Try

            ' Load the default settings

            General.settingsLoader()

            ' Load playlists, rotations, events and spots

            ProgramSettings.playlists = General.getPlaylists
            ProgramSettings.spots = General.getListOfSpots
            ProgramSettings.events = General.getListOfEvents
            ProgramSettings.rotations = General.getListOfRotations

            ' Load the actual playlists from the list of playlists

            For counter = 0 To (ProgramSettings.playlists.Count - 1)
                General.playlistLoader(ProgramSettings.playlists.Item(counter))
            Next

            ' Selects spots as default

            Me.display = 0
            Me.updateDisplay()

        Catch ex As Exception
            ErrorHandler.errorHandler(ex)
        End Try

    End Sub

    ' Load the list of spots

    Private Sub displaySpots()

        Dim spot As Spot
        Dim counter As Integer

        ' Clear current screen

        Me.lvData.Items.Clear()

        ' Show new data

        For counter = 0 To (ProgramSettings.spots.Count - 1)

            ' Load the item and display

            spot = ProgramSettings.spots(counter)
            Me.lvData.Items.Add(spot.spot_name, 0)

        Next

    End Sub

    ' Load the list of rotations

    Private Sub displayRotations()

        Dim rotation As Rotation
        Dim counter As Integer

        ' Clear current screen

        Me.lvData.Items.Clear()

        ' Show new data

        For counter = 0 To (ProgramSettings.rotations.Count - 1)

            ' Load the item and display

            rotation = ProgramSettings.rotations(counter)
            Me.lvData.Items.Add(rotation.rotation_name, 1)

        Next

    End Sub

    ' Load the list of events

    Private Sub displayEvents()

        Dim temp_event As ScheduledEvent
        Dim counter As Integer

        ' Clear the current screen

        Me.lvData.Items.Clear()

        ' Show new data

        For counter = 0 To (ProgramSettings.events.Count - 1)

            ' Load the item and display

            temp_event = ProgramSettings.events(counter)
            Me.lvData.Items.Add(temp_event.name, 2)

        Next

    End Sub

    ' Load the list of days

    Private Sub displayWeek()

        Dim counter As Integer

        ' Clear the current screen

        Me.lvData.Items.Clear()

        ' Show new data

        For counter = 0 To 6
            Me.lvData.Items.Add(Me.days_of_the_week(counter), 3)
        Next

    End Sub

    ' Delete the item

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim selected_item As Integer
        Dim db As Database
        Dim item_id As Integer

        ' Don't bother with days of the week

        If (Me.display = 3) Then
            MsgBox("You cannot delete a new day of the week!", MsgBoxStyle.Exclamation, "Hint")
            Exit Sub
        End If

        Try

            ' Get the selected item

            selected_item = Me.lvData.SelectedIndices(0)
            If (selected_item < 0 Or Me.display = 3) Then
                Exit Sub
            End If

            ' Now confirm

            If (MsgBox("Are you sure you wish to delete the selected " & Me.display_single(Me.display) & "?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes) Then

                ' We need to know what type of item it is

                Select Case Me.display
                    Case 0
                        item_id = ProgramSettings.spots(selected_item).id
                    Case 1
                        item_id = ProgramSettings.rotations(selected_item).id
                    Case 2
                        item_id = ProgramSettings.events(selected_item).id
                End Select

                ' Do the actual removal

                db = New Database(ProgramSettings.parts_db_location)
                db.execute("DELETE FROM [" & Me.display_multiple(Me.display) & "] WHERE " & Me.display_single(Me.display) & "id = " & item_id)
                db.disconnect()
                db = Nothing

            End If

            ' Update onscreen

            Me.updateDisplay()

        Catch ex As Exception
            'ErrorHandler.errorHandler(ex)
        End Try

    End Sub

    ' Update the display

    Public Sub updateDisplay()

        ' Start by reloading items from the database

        ProgramSettings.spots = General.getListOfSpots
        ProgramSettings.events = General.getListOfEvents
        ProgramSettings.rotations = General.getListOfRotations

        ' Now show the appropriate screen

        Select Case Me.display
            Case 0
                Me.displaySpots()
            Case 1
                Me.displayRotations()
            Case 2
                Me.displayEvents()
            Case 3
                Me.displayWeek()
        End Select

    End Sub

    ' Spots, Rotations, Events and Week view button

    Private Sub btnSpots_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSpots.Click

        Me.display = 0
        Me.updateDisplay()

    End Sub

    Private Sub btnRotations_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRotations.Click

        Me.display = 1
        Me.updateDisplay()

    End Sub

    Private Sub btnEvents_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEvents.Click

        Me.display = 2
        Me.updateDisplay()

    End Sub

    Private Sub btnWeek_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWeek.Click

        Me.display = 3
        Me.updateDisplay()

    End Sub

    ' Add an item

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim item_name As String = ""
        Dim create_new As Boolean = True
        Dim counter As Integer
        Dim item As Object = Nothing

        ' Don't bother with days of the week

        If (Me.display = 3) Then
            MsgBox("You cannot create a new day of the week!", MsgBoxStyle.Exclamation, "Hint")
            Exit Sub
        End If

        ' Get the item name

        item_name = InputBox("Please enter a name for the new " & Me.display_single(Me.display) & ".", "New " & Me.display_single(Me.display))
        While (item_name.Length = 0)
            MsgBox("You entered no name for the new " & Me.display_single(Me.display) & "." & Chr(13) & Chr(10) & "Please enter a valid name and try again.")
            item_name = InputBox("Please enter a name for the new " & Me.display_single(Me.display) & ".", "New " & Me.display_single(Me.display))
        End While

        ' Check we do not already have the item

        Select Case Me.display
            Case 0
                For counter = 0 To (ProgramSettings.spots.Count - 1)
                    If (item_name.Equals(ProgramSettings.spots.Item(counter).spot_name)) Then
                        If (MsgBox("A " & Me.display_single(Me.display) & " named """ & item_name & """ already exists." & Chr(13) & Chr(10) & "Do you wish to edit this " & Me.display_single(Me.display) & "?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes) Then
                            create_new = False
                            item = ProgramSettings.spots.Item(counter)
                        Else
                            Exit Sub
                        End If
                    End If
                Next
            Case 1
                For counter = 0 To (ProgramSettings.playlists.Count - 1)
                    If (item_name.Equals(ProgramSettings.playlists.Item(counter).getName)) Then
                        If (MsgBox("A " & Me.display_single(Me.display) & " named """ & item_name & """ already exists." & Chr(13) & Chr(10) & "Do you wish to edit this " & Me.display_single(Me.display) & "?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes) Then
                            create_new = False
                            item = ProgramSettings.playlists.Item(counter)
                        Else
                            Exit Sub
                        End If
                    End If
                Next
            Case 2
                For counter = 0 To (ProgramSettings.events.Count - 1)
                    If (item_name.Equals(ProgramSettings.events(counter).name.Equals(item_name))) Then
                        If (MsgBox("A " & Me.display_single(Me.display) & " named """ & item_name & """ already exists." & Chr(13) & Chr(10) & "Do you wish to edit this " & Me.display_single(Me.display) & "?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm") = MsgBoxResult.Yes) Then
                            create_new = False
                            item = ProgramSettings.events(counter)
                        Else
                            Exit Sub
                        End If
                    End If
                Next
            Case 3
        End Select

        ' Now create the item as appropriate

        If (item Is Nothing) Then
            Select Case Me.display
                Case 0
                    Dim temp_spot As New Spot(0, item_name)
                    temp_spot.saveNewSpotToDb()
                    item = temp_spot
                Case 1
                    Dim temp_rotation As New Rotation(0, item_name)
                    temp_rotation.saveNewRotationToDb()
                    item = temp_rotation
                Case 2
                    Dim temp_event As New ScheduledEvent(0, item_name, "", "")
                    temp_event.saveNewEventToDb()
                    item = temp_event
                Case 3
            End Select
        End If

        ' Display the edit screen

        Select Case Me.display
            Case 0
                frmEditSpot.showEditSpot(item)
                frmEditSpot.Show()
            Case 1
                frmEditRotation.showEditRotation(item)
                frmEditRotation.Show()
            Case 2
                frmEditEvent.Show()
                frmEditEvent.loadEvent(item)
            Case 3
        End Select

    End Sub

    ' Edit an item

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Dim selected_item As Integer

        ' Get the seleted item

        selected_item = Me.lvData.SelectedIndices(0)
        If (selected_item < 0) Then
            Exit Sub
        End If

        ' We need to know the item type

        Select Case Me.display
            Case 0
                frmEditSpot.showEditSpot(ProgramSettings.spots(selected_item))
                frmEditSpot.Show()
            Case 1
                frmEditRotation.showEditRotation(ProgramSettings.rotations(selected_item))
                frmEditRotation.Show()
            Case 2
                frmEditEvent.Show()
                frmEditEvent.loadEvent(ProgramSettings.events(selected_item))
            Case 3
                frmEditDay.Show()
                frmEditDay.loadDay(Me.days_of_the_week(selected_item))
        End Select

    End Sub

    ' About

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        frmAbout.Show()

    End Sub

    ' Quit

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub

    ' Program settings

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click

        frmSettings.Show()

    End Sub

    ' Run scheduler mini-program

    Private Sub GeneratePlaylistsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GeneratePlaylistsToolStripMenuItem.Click

        Dim location As String = """" & System.AppDomain.CurrentDomain.BaseDirectory & "console.exe"" """ & ProgramSettings.parts_db_location & """ """ & ProgramSettings.record_collection_location & """ """ & ProgramSettings.schedule_db_location & """"

        ' Generate batch file

        Try

            Dim fs As New IO.FileStream(System.AppDomain.CurrentDomain.BaseDirectory & "runconsole.bat", IO.FileMode.Create)
            Dim sw As New IO.StreamWriter(fs)

            ' Write

            sw.WriteLine(location)

            ' Close

            sw.Close()
            fs.Close()
            sw = Nothing
            fs = Nothing

            ' Notification

            MsgBox("The playlists can be generated manually by running the runconsole.bat file in this program's directory.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "RunConsole.bat")

        Catch ex As Exception

            ' Silent failure

        End Try

        Shell(location, AppWinStyle.MaximizedFocus)

    End Sub

    ' Purges the playlists

    Private Sub PurgePlaylistsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PurgePlaylistsToolStripMenuItem.Click

        ' Confirm

        If (MsgBox("Purging the current schedule will cause all currently scheduled playlists to be deleted. This includes manually edited playlists. Are you sure?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No) Then
            Exit Sub
        End If

        ' Do the delete

        Dim db As New Database(ProgramSettings.schedule_db_location)
        db.execute("DELETE * FROM [schedule]")
        db.disconnect()
        db = Nothing

    End Sub

End Class

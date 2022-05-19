Module Main

    Private last_half_past As New Date(0)
    Private last_top_of_hour As New Date(0)
    Private lo28days As List(Of Day)

    Sub Main()

        Try

            ' Display the welcome message

            Randomize()
            Console.BackgroundColor = ConsoleColor.Blue
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.Title = "AllDay DJ 2 Scheduler (Console)"
            welcomeMessage()
            Console.Beep()

            ' Load the settings and files

            General.settingsLoader()
            loadDatabase()

            ' Load successful

            Console.WriteLine("")
            Console.WriteLine("This program will now only display ERROR messages.")
            Console.WriteLine("If you see nothing, assume all OK.")
            Console.WriteLine("")
            Console.WriteLine("If you make any changes to the schedule or databases")
            Console.WriteLine("this program will update them at 30 MINS past the hour every hour.")
            Console.WriteLine("")
            Console.WriteLine("To exit press CTRL and C at the same time.")
            Console.WriteLine("To go to full screen press CTRL and ENTER / RETURN at the same time.")

            ' Run update once anyway

            checkEvents()
            load28Days()
            Console.WriteLine("")
            Console.WriteLine("Updated - " + Format(Now, "HH:mm:ss dd/MM/yyyy"))

            ' Use an infinite loop (not so smart but required)

            While True

                ' Check for top of the hour

                If (Now.Minute = 0 And Now.Second = 0 And DateDiff(DateInterval.Second, last_top_of_hour, Now) > 60) Then

                    ' Purge old data

                    removeOldData()

                End If

                ' And for half past

                If (Now.Minute = 30 And Now.Second = 0 And DateDiff(DateInterval.Second, last_half_past, Now) > 60) Then

                    ' Reload database
                    ' Generate database for next 28 days

                    loadDatabase()
                    checkEvents()
                    load28Days()
                    unloadDatabase()
                    Console.WriteLine("Updated - " + Format(Now, "HH:mm:ss dd/MM/yyyy"))

                End If

                ' Sleep

                System.Threading.Thread.Sleep(750)

            End While

        Catch ex As Exception
            ErrorHandler.errorHandler(ex)
        End Try

        ' Enexpected Quit

        Console.WriteLine("")
        Console.WriteLine("Press any key to quit.")
        Console.ReadKey()

    End Sub

    ' Welcome message routine

    Private Sub welcomeMessage()

        Console.Clear()
        Console.WriteLine("AllDay DJ 2 Scheduler Service")
        Console.WriteLine("=============================")
        Console.WriteLine("")
        Console.WriteLine("v" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.MajorRevision & "." & My.Application.Info.Version.MinorRevision)
        Console.WriteLine("Copyright (C) 2007 Marc Steele")
        Console.WriteLine("")
        Console.WriteLine("Loading...")

    End Sub

    ' Load the database

    Private Sub loadDatabase()

        ProgramSettings.events = General.getListOfEvents
        ProgramSettings.playlists = General.getPlaylists
        ProgramSettings.rotations = General.getListOfRotations
        ProgramSettings.spots = General.getListOfSpots

    End Sub

    ' Free up some memory

    Private Sub unloadDatabase()

        ProgramSettings.events.Clear()
        ProgramSettings.playlists.Clear()
        ProgramSettings.rotations.Clear()
        ProgramSettings.spots.Clear()
        ProgramSettings.events = Nothing
        ProgramSettings.playlists = Nothing
        ProgramSettings.rotations = Nothing
        ProgramSettings.spots = Nothing

    End Sub

    ' Generate the hour

    Private Function generateHour(ByVal rotation As Rotation, ByVal length As Double, ByVal prev_hour1 As Playlist, ByVal prev_hour2 As Playlist) As Playlist

        Dim playlist As New Playlist(Nothing, "Temp")
        Dim rot_pos As Integer = -1
        'Dim db_rc As New Database(ProgramSettings.record_collection_location)
        'Dim db_pt As New Database(ProgramSettings.parts_db_location)
        Dim counter As Integer
        Dim selected_playlist As Playlist
        Dim selected_spot As Spot
        Dim random_number As Integer
        Dim item As AudioItem
        Dim temp_counter As Integer
        Dim no_change_count As Integer = 0
        Dim previous_length As Integer
        Dim override_time_req As Boolean = False
        Dim original_length As Double = length

        ' No rotation? don't bother

        If (rotation Is Nothing) Then
            Return Nothing
            Exit Function
        End If

        ' Loop until full
        ' We are allowing for rounding error

        While (length > 0)

            Debug.Print("Time left: " & length & " of " & original_length)

            ' Look for a perpetual loop

            If (playlist.getPlaylistLength = previous_length) Then
                no_change_count += 1
            End If

            If (no_change_count > 3) Then

                ' Ok we've found one, DO NOT PANIC
                ' We will assume that there is nothing that fits in the gap

                override_time_req = True

            End If

            previous_length = playlist.getPlaylistLength

            ' Advance the rotation position

            rot_pos += 1
            If (rot_pos >= rotation.item_id.Count) Then
                rot_pos = 0
            End If

            ' Get the type 

            If (rotation.item_type(rot_pos) = "playlist") Then

                ' Random item from playlist

                selected_playlist = Nothing

                For counter = 0 To (ProgramSettings.playlists.Count) - 1
                    If (ProgramSettings.playlists.Item(counter).getName.Equals(rotation.item_id(rot_pos))) Then
                        selected_playlist = New Playlist(ProgramSettings.playlists.Item(counter))
                    End If
                Next

                ' Only add something if it is the playlist is not nothing :)

                If (Not selected_playlist Is Nothing) Then

                    ' Work our way through the playlist removing items that are not long enough

                    If (Not override_time_req) Then
                        For counter = (selected_playlist.getPlaylistLength - 1) To 0 Step -1
                            If ((selected_playlist.getItem(counter).getTimeEndTrack - selected_playlist.getItem(counter).getTimeStartTrack) > length) Then
                                selected_playlist.removeByIndex(counter)
                            End If
                        Next
                    End If

                    ' Now select an item at random

                    item = Nothing
                    temp_counter = 0

                    While (item Is Nothing) And (temp_counter <= selected_playlist.getPlaylistLength * 2)

                        'item = selected_playlist.getNextRandomItem
                        random_number = (Rnd() * selected_playlist.getPlaylistLength)
                        item = selected_playlist.getItem(random_number)
                        item = General.do2HrCheck(prev_hour1, prev_hour2, playlist, item)
                        temp_counter += 1

                    End While

                    ' Force a selection

                    If item Is Nothing Then

                        'item = selected_playlist.getNextRandomItem
                        random_number = (Rnd() * selected_playlist.getPlaylistLength)
                        item = selected_playlist.getItem(random_number)

                    End If

                    ' Add the item to the playlist

                    If (Not item Is Nothing) Then

                        playlist.addToPlaylist(item)

                        ' Work out the playlist length

                        length = original_length - playlist.getPlaylistLengthTime

                    End If

                End If

            ElseIf (rotation.item_type(rot_pos) = "spot") Then

                ' We're working with a spot

                selected_spot = Nothing

                For counter = 0 To (ProgramSettings.spots.Count - 1)
                    If (ProgramSettings.spots.Item(counter).spot_name.Equals(rotation.item_id)) Then
                        selected_spot = ProgramSettings.spots.Item(counter)
                    End If
                Next

                ' Only do something if the spot exists

                If (Not selected_spot Is Nothing) Then

                    ' We need to find out if it is a set spot or we are working random

                    If (selected_spot.play_as_list) Then

                        ' Go through each of the items and add them

                        For counter = 0 To (selected_spot.playlist.getPlaylistLength - 1)
                            playlist.addToPlaylist(selected_spot.playlist.getItem(counter))
                            length = original_length - playlist.getPlaylistLengthTime
                        Next

                    Else

                        ' Work in random item mode (fun!)

                        playlist.addToPlaylist(selected_spot.playlist.getNextRandomItem)
                        length = original_length - playlist.getPlaylistLengthTime

                    End If

                End If

            End If

        End While

        Return playlist

    End Function

    ' Wrapper for the above
    ' This loads the appropriate rotation (if there is one)
    ' and adjusts times for events

    Private Function generateHourWrapper(ByVal selected_date As Date, ByVal day_number As Integer, ByVal selected_hour As Integer) As Playlist

        Dim counter As Integer
        Dim sub_counter As Integer
        Dim sub_sub_counter As Integer      ' NOW we're just getting silly
        Dim hour(0 To 1) As Playlist
        Dim length As Integer = 3600
        Dim db As New Database(ProgramSettings.parts_db_location)
        Dim rs As OleDb.OleDbDataReader
        Dim rotation As Rotation = Nothing
        Dim temp_event As ScheduledEvent
        Dim flag As Boolean
        Dim temp_playlist As Playlist
        Dim temp_spot As Spot

        ' Get the previous 2 hours

        For counter = 1 To 2

            ' Don't bother if we are day zero and put ourselves back too far in time

            If (day_number = 0 And ((selected_hour - counter) < 0)) Then
                Exit For
            End If

            ' Work out which hour to load

            If ((selected_hour - counter) < 0) Then
                hour(counter - 1) = lo28days.Item(day_number - 1).hour(selected_hour - counter + 24)
            Else
                hour(counter - 1) = lo28days.Item(day_number).hour(selected_hour - counter)
            End If

        Next

        ' Look for any events
        ' We can only calculate fixed events!!!

        For counter = 0 To (ProgramSettings.events.Count - 1)

            ' Check each event (one by one)

            temp_event = ProgramSettings.events.Item(counter)

            ' Check if all of the items are spots

            flag = False

            For sub_counter = 0 To (temp_event.id_list.Count - 1)
                If (temp_event.type_list.Item(sub_counter) = "rotation") Or (temp_event.type_list.Item(sub_counter) = "playlist") Then
                    flag = True
                End If
            Next

            ' Now take action if all spots

            If (Not flag) Then

                ' TODO Work out if the event should be counted for this hour

                If (temp_event.regularity = "Hour" Or (temp_event.regularity = "Day" And temp_event.time.Hour = selected_hour) Or (temp_event.regularity = "Week" And ProgramSettings.day_of_week(temp_event.time.DayOfWeek) = ProgramSettings.day_of_week(Now.DayOfWeek)) Or (temp_event.regularity = "Month" And temp_event.time.Day = selected_date.Day And temp_event.time.Hour = selected_hour) Or DateDiff(DateInterval.Hour, New Date(selected_date.Year, selected_date.Month, selected_date.Day, selected_hour, 0, 0), Now) = 0) Then

                    ' Create and load playlist

                    temp_playlist = New Playlist(Nothing, "TEMP")

                    For sub_counter = 0 To (temp_event.id_list.Count - 1)

                        ' Find the selected spot

                        temp_spot = Nothing

                        For sub_sub_counter = 0 To (ProgramSettings.spots.Count - 1)
                            If (temp_event.id_list.Item(sub_counter) = ProgramSettings.spots.Item(sub_sub_counter).spot_name) Then
                                temp_spot = ProgramSettings.spots.Item(sub_sub_counter)
                            End If
                        Next

                        If (Not temp_spot Is Nothing) Then

                            ' Add the spot to the playlist

                            temp_playlist.appendPlaylist(temp_spot.playlist)

                            ' Now adjust the length

                            length -= temp_playlist.getPlaylistLengthTime()

                        End If

                    Next

                End If

            End If

        Next

        ' Load a rotation (if one exists!)

        If (selected_hour < 10) Then
            Dim query_string = "SELECT [0" & selected_hour & "00] FROM week WHERE day = """ & ProgramSettings.day_of_week(selected_date.DayOfWeek()) & """"
            rs = db.executeRS(query_string)
        Else
            Dim query_string = "SELECT [" & selected_hour & "00] FROM week WHERE day = """ & ProgramSettings.day_of_week(selected_date.DayOfWeek()) & """"
            rs = db.executeRS(query_string)
        End If

        If (Not rs Is Nothing) Then

            ' For every result (there should only be one...)

            While rs.Read
                For counter = 0 To (ProgramSettings.rotations.Count - 1)
                    If (Not rs.IsDBNull(0)) Then
                        If (ProgramSettings.rotations.Item(counter).rotation_name.Equals(rs.GetString(0))) Then
                            rotation = ProgramSettings.rotations.Item(counter)
                        End If
                    End If
                Next
            End While

            ' Close the rs

            rs.Close()
            rs = Nothing

        End If

        ' Close the database connection

        db.disconnect()
        db = Nothing

        ' Go ahead

        Return generateHour(rotation, length, hour(0), hour(1))

    End Function

    ' Load current 28 day block

    Private Sub load28Days()

        Dim counter As Integer
        Dim sub_counter As Integer
        Dim temp_date As Date
        Dim anything_loaded As Boolean

        ' Clear old list

        lo28days = New List(Of Day)

        ' Load 28 days worth of days

        For counter = 0 To 27

            ' Create and load new day

            temp_date = New Date(Now.Year, Now.Month, Now.Day, 0, 0, 0)
            temp_date = temp_date.AddDays(counter)
            lo28days.Add(New Day(temp_date, True))

        Next

        ' Check the 28 days

        For counter = 0 To 27

            ' Reset flag

            anything_loaded = False

            ' Check every hour

            For sub_counter = 0 To 23
                If (Not lo28days.Item(counter).hour(sub_counter) Is Nothing) Then
                    anything_loaded = True
                End If
            Next

            ' Take action as appropriate

            If (Not anything_loaded) Then
                For sub_counter = 0 To 23
                    lo28days.Item(counter).hour(sub_counter) = generateHourWrapper(lo28days.Item(counter).dDate, counter, sub_counter)
                Next
                lo28days.Item(counter).saveNewToDb()
            Else
                lo28days.Item(counter).saveToDb()
            End If

        Next

    End Sub

    ' Check the events

    Private Sub checkEvents()

        Dim counter As Integer
        Dim temp_playlist As Playlist
        Dim sub_counter As Integer
        Dim sub_sub_counter As Integer
        Dim selected_playlist As Playlist
        Dim selected_spot As Spot
        Dim random_item As Integer

        ' Reload events

        ProgramSettings.events = General.getListOfEvents

        ' No events, no checks

        If (ProgramSettings.events.Count = 0) Then
            Exit Sub
        End If

        ' Loop through all of the events

        For counter = 0 To (ProgramSettings.events.Count - 1)

            ' Events that are non-repeating

            If (ProgramSettings.events.Item(counter).regularity.Length = 0) Then
                If (DateDiff(DateInterval.Second, Now, ProgramSettings.events.Item(counter).time) < 0) Then
                    ProgramSettings.events.Item(counter).DeleteEvent()
                End If
            End If

        Next

        ' Clear the old list of events

        Dim db As New Database(ProgramSettings.schedule_db_location)
        db.execute("DELETE * FROM [events]")
        db.disconnect()
        db = Nothing

        ' And again, reload

        ProgramSettings.events = General.getListOfEvents

        ' Build the playlist

        For counter = 0 To (ProgramSettings.events.Count - 1)

            ' Clear the playlist

            temp_playlist = New Playlist(Nothing, "Temp")

            ' Read each item from the event

            For sub_counter = 0 To (ProgramSettings.events.Item(counter).id_list.Count - 1)

                ' Take appropriate action

                If (ProgramSettings.events.Item(counter).type_list.Item(sub_counter).Equals("spot")) Then

                    ' Spot

                    selected_spot = Nothing

                    For sub_sub_counter = 0 To (ProgramSettings.spots.Count - 1)
                        If (ProgramSettings.spots.Item(sub_sub_counter).spot_name.Equals(ProgramSettings.events.Item(counter).id_list(sub_counter))) Then
                            selected_spot = ProgramSettings.spots.Item(sub_sub_counter)
                        End If
                    Next

                    ' Add the spot to the playlist

                    If (Not selected_spot Is Nothing) Then
                        temp_playlist.appendPlaylist(General.spotToPlaylist(selected_spot))
                    End If

                ElseIf (ProgramSettings.events.Item(counter).type_list.Item(sub_counter).Equals("playlist")) Then

                    ' Playlist

                    selected_playlist = Nothing

                    For sub_sub_counter = 0 To (ProgramSettings.playlists.Count - 1)
                        If (ProgramSettings.playlists.Item(sub_sub_counter).getName.Equals(ProgramSettings.events.Item(counter).id_list(sub_counter))) Then
                            selected_playlist = ProgramSettings.playlists.Item(sub_sub_counter)
                        End If
                    Next

                    ' Select one random item from the playlist

                    If (Not selected_playlist Is Nothing) Then
                        temp_playlist.addToPlaylist(selected_playlist.getItem(Rnd() * selected_playlist.getPlaylistLength))
                    End If

                End If

            Next

            ' Set the event's playlist

            ProgramSettings.events.Item(counter).playlist = temp_playlist

        Next

        ' Add the events to the schedule database

        For counter = 0 To (ProgramSettings.events.Count - 1)
            ProgramSettings.events.Item(counter).saveNewEventToDbScheduled()
        Next

    End Sub

    ' Remove the old data

    Private Sub removeOldData()

        ' Delete from the database (using SQL)

        Dim db As New Database(ProgramSettings.schedule_db_location)
        db.execute("DELETE * FROM [schedule] WHERE [date] < """ & Format(New Date(Now.AddDays(-1).Year, Now.AddDays(-1).Month, Now.AddDays(-1).Day, 0, 0, 0), "dd/MM/yyyy") & """")
        db.disconnect()
        db = Nothing

    End Sub

End Module

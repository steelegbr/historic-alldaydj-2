Imports System.IO                               ' File handling

Module General

    ' Time conversion (integer and double overloaded)

    Public Function timeToString(ByVal secs As Integer) As String

        Dim hours As Integer
        Dim mins As Integer
        Dim time As String

        ' Check we have a positive time

        time = ""

        If secs < 0 Then
            time = "-"
            secs = secs * -1
        End If

        ' Calculate the hours

        hours = Int(secs / 3600)
        secs = secs Mod 3600

        ' Calculate the minutes and seconds

        mins = Int(secs / 60)
        secs = secs Mod 60

        ' Now create the time string

        Select Case hours
            Case Is >= 10
                time = time & hours & ":"
            Case Is > 0
                time = time & "0" & hours & ":"
            Case Else
                time = ""
        End Select

        Select Case mins
            Case Is >= 10
                time = time & mins
            Case Else
                time = time & "0" & mins
        End Select

        Select Case secs
            Case Is >= 10
                time = time & ":" & secs
            Case Else
                time = time & ":0" & secs
        End Select

        ' Send back the time

        Return time

    End Function

    Public Function timeToString(ByVal secs As Double) As String

        Dim hours As Integer
        Dim mins As Integer
        Dim time As String
        Dim decimal_pos As Integer

        ' Check we have a positive time

        time = ""

        If secs < 0 Then
            time = "-"
            secs = secs * -1
        End If

        ' Calculate the hours

        hours = Int(secs / 3600)
        secs = secs - (hours * 3600)

        ' Calculate the minutes and seconds

        mins = Int(secs / 60)
        secs = secs - (mins * 60)

        ' Now create the time string

        Select Case hours
            Case Is >= 10
                time = time & hours & ":"
            Case Is > 0
                time = time & "0" & hours & ":"
            Case Else
                time = ""
        End Select

        Select Case mins
            Case Is >= 10
                time = time & mins
            Case Else
                time = time & "0" & mins
        End Select

        Select Case secs
            Case Is >= 10
                time = time & ":" & secs
            Case Else
                time = time & ":0" & secs
        End Select

        ' Now make sure we only have one digit after the decimal

        Try
            decimal_pos = time.LastIndexOf(".")
            time = time.Substring(0, decimal_pos)
        Catch ex As Exception
            ' Do nothing!
        End Try

        ' Send back the time

        Return time

    End Function

    ' Check if a file exists

    Public Function fileExists(ByVal filename As String) As Boolean

        Try
            If (File.Exists(filename) = False) Then
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    ' List of...

    Public Function getListOfSpots() As List(Of Spot)

        Dim temp_list_of_spots As New List(Of Spot)

        ' Connect to the database

        Dim db As New Database(ProgramSettings.parts_db_location)
        Dim rs As OleDb.OleDbDataReader = db.executeRS("SELECT spotid, name FROM spots")

        ' Retrieve the data

        If (Not rs Is Nothing) Then
            While rs.Read
                temp_list_of_spots.Add(New Spot(rs.GetInt32(0), rs.GetString(1)))
            End While
        End If

        ' Close the connection

        rs.Close()
        db.disconnect()
        rs = Nothing
        db = Nothing

        ' Return the data

        Return temp_list_of_spots

    End Function

    Public Function getListOfRotations() As List(Of Rotation)

        Dim temp_list_of_rotations As New List(Of Rotation)

        ' Connect to the database

        Dim db As New Database(ProgramSettings.parts_db_location)
        Dim rs As OleDb.OleDbDataReader = db.executeRS("SELECT rotationid, name FROM rotations")

        ' Retrieve the data

        If (Not rs Is Nothing) Then
            While rs.Read
                temp_list_of_rotations.Add(New Rotation(rs.GetInt32(0), rs.GetString(1)))
            End While
        End If

        ' Close the connection

        rs.Close()
        db.disconnect()
        rs = Nothing
        db = Nothing

        ' Return the data

        Return temp_list_of_rotations

    End Function

    Public Function getListOfEvents() As List(Of ScheduledEvent)

        Dim temp_list_of_events As New List(Of ScheduledEvent)

        ' Connect to the database

        Dim db As New Database(ProgramSettings.parts_db_location)
        Dim rs As OleDb.OleDbDataReader = db.executeRS("SELECT eventid, name FROM events")

        ' Retrieve the data

        If (Not rs Is Nothing) Then
            While rs.Read
                temp_list_of_events.Add(New ScheduledEvent(rs.GetInt32(0), rs.GetString(1)))
            End While
        End If

        ' Close the connection

        rs.Close()
        db.disconnect()
        rs = Nothing
        db = Nothing

        ' Return the data

        Return temp_list_of_events

    End Function

    Public Function getPlaylists() As List(Of Playlist)

        Dim db As New Database(ProgramSettings.record_collection_location)
        Dim tables As DataTable
        Dim dr As DataRow
        Dim playlists As New List(Of Playlist)
        Dim counter As Integer

        tables = db.getTableList

        For Each dr In tables.Rows
            Try
                playlists.Add(New Playlist(Nothing, dr("TABLE_NAME")))
            Catch ex As Exception
                ' Do nothing for now
            End Try
        Next

        db.disconnect()
        db = Nothing

        ' Load the playlists

        For counter = 0 To (playlists.Count - 1)
            General.playlistLoader(playlists.Item(counter))
        Next

        Return playlists

    End Function

    ' Settings loader

    Public Sub settingsLoader()

        Try

            ' Obtain settings from command line

            ProgramSettings.parts_db_location = My.Application.CommandLineArgs(0)
            ProgramSettings.record_collection_location = My.Application.CommandLineArgs(1)
            ProgramSettings.schedule_db_location = My.Application.CommandLineArgs(2)

        Catch ex As Exception
            ErrorHandler.errorHandler(ex)
        End Try


    End Sub

    ' Playlist loader

    Public Sub playlistLoader(ByRef playlist As Playlist)

        Dim items As System.Data.OleDb.OleDbDataReader
        Dim item As AudioItem
        Dim db As New Database(ProgramSettings.record_collection_location)
        Dim item_number As Integer = 0

        ' Clear the current list

        playlist.clear()

        ' Get the list of items

        items = db.executeRS("SELECT * FROM [" & playlist.getName & "]")    ' TODO Replace with trackid

        ' Now load each item

        Try
            While items.Read
                item_number += 1
                'My.Application.DoEvents()
                item = New AudioItem(items.GetValue(0), playlist.getName, False)
                playlist.addToPlaylist(item)
            End While
            items.Close()
        Catch ex As Exception
            ErrorHandler.errorHandler(ex)
        End Try

        ' Randomise

        playlist.randomise()

        ' Close the database

        db.disconnect()
        db = Nothing

    End Sub

    ' 2 hr check

    Public Function do2HrCheck(ByVal prev_hour1 As Playlist, ByVal prev_hour2 As Playlist, ByVal current_hour As Playlist, ByVal item As AudioItem) As AudioItem

        Dim count As Integer = 0
        Dim counter As Integer

        ' We've been passed a bad one

        If (item Is Nothing) Then
            Return item
            Exit Function
        End If

        ' Don't bother with unknown items

        If (item.getArtist.Equals("Unknown") Or item.getArtist.Length = 0) Then
            Return item
        End If

        ' Work our way through the first playlist

        If (Not prev_hour1 Is Nothing) Then
            For counter = 0 To (prev_hour1.getPlaylistLength - 1)
                If (prev_hour1.getItem(counter).getArtist.Equals(item.getArtist)) Then
                    count += 1
                End If
            Next
        End If

        ' And now the second

        If (Not prev_hour2 Is Nothing) Then
            For counter = 0 To (prev_hour2.getPlaylistLength - 1)
                If (prev_hour2.getItem(counter).getArtist.Equals(item.getArtist)) Then
                    count += 1
                End If
            Next
        End If

        ' And the current playlist

        If (Not current_hour Is Nothing) Then
            For counter = 0 To (current_hour.getPlaylistLength - 1)
                If (current_hour.getItem(counter).getArtist.Equals(item.getArtist)) Then
                    count += 1
                End If
            Next
        End If

        ' 3 strikes

        If (count > 2) Then
            Return Nothing
        Else
            Return item
        End If

    End Function

    ' Convert to playlist

    Public Function spotToPlaylist(ByVal spot As Spot) As Playlist

        Dim playlist As New Playlist(Nothing, "Temp")
        Dim random_item As Integer

        ' Single item or multiple

        If (spot.play_as_list) Then

            ' Complete spot

            playlist.appendPlaylist(spot.playlist)

        Else

            ' Single item

            While (playlist.getPlaylistLength = 0)
                random_item = Rnd() * playlist.getPlaylistLength
                playlist.addToPlaylist(spot.playlist.getItem(random_item))
            End While

        End If

        ' Return

        Return playlist

    End Function

End Module


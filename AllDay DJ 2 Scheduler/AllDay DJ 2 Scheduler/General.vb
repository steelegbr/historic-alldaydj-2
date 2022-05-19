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

        While rs.Read
            temp_list_of_spots.Add(New Spot(rs.GetInt32(0), rs.GetString(1)))
        End While

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

        While rs.Read
            temp_list_of_rotations.Add(New Rotation(rs.GetInt32(0), rs.GetString(1)))
        End While

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

        While rs.Read
            temp_list_of_events.Add(New ScheduledEvent(rs.GetInt32(0), rs.GetString(1)))
        End While

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
        Return playlists

    End Function

    ' Settings loader

    Public Sub settingsLoader()

        ' Try obtaining the settings from my.settings

        ProgramSettings.parts_db_location = My.Settings.Item("parts_db_location")
        ProgramSettings.schedule_db_location = My.Settings.Item("schedule_db_location")
        ProgramSettings.record_collection_location = My.Settings.Item("record_collection_location")

        ' Check and load defaults as required

        If (ProgramSettings.parts_db_location.Length = 0) Then
            My.Settings.Item("parts_db_location") = System.AppDomain.CurrentDomain.BaseDirectory & "parts.mdb"
            ProgramSettings.parts_db_location = System.AppDomain.CurrentDomain.BaseDirectory & "parts.mdb"
        End If

        If (ProgramSettings.schedule_db_location.Length = 0) Then
            My.Settings.Item("schedule_db_location") = System.AppDomain.CurrentDomain.BaseDirectory & "schedule.mdb"
            ProgramSettings.schedule_db_location = System.AppDomain.CurrentDomain.BaseDirectory & "schedule.mdb"
        End If

        If (ProgramSettings.record_collection_location.Length = 0) Then
            My.Settings.Item("record_collection_location") = System.AppDomain.CurrentDomain.BaseDirectory & "record_collection.mdb"
            ProgramSettings.schedule_db_location = System.AppDomain.CurrentDomain.BaseDirectory & "record_collection.mdb"
        End If

        My.Settings.Save()

    End Sub


    ' Settings saver


    Public Sub settingsSaver()

        My.Settings.Item("parts_db_location") = ProgramSettings.parts_db_location
        My.Settings.Item("schedule_db_location") = ProgramSettings.schedule_db_location
        My.Settings.Item("record_collection_location") = ProgramSettings.record_collection_location
        My.Settings.Save()

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
                My.Application.DoEvents()
                item = New AudioItem(items.GetValue(0), playlist.getName, False)
                playlist.addToPlaylist(item)
            End While
            items.Close()
        Catch ex As Exception
            ErrorHandler.errorHandler(ex)
        End Try

        ' Close the database

        db.disconnect()
        db = Nothing

    End Sub

End Module


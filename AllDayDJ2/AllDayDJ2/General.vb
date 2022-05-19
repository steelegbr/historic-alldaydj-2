Imports System.IO                               ' File handling
Imports Bass = Un4seen.Bass.Bass                ' Bass sound system reference
Imports FX = Un4seen.Bass.AddOn.Fx.BassFx       ' BassFX
Imports WMA = Un4seen.Bass.AddOn.Wma.BassWma    ' WMA support

Module General

    Private db_record_collection_location As String = "record_collection.mdb"
    Private db_logs_location As String = "logs.mdb"
    Private comparitor As Integer
    Public sound_cards As New List(Of String)
    Public program_settings As New Settings
    Public playlist_message As String = "Loading..."
    Public station_notepad As StationNotepad
    Public play_over_channel As Integer = 0
    Public main_channel As Integer = 0
    Public events_this_hour As List(Of ScheduledEvent)
    Public screen_settings As New ScreenSettings
    Public number_format As System.Globalization.NumberFormatInfo

    Public Function timeToString(ByVal secs As Integer) As String

        Dim hours As Integer
        Dim mins As Integer
        Dim time As String

        On Error Resume Next

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

        On Error Resume Next

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


        decimal_pos = time.LastIndexOf(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
        time = time.Substring(0, decimal_pos)

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

    ' Return the database locations

    Public Function recordCollectionLocation() As String
        Return General.db_record_collection_location
    End Function

    Public Function logsLocation() As String
        Return General.db_logs_location
    End Function

    ' Loads all of the items into a playlist

    Public Sub loadPlaylist(ByRef playlist As Playlist)

        Dim items As System.Data.OleDb.OleDbDataReader
        Dim item As AudioItem
        Dim db As New Database(General.recordCollectionLocation)
        Dim item_number As Integer = 0
        Dim counter As Integer
        Dim non_exist_playlist As New Playlist(Nothing, "NonExist")

        ' Clear the current list

        playlist.clear()

        ' Get the list of items

        items = db.executeRS("SELECT * FROM [" & playlist.getName & "]")    ' TODO Replace with trackid

        ' And pause

        My.Application.DoEvents()

        ' Now load each item

        While items.Read
            Try
                item_number += 1
                frmSplashScreen.setText("Loading playlist " & playlist.getName & Chr(13) & Chr(10) & " (" & item_number & ")")
                frmLoadingPlaylists.Text = "Loading Playlist " & playlist.getName & " (" & item_number & ")"
                Try
                    item = New AudioItem(items.GetInt32(0), playlist.getName, items.GetString(1), items.GetString(2), items.GetString(3), items.GetString(4), items.GetString(5), items.GetString(6), items.GetString(7), items.GetString(8), items.GetDecimal(9), items.GetDecimal(10), items.GetDecimal(11), items.GetDecimal(12), items.GetDecimal(13), items.GetInt32(14), items.GetString(15))
                Catch ex As Exception
                    item = New AudioItem(items.GetInt32(0), playlist.getName, items.GetString(1), items.GetString(2), items.GetString(3), items.GetString(4), "", "", "", items.GetString(8), items.GetDecimal(9), items.GetDecimal(10), items.GetDecimal(11), items.GetDecimal(12), items.GetDecimal(13), items.GetInt32(14), False)
                End Try
                playlist.addToPlaylist(item)

            Catch ex As Exception
                'ErrorHandler.errorHandler(ex)
            End Try
        End While

        items.Close()

        ' Now check each file
        ' Start by finding the dead files

        frmSplashScreen.setText("Checking for dead files...")
        frmLoadingPlaylists.Text = "Checking for dead files..."

        For counter = 0 To (playlist.getPlaylistLength - 1)
            If (Not General.fileExists(playlist.getItem(counter).getFileName)) Then
                non_exist_playlist.addToPlaylist(playlist.getItem(counter))
            End If
        Next

        If (non_exist_playlist.getPlaylistLength > 0) Then

            ' Remove from active list

            For counter = 0 To (non_exist_playlist.getPlaylistLength - 1)
                playlist.removeByItem(non_exist_playlist.getItem(counter))
            Next

            ' Check if we should delete

            If (MsgBox(non_exist_playlist.getPlaylistLength & " items in the " & playlist.getName & " playlist does not exist. Do you wish to delete them from the database?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Deletion") = MsgBoxResult.Yes) Then
                For counter = 0 To (non_exist_playlist.getPlaylistLength - 1)
                    non_exist_playlist.getItem(counter).deleteFromDatabase()
                Next
            End If

        End If

        ' Randomize

        frmSplashScreen.setText("Randomising...")
        frmLoadingPlaylists.Text = "Randomising..."
        playlist.randomise()

        ' Close the database

        db.disconnect()
        db = Nothing

    End Sub

    ' Initialise the sound system

    Public Sub initSound()

        Dim wma As Boolean
        Dim fx As Boolean
        Dim cbrs() As Integer
        Dim counter As Integer = 0

        On Error Resume Next

        ' Registrations

        Un4seen.Bass.BassNet.Registration("steelegbr@gmail.com", "2X28183719152222")

        ' Actual init


        For counter = 1 To (Bass.BASS_GetDeviceCount - 1)
            If Bass.BASS_Init(counter, 44100, Un4seen.Bass.BASSInit.BASS_DEVICE_DEFAULT, 0, Nothing) = False Then
                MsgBox("Error initialising sound cards." & vbCrLf & vbCrLf & "BASS error code " + Bass.BASS_ErrorGetCode(), MsgBoxStyle.Critical, "Error")
                End
            End If
        Next

        For counter = 0 To (Bass.BASS_RecordGetDeviceCount - 1)
            If Bass.BASS_RecordInit(counter) = False Or Bass.BASS_ErrorGetCode > 0 Then
                MsgBox("Error initialising recording options." & vbCrLf & vbCrLf & "BASS error code " + Bass.BASS_ErrorGetCode(), MsgBoxStyle.Critical, "Error")
                End
            End If
        Next

        If Bass.BASS_GetDeviceCount = 0 Or Bass.BASS_RecordGetDeviceCount = 0 Then
            MsgBox("Bass error " & Bass.BASS_ErrorGetCode & ".", MsgBoxStyle.Exclamation, "Error")
        End If

        ' Load plugins (this is a hack for WMA support!)

        cbrs = Un4seen.Bass.AddOn.Wma.BassWma.BASS_WMA_EncodeGetRates(44100, 2, Un4seen.Bass.AddOn.Wma.BASSWMAEncode.BASS_WMA_ENCODE_RATES_CBR)

        General.loadCards()

    End Sub

    ' Load the sound cards

    Public Sub loadCards()

        Dim counter As Integer = 0

        ' Clear the old list

        General.sound_cards.Clear()

        ' Now create the list

        For counter = 1 To (Bass.BASS_GetDeviceCount() - 1)
            General.sound_cards.Add(Bass.BASS_GetDeviceDescription(counter))
        Next

    End Sub

    ' Load the system settings

    Public Sub loadSettings()

        Dim fs As IO.FileStream
        Dim sr As IO.StreamReader
        Dim db_location As String
        Dim logs_location As String
        Dim main_players(0 To 3, 0 To 1) As Integer
        Dim pfl_player(0 To 1) As Integer
        Dim instant_players(0 To 1) As Integer
        Dim counter As Integer
        Dim agc As New Un4seen.Bass.AddOn.Fx.BASS_FX_DSPDAMP
        Dim apply_agc As Boolean
        Dim compressor As New Un4seen.Bass.AddOn.Fx.BASS_FX_DSPCOMPRESSOR
        Dim apply_compressor As Boolean
        Dim fit_in_hour As Boolean
        Dim schedule_location As String
        Dim ducker As Boolean
        Dim ducker_trigger_level As Integer
        Dim ducker_fade_level As Integer
        Dim ducker_attack As Integer
        Dim ducker_release As Integer
        Dim sound_card As Integer
        Dim sound_input As Integer
        Dim schedule_m3u As Boolean
        Dim m3u_folder As String
        Dim m3u_file_name As String
        Dim changed As Boolean = False

        If (General.fileExists(My.Settings.Item("settings_file"))) Then

            Try

                ' Connect to the file

                fs = New IO.FileStream(My.Settings.Item("settings_file"), FileMode.Open, FileAccess.Read)
                sr = New IO.StreamReader(fs)
                sr.BaseStream.Seek(0, SeekOrigin.Begin)

                ' Read the data

                db_location = sr.ReadLine
                logs_location = sr.ReadLine
                For counter = 0 To 3
                    main_players(counter, 0) = sr.ReadLine
                    main_players(counter, 1) = sr.ReadLine
                Next counter
                pfl_player(0) = sr.ReadLine
                pfl_player(1) = sr.ReadLine
                instant_players(0) = sr.ReadLine
                instant_players(1) = sr.ReadLine
                agc.fGain = sr.ReadLine
                agc.fDelay = sr.ReadLine
                agc.fQuiet = sr.ReadLine
                agc.fRate = sr.ReadLine
                agc.fTarget = sr.ReadLine
                apply_agc = sr.ReadLine
                compressor.fAttacktime = sr.ReadLine
                compressor.fReleasetime = sr.ReadLine
                compressor.fThreshold = sr.ReadLine
                apply_compressor = sr.ReadLine
                fit_in_hour = sr.ReadLine
                schedule_location = sr.ReadLine
                ducker = sr.ReadLine
                ducker_trigger_level = sr.ReadLine
                ducker_fade_level = sr.ReadLine
                ducker_attack = sr.ReadLine
                ducker_release = sr.ReadLine
                sound_card = sr.ReadLine
                sound_input = sr.ReadLine
                schedule_m3u = sr.ReadLine
                m3u_folder = sr.ReadLine
                m3u_file_name = sr.ReadLine

                ' Close the file

                sr.Close()
                fs.Close()

                ' Fix schedule location

                If (Not File.Exists(schedule_location) Or schedule_location.Equals("schedule.mdb")) Then
                    schedule_location = System.AppDomain.CurrentDomain.BaseDirectory & "schedule.mdb"
                    changed = True
                End If

                ' Output the settings

                General.program_settings.setSettings(db_location, logs_location, main_players, pfl_player, instant_players, ducker_fade_level, agc, apply_agc, compressor, apply_compressor, fit_in_hour, schedule_location, ducker, ducker_trigger_level, ducker_attack, ducker_release, sound_card, sound_input, schedule_m3u, m3u_folder, m3u_file_name)
                General.db_record_collection_location = db_location
                General.db_logs_location = logs_location

                If (changed) Then
                    General.program_settings.saveSettings(My.Settings.Item("settings_file"))
                End If

            Catch ex As Exception
                MsgBox("An error occurred when trying to access the settings file." & Chr(13) & Chr(10) & ex.Message & Chr(13) & Chr(10) & ex.StackTrace, MsgBoxStyle.Critical, "Error")
                End
            End Try

        Else

            ' Set the defaults

            For counter = 0 To 3
                main_players(counter, 0) = 1
                main_players(counter, 1) = 0
            Next counter
            pfl_player(0) = 1
            pfl_player(1) = 0
            instant_players(0) = 1
            instant_players(1) = 0
            agc.Preset_Medium()
            compressor.Preset_Medium()
            schedule_location = System.AppDomain.CurrentDomain.BaseDirectory & "schedule.mdb"
            ducker = True
            ducker_trigger_level = 50
            ducker_fade_level = 40
            ducker_attack = 100
            ducker_release = 1000
            sound_card = 1
            sound_input = 1
            schedule_m3u = False
            m3u_folder = System.AppDomain.CurrentDomain.BaseDirectory
            m3u_file_name = "yyyy-mm-dd-hh"

            ' And load / save them

            General.program_settings.setSettings(System.AppDomain.CurrentDomain.BaseDirectory & "record_collection.mdb", System.AppDomain.CurrentDomain.BaseDirectory & "\logs.mdb", main_players, pfl_player, instant_players, ducker_fade_level, agc, False, compressor, False, False, schedule_location, ducker, ducker_trigger_level, ducker_attack, ducker_release, sound_card, sound_input, schedule_m3u, m3u_folder, m3u_file_name)
            General.program_settings.saveSettings(System.AppDomain.CurrentDomain.BaseDirectory & "settings.dat")
            My.Settings.Item("settings_file") = System.AppDomain.CurrentDomain.BaseDirectory & "settings.dat"
            My.Settings.Save()

        End If

        ' Station notepad

        General.station_notepad = New StationNotepad(System.AppDomain.CurrentDomain.BaseDirectory & "notepad.dat")

    End Sub

    ' Pan value and drop down box location value interchangers

    Public Function dropDownToPan(ByVal value As Integer) As Integer

        Select Case value
            Case 0
                Return 0
            Case 1
                Return -100
            Case 2
                Return 100
        End Select

    End Function

    Public Function PanToDropDown(ByVal value As Integer) As Integer

        Select Case value
            Case 0
                Return 0
            Case -100
                Return 1
            Case 100
                Return 2
        End Select

    End Function

    ' Auto import function

    Public Function autoImport(ByRef file_name As String, ByRef db_table As String, ByRef title As String) As AudioItem

        Dim item As New AudioItem(file_name)
        Dim channel As Long
        Dim lc_file_name As String
        Dim start_point As Double
        Dim end_point As Double

        ' Check if the item is already in the database

        If (General.inDatabase(file_name)) Then
            Return Nothing
            Exit Function
        End If

        ' Load the item

        lc_file_name = file_name.ToLower()
        If (Not Right(lc_file_name, 3).Equals("wma")) Then
            channel = Bass.BASS_StreamCreateFile(file_name, 0, 0, Un4seen.Bass.BASSStream.BASS_STREAM_DECODE)
        Else
            channel = WMA.BASS_WMA_StreamCreateFile(file_name, 0, 0, Un4seen.Bass.BASSStream.BASS_STREAM_DECODE)
        End If

        ' Check the item has loaded

        If (channel = 0) Then
            'MsgBox("Unable to load into player.\nBass error " + Bass.BASS_ErrorGetCode + ".", "Import Error")   ' REMOVE ERROR DEBUG
            Return Nothing
        End If

        ' Show the update screen

        frmTrackPos.loadItem(channel, file_name, title)
        frmTrackPos.Show()

        ' Get the start point

        While (Bass.BASS_ChannelGetLevel(channel) = 0)
            ' Do nothing
        End While

        start_point = Bass.BASS_ChannelBytes2Seconds(channel, Bass.BASS_ChannelGetPosition(channel))

        ' Get the end point

        While (Bass.BASS_ChannelGetPosition(channel) < Bass.BASS_ChannelGetLength(channel))
            My.Application.DoEvents()
            If (Un4seen.Bass.Utils.LowWord(Bass.BASS_ChannelGetLevel(channel)) >= 16384) Then
                end_point = Bass.BASS_ChannelBytes2Seconds(channel, Bass.BASS_ChannelGetPosition(channel))
            End If
        End While

        ' Close the update screen

        frmTrackPos.unloadItem()
        frmTrackPos.Hide()

        ' Set the settings

        item.setDBTable(db_table)

        item = General.autoAttributes(item, start_point, end_point, channel)
        If (Not item Is Nothing) Then
            item.saveNew()
        Else
            'MsgBox("NULL RETURN FROM AUTO ATTRIBUTES!!!", "Import Error")   ' REMOVE ERROR DEBUG
        End If

        ' Unload the channel

        Bass.BASS_StreamFree(channel)

        ' Return and quit

        Return item

    End Function

    ' Automatic attributes function

    Private Function autoAttributes(ByRef item As AudioItem, ByVal start_pos As Double, ByVal end_pos As Double, ByVal channel As Long) As AudioItem

        Dim tag_info As Un4seen.Bass.AddOn.Tags.TAG_INFO
        Dim split() As String

        ' Start by trying to parse the tags

        tag_info = Un4seen.Bass.AddOn.Tags.BassTags.BASS_TAG_GetFromFile(item.getFileName)
        If (Not tag_info Is Nothing) Then
            item.setAttributes(fixTag(tag_info.artist.Trim), fixTag(tag_info.title.Trim), fixTag(tag_info.album.Trim), "000000", fixTag(tag_info.composer.Trim), fixTag(tag_info.publisher.Trim), fixTag(tag_info.comment.Trim), 2, False, start_pos, start_pos, start_pos, end_pos, end_pos)
            Return item
            Exit Function
        End If

        ' Otherwise try the file name

        Dim file_name As String = item.getFileName
        file_name = file_name.Substring(file_name.LastIndexOf("\") + 1)
        file_name = file_name.Substring(0, file_name.LastIndexOf("."))
        split = file_name.Split(New String(" - "))

        If (split.Length <= 2) Then
            item.setAttributes(split(0).Trim, split(1).Trim, "Unknown", "000000", "Unknown", "Unknown", "", 2, False, start_pos, start_pos, start_pos, end_pos, end_pos)
        Else
            split = file_name.Split(New String("-"))
            If (split.Length = 3) Then
                item.setAttributes(split(0).Trim, split(1).Trim, "Unknown", "000000", "Unknown", "Unknown", "", 2, False, start_pos, start_pos, start_pos, end_pos, end_pos)
            Else
                item.setAttributes("Unknown", file_name.Trim, "Unknown", "000000", "Unknown", "Unknown", "", 2, False, start_pos, start_pos, start_pos, end_pos, end_pos)
            End If
        End If

        ' Return the item

        Return item

    End Function

    ' Check if the item is already in the database

    Public Function inDatabase(ByRef file_name As String)

        Dim counter As Integer
        Dim sub_counter As Integer
        Dim item As AudioItem
        Dim playlists As List(Of Playlist) = frmMain.getPlaylists

        ' Cycle through all playlists

        For counter = 0 To (playlists.Count - 1)
            For sub_counter = 0 To (playlists.Item(counter).getPlaylistLength - 1)
                item = playlists.Item(counter).getItem(sub_counter)
                If (item.getFileName.Equals(file_name)) Then
                    Return True
                End If
            Next
        Next

        Return False

    End Function

    ' Load the rotation

    Public Sub loadRotation(ByVal existing As List(Of Playlist))

        Dim fs As IO.FileStream
        Dim sr As IO.StreamReader
        Dim rotation As New List(Of String)
        Dim exists As Boolean = False

        ' Connect to the file

        fs = New IO.FileStream(System.AppDomain.CurrentDomain.BaseDirectory & "rotation.dat", FileMode.OpenOrCreate)
        sr = New IO.StreamReader(fs)

        ' Get the data from the file

        While Not sr.EndOfStream
            rotation.Add(sr.ReadLine)
        End While

        ' Close the file

        sr.Close()
        fs.Close()
        sr = Nothing
        fs = Nothing

        ' Check for zero length

        If (rotation.Count = 0) Then
            rotation.Add("Unsorted Items")
        End If

        ' Check every entry for existance

        ' For Each entry In rotation

        'exists = False

        ' Check if it exists

        'For counter = 0 To (existing.Count - 1)
        'If (entry.Equals(existing.Item(counter).getName)) Then
        'exists = True
        'End If
        'Next

        ' If not, remove it from the rotation

        'If (Not exists) Then
        'rotation.Remove(entry)
        'End If

        'Next

        ' Update the global settings

        General.program_settings.setRotation(rotation)
        General.saveRotation()

    End Sub

    ' Save the rotation

    Public Sub saveRotation()

        Dim fs As IO.FileStream
        Dim sw As IO.StreamWriter
        Dim item As String
        Dim rotation As List(Of String)

        ' Get the rotaion

        rotation = General.program_settings.getRotation

        ' Open the file to write

        fs = New IO.FileStream(System.AppDomain.CurrentDomain.BaseDirectory & "rotation.dat", FileMode.Create)
        sw = New StreamWriter(fs)

        ' Write to the file

        For Each item In rotation
            sw.WriteLine(item)
        Next

        ' Close the file

        sw.Close()
        fs.Close()
        sw = Nothing
        fs = Nothing

    End Sub

    ' Ducker

    Public Sub doDucker()

        On Error Resume Next

        Dim current_level As Integer
        Dim current_l As Integer
        Dim current_r As Integer
        Dim trigger_level As Integer = (32768 * General.program_settings.getDuckerTriggerLevel) / 200

        ' Get the current (over) level
        ' We will go with the highest single channel

        current_level = Bass.BASS_ChannelGetLevel(General.play_over_channel)
        current_l = Un4seen.Bass.Utils.LowWord(current_level)
        current_r = Un4seen.Bass.Utils.HighWord(current_level)
        If (current_l > current_r) Then
            current_level = current_l
        Else
            current_level = current_r
        End If

        ' Compare and duck as appropriate

        If (current_level >= trigger_level) Then
            Bass.BASS_ChannelSlideAttributes(General.main_channel, -1, General.program_settings.getDuckerFadeLevel, -101, 100)
        Else
            Bass.BASS_ChannelSlideAttributes(General.main_channel, -1, 100, -101, 1000)
        End If

    End Sub

    ' List of events

    Public Function getListOfEvents() As List(Of ScheduledEvent)

        Dim temp_list_of_events As New List(Of ScheduledEvent)

        ' Connect to the database

        Dim db As New Database(General.program_settings.getScheduleLocation)
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

    ' Set and get the comparitor

    Public Sub setComparitor(ByVal comparitor As Integer)

        General.comparitor = comparitor

    End Sub

    ' Check if something is a break item

    Public Function checkBreakItem(ByVal item As AudioItem) As Boolean

        On Error Resume Next

        Dim break_item As BreakItem = Nothing
        break_item = item
        If (break_item Is Nothing) Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Function fixTag(ByVal tag As String) As String

        Dim current As Char
        Dim fixed As String = ""

        For Each current In tag.ToCharArray
            If Not (current = Nothing) Then
                fixed = fixed & current
            End If
        Next

        Return fixed

    End Function

    Public Sub internationalise()

        ' Internationalise

        number_format = Globalization.CultureInfo.InstalledUICulture.NumberFormat.Clone
        number_format.NumberDecimalSeparator = "."
        number_format.NumberGroupSeparator = ","

    End Sub

End Module


Imports Bass = Un4seen.Bass.Bass                ' Audio system
Imports WMA = Un4seen.Bass.AddOn.Wma.BassWma    ' WMA Support

Public Class frmInstantPlayers

    Private file_locations(0 To 8) As TextBox
    Private browse_buttons(0 To 8) As Button
    Private clear_buttons(0 To 8) As Button

    ' Load the data from the current instant players

    Public Sub loadCurrent(ByRef instant_players() As Player)

        Dim counter As Integer
        Dim ai As AudioItem

        ' Try obtaining the file name
        ' Just skip over if there is nothing in that player

        On Error Resume Next

        For counter = 0 To 8
            ai = instant_players(counter).getItem
            If (Not ai.Equals(Nothing)) Then
                Me.file_locations(counter).Text = ai.getFileName
            End If
        Next

    End Sub

    ' File browsing

    Private Sub file_browse(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrowse1.Click, btnBrowse2.Click, btnBrowse3.Click, btnBrowse4.Click, btnBrowse5.Click, btnBrowse6.Click, btnBrowse7.Click, btnBrowse8.Click, btnBrowse9.Click

        Dim counter As Integer
        Dim file_name As String
        Dim lc_file_name As String
        Dim channel As Long

        ' Get the file

        Me.ofdAudioFiles.ShowDialog()
        file_name = Me.ofdAudioFiles.FileName

        ' Check the file can be opened

        If (Not General.fileExists(file_name)) Then
            MsgBox("The file you selected does not exist." & Chr(10) & Chr(13) & "Please select another file.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        ' Different loading method for WMA

        lc_file_name = file_name.ToLower()

        If (lc_file_name.EndsWith("wma")) Then
            channel = WMA.BASS_WMA_StreamCreateFile(file_name, 0, 0, 0)
        Else
            channel = Bass.BASS_StreamCreateFile(file_name, 0, 0, 0)
        End If

        If (channel = 0) Then
            MsgBox("The file you selected cannot be loaded." & Chr(10) & Chr(13) & "Please select another file.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        ' If it is valid and loadable unload and display onscreen

        Bass.BASS_StreamFree(channel)

        For counter = 0 To 8
            If (sender.Equals(Me.browse_buttons(counter))) Then
                Me.file_locations(counter).Text = file_name
            End If
        Next

    End Sub

    ' Clear all

    Private Sub btnClearAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClearAll.Click

        Dim counter As Integer

        For counter = 0 To 8
            Me.file_locations(counter).Text = ""
        Next

    End Sub

    ' Shift the focus (do not allow direct editing)

    Private Sub shiftFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbFile1.GotFocus, tbFile2.GotFocus, tbFile3.GotFocus, tbFile4.GotFocus, tbFile5.GotFocus, tbFile6.GotFocus, tbFile7.GotFocus, tbFile8.GotFocus, tbFile9.GotFocus

        Dim counter As Integer

        For counter = 0 To 8
            If (sender.Equals(Me.file_locations(counter))) Then
                Me.browse_buttons(counter).Focus()
            End If
        Next

    End Sub

    ' Clear a single entry

    Private Sub clearSingle(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear1.Click, btnClear2.Click, btnClear3.Click, btnClear4.Click, btnClear5.Click, btnClear6.Click, btnClear7.Click, btnClear8.Click, btnClear9.Click

        Dim counter As Integer

        For counter = 0 To 8
            If (sender.Equals(Me.clear_buttons(counter))) Then
                Me.file_locations(counter).Text = ""
            End If
        Next

    End Sub

    ' Load time operations

    Private Sub frmInstantPlayers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Create the control arrays

        file_locations(0) = Me.tbFile1
        file_locations(1) = Me.tbFile2
        file_locations(2) = Me.tbFile3
        file_locations(3) = Me.tbFile4
        file_locations(4) = Me.tbFile5
        file_locations(5) = Me.tbFile6
        file_locations(6) = Me.tbFile7
        file_locations(7) = Me.tbFile8
        file_locations(8) = Me.tbFile9

        browse_buttons(0) = Me.btnBrowse1
        browse_buttons(1) = Me.btnBrowse2
        browse_buttons(2) = Me.btnBrowse3
        browse_buttons(3) = Me.btnBrowse4
        browse_buttons(4) = Me.btnBrowse5
        browse_buttons(5) = Me.btnBrowse6
        browse_buttons(6) = Me.btnBrowse7
        browse_buttons(7) = Me.btnBrowse8
        browse_buttons(8) = Me.btnBrowse9

        clear_buttons(0) = Me.btnClear1
        clear_buttons(1) = Me.btnClear2
        clear_buttons(2) = Me.btnClear3
        clear_buttons(3) = Me.btnClear4
        clear_buttons(4) = Me.btnClear5
        clear_buttons(5) = Me.btnClear6
        clear_buttons(6) = Me.btnClear7
        clear_buttons(7) = Me.btnClear8
        clear_buttons(8) = Me.btnClear9

    End Sub

    ' Update the list

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim file_names(0 To 8) As String
        Dim audio_items(0 To 8) As AudioItem
        Dim counter As Integer

        ' Get the list of file names
        ' And create the audio items in one step

        For counter = 0 To 8
            file_names(counter) = Me.file_locations(counter).Text
            audio_items(counter) = New AudioItem(file_names(counter))
        Next

        ' Now transfer the list to the main form

        frmMain.loadIPs(audio_items)

        ' And close

        Me.Close()

    End Sub
End Class

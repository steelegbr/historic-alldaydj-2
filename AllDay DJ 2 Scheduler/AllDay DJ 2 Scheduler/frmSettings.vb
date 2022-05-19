Public Class frmSettings

    ' Browse for files

    Private Sub btnPartsBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPartsBrowse.Click

        Dim file_name As String

        ' Get the file name

        Me.ofdParts.ShowDialog()
        file_name = Me.ofdParts.FileName

        ' Check the file name

        If (file_name.Length = 0) Then
            Exit Sub
        End If

        ' Now load the file

        Me.tbPartsLocation.Text = file_name

    End Sub

    Private Sub btnScheduleBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnScheduleBrowse.Click

        Dim file_name As String

        ' Get the file name

        Me.ofdSchedule.ShowDialog()
        file_name = Me.ofdSchedule.FileName

        ' Check the file name

        If (file_name.Length = 0) Then
            Exit Sub
        End If

        ' Now load the file

        Me.tbScheduleLocation.Text = file_name

    End Sub

    Private Sub btnAllDayDj2Browse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAllDayDj2Browse.Click

        Dim file_name As String

        ' Get the file name

        Me.ofdAllDayDJ2Database.ShowDialog()
        file_name = Me.ofdAllDayDJ2Database.FileName

        ' Check the file name

        If (file_name.Length = 0) Then
            Exit Sub
        End If

        ' Now load the file

        Me.tbAllDayDj2Location.Text = file_name

    End Sub

    ' DO NOT allow users to edit the text boxes

    Private Sub tbPartsLocation_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbPartsLocation.GotFocus

        Me.btnPartsBrowse.Focus()

    End Sub

    Private Sub tbScheduleLocation_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbScheduleLocation.GotFocus

        Me.btnScheduleBrowse.Focus()

    End Sub

    Private Sub tbAllDayDj2Location_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbAllDayDj2Location.GotFocus

        Me.btnAllDayDj2Browse.Focus()

    End Sub

    ' Load time events

    Private Sub frmSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Load current locations

        Me.tbPartsLocation.Text = ProgramSettings.parts_db_location
        Me.tbScheduleLocation.Text = ProgramSettings.schedule_db_location
        Me.tbAllDayDj2Location.Text = ProgramSettings.record_collection_location

    End Sub

    ' Save the settings

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim parts As String
        Dim schedule As String
        Dim record_collection As String

        ' Get the values from the boxes

        parts = Me.tbPartsLocation.Text
        schedule = Me.tbScheduleLocation.Text
        record_collection = Me.tbAllDayDj2Location.Text

        ' Check for zero length

        If (parts.Length = 0 Or schedule.Length = 0 Or record_collection.Length = 0) Then
            MsgBox("Could not save settings." & Chr(13) & Chr(10) & "Pleae check the values entered and try again.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        ' Save the settings

        ProgramSettings.parts_db_location = parts
        ProgramSettings.record_collection_location = record_collection
        ProgramSettings.schedule_db_location = schedule

        My.Settings.parts_db_location = parts
        My.Settings.record_collection_location = record_collection
        My.Settings.schedule_db_location = schedule

        My.Settings.Save()

        ' Close the screen

        Me.Close()

    End Sub

End Class
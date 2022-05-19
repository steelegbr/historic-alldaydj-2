Public Class frmEditEvent

    Dim scheduled_event As ScheduledEvent

    ' Load the event in

    Public Sub loadEvent(ByVal scheduled_event As ScheduledEvent)

        Dim counter As Integer

        ' Set the event

        Me.scheduled_event = scheduled_event
        Me.Text = "Edit Event - " & Me.scheduled_event.name
        Me.chkForce.Checked = Me.scheduled_event.force

        ' Update the display

        Me.updateDisplay()

        ' Event time

        If (Me.scheduled_event.regularity.Length = 0) Then
            Me.rbOnceAt.Checked = True
            Me.dtpRunOnceDate.Value = Me.scheduled_event.time
            Me.dtpRunOnceTime.Value = Me.scheduled_event.time
            Exit Sub
        End If

        ' Regular event

        If (Me.scheduled_event.regularity.StartsWith("--")) Then
            Me.cmbRegularity.SelectedIndex = 0
        Else
            For counter = 0 To (Me.cmbRegularity.Items.Count - 1)
                If (Me.cmbRegularity.Items.Item(counter).ToString.Equals(Me.scheduled_event.regularity)) Then
                    Me.cmbRegularity.SelectedIndex = counter
                End If
            Next
        End If

        Me.dtpRepeatDate.Value = Me.scheduled_event.time
        Me.dtpRepeatTime.Value = Me.scheduled_event.time
        Me.rbRepeat.Checked = True
        Me.updateTimeDisplay()

    End Sub

    ' Updates the display

    Private Sub updateDisplay()

        Dim counter As Integer

        ' Clear

        Me.lbItems.Items.Clear()

        ' Re-load list

        For counter = 0 To (Me.scheduled_event.id_list.Count - 1)
            Me.lbItems.Items.Add(Me.scheduled_event.id_list(counter) & " [" & Me.scheduled_event.type_list(counter) & "]")
        Next

    End Sub

    Private Sub updateTimeDisplay()

        Dim repeat As Boolean

        ' Check if it is a repeating item

        repeat = Me.rbRepeat.Checked

        ' Take appropriate action

        If (repeat) Then

            ' Enable / Disable controls

            Me.cmbRegularity.Enabled = True
            Me.dtpRepeatDate.Enabled = True
            Me.dtpRepeatTime.Enabled = True
            Me.dtpRunOnceDate.Enabled = False
            Me.dtpRunOnceTime.Enabled = False

            ' Perform cmb action

            Me.cmbRegularity_SelectedIndexChanged(Nothing, Nothing)

        Else

            Me.cmbRegularity.Enabled = False
            Me.dtpRepeatDate.Enabled = False
            Me.dtpRepeatTime.Enabled = False
            Me.dtpRunOnceDate.Enabled = True
            Me.dtpRunOnceTime.Enabled = True

        End If

    End Sub

    ' Change on pull down menu

    Private Sub cmbRegularity_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRegularity.SelectedIndexChanged

        Dim selected_item As String
        Dim selected_index As Integer

        ' Get the selected item

        selected_item = Me.cmbRegularity.Text

        ' Zero length

        If (selected_item.Length = 0) Then
            Exit Sub
        End If

        ' Non-acceptable object

        If (selected_item.StartsWith("--")) Then
            Me.dtpRepeatDate.Enabled = False
            Me.dtpRepeatTime.Enabled = False
            Exit Sub
        End If

        ' Get the selected index

        selected_index = Me.cmbRegularity.SelectedIndex

        ' Activate controls as appropriate

        If (selected_index = 1) Then

            ' Year

            Me.dtpRepeatDate.Enabled = True
            Me.dtpRepeatTime.Enabled = True
            Me.dtpRepeatDate.Format = DateTimePickerFormat.Long
            Me.dtpRepeatTime.Format = DateTimePickerFormat.Time

        ElseIf (selected_index >= 3 And selected_index <= 14) Then

            ' Month

            Me.dtpRepeatDate.Enabled = True
            Me.dtpRepeatTime.Enabled = True
            Me.dtpRepeatDate.Format = DateTimePickerFormat.Custom
            Me.dtpRepeatTime.Format = DateTimePickerFormat.Time
            Me.dtpRepeatDate.CustomFormat = "dd"

        ElseIf (selected_index >= 16 And selected_index <= 22) Then

            ' Day (weekly)

            Me.dtpRepeatDate.Enabled = False
            Me.dtpRepeatTime.Enabled = True
            Me.dtpRepeatDate.Format = DateTimePickerFormat.Long
            Me.dtpRepeatTime.Format = DateTimePickerFormat.Time

        ElseIf (selected_index = 24) Then

            ' Daily

            Me.dtpRepeatDate.Enabled = False
            Me.dtpRepeatTime.Enabled = True
            Me.dtpRepeatDate.Format = DateTimePickerFormat.Long
            Me.dtpRepeatTime.Format = DateTimePickerFormat.Time

        ElseIf (selected_index = 25) Then

            ' Hourly

            Me.dtpRepeatDate.Enabled = False
            Me.dtpRepeatTime.Enabled = True
            Me.dtpRepeatDate.Format = DateTimePickerFormat.Long
            Me.dtpRepeatTime.Format = DateTimePickerFormat.Custom
            Me.dtpRepeatTime.CustomFormat = "mm:ss"

        End If

    End Sub

    ' Radio buttons

    Private Sub rbOnceAt_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbOnceAt.CheckedChanged

        Dim value As Boolean

        ' Get the value

        value = Me.rbOnceAt.Checked

        ' Activate / disactivate controls

        Me.dtpRunOnceDate.Enabled = value
        Me.dtpRunOnceTime.Enabled = value
        Me.rbRepeat.Checked = Not value

    End Sub

    Private Sub rbRepeat_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbRepeat.CheckedChanged


        Dim value As Boolean

        ' Get the value

        value = Me.rbRepeat.Checked

        ' Activate / disactivate controls

        Me.cmbRegularity.Enabled = value
        Me.rbOnceAt.Checked = Not value

        If (value) Then
            Me.cmbRegularity_SelectedIndexChanged(Nothing, Nothing)
        End If

    End Sub

    ' Add to the event

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        frmAddToEvent.Show()

    End Sub

    ' Remove from the event

    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        Dim selected_index As Integer

        ' Get the selected index

        selected_index = Me.lbItems.SelectedIndex
        If (selected_index < 0) Then
            Exit Sub
        End If

        ' Remove the item

        Me.scheduled_event.id_list.RemoveAt(selected_index)
        Me.scheduled_event.type_list.RemoveAt(selected_index)

        ' Update onscreen

        Me.updateDisplay()

    End Sub

    ' Add to the event (from user selection)

    Public Sub addToEvent(ByVal spot As Spot)

        Me.scheduled_event.id_list.Add(spot.spot_name)
        Me.scheduled_event.type_list.Add("spot")
        Me.updateDisplay()

    End Sub

    Public Sub addToEvent(ByVal playlist As Playlist)

        Me.scheduled_event.id_list.Add(playlist.getName)
        Me.scheduled_event.type_list.Add("playlist")
        Me.updateDisplay()

    End Sub

    ' Load time events

    Private Sub frmEditEvent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cmbRegularity.SelectedIndex = 0

    End Sub

    ' Save the changes

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim mode As Boolean

        ' Get the mode

        mode = Me.rbOnceAt.Checked

        ' Do as appropriate

        If (mode) Then

            ' Run once

            Me.scheduled_event.regularity = ""
            Me.scheduled_event.time = New Date(Me.dtpRunOnceDate.Value.Year, Me.dtpRunOnceDate.Value.Month, Me.dtpRunOnceDate.Value.Day, Me.dtpRunOnceTime.Value.Hour, Me.dtpRunOnceTime.Value.Minute, Me.dtpRunOnceTime.Value.Second)
            Me.scheduled_event.force = Me.chkForce.Checked
            Me.scheduled_event.saveToDb()
            frmMain.updateDisplay()
            Me.Close()
            Me.Dispose()

        Else

            ' Repeating
            ' Check values

            If (Me.cmbRegularity.Text.StartsWith("--")) Then
                MsgBox("No valid repetition selected." & Chr(13) & Chr(10) & "Please select a valid repetition from the drop down list.", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If

            ' Update and save

            Me.scheduled_event.regularity = Me.cmbRegularity.Text
            Me.scheduled_event.time = New Date(Me.dtpRepeatDate.Value.Year, Me.dtpRepeatDate.Value.Month, Me.dtpRepeatDate.Value.Day, Me.dtpRepeatTime.Value.Hour, Me.dtpRepeatTime.Value.Minute, Me.dtpRepeatTime.Value.Second)
            Me.scheduled_event.force = Me.chkForce.Checked
            Me.scheduled_event.saveToDb()
            frmMain.updateDisplay()
            Me.Close()
            Me.Dispose()

        End If

    End Sub

End Class
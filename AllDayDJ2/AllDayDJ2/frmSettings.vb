Imports Bass = Un4seen.Bass.Bass

Public Class frmSettings

    ' Unload this screen

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    ' Load time events

    Private Sub frmSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim counter As Integer
        On Error Resume Next

        ' Create list of sound cards

        'Try
        For counter = 0 To (General.sound_cards.Count - 1)
            Me.cmbCards1.Items.Add(General.sound_cards.Item(counter))
            Me.cmbCards2.Items.Add(General.sound_cards.Item(counter))
            Me.cmbCards3.Items.Add(General.sound_cards.Item(counter))
            Me.cmbCards4.Items.Add(General.sound_cards.Item(counter))
            Me.cmbIP.Items.Add(General.sound_cards.Item(counter))
            Me.cmbPFL.Items.Add(General.sound_cards.Item(counter))
            Me.cmbSoundCard.Items.Add(General.sound_cards.Item(counter))
        Next
        'Catch ex As Exception
        ' Do nothing
        ' This just catches as the system tends to overcount
        'End Try

        ' Screens

        Me.cmbScreenMain.Items.Clear()
        Me.cmbScreenLibrary.Items.Clear()
        Me.cmbScreenMixer.Items.Clear()

        For counter = 0 To (Screen.AllScreens.Length - 1)
            Me.cmbScreenMain.Items.Add(Screen.AllScreens(counter).DeviceName)
            Me.cmbScreenLibrary.Items.Add(Screen.AllScreens(counter).DeviceName)
            Me.cmbScreenMixer.Items.Add(Screen.AllScreens(counter).DeviceName)
        Next

    End Sub

    ' Log file location

    Private Sub btnLogsBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogsBrowse.Click

        Dim file_name As String

        Me.ofdLogsLocation.ShowDialog()
        file_name = Me.ofdLogsLocation.FileName

        If (file_name.Length > 0) Then
            Me.tbLogsLocation.Text = file_name
        End If

    End Sub

    ' Settings file location

    Private Sub btnBrowseSettingsFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseSettingsFile.Click

        Dim file_name As String

        Me.ofdSettingsFile.ShowDialog()
        file_name = Me.ofdSettingsFile.FileName

        If (file_name.Length > 0) Then
            Me.tbSettingsFile.Text = file_name
        End If

    End Sub

    Private Sub btnDbBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDbBrowse.Click

        Dim file_name As String

        Me.ofdDBLocation.ShowDialog()
        file_name = Me.ofdDBLocation.FileName

        If (file_name.Length > 0) Then
            Me.tbDbLocation.Text = file_name
        End If

    End Sub

    Private Sub btnScheduleBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnScheduleBrowse.Click

        Dim file_name As String

        Me.ofdScheduleLocation.ShowDialog()
        file_name = Me.ofdScheduleLocation.FileName

        If (file_name.Length > 0) Then
            Me.tbScheduleLocation.Text = file_name
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim db_location As String
        Dim settings_location As String
        Dim logs_location As String
        Dim schedule_location As String
        Dim main_players(0 To 3, 0 To 1) As Integer
        Dim pfl_player(0 To 1) As Integer
        Dim instant_players(0 To 1) As Integer
        Dim counter As Integer
        Dim local As New Settings
        Dim agc As New Un4seen.Bass.AddOn.Fx.BASS_FX_DSPDAMP
        Dim apply_agc As Boolean
        Dim compressor As New Un4seen.Bass.AddOn.Fx.BASS_FX_DSPCOMPRESSOR
        Dim apply_compressor As Boolean
        Dim fit_in_hour As Boolean
        Dim ducker As Boolean
        Dim ducker_fade_level As Integer
        Dim ducker_trigger_level As Integer
        Dim ducker_attack As Integer
        Dim ducker_release As Integer
        Dim sound_card As Integer
        Dim sound_input As Integer
        Dim schedule_m3u As Boolean
        Dim m3u_folder As String
        Dim m3u_file_name As String

        Try

            ' Get and test the file locations

            db_location = Me.tbDbLocation.Text
            settings_location = Me.tbSettingsFile.Text
            logs_location = Me.tbLogsLocation.Text
            schedule_location = Me.tbScheduleLocation.Text

            If (db_location.Length = 0) Then
                MsgBox("No database selected. Please select a database and try again.", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If

            If (settings_location.Length = 0) Then
                MsgBox("No settings file selected. Please select a settings file and try again.", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If

            If (logs_location.Length = 0) Then
                MsgBox("No log file selected. Please select a log file and try again.", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If

            If (schedule_location.Length = 0) Then
                MsgBox("No schedule file selected. Please select a schedule file and try again.", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If

            If (Not General.fileExists(db_location)) Then
                MsgBox("Database file not found. Please select a valid file.", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If

            If (Not General.fileExists(settings_location)) Then
                MsgBox("Settings file not found. Please select a valid file.", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If

            If (Not General.fileExists(logs_location)) Then
                MsgBox("Log file not found. Please select a valid file.", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If

            If (Not General.fileExists(schedule_location)) Then
                MsgBox("Scheudle file not found. Please select a valid file.", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If

            ' Obtain the sound hardware settings

            main_players(0, 0) = Me.cmbCards1.SelectedIndex + 1
            main_players(1, 0) = Me.cmbCards2.SelectedIndex + 1
            main_players(2, 0) = Me.cmbCards3.SelectedIndex + 1
            main_players(3, 0) = Me.cmbCards4.SelectedIndex + 1
            main_players(0, 1) = Me.cmbPan1.SelectedIndex
            main_players(1, 1) = Me.cmbPan2.SelectedIndex
            main_players(2, 1) = Me.cmbPan3.SelectedIndex
            main_players(3, 1) = Me.cmbPan4.SelectedIndex
            pfl_player(0) = Me.cmbPFL.SelectedIndex + 1
            pfl_player(1) = Me.cmbPanPFL.SelectedIndex
            instant_players(0) = Me.cmbIP.SelectedIndex + 1
            instant_players(1) = Me.cmbPanPFL.SelectedIndex
            sound_card = Me.cmbSoundCard.SelectedIndex + 1
            sound_input = Me.cmbInput.SelectedIndex + 1

            ' Get the actual pan values

            For counter = 0 To 3
                main_players(counter, 1) = General.dropDownToPan(main_players(counter, 1))
            Next

            pfl_player(1) = General.dropDownToPan(pfl_player(1))
            instant_players(1) = General.dropDownToPan(instant_players(1))

            ' Get the AGC settings

            agc.fDelay = Me.sldDelay.Value / 1000
            agc.fGain = Me.sldGain.Value
            agc.fQuiet = Me.sldMin.Value / 100
            agc.fRate = Me.sldRate.Value / 1000
            agc.fTarget = Me.sldTarget.Value / 100
            apply_agc = Me.chkEnableAGC.Checked

            ' Compressor settings

            compressor.fAttacktime = Me.tbAttackTime.Value
            compressor.fReleasetime = Me.tbReleaseTime.Value
            compressor.fThreshold = Me.tbThreshold.Value / 100
            apply_compressor = Me.chkCompressor.Checked

            ' Fit items in the hour

            fit_in_hour = Me.chkFitInHour.Checked

            ' Ducker settings

            ducker = Me.chkDucker.Checked
            ducker_fade_level = Me.tbFadeVolume.Value
            ducker_trigger_level = Me.tbTriggerVolume.Value
            ducker_attack = Me.nudAttack.Value
            ducker_release = Me.nudRelease.Value

            ' Schedule settings

            schedule_m3u = Me.radScheduleM3U.Checked
            m3u_folder = Me.tbScheduleFolder.Text
            m3u_file_name = Me.tbScheduleFileName.Text

            If (m3u_file_name.ToLower.EndsWith(".m3u")) Then
                m3u_file_name = m3u_file_name.Substring(0, m3u_file_name.Length - 5)
            End If

            ' Now load the settings into the object

            local.setSettings(db_location, logs_location, main_players, pfl_player, instant_players, ducker_fade_level, agc, apply_agc, compressor, apply_compressor, fit_in_hour, schedule_location, ducker, ducker_trigger_level, ducker_attack, ducker_release, sound_card, sound_input, schedule_m3u, m3u_folder, m3u_file_name)

            ' And save the file

            local.saveSettings(settings_location)
            My.Settings.Item("settings_file") = settings_location
            My.Settings.Save()

            ' Save the rotation

            Me.saveRotation()

            ' Save the display settings

            General.screen_settings.setAttributes(Me.cmbScreenMain.SelectedIndex, Me.cmbScreenLibrary.SelectedIndex, Me.cmbScreenMixer.SelectedIndex, Me.cbDisplayAlwaysLibrary.Checked, Me.cbDisplayAlwaysMixer.Checked)

        Catch ex As Exception
            MsgBox("Invalid setting detected. Please check all of the settings and click save again.", MsgBoxStyle.Exclamation, "Error")
        End Try

        ' Enable the cancel button and hide the screen

        Me.btnCancel.Enabled = True
        General.loadSettings()
        Me.Hide()

        If (Not frmMain.Visible) Then
            frmMain = New frmMain
        End If

    End Sub

    ' Do not allow users to change data

    Private Sub tbDbLocation_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbDbLocation.GotFocus
        Me.btnDbBrowse.Focus()
    End Sub

    Private Sub tbLogsLocation_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbLogsLocation.GotFocus
        Me.btnLogsBrowse.Focus()
    End Sub

    Private Sub tbSettingsFile_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbSettingsFile.GotFocus
        Me.btnBrowseSettingsFile.Focus()
    End Sub

    Private Sub tbScheduleFile_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbScheduleLocation.GotFocus
        Me.btnScheduleBrowse.Focus()
    End Sub

    ' Update the display with the current settings

    Public Sub updateDisplay()

        On Error Resume Next

        Dim agc As New Un4seen.Bass.AddOn.Fx.BASS_FX_DSPDAMP
        Dim compressor As New Un4seen.Bass.AddOn.Fx.BASS_FX_DSPCOMPRESSOR

        ' General values

        Me.tbDbLocation.Text = General.program_settings.getDbLocation
        Me.tbSettingsFile.Text = My.Settings.Item("settings_file")
        Me.tbLogsLocation.Text = General.program_settings.getLogsLocation
        Me.cmbCards1.SelectedIndex = 0
        Me.cmbCards2.SelectedIndex = 0
        Me.cmbCards3.SelectedIndex = 0
        Me.cmbCards4.SelectedIndex = 0
        Me.cmbIP.SelectedIndex = 0
        Me.cmbPFL.SelectedIndex = 0
        Me.cmbSoundCard.SelectedIndex = 0
        Me.cmbInput.SelectedIndex = 0
        Me.cmbCards1.SelectedIndex = General.program_settings.getMainPlayerSoundCard(0) - 1
        Me.cmbCards2.SelectedIndex = General.program_settings.getMainPlayerSoundCard(1) - 1
        Me.cmbCards3.SelectedIndex = General.program_settings.getMainPlayerSoundCard(2) - 1
        Me.cmbCards4.SelectedIndex = General.program_settings.getMainPlayerSoundCard(3) - 1
        Me.cmbIP.SelectedIndex = General.program_settings.getIPSoundCard() - 1
        Me.cmbPFL.SelectedIndex = General.program_settings.getPFLSoundCard - 1
        Me.cmbSoundCard.SelectedIndex = General.program_settings.getSoundCard
        Me.cmbInput.SelectedIndex = General.program_settings.getSoundInput


        Me.cmbPan1.SelectedIndex = General.PanToDropDown(General.program_settings.getMainPlayerPan(0))
        Me.cmbPan2.SelectedIndex = General.PanToDropDown(General.program_settings.getMainPlayerPan(1))
        Me.cmbPan3.SelectedIndex = General.PanToDropDown(General.program_settings.getMainPlayerPan(2))
        Me.cmbPan4.SelectedIndex = General.PanToDropDown(General.program_settings.getMainPlayerPan(3))
        Me.cmbIPPan.SelectedIndex = General.PanToDropDown(General.program_settings.getIPPan)
        Me.cmbPanPFL.SelectedIndex = General.PanToDropDown(General.program_settings.getPFLPan)

        ' AGC

        agc = General.program_settings.getAGC

        Me.sldDelay.Value = agc.fDelay * 1000
        Me.sldMin.Value = agc.fQuiet * 100
        Me.sldRate.Value = agc.fRate * 1000
        Me.sldTarget.Value = agc.fTarget * 100
        Me.sldGain.Value = agc.fGain

        Me.chkEnableAGC.Checked = General.program_settings.getApplyAGC
        Me.chkEnableAGC_Click(Nothing, Nothing)

        ' Compressor

        compressor = General.program_settings.getCompressor

        Me.tbAttackTime.Value = compressor.fAttacktime
        Me.tbReleaseTime.Value = compressor.fReleasetime
        Me.tbThreshold.Value = compressor.fThreshold * 100
        Me.chkCompressor.Checked = General.program_settings.getApplyCompressor

        Me.tmrSliderChange.Tag = Me.sldDelay
        Me.tmrSliderChange_Tick(Nothing, Nothing)
        Me.tmrSliderChange.Tag = Me.sldMin
        Me.tmrSliderChange_Tick(Nothing, Nothing)
        Me.tmrSliderChange.Tag = Me.sldRate
        Me.tmrSliderChange_Tick(Nothing, Nothing)
        Me.tmrSliderChange.Tag = Me.sldTarget
        Me.tmrSliderChange_Tick(Nothing, Nothing)
        Me.tmrSliderChange.Tag = Me.tbAttackTime
        Me.tmrSliderChange_Tick(Nothing, Nothing)
        Me.tmrSliderChange.Tag = Me.tbReleaseTime
        Me.tmrSliderChange_Tick(Nothing, Nothing)
        Me.tmrSliderChange.Tag = Me.tbThreshold
        Me.tmrSliderChange_Tick(Nothing, Nothing)
        Me.tmrSliderChange.Tag = Me.sldGain
        Me.tmrSliderChange_Tick(Nothing, Nothing)

        ' Load the rotation

        Me.loadRotation()

        ' Fit items in the hour

        Me.chkFitInHour.Checked = General.program_settings.getFitInHour

        ' Ducker

        Me.chkDucker.Checked = General.program_settings.getDucker
        Me.tbFadeVolume.Value = General.program_settings.getDuckerFadeLevel
        Me.tbTriggerVolume.Value = General.program_settings.getDuckerTriggerLevel
        Me.nudAttack.Value = General.program_settings.getDuckerAttack
        Me.nudRelease.Value = General.program_settings.getDuckerRelease

        Me.chkDucker_CheckedChanged(Nothing, Nothing)
        Me.tbFadeVolume_ValueChanged(Nothing, Nothing)
        Me.tbTriggerVolume_ValueChanged(Nothing, Nothing)

        ' Schedule

        Me.tbScheduleLocation.Text = General.program_settings.getScheduleLocation

        ' M3U Scheule

        Me.radScheduleAllDayDJ.Checked = Not General.program_settings.getScheduleM3U
        Me.radScheduleM3U.Checked = General.program_settings.getScheduleM3U
        Me.tbScheduleFolder.Text = General.program_settings.getM3UFolder
        Me.tbScheduleFileName.Text = General.program_settings.getM3UFileName

        ' Screen settings

            Me.cmbScreenMain.SelectedIndex = 0
            Me.cmbScreenLibrary.SelectedIndex = 0
            Me.cmbScreenMixer.SelectedIndex = 0
            Me.cbDisplayAlwaysLibrary.Checked = False
            Me.cbDisplayAlwaysMixer.Checked = False
            Me.cmbScreenMain.SelectedIndex = General.screen_settings.ScreenMain
            Me.cmbScreenLibrary.SelectedIndex = General.screen_settings.ScreenLibrary
            Me.cmbScreenMixer.SelectedIndex = General.screen_settings.ScreenMixer
            Me.cbDisplayAlwaysLibrary.Checked = General.screen_settings.PersistLibrary
            Me.cbDisplayAlwaysMixer.Checked = General.screen_settings.PersistMixer

    End Sub

    ' Enable / Disable the AGC controls

    Private Sub chkEnableAGC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkEnableAGC.Click

        Dim enabled As Boolean

        enabled = Me.chkEnableAGC.Checked

        Me.sldDelay.Enabled = enabled
        Me.sldMin.Enabled = enabled
        Me.sldRate.Enabled = enabled
        Me.sldTarget.Enabled = enabled
        Me.sldGain.Enabled = enabled

    End Sub

    ' Apply a slider value

    Private Sub tmrSliderChange_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrSliderChange.Tick

        Dim slider As TrackBar
        Dim value As Integer
        slider = Me.tmrSliderChange.Tag

        ' Get the updated values

        value = slider.Value

        ' Update as appropriate

        If (slider.Equals(Me.sldTarget)) Then
            Me.lblTargetPercent.Text = value & "%"
        End If

        If (slider.Equals(Me.sldMin)) Then
            Me.lblMinPercent.Text = value & "%"
        End If

        If (slider.Equals(Me.sldRate)) Then
            Me.lblRateMs.Text = value
        End If

        If (slider.Equals(Me.sldDelay)) Then
            Me.lblDelayMs.Text = value & "ms"
        End If

        If (slider.Equals(Me.tbAttackTime)) Then
            Me.lblAttackTimeValue.Text = value & "ms"
        End If

        If (slider.Equals(Me.tbReleaseTime)) Then
            Me.lblReleaseTimeValue.Text = value & "ms"
        End If

        If (slider.Equals(Me.tbThreshold)) Then
            Me.lblThresholdValue.Text = value & "%"
        End If

        If (slider.Equals(Me.sldGain)) Then
            Me.lblGainValue.Text = value
        End If

    End Sub

    ' Slider mouse down and up

    Private Sub slider_mouse_down(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sldDelay.MouseDown, sldMin.MouseDown, sldRate.MouseDown, sldTarget.MouseDown, tbAttackTime.MouseDown, tbReleaseTime.MouseDown, tbThreshold.MouseDown, sldGain.MouseDown

        Dim slider As TrackBar

        slider = sender

        Me.tmrSliderChange.Tag = slider
        Me.tmrSliderChange.Enabled = True

    End Sub

    Private Sub slider_mouse_up(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sldDelay.MouseUp, sldMin.MouseUp, sldRate.MouseUp, sldTarget.MouseUp, tbAttackTime.MouseUp, tbReleaseTime.MouseUp, tbThreshold.MouseUp, sldGain.MouseDown

        Me.tmrSliderChange.Enabled = False

    End Sub

    ' Compressor (yes / no)

    Private Sub chkCompressor_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCompressor.CheckedChanged

        Dim enabled As Boolean = Me.chkCompressor.Checked

        Me.tbThreshold.Enabled = enabled
        Me.tbReleaseTime.Enabled = enabled
        Me.tbAttackTime.Enabled = enabled

    End Sub

    ' Add to the rotation

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim selected_item As String

        ' Get the item

        selected_item = Me.cmbPlaylists.Text
        If (selected_item.Length = 0) Then
            Exit Sub
        End If

        ' Add the item

        Me.lbRotation.Items.Add(selected_item)

    End Sub

    ' Remove an item from rotation

    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        Dim selected_item As Integer

        ' Get the item

        selected_item = Me.lbRotation.SelectedIndex
        If (selected_item < 0) Then
            Exit Sub
        End If

        ' And remove it

        Me.lbRotation.Items.RemoveAt(selected_item)

    End Sub

    ' Move up and down the rotation

    Private Sub btnUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp.Click

        Dim selected_item As Integer
        Dim item_text As String

        ' Get the item

        selected_item = Me.lbRotation.SelectedIndex
        If (selected_item < 0) Then
            Exit Sub
        End If

        ' Check it is not the first item

        If (selected_item = 0) Then
            Exit Sub
        End If

        ' Otherwise move the item up one

        item_text = Me.lbRotation.Text
        Me.lbRotation.Items.RemoveAt(selected_item)
        Me.lbRotation.Items.Insert(selected_item - 1, item_text)

    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click

        Dim selected_item As Integer
        Dim item_text As String

        ' Get the item

        selected_item = Me.lbRotation.SelectedIndex
        If (selected_item < 0) Then
            Exit Sub
        End If

        ' Check it is not the last item

        If (selected_item = (Me.lbRotation.Items.Count - 1)) Then
            Exit Sub
        End If

        ' Otherwise move the item down one

        item_text = Me.lbRotation.Text
        Me.lbRotation.Items.RemoveAt(selected_item)
        Me.lbRotation.Items.Insert(selected_item + 1, item_text)

    End Sub

    ' Load the rotation

    Private Sub loadRotation()

        Dim rotation As List(Of String) = General.program_settings.getRotation
        Dim item As String
        Dim playlists As List(Of Playlist) = frmMain.getPlaylists
        Dim playlist As Playlist

        ' Clear current screen

        Me.lbRotation.Items.Clear()
        Me.cmbPlaylists.Items.Clear()

        ' Load the list of playlists

        For Each playlist In playlists
            Me.cmbPlaylists.Items.Add(playlist.getName)
        Next

        Me.cmbPlaylists.SelectedIndex = 0

        ' Current rotation

        For Each item In rotation
            Me.lbRotation.Items.Add(item)
        Next

    End Sub

    ' Save the rotation

    Private Sub saveRotation()

        Dim rotation As New List(Of String)
        Dim counter As Integer

        ' Throw exception if nothing there

        If (Me.lbRotation.Items.Count = 0) Then
            Throw New Exception("The rotation is empty!")
        End If

        ' Get the items

        For counter = 0 To (Me.lbRotation.Items.Count - 1)
            rotation.Add(Me.lbRotation.Items.Item(counter))
        Next

        ' Set and save

        General.program_settings.setRotation(rotation)
        General.saveRotation()

    End Sub

    ' Enable / disable ducker

    Private Sub chkDucker_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDucker.CheckedChanged

        Dim value As Boolean = Me.chkDucker.Checked

        Me.tbFadeVolume.Enabled = value
        Me.tbTriggerVolume.Enabled = value
        Me.nudAttack.Enabled = value
        Me.nudRelease.Enabled = value

    End Sub

    ' Update onscreen values

    Private Sub tbFadeVolume_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbFadeVolume.ValueChanged

        Me.lblFadePercent.Text = Me.tbFadeVolume.Value.ToString + "%"

    End Sub

    Private Sub tbTriggerVolume_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbTriggerVolume.ValueChanged

        Me.lblTriggerPercent.Text = Me.tbTriggerVolume.Value.ToString + "%"

    End Sub

    ' Display possible sound inputs

    Private Sub cmbSoundCard_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSoundCard.SelectedIndexChanged

        On Error Resume Next

        Dim sound_card As Integer
        Dim counter As Integer

        ' Get sound card

        sound_card = Me.cmbSoundCard.SelectedIndex
        If (sound_card < 0) Then
            Exit Sub
        Else
            sound_card += 1
        End If

        ' Get the inputs

        Bass.BASS_RecordSetDevice(sound_card)
        Me.cmbInput.Items.Clear()

        For counter = 1 To Bass.BASS_RecordGetInputNames.Length
            Me.cmbInput.Items.Add(Bass.BASS_RecordGetInputName(counter))
        Next

        ' Select a default

        Me.cmbInput.SelectedIndex = 0

    End Sub

    Private Sub btnScheduleHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScheduleHelp.Click

        MsgBox("This text box is used set the format of the file names generate by the M3U scheduler." + vbCrLf + vbCrLf + "Acceptable names use the standard windows time format. Some of the common strings are:" + vbCrLf + vbCrLf + "dd - Day of month." + vbCrLf + "mm - Month of year." + vbCrLf + "yyyy - Year (4 characters)." + vbCrLf + "HH - Hour of the day (24 hour format)." + vbCrLf + "MM - Minutes past the hour." + vbCrLf + "ss - Seconds past the minute." + vbCrLf + "The .M3U extension is to be ignored (it is automatically added)." + vbCrLf + vbCrLf + "The example hh-dd-mm-yyyy would look for the file name 15-01-01-2008.M3U at 15:00 on 1/January/2008.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "File Names")

    End Sub

    Private Sub btnScheduleFolderBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnScheduleFolderBrowse.Click

        Dim folder_name As String

        ' Show and get

        Me.fbdM3U.ShowDialog()
        folder_name = Me.fbdM3U.SelectedPath

        ' Check and put

        If Not folder_name Is Nothing Then
            If folder_name.Length > 0 Then
                Me.tbScheduleFolder.Text = folder_name
            End If
        End If

    End Sub

End Class
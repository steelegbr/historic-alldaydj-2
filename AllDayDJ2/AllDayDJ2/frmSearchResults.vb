Public Class frmSearchResults

    Private total_pages As Integer
    Private current_page As Integer
    Private sr As SearchResults
    Private item_buttons(0 To 19) As Button
    Private global_override As Boolean = False

    ' Load the search results

    Public Sub loadSR(ByRef sr As SearchResults)

        Dim counter As Integer

        ' Stop PFL

        If (Not Me.sr Is Nothing) Then
            Me.sr.stopPFL()
        End If

        ' Assign the sr

        Me.sr = sr

        ' Now get the number of pages

        Me.total_pages = Int(sr.getResults.getPlaylistLength / 20)
        If (sr.getResults.getPlaylistLength Mod 20 > 0) Then
            Me.total_pages += 1
        End If

        Me.lblNumberOfPages.Text = "of " & Me.total_pages

        ' Load the dropdown box

        Me.cbPageNumber.Items.Clear()
        Me.global_override = True

        For counter = 1 To Me.total_pages
            Me.cbPageNumber.Items.Add(counter)
        Next

        Me.cbPageNumber.SelectedIndex = 0
        Me.global_override = False

        ' Load the first page

        Me.loadResults(1)

    End Sub

    ' Loads a page of results

    Private Sub loadResults(ByVal page_number As Integer, Optional ByVal override As Boolean = False)

        Dim counter As Integer
        Dim sub_counter As Integer = 0
        Dim item As AudioItem

        ' Cycle through the boxes, making them invisible

        For counter = 0 To 19
            Me.item_buttons(counter).Enabled = False
            Me.item_buttons(counter).Text = "NO MORE RESULTS"
        Next

        ' Now load the appropriate items

        For counter = ((page_number - 1) * 20) To ((page_number * 20) - 1)

            ' Break as appropriate

            If (counter >= Me.sr.getResults.getPlaylistLength) Then
                Exit For
            End If

            ' Load the actual results

            item = Me.sr.getResults.getItem(counter)
            Me.item_buttons(sub_counter).Text = "[" & item.getDbTable & " - " & item.getTrackId & "]" & Chr(13) & Chr(10) & item.getArtist & Chr(13) & Chr(10) & item.getTrackName & Chr(13) & Chr(10) & General.timeToString(item.getTimeEndIntro - item.getTimeStartIntro) & "/" & General.timeToString(item.getTimeEndTrack - item.getTimeStartTrack)
            Me.item_buttons(sub_counter).Tag = counter
            Me.item_buttons(sub_counter).Enabled = True
            sub_counter += 1

        Next

        ' Set the current page

        Me.current_page = page_number

        ' Disable  / enable back / forwards buttons

        If (page_number = 1) Then
            Me.btnPrevious.Enabled = False
        Else
            Me.btnPrevious.Enabled = True
        End If

        If (page_number = Me.total_pages) Then
            Me.btnNext.Enabled = False
        Else
            Me.btnNext.Enabled = True
        End If

        ' Change the page number display

        If (Not override) Then
            Me.global_override = True
            Me.cbPageNumber.SelectedIndex = page_number - 1
            Me.global_override = False
        End If

    End Sub

    ' Load the screen

    Private Sub frmSearchResults_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Button array

        Me.item_buttons(0) = Me.btnResult0
        Me.item_buttons(1) = Me.btnResult1
        Me.item_buttons(2) = Me.btnResult2
        Me.item_buttons(3) = Me.btnResult3
        Me.item_buttons(4) = Me.btnResult4
        Me.item_buttons(5) = Me.btnResult5
        Me.item_buttons(6) = Me.btnResult6
        Me.item_buttons(7) = Me.btnResult7
        Me.item_buttons(8) = Me.btnResult8
        Me.item_buttons(9) = Me.btnResult9
        Me.item_buttons(10) = Me.btnResult10
        Me.item_buttons(11) = Me.btnResult11
        Me.item_buttons(12) = Me.btnResult12
        Me.item_buttons(13) = Me.btnResult13
        Me.item_buttons(14) = Me.btnResult14
        Me.item_buttons(15) = Me.btnResult15
        Me.item_buttons(16) = Me.btnResult16
        Me.item_buttons(17) = Me.btnResult17
        Me.item_buttons(18) = Me.btnResult18
        Me.item_buttons(19) = Me.btnResult19

        ' Maximise this screen

        Me.WindowState = FormWindowState.Maximized

    End Sub

    ' Close this screen

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.sr.stopPFL()
        Me.Hide()

    End Sub

    ' Left click (add to pl)

    Private Sub left_click(ByVal sender As Button)

        Dim item_number As Integer
        Dim item As AudioItem

        ' Get the item

        item_number = Integer.Parse(sender.Tag)
        item = Me.sr.getItem(item_number)

        ' Add the item to the main playlist

        frmMain.addToMainPL(item)

    End Sub

    ' Right click (Popup menu)

    Private Sub right_click(ByVal x As Integer, ByVal y As Integer, ByVal sender As Button)

        ' Show the popup menu

        Me.popupMenu.Tag = sender.Tag
        Me.popupMenu.Show(sender, x, y)

    End Sub

    ' Mouse handler

    Private Sub mouse_handler(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnResult0.MouseDown, btnResult1.MouseDown, btnResult2.MouseDown, btnResult3.MouseDown, btnResult4.MouseDown, btnResult5.MouseDown, btnResult6.MouseDown, btnResult7.MouseDown, btnResult8.MouseDown, btnResult9.MouseDown, btnResult10.MouseDown, btnResult11.MouseDown, btnResult12.MouseDown, btnResult13.MouseDown, btnResult14.MouseDown, btnResult15.MouseDown, btnResult16.MouseDown, btnResult17.MouseDown, btnResult18.MouseDown, btnResult19.MouseDown

        ' What button was clicked

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.left_click(sender)
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            Me.right_click(e.X, e.Y, sender)
        ElseIf e.Button = Windows.Forms.MouseButtons.XButton1 Then
            Me.movePage(-1)
        ElseIf e.Button = Windows.Forms.MouseButtons.XButton2 Then
            Me.movePage(1)
        End If

    End Sub

    ' Move forward or back one page

    Private Sub movePage(ByVal ammount As Integer)

        Dim page_number As Integer = Me.current_page

        ' Do the adjustment and check

        page_number += ammount

        If (page_number <= 0 Or page_number > Me.total_pages) Then
            Exit Sub
        End If

        ' Change the page number

        Me.loadResults(page_number)
        Me.cbPageNumber.SelectedIndex = page_number - 1

    End Sub

    ' Edit an item

    Private Sub EditItemToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EditItemToolStripMenuItem.Click

        frmEditTrack.loadData(Me, Me.sr.getResults.getItem(Me.popupMenu.Tag))
        frmEditTrack.Show()

    End Sub

    ' PFL an item

    Private Sub PFLToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PFLToolStripMenuItem.Click

        Me.sr.togglePFL(Me.popupMenu.Tag)

    End Sub

    ' Reload a search

    Public Sub reloadSearch()

        Me.sr.reloadSearch(True)
        Me.loadResults(Me.current_page)
        Me.cbPageNumber.SelectedIndex = Me.current_page - 1

    End Sub

    ' Previous and next buttons

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click

        Me.movePage(1)

    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevious.Click

        Me.movePage(-1)

    End Sub

    ' Change the page number using the drop down box

    Private Sub cbPageNumber_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPageNumber.SelectedIndexChanged

        If (Not Me.global_override) Then
            Me.loadResults(Me.cbPageNumber.SelectedIndex + 1, True)
        End If

    End Sub

End Class

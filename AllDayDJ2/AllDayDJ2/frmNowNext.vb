Public Class frmNowNext

    ' Load time

    Private Sub frmNowNext_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim playlists As List(Of Playlist) = frmMain.getPlaylists
        Dim selected_playlists As List(Of String) = modNowNext.IgnorePlaylists
        Dim counter As Integer
        Dim counter2 As Integer
        Dim added As Boolean = False

        ' Load playlist names

        Me.clbIgnore.Items.Clear()

        For counter = 0 To (playlists.Count - 1)

            ' Clear

            added = False

            ' Check the playlists

            For counter2 = 0 To (selected_playlists.Count - 1)
                If (playlists(counter).getName.Equals(selected_playlists(counter2))) Then
                    Me.clbIgnore.Items.Add(selected_playlists(counter2), True)
                    added = True
                End If
            Next

            ' Add if not added

            If (Not added) Then
                Me.clbIgnore.Items.Add(playlists(counter).getName)
            End If

        Next

        ' Load properties

        Me.tbDefaultText.Text = modNowNext.DefaultText
        Me.tbOutputFile.Text = modNowNext.OutputFile

    End Sub

    ' Browse for an output file name

    Private Sub btnBrowseOuputFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrowseOuputFile.Click

        Me.sfdOutputFile.ShowDialog()
        Me.tbOutputFile.Text = Me.sfdOutputFile.FileName

    End Sub

    ' Save the data

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim default_text As String = Me.tbDefaultText.Text
        Dim output_file As String = Me.tbOutputFile.Text
        Dim ignore_playlists As New List(Of String)
        Dim counter As Integer

        ' Check file name

        If (output_file.Length = 0) Then
            MsgBox("No output file selected. Please select a file for the now and next data.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If

        ' Get the ignore playlists

        For counter = 0 To (Me.clbIgnore.CheckedItems.Count - 1)
            ignore_playlists.Add(Me.clbIgnore.CheckedItems.Item(counter).ToString)
        Next

        ' Update

        modNowNext.updateNowNextSettings(default_text, output_file, ignore_playlists)

        ' Close

        Me.Close()

    End Sub

End Class

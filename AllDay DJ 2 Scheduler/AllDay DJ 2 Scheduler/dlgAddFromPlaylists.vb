Imports System.Windows.Forms

Public Class dlgAddFromPlaylists

    Private playlists As List(Of Playlist)
    Private playlist_selected As Playlist
    Private item_selected As Integer
    Private sender As Form

    Public ReadOnly Property selected_playlist()
        Get
            Return Me.playlist_selected
        End Get
    End Property
    Public ReadOnly Property selected_item_id() As Integer
        Get
            Return Me.item_selected
        End Get
    End Property

    ' Close and load the public variables

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim selected_item_number As Integer
        Dim selected_item_text As String

        ' Check there is something to select

        selected_item_number = Me.lbItems.SelectedIndex
        If (selected_item_number < 0) Then
            MsgBox("No item selected!" & Chr(13) & Chr(10) & "Please select an item and try again.", MsgBoxStyle.Information, "Please...")
            Exit Sub
        End If

        ' Now get the item

        selected_item_text = Me.lbItems.Text
        Me.item_selected = selected_item_text.Substring(1, (selected_item_text.IndexOf("]") - 1))

        ' Send the item to the appropriate form

        If (Me.sender.Equals(frmEditSpot)) Then
            frmEditSpot.addToSpot(New AudioItem(Me.item_selected.ToString, Me.playlist_selected.getName, False))
        End If

        ' Close the dialogue

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    ' Load the dialogue

    Private Sub dlgAddFromPlaylists_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim counter As Integer

        ' Defaults

        Me.playlists = ProgramSettings.playlists
        playlist_selected = Nothing
        item_selected = Nothing

        ' Load the playlists

        Me.cmbPlaylists.Items.Clear()

        For counter = 0 To (Me.playlists.Count - 1)
            Me.cmbPlaylists.Items.Add(Me.playlists(counter).getName)
        Next

        Me.playlist_selected = Me.playlists(0)
        Me.cmbPlaylists_SelectionChangeCommitted(Nothing, Nothing)

        ' Select the first playlist

        Me.cmbPlaylists.SelectedIndex = 0

    End Sub

    ' Set the sender form

    Public Sub setSender(ByVal form As Form)

        Me.sender = form

    End Sub

    ' Change in playlist

    Private Sub cmbPlaylists_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlaylists.SelectionChangeCommitted

        Dim selected_playlist As Integer

        ' Load and display the playlist

        selected_playlist = Me.cmbPlaylists.SelectedIndex
        If (selected_playlist < 0) Then
            Exit Sub
        End If

        Me.playlist_selected = Me.playlists(selected_playlist)

        Me.tbSearch.Text = "."
        Me.tbSearch_TextChanged(Nothing, Nothing)
        Me.tbSearch.Text = ""
        Me.tbSearch_TextChanged(Nothing, Nothing)
        
    End Sub

    ' Display a playlist

    Private Sub displayPlaylist(ByRef playlist As Playlist)

        Dim counter As Integer
        Dim item As AudioItem

        ' Display every item in the playlist

        Me.lbItems.Items.Clear()

        For counter = 0 To (playlist.getPlaylistLength - 1)
            item = playlist.getItem(counter)
            Me.lbItems.Items.Add("[" & item.getTrackId & "] " & item.getArtist & " - " & item.getTrackName)
        Next

    End Sub

    ' Search

    Private Sub tbSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbSearch.TextChanged

        Dim onscreen_playlist As Playlist

        ' Get the playlist and display it

        onscreen_playlist = Me.playlist_selected.search(Me.tbSearch.Text)
        Me.displayPlaylist(onscreen_playlist)

    End Sub

End Class

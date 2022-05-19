Module modNowNext

    Private default_text As String
    Private output_file As String
    Private ignore_playlists As New List(Of String)

    Public ReadOnly Property DefaultText() As String
        Get
            Return default_text
        End Get
    End Property
    Public ReadOnly Property OutputFile() As String
        Get
            Return output_file
        End Get
    End Property
    Public ReadOnly Property IgnorePlaylists() As List(Of String)
        Get
            Return ignore_playlists
        End Get
    End Property

    ' Load the now and next settings

    Public Sub loadNowNext()

        Dim counter As Integer = 0

        ' Check the file

        If (General.fileExists(System.AppDomain.CurrentDomain.BaseDirectory + "nownext.dat")) Then

            ' Open the file

            Dim fs As New IO.FileStream(System.AppDomain.CurrentDomain.BaseDirectory + "nownext.dat", IO.FileMode.Open)
            Dim sr As New IO.StreamReader(fs)

            ' Get data

            default_text = sr.ReadLine
            output_file = sr.ReadLine

            While Not sr.EndOfStream
                ignore_playlists.Add(sr.ReadLine.Trim)
            End While

            ' Close

            sr.Close()
            fs.Close()
            sr = Nothing
            fs = Nothing

        Else

            ' No file

            default_text = "More great music soon..."
            output_file = System.AppDomain.CurrentDomain.BaseDirectory + "nownext.txt"
            saveNowNext()

        End If

    End Sub

    ' Save the current settings

    Private Sub saveNowNext()

        Dim fs As New IO.FileStream(System.AppDomain.CurrentDomain.BaseDirectory + "nownext.dat", IO.FileMode.Create)
        Dim sw As New IO.StreamWriter(fs)
        Dim counter As Integer

        ' Write the data

        sw.WriteLine(default_text)
        sw.WriteLine(output_file)

        If (ignore_playlists.Count > 0) Then
            For counter = 0 To (ignore_playlists.Count - 1)
                sw.WriteLine(ignore_playlists(counter))
            Next
        End If

        ' Close the file

        sw.Close()
        fs.Close()
        sw = Nothing
        fs = Nothing

    End Sub

    ' Updates the now and next properties

    Public Sub updateNowNextSettings(ByVal default_text As String, ByVal ouput_file As String, ByVal ignore_playlists As List(Of String))

        ' Assign

        modNowNext.default_text = default_text
        modNowNext.output_file = output_file
        modNowNext.ignore_playlists = ignore_playlists

        ' Save

        saveNowNext()

    End Sub

    ' Sets the now and next data

    Public Sub setNowNext(ByVal now_item As String, ByVal next_item As String)

        ' Open the file

        Dim fs As New IO.FileStream(output_file, IO.FileMode.Create)
        Dim sw As New IO.StreamWriter(fs)

        ' Write

        sw.WriteLine(now_item)
        sw.WriteLine(next_item)

        ' Close

        sw.Close()
        fs.Close()
        sw = Nothing
        fs = Nothing

    End Sub

    ' Checks the playlist
    ' Returns true if to be ignore

    Public Function checkIgnore(ByVal item As AudioItem) As Boolean

        Dim counter As Integer

        ' Check

        For counter = 0 To (ignore_playlists.Count - 1)
            If (item.getDbTable.Equals(ignore_playlists(counter))) Then
                Return True
            End If
        Next

        ' Default

        Return False

    End Function

End Module

Imports System.IO

Public Class ShoutcastSettings

    Private Shared server_address As String
    Private Shared server_port As Integer
    Private Shared server_password As String
    Private Shared station_name As String
    Private Shared station_genre As String
    Private Shared station_aim As String
    Private Shared station_icq As String
    Private Shared station_irc As String
    Private Shared station_url As String
    Private Shared appear_in_directory As Boolean

    Public Shared ReadOnly Property ServerAddress() As String
        Get
            Return ShoutcastSettings.server_address
        End Get
    End Property

    Public Shared ReadOnly Property ServerPort() As Integer
        Get
            Return ShoutcastSettings.server_port
        End Get
    End Property

    Public Shared ReadOnly Property Password() As String
        Get
            Return ShoutcastSettings.server_password
        End Get
    End Property

    Public Shared ReadOnly Property StationName() As String
        Get
            Return ShoutcastSettings.station_name
        End Get
    End Property

    Public Shared ReadOnly Property Genre() As String
        Get
            Return ShoutcastSettings.station_genre
        End Get
    End Property

    Public Shared ReadOnly Property AIM()
        Get
            Return ShoutcastSettings.station_aim
        End Get
    End Property

    Public Shared ReadOnly Property ICQ() As String
        Get
            Return ShoutcastSettings.station_icq
        End Get
    End Property

    Public Shared ReadOnly Property IRC() As String
        Get
            Return ShoutcastSettings.station_irc
        End Get
    End Property

    Public Shared ReadOnly Property URL() As String
        Get
            Return ShoutcastSettings.station_url
        End Get
    End Property

    Public Shared ReadOnly Property AppearInDirectory() As Boolean
        Get
            Return ShoutcastSettings.appear_in_directory
        End Get
    End Property

    ' Update the settings

    Public Shared Sub setSettings(ByVal server_address As String, ByVal server_port As Integer, ByVal server_password As String, ByVal station_name As String, ByVal station_genre As String, ByVal station_aim As String, ByVal station_icq As String, ByVal station_irc As String, ByVal station_url As String, ByVal appear_in_directory As Boolean)

        ' Validate important variables

        If (server_address = Nothing Or server_address.Length = 0) Then
            Throw New Exception("No server address entered. Please enter a valid server address.")
        End If

        If (server_port <= 0) Then
            Throw New Exception("Invalid server port. Please enter a valid port number (a whole number greater than zero)")
        End If

        If (station_name = Nothing Or station_name.Length = 0) Then
            Throw New Exception("No station name entered. Please enter a valid station name.")
        End If

        If (station_genre = Nothing Or station_genre.Length = 0) Then
            Throw New Exception("No genre entered. Please enter a valid genre for the station.")
        End If

        If (station_url = Nothing Or station_url.Length = 0) Then
            Throw New Exception("No station URL entered. Please enter a valid URL.")
        End If

        ' Update the values

        ShoutcastSettings.server_address = server_address
        ShoutcastSettings.server_port = server_port
        ShoutcastSettings.server_password = server_password
        ShoutcastSettings.station_name = station_name
        ShoutcastSettings.station_genre = station_genre
        ShoutcastSettings.station_aim = station_aim
        ShoutcastSettings.station_icq = station_icq
        ShoutcastSettings.station_irc = station_irc
        ShoutcastSettings.station_url = station_url
        ShoutcastSettings.appear_in_directory = appear_in_directory

    End Sub

    ' Save the settings

    Public Shared Sub saveSettings()

        Try

            Dim file As File
            Dim writer As StreamWriter

            ' Open the file for writing

            writer = file.CreateText(Windows.Forms.Application.StartupPath & "\shoutcast.dat")

            ' Write the data

            writer.WriteLine(ShoutcastSettings.server_address)
            writer.WriteLine(ShoutcastSettings.server_port)
            writer.WriteLine(ShoutcastSettings.server_password)
            writer.WriteLine(ShoutcastSettings.station_name)
            writer.WriteLine(ShoutcastSettings.station_genre)
            writer.WriteLine(ShoutcastSettings.station_aim)
            writer.WriteLine(ShoutcastSettings.station_icq)
            writer.WriteLine(ShoutcastSettings.station_irc)
            writer.WriteLine(ShoutcastSettings.station_url)
            writer.WriteLine(ShoutcastSettings.appear_in_directory)

            ' Close the file

            writer.Close()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information, "Error")

        End Try

    End Sub

    ' Load the settings

    Public Shared Sub loadSettings()

        ' Check to see if the settings file exists

        If (fileExists(Windows.Forms.Application.StartupPath & "\shoutcast.dat")) Then

            ' Load the data

            Dim file As File
            Dim reader As StreamReader

            reader = file.OpenText(Windows.Forms.Application.StartupPath & "\shoutcast.dat")

            ' Read the data in

            ShoutcastSettings.server_address = reader.ReadLine
            ShoutcastSettings.server_port = reader.ReadLine
            ShoutcastSettings.server_password = reader.ReadLine
            ShoutcastSettings.station_name = reader.ReadLine
            ShoutcastSettings.station_genre = reader.ReadLine
            ShoutcastSettings.station_aim = reader.ReadLine
            ShoutcastSettings.station_icq = reader.ReadLine
            ShoutcastSettings.station_irc = reader.ReadLine
            ShoutcastSettings.station_url = reader.ReadLine
            ShoutcastSettings.appear_in_directory = reader.ReadLine

            ' Close the file

            reader.Close()

        Else

            ' Create a new file

            ShoutcastSettings.server_address = "localhost"
            ShoutcastSettings.server_port = 8000
            ShoutcastSettings.server_password = ""
            ShoutcastSettings.station_name = "Station Name"
            ShoutcastSettings.station_genre = "Genre"
            ShoutcastSettings.station_aim = ""
            ShoutcastSettings.station_icq = ""
            ShoutcastSettings.station_irc = ""
            ShoutcastSettings.station_url = ""
            ShoutcastSettings.appear_in_directory = False

            ShoutcastSettings.saveSettings()

        End If

    End Sub

End Class

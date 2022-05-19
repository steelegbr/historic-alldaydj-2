Imports System.IO

Public Class IcecastSettings

    Private Shared server_adderss As String
    Private Shared mount_point As String
    Private Shared port_number As Integer
    Private Shared server_password As String
    Private Shared station_name As String
    Private Shared station_genre As String
    Private Shared station_description As String
    Private Shared station_url As String
    Private Shared appear_in_directory As Boolean

    Public Shared ReadOnly Property ServerAddress()
        Get
            Return IcecastSettings.server_adderss
        End Get
    End Property

    Public Shared ReadOnly Property MountPoint() As String
        Get
            Return IcecastSettings.mount_point
        End Get
    End Property

    Public Shared ReadOnly Property PortNumber() As Integer
        Get
            Return IcecastSettings.port_number
        End Get
    End Property

    Public Shared ReadOnly Property Password() As String
        Get
            Return IcecastSettings.server_password
        End Get
    End Property

    Public Shared ReadOnly Property StationName() As String
        Get
            Return IcecastSettings.station_name
        End Get
    End Property

    Public Shared ReadOnly Property Genre() As String
        Get
            Return IcecastSettings.station_genre
        End Get
    End Property

    Public Shared ReadOnly Property Description() As String
        Get
            Return IcecastSettings.station_description
        End Get
    End Property

    Public Shared ReadOnly Property URL()
        Get
            Return IcecastSettings.station_url
        End Get
    End Property

    Public Shared ReadOnly Property AppearInDirectory() As Boolean
        Get
            Return IcecastSettings.appear_in_directory
        End Get
    End Property

    ' Update the settings

    Public Shared Sub setSettings(ByVal server_address As String, ByVal mount_point As String, ByVal port_number As Integer, ByVal server_password As String, ByVal station_name As String, ByVal station_genre As String, ByVal station_description As String, ByVal station_url As String, ByVal appear_in_directory As Boolean)

        ' Check validity

        If (server_address = Nothing Or server_address.Length = 0) Then
            Throw New Exception("No server address entered. Please enter the address you Icecast server is at.")
        End If

        If (mount_point = Nothing Or mount_point.Length = 0) Then
            Throw New Exception("No mount point entered. Please enter the mount point for your stream.")
        ElseIf (Not mount_point.StartsWith("/")) Then
            Throw New Exception("The mount point you entered is invalid. All mount points must start with a forward slash (/)")
        End If

        If (port_number <= 0) Then
            Throw New Exception("The port number you entered is invalid. The port number must be greater than zero.")
        End If

        ' ALLOW NULL PASSWORDS
        ' THEREFORE NO ACTION

        If (station_name = Nothing Or station_name.Length = 0) Then
            Throw New Exception("No station name was entered. Please enter a station name.")
        End If

        If (station_genre = Nothing Or station_genre.Length = 0) Then
            Throw New Exception("No genre was entered. Please enter a genre.")
        End If

        If (station_description = Nothing Or station_description.Length = 0) Then
            Throw New Exception("No station description was entered. Please enter a station description.")
        End If

        'If (station_url = Nothing Or station_url.Length = 0) Then
        'Throw New Exception("No station URL was entered. Please enter a station URL.")
        'End If

        ' No need to check the boolean appear_in_directory field
        ' This is valid in either condition

        ' If we got this far, we can update the settings

        IcecastSettings.server_adderss = server_address
        IcecastSettings.mount_point = mount_point
        IcecastSettings.port_number = port_number
        IcecastSettings.server_password = server_password
        IcecastSettings.station_name = station_name
        IcecastSettings.station_genre = station_genre
        IcecastSettings.station_url = station_url
        IcecastSettings.appear_in_directory = appear_in_directory

    End Sub

    ' Save the settings

    Public Shared Sub saveSettings()

        Try

            Dim file As File
            Dim writer As StreamWriter

            ' Open the file for writing

            writer = file.CreateText(Windows.Forms.Application.StartupPath & "\icecast.dat")

            ' Write the data

            writer.WriteLine(IcecastSettings.server_adderss)
            writer.WriteLine(IcecastSettings.mount_point)
            writer.WriteLine(IcecastSettings.port_number)
            writer.WriteLine(IcecastSettings.server_password)
            writer.WriteLine(IcecastSettings.station_name)
            writer.WriteLine(IcecastSettings.station_genre)
            writer.WriteLine(IcecastSettings.station_url)
            writer.WriteLine(IcecastSettings.appear_in_directory)

            ' Close the file

            writer.Close()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information, "Error")

        End Try

    End Sub

    ' Load the settings

    Public Shared Sub loadSettings()

        ' Check to see if the settings file exists

        If (fileExists(Windows.Forms.Application.StartupPath & "\icecast.dat")) Then

            ' Load the data

            Dim file As File
            Dim reader As StreamReader

            reader = file.OpenText(Windows.Forms.Application.StartupPath & "\icecast.dat")

            ' Read the data in

            IcecastSettings.server_adderss = reader.ReadLine()
            IcecastSettings.mount_point = reader.ReadLine()
            IcecastSettings.port_number = reader.ReadLine()
            IcecastSettings.server_password = reader.ReadLine()
            IcecastSettings.station_name = reader.ReadLine()
            IcecastSettings.station_genre = reader.ReadLine()
            IcecastSettings.station_url = reader.ReadLine()
            IcecastSettings.appear_in_directory = reader.ReadLine()

            ' Close the file

            reader.Close()

        Else

            ' Create a new file

            IcecastSettings.server_adderss = "localhost"
            IcecastSettings.mount_point = "/mount_point.mp3"
            IcecastSettings.port_number = 8000
            IcecastSettings.server_password = ""
            IcecastSettings.station_name = "Station Name"
            IcecastSettings.station_genre = "Genre"
            IcecastSettings.station_description = "Station Description"

            EncoderSettings.saveSettings()

        End If

    End Sub

End Class

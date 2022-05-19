Imports System.IO

Public Class SilenceSettings

    Private Shared silence_length As Integer
    Private Shared use_smtp As Boolean
    Private Shared smtp_server As String
    Private Shared smtp_username As String
    Private Shared smtp_password As String
    Private Shared smtp_from_address As String
    Private Shared smtp_to_address As String
    Private Shared use_m3u As Boolean
    Private Shared m3u_playlist As String
    Private Shared use_execute As Boolean
    Private Shared execute_command As String

    Public Shared ReadOnly Property SilenceLength() As Integer
        Get
            Return SilenceSettings.silence_length
        End Get
    End Property

    Public Shared ReadOnly Property SMTP() As Boolean
        Get
            Return SilenceSettings.use_smtp
        End Get
    End Property

    Public Shared ReadOnly Property SMTPServer() As String
        Get
            Return SilenceSettings.smtp_server
        End Get
    End Property

    Public Shared ReadOnly Property SMTPUsername() As String
        Get
            Return SilenceSettings.smtp_username
        End Get
    End Property

    Public Shared ReadOnly Property SMTPPassword() As String
        Get
            Return SilenceSettings.smtp_password
        End Get
    End Property

    Public Shared ReadOnly Property SMTPFromAddress() As String
        Get
            Return SilenceSettings.smtp_from_address
        End Get
    End Property

    Public Shared ReadOnly Property SMTPToAddress() As String
        Get
            Return SilenceSettings.smtp_to_address
        End Get
    End Property

    Public Shared ReadOnly Property M3U() As Boolean
        Get
            Return SilenceSettings.use_m3u
        End Get
    End Property

    Public Shared ReadOnly Property M3UPlaylist() As String
        Get
            Return SilenceSettings.m3u_playlist
        End Get
    End Property

    Public Shared ReadOnly Property Execute() As Boolean
        Get
            Return SilenceSettings.use_execute
        End Get
    End Property

    Public Shared ReadOnly Property ExecuteCommand() As String
        Get
            Return SilenceSettings.execute_command
        End Get
    End Property

    ' Update the settings

    Public Shared Sub setSettings(ByVal silence_length As Integer, ByVal use_smtp As Boolean, ByVal smtp_server As String, ByVal smtp_username As String, ByVal smtp_password As String, ByVal smtp_from_address As String, ByVal smtp_to_address As String, ByVal use_m3u As Boolean, ByVal m3u_playlist As String, ByVal use_execute As Boolean, ByVal execute_command As String)

        ' Validate

        If (silence_length <= 0) Then
            Throw New Exception("Invalid silence length entered. The silence length must be a posative whole number (greater than zero).")
        End If

        If (use_smtp) Then

            ' Check SMTP settings

            If (smtp_server = Nothing Or smtp_server.Length = 0) Then
                Throw New Exception("No SMTP server entered. Please enter a valid SMTP server.")
            End If

            If (smtp_username = Nothing Or smtp_username.Length = 0) Then
                Throw New Exception("No SMTP username entered. Please enter a valid username for your SMTP server.")
            End If

            If (smtp_password = Nothing Or smtp_password.Length = 0) Then
                Throw New Exception("No SMTP password entered. Please enter a valid password for your SMTP server.")
            End If

            If (smtp_from_address = Nothing Or smtp_from_address.Length = 0) Then
                Throw New Exception("No from e-mail address entered. You must enter a valid e-mail address to send alerts from.")
            End If

            If (Not smtp_from_address.Contains("@")) Then
                Throw New Exception("Invalid from e-mail address entered. You must enter a valid e-mail address to send the alerts from.")
            End If

            If (smtp_to_address = Nothing Or smtp_to_address.Length = 0) Then
                Throw New Exception("No to e-mail address entered. You must enter a valid e-mail address to receive the alerts.")
            End If

            If (Not smtp_to_address.Contains("@")) Then
                Throw New Exception("Invalid to e-mail address. You must enter a valid e-mail address to receive the alerts.")
            End If

        End If

        If (use_m3u) Then

            If (m3u_playlist = Nothing Or m3u_playlist.Length = 0) Then
                Throw New Exception("No M3U playlist selected. Please select a valid M3U playlist.")
            End If

            If (Not fileExists(m3u_playlist)) Then
                Throw New Exception("The M3U playlist you have selected does not exist. Please select a valid M3U playlist.")
            End If

        End If

        If (use_execute) Then

            If (execute_command = Nothing Or execute_command.Length = 0) Then
                Throw New Exception("No command entered. Please enter a valid command to execute.")
            End If

        End If

        ' Update values

        SilenceSettings.silence_length = silence_length
        SilenceSettings.use_smtp = use_smtp
        SilenceSettings.smtp_server = smtp_server
        SilenceSettings.smtp_username = smtp_username
        SilenceSettings.smtp_password = smtp_password
        SilenceSettings.smtp_from_address = smtp_from_address
        SilenceSettings.smtp_to_address = smtp_to_address
        SilenceSettings.use_m3u = use_m3u
        SilenceSettings.m3u_playlist = m3u_playlist
        SilenceSettings.use_execute = use_execute
        SilenceSettings.execute_command = execute_command

    End Sub

    ' Save the settings

    Public Shared Sub saveSettings()

        Try

            Dim file As File
            Dim writer As StreamWriter

            ' Open the file for writing

            writer = file.CreateText(Windows.Forms.Application.StartupPath & "\silence.dat")

            ' Write the data

            writer.WriteLine(SilenceSettings.silence_length)
            writer.WriteLine(SilenceSettings.use_smtp)
            writer.WriteLine(SilenceSettings.smtp_server)
            writer.WriteLine(SilenceSettings.smtp_username)
            writer.WriteLine(SilenceSettings.smtp_password)
            writer.WriteLine(SilenceSettings.smtp_from_address)
            writer.WriteLine(SilenceSettings.smtp_to_address)
            writer.WriteLine(SilenceSettings.use_m3u)
            writer.WriteLine(SilenceSettings.m3u_playlist)
            writer.WriteLine(SilenceSettings.use_execute)
            writer.WriteLine(SilenceSettings.execute_command)

            ' Close the file

            writer.Close()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information, "Error")

        End Try

    End Sub

    ' Load the settings

    Public Shared Sub loadSettings()

        ' Check to see if the settings file exists

        If (fileExists(Windows.Forms.Application.StartupPath & "\silence.dat")) Then

            ' Load the data

            Dim file As File
            Dim reader As StreamReader

            reader = file.OpenText(Windows.Forms.Application.StartupPath & "\silence.dat")

            ' Read the data in

            SilenceSettings.silence_length = reader.ReadLine
            SilenceSettings.use_smtp = reader.ReadLine
            SilenceSettings.smtp_server = reader.ReadLine
            SilenceSettings.smtp_username = reader.ReadLine
            SilenceSettings.smtp_password = reader.ReadLine
            SilenceSettings.smtp_from_address = reader.ReadLine
            SilenceSettings.smtp_to_address = reader.ReadLine
            SilenceSettings.use_m3u = reader.ReadLine
            SilenceSettings.m3u_playlist = reader.ReadLine
            SilenceSettings.use_execute = reader.ReadLine
            SilenceSettings.execute_command = reader.ReadLine

            ' Close the file

            reader.Close()

        Else

            ' Create a new file

            SilenceSettings.silence_length = 60
            SilenceSettings.use_smtp = False
            SilenceSettings.smtp_server = "localhost"
            SilenceSettings.smtp_username = "username"
            SilenceSettings.smtp_password = "password"
            SilenceSettings.smtp_from_address = "to-address@your-isp.com"
            SilenceSettings.smtp_to_address = "from-address@your-isp.com"
            SilenceSettings.use_m3u = False
            SilenceSettings.m3u_playlist = System.Windows.Forms.Application.StartupPath & "playlist.m3u"
            SilenceSettings.use_execute = False
            SilenceSettings.execute_command = "winver"

            SilenceSettings.saveSettings()

        End If

    End Sub

End Class

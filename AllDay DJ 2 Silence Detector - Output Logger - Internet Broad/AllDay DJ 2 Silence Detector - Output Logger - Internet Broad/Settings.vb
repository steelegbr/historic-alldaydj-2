Imports System.IO

Public Class Settings

    Private Shared sound_card As Integer
    Private Shared sound_input As Integer
    Private Shared now_and_next_file As String
    Private Shared internet_output As Integer

    Public Shared ReadOnly Property SHOUTCAST() As Integer
        Get
            Return 0
        End Get
    End Property

    Public Shared ReadOnly Property ICECAST() As Integer
        Get
            Return 1
        End Get
    End Property

    Public Shared ReadOnly Property SoundCard() As Integer
        Get
            Return Settings.sound_card
        End Get
    End Property

    Public Shared ReadOnly Property SoundInput() As Integer
        Get
            Return Settings.sound_input
        End Get
    End Property

    Public Shared ReadOnly Property NowAndNextFile() As String
        Get
            Return Settings.now_and_next_file
        End Get
    End Property

    Public Shared ReadOnly Property InternetOutput() As Integer
        Get
            Return Settings.internet_output
        End Get
    End Property

    ' Set the settings

    Public Shared Sub setSettings(ByVal sound_card As Integer, ByVal sound_input As Integer, ByVal now_and_next_file As String, ByVal internet_output As Integer)

        ' Check for valid values

        If (sound_card < 0) Then
            Throw New Exception("The sound card you entered was not valid. Please select a sound card from the drop-down menu.")
        End If

        If (sound_input < 0) Then
            Throw New Exception("The sound input you selected was not valid. Please selet a sound input from the drop-down menu.")
        End If

        If (Not fileExists(now_and_next_file)) Then
            Throw New Exception("The now and next file you selected does not exist. Please select a valid file and try again.")
        End If

        If (internet_output <> SHOUTCAST And internet_output <> ICECAST) Then
            Throw New Exception("You did not select a valid internet output. Please select either SHOUTCAST or ICECAST from the drop-down menu.")
        End If

        ' Now load the settings

        Settings.sound_card = sound_card
        Settings.sound_input = sound_input
        Settings.now_and_next_file = now_and_next_file
        Settings.internet_output = internet_output

    End Sub

    ' Save the settings

    Public Shared Sub saveSettings()

        Dim file As File
        Dim writer As StreamWriter

        ' Open the file for writing

        writer = file.CreateText(Windows.Forms.Application.StartupPath & "\settings.dat")

        ' Write the data

        writer.WriteLine(Settings.sound_card)
        writer.WriteLine(Settings.sound_input)
        writer.WriteLine(Settings.now_and_next_file)
        writer.WriteLine(Settings.internet_output)

        ' Close the file

        writer.Close()

    End Sub

    ' Load the settings

    Public Shared Sub loadSettings()

        ' Check to see if the settings file exists

        If (fileExists(Windows.Forms.Application.StartupPath & "\settings.dat")) Then

            ' Load the data

            Dim file As File
            Dim reader As StreamReader

            reader = file.OpenText(Windows.Forms.Application.StartupPath & "\settings.dat")

            ' Read the data in

            Settings.sound_card = reader.ReadLine()
            Settings.sound_input = reader.ReadLine()
            Settings.now_and_next_file = reader.ReadLine()
            Settings.internet_output = reader.ReadLine()

            ' Close the file

            reader.Close()

        Else

            ' Create a new file

            Settings.sound_card = 1
            Settings.sound_input = 0
            Settings.now_and_next_file = System.Windows.Forms.Application.StartupPath & "\now_and_next.txt"
            Settings.internet_output = Settings.SHOUTCAST

            Settings.saveSettings()

        End If

    End Sub

End Class

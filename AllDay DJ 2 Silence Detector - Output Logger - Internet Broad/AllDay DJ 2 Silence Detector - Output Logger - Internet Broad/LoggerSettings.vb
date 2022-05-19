Imports System.IO

Public Class LoggerSettings

    Private Shared keep_files_for As Integer
    Private Shared output_directory As String

    Public Shared ReadOnly Property KeepFilesFor() As Integer
        Get
            Return LoggerSettings.keep_files_for
        End Get
    End Property

    Public Shared ReadOnly Property OuputDirectory() As String
        Get
            Return LoggerSettings.output_directory
        End Get
    End Property

    ' Change the settings

    Public Shared Sub setSettings(ByVal keep_files_for As Integer, ByVal output_directory As String)

        ' Check for validity

        If (keep_files_for < 0) Then
            Throw New Exception("The number of days you wish to keep the files for is not valid. Please enter the number of days as a positive whole number (greater than zero).")
        End If

        If (output_directory = Nothing Or output_directory.Length = 0) Then
            Throw New Exception("You have not selected an output directory. Please select a valid output directory.")
        End If

        ' Update the variables

        LoggerSettings.keep_files_for = keep_files_for
        LoggerSettings.output_directory = output_directory

    End Sub

    ' Save the settings

    Public Shared Sub saveSettings()

        Try

            Dim file As File
            Dim writer As StreamWriter

            ' Open the file for writing

            writer = file.CreateText(Windows.Forms.Application.StartupPath & "\logger.dat")

            ' Write the data

            writer.WriteLine(LoggerSettings.keep_files_for)
            writer.WriteLine(LoggerSettings.output_directory)

            ' Close the file

            writer.Close()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information, "Error")

        End Try

    End Sub

    ' Load the settings

    Public Shared Sub loadSettings()

        ' Check to see if the settings file exists

        If (fileExists(Windows.Forms.Application.StartupPath & "\logger.dat")) Then

            ' Load the data

            Dim file As File
            Dim reader As StreamReader

            reader = file.OpenText(Windows.Forms.Application.StartupPath & "\logger.dat")

            ' Read the data in

            LoggerSettings.keep_files_for = reader.ReadLine
            LoggerSettings.output_directory = reader.ReadLine

            ' Close the file

            reader.Close()

        Else

            ' Create a new file

            LoggerSettings.keep_files_for = 42
            LoggerSettings.output_directory = System.Windows.Forms.Application.StartupPath & "/output/"

            LoggerSettings.saveSettings()

        End If

    End Sub

End Class

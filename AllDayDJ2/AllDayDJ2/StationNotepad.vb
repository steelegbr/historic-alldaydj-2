Imports System.IO   ' IO System

Public Class StationNotepad

    Private content As String = ""
    Private file_name As String

    ' Set and get the content

    Public Function getContent() As String
        Return Me.content.Trim()
    End Function

    Public Sub setContent(ByVal content As String)
        Me.content = content
    End Sub

    ' Constructor

    Public Sub New(ByVal file_name As String)

        Dim fs As IO.FileStream
        Dim sr As IO.StreamReader

        ' Open the file

        Me.file_name = file_name
        fs = New FileStream(file_name, FileMode.OpenOrCreate)

        ' Read the current content

        sr = New StreamReader(fs)
        sr.BaseStream.Seek(0, SeekOrigin.Begin)
        While (Not sr.EndOfStream)
            content = content & sr.ReadToEnd
        End While

        ' Close the connection

        sr.Close()
        fs.Close()
        sr = Nothing
        fs = Nothing

    End Sub

    ' Write the content to the file

    Public Sub writeContent()

        Dim fs As IO.FileStream
        Dim sw As IO.StreamWriter

        ' Open the file

        fs = New FileStream(Me.file_name, FileMode.Create)
        sw = New StreamWriter(fs)

        ' Write the data

        sw.WriteLine(Me.content)

        ' Close the connection

        sw.Close()
        fs.Close()
        sw = Nothing
        fs = Nothing

    End Sub

End Class

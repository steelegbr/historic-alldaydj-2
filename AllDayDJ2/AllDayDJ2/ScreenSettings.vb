Imports System.IO

Public Class ScreenSettings

    Private screen_main As Integer = 0
    Private screen_library As Integer = 0
    Private screen_mixer As Integer = 0
    Private persist_library As Boolean = False
    Private persist_mixer As Boolean = False

    Public ReadOnly Property ScreenMain() As Integer
        Get
            Return screen_main
        End Get
    End Property
    Public ReadOnly Property ScreenLibrary() As Integer
        Get
            Return screen_library
        End Get
    End Property
    Public ReadOnly Property ScreenMixer() As Integer
        Get
            Return screen_mixer
        End Get
    End Property
    Public ReadOnly Property PersistLibrary() As Boolean
        Get
            Return persist_library
        End Get
    End Property
    Public ReadOnly Property PersistMixer() As Boolean
        Get
            Return persist_mixer
        End Get
    End Property

    ' New screensettings object

    Public Sub New()

        ' Open the file (if it exists)

        If (General.fileExists(System.AppDomain.CurrentDomain.BaseDirectory & "screen.dat")) Then

            ' Open

            Dim fs As IO.FileStream
            Dim sr As IO.StreamReader

            fs = New FileStream(System.AppDomain.CurrentDomain.BaseDirectory & "screen.dat", FileMode.Open)
            sr = New StreamReader(fs)

            ' Read

            Me.screen_main = sr.ReadLine
            Me.screen_library = sr.ReadLine
            Me.screen_mixer = sr.ReadLine
            Me.persist_library = sr.ReadLine
            Me.persist_mixer = sr.ReadLine

            ' Close

            sr.Close()
            fs.Close()
            sr = Nothing
            fs = Nothing

        Else

            ' Create

            saveSettings()

        End If

    End Sub

    ' Set

    Public Sub setAttributes(ByVal screen_main As Integer, ByVal screen_library As Integer, ByVal screen_mixer As Integer, ByVal persist_library As Boolean, ByVal persist_mixer As Boolean)

        ' Assign

        Me.screen_main = screen_main
        Me.screen_library = screen_library
        Me.screen_mixer = screen_mixer
        Me.persist_library = persist_library
        Me.persist_mixer = persist_mixer

        ' Save

        saveSettings()

    End Sub

    ' Save

    Private Sub saveSettings()

        Dim fs As IO.FileStream
        Dim sw As IO.StreamWriter

        Try

            ' Open

            fs = New FileStream(System.AppDomain.CurrentDomain.BaseDirectory & "screen.dat", FileMode.Create)
            sw = New StreamWriter(fs)

            ' Write

            sw.WriteLine(Me.screen_main)
            sw.WriteLine(Me.screen_library)
            sw.WriteLine(Me.screen_mixer)
            sw.WriteLine(Me.persist_library)
            sw.WriteLine(Me.persist_mixer)

        Catch ex As Exception

            MsgBox("Unable to save screen settings!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error")

        Finally

            ' Close

            If (Not sw Is Nothing) Then
                sw.Close()
                sw = Nothing
            End If

            If (Not fs Is Nothing) Then
                fs.Close()
                fs = Nothing
            End If

        End Try

    End Sub

End Class

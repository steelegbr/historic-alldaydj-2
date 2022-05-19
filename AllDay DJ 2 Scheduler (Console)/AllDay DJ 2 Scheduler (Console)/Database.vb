Imports System.Data.OleDb   ' Database system

Public Class Database

    Private connection_string As String
    Private command As OleDbCommand
    Private connected As Boolean

    ' Constructor

    Public Sub New(ByVal filename As String)

        ' Set the connection string

        Me.connection_string = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & filename

        If (Not General.fileExists(filename)) Then
            Exit Sub
        End If

        ' Attempt the connection

        Try
            Me.command = New OleDbCommand
            With Me.command
                .Connection = New OleDbConnection(Me.connection_string)
                .Connection.Open()
            End With
            Me.connected = True
        Catch ex As Exception
            ErrorHandler.errorHandler(ex)
            Console.WriteLine("")
            Console.WriteLine("Press any key to quit.")
            Console.ReadKey()
            End
        End Try

    End Sub

    ' Disconnect this database

    Public Sub disconnect()

        Me.command.Connection.Close()
        Me.connected = False
        Me.command = Nothing

    End Sub

    ' Connect to this database
    ' Should only be used if restting a connection

    Public Sub connect()

        Try
            With Me.command
                .Connection = New OleDbConnection(Me.connection_string)
                .Connection.Open()
            End With
        Catch ex As Exception
            ErrorHandler.errorHandler("A database error occurred. Terminating program.")
            End
        End Try

        Me.connected = True

    End Sub

    ' Execute a SQL command

    Public Function execute(ByVal query As String) As Boolean

        Dim temp As Integer

        Try
            Me.command.CommandText = query
            temp = Me.command.ExecuteNonQuery()
        Catch ex As Exception
            'ErrorHandler.errorHandler("A database error ocurred." & Chr(13) & Chr(10) & "Description: " & ex.Message)
            Return False
        End Try

        Return True

    End Function

    ' Executes an SQL statement and returns a recordsets

    Public Function executeRS(ByVal query As String) As OleDbDataReader

        Try
            Me.command.CommandText = query
            Return Me.command.ExecuteReader(CommandBehavior.Default)
        Catch ex As Exception
            'ErrorHandler.errorHandler("A database error ocurred." & Chr(13) & Chr(10) & "Description: " & ex.Message & Chr(13) & Chr(10) & "SQL Query: " & query)
            Return Nothing
        End Try

    End Function

    ' Returns the entire list of tables in the database

    Public Function getTableList() As DataTable

        Try
            Return Me.command.Connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

End Class

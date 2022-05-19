Public Class Day

    Private selected_date As Date
    Private hours As New List(Of Playlist)

    Public ReadOnly Property dDate() As Date
        Get
            Return Me.selected_date
        End Get
    End Property
    Public Property hour(ByVal index As Integer) As Playlist
        Get
            If (hours Is Nothing) Then
                Return Nothing
            ElseIf (index < 0 Or index > (Me.hours.Count - 1)) Then
                Return Nothing
            Else
                Return hours.Item(index)
            End If
        End Get
        Set(ByVal value As Playlist)
            Me.hours.Item(index) = value
        End Set
    End Property

    ' Constructor

    Public Sub New(ByVal selected_date As Date, ByVal load_from_db As Boolean)

        Dim counter As Integer = 0
        Dim db As Database
        Dim rs As OleDb.OleDbDataReader
        Dim pl_string As String
        Dim pl_strings() As String
        Dim item_string() As String
        Dim sub_counter As Integer

        ' Create 24 hours

        For counter = 0 To 23
            hours.Add(Nothing)
        Next

        ' Set the date

        Me.selected_date = selected_date

        Try

            ' Load date as appropriate

            If (load_from_db) Then

                ' Make the connection

                db = New Database(ProgramSettings.schedule_db_location)

                ' For every hour

                For counter = 0 To 23

                    ' Get the rs

                    If (counter < 10) Then
                        rs = db.executeRS("SELECT [0" & counter & "00] FROM schedule WHERE [date] = """ & Format(Me.selected_date, "dd/MM/yyyy") & """")
                    Else
                        rs = db.executeRS("SELECT [" & counter & "00] FROM schedule WHERE [date] = """ & Format(Me.selected_date, "dd/MM/yyyy") & """")
                    End If

                    ' Load the selected playlist

                    While rs.Read

                        ' Get and split the string

                        pl_string = rs.GetString(0)

                        If (pl_string Is Nothing Or pl_string = "") Then
                            Exit While
                        End If

                        pl_strings = pl_string.Split(";")

                        ' Get the item strings

                        For sub_counter = 0 To (pl_strings.Length - 1)
                            item_string = pl_strings(sub_counter).Split("-")
                            If (Not item_string Is Nothing) Then
                                If ((Not item_string(0) Is Nothing) And (Not item_string(1) Is Nothing)) Then

                                    ' Generate hour if required

                                    If (Me.hours(counter) Is Nothing) Then
                                        Me.hours(counter) = New Playlist(Nothing, "Temp")
                                    End If

                                    ' Otherwise add the item

                                    Me.hours(counter).addToPlaylist(New AudioItem(item_string(0), item_string(1), False))

                                End If
                            End If
                        Next

                    End While

                    ' Close the results

                    If (Not rs Is Nothing) Then
                        rs.Close()
                        rs = Nothing
                    End If

                Next

                ' Close the database connection

                db.disconnect()
                db = Nothing

            End If

        Catch ex As Exception
            ErrorHandler.errorHandler(ex)
        End Try

    End Sub

    ' Save to database

    Public Sub saveToDb()

        Dim db As New Database(ProgramSettings.schedule_db_location)
        Dim query As String
        Dim counter As Integer
        Dim sub_counter As Integer

        ' Build the query

        query = "UPDATE schedule SET "

        For counter = 0 To 23

            ' Start of each hour

            If (counter < 10) Then
                query = query & "0" & counter & "00 = """
            Else
                query = query & counter & "00 = """
            End If

            ' Add in the hour string

            If (Not Me.hours(counter) Is Nothing) Then
                If (Not Me.hours(counter).getPlaylistLength = 0) Then

                    ' Add the items

                    For sub_counter = 0 To (Me.hours(counter).getPlaylistLength - 1)
                        query = query & Me.hours(counter).getItem(sub_counter).getTrackId & "-" & Me.hours(counter).getItem(sub_counter).getDbTable & ";"
                    Next

                    ' Lop off the end

                    query = query.Substring(0, (query.Length - 1))

                End If
            End If

            query = query & """, "

        Next

        ' Finish off the query

        query = query.Remove(query.Length - 2, 2) & " WHERE [date] = """ & Format(Me.selected_date, "dd/MM/yyyy") & """"

        ' Execute

        db.execute(query)

        ' Disconnect

        db.disconnect()
        db = Nothing

    End Sub

    Public Sub saveNewToDb()

        Dim db As New Database(ProgramSettings.schedule_db_location)
        Dim query As String
        Dim counter As Integer
        Dim sub_counter As Integer

        ' Build the query

        query = "INSERT INTO schedule VALUES (""" & Format(Me.selected_date, "dd/MM/yyyy") & """, "

        For counter = 0 To 23

            query = query & """"

            ' Add in the hour string

            If (Not Me.hours(counter) Is Nothing) Then
                If (Not Me.hours(counter).getPlaylistLength = 0) Then

                    ' Add the items

                    For sub_counter = 0 To (Me.hours(counter).getPlaylistLength - 1)
                        query = query & Me.hours(counter).getItem(sub_counter).getTrackId & "-" & Me.hours(counter).getItem(sub_counter).getDbTable & ";"
                    Next

                    ' Lop off the end

                    query = query.Substring(0, (query.Length - 1))

                End If
            End If

            query = query & """, "

        Next

        ' End query

        query = query.Substring(0, (query.Length - 2))
        query = query & ")"

        ' Execute

        db.execute("DELETE FROM schedule WHERE [Date] = """ & Format(Me.selected_date, "dd/MM/yyyy") & """")
        db.execute(query)

        ' Disconnect

        db.disconnect()
        db = Nothing

    End Sub

    ' Check if we are looking at a historic entry :)

    Public Function checkDay() As Day

        ' Compare date to now

        If (DateDiff(DateInterval.Day, Me.selected_date, Now) >= 1) Then

            ' Remove from the database

            Dim db As New Database(ProgramSettings.schedule_db_location)
            db.execute("DELETE FROM schedule WHERE [date] = """ & Format(Me.selected_date, "dd/mm/yyyy") & """")
            db.disconnect()
            db = Nothing

            ' Remove entry from memory

            Return Nothing

        Else

            ' All good

            Return Me

        End If

    End Function

End Class

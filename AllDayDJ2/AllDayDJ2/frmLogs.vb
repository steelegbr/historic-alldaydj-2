Public Class frmLogs

    Private GridPrinter As DataGridPrinter

    ' Load time

    Private Sub frmLogs_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Default dates

        Me.calendarEnd.TodayDate = Now

    End Sub

    ' Load the data

    Private Sub btnSetDates_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSetDates.Click

        Dim connection_string As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & General.program_settings.getLogsLocation
        Dim connection As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim ds As New DataSet

        ' Connect to the database

        On Error Resume Next

        connection.ConnectionString = connection_string
        connection.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM log WHERE [Time Started] >= """ & Me.calendarStart.SelectionStart & """ AND [Time Started] <= """ & Me.calendarEnd.SelectionStart.AddDays(1) & """", connection)

        ' Get the data

        da.Fill(ds)
        Me.dgLog.DataSource = ds.Tables(0)

        ' By default there is no DataGridTableStyle object.
        ' Add all DataSet table's style to the DataGrid
        Dim dTable As DataTable
        For Each dTable In ds.Tables

            Dim dgStyle As DataGridTableStyle = New DataGridTableStyle
            dgStyle.MappingName = dTable.TableName
            Me.dgLog.TableStyles.Add(dgStyle)
        Next
        ' DataGrid settings
        Me.dgLog.CaptionText = "AllDay DJ Logs (" & Me.calendarStart.SelectionStart & " - " & Me.calendarEnd.SelectionStart & ")"
        Me.dgLog.HeaderFont = New Font("Verdana", 12)


    End Sub

    ' Print

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        'Me.printc = New Print.PrinterClass(Me.pdMain, Me.dgLog)
        'Me.pdMain.Print()

        If (Me.GridPrinter Is Nothing) Then
            Me.GridPrinter = New DataGridPrinter(Me.dgLog)
        End If

        With GridPrinter
            .HeaderText = "AllDay DJ Logs (" & Me.calendarStart.SelectionStart & " - " & Me.calendarEnd.SelectionStart & ")"
            .HeaderHeightPercent = 5
            .FooterHeightPercent = 5
            .InterSectionSpacingPercent = 1
            .CellGutter = 1
            .GridPen.Width = 1
            .PrintDocument.DefaultPageSettings.Landscape = True
            .PrintFont = New Font(.PrintFont.Name, 6, FontStyle.Regular, GraphicsUnit.Pixel)
        End With

        GridPrinter.Print()

    End Sub

    ' Clear the logs

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click

        Dim db As Database

        ' Confirm thr user wishes to clear the logs

        If (MsgBox("Are you sure you wish to clear the logs?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No) Then
            Exit Sub
        End If

        ' Make the connection, delete and close

        db = New Database(General.program_settings.getLogsLocation)
        db.execute("DELETE * FROM log")
        db.disconnect()
        db = Nothing

        ' Refresh the display

        Me.btnSetDates_Click(Nothing, Nothing)

    End Sub

    ' Close the screen

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Hide()

    End Sub

End Class
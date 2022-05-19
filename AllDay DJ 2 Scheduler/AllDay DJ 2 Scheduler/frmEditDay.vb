Public Class frmEditDay

    Private time_labels(0 To 23) As Label
    Private cmb_rotations(0 To 23) As ComboBox
    Private day As String

    ' Load time events

    Private Sub frmEditDay_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim counter As Integer
        Dim sub_counter As Integer

        ' Control arrays

        time_labels(0) = Me.lblHour0
        time_labels(1) = Me.lblHour1
        time_labels(2) = Me.lblHour2
        time_labels(3) = Me.lblHour3
        time_labels(4) = Me.lblHour4
        time_labels(5) = Me.lblHour5
        time_labels(6) = Me.lblHour6
        time_labels(7) = Me.lblHour7
        time_labels(8) = Me.lblHour8
        time_labels(9) = Me.lblHour9
        time_labels(10) = Me.lblHour10
        time_labels(11) = Me.lblHour11
        time_labels(12) = Me.lblHour12
        time_labels(13) = Me.lblHour13
        time_labels(14) = Me.lblHour14
        time_labels(15) = Me.lblHour15
        time_labels(16) = Me.lblHour16
        time_labels(17) = Me.lblHour17
        time_labels(18) = Me.lblHour18
        time_labels(19) = Me.lblHour19
        time_labels(20) = Me.lblHour20
        time_labels(21) = Me.lblHour21
        time_labels(22) = Me.lblHour22
        time_labels(23) = Me.lblHour23

        cmb_rotations(0) = Me.cmbRotation0
        cmb_rotations(1) = Me.cmbRotation1
        cmb_rotations(2) = Me.cmbRotation2
        cmb_rotations(3) = Me.cmbRotation3
        cmb_rotations(4) = Me.cmbRotation4
        cmb_rotations(5) = Me.cmbRotation5
        cmb_rotations(6) = Me.cmbRotation6
        cmb_rotations(7) = Me.cmbRotation7
        cmb_rotations(8) = Me.cmbRotation8
        cmb_rotations(9) = Me.cmbRotation9
        cmb_rotations(10) = Me.cmbRotation10
        cmb_rotations(11) = Me.cmbRotation11
        cmb_rotations(12) = Me.cmbRotation12
        cmb_rotations(13) = Me.cmbRotation13
        cmb_rotations(14) = Me.cmbRotation14
        cmb_rotations(15) = Me.cmbRotation15
        cmb_rotations(16) = Me.cmbRotation16
        cmb_rotations(17) = Me.cmbRotation17
        cmb_rotations(18) = Me.cmbRotation18
        cmb_rotations(19) = Me.cmbRotation19
        cmb_rotations(20) = Me.cmbRotation20
        cmb_rotations(21) = Me.cmbRotation21
        cmb_rotations(22) = Me.cmbRotation22
        cmb_rotations(23) = Me.cmbRotation23

        ' Fill the labels

        For counter = 0 To 23
            If (counter < 10) Then
                Me.time_labels(counter).Text = "0" & counter & "00"
            Else
                Me.time_labels(counter).Text = counter & "00"
            End If
        Next

        ' And now the combo boxes

        For counter = 0 To 23

            Me.cmb_rotations(counter).Items.Clear()

            Me.cmb_rotations(counter).Items.Add(" ")

            ' Use the list of rotations

            For sub_counter = 0 To (ProgramSettings.rotations.Count - 1)
                Me.cmb_rotations(counter).Items.Add(ProgramSettings.rotations(sub_counter).rotation_name)
            Next

        Next

    End Sub

    ' Load the day

    Public Sub loadDay(ByVal day As String)

        Dim counter As Integer
        Dim db As New Database(ProgramSettings.parts_db_location)
        Dim rs As OleDb.OleDbDataReader
        Dim sub_counter As Integer

        Me.day = day
        Me.Text = "Edit Day - " & day

        ' Load the actual rotations

        For counter = 0 To 23

            Try

                If (counter < 10) Then
                    rs = db.executeRS("SELECT [0" & counter & "00] FROM week WHERE day = """ & Me.day & """")
                Else
                    rs = db.executeRS("SELECT [" & counter & "00] FROM week WHERE day = """ & Me.day & """")
                End If

                While rs.Read

                    For sub_counter = 0 To (Me.cmb_rotations(counter).Items.Count - 1)
                        If (Me.cmb_rotations(counter).Items.Item(sub_counter).ToString.Equals(rs.GetString(0))) Then
                            Me.cmb_rotations(counter).SelectedIndex = sub_counter
                        End If
                    Next

                End While

                rs.Close()
                rs = Nothing

            Catch ex As Exception
                ' Do nada
            End Try

            If (Not rs Is Nothing) Then
                rs.Close()
            End If
            rs = Nothing

        Next

    End Sub

    ' Save and close

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim db As New Database(ProgramSettings.parts_db_location)
        Dim query As String = ""
        Dim counter As Integer

        ' Build the query

        query = "UPDATE week SET "

        For counter = 0 To 23

            ' Take slightly different action if we haven't hit 10am yet

            If (counter < 10) Then
                query = query & "0" & counter & "00 = """ & Me.cmb_rotations(counter).Text & """, "
            Else
                query = query & counter & "00 = """ & Me.cmb_rotations(counter).Text & """, "
            End If

        Next

        query = query.Substring(0, (query.Length - 2))
        query = query & " WHERE day = """ & Me.day & """"

        ' Now execute and close

        db.execute(query)
        db.disconnect()
        db = Nothing

        Me.Close()

    End Sub

End Class
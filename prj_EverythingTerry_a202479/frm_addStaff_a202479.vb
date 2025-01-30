Public Class frm_addStaff_a202479
    Dim current_staff_id As String
    Private Sub frm_addStaff_a202479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"
        grd_staff.Columns(2).HeaderText = "Position"

    End Sub

    Private Sub refresh_grid()
        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A202479 order by fld_staff_id")
    End Sub

    Private Function generate_staff_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTID FROM TBL_STAFF_A202479").Rows(0).Item("LASTID")
        Dim newid As String = "ET" & Mid(lastid, 3) + 1
        Return newid
    End Function

    Private Sub get_current_staff_id()
        Dim current_row As Integer = grd_staff.CurrentRow.Index

        current_staff_id = grd_staff(0, current_row).Value

        txt_staff_id.Text = generate_staff_id()

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_STAFF_A202479 VALUES ('" & txt_staff_id.Text & "', '" & txt_staff_name.Text & "', '" & txt_position.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()


            grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A202479")
            txt_staff_id.Text = generate_staff_id()
            txt_staff_name.Text = ""
            txt_position.Text = ""

        Catch ex As Exception
            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub


    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_staffManager_a202479.Show()
        Me.Close()
    End Sub

    Private Sub grd_staff_MouseClick(sender As Object, e As MouseEventArgs) Handles grd_staff.MouseClick
        get_current_staff_id()
    End Sub


End Class
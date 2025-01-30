Public Class frm_staffManager_a202479
    Dim current_staff_id As String

    Private Sub frm_staffManager_a202479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"
        grd_staff.Columns(2).HeaderText = "Position"

    End Sub

    Private Sub refresh_grid()
        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A202479 order by fld_staff_id")
    End Sub

    Private Sub get_current_staff_id()
        Dim current_row As Integer = grd_staff.CurrentRow.Index

        current_staff_id = grd_staff(0, current_row).Value

        txt_staff_id.Text = current_staff_id
        txt_staff_name.Text = grd_staff(1, current_row).Value
        txt_position.Text = grd_staff(2, current_row).Value

    End Sub

    Private Sub clear_fields()
        txt_staff_id.Text = ""
        txt_staff_name.Text = ""
        txt_position.Text = ""
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a202479.Show()
        Me.Close()
    End Sub



    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_STAFF_A202479 SET FLD_STAFF_ID='" & txt_staff_id.Text & "' WHERE FLD_STAFF_ID='" & current_staff_id & "'")
        run_sql_command("UPDATE TBL_STAFF_A202479 SET FLD_STAFF_NAME='" & txt_staff_name.Text & "' WHERE FLD_STAFF_ID='" & current_staff_id & "'")
        run_sql_command("UPDATE TBL_STAFF_A202479 SET FLD_STAFF_POSITION='" & txt_position.Text & "' WHERE FLD_STAFF_ID='" & current_staff_id & "'")

        Beep()
        MsgBox("You have successfully updated the staff """ & current_staff_id & """.")
        refresh_grid()
        clear_fields()
        get_current_staff_id()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the course """ & current_staff_id & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_STAFF_A202479 WHERE FLD_STAFF_ID='" & current_staff_id & "'")

            Beep()
            MsgBox("The staff """ & current_staff_id & """ has been successfully deleted.")
        End If
        refresh_grid()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frm_addStaff_a202479.Show()
        Me.Close()
    End Sub

    Private Sub grd_staff_MouseClick(sender As Object, e As MouseEventArgs) Handles grd_staff.MouseClick
        get_current_staff_id()
    End Sub
End Class
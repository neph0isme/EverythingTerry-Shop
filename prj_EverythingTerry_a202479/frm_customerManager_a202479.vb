Public Class frm_customerManager_a202479
    Dim current_cust_id As String

    Private Sub frm_customerManager_a202479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

        clear_fields()

        get_current_cust_id()

        grd_cust.Columns(0).HeaderText = "Customer ID"
        grd_cust.Columns(1).HeaderText = "Customer Name"
        grd_cust.Columns(2).HeaderText = "Phone Number"
    End Sub

    Private Sub refresh_grid()
        grd_cust.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A202479 order by fld_customer_id")
    End Sub

    Private Sub get_current_cust_id()
        Dim current_row As Integer = grd_cust.CurrentRow.Index

        current_cust_id = grd_cust(0, current_row).Value

        txt_customer_id.Text = current_cust_id
        txt_customer_name.Text = grd_cust(1, current_row).Value
        txt_phone.Text = grd_cust(2, current_row).Value
    End Sub

    Private Sub clear_fields()
        txt_customer_id.Text = ""
        txt_customer_name.Text = ""
        txt_phone.Text = ""
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_CUSTOMER_A202479 SET FLD_CUSTOMER_ID='" & txt_customer_id.Text & "' WHERE FLD_CUSTOMER_ID='" & current_cust_id & "'")
        run_sql_command("UPDATE TBL_CUSTOMER_A202479 SET FLD_CUSTOMER_NAME='" & txt_customer_name.Text & "' WHERE FLD_CUSTOMER_ID='" & current_cust_id & "'")
        run_sql_command("UPDATE TBL_CUSTOMER_A202479 SET FLD_CUSTOMER_NUMBER='" & txt_phone.Text & "' WHERE FLD_CUSTOMER_ID='" & current_cust_id & "'")

        Beep()
        MsgBox("You have successfully updated the customer """ & current_cust_id & """.")
        refresh_grid()
        clear_fields()
        get_current_cust_id()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the course """ & current_cust_id & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_CUSTOMER_A202479 WHERE FLD_CUSTOMER_ID='" & current_cust_id & "'")

            Beep()
            MsgBox("The customer """ & current_cust_id & """ has been successfully deleted.")
        End If
        refresh_grid()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frm_addCust_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub grd_cust_MouseClick(sender As Object, e As MouseEventArgs) Handles grd_cust.MouseClick
        get_current_cust_id()
    End Sub
End Class
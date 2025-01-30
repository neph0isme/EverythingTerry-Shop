Public Class frm_addCust_a202479
    Dim current_cust_id As String

    Private Sub frm_addCust_a202479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

        grd_cust.Columns(0).HeaderText = "Customer ID"
        grd_cust.Columns(1).HeaderText = "Customer Name"
        grd_cust.Columns(2).HeaderText = "Phone Number
"
    End Sub

    Private Sub refresh_grid()
        grd_cust.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A202479 order by fld_customer_id")
    End Sub

    Private Function generate_cust_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTID FROM TBL_CUSTOMER_A202479").Rows(0).Item("LASTID")
        Dim newid As String = "C" & Mid(lastid, 2) + 1
        Return newid
    End Function

    Private Sub get_current_cust_id()
        Dim current_row As Integer = grd_cust.CurrentRow.Index

        current_cust_id = grd_cust(0, current_row).Value

        txt_cust_id.Text = generate_cust_id()

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A202479 VALUES ('" & txt_cust_id.Text & "', '" & txt_cust_name.Text & "', '" & txt_number.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()


            grd_cust.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A202479")
            txt_cust_id.Text = generate_cust_id()
            txt_cust_name.Text = ""
            txt_number.Text = ""

        Catch ex As Exception
            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_customerManager_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub grd_cust_MouseClick(sender As Object, e As MouseEventArgs) Handles grd_cust.MouseClick
        get_current_cust_id()
    End Sub
End Class
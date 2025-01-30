Public Class frm_customer_a202479
    Dim current_cust_id As String

    Private Sub frm_customer_a202479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_cust_id.DataSource = run_sql_query("select fld_customer_id from tbl_customer_a202479 order by fld_customer_id")
        lst_cust_id.DisplayMember = "fld_customer_id"

        refresh_text(lst_cust_id.Text)
    End Sub
    Private Sub lst_cust_id_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_cust_id.MouseClick
        refresh_text(lst_cust_id.Text)
    End Sub
    Private Sub refresh_text(cust_id As String)

        Dim mysql As String = "select * from TBL_CUSTOMER_A202479 where fld_customer_id='" & cust_id & "'"
        Dim mytable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mytable)

        txt_name.Text = mytable.Rows(0).Item("fld_customer_name")
        txt_num.Text = mytable.Rows(0).Item("fld_customer_number")

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a202479.Show()
        Me.Hide()
    End Sub


End Class
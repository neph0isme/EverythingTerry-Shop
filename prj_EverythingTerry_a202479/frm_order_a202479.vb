Public Class frm_order_a202479
    Private Sub frm_order_a202479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

        grd_custID.Columns(0).HeaderText = "Order ID"
        grd_custID.Columns(1).HeaderText = "Customer ID"
        grd_custID.Columns(2).HeaderText = "Staff ID"
        grd_custID.Columns(3).HeaderText = "Subtotal"

    End Sub

    Private Sub refresh_grid()
        grd_custID.DataSource = run_sql_query("SELECT * FROM TBL_ORDER_A202479 order by fld_order_id")
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        frm_mainmenu_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ordDet_Click(sender As Object, e As EventArgs) Handles btn_ordDet.Click
        frm_ordDet_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        frm_invoice_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        frm_orderHistory_a202479.Show()
        Me.Hide()
    End Sub


End Class
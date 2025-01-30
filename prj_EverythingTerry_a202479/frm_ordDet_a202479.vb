Public Class frm_ordDet_a202479
    Private Sub frm_ordDet_a202479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_ordDet.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTORDER_A202479 order by fld_order_id")

        grd_ordDet.Columns(0).HeaderText = "Order ID"
        grd_ordDet.Columns(1).HeaderText = "Product ID"
        grd_ordDet.Columns(2).HeaderText = "Quantity"
        grd_ordDet.Columns(3).HeaderText = "Price per Unit"
        grd_ordDet.Columns(4).HeaderText = "Subtotal"

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_order_a202479.Show()
        Me.Hide()
    End Sub
End Class
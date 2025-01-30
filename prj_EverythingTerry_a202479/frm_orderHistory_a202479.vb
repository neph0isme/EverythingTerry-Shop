Public Class frm_orderHistory_a202479

    Private Sub frm_orderHistory_a202479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_list()
        refresh_grd("")
    End Sub

    Private Sub lst_orderID_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_orderID.MouseClick
        refresh_grd(lst_orderID.Text)
        refresh_text(lst_orderID.Text)
        refresh_price(lst_orderID.Text)
    End Sub

    Private Sub refresh_list()

        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A202479"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lst_orderID.DataSource = mydatatable
        lst_orderID.DisplayMember = "FLD_ORDER_ID"

    End Sub

    Private Sub refresh_grd(id As String)
        Dim mysql As String = "SELECT FLD_PRODUCT_ID, FLD_PRICE, FLD_QUANTITY, FLD_SUBTOTAL FROM TBL_PRODUCTORDER_A202479 WHERE FLD_ORDER_ID = '" & id & "' "
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order.DataSource = mydatatable
        grd_order.Columns(0).HeaderText = "Product ID"
        grd_order.Columns(1).HeaderText = "Price"
        grd_order.Columns(2).HeaderText = "Quantity"
        grd_order.Columns(3).HeaderText = "Subtotal"

        grd_order.AllowUserToAddRows = False

    End Sub

    Private Sub refresh_text(id As String)
        Dim mysql As String = "SELECT * FROM TBL_ORDER_A202479 WHERE FLD_ORDER_ID = '" & id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        cmb_custID.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")
        cmb_staffID.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")

        refresh_cust(cmb_custID.Text)
        refresh_staff(cmb_staffID.Text)

    End Sub

    Private Sub refresh_cust(id As String)

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A202479 WHERE FLD_CUSTOMER_ID = '" & id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_custName.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_NAME")
        txt_Num.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_NUMBER")

    End Sub

    Private Sub refresh_staff(id As String)

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A202479 WHERE FLD_STAFF_ID = '" & id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_stfName.Text = mydatatable.Rows(0).Item("FLD_STAFF_NAME")
        txt_position.Text = mydatatable.Rows(0).Item("FLD_STAFF_POSITION")

    End Sub

    Private Sub refresh_price(id As String)

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A202479 WHERE FLD_ORDER_ID = '" & id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lbl_total.Text = mydatatable.Rows(0).Item("FLD_TOTAL")

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click

        cmb_custID.Text = ""
        txt_custName.Text = ""
        txt_Num.Text = ""
        cmb_staffID.Text = ""
        txt_stfName.Text = ""
        txt_position.Text = ""
        refresh_grd("")

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_order_a202479.Show()
        Me.Hide()
    End Sub


End Class
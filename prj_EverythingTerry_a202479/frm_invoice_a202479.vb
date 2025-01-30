Public Class frm_invoice_a202479
    Private Sub frm_invoice_a202479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grd("")
        refresh_list()
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

    Private Sub refresh_list()

        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A202479"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lst_orderID.DataSource = mydatatable
        lst_orderID.DisplayMember = "FLD_ORDER_ID"

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_order_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub lst_orderID_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_orderID.MouseClick
        Dim selectedOrderID As String = lst_orderID.Text
        refresh_grd(selectedOrderID)
        lbl_order_id.Text = selectedOrderID
        lbl_cust_id.Text = GetCustomerID(selectedOrderID)
        lbl_staff_id.Text = GetStaffID(selectedOrderID)

        Dim customerDetails As DataTable = GetCustomerDetails(lbl_cust_id.Text)
        Dim staffDetails As DataTable = GetStaffDetails(lbl_staff_id.Text)
        Dim total As Double = run_sql_query("SELECT FLD_TOTAL FROM TBL_ORDER_A202479 WHERE FLD_ORDER_ID = '" & selectedOrderID & "'").Rows(0).Item("FLD_TOTAL")

        If customerDetails.Rows.Count > 0 Then
            lbl_name.Text = customerDetails.Rows(0).Item("FLD_CUSTOMER_NAME").ToString()
            lbl_phone.Text = customerDetails.Rows(0).Item("FLD_CUSTOMER_NUMBER").ToString()
            lbl_staffName.Text = staffDetails.Rows(0).Item("FLD_STAFF_NAME").ToString
            lbl_total.Text = total

        Else
            lbl_name.Text = "N/A"
            lbl_phone.Text = "N/A"
            lbl_staffName.Text = "N/A"
            lbl_total.Text = "N/A"
        End If
    End Sub

    Private Function GetCustomerID(orderID As String) As String
        Dim mysql As String = "SELECT FLD_CUSTOMER_ID FROM TBL_ORDER_A202479 WHERE FLD_ORDER_ID = '" & orderID & "'"
        Dim dataTable As New DataTable
        Dim dataAdapter As New OleDb.OleDbDataAdapter(mysql, myconnection)
        dataAdapter.Fill(dataTable)

        If dataTable.Rows.Count > 0 Then
            Return dataTable.Rows(0).Item("FLD_CUSTOMER_ID").ToString()
        Else
            Return String.Empty
        End If
    End Function

    Private Function GetStaffID(orderID As String) As String
        Dim mysql As String = "SELECT FLD_STAFF_ID FROM TBL_ORDER_A202479 WHERE FLD_ORDER_ID = '" & orderID & "'"
        Dim dataTable As New DataTable
        Dim dataAdapter As New OleDb.OleDbDataAdapter(mysql, myconnection)
        dataAdapter.Fill(dataTable)

        If dataTable.Rows.Count > 0 Then
            Return dataTable.Rows(0).Item("FLD_STAFF_ID").ToString()
        Else
            Return String.Empty
        End If
    End Function

    Private Function GetCustomerDetails(customerID As String) As DataTable
        Dim mysql As String = "SELECT FLD_CUSTOMER_NAME, FLD_CUSTOMER_NUMBER FROM TBL_CUSTOMER_A202479 WHERE FLD_CUSTOMER_ID = '" & customerID & "'"
        Dim dataTable As New DataTable
        Dim dataAdapter As New OleDb.OleDbDataAdapter(mysql, myconnection)
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function

    Private Function GetStaffDetails(staffID As String) As DataTable
        Dim mysql As String = "SELECT FLD_STAFF_NAME FROM TBL_STAFF_A202479 WHERE FLD_STAFF_ID = '" & staffID & "'"
        Dim dataTable As New DataTable
        Dim dataAdapter As New OleDb.OleDbDataAdapter(mysql, myconnection)
        dataAdapter.Fill(dataTable)
        Return dataTable
    End Function


End Class
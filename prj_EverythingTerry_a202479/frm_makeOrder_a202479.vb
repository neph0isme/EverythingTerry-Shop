Public Class frm_makeOrder_a202479
    Dim order_id As String
    Dim lastrow As Integer
    Dim total As Double

    Private Sub frm_makeOrder_a202479_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_list()
        refresh_grd()
        refresh_cmb()

    End Sub

    Private Function generate_order() As String
        Dim lastorderResult As Object = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTORDER FROM TBL_ORDER_A202479").Rows(0).Item("LASTORDER")

        If lastorderResult IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(lastorderResult.ToString()) Then
            Dim neworder As String = "OD" & Mid(lastorderResult, 3) + 1
            Return neworder
        Else
            Return "OD1"
        End If
    End Function

    Private Sub refresh_list()
        lst_productID.DataSource = run_sql_query("SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A202479 ORDER BY FLD_PRODUCT_ID")
        lst_productID.DisplayMember = "FLD_PRODUCT_ID"
    End Sub

    Private Sub refresh_grd()

        grd_order.ColumnCount = 5
        grd_order.Columns(0).HeaderText = "Product ID"
        grd_order.Columns(1).HeaderText = "Product Name"
        grd_order.Columns(2).HeaderText = "Price"
        grd_order.Columns(3).HeaderText = "Quantity"
        grd_order.Columns(4).HeaderText = "Subtotal"

        grd_order.AllowUserToAddRows = False

    End Sub

    Private Sub refresh_cmb()
        Dim mysql As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A202479"
        Dim mysql2 As String = "SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMER_A202479 ORDER BY FLD_CUSTOMER_ID"

        Dim mydatatable As New DataTable
        Dim mydatatable2 As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)

        myreader.Fill(mydatatable)
        myreader2.Fill(mydatatable2)

        cmb_staffID.DataSource = mydatatable
        cmb_custID.DataSource = mydatatable2

        cmb_staffID.DisplayMember = "FLD_STAFF_ID"
        cmb_custID.DisplayMember = "FLD_CUSTOMER_ID"
    End Sub

    Private Sub lst_productID_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_productID.MouseClick
        refresh_text(lst_productID.Text)
    End Sub

    Private Sub refresh_text(id As String)

        Dim mysql As String = "select * from TBL_PRODUCTS_A202479 where fld_product_id='" & id & "'"
        Dim mytable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mytable)

        txt_product_name.Text = mytable.Rows(0).Item("fld_product_name")
        txt_price.Text = mytable.Rows(0).Item("fld_price")
        txt_series.Text = mytable.Rows(0).Item("fld_series")

        Try
            pic_prod.BackgroundImage = Image.FromFile("C:\Users\User\source\repos\prj_EverythingTerry_a202479\prj_EverythingTerry_a202479\bin\Debug\pictures\" & id & ".jpg")
        Catch ex As Exception
            pic_prod.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub


    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_atc_Click(sender As Object, e As EventArgs) Handles btn_atc.Click
        Dim quantity As Double
        Double.TryParse(nud_qty.Value, quantity)


        If quantity > 0 Then

            Dim subtotal As Double
            subtotal = txt_price.Text * quantity

            grd_order.RowCount = grd_order.RowCount + 1
            lastrow = grd_order.RowCount - 1

            grd_order(0, lastrow).Value = lst_productID.Text
            grd_order(1, lastrow).Value = txt_product_name.Text
            grd_order(2, lastrow).Value = txt_price.Text
            grd_order(3, lastrow).Value = quantity
            grd_order(4, lastrow).Value = subtotal

            nud_qty.Value = 0
            total = total + subtotal
            lbl_totalNum.Text = total.ToString
        Else
            Beep()
            MsgBox("Product quantity is out of range.")
        End If
        txt_product_name.Clear()
        txt_price.Clear()
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        order_id = generate_order()

        run_sql_command("INSERT INTO TBL_ORDER_A202479 VALUES ('" & order_id & "', '" & cmb_custID.Text & "','" & cmb_staffID.Text & "', '" & lbl_totalNum.Text & "')")

        Try

            For i As Integer = 0 To grd_order.RowCount - 1

                Dim productID As String = grd_order(0, i).Value
                Dim price As String = grd_order(2, i).Value
                Dim quantity As Integer = grd_order(3, i).Value
                Dim subtotal As String = grd_order(4, i).Value

                run_sql_command("INSERT INTO TBL_PRODUCTORDER_A202479 VALUES ('" & order_id & "', '" & productID & "','" & quantity & "'," & price & "," & subtotal & ")")
                run_sql_command("UPDATE TBL_PRODUCTS_A202479 SET FLD_QUANTITY = FLD_QUANTITY - " & quantity & " WHERE FLD_PRODUCT_ID = '" & productID & "'")

            Next

            Beep()
            MsgBox("Transaction Completed")
            grd_order.Rows.Clear()

        Catch ex As Exception
            Beep()
            MsgBox("Problem with transaction: " & vbCrLf & vbCrLf & ex.Message)


        End Try


        total = 0
        lbl_totalNum.Text = "0"
        txt_product_name.Clear()
        txt_price.Clear()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        txt_product_name.Text = ""
        txt_price.Text = ""
        txt_series.Text = ""
        nud_qty.Value = "0"

        grd_order.Rows.Clear()
        lbl_totalNum.Text = "0"
        total = 0

    End Sub
End Class
Public Class frm_productsManager_a202479
    Dim current_product_id As String
    Private Sub frm_products_manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        grd_products.Columns(0).HeaderText = "Product ID"
        grd_products.Columns(1).HeaderText = "Product Name"
        grd_products.Columns(2).HeaderText = "Unit Price"
        grd_products.Columns(3).HeaderText = "Series"
        grd_products.Columns(4).HeaderText = "Type"
        grd_products.Columns(5).HeaderText = "Quantity"
        grd_products.Columns(6).HeaderText = "Rating"


        cmb_type.Items.Add("Hardcover")
        cmb_type.Items.Add("Paperback")


    End Sub

    Private Sub refresh_text(product_id As String)

        Dim mysql As String = "select * from tbl_products_a202479 where fld_product_id='" & product_id & "'"
        Dim mytable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mytable)

        'txt_product_id.Text = mytable.Rows(0).Item("fld_product_id")
        txt_product_id.Text = generate_product_id()
        txt_product_name.Text = mytable.Rows(0).Item("fld_product_name")
        txt_price.Text = "RM" & mytable.Rows(0).Item("fld_price").ToString()
        txt_series.Text = mytable.Rows(0).Item("fld_series")
        txt_qty.Text = mytable.Rows(0).Item("fld_quantity")
        txt_rating.Text = mytable.Rows(0).Item("fld_ratings")

    End Sub

    Private Sub refresh_grid()
        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A202479 order by fld_product_id")
    End Sub
    Private Sub clear_fields()
        txt_product_id.Text = ""
        txt_product_name.Text = ""
        txt_price.Text = ""
        txt_series.Text = ""
        txt_qty.Text = ""
        txt_rating.Text = ""
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a202479.Show()
        Me.Hide()
    End Sub



    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_PRODUCTS_A202479 SET FLD_PRODUCT_ID='" & txt_product_id.Text & "' WHERE FLD_PRODUCT_ID='" & current_product_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A202479 SET FLD_PRODUCT_NAME='" & txt_product_name.Text & "' WHERE FLD_PRODUCT_ID='" & current_product_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A202479 SET FLD_PRICE='" & txt_price.Text & "' WHERE FLD_PRODUCT_ID='" & current_product_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A202479 SET FLD_SERIES='" & txt_series.Text & "' WHERE FLD_PRODUCT_ID='" & current_product_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A202479 SET FLD_TYPE='" & cmb_type.Text & "' WHERE FLD_PRODUCT_ID='" & current_product_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A202479 SET FLD_QUANTITY='" & txt_qty.Text & "' WHERE FLD_PRODUCT_ID='" & current_product_id & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A202479 SET FLD_RATING='" & txt_rating.Text & "' WHERE FLD_PRODUCT_ID='" & current_product_id & "'")

        Beep()
        MsgBox("You have successfully updated the product """ & current_product_id & """.")
        refresh_grid()
        clear_fields()
        get_current_product_id()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the course """ & current_product_id & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_PRODUCTS_A202479 WHERE FLD_PRODUCT_ID='" & current_product_id & "'")

            Beep()
            MsgBox("The product """ & current_product_id & """ has been successfully deleted.")
        End If
        refresh_grid()
    End Sub

    Private Function generate_product_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A202479").Rows(0).Item("LASTID")
        Dim newid As String = "TP" & Mid(lastid, 2) + 1
        Return newid
    End Function

    Private Sub get_current_product_id()
        Dim current_row As Integer = grd_products.CurrentRow.Index

        current_product_id = grd_products(0, current_row).Value

        txt_product_id.Text = current_product_id
        txt_product_name.Text = grd_products(1, current_row).Value
        txt_price.Text = grd_products(2, current_row).Value
        txt_series.Text = grd_products(3, current_row).Value
        cmb_type.Text = grd_products(4, current_row).Value
        txt_qty.Text = grd_products(5, current_row).Value
        txt_rating.Text = grd_products(6, current_row).Value

        Try
            pic_prod.BackgroundImage = Image.FromFile("C:\Users\User\source\repos\prj_EverythingTerry_a202479\prj_EverythingTerry_a202479\bin\Debug\pictures\" & txt_product_id.Text & ".jpg")

        Catch ex As Exception
            pic_prod.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_addProducts_a202479.Show()
        Me.Hide()
    End Sub


    Private Sub grd_products_MouseClick(sender As Object, e As MouseEventArgs) Handles grd_products.MouseClick
        get_current_product_id()
    End Sub
End Class
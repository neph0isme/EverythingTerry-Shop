Public Class frm_products_a202479
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Private Sub frm_products_a202479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_list()
        refresh_text(lst_product_id.Text)
    End Sub

    Private Sub refresh_text(product_id As String)

        Dim mysql As String = "select * from tbl_products_a202479 where fld_product_id='" & product_id & "'"
        Dim mytable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mytable)

        txt_product_id.Text = mytable.Rows(0).Item("fld_product_id")
        txt_product_name.Text = mytable.Rows(0).Item("fld_product_name")
        txt_price.Text = "RM" & mytable.Rows(0).Item("fld_price").ToString()
        txt_series.Text = mytable.Rows(0).Item("fld_series")
        txt_type.Text = mytable.Rows(0).Item("fld_type")
        txt_qty.Text = mytable.Rows(0).Item("fld_quantity")
        txt_rating.Text = mytable.Rows(0).Item("fld_ratings")

        Try
            pic_product.BackgroundImage = Image.FromFile("C:\Users\User\source\repos\prj_EverythingTerry_a202479\prj_EverythingTerry_a202479\bin\Debug\pictures\" & txt_product_id.Text & ".jpg")

        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try
    End Sub

    Private Sub refresh_list()

        lst_product_id.DataSource = run_sql_query("select fld_product_id from tbl_products_a202479 order by fld_product_id")
        lst_product_id.DisplayMember = "FLD_PRODUCT_ID"

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a202479.Show()
        Me.Hide()
    End Sub


    Private Sub lst_product_id_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_product_id.MouseClick
        refresh_text(lst_product_id.Text)
    End Sub


End Class
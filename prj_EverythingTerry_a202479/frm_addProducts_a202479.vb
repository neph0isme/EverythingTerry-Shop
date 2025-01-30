Public Class frm_addProducts_a202479
    Dim current_product_id As String
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Private Sub frm_addProducts_a202479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub refresh_grid()
        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A202479 order by fld_product_id")
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_productsManager_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub grd_products_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellContentClick
        get_current_product_id()
    End Sub

    Private Sub get_current_product_id()
        Dim current_row As Integer = grd_products.CurrentRow.Index

        current_product_id = grd_products(0, current_row).Value

        txt_product_id.Text = generate_product_id()

    End Sub
    Private Function generate_product_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A202479").Rows(0).Item("LASTID")
        Dim newid As String = "TP" & Mid(lastid, 3) + 1
        Return newid
    End Function

    Private Sub btn_selectPic_Click(sender As Object, e As EventArgs) Handles btn_selectPic.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_prod.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_imgName.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A202479 VALUES ('" & txt_product_id.Text & "', '" & txt_product_name.Text & "', '" & txt_price.Text & "', '" & txt_series.Text & "', '" & cmb_type.Text & "', '" & txt_qty.Text & "', '" & txt_rating.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_imgName.Text, "pictures\" & txt_product_id.Text & ".jpg")

            grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A202479")
            txt_product_id.Text = generate_product_id()
            txt_product_name.Text = ""
            txt_price.Text = ""
            txt_series.Text = ""
            cmb_type.Text = ""
            txt_qty.Text = ""
            txt_rating.Text = ""

            txt_imgName.Text = defaultpicture
            pic_prod.BackgroundImage = Image.FromFile(defaultpicture)


        Catch ex As Exception
            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub
End Class
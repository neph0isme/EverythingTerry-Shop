Public Class frm_staff_a202479
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Private Sub frm_staff_a202479_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_staff_id.DataSource = run_sql_query("select fld_staff_id from tbl_staff_a202479 order by fld_staff_id")
        lst_staff_id.DisplayMember = "fld_staff_id"

        refresh_text(lst_staff_id.Text)
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        frm_mainmenu_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub lst_staff_id_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_staff_id.MouseClick
        refresh_text(lst_staff_id.Text)
    End Sub

    Private Sub refresh_text(staff_id As String)

        Dim mysql As String = "select * from tbl_staff_a202479 where fld_staff_id='" & staff_id & "'"
        Dim mytable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mytable)

        txt_name.Text = mytable.Rows(0).Item("fld_staff_name")
        txt_position.Text = mytable.Rows(0).Item("fld_staff_position")

    End Sub


End Class
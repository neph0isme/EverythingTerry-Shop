Public Class frm_mainmenu_a202479
    Private Sub frm_mainmenu_a202479_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click
        frm_products_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_makeOrder_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staff_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_customer_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub tbn_prod_manager_Click(sender As Object, e As EventArgs) Handles btn_prod_manager.Click
        frm_productsManager_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_managestaff.Click
        frm_staffManager_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_customerManager_a202479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_manageOrder_Click(sender As Object, e As EventArgs) Handles btn_manageOrder.Click
        frm_order_a202479.Show()
        Me.Hide()
    End Sub
End Class

Public Class frm_splashscreen_a202479

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Timer1.Enabled = False
            frm_mainmenu_a202479.Show()
        End If
    End Sub
End Class
Public Class frm_mainAdmin
    Private Sub btn_manageProduct_Click(sender As Object, e As EventArgs) Handles btn_manageProduct.Click
        frm_ManageProduct.ShowDialog()
    End Sub

    Private Sub btn_ManageStock_Click(sender As Object, e As EventArgs) Handles btn_ManageStock.Click
        frm_ManageStock.ShowDialog()
    End Sub

    Private Sub btn_manageUsers_Click(sender As Object, e As EventArgs) Handles btn_manageUsers.Click
        frm_ManageUser.ShowDialog()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        frm_Report.ShowDialog()
    End Sub
End Class
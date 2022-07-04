Public Class FormAdmin

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbName.Text = employee.Name
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FormLogin.Close()
        Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        employee = Nothing
        FormLogin.Show()
        Close()
    End Sub

    Private Sub BtnMasterEmployee_Click(sender As Object, e As EventArgs) Handles BtnMasterEmployee.Click
        FormMasterEmployee.Show()
    End Sub
End Class

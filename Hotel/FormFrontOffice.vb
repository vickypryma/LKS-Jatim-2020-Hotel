Public Class FormFrontOffice

    Private Sub FormFrontOffice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbName.Text = employee.Name
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FormLogin.Close()
        Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnMaster_Click(sender As Object, e As EventArgs) Handles BtnMaster.Click
        PanelMaster.Visible = True
        PanelTransaction.Visible = False
        LbMaster.Visible = True
        LbTransaction.Visible = False
    End Sub

    Private Sub BtnTransaction_Click(sender As Object, e As EventArgs) Handles BtnTransaction.Click
        PanelTransaction.Visible = True
        LbTransaction.Visible = True
        LbMaster.Visible = False
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        employee = Nothing
        FormLogin.Show()
        Close()
    End Sub

    Private Sub BtnMasterRoomType_Click(sender As Object, e As EventArgs) Handles BtnMasterRoomType.Click
        FormMasterRoomType.Show()
    End Sub

    Private Sub BtnMasterRoom_Click(sender As Object, e As EventArgs) Handles BtnMasterRoom.Click
        FormMasterRoom.Show()
    End Sub

    Private Sub BtnMasterItem_Click(sender As Object, e As EventArgs) Handles BtnMasterItem.Click
        FormMasterItem.Show()
    End Sub

    Private Sub BtnReservation_Click(sender As Object, e As EventArgs) Handles BtnReservation.Click
        FormReservation.Show()
    End Sub

    Private Sub BtnCheckin_Click(sender As Object, e As EventArgs) Handles BtnCheckin.Click
        FormCheckin.Show()
    End Sub

    Private Sub BtnCheckout_Click(sender As Object, e As EventArgs) Handles BtnCheckout.Click
        FormCheckout.Show()
    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click

    End Sub
End Class
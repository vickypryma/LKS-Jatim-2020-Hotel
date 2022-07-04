Imports System.Security.Cryptography
Imports System.Text

Public Class FormLogin

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbHotelDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.DbHotelDataSet.Employee)
        Me.ActiveControl = Panel1
    End Sub

    Private Sub TbUsername_Enter(sender As Object, e As EventArgs) Handles TbUsername.Enter
        If TbUsername.Text = "Username" Then
            TbUsername.Text = ""
        End If
    End Sub

    Private Sub TbUsername_Leave(sender As Object, e As EventArgs) Handles TbUsername.Leave
        If TbUsername.Text = "" Then
            TbUsername.Text = "Username"
        End If
    End Sub

    Private Sub TbPassword_Enter(sender As Object, e As EventArgs) Handles TbPassword.Enter
        If TbPassword.Text = "Password" Then
            TbPassword.Text = ""
        End If
    End Sub

    Private Sub TbPassword_Leave(sender As Object, e As EventArgs) Handles TbPassword.Leave
        If TbPassword.Text = "" Then
            TbPassword.Text = "Password"
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username = TbUsername.Text
        Dim password = TbPassword.Text

        If username = "" Or username = "Username" Then
            MsgBox("Username harus diisi!", vbExclamation, "Username")
        ElseIf password = "" Or password = "Password" Then
            MsgBox("Password harus diisi!", vbExclamation, "Password")
        Else
            Dim passwordHashed = PasswordHash(password)
            Dim rows = EmployeeTableAdapter.Login(username, passwordHashed)
            If rows.Count = 1 Then
                employee = rows.Single
                ResetForm()
                Me.Hide()
                If rows.Single.JobID = 1 Then
                    FormFrontOffice.Show()
                Else
                    FormAdmin.Show()
                End If
            Else
                MsgBox("Akun tidak ditemukan!", vbExclamation, "Login")
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub ResetForm()
        TbUsername.Text = "Username"
        TbPassword.Text = "Password"
    End Sub
End Class
Imports System.Text.RegularExpressions

Public Class FormCheckin
    Dim myCustomerID = 0

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TbPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbPhone.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    End Sub

    Private Sub TbNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbNIK.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim dt = ViewRoomCheckinTableAdapter.FindByCode(TbSearch.Text)
        If dt.Count > 0 Then
            Dim bs As New BindingSource
            bs.DataSource = dt
            DgvRoom.DataSource = bs
            myCustomerID = dt.Single.CustomerID
            InsertForm()
        Else
            myCustomerID = 0
            DgvRoom.DataSource = Nothing
            ResetForm()
            MsgBox("Kode Booking tidak ditemukan!", vbExclamation, "Cari")
        End If
    End Sub

    Private Sub InsertForm()
        GbCustomer.Enabled = True
        Dim customer = CustomerTableAdapter.GetDataByID(myCustomerID).Single
        TbPhone.Text = customer.PhoneNumber
        TbName.Text = customer.Name
        TbEmail.Text = customer.Email
        If customer.Gender = "M" Then : RbMale.Checked = True
        Else : RbFemale.Checked = True
        End If
        TbNIK.Text = customer.NIK
        DateBirth.Value = customer.BirthDate
    End Sub

    Private Sub ResetForm()
        GbCustomer.Enabled = False
        TbPhone.Text = ""
        TbName.Text = ""
        TbEmail.Text = ""
        RbMale.Checked = True
        TbNIK.Text = ""
        DateBirth.Value = Date.Today
    End Sub

    Private Function ValidationForm() As Boolean
        Dim validationError = ""
        If TbPhone.Text = "" Then : validationError = "Nomor HP harus diisi!"
        ElseIf TbName.Text = "" Then : validationError = "Nama harus diisi!"
        ElseIf Not Regex.IsMatch(TbName.Text, "^[A-Za-z ]+$") Then : validationError = "Nama hanya boleh huruf dan spasi!"
        ElseIf TbEmail.Text = "" Then : validationError = "Email harus diisi!"
        ElseIf Not IsEmail(TbEmail.Text) Then : validationError = "Email tidak valid"
        ElseIf TbNIK.Text = "" Then : validationError = "NIK harus diisi!"
        Else : Return True
        End If

        MsgBox(validationError, vbExclamation, "Data Salah")
        Return False
    End Function

    Private Function UpdateData() As Boolean
        Try
            Dim gender = If(RbMale.Checked, "M", "F")
            CustomerTableAdapter.UpdateQuery(TbName.Text, TbNIK.Text, TbEmail.Text, gender, TbPhone.Text, DateBirth.Value, myCustomerID)
            Return True
        Catch ex As Exception
            MsgBox("Ubah data gagal!", vbExclamation, "Pelanggan")
            Return False
        End Try
    End Function

    Private Sub BtnCheckin_Click(sender As Object, e As EventArgs) Handles BtnCheckin.Click
        If DgvRoom.CurrentRow.Index >= 0 Then
            Dim id = DgvRoom.CurrentRow.Cells("ID").Value
            Try
                ReservationRoomTableAdapter.Checkin(DgvRoom.CurrentRow.Cells("StartDate").Value, id)
                DgvRoom.Rows.RemoveAt(DgvRoom.CurrentRow.Index)

                CheckData()
                MsgBox("Berhasil Checkin!", vbInformation, "Checkin")
            Catch ex As Exception
                MsgBox("Gagal Checkin!\n" & ex.ToString, vbInformation, "Checkin")
            End Try
        Else
            MsgBox("Pilih kamar terlebih dahulu!", vbExclamation, "Kamar")
        End If
    End Sub

    Private Sub CheckData()
        If DgvRoom.Rows.Count = 0 Then
            ResetForm()
            TbSearch.Text = ""
            myCustomerID = 0
        End If
    End Sub
End Class
Imports System.Text.RegularExpressions

Public Class FormMasterEmployee
    Dim employeeData As DbHotelDataSet.EmployeeRow = Nothing
    Dim state As String = Nothing

    Private Sub FormMasterEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbHotelDataSet.ViewEmployee' table. You can move, or remove it, as needed.
        Me.ViewEmployeeTableAdapter.Fill(Me.DbHotelDataSet.ViewEmployee)

    End Sub

    Private Sub ViewEmployeeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewEmployeeDataGridView.CellClick
        ChangeState(False)
        If ViewEmployeeDataGridView.CurrentRow.Index >= 0 Then
            Dim username = ViewEmployeeDataGridView.CurrentRow.Cells(0).Value.ToString
            employeeData = EmployeeTableAdapter.GetDataByUsername(username).Single
            InsertForm()
        End If
    End Sub

    Private Sub InsertForm()
        TbUsername.Text = employeeData.Username
        TbPassword.Text = ""
        TbConfirm.Text = ""
        TbName.Text = employeeData.Name
        TbEmail.Text = employeeData.Email
        TbDate.Value = employeeData.BirthDate
        CbJob.SelectedItem = If(employeeData.JobID = 1, "Front Office", "Admin")
        TbAddress.Text = employeeData.Address
    End Sub

    Private Sub ResetForm()
        TbUsername.Text = ""
        TbPassword.Text = ""
        TbConfirm.Text = ""
        TbName.Text = ""
        TbEmail.Text = ""
        TbDate.Value = Date.Today
        CbJob.SelectedIndex = -1
        TbAddress.Text = ""
    End Sub

    Private Sub ChangeState(Optional isUpdate = True)
        If isUpdate Then
            PanelForm.Enabled = True
            PanelChange.Enabled = False
            PanelSubmit.Enabled = True
        Else
            PanelForm.Enabled = False
            PanelChange.Enabled = True
            PanelSubmit.Enabled = False
        End If
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        ChangeState()
        state = "insert"
        employeeData = Nothing
        ResetForm()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If IsNothing(employeeData) Then : MsgBox("Pilih data terlebih dahulu!", vbExclamation, "Data Karyawan")
        Else
            ChangeState()
            state = "update"
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If IsNothing(employeeData) Then : MsgBox("Pilih data terlebih dahulu!", vbExclamation, "Data Karyawan")
        Else
            Dim res = MsgBox("Yakin ingin menghapus data ini?", vbYesNo, "Konfirmasi Hapus")

            If res = vbYes Then
                Try
                    EmployeeTableAdapter.DeleteQuery(employeeData.ID)
                    MsgBox("Hapus data berhasil!", vbInformation, "Sukses")
                    ResetForm()
                    RefreshData()
                Catch ex As Exception
                    MsgBox("Hapus data gagal!", vbCritical, "Gagal")
                End Try
            End If
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ValidateForm() Then
            If state = "insert" Then : InsertData()
            Else : UpdateData
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        ChangeState(False)
        If IsNothing(employeeData) Then : ResetForm()
        Else : InsertForm()
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        Dim validationError As String = ""
        If TbUsername.Text = "" Then : validationError = "Username harus diisi!"
        ElseIf Not Regex.IsMatch(TbUsername.Text, "^[0-9a-z]+$") Then : validationError = "Username hanya boleh huruf kecil dan angka!"
        ElseIf state = "insert" And TbPassword.Text = "" Then : validationError = "Password harus diisi!"
        ElseIf TbConfirm.Text <> TbPassword.Text Then : validationError = "Konfirmasi password tidak sama!"
        ElseIf TbName.Text = "" Then : validationError = "Nama harus diisi!"
        ElseIf Not Regex.IsMatch(TbName.Text, "^[A-Za-z ]+$") Then : validationError = "Nama hanya boleh huruf dan spasi!"
        ElseIf TbEmail.Text = "" Then : validationError = "Email harus diisi!"
        ElseIf Not IsEmail(TbEmail.Text) Then : validationError = "Email tidak valid!"
        ElseIf CbJob.SelectedIndex < 0 Then : validationError = "Pekerjaan belum dipilih!"
        ElseIf TbAddress.Text = "" Then : validationError = "Alamat harus diisi!"
        Else
            Dim byUsername = EmployeeTableAdapter.GetDataByUsername(TbUsername.Text)
            Dim byEmail = EmployeeTableAdapter.GetDataByEmail(TbEmail.Text)

            If ((state = "update" And employeeData?.Username <> TbUsername.Text) Or state = "insert") And byUsername.Count > 0 Then
                validationError = "Username sudah terdaftar!"
            ElseIf ((state = "update" And employeeData?.Email <> TbEmail.Text) Or state = "insert") And byEmail.Count > 0 Then
                validationError = "Email sudah terdaftar!"
            Else
                Return True
            End If

        End If
        MsgBox(validationError, vbExclamation, "Data Salah")
        Return False
    End Function

    Private Sub InsertData()
        Dim jobID = If(CbJob.SelectedIndex = 0, 1, 2)

        Try
            EmployeeTableAdapter.Insert(TbUsername.Text, TbPassword.Text, TbName.Text, TbEmail.Text, TbAddress.Text, TbDate.Value, jobID)
            MsgBox("Tambah data berhasil!", vbInformation, "Sukses")
            ChangeState(False)
            ResetForm()
            RefreshData()
        Catch ex As Exception
            MsgBox("Tambah data gagal!", vbCritical, "Gagal")
        End Try
    End Sub

    Private Sub UpdateData()
        Dim jobID = If(CbJob.SelectedIndex = 0, 1, 2)
        Dim password = If(TbPassword.Text = "", employeeData.Password, TbPassword.Text)
        Try
            EmployeeTableAdapter.UpdateQuery(TbUsername.Text, password, TbName.Text, TbEmail.Text, TbAddress.Text, TbDate.Value, jobID, employeeData.ID)
            MsgBox("Ubah data berhasil!", vbInformation, "Sukses")
            ChangeState(False)
            ResetForm()
            RefreshData()
        Catch ex As Exception
            MsgBox("Ubah data gagal!", vbCritical, "Gagal")
        End Try
    End Sub

    Private Sub RefreshData()
        ViewEmployeeTableAdapter.Fill(DbHotelDataSet.ViewEmployee)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class
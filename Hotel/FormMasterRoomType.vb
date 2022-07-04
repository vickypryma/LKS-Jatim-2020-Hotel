Imports System.Text.RegularExpressions

Public Class FormMasterRoomType
    'state = "insert" or "update"
    Dim state As String
    Dim row As DataGridViewRow

    Private Sub FormMasterRoomType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbHotelDataSet.RoomType' table. You can move, or remove it, as needed.
        Me.RoomTypeTableAdapter.Fill(Me.DbHotelDataSet.RoomType)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TbPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbPrice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    End Sub

    Private Sub TbPrice_Enter(sender As Object, e As EventArgs) Handles TbPrice.Enter
        If TbPrice.Text = "0" Then
            TbPrice.Text = ""
        End If
    End Sub

    Private Sub TbPrice_Leave(sender As Object, e As EventArgs) Handles TbPrice.Leave
        If TbPrice.Text = "" Then
            TbPrice.Text = "0"
        End If
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        state = "insert"
        ResetForm()
        ChangeState()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If IsNothing(row) Then : MsgBox("Pilih data terlebih dahulu!", vbExclamation, "Tipe Kamar")
        Else
            state = "update"
            ChangeState()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If IsNothing(row) Then : MsgBox("Pilih data terlebih dahulu!", vbExclamation, "Tipe Kamar")
        Else
            Dim res = MsgBox("Yakin ingin menghapus data ini?", vbYesNo, "Konfirmasi Hapus")

            If res = vbYes Then
                Try
                    RoomTypeBindingSource.RemoveCurrent()
                    RoomTypeBindingSource.EndEdit()
                    RoomTypeTableAdapter.Update(DbHotelDataSet.RoomType)

                    MsgBox("Hapus data berhasil!", vbInformation, "Sukses")
                    ResetForm()
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
        If IsNothing(row) Then : ResetForm()
        Else : InsertForm()
        End If
    End Sub

    Private Sub RoomTypeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles RoomTypeDataGridView.CellClick
        ChangeState(False)
        row = RoomTypeDataGridView.CurrentRow
        InsertForm()
    End Sub

    Private Sub ChangeState(Optional isUpdate = True)
        PanelForm.Enabled = isUpdate
        PanelChange.Enabled = Not isUpdate
        PanelSubmit.Enabled = isUpdate
    End Sub

    Private Sub InsertForm()
        TbName.Text = row.Cells(1).Value
        NumCapacity.Value = row.Cells(2).Value
        TbPrice.Text = row.Cells(3).Value
    End Sub

    Private Sub ResetForm()
        row = Nothing

        TbName.Text = ""
        NumCapacity.Value = 1
        TbPrice.Text = "0"
    End Sub

    Private Function ValidateForm() As Boolean
        Dim validationError = ""

        If TbName.Text = "" Then : validationError = "Nama harus diisi!"
        ElseIf Not Regex.IsMatch(TbName.Text, "^[A-Za-z0-9 _-]+$") Then
            validationError = "Nama hanya boleh huruf, angka, dan spasi!"
        ElseIf TbPrice.Text = "0" Then : validationError = "Harga harus diisi!"
        Else : Return True
        End If

        MsgBox(validationError, vbExclamation, "Data Salah")
        Return False
    End Function

    Private Sub InsertData()
        Try
            RoomTypeTableAdapter.Insert(TbName.Text, NumCapacity.Value, TbPrice.Text)

            MsgBox("Tambah data berhasil!", vbInformation, "Sukses")
            ChangeState(False)
            RefreshData()
            ResetForm()
        Catch ex As Exception
            MsgBox("Tambah data gagal!", vbCritical, "Gagal")
        End Try
    End Sub

    Private Sub UpdateData()
        Try
            RoomTypeTableAdapter.UpdateQuery(TbName.Text, NumCapacity.Value, TbPrice.Text, row.Cells(0).Value)

            MsgBox("Ubah data berhasil!", vbInformation, "Sukses")
            ChangeState(False)
            RefreshData()
            ResetForm()
        Catch ex As Exception
            MsgBox("Ubah data gagal!", vbCritical, "Gagal")
        End Try
    End Sub

    Private Sub RefreshData()
        RoomTypeTableAdapter.Fill(DbHotelDataSet.RoomType)
    End Sub
End Class
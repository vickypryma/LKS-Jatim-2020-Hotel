Public Class FormMasterItem
    'state = "insert" or "update"
    Dim state As String
    Dim row As DataGridViewRow

    Private Sub FormMasterItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbHotelDataSet.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.DbHotelDataSet.Item)

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TbReqPrice_Enter(sender As Object, e As EventArgs) Handles TbReqPrice.Enter
        If TbReqPrice.Text = "0" Then
            TbReqPrice.Text = ""
        End If
    End Sub

    Private Sub TbReqPrice_Leave(sender As Object, e As EventArgs) Handles TbReqPrice.Leave
        If TbReqPrice.Text = "" Then
            TbReqPrice.Text = "0"
        End If
    End Sub

    Private Sub TbReqPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbReqPrice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    End Sub

    Private Sub TbCompFee_Enter(sender As Object, e As EventArgs) Handles TbCompFee.Enter
        If TbCompFee.Text = "0" Then
            TbCompFee.Text = ""
        End If
    End Sub

    Private Sub TbCompFee_Leave(sender As Object, e As EventArgs) Handles TbCompFee.Leave
        If TbCompFee.Text = "" Then
            TbCompFee.Text = "0"
        End If
    End Sub

    Private Sub TbCompFee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbCompFee.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    End Sub

    Private Sub ItemDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemDataGridView.CellClick
        ChangeState(False)
        row = ItemDataGridView.CurrentRow
        InsertForm()
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        state = "insert"
        ResetForm()
        ChangeState()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If IsNothing(row) Then : MsgBox("Pilih data terlebih dahulu!", vbExclamation, "Data Item")
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
                    ItemBindingSource.RemoveCurrent()
                    ItemBindingSource.EndEdit()
                    ItemTableAdapter.Update(DbHotelDataSet.Item)

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
            Else : UpdateData()
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        ChangeState(False)
        If IsNothing(row) Then : ResetForm()
        Else : InsertForm()
        End If
    End Sub

    Private Sub ChangeState(Optional isUpdate = True)
        PanelForm.Enabled = isUpdate
        PanelChange.Enabled = Not isUpdate
        PanelSubmit.Enabled = isUpdate
    End Sub

    Private Sub InsertForm()
        TbName.Text = row.Cells(1).Value
        TbReqPrice.Text = row.Cells(2).Value
        TbCompFee.Text = row.Cells(3).Value
    End Sub

    Private Sub ResetForm()
        row = Nothing

        TbName.Text = ""
        TbReqPrice.Text = "0"
        TbCompFee.Text = "0"
    End Sub

    Private Function ValidateForm() As Boolean
        Dim validationError = ""

        If TbName.Text = "" Then : validationError = "Nama harus diisi!"
        ElseIf TbReqPrice.Text = "0" Then : validationError = "Request Price harus diisi!"
        ElseIf TbCompFee.Text = "0" Then : validationError = "Compensation Fee harus diisi!"
        Else : Return True
        End If

        MsgBox(validationError, vbExclamation, "Data Salah")
        Return False
    End Function

    Private Sub InsertData()
        Try
            ItemTableAdapter.Insert(TbName.Text, TbReqPrice.Text, TbCompFee.Text)

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
            ItemTableAdapter.UpdateQuery(TbName.Text, TbReqPrice.Text, TbCompFee.Text, row.Cells(0).Value)

            MsgBox("Ubah data berhasil!", vbInformation, "Sukses")
            ChangeState(False)
            RefreshData()
            ResetForm()
        Catch ex As Exception
            MsgBox("Ubah data gagal!", vbCritical, "Gagal")
        End Try
    End Sub

    Private Sub RefreshData()
        ItemTableAdapter.Fill(DbHotelDataSet.Item)
    End Sub
End Class
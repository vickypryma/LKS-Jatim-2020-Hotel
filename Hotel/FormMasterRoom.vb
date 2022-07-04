Public Class FormMasterRoom
    'state = "insert" or "update"
    Dim state As String
    Dim room As DataGridViewRow

    Private Sub FormMasterRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbHotelDataSet.RoomType' table. You can move, or remove it, as needed.
        Me.RoomTypeTableAdapter.Fill(Me.DbHotelDataSet.RoomType)
        'TODO: This line of code loads data into the 'DbHotelDataSet.ViewRoom' table. You can move, or remove it, as needed.
        Me.ViewRoomTableAdapter.Fill(Me.DbHotelDataSet.ViewRoom)

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TbNumber_Enter(sender As Object, e As EventArgs) Handles TbNumber.Enter
        If TbNumber.Text = "1" Then
            TbNumber.Text = ""
        End If
    End Sub

    Private Sub TbNumber_Leave(sender As Object, e As EventArgs) Handles TbNumber.Leave
        If TbNumber.Text = "" Then
            TbNumber.Text = "1"
        End If
    End Sub

    Private Sub TbNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbNumber.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    End Sub

    Private Sub ViewRoomDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewRoomDataGridView.CellClick
        ChangeState(False)
        room = ViewRoomDataGridView.CurrentRow
        InsertForm()
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        state = "insert"
        ResetForm()
        ChangeState()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If IsNothing(room) Then : MsgBox("Pilih data terlebih dahulu!", vbExclamation, "Data Kamar")
        Else
            state = "update"
            ChangeState()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If IsNothing(room) Then : MsgBox("Pilih data terlebih dahulu!", vbExclamation, "Data Kamar")
        Else
            Dim res = MsgBox("Yakin ingin menghapus data ini?", vbYesNo, "Konfirmasi Hapus")

            If res = vbYes Then
                Try
                    RoomTableAdapter.DeleteQuery(room.Cells(0).Value)

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
            Else : UpdateData()
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        ChangeState(False)
        If IsNothing(room) Then : ResetForm()
        Else : InsertForm()
        End If
    End Sub

    Private Sub ChangeState(Optional isUpdate = True)
        PanelForm.Enabled = isUpdate
        PanelChange.Enabled = Not isUpdate
        PanelSubmit.Enabled = isUpdate
    End Sub

    Private Sub InsertForm()
        TbNumber.Text = room.Cells(2).Value
        CbType.SelectedValue = room.Cells(1).Value
        NumFloor.Value = room.Cells(4).Value
        TbDescription.Text = room.Cells(5).Value
    End Sub

    Private Sub ResetForm()
        room = Nothing

        TbNumber.Text = "1"
        CbType.SelectedIndex = 0
        NumFloor.Value = 1
        TbDescription.Text = ""
    End Sub

    Private Function ValidateForm() As Boolean
        Dim validationError = ""
        Dim row = RoomTableAdapter.GetDataByRoomNumber(TbNumber.Text)

        If ((state = "update" And TbNumber.Text <> room?.Cells(2).Value) Or state = "insert") And row.Count > 0 Then
            validationError = "Kamar dengan nomor " + TbNumber.Text + " sudah ada!"
        Else : Return True
        End If

        MsgBox(validationError, vbExclamation, "Data Salah")
        Return False
    End Function

    Private Sub InsertData()
        Try
            RoomTableAdapter.Insert(CbType.SelectedValue, TbNumber.Text, NumFloor.Value, TbDescription.Text)

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
            RoomTableAdapter.UpdateQuery(CbType.SelectedValue, TbNumber.Text, NumFloor.Value, TbDescription.Text, room.Cells(0).Value)

            MsgBox("Ubah data berhasil!", vbInformation, "Sukses")
            ChangeState(False)
            RefreshData()
            ResetForm()
        Catch ex As Exception
            MsgBox("Ubah data gagal!", vbCritical, "Gagal")
        End Try
    End Sub

    Private Sub RefreshData()
        ViewRoomTableAdapter.Fill(DbHotelDataSet.ViewRoom)
    End Sub
End Class
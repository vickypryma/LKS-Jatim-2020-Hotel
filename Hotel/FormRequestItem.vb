Public Class FormRequestItem
    Dim items As New List(Of ArrayList)

    Private Sub FormRequestItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbHotelDataSet.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.DbHotelDataSet.Item)

        Dim bs As New BindingSource
        Dim dt = ViewReservationRoomTableAdapter.GetDataByTime(Date.Today)
        bs.DataSource = dt
        CbRoom.DataSource = bs
        CbRoom.DisplayMember = "RoomNumber"
        CbRoom.ValueMember = "ID"

        CbItem.SelectedIndex = -1

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CbItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbItem.SelectedIndexChanged
        If CbItem.SelectedIndex >= 0 Then
            Dim selected = CbItem.SelectedItem

            TbPrice.Text = selected("RequestPrice")
            TbSubTotal.Text = selected("RequestPrice") * NumQty.Value
        End If
    End Sub

    Private Sub NumQty_ValueChanged(sender As Object, e As EventArgs) Handles NumQty.ValueChanged
        If CbItem.SelectedIndex >= 0 Then
            Dim selected = CbItem.SelectedItem

            TbSubTotal.Text = selected("RequestPrice") * NumQty.Value
        End If
    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
        If CbItem.SelectedIndex < 0 Then : MsgBox("Pilih barang terlebih dahulu", vbExclamation, "Barang")
        Else
            Dim item As New ArrayList

            Dim i = items.FindIndex(Function(x) x(0) = CbItem.SelectedValue)
            If i >= 0 Then
                items(i)(1) += CbItem.SelectedValue
                items(i)(2) += Integer.Parse(TbSubTotal.Text)
                DgvItem.Rows(i).SetValues(CbItem.SelectedItem("Name"), items(i)(1), TbPrice.Text, items(i)(2), "Hapus")
            Else
                item.Add(CbItem.SelectedValue)
                item.Add(NumQty.Value)
                item.Add(Integer.Parse(TbSubTotal.Text))
                items.Add(item)
                DgvItem.Rows.Add(CbItem.SelectedItem("Name"), NumQty.Value, TbPrice.Text, TbSubTotal.Text, "Hapus")
            End If

            SumTotal()
        End If
    End Sub

    Private Sub DgvItem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItem.CellClick
        If e.ColumnIndex = 4 Then
            items.RemoveAt(e.RowIndex)
            DgvItem.Rows.RemoveAt(e.RowIndex)

            SumTotal()
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If items.Count > 0 Then
            For Each myiTem In items
                If Not InsertItem(myiTem(0), myiTem(1), myiTem(2)) Then
                    Exit Sub
                End If
            Next

            MsgBox("Tambah barang berhasil!", vbInformation, "Sukses")
            Close()
        Else : MsgBox("Pilih barang terlebih dahulu!", vbExclamation, "Barang")
        End If
    End Sub

    Private Function InsertItem(itemID As Integer, qty As Integer, totalPrice As Integer) As Boolean
        Try
            ReservationRequestItemTableAdapter.Insert(CbRoom.SelectedValue, itemID, qty, totalPrice)
            Return True
        Catch ex As Exception
            MsgBox("Tambah data gagal!", vbExclamation, "Barang")
            Return False
        End Try
    End Function

    Private Sub SumTotal()
        Dim total = 0

        For Each myItem In items
            total += myItem(2)
        Next

        LabelTotal.Text = total
    End Sub
End Class
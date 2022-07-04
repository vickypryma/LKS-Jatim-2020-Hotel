Public Class FormCheckout
    Dim reqItem As New List(Of ArrayList)
    Dim items As New List(Of ArrayList)

    Private Sub FormCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbHotelDataSet.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.DbHotelDataSet.Item)

        Dim bs As New BindingSource
        Dim dt = ViewReservationRoomTableAdapter.GetDataByTime(Date.Today)
        bs.DataSource = dt
        CbRoom.DataSource = bs
        CbRoom.DisplayMember = "RoomNumber"
        CbRoom.ValueMember = "ID"

        CbRoom.SelectedIndex = -1
        CbItem.SelectedIndex = -1
        CbStatus.SelectedIndex = 0

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CbRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbRoom.SelectedIndexChanged
        If CbRoom.SelectedIndex >= 0 And TypeOf CbRoom.SelectedValue Is Integer Then
            GetRequestItem(CbRoom.SelectedValue)
            GetFoods()
        End If
    End Sub

    Private Sub CbItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbItem.SelectedIndexChanged
        If CbItem.SelectedIndex >= 0 Then
            GetQty()
            Dim selected = CbItem.SelectedItem
            Dim fee = selected("CompensationFee")
            Dim noFee = selected("RequestPrice") * NumQty.Value
            Dim withFee = fee * NumQty.Value

            TbSubTotal.Text = If(CbStatus.SelectedIndex = 0, noFee, withFee)
            TbCompFee.Text = If(CbStatus.SelectedIndex = 0, "0", fee)
        End If
    End Sub

    Private Sub NumQty_ValueChanged(sender As Object, e As EventArgs) Handles NumQty.ValueChanged
        If CbItem.SelectedIndex >= 0 Then
            Dim selected = CbItem.SelectedItem
            Dim fee = selected("CompensationFee")
            Dim noFee = selected("RequestPrice") * NumQty.Value
            Dim withFee = fee * NumQty.Value

            TbSubTotal.Text = If(CbStatus.SelectedIndex = 0, noFee, withFee)
            TbCompFee.Text = If(CbStatus.SelectedIndex = 0, "0", fee)
        End If
    End Sub

    Private Sub CbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbStatus.SelectedIndexChanged
        If CbItem.SelectedIndex >= 0 Then
            Dim selected = CbItem.SelectedItem
            Dim fee = selected("CompensationFee")
            Dim noFee = selected("RequestPrice") * NumQty.Value
            Dim withFee = fee * NumQty.Value

            TbSubTotal.Text = If(CbStatus.SelectedIndex = 0, noFee, withFee)
            TbCompFee.Text = If(CbStatus.SelectedIndex = 0, "0", fee)
        End If
    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
        If CbItem.SelectedIndex < 0 Or NumQty.Value = 0 Then : MsgBox("Pilih barang terlebih dahulu", vbExclamation, "Barang")
        Else
            Dim item As New ArrayList
            Dim statusID = If(CbStatus.SelectedIndex = 0, 1, 2)

            Dim i = items.FindIndex(Function(x) x(0) = CbItem.SelectedValue And x(3) = statusID)
            If i >= 0 Then
                items(i)(1) += CbItem.SelectedValue
                items(i)(2) += Integer.Parse(TbSubTotal.Text)
                DgvItem.Rows(i).SetValues(CbItem.SelectedItem("Name"), items(i)(1), TbCompFee.Text, items(i)(2), "Hapus")
            Else
                item.Add(CbItem.SelectedValue)
                item.Add(NumQty.Value)
                item.Add(Integer.Parse(TbSubTotal.Text))
                item.Add(statusID)
                items.Add(item)
                DgvItem.Rows.Add(CbItem.SelectedItem("Name"), NumQty.Value, TbCompFee.Text, TbSubTotal.Text, "Hapus")
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

    Private Sub DgvFoods_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFoods.CellClick
        If e.ColumnIndex = 0 And e.RowIndex >= 0 Then
            Dim res = MsgBox("Yakin ingin menghapus data ini?", vbYesNo, "Konfirmasi")
            If res = vbYes Then
                Try
                    FdCheckOutTableAdapter.DeleteQuery(DgvFoods.CurrentRow.Cells("FDCheckoutID").Value)
                    MsgBox("Hapus data berhasil!", vbInformation, "Sukses")
                    GetFoods()
                Catch ex As Exception
                    MsgBox("Hapus data gagal!", vbCritical, "Gagal")
                End Try
            End If

        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If CbRoom.SelectedIndex >= 0 Then
            If items.Count > 0 Then
                For Each item In items
                    If Not InsertCheckoutData(item(0), item(3), item(1), item(2)) Then
                        Exit Sub
                    End If
                Next

                MsgBox("Berhasil Checkout!", vbInformation, "Sukses")
                Close()
            Else : MsgBox("Tidak ada barang yang dipilih!", vbExclamation, "Barang")
            End If
        Else : MsgBox("Pilih kamar terlebih dahulu!", vbExclamation, "Kamar")
        End If
    End Sub

    Private Sub GetRequestItem(roomID As Integer)
        Dim dt = ReservationRequestItemTableAdapter.GetDataByRoomID(roomID)

        For Each row In dt.Rows
            Dim item As New ArrayList
            For i = 0 To dt.Columns.Count - 1
                item.Add(row(i))
            Next

            reqItem.Add(item)
        Next

        GetQty()
    End Sub

    Private Sub GetQty()
        NumQty.Value = (From item In reqItem
                        Where item(2) = CbItem.SelectedValue
                        Select item(3)).Sum(Function(x) x)
    End Sub

    Private Sub GetFoods()
        Dim bs As New BindingSource
        Dim dt = ViewFDCheckoutTableAdapter.GetDataByRoomID(CbRoom.SelectedValue)
        bs.DataSource = dt
        DgvFoods.DataSource = bs
    End Sub

    Private Sub SumTotal()
        Dim total = 0
        Dim totalItem = 0

        For Each item In items
            total += item(2)
            totalItem += item(2)
        Next

        LabelTotalItem.Text = totalItem
        LabelTotal.Text = total
    End Sub

    Private Function InsertCheckoutData(itemID As Integer, statusID As Integer, Qty As Integer, total As Integer) As Boolean
        Try
            ReservationCheckoutTableAdapter.Insert(CbRoom.SelectedValue, itemID, statusID, Qty, total)
            Return True
        Catch ex As Exception
            MsgBox("Tambah data gagal!", vbCritical, "Checkout")
            Return False
        End Try
    End Function
End Class
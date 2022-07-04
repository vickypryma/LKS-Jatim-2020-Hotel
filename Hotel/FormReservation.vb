Imports System.Text.RegularExpressions

Public Class FormReservation
    Dim isUser As Boolean = True
    Dim rooms As New List(Of ArrayList)
    Dim roomBS As New BindingSource
    Dim items As New List(Of ArrayList)
    Dim customerID = 0
    Dim code As String
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FormReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbHotelDataSet.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.DbHotelDataSet.Item)
        'TODO: This line of code loads data into the 'DbHotelDataSet.RoomType' table. You can move, or remove it, as needed.
        Me.RoomTypeTableAdapter.Fill(Me.DbHotelDataSet.RoomType)
        'TODO: This line of code loads data into the 'DbHotelDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.DbHotelDataSet.Customer)

        isUser = False
        DateCheckin.MinDate = Date.Today
        DateCheckout.MinDate = Date.Today.AddDays(1)
        isUser = True

        CbItem.SelectedIndex = -1
        CbGender.SelectedIndex = 0

        Dim count = 1
        Do While count > 0
            code = BookingCode(6)
            count = ReservationTableAdapter.CountByBookingCode(code)
        Loop

    End Sub

    Private Sub RbAdd_CheckedChanged(sender As Object, e As EventArgs) Handles RbAdd.CheckedChanged
        PanelAdd.Visible = True
        PanelSearch.Visible = False
        TbSearch.Visible = False
    End Sub

    Private Sub RbSearch_CheckedChanged(sender As Object, e As EventArgs) Handles RbSearch.CheckedChanged
        PanelAdd.Visible = False
        PanelSearch.Visible = True
        TbSearch.Visible = True
    End Sub

    Private Sub DateCheckin_ValueChanged(sender As Object, e As EventArgs) Handles DateCheckin.ValueChanged
        If isUser Then
            isUser = False
            DateCheckout.Value = DateCheckin.Value.AddDays(NumStaying.Value)
            isUser = True
        End If
    End Sub

    Private Sub NumStaying_ValueChanged(sender As Object, e As EventArgs) Handles NumStaying.ValueChanged
        If isUser Then
            isUser = False
            DateCheckout.Value = DateCheckin.Value.AddDays(NumStaying.Value)
            isUser = True
        End If
    End Sub

    Private Sub DateCheckout_ValueChanged(sender As Object, e As EventArgs) Handles DateCheckout.ValueChanged
        If isUser Then
            isUser = False
            Dim diff = (DateCheckout.Value - DateCheckin.Value).TotalDays
            NumStaying.Value = Math.Ceiling(diff)
            isUser = True
        End If
    End Sub

    Private Sub BtnSearchRoom_Click(sender As Object, e As EventArgs) Handles BtnSearchRoom.Click
        Dim dt = ViewRoomTableAdapter.GetDataByCheckin(CbTypeRoom.SelectedValue, DateCheckin.Value, DateCheckout.Value)

        roomBS.DataSource = dt
        DgvRoom.DataSource = roomBS
    End Sub

    Private Sub BtnAddRoom_Click(sender As Object, e As EventArgs) Handles BtnAddRoom.Click
        Dim row = DgvRoom.CurrentRow
        If row.Index >= 0 Then
            Dim room = New ArrayList
            room.Add(row.Cells("ARoomID").Value)
            room.Add(row.Cells("ARoomPrice").Value)
            rooms.Add(room)

            DgvRoomChoosed.Rows.Add(row.Cells("ARoomNumber").Value, row.Cells("ARoomPrice").Value, row.Cells("ARoomFloor").Value, row.Cells("ADescription").Value)
            FilterRoom()
            SumTotal()
        End If
    End Sub

    Private Sub BtnRemoveRoom_Click(sender As Object, e As EventArgs) Handles BtnRemoveRoom.Click
        Dim i = DgvRoomChoosed.CurrentRow.Index

        If i >= 0 Then
            DgvRoomChoosed.Rows.RemoveAt(i)
            rooms.RemoveAt(i)
            FilterRoom()
            SumTotal()
        End If
    End Sub

    Private Sub CbItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbItem.SelectedIndexChanged
        Dim current = CbItem.SelectedItem

        If Not IsNothing(current) Then
            TbPrice.Text = current("RequestPrice")
            TbSubTotal.Text = current("RequestPrice") * NumQuantity.Value
        End If
    End Sub

    Private Sub NumQuantity_ValueChanged(sender As Object, e As EventArgs) Handles NumQuantity.ValueChanged
        Dim current = CbItem.SelectedItem
        If Not IsNothing(current) Then
            TbSubTotal.Text = current("RequestPrice") * NumQuantity.Value
        End If
    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
        If TbPrice.Text = "" Then : MsgBox("Pilih barang terlebih dahulu", vbExclamation, "Barang")
        Else
            Dim item As New ArrayList

            Dim i = items.FindIndex(Function(x) x(0) = CbItem.SelectedValue)
            If i >= 0 Then
                items(i)(1) += CbItem.SelectedValue
                items(i)(2) += Integer.Parse(TbSubTotal.Text)
                DgvItem.Rows(i).SetValues(CbItem.SelectedItem("Name"), items(i)(1), TbPrice.Text, items(i)(2), "Hapus")
            Else
                item.Add(CbItem.SelectedValue)
                item.Add(NumQuantity.Value)
                item.Add(Integer.Parse(TbSubTotal.Text))
                items.Add(item)
                DgvItem.Rows.Add(CbItem.SelectedItem("Name"), NumQuantity.Value, TbPrice.Text, TbSubTotal.Text, "Hapus")
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

    Private Sub FilterRoom()
        roomBS.Filter = If(rooms.Count > 0, "ID NOT IN (" + String.Join(",", rooms.ToArray.Select(Function(x) x(0))) + ")", Nothing)
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If RbAdd.Checked Then
            If ValidationAddUser() Then
                Dim id = InsertCustomer()

                If id > 0 Then
                    customerID = id
                    SubmitData()
                End If
            End If
        ElseIf customerID = 0 Then
            MsgBox("Pilih pelanggan terlebih dahulu!", vbExclamation, "Pelanggan")
        Else : SubmitData()
        End If
    End Sub

    Private Sub TbSearch_TextChanged(sender As Object, e As EventArgs) Handles TbSearch.TextChanged
        CustomerBindingSource.Filter = "Name LIKE '%" & TbSearch.Text & "%'"
    End Sub

    Private Sub DgvCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCustomer.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 1 Then
            For Each row As DataGridViewRow In DgvCustomer.Rows
                If row.Index = e.RowIndex Then
                    row.Cells("Choose").Value = Not Convert.ToBoolean(row.Cells("Choose").EditedFormattedValue)
                Else
                    row.Cells("Choose").Value = False
                End If
            Next

            Dim customerID = DgvCustomer.CurrentRow.Cells(0).Value
            Me.customerID = If(Me.customerID = customerID, 0, customerID)
        End If
    End Sub

    Private Sub TbNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbNIK.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    End Sub

    Private Sub TbPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbPhone.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    End Sub

    Private Function ValidationAddUser() As Boolean
        Dim validationError = ""

        If TbName.Text = "" Then : validationError = "Nama harus diisi!"
        ElseIf Not Regex.IsMatch(TbName.Text, "^[A-Za-z ]+$") Then : validationError = "Nama hanya boleh huruf dan spasi!"
        ElseIf TbEmail.Text <> "" And Not IsEmail(TbEmail.Text) Then : validationError = "Email tidak vaild!"
        Else : Return True
        End If

        MsgBox(validationError, vbExclamation, "Data Salah")
        Return False
    End Function

    Private Function InsertCustomer() As Integer
        Try
            Dim gender = If(CbGender.SelectedIndex = 0, "M", "F")
            Dim id = CustomerTableAdapter.InsertQuery(TbName.Text, TbNIK.Text, TbEmail.Text, gender, TbPhone.Text, DateBirth.Value)

            Return id
        Catch ex As Exception
            MsgBox("Tambah pelanggan gagal", vbCritical, "Gagal")
            Return 0
        End Try
    End Function

    Private Sub SubmitData()
        If rooms.Count > 0 Then
            Dim reservationID = InsertReservation(code)
            If reservationID > 0 Then
                Dim room As ArrayList
                For i = 0 To rooms.Count - 1
                    room = rooms(i)
                    Dim price = room(1) * NumStaying.Value
                    Dim id = InsertReservationRoom(reservationID, room(0), price)
                    If id > 0 Then
                        If i = 0 And items.Count > 0 Then
                            For Each myiTem In items
                                If Not InsertItem(id, myiTem(0), myiTem(1), myiTem(2)) Then
                                    Exit Sub
                                End If
                            Next
                        End If
                    Else
                        Exit Sub
                    End If
                Next

                MsgBox("Kode Booking: " & code, vbInformation, "Sukses")
                Close()
            End If
        Else
            MsgBox("Silahkan pilih kamar terlebih dahulu!", vbExclamation, "Kamar")
        End If
    End Sub

    Private Function InsertReservation(code As String) As Integer
        Try
            'Debug Only
            Dim employeeID = If(IsNothing(employee), 2, employee.ID)
            Dim id = ReservationTableAdapter.InsertQuery(Date.Today, employeeID, customerID, code)

            Return id
        Catch ex As Exception
            MsgBox("Tambah data gagal!", vbExclamation, "Reservasi")
            Return 0
        End Try
    End Function

    Private Function InsertReservationRoom(reservationID As Integer, roomID As Integer, price As Integer) As Integer
        Try
            Dim id = ReservationRoomTableAdapter.InsertQuery(reservationID, roomID, Date.Today, NumStaying.Value, price, DateCheckin.Value, DateCheckout.Value)

            Return id
        Catch ex As Exception
            MsgBox("Tambah data gagal!", vbExclamation, "Reservasi Kamar")
            Return 0
        End Try
    End Function

    Private Function InsertItem(reservationRoomID As Integer, itemID As Integer, qty As Integer, totalPrice As Integer) As Boolean
        Try
            ReservationRequestItemTableAdapter.Insert(reservationRoomID, itemID, qty, totalPrice)
            Return True
        Catch ex As Exception
            MsgBox("Tambah data gagal!", vbExclamation, "Barang")
            Return False
        End Try
    End Function

    Private Sub SumTotal()
        Dim total = 0

        For Each room In rooms
            total += room(1) * NumStaying.Value
        Next

        For Each myItem In items
            total += myItem(2)
        Next

        LbTotalPrice.Text = total
    End Sub
End Class
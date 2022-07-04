<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCheckout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbRoom = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TbSubTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnAddItem = New System.Windows.Forms.Button()
        Me.CbStatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbCompFee = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumQty = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbItem = New System.Windows.Forms.ComboBox()
        Me.ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbHotelDataSet = New Hotel.DbHotelDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCompFee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemOption = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelTotalItem = New System.Windows.Forms.Label()
        Me.DgvFoods = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelTotalFoods = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ItemTableAdapter = New Hotel.DbHotelDataSetTableAdapters.ItemTableAdapter()
        Me.ViewReservationRoomTableAdapter = New Hotel.DbHotelDataSetTableAdapters.ViewReservationRoomTableAdapter()
        Me.ReservationRequestItemTableAdapter = New Hotel.DbHotelDataSetTableAdapters.ReservationRequestItemTableAdapter()
        Me.ViewFDCheckoutTableAdapter = New Hotel.DbHotelDataSetTableAdapters.ViewFDCheckoutTableAdapter()
        Me.ReservationCheckoutTableAdapter = New Hotel.DbHotelDataSetTableAdapters.ReservationCheckoutTableAdapter()
        Me.FoodName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodOption = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FDCheckoutID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FDRoomID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FDID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FdCheckOutTableAdapter = New Hotel.DbHotelDataSetTableAdapters.FDCheckOutTableAdapter()
        Me.PanelHeader.SuspendLayout()
        Me.PanelControl.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbHotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvFoods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.Silver
        Me.PanelHeader.Controls.Add(Me.LabelHeader)
        Me.PanelHeader.Controls.Add(Me.PanelControl)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(800, 40)
        Me.PanelHeader.TabIndex = 11
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = True
        Me.LabelHeader.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelHeader.Location = New System.Drawing.Point(351, 12)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(84, 19)
        Me.LabelHeader.TabIndex = 4
        Me.LabelHeader.Text = "Checkout"
        '
        'PanelControl
        '
        Me.PanelControl.Controls.Add(Me.BtnMinimize)
        Me.PanelControl.Controls.Add(Me.BtnClose)
        Me.PanelControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl.Location = New System.Drawing.Point(709, 0)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(91, 40)
        Me.PanelControl.TabIndex = 3
        '
        'BtnMinimize
        '
        Me.BtnMinimize.FlatAppearance.BorderSize = 0
        Me.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimize.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinimize.ForeColor = System.Drawing.Color.Black
        Me.BtnMinimize.Location = New System.Drawing.Point(6, 0)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(40, 40)
        Me.BtnMinimize.TabIndex = 2
        Me.BtnMinimize.Text = "_"
        Me.BtnMinimize.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.Location = New System.Drawing.Point(53, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(40, 40)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbRoom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 57)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kamar yang Sedang Dipakai"
        '
        'CbRoom
        '
        Me.CbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbRoom.FormattingEnabled = True
        Me.CbRoom.Location = New System.Drawing.Point(130, 24)
        Me.CbRoom.Name = "CbRoom"
        Me.CbRoom.Size = New System.Drawing.Size(253, 24)
        Me.CbRoom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Kamar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TbSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.BtnAddItem)
        Me.GroupBox2.Controls.Add(Me.CbStatus)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TbCompFee)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.NumQty)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CbItem)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(775, 126)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Barang"
        '
        'TbSubTotal
        '
        Me.TbSubTotal.Location = New System.Drawing.Point(517, 93)
        Me.TbSubTotal.Name = "TbSubTotal"
        Me.TbSubTotal.ReadOnly = True
        Me.TbSubTotal.Size = New System.Drawing.Size(253, 22)
        Me.TbSubTotal.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(405, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Sub Total"
        '
        'BtnAddItem
        '
        Me.BtnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAddItem.FlatAppearance.BorderSize = 0
        Me.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddItem.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAddItem.Location = New System.Drawing.Point(21, 89)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(75, 26)
        Me.BtnAddItem.TabIndex = 14
        Me.BtnAddItem.Text = "Tambah"
        Me.BtnAddItem.UseVisualStyleBackColor = False
        '
        'CbStatus
        '
        Me.CbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbStatus.FormattingEnabled = True
        Me.CbStatus.Items.AddRange(New Object() {"NORMAL", "RUSAK"})
        Me.CbStatus.Location = New System.Drawing.Point(517, 63)
        Me.CbStatus.Name = "CbStatus"
        Me.CbStatus.Size = New System.Drawing.Size(253, 24)
        Me.CbStatus.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(405, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Denda"
        '
        'TbCompFee
        '
        Me.TbCompFee.Location = New System.Drawing.Point(517, 35)
        Me.TbCompFee.Name = "TbCompFee"
        Me.TbCompFee.ReadOnly = True
        Me.TbCompFee.Size = New System.Drawing.Size(253, 22)
        Me.TbCompFee.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(405, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Status"
        '
        'NumQty
        '
        Me.NumQty.Location = New System.Drawing.Point(130, 60)
        Me.NumQty.Name = "NumQty"
        Me.NumQty.Size = New System.Drawing.Size(253, 22)
        Me.NumQty.TabIndex = 3
        Me.NumQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah"
        '
        'CbItem
        '
        Me.CbItem.DataSource = Me.ItemBindingSource
        Me.CbItem.DisplayMember = "Name"
        Me.CbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbItem.FormattingEnabled = True
        Me.CbItem.Location = New System.Drawing.Point(130, 30)
        Me.CbItem.Name = "CbItem"
        Me.CbItem.Size = New System.Drawing.Size(253, 24)
        Me.CbItem.TabIndex = 1
        Me.CbItem.ValueMember = "ID"
        '
        'ItemBindingSource
        '
        Me.ItemBindingSource.DataMember = "Item"
        Me.ItemBindingSource.DataSource = Me.DbHotelDataSet
        '
        'DbHotelDataSet
        '
        Me.DbHotelDataSet.DataSetName = "DbHotelDataSet"
        Me.DbHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Barang"
        '
        'DgvItem
        '
        Me.DgvItem.AllowUserToAddRows = False
        Me.DgvItem.AllowUserToDeleteRows = False
        Me.DgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemName, Me.Quantity, Me.ItemCompFee, Me.SubTotal, Me.ItemOption})
        Me.DgvItem.Location = New System.Drawing.Point(13, 241)
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.ReadOnly = True
        Me.DgvItem.RowHeadersWidth = 51
        Me.DgvItem.RowTemplate.Height = 24
        Me.DgvItem.Size = New System.Drawing.Size(775, 194)
        Me.DgvItem.TabIndex = 15
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Barang"
        Me.ItemName.MinimumWidth = 6
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 125
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Jumlah"
        Me.Quantity.MinimumWidth = 6
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 75
        '
        'ItemCompFee
        '
        Me.ItemCompFee.HeaderText = "Denda"
        Me.ItemCompFee.MinimumWidth = 6
        Me.ItemCompFee.Name = "ItemCompFee"
        Me.ItemCompFee.ReadOnly = True
        Me.ItemCompFee.Width = 125
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "Sub Total"
        Me.SubTotal.MinimumWidth = 6
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        Me.SubTotal.Width = 125
        '
        'ItemOption
        '
        Me.ItemOption.HeaderText = "Opsi"
        Me.ItemOption.MinimumWidth = 6
        Me.ItemOption.Name = "ItemOption"
        Me.ItemOption.ReadOnly = True
        Me.ItemOption.Width = 125
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(575, 442)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Total: Rp."
        '
        'LabelTotalItem
        '
        Me.LabelTotalItem.AutoSize = True
        Me.LabelTotalItem.Location = New System.Drawing.Point(662, 442)
        Me.LabelTotalItem.Name = "LabelTotalItem"
        Me.LabelTotalItem.Size = New System.Drawing.Size(14, 16)
        Me.LabelTotalItem.TabIndex = 17
        Me.LabelTotalItem.Text = "0"
        '
        'DgvFoods
        '
        Me.DgvFoods.AllowUserToAddRows = False
        Me.DgvFoods.AllowUserToDeleteRows = False
        Me.DgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFoods.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FoodName, Me.FoodType, Me.FoodPrice, Me.FoodQty, Me.FoodSubTotal, Me.FoodOption, Me.FDCheckoutID, Me.FDRoomID, Me.FDID})
        Me.DgvFoods.Location = New System.Drawing.Point(13, 483)
        Me.DgvFoods.Name = "DgvFoods"
        Me.DgvFoods.ReadOnly = True
        Me.DgvFoods.RowHeadersWidth = 51
        Me.DgvFoods.RowTemplate.Height = 24
        Me.DgvFoods.Size = New System.Drawing.Size(775, 194)
        Me.DgvFoods.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 464)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Makanan dan Minuman"
        '
        'LabelTotalFoods
        '
        Me.LabelTotalFoods.AutoSize = True
        Me.LabelTotalFoods.Location = New System.Drawing.Point(662, 689)
        Me.LabelTotalFoods.Name = "LabelTotalFoods"
        Me.LabelTotalFoods.Size = New System.Drawing.Size(14, 16)
        Me.LabelTotalFoods.TabIndex = 21
        Me.LabelTotalFoods.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(575, 689)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Total: Rp."
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSubmit.FlatAppearance.BorderSize = 0
        Me.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubmit.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSubmit.Location = New System.Drawing.Point(15, 712)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 26)
        Me.BtnSubmit.TabIndex = 22
        Me.BtnSubmit.Text = "Simpan"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(661, 715)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(18, 19)
        Me.LabelTotal.TabIndex = 24
        Me.LabelTotal.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(537, 717)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 16)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Total Biaya: Rp."
        '
        'ItemTableAdapter
        '
        Me.ItemTableAdapter.ClearBeforeFill = True
        '
        'ViewReservationRoomTableAdapter
        '
        Me.ViewReservationRoomTableAdapter.ClearBeforeFill = True
        '
        'ReservationRequestItemTableAdapter
        '
        Me.ReservationRequestItemTableAdapter.ClearBeforeFill = True
        '
        'ViewFDCheckoutTableAdapter
        '
        Me.ViewFDCheckoutTableAdapter.ClearBeforeFill = True
        '
        'ReservationCheckoutTableAdapter
        '
        Me.ReservationCheckoutTableAdapter.ClearBeforeFill = True
        '
        'FoodName
        '
        Me.FoodName.DataPropertyName = "Name"
        Me.FoodName.HeaderText = "Nama"
        Me.FoodName.MinimumWidth = 6
        Me.FoodName.Name = "FoodName"
        Me.FoodName.ReadOnly = True
        Me.FoodName.Width = 150
        '
        'FoodType
        '
        Me.FoodType.DataPropertyName = "Type"
        Me.FoodType.HeaderText = "Tipe"
        Me.FoodType.MinimumWidth = 6
        Me.FoodType.Name = "FoodType"
        Me.FoodType.ReadOnly = True
        Me.FoodType.Width = 75
        '
        'FoodPrice
        '
        Me.FoodPrice.DataPropertyName = "Price"
        Me.FoodPrice.HeaderText = "Harga"
        Me.FoodPrice.MinimumWidth = 6
        Me.FoodPrice.Name = "FoodPrice"
        Me.FoodPrice.ReadOnly = True
        Me.FoodPrice.Width = 75
        '
        'FoodQty
        '
        Me.FoodQty.DataPropertyName = "Qty"
        Me.FoodQty.HeaderText = "Jumlah"
        Me.FoodQty.MinimumWidth = 6
        Me.FoodQty.Name = "FoodQty"
        Me.FoodQty.ReadOnly = True
        Me.FoodQty.Width = 75
        '
        'FoodSubTotal
        '
        Me.FoodSubTotal.DataPropertyName = "TotalPrice"
        Me.FoodSubTotal.HeaderText = "Sub Total"
        Me.FoodSubTotal.MinimumWidth = 6
        Me.FoodSubTotal.Name = "FoodSubTotal"
        Me.FoodSubTotal.ReadOnly = True
        Me.FoodSubTotal.Width = 125
        '
        'FoodOption
        '
        Me.FoodOption.HeaderText = "Opsi"
        Me.FoodOption.MinimumWidth = 6
        Me.FoodOption.Name = "FoodOption"
        Me.FoodOption.ReadOnly = True
        Me.FoodOption.Text = "Hapus"
        Me.FoodOption.UseColumnTextForButtonValue = True
        Me.FoodOption.Width = 125
        '
        'FDCheckoutID
        '
        Me.FDCheckoutID.DataPropertyName = "ID"
        Me.FDCheckoutID.HeaderText = "ID"
        Me.FDCheckoutID.MinimumWidth = 6
        Me.FDCheckoutID.Name = "FDCheckoutID"
        Me.FDCheckoutID.ReadOnly = True
        Me.FDCheckoutID.Visible = False
        Me.FDCheckoutID.Width = 125
        '
        'FDRoomID
        '
        Me.FDRoomID.DataPropertyName = "ReservationRoomID"
        Me.FDRoomID.HeaderText = "ReservationRoomID"
        Me.FDRoomID.MinimumWidth = 6
        Me.FDRoomID.Name = "FDRoomID"
        Me.FDRoomID.ReadOnly = True
        Me.FDRoomID.Visible = False
        Me.FDRoomID.Width = 125
        '
        'FDID
        '
        Me.FDID.DataPropertyName = "FDID"
        Me.FDID.HeaderText = "FDID"
        Me.FDID.MinimumWidth = 6
        Me.FDID.Name = "FDID"
        Me.FDID.ReadOnly = True
        Me.FDID.Visible = False
        Me.FDID.Width = 125
        '
        'FdCheckOutTableAdapter
        '
        Me.FdCheckOutTableAdapter.ClearBeforeFill = True
        '
        'FormCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 750)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.LabelTotalFoods)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DgvFoods)
        Me.Controls.Add(Me.LabelTotalItem)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DgvItem)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCheckout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCheckout"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.PanelControl.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbHotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvFoods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LabelHeader As Label
    Friend WithEvents PanelControl As Panel
    Friend WithEvents BtnMinimize As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbRoom As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumQty As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents CbItem As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbStatus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbCompFee As TextBox
    Friend WithEvents BtnAddItem As Button
    Friend WithEvents DgvItem As DataGridView
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents ItemCompFee As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents ItemOption As DataGridViewButtonColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelTotalItem As Label
    Friend WithEvents DgvFoods As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelTotalFoods As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DbHotelDataSet As DbHotelDataSet
    Friend WithEvents ItemBindingSource As BindingSource
    Friend WithEvents ItemTableAdapter As DbHotelDataSetTableAdapters.ItemTableAdapter
    Friend WithEvents ViewReservationRoomTableAdapter As DbHotelDataSetTableAdapters.ViewReservationRoomTableAdapter
    Friend WithEvents ReservationRequestItemTableAdapter As DbHotelDataSetTableAdapters.ReservationRequestItemTableAdapter
    Friend WithEvents TbSubTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ViewFDCheckoutTableAdapter As DbHotelDataSetTableAdapters.ViewFDCheckoutTableAdapter
    Friend WithEvents ReservationCheckoutTableAdapter As DbHotelDataSetTableAdapters.ReservationCheckoutTableAdapter
    Friend WithEvents FoodName As DataGridViewTextBoxColumn
    Friend WithEvents FoodType As DataGridViewTextBoxColumn
    Friend WithEvents FoodPrice As DataGridViewTextBoxColumn
    Friend WithEvents FoodQty As DataGridViewTextBoxColumn
    Friend WithEvents FoodSubTotal As DataGridViewTextBoxColumn
    Friend WithEvents FoodOption As DataGridViewButtonColumn
    Friend WithEvents FDCheckoutID As DataGridViewTextBoxColumn
    Friend WithEvents FDRoomID As DataGridViewTextBoxColumn
    Friend WithEvents FDID As DataGridViewTextBoxColumn
    Friend WithEvents FdCheckOutTableAdapter As DbHotelDataSetTableAdapters.FDCheckOutTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReservation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PanelAdd = New System.Windows.Forms.Panel()
        Me.DateBirth = New System.Windows.Forms.DateTimePicker()
        Me.CbGender = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbPhone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNIK = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelSearch = New System.Windows.Forms.Panel()
        Me.DgvCustomer = New System.Windows.Forms.DataGridView()
        Me.Choose = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PanelCustomerHeader = New System.Windows.Forms.Panel()
        Me.TbSearch = New System.Windows.Forms.TextBox()
        Me.RbSearch = New System.Windows.Forms.RadioButton()
        Me.RbAdd = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumStaying = New System.Windows.Forms.NumericUpDown()
        Me.DateCheckout = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateCheckin = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnSearchRoom = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CbTypeRoom = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DgvRoom = New System.Windows.Forms.DataGridView()
        Me.ARoomID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARoomNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARoomPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARoomFloor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARoomTypeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARoomType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACapacity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DgvRoomChoosed = New System.Windows.Forms.DataGridView()
        Me.RoomNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomFloor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAddRoom = New System.Windows.Forms.Button()
        Me.BtnRemoveRoom = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BtnAddItem = New System.Windows.Forms.Button()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Options = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TbSubTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TbPrice = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NumQuantity = New System.Windows.Forms.NumericUpDown()
        Me.CbItem = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LbTotalPrice = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbHotelDataSet = New Hotel.DbHotelDataSet()
        Me.RoomTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Hotel.DbHotelDataSetTableAdapters.CustomerTableAdapter()
        Me.RoomTypeTableAdapter = New Hotel.DbHotelDataSetTableAdapters.RoomTypeTableAdapter()
        Me.ItemTableAdapter = New Hotel.DbHotelDataSetTableAdapters.ItemTableAdapter()
        Me.ViewRoomTableAdapter = New Hotel.DbHotelDataSetTableAdapters.ViewRoomTableAdapter()
        Me.ReservationTableAdapter = New Hotel.DbHotelDataSetTableAdapters.ReservationTableAdapter()
        Me.ReservationRoomTableAdapter = New Hotel.DbHotelDataSetTableAdapters.ReservationRoomTableAdapter()
        Me.ReservationRequestItemTableAdapter = New Hotel.DbHotelDataSetTableAdapters.ReservationRequestItemTableAdapter()
        Me.PanelHeader.SuspendLayout()
        Me.PanelControl.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelAdd.SuspendLayout()
        Me.PanelSearch.SuspendLayout()
        CType(Me.DgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCustomerHeader.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumStaying, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DgvRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DgvRoomChoosed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbHotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.Silver
        Me.PanelHeader.Controls.Add(Me.Label9)
        Me.PanelHeader.Controls.Add(Me.PanelControl)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1000, 40)
        Me.PanelHeader.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(447, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 19)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Reservasi"
        '
        'PanelControl
        '
        Me.PanelControl.Controls.Add(Me.BtnMinimize)
        Me.PanelControl.Controls.Add(Me.BtnClose)
        Me.PanelControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl.Location = New System.Drawing.Point(908, 0)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(92, 40)
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
        Me.BtnClose.Location = New System.Drawing.Point(52, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(40, 40)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PanelAdd)
        Me.GroupBox1.Controls.Add(Me.PanelSearch)
        Me.GroupBox1.Controls.Add(Me.PanelCustomerHeader)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 259)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informasi Pelanggan"
        '
        'PanelAdd
        '
        Me.PanelAdd.Controls.Add(Me.DateBirth)
        Me.PanelAdd.Controls.Add(Me.CbGender)
        Me.PanelAdd.Controls.Add(Me.Label6)
        Me.PanelAdd.Controls.Add(Me.TbPhone)
        Me.PanelAdd.Controls.Add(Me.Label5)
        Me.PanelAdd.Controls.Add(Me.Label4)
        Me.PanelAdd.Controls.Add(Me.TbEmail)
        Me.PanelAdd.Controls.Add(Me.Label3)
        Me.PanelAdd.Controls.Add(Me.TbNIK)
        Me.PanelAdd.Controls.Add(Me.Label2)
        Me.PanelAdd.Controls.Add(Me.TbName)
        Me.PanelAdd.Controls.Add(Me.Label1)
        Me.PanelAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAdd.Location = New System.Drawing.Point(3, 53)
        Me.PanelAdd.Name = "PanelAdd"
        Me.PanelAdd.Size = New System.Drawing.Size(490, 203)
        Me.PanelAdd.TabIndex = 1
        Me.PanelAdd.Visible = False
        '
        'DateBirth
        '
        Me.DateBirth.Location = New System.Drawing.Point(125, 166)
        Me.DateBirth.Name = "DateBirth"
        Me.DateBirth.Size = New System.Drawing.Size(362, 22)
        Me.DateBirth.TabIndex = 13
        '
        'CbGender
        '
        Me.CbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbGender.FormattingEnabled = True
        Me.CbGender.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.CbGender.Location = New System.Drawing.Point(125, 105)
        Me.CbGender.Name = "CbGender"
        Me.CbGender.Size = New System.Drawing.Size(362, 24)
        Me.CbGender.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date of Birth"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TbPhone
        '
        Me.TbPhone.Location = New System.Drawing.Point(125, 139)
        Me.TbPhone.Name = "TbPhone"
        Me.TbPhone.Size = New System.Drawing.Size(362, 22)
        Me.TbPhone.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nomor HP"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Jenis Kelamin"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TbEmail
        '
        Me.TbEmail.Location = New System.Drawing.Point(125, 77)
        Me.TbEmail.Name = "TbEmail"
        Me.TbEmail.Size = New System.Drawing.Size(362, 22)
        Me.TbEmail.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TbNIK
        '
        Me.TbNIK.Location = New System.Drawing.Point(125, 46)
        Me.TbNIK.Name = "TbNIK"
        Me.TbNIK.Size = New System.Drawing.Size(362, 22)
        Me.TbNIK.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIK"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TbName
        '
        Me.TbName.Location = New System.Drawing.Point(125, 15)
        Me.TbName.Name = "TbName"
        Me.TbName.Size = New System.Drawing.Size(362, 22)
        Me.TbName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Lengkap"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelSearch
        '
        Me.PanelSearch.Controls.Add(Me.DgvCustomer)
        Me.PanelSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSearch.Location = New System.Drawing.Point(3, 53)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(490, 203)
        Me.PanelSearch.TabIndex = 1
        '
        'DgvCustomer
        '
        Me.DgvCustomer.AllowUserToAddRows = False
        Me.DgvCustomer.AllowUserToDeleteRows = False
        Me.DgvCustomer.AutoGenerateColumns = False
        Me.DgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.Choose, Me.NameDataGridViewTextBoxColumn, Me.NIKDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.BirthDateDataGridViewTextBoxColumn})
        Me.DgvCustomer.DataSource = Me.CustomerBindingSource
        Me.DgvCustomer.Location = New System.Drawing.Point(6, 6)
        Me.DgvCustomer.Name = "DgvCustomer"
        Me.DgvCustomer.ReadOnly = True
        Me.DgvCustomer.RowHeadersWidth = 51
        Me.DgvCustomer.RowTemplate.Height = 24
        Me.DgvCustomer.Size = New System.Drawing.Size(481, 185)
        Me.DgvCustomer.TabIndex = 0
        '
        'Choose
        '
        Me.Choose.HeaderText = "Pilih"
        Me.Choose.MinimumWidth = 6
        Me.Choose.Name = "Choose"
        Me.Choose.ReadOnly = True
        Me.Choose.Width = 50
        '
        'PanelCustomerHeader
        '
        Me.PanelCustomerHeader.Controls.Add(Me.TbSearch)
        Me.PanelCustomerHeader.Controls.Add(Me.RbSearch)
        Me.PanelCustomerHeader.Controls.Add(Me.RbAdd)
        Me.PanelCustomerHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCustomerHeader.Location = New System.Drawing.Point(3, 18)
        Me.PanelCustomerHeader.Name = "PanelCustomerHeader"
        Me.PanelCustomerHeader.Size = New System.Drawing.Size(490, 35)
        Me.PanelCustomerHeader.TabIndex = 0
        '
        'TbSearch
        '
        Me.TbSearch.Location = New System.Drawing.Point(203, 5)
        Me.TbSearch.Name = "TbSearch"
        Me.TbSearch.Size = New System.Drawing.Size(284, 22)
        Me.TbSearch.TabIndex = 5
        '
        'RbSearch
        '
        Me.RbSearch.AutoSize = True
        Me.RbSearch.Checked = True
        Me.RbSearch.Location = New System.Drawing.Point(141, 6)
        Me.RbSearch.Name = "RbSearch"
        Me.RbSearch.Size = New System.Drawing.Size(51, 20)
        Me.RbSearch.TabIndex = 4
        Me.RbSearch.TabStop = True
        Me.RbSearch.Text = "Cari"
        Me.RbSearch.UseVisualStyleBackColor = True
        '
        'RbAdd
        '
        Me.RbAdd.AutoSize = True
        Me.RbAdd.Location = New System.Drawing.Point(3, 6)
        Me.RbAdd.Name = "RbAdd"
        Me.RbAdd.Size = New System.Drawing.Size(104, 20)
        Me.RbAdd.TabIndex = 3
        Me.RbAdd.Text = "Tambah Baru"
        Me.RbAdd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.NumStaying)
        Me.GroupBox2.Controls.Add(Me.DateCheckout)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.DateCheckin)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(514, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(474, 128)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informasi Reservasi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 16)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Lama Tinggal"
        '
        'NumStaying
        '
        Me.NumStaying.Location = New System.Drawing.Point(119, 62)
        Me.NumStaying.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumStaying.Name = "NumStaying"
        Me.NumStaying.Size = New System.Drawing.Size(349, 22)
        Me.NumStaying.TabIndex = 4
        Me.NumStaying.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumStaying.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DateCheckout
        '
        Me.DateCheckout.Location = New System.Drawing.Point(119, 93)
        Me.DateCheckout.Name = "DateCheckout"
        Me.DateCheckout.Size = New System.Drawing.Size(349, 22)
        Me.DateCheckout.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Check Out"
        '
        'DateCheckin
        '
        Me.DateCheckin.Location = New System.Drawing.Point(119, 31)
        Me.DateCheckin.Name = "DateCheckin"
        Me.DateCheckin.Size = New System.Drawing.Size(349, 22)
        Me.DateCheckin.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Check In"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnSearchRoom)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.CbTypeRoom)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(514, 190)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(474, 121)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informasi Kamar"
        '
        'BtnSearchRoom
        '
        Me.BtnSearchRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSearchRoom.FlatAppearance.BorderSize = 0
        Me.BtnSearchRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchRoom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchRoom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSearchRoom.Location = New System.Drawing.Point(119, 65)
        Me.BtnSearchRoom.Name = "BtnSearchRoom"
        Me.BtnSearchRoom.Size = New System.Drawing.Size(100, 30)
        Me.BtnSearchRoom.TabIndex = 2
        Me.BtnSearchRoom.Text = "Cari"
        Me.BtnSearchRoom.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Tipe Kamar"
        '
        'CbTypeRoom
        '
        Me.CbTypeRoom.DataSource = Me.RoomTypeBindingSource
        Me.CbTypeRoom.DisplayMember = "Name"
        Me.CbTypeRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTypeRoom.FormattingEnabled = True
        Me.CbTypeRoom.Location = New System.Drawing.Point(119, 34)
        Me.CbTypeRoom.Name = "CbTypeRoom"
        Me.CbTypeRoom.Size = New System.Drawing.Size(349, 24)
        Me.CbTypeRoom.TabIndex = 0
        Me.CbTypeRoom.ValueMember = "ID"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DgvRoom)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 320)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(441, 243)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Kamar Tersedia"
        '
        'DgvRoom
        '
        Me.DgvRoom.AllowUserToAddRows = False
        Me.DgvRoom.AllowUserToDeleteRows = False
        Me.DgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRoom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ARoomID, Me.ARoomNumber, Me.ARoomPrice, Me.ARoomFloor, Me.ADescription, Me.ARoomTypeID, Me.ARoomType, Me.ACapacity})
        Me.DgvRoom.Location = New System.Drawing.Point(3, 22)
        Me.DgvRoom.Name = "DgvRoom"
        Me.DgvRoom.ReadOnly = True
        Me.DgvRoom.RowHeadersWidth = 51
        Me.DgvRoom.RowTemplate.Height = 24
        Me.DgvRoom.Size = New System.Drawing.Size(432, 215)
        Me.DgvRoom.TabIndex = 0
        '
        'ARoomID
        '
        Me.ARoomID.DataPropertyName = "ID"
        Me.ARoomID.HeaderText = "ID"
        Me.ARoomID.MinimumWidth = 6
        Me.ARoomID.Name = "ARoomID"
        Me.ARoomID.ReadOnly = True
        Me.ARoomID.Visible = False
        Me.ARoomID.Width = 125
        '
        'ARoomNumber
        '
        Me.ARoomNumber.DataPropertyName = "RoomNumber"
        Me.ARoomNumber.HeaderText = "No. Kamar"
        Me.ARoomNumber.MinimumWidth = 6
        Me.ARoomNumber.Name = "ARoomNumber"
        Me.ARoomNumber.ReadOnly = True
        Me.ARoomNumber.Width = 125
        '
        'ARoomPrice
        '
        Me.ARoomPrice.DataPropertyName = "RoomPrice"
        Me.ARoomPrice.HeaderText = "Harga"
        Me.ARoomPrice.MinimumWidth = 6
        Me.ARoomPrice.Name = "ARoomPrice"
        Me.ARoomPrice.ReadOnly = True
        Me.ARoomPrice.Width = 125
        '
        'ARoomFloor
        '
        Me.ARoomFloor.DataPropertyName = "RoomFloor"
        Me.ARoomFloor.HeaderText = "Lantai"
        Me.ARoomFloor.MinimumWidth = 6
        Me.ARoomFloor.Name = "ARoomFloor"
        Me.ARoomFloor.ReadOnly = True
        Me.ARoomFloor.Width = 75
        '
        'ADescription
        '
        Me.ADescription.DataPropertyName = "Description"
        Me.ADescription.HeaderText = "Deskripsi"
        Me.ADescription.MinimumWidth = 6
        Me.ADescription.Name = "ADescription"
        Me.ADescription.ReadOnly = True
        Me.ADescription.Width = 125
        '
        'ARoomTypeID
        '
        Me.ARoomTypeID.DataPropertyName = "RoomTypeID"
        Me.ARoomTypeID.HeaderText = "RoomTypeID"
        Me.ARoomTypeID.MinimumWidth = 6
        Me.ARoomTypeID.Name = "ARoomTypeID"
        Me.ARoomTypeID.ReadOnly = True
        Me.ARoomTypeID.Visible = False
        Me.ARoomTypeID.Width = 125
        '
        'ARoomType
        '
        Me.ARoomType.DataPropertyName = "RoomType"
        Me.ARoomType.HeaderText = "RoomType"
        Me.ARoomType.MinimumWidth = 6
        Me.ARoomType.Name = "ARoomType"
        Me.ARoomType.ReadOnly = True
        Me.ARoomType.Visible = False
        Me.ARoomType.Width = 125
        '
        'ACapacity
        '
        Me.ACapacity.DataPropertyName = "Capacity"
        Me.ACapacity.HeaderText = "Capacity"
        Me.ACapacity.MinimumWidth = 6
        Me.ACapacity.Name = "ACapacity"
        Me.ACapacity.ReadOnly = True
        Me.ACapacity.Visible = False
        Me.ACapacity.Width = 125
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DgvRoomChoosed)
        Me.GroupBox5.Location = New System.Drawing.Point(550, 319)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(441, 243)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Kamar Dipilih"
        '
        'DgvRoomChoosed
        '
        Me.DgvRoomChoosed.AllowUserToAddRows = False
        Me.DgvRoomChoosed.AllowUserToDeleteRows = False
        Me.DgvRoomChoosed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRoomChoosed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomNumber, Me.RoomPrice, Me.RoomFloor, Me.Description})
        Me.DgvRoomChoosed.Location = New System.Drawing.Point(5, 22)
        Me.DgvRoomChoosed.Name = "DgvRoomChoosed"
        Me.DgvRoomChoosed.ReadOnly = True
        Me.DgvRoomChoosed.RowHeadersWidth = 51
        Me.DgvRoomChoosed.RowTemplate.Height = 24
        Me.DgvRoomChoosed.Size = New System.Drawing.Size(430, 215)
        Me.DgvRoomChoosed.TabIndex = 0
        '
        'RoomNumber
        '
        Me.RoomNumber.HeaderText = "No. Kamar"
        Me.RoomNumber.MinimumWidth = 6
        Me.RoomNumber.Name = "RoomNumber"
        Me.RoomNumber.ReadOnly = True
        Me.RoomNumber.Width = 125
        '
        'RoomPrice
        '
        Me.RoomPrice.HeaderText = "Harga"
        Me.RoomPrice.MinimumWidth = 6
        Me.RoomPrice.Name = "RoomPrice"
        Me.RoomPrice.ReadOnly = True
        Me.RoomPrice.Width = 125
        '
        'RoomFloor
        '
        Me.RoomFloor.HeaderText = "Lantai"
        Me.RoomFloor.MinimumWidth = 6
        Me.RoomFloor.Name = "RoomFloor"
        Me.RoomFloor.ReadOnly = True
        Me.RoomFloor.Width = 75
        '
        'Description
        '
        Me.Description.HeaderText = "Deskripsi"
        Me.Description.MinimumWidth = 6
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 125
        '
        'BtnAddRoom
        '
        Me.BtnAddRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAddRoom.FlatAppearance.BorderSize = 0
        Me.BtnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddRoom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddRoom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAddRoom.Location = New System.Drawing.Point(462, 414)
        Me.BtnAddRoom.Name = "BtnAddRoom"
        Me.BtnAddRoom.Size = New System.Drawing.Size(82, 30)
        Me.BtnAddRoom.TabIndex = 14
        Me.BtnAddRoom.Text = ">>"
        Me.BtnAddRoom.UseVisualStyleBackColor = False
        '
        'BtnRemoveRoom
        '
        Me.BtnRemoveRoom.BackColor = System.Drawing.Color.Maroon
        Me.BtnRemoveRoom.FlatAppearance.BorderSize = 0
        Me.BtnRemoveRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemoveRoom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveRoom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnRemoveRoom.Location = New System.Drawing.Point(462, 450)
        Me.BtnRemoveRoom.Name = "BtnRemoveRoom"
        Me.BtnRemoveRoom.Size = New System.Drawing.Size(82, 30)
        Me.BtnRemoveRoom.TabIndex = 15
        Me.BtnRemoveRoom.Text = "<<"
        Me.BtnRemoveRoom.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BtnAddItem)
        Me.GroupBox6.Controls.Add(Me.DgvItem)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.TbSubTotal)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.TbPrice)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.NumQuantity)
        Me.GroupBox6.Controls.Add(Me.CbItem)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(15, 568)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(754, 294)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tambahan Barang"
        '
        'BtnAddItem
        '
        Me.BtnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAddItem.FlatAppearance.BorderSize = 0
        Me.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAddItem.Location = New System.Drawing.Point(666, 91)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(82, 30)
        Me.BtnAddItem.TabIndex = 15
        Me.BtnAddItem.Text = "Tambah"
        Me.BtnAddItem.UseVisualStyleBackColor = False
        '
        'DgvItem
        '
        Me.DgvItem.AllowUserToAddRows = False
        Me.DgvItem.AllowUserToDeleteRows = False
        Me.DgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.Quantity, Me.Price, Me.SubTotal, Me.Options})
        Me.DgvItem.Location = New System.Drawing.Point(6, 91)
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.ReadOnly = True
        Me.DgvItem.RowHeadersWidth = 51
        Me.DgvItem.RowTemplate.Height = 24
        Me.DgvItem.Size = New System.Drawing.Size(656, 194)
        Me.DgvItem.TabIndex = 8
        '
        'Item
        '
        Me.Item.HeaderText = "Barang"
        Me.Item.MinimumWidth = 6
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 125
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Jumlah"
        Me.Quantity.MinimumWidth = 6
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 75
        '
        'Price
        '
        Me.Price.HeaderText = "Harga"
        Me.Price.MinimumWidth = 6
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 75
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "Sub Total"
        Me.SubTotal.MinimumWidth = 6
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        Me.SubTotal.Width = 125
        '
        'Options
        '
        Me.Options.HeaderText = "Opsi"
        Me.Options.MinimumWidth = 6
        Me.Options.Name = "Options"
        Me.Options.ReadOnly = True
        Me.Options.Text = "Hapus"
        Me.Options.Width = 125
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(386, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 16)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Sub Total"
        '
        'TbSubTotal
        '
        Me.TbSubTotal.Location = New System.Drawing.Point(464, 53)
        Me.TbSubTotal.Name = "TbSubTotal"
        Me.TbSubTotal.ReadOnly = True
        Me.TbSubTotal.Size = New System.Drawing.Size(284, 22)
        Me.TbSubTotal.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(406, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 16)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Harga"
        '
        'TbPrice
        '
        Me.TbPrice.Location = New System.Drawing.Point(464, 24)
        Me.TbPrice.Name = "TbPrice"
        Me.TbPrice.ReadOnly = True
        Me.TbPrice.Size = New System.Drawing.Size(284, 22)
        Me.TbPrice.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Jumlah"
        '
        'NumQuantity
        '
        Me.NumQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NumQuantity.Location = New System.Drawing.Point(81, 51)
        Me.NumQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumQuantity.Name = "NumQuantity"
        Me.NumQuantity.Size = New System.Drawing.Size(265, 22)
        Me.NumQuantity.TabIndex = 2
        Me.NumQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CbItem
        '
        Me.CbItem.DataSource = Me.ItemBindingSource
        Me.CbItem.DisplayMember = "Name"
        Me.CbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbItem.FormattingEnabled = True
        Me.CbItem.Location = New System.Drawing.Point(81, 21)
        Me.CbItem.Name = "CbItem"
        Me.CbItem.Size = New System.Drawing.Size(265, 24)
        Me.CbItem.TabIndex = 1
        Me.CbItem.ValueMember = "ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Barang"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(775, 589)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 17)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Total Harga: Rp."
        '
        'LbTotalPrice
        '
        Me.LbTotalPrice.AutoSize = True
        Me.LbTotalPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalPrice.Location = New System.Drawing.Point(905, 589)
        Me.LbTotalPrice.Name = "LbTotalPrice"
        Me.LbTotalPrice.Size = New System.Drawing.Size(16, 17)
        Me.LbTotalPrice.TabIndex = 18
        Me.LbTotalPrice.Text = "0"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSubmit.FlatAppearance.BorderSize = 0
        Me.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubmit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSubmit.Location = New System.Drawing.Point(778, 619)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(82, 30)
        Me.BtnSubmit.TabIndex = 19
        Me.BtnSubmit.Text = "Simpan"
        Me.BtnSubmit.UseVisualStyleBackColor = False
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
        'RoomTypeBindingSource
        '
        Me.RoomTypeBindingSource.DataMember = "RoomType"
        Me.RoomTypeBindingSource.DataSource = Me.DbHotelDataSet
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'NIKDataGridViewTextBoxColumn
        '
        Me.NIKDataGridViewTextBoxColumn.DataPropertyName = "NIK"
        Me.NIKDataGridViewTextBoxColumn.HeaderText = "NIK"
        Me.NIKDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NIKDataGridViewTextBoxColumn.Name = "NIKDataGridViewTextBoxColumn"
        Me.NIKDataGridViewTextBoxColumn.ReadOnly = True
        Me.NIKDataGridViewTextBoxColumn.Visible = False
        Me.NIKDataGridViewTextBoxColumn.Width = 125
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Width = 125
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn.Width = 125
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        Me.PhoneNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhoneNumberDataGridViewTextBoxColumn.Visible = False
        Me.PhoneNumberDataGridViewTextBoxColumn.Width = 125
        '
        'BirthDateDataGridViewTextBoxColumn
        '
        Me.BirthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate"
        Me.BirthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate"
        Me.BirthDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BirthDateDataGridViewTextBoxColumn.Name = "BirthDateDataGridViewTextBoxColumn"
        Me.BirthDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.BirthDateDataGridViewTextBoxColumn.Visible = False
        Me.BirthDateDataGridViewTextBoxColumn.Width = 125
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.DbHotelDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'RoomTypeTableAdapter
        '
        Me.RoomTypeTableAdapter.ClearBeforeFill = True
        '
        'ItemTableAdapter
        '
        Me.ItemTableAdapter.ClearBeforeFill = True
        '
        'ViewRoomTableAdapter
        '
        Me.ViewRoomTableAdapter.ClearBeforeFill = True
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'ReservationRoomTableAdapter
        '
        Me.ReservationRoomTableAdapter.ClearBeforeFill = True
        '
        'ReservationRequestItemTableAdapter
        '
        Me.ReservationRequestItemTableAdapter.ClearBeforeFill = True
        '
        'FormReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1000, 875)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.LbTotalPrice)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.BtnRemoveRoom)
        Me.Controls.Add(Me.BtnAddRoom)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormReservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.PanelControl.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.PanelAdd.ResumeLayout(False)
        Me.PanelAdd.PerformLayout()
        Me.PanelSearch.ResumeLayout(False)
        CType(Me.DgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCustomerHeader.ResumeLayout(False)
        Me.PanelCustomerHeader.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumStaying, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DgvRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DgvRoomChoosed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbHotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelControl As Panel
    Friend WithEvents BtnMinimize As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PanelCustomerHeader As Panel
    Friend WithEvents TbSearch As TextBox
    Friend WithEvents RbSearch As RadioButton
    Friend WithEvents RbAdd As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvCustomer As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DbHotelDataSet As DbHotelDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As DbHotelDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents Label10 As Label
    Friend WithEvents NumStaying As NumericUpDown
    Friend WithEvents DateCheckout As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents DateCheckin As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnSearchRoom As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents CbTypeRoom As ComboBox
    Friend WithEvents RoomTypeBindingSource As BindingSource
    Friend WithEvents RoomTypeTableAdapter As DbHotelDataSetTableAdapters.RoomTypeTableAdapter
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BtnAddRoom As Button
    Friend WithEvents BtnRemoveRoom As Button
    Friend WithEvents DgvRoom As DataGridView
    Friend WithEvents DgvRoomChoosed As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TbSubTotal As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TbPrice As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents NumQuantity As NumericUpDown
    Friend WithEvents CbItem As ComboBox
    Friend WithEvents DgvItem As DataGridView
    Friend WithEvents BtnAddItem As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents LbTotalPrice As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents ItemBindingSource As BindingSource
    Friend WithEvents ItemTableAdapter As DbHotelDataSetTableAdapters.ItemTableAdapter
    Friend WithEvents ViewRoomTableAdapter As DbHotelDataSetTableAdapters.ViewRoomTableAdapter
    Friend WithEvents RoomNumber As DataGridViewTextBoxColumn
    Friend WithEvents RoomPrice As DataGridViewTextBoxColumn
    Friend WithEvents RoomFloor As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents ARoomID As DataGridViewTextBoxColumn
    Friend WithEvents ARoomNumber As DataGridViewTextBoxColumn
    Friend WithEvents ARoomPrice As DataGridViewTextBoxColumn
    Friend WithEvents ARoomFloor As DataGridViewTextBoxColumn
    Friend WithEvents ADescription As DataGridViewTextBoxColumn
    Friend WithEvents ARoomTypeID As DataGridViewTextBoxColumn
    Friend WithEvents ARoomType As DataGridViewTextBoxColumn
    Friend WithEvents ACapacity As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents Options As DataGridViewButtonColumn
    Friend WithEvents PanelSearch As Panel
    Friend WithEvents PanelAdd As Panel
    Friend WithEvents DateBirth As DateTimePicker
    Friend WithEvents CbGender As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbPhone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbNIK As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Choose As DataGridViewCheckBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NIKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReservationTableAdapter As DbHotelDataSetTableAdapters.ReservationTableAdapter
    Friend WithEvents ReservationRoomTableAdapter As DbHotelDataSetTableAdapters.ReservationRoomTableAdapter
    Friend WithEvents ReservationRequestItemTableAdapter As DbHotelDataSetTableAdapters.ReservationRequestItemTableAdapter
End Class

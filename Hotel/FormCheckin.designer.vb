<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCheckin
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PanelSearch = New System.Windows.Forms.Panel()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbSearch = New System.Windows.Forms.TextBox()
        Me.GbRoom = New System.Windows.Forms.GroupBox()
        Me.DgvRoom = New System.Windows.Forms.DataGridView()
        Me.GbCustomer = New System.Windows.Forms.GroupBox()
        Me.DateBirth = New System.Windows.Forms.DateTimePicker()
        Me.RbFemale = New System.Windows.Forms.RadioButton()
        Me.RbMale = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbNIK = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbPhone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerTableAdapter = New Hotel.DbHotelDataSetTableAdapters.CustomerTableAdapter()
        Me.ViewRoomCheckinTableAdapter = New Hotel.DbHotelDataSetTableAdapters.ViewRoomCheckinTableAdapter()
        Me.BtnCheckin = New System.Windows.Forms.Button()
        Me.RoomNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomFloor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationRoomTableAdapter = New Hotel.DbHotelDataSetTableAdapters.ReservationRoomTableAdapter()
        Me.PanelHeader.SuspendLayout()
        Me.PanelControl.SuspendLayout()
        Me.PanelSearch.SuspendLayout()
        Me.GbRoom.SuspendLayout()
        CType(Me.DgvRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCustomer.SuspendLayout()
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
        Me.PanelHeader.Size = New System.Drawing.Size(1000, 40)
        Me.PanelHeader.TabIndex = 9
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = True
        Me.LabelHeader.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelHeader.Location = New System.Drawing.Point(447, 12)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(77, 19)
        Me.LabelHeader.TabIndex = 4
        Me.LabelHeader.Text = "Check In"
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
        'PanelSearch
        '
        Me.PanelSearch.Controls.Add(Me.BtnSearch)
        Me.PanelSearch.Controls.Add(Me.Label1)
        Me.PanelSearch.Controls.Add(Me.TbSearch)
        Me.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSearch.Location = New System.Drawing.Point(0, 40)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(1000, 65)
        Me.PanelSearch.TabIndex = 10
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSearch.Location = New System.Drawing.Point(620, 18)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 30)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.Text = "Cari"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(45, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Booking"
        '
        'TbSearch
        '
        Me.TbSearch.Location = New System.Drawing.Point(171, 22)
        Me.TbSearch.Name = "TbSearch"
        Me.TbSearch.Size = New System.Drawing.Size(427, 22)
        Me.TbSearch.TabIndex = 0
        '
        'GbRoom
        '
        Me.GbRoom.Controls.Add(Me.DgvRoom)
        Me.GbRoom.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbRoom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GbRoom.Location = New System.Drawing.Point(12, 111)
        Me.GbRoom.Name = "GbRoom"
        Me.GbRoom.Size = New System.Drawing.Size(500, 327)
        Me.GbRoom.TabIndex = 11
        Me.GbRoom.TabStop = False
        Me.GbRoom.Text = "Informasi Kamar"
        '
        'DgvRoom
        '
        Me.DgvRoom.AllowUserToAddRows = False
        Me.DgvRoom.AllowUserToDeleteRows = False
        Me.DgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRoom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomNumber, Me.RoomFloor, Me.RoomType, Me.StartDate, Me.ID, Me.BookingCode, Me.StartDateTime, Me.CustomerID})
        Me.DgvRoom.Location = New System.Drawing.Point(7, 22)
        Me.DgvRoom.Name = "DgvRoom"
        Me.DgvRoom.ReadOnly = True
        Me.DgvRoom.RowHeadersWidth = 51
        Me.DgvRoom.RowTemplate.Height = 24
        Me.DgvRoom.Size = New System.Drawing.Size(487, 299)
        Me.DgvRoom.TabIndex = 0
        '
        'GbCustomer
        '
        Me.GbCustomer.Controls.Add(Me.DateBirth)
        Me.GbCustomer.Controls.Add(Me.RbFemale)
        Me.GbCustomer.Controls.Add(Me.RbMale)
        Me.GbCustomer.Controls.Add(Me.Label7)
        Me.GbCustomer.Controls.Add(Me.TbNIK)
        Me.GbCustomer.Controls.Add(Me.Label6)
        Me.GbCustomer.Controls.Add(Me.Label5)
        Me.GbCustomer.Controls.Add(Me.TbEmail)
        Me.GbCustomer.Controls.Add(Me.Label4)
        Me.GbCustomer.Controls.Add(Me.TbName)
        Me.GbCustomer.Controls.Add(Me.Label3)
        Me.GbCustomer.Controls.Add(Me.TbPhone)
        Me.GbCustomer.Controls.Add(Me.Label2)
        Me.GbCustomer.Enabled = False
        Me.GbCustomer.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GbCustomer.Location = New System.Drawing.Point(518, 111)
        Me.GbCustomer.Name = "GbCustomer"
        Me.GbCustomer.Size = New System.Drawing.Size(470, 223)
        Me.GbCustomer.TabIndex = 12
        Me.GbCustomer.TabStop = False
        Me.GbCustomer.Text = "Informasi Pelanggan"
        '
        'DateBirth
        '
        Me.DateBirth.Location = New System.Drawing.Point(127, 169)
        Me.DateBirth.Name = "DateBirth"
        Me.DateBirth.Size = New System.Drawing.Size(337, 22)
        Me.DateBirth.TabIndex = 14
        '
        'RbFemale
        '
        Me.RbFemale.AutoSize = True
        Me.RbFemale.Location = New System.Drawing.Point(246, 116)
        Me.RbFemale.Name = "RbFemale"
        Me.RbFemale.Size = New System.Drawing.Size(94, 20)
        Me.RbFemale.TabIndex = 13
        Me.RbFemale.Text = "Perempuan"
        Me.RbFemale.UseVisualStyleBackColor = True
        '
        'RbMale
        '
        Me.RbMale.AutoSize = True
        Me.RbMale.Checked = True
        Me.RbMale.Location = New System.Drawing.Point(127, 116)
        Me.RbMale.Name = "RbMale"
        Me.RbMale.Size = New System.Drawing.Size(80, 20)
        Me.RbMale.TabIndex = 12
        Me.RbMale.TabStop = True
        Me.RbMale.Text = "Laki-Laki"
        Me.RbMale.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tanggal Lahir"
        '
        'TbNIK
        '
        Me.TbNIK.Location = New System.Drawing.Point(127, 143)
        Me.TbNIK.Name = "TbNIK"
        Me.TbNIK.Size = New System.Drawing.Size(337, 22)
        Me.TbNIK.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "NIK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Jenis Kelamin"
        '
        'TbEmail
        '
        Me.TbEmail.Location = New System.Drawing.Point(127, 87)
        Me.TbEmail.Name = "TbEmail"
        Me.TbEmail.Size = New System.Drawing.Size(337, 22)
        Me.TbEmail.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Email"
        '
        'TbName
        '
        Me.TbName.Location = New System.Drawing.Point(127, 59)
        Me.TbName.Name = "TbName"
        Me.TbName.Size = New System.Drawing.Size(337, 22)
        Me.TbName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Lengkap"
        '
        'TbPhone
        '
        Me.TbPhone.Location = New System.Drawing.Point(127, 31)
        Me.TbPhone.Name = "TbPhone"
        Me.TbPhone.Size = New System.Drawing.Size(337, 22)
        Me.TbPhone.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nomor HP"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'ViewRoomCheckinTableAdapter
        '
        Me.ViewRoomCheckinTableAdapter.ClearBeforeFill = True
        '
        'BtnCheckin
        '
        Me.BtnCheckin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCheckin.FlatAppearance.BorderSize = 0
        Me.BtnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCheckin.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCheckin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCheckin.Location = New System.Drawing.Point(537, 350)
        Me.BtnCheckin.Name = "BtnCheckin"
        Me.BtnCheckin.Size = New System.Drawing.Size(75, 30)
        Me.BtnCheckin.TabIndex = 13
        Me.BtnCheckin.Text = "Checkin"
        Me.BtnCheckin.UseVisualStyleBackColor = False
        '
        'RoomNumber
        '
        Me.RoomNumber.DataPropertyName = "RoomNumber"
        Me.RoomNumber.HeaderText = "No. Kamar"
        Me.RoomNumber.MinimumWidth = 6
        Me.RoomNumber.Name = "RoomNumber"
        Me.RoomNumber.ReadOnly = True
        Me.RoomNumber.Width = 125
        '
        'RoomFloor
        '
        Me.RoomFloor.DataPropertyName = "RoomFloor"
        Me.RoomFloor.HeaderText = "Lantai"
        Me.RoomFloor.MinimumWidth = 6
        Me.RoomFloor.Name = "RoomFloor"
        Me.RoomFloor.ReadOnly = True
        Me.RoomFloor.Width = 75
        '
        'RoomType
        '
        Me.RoomType.DataPropertyName = "RoomType"
        Me.RoomType.HeaderText = "Tipe Kamar"
        Me.RoomType.MinimumWidth = 6
        Me.RoomType.Name = "RoomType"
        Me.RoomType.ReadOnly = True
        Me.RoomType.Width = 125
        '
        'StartDate
        '
        Me.StartDate.DataPropertyName = "CheckinDateTime"
        Me.StartDate.HeaderText = "Tanggal"
        Me.StartDate.MinimumWidth = 6
        Me.StartDate.Name = "StartDate"
        Me.StartDate.ReadOnly = True
        Me.StartDate.Width = 125
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 125
        '
        'BookingCode
        '
        Me.BookingCode.DataPropertyName = "BookingCode"
        Me.BookingCode.HeaderText = "BookingCode"
        Me.BookingCode.MinimumWidth = 6
        Me.BookingCode.Name = "BookingCode"
        Me.BookingCode.ReadOnly = True
        Me.BookingCode.Visible = False
        Me.BookingCode.Width = 125
        '
        'StartDateTime
        '
        Me.StartDateTime.DataPropertyName = "StartDateTime"
        Me.StartDateTime.HeaderText = "StartDateTime"
        Me.StartDateTime.MinimumWidth = 6
        Me.StartDateTime.Name = "StartDateTime"
        Me.StartDateTime.ReadOnly = True
        Me.StartDateTime.Visible = False
        Me.StartDateTime.Width = 125
        '
        'CustomerID
        '
        Me.CustomerID.DataPropertyName = "CustomerID"
        Me.CustomerID.HeaderText = "CustomerID"
        Me.CustomerID.MinimumWidth = 6
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.ReadOnly = True
        Me.CustomerID.Visible = False
        Me.CustomerID.Width = 125
        '
        'ReservationRoomTableAdapter
        '
        Me.ReservationRoomTableAdapter.ClearBeforeFill = True
        '
        'FormCheckin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1000, 450)
        Me.Controls.Add(Me.BtnCheckin)
        Me.Controls.Add(Me.GbCustomer)
        Me.Controls.Add(Me.GbRoom)
        Me.Controls.Add(Me.PanelSearch)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCheckin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.PanelControl.ResumeLayout(False)
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        Me.GbRoom.ResumeLayout(False)
        CType(Me.DgvRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCustomer.ResumeLayout(False)
        Me.GbCustomer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LabelHeader As Label
    Friend WithEvents PanelControl As Panel
    Friend WithEvents BtnMinimize As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents PanelSearch As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TbSearch As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents GbRoom As GroupBox
    Friend WithEvents DgvRoom As DataGridView
    Friend WithEvents GbCustomer As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbNIK As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TbEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbPhone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CustomerTableAdapter As DbHotelDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents RbFemale As RadioButton
    Friend WithEvents RbMale As RadioButton
    Friend WithEvents DateBirth As DateTimePicker
    Friend WithEvents ViewRoomCheckinTableAdapter As DbHotelDataSetTableAdapters.ViewRoomCheckinTableAdapter
    Friend WithEvents BtnCheckin As Button
    Friend WithEvents RoomNumber As DataGridViewTextBoxColumn
    Friend WithEvents RoomFloor As DataGridViewTextBoxColumn
    Friend WithEvents RoomType As DataGridViewTextBoxColumn
    Friend WithEvents StartDate As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents BookingCode As DataGridViewTextBoxColumn
    Friend WithEvents StartDateTime As DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents ReservationRoomTableAdapter As DbHotelDataSetTableAdapters.ReservationRoomTableAdapter
End Class

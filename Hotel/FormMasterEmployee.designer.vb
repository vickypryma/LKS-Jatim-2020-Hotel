<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterEmployee
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
        Me.ViewEmployeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbHotelDataSet = New Hotel.DbHotelDataSet()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbJob = New System.Windows.Forms.ComboBox()
        Me.TbDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbConfirm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelChange = New System.Windows.Forms.Panel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.PanelSubmit = New System.Windows.Forms.Panel()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ViewEmployeeTableAdapter = New Hotel.DbHotelDataSetTableAdapters.ViewEmployeeTableAdapter()
        Me.TableAdapterManager = New Hotel.DbHotelDataSetTableAdapters.TableAdapterManager()
        Me.EmployeeTableAdapter = New Hotel.DbHotelDataSetTableAdapters.EmployeeTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        CType(Me.ViewEmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbHotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelForm.SuspendLayout()
        Me.PanelChange.SuspendLayout()
        Me.PanelSubmit.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ViewEmployeeDataGridView
        '
        Me.ViewEmployeeDataGridView.AllowUserToAddRows = False
        Me.ViewEmployeeDataGridView.AllowUserToDeleteRows = False
        Me.ViewEmployeeDataGridView.AutoGenerateColumns = False
        Me.ViewEmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewEmployeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ViewEmployeeDataGridView.DataSource = Me.ViewEmployeeBindingSource
        Me.ViewEmployeeDataGridView.Location = New System.Drawing.Point(12, 441)
        Me.ViewEmployeeDataGridView.Name = "ViewEmployeeDataGridView"
        Me.ViewEmployeeDataGridView.ReadOnly = True
        Me.ViewEmployeeDataGridView.RowHeadersWidth = 51
        Me.ViewEmployeeDataGridView.RowTemplate.Height = 24
        Me.ViewEmployeeDataGridView.Size = New System.Drawing.Size(776, 347)
        Me.ViewEmployeeDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Job"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Job"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'ViewEmployeeBindingSource
        '
        Me.ViewEmployeeBindingSource.DataMember = "ViewEmployee"
        Me.ViewEmployeeBindingSource.DataSource = Me.DbHotelDataSet
        '
        'DbHotelDataSet
        '
        Me.DbHotelDataSet.DataSetName = "DbHotelDataSet"
        Me.DbHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PanelForm
        '
        Me.PanelForm.Controls.Add(Me.Label8)
        Me.PanelForm.Controls.Add(Me.TbAddress)
        Me.PanelForm.Controls.Add(Me.Label7)
        Me.PanelForm.Controls.Add(Me.CbJob)
        Me.PanelForm.Controls.Add(Me.TbDate)
        Me.PanelForm.Controls.Add(Me.Label6)
        Me.PanelForm.Controls.Add(Me.TbEmail)
        Me.PanelForm.Controls.Add(Me.Label5)
        Me.PanelForm.Controls.Add(Me.TbName)
        Me.PanelForm.Controls.Add(Me.Label4)
        Me.PanelForm.Controls.Add(Me.TbConfirm)
        Me.PanelForm.Controls.Add(Me.Label3)
        Me.PanelForm.Controls.Add(Me.TbPassword)
        Me.PanelForm.Controls.Add(Me.Label2)
        Me.PanelForm.Controls.Add(Me.TbUsername)
        Me.PanelForm.Controls.Add(Me.Label1)
        Me.PanelForm.Enabled = False
        Me.PanelForm.Location = New System.Drawing.Point(12, 46)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(592, 375)
        Me.PanelForm.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(12, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Address"
        '
        'TbAddress
        '
        Me.TbAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbAddress.Location = New System.Drawing.Point(193, 224)
        Me.TbAddress.Multiline = True
        Me.TbAddress.Name = "TbAddress"
        Me.TbAddress.Size = New System.Drawing.Size(367, 127)
        Me.TbAddress.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Job"
        '
        'CbJob
        '
        Me.CbJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbJob.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbJob.FormattingEnabled = True
        Me.CbJob.Items.AddRange(New Object() {"Front Office", "Admin"})
        Me.CbJob.Location = New System.Drawing.Point(193, 194)
        Me.CbJob.Name = "CbJob"
        Me.CbJob.Size = New System.Drawing.Size(367, 25)
        Me.CbJob.TabIndex = 12
        '
        'TbDate
        '
        Me.TbDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDate.Location = New System.Drawing.Point(193, 165)
        Me.TbDate.Name = "TbDate"
        Me.TbDate.Size = New System.Drawing.Size(367, 25)
        Me.TbDate.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date of  Birth"
        '
        'TbEmail
        '
        Me.TbEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbEmail.Location = New System.Drawing.Point(193, 136)
        Me.TbEmail.Name = "TbEmail"
        Me.TbEmail.Size = New System.Drawing.Size(367, 25)
        Me.TbEmail.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Email"
        '
        'TbName
        '
        Me.TbName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbName.Location = New System.Drawing.Point(193, 108)
        Me.TbName.Name = "TbName"
        Me.TbName.Size = New System.Drawing.Size(367, 25)
        Me.TbName.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Name"
        '
        'TbConfirm
        '
        Me.TbConfirm.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbConfirm.Location = New System.Drawing.Point(193, 80)
        Me.TbConfirm.Name = "TbConfirm"
        Me.TbConfirm.Size = New System.Drawing.Size(367, 25)
        Me.TbConfirm.TabIndex = 5
        Me.TbConfirm.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Confirm Password"
        '
        'TbPassword
        '
        Me.TbPassword.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPassword.Location = New System.Drawing.Point(193, 52)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.Size = New System.Drawing.Size(367, 25)
        Me.TbPassword.TabIndex = 3
        Me.TbPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'TbUsername
        '
        Me.TbUsername.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUsername.Location = New System.Drawing.Point(193, 24)
        Me.TbUsername.Name = "TbUsername"
        Me.TbUsername.Size = New System.Drawing.Size(367, 25)
        Me.TbUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'PanelChange
        '
        Me.PanelChange.Controls.Add(Me.BtnDelete)
        Me.PanelChange.Controls.Add(Me.BtnUpdate)
        Me.PanelChange.Controls.Add(Me.BtnInsert)
        Me.PanelChange.Location = New System.Drawing.Point(610, 46)
        Me.PanelChange.Name = "PanelChange"
        Me.PanelChange.Size = New System.Drawing.Size(178, 175)
        Me.PanelChange.TabIndex = 3
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Maroon
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDelete.Location = New System.Drawing.Point(3, 116)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(172, 40)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.BorderSize = 0
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnUpdate.Location = New System.Drawing.Point(3, 70)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(172, 40)
        Me.BtnUpdate.TabIndex = 1
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnInsert
        '
        Me.BtnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnInsert.FlatAppearance.BorderSize = 0
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsert.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnInsert.Location = New System.Drawing.Point(3, 27)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(172, 40)
        Me.BtnInsert.TabIndex = 0
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = False
        '
        'PanelSubmit
        '
        Me.PanelSubmit.Controls.Add(Me.BtnCancel)
        Me.PanelSubmit.Controls.Add(Me.BtnSave)
        Me.PanelSubmit.Enabled = False
        Me.PanelSubmit.Location = New System.Drawing.Point(610, 228)
        Me.PanelSubmit.Name = "PanelSubmit"
        Me.PanelSubmit.Size = New System.Drawing.Size(178, 143)
        Me.PanelSubmit.TabIndex = 4
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Maroon
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCancel.Location = New System.Drawing.Point(3, 54)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(172, 40)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSave.Location = New System.Drawing.Point(3, 8)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(172, 40)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'ViewEmployeeTableAdapter
        '
        Me.ViewEmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.FDCheckOutTableAdapter = Nothing
        Me.TableAdapterManager.FoodsAndDrinksTableAdapter = Nothing
        Me.TableAdapterManager.ItemStatusTableAdapter = Nothing
        Me.TableAdapterManager.ItemTableAdapter = Nothing
        Me.TableAdapterManager.JobTableAdapter = Nothing
        Me.TableAdapterManager.ReservationCheckoutTableAdapter = Nothing
        Me.TableAdapterManager.ReservationRequestItemTableAdapter = Nothing
        Me.TableAdapterManager.ReservationRoomTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableAdapter = Nothing
        Me.TableAdapterManager.RoomTableAdapter = Nothing
        Me.TableAdapterManager.RoomTypeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Hotel.DbHotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 40)
        Me.Panel2.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(334, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 19)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Data Karyawan"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BtnMinimize)
        Me.Panel4.Controls.Add(Me.BtnClose)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(708, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(92, 40)
        Me.Panel4.TabIndex = 3
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
        'FormMasterEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 800)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelSubmit)
        Me.Controls.Add(Me.PanelChange)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.ViewEmployeeDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMasterEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Karyawan"
        CType(Me.ViewEmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbHotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelForm.ResumeLayout(False)
        Me.PanelForm.PerformLayout()
        Me.PanelChange.ResumeLayout(False)
        Me.PanelSubmit.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DbHotelDataSet As DbHotelDataSet
    Friend WithEvents ViewEmployeeBindingSource As BindingSource
    Friend WithEvents ViewEmployeeTableAdapter As DbHotelDataSetTableAdapters.ViewEmployeeTableAdapter
    Friend WithEvents TableAdapterManager As DbHotelDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ViewEmployeeDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents PanelForm As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TbAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbJob As ComboBox
    Friend WithEvents TbDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents TbEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbConfirm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelChange As Panel
    Friend WithEvents PanelSubmit As Panel
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnInsert As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents EmployeeTableAdapter As DbHotelDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnMinimize As Button
    Friend WithEvents BtnClose As Button
End Class

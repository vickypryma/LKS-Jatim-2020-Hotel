<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMasterRoom
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.DbHotelDataSet = New Hotel.DbHotelDataSet()
        Me.TableAdapterManager = New Hotel.DbHotelDataSetTableAdapters.TableAdapterManager()
        Me.ViewRoomDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomTypeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewRoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.NumFloor = New System.Windows.Forms.NumericUpDown()
        Me.CbType = New System.Windows.Forms.ComboBox()
        Me.RoomTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelSubmit = New System.Windows.Forms.Panel()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.PanelChange = New System.Windows.Forms.Panel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.RoomTypeTableAdapter = New Hotel.DbHotelDataSetTableAdapters.RoomTypeTableAdapter()
        Me.ViewRoomTableAdapter = New Hotel.DbHotelDataSetTableAdapters.ViewRoomTableAdapter()
        Me.RoomTableAdapter = New Hotel.DbHotelDataSetTableAdapters.RoomTableAdapter()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DbHotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewRoomDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewRoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelForm.SuspendLayout()
        CType(Me.NumFloor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSubmit.SuspendLayout()
        Me.PanelChange.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 40)
        Me.Panel2.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(257, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 19)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Data Kamar"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BtnMinimize)
        Me.Panel4.Controls.Add(Me.BtnClose)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(508, 0)
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
        'DbHotelDataSet
        '
        Me.DbHotelDataSet.DataSetName = "DbHotelDataSet"
        Me.DbHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ViewRoomDataGridView
        '
        Me.ViewRoomDataGridView.AllowUserToAddRows = False
        Me.ViewRoomDataGridView.AllowUserToDeleteRows = False
        Me.ViewRoomDataGridView.AutoGenerateColumns = False
        Me.ViewRoomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewRoomDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.RoomTypeID, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ViewRoomDataGridView.DataSource = Me.ViewRoomBindingSource
        Me.ViewRoomDataGridView.Location = New System.Drawing.Point(15, 328)
        Me.ViewRoomDataGridView.Name = "ViewRoomDataGridView"
        Me.ViewRoomDataGridView.ReadOnly = True
        Me.ViewRoomDataGridView.RowHeadersWidth = 51
        Me.ViewRoomDataGridView.RowTemplate.Height = 24
        Me.ViewRoomDataGridView.Size = New System.Drawing.Size(576, 260)
        Me.ViewRoomDataGridView.TabIndex = 8
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
        'RoomTypeID
        '
        Me.RoomTypeID.DataPropertyName = "RoomTypeID"
        Me.RoomTypeID.HeaderText = "RoomTypeID"
        Me.RoomTypeID.MinimumWidth = 6
        Me.RoomTypeID.Name = "RoomTypeID"
        Me.RoomTypeID.ReadOnly = True
        Me.RoomTypeID.Visible = False
        Me.RoomTypeID.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RoomNumber"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RoomNumber"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RoomType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RoomType"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RoomFloor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RoomFloor"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'ViewRoomBindingSource
        '
        Me.ViewRoomBindingSource.DataMember = "ViewRoom"
        Me.ViewRoomBindingSource.DataSource = Me.DbHotelDataSet
        '
        'PanelForm
        '
        Me.PanelForm.Controls.Add(Me.NumFloor)
        Me.PanelForm.Controls.Add(Me.CbType)
        Me.PanelForm.Controls.Add(Me.TbDescription)
        Me.PanelForm.Controls.Add(Me.Label4)
        Me.PanelForm.Controls.Add(Me.Label3)
        Me.PanelForm.Controls.Add(Me.Label2)
        Me.PanelForm.Controls.Add(Me.TbNumber)
        Me.PanelForm.Controls.Add(Me.Label1)
        Me.PanelForm.Enabled = False
        Me.PanelForm.Location = New System.Drawing.Point(12, 46)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(576, 231)
        Me.PanelForm.TabIndex = 9
        '
        'NumFloor
        '
        Me.NumFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumFloor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumFloor.Location = New System.Drawing.Point(153, 74)
        Me.NumFloor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumFloor.Name = "NumFloor"
        Me.NumFloor.Size = New System.Drawing.Size(408, 25)
        Me.NumFloor.TabIndex = 11
        Me.NumFloor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumFloor.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CbType
        '
        Me.CbType.DataSource = Me.RoomTypeBindingSource
        Me.CbType.DisplayMember = "Name"
        Me.CbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbType.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbType.FormattingEnabled = True
        Me.CbType.Location = New System.Drawing.Point(153, 43)
        Me.CbType.Name = "CbType"
        Me.CbType.Size = New System.Drawing.Size(408, 25)
        Me.CbType.TabIndex = 10
        Me.CbType.ValueMember = "ID"
        '
        'RoomTypeBindingSource
        '
        Me.RoomTypeBindingSource.DataMember = "RoomType"
        Me.RoomTypeBindingSource.DataSource = Me.DbHotelDataSet
        '
        'TbDescription
        '
        Me.TbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbDescription.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDescription.Location = New System.Drawing.Point(153, 105)
        Me.TbDescription.Multiline = True
        Me.TbDescription.Name = "TbDescription"
        Me.TbDescription.Size = New System.Drawing.Size(408, 123)
        Me.TbDescription.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(19, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(19, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Room Floor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(19, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Room Type"
        '
        'TbNumber
        '
        Me.TbNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbNumber.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNumber.Location = New System.Drawing.Point(153, 12)
        Me.TbNumber.Name = "TbNumber"
        Me.TbNumber.Size = New System.Drawing.Size(408, 25)
        Me.TbNumber.TabIndex = 3
        Me.TbNumber.Text = "1"
        Me.TbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Room Number"
        '
        'PanelSubmit
        '
        Me.PanelSubmit.Controls.Add(Me.BtnCancel)
        Me.PanelSubmit.Controls.Add(Me.BtnSave)
        Me.PanelSubmit.Enabled = False
        Me.PanelSubmit.Location = New System.Drawing.Point(336, 283)
        Me.PanelSubmit.Name = "PanelSubmit"
        Me.PanelSubmit.Size = New System.Drawing.Size(252, 39)
        Me.PanelSubmit.TabIndex = 12
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Maroon
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCancel.Location = New System.Drawing.Point(149, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 30)
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
        Me.BtnSave.Location = New System.Drawing.Point(43, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 30)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'PanelChange
        '
        Me.PanelChange.Controls.Add(Me.BtnDelete)
        Me.PanelChange.Controls.Add(Me.BtnUpdate)
        Me.PanelChange.Controls.Add(Me.BtnInsert)
        Me.PanelChange.Location = New System.Drawing.Point(12, 283)
        Me.PanelChange.Name = "PanelChange"
        Me.PanelChange.Size = New System.Drawing.Size(318, 40)
        Me.PanelChange.TabIndex = 11
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Maroon
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDelete.Location = New System.Drawing.Point(215, 3)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(100, 30)
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
        Me.BtnUpdate.Location = New System.Drawing.Point(109, 4)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(100, 30)
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
        Me.BtnInsert.Location = New System.Drawing.Point(3, 3)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(100, 30)
        Me.BtnInsert.TabIndex = 0
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = False
        '
        'RoomTypeTableAdapter
        '
        Me.RoomTypeTableAdapter.ClearBeforeFill = True
        '
        'ViewRoomTableAdapter
        '
        Me.ViewRoomTableAdapter.ClearBeforeFill = True
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
        '
        'FormMasterRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 600)
        Me.Controls.Add(Me.PanelSubmit)
        Me.Controls.Add(Me.PanelChange)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.ViewRoomDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMasterRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DbHotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewRoomDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewRoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelForm.ResumeLayout(False)
        Me.PanelForm.PerformLayout()
        CType(Me.NumFloor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSubmit.ResumeLayout(False)
        Me.PanelChange.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnMinimize As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents DbHotelDataSet As DbHotelDataSet
    Friend WithEvents ViewRoomBindingSource As BindingSource
    Friend WithEvents ViewRoomTableAdapter As DbHotelDataSetTableAdapters.ViewRoomTableAdapter
    Friend WithEvents TableAdapterManager As DbHotelDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ViewRoomDataGridView As DataGridView
    Friend WithEvents PanelForm As Panel
    Friend WithEvents TbNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbType As ComboBox
    Friend WithEvents TbDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelSubmit As Panel
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents PanelChange As Panel
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnInsert As Button
    Friend WithEvents NumFloor As NumericUpDown
    Friend WithEvents RoomTypeBindingSource As BindingSource
    Friend WithEvents RoomTypeTableAdapter As DbHotelDataSetTableAdapters.RoomTypeTableAdapter
    Friend WithEvents RoomTableAdapter As DbHotelDataSetTableAdapters.RoomTableAdapter
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents RoomTypeID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class

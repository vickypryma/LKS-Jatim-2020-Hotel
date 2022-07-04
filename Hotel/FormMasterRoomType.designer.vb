<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMasterRoomType
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
        Me.RoomTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomTypeTableAdapter = New Hotel.DbHotelDataSetTableAdapters.RoomTypeTableAdapter()
        Me.TableAdapterManager = New Hotel.DbHotelDataSetTableAdapters.TableAdapterManager()
        Me.RoomTypeDataGridView = New System.Windows.Forms.DataGridView()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.TbPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumCapacity = New System.Windows.Forms.NumericUpDown()
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelSubmit = New System.Windows.Forms.Panel()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.PanelChange = New System.Windows.Forms.Panel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DbHotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomTypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelForm.SuspendLayout()
        CType(Me.NumCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(233, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 19)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Data Tipe Kamar"
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
        'RoomTypeBindingSource
        '
        Me.RoomTypeBindingSource.DataMember = "RoomType"
        Me.RoomTypeBindingSource.DataSource = Me.DbHotelDataSet
        '
        'RoomTypeTableAdapter
        '
        Me.RoomTypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
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
        Me.TableAdapterManager.RoomTypeTableAdapter = Me.RoomTypeTableAdapter
        Me.TableAdapterManager.UpdateOrder = Hotel.DbHotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RoomTypeDataGridView
        '
        Me.RoomTypeDataGridView.AllowUserToAddRows = False
        Me.RoomTypeDataGridView.AllowUserToDeleteRows = False
        Me.RoomTypeDataGridView.AutoGenerateColumns = False
        Me.RoomTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RoomTypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.RoomTypeDataGridView.DataSource = Me.RoomTypeBindingSource
        Me.RoomTypeDataGridView.Location = New System.Drawing.Point(15, 208)
        Me.RoomTypeDataGridView.Name = "RoomTypeDataGridView"
        Me.RoomTypeDataGridView.ReadOnly = True
        Me.RoomTypeDataGridView.RowHeadersWidth = 51
        Me.RoomTypeDataGridView.RowTemplate.Height = 24
        Me.RoomTypeDataGridView.Size = New System.Drawing.Size(576, 230)
        Me.RoomTypeDataGridView.TabIndex = 7
        '
        'PanelForm
        '
        Me.PanelForm.Controls.Add(Me.TbPrice)
        Me.PanelForm.Controls.Add(Me.Label3)
        Me.PanelForm.Controls.Add(Me.Label2)
        Me.PanelForm.Controls.Add(Me.NumCapacity)
        Me.PanelForm.Controls.Add(Me.TbName)
        Me.PanelForm.Controls.Add(Me.Label1)
        Me.PanelForm.Enabled = False
        Me.PanelForm.Location = New System.Drawing.Point(12, 46)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(576, 110)
        Me.PanelForm.TabIndex = 8
        '
        'TbPrice
        '
        Me.TbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPrice.Location = New System.Drawing.Point(148, 73)
        Me.TbPrice.Name = "TbPrice"
        Me.TbPrice.Size = New System.Drawing.Size(408, 25)
        Me.TbPrice.TabIndex = 6
        Me.TbPrice.Text = "0"
        Me.TbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(14, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Price (Rp)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Capacity"
        '
        'NumCapacity
        '
        Me.NumCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumCapacity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumCapacity.Location = New System.Drawing.Point(148, 42)
        Me.NumCapacity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumCapacity.Name = "NumCapacity"
        Me.NumCapacity.Size = New System.Drawing.Size(408, 25)
        Me.NumCapacity.TabIndex = 2
        Me.NumCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumCapacity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TbName
        '
        Me.TbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbName.Location = New System.Drawing.Point(148, 11)
        Me.TbName.Name = "TbName"
        Me.TbName.Size = New System.Drawing.Size(408, 25)
        Me.TbName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'PanelSubmit
        '
        Me.PanelSubmit.Controls.Add(Me.BtnCancel)
        Me.PanelSubmit.Controls.Add(Me.BtnSave)
        Me.PanelSubmit.Enabled = False
        Me.PanelSubmit.Location = New System.Drawing.Point(336, 162)
        Me.PanelSubmit.Name = "PanelSubmit"
        Me.PanelSubmit.Size = New System.Drawing.Size(252, 39)
        Me.PanelSubmit.TabIndex = 10
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
        Me.PanelChange.Location = New System.Drawing.Point(12, 162)
        Me.PanelChange.Name = "PanelChange"
        Me.PanelChange.Size = New System.Drawing.Size(318, 40)
        Me.PanelChange.TabIndex = 9
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Capacity"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Capacity"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RoomPrice"
        Me.DataGridViewTextBoxColumn4.HeaderText = "RoomPrice"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'FormMasterRoomType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.PanelSubmit)
        Me.Controls.Add(Me.PanelChange)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.RoomTypeDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMasterRoomType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMasterRoomType"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DbHotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomTypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelForm.ResumeLayout(False)
        Me.PanelForm.PerformLayout()
        CType(Me.NumCapacity, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RoomTypeBindingSource As BindingSource
    Friend WithEvents RoomTypeTableAdapter As DbHotelDataSetTableAdapters.RoomTypeTableAdapter
    Friend WithEvents TableAdapterManager As DbHotelDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RoomTypeDataGridView As DataGridView
    Friend WithEvents PanelForm As Panel
    Friend WithEvents PanelSubmit As Panel
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents PanelChange As Panel
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnInsert As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumCapacity As NumericUpDown
    Friend WithEvents TbName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbPrice As TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class

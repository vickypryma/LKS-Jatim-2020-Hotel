<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TbUsername = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.DbHotelDataSet = New Hotel.DbHotelDataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New Hotel.DbHotelDataSetTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New Hotel.DbHotelDataSetTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DbHotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 74)
        Me.Panel1.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnClose.Location = New System.Drawing.Point(458, 23)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(30, 30)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(165, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hotel Login"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TbUsername)
        Me.Panel2.Location = New System.Drawing.Point(128, 105)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 41)
        Me.Panel2.TabIndex = 1
        '
        'TbUsername
        '
        Me.TbUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbUsername.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUsername.Location = New System.Drawing.Point(8, 8)
        Me.TbUsername.Margin = New System.Windows.Forms.Padding(8)
        Me.TbUsername.Name = "TbUsername"
        Me.TbUsername.Size = New System.Drawing.Size(246, 23)
        Me.TbUsername.TabIndex = 2
        Me.TbUsername.Text = "Username"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TbPassword)
        Me.Panel3.Location = New System.Drawing.Point(128, 161)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(262, 41)
        Me.Panel3.TabIndex = 2
        '
        'TbPassword
        '
        Me.TbPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPassword.Location = New System.Drawing.Point(8, 8)
        Me.TbPassword.Margin = New System.Windows.Forms.Padding(8)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.Size = New System.Drawing.Size(246, 23)
        Me.TbPassword.TabIndex = 2
        Me.TbPassword.Text = "Password"
        Me.TbPassword.UseSystemPasswordChar = True
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnLogin.Location = New System.Drawing.Point(160, 243)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(193, 43)
        Me.BtnLogin.TabIndex = 3
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'DbHotelDataSet
        '
        Me.DbHotelDataSet.DataSetName = "DbHotelDataSet"
        Me.DbHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.DbHotelDataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
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
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DbHotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DbHotelDataSet As DbHotelDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As DbHotelDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As DbHotelDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TbUsername As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnClose As Button
End Class

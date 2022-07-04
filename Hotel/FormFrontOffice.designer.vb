<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFrontOffice
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LbRole = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LbName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.PanelMaster = New System.Windows.Forms.Panel()
        Me.PanelTransaction = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnAddItem = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnCheckout = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnCheckin = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnReservation = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnMasterItem = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnMasterRoom = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnMasterRoomType = New System.Windows.Forms.Button()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LbMaster = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnMaster = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LbTransaction = New System.Windows.Forms.Label()
        Me.BtnTransaction = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelMaster.SuspendLayout()
        Me.PanelTransaction.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(7, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Menu Utama"
        '
        'LbRole
        '
        Me.LbRole.AutoSize = True
        Me.LbRole.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRole.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LbRole.Location = New System.Drawing.Point(85, 83)
        Me.LbRole.Name = "LbRole"
        Me.LbRole.Size = New System.Drawing.Size(74, 16)
        Me.LbRole.TabIndex = 7
        Me.LbRole.Text = "Front Office"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(90, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 2)
        Me.Label6.TabIndex = 6
        '
        'LbName
        '
        Me.LbName.AutoSize = True
        Me.LbName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LbName.Location = New System.Drawing.Point(84, 49)
        Me.LbName.Name = "LbName"
        Me.LbName.Size = New System.Drawing.Size(63, 24)
        Me.LbName.TabIndex = 5
        Me.LbName.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(85, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Selamat datang,"
        '
        'BtnLogout
        '
        Me.BtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnLogout.Location = New System.Drawing.Point(0, 560)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(250, 40)
        Me.BtnLogout.TabIndex = 2
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'PanelMaster
        '
        Me.PanelMaster.Controls.Add(Me.Label10)
        Me.PanelMaster.Controls.Add(Me.BtnMasterItem)
        Me.PanelMaster.Controls.Add(Me.Label7)
        Me.PanelMaster.Controls.Add(Me.BtnMasterRoom)
        Me.PanelMaster.Controls.Add(Me.Label9)
        Me.PanelMaster.Controls.Add(Me.Label2)
        Me.PanelMaster.Controls.Add(Me.BtnMasterRoomType)
        Me.PanelMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMaster.Location = New System.Drawing.Point(250, 40)
        Me.PanelMaster.Name = "PanelMaster"
        Me.PanelMaster.Size = New System.Drawing.Size(750, 560)
        Me.PanelMaster.TabIndex = 5
        '
        'PanelTransaction
        '
        Me.PanelTransaction.Controls.Add(Me.Label15)
        Me.PanelTransaction.Controls.Add(Me.BtnAddItem)
        Me.PanelTransaction.Controls.Add(Me.Label11)
        Me.PanelTransaction.Controls.Add(Me.BtnCheckout)
        Me.PanelTransaction.Controls.Add(Me.Label12)
        Me.PanelTransaction.Controls.Add(Me.BtnCheckin)
        Me.PanelTransaction.Controls.Add(Me.Label13)
        Me.PanelTransaction.Controls.Add(Me.Label14)
        Me.PanelTransaction.Controls.Add(Me.BtnReservation)
        Me.PanelTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTransaction.Location = New System.Drawing.Point(250, 40)
        Me.PanelTransaction.Name = "PanelTransaction"
        Me.PanelTransaction.Size = New System.Drawing.Size(750, 560)
        Me.PanelTransaction.TabIndex = 15
        Me.PanelTransaction.Visible = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(54, 467)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(200, 34)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Item Tambahan"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAddItem
        '
        Me.BtnAddItem.BackColor = System.Drawing.Color.Silver
        Me.BtnAddItem.FlatAppearance.BorderSize = 0
        Me.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddItem.Image = Global.Hotel.My.Resources.Resources.item
        Me.BtnAddItem.Location = New System.Drawing.Point(54, 301)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(200, 200)
        Me.BtnAddItem.TabIndex = 14
        Me.BtnAddItem.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(518, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(200, 34)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Check Out"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCheckout
        '
        Me.BtnCheckout.BackColor = System.Drawing.Color.Silver
        Me.BtnCheckout.FlatAppearance.BorderSize = 0
        Me.BtnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCheckout.Image = Global.Hotel.My.Resources.Resources.chekout
        Me.BtnCheckout.Location = New System.Drawing.Point(518, 68)
        Me.BtnCheckout.Name = "BtnCheckout"
        Me.BtnCheckout.Size = New System.Drawing.Size(200, 200)
        Me.BtnCheckout.TabIndex = 12
        Me.BtnCheckout.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(289, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(200, 34)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Check In"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCheckin
        '
        Me.BtnCheckin.BackColor = System.Drawing.Color.Silver
        Me.BtnCheckin.FlatAppearance.BorderSize = 0
        Me.BtnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCheckin.Image = Global.Hotel.My.Resources.Resources.checkin
        Me.BtnCheckin.Location = New System.Drawing.Point(289, 68)
        Me.BtnCheckin.Name = "BtnCheckin"
        Me.BtnCheckin.Size = New System.Drawing.Size(200, 200)
        Me.BtnCheckin.TabIndex = 10
        Me.BtnCheckin.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(54, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Transaksi"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Location = New System.Drawing.Point(54, 232)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(200, 34)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Reservasi"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnReservation
        '
        Me.BtnReservation.BackColor = System.Drawing.Color.Silver
        Me.BtnReservation.FlatAppearance.BorderSize = 0
        Me.BtnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReservation.Image = Global.Hotel.My.Resources.Resources.reservation
        Me.BtnReservation.Location = New System.Drawing.Point(54, 66)
        Me.BtnReservation.Name = "BtnReservation"
        Me.BtnReservation.Size = New System.Drawing.Size(200, 200)
        Me.BtnReservation.TabIndex = 0
        Me.BtnReservation.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(518, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 35)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Data Item"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnMasterItem
        '
        Me.BtnMasterItem.BackColor = System.Drawing.Color.Silver
        Me.BtnMasterItem.FlatAppearance.BorderSize = 0
        Me.BtnMasterItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMasterItem.Image = Global.Hotel.My.Resources.Resources.item
        Me.BtnMasterItem.Location = New System.Drawing.Point(518, 68)
        Me.BtnMasterItem.Name = "BtnMasterItem"
        Me.BtnMasterItem.Size = New System.Drawing.Size(200, 200)
        Me.BtnMasterItem.TabIndex = 12
        Me.BtnMasterItem.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(289, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 35)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Data Kamar"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnMasterRoom
        '
        Me.BtnMasterRoom.BackColor = System.Drawing.Color.Silver
        Me.BtnMasterRoom.FlatAppearance.BorderSize = 0
        Me.BtnMasterRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMasterRoom.Image = Global.Hotel.My.Resources.Resources.room
        Me.BtnMasterRoom.Location = New System.Drawing.Point(289, 68)
        Me.BtnMasterRoom.Name = "BtnMasterRoom"
        Me.BtnMasterRoom.Size = New System.Drawing.Size(200, 200)
        Me.BtnMasterRoom.TabIndex = 10
        Me.BtnMasterRoom.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(54, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Data Master"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(54, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data Tipe Kamar"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnMasterRoomType
        '
        Me.BtnMasterRoomType.BackColor = System.Drawing.Color.Silver
        Me.BtnMasterRoomType.FlatAppearance.BorderSize = 0
        Me.BtnMasterRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMasterRoomType.Image = Global.Hotel.My.Resources.Resources.roomtype
        Me.BtnMasterRoomType.Location = New System.Drawing.Point(54, 66)
        Me.BtnMasterRoomType.Name = "BtnMasterRoomType"
        Me.BtnMasterRoomType.Size = New System.Drawing.Size(200, 200)
        Me.BtnMasterRoomType.TabIndex = 0
        Me.BtnMasterRoomType.UseVisualStyleBackColor = False
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
        'LbMaster
        '
        Me.LbMaster.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbMaster.Location = New System.Drawing.Point(0, 160)
        Me.LbMaster.Name = "LbMaster"
        Me.LbMaster.Size = New System.Drawing.Size(5, 40)
        Me.LbMaster.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(250, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(750, 40)
        Me.Panel2.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BtnMinimize)
        Me.Panel4.Controls.Add(Me.BtnClose)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(658, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(92, 40)
        Me.Panel4.TabIndex = 3
        '
        'BtnMaster
        '
        Me.BtnMaster.FlatAppearance.BorderSize = 0
        Me.BtnMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaster.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMaster.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnMaster.Location = New System.Drawing.Point(-3, 160)
        Me.BtnMaster.Name = "BtnMaster"
        Me.BtnMaster.Size = New System.Drawing.Size(253, 40)
        Me.BtnMaster.TabIndex = 0
        Me.BtnMaster.Text = "Data Master"
        Me.BtnMaster.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LbTransaction)
        Me.Panel1.Controls.Add(Me.BtnTransaction)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.LbRole)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.LbName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.LbMaster)
        Me.Panel1.Controls.Add(Me.BtnMaster)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 600)
        Me.Panel1.TabIndex = 3
        '
        'LbTransaction
        '
        Me.LbTransaction.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LbTransaction.Location = New System.Drawing.Point(0, 206)
        Me.LbTransaction.Name = "LbTransaction"
        Me.LbTransaction.Size = New System.Drawing.Size(5, 40)
        Me.LbTransaction.TabIndex = 10
        Me.LbTransaction.Visible = False
        '
        'BtnTransaction
        '
        Me.BtnTransaction.FlatAppearance.BorderSize = 0
        Me.BtnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTransaction.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransaction.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnTransaction.Location = New System.Drawing.Point(-3, 206)
        Me.BtnTransaction.Name = "BtnTransaction"
        Me.BtnTransaction.Size = New System.Drawing.Size(253, 40)
        Me.BtnTransaction.TabIndex = 9
        Me.BtnTransaction.Text = "Transaksi"
        Me.BtnTransaction.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Image = Global.Hotel.My.Resources.Resources.user
        Me.Label3.Location = New System.Drawing.Point(8, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 70)
        Me.Label3.TabIndex = 3
        '
        'FormFrontOffice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.PanelTransaction)
        Me.Controls.Add(Me.PanelMaster)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormFrontOffice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormFrontOffice"
        Me.PanelMaster.ResumeLayout(False)
        Me.PanelMaster.PerformLayout()
        Me.PanelTransaction.ResumeLayout(False)
        Me.PanelTransaction.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnMasterRoomType As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents LbRole As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LbName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnLogout As Button
    Friend WithEvents PanelMaster As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnMinimize As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents LbMaster As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnMaster As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LbTransaction As Label
    Friend WithEvents BtnTransaction As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnMasterItem As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnMasterRoom As Button
    Friend WithEvents PanelTransaction As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnAddItem As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnCheckout As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnCheckin As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnReservation As Button
End Class

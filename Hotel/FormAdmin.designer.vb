<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LbRole = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LbName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnMaster = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnMasterEmployee = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.LbRole)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.LbName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnMaster)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 600)
        Me.Panel1.TabIndex = 0
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
        Me.LbRole.Size = New System.Drawing.Size(44, 16)
        Me.LbRole.TabIndex = 7
        Me.LbRole.Text = "Admin"
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(5, 40)
        Me.Label1.TabIndex = 1
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(250, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(750, 40)
        Me.Panel2.TabIndex = 1
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(54, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data Karyawan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.BtnMasterEmployee)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(250, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(750, 560)
        Me.Panel3.TabIndex = 2
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
        'BtnMasterEmployee
        '
        Me.BtnMasterEmployee.BackColor = System.Drawing.Color.Silver
        Me.BtnMasterEmployee.FlatAppearance.BorderSize = 0
        Me.BtnMasterEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMasterEmployee.Image = Global.Hotel.My.Resources.Resources.people
        Me.BtnMasterEmployee.Location = New System.Drawing.Point(54, 66)
        Me.BtnMasterEmployee.Name = "BtnMasterEmployee"
        Me.BtnMasterEmployee.Size = New System.Drawing.Size(200, 200)
        Me.BtnMasterEmployee.TabIndex = 0
        Me.BtnMasterEmployee.UseVisualStyleBackColor = False
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
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnMinimize As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnMaster As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LbRole As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LbName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnMasterEmployee As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
End Class

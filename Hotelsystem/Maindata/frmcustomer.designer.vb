<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcustomer))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnsave = New System.Windows.Forms.ToolStripButton()
        Me.btndelete = New System.Windows.Forms.ToolStripButton()
        Me.btnupdate = New System.Windows.Forms.ToolStripButton()
        Me.btnedit = New System.Windows.Forms.ToolStripButton()
        Me.btnnew = New System.Windows.Forms.ToolStripButton()
        Me.btnclose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonX5 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.btnAddProvince = New DevComponents.DotNetBar.ButtonX()
        Me.cbprovince = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbdistrict = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.chkActivate = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbcustomertype = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbRoomrate = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbtitlename = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbvillage = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtNationality = New System.Windows.Forms.TextBox()
        Me.txtIdcard = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtPassport = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.dgvcustomer = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.miniToolStrip = New System.Windows.Forms.ToolStrip()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvcustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvcustomer, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 251.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1346, 732)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(10, 10)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnsave, Me.btndelete, Me.btnupdate, Me.btnedit, Me.btnnew, Me.btnclose, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1346, 55)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.Hotelsystem.My.Resources.Resources.Save
        Me.btnsave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnsave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsave.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(90, 55)
        Me.btnsave.Text = "ບັນທືກ"
        '
        'btndelete
        '
        Me.btndelete.Image = Global.Hotelsystem.My.Resources.Resources.Delete
        Me.btndelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndelete.Margin = New System.Windows.Forms.Padding(10, 1, 10, 2)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(69, 52)
        Me.btndelete.Text = "ລືບ"
        '
        'btnupdate
        '
        Me.btnupdate.Image = Global.Hotelsystem.My.Resources.Resources.Refresh
        Me.btnupdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnupdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(10, 1, 10, 2)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(87, 52)
        Me.btnupdate.Text = "ປັບປຸງ"
        '
        'btnedit
        '
        Me.btnedit.Image = Global.Hotelsystem.My.Resources.Resources.Edit_page
        Me.btnedit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnedit.Margin = New System.Windows.Forms.Padding(10, 1, 10, 2)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(87, 52)
        Me.btnedit.Text = "ແກ້ໄຂ"
        '
        'btnnew
        '
        Me.btnnew.Image = Global.Hotelsystem.My.Resources.Resources.New_file
        Me.btnnew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnew.Margin = New System.Windows.Forms.Padding(10, 1, 10, 2)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(105, 52)
        Me.btnnew.Text = "ເພີ້ມໃຫ່ມ"
        '
        'btnclose
        '
        Me.btnclose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnclose.Image = Global.Hotelsystem.My.Resources.Resources._1489493744_exit
        Me.btnclose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(69, 52)
        Me.btnclose.Text = "ປິດ"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonX5)
        Me.Panel1.Controls.Add(Me.ButtonX2)
        Me.Panel1.Controls.Add(Me.ButtonX4)
        Me.Panel1.Controls.Add(Me.ButtonX3)
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.btnAddProvince)
        Me.Panel1.Controls.Add(Me.cbprovince)
        Me.Panel1.Controls.Add(Me.cbdistrict)
        Me.Panel1.Controls.Add(Me.chkActivate)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cbcustomertype)
        Me.Panel1.Controls.Add(Me.cbRoomrate)
        Me.Panel1.Controls.Add(Me.cbtitlename)
        Me.Panel1.Controls.Add(Me.cbvillage)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtFax)
        Me.Panel1.Controls.Add(Me.txtTel)
        Me.Panel1.Controls.Add(Me.txtNationality)
        Me.Panel1.Controls.Add(Me.txtIdcard)
        Me.Panel1.Controls.Add(Me.txtid)
        Me.Panel1.Controls.Add(Me.txtPassport)
        Me.Panel1.Controls.Add(Me.txtSurname)
        Me.Panel1.Controls.Add(Me.txtCustomerName)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtCustomerID)
        Me.Panel1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 59)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1340, 243)
        Me.Panel1.TabIndex = 3
        '
        'ButtonX5
        '
        Me.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX5.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX5.ForeColor = System.Drawing.Color.Blue
        Me.ButtonX5.Image = CType(resources.GetObject("ButtonX5.Image"), System.Drawing.Image)
        Me.ButtonX5.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.ButtonX5.Location = New System.Drawing.Point(1120, 117)
        Me.ButtonX5.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonX5.Name = "ButtonX5"
        Me.ButtonX5.Size = New System.Drawing.Size(101, 35)
        Me.ButtonX5.TabIndex = 28
        Me.ButtonX5.Text = "ເພີມແຂວງ"
        Me.ButtonX5.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.ForeColor = System.Drawing.Color.Blue
        Me.ButtonX2.Image = CType(resources.GetObject("ButtonX2.Image"), System.Drawing.Image)
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.ButtonX2.Location = New System.Drawing.Point(1182, 12)
        Me.ButtonX2.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(131, 35)
        Me.ButtonX2.TabIndex = 28
        Me.ButtonX2.Text = "ເພີມລາຄາຫ້ອງ"
        Me.ButtonX2.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX4.ForeColor = System.Drawing.Color.Blue
        Me.ButtonX4.Image = CType(resources.GetObject("ButtonX4.Image"), System.Drawing.Image)
        Me.ButtonX4.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.ButtonX4.Location = New System.Drawing.Point(999, 117)
        Me.ButtonX4.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(101, 35)
        Me.ButtonX4.TabIndex = 28
        Me.ButtonX4.Text = "ເພີມເມືອງ"
        Me.ButtonX4.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX3.ForeColor = System.Drawing.Color.Blue
        Me.ButtonX3.Image = CType(resources.GetObject("ButtonX3.Image"), System.Drawing.Image)
        Me.ButtonX3.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.ButtonX3.Location = New System.Drawing.Point(999, 65)
        Me.ButtonX3.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(129, 35)
        Me.ButtonX3.TabIndex = 28
        Me.ButtonX3.Text = "ເພີມຄຳນຳໜ້າ"
        Me.ButtonX3.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.ForeColor = System.Drawing.Color.Blue
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.ButtonX1.Location = New System.Drawing.Point(1148, 65)
        Me.ButtonX1.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(101, 35)
        Me.ButtonX1.TabIndex = 28
        Me.ButtonX1.Text = "ເພີມບ້ານ"
        Me.ButtonX1.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnAddProvince
        '
        Me.btnAddProvince.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAddProvince.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAddProvince.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProvince.ForeColor = System.Drawing.Color.Blue
        Me.btnAddProvince.Image = CType(resources.GetObject("btnAddProvince.Image"), System.Drawing.Image)
        Me.btnAddProvince.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnAddProvince.Location = New System.Drawing.Point(997, 12)
        Me.btnAddProvince.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddProvince.Name = "btnAddProvince"
        Me.btnAddProvince.Size = New System.Drawing.Size(157, 35)
        Me.btnAddProvince.TabIndex = 28
        Me.btnAddProvince.Text = "ເພີມປະເພດລູກຄ້າ"
        Me.btnAddProvince.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'cbprovince
        '
        Me.cbprovince.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbprovince.DisplayMember = "Text"
        Me.cbprovince.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbprovince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbprovince.FormattingEnabled = True
        Me.cbprovince.ItemHeight = 29
        Me.cbprovince.Location = New System.Drawing.Point(412, 82)
        Me.cbprovince.Name = "cbprovince"
        Me.cbprovince.Size = New System.Drawing.Size(217, 35)
        Me.cbprovince.TabIndex = 27
        '
        'cbdistrict
        '
        Me.cbdistrict.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbdistrict.DisplayMember = "Text"
        Me.cbdistrict.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbdistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbdistrict.FormattingEnabled = True
        Me.cbdistrict.ItemHeight = 29
        Me.cbdistrict.Location = New System.Drawing.Point(413, 123)
        Me.cbdistrict.Name = "cbdistrict"
        Me.cbdistrict.Size = New System.Drawing.Size(217, 35)
        Me.cbdistrict.TabIndex = 26
        '
        'chkActivate
        '
        Me.chkActivate.AutoSize = True
        Me.chkActivate.Location = New System.Drawing.Point(757, 199)
        Me.chkActivate.Name = "chkActivate"
        Me.chkActivate.Size = New System.Drawing.Size(76, 33)
        Me.chkActivate.TabIndex = 25
        Me.chkActivate.Text = "ໃຊ້ງານ"
        Me.chkActivate.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(704, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 29)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "ແຟ໋ກ:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 29)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "ລາຄາຫ້ອງ:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(363, 164)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 29)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "ບ້ານ:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(361, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 29)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "ເມືອງ:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(356, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 29)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "ແຂວງ:"
        '
        'cbcustomertype
        '
        Me.cbcustomertype.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbcustomertype.DisplayMember = "Text"
        Me.cbcustomertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbcustomertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcustomertype.FormattingEnabled = True
        Me.cbcustomertype.ItemHeight = 29
        Me.cbcustomertype.Location = New System.Drawing.Point(105, 46)
        Me.cbcustomertype.Name = "cbcustomertype"
        Me.cbcustomertype.Size = New System.Drawing.Size(217, 35)
        Me.cbcustomertype.TabIndex = 23
        '
        'cbRoomrate
        '
        Me.cbRoomrate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRoomrate.DisplayMember = "Text"
        Me.cbRoomrate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbRoomrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRoomrate.FormattingEnabled = True
        Me.cbRoomrate.ItemHeight = 29
        Me.cbRoomrate.Location = New System.Drawing.Point(105, 83)
        Me.cbRoomrate.Name = "cbRoomrate"
        Me.cbRoomrate.Size = New System.Drawing.Size(217, 35)
        Me.cbRoomrate.TabIndex = 23
        '
        'cbtitlename
        '
        Me.cbtitlename.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbtitlename.DisplayMember = "Text"
        Me.cbtitlename.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbtitlename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtitlename.FormattingEnabled = True
        Me.cbtitlename.ItemHeight = 29
        Me.cbtitlename.Location = New System.Drawing.Point(105, 120)
        Me.cbtitlename.Name = "cbtitlename"
        Me.cbtitlename.Size = New System.Drawing.Size(217, 35)
        Me.cbtitlename.TabIndex = 23
        '
        'cbvillage
        '
        Me.cbvillage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbvillage.DisplayMember = "Text"
        Me.cbvillage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbvillage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbvillage.FormattingEnabled = True
        Me.cbvillage.ItemHeight = 29
        Me.cbvillage.Location = New System.Drawing.Point(414, 161)
        Me.cbvillage.Name = "cbvillage"
        Me.cbvillage.Size = New System.Drawing.Size(216, 35)
        Me.cbvillage.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(634, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 29)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "ເລກບັດປະຈຳຕົວ:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(325, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 29)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "ນາມສະກຸນ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ລະຫັດລູກຄ້າ:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(709, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 29)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ໂທ:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(344, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 29)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ຊັ້ນຊາດ:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(698, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 29)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "ອີເມວ:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ຄຳນຳໜ້າ:"
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(757, 117)
        Me.txtFax.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(217, 35)
        Me.txtFax.TabIndex = 3
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(757, 79)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(217, 35)
        Me.txtTel.TabIndex = 3
        '
        'txtNationality
        '
        Me.txtNationality.Location = New System.Drawing.Point(412, 44)
        Me.txtNationality.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Size = New System.Drawing.Size(217, 35)
        Me.txtNationality.TabIndex = 3
        '
        'txtIdcard
        '
        Me.txtIdcard.Location = New System.Drawing.Point(757, 42)
        Me.txtIdcard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdcard.Name = "txtIdcard"
        Me.txtIdcard.Size = New System.Drawing.Size(217, 35)
        Me.txtIdcard.TabIndex = 3
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(105, 204)
        Me.txtid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(93, 35)
        Me.txtid.TabIndex = 3
        Me.txtid.Visible = False
        '
        'txtPassport
        '
        Me.txtPassport.Location = New System.Drawing.Point(757, 5)
        Me.txtPassport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassport.Name = "txtPassport"
        Me.txtPassport.Size = New System.Drawing.Size(217, 35)
        Me.txtPassport.TabIndex = 3
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(413, 5)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(217, 35)
        Me.txtSurname.TabIndex = 3
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(105, 158)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(217, 35)
        Me.txtCustomerName.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(757, 157)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(217, 35)
        Me.txtEmail.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(671, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ພາສປອດ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ຊື່ລູກຄ້າ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ປະເພດລູກຄ້າ:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(105, 8)
        Me.txtCustomerID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(217, 35)
        Me.txtCustomerID.TabIndex = 1
        '
        'dgvcustomer
        '
        Me.dgvcustomer.AllowUserToAddRows = False
        Me.dgvcustomer.AllowUserToDeleteRows = False
        Me.dgvcustomer.AllowUserToResizeColumns = False
        Me.dgvcustomer.AllowUserToResizeRows = False
        Me.dgvcustomer.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvcustomer.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcustomer.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvcustomer.Location = New System.Drawing.Point(3, 310)
        Me.dgvcustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvcustomer.Name = "dgvcustomer"
        Me.dgvcustomer.ReadOnly = True
        Me.dgvcustomer.RowHeadersVisible = False
        Me.dgvcustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvcustomer.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcustomer.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvcustomer.RowTemplate.Height = 28
        Me.dgvcustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcustomer.Size = New System.Drawing.Size(1340, 343)
        Me.dgvcustomer.TabIndex = 4
        '
        'miniToolStrip
        '
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.BackColor = System.Drawing.Color.Transparent
        Me.miniToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.miniToolStrip.CanOverflow = False
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.miniToolStrip.ImageScalingSize = New System.Drawing.Size(10, 10)
        Me.miniToolStrip.Location = New System.Drawing.Point(773, 18)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.miniToolStrip.Size = New System.Drawing.Size(1002, 55)
        Me.miniToolStrip.TabIndex = 2
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1352, 763)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "ເພີ້ມລູກຄ້າ"
        '
        'frmcustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1352, 763)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmcustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvcustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnsave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btndelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnupdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnedit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnnew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnclose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbvillage As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtNationality As System.Windows.Forms.TextBox
    Friend WithEvents txtIdcard As System.Windows.Forms.TextBox
    Friend WithEvents txtPassport As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents dgvcustomer As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents miniToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents chkActivate As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbRoomrate As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents cbtitlename As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbcustomertype As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbprovince As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbdistrict As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents ButtonX5 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAddProvince As DevComponents.DotNetBar.ButtonX
End Class

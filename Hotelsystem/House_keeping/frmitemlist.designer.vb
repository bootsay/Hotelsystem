<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmitemlist
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtqty = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnnew = New DevComponents.DotNetBar.ButtonX()
        Me.btnsave = New DevComponents.DotNetBar.ButtonX()
        Me.btnedit = New DevComponents.DotNetBar.ButtonX()
        Me.btnupdate = New DevComponents.DotNetBar.ButtonX()
        Me.btndelete = New DevComponents.DotNetBar.ButtonX()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdateadd = New System.Windows.Forms.DateTimePicker()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtproductname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbrown2 = New DevComponents.DotNetBar.ButtonX()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtroomno = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtproid = New System.Windows.Forms.TextBox()
        Me.txtroomid = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvproduct = New System.Windows.Forms.DataGridView()
        Me.dgvlist = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1354, 608)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtqty)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.txtdateadd)
        Me.Panel1.Controls.Add(Me.txtprice)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtuser)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtproductname)
        Me.Panel1.Controls.Add(Me.txtid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnbrown2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtroomno)
        Me.Panel1.Controls.Add(Me.txtproid)
        Me.Panel1.Controls.Add(Me.txtroomid)
        Me.Panel1.Controls.Add(Me.txtuserid)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1348, 118)
        Me.Panel1.TabIndex = 1
        '
        'txtqty
        '
        Me.txtqty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtqty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txtqty.Border.Class = "TextBoxBorder"
        Me.txtqty.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtqty.Location = New System.Drawing.Point(403, 80)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(474, 35)
        Me.txtqty.TabIndex = 49
        Me.txtqty.WatermarkText = "ກະລຸນາປ້ອນຈໍານວນສິນຄ້າທີ່ສັ່ງ"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnnew)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnsave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnedit)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnupdate)
        Me.FlowLayoutPanel1.Controls.Add(Me.btndelete)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(883, 9)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(462, 104)
        Me.FlowLayoutPanel1.TabIndex = 47
        '
        'btnnew
        '
        Me.btnnew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnnew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnnew.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnnew.Image = Global.HotelSystem.My.Resources.Resources.add2
        Me.btnnew.Location = New System.Drawing.Point(3, 3)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(110, 45)
        Me.btnnew.TabIndex = 14
        Me.btnnew.Text = "ສ້າງໄຫມ່"
        '
        'btnsave
        '
        Me.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsave.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnsave.Image = Global.Hotelsystem.My.Resources.Resources.Save_icon
        Me.btnsave.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnsave.Location = New System.Drawing.Point(119, 3)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(90, 45)
        Me.btnsave.TabIndex = 15
        Me.btnsave.Text = "ບັນທືກ"
        '
        'btnedit
        '
        Me.btnedit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnedit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnedit.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnedit.Image = Global.Hotelsystem.My.Resources.Resources.Add_product
        Me.btnedit.Location = New System.Drawing.Point(215, 3)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(88, 45)
        Me.btnedit.TabIndex = 16
        Me.btnedit.Text = "ແກ້ໄຂ"
        '
        'btnupdate
        '
        Me.btnupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnupdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnupdate.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnupdate.Image = Global.Hotelsystem.My.Resources.Resources._1472720664_document_open
        Me.btnupdate.Location = New System.Drawing.Point(309, 3)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(92, 45)
        Me.btnupdate.TabIndex = 17
        Me.btnupdate.Text = "ປັບປຸງ"
        '
        'btndelete
        '
        Me.btndelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btndelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btndelete.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btndelete.Image = Global.Hotelsystem.My.Resources.Resources.Delete
        Me.btndelete.Location = New System.Drawing.Point(407, 3)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(46, 45)
        Me.btndelete.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtsearch)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(3, 54)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(459, 52)
        Me.Panel4.TabIndex = 18
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.Location = New System.Drawing.Point(64, 12)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(395, 35)
        Me.txtsearch.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 29)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "ຊື່ສິນຄ້າ:"
        '
        'txtdateadd
        '
        Me.txtdateadd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdateadd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdateadd.Location = New System.Drawing.Point(677, 2)
        Me.txtdateadd.Name = "txtdateadd"
        Me.txtdateadd.Size = New System.Drawing.Size(200, 35)
        Me.txtdateadd.TabIndex = 44
        '
        'txtprice
        '
        Me.txtprice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtprice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtprice.Enabled = False
        Me.txtprice.Location = New System.Drawing.Point(403, 42)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(474, 35)
        Me.txtprice.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(338, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 29)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "ລາຄາ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 29)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "ຊື່ຫ້ອງ:"
        '
        'txtuser
        '
        Me.txtuser.Enabled = False
        Me.txtuser.Location = New System.Drawing.Point(85, 81)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(247, 35)
        Me.txtuser.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 29)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "ຜູ້ອອກບີນ:"
        '
        'txtproductname
        '
        Me.txtproductname.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txtproductname.Border.Class = "TextBoxBorder"
        Me.txtproductname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtproductname.Enabled = False
        Me.txtproductname.Location = New System.Drawing.Point(403, 3)
        Me.txtproductname.Name = "txtproductname"
        Me.txtproductname.ReadOnly = True
        Me.txtproductname.Size = New System.Drawing.Size(227, 35)
        Me.txtproductname.TabIndex = 18
        Me.txtproductname.WatermarkText = "ກະລຸນາເລືອກລາຍການສິນຄ້າ"
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Location = New System.Drawing.Point(85, 3)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(248, 35)
        Me.txtid.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ລະຫັດ:"
        '
        'btnbrown2
        '
        Me.btnbrown2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnbrown2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnbrown2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnbrown2.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnbrown2.Location = New System.Drawing.Point(279, 42)
        Me.btnbrown2.Name = "btnbrown2"
        Me.btnbrown2.Size = New System.Drawing.Size(54, 35)
        Me.btnbrown2.TabIndex = 15
        Me.btnbrown2.Text = "ເລືອກ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(632, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 29)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "ວັນທີ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(339, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 29)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "ຊື່ສິນຄ້າ:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(338, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 29)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "ຈໍານວນ:"
        '
        'txtroomno
        '
        Me.txtroomno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txtroomno.Border.Class = "TextBoxBorder"
        Me.txtroomno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtroomno.Location = New System.Drawing.Point(85, 42)
        Me.txtroomno.Name = "txtroomno"
        Me.txtroomno.ReadOnly = True
        Me.txtroomno.Size = New System.Drawing.Size(188, 35)
        Me.txtroomno.TabIndex = 14
        Me.txtroomno.WatermarkText = "ກະລຸນາເລືອກຫ້ອງລູກຄ້າ"
        '
        'txtproid
        '
        Me.txtproid.Enabled = False
        Me.txtproid.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtproid.Location = New System.Drawing.Point(533, 46)
        Me.txtproid.Name = "txtproid"
        Me.txtproid.Size = New System.Drawing.Size(93, 27)
        Me.txtproid.TabIndex = 51
        '
        'txtroomid
        '
        Me.txtroomid.Enabled = False
        Me.txtroomid.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtroomid.Location = New System.Drawing.Point(167, 46)
        Me.txtroomid.Name = "txtroomid"
        Me.txtroomid.Size = New System.Drawing.Size(93, 27)
        Me.txtroomid.TabIndex = 50
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.63706!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.36293!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgvlist, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 127)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1348, 478)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.dgvproduct)
        Me.Panel2.Location = New System.Drawing.Point(887, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(458, 472)
        Me.Panel2.TabIndex = 49
        '
        'dgvproduct
        '
        Me.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvproduct.Location = New System.Drawing.Point(0, 0)
        Me.dgvproduct.Name = "dgvproduct"
        Me.dgvproduct.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvproduct.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvproduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvproduct.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvproduct.RowTemplate.Height = 30
        Me.dgvproduct.Size = New System.Drawing.Size(458, 472)
        Me.dgvproduct.TabIndex = 1
        '
        'dgvlist
        '
        Me.dgvlist.AllowDrop = True
        Me.dgvlist.AllowUserToAddRows = False
        Me.dgvlist.AllowUserToDeleteRows = False
        Me.dgvlist.AllowUserToResizeColumns = False
        Me.dgvlist.AllowUserToResizeRows = False
        Me.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlist.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvlist.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvlist.Location = New System.Drawing.Point(3, 3)
        Me.dgvlist.Name = "dgvlist"
        Me.dgvlist.ReadOnly = True
        Me.dgvlist.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvlist.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvlist.RowTemplate.Height = 30
        Me.dgvlist.Size = New System.Drawing.Size(878, 472)
        Me.dgvlist.TabIndex = 1
        '
        'txtuserid
        '
        Me.txtuserid.Enabled = False
        Me.txtuserid.Font = New System.Drawing.Font("Saysettha OT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtuserid.Location = New System.Drawing.Point(203, 85)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(93, 27)
        Me.txtuserid.TabIndex = 52
        '
        'frmitemlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1354, 608)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MinimizeBox = False
        Me.Name = "frmitemlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ຂໍ້ມູນລາຍລະອຽດລາຍການລູກຄ້າສັ່ງອາຫານ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvproduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtroomno As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnbrown2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtproductname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdateadd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnnew As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnsave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnedit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnupdate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvlist As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtqty As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtroomid As System.Windows.Forms.TextBox
    Friend WithEvents txtproid As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvproduct As System.Windows.Forms.DataGridView
    Friend WithEvents btndelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtuserid As System.Windows.Forms.TextBox
End Class

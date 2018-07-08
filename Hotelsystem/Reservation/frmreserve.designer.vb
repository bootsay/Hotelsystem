<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreserve
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnprint = New DevComponents.DotNetBar.ButtonX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btncancel = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnnew = New DevComponents.DotNetBar.ButtonX()
        Me.btnsave = New DevComponents.DotNetBar.ButtonX()
        Me.btnedit = New DevComponents.DotNetBar.ButtonX()
        Me.btnupdate = New DevComponents.DotNetBar.ButtonX()
        Me.txtnumberpeople = New System.Windows.Forms.TextBox()
        Me.txtdatereserve = New System.Windows.Forms.DateTimePicker()
        Me.btnroom = New DevComponents.DotNetBar.ButtonX()
        Me.txtroomno = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnbrown2 = New DevComponents.DotNetBar.ButtonX()
        Me.txtdatecheckout = New System.Windows.Forms.DateTimePicker()
        Me.btncus = New DevComponents.DotNetBar.ButtonX()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvlist = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtuserid = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtdatecheckin = New System.Windows.Forms.DateTimePicker()
        Me.txtcustomername = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnbrown1 = New DevComponents.DotNetBar.ButtonX()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtroomid = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtcustomerid = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel2.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnprint
        '
        Me.btnprint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnprint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnprint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.btnprint.Location = New System.Drawing.Point(3, 4)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(171, 46)
        Me.btnprint.TabIndex = 18
        Me.btnprint.Text = "ພິມບີນ"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.btnprint)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 605)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 54)
        Me.Panel2.TabIndex = 2
        '
        'btncancel
        '
        Me.btncancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncancel.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btncancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.btncancel.Location = New System.Drawing.Point(180, 3)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(121, 47)
        Me.btncancel.TabIndex = 19
        Me.btncancel.Text = "ຍົກເລີກ"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(1098, 155)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(95, 35)
        Me.ButtonX1.TabIndex = 42
        Me.ButtonX1.Text = "ຄົ້ນຫາ"
        Me.ButtonX1.TextColor = System.Drawing.Color.Brown
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsearch.Location = New System.Drawing.Point(82, 155)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(1010, 35)
        Me.txtsearch.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 29)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "ຄົ້ນຫາ:"
        '
        'txtprice
        '
        Me.txtprice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtprice.ForeColor = System.Drawing.Color.Blue
        Me.txtprice.Location = New System.Drawing.Point(336, 42)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(272, 35)
        Me.txtprice.TabIndex = 6
        '
        'GroupPanel3
        '
        Me.GroupPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupPanel3.Location = New System.Drawing.Point(928, 5)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(265, 109)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 34
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnnew)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnsave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnedit)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnupdate)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(259, 103)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnnew
        '
        Me.btnnew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnnew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnnew.Location = New System.Drawing.Point(3, 3)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(103, 45)
        Me.btnnew.TabIndex = 14
        Me.btnnew.Text = "ສ້າງໄຫມ່"
        '
        'btnsave
        '
        Me.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsave.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnsave.Location = New System.Drawing.Point(112, 3)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(95, 45)
        Me.btnsave.TabIndex = 15
        Me.btnsave.Text = "ບັນທືກ"
        '
        'btnedit
        '
        Me.btnedit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnedit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnedit.Location = New System.Drawing.Point(3, 54)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(103, 45)
        Me.btnedit.TabIndex = 16
        Me.btnedit.Text = "ແກ້ໄຂ"
        '
        'btnupdate
        '
        Me.btnupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnupdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnupdate.Location = New System.Drawing.Point(112, 54)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(95, 45)
        Me.btnupdate.TabIndex = 17
        Me.btnupdate.Text = "ປັບປຸງ"
        '
        'txtnumberpeople
        '
        Me.txtnumberpeople.Location = New System.Drawing.Point(336, 80)
        Me.txtnumberpeople.Name = "txtnumberpeople"
        Me.txtnumberpeople.Size = New System.Drawing.Size(272, 35)
        Me.txtnumberpeople.TabIndex = 7
        '
        'txtdatereserve
        '
        Me.txtdatereserve.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdatereserve.Location = New System.Drawing.Point(82, 79)
        Me.txtdatereserve.Name = "txtdatereserve"
        Me.txtdatereserve.Size = New System.Drawing.Size(163, 35)
        Me.txtdatereserve.TabIndex = 2
        '
        'btnroom
        '
        Me.btnroom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnroom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnroom.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnroom.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnroom.Location = New System.Drawing.Point(868, 3)
        Me.btnroom.Name = "btnroom"
        Me.btnroom.Size = New System.Drawing.Size(54, 35)
        Me.btnroom.TabIndex = 10
        Me.btnroom.Text = "ໄໝ່"
        Me.btnroom.TextColor = System.Drawing.Color.Maroon
        '
        'txtroomno
        '
        Me.txtroomno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txtroomno.Border.Class = "TextBoxBorder"
        Me.txtroomno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtroomno.Location = New System.Drawing.Point(616, 3)
        Me.txtroomno.Name = "txtroomno"
        Me.txtroomno.ReadOnly = True
        Me.txtroomno.Size = New System.Drawing.Size(190, 35)
        Me.txtroomno.TabIndex = 8
        Me.txtroomno.WatermarkText = "ກະລຸນາເລືອກຫ້ອງໃຫ້ລູກຄ້າ"
        '
        'btnbrown2
        '
        Me.btnbrown2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnbrown2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnbrown2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnbrown2.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnbrown2.Location = New System.Drawing.Point(810, 3)
        Me.btnbrown2.Name = "btnbrown2"
        Me.btnbrown2.Size = New System.Drawing.Size(54, 35)
        Me.btnbrown2.TabIndex = 9
        Me.btnbrown2.Text = "ເລືອກ"
        '
        'txtdatecheckout
        '
        Me.txtdatecheckout.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdatecheckout.Location = New System.Drawing.Point(687, 79)
        Me.txtdatecheckout.Name = "txtdatecheckout"
        Me.txtdatecheckout.Size = New System.Drawing.Size(235, 35)
        Me.txtdatecheckout.TabIndex = 12
        '
        'btncus
        '
        Me.btncus.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncus.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncus.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btncus.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btncus.Location = New System.Drawing.Point(554, 4)
        Me.btncus.Name = "btncus"
        Me.btncus.Size = New System.Drawing.Size(54, 35)
        Me.btncus.TabIndex = 5
        Me.btncus.Text = "ໄໝ່"
        Me.btncus.TextColor = System.Drawing.Color.Maroon
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvlist, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1206, 662)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'dgvlist
        '
        Me.dgvlist.AllowDrop = True
        Me.dgvlist.AllowUserToAddRows = False
        Me.dgvlist.AllowUserToDeleteRows = False
        Me.dgvlist.AllowUserToResizeColumns = False
        Me.dgvlist.AllowUserToResizeRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlist.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvlist.EnableHeadersVisualStyles = False
        Me.dgvlist.GridColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgvlist.Location = New System.Drawing.Point(3, 207)
        Me.dgvlist.Name = "dgvlist"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlist.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvlist.RowHeadersVisible = False
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvlist.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvlist.RowTemplate.Height = 28
        Me.dgvlist.Size = New System.Drawing.Size(1200, 392)
        Me.dgvlist.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtprice)
        Me.Panel1.Controls.Add(Me.GroupPanel3)
        Me.Panel1.Controls.Add(Me.txtnumberpeople)
        Me.Panel1.Controls.Add(Me.txtdatereserve)
        Me.Panel1.Controls.Add(Me.btnroom)
        Me.Panel1.Controls.Add(Me.txtroomno)
        Me.Panel1.Controls.Add(Me.btnbrown2)
        Me.Panel1.Controls.Add(Me.txtdatecheckout)
        Me.Panel1.Controls.Add(Me.btncus)
        Me.Panel1.Controls.Add(Me.txtuser)
        Me.Panel1.Controls.Add(Me.txtdatecheckin)
        Me.Panel1.Controls.Add(Me.txtcustomername)
        Me.Panel1.Controls.Add(Me.btnbrown1)
        Me.Panel1.Controls.Add(Me.txtNote)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtroomid)
        Me.Panel1.Controls.Add(Me.txtcustomerid)
        Me.Panel1.Controls.Add(Me.txtuserid)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 198)
        Me.Panel1.TabIndex = 1
        '
        'txtuserid
        '
        Me.txtuserid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txtuserid.Border.Class = "TextBoxBorder"
        Me.txtuserid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtuserid.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtuserid.Location = New System.Drawing.Point(174, 44)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.ReadOnly = True
        Me.txtuserid.Size = New System.Drawing.Size(65, 30)
        Me.txtuserid.TabIndex = 43
        Me.txtuserid.WatermarkText = "ເລືອກລູກຄ້າ"
        '
        'txtuser
        '
        Me.txtuser.Enabled = False
        Me.txtuser.Location = New System.Drawing.Point(82, 41)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(163, 35)
        Me.txtuser.TabIndex = 1
        '
        'txtdatecheckin
        '
        Me.txtdatecheckin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdatecheckin.Location = New System.Drawing.Point(687, 41)
        Me.txtdatecheckin.Name = "txtdatecheckin"
        Me.txtdatecheckin.Size = New System.Drawing.Size(235, 35)
        Me.txtdatecheckin.TabIndex = 11
        '
        'txtcustomername
        '
        Me.txtcustomername.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txtcustomername.Border.Class = "TextBoxBorder"
        Me.txtcustomername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcustomername.Location = New System.Drawing.Point(337, 4)
        Me.txtcustomername.Name = "txtcustomername"
        Me.txtcustomername.ReadOnly = True
        Me.txtcustomername.Size = New System.Drawing.Size(153, 35)
        Me.txtcustomername.TabIndex = 3
        Me.txtcustomername.WatermarkText = "ກະລຸນາເລືອກລູກຄ້າ"
        '
        'btnbrown1
        '
        Me.btnbrown1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnbrown1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnbrown1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnbrown1.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnbrown1.Location = New System.Drawing.Point(496, 4)
        Me.btnbrown1.Name = "btnbrown1"
        Me.btnbrown1.Size = New System.Drawing.Size(54, 35)
        Me.btnbrown1.TabIndex = 4
        Me.btnbrown1.Text = "ເລືອກ"
        '
        'txtNote
        '
        Me.txtNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNote.Location = New System.Drawing.Point(82, 117)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(1111, 35)
        Me.txtNote.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ຜູ້ອອກບີນ:"
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Location = New System.Drawing.Point(82, 3)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(163, 35)
        Me.txtid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ລະຫັດ:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(613, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 29)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "ວັນທີເຂົ້າ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(607, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 29)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "ວັນທີອອກ:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 29)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "ວັນທີຈອງ:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(246, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 29)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "ຈໍານວນຄົນ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 29)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "ໜາຍເຫດ:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(281, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 29)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "ລາຄາ:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(280, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 29)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "ລູກຄ້າ:"
        '
        'txtroomid
        '
        Me.txtroomid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txtroomid.Border.Class = "TextBoxBorder"
        Me.txtroomid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtroomid.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtroomid.Location = New System.Drawing.Point(693, 5)
        Me.txtroomid.Name = "txtroomid"
        Me.txtroomid.ReadOnly = True
        Me.txtroomid.Size = New System.Drawing.Size(101, 30)
        Me.txtroomid.TabIndex = 39
        Me.txtroomid.WatermarkText = "ເລືອກຫ້ອງ"
        '
        'txtcustomerid
        '
        Me.txtcustomerid.AcceptsReturn = True
        Me.txtcustomerid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txtcustomerid.Border.Class = "TextBoxBorder"
        Me.txtcustomerid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcustomerid.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtcustomerid.Location = New System.Drawing.Point(410, 7)
        Me.txtcustomerid.Name = "txtcustomerid"
        Me.txtcustomerid.ReadOnly = True
        Me.txtcustomerid.Size = New System.Drawing.Size(74, 30)
        Me.txtcustomerid.TabIndex = 38
        Me.txtcustomerid.WatermarkText = "ເລືອກລູກຄ້າ"
        '
        'frmreserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 662)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Name = "frmreserve"
        Me.Text = "ຈອງຫ້ອງພັກ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnprint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btncancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnnew As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnsave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnedit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnupdate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtnumberpeople As System.Windows.Forms.TextBox
    Friend WithEvents txtdatereserve As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnroom As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtroomno As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnbrown2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtdatecheckout As System.Windows.Forms.DateTimePicker
    Friend WithEvents btncus As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvlist As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtdatecheckin As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcustomername As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnbrown1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtroomid As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtcustomerid As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtuserid As DevComponents.DotNetBar.Controls.TextBoxX
End Class

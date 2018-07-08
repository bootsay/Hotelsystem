<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmroomtype
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmroomtype))
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnsave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btndelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnedit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnupdate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnnew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtroomtype = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdes = New System.Windows.Forms.TextBox()
        Me.txtextrabed = New System.Windows.Forms.TextBox()
        Me.txtmaxperson = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvshow = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvshow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(726, 582)
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
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvshow, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(720, 576)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(5)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnsave, Me.ToolStripSeparator1, Me.btndelete, Me.ToolStripSeparator2, Me.btnedit, Me.ToolStripSeparator3, Me.btnupdate, Me.ToolStripSeparator4, Me.btnnew, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(3)
        Me.ToolStrip1.Size = New System.Drawing.Size(720, 45)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnsave
        '
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Image = Global.Hotelsystem.My.Resources.Resources.Save
        Me.btnsave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnsave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsave.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(90, 36)
        Me.btnsave.Text = "ບັນທືກ"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btndelete
        '
        Me.btndelete.ForeColor = System.Drawing.Color.Black
        Me.btndelete.Image = Global.Hotelsystem.My.Resources.Resources.Delete
        Me.btndelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(69, 36)
        Me.btndelete.Text = "ລືບ"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnedit
        '
        Me.btnedit.ForeColor = System.Drawing.Color.Black
        Me.btnedit.Image = Global.Hotelsystem.My.Resources.Resources.Edit_page
        Me.btnedit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(87, 36)
        Me.btnedit.Text = "ແກ້ໄຂ"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'btnupdate
        '
        Me.btnupdate.Image = Global.Hotelsystem.My.Resources.Resources.Refresh
        Me.btnupdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnupdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(87, 36)
        Me.btnupdate.Text = "ປັບປຸງ"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'btnnew
        '
        Me.btnnew.ForeColor = System.Drawing.Color.Black
        Me.btnnew.Image = Global.Hotelsystem.My.Resources.Resources.New_file
        Me.btnnew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(105, 36)
        Me.btnnew.Text = "ເພີ້ມໃຫ່ມ"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Hotelsystem.My.Resources.Resources._1489493744_exit
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtroomtype)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtdes)
        Me.Panel1.Controls.Add(Me.txtextrabed)
        Me.Panel1.Controls.Add(Me.txtmaxperson)
        Me.Panel1.Controls.Add(Me.txtid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(4, 49)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 200)
        Me.Panel1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 83)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 27)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ລາຄາຕຽງພິເສດ:"
        '
        'txtroomtype
        '
        Me.txtroomtype.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtroomtype.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtroomtype.Location = New System.Drawing.Point(137, 44)
        Me.txtroomtype.Margin = New System.Windows.Forms.Padding(4)
        Me.txtroomtype.Name = "txtroomtype"
        Me.txtroomtype.Size = New System.Drawing.Size(506, 34)
        Me.txtroomtype.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 158)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 27)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ຄຳອະທິບາຍ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ຈຳນວນຄົນສູງສຸດ:"
        '
        'txtdes
        '
        Me.txtdes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdes.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdes.Location = New System.Drawing.Point(137, 154)
        Me.txtdes.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(506, 34)
        Me.txtdes.TabIndex = 3
        '
        'txtextrabed
        '
        Me.txtextrabed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtextrabed.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtextrabed.Location = New System.Drawing.Point(137, 80)
        Me.txtextrabed.Margin = New System.Windows.Forms.Padding(4)
        Me.txtextrabed.Name = "txtextrabed"
        Me.txtextrabed.Size = New System.Drawing.Size(506, 34)
        Me.txtextrabed.TabIndex = 3
        '
        'txtmaxperson
        '
        Me.txtmaxperson.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmaxperson.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmaxperson.Location = New System.Drawing.Point(137, 117)
        Me.txtmaxperson.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmaxperson.Name = "txtmaxperson"
        Me.txtmaxperson.Size = New System.Drawing.Size(93, 34)
        Me.txtmaxperson.TabIndex = 3
        '
        'txtid
        '
        Me.txtid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtid.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(137, 8)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(506, 34)
        Me.txtid.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ປະເພດຫ້ອງ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ລະຫັດ:"
        '
        'dgvshow
        '
        Me.dgvshow.AllowUserToAddRows = False
        Me.dgvshow.AllowUserToDeleteRows = False
        Me.dgvshow.AllowUserToResizeColumns = False
        Me.dgvshow.AllowUserToResizeRows = False
        Me.dgvshow.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvshow.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvshow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvshow.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvshow.Location = New System.Drawing.Point(4, 257)
        Me.dgvshow.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvshow.Name = "dgvshow"
        Me.dgvshow.ReadOnly = True
        Me.dgvshow.RowHeadersVisible = False
        Me.dgvshow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvshow.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvshow.RowTemplate.Height = 28
        Me.dgvshow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvshow.Size = New System.Drawing.Size(712, 315)
        Me.dgvshow.TabIndex = 3
        '
        'frmroomtype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 582)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmroomtype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ປະເພດຫ້ອງ"
        Me.GroupPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvshow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnsave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btndelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnedit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnupdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnnew As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtmaxperson As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvshow As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtroomtype As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdes As System.Windows.Forms.TextBox
    Friend WithEvents txtextrabed As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcheckin
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcheckin))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvlist = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBoxEx2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbmarket = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtnumberpeople = New DevComponents.Editors.IntegerInput()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.dtsearch2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtsearch1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dt2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dt1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rddate = New System.Windows.Forms.RadioButton()
        Me.rdroomnumber = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.rdname = New System.Windows.Forms.RadioButton()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbpricetype = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcustomertype = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtroomno = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnbrown2 = New DevComponents.DotNetBar.ButtonX()
        Me.btncus = New DevComponents.DotNetBar.ButtonX()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtcustomername = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnbrown1 = New DevComponents.DotNetBar.ButtonX()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btncancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnprint = New DevComponents.DotNetBar.ButtonX()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.rdno = New System.Windows.Forms.GroupBox()
        Me.btnclose = New DevComponents.DotNetBar.ButtonX()
        Me.txtreserverNO_search = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnsearchreserve = New DevComponents.DotNetBar.ButtonX()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnnew = New DevComponents.DotNetBar.ButtonX()
        Me.btnsave = New DevComponents.DotNetBar.ButtonX()
        Me.btnedit = New DevComponents.DotNetBar.ButtonX()
        Me.btnupdate = New DevComponents.DotNetBar.ButtonX()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txtnumberpeople, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsearch2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsearch1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.rdno.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvlist, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 248.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1067, 729)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgvlist
        '
        Me.dgvlist.AllowDrop = True
        Me.dgvlist.AllowUserToAddRows = False
        Me.dgvlist.AllowUserToDeleteRows = False
        Me.dgvlist.AllowUserToResizeColumns = False
        Me.dgvlist.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvlist.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvlist.EnableHeadersVisualStyles = False
        Me.dgvlist.GridColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgvlist.Location = New System.Drawing.Point(3, 327)
        Me.dgvlist.MultiSelect = False
        Me.dgvlist.Name = "dgvlist"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlist.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvlist.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvlist.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvlist.RowTemplate.Height = 30
        Me.dgvlist.Size = New System.Drawing.Size(1061, 339)
        Me.dgvlist.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.ComboBoxEx2)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.cbmarket)
        Me.Panel1.Controls.Add(Me.txtnumberpeople)
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Controls.Add(Me.dtsearch2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.dtsearch1)
        Me.Panel1.Controls.Add(Me.dt2)
        Me.Panel1.Controls.Add(Me.dt1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.GroupPanel1)
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cbpricetype)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtcustomertype)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtprice)
        Me.Panel1.Controls.Add(Me.txtroomno)
        Me.Panel1.Controls.Add(Me.btnbrown2)
        Me.Panel1.Controls.Add(Me.btncus)
        Me.Panel1.Controls.Add(Me.txtuser)
        Me.Panel1.Controls.Add(Me.txtcustomername)
        Me.Panel1.Controls.Add(Me.btnbrown1)
        Me.Panel1.Controls.Add(Me.txtNote)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 242)
        Me.Panel1.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(735, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 24)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "ອາຫານ:"
        '
        'ComboBoxEx2
        '
        Me.ComboBoxEx2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxEx2.DisplayMember = "Text"
        Me.ComboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx2.FormattingEnabled = True
        Me.ComboBoxEx2.ItemHeight = 29
        Me.ComboBoxEx2.Location = New System.Drawing.Point(833, 81)
        Me.ComboBoxEx2.Name = "ComboBoxEx2"
        Me.ComboBoxEx2.Size = New System.Drawing.Size(219, 35)
        Me.ComboBoxEx2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx2.TabIndex = 65
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(732, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 24)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "ຕະຫລາດ:"
        '
        'cbmarket
        '
        Me.cbmarket.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbmarket.DisplayMember = "Text"
        Me.cbmarket.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbmarket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmarket.FormattingEnabled = True
        Me.cbmarket.ItemHeight = 29
        Me.cbmarket.Location = New System.Drawing.Point(833, 44)
        Me.cbmarket.Name = "cbmarket"
        Me.cbmarket.Size = New System.Drawing.Size(219, 35)
        Me.cbmarket.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbmarket.TabIndex = 63
        '
        'txtnumberpeople
        '
        Me.txtnumberpeople.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtnumberpeople.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtnumberpeople.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnumberpeople.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtnumberpeople.Location = New System.Drawing.Point(833, 118)
        Me.txtnumberpeople.Name = "txtnumberpeople"
        Me.txtnumberpeople.ShowUpDown = True
        Me.txtnumberpeople.Size = New System.Drawing.Size(218, 35)
        Me.txtnumberpeople.TabIndex = 62
        Me.txtnumberpeople.Value = 1
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsearch.Location = New System.Drawing.Point(505, 199)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(452, 35)
        Me.txtsearch.TabIndex = 40
        '
        'dtsearch2
        '
        Me.dtsearch2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtsearch2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtsearch2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtsearch2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtsearch2.ButtonDropDown.Visible = True
        Me.dtsearch2.IsPopupCalendarOpen = False
        Me.dtsearch2.Location = New System.Drawing.Point(771, 199)
        '
        '
        '
        Me.dtsearch2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtsearch2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtsearch2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtsearch2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtsearch2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtsearch2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtsearch2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtsearch2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtsearch2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtsearch2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtsearch2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtsearch2.MonthCalendar.DisplayMonth = New Date(2018, 7, 1, 0, 0, 0, 0)
        Me.dtsearch2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtsearch2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtsearch2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtsearch2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtsearch2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtsearch2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtsearch2.MonthCalendar.TodayButtonVisible = True
        Me.dtsearch2.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtsearch2.Name = "dtsearch2"
        Me.dtsearch2.Size = New System.Drawing.Size(186, 35)
        Me.dtsearch2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtsearch2.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(732, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 24)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "ຫາ:"
        '
        'dtsearch1
        '
        '
        '
        '
        Me.dtsearch1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtsearch1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtsearch1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtsearch1.ButtonDropDown.Visible = True
        Me.dtsearch1.IsPopupCalendarOpen = False
        Me.dtsearch1.Location = New System.Drawing.Point(505, 198)
        '
        '
        '
        Me.dtsearch1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtsearch1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtsearch1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtsearch1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtsearch1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtsearch1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtsearch1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtsearch1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtsearch1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtsearch1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtsearch1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtsearch1.MonthCalendar.DisplayMonth = New Date(2018, 7, 1, 0, 0, 0, 0)
        Me.dtsearch1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtsearch1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtsearch1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtsearch1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtsearch1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtsearch1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtsearch1.MonthCalendar.TodayButtonVisible = True
        Me.dtsearch1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtsearch1.Name = "dtsearch1"
        Me.dtsearch1.Size = New System.Drawing.Size(221, 35)
        Me.dtsearch1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtsearch1.TabIndex = 59
        '
        'dt2
        '
        '
        '
        '
        Me.dt2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dt2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dt2.ButtonDropDown.Visible = True
        Me.dt2.IsPopupCalendarOpen = False
        Me.dt2.Location = New System.Drawing.Point(87, 118)
        '
        '
        '
        Me.dt2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dt2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dt2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt2.MonthCalendar.DisplayMonth = New Date(2018, 7, 1, 0, 0, 0, 0)
        Me.dt2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dt2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dt2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dt2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dt2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt2.MonthCalendar.TodayButtonVisible = True
        Me.dt2.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(304, 35)
        Me.dt2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dt2.TabIndex = 58
        '
        'dt1
        '
        '
        '
        '
        Me.dt1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dt1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dt1.ButtonDropDown.Visible = True
        Me.dt1.IsPopupCalendarOpen = False
        Me.dt1.Location = New System.Drawing.Point(87, 79)
        '
        '
        '
        Me.dt1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dt1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dt1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt1.MonthCalendar.DisplayMonth = New Date(2018, 7, 1, 0, 0, 0, 0)
        Me.dt1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dt1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dt1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dt1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dt1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dt1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt1.MonthCalendar.TodayButtonVisible = True
        Me.dt1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(304, 35)
        Me.dt1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dt1.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 24)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "ຄົ້ນຫາ:"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.rddate)
        Me.GroupPanel1.Controls.Add(Me.rdroomnumber)
        Me.GroupPanel1.Controls.Add(Me.RadioButton2)
        Me.GroupPanel1.Controls.Add(Me.rdname)
        Me.GroupPanel1.Location = New System.Drawing.Point(87, 196)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(412, 41)
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
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 55
        '
        'rddate
        '
        Me.rddate.AutoSize = True
        Me.rddate.BackColor = System.Drawing.Color.Transparent
        Me.rddate.Location = New System.Drawing.Point(3, 3)
        Me.rddate.Name = "rddate"
        Me.rddate.Size = New System.Drawing.Size(63, 28)
        Me.rddate.TabIndex = 62
        Me.rddate.TabStop = True
        Me.rddate.Text = "ວັນທີ:"
        Me.rddate.UseVisualStyleBackColor = False
        '
        'rdroomnumber
        '
        Me.rdroomnumber.AutoSize = True
        Me.rdroomnumber.BackColor = System.Drawing.Color.Transparent
        Me.rdroomnumber.Location = New System.Drawing.Point(324, 3)
        Me.rdroomnumber.Name = "rdroomnumber"
        Me.rdroomnumber.Size = New System.Drawing.Size(78, 28)
        Me.rdroomnumber.TabIndex = 61
        Me.rdroomnumber.TabStop = True
        Me.rdroomnumber.Text = "ເບີຫ້ອງ:"
        Me.rdroomnumber.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(204, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(114, 28)
        Me.RadioButton2.TabIndex = 60
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "ເລກປະຈໍາໂຕ:"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'rdname
        '
        Me.rdname.AutoSize = True
        Me.rdname.BackColor = System.Drawing.Color.Transparent
        Me.rdname.Location = New System.Drawing.Point(72, 3)
        Me.rdname.Name = "rdname"
        Me.rdname.Size = New System.Drawing.Size(110, 28)
        Me.rdname.TabIndex = 59
        Me.rdname.TabStop = True
        Me.rdname.Text = "ຄົ້ນຫາຕາມຊື່:"
        Me.rdname.UseVisualStyleBackColor = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonX1.Location = New System.Drawing.Point(963, 197)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(88, 35)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 54
        Me.ButtonX1.Text = "ຄົ້ນຫາ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(397, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 24)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "ປະເພດລູກຄ້າ:"
        '
        'cbpricetype
        '
        Me.cbpricetype.DisplayMember = "Text"
        Me.cbpricetype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbpricetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpricetype.FormattingEnabled = True
        Me.cbpricetype.ItemHeight = 29
        Me.cbpricetype.Location = New System.Drawing.Point(500, 79)
        Me.cbpricetype.Name = "cbpricetype"
        Me.cbpricetype.Size = New System.Drawing.Size(226, 35)
        Me.cbpricetype.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbpricetype.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(399, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 24)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "ປະເພດລາຄາ:"
        '
        'txtcustomertype
        '
        Me.txtcustomertype.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txtcustomertype.Border.Class = "TextBoxBorder"
        Me.txtcustomertype.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcustomertype.Location = New System.Drawing.Point(501, 42)
        Me.txtcustomertype.Name = "txtcustomertype"
        Me.txtcustomertype.ReadOnly = True
        Me.txtcustomertype.Size = New System.Drawing.Size(225, 35)
        Me.txtcustomertype.TabIndex = 44
        Me.txtcustomertype.WatermarkText = "ເລືອກປະເພດລູກຄ້າ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(437, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 24)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "ຊື່ຫ້ອງ:"
        '
        'txtprice
        '
        Me.txtprice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtprice.ForeColor = System.Drawing.Color.Blue
        Me.txtprice.Location = New System.Drawing.Point(501, 118)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(225, 35)
        Me.txtprice.TabIndex = 6
        '
        'txtroomno
        '
        Me.txtroomno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txtroomno.Border.Class = "TextBoxBorder"
        Me.txtroomno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtroomno.Location = New System.Drawing.Point(502, 5)
        Me.txtroomno.Name = "txtroomno"
        Me.txtroomno.ReadOnly = True
        Me.txtroomno.Size = New System.Drawing.Size(160, 35)
        Me.txtroomno.TabIndex = 8
        Me.txtroomno.WatermarkText = "ກະລຸນາເລືອກຫ້ອງ"
        '
        'btnbrown2
        '
        Me.btnbrown2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnbrown2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnbrown2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnbrown2.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnbrown2.Location = New System.Drawing.Point(666, 4)
        Me.btnbrown2.Name = "btnbrown2"
        Me.btnbrown2.Size = New System.Drawing.Size(54, 35)
        Me.btnbrown2.TabIndex = 9
        Me.btnbrown2.Text = "ເລືອກ"
        '
        'btncus
        '
        Me.btncus.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncus.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncus.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btncus.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btncus.Location = New System.Drawing.Point(997, 6)
        Me.btncus.Name = "btncus"
        Me.btncus.Size = New System.Drawing.Size(54, 35)
        Me.btncus.TabIndex = 5
        Me.btncus.Text = "ໄໝ່"
        Me.btncus.TextColor = System.Drawing.Color.Maroon
        '
        'txtuser
        '
        Me.txtuser.Enabled = False
        Me.txtuser.Location = New System.Drawing.Point(87, 42)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.ReadOnly = True
        Me.txtuser.Size = New System.Drawing.Size(304, 35)
        Me.txtuser.TabIndex = 1
        '
        'txtcustomername
        '
        Me.txtcustomername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcustomername.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txtcustomername.Border.Class = "TextBoxBorder"
        Me.txtcustomername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcustomername.Location = New System.Drawing.Point(833, 6)
        Me.txtcustomername.Name = "txtcustomername"
        Me.txtcustomername.ReadOnly = True
        Me.txtcustomername.Size = New System.Drawing.Size(101, 35)
        Me.txtcustomername.TabIndex = 3
        Me.txtcustomername.WatermarkText = "ກະລຸນາເລືອກລູກຄ້າ"
        '
        'btnbrown1
        '
        Me.btnbrown1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnbrown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbrown1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnbrown1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnbrown1.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnbrown1.Location = New System.Drawing.Point(937, 6)
        Me.btnbrown1.Name = "btnbrown1"
        Me.btnbrown1.Size = New System.Drawing.Size(54, 35)
        Me.btnbrown1.TabIndex = 4
        Me.btnbrown1.Text = "ເລືອກ"
        '
        'txtNote
        '
        Me.txtNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNote.Location = New System.Drawing.Point(87, 157)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(964, 35)
        Me.txtNote.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ຜູ້ອອກບີນ:"
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Location = New System.Drawing.Point(87, 5)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(304, 35)
        Me.txtid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ລະຫັດ:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 24)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "ວັນທີເຂົ້າ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(6, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 24)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "ວັນທີອອກ:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(732, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 24)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "ຈໍານວນຄົນ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "ໜາຍເຫດ:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(436, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 24)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "ລາຄາ:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(732, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 24)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "ລູກຄ້າ:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.btnprint)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 672)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1061, 54)
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.60132!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.39868!))
        Me.TableLayoutPanel2.Controls.Add(Me.rdno, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1061, 70)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'rdno
        '
        Me.rdno.Controls.Add(Me.btnclose)
        Me.rdno.Controls.Add(Me.txtreserverNO_search)
        Me.rdno.Controls.Add(Me.btnsearchreserve)
        Me.rdno.Controls.Add(Me.Label9)
        Me.rdno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdno.Location = New System.Drawing.Point(454, 3)
        Me.rdno.Name = "rdno"
        Me.rdno.Size = New System.Drawing.Size(604, 64)
        Me.rdno.TabIndex = 6
        Me.rdno.TabStop = False
        Me.rdno.Text = "ຄົ້ນຫາ"
        '
        'btnclose
        '
        Me.btnclose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnclose.Image = Global.HotelSystem.My.Resources.Resources._1489493744_exit
        Me.btnclose.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnclose.Location = New System.Drawing.Point(532, 22)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(72, 36)
        Me.btnclose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnclose.TabIndex = 12
        Me.btnclose.Text = "ປິດ"
        '
        'txtreserverNO_search
        '
        '
        '
        '
        Me.txtreserverNO_search.Border.Class = "TextBoxBorder"
        Me.txtreserverNO_search.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtreserverNO_search.Location = New System.Drawing.Point(101, 22)
        Me.txtreserverNO_search.Name = "txtreserverNO_search"
        Me.txtreserverNO_search.Size = New System.Drawing.Size(253, 35)
        Me.txtreserverNO_search.TabIndex = 11
        '
        'btnsearchreserve
        '
        Me.btnsearchreserve.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText
        Me.btnsearchreserve.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsearchreserve.Image = CType(resources.GetObject("btnsearchreserve.Image"), System.Drawing.Image)
        Me.btnsearchreserve.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnsearchreserve.Location = New System.Drawing.Point(360, 22)
        Me.btnsearchreserve.Name = "btnsearchreserve"
        Me.btnsearchreserve.Size = New System.Drawing.Size(88, 35)
        Me.btnsearchreserve.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnsearchreserve.TabIndex = 10
        Me.btnsearchreserve.Text = "ຄົ້ນຫາ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(2, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 24)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "ເລກການຈອງ:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.btnnew)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnsave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnedit)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnupdate)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(445, 64)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'btnnew
        '
        Me.btnnew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnnew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnnew.Image = Global.HotelSystem.My.Resources.Resources.New_file
        Me.btnnew.Location = New System.Drawing.Point(3, 3)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(103, 45)
        Me.btnnew.TabIndex = 18
        Me.btnnew.Text = "ສ້າງໄຫມ່"
        '
        'btnsave
        '
        Me.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsave.Image = Global.HotelSystem.My.Resources.Resources.Save_icon
        Me.btnsave.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnsave.Location = New System.Drawing.Point(112, 3)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(95, 45)
        Me.btnsave.TabIndex = 19
        Me.btnsave.Text = "ບັນທືກ"
        '
        'btnedit
        '
        Me.btnedit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnedit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnedit.Image = Global.HotelSystem.My.Resources.Resources.Edit_page
        Me.btnedit.Location = New System.Drawing.Point(213, 3)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(103, 45)
        Me.btnedit.TabIndex = 20
        Me.btnedit.Text = "ແກ້ໄຂ"
        '
        'btnupdate
        '
        Me.btnupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnupdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnupdate.Image = Global.HotelSystem.My.Resources.Resources.Refresh
        Me.btnupdate.Location = New System.Drawing.Point(322, 3)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(95, 45)
        Me.btnupdate.TabIndex = 21
        Me.btnupdate.Text = "ປັບປຸງ"
        '
        'frmcheckin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 729)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MinimumSize = New System.Drawing.Size(1024, 700)
        Me.Name = "frmcheckin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ໃບແຈ້ງພັກ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtnumberpeople, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsearch2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsearch1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.rdno.ResumeLayout(False)
        Me.rdno.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvlist As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnbrown1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtcustomername As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnprint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btncancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents btncus As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtroomno As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnbrown2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcustomertype As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbpricetype As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rdno As System.Windows.Forms.GroupBox
    Friend WithEvents txtreserverNO_search As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnsearchreserve As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnnew As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnsave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnedit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnupdate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnclose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rddate As System.Windows.Forms.RadioButton
    Friend WithEvents rdroomnumber As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdname As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dt2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dt1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtsearch2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtsearch1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxEx2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbmarket As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtnumberpeople As DevComponents.Editors.IntegerInput
End Class

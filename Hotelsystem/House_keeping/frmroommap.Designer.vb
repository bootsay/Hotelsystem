﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmroommap
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbroomtype = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbfloor = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.froom = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnclose = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.cbroomtype)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.cbfloor)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(223, 598)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ປະເພດ:"
        '
        'cbroomtype
        '
        Me.cbroomtype.DisplayMember = "Text"
        Me.cbroomtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbroomtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbroomtype.FormattingEnabled = True
        Me.cbroomtype.ItemHeight = 29
        Me.cbroomtype.Location = New System.Drawing.Point(1, 126)
        Me.cbroomtype.Name = "cbroomtype"
        Me.cbroomtype.Size = New System.Drawing.Size(216, 35)
        Me.cbroomtype.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbroomtype.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ຊັ້ນ:"
        '
        'cbfloor
        '
        Me.cbfloor.DisplayMember = "Text"
        Me.cbfloor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbfloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbfloor.FormattingEnabled = True
        Me.cbfloor.ItemHeight = 29
        Me.cbfloor.Location = New System.Drawing.Point(3, 52)
        Me.cbfloor.Name = "cbfloor"
        Me.cbfloor.Size = New System.Drawing.Size(217, 35)
        Me.cbfloor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbfloor.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.froom, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnclose, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(223, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(824, 598)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'froom
        '
        Me.froom.BackColor = System.Drawing.Color.White
        Me.froom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.froom.Location = New System.Drawing.Point(3, 62)
        Me.froom.Name = "froom"
        Me.froom.Size = New System.Drawing.Size(818, 420)
        Me.froom.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 488)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(818, 107)
        Me.Panel1.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(382, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 24)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "ຫ້ອງຢຸດປັບປຸງ"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.HotelSystem.My.Resources.Resources.hotel_outofforder
        Me.PictureBox5.Location = New System.Drawing.Point(328, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(228, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 24)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "ຫ້ອງບໍ່ວ່າງ"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.HotelSystem.My.Resources.Resources.hotel_notempty
        Me.PictureBox4.Location = New System.Drawing.Point(174, 58)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ຫ້ອງເປື້ອນ"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.HotelSystem.My.Resources.Resources.hotel_dirty
        Me.PictureBox3.Location = New System.Drawing.Point(174, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ບ໋ອກຫ້ອງ"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.HotelSystem.My.Resources.Resources.room
        Me.PictureBox2.Location = New System.Drawing.Point(24, 58)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ຫ້ອງວ່າງ"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HotelSystem.My.Resources.Resources.hotel_empty
        Me.PictureBox1.Location = New System.Drawing.Point(24, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnclose
        '
        Me.btnclose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnclose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnclose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnclose.Image = Global.HotelSystem.My.Resources.Resources._1489493744_exit
        Me.btnclose.Location = New System.Drawing.Point(729, 3)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(92, 53)
        Me.btnclose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnclose.TabIndex = 2
        Me.btnclose.Text = "ປິດ"
        '
        'frmroommap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmroommap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbfloor As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbroomtype As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents froom As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmoption
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
        Me.btncheckin = New DevComponents.DotNetBar.ButtonX()
        Me.btncheckout = New DevComponents.DotNetBar.ButtonX()
        Me.btnchangstatus = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'btncheckin
        '
        Me.btncheckin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncheckin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncheckin.Location = New System.Drawing.Point(96, 23)
        Me.btncheckin.Name = "btncheckin"
        Me.btncheckin.Size = New System.Drawing.Size(330, 101)
        Me.btncheckin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btncheckin.TabIndex = 0
        Me.btncheckin.Text = "ເຂົ້າຫ້ອງ"
        '
        'btncheckout
        '
        Me.btncheckout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncheckout.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncheckout.Location = New System.Drawing.Point(96, 127)
        Me.btncheckout.Name = "btncheckout"
        Me.btncheckout.Size = New System.Drawing.Size(330, 101)
        Me.btncheckout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btncheckout.TabIndex = 1
        Me.btncheckout.Text = "ອອກຫ້ອງ"
        '
        'btnchangstatus
        '
        Me.btnchangstatus.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnchangstatus.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnchangstatus.Location = New System.Drawing.Point(96, 234)
        Me.btnchangstatus.Name = "btnchangstatus"
        Me.btnchangstatus.Size = New System.Drawing.Size(330, 101)
        Me.btnchangstatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnchangstatus.TabIndex = 2
        Me.btnchangstatus.Text = "ປ່ຽນສະຖານະ"
        '
        'frmoption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 392)
        Me.Controls.Add(Me.btnchangstatus)
        Me.Controls.Add(Me.btncheckout)
        Me.Controls.Add(Me.btncheckin)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmoption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ທາງເລືອກ"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btncheckin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btncheckout As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnchangstatus As DevComponents.DotNetBar.ButtonX
End Class

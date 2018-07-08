Public Class frmroommap
    Dim floors As New tbfroomlocation
    Dim roomtype As New tbfroomtype
    Dim rooms As New tbfroom
    Dim dtroom As New DataTable
    Private Sub frmroommap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        floors.comboroomlocation(cbfloor)
        cbfloor.SelectedIndex = 0
        roomtype.comboroomtype(cbroomtype)
        dtroom.Clear()
        rooms.getroom(cbfloor.SelectedValue, dtroom)
        For i As Integer = 0 To dtroom.Rows.Count - 1
            Dim btn As New DevComponents.DotNetBar.ButtonX
            AddHandler btn.DoubleClick, AddressOf clickme
            btn.Width = 140
            btn.Height = 100
            btn.Font = New System.Drawing.Font("Saysettha OT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            btn.Text = dtroom.Rows(i).Item(4)
            btn.Name = dtroom.Rows(i).Item(0)
            btn.Visible = True
            froom.Controls.Add(btn)
        Next
    End Sub
    Private Sub clickme(ByVal sendr As Object, ByVal e As EventArgs)
        frmoption.ShowDialog()
        frmoption.Close()
    End Sub
 
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class
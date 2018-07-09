Public Class frmroomrate
    Dim roomrate As New tbfroomrate
    Dim roomtype As New tbfroomtype
    Dim roomtyperate As New tbfroomtyperate
    Private Sub frmemployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Text = roomrate.runid
        roomtype.comboroomtype(cbroomtype)
        roomtyperate.comboroomtyperate(cbroomtyperate)
        roomrate.loadtbfroomrate(dgvshow)
        enablesave()
        txtprice.Select()
    End Sub
    Private Sub enablesave()
        btnsave.Enabled = True
        btndelete.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = False
        btnnew.Enabled = True
    End Sub
    Private Sub enableedit()
        btnsave.Enabled = False
        btndelete.Enabled = True
        btnedit.Enabled = True
        btnupdate.Enabled = False
        btnnew.Enabled = True
    End Sub
    Private Sub enableupdate()
        btnsave.Enabled = False
        btndelete.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = True
        btnnew.Enabled = True
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtdes.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtprice.Select()
            Return
        End If
        If txtprice.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtprice.Select()
            Return
        End If
        roomrate.save(txtid.Text, cbroomtype.SelectedValue, cbroomtyperate.SelectedValue, txtprice.Text, txtdes.Text)
        txtdes.Clear()
        txtprice.Clear()
        roomrate.loadtbfroomrate(dgvshow)
        txtid.Text = roomrate.runid
        enablesave()
        txtprice.Select()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        roomrate.delete(txtid.Text)
        txtprice.ReadOnly = False
        txtid.Text = roomrate.runid
        roomrate.loadtbfroomrate(dgvshow)
        txtdes.Clear()
        txtprice.Clear()
        txtprice.Select()
        enablesave()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtprice.ReadOnly = False
        txtdes.ReadOnly = False
        txtprice.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        roomrate.update(txtid.Text, cbroomtype.SelectedValue, cbroomtyperate.SelectedValue, txtprice.Text, txtdes.Text)
        txtprice.ReadOnly = False
        txtdes.ReadOnly = False
        txtid.Text = roomrate.runid
        roomrate.loadtbfroomrate(dgvshow)
        txtdes.Clear()
        txtprice.Clear()
        txtprice.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtdes.Clear()
        txtprice.Clear()
        txtprice.ReadOnly = False
        'txtdes.ReadOnly = False
        txtid.Text = roomrate.runid
        roomrate.loadtbfroomrate(dgvshow)
        txtprice.Select()
        enablesave()
    End Sub
    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                cbroomtype.Text = .CurrentRow.Cells(1).Value
                cbroomtyperate.Text = .CurrentRow.Cells(2).Value
                txtprice.Text = .CurrentRow.Cells(3).Value
                txtdes.Text = .CurrentRow.Cells(4).Value
                txtdes.ReadOnly = True
                txtprice.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick

    End Sub

    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtprice_TextChanged(sender As Object, e As EventArgs) Handles txtprice.TextChanged
        Try
            Dim tem As Double = txtprice.Text
            txtprice.Text = tem.ToString("N0")
            txtprice.SelectionStart = txtprice.TextLength
        Catch ex As Exception

        End Try
    End Sub
End Class
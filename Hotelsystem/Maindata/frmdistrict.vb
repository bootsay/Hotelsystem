Public Class frmdistrict
    Dim cate As New tbdistrict
    Dim provinces As New tbprovince
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If cbprovience.SelectedValue < 1 Then
            MessageBox.Show("ກະລຸນາເລືອກແຂວງ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If txttype.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txttype.Select()
            Return
        End If
        cate.save(txtid.Text, cbprovience.SelectedValue, txttype.Text)
        txttype.Clear()
        cate.loadtbdistrict(cbprovience.SelectedValue, dgvshow)
        txtid.Text = cate.runid
        enablesave()
        txttype.Select()
    End Sub

    Private Sub frmdistrict_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = cate.runid
            cate.loadtbdistrict(cbprovience.SelectedValue, dgvshow)
            provinces.comboprovince(cbprovience)
            enablesave()
            txttype.Select()
        Catch ex As Exception

        End Try
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

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        cate.delete(txtid.Text)
        txttype.ReadOnly = False
        txtid.Text = cate.runid
        cate.loadtbdistrict(cbprovience.SelectedValue, dgvshow)
        txttype.Clear()
        txttype.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txttype.Text = .CurrentRow.Cells(2).Value
                cbprovience.Text = .CurrentRow.Cells(1).Value
                txttype.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txttype.ReadOnly = False
        txttype.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        cate.update(txtid.Text, cbprovience.SelectedValue, txttype.Text)
        txttype.ReadOnly = False
        txtid.Text = cate.runid
        cate.loadtbdistrict(cbprovience.SelectedValue, dgvshow)
        txttype.Clear()
        txttype.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txttype.Clear()
        txttype.ReadOnly = False
        txtid.Text = cate.runid
        cate.loadtbdistrict(cbprovience.SelectedValue, dgvshow)
        txttype.Select()
        enablesave()
    End Sub

    'Private Sub cbprovience_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbprovience.SelectedIndexChanged
    '    Try
    '        cate.viewdistrict(cbprovience.SelectedValue, dgvshow)
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub cbprovience_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbprovience.SelectedIndexChanged
        Try
            cate.loadtbdistrict(cbprovience.SelectedValue, dgvshow)
        Catch ex As Exception

        End Try
    End Sub
End Class
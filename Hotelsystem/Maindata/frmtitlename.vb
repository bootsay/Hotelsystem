Public Class frmtitlename
    'Dim cate As New tbtitlename
    'Dim cat As New tbcategory
    'Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

    '    If txttitlename.Text = "" Then
    '        MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        txttitlename.Select()
    '        Return
    '    End If
    '    cate.save(txtid.Text, txttype.Text)
    '    txttitlename.Clear()
    '    cate.loadbrand(dgvshow)
    '    txtid.Text = cate.runid
    '    enablesave()
    '    txttitlename.Select()
    'End Sub

    'Private Sub frmcategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Try
    '        txtid.Text = cate.runid
    '        cate.loadbrand(dgvshow)
    '        enablesave()
    '        txttitlename.Select()
    '    Catch ex As Exception

    '    End Try
    'End Sub
    'Private Sub enablesave()
    '    btnsave.Enabled = True
    '    btndelete.Enabled = False
    '    btnedit.Enabled = False
    '    btnupdate.Enabled = False
    '    btnnew.Enabled = True
    'End Sub
    'Private Sub enableedit()
    '    btnsave.Enabled = False
    '    btndelete.Enabled = True
    '    btnedit.Enabled = True
    '    btnupdate.Enabled = False
    '    btnnew.Enabled = True
    'End Sub
    'Private Sub enableupdate()
    '    btnsave.Enabled = False
    '    btndelete.Enabled = False
    '    btnedit.Enabled = False
    '    btnupdate.Enabled = True
    '    btnnew.Enabled = True
    'End Sub

    'Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
    '    cate.delete(txtid.Text)
    '    txttitlename.ReadOnly = False
    '    txtid.Text = cate.runid
    '    cate.loadbrand(dgvshow)
    '    txttitlename.Clear()
    '    txttitlename.Select()
    '    enablesave()
    'End Sub

    'Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
    '    Try
    '        With dgvshow
    '            txtid.Text = .CurrentRow.Cells(0).Value
    '            txttitlename.Text = .CurrentRow.Cells(1).Value
    '            txttitlename.ReadOnly = True
    '            enableedit()
    '        End With
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
    '    txttitlename.ReadOnly = False
    '    txttitlename.Select()
    '    enableupdate()
    'End Sub

    'Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
    '    cate.update(txtid.Text, txttype.Text)
    '    txttitlename.ReadOnly = False
    '    txtid.Text = cate.runid
    '    cate.loadbrand(dgvshow)
    '    txttitlename.Clear()
    '    txttitlename.Select()
    '    enablesave()
    'End Sub

    'Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
    '    txttitlename.Clear()
    '    txttitlename.ReadOnly = False
    '    txtid.Text = cate.runid
    '    cate.loadbrand(dgvshow)
    '    txttitlename.Select()
    '    enablesave()
    'End Sub

    'Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick

    'End Sub
End Class
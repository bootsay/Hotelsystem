Public Class frmcustype

    'Dim cate As New tbcustomertype
    'Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
    '    If txtCustomerType.Text = "" Then
    '        MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        txtCustomerType.Select()
    '        Return
    '    End If
    '    cate.save(txtid.Text, txttype.Text)
    '    txtCustomerType.Clear()
    '    cate.loaddata(dgvshow)
    '    txtid.Text = cate.runid
    '    enablesave()
    '    txtCustomerType.Select()
    'End Sub

    'Private Sub frmcategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    txtid.Text = cate.runid
    '    cate.loaddata(dgvshow)
    '    enablesave()
    '    txtCustomerType.Select()
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
    '    txtCustomerType.ReadOnly = False
    '    txtid.Text = cate.runid
    '    cate.loaddata(dgvshow)
    '    txtCustomerType.Clear()
    '    txtCustomerType.Select()
    '    enablesave()
    'End Sub

    'Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
    '    Try
    '        With dgvshow
    '            txtid.Text = .CurrentRow.Cells(0).Value
    '            txtCustomerType.Text = .CurrentRow.Cells(1).Value
    '            txtCustomerType.ReadOnly = True
    '            enableedit()
    '        End With
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
    '    txtCustomerType.ReadOnly = False
    '    txtCustomerType.Select()
    '    enableupdate()
    'End Sub

    'Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
    '    cate.update(txtid.Text, txttype.Text)
    '    txtCustomerType.ReadOnly = False
    '    txtid.Text = cate.runid
    '    cate.loaddata(dgvshow)
    '    txtCustomerType.Clear()
    '    txtCustomerType.Select()
    '    enablesave()
    'End Sub

    'Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
    '    txtCustomerType.Clear()
    '    txtCustomerType.ReadOnly = False
    '    txtid.Text = cate.runid
    '    cate.loaddata(dgvshow)
    '    txtCustomerType.Select()
    '    enablesave()
    'End Sub
End Class
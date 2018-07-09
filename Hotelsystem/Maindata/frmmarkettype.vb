Public Class frmmarkettype
    Dim markrttype As New tbfmarkettype
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtmarkettype.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtmarkettype.Select()
            Return
        End If
        markrttype.save(txtid.Text, txtmarkettype.Text)
        txtmarkettype.Clear()
        markrttype.loadtbmarkettype(dgvshow)
        txtid.Text = markrttype.runid
        enablesave()
        txtmarkettype.Select()
    End Sub

    Private Sub frmmarkrttypegory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = markrttype.runid
            markrttype.loadtbmarkettype(dgvshow)
            enablesave()
            txtmarkettype.Select()
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
        markrttype.delete(txtid.Text)
        txtmarkettype.ReadOnly = False
        txtid.Text = markrttype.runid
        markrttype.loadtbmarkettype(dgvshow)
        txtmarkettype.Clear()
        txtmarkettype.Select()
        enablesave()
    End Sub


    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtmarkettype.ReadOnly = False
        txtmarkettype.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        markrttype.update(txtid.Text, txtmarkettype.Text)
        txtmarkettype.ReadOnly = False
        txtid.Text = markrttype.runid
        markrttype.loadtbmarkettype(dgvshow)
        txtmarkettype.Clear()
        txtmarkettype.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtmarkettype.Clear()
        txtmarkettype.ReadOnly = False
        txtid.Text = markrttype.runid
        markrttype.loadtbmarkettype(dgvshow)
        txtmarkettype.Select()
        enablesave()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub dgvtype_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick

    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txtmarkettype.Text = .CurrentRow.Cells(1).Value
                txtmarkettype.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class
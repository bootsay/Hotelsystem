Public Class frmpaymethod
    Dim paymethod As New tbpaymethod
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtpaymethod.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpaymethod.Select()
            Return
        End If
        paymethod.save(txtid.Text, txtpaymethod.Text)
        txtpaymethod.Clear()
        paymethod.loadtbpaymethod(dgvshow)
        txtid.Text = paymethod.runid
        enablesave()
        txtpaymethod.Select()
    End Sub

    Private Sub frmpaymethodgory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = paymethod.runid
            paymethod.loadtbpaymethod(dgvshow)
            enablesave()
            txtpaymethod.Select()
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
        paymethod.delete(txtid.Text)
        txtpaymethod.ReadOnly = False
        txtid.Text = paymethod.runid
        paymethod.loadtbpaymethod(dgvshow)
        txtpaymethod.Clear()
        txtpaymethod.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txtpaymethod.Text = .CurrentRow.Cells(1).Value
                txtpaymethod.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtpaymethod.ReadOnly = False
        txtpaymethod.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        paymethod.update(txtid.Text, txtpaymethod.Text)
        txtpaymethod.ReadOnly = False
        txtid.Text = paymethod.runid
        paymethod.loadtbpaymethod(dgvshow)
        txtpaymethod.Clear()
        txtpaymethod.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtpaymethod.Clear()
        txtpaymethod.ReadOnly = False
        txtid.Text = paymethod.runid
        paymethod.loadtbpaymethod(dgvshow)
        txtpaymethod.Select()
        enablesave()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class
Public Class frminouttype
    Dim inouttype As New tbfinouttype
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtinouttype.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtinouttype.Select()
            Return
        End If
        inouttype.save(txtid.Text, txtinouttype.Text)
        txtinouttype.Clear()
        inouttype.loadtbfinouttype(dgvshow)
        txtid.Text = inouttype.runid
        enablesave()
        txtinouttype.Select()
    End Sub

    Private Sub frminouttypegory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = inouttype.runid
            inouttype.loadtbfinouttype(dgvshow)
            enablesave()
            txtinouttype.Select()
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
        inouttype.delete(txtid.Text)
        txtinouttype.ReadOnly = False
        txtid.Text = inouttype.runid
        inouttype.loadtbfinouttype(dgvshow)
        txtinouttype.Clear()
        txtinouttype.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txtinouttype.Text = .CurrentRow.Cells(1).Value
                txtinouttype.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtinouttype.ReadOnly = False
        txtinouttype.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        inouttype.update(txtid.Text, txtinouttype.Text)
        txtinouttype.ReadOnly = False
        txtid.Text = inouttype.runid
        inouttype.loadtbfinouttype(dgvshow)
        txtinouttype.Clear()
        txtinouttype.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtinouttype.Clear()
        txtinouttype.ReadOnly = False
        txtid.Text = inouttype.runid
        inouttype.loadtbfinouttype(dgvshow)
        txtinouttype.Select()
        enablesave()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class
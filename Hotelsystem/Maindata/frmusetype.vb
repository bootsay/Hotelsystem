Public Class frmusetype
    Dim usetype As New tbfusetype
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtusetype.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusetype.Select()
            Return
        End If
        usetype.save(txtid.Text, txtusetype.Text)
        txtusetype.Clear()
        usetype.loadtbfusetype(dgvshow)
        txtid.Text = usetype.runid
        enablesave()
        txtusetype.Select()
    End Sub

    Private Sub frmusetypegory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = usetype.runid
            usetype.loadtbfusetype(dgvshow)
            enablesave()
            txtusetype.Select()
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
        usetype.delete(txtid.Text)
        txtusetype.ReadOnly = False
        txtid.Text = usetype.runid
        usetype.loadtbfusetype(dgvshow)
        txtusetype.Clear()
        txtusetype.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txtusetype.Text = .CurrentRow.Cells(1).Value
                txtusetype.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtusetype.ReadOnly = False
        txtusetype.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        usetype.update(txtid.Text, txtusetype.Text)
        txtusetype.ReadOnly = False
        txtid.Text = usetype.runid
        usetype.loadtbfusetype(dgvshow)
        txtusetype.Clear()
        txtusetype.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtusetype.Clear()
        txtusetype.ReadOnly = False
        txtid.Text = usetype.runid
        usetype.loadtbfusetype(dgvshow)
        txtusetype.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class
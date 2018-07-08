Public Class frmlevel
    Dim level As New tblevel
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtlevel.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtlevel.Select()
            Return
        End If
        level.save(txtid.Text, txtlevel.Text)
        txtlevel.Clear()
        level.loadtblevel(dgvshow)
        txtid.Text = level.runid
        enablesave()
        txtlevel.Select()
    End Sub

    Private Sub frmlevelgory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = level.runid
            level.loadtblevel(dgvshow)
            enablesave()
            txtlevel.Select()
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
        level.delete(txtid.Text)
        txtlevel.ReadOnly = False
        txtid.Text = level.runid
        level.loadtblevel(dgvshow)
        txtlevel.Clear()
        txtlevel.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txtlevel.Text = .CurrentRow.Cells(1).Value
                txtlevel.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtlevel.ReadOnly = False
        txtlevel.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        level.update(txtid.Text, txtlevel.Text)
        txtlevel.ReadOnly = False
        txtid.Text = level.runid
        level.loadtblevel(dgvshow)
        txtlevel.Clear()
        txtlevel.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtlevel.Clear()
        txtlevel.ReadOnly = False
        txtid.Text = level.runid
        level.loadtblevel(dgvshow)
        txtlevel.Select()
        enablesave()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class
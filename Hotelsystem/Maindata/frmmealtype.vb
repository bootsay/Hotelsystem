Public Class frmmealtype
    Dim mealtype As New tbmealtype
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtmealtype.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtmealtype.Select()
            Return
        End If
        mealtype.save(txtid.Text, txtmealtype.Text)
        txtmealtype.Clear()
        mealtype.loadtbmealtype(dgvshow)
        txtid.Text = mealtype.runid
        enablesave()
        txtmealtype.Select()
    End Sub

    Private Sub frmmealtypegory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = mealtype.runid
            mealtype.loadtbmealtype(dgvshow)
            enablesave()
            txtmealtype.Select()
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
        mealtype.delete(txtid.Text)
        txtmealtype.ReadOnly = False
        txtid.Text = mealtype.runid
        mealtype.loadtbmealtype(dgvshow)
        txtmealtype.Clear()
        txtmealtype.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txtmealtype.Text = .CurrentRow.Cells(1).Value
                txtmealtype.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtmealtype.ReadOnly = False
        txtmealtype.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        mealtype.update(txtid.Text, txtmealtype.Text)
        txtmealtype.ReadOnly = False
        txtid.Text = mealtype.runid
        mealtype.loadtbmealtype(dgvshow)
        txtmealtype.Clear()
        txtmealtype.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtmealtype.Clear()
        txtmealtype.ReadOnly = False
        txtid.Text = mealtype.runid
        mealtype.loadtbmealtype(dgvshow)
        txtmealtype.Select()
        enablesave()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class
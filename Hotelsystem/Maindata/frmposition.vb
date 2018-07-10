Public Class frmposition
    Dim position As New tbposition
    Dim department As New tbdepartment
    Public frmdepartment1 As Boolean = False
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtposition.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtposition.Select()
            Return
        End If
        position.save(txtid.Text, cbdepartment.SelectedValue, txtposition.Text)
        txtposition.Clear()
        position.loadtbposition(dgvshow)
        department.combodepartment(cbdepartment)
        txtid.Text = position.runid
        enablesave()
        txtposition.Select()
    End Sub

    Private Sub frmpositiongory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = position.runid
            position.loadtbposition(dgvshow)
            department.combodepartment(cbdepartment)
            enablesave()
            txtposition.Select()
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
        position.delete(txtid.Text)
        txtposition.ReadOnly = False
        txtid.Text = position.runid
        position.loadtbposition(dgvshow)
        department.combodepartment(cbdepartment)
        txtposition.Clear()
        txtposition.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                cbdepartment.Text = .CurrentRow.Cells(1).Value
                txtposition.Text = .CurrentRow.Cells(2).Value
                txtposition.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtposition.ReadOnly = False
        txtposition.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        position.update(txtid.Text, cbdepartment.SelectedValue, txtposition.Text)
        txtposition.ReadOnly = False
        txtid.Text = position.runid
        position.loadtbposition(dgvshow)
        department.combodepartment(cbdepartment)
        txtposition.Clear()
        txtposition.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtposition.Clear()
        txtposition.ReadOnly = False
        txtid.Text = position.runid
        position.loadtbposition(dgvshow)
        txtposition.Select()
        enablesave()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub


    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

        frmdepartment1 = True
        frmdepartment.ShowDialog()
        frmdepartment.Close()
        department.combodepartment(cbdepartment)
        frmdepartment1 = False
    End Sub

    Private Sub txtposition_TextChanged(sender As Object, e As EventArgs) Handles txtposition.TextChanged

    End Sub

    Private Sub cbdepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdepartment.SelectedIndexChanged

    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub
End Class
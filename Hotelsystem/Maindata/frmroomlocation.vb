Public Class frmroomlocation
    Dim roomlocation As New tbfroomlocation
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtroomlocation.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtroomlocation.Select()
            Return
        End If
        roomlocation.save(txtid.Text, txtroomlocation.Text)
        txtroomlocation.Clear()
        roomlocation.loadtbfroomlocation(dgvshow)
        txtid.Text = roomlocation.runid
        enablesave()
        txtroomlocation.Select()
    End Sub

    Private Sub frmroomlocationgory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = roomlocation.runid
            roomlocation.loadtbfroomlocation(dgvshow)
            enablesave()
            txtroomlocation.Select()
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
        roomlocation.delete(txtid.Text)
        txtroomlocation.ReadOnly = False
        txtid.Text = roomlocation.runid
        roomlocation.loadtbfroomlocation(dgvshow)
        txtroomlocation.Clear()
        txtroomlocation.Select()
        enablesave()
    End Sub


    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtroomlocation.ReadOnly = False
        txtroomlocation.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        roomlocation.update(txtid.Text, txtroomlocation.Text)
        txtroomlocation.ReadOnly = False
        txtid.Text = roomlocation.runid
        roomlocation.loadtbfroomlocation(dgvshow)
        txtroomlocation.Clear()
        txtroomlocation.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtroomlocation.Clear()
        txtroomlocation.ReadOnly = False
        txtid.Text = roomlocation.runid
        roomlocation.loadtbfroomlocation(dgvshow)
        txtroomlocation.Select()
        enablesave()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick

    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txtroomlocation.Text = .CurrentRow.Cells(1).Value
                txtroomlocation.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class
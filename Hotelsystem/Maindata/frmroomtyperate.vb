Public Class frmroomtyperate
    Dim roomtyperate As New tbfroomtyperate
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtroomtyperate.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtroomtyperate.Select()
            Return
        End If
        roomtyperate.save(txtid.Text, txtroomtyperate.Text)
        txtroomtyperate.Clear()
        roomtyperate.loadtbfroomtyperate(dgvshow)
        txtid.Text = roomtyperate.runid
        enablesave()
        txtroomtyperate.Select()
    End Sub

    Private Sub frmroomtyperategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = roomtyperate.runid
            roomtyperate.loadtbfroomtyperate(dgvshow)
            enablesave()
            txtroomtyperate.Select()
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
        roomtyperate.delete(txtid.Text)
        txtroomtyperate.ReadOnly = False
        txtid.Text = roomtyperate.runid
        roomtyperate.loadtbfroomtyperate(dgvshow)
        txtroomtyperate.Clear()
        txtroomtyperate.Select()
        enablesave()
    End Sub


    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtroomtyperate.ReadOnly = False
        txtroomtyperate.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        roomtyperate.update(txtid.Text, txtroomtyperate.Text)
        txtroomtyperate.ReadOnly = False
        txtid.Text = roomtyperate.runid
        roomtyperate.loadtbfroomtyperate(dgvshow)
        txtroomtyperate.Clear()
        txtroomtyperate.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtroomtyperate.Clear()
        txtroomtyperate.ReadOnly = False
        txtid.Text = roomtyperate.runid
        roomtyperate.loadtbfroomtyperate(dgvshow)
        txtroomtyperate.Select()
        enablesave()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick

    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txtroomtyperate.Text = .CurrentRow.Cells(1).Value
                txtroomtyperate.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class
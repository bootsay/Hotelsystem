Public Class frmroomtype
    Dim roomtype As New tbfroomtype
    Private Sub frmemployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = roomtype.runid
            roomtype.loadtbfroomrate(dgvshow)
            enablesave()
            txtroomtype.Select()
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
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtroomtype.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtroomtype.Select()
            Return
        End If
        roomtype.save(txtid.Text, txtroomtype.Text, txtextrabed.Text, txtmaxperson.Text, txtdes.Text)
        txtroomtype.Clear()
        txtmaxperson.Clear()
        txtextrabed.Clear()
        txtdes.Clear()
        txtid.Text = roomtype.runid
        roomtype.loadtbfroomrate(dgvshow)
        enablesave()
        txtroomtype.Select()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        roomtype.delete(txtid.Text)
        txtroomtype.ReadOnly = False
        txtid.Text = roomtype.runid
        txtroomtype.Clear()
        txtmaxperson.Clear()
        txtdes.Clear()
        txtdes.Clear()
        roomtype.loadtbfroomrate(dgvshow)
        txtroomtype.Select()
        enablesave()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtroomtype.ReadOnly = False
        txtmaxperson.ReadOnly = False
        txtextrabed.ReadOnly = False
        txtdes.ReadOnly = False
        txtroomtype.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        roomtype.update(txtid.Text, txtroomtype.Text, txtextrabed.Text, txtmaxperson.Text, txtdes.Text)
        txtroomtype.ReadOnly = False
        txtmaxperson.ReadOnly = False
        txtid.Text = roomtype.runid
        txtroomtype.Clear()
        txtmaxperson.Clear()
        txtdes.Clear()
        txtextrabed.Clear()
        roomtype.loadtbfroomrate(dgvshow)
        txtroomtype.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtroomtype.Clear()
        txtextrabed.Clear()
        txtmaxperson.Clear()
        txtdes.Clear()
        txtroomtype.ReadOnly = False
        txtmaxperson.ReadOnly = False
        txtid.Text = roomtype.runid
        txtroomtype.Select()
        roomtype.loadtbfroomrate(dgvshow)
        enablesave()
    End Sub
    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txtroomtype.Text = .CurrentRow.Cells(1).Value
                txtextrabed.Text = .CurrentRow.Cells(2).Value
                txtmaxperson.Text = .CurrentRow.Cells(3).Value
                txtdes.Text = .CurrentRow.Cells(4).Value
                txtroomtype.ReadOnly = True
                txtmaxperson.ReadOnly = True
                txtextrabed.ReadOnly = True
                txtdes.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class
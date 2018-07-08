Public Class frmroomstatus
    Dim roomstatus As New tbroomstatus
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txttype.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txttype.Select()
            Return
        End If
        roomstatus.save(txtid.Text, txttype.Text)
        txttype.Clear()
        roomstatus.loadtbstatus(dgvshow)
        txtid.Text = roomstatus.runid
        enablesave()
        txttype.Select()
    End Sub

    Private Sub frmroomstatusgory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = roomstatus.runid
            roomstatus.loadtbstatus(dgvshow)
            enablesave()
            txttype.Select()
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
        roomstatus.delete(txtid.Text)
        txttype.ReadOnly = False
        txtid.Text = roomstatus.runid
        roomstatus.loadtbstatus(dgvshow)
        txttype.Clear()
        txttype.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txttype.Text = .CurrentRow.Cells(1).Value
                txttype.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txttype.ReadOnly = False
        txttype.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        roomstatus.update(txtid.Text, txttype.Text)
        txttype.ReadOnly = False
        txtid.Text = roomstatus.runid
        roomstatus.loadtbstatus(dgvshow)
        txttype.Clear()
        txttype.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txttype.Clear()
        txttype.ReadOnly = False
        txtid.Text = roomstatus.runid
        roomstatus.loadtbstatus(dgvshow)
        txttype.Select()
        enablesave()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class
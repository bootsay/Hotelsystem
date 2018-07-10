Public Class frmtitlename
    Dim title As New tbtitlename
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txttitlename.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txttitlename.Select()
            Return
        End If
        title.save(txtid.Text, txttitlename.Text)
        txttitlename.Clear()
        title.loadtbtitlename(dgvshow)
        txtid.Text = title.runid
        enablesave()
        txttitlename.Select()
    End Sub

    Private Sub frmtitlegory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = title.runid
            title.loadtbtitlename(dgvshow)
            enablesave()
            txttitlename.Select()
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
        title.delete(txtid.Text)
        txttitlename.ReadOnly = False
        txtid.Text = title.runid
        title.loadtbtitlename(dgvshow)
        txttitlename.Clear()
        txttitlename.Select()
        enablesave()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txttitlename.ReadOnly = False
        txttitlename.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        title.update(txtid.Text, txttitlename.Text)
        txttitlename.ReadOnly = False
        txtid.Text = title.runid
        title.loadtbtitlename(dgvshow)
        txttitlename.Clear()
        txttitlename.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txttitlename.Clear()
        txttitlename.ReadOnly = False
        txtid.Text = title.runid
        title.loadtbtitlename(dgvshow)
        txttitlename.Select()
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
                txttitlename.Text = .CurrentRow.Cells(1).Value
                txttitlename.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class
Public Class frmmainmoney
    Dim mainmoney As New tbmainmoney
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtmainmoney.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtmainmoney.Select()
            Return
        End If
        mainmoney.save(txtid.Text, txtmainmoney.Text)
        txtmainmoney.Clear()
        mainmoney.loadtbmainmoneyl(dgvshow)
        txtid.Text = mainmoney.runid
        enablesave()
        txtmainmoney.Select()
    End Sub

    Private Sub frmmainmoneygory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = mainmoney.runid
            mainmoney.loadtbmainmoneyl(dgvshow)
            enablesave()
            txtmainmoney.Select()
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
        mainmoney.delete(txtid.Text)
        txtmainmoney.ReadOnly = False
        txtid.Text = mainmoney.runid
        mainmoney.loadtbmainmoneyl(dgvshow)
        txtmainmoney.Clear()
        txtmainmoney.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txtmainmoney.Text = .CurrentRow.Cells(1).Value
                txtmainmoney.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtmainmoney.ReadOnly = False
        txtmainmoney.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        mainmoney.update(txtid.Text, txtmainmoney.Text)
        txtmainmoney.ReadOnly = False
        txtid.Text = mainmoney.runid
        mainmoney.loadtbmainmoneyl(dgvshow)
        txtmainmoney.Clear()
        txtmainmoney.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtmainmoney.Clear()
        txtmainmoney.ReadOnly = False
        txtid.Text = mainmoney.runid
        mainmoney.loadtbmainmoneyl(dgvshow)
        txtmainmoney.Select()
        enablesave()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class
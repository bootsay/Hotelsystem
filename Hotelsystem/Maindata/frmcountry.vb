Public Class frmcountry

    Dim countrys As New tbcountry
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtcountry.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtcountry.Select()
            Return
        End If
        countrys.save(txtid.Text, txtcountry.Text)
        countrys.loadtbcountry(dgvshow)
        txtcountry.Clear()
        txtid.Text = countrys.runid
        txtcountry.Select()
        enablesave()
      
    End Sub

    Private Sub frmcategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = countrys.runid
            countrys.loadtbcountry(dgvshow)
            txtcountry.Select()
            enablesave()
         
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
        countrys.delete(txtid.Text)
        txtcountry.ReadOnly = False
        txtid.Text = countrys.runid
        countrys.loadtbcountry(dgvshow)
        txtcountry.Clear()
        txtcountry.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                txtcountry.Text = .CurrentRow.Cells(1).Value
                txtcountry.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtcountry.ReadOnly = False
        txtcountry.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtcountry.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtcountry.Select()
            Return
        End If
        countrys.update(txtid.Text, txtcountry.Text)
        countrys.loadtbcountry(dgvshow)
        txtcountry.Clear()
        txtid.Text = countrys.runid
        txtcountry.Select()

        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtcountry.Clear()
        txtcountry.ReadOnly = False
        txtid.Text = countrys.runid
        countrys.loadtbcountry(dgvshow)
        txtcountry.Select()
        enablesave()
    End Sub

   

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

End Class
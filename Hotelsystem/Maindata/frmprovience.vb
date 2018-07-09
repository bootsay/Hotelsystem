Public Class frmprovience
    Dim cate As New tbprovince
    Dim countrys As New tbcountry
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtProvince.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtProvince.Select()
            Return
        End If
        cate.save(txtid.Text, cbCountry.SelectedValue, txtProvince.Text)
        txtProvince.Clear()
        cate.loadtbprovince(cbCountry.SelectedValue, dgvshow)
        txtid.Text = cate.runid

        txtProvince.Select()
        enablesave()
    End Sub

    Private Sub frmcategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Text = cate.runid
        cate.loadtbprovince(cbCountry.SelectedValue, dgvshow)
        countrys.combocountry(cbCountry)
        txtProvince.Select()
        enablesave()
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
        cate.delete(txtid.Text)
        txtProvince.ReadOnly = False
        txtid.Text = cate.runid
        cate.loadtbprovince(cbCountry.SelectedValue, dgvshow)
        txtProvince.Clear()
        txtProvince.Select()
        enablesave()
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtProvince.ReadOnly = False
        txtProvince.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        cate.update(txtid.Text, cbCountry.SelectedValue, txtProvince.Text)
        txtProvince.ReadOnly = False
        txtid.Text = cate.runid
        cate.loadtbprovince(cbCountry.SelectedValue, dgvshow)
        txtProvince.Clear()
        txtProvince.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtProvince.Clear()
        txtProvince.ReadOnly = False
        txtid.Text = cate.runid
        cate.loadtbprovince(cbCountry.SelectedValue, dgvshow)
        txtProvince.Select()
        enablesave()
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub dgvshow_CellMouseUp1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                cbCountry.Text = .CurrentRow.Cells(1).Value
                txtProvince.Text = .CurrentRow.Cells(2).Value
                txtProvince.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCountry.SelectedIndexChanged
        Try
            cate.loadtbprovince(cbCountry.SelectedValue, dgvshow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        frmcountry.ShowDialog()
    End Sub
End Class
Public Class frmvillage
    Dim village As New tbvillage
    Dim province As New tbprovince
    Dim district As New tbdistrict
    Public frmprovience1 As Boolean = False

    Public frmdistrict1 As Boolean = False
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If cbprovince.SelectedValue < 1 Then
            MessageBox.Show("ກະລຸນາເລືອກແຂວງ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cbdistrict.SelectedValue < 1 Then
            MessageBox.Show("ກະລຸນາເລືອກເມືອງ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtvillage.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtvillage.Select()
            Return
        End If

        village.save(txtid.Text, cbdistrict.SelectedValue, txtvillage.Text)
        txtvillage.Clear()
        village.loadtbvillage(dgvshow)
        txtid.Text = village.runid
        enablesave()
        txtvillage.Select()
    End Sub

    Private Sub frmvillage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Text = village.runid
        province.comboprovince(cbprovince)
        village.loadtbvillage(dgvshow)
        enablesave()
        txtvillage.Select()
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
        village.delete(txtid.Text)
        txtvillage.ReadOnly = False
        txtid.Text = village.runid
        village.loadtbvillage(dgvshow)
        txtvillage.Clear()
        txtvillage.Select()
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                district.comboboxdistrict(cbdistrict)
                txtid.Text = .CurrentRow.Cells(0).Value
                cbdistrict.Text = .CurrentRow.Cells(2).Value
                txtvillage.Text = .CurrentRow.Cells(3).Value
                cbprovince.Text = .CurrentRow.Cells(1).Value
                txtvillage.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtvillage.ReadOnly = False
        txtvillage.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        village.update(txtid.Text, cbdistrict.SelectedValue, txtvillage.Text)
        txtvillage.ReadOnly = False
        txtid.Text = province.runid
        village.loadtbvillage(dgvshow)
        txtvillage.Clear()
        txtvillage.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtvillage.Clear()
        txtvillage.ReadOnly = False
        txtid.Text = village.runid
        village.loadtbvillage(dgvshow)
        txtvillage.Select()
        enablesave()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub btnAddCountry_Click(sender As Object, e As EventArgs)
        frmcountry.Show()
    End Sub

    Private Sub cbprovince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbprovince.SelectedIndexChanged
        Try
            district.combodistrict(cbprovince.SelectedValue, cbdistrict)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        frmprovience1 = True
        frmprovience.ShowDialog()
        frmprovience.Close()
        province.comboprovince(cbprovince)
        frmprovience1 = False
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click

        frmdistrict1 = True
        frmdistrict.ShowDialog()
        frmdistrict.Close()
        province.comboprovince(cbprovince)
        frmdistrict1 = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub
End Class
Public Class frmcustomertype
    Dim customertype As New tbfcustomertype
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtcustomertype.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtcustomertype.Select()
            Return
        End If
        customertype.save(txtid.Text, txtcustomertype.Text)
        txtcustomertype.Clear()
        customertype.loadtbfcustomertype(dgvshow)
        txtid.Text = customertype.runid
        enablesave()
        txtcustomertype.Select()
    End Sub

    Private Sub frmcustomertypegory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = customertype.runid
            customertype.loadtbfcustomertype(dgvshow)
            enablesave()
            txtcustomertype.Select()
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
        customertype.delete(txtid.Text)
        txtcustomertype.ReadOnly = False
        txtid.Text = customertype.runid
        customertype.loadtbfcustomertype(dgvshow)
        txtcustomertype.Clear()
        txtcustomertype.Select()
        enablesave()
    End Sub


    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtcustomertype.ReadOnly = False
        txtcustomertype.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        customertype.update(txtid.Text, txtcustomertype.Text)
        txtcustomertype.ReadOnly = False
        txtid.Text = customertype.runid
        customertype.loadtbfcustomertype(dgvshow)
        txtcustomertype.Clear()
        txtcustomertype.Select()
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtcustomertype.Clear()
        txtcustomertype.ReadOnly = False
        txtid.Text = customertype.runid
        customertype.loadtbfcustomertype(dgvshow)
        txtcustomertype.Select()
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
                txtcustomertype.Text = .CurrentRow.Cells(1).Value
                txtcustomertype.ReadOnly = True
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class
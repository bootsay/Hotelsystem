Public Class frmcheckout
    Dim checkout As New tbfcheckout
    Dim customer As New tbcustomer
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim idno As String = checkout.runidNO
        Dim id As Integer = checkout.runid
        checkout.save(idno, id, cbcustomer.SelectedValue, Format(CDate(dtCheckout.Text), "MM/dd/yyyy"))
        checkout.loadtbfcheckout(dgvshow)
        customer.combocustomer(cbcustomer)
        txtCheckoutNO.Text = checkout.runidNO
        enablesave()
    End Sub

    Private Sub frmcheckoutgory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtCheckoutNO.Text = checkout.runidNO
            checkout.loadtbfcheckout(dgvshow)
            customer.combocustomer(cbcustomer)
            cbcustomer.Focus()
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
        checkout.delete(txtCheckoutId.Text)
        txtCheckoutNO.Text = checkout.runidNO
        checkout.loadtbfcheckout(dgvshow)
        enablesave()
    End Sub

    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                customer.combocustomer(cbcustomer)
                txtCheckoutId.Text = .CurrentRow.Cells(0).Value
                txtCheckoutNO.Text = .CurrentRow.Cells(1).Value
                cbcustomer.Text = .CurrentRow.Cells(2).Value
                dtCheckout.Text = .CurrentRow.Cells(3).Value
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        checkout.update(txtCheckoutNO.Text, txtCheckoutId.Text, cbcustomer.SelectedValue, Format(CDate(dtCheckout.Text), "MM/dd/yyyy"))
        checkout.loadtbfcheckout(dgvshow)
        customer.combocustomer(cbcustomer)
        txtCheckoutNO.Text = checkout.runidNO
        enablesave()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
     txtCheckoutNO.Text = checkout.runidNO
        enablesave()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class
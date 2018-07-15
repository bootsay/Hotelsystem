Imports System.Data.SqlClient
Public Class frmproduct
    Dim product As New tbproduct
    Dim cate As New tbcategory
    Dim unit As New tbunit
    Public frmcategory1 As Boolean = False
    Public frmunit1 As Boolean = False
    Private Sub frmproduct1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtProductNO.Text = product.runidNO
            cate.combocategory(cbcategory)
            unit.combounit(cbunit)
            product.loadtbproduct(dgvshow)
            enablesave()
            rduse.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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
    Private Sub cleartext()
        txtname.Clear()
        txtsale.Clear()
        txtbuy.Clear()
        rduse.Checked = True
    End Sub
    Private Sub disabletext()
        txtname.Enabled = False
        txtsale.Enabled = False
        txtbuy.Enabled = False
        cbcategory.Enabled = False
        cbunit.Enabled = False
        rdnouse.Enabled = False
        rduse.Enabled = False
    End Sub
    Private Sub enabletext()
        txtname.Enabled = True
        txtsale.Enabled = True
        txtbuy.Enabled = True
        cbcategory.Enabled = True
        cbunit.Enabled = True
        rdnouse.Enabled = True
        rduse.Enabled = True
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        product.delete(txtProductNO.Text)
        txtProductNO.Text = product.runidNO
        product.loadtbproduct(dgvshow)
        cleartext()
        enabletext()
        txtname.Select()
        enablesave()
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        enabletext()
        txtname.Select()
        enableupdate()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtname.Text = "" Then
            MessageBox.Show("ກາລຸນາປ້ອນຊື່ສິນຄ້າ")
            txtname.Focus()
            Return
        End If
        If txtbuy.Text = "" Then
            MessageBox.Show("ຫາລຸນາປ້ອນລາຄາຊື້")
            txtbuy.Focus()
            Return
        End If
        If txtsale.Text = "" Then
            MessageBox.Show("ຫາລຸນາປ້ອນລາຄາຂາຍ")
            txtsale.Focus()
            Return
        End If
        Dim activates As Boolean
        If rduse.Checked = True Then
            activates = True
        Else
            activates = False
        End If
        Dim idno As String = product.runidNO
        Dim id As Integer = product.runid
        Dim stockqty As Integer = 0

        product.update(txtProductNO.Text, id, cbcategory.SelectedValue, txtname.Text, cbunit.SelectedValue, txtbuy.Text, txtsale.Text, stockqty, activates)
        product.loadtbproduct(dgvshow)
        txtProductNO.Text = product.runidNO
        enablesave()
        txtname.Select()
        cleartext()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        cleartext()
        enabletext()
        txtProductNO.Text = product.runidNO
        product.loadtbproduct(dgvshow)
        txtname.Select()
        enablesave()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtname.Text = "" Then
            MessageBox.Show("ກາລຸນາປ້ອນຊື່ສິນຄ້າ")
            txtname.Focus()
            Return
        End If
        If txtbuy.Text = "" Then
            MessageBox.Show("ຫາລຸນາປ້ອນລາຄາຊື້")
            txtbuy.Focus()
            Return
        End If
        If txtsale.Text = "" Then
            MessageBox.Show("ຫາລຸນາປ້ອນລາຄາຂາຍ")
            txtsale.Focus()
            Return
        End If
        Dim activates As Boolean
        If rduse.Checked = True Then
            activates = True
        Else
            activates = False
        End If
        Dim idno As String = product.runidNO
        Dim id As Integer = product.runid
        Dim stockqty As Integer = 0
        product.save(idno, id, cbcategory.SelectedValue, txtname.Text, cbunit.SelectedValue, txtbuy.Text, txtsale.Text, stockqty, activates)
        product.loadtbproduct(dgvshow)
        txtProductNO.Text = product.runidNO
        enablesave()
        txtname.Select()
        cleartext()
    End Sub
    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                cate.combocategory(cbcategory)
                unit.combounit(cbunit)
                
                txtProductNO.Text = .CurrentRow.Cells(0).Value
                cbcategory.Text = .CurrentRow.Cells(1).Value
                txtname.Text = .CurrentRow.Cells(2).Value
                cbunit.Text = .CurrentRow.Cells(3).Value
                txtbuy.Text = .CurrentRow.Cells(4).Value
                txtsale.Text = .CurrentRow.Cells(5).Value
                '  txtNationality.Text = .CurrentRow.Cells(6).Value
                'rduse.Checked = .CurrentRow.Cells(7).Value

                If .CurrentRow.Cells(7).Value = True Then
                    rduse.Checked = True
                    'rdnouse.Checked = False
                Else

                    'rduse.Checked = False
                    rdnouse.Checked = True
                End If

                txtid.Text = .CurrentRow.Cells(8).Value
                disabletext()
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub



    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

        frmcategory1 = True
        frmcategory.ShowDialog()
        frmcategory.Close()
        cate.combocategory(cbcategory)
        frmcategory1 = False
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        frmunit1 = True
        frmunit.ShowDialog()
        frmunit.Close()
        unit.combounit(cbunit)
        frmunit1 = False
    End Sub

    Private Sub txtsale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsale.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsale_TextChanged(sender As Object, e As EventArgs) Handles txtsale.TextChanged
        Try
            Dim tem As Double = txtsale.Text
            txtsale.Text = tem.ToString("N0")
            txtsale.SelectionStart = txtsale.TextLength
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbuy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuy.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbuy_TextChanged(sender As Object, e As EventArgs) Handles txtbuy.TextChanged
        Try
            Dim tem As Double = txtbuy.Text
            txtbuy.Text = tem.ToString("N0")
            txtbuy.SelectionStart = txtbuy.TextLength
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rduse.CheckedChanged

    End Sub

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick

    End Sub
End Class
Imports System.Data.SqlClient
Public Class frmproduct
    Dim product As New tbproduct
    Dim cate As New tbcategory
    Dim unit As New tbunit
    Private Sub frmproduct1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtProductNO.Text = product.runidNO
            cate.combocategory(cbcategory)
            unit.combounit(cbunit)
            product.loadtbproduct(dgvshow)
            enablesave()

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
    End Sub
    Private Sub disabletext()
        txtname.Enabled = False
        txtsale.Enabled = False
        txtbuy.Enabled = False
        cbcategory.Enabled = False
        cbunit.Enabled = False
        chkactivate.Enabled = False
    End Sub
    Private Sub enabletext()
        txtname.Enabled = True
        txtsale.Enabled = True
        txtbuy.Enabled = True
        cbcategory.Enabled = True
        cbunit.Enabled = True
        chkactivate.Enabled = True
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        product.delete(txtid.Text)
        txtid.Text = cate.runid
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
        If chkactivate.Checked = True Then
            activates = True
        Else
            activates = False
        End If
        Dim stockqty As Integer = 0
        product.update(txtProductNO.Text, txtid.Text, cbcategory.SelectedValue, txtname.Text, cbunit.SelectedValue, txtbuy.Text, txtsale.Text, stockqty, activates)
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
        If chkactivate.Checked = True Then
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
                chkactivate.Checked = .CurrentRow.Cells(7).Value
                txtid.Text = .CurrentRow.Cells(8).Value
                disabletext()
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsubcategory_Click(sender As Object, e As EventArgs) Handles btnsubcategory.Click
        frmunit.Show()
    End Sub

    Private Sub btnaddcategory_Click(sender As Object, e As EventArgs) Handles btnaddcategory.Click
        frmcategory.Show()
    End Sub
End Class
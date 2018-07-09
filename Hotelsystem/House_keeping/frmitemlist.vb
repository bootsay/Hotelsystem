Public Class frmitemlist
    Public dt As New DataTable
    Public formstockout As Boolean
    'Dim stockout As New tbcheckout
    Public frmitemlist As Boolean = False
    Dim pro As New tbproduct
    Dim itemlist As New tbitemlist
    Dim tem_totalsale As Double
    Dim txttotalprice As New TextBox
    Dim unitname As String
    Private Sub btnbrown2_Click(sender As Object, e As EventArgs) Handles btnbrown2.Click
        frmitemlist = True
        frmshowroomlistitem.ShowDialog()
        frmshowroomlistitem.Close()
        frmitemlist = False
    End Sub

    Private Sub frmitemlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pro.loadtbproductitemlist(dgvproduct)
        itemlist.loaditemlistbyroom(dgvlist, txtroomno.Text)
        txtid.Text = itemlist.runid
        txtclear()
        txtread()
    End Sub


    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        pro.loadtbproductitemlistearch(dgvproduct, txtsearch.Text)
    End Sub


    Private Sub dgvproduct_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvproduct.CellMouseUp
        Try
            With dgvproduct
                txtproid.Text = .CurrentRow.Cells(8).Value
                txtproductname.Text = .CurrentRow.Cells(2).Value
                txtprice.Text = .CurrentRow.Cells(5).Value
                unitname = .CurrentRow.Cells(2).Value
            End With
            txtqty.Select()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtqty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqty.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    If txtroomno.Text = "" Then
        '        MessageBox.Show("ກະລຸນາເລືອກຫ້ອງຂອງລູກຄ້າ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        txtroomno.Select()
        '        Return
        '    End If
        '    If txtproductname.Text = "" Then
        '        MessageBox.Show("ກະລຸນາເລືອກສິນຄ້າທີ່ລູກຄ້າສັ່ງ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        txtproductname.Select()
        '        Return
        '    End If
        '    If txtqty.Text = "" Then
        '        txtqty.Select()
        '    End If
        '    If txtprice.Text = "" Then
        '        MessageBox.Show("ກະລຸນາໃສ່ລາຄາສິນຄ້າ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK)
        '        txtprice.Select()
        '        Return
        '    End If
        '    If txtqty.Text = "" Then
        '        MessageBox.Show("ກະລຸນາໃສ່ຈໍານວນສິນຄ້າທີ່ລູກຄ້າສັ່ງ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK)
        '        txtqty.Select()
        '        Return
        '    End If
        '    dgvlist.Rows.Add(txtproid.Text, txtproductname.Text, txtqty.Text, unitname, txttotalprice.Text)
        '    sum_datachange()
        '    txtprice.Clear()
        '    txtqty.Clear()
        '    txtproductname.Clear()
        '    txttotalprice.Clear()
        'End If
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub caculus()
        Dim price As Integer = CInt(txtprice.Text)
        Dim qty As Integer = CInt(txtqty.Text)
        Dim total As Double
        total = price * qty
        txttotalprice.Text = total.ToString("N0")
    End Sub

    Private Sub txtqty_LostFocus(sender As Object, e As EventArgs) Handles txtqty.LostFocus

    End Sub

    Private Sub txtqty_TextChanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged
        Try

            If txtqty.Text = "" Then
                txtqty.Text = 0
                txttotalprice.Text = 0
            Else

            End If

            Dim tem As Double = Val(CInt(txtqty.Text))
            txtqty.Text = tem.ToString("N0")
            txtprice.SelectionStart = txtqty.TextLength
            caculus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txttotalprice_TextChanged(sender As Object, e As EventArgs)
        Try
            Dim tem As Double = txttotalprice.Text
            txttotalprice.Text = tem.ToString("N0")
            txttotalprice.SelectionStart = txttotalprice.TextLength
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtprice_TextChanged(sender As Object, e As EventArgs) Handles txtprice.TextChanged
        Try
            Dim tem As Double = txtprice.Text
            txtprice.Text = tem.ToString("N0")
            txtprice.SelectionStart = txtprice.TextLength
        Catch ex As Exception

        End Try
    End Sub
    Private Sub enablesave()
        btnsave.Enabled = True
        btnedit.Enabled = False
        btnupdate.Enabled = False
        btnnew.Enabled = True
    End Sub
    Private Sub enableedit()
        btnsave.Enabled = False
        btnedit.Enabled = True
        btnupdate.Enabled = False
        btnnew.Enabled = True
    End Sub
    Private Sub enableupdate()
        btnsave.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = True
        btnnew.Enabled = True
    End Sub
    Private Sub txtclear()   
        'txtroomno.Clear()
        'txtroomid.Clear()
        txtproductname.Clear()
        txtprice.Clear()
        txtqty.Clear()
        txttotalprice.Clear()

        txtproid.Clear()
    End Sub
    Private Sub txtread()
        txtroomno.Enabled = False
        txtproductname.Enabled = False
        txtprice.Enabled = False
        txtqty.Enabled = False
        txttotalprice.Enabled = False
        txtdateadd.Enabled = False
        btnbrown2.Enabled = False
        'btnadd.Enabled = False
        dgvproduct.Enabled = False
    End Sub
    Private Sub txtwrite()
        txtroomno.Enabled = True
        txtproductname.Enabled = True
        txtprice.Enabled = True
        txtqty.Enabled = True
        txttotalprice.Enabled = True
        txtdateadd.Enabled = True
        btnbrown2.Enabled = True
        'btnadd.Enabled = True
        dgvproduct.Enabled = True
    End Sub
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtid.Text = itemlist.runid
        'itemlist.loaditemlist(dgvlist)
        txtclear()
        txtwrite()
        txtroomno.Clear()
        txtroomid.Clear()
        enablesave()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtid.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Select()
            Return
        End If
        itemlist.update(txtid.Text, txtroomid.Text, txtproid.Text, txtqty.Text, txtprice.Text, txttotalprice.Text, Format(CDate(txtdateadd.Text), "MM/dd/yyyy"), "ປົກກະຕິ", frmmain.userid)
        itemlist.loaditemlistbyroom(dgvlist, txtroomno.Text)
        txtclear()
        txtid.Text = itemlist.runid
        enablesave()
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtroomno.Text = "" Or txtroomid.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtroomno.Select()
            Return
        End If
        If txtproductname.Text = "" Or txtproid.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtproductname.Select()
            Return
        End If
        'If txtuser.Text = "" Then
        '    MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtuser.Select()
        '    Return
        'End If
        itemlist.save(txtid.Text, txtroomid.Text, txtproid.Text, txtqty.Text, txtprice.Text, txttotalprice.Text, Format(CDate(txtdateadd.Text), "MM/dd/yyyy"), "ປົກກະຕິ", frmmain.userid)
        'room.updateroom(txtroomid.Text, 2)
        itemlist.loaditemlistbyroom(dgvlist, txtroomno.Text)
        txtclear()
        txtid.Text = itemlist.runid
        txtid.Select()
        enablesave()
    End Sub

    Private Sub sum_datachange()
        Dim totalsale As Double
        For i As Integer = 0 To dgvlist.Rows.Count - 1
            totalsale += dgvlist.Rows(i).Cells(4).Value
        Next
        tem_totalsale = totalsale
        'txttotals.Text = totalsale.ToString("N0")
    End Sub

    'Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
    '    If txtroomno.Text = "" Then
    '        MessageBox.Show("ກະລຸນາເລືອກຫ້ອງຂອງລູກຄ້າ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        txtroomno.Select()
    '        Return
    '    End If
    '    If txtproductname.Text = "" Then
    '        MessageBox.Show("ກະລຸນາເລືອກສິນຄ້າທີ່ລູກຄ້າສັ່ງ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        txtproductname.Select()
    '        Return
    '    End If
    '    If txtqty.Text = "" Then
    '        txtqty.Select()
    '    End If
    '    If txtprice.Text = "" Then
    '        MessageBox.Show("ກະລຸນາໃສ່ລາຄາສິນຄ້າ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK)
    '        txtprice.Select()
    '        Return
    '    End If
    '    If txtqty.Text = "" Then
    '        MessageBox.Show("ກະລຸນາໃສ່ຈໍານວນສິນຄ້າທີ່ລູກຄ້າສັ່ງ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK)
    '        txtqty.Select()
    '        Return
    '    End If
    '    'For k As Integer = 0 To dgvlist.Rows.Count - 1
    '    '    If dgvlist.Rows(k).Cells(0).Value = txtproid.Text Then
    '    '        If MessageBox.Show("", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

    '    '        Else
    '    '            Exit Sub
    '    '        End If

    '    '    End If
    '    'Next
    '    itemlist.save(txtid.Text, txtroomid.Text, txtproid.Text, txtqty.Text, txtprice.Text, txttotalprice.Text, Format(CDate(txtdateadd.Text), "MM/dd/yyyy"), "ປົກກະຕິ", 1)
    '    sum_datachange()
    '    txtprice.Clear()
    '    txtqty.Clear()
    '    txtproductname.Clear()
    '    txttotalprice.Clear()
    'End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtroomno.Select()
        enableupdate()
        txtwrite()
    End Sub

    'Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs)
    '    Try
    '        Dim tem As Double = txttotals.Text
    '        txttotals.Text = tem.ToString("N0")
    '        txttotals.SelectionStart = txttotals.TextLength
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtroomno_TextChanged(sender As Object, e As EventArgs) Handles txtroomno.TextChanged
        itemlist.loaditemlistbyroom(dgvlist, txtroomno.Text)
    End Sub

    Private Sub dgvlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlist.CellContentClick

    End Sub

    Private Sub dgvlist_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvlist.CellMouseUp
        Try
            With dgvlist
                txtid.Text = .CurrentRow.Cells(0).Value
                txtroomno.Text = .CurrentRow.Cells(1).Value
                txtproductname.Text = .CurrentRow.Cells(2).Value
                txtqty.Text = .CurrentRow.Cells(3).Value
                txtprice.Text = .CurrentRow.Cells(4).Value
                txttotalprice.Text = .CurrentRow.Cells(5).Value
                txtdateadd.Text = .CurrentRow.Cells(6).Value
                txtuser.Text = .CurrentRow.Cells(8).Value
                txtroomid.Text = .CurrentRow.Cells(9).Value
                txtproid.Text = .CurrentRow.Cells(10).Value
                txtuserid.Text = .CurrentRow.Cells(11).Value

            End With
            txtqty.Select()
            enableedit()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        itemlist.delete(txtid.Text)
        txtid.Text = itemlist.runid
        itemlist.loaditemlistbyroom(dgvlist, txtroomno.Text)
        txtclear()
        txtroomno.Clear()
        txtroomid.Clear()
        enablesave()
    End Sub
End Class
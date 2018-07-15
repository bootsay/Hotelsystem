Public Class frmcheckin
    Public formcheckin As Boolean = False

    Private pCase As Integer
    Private btnSelector As New Button()
    Private rowIndex As Integer = 0
    Dim tem_totalsale As Double
    Public cus_id As String
    Public room_id As Integer
    Public mainmoney As String
    Public payname As String
    Public dt As New DataTable
    Dim cbt As Int16
    Dim dtorderdetail As New DataTable
    Dim cus As New tbcustomer
    Dim room As New tbfroom
    Dim reserve As New tbfreserve
    Dim reserveid As Integer
    Dim checkins As New tbfcheckin
    Public Customerid As String
    Dim roomratetype As New tbfroomtyperate
    Dim bookingtype As New tbfbookingtype
    Dim usetype As New tbfusetype
    Dim markettype As New tbfmarkettype
    Dim mealtype As New tbmealtype

    Private Sub btnbrown_Click(sender As Object, e As EventArgs) Handles btnbrown1.Click
        frmshowcustomer.getform = "CHIN"
        frmshowcustomer.ShowDialog()
        frmshowcustomer.Close()
        Dim customerdt As New DataTable
        customerdt.Clear()
        cus.Selectcustomer(customerdt)
        If customerdt.Rows.Count > 0 Then
            cus_id = customerdt.Rows(0).Item(0)
            txtcustomername.Text = customerdt.Rows(0).Item(4)
            txtprice.Text = customerdt.Rows(0).Item(15)
            txtcustomertype.Text = customerdt.Rows(0).Item(2)
        Else

        End If

        frmshowcustomer.getform = ""
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles btnbrown2.Click
        frmshowroomlistitem.getformname = "CHIN"
        frmshowroomlistitem.ShowDialog()
        frmshowroomlistitem.Close()
        frmshowroomlistitem.getformname = ""
    End Sub

    Private Sub btncustomer_Click(sender As Object, e As EventArgs) Handles btncus.Click
        formcheckin = True
        frmcustomer.ShowDialog()
        frmcustomer.Close()
        Dim customerdt As New DataTable
        customerdt.Clear()
        cus.Selectcustomer(customerdt)
        If customerdt.Rows.Count > 0 Then
            cus_id = customerdt.Rows(0).Item(0)
            txtcustomername.Text = customerdt.Rows(0).Item(4)
            txtprice.Text = customerdt.Rows(0).Item(15)
            txtcustomertype.Text = customerdt.Rows(0).Item(2)
        Else

        End If

        formcheckin = False
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs)
        formcheckin = True
        frmroom.ShowDialog()
        frmroom.Close()
        Dim roomdt As New DataTable
        roomdt.Clear()
        room.Selectroom(roomdt)
        If roomdt.Rows.Count > 0 Then
            room_id = roomdt.Rows(0).Item(0)
            txtroomno.Text = roomdt.Rows(0).Item(4)
        Else

        End If
        formcheckin = False
    End Sub

    Private Sub frmcreatereserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuser.Text = frmmain.laoname
        bookingtype.combobookingtype(cbbooktype)
        dtsearch1.Text = Today.Date
        dtsearch2.Text = Today.Date
        usetype.combousetype(cbstaytype)
        mealtype.combomealtype(cbfood)

        formdisable()
        btnnew.Enabled = True
        btnsave.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = False





    End Sub

    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtprice_TextChanged(sender As Object, e As EventArgs) Handles txtprice.TextChanged
        Try
            Dim tem As Double = txtprice.Text
            txtprice.Text = tem.ToString("N0")
            txtprice.SelectionStart = txtprice.TextLength
        Catch ex As Exception

        End Try
    End Sub

    Public Sub enablesave()
        btnsave.Enabled = True
        btnedit.Enabled = False
        btnupdate.Enabled = False
        btnnew.Enabled = True
    End Sub
    Public Sub enableedit()
        btnsave.Enabled = False
        btnedit.Enabled = True
        btnupdate.Enabled = False
        btnnew.Enabled = True
    End Sub
    Public Sub enableupdate()
        btnsave.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = True
        btnnew.Enabled = True
    End Sub
    Public Sub txtclear()
        'txtid.Clear()
        txtuser.Text = 1
        txtprice.Clear()
        txtNote.Clear()

        txtcustomername.Clear()
        txtroomno.Clear()
    End Sub
  
    Public Sub formdisable()
        btnbrown2.Enabled = False
        btnbrown1.Enabled = False
        cbbooktype.Enabled = False
        'txtprice.Enabled = False
        cbmarket.Enabled = False
        cbpricetype.Enabled = False
        cbfood.Enabled = False
        txtNote.Enabled = False
        dt1.Enabled = False
        dt2.Enabled = False
        btncus.Enabled = False
        cbstaytype.Enabled = False
    End Sub
    Public Function formenable()
        btnbrown2.Enabled = True
        btnbrown1.Enabled = True
        cbbooktype.Enabled = True
        'txtprice.Enabled = True
        cbmarket.Enabled = True
        cbpricetype.Enabled = True
        cbfood.Enabled = True
        txtNote.Enabled = True
        dt1.Enabled = True
        dt2.Enabled = True
        btncus.Enabled = True
        cbstaytype.Enabled = True
    End Function
  
    Private Sub txtnumberpeople_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs)
        txtid.ReadOnly = False
        txtid.Select()
        enableupdate()
        formenable()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs)
        If txtid.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Select()
            Return
        End If
        'reserve.update(txtid.Text, reserveid, txtcusid.Text, txtroomid.Text, Format(CDate(txtdatereserve.Text), "MM/dd/yyyy"), Format(CDate(txtdatecheckin.Text), "MM/dd/yyyy"), Format(CDate(txtdatecheckout.Text), "MM/dd/yyyy"), txtnumberpeople.Text, txtNote.Text, "ປົກກະຕິ", 1, "NO")
        'room.updateroom(txtroomid.Text, 2)
        checkins.loadtbfcheckin(dgvlist)
        txtid.Text = reserve.runidNO
        reserveid = reserve.runid
        enablesave()
        txtclear()
    End Sub



    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If rddate.Checked = True Then
                    dgvlist.DataSource = Nothing
                    checkins.search_checkinby_datein(Format(CDate(dtsearch1.Text), "MM/dd/yyyy'"), Format(CDate(dtsearch2.Text), "MM/dd/yyyy'"), dgvlist)
                ElseIf rdname.Checked = True Then
                    dgvlist.DataSource = Nothing
                    checkins.search_checkinby_Name(txtsearch.Text, dgvlist)
                ElseIf rdroomnumber.Checked = True Then
                    dgvlist.DataSource = Nothing
                    checkins.search_checkinby_roomNO(txtsearch.Text, dgvlist)
                ElseIf rdIDcard.Checked = True Then
                    dgvlist.DataSource = Nothing
                    checkins.search_checkinby_IDCard(txtsearch.Text, dgvlist)
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)
        Try
            If txtsearch.Text = "" Then
                reserve.loadtbfreserve(dgvlist)
            Else
                reserve.loadtbfreserveSearchbyidorname(dgvlist, txtsearch.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtnumberpeople_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub rddate_CheckedChanged(sender As Object, e As EventArgs) Handles rddate.CheckedChanged
        If rddate.Checked = True Then
            txtsearch.Visible = False
            dtsearch1.Visible = True
            dtsearch2.Visible = True
        Else
            txtsearch.Visible = True
            dtsearch1.Visible = False
            dtsearch2.Visible = False
        End If
    End Sub

    Private Sub rdname_CheckedChanged(sender As Object, e As EventArgs) Handles rdname.CheckedChanged
        If rddate.Checked = True Then
            txtsearch.Visible = False
            dtsearch1.Visible = True
            dtsearch2.Visible = True
        Else
            txtsearch.Visible = True
            dtsearch1.Visible = False
            dtsearch2.Visible = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdIDcard.CheckedChanged
        If rddate.Checked = True Then
            txtsearch.Visible = False
            dtsearch1.Visible = True
            dtsearch2.Visible = True
        Else
            txtsearch.Visible = True
            dtsearch1.Visible = False
            dtsearch2.Visible = False
        End If
    End Sub

    Private Sub rdroomnumber_CheckedChanged(sender As Object, e As EventArgs) Handles rdroomnumber.CheckedChanged
        If rddate.Checked = True Then
            txtsearch.Visible = False
            dtsearch1.Visible = True
            dtsearch2.Visible = True
        Else
            txtsearch.Visible = True
            dtsearch1.Visible = False
            dtsearch2.Visible = False
        End If
    End Sub

    Private Sub btnsearchreserve_Click(sender As Object, e As EventArgs) Handles btnsearchreserve.Click
        Dim dtreserve As New DataTable
        markettype.combomarkettype(cbmarket)
        roomratetype.comboroomtyperate(cbpricetype)
        checkins.selectReserveNO(txtreserverNO_search.Text, dtreserve)
        If dtreserve.Rows.Count > 0 Then
            txtroomno.Text = dtreserve.Rows(0).Item(17)
            txtcustomername.Text = dtreserve.Rows(0).Item(3)
            txtcustomertype.Text = dtreserve.Rows(0).Item(1)
            cbpricetype.Text = dtreserve.Rows(0).Item(31)
            txtprice.Text = dtreserve.Rows(0).Item(29)
            txtnumberpeople.Text = dtreserve.Rows(0).Item(22)
            dt1.Text = dtreserve.Rows(0).Item(20)
            dt2.Text = dtreserve.Rows(0).Item(21)

        Else
            MessageBox.Show("ບໍ່ມີລະຫັັດນີ້", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtreserverNO_search.Clear()
            txtreserverNO_search.Select()
        End If
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click

        dt1.Text = Today.Date
        dt2.Text = Today.Date
        rddate.Checked = True
        If rddate.Checked = True Then
            txtsearch.Visible = False
            dtsearch1.Visible = True
            dtsearch2.Visible = True
        Else
            txtsearch.Visible = True
            dtsearch1.Visible = False
            dtsearch2.Visible = False
        End If
        checkins.search_checkinby_datein(Format(CDate(dtsearch1.Text), "MM/dd/yyyy"), Format(CDate(dtsearch2.Text), "MM/dd/yyyy"), dgvlist)
        formenable()
        markettype.combomarkettype(cbmarket)
        roomratetype.comboroomtyperate(cbpricetype)
        txtid.Text = checkins.runidNO

        formenable()
        txtclear()
        enablesave()
    End Sub

  
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim frm As frmmain = DirectCast(Application.OpenForms("frmmain"), frmmain)
        If txtcustomername.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtcustomername.Select()
            Return
        End If
        If txtnumberpeople.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtnumberpeople.Select()
            Return
        End If
        If txtroomno.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtroomno.Select()
            Return
        End If

        Dim checkno As String = checkins.runidNO
        Dim checkid As Integer = checkins.runid
        If txtreserverNO_search.Text = "" Then
            txtreserverNO_search.Text = "0"
        End If

        checkins.save(checkno, checkid, frm.userid, txtreserverNO_search.Text, room_id, Customerid, cbbooktype.SelectedValue, cbmarket.SelectedValue, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"), txtnumberpeople.Text, cbfood.SelectedValue, cbstaytype.SelectedValue, txtNote.Text, 6, txtprice.Text)
        checkins.search_checkinby_datein(Format(CDate(dtsearch1.Text), "MM/dd/yyyy"), Format(CDate(dtsearch2.Text), "MM/dd/yyyy"), dgvlist)
        room.updateroom(room_id, 6)
        reserve.loadtbfreserve(dgvlist)
        txtclear()
        txtid.Text = reserve.runidNO
        txtid.Select()
        enablesave()
    End Sub
  
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If rddate.Checked = True Then
            dgvlist.DataSource = Nothing
            checkins.search_checkinby_datein(Format(CDate(dtsearch1.Text), "MM/dd/yyyy"), Format(CDate(dtsearch2.Text), "MM/dd/yyyy"), dgvlist)
        ElseIf rdname.Checked = True Then
            dgvlist.DataSource = Nothing
            checkins.search_checkinby_Name(txtsearch.Text, dgvlist)
        ElseIf rdroomnumber.Checked = True Then
            dgvlist.DataSource = Nothing
            checkins.search_checkinby_roomNO(txtsearch.Text, dgvlist)
        ElseIf rdIDcard.Checked = True Then
            dgvlist.DataSource = Nothing
            checkins.search_checkinby_IDCard(txtsearch.Text, dgvlist)
        End If
    End Sub

    Private Sub dgvlist_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvlist.CellMouseUp
        Try
            With dgvlist
                txtid.Text = .CurrentRow.Cells(0).Value
                txtuser.Text = .CurrentRow.Cells(2).Value
                If .CurrentRow.Cells(1).Value Is DBNull.Value Then
                    txtreserveNO.Text = ""
                Else
                    txtreserveNO.Text = .CurrentRow.Cells(1).Value
                End If

                dt1.Text = .CurrentRow.Cells(24).Value
                dt2.Text = .CurrentRow.Cells(25).Value
                txtroomno.Text = .CurrentRow.Cells(5).Value
                txtcustomername.Text = .CurrentRow.Cells(10).Value
                txtcustomertype.Text = .CurrentRow.Cells(8).Value
                cbpricetype.Text = .CurrentRow.Cells(6).Value
                txtprice.Text = .CurrentRow.Cells(7).Value
                cbbooktype.Text = .CurrentRow.Cells(22).Value
                cbmarket.Text = .CurrentRow.Cells(23).Value
                cbfood.Text = .CurrentRow.Cells(27).Value
                txtnumberpeople.Text = .CurrentRow.Cells(26).Value
                cbstaytype.Text = .CurrentRow.Cells(28).Value
                txtNote.Text = .CurrentRow.Cells(29).Value

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnreservelist_Click(sender As Object, e As EventArgs) Handles btnreservelist.Click
        frmshowreserve.ShowDialog()
        frmshowreserve.Close()
        Dim dtreserve As New DataTable
        markettype.combomarkettype(cbmarket)
        roomratetype.comboroomtyperate(cbpricetype)
        checkins.selectReserveNO(txtreserverNO_search.Text, dtreserve)
        If dtreserve.Rows.Count > 0 Then
            txtroomno.Text = dtreserve.Rows(0).Item(17)
            txtcustomername.Text = dtreserve.Rows(0).Item(3)
            txtcustomertype.Text = dtreserve.Rows(0).Item(1)
            cbpricetype.Text = dtreserve.Rows(0).Item(31)
            txtprice.Text = dtreserve.Rows(0).Item(29)
            txtnumberpeople.Text = dtreserve.Rows(0).Item(22)
            dt1.Text = dtreserve.Rows(0).Item(20)
            dt2.Text = dtreserve.Rows(0).Item(21)
        Else
        End If

    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        If dgvlist.SelectedCells.Count < 0 Then

        Else
            frmBillcheckin.ShowDialog()
            frmBillcheckin.Close()
        End If
    End Sub
End Class
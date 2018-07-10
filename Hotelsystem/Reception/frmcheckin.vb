﻿Public Class frmcheckin
    Public frmcreatereserve As Boolean = False
    Dim markettype As New tbfmarkettype
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
    Private Sub btnbrown_Click(sender As Object, e As EventArgs) Handles btnbrown1.Click
        frmcreatereserve = True
        frmshowcustomer.ShowDialog()
        frmshowcustomer.Close()
        frmcreatereserve = False
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles btnbrown2.Click

        frmcreatereserve = True
        frmshowroomlistitem.ShowDialog()
        frmshowroomlistitem.Close()
        frmcreatereserve = False
    End Sub

    Private Sub btncustomer_Click(sender As Object, e As EventArgs) Handles btncus.Click
        frmcreatereserve = True
        frmcustomer.ShowDialog()
        frmcustomer.Close()
        Dim customerdt As New DataTable
        customerdt.Clear()
        cus.Selectcustomer(customerdt)
        If customerdt.Rows.Count > 0 Then
            cus_id = customerdt.Rows(0).Item(0)
            txtcustomername.Text = customerdt.Rows(0).Item(4)
            txtprice.Text = customerdt.Rows(0).Item(15)
        Else

        End If

        frmcreatereserve = False
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs)
        frmcreatereserve = True
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
        frmcreatereserve = False
    End Sub

    Private Sub frmcreatereserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'txtid.Clear()
        txtuser.Text = 1
        txtprice.Clear()
        txtNote.Clear()

        txtcustomername.Clear()
        txtroomno.Clear()
    End Sub
    Private Sub txtread()
        'txtid.Clear()
        txtuser.Enabled = False
        txtprice.Enabled = False
        txtNote.Enabled = False
        txtnumberpeople.Enabled = False
        txtcustomername.Enabled = False
        txtroomno.Enabled = False
        'txtdatereserve.Enabled = False
    
        btnbrown1.Enabled = False
        btnbrown2.Enabled = False
        btncus.Enabled = False

    End Sub
    Private Sub txtwrite()
        'txtid.Clear()
        'txtuser.Enabled = True
        txtprice.Enabled = False
        txtNote.Enabled = True
        txtnumberpeople.Enabled = True
        txtcustomername.Enabled = True
        txtroomno.Enabled = True
        'txtdatereserve.Enabled = True
    
        btnbrown1.Enabled = True
        btnbrown2.Enabled = True
        btncus.Enabled = True

    End Sub
    Private Sub txtnumberpeople_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs)
        txtid.ReadOnly = False
        txtid.Select()
        enableupdate()
        txtwrite()
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
                If txtsearch.Text = "" Then
                    reserve.loadtbfreserve(dgvlist)
                Else
                    reserve.loadtbfreserveSearch(dgvlist, txtsearch.Text)
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
                reserve.loadtbfreserveSearch(dgvlist, txtsearch.Text)
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

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
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
        checkins.loadtbfcheckin(dgvlist)
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
        markettype.combomarkettype(cbmarket)
        roomratetype.comboroomtyperate(cbpricetype)
        txtid.Text = checkins.runidNO
        enablesave()
        txtwrite()
    End Sub

  
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
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
        'checkins.save(checkno, checkid, txtreserverNO_search.Text, 1, Customerid, )
        'room.updateroom(txtroomid.Text, 2)
        reserve.loadtbfreserve(dgvlist)
        txtclear()
        txtid.Text = reserve.runidNO
        txtid.Select()
        enablesave()
    End Sub
  
End Class
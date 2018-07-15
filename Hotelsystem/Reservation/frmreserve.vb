﻿Public Class frmreserve
    Public frmcreatereserve As Boolean = False
    Private pCase As Integer
    Private btnSelector As New Button()
    Private rowIndex As Integer = 0
    Dim tem_totalsale As Double
    Public cus_id As String
    Public room_id As Integer
    'Dim frmmain As frmmain = CType(Application.OpenForms("frmmain"), frmmain)
    Public mainmoney As String
    Public payname As String
    Public dt As New DataTable
    Dim cbt As Int16
    Dim dtorderdetail As New DataTable
    Dim cus As New tbcustomer
    Dim room As New tbfroom
    Dim reserve As New tbfreserve
    Dim reserveid As Integer
    Public frmroom1 As Boolean = False
    Private Sub btnbrown_Click(sender As Object, e As EventArgs) Handles btnbrown1.Click
        frmcreatereserve = True
        frmshowcustomer.ShowDialog()
        frmshowcustomer.Close()
        frmcreatereserve = False
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles btnbrown2.Click

        frmcreatereserve = True
        frmshowroomreserve.ShowDialog()
        frmshowroomreserve.Close()
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
        reserve.loadtbfreserve(dgvlist)
        txtid.Text = reserve.runidNO
        enableedit()
        txtread()
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
        'txtnumberpeople.Clear()
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
        txtdatereserve.Enabled = False
        txtdatecheckin.Enabled = False
        txtdatecheckout.Enabled = False
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
        txtdatereserve.Enabled = True
        txtdatecheckin.Enabled = True
        txtdatecheckout.Enabled = True
        btnbrown1.Enabled = True
        btnbrown2.Enabled = True
        btncus.Enabled = True

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtid.Text = reserve.runidNO
        reserveid = reserve.runid
        txtclear()
        enablesave()
        txtwrite()
    End Sub

    Private Sub txtnumberpeople_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
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


        reserve.save(txtid.Text, reserveid, txtcustomerid.Text, txtroomid.Text, Format(CDate(txtdatereserve.Text), "MM/dd/yyyy"), Format(CDate(txtdatecheckin.Text), "MM/dd/yyyy"), Format(CDate(txtdatecheckout.Text), "MM/dd/yyyy"), txtnumberpeople.Text, txtNote.Text, 2, frmmain.userid)
        room.updateroom(txtroomid.Text, 2)
        reserve.loadtbfreserve(dgvlist)
        txtclear()
        txtid.Text = reserve.runidNO
        txtid.Select()
        enablesave()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtid.ReadOnly = False
        txtid.Select()
        enableupdate()
        txtwrite()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtid.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Select()
            Return
        End If
        reserve.update(txtid.Text, reserveid, txtcustomerid.Text, txtroomid.Text, Format(CDate(txtdatereserve.Text), "MM/dd/yyyy"), Format(CDate(txtdatecheckin.Text), "MM/dd/yyyy"), Format(CDate(txtdatecheckout.Text), "MM/dd/yyyy"), txtnumberpeople.Text, txtNote.Text, 2, frmmain.userid)
        room.updateroom(txtroomid.Text, 2)
        reserve.loadtbfreserve(dgvlist)
        txtid.Text = reserve.runidNO
        reserveid = reserve.runid
        enablesave()
        txtclear()
    End Sub

    Private Sub dgvlist_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvlist.CellMouseUp
        Try
            With dgvlist
                txtid.Text = .CurrentRow.Cells(0).Value
                txtcustomername.Text = .CurrentRow.Cells(3).Value
                txtroomno.Text = .CurrentRow.Cells(17).Value
                txtdatereserve.Text = .CurrentRow.Cells(19).Value
                txtdatecheckin.Text = .CurrentRow.Cells(20).Value
                txtdatecheckout.Text = .CurrentRow.Cells(21).Value
                txtnumberpeople.Text = .CurrentRow.Cells(22).Value
                txtNote.Text = .CurrentRow.Cells(23).Value
                txtuser.Text = .CurrentRow.Cells(24).Value
                txtcustomerid.Text = .CurrentRow.Cells(26).Value
                'statusname.Text = .CurrentRow.Cells(25).Value
                txtuserid.Text = .CurrentRow.Cells(27).Value
                txtroomid.Text = .CurrentRow.Cells(28).Value
                txtprice.Text = .CurrentRow.Cells(29).Value
                'statusid.Text = .CurrentRow.Cells(30).Value
            End With

            enableedit()
            btnedit.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                If txtsearch.Text = "" Then
                    reserve.loadtbfreserve(dgvlist)
                Else
                    reserve.loadtbfreserveSearchbyidorname(dgvlist, txtsearch.Text)
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            If rdreserve.Checked = True Or rdname.Checked = True Then
                If txtsearch.Text = "" Then
                    reserve.loadtbfreserve(dgvlist)
                Else
                    reserve.loadtbfreserveSearchbyidorname(dgvlist, txtsearch.Text)
                End If
            ElseIf rddate.Checked = True Then
             cbroom.Text = "%"
                reserve.loadtbfreserveSearchbydate(dgvlist, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"))
            Else
                txtsearch.Text = "%"
                reserve.loadtbfreserveSearchbyroom(dgvlist, cbroom.SelectedValue)
            End If
       
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlist.CellContentClick

    End Sub

   
    Private Sub txtserchroom_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtserchroom_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtsearch_KeyDown1(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If rdname.Checked = True Or rdreserve.Checked = True Then
                    cbroom.Text = "%"
                    reserve.loadtbfreserveSearchbyidorname(dgvlist, txtsearch.Text)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dt2_ValueChanged(sender As Object, e As EventArgs) Handles dt2.ValueChanged
        Try
            If rddate.Checked = True Then
                cbroom.Text = "%"
                reserve.loadtbfreserveSearchbydate(dgvlist, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged
        Try
            If rddate.Checked = True Then
                cbroom.Text = "%"
                reserve.loadtbfreserveSearchbydate(dgvlist, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbroom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbroom.SelectedIndexChanged

    End Sub

    Private Sub cbroom_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbroom.SelectionChangeCommitted
        Try
            If rdroom.Checked = True Then
                cbroom.Text = "%"
                reserve.loadtbfreserveSearchbydate(dgvlist, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdreserve_CheckedChanged(sender As Object, e As EventArgs) Handles rdreserve.CheckedChanged
        If rdreserve.Checked = True Then
            txtsearch.Visible = True
            cbroom.Visible = False
            dt1.Visible = False
            dt11.Visible = False
            dt2.Visible = False
        Else
            txtsearch.Visible = True
            cbroom.Visible = False
            dt1.Visible = False
            dt11.Visible = False
            dt2.Visible = False
        End If
    End Sub

    Private Sub rdname_CheckedChanged(sender As Object, e As EventArgs) Handles rdname.CheckedChanged
        If rdname.Checked = True Then
            txtsearch.Visible = True
            cbroom.Visible = False
            dt1.Visible = False
            dt11.Visible = False
            dt2.Visible = False
        Else
            txtsearch.Visible = True
            cbroom.Visible = False
            dt1.Visible = False
            dt11.Visible = False
            dt2.Visible = False
        End If
    End Sub

    Private Sub rddate_CheckedChanged(sender As Object, e As EventArgs) Handles rddate.CheckedChanged
        If rddate.Checked = True Then
            txtsearch.Visible = False
            cbroom.Visible = False
            dt1.Visible = True
            dt11.Visible = True
            dt2.Visible = True
        Else
            txtsearch.Visible = True
            cbroom.Visible = False
            dt1.Visible = False
            dt11.Visible = False
            dt2.Visible = False
        End If
    End Sub

    Private Sub rdroom_CheckedChanged(sender As Object, e As EventArgs) Handles rdroom.CheckedChanged
        If rdroom.Checked = True Then
            txtsearch.Visible = False
            cbroom.Visible = True
            dt1.Visible = False
            dt11.Visible = False
            dt2.Visible = False
        Else
            txtsearch.Visible = True
            cbroom.Visible = False
            dt1.Visible = False
            dt11.Visible = False
            dt2.Visible = False
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        If dgvlist.SelectedCells.Count > 0 Then
            frmBillreserve.ShowDialog()
            frmBillreserve.Close()
        Else

        End If
    End Sub
End Class
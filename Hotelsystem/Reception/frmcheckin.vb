Public Class frmcheckin
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

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles btnroom.Click
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
        txtnumberpeople.Clear()
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
        txtdatecheckin.Enabled = False
        txtdatecheckout.Enabled = False
        btnbrown1.Enabled = False
        btnbrown2.Enabled = False
        btncus.Enabled = False
        btnroom.Enabled = False
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
        txtdatecheckin.Enabled = True
        txtdatecheckout.Enabled = True
        btnbrown1.Enabled = True
        btnbrown2.Enabled = True
        btncus.Enabled = True
        btnroom.Enabled = True
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtid.Text = reserve.runidNO
        reserveid = reserve.runid
        txtclear()
        enablesave()
        txtwrite()
    End Sub

    Private Sub txtnumberpeople_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumberpeople.KeyPress
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


        'reserve.save(txtid.Text, reserveid, txtcusid.Text, txtroomid.Text, Format(CDate(txtdatereserve.Text), "MM/dd/yyyy"), Format(CDate(txtdatecheckin.Text), "MM/dd/yyyy"), Format(CDate(txtdatecheckout.Text), "MM/dd/yyyy"), txtnumberpeople.Text, txtNote.Text, "ປົກກະຕິ", 1, "NO")
        'room.updateroom(txtroomid.Text, 2)
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
        'reserve.update(txtid.Text, reserveid, txtcusid.Text, txtroomid.Text, Format(CDate(txtdatereserve.Text), "MM/dd/yyyy"), Format(CDate(txtdatecheckin.Text), "MM/dd/yyyy"), Format(CDate(txtdatecheckout.Text), "MM/dd/yyyy"), txtnumberpeople.Text, txtNote.Text, "ປົກກະຕິ", 1, "NO")
        'room.updateroom(txtroomid.Text, 2)
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
                txtroomno.Text = .CurrentRow.Cells(6).Value
                'txtdatereserve.Text = .CurrentRow.Cells(19).Value
                txtdatecheckin.Text = .CurrentRow.Cells(20).Value
                txtdatecheckout.Text = .CurrentRow.Cells(21).Value
                txtnumberpeople.Text = .CurrentRow.Cells(22).Value
                txtNote.Text = .CurrentRow.Cells(23).Value
                txtuser.Text = .CurrentRow.Cells(24).Value
                'txtcusid.Text = .CurrentRow.Cells(27).Value
                'txtroomid.Text = .CurrentRow.Cells(28).Value
                txtprice.Text = .CurrentRow.Cells(29).Value
                enableedit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

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


    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
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

    Private Sub txtnumberpeople_TextChanged(sender As Object, e As EventArgs) Handles txtnumberpeople.TextChanged

    End Sub
End Class
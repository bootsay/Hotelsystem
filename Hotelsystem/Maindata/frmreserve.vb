Imports System.Data.SqlClient
Public Class frmreserve
    Dim reserve As New tbfreserve
    Dim customer As New tbcustomer
    Dim room As New tbfroom
    Private Sub frmbusinessvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtreserveNO.Text = reserve.runidNO
        reserve.loadtbfreserve(dgvshow)
        customer.combocustomer(cbcustomer)
        room.comboroom(cbroom)
        txtRemark.Select()
        enablesave()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If txtRemark.Text = "" Then
                MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ")
                txtRemark.Focus()
                Return
            End If
            If txtnumberofpax.Text = "" Then
                MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ")
                txtnumberofpax.Focus()
                Return
            End If
            Dim idno As String = reserve.runidNO
            Dim id As Integer = reserve.runid
            reserve.save(idno, id, cbcustomer.SelectedValue, cbroom.SelectedValue, Format(CDate(dtDateReserve.Text), "MM/dd/yyyy"), Format(CDate(dtDateCheckin.Text), "MM/dd/yyyy"), Format(CDate(dtDateCheckout.Text), "MM/dd/yyyy"), txtnumberofpax.Text, txtRemark.Text)
            reserve.loadtbfreserve(dgvshow)
            customer.combocustomer(cbcustomer)
            room.comboroom(cbroom)
            enablesave()
            txtRemark.Clear()
            txtnumberofpax.Clear()
            txtnumberofpax.Select()
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
        'btnnew.Enabled = True
        'txtbsnnid.Enabled = False
        'txtbsnnamelao.Enabled = True
        'txtbsnnameenglish.Enabled = True
        'txtaddress.Enabled = True
        'txttel.Enabled = True
        'txtemail.Enabled = True
    End Sub
    Private Sub enableupdate()
        btnsave.Enabled = False
        btndelete.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = True
        'btnnew.Enabled = True
    End Sub
    Private Sub disabletext()
        cbcustomer.Enabled = False
        cbroom.Enabled = False
        dtDateReserve.Enabled = False
        dtDateCheckin.Enabled = False
        dtDateCheckout.Enabled = False
        txtnumberofpax.Enabled = False
        txtRemark.Enabled = False
    End Sub
    Private Sub enabletext()
        cbcustomer.Enabled = True
        cbroom.Enabled = True
        dtDateReserve.Enabled = True
        dtDateCheckin.Enabled = True
        dtDateCheckout.Enabled = True
        txtnumberofpax.Enabled = True
        txtRemark.Enabled = True
    End Sub
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        reserve.delete(txtReserveId.Text)
        txtreserveNO.Text = reserve.runidNO
        reserve.loadtbfreserve(dgvshow)
        txtnumberofpax.Select()
        enablesave()
        txtnumberofpax.Clear()
        txtRemark.Clear()
        btnsave.Enabled = False

    End Sub
    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                customer.combocustomer(cbcustomer)
                room.comboroom(cbroom)
                txtReserveId.Text = .CurrentRow.Cells(0).Value
                txtreserveNO.Text = .CurrentRow.Cells(1).Value
                cbcustomer.Text = .CurrentRow.Cells(2).Value
                cbroom.Text = .CurrentRow.Cells(3).Value
                dtDateReserve.Text = .CurrentRow.Cells(4).Value
                dtDateCheckin.Text = .CurrentRow.Cells(5).Value
                dtDateCheckout.Text = .CurrentRow.Cells(6).Value
                txtnumberofpax.Text = .CurrentRow.Cells(7).Value
                txtRemark.Text = .CurrentRow.Cells(8).Value
                enablesave()
                disabletext()
                btnedit.Enabled = True
                btndelete.Enabled = True
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtnumberofpax.Select()
        enableupdate()
        enableedit()
        enabletext()
        btnupdate.Enabled = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        reserve.update(txtreserveNO.Text, txtReserveId.Text, cbcustomer.SelectedValue, cbroom.SelectedValue, Format(CDate(dtDateReserve.Text), "MM/dd/yyyy"), Format(CDate(dtDateCheckin.Text), "MM/dd/yyyy"), Format(CDate(dtDateCheckout.Text), "MM/dd/yyyy"), txtnumberofpax.Text, txtRemark.Text)
        reserve.loadtbfreserve(dgvshow)
        customer.combocustomer(cbcustomer)
        room.comboroom(cbroom)
        enablesave()
        txtRemark.Clear()
        txtnumberofpax.Clear()
        txtnumberofpax.Select()
        txtreserveNO.Text = reserve.runidNO
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        frmroom.Show()
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        frmcustomer.Show()
    End Sub

    Private Sub btnnew_Click_1(sender As Object, e As EventArgs) Handles btnnew.Click
        txtreserveNO.Text = reserve.runidNO
        txtnumberofpax.Clear()
        txtRemark.Clear()
        txtnumberofpax.Select()
        reserve.loadtbfreserve(dgvshow)
        customer.combocustomer(cbcustomer)
        room.comboroom(cbroom)
        room.comboroom(cbroom)
        enablesave()
        enabletext()
    End Sub
End Class
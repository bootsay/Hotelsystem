Imports System.Data.SqlClient
Public Class frmcheckin
    Dim checkin As New tbfcheckin
    Dim user As New tbuser
    Dim customer As New tbcustomer
    Dim bookingtype As New tbfbookingtype
    Dim status As New tbstatusall
    Dim markettype As New tbfmarkettype
    Dim mealtype As New tbmealtype
    Dim usetype As New tbfusetype
    Dim room As New tbfroom
    Private Sub frmproduct1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtCheckinNO.Text = checkin.runidNO
            loadcombo()
            checkin.loadtbfcheckin(dgvshow)
            enablesave()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub loadcombo()
        customer.combocustomer(cbCustomerNO)
        bookingtype.combobookingtype(cbBookingType)
        status.combostatus(cbstatus)
        markettype.combomarkettype(cbMarketType)
        mealtype.combomealtype(cbMealType)
        usetype.combousetype(cbUseType)
        room.comboroom(cbroom)
    End Sub
    Private Sub enablesave()
        btnsave4.Enabled = True
        btndelete4.Enabled = False
        btnedit4.Enabled = False
        btnupdate4.Enabled = False
        btnnew4.Enabled = True
    End Sub
    Private Sub enableedit()
        btnsave4.Enabled = False
        btndelete4.Enabled = True
        btnedit4.Enabled = True
        btnupdate4.Enabled = False
        btnnew4.Enabled = True
    End Sub
    Private Sub enableupdate()
        btnsave4.Enabled = False
        btndelete4.Enabled = False
        btnedit4.Enabled = False
        btnupdate4.Enabled = True
        btnnew4.Enabled = True
    End Sub
    Private Sub enabletext()
        cbroom.Enabled = True
        cbCustomerNO.Enabled = True
        cbBookingType.Enabled = True
        cbMarketType.Enabled = True
        dtDateCheckin.Enabled = True
        dtDateCheckout.Enabled = True
        txtnumberofpax.Enabled = True
        cbMealType.Enabled = True
        cbUseType.Enabled = True
        txtremark.Enabled = True
        cbstatus.Enabled = True
    End Sub
    Private Sub disabletext()
        cbroom.Enabled = False
        cbCustomerNO.Enabled = False
        cbBookingType.Enabled = False
        cbMarketType.Enabled = False
        dtDateCheckin.Enabled = False
        dtDateCheckout.Enabled = False
        txtnumberofpax.Enabled = False
        cbMealType.Enabled = False
        cbUseType.Enabled = False
        txtremark.Enabled = False
        cbstatus.Enabled = False
    End Sub
    Private Sub btnsave4_Click(sender As Object, e As EventArgs) Handles btnsave4.Click
        Try
            If txtnumberofpax.Text = "" Then
                MessageBox.Show("ກະລຸນາໃສ່ຈຳນວນຄົນ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtnumberofpax.Select()
                Return
            End If
            Dim username As String = "1"
            Dim idno As String = checkin.runidNO
            Dim id As Integer = checkin.runid
            checkin.save(idno, id, username, cbroom.SelectedValue, cbCustomerNO.SelectedValue, cbBookingType.SelectedValue, cbMarketType.SelectedValue, Format(CDate(dtDateCheckin.Text), "MM/dd/yyyy"), Format(CDate(dtDateCheckout.Text), "MM/dd/yyyy"), txtnumberofpax.Value, cbMealType.SelectedValue, cbUseType.SelectedValue, txtremark.Text, cbstatus.SelectedValue)

            checkin.loadtbfcheckin(dgvshow)
            loadcombo()
            enablesave()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnedit4_Click(sender As Object, e As EventArgs) Handles btnedit4.Click
        enableupdate()
        enabletext()

    End Sub

 
   
  

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow

                room.comboroom(cbroom)
                customer.combocustomer(cbCustomerNO)
                bookingtype.combobookingtype(cbBookingType)
                markettype.combomarkettype(cbMarketType)
                mealtype.combomealtype(cbMealType)
                usetype.combousetype(cbUseType)
                status.combostatus(cbstatus)

                txtCheckinNO.Text = .CurrentRow.Cells(0).Value
                txtid.Text = .CurrentRow.Cells(24).Value
                cbroom.Text = .CurrentRow.Cells(4).Value
                cbCustomerNO.Text = .CurrentRow.Cells(1).Value
                cbBookingType.Text = .CurrentRow.Cells(14).Value
                cbMarketType.Text = .CurrentRow.Cells(15).Value
                dtDateCheckin.Text = .CurrentRow.Cells(16).Value
                dtDateCheckout.Text = .CurrentRow.Cells(17).Value
                txtnumberofpax.Text = .CurrentRow.Cells(18).Value
                cbMealType.Text = .CurrentRow.Cells(19).Value
                cbUseType.Text = .CurrentRow.Cells(20).Value
                txtremark.Text = .CurrentRow.Cells(21).Value
                cbstatus.Text = .CurrentRow.Cells(22).Value

                disabletext()
                enableedit()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btndelete4_Click(sender As Object, e As EventArgs) Handles btndelete4.Click
        checkin.delete(txtid.Text)
        txtCheckinNO.Text = checkin.runidNO
        checkin.loadtbfcheckin(dgvshow)
        enablesave()
    End Sub

    Private Sub btnnew4_Click(sender As Object, e As EventArgs) Handles btnnew4.Click
        enabletext()
        txtCheckinNO.Text = checkin.runidNO
        txtremark.Clear()
        checkin.loadtbfcheckin(dgvshow)
        enablesave()
    End Sub

    Private Sub btnupdate4_Click(sender As Object, e As EventArgs) Handles btnupdate4.Click
        Dim username As String = "1"
        checkin.update(txtCheckinNO.Text, txtid.Text, username, cbroom.SelectedValue, cbCustomerNO.SelectedValue, cbBookingType.SelectedValue, cbMarketType.SelectedValue, Format(CDate(dtDateCheckin.Text), "MM/dd/yyyy"), Format(CDate(dtDateCheckout.Text), "MM/dd/yyyy"), txtnumberofpax.Value, cbMealType.SelectedValue, cbUseType.SelectedValue, txtremark.Text, cbstatus.SelectedValue)
        checkin.loadtbfcheckin(dgvshow)
        txtCheckinNO.Text = checkin.runidNO
        enablesave()
        txtremark.Clear()

    End Sub
End Class
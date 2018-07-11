Public Class frmcustomer
    Dim customer As New tbcustomer
    Dim customertype As New tbfcustomertype
    Dim roomrate As New tbfroomrate
    Dim titlename As New tbtitlename
    Dim province As New tbprovince
    Dim district As New tbdistrict
    Dim village As New tbvillage
    Public type As String
    Public frmcustomertype1 As Boolean = False
    Public frmroomrate1 As Boolean = False
    Public frmtitlename1 As Boolean = False
    Public frmvillage1 As Boolean = False
    Public frmdistrict1 As Boolean = False
    Public frmprovience1 As Boolean = False
    Public frmcountry1 As Boolean = False
    Dim countrys As New tbcountry
    Private Sub frmcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtCustomerID.Text = customer.runidNO
            customertype.combocustomertype(cbcustomertype)
            roomrate.comboroomrate(cbRoomrate)
            titlename.combotitlename(cbtitlename)

            countrys.combocountry(cbcountry)

            province.comboprovince(cbprovince)
            customer.loadtbcustomer(dgvcustomer)

            enableSave()
            txtCustomerName.Select()

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
        txtCustomerName.Clear()
        txtEmail.Clear()
        txtIdcard.Clear()
        txttel.Clear()
        txtFax.Clear()
        txtNationality.Clear()
        txtPassport.Clear()
        txtSurname.Clear()

    End Sub
    Private Sub disabletext()
        txtCustomerName.Enabled = False
        txtEmail.Enabled = False
        txtTel.Enabled = False
        txtFax.Enabled = False
        txtPassport.Enabled = False
        txtSurname.Enabled = False
        txtNationality.Enabled = False
        txtIdcard.Enabled = False

        cbcustomertype.Enabled = False
        cbRoomrate.Enabled = False
        cbtitlename.Enabled = False
        cbvillage.Enabled = False
        cbdistrict.Enabled = False
        cbprovince.Enabled = False
        chkActivate.Enabled = False
    End Sub
    Private Sub Enabletext()
        txtCustomerName.Enabled = True
        txtEmail.Enabled = True
        txtTel.Enabled = True
        txtFax.Enabled = True
        txtPassport.Enabled = True
        txtSurname.Enabled = True
        txtNationality.Enabled = True
        txtIdcard.Enabled = True

        cbcustomertype.Enabled = True
        cbRoomrate.Enabled = True
        cbtitlename.Enabled = True
        cbvillage.Enabled = True
        cbdistrict.Enabled = True
        cbprovince.Enabled = True
        chkActivate.Enabled = True
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click     
        If txtCustomerName.Text = "" Then
            MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ")
            txtCustomerName.Focus()
            Return
        End If
        If txtSurname.Text = "" Then
            MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ")
            txtSurname.Focus()
            Return
        End If

        If txtNationality.Text = "" Then
            MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ")
            txtNationality.Focus()
            Return
        End If
        If txtPassport.Text = "" Then
            MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ")
            txtPassport.Focus()
            Return
        End If
        If txtIdcard.Text = "" Then
            MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ")
            txtIdcard.Focus()
            Return
        End If
        If txtTel.Text = "" Then
            MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ")
            txtTel.Focus()
            Return
        End If
        If txtFax.Text = "" Then
            MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ")
            txtFax.Focus()
            Return
        End If
        If txtEmail.Text = "" Then
            MessageBox.Show("ຂໍ້ມູນທີທ່ານປ້ອນເຂົ້າຍັງບໍ່ສໍາເລັດ")
            txtEmail.Focus()
            Return
        End If
        Dim activates As Boolean
        If chkActivate.Checked = True Then
            activates = True
        Else
            activates = False
        End If
        Dim idno As String = customer.runidNO
        Dim id As Integer = customer.runid
        customer.save(idno, id, cbcustomertype.SelectedValue, cbtitlename.SelectedValue, txtCustomerName.Text, txtSurname.Text, txtNationality.Text, cbvillage.SelectedValue, txtPassport.Text, txtIdcard.Text, txtTel.Text, txtFax.Text, txtEmail.Text, cbRoomrate.SelectedValue, activates)
        customer.loadtbcustomer(dgvcustomer)
        enableSave()
        cleartext()
        txtCustomerName.Select()

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        enableSave()
        Enabletext()
        cleartext()
        txtCustomerName.Select()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            Dim activates As Boolean
            If chkActivate.Checked = True Then
                activates = True
            End If
            customer.update(txtCustomerID.Text, txtid.Text, cbcustomertype.SelectedValue, cbtitlename.SelectedValue, txtCustomerName.Text, txtSurname.Text, txtNationality.Text, cbvillage.SelectedValue, txtPassport.Text, txtIdcard.Text, txtTel.Text, txtFax.Text, txtEmail.Text, cbRoomrate.SelectedValue, activates)
            customer.loadtbcustomer(dgvcustomer)
            enableSave()
            cleartext()
            txtCustomerName.Select()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Enabletext()
        txtCustomerName.Select()
        enableUpdate()
    End Sub

    Private Sub dgvcustomer_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvcustomer.CellMouseUp
        Try
            With dgvcustomer
                customertype.combocustomertype(cbcustomertype)
                roomrate.comboroomrate(cbRoomrate)
                titlename.combotitlename(cbtitlename)
                village.comboboxvillage(cbvillage)
                district.comboboxdistrict(cbdistrict)
                province.comboprovince(cbprovince)

                txtid.Text = .CurrentRow.Cells(0).Value
                txtCustomerID.Text = .CurrentRow.Cells(1).Value
                cbcustomertype.Text = .CurrentRow.Cells(2).Value
                cbtitlename.Text = .CurrentRow.Cells(3).Value
                txtCustomerName.Text = .CurrentRow.Cells(4).Value
                txtSurname.Text = .CurrentRow.Cells(5).Value
                txtNationality.Text = .CurrentRow.Cells(6).Value
                cbvillage.Text = .CurrentRow.Cells(7).Value
                cbdistrict.Text = .CurrentRow.Cells(8).Value
                cbprovince.Text = .CurrentRow.Cells(9).Value
                cbcountry.Text = .CurrentRow.Cells(10).Value
                txtPassport.Text = .CurrentRow.Cells(11).Value
                txtIdcard.Text = .CurrentRow.Cells(12).Value
                txtTel.Text = .CurrentRow.Cells(13).Value
                txtFax.Text = .CurrentRow.Cells(14).Value
                txtEmail.Text = .CurrentRow.Cells(15).Value
                cbRoomrate.Text = .CurrentRow.Cells(16).Value
                chkActivate.Checked = .CurrentRow.Cells(17).Value
                disabletext()
                enableEdit()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        customer.delete(txtid.Text)
        Enabletext()
        cleartext()
        txtCustomerName.Select()
        enableSave()
        customer.loadtbcustomer(dgvcustomer)
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub cbprovince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbprovince.SelectedIndexChanged
        Try
            district.combodistrict(cbprovince.SelectedValue, cbdistrict)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbdistrict_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdistrict.SelectedIndexChanged
        Try
            village.combovillage(cbdistrict.SelectedValue, cbvillage)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        frmcustomertype1 = True
        frmcustomertype.ShowDialog()
        frmcustomertype.Close()
        customertype.combocustomertype(cbcustomertype)
        frmcustomertype1 = False
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click

        frmroomrate1 = True
        frmroomrate.ShowDialog()
        frmroomrate.Close()
        roomrate.comboroomrate(cbRoomrate)
        frmroomrate1 = False

    End Sub


    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click

        frmtitlename1 = True
        frmtitlename.ShowDialog()
        frmtitlename.Close()
        titlename.combotitlename(cbtitlename)
        frmtitlename1 = False
    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click

        frmvillage1 = True
        frmvillage.ShowDialog()
        frmvillage.Close()
        village.combovillage(cbdistrict.SelectedValue, cbvillage)
        frmvillage1 = False
    End Sub

    Private Sub ToolStripLabel6_Click(sender As Object, e As EventArgs) Handles ToolStripLabel6.Click
        frmdistrict1 = True
        frmdistrict.ShowDialog()
        frmdistrict.Close()
        district.combodistrict(cbprovince.SelectedValue, cbdistrict)
        frmdistrict1 = False
    End Sub

    Private Sub ToolStripLabel7_Click(sender As Object, e As EventArgs) Handles ToolStripLabel7.Click

        frmprovience1 = True
        frmprovience.ShowDialog()
        frmprovience.Close()
        province.comboprovince(cbprovince)
        frmprovience1 = False
    End Sub

    Private Sub cbcustomertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcustomertype.SelectedIndexChanged

    End Sub

    Private Sub txtCustomerID_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerID.TextChanged

    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripLabel4_Click_1(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        frmcountry1 = True
        frmcountry.ShowDialog()
        frmcountry.Close()
        countrys.combocountry(cbcountry)
        frmcountry1 = False
    End Sub

    Private Sub cbcountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcountry.SelectedIndexChanged
        Try
            countrys.comprovinceall(cbcountry.SelectedValue, cbprovince)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvcustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcustomer.CellContentClick

    End Sub
End Class
Imports System.Data.SqlClient
Public Class frmroom
    Dim room As New tbfroom
    Dim roomtype As New tbfroomtype
    Dim roomlocation As New tbfroomlocation
    Dim status As New tbstatusall
    Private Sub frmbusinessvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtid.Text = room.runid
            room.loadtbfroom(dgvshow)
            roomtype.comboroomtype(cbroomtype)
            roomlocation.comboroomlocation(cbroomlocation)
            status.combostatus(cbstatus)
            enablesave()
            txtphone.Select()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtphone.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtphone.Select()
            Return
        End If
        If txtroomid.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtphone.Select()
            Return
        End If
        If txtdes.Text = "" Then
            MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtphone.Select()
            Return
        End If
        Dim activates As Boolean
        If chkactivate.Checked = True Then
            activates = True
        Else
            activates = False
        End If
        room.save(txtid.Text, cbroomtype.SelectedValue, cbroomlocation.SelectedValue, txtphone.Text, txtroomid.Text, txtdes.Text, activates, cbstatus.SelectedValue)
        txtphone.Clear()
        txtroomid.Clear()
        txtdes.Clear()
        btnsave.Enabled = False
        room.loadtbfroom(dgvshow)
        txtid.Text = room.runid
        txtphone.Select()
        enablesave()
    End Sub
    Private Sub enablesave()
        btnsave.Enabled = True
        btndelete.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = False
        'btnnew.Enabled = True
    End Sub
    Private Sub enableedit()
        btnsave.Enabled = False
        btndelete.Enabled = True
        btnedit.Enabled = True
        btnupdate.Enabled = False
        'btnnew.Enabled = True
        txtid.Enabled = False
        txtphone.Enabled = True
        txtroomid.Enabled = True
        txtdes.Enabled = True
        cbroomtype.Enabled = True
        cbroomlocation.Enabled = True
        cbstatus.Enabled = True
        chkactivate.Enabled = True
    End Sub
    Private Sub enableupdate()
        btnsave.Enabled = False
        btndelete.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = True
        'btnnew.Enabled = True
    End Sub
    'Private Sub txtclear()
    '    txtbsnnamelao.Clear()
    '    txtbsnnameenglish.Clear()
    '    txtaddress.Clear()
    '    txttel.Clear()
    '    txtemail.Clear()
    '    pimage.Image = pimage.ErrorImage
    'End Sub
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        room.delete(txtid.Text)
        txtid.Text = room.runid
        room.loadtbfroom(dgvshow)
        txtphone.Select()
        txtphone.Clear()
        txtroomid.Clear()
        txtdes.Clear()
        enablesave()
    End Sub
    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtid.Text = .CurrentRow.Cells(0).Value
                cbroomtype.Text = .CurrentRow.Cells(1).Value
                cbroomlocation.Text = .CurrentRow.Cells(2).Value
                txtroomid.Text = .CurrentRow.Cells(3).Value
                txtphone.Text = .CurrentRow.Cells(4).Value
                txtdes.Text = .CurrentRow.Cells(5).Value
                chkactivate.Checked = .CurrentRow.Cells(6).Value
                cbstatus.Text = .CurrentRow.Cells(7).Value
                enablesave()
                btnedit.Enabled = True
                btndelete.Enabled = True
                txtphone.Enabled = False
                txtroomid.Enabled = False
                txtdes.Enabled = False
                cbroomtype.Enabled = False
                cbroomlocation.Enabled = False
                cbstatus.Enabled = False
                chkactivate.Enabled = False
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtphone.ReadOnly = False
        txtroomid.ReadOnly = False
        txtdes.ReadOnly = False
        txtphone.Select()
        enableupdate()
        enableedit()
        btnupdate.Enabled = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim activates As Boolean
        If chkactivate.Checked = True Then
            activates = True
        Else
            activates = False
        End If
        room.update(txtid.Text, cbroomtype.SelectedValue, cbroomlocation.SelectedValue, txtphone.Text, txtroomid.Text, txtdes.Text, activates, cbstatus.SelectedValue)
        txtphone.ReadOnly = False
        txtdes.ReadOnly = False
        txtroomid.ReadOnly = False
        txtid.Text = room.runid
        room.loadtbfroom(dgvshow)
        txtdes.Clear()
        txtphone.Clear()
        txtroomid.Clear()
        txtphone.Select()
        enablesave()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtphone.Clear()
        txtroomid.Clear()
        txtdes.Clear()
        txtphone.ReadOnly = False
        txtid.Text = room.runid
        room.loadtbfroom(dgvshow)
        txtphone.Select()
        txtphone.Enabled = True
        txtroomid.Enabled = True
        txtdes.Enabled = True
        cbroomtype.Enabled = True
        cbroomlocation.Enabled = True
        cbstatus.Enabled = True
        chkactivate.Enabled = True
        enablesave()
    End Sub

    Private Sub chkactivate_CheckedChanged(sender As Object, e As EventArgs) Handles chkactivate.CheckedChanged

    End Sub

    Private Sub dgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvshow.CellContentClick

    End Sub
End Class
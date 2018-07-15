Public Class frmoption
    Dim checkins As New tbfcheckin
    Dim markettype As New tbfmarkettype
    Dim roomratetype As New tbfroomtyperate
    Private Sub frmoption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncheckin_Click(sender As Object, e As EventArgs) Handles btncheckin.Click
        Me.Close()
        frmcheckin.room_id = frmroommap.roomid
        frmcheckin.dt1.Text = Today.Date
        frmcheckin.dt2.Text = Today.Date
        frmcheckin.rddate.Checked = True
        If frmcheckin.rddate.Checked = True Then
            frmcheckin.txtsearch.Visible = False
            frmcheckin.dtsearch1.Visible = True
            frmcheckin.dtsearch2.Visible = True
        Else
            frmcheckin.txtsearch.Visible = True
            frmcheckin.dtsearch1.Visible = False
            frmcheckin.dtsearch2.Visible = False
        End If
        markettype.combomarkettype(frmcheckin.cbmarket)
        roomratetype.comboroomtyperate(frmcheckin.cbpricetype)
        frmcheckin.txtid.Text = checkins.runidNO

        frmcheckin.formenable()
        frmcheckin.txtclear()
        frmcheckin.enablesave()



        frmcheckin.txtroomno.Text = frmroommap.roomNumber
        frmmain.closeform.closeform()
        frmmain.closeform.f = frmcheckin
        frmmain.closeform.f.MdiParent = frmmain
        frmmain.closeform.f.WindowState = FormWindowState.Normal
        frmmain.closeform.f.ControlBox = False
        frmmain.closeform.f.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        frmmain.closeform.f.Text = ""
        frmmain.closeform.f.Dock = DockStyle.Fill
        frmmain.closeform.f.Show()

        checkins.search_checkinby_datein(Format(CDate(frmcheckin.dtsearch1.Text), "MM/dd/yyyy"), Format(CDate(frmcheckin.dtsearch2.Text), "MM/dd/yyyy"), frmcheckin.dgvlist)





    End Sub

    Private Sub btncheckout_Click(sender As Object, e As EventArgs) Handles btncheckout.Click
        Me.Close()
        FrmBill.ShowDialog()

    End Sub
End Class
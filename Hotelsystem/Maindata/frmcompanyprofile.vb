Imports System.Data.SqlClient
Public Class frmcompanyprofile
    Dim com As New tbcompanyprofile
    Private Sub frmbusinessvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbsnnid.Text = com.runid
        com.loadtbcompanyprofile(dgvshow)
        txtname.Select           
        enablesave()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try

            If txtname.Text = "" Then
                MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtname.Select()
                Return
            End If
            If txtaddress.Text = "" Then
                MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtaddress.Select()
                Return
            End If
            If txttel.Text = "" Then
                MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txttel.Select()
                Return
            End If
            If txtemail.Text = "" Then
                MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtemail.Select()
                Return
            End If
            If txtfax.Text = "" Then
                MessageBox.Show("ກະລຸນາເພີ້ມຂໍ້ມູນໃຫ້ສໍາເລັດ", "ຄໍາແນະນໍາ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtfax.Select()
                Return
            End If
            com.save(txtbsnnid.Text, txtname.Text, txtaddress.Text, txttel.Text, txtfax.Text, txtemail.Text, Format(CDate(dtstart.Text), "MM/dd/yyyy"))
            txtname.Clear()
            btnsave.Enabled = False
            com.loadtbcompanyprofile(dgvshow)
            txtbsnnid.Text = com.runid
            txtname.Select()
            enablesave()
            txtclear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub enablesave()
        'btnsave.Enabled = True
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
    End Sub
    Private Sub enableupdate()
        btnsave.Enabled = False
        btndelete.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = True
        'btnnew.Enabled = True
    End Sub
    Private Sub disabletext()
        txtname.Enabled = False
        txtaddress.Enabled = False
        txttel.Enabled = False
        txtfax.Enabled = False
        txtemail.Enabled = False
        dtstart.Enabled = False
        pimage.Enabled = False
    End Sub
    Private Sub enabletext()
        txtname.Enabled = True
        txtaddress.Enabled = True
        txttel.Enabled = True
        txtfax.Enabled = True
        txtemail.Enabled = True
        dtstart.Enabled = True
        pimage.Enabled = True
    End Sub
    Private Sub txtclear()
        txtname.Clear()
        txtaddress.Clear()
        txtfax.Clear()
        txttel.Clear()
        txtemail.Clear()
        pimage.Image = pimage.ErrorImage
    End Sub
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        com.delete(txtbsnnid.Text)
        txtclear()
        enabletext()
        txtbsnnid.Text = com.runid
        com.loadtbcompanyprofile(dgvshow)
        txtname.Select()
        enablesave()

    End Sub
    Private Sub dgvshow_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvshow.CellMouseUp
        Try
            With dgvshow
                txtbsnnid.Text = .CurrentRow.Cells(0).Value
                txtname.Text = .CurrentRow.Cells(1).Value
                txtaddress.Text = .CurrentRow.Cells(2).Value
                txttel.Text = .CurrentRow.Cells(3).Value
                txtfax.Text = .CurrentRow.Cells(4).Value
                txtemail.Text = .CurrentRow.Cells(5).Value
                dtstart.Text = .CurrentRow.Cells(6).Value
                com.showimage(dgvshow)
                enablesave()
                disabletext()
                btnedit.Enabled = True
                btndelete.Enabled = True
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtname.Select()
        enableupdate()
        enableedit()
        btnupdate.Enabled = True
        enabletext()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            com.update(txtbsnnid.Text, txtname.Text, txtaddress.Text, txttel.Text, txtfax.Text, txtemail.Text, Format(CDate(dtstart.Text), "MM/dd/yyyy"))
            txtname.Clear()
            btnsave.Enabled = False
            com.loadtbcompanyprofile(dgvshow)
            txtname.Select()
            enablesave()
            txtclear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub pimage_MouseClick(sender As Object, e As MouseEventArgs) Handles pimage.MouseClick
        Try
            Dim FilePath As String
            OpenFileDialog1.ShowDialog()
            FilePath = OpenFileDialog1.FileName
            If FilePath <> Nothing Then
                pimage.Image = Image.FromFile(FilePath)
                pimage.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtclear()
        enabletext()
        txtbsnnid.Text = com.runid
        com.loadtbcompanyprofile(dgvshow)
        txtname.Select()
        enablesave()
    End Sub
End Class
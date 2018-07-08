Imports System.Data.SqlClient
Public Class tbcompanyprofile
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim re As SqlDataReader
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Public Function saveimage() As Byte()
        Dim frmp As frmcompanyprofile = CType(Application.OpenForms("frmcompanyprofile"), frmcompanyprofile)
        Dim memstream1 As New IO.MemoryStream
        frmp.pimage.Image.Save(memstream1, Drawing.Imaging.ImageFormat.Jpeg)
        Return memstream1.ToArray()
    End Function
    Public Function save(profileid As Integer, comname As String, address As String, tel As String, fax As String, email As String, startdate As String)
        cn.connect()

        cn.connect()
        Try
            Dim pic() As Byte = saveimage()
            cm.Parameters.AddWithValue("pic", pic)
            Dim sav As String = "insert into tbcompanyprofile values('" & profileid & "',N'" & comname & "',N'" & address & "',N'" & tel & "','" & fax & "',N'" & email & "','" & startdate & "',@pic)"
            With cm
                If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                    .CommandType = CommandType.Text
                    .CommandText = sav
                    .Connection = cn.conn
                    cm.ExecuteNonQuery()
                Else

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function showimage(dgv As DataGridView)
        Dim product As frmcompanyprofile = CType(Application.OpenForms("frmcompanyprofile"), frmcompanyprofile)
        cn.connect()
        Try
            cm = New SqlCommand("select logo from tbcompanyprofile where profileid='" & dgv.CurrentRow.Cells(0).Value & "'", cn.conn)
            re = cm.ExecuteReader
            If re.Read Then
                Dim bytimage() As Byte

                bytimage = CType(re(0), Byte())
                Dim ms As New System.IO.MemoryStream(bytimage)
                Dim bmimage As New Bitmap(ms)
                ms.Close()
                product.pimage.SizeMode = PictureBoxSizeMode.StretchImage
                product.pimage.Image = bmimage
            End If
            re.Close()
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function delete(profileid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbcompanyprofile where profileid='" & profileid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function updateimage()
        Dim product As frmcompanyprofile = CType(Application.OpenForms("frmcompanyprofile"), frmcompanyprofile)
        Dim byteimage() As Byte
        Dim ms As New System.IO.MemoryStream
        Dim dd As New Bitmap(product.pimage.Image)
        dd.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        byteimage = ms.ToArray()
        Return ms.ToArray
    End Function
    Public Function update(profileid As Integer, comname As String, address As String, tel As String, fax As String, email As String, startdate As String)
        cn.connect()
        Try
            Dim pic() As Byte = updateimage()
            cm.Parameters.AddWithValue("pic", pic)
            Dim up As String = "update tbcompanyprofile set comname=N'" & comname & "',address=N'" & address & "',tel=N'" & tel & "',fax=N'" & fax & "',emal='" & email & "',startdate='" & startdate & "',logo=" & "@pic where profileid='" & profileid & "'"
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                With cm
                    .CommandType = CommandType.Text
                    .CommandText = up
                    .Connection = cn.conn
                    cm.ExecuteNonQuery()
                End With
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function runid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 profileid from tbcompanyprofile order by profileid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0).ToString + 1
                End While
            Else
                id = "1"
            End If
        Catch ex As Exception

        End Try
        Return id
    End Function

    Public Function loadtbcompanyprofile(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbcompanyprofile", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ຊື່ບໍລິສັດ"
                .Columns(2).HeaderText = "ທີຢູ່"
                .Columns(3).HeaderText = "ໂທ"
                .Columns(4).HeaderText = "ແຟກ"
                .Columns(5).HeaderText = "ອີເມວ"
                .Columns(6).HeaderText = "ວັນທີກໍ່ຕັ້ງ"
                .Columns(7).Visible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

Imports System.Data.SqlClient
Public Class tbcompanyprofile
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(profileid As Integer, comname As String, address As String, tel As String, fax As String, email As String, logo As String, startdate As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbcompanyprofile(profileid,comname,address,tel,fax,email,logo,startdate)values('" & profileid & "','" & comname & "','" & address & "','" & tel & "','" & fax & "','" & email & "','" & logo & "','" & startdate & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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

    Public Function update(profileid As Integer, comname As String, address As String, tel As String, fax As String, email As String, logo As String, startdate As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbcompanyprofile set comname='" & comname & "', address='" & address & "', tel='" & tel & "', fax='" & fax & "', email='" & email & "', logo='" & logo & "', startdate='" & startdate & "' where profileid='" & profileid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
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
                .Columns(0).HeaderText = "ລະຫັດໂປຣຟາຍ"
                .Columns(1).HeaderText = "ຊື່ບໍລິສັດ"
                .Columns(2).HeaderText = "ທີຢູ່"
                .Columns(3).HeaderText = "ໂທ"
                .Columns(4).HeaderText = "ແຟກ"
                .Columns(5).HeaderText = "ອີເມວ"
                .Columns(6).HeaderText = "ໂລໂກ"
                .Columns(7).HeaderText = "ວັນທີເລີ່ມຕົ້ນ"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

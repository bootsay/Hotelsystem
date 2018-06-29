Imports System.Data.SqlClient
Public Class tbbilldetailmoveitem
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(moveitemid As Integer, billNO As String, frombillNO As String, listitem As String, qty As Integer, price As Double, totalprice As String, datemove As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbbilldetailmoveitem(moveitemid,billNO,frombillNO,listitem,qty,price,totalprice,datemove)values('" & moveitemid & "','" & billNO & "','" & frombillNO & "','" & listitem & "','" & qty & "','" & price & "','" & totalprice & "','" & datemove & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(moveitemid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbbilldetailmoveitem where moveitemid='" & moveitemid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update(moveitemid As Integer, billNO As String, frombillNO As String, listitem As String, qty As Integer, price As Double, totalprice As String, datemove As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbbilldetailmoveitem set billNO='" & billNO & "', frombillNO='" & frombillNO & "', listitem='" & listitem & "', qty='" & qty & "', price='" & price & "', totalprice='" & totalprice & "', datemove='" & datemove & "' where moveitemid='" & moveitemid & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 moveitemid from tbbilldetailmoveitem order by moveitemid desc", cn.conn)
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

    Public Function loadtbbilldetailmoveitem(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbbilldetailmoveitem", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ລະຫັດຍ້າຍ"
                .Columns(1).HeaderText = "ເລກທີບິນ"
                .Columns(2).HeaderText = "ຈາກເລກທີບິນ"
                .Columns(3).HeaderText = "ລາຍການ"
                .Columns(4).HeaderText = "ຈຳນວນ"
                .Columns(5).HeaderText = "ລາຄາ"
                .Columns(6).HeaderText = "ລາຄາທັງໝົດ"
                .Columns(7).HeaderText = "ວັນທີຍ້າຍ"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

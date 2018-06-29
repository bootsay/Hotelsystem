Imports System.Data.SqlClient
Public Class tbfBilldetail
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(billdetailid As Integer, billNO As String, listitem As String, qty As Integer, price As Double, totalprice As Double, remarkitem As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbfBilldetail(billdetailid,billNO,listitem,qty,price,totalprice,remarkitem) values('" & billdetailid & "','" & billNO & "','" & listitem & "','" & qty & "','" & price & "','" & totalprice & "','" & remarkitem & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(billdetailid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfBilldetail where billdetailid='" & billdetailid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update(billdetailid As Integer, billNO As String, listitem As String, qty As Integer, price As Double, totalprice As Double, remarkitem As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbfBilldetail set billNO='" & billNO & "', listitem='" & listitem & "', qty='" & qty & "', price='" & price & "', totalprice='" & totalprice & "', remarkitem='" & remarkitem & "' where billdetailid='" & billdetailid & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 billdetailid from tbfBilldetail order by billdetailid desc", cn.conn)
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

    Public Function loadtbfBilldetail(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbfBilldetail", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ລະຫັດລະອຽດບິນ"
                .Columns(1).HeaderText = "ເລກທີບິນ"
                .Columns(2).HeaderText = "ລາຍການ"
                .Columns(3).HeaderText = "ຈຳນວນ"
                .Columns(4).HeaderText = "ລາຄາ"
                .Columns(5).HeaderText = "ລາຄາທັງໝົດ"
                .Columns(6).HeaderText = "ໝາຍເຫດສິງຂອງ"
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

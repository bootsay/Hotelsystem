Imports System.Data.SqlClient
Public Class tbfBill
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(billNO As String, billid As Integer, reserveNO As String, payid As Integer, userid As Integer, customerNO As String, discount As Double, vath As Double, totalsale As Double, billdate As String, billstatus As String, remark As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbfBill(billNO,billid,reserveNO,payid,userid,customerNO,discount,vath,totalsale,billdate,billstatus,remark)values('" & billNO & "','" & billid & "','" & reserveNO & "','" & payid & "','" & userid & "','" & customerNO & "','" & discount & "','" & vath & "','" & totalsale & "','" & billdate & "','" & billstatus & "','" & remark & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(billNO As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfBill where billNO='" & billNO & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update(billNO As String, billid As Integer, reserveNO As String, payid As Integer, userid As Integer, customerNO As String, discount As Double, vath As Double, totalsale As Double, billdate As String, billstatus As String, remark As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbfBill set billid='" & billid & "', reserveNO='" & reserveNO & "', payid='" & payid & "', userid='" & userid & "', customerNO='" & customerNO & "', discount='" & discount & "', vath='" & vath & "', totalsale='" & totalsale & "', billdate='" & billdate & "', billstatus='" & billstatus & "', remark='" & remark & "' where billNO='" & billNO & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 billid from tbfBill order by billid desc", cn.conn)
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

    Public Function loadtbfBill(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbfBill", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
   
            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ເລກທີບິນ"
                .Columns(1).HeaderText = "ລະຫັດບິນ"
                .Columns(2).HeaderText = "ເລກທີສັງຈອງ"
                .Columns(3).HeaderText = "ລະຫັດຈ່າຍເງິນ"
                .Columns(4).HeaderText = "ລະຫັດຜູ້ໃຊ້"
                .Columns(5).HeaderText = "ເລກທີລູກຄ້າ"
                .Columns(6).HeaderText = "ສວນຫຼຸດ"
                .Columns(7).HeaderText = "vath"
                .Columns(8).HeaderText = "ຂາຍທັງໝົດ"
                .Columns(9).HeaderText = "ວັນທີອອກບິນ"
                .Columns(10).HeaderText = "ສະຖານະບິນ"
                .Columns(11).HeaderText = "ໝາຍເຫດ"
                .Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

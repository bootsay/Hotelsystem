Imports System.Data.SqlClient
Public Class tbproduct
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(productNO As Integer, proid As Integer, cateid As Integer, proname As String, unitid As Integer, pricebuy As Double, pricesale As Double, stockqty As Integer, activate As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbproduct(productNO,proid,cateid,proname,unitid,pricebuy,pricesale,stockqty,remark)values('" & productNO & "','" & proid & "','" & cateid & "','" & proname & "','" & unitid & "','" & pricebuy & "','" & pricesale & "','" & stockqty & "','" & activate & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(productNO As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbproduct where productNO='" & productNO & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update(productNO As Integer, proid As Integer, cateid As Integer, proname As String, unitid As Integer, pricebuy As Double, pricesale As Double, stockqty As Integer, activate As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbproduct set proid='" & proid & "', cateid='" & cateid & "', proname='" & proname & "', unitid='" & unitid & "', pricebuy='" & pricebuy & "', pricesale='" & pricesale & "', stockqty='" & stockqty & "', activate='" & activate & "' where productNO='" & productNO & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 productNO from tbproduct order by productNO desc", cn.conn)
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

    Public Function loadtbfreserve(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbproduct", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ເລກທີສິນຄ້າ"
                .Columns(1).HeaderText = "ລະຫັດສິນຄ້າ"
                .Columns(2).HeaderText = "ລະຫັດປະເພດສິນຄ້າ"
                .Columns(3).HeaderText = "ຊື່ສິນຄ້າ"
                .Columns(4).HeaderText = "ລະຫັດຫົວໜ່ວຍ"
                .Columns(5).HeaderText = "ລາຄາຊື້"
                .Columns(6).HeaderText = "ລາຄາຂາຍ"
                .Columns(7).HeaderText = "ຈຳນວນສະຕ໋ອກ"
                .Columns(8).HeaderText = "ໃຊ້ງານ"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

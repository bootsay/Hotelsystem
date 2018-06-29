Imports System.Data.SqlClient
Public Class tbcustomer
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(customerNO As String, customerid As Integer, customertypeid As Integer, titlenameid As Integer, cusname As String, surname As String, nationality As String, villageid As Integer, passport As String, idcard As String, tel As String, fax As String, email As String, roomrateid As Integer, activate As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbcustomer(customerNO,customerid,customertypeid,titlenameid,cusname,surname,nationality,villageid,passport,idcard,tel,fax, email,roomrateid,activate)values('" & customerNO & "','" & customerid & "','" & customertypeid & "','" & titlenameid & "','" & cusname & "','" & surname & "','" & nationality & "','" & villageid & "','" & passport & "','" & idcard & "','" & tel & "','" & fax & "','" & email & "','" & roomrateid & "','" & activate & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(customerNO As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbcustomer where customerNO='" & customerNO & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update(customerNO As String, customerid As Integer, customertypeid As Integer, titlenameid As Integer, cusname As String, surname As String, nationality As String, villageid As Integer, passport As String, idcard As String, tel As String, fax As String, email As String, roomrateid As Integer, activate As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbcustomer set customerid='" & customerid & "', customertypeid='" & customertypeid & "', titlenameid='" & titlenameid & "', cusname='" & cusname & "', surname='" & surname & "', nationality='" & nationality & "', villageid='" & villageid & "', passport='" & passport & "', idcard='" & idcard & "', tel='" & tel & "', fax='" & fax & "', email='" & email & "', roomrateid='" & roomrateid & "', activate='" & activate & "' where customerNO='" & customerNO & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 customerNO from tbcustomer order by customerNO desc", cn.conn)
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

    Public Function loadtbcustomer(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbcustomer", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ເລກທີລູກຄ້າ"
                .Columns(1).HeaderText = "ລະຫັດລູກຄ້າ"
                .Columns(2).HeaderText = "ລະຫັດປະເພດລູກຄ້າ"
                .Columns(3).HeaderText = "ລະຫັດຊື່ຫົວຂໍ້"
                .Columns(4).HeaderText = "ຊື່ລູກຄ້າ"
                .Columns(5).HeaderText = "ນາມສະກຸນ"
                .Columns(6).HeaderText = "ຊັ້ນຊາດ"
                .Columns(7).HeaderText = "ລະຫັດບ້ານ"
                .Columns(8).HeaderText = "ພາສປອດ"
                .Columns(9).HeaderText = "ບັດປະຈຳຕົວ"
                .Columns(10).HeaderText = "ເບີໂທ"
                .Columns(11).HeaderText = "ແຟກ"
                .Columns(12).HeaderText = "ອີເມວ"
                .Columns(13).HeaderText = "ລະຫັດລາຄາຫ້ອງ"
                .Columns(14).HeaderText = "ໃຊ້ງານ"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

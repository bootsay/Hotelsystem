Imports System.Data.SqlClient
Public Class tbfcheckin
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(checkinNO As String, checkinid As Integer, reserveNO As String, inoutid As Integer, customerNO As String, bookingtypeid As Integer, markettypeid As Integer, checkindate As String, checkoutdate As String, numberofpax As Integer, mealtypeid As Integer, usetypeid As Integer, remark As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbfcheckin(checkinNO,checkinid,reserveNO,inoutid,customerNO,bookingtypeid,markettypeid,checkindate,checkoutdate,numberofpax, mealtypeid,usetypeid,remark)values('" & checkinNO & "','" & checkinid & "','" & reserveNO & "','" & inoutid & "','" & customerNO & "','" & bookingtypeid & "','" & markettypeid & "','" & checkindate & "','" & checkoutdate & "','" & numberofpax & "','" & mealtypeid & "','" & usetypeid & "','" & remark & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(checkinNO As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfcheckin where checkinNO='" & checkinNO & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update(checkinNO As String, checkinid As Integer, reserveNO As String, inoutid As Integer, customerNO As String, bookingtypeid As Integer, markettypeid As Integer, checkindate As String, checkoutdate As String, numberofpax As Integer, mealtypeid As Integer, usetypeid As Integer, remark As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbfcheckin set checkinid='" & checkinid & "', reserveNO='" & reserveNO & "', inoutid='" & inoutid & "', customerNO='" & customerNO & "', bookingtypeid='" & bookingtypeid & "', markettypeid='" & markettypeid & "', checkindate='" & checkindate & "', checkoutdate='" & checkoutdate & "', numberofpax='" & numberofpax & "', mealtypeid='" & mealtypeid & "', usetypeid='" & usetypeid & "', remark='" & remark & "' where checkinNO='" & checkinNO & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 checkinNO from tbfcheckin order by checkinNO desc", cn.conn)
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

    Public Function loadtbfcheckin(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbfcheckin", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ເລກທີແຈ້ງເຂົ້າ"
                .Columns(1).HeaderText = "ລະຫັດແຈ້ງເຂົ້າ"
                .Columns(2).HeaderText = "ເລກທີສັງຈອງ"
                .Columns(3).HeaderText = "ລະຫັດເຂົ້າອອກ"
                .Columns(4).HeaderText = "ເລກທີລູກຄ້າ"
                .Columns(5).HeaderText = "ລະຫັດປະເພດສັງຈອງ"
                .Columns(6).HeaderText = "ລະຫັດປະເພດຕະຫຼາດ"
                .Columns(7).HeaderText = "ວັນທີເເຈ້ງເຂົ້າ"
                .Columns(8).HeaderText = "ວັນທີແຈ້ງອອກ"
                .Columns(9).HeaderText = "ຈຳນວນຄົນ"
                .Columns(10).HeaderText = "ລະຫັດປະເພດຄາບເຂົ້າ"
                .Columns(11).HeaderText = "ລະຫັດປະເພດໃຊ້"
                .Columns(12).HeaderText = "ໝາຍເຫດ"
                .Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

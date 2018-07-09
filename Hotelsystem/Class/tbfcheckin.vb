Imports System.Data.SqlClient
Public Class tbfcheckin
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader
    Public Function selectReserveNO(reserveNO As String, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewreserve where reserveNO='" & reserveNO & "'", cn.conn)
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
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

    Public Function runidNO()
        cn.connect()
        Dim id As String = Nothing
        Dim idorder As Integer
        Dim length As Integer = 4
        Try
            cm = New SqlCommand("select top 1 checkinid from tbfcheckin order by checkinid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    idorder = re.GetValue(0) + 1
                End While
            Else
                idorder = 1
            End If
            id = idorder
            id = String.Format("{0}{1}", "CHKIN", idorder.ToString().PadLeft(length, "0"))
            re.Close()
            cm.Dispose()
            cn.conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    Public Function runid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 checkinid from tbfcheckin order by checkinid desc", cn.conn)
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
            da = New SqlDataAdapter("select * from viewcheckin", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ເລກທີແຈ້ງເຂົ້າ"
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ທີ່ຕັ້ງຫ້ອງ"
                .Columns(3).HeaderText = "ປະເພດຫ້ອງ"
                .Columns(4).HeaderText = "ເບີຫ້ອງ"
                .Columns(5).HeaderText = "ປະເພດລູກຄ້າ"
                .Columns(6).HeaderText = "ຄຳນຳໜ້າ"
                .Columns(7).HeaderText = "ຊື່"
                .Columns(8).HeaderText = "ນາມສະກຸນ"
                .Columns(9).HeaderText = "ຊັ້ນຊາດ"
                .Columns(10).HeaderText = "ບ້ານ"
                .Columns(11).HeaderText = "ເມືອງ"
                .Columns(12).HeaderText = "ແຂວງ"
                .Columns(13).HeaderText = "ປະເທດ"
                .Columns(14).HeaderText = "ປະເພດສັງຈອງ"
                .Columns(15).HeaderText = "ປະເພດຕະຫຼາດ"
                .Columns(16).HeaderText = "ວັນທີເເຈ້ງເຂົ້າ"
                .Columns(17).HeaderText = "ວັນທີແຈ້ງອອກ"
                .Columns(18).HeaderText = "ຈຳນວນຄົນ"
                .Columns(19).HeaderText = "ປະເພດຄາບເຂົ້າ"
                .Columns(20).HeaderText = "ປະເພດນຳໃຊ້"
                .Columns(21).HeaderText = "ໝາຍເຫດ"
                .Columns(22).Visible = False
                .Columns(23).Visible = False
                .Columns(24).Visible = False
                .Columns(25).Visible = False
                .Columns(26).Visible = False
                .Columns(27).Visible = False
                .Columns(28).Visible = False
                .Columns(29).Visible = False
                .Columns(30).Visible = False
                .Columns(31).Visible = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

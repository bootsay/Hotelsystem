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
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function save(checkinNO As String, checkinid As Integer, userid As Integer, reserveNO As String, inoutid As Integer, customerNO As String, bookingtypeid As Integer, markettypeid As Integer, checkindate As String, checkoutdate As String, numberofpax As Integer, mealtypeid As Integer, usetypeid As Integer, remark As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbfcheckin values('" & checkinNO & "','" & checkinid & "','" & userid & "', '" & reserveNO & "','" & inoutid & "','" & customerNO & "','" & bookingtypeid & "','" & markettypeid & "','" & checkindate & "','" & checkoutdate & "','" & numberofpax & "','" & mealtypeid & "','" & usetypeid & "','" & remark & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
                cm.Dispose()
                cn.conn.Close()
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
    Public Function search_checkinby_datein(dt1 As String, dt2 As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewcheckin where checkindate>='" & dt1 & "' and checkindate<='" & dt2 & "' order by checkinid desc", cn.conn)
            da.Fill(ds, "pt1")
            ds.Tables.Clear()
            da.Fill(ds, "pt1")
            dgv.DataSource = ds.Tables(0)
            format_viewcheckin(dgv)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function search_checkinby_Name(name As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewcheckin where cusname like N'%" & name & "%' order by checkinid desc", cn.conn)
            da.Fill(ds, "pt1")
            ds.Tables.Clear()
            da.Fill(ds, "pt1")
            dgv.DataSource = ds.Tables(0)
            format_viewcheckin(dgv)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function search_checkinby_roomNO(name As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewcheckin where room_id like N'%" & name & "%' order by checkinid desc", cn.conn)
            da.Fill(ds, "pt1")
            ds.Tables.Clear()
            da.Fill(ds, "pt1")
            dgv.DataSource = ds.Tables(0)
            format_viewcheckin(dgv)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function search_checkinby_IDCard(name As String, dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewcheckin where idcard like N'%" & name & "%' order by checkinid desc", cn.conn)
            da.Fill(ds, "pt1")
            ds.Tables.Clear()
            da.Fill(ds, "pt1")
            dgv.DataSource = ds.Tables(0)
            format_viewcheckin(dgv)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadtbfcheckin(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewcheckin", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            format_viewcheckin(dgv)

        
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function format_viewcheckin(dgv As DataGridView)
        With dgv
            .ReadOnly = True
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .Columns(0).HeaderText = "ເລກທີແຈ້ງເຂົ້າ"
            .Columns(1).HeaderText = "ເລກທີຈອງ"
            .Columns(2).HeaderText = "ຜູ້ບັນທືກ"
            .Columns(3).HeaderText = "ທີ່ຕັ້ງຫ້ອງ"
            .Columns(4).HeaderText = "ປະເພດຫ້ອງ"
            .Columns(5).HeaderText = "ເບີຫ້ອງ"
            .Columns(6).HeaderText = "ປະເພດລາຄາ"
            .Columns(7).HeaderText = "ລາຄາ"
            .Columns(8).HeaderText = "ປະເພດລູກຄ້າ"
            .Columns(9).HeaderText = "ຫົວຂໍ້"
            .Columns(10).HeaderText = "ຊື່"
            .Columns(11).HeaderText = "ນາມສະກຸນ"
            .Columns(12).HeaderText = "ບັດສະປ໋ອດ"
            .Columns(13).HeaderText = "ບັດປະຈໍາຕົວ"
            .Columns(14).HeaderText = "ເບີໂທ"
            .Columns(15).HeaderText = "ແຟ່ກ"
            .Columns(16).HeaderText = "ອີເມວ"
            .Columns(17).HeaderText = "ຊັ້ນຊາດ"
            .Columns(18).HeaderText = "ບ້ານ"
            .Columns(19).HeaderText = "ເມືອງ"
            .Columns(20).HeaderText = "ແຂວງ"
            .Columns(21).HeaderText = "ປະເທດ"
            .Columns(22).HeaderText = "ປະເພດສັງຈອງ"
            .Columns(23).HeaderText = "ຕະຫຼາດ"
            .Columns(24).HeaderText = "ວັນທີເເຈ້ງເຂົ້າ"
            .Columns(25).HeaderText = "ວັນທີແຈ້ງອອກ"
            .Columns(26).HeaderText = "ຈໍານວນຄົນ"
            .Columns(27).HeaderText = "ປະເພດຄາບເຂົ້າ"
            .Columns(28).HeaderText = "ປະເພດນໍາໃຊ້"
            .Columns(29).HeaderText = "ໝາຍເຫດ"
            .Columns(30).HeaderText = "ສະຖານະ"
            .Columns(31).Visible = False
            .Columns(32).Visible = False
            .Columns(33).Visible = False
            .Columns(34).Visible = False
            .Columns(35).Visible = False
            .Columns(36).Visible = False
            .Columns(37).Visible = False
            .Columns(38).Visible = False
            .Columns(39).Visible = False
            .Columns(40).Visible = False
            .Columns(7).DefaultCellStyle.Format = "N0"
        End With
        Return True
    End Function
End Class

Imports System.Data.SqlClient
Public Class tbfreserve
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(reserveNo As String, reserveid As Integer, customerNo As String, roomid As String, datereserve As String, datecheckin As String, datecheckout As String, numberofpax As Integer, remark As String, statusid As String, userid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbfreserve(reserveNo,reserveid,customerNO,roomid,datereserve,datecheckin,datecheckout,numberofpax,remark,statusid,userid,statuscheckin)values('" & reserveNo & "','" & reserveid & "','" & customerNo & "','" & roomid & "','" & datereserve & "','" & datecheckin & "','" & datecheckout & "','" & CInt(numberofpax) & "',N'" & remark & "','" & statusid & "','" & userid & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(reserveid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfreserve where reserveid='" & reserveid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update(reserveNo As String, reserveid As Integer, customerNo As String, roomid As String, datereserve As String, datecheckin As String, datecheckout As String, numberofpax As Integer, remark As String, statusid As String, userid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("update tbfreserve set customerNO='" & customerNo & "', roomid='" & roomid & "', datereserve='" & datereserve & "', datecheckin='" & datecheckin & "', datecheckout='" & datecheckout & "', numberofpax='" & numberofpax & "', remark=N'" & remark & "',statusid=N'" & statusid & "',userid='" & userid & "' where reserveNO='" & reserveNo & "'", cn.conn)
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
        Dim length As Integer = 6
        Try
            cm = New SqlCommand("select top 1 reserveid from tbfreserve order by reserveid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    idorder = re.GetValue(0) + 1
                End While
            Else
                idorder = 1
            End If
            id = idorder
            id = String.Format("{0}{1}", "R", idorder.ToString().PadLeft(length, "0"))
            re.Close()
            cm.Dispose()
            cn.conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function


    'Public Function runreceiveroomNO()
    '    Dim y As String
    '    Dim years As New DateTimePicker

    '    y = years.Value.Year

    '    Dim m As String
    '    Dim month As New DateTimePicker
    '    m = month.Value.Month

    '    Dim d As String
    '    Dim day As New DateTimePicker
    '    d = day.Value.Day
    '    'Dim w As String
    '    'w = "000"
    '    'MessageBox.Show(a)
    '    Dim strseqno As String
    '    Dim strprefix = ""
    '    Dim lengs = 4
    '    Dim intsequence = 0
    '    cn.connect()
    '    Dim str As String = "select top 1 reserveid from tbfreserve order by reserveid desc"
    '    cm = New SqlCommand(str, cn.conn)
    '    re = cm.ExecuteReader
    '    If re.HasRows Then
    '        re.Read()
    '        intsequence = Convert.ToInt32(re("reserveid") + 1)
    '    Else
    '        intsequence = 1
    '    End If
    '    strseqno = intsequence
    '    strseqno = String.Format("{0}{1}" & m & "" & y & "", strprefix, intsequence.ToString().PadLeft(lengs, "0"))
    '    re.Close()
    '    cm.Dispose()
    '    cn.conn.Close()
    '    Return strseqno
    'End Function
    Public Function runid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 reserveid from tbfreserve order by reserveid desc", cn.conn)
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
            da = New SqlDataAdapter("select * from viewreserve where statusid=2 order by reserveNO desc", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ເລກທີສັງຈອງ"
                .Columns(1).HeaderText = "ປະເພດລູກຄ້າ"
                .Columns(2).HeaderText = "ນາມຊື່"
                .Columns(3).HeaderText = "ຊື່"
                .Columns(4).HeaderText = "ນາມສະກຸນ"
                .Columns(5).HeaderText = "ສັນຊາດ"
                .Columns(6).HeaderText = "ທີ່ຢູ່ບ້ານ"
                .Columns(7).HeaderText = "ເມືອງ"
                .Columns(8).HeaderText = "ແຂວງ"
                .Columns(9).HeaderText = "ປະເທດ"
                .Columns(10).HeaderText = "ເລກທີພາດສະປອດ"
                .Columns(11).HeaderText = "ເລກບັດປະຈໍາຕົວ"
                .Columns(12).HeaderText = "ເບີໂທລະສັບ"
                .Columns(13).HeaderText = "ແຟັກ"
                .Columns(14).HeaderText = "ອີເມວ"
                .Columns(15).HeaderText = "ຊັ້ນ"
                .Columns(16).HeaderText = "ປະເພດຫ້ອງ"
                .Columns(17).HeaderText = "ເບີຫ້ອງ"
                .Columns(18).HeaderText = "ເບີໂທລະສັບຫ້ອງ"
                .Columns(19).HeaderText = "ວັນທີຈອງ"
                .Columns(20).HeaderText = "ວັນທີເຊັກອິນ"
                .Columns(21).HeaderText = "ວັນທີເຊັກເອົ້າ"
                .Columns(22).HeaderText = "ຈໍານວນຄົນ"
                .Columns(23).HeaderText = "ໝາຍເຫດ"
                .Columns(24).HeaderText = "ຊື່ຜູ້ໃຊ້"
                .Columns(25).HeaderText = "ສະຖານະ"
                .Columns(26).Visible = False
                .Columns(27).Visible = False
                .Columns(28).Visible = False
                .Columns(29).Visible = False
                .Columns(30).Visible = False
                '.Columns(31).Visible = False
                '.Columns(32).Visible = False
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(14).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(15).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(16).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(17).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(18).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(19).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(20).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(21).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(22).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(23).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(24).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(25).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadtbfreserveSearch(dgv As DataGridView, name As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewreserve where reserveNO like N'%" & name & "%'or room_id='" & name & "'and statusid=2 order by reserveNO desc", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ເລກທີສັງຈອງ"
                .Columns(1).HeaderText = "ປະເພດລູກຄ້າ"
                .Columns(2).HeaderText = "ນາມຊື່"
                .Columns(3).HeaderText = "ຊື່"
                .Columns(4).HeaderText = "ນາມສະກຸນ"
                .Columns(5).HeaderText = "ສັນຊາດ"
                .Columns(6).HeaderText = "ທີ່ຢູ່ບ້ານ"
                .Columns(7).HeaderText = "ເມືອງ"
                .Columns(8).HeaderText = "ແຂວງ"
                .Columns(9).HeaderText = "ປະເທດ"
                .Columns(10).HeaderText = "ເລກທີພາດສະປອດ"
                .Columns(11).HeaderText = "ເລກບັດປະຈໍາຕົວ"
                .Columns(12).HeaderText = "ເບີໂທລະສັບ"
                .Columns(13).HeaderText = "ແຟັກ"
                .Columns(14).HeaderText = "ອີເມວ"
                .Columns(15).HeaderText = "ຊັ້ນ"
                .Columns(16).HeaderText = "ປະເພດຫ້ອງ"
                .Columns(17).HeaderText = "ເບີຫ້ອງ"
                .Columns(18).HeaderText = "ເບີໂທລະສັບຫ້ອງ"
                .Columns(19).HeaderText = "ວັນທີຈອງ"
                .Columns(20).HeaderText = "ວັນທີເຊັກອິນ"
                .Columns(21).HeaderText = "ວັນທີເຊັກເອົ້າ"
                .Columns(22).HeaderText = "ຈໍານວນຄົນ"
                .Columns(23).HeaderText = "ໝາຍເຫດ"
                .Columns(24).HeaderText = "ຊື່ຜູ້ໃຊ້"
                .Columns(25).HeaderText = "ສະຖານະ"
                .Columns(26).Visible = False
                .Columns(27).Visible = False
                .Columns(28).Visible = False
                .Columns(29).Visible = False
                .Columns(30).Visible = False
                '.Columns(31).Visible = False
                '.Columns(32).Visible = False
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(14).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(15).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(16).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(17).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(18).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(19).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(20).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(21).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(22).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(23).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(24).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(25).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadtbfreserveSearchorderdate(dgv As DataGridView, d1 As String, d2 As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewreserve where datereserve>='" & d1 & "'and datereserve<='" & d2 & "'and statusid=2 order by reserveNO desc", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ເລກທີສັງຈອງ"
                .Columns(1).HeaderText = "ປະເພດລູກຄ້າ"
                .Columns(2).HeaderText = "ນາມຊື່"
                .Columns(3).HeaderText = "ຊື່"
                .Columns(4).HeaderText = "ນາມສະກຸນ"
                .Columns(5).HeaderText = "ສັນຊາດ"
                .Columns(6).HeaderText = "ທີ່ຢູ່ບ້ານ"
                .Columns(7).HeaderText = "ເມືອງ"
                .Columns(8).HeaderText = "ແຂວງ"
                .Columns(9).HeaderText = "ປະເທດ"
                .Columns(10).HeaderText = "ເລກທີພາດສະປອດ"
                .Columns(11).HeaderText = "ເລກບັດປະຈໍາຕົວ"
                .Columns(12).HeaderText = "ເບີໂທລະສັບ"
                .Columns(13).HeaderText = "ແຟັກ"
                .Columns(14).HeaderText = "ອີເມວ"
                .Columns(15).HeaderText = "ຊັ້ນ"
                .Columns(16).HeaderText = "ປະເພດຫ້ອງ"
                .Columns(17).HeaderText = "ເບີຫ້ອງ"
                .Columns(18).HeaderText = "ເບີໂທລະສັບຫ້ອງ"
                .Columns(19).HeaderText = "ວັນທີຈອງ"
                .Columns(20).HeaderText = "ວັນທີເຊັກອິນ"
                .Columns(21).HeaderText = "ວັນທີເຊັກເອົ້າ"
                .Columns(22).HeaderText = "ຈໍານວນຄົນ"
                .Columns(23).HeaderText = "ໝາຍເຫດ"
                .Columns(24).HeaderText = "ຊື່ຜູ້ໃຊ້"
                .Columns(25).HeaderText = "ສະຖານະ"
                .Columns(26).Visible = False
                .Columns(27).Visible = False
                .Columns(28).Visible = False
                .Columns(29).Visible = False
                .Columns(30).Visible = False
                '.Columns(31).Visible = False
                '.Columns(32).Visible = False
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(14).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(15).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(16).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(17).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(18).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(19).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(20).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(21).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(22).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(23).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(24).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(25).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

End Class

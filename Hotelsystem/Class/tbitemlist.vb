Imports System.Data.SqlClient
Public Class tbitemlist
    Dim cn As New connectdb
    Dim re As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    'Public Function run_runNO()
    '    Dim y As String
    '    Dim years As New DateTimePicker
    '    y = years.Value.Year
    '    Dim m As String
    '    Dim month As New DateTimePicker
    '    m = month.Value.Month
    '    Dim d As String
    '    Dim day As New DateTimePicker
    '    d = day.Value.Day
    '    Dim w As String
    '    'w = "HT"
    '    'MessageBox.Show(a)
    '    Dim strseqno As String
    '    Dim strprefix = ""
    '    Dim lengs = 5
    '    Dim intsequence = 0
    '    cn.connect()
    '    Dim str As String = "select top 1 itemlistid from tbitemlist order by itemlistid desc"
    '    cm = New SqlCommand(str, cn.conn)
    '    re = cm.ExecuteReader
    '    If re.HasRows Then
    '        re.Read()
    '        intsequence = Convert.ToInt32(re("itemlistid") + 1)
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
    Public Function save(itemlistid As Integer, roomid As Integer, proid As Integer, qty As Integer, price As Integer, totalprice As Integer, dateadd As String, statusid As String, userid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbitemlist(itemlistid,roomid,proid,qty,price,totalprice,dateadd,statusid,userid) values('" & itemlistid & "','" & roomid & "','" & proid & "','" & qty & "','" & price & "','" & totalprice & "','" & dateadd & "',N'" & statusid & "','" & userid & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(itemlistid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbitemlist where itemlistid='" & itemlistid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່?", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function

    Public Function update(itemlistid As Integer, roomid As Integer, proid As Integer, qty As Integer, price As Integer, totalprice As Integer, dateadd As String, statusid As String, userid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("update tbitemlist set roomid='" & roomid & "',proid='" & proid & "',qty='" & qty & "',price='" & price & "',totalprice='" & totalprice & "',dateadd='" & dateadd & "',statusid=N'" & statusid & "',userid='" & userid & "' where itemlistid='" & itemlistid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
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
            cm = New SqlCommand("select top 1 itemlistid from tbitemlist order by itemlistid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0).ToString + 1
                End While
            Else
                id = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        re.Close()
        Return id
    End Function

    'Public Function loaditemlist(dgv As DataGridView)
    '    cn.connect()
    '    Try
    '        da = New SqlDataAdapter("select * from viewitemlist order by itemlistid desc", cn.conn)
    '        da.Fill(ds, "pt")
    '        ds.Tables.Clear()
    '        da.Fill(ds, "pt")
    '        dgv.DataSource = ds.Tables(0)
    '        dgv.Refresh()
    '        With dgv
    '            .Columns(0).HeaderText = "ລະຫັດ"
    '            .Columns(1).HeaderText = "ນໍ້າເບີຫ້ອງ"
    '            .Columns(2).HeaderText = "ຊື່ສິນຄ້າ"
    '            .Columns(3).HeaderText = "ນໍ້ຈໍານວນ"
    '            .Columns(4).HeaderText = "ລາຄາ"
    '            .Columns(4).DefaultCellStyle.Format = "#,###"
    '            .Columns(5).HeaderText = "ລາຄາລວມ"
    '            .Columns(5).DefaultCellStyle.Format = "#,###"
    '            .Columns(6).HeaderText = "ວັນທີອັບເດດຂໍ້ມູນ"
    '            .Columns(7).HeaderText = "ສະຖານະ"
    '            .Columns(8).HeaderText = "ຜູ້ໃຊ້ລະບົບ"
    '            .Columns(9).Visible = False
    '            .Columns(10).Visible = False
    '            .Columns(11).Visible = False
    '            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '            .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '            .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '        End With
    '    Catch ex As Exception

    '    End Try
    '    Return True
    'End Function
    Public Function loaditemlistbyroom(dgv As DataGridView, name As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewitemlist where room_id='" & name & "' order by itemlistid desc", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ນໍ້າເບີຫ້ອງ"
                .Columns(2).HeaderText = "ຊື່ສິນຄ້າ"
                .Columns(3).HeaderText = "ຈໍານວນ"
                .Columns(4).HeaderText = "ລາຄາ"
                .Columns(4).DefaultCellStyle.Format = "#,###"
                .Columns(5).HeaderText = "ລາຄາລວມ"
                .Columns(5).DefaultCellStyle.Format = "#,###"
                .Columns(6).HeaderText = "ວັນທີອັບເດດຂໍ້ມູນ"
                .Columns(7).HeaderText = "ສະຖານະ"
                .Columns(8).HeaderText = "ຜູ້ໃຊ້ລະບົບ"
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception

        End Try
        Return True
    End Function
    'Public Function combocountry(cb As ComboBox)
    '    cn.connect()
    '    Dim dt As New DataTable
    '    Try
    '        da = New SqlDataAdapter("select * from tbcountry", cn.conn)
    '        da.Fill(dt)

    '        With cb
    '            .DataSource = dt
    '            .DisplayMember = dt.Columns("countryname").ToString
    '            .ValueMember = dt.Columns("countryid").ToString
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    '    Return True
    'End Function
    'Public Function comboprovince(cb As ComboBox)
    '    cn.connect()
    '    Dim dt As New DataTable
    '    Try
    '        da = New SqlDataAdapter("select * from tbprovince", cn.conn)
    '        da.Fill(dt)

    '        With cb
    '            .DataSource = dt
    '            .DisplayMember = dt.Columns("provincename").ToString
    '            .ValueMember = dt.Columns("provinceid").ToString
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    '    Return True
    'End Function
    'Public Function combodistrict(cb As ComboBox)
    '    cn.connect()
    '    Dim dt As New DataTable
    '    Try
    '        da = New SqlDataAdapter("select * from tbdistrict", cn.conn)
    '        da.Fill(dt)

    '        With cb
    '            .DataSource = dt
    '            .DisplayMember = dt.Columns("districtname").ToString
    '            .ValueMember = dt.Columns("districtid").ToString
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    '    Return True
    'End Function
End Class

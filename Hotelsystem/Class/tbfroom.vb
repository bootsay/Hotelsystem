Imports System.Data.SqlClient
Public Class tbfroom
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader
    Public Function getroom(floorid As Integer, dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select * from viewroominfo where locationid='" & floorid & "'", cn.conn)
            da.Fill(dt)

        Catch ex As Exception

        End Try
        Return True
    End Function

    Public Function save(roomid As Integer, roomtypeid As Integer, locationid As Integer, phone_ext As String, room_id As Integer, des As String, activate As String, statusid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbfroom(roomid,roomtypeid,locationid,phone_ext,room_id,des,activate,statusid)values('" & roomid & "','" & roomtypeid & "','" & locationid & "','" & phone_ext & "','" & room_id & "','" & des & "','" & activate & "','" & statusid & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function Selectroom(dt As DataTable)
        cn.connect()
        Try
            dt.Clear()
            da = New SqlDataAdapter("select top 1 * from tbfroom order by roomid desc", cn.conn)
            da.Fill(dt)
            da.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function delete(roomid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfroom where roomid='" & roomid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update(roomid As Integer, roomtypeid As Integer, locationid As Integer, phone_ext As String, room_id As Integer, des As String, activate As String, statusid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("update tbfroom set roomtypeid='" & roomtypeid & "', locationid='" & locationid & "', phone_ext='" & phone_ext & "', room_id='" & room_id & "', des='" & des & "', activate='" & activate & "', statusid='" & statusid & "' where roomid='" & roomid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function updateroom(roomid As Integer, statusid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("update tbfroom set statusid='" & statusid & "' where roomid='" & roomid & "'", cn.conn)
            'If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            cm.ExecuteNonQuery()
            'Else

            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function runid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 roomid from tbfroom order by roomid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    id = re.GetValue(0) + 1
                End While
            Else
                id = "1"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function

    Public Function loadtbfroom(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewroom order by roomid", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ປະເພດຫ້ອງ"
                .Columns(2).HeaderText = "ທີຕັ້ງຫ້ອງ"
                .Columns(3).HeaderText = "ເບີຫ້ອງ"
                .Columns(4).HeaderText = "ໂທລະສັບຫ້ອງ"
                .Columns(5).HeaderText = "ຄຳອະທິບາຍ"
                .Columns(6).HeaderText = "ໃຊ້ງານ"
                .Columns(7).HeaderText = "ສະຖານະ"
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadtbfroomshow(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewroom where statusid=3 order by roomid", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ປະເພດຫ້ອງ"
                .Columns(2).HeaderText = "ທີຕັ້ງຫ້ອງ"
                .Columns(3).HeaderText = "ເບີຫ້ອງ"
                .Columns(4).HeaderText = "ໂທລະສັບຫ້ອງ"
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                '.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadtbfroomshowlist(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewroom where statusid=2 order by roomid", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ປະເພດຫ້ອງ"
                .Columns(2).HeaderText = "ທີຕັ້ງຫ້ອງ"
                .Columns(3).HeaderText = "ເບີຫ້ອງ"
                .Columns(4).HeaderText = "ໂທລະສັບຫ້ອງ"
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                '.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadtbfroomName(dgv As DataGridView, name As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewroom where room_id like N'%" & name & "%'and statusid=3 order by roomid", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ປະເພດຫ້ອງ"
                .Columns(2).HeaderText = "ທີຕັ້ງຫ້ອງ"
                .Columns(3).HeaderText = "ເບີຫ້ອງ"
                .Columns(4).HeaderText = "ໂທລະສັບຫ້ອງ"
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                '.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadtbfroomNamelist(dgv As DataGridView, name As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewroom where room_id like N'%" & name & "%'and statusid=2 order by roomid", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ປະເພດຫ້ອງ"
                .Columns(2).HeaderText = "ທີຕັ້ງຫ້ອງ"
                .Columns(3).HeaderText = "ເບີຫ້ອງ"
                .Columns(4).HeaderText = "ໂທລະສັບຫ້ອງ"
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                '.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadtbfroomType(dgv As DataGridView, Type As Integer)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewroom where roomtypeid='" & Type & "'and statusid=3 order by roomid", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ປະເພດຫ້ອງ"
                .Columns(2).HeaderText = "ທີຕັ້ງຫ້ອງ"
                .Columns(3).HeaderText = "ເບີຫ້ອງ"
                .Columns(4).HeaderText = "ໂທລະສັບຫ້ອງ"
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                '.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadtbfroomTypelist(dgv As DataGridView, Type As Integer)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewroom where roomtypeid='" & Type & "'and statusid=2 order by roomid", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ປະເພດຫ້ອງ"
                .Columns(2).HeaderText = "ທີຕັ້ງຫ້ອງ"
                .Columns(3).HeaderText = "ເບີຫ້ອງ"
                .Columns(4).HeaderText = "ໂທລະສັບຫ້ອງ"
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                '.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function comboroom(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tbfroom", cn.conn)
            da.Fill(dt)

            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("room_id").ToString
                .ValueMember = dt.Columns("roomid").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

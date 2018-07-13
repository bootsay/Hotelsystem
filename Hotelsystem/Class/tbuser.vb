Imports System.Data.SqlClient
Public Class tbuser
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader
    Public Function save(id As Integer, laoname As String, username As String, password As String, department As Integer, position As Integer, levleid As Integer, auth As String, activates As Boolean)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbuser values('" & id & "', N'" & laoname & "',N'" & username & "', N'" & password & "', N'" & department & "', '" & position & "', N'" & levleid & "','" & auth & "','" & activates & "')", cn.conn)
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
    Public Function update(id As Integer, laoname As String, username As String, password As String, department As Integer, position As Integer, levleid As Integer, auth As String, activates As Boolean)
        cn.connect()
        Try
            cm = New SqlCommand("update tbuser set userlao=N'" & laoname & "',username=N'" & username & "', password='" & password & "',deptid=N'" & department & "', postionid=N'" & position & "',levelid='" & levleid & "', auth='" & auth & "', activateid='" & activates & "' where userid='" & id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
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
    Public Function delete(user_id As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbuser where userid='" & user_id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
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
    Public Function loaduser(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewuser", cn.conn)
            da.Fill(ds, "user")
            ds.Tables.Clear()
            da.Fill(ds, "user")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .Columns(0).HeaderText = "ລໍາດັບ"
                .Columns(1).HeaderText = "ຊື່ພາສາລາວ"
                .Columns(2).HeaderText = "ຊຶ່ເຂົ້າລະບົບ"
                .Columns(3).HeaderText = "ລະຫັດ"
                .Columns(4).HeaderText = "ພະແນກ"
                .Columns(5).HeaderText = "ຕໍາແໜ່ງ"
                .Columns(6).HeaderText = "ສິດທິ"
                .Columns(7).Visible = False
                .Columns(8).HeaderText = "ສະຖານະ"
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function runid()
        Dim idd As Integer = Nothing
        cn.connect()
        Try
            cm = New SqlCommand("select top 1 userid from tbuser order by userid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    idd = re.GetValue(0) + 1
                End While
            Else
                idd = 1001
            End If
            re.Close()
            cm.Dispose()
            cn.conn.Close()
            re.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return idd
    End Function
    Public Function combolevel(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tblevel", cn.conn)
            da.Fill(dt)

            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("levelname").ToString
                .ValueMember = dt.Columns("levelid").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function updateauth(id As Integer, auth As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbuser set auth='" & auth & "' where userid='" & id & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການປັບປຸງສິດທິຂອງຜູ້ໃຊ້ແທ້ບໍ່ ?", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function user_auth(id As Integer)
        Dim auth As String = Nothing
        cn.connect()
        'Try
        cm = New SqlCommand("select auth from tbuser where userid='" & id & "'", cn.conn)
        re = cm.ExecuteReader
        If re.HasRows Then
            While re.Read
                auth = re.GetValue(0)
            End While

        End If
        re.Close()
        cm.Dispose()
        cn.conn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Return auth
    End Function
    Public Function check_userduplicatename(name As String)
        cn.connect()
        Dim duplicatename As Boolean
        Try
            cm = New SqlCommand("select username frm tbuser where username='" & name & "'", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    duplicatename = True
                End While
            Else
                duplicatename = False
            End If
        Catch ex As Exception

        End Try
        re.Close()
        cm.Dispose()
        cn.conn.Close()
        Return duplicatename
    End Function

End Class

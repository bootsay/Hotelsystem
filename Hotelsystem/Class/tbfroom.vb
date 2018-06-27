Imports System.Data.SqlClient
Public Class tbfroom
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(roomid As Integer, roomtypeid As Integer, locationid As Integer, phone_ext As Integer, room_id As Integer, des As String, activate As String, statusid As Integer)
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

    Public Function update(roomid As Integer, roomtypeid As Integer, locationid As Integer, phone_ext As Integer, room_id As Integer, des As String, activate As String, statusid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("update tbfreserve set roomtypeid='" & roomtypeid & "', locationid='" & locationid & "', phone_ext='" & phone_ext & "', room_id='" & room_id & "', des='" & des & "', activate='" & activate & "', statusid='" & statusid & "' where roomid='" & roomid & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 roomid from tbfroom order by roomid desc", cn.conn)
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

    Public Function loadtbfroom(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbfreserve", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ລະຫັດຫ້ອງ"
                .Columns(1).HeaderText = "ລະຫັດປະເພດຫ້ອງ"
                .Columns(2).HeaderText = "ລະຫັດສະຖານທີ"
                .Columns(3).HeaderText = "ໂທລະສັບ"
                .Columns(4).HeaderText = "ລະຫັດຫ້ອງ"
                .Columns(5).HeaderText = "ລາຍລະອຽດ"
                .Columns(6).HeaderText = "ໃຊ້ງານ"
                .Columns(7).HeaderText = "ລະຫັດສະຖານະ"
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

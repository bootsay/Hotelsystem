Imports System.Data.SqlClient
Public Class tbchangeroom
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(changeroomid As Integer, userid As Integer, roomid As Integer, toroomid As Integer, datechange As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbchangeroom(changeroomid,userid,roomid,toroomid,datechange)values('" & changeroomid & "','" & userid & "','" & roomid & "','" & toroomid & "','" & datechange & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(changeroomid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbchangeroom where changeroomid='" & changeroomid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update(changeroomid As Integer, userid As Integer, roomid As Integer, toroomid As Integer, datechange As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbfroomrate set userid='" & userid & "', roomid='" & roomid & "', toroomid='" & toroomid & "', datechange='" & datechange & "' where changeroomid='" & changeroomid & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 changeroomid from tbfroomrate order by changeroomid desc", cn.conn)
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

    Public Function loadtbchangeroom(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbfroomrate", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ລະຫັດປ່ຽນຫ້ອງ"
                .Columns(1).HeaderText = "ລະຫັດຜູ້ໃຊ້"
                .Columns(2).HeaderText = "ລະຫັດຫ້ອງ"
                .Columns(3).HeaderText = "ລະຫັດຍ້າຍຫ້ອງໄປ"
                .Columns(4).HeaderText = "ວັນທີຍ້າຍ"
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

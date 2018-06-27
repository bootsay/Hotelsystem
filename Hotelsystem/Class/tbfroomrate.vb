Imports System.Data.SqlClient
Public Class tbfroomrate
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(roomrateid As Integer, roomtypeid As Integer, roomtyperateid As Integer, price As Double, des As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbfroomrate(roomrateid,roomtypeid,roomtyperateid,price,des)values('" & roomrateid & "','" & roomtypeid & "','" & roomtyperateid & "','" & price & "','" & des & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(roomrateid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfroomrate where roomrateid='" & roomrateid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update(roomrateid As Integer, roomtypeid As Integer, roomtyperateid As Integer, price As Double, des As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbfroomrate set roomtypeid='" & roomtypeid & "', price='" & price & "', des='" & des & "' where roomrateid='" & roomrateid & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 roomrateid from tbfroomrate order by roomrateid desc", cn.conn)
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

    Public Function loadtbfroomrate(dgv As DataGridView)
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
                .Columns(0).HeaderText = "ລະຫັດລາຄາຫ້ອງ"
                .Columns(1).HeaderText = "ລະຫັດປະເພດຫ້ອງ"
                .Columns(2).HeaderText = "ລະຫັດປະເພດລາຄາຫ້ອງ"
                .Columns(3).HeaderText = "ລາຄາ"
                .Columns(4).HeaderText = "ຄຳອະທິບາຍ"
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

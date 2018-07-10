Imports System.Data.SqlClient
Public Class tbfroomtype
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(roomtypeid As Integer, roomtypename As String, extrabedprice As Double, max_person As Integer, des As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbfroomtype(roomtypeid,romtypename,extrabedprice,max_person,des)values('" & roomtypeid & "','" & roomtypename & "','" & extrabedprice & "','" & max_person & "','" & des & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(roomtypeid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfroomtype where roomtypeid='" & roomtypeid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update(roomtypeid As Integer, roomtypename As String, extrabedprice As Double, max_person As Integer, des As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbfroomtype set romtypename='" & roomtypename & "', extrabedprice='" & extrabedprice & "', max_person='" & max_person & "', des='" & des & "' where roomtypeid='" & roomtypeid & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 roomtypeid from tbfroomtype order by roomtypeid desc", cn.conn)
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
            da = New SqlDataAdapter("select * from tbfroomtype", cn.conn)
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
                .Columns(2).HeaderText = "ລາຄາຕຽງພິເສດ"
                .Columns(3).HeaderText = "ຈຳນວນຄົນສູງສຸດ"
                .Columns(4).HeaderText = "ຄຳອະທິບາຍ"
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function comboroomtype(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tbfroomtype order by roomtypeid desc", cn.conn)
            da.Fill(dt)
            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("romtypename").ToString
                .ValueMember = dt.Columns("roomtypeid").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

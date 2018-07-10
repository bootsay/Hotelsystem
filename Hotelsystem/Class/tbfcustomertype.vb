Imports System.Data.SqlClient
Public Class tbfcustomertype
    Dim cn As New connectdb
    Dim re As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand

    Public Function save(customertypeid As Integer, customertypename As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbfcustomertype(customertypeid,customertypename) values('" & customertypeid & "',N'" & customertypename & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(customertypeid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfcustomertype where customertypeid='" & customertypeid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່?", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function

    Public Function update(customertypeid As Integer, customertypename As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbfcustomertype set customertypename=N'" & customertypename & "' where customertypeid='" & customertypeid & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 customertypeid from tbfcustomertype order by customertypeid desc", cn.conn)
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

    Public Function loadtbfcustomertype(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbfcustomertype", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ປະເພດລູກຄ້າ"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
        End Try
        Return True
    End Function
    Public Function combocustomertype(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tbfcustomertype order by customertypeid desc", cn.conn)
            da.Fill(dt)

            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("customertypename").ToString
                .ValueMember = dt.Columns("customertypeid").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    'Public Function Selectcustomertype(cb As ComboBox)
    '    cn.connect()
    '    Dim dt As New DataTable
    '    Try
    '        da = New SqlDataAdapter("select * from tbfcustomertype order by customertypeid desc", cn.conn)
    '        da.Fill(dt)
    '        With cb
    '            .DataSource = dt
    '            .DisplayMember = dt.Columns("customertypename").ToString
    '            .ValueMember = dt.Columns("customertypeid").ToString
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    '    Return True
    'End Function
End Class

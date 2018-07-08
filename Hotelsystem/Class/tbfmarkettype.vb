Imports System.Data.SqlClient
Public Class tbfmarkettype
    Dim cn As New connectdb
    Dim re As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand

    Public Function save(markettypeid As Integer, markettypename As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbfmarkettype(markettypeid,markettypename) values('" & markettypeid & "',N'" & markettypename & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(markettypeid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfmarkettype where markettypeid='" & markettypeid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່?", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function

    Public Function update(markettypeid As Integer, markettypename As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbfmarkettype set markettypename=N'" & markettypename & "' where markettypeid='" & markettypeid & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 markettypeid from tbfmarkettype order by markettypeid desc", cn.conn)
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

    Public Function loadtbmarkettype(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbfmarkettype", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ປະເພດຕະຫຼາດ"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function combomarkettype(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tbfmarkettype", cn.conn)
            da.Fill(dt)

            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("markettypename").ToString
                .ValueMember = dt.Columns("markettypeid").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

End Class

Imports System.Data.SqlClient
Public Class tbvillage
    Dim cn As New connectdb
    Dim re As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Public Function save(villageid As Integer, districtid As Integer, villagename As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbvillage(villageid,districtid,villagename) values('" & villageid & "','" & districtid & "',N'" & villagename & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(villageid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbvillage where villageid='" & villageid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່?", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function

    Public Function update(villageid As Integer, districtid As Integer, villagename As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbvillage set districtid=N'" & districtid & "',villagename=N'" & villagename & "' where villageid='" & villageid & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 villageid from tbvillage order by villageid desc", cn.conn)
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

    Public Function loadtbvillage(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewvillage  order by villageid", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ແຂວງ"
                .Columns(2).HeaderText = "ເມືອງ"
                .Columns(3).HeaderText = "ບ້ານ"
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function combovillage(districtid As Integer, cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tbvillage where districtid='" & districtid & "'", cn.conn)
            da.Fill(dt)

            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("villagename").ToString
                .ValueMember = dt.Columns("villageid").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function comboboxvillage(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tbvillage ", cn.conn)
            da.Fill(dt)

            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("villagename").ToString
                .ValueMember = dt.Columns("villageid").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

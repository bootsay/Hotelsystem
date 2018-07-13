Imports System.Data.SqlClient
Public Class tbposition
    Dim cn As New connectdb
    Dim re As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand

    Public Function save(positionid As Integer, deptid As Integer, positionname As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbposition(positionid,deptid,positionname) values('" & positionid & "','" & deptid & "',N'" & positionname & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່?", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(positionid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbposition where positionid='" & positionid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່?", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລືບໃດ້ ເນື່ອງຈາກຂໍ້ມູນມີການໃຊ້ງານ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function

    Public Function update(positionid As Integer, deptid As Integer, positionname As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbposition set deptid=N'" & deptid & "',positionname=N'" & positionname & "' where positionid='" & positionid & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 positionid from tbposition order by positionid desc", cn.conn)
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

    Public Function loadtbposition(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewposition order by positionid", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .Columns(0).HeaderText = "ລະຫັດ"
                .Columns(1).HeaderText = "ພະແນກ"
                .Columns(2).HeaderText = "ຕຳແໜ່ງ"
                .Columns(3).Visible = False
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Function comboposition(cb As ComboBox)
        cn.connect()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from tbposition  order by positionid desc", cn.conn)
            da.Fill(dt)

            With cb
                .DataSource = dt
                .DisplayMember = dt.Columns("positionname").ToString
                .ValueMember = dt.Columns("positionid").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

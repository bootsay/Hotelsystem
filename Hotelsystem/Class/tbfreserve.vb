Imports System.Data.SqlClient
Public Class tbfreserve
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(reserveNo As String, reserveid As Integer, customerNo As String, roomid As String, datereserve As String, datecheckin As String, datecheckout As String, numberofpax As Integer, remark As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbfreserve(reserveNo,reserveid,customerNO,roomid,datereserve,datecheckin,datecheckout,numberofpax,remark)values('" & reserveNo & "','" & reserveid & "','" & customerNo & "','" & roomid & "','" & datereserve & "','" & datecheckin & "','" & datecheckout & "','" & numberofpax & "',N'" & remark & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(reserveid As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfreserve where reserveid='" & reserveid & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update(reserveNo As String, reserveid As Integer, customerNo As String, roomid As String, datereserve As String, datecheckin As String, datecheckout As String, numberofpax As Integer, remark As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbfreserve set customerNO='" & customerNo & "', roomid='" & roomid & "', datereserve='" & datereserve & "', datecheckin='" & datecheckin & "', datecheckout='" & datecheckout & "', numberofpax='" & numberofpax & "', remark='" & remark & "' where reserveNO='" & reserveNo & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂແທ້ບໍ່", "ແກ້ໄຂ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function runidNO()
        cn.connect()
        Dim id As String = Nothing
        Dim idorder As Integer
        Dim length As Integer = 4
        Try
            cm = New SqlCommand("select top 1 reserveid from tbfreserve order by reserveid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    idorder = re.GetValue(0) + 1
                End While
            Else
                idorder = 1
            End If
            id = idorder
            id = String.Format("{0}{1}", "R", idorder.ToString().PadLeft(length, "0"))
            re.Close()
            cm.Dispose()
            cn.conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    Public Function runid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 reserveid from tbfreserve order by reserveid desc", cn.conn)
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

    Public Function loadtbfreserve(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewreserve", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).Visible = False
                .Columns(1).HeaderText = "ເລກທີສັງຈອງ"
                .Columns(2).HeaderText = "ຊື່ລູກຄ້າ"
                .Columns(3).HeaderText = "ເບີຫ້ອງ"
                .Columns(4).HeaderText = "ວັນທີຈອງ"
                .Columns(5).HeaderText = "ວັນທີເຂົ້າ"
                .Columns(6).HeaderText = "ວັນທີອອກ"
                .Columns(7).HeaderText = "ຈຳນວນຄົນ"
                .Columns(8).HeaderText = "ຄຳອະທິບາຍ"
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

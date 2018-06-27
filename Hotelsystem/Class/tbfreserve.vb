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
            cm = New SqlCommand("insert into tbexchange(reserveNo,reserveid,customerNO,roomid,datereserve,datecheckin,datechecout,numberofpax,remark)values('" & reserveNo & "','" & reserveid & "','" & customerNo & "','" & roomid & "','" & datereserve & "','" & datecheckin & "','" & datecheckout & "','" & numberofpax & "','" & remark & "')", cn.conn)
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
            cm = New SqlCommand("delete from tbfreserve where reserveNO='" & reserveid & "'", cn.conn)
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

    Public Function runid()
        cn.connect()
        Dim id As Integer
        Try
            cm = New SqlCommand("select top 1 reserveNo from tbfreserve order by reserveNo desc", cn.conn)
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
            da = New SqlDataAdapter("select * from tbfreserve", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ເລກທີ"
                .Columns(1).HeaderText = "ລະຫັດສັງຈອງ"
                .Columns(2).HeaderText = "ລະຫັດລູກຄ້າ"
                .Columns(3).HeaderText = "ລະຫັດຫ້ອງ"
                .Columns(4).HeaderText = "ວັນທີຈອງ"
                .Columns(5).HeaderText = "ວັນທີເຂົ້າ"
                .Columns(6).HeaderText = "ວັນທີອອກ"
                .Columns(7).HeaderText = "ຈຳນວນຄົນ"
                .Columns(8).HeaderText = "ຄຳອະທິບາຍ"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

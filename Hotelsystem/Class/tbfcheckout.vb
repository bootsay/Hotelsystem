Imports System.Data.SqlClient
Public Class tbfcheckout
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader

    Public Function save(checkoutNO As String, checkoutid As Integer, customerNO As String, datecheckout As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbfcheckout(checkoutNO,checkoutid,customerNO,datecheckout)values('" & checkoutNO & "','" & checkoutid & "','" & customerNO & "','" & datecheckout & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(checkoutNO As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfcheckout where checkoutNO='" & checkoutNO & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update(checkoutNO As String, checkoutid As Integer, customerNO As String, datecheckout As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbfcheckout set checkoutid='" & checkoutid & "', customerNO='" & customerNO & "', datecheckout='" & datecheckout & "' where checkoutNO='" & checkoutNO & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 checkoutNO from tbfcheckout order by checkoutNO desc", cn.conn)
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

    Public Function loadtbfcheckout(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from tbfcheckout", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()

            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ເລກທີແຈ້ງອອກ"
                .Columns(1).HeaderText = "ລະຫັດແຈ້ງອອກ"
                .Columns(2).HeaderText = "ເລກທີລູກຄ້າ"
                .Columns(3).HeaderText = "ວັນທີແຈ້ງອອກ"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

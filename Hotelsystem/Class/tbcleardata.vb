Imports System.Data.SqlClient
Public Class tbcleardata
    Dim cn As New connectdb
    Dim cm As New SqlCommand
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Public Function deleteBilldetail()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfBilldetail", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deleteBill()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfBill", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deletetbfreserve()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfreserve", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deleteitemlist()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbitemlist", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deletecheckout()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfcheckout", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deletecheckin()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbfcheckin", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deletevillage()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbvillage", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deletedistrict()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbdistrict", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deleteprovience()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbprovince", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function deletecountry()
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbcountry", cn.conn)
            cm.ExecuteNonQuery()
            cm.Dispose()
            cn.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

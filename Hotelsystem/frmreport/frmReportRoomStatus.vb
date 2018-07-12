Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmReportRoomStatus
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt, dt1, dt2 As New DataTable
    Dim cm As New SqlCommand
    Dim markettype As New tbfbookingtype
    Dim cry As New CryReportRoomStatus
    'Dim data1 As New mydata
    Dim dttt As New DataTable
    Public sup_id As String
    Dim roomlocation As New tbfroomlocation
    Public frmreportsaledetail As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Frmreport_Sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            roomlocation.comboroomlocation(cblocation)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btncry_Click(sender As Object, e As EventArgs) Handles btncry.Click
        Try
            Dim subname As String = Nothing
            If cblocation.SelectedValue = 0 Then
                subname = "%"
            Else
                Dim rows As DataRowView = cblocation.SelectedItem
                Dim row As DataRow = rows.Row
                'subname = row(3).ToString
            End If
            dt.Clear()
            cn.connect()
            cm = New SqlCommand("select * from viewroom where locationname like N'%" & subname & "%'ORDER BY roomid ASC", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With
            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetDataSource(dt)
            'cry.SetParameterValue("dt1", date1.Text)
            'cry.SetParameterValue("dt2", date2.Text)
            CrystalReportViewer1.ReportSource = cry
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Private Sub txtcustomer_TextChanged(sender As Object, e As EventArgs) Handles txtcustomer.TextChanged

    '    dt.Clear()
    '    cn.connect()
    '    cm = New SqlCommand("select * from viewsaledetail where companyname like N'%" & txtcustomer.Text & "%' and approve='YES' and statusid<>4 ORDER BY saleNO ASC", cn.conn)
    '    With da
    '        .SelectCommand = cm
    '        .Fill(dt)
    '    End With
    '    'cry.SetDatabaseLogon(cn.user, cn.password)
    '    'cry.SetDataSource(dt)
    '    'cry.SetParameterValue("dt1", date1.Text)
    '    'cry.SetParameterValue("dt2", date2.Text)
    '    'CrystalReportViewer1.ReportSource = cry
    'End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub date1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Dim subname As String = Nothing
            If cblocation.SelectedValue = 0 Then
                subname = "%"
            Else
                'Dim rows As DataRowView = cblocation.SelectedItem
                'Dim row As DataRow = rows.Row
                'subname = row(3).ToString
            End If
            dt.Clear()
            cn.connect()
            cm = New SqlCommand("select * from viewroom ORDER BY roomid ASC", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With
            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetDataSource(dt)
            'cry.SetParameterValue("dt1", date1.Text)
            'cry.SetParameterValue("dt2", date2.Text)
            CrystalReportViewer1.ReportSource = cry
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
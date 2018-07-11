Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmReportGroupCheckinGraph
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt, dt1, dt2 As New DataTable
    Dim cm As New SqlCommand
    Dim markettype As New tbfbookingtype
    Dim cry As New CryReportGroupCheckinGraph
    Dim dttt As New DataTable
    Public sup_id As String
    Public frmreportsaledetail As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Frmreport_Sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    markettype.combobookingtype(cbmarkettry)
        '    cbmarkettry.SelectedValue = 0
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub btncry_Click(sender As Object, e As EventArgs) Handles btncry.Click
        Try
            dt.Clear()
            cn.connect()
            cm = New SqlCommand("select * from viewcheckin where checkindate>='" & Format(CDate(date1.Text), "MM/dd/yyyy") & "'and checkindate<='" & Format(CDate(date2.Text), "MM/dd/yyyy") & "' and statusid=2  ORDER BY checkinNO ASC", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With
            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetDataSource(dt)
            cry.SetParameterValue("dt1", date1.Text)
            cry.SetParameterValue("dt2", date2.Text)
            CrystalReportViewer1.ReportSource = cry
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
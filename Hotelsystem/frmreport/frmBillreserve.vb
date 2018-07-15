Imports System.Data.SqlClient
Public Class frmBillreserve
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim dtt As New DataTable
    Dim mydataset As New ReportDataset
    Private Sub frmBillcheckin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.connect()
        'Try
        Dim fmin As frmreserve = DirectCast(Application.OpenForms("frmreserve"), frmreserve)
        dt.Clear()
        dtt.Clear()
        mydataset.viewreserve.Clear()
        mydataset.tbcompanyprofile.Clear()

        Dim dda As New SqlDataAdapter
        dda = New SqlDataAdapter("select * from tbcompanyprofile", cn.conn)
        dda.Fill(mydataset.tbcompanyprofile)
        dtt = mydataset.tbcompanyprofile

        da = New SqlDataAdapter("select * from viewreserve where reserveNO='" & fmin.dgvlist.CurrentRow.Cells(0).Value & "'", cn.conn)
        da.Fill(mydataset.viewreserve)
        dt = mydataset.viewreserve
        Dim cry As New billReserved
        cry.SetDatabaseLogon(cn.user, cn.password)
        cry.Database.Tables("tbcompanyprofile").SetDataSource(dtt)
        cry.Database.Tables("viewreserve").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cry

        'Catch ex As Exception
        '    m()
        'End Try
    End Sub
End Class
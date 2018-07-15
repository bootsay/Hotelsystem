Imports System.Data.SqlClient
Public Class frmBillcheckin
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim dtt As New DataTable
    Dim mydataset As New ReportDataset
    Private Sub frmBillcheckin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.connect()
        'Try
        Dim fmin As frmcheckin = DirectCast(Application.OpenForms("frmcheckin"), frmcheckin)
        dt.Clear()
        dtt.Clear()
        mydataset.viewcheckin.Clear()
        mydataset.tbcompanyprofile.Clear()

        Dim dda As New SqlDataAdapter
        dda = New SqlDataAdapter("select * from tbcompanyprofile", cn.conn)
        dda.Fill(mydataset.tbcompanyprofile)
        dtt = mydataset.tbcompanyprofile

        da = New SqlDataAdapter("select * from viewcheckin where checkinNO='" & fmin.dgvlist.CurrentRow.Cells(0).Value & "'", cn.conn)
        da.Fill(mydataset.viewcheckin)
        dt = mydataset.viewcheckin
        Dim cry As New billCheckin
        cry.SetDatabaseLogon(cn.user, cn.password)
        cry.Database.Tables("tbcompanyprofile").SetDataSource(dtt)
        cry.Database.Tables("viewcheckin").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cry

        'Catch ex As Exception
        '    m()
        'End Try
    End Sub
End Class
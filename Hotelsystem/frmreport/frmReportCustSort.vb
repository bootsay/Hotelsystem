﻿Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmReportCustSort
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt, dt1, dt2 As New DataTable
    Dim cm As New SqlCommand
    Dim markettype As New tbfbookingtype
    Dim cry As New CryReportCustSort
    'Dim data1 As New mydata
    Dim dttt As New DataTable
    Public sup_id As String
    Public frmreportsaledetail As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Frmreport_Sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            markettype.combobookingtype(cbmarkettry)
            'cbmarkettry.SelectedValue = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btncry_Click(sender As Object, e As EventArgs) Handles btncry.Click
        'Try
        Dim subname As String = cbmarkettry.Text
        If cbmarkettry.SelectedValue = 0 Then
            subname = "%"
        Else
            'Dim rows As DataRowView = cbmarkettry.SelectedItem
            'Dim row As DataRow = rows.Row
            ''subname = row(3).ToString
        End If
        dt.Clear()
        cn.connect()
        cm = New SqlCommand("select * from viewcheckin where checkindate>='" & Format(CDate(date1.Text), "MM/dd/yyyy") & "'and checkindate<='" & Format(CDate(date2.Text), "MM/dd/yyyy") & "' and  bookingtypename like N'%" & subname & "%' and statusid=3  ORDER BY checkinNO ASC", cn.conn)
        With da
            .SelectCommand = cm
            .Fill(dt)
        End With
        cry.SetDatabaseLogon(cn.user, cn.password)
        cry.SetDataSource(dt)
        cry.SetParameterValue("StartDate", date1.Text)
        cry.SetParameterValue("EndDate", date2.Text)
        CrystalReportViewer1.ReportSource = cry
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
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
End Class
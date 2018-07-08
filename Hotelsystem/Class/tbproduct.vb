Imports System.Data.SqlClient
Public Class tbproduct
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim re As SqlDataReader
    Public Function runidNO()
        cn.connect()
        Dim id As String = Nothing
        Dim idorder As Integer
        Dim length As Integer = 4
        Try
            cm = New SqlCommand("select top 1 proid from tbproduct order by proid desc", cn.conn)
            re = cm.ExecuteReader
            If re.HasRows Then
                While re.Read
                    idorder = re.GetValue(0) + 1
                End While
            Else
                idorder = 1
            End If
            id = idorder
            id = String.Format("{0}{1}", "P", idorder.ToString().PadLeft(length, "0"))
            re.Close()
            cm.Dispose()
            cn.conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function
    'Public Function runid()
    '    cn.connect()
    '    Dim id As Integer
    '    Try
    '        cm = New SqlCommand("select top 1 proid from tbproduct order by proid desc", cn.conn)
    '        re = cm.ExecuteReader
    '        If re.HasRows Then
    '            While re.Read
    '                id = re.GetValue(0).ToString + 1
    '            End While
    '        Else
    '            id = "1"
    '        End If
    '    Catch ex As Exception

    '    End Try
    '    Return id
    'End Function

    Public Function save(productNO As Integer, proid As Integer, cateid As Integer, proname As String, unitid As Integer, pricebuy As Double, pricesale As Double, stockqty As Integer, activate As String)
        cn.connect()
        Try
            cm = New SqlCommand("insert into tbproduct(productNO,proid,cateid,proname,unitid,pricebuy,pricesale,stockqty,remark)values('" & productNO & "','" & proid & "','" & cateid & "','" & proname & "','" & unitid & "','" & pricebuy & "','" & pricesale & "','" & stockqty & "','" & activate & "')", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການບັນທືກແທ້ບໍ່", "ບັນທືກ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function delete(productNO As Integer)
        cn.connect()
        Try
            cm = New SqlCommand("delete from tbproduct where productNO='" & productNO & "'", cn.conn)
            If MessageBox.Show("ທ່ານຕ້ອງການລືບແທ້ບໍ່", "ລືບ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                cm.ExecuteNonQuery()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function

    Public Function update(productNO As Integer, proid As Integer, cateid As Integer, proname As String, unitid As Integer, pricebuy As Double, pricesale As Double, stockqty As Integer, activate As String)
        cn.connect()
        Try
            cm = New SqlCommand("update tbproduct set proid='" & proid & "', cateid='" & cateid & "', proname='" & proname & "', unitid='" & unitid & "', pricebuy='" & pricebuy & "', pricesale='" & pricesale & "', stockqty='" & stockqty & "', activate='" & activate & "' where productNO='" & productNO & "'", cn.conn)
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
            cm = New SqlCommand("select top 1 productNO from tbproduct order by productNO desc", cn.conn)
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

    Public Function loadtbproduct(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewproduct", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).HeaderText = "ລະຫັດສິນຄ້າ"
                .Columns(1).HeaderText = "ລະຫັດປະເພດສິນຄ້າ"
                .Columns(2).HeaderText = "ຊື່ສິນຄ້າ"
                .Columns(3).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(4).HeaderText = "ລາຄາຊື້"
                .Columns(5).HeaderText = "ລາຄາຂາຍ"
                .Columns(6).HeaderText = "ຈຳນວນສະຕ໋ອກ"
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadtbproductitemlist(dgv As DataGridView)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewproduct", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ຊື່ສິນຄ້າ"
                .Columns(3).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(4).Visible = False
                .Columns(5).HeaderText = "ລາຄາຂາຍ"
                .Columns(6).HeaderText = "ຈຳນວນສະຕ໋ອກ"
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                '.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                '.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    Public Function loadtbproductitemlistearch(dgv As DataGridView, name As String)
        cn.connect()
        Try
            da = New SqlDataAdapter("select * from viewproduct where proname like N'%" & name & "%'", cn.conn)
            da.Fill(ds, "pt")
            ds.Tables.Clear()
            da.Fill(ds, "pt")
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
            With dgv
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "ຊື່ສິນຄ້າ"
                .Columns(3).HeaderText = "ຫົວໜ່ວຍ"
                .Columns(4).Visible = False
                .Columns(5).HeaderText = "ລາຄາຂາຍ"
                .Columns(6).HeaderText = "ຈຳນວນສະຕ໋ອກ"
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
                '.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                '.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                '.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
End Class

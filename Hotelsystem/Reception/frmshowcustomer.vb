Public Class frmshowcustomer
    Dim customer As New tbcustomer
    Dim custype As New tbfcustomertype
    Dim custype1 As String
    Public createreserve As Boolean = False
    Private Sub frmshowcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            customer.loadtbcustomer(dgvcus)
            custype.combocustomertype(cbtype)
            rname.Checked = True
            txtsearch.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rtype_CheckedChanged(sender As Object, e As EventArgs) Handles rtype.CheckedChanged
        If rtype.Checked = True Then
            txtsearch.Visible = False
            cbtype.Visible = True
        Else
            txtsearch.Visible = True
            cbtype.Visible = False
        End If
    End Sub

    Private Sub rname_CheckedChanged(sender As Object, e As EventArgs) Handles rname.CheckedChanged
        If rname.Checked = True Then
            txtsearch.Clear()
            txtsearch.Select()
        End If
    End Sub

    Private Sub cbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtype.SelectedIndexChanged
        Try
            If rtype.Checked = True Then
                txtsearch.Text = "%"
                customer.loadtbcustomerType(dgvcus, cbtype.SelectedValue)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            Dim custype1 As String = "%"
            Dim p As String = "%"
            Dim d As String = "%"
            Dim b As String = "%"
            'sup.showsuppliers(custype1, dgvcus, p, d, b)
            With dgvcus
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            If rname.Checked = True Then
                custype1 = "%"
                customer.loadtbcustomerName(dgvcus, txtsearch.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvcus_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcus.CellMouseEnter

    End Sub

    Private Sub dgvcus_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvcus.CellMouseUp
        Try
            With dgvcus
                If frmreserve.frmcreatereserve = True Then
                    frmreserve.txtcustomerid.Text = .CurrentRow.Cells(1).Value
                    frmreserve.txtcustomername.Text = .CurrentRow.Cells(4).Value
                    frmreserve.txtprice.Text = .CurrentRow.Cells(15).Value
                    Me.Close()
                End If
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvcus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcus.CellContentClick

    End Sub
End Class
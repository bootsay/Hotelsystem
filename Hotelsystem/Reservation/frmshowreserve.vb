Public Class frmshowreserve
    Dim room As New tbfroom
    Dim reserve As New tbfreserve
    'Dim level As New tbfroomlocation
    Private Sub frmshowunit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            room.loadtbfroomshow(dgvroom)
            'roomrtype.comboroomtype(cbroom)
            'level.comboroomlocation(cblevel)
            rdname.Checked = True
            txtsearch.Select()

            If rdreserve.Checked = True Then
                txtsearch.Visible = False
                cbroom.Visible = True
            Else
                txtsearch.Visible = True
                cbroom.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub dgvunit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvroom.CellClick
        'Try
        'If frmsale.formsale = True Then
        '    With dgvunit
        '        frmsale.dgvsale.CurrentRow.Cells(2).Value = .CurrentRow.Cells(0).Value
        '        If frmsale.cbprice.SelectedIndex = 1 Then
        '            frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(2).Value
        '        ElseIf frmsale.cbprice.SelectedIndex = 2 Then
        '            frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(3).Value
        '        ElseIf frmsale.cbprice.SelectedIndex = 3 Then
        '            frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(4).Value
        '        ElseIf frmsale.cbprice.SelectedIndex = 4 Then
        '            frmsale.dgvsale.CurrentRow.Cells(3).Value = .CurrentRow.Cells(5).Value
        '        End If
        '        frmsale.dgvsale.CurrentRow.Cells(9).Value = .CurrentRow.Cells(1).Value
        '        Me.Close()
        '    End With
        'ElseIf frmproduct1.formproduct = True Then
        '    With dgvunit
        '        frmproduct1.dgvprice.CurrentRow.Cells(2).Value = .CurrentRow.Cells(1).Value
        '        frmproduct1.dgvprice.CurrentRow.Cells(8).Value = .CurrentRow.Cells(0).Value
        '        Me.Close()
        '    End With
        'ElseIf frmcreatereserve.formcreateorder = True Then
        '    With dgvunit
        '        frmcreatereserve.dgvlist.CurrentRow.Cells(2).Value = .CurrentRow.Cells(0).Value
        '        frmcreatereserve.dgvlist.CurrentRow.Cells(6).Value = .CurrentRow.Cells(1).Value
        '    End With
        '    Me.Close()
        'End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If rdname.Checked = True Or rdreserve.Checked = True Then
                    cbroom.Text = "%"
                    reserve.loadtbfreserveSearchbyidorname(dgvroom, txtsearch.Text)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

    End Sub

    Private Sub rtype_CheckedChanged(sender As Object, e As EventArgs) Handles rdreserve.CheckedChanged
        If rdreserve.Checked = True Then
            txtsearch.Visible = True
            cbroom.Visible = False
            dt1.Visible = False
            dt11.Visible = False
            dt2.Visible = False
        Else
            txtsearch.Visible = True
            cbroom.Visible = False
            dt1.Visible = False
            dt11.Visible = False
            dt2.Visible = False
        End If
    End Sub

    Private Sub rname_CheckedChanged(sender As Object, e As EventArgs) Handles rdname.CheckedChanged
        If rdname.Checked = True Then
            txtsearch.Visible = True
            cbroom.Visible = False
            dt1.Visible = False
            dt11.Visible = False
            dt2.Visible = False
        Else
            txtsearch.Visible = True
            cbroom.Visible = False
            dt1.Visible = False
            dt11.Visible = False
            dt2.Visible = False
        End If
    End Sub

    Private Sub dgvroom_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvroom.CellMouseUp
        Try
            With dgvroom
                If frmreserve.frmcreatereserve = True Then
                    frmreserve.txtroomid.Text = .CurrentRow.Cells(0).Value
                    frmreserve.txtroomno.Text = .CurrentRow.Cells(3).Value
                    Me.Close()
                End If
            End With
        Catch ex As Exception

        End Try

    End Sub
    Private Sub rlevel_CheckedChanged(sender As Object, e As EventArgs) Handles rdroom.CheckedChanged
        If rdroom.Checked = True Then
            txtsearch.Visible = False
            cbroom.Visible = True
            dt1.Visible = False
            dt11.Visible = False
            dt2.Visible = False
        Else
            txtsearch.Visible = True
            cbroom.Visible = False
            dt1.Visible = False
            dt11.Visible = False
            dt2.Visible = False
        End If
    End Sub

    Private Sub cbroom_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbroom.SelectionChangeCommitted
        Try
            If rdreserve.Checked = True Then
                txtsearch.Text = "%"
                reserve.loadtbfreserveSearchbyroom(dgvroom, cbroom.SelectedValue)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rddate_CheckedChanged(sender As Object, e As EventArgs) Handles rddate.CheckedChanged
        If rddate.Checked = True Then
            txtsearch.Visible = False
            cbroom.Visible = False
            dt1.Visible = True
            dt11.Visible = True
            dt2.Visible = True
        Else
            txtsearch.Visible = True
            cbroom.Visible = False
            dt1.Visible = False
            dt11.Visible = False
            dt2.Visible = False
        End If
    End Sub

    Private Sub dt2_ValueChanged(sender As Object, e As EventArgs) Handles dt2.ValueChanged
        Try
            If rddate.Checked = True Then
                cbroom.Text = "%"
                reserve.loadtbfreserveSearchbydate(dgvroom, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged
        Try
            If rddate.Checked = True Then
                cbroom.Text = "%"
                reserve.loadtbfreserveSearchbydate(dgvroom, Format(CDate(dt1.Text), "MM/dd/yyyy"), Format(CDate(dt2.Text), "MM/dd/yyyy"))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbroom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbroom.SelectedIndexChanged

    End Sub
End Class
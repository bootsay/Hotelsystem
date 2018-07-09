Public Class frmshowroomreserve
    Dim room As New tbfroom
    Dim roomrtype As New tbfroomtype
    Dim level As New tbfroomlocation
    Private Sub frmshowunit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            room.loadtbfroomshow(dgvroom)
            roomrtype.comboroomtype(cbtype)
            level.comboroomlocation(cblevel)
            rname.Checked = True
            txtsearch.Select()

            If rtype.Checked = True Then
                txtsearch.Visible = False
                cbtype.Visible = True
            Else
                txtsearch.Visible = True
                cbtype.Visible = False
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

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            If rname.Checked = True Then
                cbtype.Text = "%"
                cblevel.Text = "%"
                room.loadtbfroomName(dgvroom, txtsearch.Text)
            End If
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
                cblevel.Text = "%"
                'MessageBox.Show(cbtype.SelectedValue)
                room.loadtbfroomType(dgvroom, cbtype.SelectedValue)

            End If
        Catch ex As Exception

        End Try
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
    Private Sub rlevel_CheckedChanged(sender As Object, e As EventArgs) Handles rlevel.CheckedChanged
        If rlevel.Checked = True Then
            txtsearch.Visible = False
            cbtype.Visible = False
            cblevel.Visible = True
        Else
            txtsearch.Visible = True
            cbtype.Visible = False
            cblevel.Visible = False
        End If
    End Sub

    Private Sub cblevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cblevel.SelectedIndexChanged
        Try
            If rlevel.Checked = True Then
                txtsearch.Text = "%"
                cbtype.Text = "%"
                room.loadtbfroomLevel(dgvroom, cblevel.SelectedValue)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvroom_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvroom.CellContentClick

    End Sub
End Class
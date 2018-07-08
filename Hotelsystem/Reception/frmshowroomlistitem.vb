Public Class frmshowroomlistitem
    Dim room As New tbfroom
    Dim roomrtype As New tbfroomtype

    Private Sub frmshowroomitemlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            room.loadtbfroomshowlist(dgvroom)
            roomrtype.comboroomtype(cbtype)
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
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            If rname.Checked = True Then
                cbtype.Text = "%"
                room.loadtbfroomNamelist(dgvroom, txtsearch.Text)
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
                'MessageBox.Show(cbtype.SelectedValue)
                room.loadtbfroomTypelist(dgvroom, cbtype.SelectedValue)

            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgvroom_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvroom.CellMouseUp
        With dgvroom
            If frmitemlist.frmitemlist = True Then
                frmitemlist.txtroomid.Text = .CurrentRow.Cells(0).Value
                frmitemlist.txtroomno.Text = .CurrentRow.Cells(4).Value
                Me.Close()
            End If
        End With
    End Sub

    Private Sub dgvroom_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvroom.CellContentClick

    End Sub
End Class
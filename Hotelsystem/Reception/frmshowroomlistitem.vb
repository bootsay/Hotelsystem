Public Class frmshowroomlistitem
    Dim room As New tbfroom
    Dim roomrtype As New tbfroomtype
    Dim level As New tbfroomlocation
    Private Sub frmshowroomitemlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            room.loadtbfroomshowlist(dgvroom)
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
                cblevel.Text = "%"
                'MessageBox.Show(cbtype.SelectedValue)
                room.loadtbfroomTypelist(dgvroom, cbtype.SelectedValue)

            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgvroom_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvroom.CellMouseUp
        Try
            With dgvroom
                If frmitemlist.frmitemlist = True Then
                    frmitemlist.txtroomid.Text = .CurrentRow.Cells(0).Value
                    frmitemlist.txtroomno.Text = .CurrentRow.Cells(3).Value
                    Me.Close()
                End If
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgvroom_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvroom.CellContentClick

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
                'MessageBox.Show(cbtype.SelectedValue)
                room.loadtbfroomLevellist(dgvroom, cblevel.SelectedValue)

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
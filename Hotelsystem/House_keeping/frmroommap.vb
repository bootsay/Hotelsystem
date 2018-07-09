Public Class frmroommap
    Dim floors As New tbfroomlocation
    Dim roomtype As New tbfroomtype
    Dim rooms As New tbfroom
    Dim dtroom As New DataTable
    Dim roomstatus As Integer
    Dim roomtypename As String
    Dim roomNumber As String
    Private Sub frmroommap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        floors.comboroomlocation(cbfloor)
        cbfloor.SelectedIndex = 0
        roomtype.comboroomtype(cbroomtype)
        dtroom.Clear()
        rooms.getroom(cbfloor.SelectedValue, "%", dtroom)
        froom.Controls.Clear()
        If dtroom.Rows.Count > 0 Then
            For i As Integer = 0 To dtroom.Rows.Count - 1
                Dim btn As New DevComponents.DotNetBar.ButtonX
                AddHandler btn.Click, AddressOf clickme
                btn.Width = 140
                btn.Height = 100
                btn.Font = New System.Drawing.Font("Saysettha OT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                roomstatus = dtroom.Rows(i).Item(10)
                roomtypename = dtroom.Rows(i).Item(1)
                roomNumber = dtroom.Rows(i).Item(4)
                btn.Text = roomNumber + "(" & roomtypename & ")"
                If roomstatus = 1 Then
                    btn.Image = My.Resources.hotel_empty
                    btn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
                ElseIf roomstatus = 2 Then
                    btn.Image = My.Resources.room1
                    btn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
                ElseIf roomstatus = 3 Then
                    btn.Image = My.Resources.hotel_notempty
                    btn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
                ElseIf roomstatus = 4 Then
                    btn.Image = My.Resources.hotel_dirty
                    btn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
                ElseIf roomstatus = 5 Then
                    btn.Image = My.Resources.hotel_outofforder
                    btn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
                ElseIf roomstatus = 6 Then
                    btn.Image = My.Resources.hotel_dirty
                    btn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
                End If
                btn.Name = dtroom.Rows(i).Item(0)
                btn.Visible = True
                froom.Controls.Add(btn)
            Next
        End If
    End Sub
    Private Sub clickme(ByVal sendr As Object, ByVal e As EventArgs)

        frmoption.ShowDialog()
        frmoption.Close()
    End Sub
 
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub cbfloor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbfloor.SelectedIndexChanged
        Try
            dtroom.Clear()

            rooms.getroom(cbfloor.SelectedValue, "%", dtroom)
            froom.Controls.Clear()
            If dtroom.Rows.Count > 0 Then
                For i As Integer = 0 To dtroom.Rows.Count - 1
                    Dim btn As New DevComponents.DotNetBar.ButtonX
                    AddHandler btn.Click, AddressOf clickme
                    btn.Width = 140
                    btn.Height = 100
                    btn.Font = New System.Drawing.Font("Saysettha OT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    btn.Text = dtroom.Rows(i).Item(4)
                    btn.Name = dtroom.Rows(i).Item(0)
                    btn.Visible = True
                    froom.Controls.Add(btn)
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class
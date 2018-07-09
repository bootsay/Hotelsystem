Public Class frmmain
    Public userid As Integer
    Public laoname As String
    Public level As String
    Dim closeform As New formclose
    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

  
    Private Sub category_Click(sender As Object, e As EventArgs) Handles category.Click
        closeform.closeform()
        closeform.f = frmcategory
        closeform.f.MdiParent = Me
        closeform.f.Show()

    End Sub

    Private Sub unit_Click(sender As Object, e As EventArgs) Handles unit.Click
        closeform.closeform()
        closeform.f = frmunit
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub addproduct_Click(sender As Object, e As EventArgs) Handles addproduct.Click
        closeform.closeform()
        closeform.f = frmproduct
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub country_Click(sender As Object, e As EventArgs) Handles country.Click
        closeform.closeform()
        closeform.f = frmcountry
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub provience_Click(sender As Object, e As EventArgs) Handles provience.Click
        closeform.closeform()
        closeform.f = frmprovience
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub district_Click(sender As Object, e As EventArgs) Handles district.Click
        closeform.closeform()
        closeform.f = frmdistrict
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub village_Click(sender As Object, e As EventArgs) Handles village.Click
        closeform.closeform()
        closeform.f = frmvillage
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub hotel_location_Click(sender As Object, e As EventArgs) Handles hotel_location.Click
        closeform.closeform()
        closeform.f = frmroomlocation
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub hotel_roomtype_Click(sender As Object, e As EventArgs) Handles hotel_roomtype.Click
        closeform.closeform()
        closeform.f = frmroomtype
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub hotelroom_Click(sender As Object, e As EventArgs) Handles hotelroom.Click
        closeform.closeform()
        closeform.f = frmroom
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub exchange_Click(sender As Object, e As EventArgs) Handles exchange.Click
        closeform.closeform()
        closeform.f = frmexchange
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub roomratetype_Click(sender As Object, e As EventArgs) Handles roomratetype.Click
        closeform.closeform()
        closeform.f = frmroomtyperate
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub roomrate_Click(sender As Object, e As EventArgs) Handles roomrate.Click
        closeform.closeform()
        closeform.f = frmroomrate
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub titlename_Click(sender As Object, e As EventArgs) Handles titlename.Click
        closeform.closeform()
        closeform.f = frmtitlename
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub customertype_Click(sender As Object, e As EventArgs) Handles customertype.Click
        closeform.closeform()
        closeform.f = frmcustomertype
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub marketing_type_Click(sender As Object, e As EventArgs) Handles marketing_type.Click
        closeform.closeform()
        closeform.f = frmmarkettype
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub customerinfomation_Click(sender As Object, e As EventArgs) Handles customerinfomation.Click
        closeform.closeform()
        closeform.f = frmcustomer
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub usercode_Click(sender As Object, e As EventArgs) Handles usercode.Click
        closeform.closeform()
        closeform.f = frmuser
        closeform.f.MdiParent = Me
        closeform.f.Show()
    End Sub

    Private Sub checkin_Click(sender As Object, e As EventArgs) Handles checkin.Click
        closeform.closeform()
        closeform.f = frmcheckin
        closeform.f.MdiParent = Me
        closeform.f.WindowState = FormWindowState.Normal
        closeform.f.ControlBox = False
        closeform.f.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        closeform.f.Text = ""
        closeform.f.Dock = DockStyle.Fill
        closeform.f.Show()
    End Sub

    Private Sub checkout_Click(sender As Object, e As EventArgs) Handles checkout.Click
        closeform.closeform()
        closeform.f = frmcheckout
        closeform.f.MdiParent = Me
        closeform.f.WindowState = FormWindowState.Normal
        closeform.f.ControlBox = False
        closeform.f.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        closeform.f.Text = ""
        closeform.f.Dock = DockStyle.Fill
        closeform.f.Show()
    End Sub

    Private Sub roominformation_Click(sender As Object, e As EventArgs) Handles roominformation.Click
        closeform.closeform()
        closeform.f = frmroommap
        closeform.f.MdiParent = Me
        closeform.f.Dock = DockStyle.Fill
        closeform.f.Show()
    End Sub

    Private Sub reservation_Click(sender As Object, e As EventArgs) Handles reservation.Click
        closeform.closeform()
        closeform.f = frmreserve
        closeform.f.MdiParent = Me
        closeform.f.WindowState = FormWindowState.Normal
        closeform.f.ControlBox = False
        closeform.f.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        closeform.f.Text = ""
        closeform.f.Dock = DockStyle.Fill
        closeform.f.Show()
    End Sub
End Class

Public Class molding_select

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        display_form(machine_frame)
    End Sub
    Private Sub display_form(form As Form)
        With form
            .Refresh()
            .TopLevel = False
            molding_mainframe.Panel1.Controls.Add(form)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        display_form(resin_frame)
    End Sub
End Class
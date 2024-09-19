
Public Class print_sticker
    Private Sub print_sticker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub display_form(form As Form, tabpage As Panel)
        With form
            .Refresh()
            .TopLevel = False
            tabpage.Controls.Add(form)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub tab_mixed_Click(sender As Object, e As EventArgs) Handles tab_mixed.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles tabcontrol1.TabIndexChanged, MyBase.Load
        display_form(print_sticker_virgin, panel_virgin)
        display_form(print_sticker_recycle, panel_recycle)
        display_form(print_sticker_mixed, panel_mixed)
    End Sub
End Class
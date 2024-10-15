Public Class molding_mainframe
    Private Sub molding_mainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If con.ConnectionString = "server=localhost;user id=momel;password=Magnaye2143@#;database=trcsystem" Then
            error_panel.Visible = True
            display_form(machine_frame)
            'credentials for log in
            fname = "Dev Rommel"
            idno = "03200728"
            designation = "U1-4"

            display_form(machine_frame)
            machine_frame.userstrip.Text = fname

        Else
            display_form(Login)
        End If
    End Sub
End Class
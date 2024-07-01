Imports QRCoder
Public Class qr_generator
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(textinput.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        pic1.Image = code.GetGraphic(6)
    End Sub
End Class
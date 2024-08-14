Imports MySql.Data.MySqlClient
Public Class resin_scan_IN

    Dim partcode As String
    Dim qty As Decimal
    Dim series As String
    Dim type As String


    Private Sub txtqr_matrix_TextChanged(sender As Object, e As EventArgs) Handles txtqr_matrix.TextChanged

    End Sub
    Private Sub processQRcode(qrcode As String)
        Try

            'CONDITION 1 : Split QR
            con.Close()
            Dim parts() As String = qrcode.Split("-")
            If parts.Length >= 3 AndAlso parts.Length <= 4 Then

                partcode = parts(0)
                qty = parts(1)
                series = parts(2)
                type = parts(3)

            Else 'CONDITION 1 : Split QR
                showerror("Invalid QR!")
                con.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()

        End Try

    End Sub
    Private Sub showerror(text As String)
        Try
            labelerror.Text = text
            labelerror.Visible = True
            sounderror()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtqr_matrix_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_matrix.KeyDown
        If e.KeyCode = Keys.Enter Then
            processQRcode(txtqr_matrix.Text)

        End If
    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class delete__resin
    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            processQRcode(txtqr.Text)
            txtqr.Clear()
        End If
    End Sub


    Private Sub processQRcode(qrcode As String)
        Try
            con.Close()
            con.Open()

            ' Check for duplicates and delete based on the serial_code using parameterized query
            Dim selectdata As New MySqlCommand("DELETE FROM molding_resin WHERE serial_code=@serialCode", con)
            selectdata.Parameters.AddWithValue("@serialCode", qrcode)

            selectdata.ExecuteNonQuery()

        Catch ex As Exception
            ' If you want to use a better UI for error messages, replace MessageBox.Show with your preferred method
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class
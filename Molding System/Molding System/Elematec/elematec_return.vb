
Imports MySql.Data.MySqlClient
Public Class elematec_return
    Dim batch As String
    Dim supplier As String

    'duplicate info
    Dim status As String
    Dim located As String
    Dim datein As Date
    Dim partcode As String

    Dim lotnumber As String
    Dim remarks As String
    Dim qty As Integer
    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then

            ProcessQRcode(txtqr.Text)

        End If
    End Sub

    Private Sub ProcessQRcode(qrcode As String)
        Try


            'CON 2 : IF SCANNED
            con.Close()
                con.Open()
            Dim cmdselect As New MySqlCommand("SELECT `qrcode`,`status`,`located`,`datein` FROM `molding_stock` WHERE `qrcode`='" & qrcode & "' LIMIT 1", con)
            dr = cmdselect.ExecuteReader
                If dr.Read = True Then
                Dim status As Integer = dr.GetInt32("status")
                datein = dr.GetDateTime("datein")

                    Select Case status


                    Case 1

                        display_error("Duplicate Entry")

                    Case 0
                        update_molding_stock(qrcode)


                End Select

                Else 'CON 2 : IF NOT SCANNED
                display_error("Record doesn't exist")

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            txtqr.Text = ""

            txtqr.Focus()

        End Try

    End Sub

    Private Sub refreshgrid()
        Try
            datagrid1.Rows.Add(txtqr.Text, partcode, qty, lotnumber)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            con.Close()
        End Try
    End Sub

    Private Sub update_molding_stock(qr As String)
        Try

            con.Close()
            con.Open()
            Dim cmdupdate As New MySqlCommand("UPDATE `molding_stock` SET `status`=1, returned='" & idno & "',pcin='" & PCname & "' WHERE qrcode='" & qr & "'", con)
            cmdupdate.ExecuteNonQuery()
            refreshgrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
End Class
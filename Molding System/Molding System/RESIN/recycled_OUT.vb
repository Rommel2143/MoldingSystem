
Imports MySql.Data.MySqlClient
Public Class recycled_OUT
    Dim status As Integer
    Dim qty_rem As Decimal
    Dim partcode As String
    Private Sub processQRcode(qrcode As String)
        Try
            ' Split the QR code
            con.Close()
            Dim parts() As String = qrcode.Split("|"c)

            ' Check if the split result has the correct length
            If parts.Length >= 3 Then
                partcode = parts(0).Trim()
                Dim qty As Decimal = parts(1).Trim()
                Dim category As String = parts(2).Trim()
                Dim series As String = parts(3).Trim()

                If category = "R" Then
                    con.Close()
                    con.Open()

                    ' Check for duplicates
                    Dim selectdata As New MySqlCommand("SELECT serial_code,status,qty FROM molding_resin WHERE serial_code='" & qrcode & "'", con)
                    With selectdata.Parameters
                        .AddWithValue("@resinid", partcode)
                        .AddWithValue("@serialno", series)
                    End With
                    dr = selectdata.ExecuteReader
                    If dr.Read() = True Then
                        status = dr.GetInt32("status")
                        qty_rem = dr.GetDecimal("qty")

                        Select Case status
                            Case 0
                                ' Duplicate found
                                showduplicate("Status : OUT")
                            Case 1
                                If qty_rem = txt_qty.Value Then
                                    con.Close()
                                    con.Open()
                                    ' Insert the new record
                                    Dim updatedata As New MySqlCommand("UPDATE `molding_resin` SET `userout`='" & idno & "', `dateout`='" & datedb & "', `status`='0' WHERE serial_code='" & txtqr.Text & "'", con)
                                    updatedata.ExecuteNonQuery()
                                    panelerror.Visible = False

                                ElseIf qty_rem > txt_qty.Value Then
                                    con.Close()
                                    con.Open()

                                    Dim updatedata As New MySqlCommand("UPDATE `molding_resin` SET `userout`='" & idno & "', `dateout`='" & datedb & "', qty='" & qty_rem - txt_qty.Value & "' WHERE serial_code='" & txtqr.Text & "'", con)
                                    updatedata.ExecuteNonQuery()
                                Else
                                    showerror("Qty greater than remaining :" & qty_rem)
                                End If
                        End Select
                    Else
                        'no record
                        showerror("No record found!")
                    End If
                Else
                    ' Not virgin
                    showerror("Resin not Recycled")
                End If
            Else
                ' Invalid QR code format
                showerror("Invalid QR! Expected 4 parts but got " & parts.Length)
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            reload("SELECT  `partcode`, `serialno`, `qty` FROM `molding_resin` 
                    JOIN molding_resin_masterlist rm ON rm.id=resinid WHERE category='R' and userout='" & idno & "' and dateout='" & datedb & "'", datagrid1)
            lbl_count2.Text = datagrid1.Rows.Count
            txtqr.Clear()
            txtqr.Focus()
        End Try
    End Sub


    Private Sub showerror(text As String)
        Try
            texterror.Text = text
            panelerror.Visible = True
            sounderror()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub showduplicate(text As String)
        Try
            texterror.Text = text
            panelerror.Visible = True
            soundduplicate()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtqr_matrix_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            processQRcode(txtqr.Text)

        End If
    End Sub

    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub btn_proceed_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub recycled_OUT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
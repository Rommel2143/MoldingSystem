﻿Imports MySql.Data.MySqlClient
Public Class virgin_IN



    Private Sub processQRcode(qrcode As String)
        Try
            ' Split the QR code
            con.Close()
            Dim parts() As String = qrcode.Split("|"c)

            ' Check if the split result has the correct length
            If parts.Length >= 3 Then
                Dim partcode As String = parts(0).Trim()
                Dim qty As Decimal = parts(1).Trim()
                Dim category As String = parts(2).Trim()
                Dim series As String = parts(3).Trim()

                If category = "V" Then
                    con.Close()
                    con.Open()

                    ' Check for duplicates
                    Dim selectdata As New MySqlCommand("SELECT serial_code,status FROM molding_resin WHERE serial_code='" & qrcode & "'", con)
                    With selectdata.Parameters
                        .AddWithValue("@resinid", partcode)
                        .AddWithValue("@serialno", series)
                    End With
                    dr = selectdata.ExecuteReader
                    If dr.Read() = True Then
                        Dim status As Integer = dr.GetInt32("status")
                        Select Case status
                            Case 0
                                display_error("Status : OUT")
                            Case 1
                                ' Duplicate found
                                display_error("Serial already scanned!")
                            Case 3
                                display_error("Status : For Mixing")
                        End Select
                    Else
                            con.Close()
                        con.Open()

                        ' Insert the new record
                        Dim selectcmd As New MySqlCommand("INSERT INTO `molding_resin`(`resinid`, `serial_code`, `serialno`,qty,userin ,`datein`,`category`)
                                                           VALUES (@resinid, @serial_code, @serialno,@qty,@userin, @datein, @category)", con)
                        With selectcmd.Parameters
                            .AddWithValue("@resinid", partcode)
                            .AddWithValue("@serial_code", qrcode)
                            .AddWithValue("@serialno", series)
                            .AddWithValue("@qty", qty)
                            .AddWithValue("@userin", idno)
                            .AddWithValue("@datein", datedb)
                            .AddWithValue("@category", "V")
                        End With
                        selectcmd.ExecuteNonQuery()
                        machine_frame.error_panel.Visible = False


                    End If
                Else
                    ' Not virgin
                    display_error("Resin not Virgin")
                End If
            Else
                ' Invalid QR code format
                display_error("Invalid QR! Expected 4 parts but got " & parts.Length)
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            reload("SELECT  `partcode`, `serialno`, `qty` FROM `molding_resin` 
                    JOIN molding_resin_masterlist rm ON rm.id=resinid WHERE category='V' and userin='" & idno & "' and datein='" & datedb & "' ORDER by molding_resin.id DESC", datagrid1)
            lbl_count2.Text = datagrid1.Rows.Count
        End Try
    End Sub



    Private Sub txtqr_matrix_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            processQRcode(txtqr.Text)
            txtqr.Clear()
        End If
    End Sub

    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
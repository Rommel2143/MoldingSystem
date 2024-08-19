Imports MySql.Data.MySqlClient
Public Class virgin_IN

    Dim partcode As String
    Dim qty As Decimal
    Dim series As String
    Dim type As String
    Dim category As String


    Private Sub processQRcode(qrcode As String)
        Try
            ' Split the QR code
            con.Close()
            Dim parts() As String = qrcode.Split("-")

            ' Check if the split result has the correct length
            If parts.Length >= 3 Then
                Dim partcode As String = parts(0)
                Dim qty As String = parts(1)
                Dim category As String = parts(2)
                Dim series As String = parts(3)


                If category = "V" Then

                    con.Close()
                    con.Open()

                    ' Check for duplicates
                    Dim selectdata As New MySqlCommand("SELECT resinid, serial_number FROM `molding_resin_serial` WHERE resinid=@resinid AND serial_number=@serial_number", con)
                    With selectdata.Parameters
                        .AddWithValue("@resinid", partcode)
                        .AddWithValue("@serial_number", series)
                    End With
                    dr = selectdata.ExecuteReader
                    If dr.Read() = True Then
                        ' Duplicate found
                        showduplicate("Serial already scanned!")
                    Else
                        con.Close()
                        con.Open()

                        ' Insert the new record
                        Dim selectcmd As New MySqlCommand("INSERT INTO `molding_resin_serial`(`resinid`, `serial_code`, `serial_number`,`datein`) VALUES (@resinid, @serial_code, @serial_number, @datein)", con)
                        With selectcmd.Parameters
                            .AddWithValue("@resinid", partcode)
                            .AddWithValue("@serial_code", qrcode)
                            .AddWithValue("@serial_number", series)
                            .AddWithValue("@datein", datedb)
                        End With

                        selectcmd.ExecuteNonQuery()
                    End If
                Else
                    'not virgin


                End If

            Else
                    ' Invalid QR code format
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
            texterror.Text = text
            labelerror.Visible = True
            sounderror()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub showduplicate(text As String)
        Try
            texterror.Text = text
            labelerror.Visible = True
            soundduplicate()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtqr_matrix_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            processQRcode(txtqr.Text)

            reload("SELECT rm.partcode, rs.serial_number FROM molding_resin_serial rs
                    JOIN molding_resin_masterlist rm ON rm.id= rs.resinid
                    WHERE rs.datein= '" & datedb & "'", datagrid1)

            txtqr.Clear()
        End If
    End Sub
End Class
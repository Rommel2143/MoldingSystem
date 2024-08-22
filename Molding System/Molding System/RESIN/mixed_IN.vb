Imports MySql.Data.MySqlClient
Public Class Mixed_IN



    Private Sub processQRcode(qrcode As String)
        Try
            ' Split the QR code
            con.Close()
            Dim parts() As String = qrcode.Split("|"c)

            ' Check if the split result has the correct length
            If parts.Length >= 3 Then
                Dim partcode As String = parts(0).Trim()
                Dim qty As String = parts(1).Trim()
                Dim category As String = parts(2).Trim()
                Dim series As String = parts(3).Trim()

                If category = "M" Then
                    con.Close()
                    con.Open()

                    ' Check for duplicates
                    Dim selectdata As New MySqlCommand("SELECT resinid, serialno FROM molding_resin_mixed WHERE resinid=@resinid AND serialno=@serialno", con)
                    With selectdata.Parameters
                        .AddWithValue("@resinid", partcode)
                        .AddWithValue("@serialno", series)
                    End With
                    dr = selectdata.ExecuteReader
                    If dr.Read() = True Then
                        ' Duplicate found
                        showduplicate("Serial already scanned!")
                    Else
                        con.Close()
                        con.Open()

                        ' Insert the new record
                        Dim selectcmd As New MySqlCommand("INSERT INTO `molding_resin_mixed`(`resinid`, `serial_code`, `serialno`,qty,userin ,`datein`)
                                                           VALUES (@resinid, @serial_code, @serialno,@qty,@userin, @datein)", con)
                        With selectcmd.Parameters
                            .AddWithValue("@resinid", partcode)
                            .AddWithValue("@serial_code", qrcode)
                            .AddWithValue("@serialno", series)
                            .AddWithValue("@qty", qty)
                            .AddWithValue("@userin", idno)
                            .AddWithValue("@datein", datedb)
                        End With
                        selectcmd.ExecuteNonQuery()
                        panelerror.Visible = False
                        lbl_count2.Text = datagrid1.Rows.Count
                    End If
                Else
                    ' Not virgin
                    showerror("Resin not Mixed")
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

            reload("SELECT rm.partcode, rv.serialno FROM molding_resin_mixed rv
                    JOIN molding_resin_masterlist rm ON rm.id= rv.resinid
                    WHERE rv.datein= '" & datedb & "' and rv.userin= '" & idno & "'", datagrid1)

            txtqr.Clear()
        End If
    End Sub

    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub virgin_IN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
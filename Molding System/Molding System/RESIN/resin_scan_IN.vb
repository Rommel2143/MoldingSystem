Imports MySql.Data.MySqlClient
Public Class resin_scan_IN

    Dim partcode As String
    Dim qty As Decimal
    Dim series As String
    Dim type As String
    Dim category As String


    Private Sub txtqr_matrix_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub
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

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub labelerror_Paint(sender As Object, e As PaintEventArgs) Handles labelerror.Paint

    End Sub

    Private Sub texterror_Click(sender As Object, e As EventArgs) Handles texterror.Click

    End Sub

    Private Sub Guna2GroupBox3_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox3.Click

    End Sub

    Private Sub Guna2Separator1_Click(sender As Object, e As EventArgs) Handles Guna2Separator1.Click

    End Sub

    Private Sub lbl_count2_Click(sender As Object, e As EventArgs) Handles lbl_count2.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub txtdate_Click(sender As Object, e As EventArgs) Handles txtdate.Click

    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub
End Class
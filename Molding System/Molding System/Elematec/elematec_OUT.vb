

Imports MySql.Data.MySqlClient
Public Class elematec_OUT
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

    Private Sub scan_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles batchcode.TextChanged
        Try
            batch = batchcode.Text
            If batchcode.Text = "" Then
                txtqr.Enabled = False

            Else
                txtqr.Enabled = True
                refreshgrid()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub Txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then

            txt_box.Enabled = True
            txt_box.Focus()

        End If

    End Sub

    Private Sub ProcessQRcode(qrcode As String)
        Try

            con.Close()
                con.Open()
            Dim cmdselect As New MySqlCommand("SELECT `qrcode`,`status`,`located`,`datein` FROM `molding_stock` WHERE `qrcode`='" & qrcode & "' LIMIT 1", con)
            dr = cmdselect.ExecuteReader
                If dr.Read = True Then
                Dim status As Integer = dr.GetInt32("status")
                datein = dr.GetDateTime("datein")

                    Select Case status

                    Case 1
                        'update
                        update_painting_stock(qrcode)

                    Case 0
                        'duplicate
                        display_error("Duplicate Entry")
                End Select

                Else 'CON 2 : IF NOT SCANNED
                display_error("Record doesn't exist")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            txtqr.Text = ""
            txt_box.Clear()
            txt_box.Enabled = False
            txtqr.Focus()
            refreshgrid()
        End Try

    End Sub

    Private Sub refreshgrid()
        Try
            con.Close()
            con.Open()
            Dim cmdrefreshgrid As New MySqlCommand("SELECT `qrcode`,`partcode`,  `lotnumber`, `remarks`, `qty` FROM `molding_stock`
                                                    WHERE `dateout`='" & datedb & "' and `userout`='" & idno & "' and `batchout`='" & batch & "' ", con)

            Dim da As New MySqlDataAdapter(cmdrefreshgrid)
            Dim dt As New DataTable
            da.Fill(dt)
            datagrid1.DataSource = dt
            da.Dispose()

            con.Close()
            con.Open()
            Dim cmdrefreshgrid2 As New MySqlCommand("SELECT `partcode`, SUM(`qty`) FROM `molding_stock`
                                                    WHERE `dateout`='" & datedb & "' and `batchout`='" & batch & "' and `userout`='" & idno & "'
                                                    GROUP BY partcode", con)

            Dim da2 As New MySqlDataAdapter(cmdrefreshgrid2)
            Dim dt2 As New DataTable
            da2.Fill(dt2)
            datagrid2.DataSource = dt2
            datagrid2.AutoResizeColumns()
            da2.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            con.Close()
        End Try
    End Sub

    Private Sub update_painting_stock(qr As String)
        Try

            con.Close()
            con.Open()
            Dim cmdupdate As New MySqlCommand("UPDATE `molding_stock` SET `status`= 0,`batchout`='" & batch & "',`dateout`='" & datedb & "',`userout`='" & idno & "',`boxno`='" & txt_box.Text & "',`pcout`='" & PCname & "' WHERE qrcode='" & qr & "'", con)
            cmdupdate.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub txt_box_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_box.KeyDown
        If e.KeyCode = Keys.Enter Then

            ProcessQRcode(txtqr.Text)
            txt_box.Enabled = False

        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim results As New scan_results
        results.loaddata("OUT")
        results.ShowDialog()
        results.BringToFront()
    End Sub

    Private Sub txt_box_TextChanged(sender As Object, e As EventArgs) Handles txt_box.TextChanged

    End Sub

    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub txtqr_Layout(sender As Object, e As LayoutEventArgs) Handles txtqr.Layout

    End Sub
End Class
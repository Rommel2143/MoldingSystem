Imports MySql.Data.MySqlClient
Public Class dailyoutput
    Dim lotno As String
    Dim qty As Integer
    Dim remarks As String
    Dim itemstatus As String
    Private Sub dailyoutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuser.Text = idno
        txtfname.Text = fname
        Try
            refreshgrid()
            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("SELECT distinct `machine`
                                            FROM `moldingtblsetup`
                                            WHERE `date1` like '" & txtdate.Text & "' and `shift1` like '" & txtshift.Text & "'", con)
            dr = cmd.ExecuteReader
            cmbmachine.Items.Clear()
            While (dr.Read())
                cmbmachine.Items.Add(dr.GetString("machine"))
            End While


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            con.Close()
        End Try

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged
        If txtqr.Text = "" Then
            txtbox.Enabled = False
        Else
            txtbox.Enabled = True
        End If
    End Sub

    Private Sub Guna2TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtbox.Text = ""
            txtbox.Focus()

        End If
    End Sub
    Private Sub processQRcode(qrcode As String)
        Try
            'CONDITION 1 : Split QR
            con.Close()
            Dim parts() As String = qrcode.Split("|")
            If parts.Length >= 5 AndAlso parts.Length <= 8 Then
                Dim codedaily As String
                codedaily = parts(0).Remove(0, 2).Trim
                lotno = parts(2).Remove(0, 2).Trim
                qty = parts(3).Remove(0, 2).Trim
                remarks = parts(4).Remove(0, 2).Trim

                'CONDITION 2 : If partcode is equal
                If txtcode.Text = codedaily Then


                    'CONDITION 3 : If duplicate to moldingdaily
                    con.Open()
                    Dim cmd As New MySqlCommand("SELECT * FROM `moldingtbldaily` WHERE `qrcode` like '" & txtqr.Text & "'", con)
                    dr = cmd.ExecuteReader
                    If dr.Read = False Then

                        'INSERT DATA
                        If itemstatus = Nothing Then
                            MessageBox.Show("Please Select Status!")
                        ElseIf itemstatus = "WIP" Then
                            saveqrWIP()
                        ElseIf itemstatus = "FG" Then
                            saveqrFG()
                        End If



                    Else 'CONDITION 3 : If duplicate to moldingdaily
                        duplicate()
                        txtqr.Text = ""
                        txtqr.Focus()
                    End If



                Else 'CONDITION 2 : If partcode is equal
                    partcodenotequal()
                    txtqr.Text = ""
                    txtqr.Focus()

                End If



            Else 'CONDITION 1 : Split QR
                showerror()
                con.Close()
                txtqr.Text = ""
                txtqr.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub saveqrWIP()
        Try

            'Save to moldingtbldaily
            con.Close()
            con.Open()
            Dim cmdinsert As New MySqlCommand("INSERT INTO `moldingtbldaily`(`machineno`, `material`, `qrcode`, `date1`, `time1`, `lotno`, `qty`, `remarks`, `boxno`, `shift`, `user`,`status`,`partcode`,`moldno`)
                                                        VALUES ('" & cmbmachine.Text & "','" & cmbmaterial.Text & "','" & txtqr.Text & "','" & datedb & "','" & Date.Now.ToString("HH:mm") & "','" & lotno & "','" & qty & "','" & remarks & "','" & txtbox.Text & "','" & txtshift.Text & "','" & txtuser.Text & "','" & itemstatus & "','" & txtcode.Text & "','" & txtmold.Text & "')", con)
            cmdinsert.ExecuteNonQuery()


            '2 : SAVE DATA TO INVENTORY SYSTEM 
            insert_to_inventory_fg_scan_WIP()
            refreshgrid()

            labelerror.Visible = False
            txtbox.Text = ""
            txtqr.Text = ""
            txtqr.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
    Private Sub insert_to_inventory_fg_scan_WIP()
        Try

            con.Close()
            con.Open()
            Dim cmdinsert As New MySqlCommand("INSERT INTO `inventory_fg_scan`(`status`,
                                                                    `batch`,
                                                                    `userin`,
                                                                    `datein`,
                                                                    `partcode`,
                                                                    `qrcode`,
                                                                    `lotnumber`,
                                                                    `remarks`,
                                                                    `qty`,
                                                                    `located`) 

                                                       VALUES('WIP',
                                                              '" & cmbmaterial.Text & "',
                                                              '" & idno & "',
                                                              '" & datedb & "',
                                                              '" & txtcode.Text & "',
                                                              '" & txtqr.Text & "',
                                                              '" & lotno & "',
                                                              '" & remarks & "',
                                                              '" & qty & "',
                                                              'U1-4')", con)
            cmdinsert.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
    Private Sub insert_to_inventory_fg_scan_FG()
        Try

            con.Close()
            con.Open()
            Dim cmdinsert As New MySqlCommand("INSERT INTO `inventory_fg_scan`(`status`,
                                                                    `batch`,
                                                                    `userin`,
                                                                    `datein`,
                                                                    `partcode`,
                                                                    `qrcode`,
                                                                    `lotnumber`,
                                                                    `remarks`,
                                                                    `qty`,
                                                                    `located`) 

                                                       VALUES('IN',
                                                              '" & cmbmaterial.Text & "',
                                                              '" & idno & "',
                                                              '" & datedb & "',
                                                              '" & txtcode.Text & "',
                                                              '" & txtqr.Text & "',
                                                              '" & lotno & "',
                                                              '" & remarks & "',
                                                              '" & qty & "',
                                                              'U1-4')", con)
            cmdinsert.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub saveqrFG()
        Try

            '2 : SAVE DATA TO INVENTORY SYSTEM


            insert_to_inventory_fg_scan_FG()
            '3 : INSERT DATA TO MOLDING DAILY
            con.Close()
            con.Open()
            Dim cmdinsert As New MySqlCommand("INSERT INTO `moldingtbldaily`(`machineno`, `material`, `qrcode`, `date1`, `time1`, `lotno`, `qty`, `remarks`, `boxno`, `shift`, `user`,`status`,`partcode`,`moldno`)
                                                        VALUES ('" & cmbmachine.Text & "','" & cmbmaterial.Text & "','" & txtqr.Text & "','" & datedb & "','" & Date.Now.ToString("HH:mm") & "','" & lotno & "','" & qty & "','" & remarks & "','" & txtbox.Text & "','" & txtshift.Text & "','" & txtuser.Text & "','" & itemstatus & "','" & txtcode.Text & "','" & txtmold.Text & "')", con)
            cmdinsert.ExecuteNonQuery()

            refreshgrid()

            labelerror.Visible = False
            txtbox.Text = ""
            txtqr.Text = ""
            txtqr.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try



    End Sub
    Private Sub Norecord()
        Try
            labelerror.Text = "NO PARTCODE SAVED"
            labelerror.Visible = True
            sounderror()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub duplicate()
        Try
            labelerror.Text = "DUPLICATE QR"
            labelerror.Visible = True
            sounderror()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub showerror()
        Try
            labelerror.Text = "INVALID QR"
            labelerror.Visible = True
            sounderror()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub partcodenotequal()
        Try
            labelerror.Text = "PARTCODE NOT EQUAL"
            labelerror.Visible = True
            sounderror()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub selectstatus()
        Try
            labelerror.Text = "Please Select Status (WIP/FG)"
            labelerror.Visible = True
            sounderror()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmbmachine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmachine.SelectedIndexChanged
        con.Close()
        con.Open()
        Dim cmd As New MySqlCommand("SELECT distinct `materiallot`
                                            FROM `moldingtblsetup`
                                            WHERE `machine` like '" & cmbmachine.Text & "' and `date1` like '" & txtdate.Text & "'", con)
        dr = cmd.ExecuteReader
        cmbmaterial.Items.Clear()
        While (dr.Read())
            cmbmaterial.Items.Add(dr.GetString("materiallot"))
        End While

    End Sub

    Private Sub cmbmaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmaterial.SelectedIndexChanged
        con.Close()
        con.Open()
        Try
            Dim cmd As New MySqlCommand("SELECT p.`partcode`,p.`moldno`,p.`target`,pt.`partname`
                                          FROM `moldingtblsetup` p
                                           JOIN `inventory_fg_masterlist` pt ON pt.`partcode`= p.`partcode`
                                            WHERE `materiallot` like '" & cmbmaterial.Text & "' and `machine` like '" & cmbmachine.Text & "' and `date1` like '" & txtdate.Text & "'", con)
            dr = cmd.ExecuteReader
            If (dr.Read()) = True Then
                txtcode.Text = dr.GetString("partcode")
                txttarget.Text = dr.GetInt32("target")
                txtmold.Text = dr.GetString("moldno")
                txtname.Text = dr.GetString("partname")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            con.Close()
        End Try
    End Sub

    Private Sub txtcode_TextChanged(sender As Object, e As EventArgs) Handles txtcode.TextChanged

    End Sub

    Private Sub txtdate_TextChanged(sender As Object, e As EventArgs) Handles txtdate.TextChanged

    End Sub
    Private Sub refreshgrid()
        Try
            con.Close()
            con.Open()
            Dim cmdrefreshgrid As New MySqlCommand("SELECT `id`, `machineno`, `material`, `qrcode`, `lotno`, `qty`, `remarks`, `boxno`, `user`, `date1`, `shift`, `time1`, `status`
                                                    FROM `moldingtbldaily`
                                                    WHERE `user` like '" & idno & "' and `date1` like '" & datedb & "' and `shift` like '" & shift1 & "'", con)

            Dim da As New MySqlDataAdapter(cmdrefreshgrid)
            Dim dt As New DataTable
            da.Fill(dt)
            datagrid1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            con.Close()
        End Try
    End Sub
    Private Sub txtshift_TextChanged(sender As Object, e As EventArgs) Handles txtshift.TextChanged
        Try
            refreshgrid()
            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("SELECT distinct `machine`
                                            FROM `moldingtblsetup`
                                            WHERE `date1` like '" & txtdate.Text & "'", con)
            dr = cmd.ExecuteReader
            cmbmachine.Items.Clear()
            While (dr.Read())
                cmbmachine.Items.Add(dr.GetString("machine"))
            End While


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            con.Close()
        End Try
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbox.TextChanged

    End Sub

    Private Sub txtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If itemstatus = Nothing Then
                selectstatus()
            Else
                processQRcode(txtqr.Text)
            End If
        End If
    End Sub

    Private Sub panelset_Paint(sender As Object, e As PaintEventArgs) Handles panelset.Paint

    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Try
            refreshgrid()
            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("SELECT distinct `machine`
                                            FROM `moldingtblsetup`
                                            WHERE `date1` like '" & txtdate.Text & "' and `shift1` like '" & txtshift.Text & "'", con)
            dr = cmd.ExecuteReader
            cmbmachine.Items.Clear()
            While (dr.Read())
                cmbmachine.Items.Add(dr.GetString("machine"))
            End While


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            con.Close()
        End Try
    End Sub

    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton1.CheckedChanged
        itemstatus = "WIP"
        txtqr.Enabled = True
    End Sub

    Private Sub Guna2RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton2.CheckedChanged
        itemstatus = "FG"
        txtqr.Enabled = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
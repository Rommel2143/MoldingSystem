Imports MySql.Data.MySqlClient
Public Class dailysetup
    Dim idset As Integer
    Private Sub stockmonitoring_setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdate.Value = Date.Now.ToString("MMMM dd yyyy")
        Try
            txtdate.Value = Date.Now.ToString("MMMM dd yyyy")
            con.Close()
            con.Open()
            buttonadd()
            txtuser.Text = idno
            txtfname.Text = fname

            reloadgrid()

            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("SELECT distinct `machineno`
                                            FROM `moldingtblmachine`", con)
            dr = cmd.ExecuteReader
            cmbmachine.Items.Clear()
            While (dr.Read())
                cmbmachine.Items.Add(dr.GetString("machineno"))
            End While


            con.Close()
            con.Open()
            Dim cmd1 As New MySqlCommand("SELECT DISTINCT `partcode` FROM `tblmaster`
                                            ORDER BY `partcode` DESC", con)
            dr = cmd1.ExecuteReader
            txtcode.Items.Clear()
            While (dr.Read())
                txtcode.Items.Add(dr.GetString("partcode"))
            End While








        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            con.Close()
        End Try

    End Sub
    Private Sub buttonedit()
        updatebtn.Enabled = True
        deletebtn.Enabled = True
        addbtn.Enabled = False
        cancelbtn.Enabled = True
    End Sub
    Private Sub buttonadd()
        updatebtn.Enabled = False
        deletebtn.Enabled = False
        addbtn.Enabled = True
        cancelbtn.Enabled = False

    End Sub
    Private Sub reloadgrid()
        Try
            con.Close()
            con.Open()
            Dim cmdrefreshgrid As New MySqlCommand("SELECT p.`id`, p.`user`, p.`operator`, p.`machine`, p.`materiallot`, p.`partcode`,sp.`partname`, p.`moldno`, p.`target`, p.`date1`, p.`shift1` 
                                                    FROM `moldingtblsetup` p
                                                    JOIN `tblmaster` sp on p.`partcode`= sp.`partcode`
                                                     WHERE  `user` like '" & idno & "' and `date1` like '" & date1 & "' and `shift1` like '" & shift1 & "'", con)

            Dim da As New MySqlDataAdapter(cmdrefreshgrid)
            Dim dt As New DataTable
            da.Fill(dt)
            datagrid1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub
    Private Sub clearcontents()
        txtname.Text = ""
        txtcode.SelectedItem = Nothing
        cmbmold.SelectedItem = Nothing
        txttarget.Text = ""
        txtmaterial.Text = ""
        cmbmachine.SelectedItem = Nothing
        txtoperator.Text = ""

    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        If panel2.BackColor = Color.LightBlue Then
            Try
                con.Close()
                con.Open()

                Dim cmd As New MySqlCommand("INSERT INTO `moldingtblsetup`(`user`, `operator`, `machine`, `materiallot`, `partcode`, `moldno`, `target`, `date1`, `shift1`)
            VALUES ('" & txtuser.Text & "','" & txtoperator.Text & "','" & cmbmachine.Text & "','" & txtmaterial.Text & "','" & txtcode.Text & "','" & cmbmold.Text & "','" & txttarget.Text & "','" & date1 & "','" & shift1 & "')", con)
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                datagrid1.DataSource = dt
                clearcontents()



            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
                reloadgrid()
                da.Dispose()

            End Try
        Else
            MessageBox.Show("Set Date and Shift First!")
        End If
    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles panelset.Paint

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles cmbshift.Click
        date1 = txtdate.Value.ToString("MMMM dd yyyy")
        shift1 = txtshift.Text
        If date1 = "" Or shift1 = "" Then
            MessageBox.Show("Select shift first!")
        Else
            panel2.BackColor = Color.LightBlue
            panelset.Enabled = True
            With dailyoutput
                .panelset.Enabled = True
                .txtdate.Text = date1
                .txtshift.Text = shift1
            End With

            reloadgrid()
        End If

    End Sub

    Private Sub txtcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcode.SelectedIndexChanged
        con.Close()
        con.Open()
        Dim cmd1 As New MySqlCommand("SELECT tm.`partname`, mml.`moldno` 
                                       FROM `tblmaster` tm
INNER JOIN `molding_mold_list` mml ON mml.partcode=tm.partcode
                                        WHERE  tm.`partcode` like '" & txtcode.Text & "'", con)
        dr = cmd1.ExecuteReader


        cmbmold.Items.Clear()
        While (dr.Read())
            cmbmold.Items.Add(dr.GetString("moldno"))
            txtname.Text = (dr.GetString("partname"))
        End While
    End Sub

    Private Sub txtdate_ValueChanged(sender As Object, e As EventArgs) Handles txtdate.ValueChanged

    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        Try
            'p.`id`, p.`user`, p.`operator`, p.`machine`, p.`materiallot`, p.`partcode`,sp.`partname`, p.`moldno`, p.`target`, p.`date1`, p.`shift1` 
            buttonedit()

            With datagrid1
                idset = .SelectedCells(0).Value.ToString()
                txtoperator.Text = .SelectedCells(2).Value.ToString()
                cmbmachine.SelectedItem = .SelectedCells(3).Value.ToString()
                txtmaterial.Text = .SelectedCells(4).Value.ToString()
                txtcode.SelectedItem = .SelectedCells(5).Value.ToString()
                txtname.Text = .SelectedCells(6).Value.ToString()
                cmbmold.SelectedItem = .SelectedCells(7).Value.ToString()
                txttarget.Text = .SelectedCells(8).Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub txtuser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuser.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM `tblscanoperator` WHERE `IDno` LIKE '%" & txtuser.Text & "%'", con)

                dr = cmd.ExecuteReader
                If dr.Read = True Then

                    fname = dr("fullname").ToString
                    idno = dr("idno").ToString
                    txtfname.Text = fname
                Else

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                con.Close()

            End Try
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles deletebtn.Click

        If MsgBox("Are you sure to DELETE this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            con.Close()


            delete("DELETE FROM `moldingtblsetup` WHERE `id`= '" & idset & "'")

            reloadgrid()



        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Try
            con.Close()
            con.Open()

            Dim cmd As New MySqlCommand("UPDATE `moldingtblsetup` SET `user`='" & txtuser.Text & "', `operator`='" & txtoperator.Text & "', `machine`='" & cmbmachine.Text & "', `materiallot`='" & txtmaterial.Text & "', `partcode`='" & txtcode.Text & "', `moldno`='" & cmbmold.Text & "', `target`='" & txttarget.Text & "' 
                                        WHERE `id` like '" & idset & "'", con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            datagrid1.DataSource = dt
            clearcontents()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            reloadgrid()
            da.Dispose()

        End Try
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        buttonadd()
        clearcontents()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub cmbmold_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmold.SelectedIndexChanged

    End Sub

    Private Sub cmbsearch_TextChanged(sender As Object, e As EventArgs) Handles cmbsearch.TextChanged
        Try
            con.Close()
            con.Open()
            Dim cmdrefreshgrid As New MySqlCommand("SELECT p.`id`, p.`user`, p.`operator`, p.`machine`, p.`materiallot`, p.`partcode`,sp.`partname`, p.`moldno`, p.`target`, p.`date1`, p.`shift1` 
                                                    FROM `moldingtblsetup` p
                                                    JOIN `tblmaster` sp on p.`partcode`= sp.`partcode`
                                                     WHERE (`user` like '" & idno & "' and `date1` like '" & date1 & "' and `shift1` like '" & shift1 & "') and (`machine` REGEXP '" & cmbsearch.Text & "' or `materiallot` REGEXP '" & cmbsearch.Text & "')", con)

            Dim da As New MySqlDataAdapter(cmdrefreshgrid)
            Dim dt As New DataTable
            da.Fill(dt)
            datagrid1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub

    Private Sub txttarget_TextChanged(sender As Object, e As EventArgs) Handles txttarget.TextChanged

    End Sub

    Private Sub cmbmachine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmachine.SelectedIndexChanged

    End Sub
End Class
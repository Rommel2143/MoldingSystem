Imports MySql.Data.MySqlClient
Public Class addmold
    Private Sub addmold_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        con.Open()
        Dim cmd1 As New MySqlCommand("SELECT DISTINCT `partcode` FROM `tblmaster`
                                            ORDER BY `partcode` DESC", con)
        dr = cmd1.ExecuteReader
        txtcode.Items.Clear()
        While (dr.Read())
            txtcode.Items.Add(dr.GetString("partcode"))
        End While
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

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        con.Close()
        con.Open()
        Dim cmd2 As New MySqlCommand("SELECT distinct `partcode`, `moldno`
                                        FROM `molding_mold_list` 
                                        WHERE `partcode` Like '" & txtcode.Text & "' and `moldno` Like '" & txtmold.Text & "'", con)
        dr = cmd2.ExecuteReader
        If dr.Read = False Then

            insertmold("INSERT INTO `molding_mold_list`(`partcode`, `moldno`)
                             VALUES ('" & txtcode.Text & "','" & txtmold.Text & "')")



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
        Else
            MessageBox.Show("Partcode and Mold already Registered!")
        End If
    End Sub

    Public Sub insertmold(ByVal sql As String)
        Try
            con.Close()
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to send!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Mold Registered Sucessfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub
End Class
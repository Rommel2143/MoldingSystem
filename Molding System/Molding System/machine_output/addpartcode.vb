Imports MySql.Data.MySqlClient
Public Class addpartcode
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        con.Close()
        con.Open()
        Dim cmd2 As New MySqlCommand("SELECT distinct `partcode`
                                        FROM `tblmaster` 
                                        WHERE `partcode` Like '" & txtcode.Text & "'", con)
        dr = cmd2.ExecuteReader
        If dr.Read = False Then
            insertpartcode("INSERT INTO `tblmaster`(`partcode`, `partname`, `section`)
                             VALUES ('" & txtcode.Text & "','" & txtname.Text & "','MOLDING')")
        Else
            MessageBox.Show("Partcode already Registered!")
        End If

    End Sub

    Private Sub txtcode_TextChanged(sender As Object, e As EventArgs) Handles txtcode.TextChanged

    End Sub

    Public Sub insertpartcode(ByVal sql As String)
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
                    MessageBox.Show("Partcode Registered Sucessfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub
End Class
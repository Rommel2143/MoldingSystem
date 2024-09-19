Imports MySql.Data.MySqlClient
Public Class add_resin
    Private Sub add_resin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_display("SELECT DISTINCT(type) FROM `molding_resin_masterlist`", "type", cmb_type)
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        If txtcode.Text = "" Then
            MessageBox.Show("Please input Partcode")
        Else
            con.Close()
            con.Open()

            ' Insert the new record
            Dim selectcmd As New MySqlCommand("INSERT INTO `molding_resin_masterlist`(`type`, `partcode`, `weight`) 
                                           VALUES ('" & cmb_type.Text & "','" & txtcode.Text & "','" & txt_qty.Value & "')", con)

            selectcmd.ExecuteNonQuery()
            MessageBox.Show("Partcode Successfully Added!")
            print_sticker_virgin.Close()
        End If

    End Sub
End Class
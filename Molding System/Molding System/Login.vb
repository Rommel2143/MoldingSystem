﻿Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            txtpcname.Text = PCname
            txtpcmac.Text = PCmac

            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT * FROM computer_location WHERE `PCname`='" & PCname & "' and `PCmac`='" & PCmac & "'", con)
            dr = cmdselect.ExecuteReader
            If dr.Read = True Then
                txtbarcode.Enabled = True
                txtbarcode.Focus()
                PClocation = dr.GetString("location")
                txtpclocation.Text = PClocation
            Else
                Dim result As DialogResult = MessageBox.Show("Machine not Verified!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)


                If result = DialogResult.OK Then
                    display_form(Register_PC)

                ElseIf result = DialogResult.Cancel Then
                    con.Close()
                    Application.Exit()
                End If



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
            txtbarcode.Clear()

        End Try
    End Sub

    Private Sub txtbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtbarcode.TextChanged

    End Sub

    Private Sub txtbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcode.KeyDown

        If e.KeyCode = Keys.Enter Then
            Try
                Dim idwithA As String = "A" & txtbarcode.Text & "A"
                Dim idwithoutA As String = txtbarcode.Text.TrimStart("A"c).TrimEnd("A"c)
                Dim idwithoutasmall As String = txtbarcode.Text.TrimStart("a"c).TrimEnd("a"c)
                con.Close()
                con.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM `tblscanoperator_ms` WHERE `IDno` = '" & idwithoutA & "' or `IDno` = '" & idwithA & "' or `IDno` = '" & idwithoutasmall & "' ", con)
                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    fname = dr("fullname").ToString
                    idno = dr("IDno").ToString
                    user_level = dr.GetInt32("status")
                    machine_frame.Panel1.Controls.Clear()


                    'Denso Label
                    If dr.GetInt32("denso_label") = 1 Then
                        machine_frame.btn_denso.Visible = True
                    Else
                        machine_frame.btn_denso.Visible = False
                    End If


                    'Resin
                    If dr.GetInt32("resin") = 1 Then
                        machine_frame.btn_resin.Enabled = True
                    Else
                        machine_frame.btn_resin.Enabled = False
                    End If


                    'Machine
                    If dr.GetInt32("Machine") = 1 Then
                        machine_frame.btn_machine.Enabled = True
                    Else
                        machine_frame.btn_machine.Enabled = False
                    End If

                    'ADMIN
                    If user_level = 1 Then
                        machine_frame.btn_delete.Visible = True
                        machine_frame.btn_add.Visible = True
                        machine_frame.resin_additem.Visible = True
                        machine_frame.btn_mold.Visible = True
                    Else
                        machine_frame.btn_delete.Visible = False
                        machine_frame.btn_add.Visible = False
                        machine_frame.resin_additem.Visible = False
                        machine_frame.btn_mold.Visible = False
                    End If



                    display_form(machine_frame)
                    machine_frame.userstrip.Text = fname
                    labelerror.Visible = False
                Else
                    noid()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                con.Close()
                txtbarcode.Clear()

            End Try
        End If

    End Sub
    Private Sub noid()
        Try
            labelerror.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class
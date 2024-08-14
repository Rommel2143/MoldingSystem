Imports System
Public Class machine_frame

    Private Sub Scan_Frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userstrip.Text = fname
    End Sub

    Private Sub PARTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PARTSToolStripMenuItem.Click
        display_form(dailysetup)
    End Sub
    Private Sub FGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FGToolStripMenuItem.Click
        display_form(dailyoutput)
    End Sub
    Private Sub display_formscan(form As Form)
        With form
            .Refresh()
            .TopLevel = False
            Panel1.Controls.Add(form)
            .BringToFront()
            .Show()

        End With
    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        con.Close()
        Application.Exit()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        With Login
            .Refresh()
            .TopLevel = False
            molding_mainframe.Panel1.Controls.Add(Login)
            .BringToFront()
            .Show()

        End With
        Login.txtbarcode.Clear()
    End Sub



    Private Sub MenuStrip1_ItemClicked_1(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
    Private Sub display_form(form As Form)
        With form
            .Refresh()
            .TopLevel = False
            Panel1.Controls.Add(form)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub AddPartcodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPartcodeToolStripMenuItem.Click
        display_form(addpartcode)
    End Sub

    Private Sub AddMoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMoldToolStripMenuItem.Click
        display_form(addmold)
    End Sub

    Private Sub MasterlistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterlistToolStripMenuItem.Click

    End Sub
End Class
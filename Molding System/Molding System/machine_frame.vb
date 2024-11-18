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

    Private Sub AddPartcodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        display_form(addpartcode)
    End Sub

    Private Sub AddMoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btn_mold.Click
        display_form(addmold)
    End Sub

    Private Sub MasterlistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btn_machine.Click

    End Sub

    Private Sub CreateStickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateStickerToolStripMenuItem.Click
        display_formscan(print_sticker)
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        display_formscan(resin_dashboard)
        resin_dashboard.loaddata()
    End Sub


    Private Sub SCANFGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SCANFGToolStripMenuItem.Click
        display_formscan(daily_FG)
    End Sub

    Private Sub INToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INToolStripMenuItem.Click
        display_formscan(virgin_IN)
    End Sub

    Private Sub OUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OUTToolStripMenuItem.Click
        display_formscan(virgin_OUT)
    End Sub

    Private Sub INToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles INToolStripMenuItem1.Click
        display_formscan(mixed_IN)
    End Sub

    Private Sub OUTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OUTToolStripMenuItem1.Click
        display_formscan(mixed_OUT)
    End Sub

    Private Sub INToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles INToolStripMenuItem2.Click
        display_formscan(recycled_IN)
    End Sub

    Private Sub OUTToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OUTToolStripMenuItem2.Click
        display_formscan(recycled_OUT)
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles resin_additem.Click
        display_formscan(add_resin)
    End Sub

    Private Sub UpdateVersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateVersionToolStripMenuItem.Click

    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        display_formscan(virgin_return)
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        error_panel.Visible = False
    End Sub

    Private Sub ReturnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem1.Click
        display_formscan(mixed_return)
    End Sub

    Private Sub DensoLabelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btn_denso.Click
        display_formscan(print_label)
    End Sub

    Private Sub DeleteQRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        display_formscan(delete__resin)
    End Sub

    Private Sub ElematecToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElematecToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        display_formscan(elematec_IN)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        display_formscan(elematec_OUT)
    End Sub

    Private Sub ReturnBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnBoxToolStripMenuItem.Click
        display_formscan(elematec_return)
    End Sub
End Class
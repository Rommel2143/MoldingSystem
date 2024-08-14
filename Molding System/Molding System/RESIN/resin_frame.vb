Public Class resin_frame
    Private Sub PARTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PARTSToolStripMenuItem.Click
        display_formscan(resin_scan_IN)
    End Sub

    Private Sub MasterlistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterlistToolStripMenuItem.Click

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
End Class
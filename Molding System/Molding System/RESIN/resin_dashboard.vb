﻿Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class resin_dashboard
    Dim selected_category As String
    Private Sub resin_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker_resindelivery.Value = Date.Now
        dtpicker_used.Value = Date.Now

    End Sub

    Public Sub loaddata()
        reload("SELECT rm.partcode, SUM(rs.qty) AS Total_Kg FROM molding_resin rs
                 JOIN molding_resin_masterlist rm ON rm.id=rs.resinid
                WHERE rs.category='V' and rs.status='1'
                GROUP BY rm.partcode ORDER BY Total_Kg DESC", datagrid_stock_virgin)
        reload("SELECT rm.partcode, SUM(rs.qty) AS Total_Kg FROM molding_resin rs
                 JOIN molding_resin_masterlist rm ON rm.id=rs.resinid
                WHERE rs.category='R' and rs.status='1'
                GROUP BY rm.partcode ORDER BY Total_Kg DESC", datagrid_stock_recycled)
        reload("SELECT rm.partcode, SUM(rs.qty) AS Total_Kg FROM molding_resin rs
                 JOIN molding_resin_masterlist rm ON rm.id=rs.resinid
                WHERE rs.category='M' and rs.status='1'
                GROUP BY rm.partcode ORDER BY Total_Kg DESC", datagrid_stock_mixed)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        savetoPDF(datagrid_delivery, "Resin Delivery")
    End Sub

    Private Sub savetoPDF(datagrid As Guna.UI2.WinForms.Guna2DataGridView, title As String)
        Try
            ' Get the selected date from dtpicker1
            Dim selectedDate As String = dtpicker_resindelivery.Value.ToString("MMMMdd-yyyyy")

            ' Prompt the user for the save location with the date in the file name
            Using saveDialog As New SaveFileDialog()
                saveDialog.Filter = "PDF Files (*.pdf)|*.pdf"
                saveDialog.FileName = "" & title & "_" & selectedDate & ".pdf"

                If saveDialog.ShowDialog() = DialogResult.OK Then
                    ' Export DataGridView to PDF using iTextSharp
                    Dim pdfDoc As New Document(PageSize.A4, 10, 10, 10, 10)
                    Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(saveDialog.FileName, FileMode.Create))
                    pdfDoc.Open()

                    ' Adding title with Helvetica font
                    Dim titleFont As Font = FontFactory.GetFont("Helvetica", CSng(16), CType(Font.Bold, Integer))
                    pdfDoc.Add(New Paragraph(title, titleFont) With {.Alignment = Element.ALIGN_CENTER})

                    ' Add selected date from dtpicker1
                    Dim dateFont As Font = FontFactory.GetFont("Helvetica", CSng(12), CType(Font.Bold, Integer))
                    pdfDoc.Add(New Paragraph("Date: " & dtpicker_resindelivery.Value.ToString("MMMM-dd-yyyy"), dateFont) With {.Alignment = Element.ALIGN_CENTER})
                    pdfDoc.Add(New Paragraph(Environment.NewLine)) ' Add a space after the title and date

                    ' Create PDF table
                    Dim pdfTable As New PdfPTable(datagrid.ColumnCount) With {
                        .WidthPercentage = 100,
                        .SpacingBefore = 10,
                        .SpacingAfter = 10
                    }

                    ' Add table headers
                    For Each column As DataGridViewColumn In datagrid.Columns
                        Dim headerFont As Font = FontFactory.GetFont("Helvetica", CSng(12), CType(Font.Bold, Integer))
                        pdfTable.AddCell(New PdfPCell(New Phrase(column.HeaderText, headerFont)) With {.HorizontalAlignment = Element.ALIGN_CENTER})
                    Next

                    ' Add table data
                    For Each row As DataGridViewRow In datagrid.Rows
                        If Not row.IsNewRow Then
                            For Each cell As DataGridViewCell In row.Cells
                                Dim cellValue As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                                pdfTable.AddCell(New Phrase(cellValue))
                            Next
                        End If
                    Next

                    ' Add table to document
                    pdfDoc.Add(pdfTable)
                    pdfDoc.Close()
                    writer.Close()

                    MessageBox.Show("Exported to PDF successfully.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while exporting: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtpicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker_resindelivery.ValueChanged
        reload("SELECT rm.partcode, COUNT(rs.id) AS count, SUM(rs.qty) AS Sack FROM molding_resin rs
                 JOIN molding_resin_masterlist rm ON rm.id=rs.resinid
                  WHERE rs.datein ='" & dtpicker_resindelivery.Value.ToString("yyyy-MM-dd") & "' and category='V'
                GROUP BY rs.resinid ORDER BY count DESC", datagrid_delivery)
    End Sub



    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        savetoPDF(datagrid_stock_virgin, "Resin Stock (Virgin) ")
    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker_used.ValueChanged
        reload("SELECT rm.partcode, sum(rs.qty) AS Total FROM molding_resin rs
                 JOIN molding_resin_masterlist rm ON rm.id=rs.resinid
                  WHERE rs.dateout ='" & dtpicker_used.Value.ToString("yyyy-MM-dd") & "' and rs.status='0' and rs.category='M'
                GROUP BY rs.resinid ORDER BY Total DESC", datagrid_used_mixed)

        reload("SELECT rm.partcode, sum(rs.qty) AS Total FROM molding_resin rs
                 JOIN molding_resin_masterlist rm ON rm.id=rs.resinid
                  WHERE rs.dateout ='" & dtpicker_used.Value.ToString("yyyy-MM-dd") & "' and rs.status='0' and rs.category='V'
                GROUP BY rs.resinid ORDER BY Total DESC ", datagrid_used_virgin)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        savetoPDF(datagrid_stock_recycled, "Resin Stock (Recycled) ")
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        savetoPDF(datagrid_stock_mixed, "Resin Stock (Mixed) ")
    End Sub
End Class

Imports MySql.Data.MySqlClient
Imports QRCoder
Imports System.IO
Imports CrystalDecisions.CrystalReports
Public Class print_sticker_virgin
    Dim category As String = "V"
    Dim dt_records As New DataTable

    Dim resin_id As String
    Dim resin_weight As Decimal

    Dim startqty As Integer = 0
    Dim newqty As Integer
    Private Sub print_memo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loadrpt()
        cmb_display("SELECT DISTINCT(type) FROM `molding_resin_masterlist` ORDER BY type ASC", "type", cmb_type)

    End Sub

    Private Sub loadrpt()
        'Dim myrpt As New print_serial
        Dim myrpt As New printsticker
        ' Check if dt_records contains data
        If dt_records Is Nothing OrElse dt_records.Rows.Count = 0 Then
            MessageBox.Show("No data available for the report.")
            Exit Sub
        End If

        ' Clear existing report source
        CrystalReportViewer1.ReportSource = Nothing

        Try
            ' Get the table from the report
            Dim reportTable As CrystalDecisions.CrystalReports.Engine.Table = myrpt.Database.Tables("resin_serial")
            If reportTable Is Nothing Then
                MessageBox.Show("Table 'resin_serial' not found in the report.")
                Exit Sub
            End If

            ' Set the DataSource for the report
            reportTable.SetDataSource(dt_records)
            CrystalReportViewer1.ReportSource = myrpt
        Catch ex As Exception
            MessageBox.Show("Error setting report data source: " & ex.Message)
        End Try
    End Sub


    Private Sub txt_qty_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_qty_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedIndexChanged
        cmb_display("SELECT DISTINCT(partcode) FROM `molding_resin_masterlist` WHERE type ='" & cmb_type.Text & "'", "partcode", cmb_resin)
    End Sub

    Private Sub cmb_resin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_resin.SelectedIndexChanged
        con.Close()
        con.Open()
        Dim selectcmd As New MySqlCommand("SELECT id,partcode,weight FROM `molding_resin_masterlist` WHERE partcode = @partcode ", con)
        With selectcmd.Parameters
            .AddWithValue("@partcode", cmb_resin.Text)
        End With

        dr = selectcmd.ExecuteReader
        If dr.Read = True Then
            resin_id = dr.GetInt32("id")
            resin_weight = dr.GetDecimal("weight")
            resin_kg.Value = resin_weight
        End If


    End Sub


    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Try
            If category = "" Or cmb_resin.Text = "" Then
                display_error("Please Complete Data!")
                Exit Sub
            End If

            con.Close()
            con.Open()
            Dim selectcmd As New MySqlCommand("SELECT MAX(serialno) FROM molding_resin WHERE resinid=@resinid and category=@category", con)
            selectcmd.Parameters.AddWithValue("@resinid", resin_id)
            selectcmd.Parameters.AddWithValue("@category", category)
            dr = selectcmd.ExecuteReader()
            If dr.Read() Then
                If Not IsDBNull(dr(0)) Then
                    newqty = startqty + dr.GetInt32(0)
                Else
                    newqty = startqty
                End If

            End If
            dr.Close() ' Close the reader after usage

            ' Clear the DataGridView and DataTable
            datagrid1.Rows.Clear()
            dt_records.Clear()

            If dt_records.Columns.Count = 0 Then
                dt_records.Columns.Add("serial", GetType(String))
                dt_records.Columns.Add("partcode", GetType(String))
                dt_records.Columns.Add("category", GetType(String))
                dt_records.Columns.Add("number", GetType(String))
                dt_records.Columns.Add("qrcode", GetType(Byte())) ' Byte array for the QR code image
                dt_records.Columns.Add("qty", GetType(Decimal))
            End If

            dt_records.Rows.Clear()

            ' Get the quantity input from txt_qty
            Dim qty As Decimal
            If Decimal.TryParse(txt_qty.Text, qty) Then
                ' Generate rows based on the quantity
                For i As Integer = newqty + 1 To newqty + qty
                    Dim serial_no As String = $"{resin_id}|{resin_weight}|{category}|{i}"

                    ' Generate the QR code and convert it to a byte array
                    Dim qrImage As Image = GenerateQRCode(serial_no)
                    Dim qrImageBytes As Byte() = ImageToByteArray(qrImage)

                    ' Add the data and QR code to the DataTable
                    dt_records.Rows.Add(serial_no, cmb_resin.Text, category, i, qrImageBytes, resin_weight)

                    ' Also add to the DataGridView for visual confirmation
                    datagrid1.Rows.Add(i, serial_no)
                Next

                ' Load the report
                loadrpt()
            Else
                MessageBox.Show("Please enter a valid quantity.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close() ' Ensure the connection is closed
        End Try
    End Sub




    Private Function GenerateQRCode(serial As String) As Bitmap
        Dim qrGenerator As New QRCodeGenerator()
        Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(serial, QRCodeGenerator.ECCLevel.Q)
        Dim qrCode As New QRCode(qrCodeData)
        Return qrCode.GetGraphic(20)
    End Function
    Private Function ImageToByteArray(image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub btn_generate_Click(sender As Object, e As EventArgs)

    End Sub
End Class
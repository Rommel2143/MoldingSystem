﻿Imports MySql.Data.MySqlClient
Imports QRCoder
Imports System.IO
Public Class print_label
    Dim label_shift As String = "A"
    Dim dt_records As New DataTable
    Dim partcode As String
    Dim partname As String
    Private Sub print_label_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker1.Value = Date.Now
        cmb_display("SELECT CONCAT(partcode,'-',partname) AS item FROM molding_label_masterlist", "item", cmb_item)
    End Sub

    Private Sub cmb_item_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_item.SelectedIndexChanged
        Try
            con.Close()
            con.Open()

            Dim query As String = "SELECT `id`, `partcode`, `partname`, `model`, `material`, `cavity`, `qty` FROM molding_label_masterlist WHERE CONCAT(partcode,'-',partname)='" & cmb_item.Text & "'"
            Using displaydata As New MySqlCommand(query, con)
                dr = displaydata.ExecuteReader
                dr.Read()
                txt_total.Text = dr.GetInt32("qty").ToString
                lbl_cavity.Text = dr.GetInt32("cavity")
                lbl_material.Text = dr.GetString("material")
                lbl_model.Text = dr.GetString("model")
                partcode = dr.GetString("partcode")
                partname = dr.GetString("partname")
            End Using
        Catch ex As Exception
            display_error(ex.Message)
        End Try
    End Sub
    Private Sub checktotal() Handles cmb_item.SelectedIndexChanged
        txt_qty.Clear()

        If Convert.ToInt32(txt_total.Text) = 0 Then
            txt_total.Enabled = True
        Else
            txt_total.Enabled = False
        End If
    End Sub
    Private Sub numberKeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qty.KeyPress, txt_total.KeyPress
        ' Allow only digits and control characters (e.g., backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub num_qty_ValueChanged(sender As Object, e As EventArgs)
        If Convert.ToInt32(txt_qty.Text) < Convert.ToInt32(txt_total.Text) Then
            display_error("Qty must be larger then SPQ!")
        Else
            machine_frame.error_panel.Visible = False

        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        initializedata()
        Dim proddate As Date = dtpicker1.Value


        ' label_report.getdata(count, proddate, label_shift)
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub cmb_shift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_shift.SelectedIndexChanged
        Select Case cmb_shift.Text
            Case "Day"
                label_shift = "A"
            Case "Night"
                label_shift = "B"
        End Select


    End Sub

    Private Sub initializedata()
        Try
            Dim lotnumber As String
            Dim count As Integer = Convert.ToInt32(txt_qty.Text) / Convert.ToInt32(txt_total.Text)
            Dim serial As Integer
            Dim addserial As Integer
            Dim query As String = "SELECT MAX(id) FROM molding_label_serial"
            con.Close()
            con.Open()

            Dim checkmax As New MySqlCommand(query, con)
            dr = checkmax.ExecuteReader
                dr.Read()
            serial = dr.GetInt32(0) + 1
            addserial = serial
            con.Close()
            dt_records.Clear()
            ' Initialize the DataTable columns only once during form load
            If dt_records.Columns.Count = 0 Then
                dt_records.Columns.Add("partno", GetType(String))
                dt_records.Columns.Add("partname", GetType(String))
                dt_records.Columns.Add("process", GetType(String))
                dt_records.Columns.Add("model", GetType(String))
                dt_records.Columns.Add("lot", GetType(String))
                dt_records.Columns.Add("qty", GetType(Integer))
                dt_records.Columns.Add("material", GetType(String))
                dt_records.Columns.Add("material_lot", GetType(String))
                dt_records.Columns.Add("boxno", GetType(Integer))
                dt_records.Columns.Add("mold", GetType(String))
                dt_records.Columns.Add("remarks", GetType(String))
                dt_records.Columns.Add("proddate", GetType(Date))
                dt_records.Columns.Add("supcd", GetType(String))
                dt_records.Columns.Add("cavity", GetType(String))
                dt_records.Columns.Add("qrcode", GetType(Byte()))
            End If
            dt_records.Rows.Clear()
            ' Input validation


            ' Get the quantity input from num_qty
            For i As Integer = 1 To count

                lotnumber = dtpicker1.Value.ToString("yyMMdd") & "-" & i & "-" & label_shift & "-" & txt_operator.Text.ToUpper
                Dim qrcode As String = $"{partcode.PadRight(15)}{Convert.ToInt32(txt_total.Text).ToString.PadRight(5)}{lotnumber.PadRight(20)}{txt_mlot.Text.PadRight(20)}{num_mold.Value.ToString.PadRight(20)}{lbl_cavity.Text.ToString.PadRight(20)}{Date.Now.ToString("MM/d/yyyy").PadRight(10)}{lbl_material.Text.PadRight(40)}{"P86"}{serial.ToString.PadRight(10)}{txt_remarks.Text.PadRight(30)}{addserial.ToString.PadRight(10)}{lotnumber.PadRight(20)}"
                ' Generate the QR code and convert it to a byte array
                Dim qrImage As Image = GenerateQRCode(qrcode)
                Dim qrImageBytes As Byte() = ImageToByteArray(qrImage)

                ' Add the data and QR code to the DataTable
                dt_records.Rows.Add(partcode, partname, cmb_process.Text, lbl_model.Text, lotnumber, txt_total.Text, lbl_material.Text, txt_mlot.Text, i, num_mold.Value.ToString, txt_remarks.Text, dtpicker1.Value, "P86" & serial, lbl_cavity.Text, qrImageBytes)
                con.Close()
                con.Open()
                Dim queryadd As String = "INSERT INTO molding_label_serial (qrcode) VALUES ('" & qrcode & "')"
                Dim addqr As New MySqlCommand(queryadd, con)
                addqr.ExecuteNonQuery()

                    con.Close()
                addserial += 1
            Next

            ' Load the report
            loadrpt()
            loadrpt_small()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ' Close the connection only if it was opened
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
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

    Private Sub loadrpt()
        'Dim myrpt As New print_serial
        Dim myrpt As New labelrpt
        ' Check if dt_records contains data
        If dt_records Is Nothing OrElse dt_records.Rows.Count = 0 Then
            MessageBox.Show("No data available for the report.")
            Exit Sub
        End If

        ' Clear existing report source
        CrystalReportViewer1.ReportSource = Nothing

        Try
            ' Get the table from the report
            Dim reportTable As CrystalDecisions.CrystalReports.Engine.Table = myrpt.Database.Tables("label")
            If reportTable Is Nothing Then
                MessageBox.Show("Table not found in the report.")
                Exit Sub
            End If

            ' Set the DataSource for the report
            reportTable.SetDataSource(dt_records)
            CrystalReportViewer1.ReportSource = myrpt
        Catch ex As Exception
            MessageBox.Show("Error setting report data source: " & ex.Message)
        End Try
    End Sub


    Private Sub loadrpt_small()
        'Dim myrpt As New print_serial
        Dim myrpt As New smalllabel
        ' Check if dt_records contains data
        If dt_records Is Nothing OrElse dt_records.Rows.Count = 0 Then
            MessageBox.Show("No data available for the report.")
            Exit Sub
        End If

        ' Clear existing report source
        CrystalReportViewer2.ReportSource = Nothing

        Try
            ' Get the table from the report
            Dim reportTable As CrystalDecisions.CrystalReports.Engine.Table = myrpt.Database.Tables("label")
            If reportTable Is Nothing Then
                MessageBox.Show("Table not found in the report.")
                Exit Sub
            End If

            ' Set the DataSource for the report
            reportTable.SetDataSource(dt_records)
            CrystalReportViewer2.ReportSource = myrpt
        Catch ex As Exception
            MessageBox.Show("Error setting report data source: " & ex.Message)
        End Try
    End Sub
End Class
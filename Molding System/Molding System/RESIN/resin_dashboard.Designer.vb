<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resin_dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(resin_dashboard))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btn_export = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpicker_resindelivery = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.datagrid_delivery = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cmb_stock = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.datagrid_stock = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.datagrid_delivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.datagrid_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2GroupBox1.Controls.Add(Me.btn_export)
        Me.Guna2GroupBox1.Controls.Add(Me.dtpicker_resindelivery)
        Me.Guna2GroupBox1.Controls.Add(Me.datagrid_delivery)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.SystemColors.HotTrack
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(781, 102)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(383, 547)
        Me.Guna2GroupBox1.TabIndex = 228
        Me.Guna2GroupBox1.Text = "Resin Recieved"
        '
        'btn_export
        '
        Me.btn_export.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_export.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_export.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_export.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_export.FillColor = System.Drawing.SystemColors.HotTrack
        Me.btn_export.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_export.ForeColor = System.Drawing.Color.White
        Me.btn_export.Image = CType(resources.GetObject("btn_export.Image"), System.Drawing.Image)
        Me.btn_export.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_export.Location = New System.Drawing.Point(347, 0)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(33, 40)
        Me.btn_export.TabIndex = 230
        '
        'dtpicker_resindelivery
        '
        Me.dtpicker_resindelivery.Checked = True
        Me.dtpicker_resindelivery.FillColor = System.Drawing.SystemColors.HotTrack
        Me.dtpicker_resindelivery.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpicker_resindelivery.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpicker_resindelivery.Location = New System.Drawing.Point(122, 0)
        Me.dtpicker_resindelivery.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker_resindelivery.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker_resindelivery.Name = "dtpicker_resindelivery"
        Me.dtpicker_resindelivery.Size = New System.Drawing.Size(202, 40)
        Me.dtpicker_resindelivery.TabIndex = 209
        Me.dtpicker_resindelivery.Value = New Date(2024, 8, 20, 14, 57, 38, 936)
        '
        'datagrid_delivery
        '
        Me.datagrid_delivery.AllowUserToAddRows = False
        Me.datagrid_delivery.AllowUserToDeleteRows = False
        Me.datagrid_delivery.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid_delivery.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_delivery.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.datagrid_delivery.ColumnHeadersHeight = 30
        Me.datagrid_delivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_delivery.ColumnHeadersVisible = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_delivery.DefaultCellStyle = DataGridViewCellStyle11
        Me.datagrid_delivery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid_delivery.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_delivery.Location = New System.Drawing.Point(0, 40)
        Me.datagrid_delivery.Name = "datagrid_delivery"
        Me.datagrid_delivery.ReadOnly = True
        Me.datagrid_delivery.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_delivery.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.datagrid_delivery.RowHeadersVisible = False
        Me.datagrid_delivery.RowTemplate.Height = 31
        Me.datagrid_delivery.Size = New System.Drawing.Size(383, 507)
        Me.datagrid_delivery.TabIndex = 208
        Me.datagrid_delivery.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid_delivery.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagrid_delivery.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagrid_delivery.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagrid_delivery.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagrid_delivery.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagrid_delivery.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_delivery.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_delivery.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid_delivery.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_delivery.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid_delivery.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_delivery.ThemeStyle.HeaderStyle.Height = 30
        Me.datagrid_delivery.ThemeStyle.ReadOnly = True
        Me.datagrid_delivery.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid_delivery.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid_delivery.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_delivery.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid_delivery.ThemeStyle.RowsStyle.Height = 31
        Me.datagrid_delivery.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_delivery.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2GroupBox2.Controls.Add(Me.cmb_stock)
        Me.Guna2GroupBox2.Controls.Add(Me.datagrid_stock)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.SystemColors.HotTrack
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(287, 102)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(479, 547)
        Me.Guna2GroupBox2.TabIndex = 231
        Me.Guna2GroupBox2.Text = "Resin Stock"
        '
        'cmb_stock
        '
        Me.cmb_stock.BackColor = System.Drawing.Color.Transparent
        Me.cmb_stock.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_stock.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_stock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_stock.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmb_stock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_stock.ItemHeight = 30
        Me.cmb_stock.Items.AddRange(New Object() {"Virgin", "Recycled", "Mixed"})
        Me.cmb_stock.Location = New System.Drawing.Point(111, 2)
        Me.cmb_stock.Name = "cmb_stock"
        Me.cmb_stock.Size = New System.Drawing.Size(169, 36)
        Me.cmb_stock.StartIndex = 0
        Me.cmb_stock.TabIndex = 233
        '
        'datagrid_stock
        '
        Me.datagrid_stock.AllowUserToAddRows = False
        Me.datagrid_stock.AllowUserToDeleteRows = False
        Me.datagrid_stock.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid_stock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_stock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.datagrid_stock.ColumnHeadersHeight = 30
        Me.datagrid_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_stock.ColumnHeadersVisible = False
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_stock.DefaultCellStyle = DataGridViewCellStyle15
        Me.datagrid_stock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid_stock.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_stock.Location = New System.Drawing.Point(0, 40)
        Me.datagrid_stock.Name = "datagrid_stock"
        Me.datagrid_stock.ReadOnly = True
        Me.datagrid_stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_stock.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.datagrid_stock.RowHeadersVisible = False
        Me.datagrid_stock.RowTemplate.Height = 31
        Me.datagrid_stock.Size = New System.Drawing.Size(479, 507)
        Me.datagrid_stock.TabIndex = 208
        Me.datagrid_stock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid_stock.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagrid_stock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagrid_stock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagrid_stock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagrid_stock.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagrid_stock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_stock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_stock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid_stock.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_stock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid_stock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid_stock.ThemeStyle.HeaderStyle.Height = 30
        Me.datagrid_stock.ThemeStyle.ReadOnly = True
        Me.datagrid_stock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid_stock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid_stock.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_stock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid_stock.ThemeStyle.RowsStyle.Height = 31
        Me.datagrid_stock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid_stock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.SystemColors.HotTrack
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button1.Location = New System.Drawing.Point(443, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(33, 40)
        Me.Guna2Button1.TabIndex = 230
        '
        'resin_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 751)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "resin_dashboard"
        Me.Text = "resin_dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.datagrid_delivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        CType(Me.datagrid_stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents datagrid_delivery As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btn_export As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpicker_resindelivery As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents datagrid_stock As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmb_stock As Guna.UI2.WinForms.Guna2ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print_sticker_mixed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(print_sticker_mixed))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.check_r = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.check_v = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtqr_r = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panel_create = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.resin_kg = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_qty = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.btn_generate = New Guna.UI2.WinForms.Guna2Button()
        Me.cmb_type = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_resin = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtqr_v = New Guna.UI2.WinForms.Guna2TextBox()
        Me.datagrid1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.check_r, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.check_v, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_create.SuspendLayout()
        CType(Me.resin_kg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.check_r)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel2.Controls.Add(Me.check_v)
        Me.Guna2Panel2.Controls.Add(Me.Label8)
        Me.Guna2Panel2.Controls.Add(Me.Label7)
        Me.Guna2Panel2.Controls.Add(Me.txtqr_r)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.panel_create)
        Me.Guna2Panel2.Controls.Add(Me.txtqr_v)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1242, 249)
        Me.Guna2Panel2.TabIndex = 238
        '
        'check_r
        '
        Me.check_r.BackColor = System.Drawing.Color.Transparent
        Me.check_r.Image = CType(resources.GetObject("check_r.Image"), System.Drawing.Image)
        Me.check_r.ImageRotate = 0!
        Me.check_r.Location = New System.Drawing.Point(549, 29)
        Me.check_r.Name = "check_r"
        Me.check_r.Size = New System.Drawing.Size(19, 19)
        Me.check_r.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.check_r.TabIndex = 244
        Me.check_r.TabStop = False
        Me.check_r.Visible = False
        '
        'check_v
        '
        Me.check_v.BackColor = System.Drawing.Color.Transparent
        Me.check_v.Image = CType(resources.GetObject("check_v.Image"), System.Drawing.Image)
        Me.check_v.ImageRotate = 0!
        Me.check_v.Location = New System.Drawing.Point(257, 29)
        Me.check_v.Name = "check_v"
        Me.check_v.Size = New System.Drawing.Size(19, 19)
        Me.check_v.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.check_v.TabIndex = 243
        Me.check_v.TabStop = False
        Me.check_v.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(288, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 30)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(318, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 241
        Me.Label7.Text = "RECYCLED"
        '
        'txtqr_r
        '
        Me.txtqr_r.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtqr_r.DefaultText = ""
        Me.txtqr_r.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtqr_r.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtqr_r.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtqr_r.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtqr_r.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqr_r.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtqr_r.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqr_r.IconLeft = CType(resources.GetObject("txtqr_r.IconLeft"), System.Drawing.Image)
        Me.txtqr_r.Location = New System.Drawing.Point(321, 22)
        Me.txtqr_r.Name = "txtqr_r"
        Me.txtqr_r.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtqr_r.PlaceholderText = "Scan Barcode..."
        Me.txtqr_r.SelectedText = ""
        Me.txtqr_r.Size = New System.Drawing.Size(249, 36)
        Me.txtqr_r.TabIndex = 240
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(27, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 239
        Me.Label6.Text = "VIRGIN"
        '
        'panel_create
        '
        Me.panel_create.Controls.Add(Me.Label5)
        Me.panel_create.Controls.Add(Me.resin_kg)
        Me.panel_create.Controls.Add(Me.Label4)
        Me.panel_create.Controls.Add(Me.txt_qty)
        Me.panel_create.Controls.Add(Me.btn_generate)
        Me.panel_create.Controls.Add(Me.cmb_type)
        Me.panel_create.Controls.Add(Me.Label2)
        Me.panel_create.Controls.Add(Me.Label1)
        Me.panel_create.Controls.Add(Me.cmb_resin)
        Me.panel_create.Controls.Add(Me.Label3)
        Me.panel_create.Enabled = False
        Me.panel_create.Location = New System.Drawing.Point(12, 64)
        Me.panel_create.Name = "panel_create"
        Me.panel_create.Size = New System.Drawing.Size(865, 176)
        Me.panel_create.TabIndex = 238
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(604, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 65)
        Me.Label5.TabIndex = 236
        Me.Label5.Text = "MIXED"
        '
        'resin_kg
        '
        Me.resin_kg.BackColor = System.Drawing.Color.Transparent
        Me.resin_kg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.resin_kg.DecimalPlaces = 2
        Me.resin_kg.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resin_kg.Location = New System.Drawing.Point(222, 105)
        Me.resin_kg.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.resin_kg.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.resin_kg.Name = "resin_kg"
        Me.resin_kg.Size = New System.Drawing.Size(141, 62)
        Me.resin_kg.TabIndex = 235
        Me.resin_kg.UpDownButtonFillColor = System.Drawing.SystemColors.HotTrack
        Me.resin_kg.Value = New Decimal(New Integer() {22, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(219, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 234
        Me.Label4.Text = "KG :"
        '
        'txt_qty
        '
        Me.txt_qty.BackColor = System.Drawing.Color.Transparent
        Me.txt_qty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_qty.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(21, 105)
        Me.txt_qty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(141, 62)
        Me.txt_qty.TabIndex = 233
        Me.txt_qty.UpDownButtonFillColor = System.Drawing.SystemColors.HotTrack
        Me.txt_qty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btn_generate
        '
        Me.btn_generate.Animated = True
        Me.btn_generate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_generate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_generate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_generate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_generate.FillColor = System.Drawing.SystemColors.HotTrack
        Me.btn_generate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generate.ForeColor = System.Drawing.Color.White
        Me.btn_generate.Image = CType(resources.GetObject("btn_generate.Image"), System.Drawing.Image)
        Me.btn_generate.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_generate.Location = New System.Drawing.Point(423, 105)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(175, 62)
        Me.btn_generate.TabIndex = 155
        Me.btn_generate.Text = "Generate Serial"
        '
        'cmb_type
        '
        Me.cmb_type.BackColor = System.Drawing.Color.Transparent
        Me.cmb_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_type.DropDownHeight = 300
        Me.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_type.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_type.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_type.IntegralHeight = False
        Me.cmb_type.ItemHeight = 30
        Me.cmb_type.Location = New System.Drawing.Point(21, 32)
        Me.cmb_type.MaxDropDownItems = 5
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(167, 36)
        Me.cmb_type.TabIndex = 153
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(18, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = " Resin Type :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(18, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "Sack Qty :"
        '
        'cmb_resin
        '
        Me.cmb_resin.BackColor = System.Drawing.Color.Transparent
        Me.cmb_resin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_resin.DropDownHeight = 300
        Me.cmb_resin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_resin.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_resin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_resin.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_resin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_resin.IntegralHeight = False
        Me.cmb_resin.ItemHeight = 30
        Me.cmb_resin.Location = New System.Drawing.Point(222, 32)
        Me.cmb_resin.MaxDropDownItems = 5
        Me.cmb_resin.Name = "cmb_resin"
        Me.cmb_resin.Size = New System.Drawing.Size(376, 36)
        Me.cmb_resin.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(219, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = " Resin Code :"
        '
        'txtqr_v
        '
        Me.txtqr_v.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtqr_v.DefaultText = ""
        Me.txtqr_v.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtqr_v.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtqr_v.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtqr_v.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtqr_v.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqr_v.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtqr_v.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqr_v.IconLeft = CType(resources.GetObject("txtqr_v.IconLeft"), System.Drawing.Image)
        Me.txtqr_v.Location = New System.Drawing.Point(30, 22)
        Me.txtqr_v.Name = "txtqr_v"
        Me.txtqr_v.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtqr_v.PlaceholderText = "Scan Barcode..."
        Me.txtqr_v.SelectedText = ""
        Me.txtqr_v.Size = New System.Drawing.Size(249, 36)
        Me.txtqr_v.TabIndex = 237
        '
        'datagrid1
        '
        Me.datagrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.datagrid1.ColumnHeadersHeight = 35
        Me.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid1.DefaultCellStyle = DataGridViewCellStyle7
        Me.datagrid1.Dock = System.Windows.Forms.DockStyle.Left
        Me.datagrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.Location = New System.Drawing.Point(0, 0)
        Me.datagrid1.Name = "datagrid1"
        Me.datagrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.datagrid1.RowHeadersVisible = False
        Me.datagrid1.RowTemplate.Height = 36
        Me.datagrid1.Size = New System.Drawing.Size(305, 513)
        Me.datagrid1.TabIndex = 2
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid1.ThemeStyle.HeaderStyle.Height = 35
        Me.datagrid1.ThemeStyle.ReadOnly = False
        Me.datagrid1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.Height = 36
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column2
        '
        Me.Column2.FillWeight = 80.95028!
        Me.Column2.HeaderText = "No."
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.FillWeight = 118.3898!
        Me.Column1.HeaderText = "Serial Code"
        Me.Column1.Name = "Column1"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.CrystalReportViewer1)
        Me.Guna2Panel1.Controls.Add(Me.datagrid1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 249)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1242, 513)
        Me.Guna2Panel1.TabIndex = 237
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(305, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(937, 513)
        Me.CrystalReportViewer1.TabIndex = 151
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
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
        Me.Guna2Button1.Location = New System.Drawing.Point(576, 22)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(98, 36)
        Me.Guna2Button1.TabIndex = 245
        Me.Guna2Button1.Text = "Proceed"
        '
        'print_sticker_mixed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 762)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "print_sticker_mixed"
        Me.Text = "print_sticker_mixed"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.check_r, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.check_v, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_create.ResumeLayout(False)
        Me.panel_create.PerformLayout()
        CType(Me.resin_kg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents resin_kg As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_qty As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents btn_generate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmb_type As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_resin As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents datagrid1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtqr_r As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents panel_create As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtqr_v As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents check_r As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents check_v As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class

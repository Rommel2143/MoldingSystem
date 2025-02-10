<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print_label
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(print_label))
        Me.cmb_item = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_process = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_material = New System.Windows.Forms.Label()
        Me.lbl_model = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_cavity = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmb_mold = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_remarks = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_total = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_qty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_shift = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tabcontrol1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_mlot = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_operator = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.num_count = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.txt_qrsmall = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.tabcontrol1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.num_count, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_item
        '
        Me.cmb_item.BackColor = System.Drawing.Color.Transparent
        Me.cmb_item.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_item.DropDownHeight = 360
        Me.cmb_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_item.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_item.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_item.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_item.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_item.IntegralHeight = False
        Me.cmb_item.ItemHeight = 30
        Me.cmb_item.Location = New System.Drawing.Point(184, 76)
        Me.cmb_item.MaxDropDownItems = 10
        Me.cmb_item.Name = "cmb_item"
        Me.cmb_item.Size = New System.Drawing.Size(249, 36)
        Me.cmb_item.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(37, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Partcode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(558, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Process"
        '
        'cmb_process
        '
        Me.cmb_process.BackColor = System.Drawing.Color.Transparent
        Me.cmb_process.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_process.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_process.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_process.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_process.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_process.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_process.ItemHeight = 30
        Me.cmb_process.Items.AddRange(New Object() {"Injection", "Assembly", "Packing Process"})
        Me.cmb_process.Location = New System.Drawing.Point(561, 192)
        Me.cmb_process.Name = "cmb_process"
        Me.cmb_process.Size = New System.Drawing.Size(291, 36)
        Me.cmb_process.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(559, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "SPQ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(62, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Material"
        '
        'lbl_material
        '
        Me.lbl_material.AutoSize = True
        Me.lbl_material.BackColor = System.Drawing.Color.Transparent
        Me.lbl_material.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_material.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_material.Location = New System.Drawing.Point(62, 161)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(28, 21)
        Me.lbl_material.TabIndex = 15
        Me.lbl_material.Text = "---"
        '
        'lbl_model
        '
        Me.lbl_model.AutoSize = True
        Me.lbl_model.BackColor = System.Drawing.Color.Transparent
        Me.lbl_model.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_model.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_model.Location = New System.Drawing.Point(62, 225)
        Me.lbl_model.Name = "lbl_model"
        Me.lbl_model.Size = New System.Drawing.Size(28, 21)
        Me.lbl_model.TabIndex = 17
        Me.lbl_model.Text = "---"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(62, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Model"
        '
        'lbl_cavity
        '
        Me.lbl_cavity.AutoSize = True
        Me.lbl_cavity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cavity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cavity.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_cavity.Location = New System.Drawing.Point(63, 289)
        Me.lbl_cavity.Name = "lbl_cavity"
        Me.lbl_cavity.Size = New System.Drawing.Size(28, 21)
        Me.lbl_cavity.TabIndex = 19
        Me.lbl_cavity.Text = "---"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(63, 272)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 17)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Cavity"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.txt_search)
        Me.Guna2Panel1.Controls.Add(Me.cmb_mold)
        Me.Guna2Panel1.Controls.Add(Me.lbl_cavity)
        Me.Guna2Panel1.Controls.Add(Me.Label12)
        Me.Guna2Panel1.Controls.Add(Me.lbl_model)
        Me.Guna2Panel1.Controls.Add(Me.Label10)
        Me.Guna2Panel1.Controls.Add(Me.lbl_material)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.cmb_item)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(64, 96)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(469, 440)
        Me.Guna2Panel1.TabIndex = 22
        '
        'cmb_mold
        '
        Me.cmb_mold.AutoSize = True
        Me.cmb_mold.BackColor = System.Drawing.Color.Transparent
        Me.cmb_mold.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_mold.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cmb_mold.Location = New System.Drawing.Point(63, 357)
        Me.cmb_mold.Name = "cmb_mold"
        Me.cmb_mold.Size = New System.Drawing.Size(28, 21)
        Me.cmb_mold.TabIndex = 24
        Me.cmb_mold.Text = "---"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(62, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Mold no."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(558, 386)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 17)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Remarks"
        '
        'txt_remarks
        '
        Me.txt_remarks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_remarks.DefaultText = ""
        Me.txt_remarks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_remarks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_remarks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_remarks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_remarks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_remarks.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remarks.ForeColor = System.Drawing.Color.Black
        Me.txt_remarks.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_remarks.Location = New System.Drawing.Point(561, 407)
        Me.txt_remarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_remarks.MaxLength = 30
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_remarks.PlaceholderText = ""
        Me.txt_remarks.SelectedText = ""
        Me.txt_remarks.Size = New System.Drawing.Size(293, 38)
        Me.txt_remarks.TabIndex = 25
        '
        'dtpicker1
        '
        Me.dtpicker1.Checked = True
        Me.dtpicker1.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.dtpicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpicker1.ForeColor = System.Drawing.Color.White
        Me.dtpicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpicker1.Location = New System.Drawing.Point(561, 116)
        Me.dtpicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker1.Name = "dtpicker1"
        Me.dtpicker1.Size = New System.Drawing.Size(213, 36)
        Me.dtpicker1.TabIndex = 27
        Me.dtpicker1.Value = New Date(2024, 10, 14, 14, 22, 15, 800)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label16.Location = New System.Drawing.Point(558, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 17)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Production Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(715, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Qty"
        '
        'txt_total
        '
        Me.txt_total.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_total.DefaultText = ""
        Me.txt_total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_total.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_total.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.Black
        Me.txt_total.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_total.Location = New System.Drawing.Point(561, 335)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_total.MaxLength = 5
        Me.txt_total.Name = "txt_total"
        Me.txt_total.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_total.PlaceholderText = ""
        Me.txt_total.SelectedText = ""
        Me.txt_total.Size = New System.Drawing.Size(135, 38)
        Me.txt_total.TabIndex = 31
        '
        'txt_qty
        '
        Me.txt_qty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_qty.DefaultText = ""
        Me.txt_qty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_qty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_qty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_qty.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.ForeColor = System.Drawing.Color.Black
        Me.txt_qty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_qty.Location = New System.Drawing.Point(718, 335)
        Me.txt_qty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_qty.MaxLength = 5
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_qty.PlaceholderText = ""
        Me.txt_qty.SelectedText = ""
        Me.txt_qty.Size = New System.Drawing.Size(136, 40)
        Me.txt_qty.TabIndex = 32
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(718, 463)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(134, 59)
        Me.Guna2Button1.TabIndex = 33
        Me.Guna2Button1.Text = "Generate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(777, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Shift"
        '
        'cmb_shift
        '
        Me.cmb_shift.BackColor = System.Drawing.Color.Transparent
        Me.cmb_shift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_shift.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_shift.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_shift.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_shift.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_shift.ItemHeight = 30
        Me.cmb_shift.Items.AddRange(New Object() {"Day", "Night"})
        Me.cmb_shift.Location = New System.Drawing.Point(780, 116)
        Me.cmb_shift.Name = "cmb_shift"
        Me.cmb_shift.Size = New System.Drawing.Size(74, 36)
        Me.cmb_shift.StartIndex = 0
        Me.cmb_shift.TabIndex = 34
        '
        'tabcontrol1
        '
        Me.tabcontrol1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tabcontrol1.Controls.Add(Me.TabPage1)
        Me.tabcontrol1.Controls.Add(Me.TabPage2)
        Me.tabcontrol1.Controls.Add(Me.TabPage3)
        Me.tabcontrol1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrol1.ItemSize = New System.Drawing.Size(180, 40)
        Me.tabcontrol1.Location = New System.Drawing.Point(0, 0)
        Me.tabcontrol1.Name = "tabcontrol1"
        Me.tabcontrol1.SelectedIndex = 0
        Me.tabcontrol1.Size = New System.Drawing.Size(1123, 803)
        Me.tabcontrol1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.tabcontrol1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tabcontrol1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tabcontrol1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.tabcontrol1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tabcontrol1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.tabcontrol1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tabcontrol1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tabcontrol1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.tabcontrol1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tabcontrol1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.tabcontrol1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.tabcontrol1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tabcontrol1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.tabcontrol1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabcontrol1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.tabcontrol1.TabIndex = 36
        Me.tabcontrol1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txt_mlot)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txt_operator)
        Me.TabPage1.Controls.Add(Me.Guna2Panel1)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txt_total)
        Me.TabPage1.Controls.Add(Me.cmb_process)
        Me.TabPage1.Controls.Add(Me.dtpicker1)
        Me.TabPage1.Controls.Add(Me.txt_qty)
        Me.TabPage1.Controls.Add(Me.cmb_shift)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_remarks)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Guna2Button1)
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(935, 795)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generate"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(559, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 17)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Material Lot"
        '
        'txt_mlot
        '
        Me.txt_mlot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_mlot.DefaultText = ""
        Me.txt_mlot.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_mlot.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_mlot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_mlot.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_mlot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_mlot.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mlot.ForeColor = System.Drawing.Color.Black
        Me.txt_mlot.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_mlot.Location = New System.Drawing.Point(562, 261)
        Me.txt_mlot.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_mlot.MaxLength = 30
        Me.txt_mlot.Name = "txt_mlot"
        Me.txt_mlot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_mlot.PlaceholderText = ""
        Me.txt_mlot.SelectedText = ""
        Me.txt_mlot.Size = New System.Drawing.Size(293, 38)
        Me.txt_mlot.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(558, 463)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 17)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Operator Initials"
        '
        'txt_operator
        '
        Me.txt_operator.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_operator.DefaultText = ""
        Me.txt_operator.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_operator.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_operator.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_operator.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_operator.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_operator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_operator.ForeColor = System.Drawing.Color.Black
        Me.txt_operator.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_operator.Location = New System.Drawing.Point(561, 484)
        Me.txt_operator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_operator.MaxLength = 4
        Me.txt_operator.Name = "txt_operator"
        Me.txt_operator.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_operator.PlaceholderText = ""
        Me.txt_operator.SelectedText = ""
        Me.txt_operator.Size = New System.Drawing.Size(134, 38)
        Me.txt_operator.TabIndex = 36
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(935, 795)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Label Preview"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(929, 789)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CrystalReportViewer2)
        Me.TabPage3.Controls.Add(Me.Guna2Panel2)
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(935, 795)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sticker (small)"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(0, 144)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(935, 651)
        Me.CrystalReportViewer2.TabIndex = 0
        Me.CrystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel2.Controls.Add(Me.Label13)
        Me.Guna2Panel2.Controls.Add(Me.num_count)
        Me.Guna2Panel2.Controls.Add(Me.txt_qrsmall)
        Me.Guna2Panel2.Controls.Add(Me.Label11)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(935, 144)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(494, 56)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(108, 38)
        Me.Guna2Button2.TabIndex = 39
        Me.Guna2Button2.Text = "Generate"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(376, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 17)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Count"
        '
        'num_count
        '
        Me.num_count.BackColor = System.Drawing.Color.Transparent
        Me.num_count.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.num_count.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.num_count.Location = New System.Drawing.Point(379, 56)
        Me.num_count.Name = "num_count"
        Me.num_count.Size = New System.Drawing.Size(88, 38)
        Me.num_count.TabIndex = 38
        Me.num_count.UpDownButtonFillColor = System.Drawing.Color.DarkSlateBlue
        '
        'txt_qrsmall
        '
        Me.txt_qrsmall.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_qrsmall.DefaultText = ""
        Me.txt_qrsmall.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_qrsmall.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_qrsmall.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qrsmall.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qrsmall.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_qrsmall.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qrsmall.ForeColor = System.Drawing.Color.Black
        Me.txt_qrsmall.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_qrsmall.IconLeft = CType(resources.GetObject("txt_qrsmall.IconLeft"), System.Drawing.Image)
        Me.txt_qrsmall.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txt_qrsmall.Location = New System.Drawing.Point(34, 56)
        Me.txt_qrsmall.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_qrsmall.MaxLength = 300
        Me.txt_qrsmall.Name = "txt_qrsmall"
        Me.txt_qrsmall.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_qrsmall.PlaceholderText = "Scan QR..."
        Me.txt_qrsmall.SelectedText = ""
        Me.txt_qrsmall.Size = New System.Drawing.Size(326, 38)
        Me.txt_qrsmall.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(31, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 17)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Remarks"
        '
        'txt_search
        '
        Me.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search.DefaultText = ""
        Me.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.ForeColor = System.Drawing.Color.Black
        Me.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.IconLeft = CType(resources.GetObject("txt_search.IconLeft"), System.Drawing.Image)
        Me.txt_search.Location = New System.Drawing.Point(40, 77)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.MaxLength = 30
        Me.txt_search.Name = "txt_search"
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.PlaceholderText = "Input Keywords..."
        Me.txt_search.SelectedText = ""
        Me.txt_search.Size = New System.Drawing.Size(138, 35)
        Me.txt_search.TabIndex = 40
        '
        'print_label
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 803)
        Me.Controls.Add(Me.tabcontrol1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "print_label"
        Me.Text = "print_label"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.tabcontrol1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.num_count, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmb_item As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_process As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_material As Label
    Friend WithEvents lbl_model As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_cavity As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_remarks As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_total As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_qty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_shift As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tabcontrol1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_operator As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_mlot As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_qrsmall As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents num_count As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmb_mold As Label
    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
End Class

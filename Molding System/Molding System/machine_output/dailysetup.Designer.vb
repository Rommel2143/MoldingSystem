<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dailysetup
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dailysetup))
        Me.datagrid1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cancelbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbmold = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.updatebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.deletebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbshift = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtshift = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.panelset = New Guna.UI2.WinForms.Guna2Panel()
        Me.addbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.txtoperator = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtfname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txttarget = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtcode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtmaterial = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbmachine = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtuser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panelset.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagrid1
        '
        Me.datagrid1.AllowUserToAddRows = False
        Me.datagrid1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.datagrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.datagrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.datagrid1.ColumnHeadersHeight = 30
        Me.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid1.DefaultCellStyle = DataGridViewCellStyle6
        Me.datagrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.Location = New System.Drawing.Point(0, 398)
        Me.datagrid1.Name = "datagrid1"
        Me.datagrid1.ReadOnly = True
        Me.datagrid1.RowHeadersVisible = False
        Me.datagrid1.Size = New System.Drawing.Size(1503, 342)
        Me.datagrid1.TabIndex = 189
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
        Me.datagrid1.ThemeStyle.HeaderStyle.Height = 30
        Me.datagrid1.ThemeStyle.ReadOnly = True
        Me.datagrid1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.Height = 22
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'cancelbtn
        '
        Me.cancelbtn.BorderRadius = 2
        Me.cancelbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelbtn.FillColor = System.Drawing.Color.Tomato
        Me.cancelbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cancelbtn.ForeColor = System.Drawing.Color.White
        Me.cancelbtn.Location = New System.Drawing.Point(861, 154)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(99, 36)
        Me.cancelbtn.TabIndex = 157
        Me.cancelbtn.Text = "Cancel"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 156
        Me.Label10.Text = "Material Lot :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(535, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 155
        Me.Label11.Text = "Target :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(520, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 154
        Me.Label7.Text = "Mold No.  :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(523, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "Partname :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(526, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 152
        Me.Label9.Text = "Partcode :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Machine :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Operator/s :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "Scanner :"
        '
        'cmbmold
        '
        Me.cmbmold.BackColor = System.Drawing.Color.Transparent
        Me.cmbmold.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbmold.DropDownHeight = 200
        Me.cmbmold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmold.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbmold.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbmold.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbmold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbmold.IntegralHeight = False
        Me.cmbmold.ItemHeight = 30
        Me.cmbmold.Location = New System.Drawing.Point(586, 106)
        Me.cmbmold.Name = "cmbmold"
        Me.cmbmold.Size = New System.Drawing.Size(146, 36)
        Me.cmbmold.TabIndex = 148
        '
        'updatebtn
        '
        Me.updatebtn.BorderRadius = 2
        Me.updatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.updatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.updatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.updatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.updatebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.updatebtn.ForeColor = System.Drawing.Color.White
        Me.updatebtn.Location = New System.Drawing.Point(861, 70)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(99, 36)
        Me.updatebtn.TabIndex = 146
        Me.updatebtn.Text = "Update"
        '
        'deletebtn
        '
        Me.deletebtn.BorderRadius = 2
        Me.deletebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.deletebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.deletebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.deletebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.deletebtn.FillColor = System.Drawing.Color.Tomato
        Me.deletebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.deletebtn.ForeColor = System.Drawing.Color.White
        Me.deletebtn.Location = New System.Drawing.Point(861, 112)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(99, 36)
        Me.deletebtn.TabIndex = 145
        Me.deletebtn.Text = "Delete"
        '
        'cmbsearch
        '
        Me.cmbsearch.AutoRoundedCorners = True
        Me.cmbsearch.BorderRadius = 15
        Me.cmbsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cmbsearch.DefaultText = ""
        Me.cmbsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmbsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cmbsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cmbsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cmbsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmbsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbsearch.IconLeft = CType(resources.GetObject("cmbsearch.IconLeft"), System.Drawing.Image)
        Me.cmbsearch.Location = New System.Drawing.Point(24, 10)
        Me.cmbsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbsearch.Name = "cmbsearch"
        Me.cmbsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cmbsearch.PlaceholderText = "Enter Machine or Material lot..."
        Me.cmbsearch.SelectedText = ""
        Me.cmbsearch.Size = New System.Drawing.Size(224, 32)
        Me.cmbsearch.TabIndex = 207
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.cmbsearch)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 247)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1503, 49)
        Me.Guna2Panel1.TabIndex = 158
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panel2.Controls.Add(Me.cmbshift)
        Me.panel2.Controls.Add(Me.Label2)
        Me.panel2.Controls.Add(Me.Label1)
        Me.panel2.Controls.Add(Me.txtshift)
        Me.panel2.Controls.Add(Me.txtdate)
        Me.panel2.Controls.Add(Me.Guna2Separator1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 36)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1503, 66)
        Me.panel2.TabIndex = 187
        '
        'cmbshift
        '
        Me.cmbshift.BorderRadius = 2
        Me.cmbshift.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmbshift.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmbshift.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmbshift.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmbshift.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbshift.ForeColor = System.Drawing.Color.White
        Me.cmbshift.Location = New System.Drawing.Point(577, 12)
        Me.cmbshift.Name = "cmbshift"
        Me.cmbshift.Size = New System.Drawing.Size(99, 36)
        Me.cmbshift.TabIndex = 142
        Me.cmbshift.Text = "Set Date/Shift"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Shift :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Date :"
        '
        'txtshift
        '
        Me.txtshift.BackColor = System.Drawing.Color.Transparent
        Me.txtshift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtshift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtshift.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtshift.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtshift.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtshift.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtshift.ItemHeight = 30
        Me.txtshift.Items.AddRange(New Object() {"Day", "Night"})
        Me.txtshift.Location = New System.Drawing.Point(363, 12)
        Me.txtshift.Name = "txtshift"
        Me.txtshift.Size = New System.Drawing.Size(185, 36)
        Me.txtshift.TabIndex = 128
        '
        'txtdate
        '
        Me.txtdate.BorderRadius = 2
        Me.txtdate.Checked = True
        Me.txtdate.CustomFormat = "MMMM dd yyyy"
        Me.txtdate.FillColor = System.Drawing.SystemColors.Highlight
        Me.txtdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdate.ForeColor = System.Drawing.Color.White
        Me.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdate.Location = New System.Drawing.Point(64, 12)
        Me.txtdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(191, 36)
        Me.txtdate.TabIndex = 127
        Me.txtdate.Value = New Date(2024, 2, 15, 17, 36, 52, 828)
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Separator1.Location = New System.Drawing.Point(0, 47)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1503, 19)
        Me.Guna2Separator1.TabIndex = 131
        '
        'panelset
        '
        Me.panelset.Controls.Add(Me.Guna2Panel1)
        Me.panelset.Controls.Add(Me.cancelbtn)
        Me.panelset.Controls.Add(Me.Label10)
        Me.panelset.Controls.Add(Me.Label11)
        Me.panelset.Controls.Add(Me.Label7)
        Me.panelset.Controls.Add(Me.Label8)
        Me.panelset.Controls.Add(Me.Label9)
        Me.panelset.Controls.Add(Me.Label5)
        Me.panelset.Controls.Add(Me.Label4)
        Me.panelset.Controls.Add(Me.Label3)
        Me.panelset.Controls.Add(Me.cmbmold)
        Me.panelset.Controls.Add(Me.updatebtn)
        Me.panelset.Controls.Add(Me.deletebtn)
        Me.panelset.Controls.Add(Me.addbtn)
        Me.panelset.Controls.Add(Me.txtoperator)
        Me.panelset.Controls.Add(Me.txtfname)
        Me.panelset.Controls.Add(Me.txttarget)
        Me.panelset.Controls.Add(Me.txtcode)
        Me.panelset.Controls.Add(Me.txtmaterial)
        Me.panelset.Controls.Add(Me.cmbmachine)
        Me.panelset.Controls.Add(Me.txtname)
        Me.panelset.Controls.Add(Me.txtuser)
        Me.panelset.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelset.Location = New System.Drawing.Point(0, 102)
        Me.panelset.Name = "panelset"
        Me.panelset.Size = New System.Drawing.Size(1503, 296)
        Me.panelset.TabIndex = 188
        '
        'addbtn
        '
        Me.addbtn.BorderRadius = 2
        Me.addbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addbtn.FillColor = System.Drawing.Color.ForestGreen
        Me.addbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addbtn.ForeColor = System.Drawing.Color.White
        Me.addbtn.Location = New System.Drawing.Point(861, 27)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(99, 36)
        Me.addbtn.TabIndex = 143
        Me.addbtn.Text = "Add Machine"
        '
        'txtoperator
        '
        Me.txtoperator.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtoperator.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtoperator.DefaultText = ""
        Me.txtoperator.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtoperator.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtoperator.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtoperator.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtoperator.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtoperator.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtoperator.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtoperator.Location = New System.Drawing.Point(101, 63)
        Me.txtoperator.Name = "txtoperator"
        Me.txtoperator.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtoperator.PlaceholderText = "Machine Operator/s..."
        Me.txtoperator.SelectedText = ""
        Me.txtoperator.Size = New System.Drawing.Size(389, 30)
        Me.txtoperator.TabIndex = 141
        '
        'txtfname
        '
        Me.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfname.DefaultText = ""
        Me.txtfname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfname.Enabled = False
        Me.txtfname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfname.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtfname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfname.Location = New System.Drawing.Point(248, 27)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfname.PlaceholderText = "Name of Scanner"
        Me.txtfname.SelectedText = ""
        Me.txtfname.Size = New System.Drawing.Size(242, 30)
        Me.txtfname.TabIndex = 140
        '
        'txttarget
        '
        Me.txttarget.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttarget.DefaultText = ""
        Me.txttarget.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttarget.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttarget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttarget.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttarget.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttarget.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttarget.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttarget.Location = New System.Drawing.Point(586, 149)
        Me.txttarget.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttarget.Name = "txttarget"
        Me.txttarget.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttarget.PlaceholderText = "Target Plan..."
        Me.txttarget.SelectedText = ""
        Me.txttarget.Size = New System.Drawing.Size(172, 37)
        Me.txttarget.TabIndex = 138
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.Color.Transparent
        Me.txtcode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtcode.DropDownHeight = 200
        Me.txtcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtcode.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtcode.IntegralHeight = False
        Me.txtcode.ItemHeight = 30
        Me.txtcode.Location = New System.Drawing.Point(586, 27)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(229, 36)
        Me.txtcode.TabIndex = 137
        '
        'txtmaterial
        '
        Me.txtmaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmaterial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmaterial.DefaultText = ""
        Me.txtmaterial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtmaterial.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtmaterial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmaterial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmaterial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmaterial.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmaterial.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmaterial.Location = New System.Drawing.Point(101, 141)
        Me.txtmaterial.Name = "txtmaterial"
        Me.txtmaterial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmaterial.PlaceholderText = "Material Lot..."
        Me.txtmaterial.SelectedText = ""
        Me.txtmaterial.Size = New System.Drawing.Size(154, 30)
        Me.txtmaterial.TabIndex = 136
        '
        'cmbmachine
        '
        Me.cmbmachine.BackColor = System.Drawing.Color.Transparent
        Me.cmbmachine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbmachine.DropDownHeight = 200
        Me.cmbmachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmachine.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbmachine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbmachine.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbmachine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbmachine.IntegralHeight = False
        Me.cmbmachine.ItemHeight = 30
        Me.cmbmachine.Location = New System.Drawing.Point(101, 99)
        Me.cmbmachine.Name = "cmbmachine"
        Me.cmbmachine.Size = New System.Drawing.Size(224, 36)
        Me.cmbmachine.TabIndex = 135
        '
        'txtname
        '
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.DefaultText = ""
        Me.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.Location = New System.Drawing.Point(586, 69)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.PlaceholderText = "Part name..."
        Me.txtname.SelectedText = ""
        Me.txtname.Size = New System.Drawing.Size(229, 30)
        Me.txtname.TabIndex = 133
        '
        'txtuser
        '
        Me.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtuser.DefaultText = ""
        Me.txtuser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtuser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtuser.Enabled = False
        Me.txtuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtuser.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtuser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtuser.Location = New System.Drawing.Point(101, 27)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtuser.PlaceholderText = "Scanning Operator..."
        Me.txtuser.SelectedText = ""
        Me.txtuser.Size = New System.Drawing.Size(141, 30)
        Me.txtuser.TabIndex = 132
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1503, 36)
        Me.Panel1.TabIndex = 186
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(10, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 32)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "SET - UP"
        '
        'dailysetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1503, 740)
        Me.Controls.Add(Me.datagrid1)
        Me.Controls.Add(Me.panelset)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dailysetup"
        Me.Text = "daily_setup"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.panelset.ResumeLayout(False)
        Me.panelset.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datagrid1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cancelbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbmold As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents updatebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents deletebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmbshift As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtshift As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents panelset As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents addbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtoperator As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtfname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txttarget As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtcode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtmaterial As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbmachine As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtuser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
End Class

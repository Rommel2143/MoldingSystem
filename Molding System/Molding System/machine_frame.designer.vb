<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class machine_frame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(machine_frame))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btn_machine = New System.Windows.Forms.ToolStripMenuItem()
        Me.PARTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SCANFGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_add = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_mold = New System.Windows.Forms.ToolStripMenuItem()
        Me.userstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateVersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuggestToImproveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_resin = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateStickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScaninToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RECYCLEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OUTToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIXEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OUTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.resin_additem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_denso = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElematecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.error_panel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.ReturnBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.error_panel.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1208, 597)
        Me.Panel1.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_machine, Me.userstrip, Me.btn_resin, Me.btn_denso, Me.ElematecToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1208, 53)
        Me.MenuStrip1.TabIndex = 13
        '
        'btn_machine
        '
        Me.btn_machine.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PARTSToolStripMenuItem, Me.FGToolStripMenuItem, Me.SCANFGToolStripMenuItem, Me.btn_add, Me.btn_mold})
        Me.btn_machine.Image = CType(resources.GetObject("btn_machine.Image"), System.Drawing.Image)
        Me.btn_machine.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_machine.Name = "btn_machine"
        Me.btn_machine.Size = New System.Drawing.Size(116, 49)
        Me.btn_machine.Text = "Machine"
        '
        'PARTSToolStripMenuItem
        '
        Me.PARTSToolStripMenuItem.Image = CType(resources.GetObject("PARTSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PARTSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PARTSToolStripMenuItem.Name = "PARTSToolStripMenuItem"
        Me.PARTSToolStripMenuItem.Size = New System.Drawing.Size(197, 38)
        Me.PARTSToolStripMenuItem.Text = "Daily Setup"
        '
        'FGToolStripMenuItem
        '
        Me.FGToolStripMenuItem.Image = CType(resources.GetObject("FGToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FGToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FGToolStripMenuItem.Name = "FGToolStripMenuItem"
        Me.FGToolStripMenuItem.Size = New System.Drawing.Size(197, 38)
        Me.FGToolStripMenuItem.Text = "Daily Output"
        '
        'SCANFGToolStripMenuItem
        '
        Me.SCANFGToolStripMenuItem.Image = CType(resources.GetObject("SCANFGToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SCANFGToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SCANFGToolStripMenuItem.Name = "SCANFGToolStripMenuItem"
        Me.SCANFGToolStripMenuItem.Size = New System.Drawing.Size(197, 38)
        Me.SCANFGToolStripMenuItem.Text = "SCAN FG"
        '
        'btn_add
        '
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(197, 38)
        Me.btn_add.Text = "Add Partcode"
        Me.btn_add.Visible = False
        '
        'btn_mold
        '
        Me.btn_mold.Image = CType(resources.GetObject("btn_mold.Image"), System.Drawing.Image)
        Me.btn_mold.Name = "btn_mold"
        Me.btn_mold.Size = New System.Drawing.Size(197, 38)
        Me.btn_mold.Text = "Add Mold"
        Me.btn_mold.Visible = False
        '
        'userstrip
        '
        Me.userstrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.userstrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.MinimizeToolStripMenuItem, Me.ExitToolStripMenuItem, Me.UpdateVersionToolStripMenuItem, Me.SuggestToImproveToolStripMenuItem})
        Me.userstrip.Image = CType(resources.GetObject("userstrip.Image"), System.Drawing.Image)
        Me.userstrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.userstrip.Name = "userstrip"
        Me.userstrip.Size = New System.Drawing.Size(71, 49)
        Me.userstrip.Text = "User"
        Me.userstrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.userstrip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Image = CType(resources.GetObject("MinimizeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.MinimizeToolStripMenuItem.Text = "Minimize"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'UpdateVersionToolStripMenuItem
        '
        Me.UpdateVersionToolStripMenuItem.Image = CType(resources.GetObject("UpdateVersionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateVersionToolStripMenuItem.Name = "UpdateVersionToolStripMenuItem"
        Me.UpdateVersionToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.UpdateVersionToolStripMenuItem.Text = "Update Version"
        '
        'SuggestToImproveToolStripMenuItem
        '
        Me.SuggestToImproveToolStripMenuItem.Image = CType(resources.GetObject("SuggestToImproveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SuggestToImproveToolStripMenuItem.Name = "SuggestToImproveToolStripMenuItem"
        Me.SuggestToImproveToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.SuggestToImproveToolStripMenuItem.Text = "Suggest to improve"
        '
        'btn_resin
        '
        Me.btn_resin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.CreateStickerToolStripMenuItem, Me.ScaninToolStripMenuItem, Me.RECYCLEDToolStripMenuItem, Me.MIXEDToolStripMenuItem, Me.resin_additem, Me.btn_delete})
        Me.btn_resin.Image = CType(resources.GetObject("btn_resin.Image"), System.Drawing.Image)
        Me.btn_resin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_resin.Name = "btn_resin"
        Me.btn_resin.Size = New System.Drawing.Size(93, 49)
        Me.btn_resin.Text = "Resin"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Image = CType(resources.GetObject("DashboardToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DashboardToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(175, 38)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'CreateStickerToolStripMenuItem
        '
        Me.CreateStickerToolStripMenuItem.Image = CType(resources.GetObject("CreateStickerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CreateStickerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CreateStickerToolStripMenuItem.Name = "CreateStickerToolStripMenuItem"
        Me.CreateStickerToolStripMenuItem.Size = New System.Drawing.Size(175, 38)
        Me.CreateStickerToolStripMenuItem.Text = "Print Serial"
        '
        'ScaninToolStripMenuItem
        '
        Me.ScaninToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INToolStripMenuItem, Me.OUTToolStripMenuItem, Me.ReturnToolStripMenuItem})
        Me.ScaninToolStripMenuItem.Image = CType(resources.GetObject("ScaninToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ScaninToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ScaninToolStripMenuItem.Name = "ScaninToolStripMenuItem"
        Me.ScaninToolStripMenuItem.Size = New System.Drawing.Size(175, 38)
        Me.ScaninToolStripMenuItem.Text = "VIRGIN"
        '
        'INToolStripMenuItem
        '
        Me.INToolStripMenuItem.Name = "INToolStripMenuItem"
        Me.INToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.INToolStripMenuItem.Text = "IN"
        '
        'OUTToolStripMenuItem
        '
        Me.OUTToolStripMenuItem.Name = "OUTToolStripMenuItem"
        Me.OUTToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.OUTToolStripMenuItem.Text = "OUT"
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.ReturnToolStripMenuItem.Text = "Return"
        '
        'RECYCLEDToolStripMenuItem
        '
        Me.RECYCLEDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INToolStripMenuItem2, Me.OUTToolStripMenuItem2})
        Me.RECYCLEDToolStripMenuItem.Image = CType(resources.GetObject("RECYCLEDToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RECYCLEDToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RECYCLEDToolStripMenuItem.Name = "RECYCLEDToolStripMenuItem"
        Me.RECYCLEDToolStripMenuItem.Size = New System.Drawing.Size(175, 38)
        Me.RECYCLEDToolStripMenuItem.Text = "RECYCLED"
        '
        'INToolStripMenuItem2
        '
        Me.INToolStripMenuItem2.Name = "INToolStripMenuItem2"
        Me.INToolStripMenuItem2.Size = New System.Drawing.Size(112, 26)
        Me.INToolStripMenuItem2.Text = "IN"
        '
        'OUTToolStripMenuItem2
        '
        Me.OUTToolStripMenuItem2.Name = "OUTToolStripMenuItem2"
        Me.OUTToolStripMenuItem2.Size = New System.Drawing.Size(112, 26)
        Me.OUTToolStripMenuItem2.Text = "OUT"
        '
        'MIXEDToolStripMenuItem
        '
        Me.MIXEDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INToolStripMenuItem1, Me.OUTToolStripMenuItem1, Me.ReturnToolStripMenuItem1})
        Me.MIXEDToolStripMenuItem.Image = CType(resources.GetObject("MIXEDToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MIXEDToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MIXEDToolStripMenuItem.Name = "MIXEDToolStripMenuItem"
        Me.MIXEDToolStripMenuItem.Size = New System.Drawing.Size(175, 38)
        Me.MIXEDToolStripMenuItem.Text = "MIXED"
        '
        'INToolStripMenuItem1
        '
        Me.INToolStripMenuItem1.Name = "INToolStripMenuItem1"
        Me.INToolStripMenuItem1.Size = New System.Drawing.Size(129, 26)
        Me.INToolStripMenuItem1.Text = "IN"
        '
        'OUTToolStripMenuItem1
        '
        Me.OUTToolStripMenuItem1.Name = "OUTToolStripMenuItem1"
        Me.OUTToolStripMenuItem1.Size = New System.Drawing.Size(129, 26)
        Me.OUTToolStripMenuItem1.Text = "OUT"
        '
        'ReturnToolStripMenuItem1
        '
        Me.ReturnToolStripMenuItem1.Name = "ReturnToolStripMenuItem1"
        Me.ReturnToolStripMenuItem1.Size = New System.Drawing.Size(129, 26)
        Me.ReturnToolStripMenuItem1.Text = "Return"
        '
        'resin_additem
        '
        Me.resin_additem.Image = CType(resources.GetObject("resin_additem.Image"), System.Drawing.Image)
        Me.resin_additem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.resin_additem.Name = "resin_additem"
        Me.resin_additem.Size = New System.Drawing.Size(175, 38)
        Me.resin_additem.Text = "Add item"
        '
        'btn_delete
        '
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(175, 38)
        Me.btn_delete.Text = "Delete QR"
        Me.btn_delete.Visible = False
        '
        'btn_denso
        '
        Me.btn_denso.Image = CType(resources.GetObject("btn_denso.Image"), System.Drawing.Image)
        Me.btn_denso.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_denso.Name = "btn_denso"
        Me.btn_denso.Size = New System.Drawing.Size(143, 49)
        Me.btn_denso.Text = "Denso Label"
        '
        'ElematecToolStripMenuItem
        '
        Me.ElematecToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ReturnBoxToolStripMenuItem})
        Me.ElematecToolStripMenuItem.Image = CType(resources.GetObject("ElematecToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ElematecToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ElematecToolStripMenuItem.Name = "ElematecToolStripMenuItem"
        Me.ElematecToolStripMenuItem.Size = New System.Drawing.Size(120, 49)
        Me.ElematecToolStripMenuItem.Text = "Elematec"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.ToolStripMenuItem1.Text = "Scan IN"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 26)
        Me.ToolStripMenuItem2.Text = "Scan OUT"
        '
        'error_panel
        '
        Me.error_panel.Controls.Add(Me.Guna2PictureBox2)
        Me.error_panel.Controls.Add(Me.Guna2PictureBox1)
        Me.error_panel.Controls.Add(Me.lbl_error)
        Me.error_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.error_panel.FillColor = System.Drawing.Color.Red
        Me.error_panel.FillColor2 = System.Drawing.Color.Tomato
        Me.error_panel.Location = New System.Drawing.Point(0, 53)
        Me.error_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.error_panel.Name = "error_panel"
        Me.error_panel.Size = New System.Drawing.Size(1208, 27)
        Me.error_panel.TabIndex = 14
        Me.error_panel.Visible = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(1187, 7)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(10, 10)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 3
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(10, 2)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(16, 19)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'lbl_error
        '
        Me.lbl_error.AutoSize = True
        Me.lbl_error.BackColor = System.Drawing.Color.Transparent
        Me.lbl_error.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error.ForeColor = System.Drawing.Color.White
        Me.lbl_error.Location = New System.Drawing.Point(26, 2)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(27, 20)
        Me.lbl_error.TabIndex = 0
        Me.lbl_error.Text = "---"
        '
        'ReturnBoxToolStripMenuItem
        '
        Me.ReturnBoxToolStripMenuItem.Name = "ReturnBoxToolStripMenuItem"
        Me.ReturnBoxToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ReturnBoxToolStripMenuItem.Text = "Return Box"
        '
        'machine_frame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 677)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.error_panel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "machine_frame"
        Me.Text = "Scan_Frame"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.error_panel.ResumeLayout(False)
        Me.error_panel.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btn_machine As ToolStripMenuItem
    Friend WithEvents PARTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_add As ToolStripMenuItem
    Friend WithEvents btn_mold As ToolStripMenuItem
    Friend WithEvents userstrip As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateVersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuggestToImproveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_resin As ToolStripMenuItem
    Friend WithEvents CreateStickerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScaninToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RECYCLEDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MIXEDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SCANFGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OUTToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents INToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents OUTToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents resin_additem As ToolStripMenuItem
    Friend WithEvents ReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents error_panel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_error As Label
    Friend WithEvents ReturnToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btn_denso As ToolStripMenuItem
    Friend WithEvents btn_delete As ToolStripMenuItem
    Friend WithEvents ElematecToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ReturnBoxToolStripMenuItem As ToolStripMenuItem
End Class

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
        Me.AddPartcodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMoldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.RECYCLEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OUTToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIXEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OUTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1208, 624)
        Me.Panel1.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_machine, Me.userstrip, Me.btn_resin})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1208, 53)
        Me.MenuStrip1.TabIndex = 13
        '
        'btn_machine
        '
        Me.btn_machine.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PARTSToolStripMenuItem, Me.FGToolStripMenuItem, Me.SCANFGToolStripMenuItem, Me.AddPartcodeToolStripMenuItem, Me.AddMoldToolStripMenuItem})
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
        'AddPartcodeToolStripMenuItem
        '
        Me.AddPartcodeToolStripMenuItem.Image = CType(resources.GetObject("AddPartcodeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddPartcodeToolStripMenuItem.Name = "AddPartcodeToolStripMenuItem"
        Me.AddPartcodeToolStripMenuItem.Size = New System.Drawing.Size(197, 38)
        Me.AddPartcodeToolStripMenuItem.Text = "Add Partcode"
        '
        'AddMoldToolStripMenuItem
        '
        Me.AddMoldToolStripMenuItem.Image = CType(resources.GetObject("AddMoldToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddMoldToolStripMenuItem.Name = "AddMoldToolStripMenuItem"
        Me.AddMoldToolStripMenuItem.Size = New System.Drawing.Size(197, 38)
        Me.AddMoldToolStripMenuItem.Text = "Add Mold"
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
        Me.btn_resin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.CreateStickerToolStripMenuItem, Me.ScaninToolStripMenuItem, Me.RECYCLEDToolStripMenuItem, Me.MIXEDToolStripMenuItem, Me.AddItemToolStripMenuItem})
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
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'CreateStickerToolStripMenuItem
        '
        Me.CreateStickerToolStripMenuItem.Image = CType(resources.GetObject("CreateStickerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CreateStickerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CreateStickerToolStripMenuItem.Name = "CreateStickerToolStripMenuItem"
        Me.CreateStickerToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.CreateStickerToolStripMenuItem.Text = "Print Serial"
        '
        'ScaninToolStripMenuItem
        '
        Me.ScaninToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INToolStripMenuItem, Me.OUTToolStripMenuItem, Me.ReturnToolStripMenuItem})
        Me.ScaninToolStripMenuItem.Image = CType(resources.GetObject("ScaninToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ScaninToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ScaninToolStripMenuItem.Name = "ScaninToolStripMenuItem"
        Me.ScaninToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.ScaninToolStripMenuItem.Text = "VIRGIN"
        '
        'INToolStripMenuItem
        '
        Me.INToolStripMenuItem.Name = "INToolStripMenuItem"
        Me.INToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.INToolStripMenuItem.Text = "IN"
        '
        'OUTToolStripMenuItem
        '
        Me.OUTToolStripMenuItem.Name = "OUTToolStripMenuItem"
        Me.OUTToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.OUTToolStripMenuItem.Text = "OUT"
        '
        'RECYCLEDToolStripMenuItem
        '
        Me.RECYCLEDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INToolStripMenuItem2, Me.OUTToolStripMenuItem2})
        Me.RECYCLEDToolStripMenuItem.Image = CType(resources.GetObject("RECYCLEDToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RECYCLEDToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RECYCLEDToolStripMenuItem.Name = "RECYCLEDToolStripMenuItem"
        Me.RECYCLEDToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
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
        Me.MIXEDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INToolStripMenuItem1, Me.OUTToolStripMenuItem1})
        Me.MIXEDToolStripMenuItem.Image = CType(resources.GetObject("MIXEDToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MIXEDToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MIXEDToolStripMenuItem.Name = "MIXEDToolStripMenuItem"
        Me.MIXEDToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.MIXEDToolStripMenuItem.Text = "MIXED"
        '
        'INToolStripMenuItem1
        '
        Me.INToolStripMenuItem1.Name = "INToolStripMenuItem1"
        Me.INToolStripMenuItem1.Size = New System.Drawing.Size(112, 26)
        Me.INToolStripMenuItem1.Text = "IN"
        '
        'OUTToolStripMenuItem1
        '
        Me.OUTToolStripMenuItem1.Name = "OUTToolStripMenuItem1"
        Me.OUTToolStripMenuItem1.Size = New System.Drawing.Size(112, 26)
        Me.OUTToolStripMenuItem1.Text = "OUT"
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.AddItemToolStripMenuItem.Text = "Add item"
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ReturnToolStripMenuItem.Text = "Return"
        '
        'machine_frame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 677)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "machine_frame"
        Me.Text = "Scan_Frame"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btn_machine As ToolStripMenuItem
    Friend WithEvents PARTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPartcodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddMoldToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents AddItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnToolStripMenuItem As ToolStripMenuItem
End Class

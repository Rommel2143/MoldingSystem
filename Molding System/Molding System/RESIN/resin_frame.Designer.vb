<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resin_frame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(resin_frame))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterlistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PARTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPartcodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMoldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.userstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateVersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuggestToImproveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1165, 593)
        Me.Panel1.TabIndex = 14
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterlistToolStripMenuItem, Me.userstrip})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1165, 53)
        Me.MenuStrip1.TabIndex = 15
        '
        'MasterlistToolStripMenuItem
        '
        Me.MasterlistToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PARTSToolStripMenuItem, Me.FGToolStripMenuItem, Me.AddPartcodeToolStripMenuItem, Me.AddMoldToolStripMenuItem})
        Me.MasterlistToolStripMenuItem.Image = CType(resources.GetObject("MasterlistToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MasterlistToolStripMenuItem.Name = "MasterlistToolStripMenuItem"
        Me.MasterlistToolStripMenuItem.Size = New System.Drawing.Size(164, 49)
        Me.MasterlistToolStripMenuItem.Text = "Resin Monitoring"
        '
        'PARTSToolStripMenuItem
        '
        Me.PARTSToolStripMenuItem.Image = CType(resources.GetObject("PARTSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PARTSToolStripMenuItem.Name = "PARTSToolStripMenuItem"
        Me.PARTSToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PARTSToolStripMenuItem.Text = "Recieving"
        '
        'FGToolStripMenuItem
        '
        Me.FGToolStripMenuItem.Image = CType(resources.GetObject("FGToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FGToolStripMenuItem.Name = "FGToolStripMenuItem"
        Me.FGToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FGToolStripMenuItem.Text = "Daily Output"
        '
        'AddPartcodeToolStripMenuItem
        '
        Me.AddPartcodeToolStripMenuItem.Image = CType(resources.GetObject("AddPartcodeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddPartcodeToolStripMenuItem.Name = "AddPartcodeToolStripMenuItem"
        Me.AddPartcodeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddPartcodeToolStripMenuItem.Text = "Add Partcode"
        '
        'AddMoldToolStripMenuItem
        '
        Me.AddMoldToolStripMenuItem.Image = CType(resources.GetObject("AddMoldToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddMoldToolStripMenuItem.Name = "AddMoldToolStripMenuItem"
        Me.AddMoldToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddMoldToolStripMenuItem.Text = "Add Mold"
        '
        'userstrip
        '
        Me.userstrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.userstrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.MinimizeToolStripMenuItem, Me.ExitToolStripMenuItem, Me.UpdateVersionToolStripMenuItem, Me.SuggestToImproveToolStripMenuItem})
        Me.userstrip.Image = CType(resources.GetObject("userstrip.Image"), System.Drawing.Image)
        Me.userstrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.userstrip.Name = "userstrip"
        Me.userstrip.Size = New System.Drawing.Size(72, 49)
        Me.userstrip.Text = "User"
        Me.userstrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.userstrip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Image = CType(resources.GetObject("MinimizeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.MinimizeToolStripMenuItem.Text = "Minimize"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'UpdateVersionToolStripMenuItem
        '
        Me.UpdateVersionToolStripMenuItem.Image = CType(resources.GetObject("UpdateVersionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateVersionToolStripMenuItem.Name = "UpdateVersionToolStripMenuItem"
        Me.UpdateVersionToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.UpdateVersionToolStripMenuItem.Text = "Update Version"
        '
        'SuggestToImproveToolStripMenuItem
        '
        Me.SuggestToImproveToolStripMenuItem.Image = CType(resources.GetObject("SuggestToImproveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SuggestToImproveToolStripMenuItem.Name = "SuggestToImproveToolStripMenuItem"
        Me.SuggestToImproveToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.SuggestToImproveToolStripMenuItem.Text = "Suggest to improve"
        '
        'resin_frame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 646)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "resin_frame"
        Me.Text = "resin_frame"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterlistToolStripMenuItem As ToolStripMenuItem
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
End Class

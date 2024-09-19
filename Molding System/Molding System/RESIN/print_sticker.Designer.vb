<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class print_sticker
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
        Me.tabcontrol1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.tab_virgin = New System.Windows.Forms.TabPage()
        Me.panel_virgin = New Guna.UI2.WinForms.Guna2Panel()
        Me.tab_recycle = New System.Windows.Forms.TabPage()
        Me.panel_recycle = New Guna.UI2.WinForms.Guna2Panel()
        Me.tab_mixed = New System.Windows.Forms.TabPage()
        Me.panel_mixed = New System.Windows.Forms.Panel()
        Me.tabcontrol1.SuspendLayout()
        Me.tab_virgin.SuspendLayout()
        Me.tab_recycle.SuspendLayout()
        Me.tab_mixed.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabcontrol1
        '
        Me.tabcontrol1.Controls.Add(Me.tab_virgin)
        Me.tabcontrol1.Controls.Add(Me.tab_recycle)
        Me.tabcontrol1.Controls.Add(Me.tab_mixed)
        Me.tabcontrol1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrol1.ItemSize = New System.Drawing.Size(180, 40)
        Me.tabcontrol1.Location = New System.Drawing.Point(0, 0)
        Me.tabcontrol1.Name = "tabcontrol1"
        Me.tabcontrol1.SelectedIndex = 0
        Me.tabcontrol1.Size = New System.Drawing.Size(1444, 836)
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
        Me.tabcontrol1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.tabcontrol1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabcontrol1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.tabcontrol1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tabcontrol1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.tabcontrol1.TabIndex = 0
        Me.tabcontrol1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tabcontrol1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'tab_virgin
        '
        Me.tab_virgin.Controls.Add(Me.panel_virgin)
        Me.tab_virgin.Location = New System.Drawing.Point(4, 44)
        Me.tab_virgin.Name = "tab_virgin"
        Me.tab_virgin.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_virgin.Size = New System.Drawing.Size(1436, 788)
        Me.tab_virgin.TabIndex = 0
        Me.tab_virgin.Text = "Virgin"
        Me.tab_virgin.UseVisualStyleBackColor = True
        '
        'panel_virgin
        '
        Me.panel_virgin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_virgin.Location = New System.Drawing.Point(3, 3)
        Me.panel_virgin.Name = "panel_virgin"
        Me.panel_virgin.Size = New System.Drawing.Size(1430, 782)
        Me.panel_virgin.TabIndex = 0
        '
        'tab_recycle
        '
        Me.tab_recycle.Controls.Add(Me.panel_recycle)
        Me.tab_recycle.Location = New System.Drawing.Point(4, 44)
        Me.tab_recycle.Name = "tab_recycle"
        Me.tab_recycle.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_recycle.Size = New System.Drawing.Size(1436, 788)
        Me.tab_recycle.TabIndex = 1
        Me.tab_recycle.Text = "Recycle"
        Me.tab_recycle.UseVisualStyleBackColor = True
        '
        'panel_recycle
        '
        Me.panel_recycle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_recycle.Location = New System.Drawing.Point(3, 3)
        Me.panel_recycle.Name = "panel_recycle"
        Me.panel_recycle.Size = New System.Drawing.Size(1430, 782)
        Me.panel_recycle.TabIndex = 1
        '
        'tab_mixed
        '
        Me.tab_mixed.Controls.Add(Me.panel_mixed)
        Me.tab_mixed.Location = New System.Drawing.Point(4, 44)
        Me.tab_mixed.Name = "tab_mixed"
        Me.tab_mixed.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_mixed.Size = New System.Drawing.Size(1436, 788)
        Me.tab_mixed.TabIndex = 2
        Me.tab_mixed.Text = "Mixed"
        Me.tab_mixed.UseVisualStyleBackColor = True
        '
        'panel_mixed
        '
        Me.panel_mixed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_mixed.Location = New System.Drawing.Point(3, 3)
        Me.panel_mixed.Name = "panel_mixed"
        Me.panel_mixed.Size = New System.Drawing.Size(1430, 782)
        Me.panel_mixed.TabIndex = 0
        '
        'print_sticker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1444, 836)
        Me.Controls.Add(Me.tabcontrol1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "print_sticker"
        Me.Text = "print_sticker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabcontrol1.ResumeLayout(False)
        Me.tab_virgin.ResumeLayout(False)
        Me.tab_recycle.ResumeLayout(False)
        Me.tab_mixed.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabcontrol1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents tab_virgin As TabPage
    Friend WithEvents tab_recycle As TabPage
    Friend WithEvents tab_mixed As TabPage
    Friend WithEvents panel_virgin As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panel_recycle As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panel_mixed As Panel
End Class

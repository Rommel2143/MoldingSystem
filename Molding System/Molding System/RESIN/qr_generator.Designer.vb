<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qr_generator
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
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.textinput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pic1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(33, 413)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "Guna2Button1"
        '
        'textinput
        '
        Me.textinput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textinput.DefaultText = ""
        Me.textinput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textinput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textinput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textinput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textinput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textinput.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textinput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textinput.Location = New System.Drawing.Point(33, 350)
        Me.textinput.Name = "textinput"
        Me.textinput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textinput.PlaceholderText = ""
        Me.textinput.SelectedText = ""
        Me.textinput.Size = New System.Drawing.Size(373, 36)
        Me.textinput.TabIndex = 1
        '
        'pic1
        '
        Me.pic1.ImageRotate = 0!
        Me.pic1.Location = New System.Drawing.Point(33, 109)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(219, 200)
        Me.pic1.TabIndex = 2
        Me.pic1.TabStop = False
        '
        'qr_generator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 626)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.textinput)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Name = "qr_generator"
        Me.Text = "qr_generator"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents textinput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pic1 As Guna.UI2.WinForms.Guna2PictureBox
End Class

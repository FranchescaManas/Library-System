<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginModule
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.backbtn = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.login_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.password_txtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.username_txtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.label1)
        Me.Guna2GroupBox1.Controls.Add(Me.backbtn)
        Me.Guna2GroupBox1.Controls.Add(Me.login_btn)
        Me.Guna2GroupBox1.Controls.Add(Me.password_txtbx)
        Me.Guna2GroupBox1.Controls.Add(Me.username_txtbx)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(460, 228)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Login"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(136, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label1.Location = New System.Drawing.Point(136, 59)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(81, 21)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Username"
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.Color.Transparent
        Me.backbtn.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.backbtn.CheckedState.Parent = Me.backbtn
        Me.backbtn.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.backbtn.HoverState.Parent = Me.backbtn
        Me.backbtn.Image = Global.Project.My.Resources.Resources.icons8_arrow_pointing_left_90
        Me.backbtn.ImageRotate = 0!
        Me.backbtn.ImageSize = New System.Drawing.Size(35, 45)
        Me.backbtn.Location = New System.Drawing.Point(16, 6)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.PressedState.ImageSize = New System.Drawing.Size(45, 55)
        Me.backbtn.PressedState.Parent = Me.backbtn
        Me.backbtn.Size = New System.Drawing.Size(41, 27)
        Me.backbtn.TabIndex = 11
        Me.backbtn.UseTransparentBackground = True
        '
        'login_btn
        '
        Me.login_btn.Animated = True
        Me.login_btn.AutoRoundedCorners = True
        Me.login_btn.BorderRadius = 12
        Me.login_btn.CheckedState.Parent = Me.login_btn
        Me.login_btn.CustomImages.Parent = Me.login_btn
        Me.login_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.login_btn.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.login_btn.ForeColor = System.Drawing.Color.White
        Me.login_btn.HoverState.Parent = Me.login_btn
        Me.login_btn.Location = New System.Drawing.Point(181, 176)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.ShadowDecoration.Parent = Me.login_btn
        Me.login_btn.Size = New System.Drawing.Size(108, 26)
        Me.login_btn.TabIndex = 10
        Me.login_btn.Text = "Login"
        '
        'password_txtbx
        '
        Me.password_txtbx.BorderColor = System.Drawing.Color.Silver
        Me.password_txtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password_txtbx.DefaultText = ""
        Me.password_txtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.password_txtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.password_txtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_txtbx.DisabledState.Parent = Me.password_txtbx
        Me.password_txtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_txtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_txtbx.FocusedState.Parent = Me.password_txtbx
        Me.password_txtbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.password_txtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_txtbx.HoverState.Parent = Me.password_txtbx
        Me.password_txtbx.Location = New System.Drawing.Point(140, 138)
        Me.password_txtbx.Name = "password_txtbx"
        Me.password_txtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txtbx.PlaceholderText = ""
        Me.password_txtbx.SelectedText = ""
        Me.password_txtbx.ShadowDecoration.Parent = Me.password_txtbx
        Me.password_txtbx.Size = New System.Drawing.Size(196, 28)
        Me.password_txtbx.TabIndex = 7
        '
        'username_txtbx
        '
        Me.username_txtbx.BorderColor = System.Drawing.Color.Silver
        Me.username_txtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username_txtbx.DefaultText = ""
        Me.username_txtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.username_txtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.username_txtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username_txtbx.DisabledState.Parent = Me.username_txtbx
        Me.username_txtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username_txtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username_txtbx.FocusedState.Parent = Me.username_txtbx
        Me.username_txtbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.username_txtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username_txtbx.HoverState.Parent = Me.username_txtbx
        Me.username_txtbx.Location = New System.Drawing.Point(140, 83)
        Me.username_txtbx.Name = "username_txtbx"
        Me.username_txtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username_txtbx.PlaceholderText = ""
        Me.username_txtbx.SelectedText = ""
        Me.username_txtbx.ShadowDecoration.Parent = Me.username_txtbx
        Me.username_txtbx.Size = New System.Drawing.Size(196, 28)
        Me.username_txtbx.TabIndex = 6
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.ContainerControl = Me
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 228)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents login_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents password_txtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents username_txtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents backbtn As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class

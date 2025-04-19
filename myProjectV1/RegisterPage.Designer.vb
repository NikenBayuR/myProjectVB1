<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterPage))
        Panel2 = New Panel()
        panelTop = New Panel()
        btnMaximized = New Button()
        btnMinimized = New Button()
        btnClose = New Button()
        panelContent = New Panel()
        CheckBoxShowPass = New CheckBox()
        txtWelcomeBack = New Label()
        txtUsername = New Label()
        LinkRegister = New LinkLabel()
        txtPassword = New Label()
        suUsername = New TextBox()
        suPassword = New TextBox()
        btnRegister = New Button()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        panelTop.SuspendLayout()
        panelContent.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.Controls.Add(panelTop)
        Panel2.Controls.Add(panelContent)
        Panel2.Dock = DockStyle.Fill
        Panel2.ForeColor = Color.Transparent
        Panel2.Location = New Point(396, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(703, 846)
        Panel2.TabIndex = 3
        ' 
        ' panelTop
        ' 
        panelTop.Controls.Add(btnMaximized)
        panelTop.Controls.Add(btnMinimized)
        panelTop.Controls.Add(btnClose)
        panelTop.Dock = DockStyle.Top
        panelTop.Location = New Point(0, 0)
        panelTop.Name = "panelTop"
        panelTop.Size = New Size(703, 50)
        panelTop.TabIndex = 2
        ' 
        ' btnMaximized
        ' 
        btnMaximized.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximized.BackColor = Color.White
        btnMaximized.FlatAppearance.BorderSize = 0
        btnMaximized.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnMaximized.FlatAppearance.MouseOverBackColor = Color.Red
        btnMaximized.FlatStyle = FlatStyle.Flat
        btnMaximized.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMaximized.ForeColor = Color.Brown
        btnMaximized.Location = New Point(614, 2)
        btnMaximized.Name = "btnMaximized"
        btnMaximized.Size = New Size(40, 45)
        btnMaximized.TabIndex = 2
        btnMaximized.Text = "+"
        btnMaximized.UseVisualStyleBackColor = False
        ' 
        ' btnMinimized
        ' 
        btnMinimized.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimized.BackColor = Color.White
        btnMinimized.FlatAppearance.BorderSize = 0
        btnMinimized.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnMinimized.FlatAppearance.MouseOverBackColor = Color.Red
        btnMinimized.FlatStyle = FlatStyle.Flat
        btnMinimized.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMinimized.ForeColor = Color.Brown
        btnMinimized.Location = New Point(568, 2)
        btnMinimized.Name = "btnMinimized"
        btnMinimized.Size = New Size(40, 45)
        btnMinimized.TabIndex = 1
        btnMinimized.Text = "-"
        btnMinimized.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.White
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnClose.FlatAppearance.MouseOverBackColor = Color.Red
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.Brown
        btnClose.Location = New Point(660, 2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(40, 45)
        btnClose.TabIndex = 0
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' panelContent
        ' 
        panelContent.Controls.Add(CheckBoxShowPass)
        panelContent.Controls.Add(txtWelcomeBack)
        panelContent.Controls.Add(txtUsername)
        panelContent.Controls.Add(LinkRegister)
        panelContent.Controls.Add(txtPassword)
        panelContent.Controls.Add(suUsername)
        panelContent.Controls.Add(suPassword)
        panelContent.Controls.Add(btnRegister)
        panelContent.Location = New Point(3, 281)
        panelContent.Name = "panelContent"
        panelContent.Size = New Size(694, 369)
        panelContent.TabIndex = 1
        ' 
        ' CheckBoxShowPass
        ' 
        CheckBoxShowPass.AutoSize = True
        CheckBoxShowPass.BackColor = Color.Transparent
        CheckBoxShowPass.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        CheckBoxShowPass.ForeColor = Color.Sienna
        CheckBoxShowPass.Location = New Point(520, 207)
        CheckBoxShowPass.Name = "CheckBoxShowPass"
        CheckBoxShowPass.Size = New Size(159, 28)
        CheckBoxShowPass.TabIndex = 10
        CheckBoxShowPass.Text = "show password"
        CheckBoxShowPass.UseVisualStyleBackColor = False
        ' 
        ' txtWelcomeBack
        ' 
        txtWelcomeBack.AutoSize = True
        txtWelcomeBack.BackColor = Color.Transparent
        txtWelcomeBack.Font = New Font("Arial Narrow", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtWelcomeBack.ForeColor = Color.Sienna
        txtWelcomeBack.Location = New Point(205, 51)
        txtWelcomeBack.Name = "txtWelcomeBack"
        txtWelcomeBack.Size = New Size(166, 52)
        txtWelcomeBack.TabIndex = 1
        txtWelcomeBack.Text = "Register"
        ' 
        ' txtUsername
        ' 
        txtUsername.AutoSize = True
        txtUsername.BackColor = Color.Transparent
        txtUsername.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        txtUsername.ForeColor = Color.Sienna
        txtUsername.Location = New Point(88, 151)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(88, 24)
        txtUsername.TabIndex = 4
        txtUsername.Text = "Username"
        ' 
        ' LinkRegister
        ' 
        LinkRegister.AutoSize = True
        LinkRegister.BackColor = Color.Transparent
        LinkRegister.Font = New Font("Arial Narrow", 9F, FontStyle.Bold)
        LinkRegister.LinkBehavior = LinkBehavior.HoverUnderline
        LinkRegister.LinkColor = Color.Sienna
        LinkRegister.Location = New Point(335, 280)
        LinkRegister.Name = "LinkRegister"
        LinkRegister.Size = New Size(193, 22)
        LinkRegister.TabIndex = 8
        LinkRegister.TabStop = True
        LinkRegister.Text = "Already have an Account?"
        ' 
        ' txtPassword
        ' 
        txtPassword.AutoSize = True
        txtPassword.BackColor = Color.Transparent
        txtPassword.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        txtPassword.ForeColor = Color.Sienna
        txtPassword.Location = New Point(88, 207)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(87, 24)
        txtPassword.TabIndex = 5
        txtPassword.Text = "Password"
        ' 
        ' suUsername
        ' 
        suUsername.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        suUsername.ForeColor = Color.Sienna
        suUsername.Location = New Point(205, 147)
        suUsername.Name = "suUsername"
        suUsername.Size = New Size(298, 30)
        suUsername.TabIndex = 2
        ' 
        ' suPassword
        ' 
        suPassword.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        suPassword.ForeColor = Color.Sienna
        suPassword.Location = New Point(205, 203)
        suPassword.Name = "suPassword"
        suPassword.PasswordChar = "*"c
        suPassword.Size = New Size(298, 30)
        suPassword.TabIndex = 3
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.White
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        btnRegister.ForeColor = Color.Sienna
        btnRegister.Location = New Point(205, 266)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(124, 36)
        btnRegister.TabIndex = 7
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Brown
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(396, 846)
        Panel1.TabIndex = 2
        ' 
        ' RegisterPage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1099, 846)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RegisterPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegisterPage"
        Panel2.ResumeLayout(False)
        panelTop.ResumeLayout(False)
        panelContent.ResumeLayout(False)
        panelContent.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtPassword As Label
    Friend WithEvents txtUsername As Label
    Friend WithEvents suPassword As TextBox
    Friend WithEvents suUsername As TextBox
    Friend WithEvents txtWelcomeBack As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkRegister As LinkLabel
    Friend WithEvents CheckBoxShowPass As CheckBox
    Friend WithEvents panelContent As Panel
    Friend WithEvents panelTop As Panel
    Friend WithEvents btnMaximized As Button
    Friend WithEvents btnMinimized As Button
End Class

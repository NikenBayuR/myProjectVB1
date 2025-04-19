<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPage))
        Panel1 = New Panel()
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
        TextBoxUsername = New TextBox()
        TextBoxPassword = New TextBox()
        btnLogin = New Button()
        Panel2.SuspendLayout()
        panelTop.SuspendLayout()
        panelContent.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Brown
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(396, 846)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.Controls.Add(panelTop)
        Panel2.Controls.Add(panelContent)
        Panel2.Dock = DockStyle.Fill
        Panel2.ForeColor = Color.Transparent
        Panel2.Location = New Point(396, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(703, 846)
        Panel2.TabIndex = 1
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
        panelTop.TabIndex = 0
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
        panelContent.BackColor = Color.Transparent
        panelContent.Controls.Add(CheckBoxShowPass)
        panelContent.Controls.Add(txtWelcomeBack)
        panelContent.Controls.Add(txtUsername)
        panelContent.Controls.Add(LinkRegister)
        panelContent.Controls.Add(txtPassword)
        panelContent.Controls.Add(TextBoxUsername)
        panelContent.Controls.Add(TextBoxPassword)
        panelContent.Controls.Add(btnLogin)
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
        CheckBoxShowPass.Location = New Point(525, 203)
        CheckBoxShowPass.Name = "CheckBoxShowPass"
        CheckBoxShowPass.Size = New Size(159, 28)
        CheckBoxShowPass.TabIndex = 9
        CheckBoxShowPass.Text = "show password"
        CheckBoxShowPass.UseVisualStyleBackColor = False
        ' 
        ' txtWelcomeBack
        ' 
        txtWelcomeBack.AutoSize = True
        txtWelcomeBack.BackColor = Color.Transparent
        txtWelcomeBack.Font = New Font("Arial Narrow", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtWelcomeBack.ForeColor = Color.Sienna
        txtWelcomeBack.Location = New Point(210, 47)
        txtWelcomeBack.Name = "txtWelcomeBack"
        txtWelcomeBack.Size = New Size(298, 52)
        txtWelcomeBack.TabIndex = 1
        txtWelcomeBack.Text = "Welcome Back !"
        ' 
        ' txtUsername
        ' 
        txtUsername.AutoSize = True
        txtUsername.BackColor = Color.Transparent
        txtUsername.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        txtUsername.ForeColor = Color.Sienna
        txtUsername.Location = New Point(93, 147)
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
        LinkRegister.Location = New Point(340, 276)
        LinkRegister.Name = "LinkRegister"
        LinkRegister.Size = New Size(172, 22)
        LinkRegister.TabIndex = 8
        LinkRegister.TabStop = True
        LinkRegister.Text = "Create a new Account?"
        ' 
        ' txtPassword
        ' 
        txtPassword.AutoSize = True
        txtPassword.BackColor = Color.Transparent
        txtPassword.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        txtPassword.ForeColor = Color.Sienna
        txtPassword.Location = New Point(93, 203)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(87, 24)
        txtPassword.TabIndex = 5
        txtPassword.Text = "Password"
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxUsername.ForeColor = Color.Sienna
        TextBoxUsername.Location = New Point(210, 143)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(298, 30)
        TextBoxUsername.TabIndex = 2
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxPassword.ForeColor = Color.Sienna
        TextBoxPassword.Location = New Point(210, 199)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PasswordChar = "*"c
        TextBoxPassword.Size = New Size(298, 30)
        TextBoxPassword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.WhiteSmoke
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        btnLogin.ForeColor = Color.Sienna
        btnLogin.Location = New Point(210, 262)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(124, 36)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' LoginPage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1099, 846)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginPage"
        Panel2.ResumeLayout(False)
        panelTop.ResumeLayout(False)
        panelContent.ResumeLayout(False)
        panelContent.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents panelTop As Panel
    Friend WithEvents panelContent As Panel
    Friend WithEvents CheckBoxShowPass As CheckBox
    Friend WithEvents txtWelcomeBack As Label
    Friend WithEvents txtUsername As Label
    Friend WithEvents LinkRegister As LinkLabel
    Friend WithEvents txtPassword As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnMaximized As Button
    Friend WithEvents btnMinimized As Button

End Class

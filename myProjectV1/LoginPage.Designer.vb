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
        CheckBoxShowPass = New CheckBox()
        LinkRegister = New LinkLabel()
        btnLogin = New Button()
        txtPassword = New Label()
        txtUsername = New Label()
        TextBoxPassword = New TextBox()
        TextBoxUsername = New TextBox()
        txtWelcomeBack = New Label()
        btnClose = New Button()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Brown
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
        Panel2.Controls.Add(CheckBoxShowPass)
        Panel2.Controls.Add(LinkRegister)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(txtUsername)
        Panel2.Controls.Add(TextBoxPassword)
        Panel2.Controls.Add(TextBoxUsername)
        Panel2.Controls.Add(txtWelcomeBack)
        Panel2.Controls.Add(btnClose)
        Panel2.ForeColor = Color.Transparent
        Panel2.Location = New Point(390, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(709, 846)
        Panel2.TabIndex = 1
        ' 
        ' CheckBoxShowPass
        ' 
        CheckBoxShowPass.AutoSize = True
        CheckBoxShowPass.BackColor = Color.Transparent
        CheckBoxShowPass.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        CheckBoxShowPass.ForeColor = Color.Sienna
        CheckBoxShowPass.Location = New Point(526, 485)
        CheckBoxShowPass.Name = "CheckBoxShowPass"
        CheckBoxShowPass.Size = New Size(159, 28)
        CheckBoxShowPass.TabIndex = 9
        CheckBoxShowPass.Text = "show password"
        CheckBoxShowPass.UseVisualStyleBackColor = False
        ' 
        ' LinkRegister
        ' 
        LinkRegister.AutoSize = True
        LinkRegister.BackColor = Color.Transparent
        LinkRegister.Font = New Font("Arial Narrow", 9F, FontStyle.Bold)
        LinkRegister.LinkBehavior = LinkBehavior.HoverUnderline
        LinkRegister.LinkColor = Color.Sienna
        LinkRegister.Location = New Point(341, 558)
        LinkRegister.Name = "LinkRegister"
        LinkRegister.Size = New Size(172, 22)
        LinkRegister.TabIndex = 8
        LinkRegister.TabStop = True
        LinkRegister.Text = "Create a new Account?"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.WhiteSmoke
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        btnLogin.ForeColor = Color.Sienna
        btnLogin.Location = New Point(211, 544)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(124, 36)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.AutoSize = True
        txtPassword.BackColor = Color.Transparent
        txtPassword.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        txtPassword.ForeColor = Color.Sienna
        txtPassword.Location = New Point(94, 485)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(87, 24)
        txtPassword.TabIndex = 5
        txtPassword.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.AutoSize = True
        txtUsername.BackColor = Color.Transparent
        txtUsername.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        txtUsername.ForeColor = Color.Sienna
        txtUsername.Location = New Point(94, 429)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(88, 24)
        txtUsername.TabIndex = 4
        txtUsername.Text = "Username"
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxPassword.ForeColor = Color.Sienna
        TextBoxPassword.Location = New Point(211, 481)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PasswordChar = "*"c
        TextBoxPassword.Size = New Size(298, 30)
        TextBoxPassword.TabIndex = 3
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxUsername.ForeColor = Color.Sienna
        TextBoxUsername.Location = New Point(211, 425)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(298, 30)
        TextBoxUsername.TabIndex = 2
        ' 
        ' txtWelcomeBack
        ' 
        txtWelcomeBack.AutoSize = True
        txtWelcomeBack.BackColor = Color.Transparent
        txtWelcomeBack.Font = New Font("Arial Narrow", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtWelcomeBack.ForeColor = Color.Sienna
        txtWelcomeBack.Location = New Point(211, 329)
        txtWelcomeBack.Name = "txtWelcomeBack"
        txtWelcomeBack.Size = New Size(298, 52)
        txtWelcomeBack.TabIndex = 1
        txtWelcomeBack.Text = "Welcome Back !"
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.White
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnClose.FlatAppearance.MouseOverBackColor = Color.Red
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.Brown
        btnClose.Location = New Point(636, 1)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(72, 34)
        btnClose.TabIndex = 0
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
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
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents txtWelcomeBack As Label
    Friend WithEvents txtPassword As Label
    Friend WithEvents txtUsername As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents LinkRegister As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents CheckBoxShowPass As CheckBox

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LandingPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LandingPage))
        navbar = New Panel()
        txtWelcome = New Label()
        btnLogOut = New Button()
        dash_username = New Label()
        btnClose = New Button()
        BtnTampilkan = New Button()
        TextBoxNpm = New TextBox()
        LabelNpm = New Label()
        TextBoxKelas = New TextBox()
        LabelKelas = New Label()
        TextBoxNama = New TextBox()
        LabelNama = New Label()
        txtHire = New Label()
        LabelJenisKelamin = New Label()
        TextBoxJenisKelamin = New TextBox()
        LabelAgama = New Label()
        TextBoxAgama = New TextBox()
        navbar.SuspendLayout()
        SuspendLayout()
        ' 
        ' navbar
        ' 
        navbar.BackColor = Color.Brown
        navbar.Controls.Add(txtWelcome)
        navbar.Controls.Add(btnLogOut)
        navbar.Controls.Add(dash_username)
        navbar.Controls.Add(btnClose)
        navbar.Location = New Point(0, -1)
        navbar.Name = "navbar"
        navbar.Size = New Size(1100, 83)
        navbar.TabIndex = 0
        ' 
        ' txtWelcome
        ' 
        txtWelcome.AutoSize = True
        txtWelcome.BackColor = Color.Transparent
        txtWelcome.Font = New Font("Britannic Bold", 17F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtWelcome.ForeColor = Color.Silver
        txtWelcome.Location = New Point(0, 25)
        txtWelcome.Name = "txtWelcome"
        txtWelcome.Size = New Size(150, 37)
        txtWelcome.TabIndex = 3
        txtWelcome.Text = "Welcome"
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.Transparent
        btnLogOut.FlatAppearance.BorderSize = 0
        btnLogOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnLogOut.FlatAppearance.MouseOverBackColor = Color.Red
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogOut.ForeColor = Color.Silver
        btnLogOut.Location = New Point(984, 36)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(107, 40)
        btnLogOut.TabIndex = 2
        btnLogOut.Text = "LogOut"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' dash_username
        ' 
        dash_username.AutoSize = True
        dash_username.BackColor = Color.Transparent
        dash_username.Font = New Font("Britannic Bold", 17F)
        dash_username.ForeColor = Color.Silver
        dash_username.Location = New Point(144, 25)
        dash_username.Name = "dash_username"
        dash_username.Size = New Size(0, 37)
        dash_username.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Transparent
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnClose.FlatAppearance.MouseOverBackColor = Color.Red
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.Silver
        btnClose.Location = New Point(1064, 0)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(32, 30)
        btnClose.TabIndex = 1
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' BtnTampilkan
        ' 
        BtnTampilkan.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        BtnTampilkan.ForeColor = Color.Sienna
        BtnTampilkan.Location = New Point(514, 171)
        BtnTampilkan.Name = "BtnTampilkan"
        BtnTampilkan.Size = New Size(112, 34)
        BtnTampilkan.TabIndex = 7
        BtnTampilkan.Text = "Print"
        BtnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' TextBoxNpm
        ' 
        TextBoxNpm.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxNpm.ForeColor = Color.Sienna
        TextBoxNpm.Location = New Point(144, 297)
        TextBoxNpm.Name = "TextBoxNpm"
        TextBoxNpm.Size = New Size(287, 30)
        TextBoxNpm.TabIndex = 5
        ' 
        ' LabelNpm
        ' 
        LabelNpm.AutoSize = True
        LabelNpm.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelNpm.ForeColor = Color.Sienna
        LabelNpm.Location = New Point(17, 297)
        LabelNpm.Name = "LabelNpm"
        LabelNpm.Size = New Size(46, 24)
        LabelNpm.TabIndex = 6
        LabelNpm.Text = "Npm"
        ' 
        ' TextBoxKelas
        ' 
        TextBoxKelas.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxKelas.ForeColor = Color.Sienna
        TextBoxKelas.Location = New Point(144, 236)
        TextBoxKelas.Name = "TextBoxKelas"
        TextBoxKelas.Size = New Size(287, 30)
        TextBoxKelas.TabIndex = 3
        ' 
        ' LabelKelas
        ' 
        LabelKelas.AutoSize = True
        LabelKelas.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelKelas.ForeColor = Color.Sienna
        LabelKelas.Location = New Point(17, 236)
        LabelKelas.Name = "LabelKelas"
        LabelKelas.Size = New Size(53, 24)
        LabelKelas.TabIndex = 4
        LabelKelas.Text = "Kelas"
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxNama.ForeColor = Color.Sienna
        TextBoxNama.Location = New Point(144, 175)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.Size = New Size(287, 30)
        TextBoxNama.TabIndex = 1
        ' 
        ' LabelNama
        ' 
        LabelNama.AutoSize = True
        LabelNama.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelNama.ForeColor = Color.Sienna
        LabelNama.Location = New Point(17, 175)
        LabelNama.Name = "LabelNama"
        LabelNama.Size = New Size(54, 24)
        LabelNama.TabIndex = 2
        LabelNama.Text = "Nama"
        ' 
        ' txtHire
        ' 
        txtHire.AutoSize = True
        txtHire.Font = New Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtHire.ForeColor = Color.Sienna
        txtHire.Location = New Point(144, 127)
        txtHire.Name = "txtHire"
        txtHire.Size = New Size(265, 33)
        txtHire.TabIndex = 8
        txtHire.Text = "New Employee biodata"
        ' 
        ' LabelJenisKelamin
        ' 
        LabelJenisKelamin.AutoSize = True
        LabelJenisKelamin.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelJenisKelamin.ForeColor = Color.Sienna
        LabelJenisKelamin.Location = New Point(17, 416)
        LabelJenisKelamin.Name = "LabelJenisKelamin"
        LabelJenisKelamin.Size = New Size(118, 24)
        LabelJenisKelamin.TabIndex = 12
        LabelJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' TextBoxJenisKelamin
        ' 
        TextBoxJenisKelamin.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxJenisKelamin.ForeColor = Color.Sienna
        TextBoxJenisKelamin.Location = New Point(144, 416)
        TextBoxJenisKelamin.Name = "TextBoxJenisKelamin"
        TextBoxJenisKelamin.Size = New Size(287, 30)
        TextBoxJenisKelamin.TabIndex = 11
        ' 
        ' LabelAgama
        ' 
        LabelAgama.AutoSize = True
        LabelAgama.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelAgama.ForeColor = Color.Sienna
        LabelAgama.Location = New Point(17, 355)
        LabelAgama.Name = "LabelAgama"
        LabelAgama.Size = New Size(63, 24)
        LabelAgama.TabIndex = 10
        LabelAgama.Text = "Agama"
        ' 
        ' TextBoxAgama
        ' 
        TextBoxAgama.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxAgama.ForeColor = Color.Sienna
        TextBoxAgama.Location = New Point(144, 355)
        TextBoxAgama.Name = "TextBoxAgama"
        TextBoxAgama.Size = New Size(287, 30)
        TextBoxAgama.TabIndex = 9
        ' 
        ' LandingPage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1099, 846)
        Controls.Add(LabelJenisKelamin)
        Controls.Add(TextBoxJenisKelamin)
        Controls.Add(LabelAgama)
        Controls.Add(TextBoxAgama)
        Controls.Add(txtHire)
        Controls.Add(BtnTampilkan)
        Controls.Add(LabelNpm)
        Controls.Add(TextBoxNpm)
        Controls.Add(LabelKelas)
        Controls.Add(TextBoxKelas)
        Controls.Add(LabelNama)
        Controls.Add(TextBoxNama)
        Controls.Add(navbar)
        FormBorderStyle = FormBorderStyle.None
        Name = "LandingPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LandingPage"
        navbar.ResumeLayout(False)
        navbar.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents navbar As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents dash_username As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents txtWelcome As Label
    Friend WithEvents BtnTampilkan As Button
    Friend WithEvents TextBoxNpm As TextBox
    Friend WithEvents LabelNpm As Label
    Friend WithEvents TextBoxKelas As TextBox
    Friend WithEvents LabelKelas As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents LabelNama As Label
    Friend WithEvents txtHire As Label
    Friend WithEvents LabelJenisKelamin As Label
    Friend WithEvents TextBoxJenisKelamin As TextBox
    Friend WithEvents LabelAgama As Label
    Friend WithEvents TextBoxAgama As TextBox
End Class

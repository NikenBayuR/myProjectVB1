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
        panelNavbar = New Panel()
        btnMaximized = New Button()
        btnMinimized = New Button()
        txtWelcome = New Label()
        btnLogOut = New Button()
        btnClose = New Button()
        dash_username = New Label()
        panelBackground = New Panel()
        panelContent = New Panel()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        panelNavbar.SuspendLayout()
        panelBackground.SuspendLayout()
        panelContent.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelNavbar
        ' 
        panelNavbar.BackColor = Color.Brown
        panelNavbar.Controls.Add(btnMaximized)
        panelNavbar.Controls.Add(btnMinimized)
        panelNavbar.Controls.Add(txtWelcome)
        panelNavbar.Controls.Add(btnLogOut)
        panelNavbar.Controls.Add(btnClose)
        panelNavbar.Controls.Add(dash_username)
        panelNavbar.Dock = DockStyle.Top
        panelNavbar.Location = New Point(0, 0)
        panelNavbar.Name = "panelNavbar"
        panelNavbar.Size = New Size(1099, 83)
        panelNavbar.TabIndex = 0
        ' 
        ' btnMaximized
        ' 
        btnMaximized.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximized.BackColor = Color.Transparent
        btnMaximized.FlatAppearance.BorderSize = 0
        btnMaximized.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnMaximized.FlatAppearance.MouseOverBackColor = Color.Red
        btnMaximized.FlatStyle = FlatStyle.Flat
        btnMaximized.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMaximized.ForeColor = Color.Silver
        btnMaximized.Location = New Point(1022, 4)
        btnMaximized.Name = "btnMaximized"
        btnMaximized.Size = New Size(32, 30)
        btnMaximized.TabIndex = 5
        btnMaximized.Text = "+"
        btnMaximized.UseVisualStyleBackColor = False
        ' 
        ' btnMinimized
        ' 
        btnMinimized.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimized.BackColor = Color.Transparent
        btnMinimized.FlatAppearance.BorderSize = 0
        btnMinimized.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnMinimized.FlatAppearance.MouseOverBackColor = Color.Red
        btnMinimized.FlatStyle = FlatStyle.Flat
        btnMinimized.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMinimized.ForeColor = Color.Silver
        btnMinimized.Location = New Point(984, 4)
        btnMinimized.Name = "btnMinimized"
        btnMinimized.Size = New Size(32, 30)
        btnMinimized.TabIndex = 4
        btnMinimized.Text = "-"
        btnMinimized.UseVisualStyleBackColor = False
        ' 
        ' txtWelcome
        ' 
        txtWelcome.AutoSize = True
        txtWelcome.BackColor = Color.Transparent
        txtWelcome.Font = New Font("Britannic Bold", 17F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtWelcome.ForeColor = Color.Silver
        txtWelcome.Location = New Point(5, 29)
        txtWelcome.Name = "txtWelcome"
        txtWelcome.Size = New Size(150, 37)
        txtWelcome.TabIndex = 3
        txtWelcome.Text = "Welcome"
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogOut.BackColor = Color.Transparent
        btnLogOut.FlatAppearance.BorderSize = 0
        btnLogOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnLogOut.FlatAppearance.MouseOverBackColor = Color.Red
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogOut.ForeColor = Color.Silver
        btnLogOut.Location = New Point(989, 40)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(107, 40)
        btnLogOut.TabIndex = 2
        btnLogOut.Text = "LogOut"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.Transparent
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnClose.FlatAppearance.MouseOverBackColor = Color.Red
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.Silver
        btnClose.Location = New Point(1060, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(32, 30)
        btnClose.TabIndex = 1
        btnClose.Text = "x"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' dash_username
        ' 
        dash_username.AutoSize = True
        dash_username.BackColor = Color.Transparent
        dash_username.Font = New Font("Britannic Bold", 17F)
        dash_username.ForeColor = Color.Silver
        dash_username.Location = New Point(149, 29)
        dash_username.Name = "dash_username"
        dash_username.Size = New Size(101, 37)
        dash_username.TabIndex = 0
        dash_username.Text = "Niken"
        ' 
        ' panelBackground
        ' 
        panelBackground.BackColor = Color.Transparent
        panelBackground.BackgroundImage = CType(resources.GetObject("panelBackground.BackgroundImage"), Image)
        panelBackground.BackgroundImageLayout = ImageLayout.Center
        panelBackground.Controls.Add(panelContent)
        panelBackground.Dock = DockStyle.Fill
        panelBackground.Location = New Point(0, 83)
        panelBackground.Name = "panelBackground"
        panelBackground.Size = New Size(1099, 763)
        panelBackground.TabIndex = 0
        ' 
        ' panelContent
        ' 
        panelContent.BackColor = Color.Transparent
        panelContent.Controls.Add(Label5)
        panelContent.Controls.Add(Label4)
        panelContent.Controls.Add(Label3)
        panelContent.Controls.Add(Label2)
        panelContent.Controls.Add(Label1)
        panelContent.Controls.Add(DataGridView1)
        panelContent.Dock = DockStyle.Fill
        panelContent.Location = New Point(0, 0)
        panelContent.Name = "panelContent"
        panelContent.Size = New Size(1099, 763)
        panelContent.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Chartreuse
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.Location = New Point(0, 525)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1099, 238)
        DataGridView1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 25)
        Label2.TabIndex = 2
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 25)
        Label3.TabIndex = 3
        Label3.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 155)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 25)
        Label4.TabIndex = 4
        Label4.Text = "Label4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 195)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 25)
        Label5.TabIndex = 5
        Label5.Text = "Label5"
        ' 
        ' LandingPage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1099, 846)
        Controls.Add(panelBackground)
        Controls.Add(panelNavbar)
        FormBorderStyle = FormBorderStyle.None
        Name = "LandingPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LandingPage"
        panelNavbar.ResumeLayout(False)
        panelNavbar.PerformLayout()
        panelBackground.ResumeLayout(False)
        panelContent.ResumeLayout(False)
        panelContent.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents panelNavbar As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents dash_username As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents txtWelcome As Label
    Friend WithEvents btnMaximized As Button
    Friend WithEvents btnMinimized As Button
    Friend WithEvents panelBackground As Panel
    Friend WithEvents panelContent As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class

Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices

Public Class LandingPage
    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'displayUser()

    End Sub

    'Sub displayUser()
    'Dim user As String = LoginPage.TextBoxUsername.Text
    'user = user.Substring(0, 1).ToUpper & user.Substring(1)
    'dash_username.Text = user
    'End Sub

    'menentukan ukuran poisisi datagridview di bawah logo!
    Private Sub LandingPage_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' Asumsikan tinggi gambar/logo adalah 150px, dan posisi vertikal tengah
        Dim tinggiLogo As Integer = 150
        Dim posisiYLogo As Integer = (Me.Height \ 2) - (tinggiLogo \ 2)
        Dim posisiYSetelahLogo As Integer = posisiYLogo + tinggiLogo + 10 ' kasih jarak 10px

        ' Atur posisi DataGridView agar berada tepat di bawah gambar/logo Zxy.Co
        DataGridView1.Top = posisiYSetelahLogo
        DataGridView1.Left = 20
        DataGridView1.Width = panelContent.Width - 40
        DataGridView1.Height = panelContent.Height - posisiYSetelahLogo - 20 ' kasih jarak dari bawah

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.ExitThread()
    End Sub

    Private Sub btnMaximized_Click(sender As Object, e As EventArgs) Handles btnMaximized.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        LoginPage.WindowState = Me.WindowState
        LoginPage.Show()
        LoginPage.TextBoxUsername.Clear()
        LoginPage.TextBoxPassword.Clear()
        Me.Close()
    End Sub



End Class
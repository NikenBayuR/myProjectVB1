
Imports System.Data.OleDb
Imports System.IO

Public Class LandingPage
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PE-D\Documents\CURD.accdb;")
    Dim dr As OleDbDataReader

    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        displayUser()
        Try
            conn.Open()
            LabelConnection.Text = "Connected"
            LabelConnection.ForeColor = Color.Lime
        Catch ex As Exception
            LabelConnection.Text = "DisConnected"
            LabelConnection.ForeColor = Color.Red
        End Try
        conn.Close()
        loadingDataGridView()


    End Sub

    Sub displayUser()
        Dim user As String = LoginPage.TextBoxUsername.Text
        user = user.Substring(0, 1).ToUpper & user.Substring(1)
        dash_username.Text = user
    End Sub

    'menentukan ukuran poisisi datagridview di bawah logo!
    Private Sub LandingPage_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim marginKiriKanan As Integer = 40
        Dim tinggiLogo As Integer = 150 ' Perkirakan tinggi logo dalam background image

        ' Hitung posisi Y di bawah logo (asumsinya gambar berada di tengah panel)
        Dim posisiYSetelahLogo As Integer = panelBackground.Top + (panelBackground.Height \ 2) + (tinggiLogo \ 2) + 20

        ' Atur DataGridView
        DataGridView1.Top = posisiYSetelahLogo
        DataGridView1.Left = marginKiriKanan
        DataGridView1.Width = panelContent.Width - (2 * marginKiriKanan)
        DataGridView1.Height = panelContent.Height - posisiYSetelahLogo - 30
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

    Sub loadingDataGridView()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDbCommand("Select * from CURD ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("NIK"), dr.Item("NAMA"), dr.Item("TEMPAT LAHIR"), dr.Item("TANGGAL LAHIR"), dr.Item("JENIS KELAMIN"), dr.Item("ALAMAT"),
                                       dr.Item("RT / RW"), dr.Item("KELURAHAN"), dr.Item("AGAMA"), dr.Item("STATUS KAWIN"), dr.Item("PEKERJAAN"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

End Class
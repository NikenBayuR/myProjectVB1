Imports System.Data.OleDb
Imports System.Data

Public Class LoginPage
    Dim connect As New OleDbConnection
    Dim command As OleDbCommand
    Dim sql As String = Nothing

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterContent()
        connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PE-D\Documents\dataBaseVbNetV1.accdb;"
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

    Private Sub LoginPage_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CenterContent()
    End Sub
    Private Sub CenterContent()
        panelContent.Left = (Panel2.ClientSize.Width - panelContent.Width) \ 2
        panelContent.Top = (Panel2.ClientSize.Height - panelContent.Height) \ 2
    End Sub
    Private Sub LinkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRegister.LinkClicked
        RegisterPage.Show()
        Me.Hide()
    End Sub

    'HANDLE FORM LOGIN.
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        'handle alert ketika form username atau password tidak terisi 
        If TextBoxUsername.Text = Nothing Or TextBoxPassword.Text = Nothing Then
            MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'handle ketika username atau password benar
            sql = "SELECT * FROM admin WHERE username = ? and password = ?"

            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBoxUsername.Text
            command.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TextBoxPassword.Text
            'handel allert
            Dim check = Convert.ToInt32(command.ExecuteScalar())
            If check > 0 Then
                'handel alert ketika pasword diisi benar dan salah 
                'then Sucessfully Login
                MessageBox.Show("Sucessfuly Login", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LandingPage.Show()
                Me.Hide()
            Else
                'Then wrong username or password
                MessageBox.Show("Wrong Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    'HANDLE SHOW PASSWORD.
    Private Sub CheckBoxShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPass.CheckedChanged
        If CheckBoxShowPass.Checked = True Then
            TextBoxPassword.PasswordChar = ""
        Else
            TextBoxPassword.PasswordChar = "*"
        End If
    End Sub


End Class
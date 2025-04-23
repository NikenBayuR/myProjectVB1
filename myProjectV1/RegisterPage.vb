Imports System.Data.OleDb
Imports System.Data
Public Class RegisterPage

    'HANDLE CONNECTION TO DATABASE
    Dim connect As New OleDbConnection
    Dim command As OleDbCommand
    Dim sql As String = Nothing


    Private Sub RegisterPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        CenterContent()
        connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PE-D\Documents\dataBaseVbNetV1.accdb;"
    End Sub



    'HANDLE BUTTONS MINIMIZED MAXIMIZED
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



    'HANDLE DRAG FORM
    Private Sub RegisterPage_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CenterContent()
    End Sub
    Private Sub CenterContent()
        panelContent.Left = (Panel2.ClientSize.Width - panelContent.Width) \ 2
        panelContent.Top = (Panel2.ClientSize.Height - panelContent.Height) \ 2
    End Sub


    'HANDLE BUTTON BACK TO LOGIN
    Private Sub LinkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRegister.LinkClicked
        LoginPage.WindowState = Me.WindowState
        LoginPage.Show()
        Me.Hide()
    End Sub


    'HANDLE BUTTON REGISTER
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        If suUsername.Text = Nothing Or suPassword.Text = Nothing Then
            MessageBox.Show("please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim checkData As String = "SELECT * FROM admin WHERE username = '" & suUsername.Text & "'"

            command = New OleDbCommand(checkData, connect)
            Dim check = Convert.ToInt32(command.ExecuteScalar())

            If check > 0 Then
                MessageBox.Show("Username: " & suUsername.Text & " is already axist!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                suUsername.Clear()
                suPassword.Clear()
            Else
                sql = "INSERT INTO admin ([username],[password]) VALUES (?,?)"
                command = New OleDbCommand(sql, connect)
                command.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = suUsername.Text
                command.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = suPassword.Text

                command.ExecuteNonQuery()

                MessageBox.Show("Succesfully create a new account", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                suUsername.Clear()
                suPassword.Clear()
                LoginPage.Show()
                Me.Hide()


            End If


        End If

    End Sub



    'HANDLE CHECKBOX SHOW PASSWORD
    Private Sub CheckBoxShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPass.CheckedChanged
        If CheckBoxShowPass.Checked = True Then
            suPassword.PasswordChar = ""
        Else
            suPassword.PasswordChar = "*"
        End If
    End Sub
End Class
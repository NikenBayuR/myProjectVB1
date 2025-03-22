Imports Microsoft.VisualBasic.ApplicationServices

Public Class LandingPage
    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayUser()

    End Sub

    Sub displayUser()
        Dim user As String = LoginPage.TextBoxUsername.Text
        user = user.Substring(0, 1).ToUpper & user.Substring(1)
        dash_username.Text = user
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.ExitThread()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        LoginPage.Show()
        LoginPage.TextBoxUsername.Clear()
        LoginPage.TextBoxPassword.Clear()
        Me.Close()
    End Sub

    Private Sub BtnTampilkan_Click(sender As Object, e As EventArgs) Handles BtnTampilkan.Click
        Dim Nama As String = TextBoxNama.Text
        Dim Kelas As String = TextBoxKelas.Text
        Dim Npm As String = TextBoxNpm.Text
        Dim Agama As String = TextBoxAgama.Text
        Dim JenisKelamin As String = TextBoxJenisKelamin.Text
        Dim hasilBiodata As String = $"Nama: {Nama}" & vbCrLf &
                                     "Kelas: " & Kelas & vbCrLf &
                                     "Npm: " & Npm & vbCrLf &
                                     "Agama: " & Agama & vbCrLf &
                                     "jenis Kelamin: " & Kelas & vbCrLf
        MessageBox.Show(hasilBiodata, "New Employe Biodata", MessageBoxButtons.OK, MessageBoxIcon.Information)



    End Sub
End Class
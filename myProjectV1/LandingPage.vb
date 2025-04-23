
Imports System.Data.OleDb
Imports System.IO


Public Class LandingPage
    'HANDLE CONNECTION VARABLE
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PE-D\Documents\CURD.accdb;")
    Dim dr As OleDbDataReader
    Dim i As Integer



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

        TextBoxID.Text = "[ AUTO INCREMENT ]"
        TextBoxID.Enabled = False

        loadingDataGridView()
    End Sub



    'HANDLE DASH NAME
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




    'HANDLE BUTTON CLOSE, MAXIMIZED, MINIMIZED
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



    'HANDLE READ DATA
    Sub loadingDataGridView()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDbCommand("Select * from CURD ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("Nik"), dr.Item("Nama"), dr.Item("TempatLahir"), dr.Item("TanggalLahir"), dr.Item("JenisKelamin"), dr.Item("Alamat"),
                                       dr.Item("Rt_Rw"), dr.Item("Kelurahan"), dr.Item("Kecamatan"), dr.Item("Agama"), dr.Item("StatusKawin"), dr.Item("Pekerjaan"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub



    'HANDLE BUTTON CLEAR FORM
    Sub clear()

        TextBoxID.Text = "[ AUTO INCREMENT ]"
        TextBoxNik.Clear()
        TextBoxNama.Clear()
        TextBoxTempatLahir.Clear()
        DateTimePicker1.Value = DateTime.Now
        ComboBoxJenisKelamin.SelectedIndex = -1
        TextBoxAlamat.Clear()
        TextBoxRtRw.Clear()
        TextBoxKelurahanDesa.Clear()
        TextBoxKecamatan.Clear()
        ComboBoxAgama.SelectedIndex = -1
        ComboBoxStatusKawin.SelectedIndex = -1
        ComboBoxPekerjaan.SelectedIndex = -1
    End Sub

    Private Sub ButtonClearForm_Click(sender As Object, e As EventArgs) Handles ButtonClearForm.Click
        clear()
    End Sub



    'HANDLE BUTTON CREATE
    Sub create()

        Try
            conn.Open()
            If MsgBox("Are You Sure Insert This Record", vbQuestion + vbYesNo) = vbYes Then
                Dim cmd As New OleDb.OleDbCommand("Insert Into CURD (`Nik`,`Nama`,`TempatLahir`,`TanggalLahir`,`JenisKelamin`,`Alamat`,`RT_RW`,`Kelurahan`,`Kecamatan`,`Agama`,`StatusKawin`,`Pekerjaan`)
                                                   Values(@Nik,@Nama,@TempatLahir,@TanggalLahir,@JenisKelamin,@Alamat,@Rt_Rw,@Kelurahan,@Kecamatan,@Agama,@StatusKawin,@Pekerjaan)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Nik", TextBoxNik.Text)
                cmd.Parameters.AddWithValue("@Nama", TextBoxNama.Text)
                cmd.Parameters.AddWithValue("@TempatLahir", TextBoxTempatLahir.Text)
                cmd.Parameters.AddWithValue("@TanggalLahir", DateTimePicker1.Text)
                cmd.Parameters.AddWithValue("@JenisKelamin", ComboBoxJenisKelamin.Text)
                cmd.Parameters.AddWithValue("@Alamat", TextBoxAlamat.Text)
                cmd.Parameters.AddWithValue("@Rt_Rw", TextBoxRtRw.Text)
                cmd.Parameters.AddWithValue("@Kelurahan", TextBoxKelurahanDesa.Text)
                cmd.Parameters.AddWithValue("@Kecamatan", TextBoxKecamatan.Text)
                cmd.Parameters.AddWithValue("@Agama", ComboBoxAgama.Text)
                cmd.Parameters.AddWithValue("@StatusKawin", ComboBoxStatusKawin.Text)
                cmd.Parameters.AddWithValue("@Pekerjaan", ComboBoxPekerjaan.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Record Save Succes !!", vbInformation)
                Else
                    MsgBox("Failed", vbCritical)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingDataGridView()
        clear()
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        create()
    End Sub



    'HANDLE BUTTON DELETE
    Sub delete()
        Try
            conn.Open()
            If MsgBox("Are You Sure Delete This Record", vbQuestion + vbYesNo) = vbYes Then
                Dim cmd As New OleDb.OleDbCommand("Delete from CURD where ID=@ID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ID", TextBoxID.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Record Delete Succes !!", vbInformation)
                Else
                    MsgBox("Failed", vbCritical)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingDataGridView()
        clear()
    End Sub
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        delete()
    End Sub



    'HANDLE BUTTON PRINT DATAGRIDVIEW1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBoxID.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBoxNik.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBoxNama.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBoxTempatLahir.Text = DataGridView1.CurrentRow.Cells(3).Value
        DateTimePicker1.Text = DataGridView1.CurrentRow.Cells(4).Value
        ComboBoxJenisKelamin.Text = DataGridView1.CurrentRow.Cells(5).Value
        TextBoxAlamat.Text = DataGridView1.CurrentRow.Cells(6).Value
        TextBoxRtRw.Text = DataGridView1.CurrentRow.Cells(7).Value
        TextBoxKelurahanDesa.Text = DataGridView1.CurrentRow.Cells(8).Value
        TextBoxKecamatan.Text = DataGridView1.CurrentRow.Cells(9).Value
        ComboBoxAgama.Text = DataGridView1.CurrentRow.Cells(10).Value
        ComboBoxStatusKawin.Text = DataGridView1.CurrentRow.Cells(11).Value
        ComboBoxPekerjaan.Text = DataGridView1.CurrentRow.Cells(12).Value
    End Sub



    'HANDLE BUTTON UPDATE
    Sub edit()
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Update CURD SET `Nik`=@Nik,`Nama`=@Nama,`TempatLahir`=@TempatLahir,`TanggalLahir`=@TanggalLahir,`JenisKelamin`=@JenisKelamin,`Alamat`=@Alamat,
                                              `RT_RW`=@RT_RW,`Kelurahan`=@Kelurahan,`Kecamatan`=@Kecamatan,`Agama`=@Agama,`StatusKawin`=@StatusKawin,`Pekerjaan`=@Pekerjaan Where ID=@ID ", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Nik", TextBoxNik.Text)
            cmd.Parameters.AddWithValue("@Nama", TextBoxNama.Text)
            cmd.Parameters.AddWithValue("@TempatLahir", TextBoxTempatLahir.Text)
            cmd.Parameters.AddWithValue("@TanggalLahir", DateTimePicker1.Text)
            cmd.Parameters.AddWithValue("@JenisKelamin", ComboBoxJenisKelamin.Text)
            cmd.Parameters.AddWithValue("@Alamat", TextBoxAlamat.Text)
            cmd.Parameters.AddWithValue("@Rt_Rw", TextBoxRtRw.Text)
            cmd.Parameters.AddWithValue("@Kelurahan", TextBoxKelurahanDesa.Text)
            cmd.Parameters.AddWithValue("@Kecamatan", TextBoxKecamatan.Text)
            cmd.Parameters.AddWithValue("@Agama", ComboBoxAgama.Text)
            cmd.Parameters.AddWithValue("@StatusKawin", ComboBoxStatusKawin.Text)
            cmd.Parameters.AddWithValue("@Pekerjaan", ComboBoxPekerjaan.Text)
            cmd.Parameters.AddWithValue("@ID", TextBoxID.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record Update Succes !!", vbInformation)
            Else
                MsgBox("Failed", vbCritical)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingDataGridView()
        clear()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        edit()
    End Sub



    'HANDLE BUTTON SEARCH
    Sub search()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDbCommand("Select * from CURD Where
                                       `Nik` like '%" & TextBoxSearch.Text & "%'
                                         or `Nama` like '%" & TextBoxSearch.Text & "%'
                                          or `TempatLahir` like '%" & TextBoxSearch.Text & "%'
                                           or `TanggalLahir` like '%" & TextBoxSearch.Text & "%'
                                            or `JenisKelamin` like '%" & TextBoxSearch.Text & "%'
                                             or `Alamat` like '%" & TextBoxSearch.Text & "%'
                                              or `Rt_Rw` like '%" & TextBoxSearch.Text & "%'
                                               or `Kelurahan` like '%" & TextBoxSearch.Text & "%'
                                                or `Kecamatan` like '%" & TextBoxSearch.Text & "%'
                                                 or `Agama` like '%" & TextBoxSearch.Text & "%'
                                                  or `StatusKawin` like '%" & TextBoxSearch.Text & "%'
                                                   or `Pekerjaan` like '%" & TextBoxSearch.Text & "%'
                                                    ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("Nik"), dr.Item("Nama"), dr.Item("TempatLahir"), dr.Item("TanggalLahir"), dr.Item("JenisKelamin"), dr.Item("Alamat"),
                                       dr.Item("Rt_Rw"), dr.Item("Kelurahan"), dr.Item("Kecamatan"), dr.Item("Agama"), dr.Item("StatusKawin"), dr.Item("Pekerjaan"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        search()
    End Sub
End Class
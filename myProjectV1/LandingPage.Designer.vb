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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        panelNavbar = New Panel()
        LabelJudul = New Label()
        btnMaximized = New Button()
        btnMinimized = New Button()
        txtWelcome = New Label()
        btnLogOut = New Button()
        btnClose = New Button()
        dash_username = New Label()
        panelBackground = New Panel()
        panelContent = New Panel()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        ComboBoxJenisKelamin = New ComboBox()
        ButtonClearForm = New Button()
        ButtonUpdate = New Button()
        ButtonDelete = New Button()
        ButtonCreate = New Button()
        LabelSearch = New Label()
        TextBoxSearch = New TextBox()
        LabelConnection = New Label()
        LabelConnectionState = New Label()
        LabelID = New Label()
        TextBoxID = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        ComboBoxPekerjaan = New ComboBox()
        ComboBoxStatusKawin = New ComboBox()
        ComboBoxAgama = New ComboBox()
        LabelStatusKawin = New Label()
        LabelPekerjaan = New Label()
        LabelAgama = New Label()
        LabelTanggalLahir = New Label()
        LabelKecamatan = New Label()
        TextBoxKecamatan = New TextBox()
        LabelKelurahanDesa = New Label()
        TextBoxKelurahanDesa = New TextBox()
        LabelRtRw = New Label()
        TextBoxRtRw = New TextBox()
        LabeAlamat = New Label()
        TextBoxAlamat = New TextBox()
        LabelJenisKelamin = New Label()
        LabelTempatLahir = New Label()
        TextBoxTempatLahir = New TextBox()
        LabelNama = New Label()
        TextBoxNama = New TextBox()
        LabelNIK = New Label()
        TextBoxNik = New TextBox()
        panelNavbar.SuspendLayout()
        panelBackground.SuspendLayout()
        panelContent.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelNavbar
        ' 
        panelNavbar.BackColor = Color.Brown
        panelNavbar.Controls.Add(LabelJudul)
        panelNavbar.Controls.Add(btnMaximized)
        panelNavbar.Controls.Add(btnMinimized)
        panelNavbar.Controls.Add(txtWelcome)
        panelNavbar.Controls.Add(btnLogOut)
        panelNavbar.Controls.Add(btnClose)
        panelNavbar.Controls.Add(dash_username)
        panelNavbar.Dock = DockStyle.Top
        panelNavbar.Location = New Point(0, 0)
        panelNavbar.Name = "panelNavbar"
        panelNavbar.Size = New Size(1500, 83)
        panelNavbar.TabIndex = 0
        ' 
        ' LabelJudul
        ' 
        LabelJudul.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LabelJudul.AutoSize = True
        LabelJudul.BackColor = Color.Transparent
        LabelJudul.Font = New Font("Britannic Bold", 17F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelJudul.ForeColor = Color.Silver
        LabelJudul.Location = New Point(524, 23)
        LabelJudul.Name = "LabelJudul"
        LabelJudul.Size = New Size(498, 37)
        LabelJudul.TabIndex = 6
        LabelJudul.Text = "WARGA DESA KAMPUNG SONDOL"
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
        btnMaximized.Location = New Point(1423, 4)
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
        btnMinimized.Location = New Point(1385, 4)
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
        btnLogOut.Location = New Point(1390, 40)
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
        btnClose.Location = New Point(1461, 4)
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
        dash_username.Size = New Size(0, 37)
        dash_username.TabIndex = 0
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
        panelBackground.Size = New Size(1500, 763)
        panelBackground.TabIndex = 0
        ' 
        ' panelContent
        ' 
        panelContent.BackColor = Color.Transparent
        panelContent.BorderStyle = BorderStyle.FixedSingle
        panelContent.Controls.Add(DataGridView1)
        panelContent.Controls.Add(ComboBoxJenisKelamin)
        panelContent.Controls.Add(ButtonClearForm)
        panelContent.Controls.Add(ButtonUpdate)
        panelContent.Controls.Add(ButtonDelete)
        panelContent.Controls.Add(ButtonCreate)
        panelContent.Controls.Add(LabelSearch)
        panelContent.Controls.Add(TextBoxSearch)
        panelContent.Controls.Add(LabelConnection)
        panelContent.Controls.Add(LabelConnectionState)
        panelContent.Controls.Add(LabelID)
        panelContent.Controls.Add(TextBoxID)
        panelContent.Controls.Add(DateTimePicker1)
        panelContent.Controls.Add(ComboBoxPekerjaan)
        panelContent.Controls.Add(ComboBoxStatusKawin)
        panelContent.Controls.Add(ComboBoxAgama)
        panelContent.Controls.Add(LabelStatusKawin)
        panelContent.Controls.Add(LabelPekerjaan)
        panelContent.Controls.Add(LabelAgama)
        panelContent.Controls.Add(LabelTanggalLahir)
        panelContent.Controls.Add(LabelKecamatan)
        panelContent.Controls.Add(TextBoxKecamatan)
        panelContent.Controls.Add(LabelKelurahanDesa)
        panelContent.Controls.Add(TextBoxKelurahanDesa)
        panelContent.Controls.Add(LabelRtRw)
        panelContent.Controls.Add(TextBoxRtRw)
        panelContent.Controls.Add(LabeAlamat)
        panelContent.Controls.Add(TextBoxAlamat)
        panelContent.Controls.Add(LabelJenisKelamin)
        panelContent.Controls.Add(LabelTempatLahir)
        panelContent.Controls.Add(TextBoxTempatLahir)
        panelContent.Controls.Add(LabelNama)
        panelContent.Controls.Add(TextBoxNama)
        panelContent.Controls.Add(LabelNIK)
        panelContent.Controls.Add(TextBoxNik)
        panelContent.Dock = DockStyle.Fill
        panelContent.Location = New Point(0, 0)
        panelContent.Name = "panelContent"
        panelContent.Size = New Size(1500, 763)
        panelContent.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle1.ForeColor = Color.DimGray
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle2.ForeColor = Color.DimGray
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDark
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(-1, 551)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1496, 211)
        DataGridView1.TabIndex = 47
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 67
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Nik"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 78
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Nama"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Tempat Lahir"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 159
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Tanggal Lahir"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 163
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Jenis Kelamin"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 164
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "Alamat"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 110
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "Rt/Rw"
        Column8.MinimumWidth = 8
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 101
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "Kelurahan"
        Column9.MinimumWidth = 8
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 135
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column10.HeaderText = "Kecamatan"
        Column10.MinimumWidth = 8
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 144
        ' 
        ' Column11
        ' 
        Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column11.HeaderText = "Agama"
        Column11.MinimumWidth = 8
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 110
        ' 
        ' Column12
        ' 
        Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column12.HeaderText = "Status Kawin"
        Column12.MinimumWidth = 8
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        Column12.Width = 158
        ' 
        ' Column13
        ' 
        Column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column13.HeaderText = "Pekerjaan"
        Column13.MinimumWidth = 8
        Column13.Name = "Column13"
        Column13.ReadOnly = True
        Column13.Width = 131
        ' 
        ' ComboBoxJenisKelamin
        ' 
        ComboBoxJenisKelamin.FormattingEnabled = True
        ComboBoxJenisKelamin.Items.AddRange(New Object() {"Laki Laki", "Perempuan"})
        ComboBoxJenisKelamin.Location = New Point(199, 249)
        ComboBoxJenisKelamin.Name = "ComboBoxJenisKelamin"
        ComboBoxJenisKelamin.Size = New Size(298, 33)
        ComboBoxJenisKelamin.TabIndex = 46
        ' 
        ' ButtonClearForm
        ' 
        ButtonClearForm.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        ButtonClearForm.ForeColor = Color.Sienna
        ButtonClearForm.Location = New Point(791, 439)
        ButtonClearForm.Name = "ButtonClearForm"
        ButtonClearForm.Size = New Size(188, 30)
        ButtonClearForm.TabIndex = 45
        ButtonClearForm.Text = "CLEAR FORM"
        ButtonClearForm.UseVisualStyleBackColor = True
        ' 
        ' ButtonUpdate
        ' 
        ButtonUpdate.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        ButtonUpdate.ForeColor = Color.Sienna
        ButtonUpdate.Location = New Point(546, 439)
        ButtonUpdate.Name = "ButtonUpdate"
        ButtonUpdate.Size = New Size(188, 30)
        ButtonUpdate.TabIndex = 44
        ButtonUpdate.Text = "UPDATE"
        ButtonUpdate.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        ButtonDelete.ForeColor = Color.Sienna
        ButtonDelete.Location = New Point(286, 439)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(188, 30)
        ButtonDelete.TabIndex = 43
        ButtonDelete.Text = "DELETE"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' ButtonCreate
        ' 
        ButtonCreate.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        ButtonCreate.ForeColor = Color.Sienna
        ButtonCreate.Location = New Point(31, 439)
        ButtonCreate.Name = "ButtonCreate"
        ButtonCreate.Size = New Size(188, 30)
        ButtonCreate.TabIndex = 42
        ButtonCreate.Text = "CREATE"
        ButtonCreate.UseVisualStyleBackColor = False
        ' 
        ' LabelSearch
        ' 
        LabelSearch.AutoSize = True
        LabelSearch.BackColor = Color.Transparent
        LabelSearch.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelSearch.ForeColor = Color.Sienna
        LabelSearch.Location = New Point(1055, 442)
        LabelSearch.Name = "LabelSearch"
        LabelSearch.Size = New Size(79, 24)
        LabelSearch.TabIndex = 41
        LabelSearch.Text = "SEARCH"
        ' 
        ' TextBoxSearch
        ' 
        TextBoxSearch.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxSearch.ForeColor = Color.Sienna
        TextBoxSearch.Location = New Point(1156, 439)
        TextBoxSearch.Name = "TextBoxSearch"
        TextBoxSearch.Size = New Size(298, 30)
        TextBoxSearch.TabIndex = 40
        ' 
        ' LabelConnection
        ' 
        LabelConnection.AutoSize = True
        LabelConnection.BackColor = Color.Transparent
        LabelConnection.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelConnection.ForeColor = Color.White
        LabelConnection.Location = New Point(1285, 92)
        LabelConnection.Name = "LabelConnection"
        LabelConnection.Size = New Size(0, 24)
        LabelConnection.TabIndex = 35
        ' 
        ' LabelConnectionState
        ' 
        LabelConnectionState.AutoSize = True
        LabelConnectionState.BackColor = Color.Transparent
        LabelConnectionState.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelConnectionState.ForeColor = Color.Sienna
        LabelConnectionState.Location = New Point(1125, 93)
        LabelConnectionState.Name = "LabelConnectionState"
        LabelConnectionState.Size = New Size(143, 24)
        LabelConnectionState.TabIndex = 34
        LabelConnectionState.Text = "Connection State"
        ' 
        ' LabelID
        ' 
        LabelID.AutoSize = True
        LabelID.BackColor = Color.Transparent
        LabelID.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelID.ForeColor = Color.Sienna
        LabelID.Location = New Point(1125, 39)
        LabelID.Name = "LabelID"
        LabelID.Size = New Size(26, 24)
        LabelID.TabIndex = 32
        LabelID.Text = "ID"
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxID.ForeColor = Color.Sienna
        TextBoxID.Location = New Point(1169, 35)
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(176, 30)
        TextBoxID.TabIndex = 31
        TextBoxID.Text = "[ AUTO INCREMENT ]"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(199, 197)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(298, 31)
        DateTimePicker1.TabIndex = 30
        ' 
        ' ComboBoxPekerjaan
        ' 
        ComboBoxPekerjaan.FormattingEnabled = True
        ComboBoxPekerjaan.Items.AddRange(New Object() {"Guru", "Dosen", "Dokter", "Wirausaha", "Wiraswasta", "Pelajar/Mahasiswa", "PNS (Pegawai Negeri Sipil)", "Membantu Rumah Tangga", "Polri (Polisi Republik Indonesia)", "TNI (Tentara Nasional Indonesia)", ""})
        ComboBoxPekerjaan.Location = New Point(800, 304)
        ComboBoxPekerjaan.Name = "ComboBoxPekerjaan"
        ComboBoxPekerjaan.Size = New Size(298, 33)
        ComboBoxPekerjaan.TabIndex = 29
        ' 
        ' ComboBoxStatusKawin
        ' 
        ComboBoxStatusKawin.FormattingEnabled = True
        ComboBoxStatusKawin.Items.AddRange(New Object() {"Belum Kawin", "Sudah Kawin", "Duda", "Janda"})
        ComboBoxStatusKawin.Location = New Point(800, 243)
        ComboBoxStatusKawin.Name = "ComboBoxStatusKawin"
        ComboBoxStatusKawin.Size = New Size(196, 33)
        ComboBoxStatusKawin.TabIndex = 28
        ' 
        ' ComboBoxAgama
        ' 
        ComboBoxAgama.FormattingEnabled = True
        ComboBoxAgama.Items.AddRange(New Object() {"Islam", "Hindu", "Buddha", "Konghucu", "Kristen katolik", "Kristen Protestan"})
        ComboBoxAgama.Location = New Point(800, 193)
        ComboBoxAgama.Name = "ComboBoxAgama"
        ComboBoxAgama.Size = New Size(196, 33)
        ComboBoxAgama.TabIndex = 27
        ' 
        ' LabelStatusKawin
        ' 
        LabelStatusKawin.AutoSize = True
        LabelStatusKawin.BackColor = Color.Transparent
        LabelStatusKawin.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelStatusKawin.ForeColor = Color.Sienna
        LabelStatusKawin.Location = New Point(600, 254)
        LabelStatusKawin.Name = "LabelStatusKawin"
        LabelStatusKawin.Size = New Size(134, 24)
        LabelStatusKawin.TabIndex = 26
        LabelStatusKawin.Text = "STATUS KAWIN"
        ' 
        ' LabelPekerjaan
        ' 
        LabelPekerjaan.AutoSize = True
        LabelPekerjaan.BackColor = Color.Transparent
        LabelPekerjaan.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelPekerjaan.ForeColor = Color.Sienna
        LabelPekerjaan.Location = New Point(600, 315)
        LabelPekerjaan.Name = "LabelPekerjaan"
        LabelPekerjaan.Size = New Size(110, 24)
        LabelPekerjaan.TabIndex = 25
        LabelPekerjaan.Text = "PEKERJAAN"
        ' 
        ' LabelAgama
        ' 
        LabelAgama.AutoSize = True
        LabelAgama.BackColor = Color.Transparent
        LabelAgama.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelAgama.ForeColor = Color.Sienna
        LabelAgama.Location = New Point(600, 202)
        LabelAgama.Name = "LabelAgama"
        LabelAgama.Size = New Size(70, 24)
        LabelAgama.TabIndex = 24
        LabelAgama.Text = "AGAMA"
        ' 
        ' LabelTanggalLahir
        ' 
        LabelTanggalLahir.AutoSize = True
        LabelTanggalLahir.BackColor = Color.Transparent
        LabelTanggalLahir.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelTanggalLahir.ForeColor = Color.Sienna
        LabelTanggalLahir.Location = New Point(31, 202)
        LabelTanggalLahir.Name = "LabelTanggalLahir"
        LabelTanggalLahir.Size = New Size(144, 24)
        LabelTanggalLahir.TabIndex = 23
        LabelTanggalLahir.Text = "TANGGAL LAHIR"
        ' 
        ' LabelKecamatan
        ' 
        LabelKecamatan.AutoSize = True
        LabelKecamatan.BackColor = Color.Transparent
        LabelKecamatan.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelKecamatan.ForeColor = Color.Sienna
        LabelKecamatan.Location = New Point(600, 144)
        LabelKecamatan.Name = "LabelKecamatan"
        LabelKecamatan.Size = New Size(114, 24)
        LabelKecamatan.TabIndex = 22
        LabelKecamatan.Text = "KECAMATAN"
        ' 
        ' TextBoxKecamatan
        ' 
        TextBoxKecamatan.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxKecamatan.ForeColor = Color.Sienna
        TextBoxKecamatan.Location = New Point(800, 140)
        TextBoxKecamatan.Name = "TextBoxKecamatan"
        TextBoxKecamatan.Size = New Size(298, 30)
        TextBoxKecamatan.TabIndex = 21
        ' 
        ' LabelKelurahanDesa
        ' 
        LabelKelurahanDesa.AutoSize = True
        LabelKelurahanDesa.BackColor = Color.Transparent
        LabelKelurahanDesa.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelKelurahanDesa.ForeColor = Color.Sienna
        LabelKelurahanDesa.Location = New Point(600, 91)
        LabelKelurahanDesa.Name = "LabelKelurahanDesa"
        LabelKelurahanDesa.Size = New Size(173, 24)
        LabelKelurahanDesa.TabIndex = 20
        LabelKelurahanDesa.Text = "KELURAHAN / DESA"
        ' 
        ' TextBoxKelurahanDesa
        ' 
        TextBoxKelurahanDesa.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxKelurahanDesa.ForeColor = Color.Sienna
        TextBoxKelurahanDesa.Location = New Point(800, 87)
        TextBoxKelurahanDesa.Name = "TextBoxKelurahanDesa"
        TextBoxKelurahanDesa.Size = New Size(298, 30)
        TextBoxKelurahanDesa.TabIndex = 19
        ' 
        ' LabelRtRw
        ' 
        LabelRtRw.AutoSize = True
        LabelRtRw.BackColor = Color.Transparent
        LabelRtRw.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelRtRw.ForeColor = Color.Sienna
        LabelRtRw.Location = New Point(600, 37)
        LabelRtRw.Name = "LabelRtRw"
        LabelRtRw.Size = New Size(74, 24)
        LabelRtRw.TabIndex = 18
        LabelRtRw.Text = "RT / RW"
        ' 
        ' TextBoxRtRw
        ' 
        TextBoxRtRw.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxRtRw.ForeColor = Color.Sienna
        TextBoxRtRw.Location = New Point(800, 33)
        TextBoxRtRw.Name = "TextBoxRtRw"
        TextBoxRtRw.Size = New Size(298, 30)
        TextBoxRtRw.TabIndex = 17
        ' 
        ' LabeAlamat
        ' 
        LabeAlamat.AutoSize = True
        LabeAlamat.BackColor = Color.Transparent
        LabeAlamat.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabeAlamat.ForeColor = Color.Sienna
        LabeAlamat.Location = New Point(31, 313)
        LabeAlamat.Name = "LabeAlamat"
        LabeAlamat.Size = New Size(62, 24)
        LabeAlamat.TabIndex = 16
        LabeAlamat.Text = "Alamat"
        ' 
        ' TextBoxAlamat
        ' 
        TextBoxAlamat.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxAlamat.ForeColor = Color.Sienna
        TextBoxAlamat.Location = New Point(199, 310)
        TextBoxAlamat.Name = "TextBoxAlamat"
        TextBoxAlamat.Size = New Size(298, 30)
        TextBoxAlamat.TabIndex = 15
        ' 
        ' LabelJenisKelamin
        ' 
        LabelJenisKelamin.AutoSize = True
        LabelJenisKelamin.BackColor = Color.Transparent
        LabelJenisKelamin.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelJenisKelamin.ForeColor = Color.Sienna
        LabelJenisKelamin.Location = New Point(31, 252)
        LabelJenisKelamin.Name = "LabelJenisKelamin"
        LabelJenisKelamin.Size = New Size(136, 24)
        LabelJenisKelamin.TabIndex = 14
        LabelJenisKelamin.Text = "JENIS KELAMIN"
        ' 
        ' LabelTempatLahir
        ' 
        LabelTempatLahir.AutoSize = True
        LabelTempatLahir.BackColor = Color.Transparent
        LabelTempatLahir.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelTempatLahir.ForeColor = Color.Sienna
        LabelTempatLahir.Location = New Point(31, 142)
        LabelTempatLahir.Name = "LabelTempatLahir"
        LabelTempatLahir.Size = New Size(131, 24)
        LabelTempatLahir.TabIndex = 12
        LabelTempatLahir.Text = "TEMPAT LAHIR"
        ' 
        ' TextBoxTempatLahir
        ' 
        TextBoxTempatLahir.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxTempatLahir.ForeColor = Color.Sienna
        TextBoxTempatLahir.Location = New Point(199, 139)
        TextBoxTempatLahir.Name = "TextBoxTempatLahir"
        TextBoxTempatLahir.Size = New Size(298, 30)
        TextBoxTempatLahir.TabIndex = 11
        ' 
        ' LabelNama
        ' 
        LabelNama.AutoSize = True
        LabelNama.BackColor = Color.Transparent
        LabelNama.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelNama.ForeColor = Color.Sienna
        LabelNama.Location = New Point(31, 89)
        LabelNama.Name = "LabelNama"
        LabelNama.Size = New Size(58, 24)
        LabelNama.TabIndex = 10
        LabelNama.Text = "NAMA"
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxNama.ForeColor = Color.Sienna
        TextBoxNama.Location = New Point(199, 86)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.Size = New Size(298, 30)
        TextBoxNama.TabIndex = 9
        ' 
        ' LabelNIK
        ' 
        LabelNIK.AutoSize = True
        LabelNIK.BackColor = Color.Transparent
        LabelNIK.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        LabelNIK.ForeColor = Color.Sienna
        LabelNIK.Location = New Point(31, 35)
        LabelNIK.Name = "LabelNIK"
        LabelNIK.Size = New Size(38, 24)
        LabelNIK.TabIndex = 8
        LabelNIK.Text = "NIK"
        ' 
        ' TextBoxNik
        ' 
        TextBoxNik.Font = New Font("Arial Narrow", 10F, FontStyle.Bold)
        TextBoxNik.ForeColor = Color.Sienna
        TextBoxNik.Location = New Point(199, 32)
        TextBoxNik.Name = "TextBoxNik"
        TextBoxNik.Size = New Size(298, 30)
        TextBoxNik.TabIndex = 7
        ' 
        ' LandingPage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1500, 846)
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
    Friend WithEvents ComboBoxStatusKawin As ComboBox
    Friend WithEvents ComboBoxAgama As ComboBox
    Friend WithEvents LabelStatusKawin As Label
    Friend WithEvents LabelPekerjaan As Label
    Friend WithEvents LabelAgama As Label
    Friend WithEvents LabelTanggalLahir As Label
    Friend WithEvents LabelKecamatan As Label
    Friend WithEvents TextBoxKecamatan As TextBox
    Friend WithEvents LabelKelurahanDesa As Label
    Friend WithEvents TextBoxKelurahanDesa As TextBox
    Friend WithEvents LabelRtRw As Label
    Friend WithEvents TextBoxRtRw As TextBox
    Friend WithEvents LabeAlamat As Label
    Friend WithEvents TextBoxAlamat As TextBox
    Friend WithEvents LabelJenisKelamin As Label
    Friend WithEvents LabelTempatLahir As Label
    Friend WithEvents TextBoxTempatLahir As TextBox
    Friend WithEvents LabelNama As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents LabelNIK As Label
    Friend WithEvents TextBoxNik As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBoxPekerjaan As ComboBox
    Friend WithEvents LabelID As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents LabelConnectionState As Label
    Friend WithEvents LabelSearch As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonClearForm As Button
    Friend WithEvents LabelConnection As Label
    Friend WithEvents ComboBoxJenisKelamin As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents LabelJudul As Label
End Class

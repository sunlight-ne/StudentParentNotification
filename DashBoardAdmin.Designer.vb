<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashBoardAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashBoardAdmin))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnViewStudent2 = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnViewSubAdmin2 = New System.Windows.Forms.Button()
        Me.btnViewRecord2 = New System.Windows.Forms.Button()
        Me.pnlViewRecord = New System.Windows.Forms.Panel()
        Me.dtpRecord = New System.Windows.Forms.DateTimePicker()
        Me.btnPrintRecord = New System.Windows.Forms.Button()
        Me.btnFilterRecord = New System.Windows.Forms.Button()
        Me.txtFilterRecord = New System.Windows.Forms.TextBox()
        Me.cboFilterRecord = New System.Windows.Forms.ComboBox()
        Me.dtgViewRecord = New System.Windows.Forms.DataGridView()
        Me.lblPanelname = New System.Windows.Forms.Label()
        Me.pnlViewSubadmin = New System.Windows.Forms.Panel()
        Me.btnPrintSub = New System.Windows.Forms.Button()
        Me.btnAddSub = New System.Windows.Forms.Button()
        Me.btnFilterSub = New System.Windows.Forms.Button()
        Me.txtFilterSub = New System.Windows.Forms.TextBox()
        Me.cboFilterSub = New System.Windows.Forms.ComboBox()
        Me.dtgListSubadmin = New System.Windows.Forms.DataGridView()
        Me.pnlViewStudent = New System.Windows.Forms.Panel()
        Me.btnPrintStudent = New System.Windows.Forms.Button()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnFilterStudent = New System.Windows.Forms.Button()
        Me.txtFilterStudent = New System.Windows.Forms.TextBox()
        Me.cboFilterStudent = New System.Windows.Forms.ComboBox()
        Me.dtgStudent = New System.Windows.Forms.DataGridView()
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.gpbGeneratecode = New System.Windows.Forms.GroupBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnUpdateCode = New System.Windows.Forms.Button()
        Me.btnGenerateCode = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpdateCredentials = New System.Windows.Forms.Button()
        Me.txtReEnterPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlProfileInformation = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboGenderProfile = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNumberProfile = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.txtEmailProfile = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMiddleNameProfile = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLastNameProfile = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFirstNameProfile = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlPendingStudents = New System.Windows.Forms.Panel()
        Me.btnPrinfPending = New System.Windows.Forms.Button()
        Me.btnFilterPending = New System.Windows.Forms.Button()
        Me.txtFilterPending = New System.Windows.Forms.TextBox()
        Me.cboFilterPending = New System.Windows.Forms.ComboBox()
        Me.dtgStudentPending = New System.Windows.Forms.DataGridView()
        Me.btnStudentCount = New System.Windows.Forms.Button()
        Me.btnSubadminCount = New System.Windows.Forms.Button()
        Me.btnRecordCount = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ptbimageprofilesubadmin = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlViewRecord.SuspendLayout()
        CType(Me.dtgViewRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlViewSubadmin.SuspendLayout()
        CType(Me.dtgListSubadmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlViewStudent.SuspendLayout()
        CType(Me.dtgStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSettings.SuspendLayout()
        Me.gpbGeneratecode.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlProfileInformation.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.pnlPendingStudents.SuspendLayout()
        CType(Me.dtgStudentPending, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDashboard.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbimageprofilesubadmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnViewStudent2)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btnViewSubAdmin2)
        Me.Panel1.Controls.Add(Me.btnViewRecord2)
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(189, 570)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 55)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Settings"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(1, 220)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(189, 55)
        Me.btnHome.TabIndex = 5
        Me.btnHome.Text = "Student pending"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1, 515)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(189, 55)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "LogOut"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnViewStudent2
        '
        Me.btnViewStudent2.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnViewStudent2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewStudent2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewStudent2.ForeColor = System.Drawing.Color.White
        Me.btnViewStudent2.Location = New System.Drawing.Point(1, 279)
        Me.btnViewStudent2.Name = "btnViewStudent2"
        Me.btnViewStudent2.Size = New System.Drawing.Size(189, 55)
        Me.btnViewStudent2.TabIndex = 3
        Me.btnViewStudent2.Text = "View Student"
        Me.btnViewStudent2.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1, 457)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(189, 55)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnViewSubAdmin2
        '
        Me.btnViewSubAdmin2.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnViewSubAdmin2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewSubAdmin2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewSubAdmin2.ForeColor = System.Drawing.Color.White
        Me.btnViewSubAdmin2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnViewSubAdmin2.Location = New System.Drawing.Point(1, 160)
        Me.btnViewSubAdmin2.Name = "btnViewSubAdmin2"
        Me.btnViewSubAdmin2.Size = New System.Drawing.Size(189, 55)
        Me.btnViewSubAdmin2.TabIndex = 1
        Me.btnViewSubAdmin2.Text = "View Sub Admin"
        Me.btnViewSubAdmin2.UseVisualStyleBackColor = False
        '
        'btnViewRecord2
        '
        Me.btnViewRecord2.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnViewRecord2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewRecord2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewRecord2.ForeColor = System.Drawing.Color.White
        Me.btnViewRecord2.Location = New System.Drawing.Point(1, 338)
        Me.btnViewRecord2.Name = "btnViewRecord2"
        Me.btnViewRecord2.Size = New System.Drawing.Size(189, 55)
        Me.btnViewRecord2.TabIndex = 0
        Me.btnViewRecord2.Text = "View Record"
        Me.btnViewRecord2.UseVisualStyleBackColor = False
        '
        'pnlViewRecord
        '
        Me.pnlViewRecord.BackColor = System.Drawing.Color.White
        Me.pnlViewRecord.Controls.Add(Me.dtpRecord)
        Me.pnlViewRecord.Controls.Add(Me.btnPrintRecord)
        Me.pnlViewRecord.Controls.Add(Me.btnFilterRecord)
        Me.pnlViewRecord.Controls.Add(Me.txtFilterRecord)
        Me.pnlViewRecord.Controls.Add(Me.cboFilterRecord)
        Me.pnlViewRecord.Controls.Add(Me.dtgViewRecord)
        Me.pnlViewRecord.Location = New System.Drawing.Point(910, 463)
        Me.pnlViewRecord.Name = "pnlViewRecord"
        Me.pnlViewRecord.Size = New System.Drawing.Size(728, 497)
        Me.pnlViewRecord.TabIndex = 1
        Me.pnlViewRecord.Visible = False
        '
        'dtpRecord
        '
        Me.dtpRecord.Enabled = False
        Me.dtpRecord.Location = New System.Drawing.Point(300, 43)
        Me.dtpRecord.Name = "dtpRecord"
        Me.dtpRecord.Size = New System.Drawing.Size(200, 20)
        Me.dtpRecord.TabIndex = 5
        '
        'btnPrintRecord
        '
        Me.btnPrintRecord.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnPrintRecord.ForeColor = System.Drawing.Color.White
        Me.btnPrintRecord.Location = New System.Drawing.Point(631, 461)
        Me.btnPrintRecord.Name = "btnPrintRecord"
        Me.btnPrintRecord.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintRecord.TabIndex = 4
        Me.btnPrintRecord.Text = "Print"
        Me.btnPrintRecord.UseVisualStyleBackColor = False
        '
        'btnFilterRecord
        '
        Me.btnFilterRecord.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnFilterRecord.ForeColor = System.Drawing.Color.White
        Me.btnFilterRecord.Location = New System.Drawing.Point(631, 43)
        Me.btnFilterRecord.Name = "btnFilterRecord"
        Me.btnFilterRecord.Size = New System.Drawing.Size(75, 23)
        Me.btnFilterRecord.TabIndex = 3
        Me.btnFilterRecord.Text = "Filter"
        Me.btnFilterRecord.UseVisualStyleBackColor = False
        '
        'txtFilterRecord
        '
        Me.txtFilterRecord.Enabled = False
        Me.txtFilterRecord.Location = New System.Drawing.Point(32, 43)
        Me.txtFilterRecord.Name = "txtFilterRecord"
        Me.txtFilterRecord.Size = New System.Drawing.Size(262, 20)
        Me.txtFilterRecord.TabIndex = 2
        '
        'cboFilterRecord
        '
        Me.cboFilterRecord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterRecord.FormattingEnabled = True
        Me.cboFilterRecord.Items.AddRange(New Object() {"FirstName", "LastName", "Date"})
        Me.cboFilterRecord.Location = New System.Drawing.Point(504, 43)
        Me.cboFilterRecord.Name = "cboFilterRecord"
        Me.cboFilterRecord.Size = New System.Drawing.Size(121, 21)
        Me.cboFilterRecord.TabIndex = 1
        '
        'dtgViewRecord
        '
        Me.dtgViewRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgViewRecord.BackgroundColor = System.Drawing.Color.White
        Me.dtgViewRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgViewRecord.Location = New System.Drawing.Point(32, 83)
        Me.dtgViewRecord.Name = "dtgViewRecord"
        Me.dtgViewRecord.Size = New System.Drawing.Size(674, 371)
        Me.dtgViewRecord.TabIndex = 0
        '
        'lblPanelname
        '
        Me.lblPanelname.AutoSize = True
        Me.lblPanelname.BackColor = System.Drawing.Color.Transparent
        Me.lblPanelname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelname.ForeColor = System.Drawing.Color.Black
        Me.lblPanelname.Location = New System.Drawing.Point(233, 23)
        Me.lblPanelname.Name = "lblPanelname"
        Me.lblPanelname.Size = New System.Drawing.Size(132, 25)
        Me.lblPanelname.TabIndex = 10
        Me.lblPanelname.Text = "PanelName"
        Me.lblPanelname.Visible = False
        '
        'pnlViewSubadmin
        '
        Me.pnlViewSubadmin.BackColor = System.Drawing.Color.White
        Me.pnlViewSubadmin.Controls.Add(Me.btnPrintSub)
        Me.pnlViewSubadmin.Controls.Add(Me.btnAddSub)
        Me.pnlViewSubadmin.Controls.Add(Me.btnFilterSub)
        Me.pnlViewSubadmin.Controls.Add(Me.txtFilterSub)
        Me.pnlViewSubadmin.Controls.Add(Me.cboFilterSub)
        Me.pnlViewSubadmin.Controls.Add(Me.dtgListSubadmin)
        Me.pnlViewSubadmin.Location = New System.Drawing.Point(875, 496)
        Me.pnlViewSubadmin.Name = "pnlViewSubadmin"
        Me.pnlViewSubadmin.Size = New System.Drawing.Size(728, 497)
        Me.pnlViewSubadmin.TabIndex = 11
        Me.pnlViewSubadmin.Visible = False
        '
        'btnPrintSub
        '
        Me.btnPrintSub.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnPrintSub.ForeColor = System.Drawing.Color.White
        Me.btnPrintSub.Location = New System.Drawing.Point(550, 461)
        Me.btnPrintSub.Name = "btnPrintSub"
        Me.btnPrintSub.Size = New System.Drawing.Size(75, 26)
        Me.btnPrintSub.TabIndex = 5
        Me.btnPrintSub.Text = "Print"
        Me.btnPrintSub.UseVisualStyleBackColor = False
        '
        'btnAddSub
        '
        Me.btnAddSub.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddSub.ForeColor = System.Drawing.Color.White
        Me.btnAddSub.Location = New System.Drawing.Point(631, 461)
        Me.btnAddSub.Name = "btnAddSub"
        Me.btnAddSub.Size = New System.Drawing.Size(75, 26)
        Me.btnAddSub.TabIndex = 4
        Me.btnAddSub.Text = "Add New"
        Me.btnAddSub.UseVisualStyleBackColor = False
        '
        'btnFilterSub
        '
        Me.btnFilterSub.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnFilterSub.ForeColor = System.Drawing.Color.White
        Me.btnFilterSub.Location = New System.Drawing.Point(631, 43)
        Me.btnFilterSub.Name = "btnFilterSub"
        Me.btnFilterSub.Size = New System.Drawing.Size(75, 23)
        Me.btnFilterSub.TabIndex = 3
        Me.btnFilterSub.Text = "Filter"
        Me.btnFilterSub.UseVisualStyleBackColor = False
        '
        'txtFilterSub
        '
        Me.txtFilterSub.Location = New System.Drawing.Point(32, 43)
        Me.txtFilterSub.Name = "txtFilterSub"
        Me.txtFilterSub.Size = New System.Drawing.Size(466, 20)
        Me.txtFilterSub.TabIndex = 2
        '
        'cboFilterSub
        '
        Me.cboFilterSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterSub.FormattingEnabled = True
        Me.cboFilterSub.Items.AddRange(New Object() {"FirstName", "LastName", "Number", "Position", "Gender", "Email"})
        Me.cboFilterSub.Location = New System.Drawing.Point(504, 43)
        Me.cboFilterSub.Name = "cboFilterSub"
        Me.cboFilterSub.Size = New System.Drawing.Size(121, 21)
        Me.cboFilterSub.TabIndex = 1
        '
        'dtgListSubadmin
        '
        Me.dtgListSubadmin.BackgroundColor = System.Drawing.Color.White
        Me.dtgListSubadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListSubadmin.Location = New System.Drawing.Point(32, 83)
        Me.dtgListSubadmin.Name = "dtgListSubadmin"
        Me.dtgListSubadmin.Size = New System.Drawing.Size(674, 371)
        Me.dtgListSubadmin.TabIndex = 0
        '
        'pnlViewStudent
        '
        Me.pnlViewStudent.BackColor = System.Drawing.Color.White
        Me.pnlViewStudent.Controls.Add(Me.btnPrintStudent)
        Me.pnlViewStudent.Controls.Add(Me.btnAddStudent)
        Me.pnlViewStudent.Controls.Add(Me.btnFilterStudent)
        Me.pnlViewStudent.Controls.Add(Me.txtFilterStudent)
        Me.pnlViewStudent.Controls.Add(Me.cboFilterStudent)
        Me.pnlViewStudent.Controls.Add(Me.dtgStudent)
        Me.pnlViewStudent.Location = New System.Drawing.Point(787, 533)
        Me.pnlViewStudent.Name = "pnlViewStudent"
        Me.pnlViewStudent.Size = New System.Drawing.Size(728, 497)
        Me.pnlViewStudent.TabIndex = 12
        Me.pnlViewStudent.Visible = False
        '
        'btnPrintStudent
        '
        Me.btnPrintStudent.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnPrintStudent.ForeColor = System.Drawing.Color.White
        Me.btnPrintStudent.Location = New System.Drawing.Point(631, 458)
        Me.btnPrintStudent.Name = "btnPrintStudent"
        Me.btnPrintStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintStudent.TabIndex = 5
        Me.btnPrintStudent.Text = "Print"
        Me.btnPrintStudent.UseVisualStyleBackColor = False
        '
        'btnAddStudent
        '
        Me.btnAddStudent.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddStudent.ForeColor = System.Drawing.Color.White
        Me.btnAddStudent.Location = New System.Drawing.Point(550, 457)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnAddStudent.TabIndex = 4
        Me.btnAddStudent.Text = "Add New"
        Me.btnAddStudent.UseVisualStyleBackColor = False
        '
        'btnFilterStudent
        '
        Me.btnFilterStudent.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnFilterStudent.ForeColor = System.Drawing.Color.White
        Me.btnFilterStudent.Location = New System.Drawing.Point(631, 43)
        Me.btnFilterStudent.Name = "btnFilterStudent"
        Me.btnFilterStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnFilterStudent.TabIndex = 3
        Me.btnFilterStudent.Text = "Filter"
        Me.btnFilterStudent.UseVisualStyleBackColor = False
        '
        'txtFilterStudent
        '
        Me.txtFilterStudent.Location = New System.Drawing.Point(32, 43)
        Me.txtFilterStudent.Name = "txtFilterStudent"
        Me.txtFilterStudent.Size = New System.Drawing.Size(466, 20)
        Me.txtFilterStudent.TabIndex = 2
        '
        'cboFilterStudent
        '
        Me.cboFilterStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterStudent.FormattingEnabled = True
        Me.cboFilterStudent.Items.AddRange(New Object() {"FirstName", "LastName", "Number", "StudentNumber", "Status", "Course", "Gender", "Email"})
        Me.cboFilterStudent.Location = New System.Drawing.Point(504, 43)
        Me.cboFilterStudent.Name = "cboFilterStudent"
        Me.cboFilterStudent.Size = New System.Drawing.Size(121, 21)
        Me.cboFilterStudent.TabIndex = 1
        '
        'dtgStudent
        '
        Me.dtgStudent.AllowUserToAddRows = False
        Me.dtgStudent.AllowUserToDeleteRows = False
        Me.dtgStudent.BackgroundColor = System.Drawing.Color.White
        Me.dtgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgStudent.Location = New System.Drawing.Point(32, 83)
        Me.dtgStudent.Name = "dtgStudent"
        Me.dtgStudent.Size = New System.Drawing.Size(674, 371)
        Me.dtgStudent.TabIndex = 0
        '
        'pnlSettings
        '
        Me.pnlSettings.BackColor = System.Drawing.Color.White
        Me.pnlSettings.Controls.Add(Me.gpbGeneratecode)
        Me.pnlSettings.Controls.Add(Me.GroupBox1)
        Me.pnlSettings.Location = New System.Drawing.Point(225, 19)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(728, 497)
        Me.pnlSettings.TabIndex = 13
        Me.pnlSettings.Visible = False
        '
        'gpbGeneratecode
        '
        Me.gpbGeneratecode.Controls.Add(Me.btnCopy)
        Me.gpbGeneratecode.Controls.Add(Me.btnUpdateCode)
        Me.gpbGeneratecode.Controls.Add(Me.btnGenerateCode)
        Me.gpbGeneratecode.Controls.Add(Me.txtCode)
        Me.gpbGeneratecode.Controls.Add(Me.Label4)
        Me.gpbGeneratecode.Location = New System.Drawing.Point(30, 270)
        Me.gpbGeneratecode.Name = "gpbGeneratecode"
        Me.gpbGeneratecode.Size = New System.Drawing.Size(662, 112)
        Me.gpbGeneratecode.TabIndex = 1
        Me.gpbGeneratecode.TabStop = False
        Me.gpbGeneratecode.Text = "Generate New Code"
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCopy.ForeColor = System.Drawing.Color.White
        Me.btnCopy.Location = New System.Drawing.Point(171, 72)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 11
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'btnUpdateCode
        '
        Me.btnUpdateCode.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnUpdateCode.ForeColor = System.Drawing.Color.White
        Me.btnUpdateCode.Location = New System.Drawing.Point(354, 83)
        Me.btnUpdateCode.Name = "btnUpdateCode"
        Me.btnUpdateCode.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateCode.TabIndex = 10
        Me.btnUpdateCode.Text = "Update"
        Me.btnUpdateCode.UseVisualStyleBackColor = False
        '
        'btnGenerateCode
        '
        Me.btnGenerateCode.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnGenerateCode.ForeColor = System.Drawing.Color.White
        Me.btnGenerateCode.Location = New System.Drawing.Point(354, 46)
        Me.btnGenerateCode.Name = "btnGenerateCode"
        Me.btnGenerateCode.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerateCode.TabIndex = 9
        Me.btnGenerateCode.Text = "Generate"
        Me.btnGenerateCode.UseVisualStyleBackColor = False
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(171, 46)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(177, 20)
        Me.txtCode.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Code"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpdateCredentials)
        Me.GroupBox1.Controls.Add(Me.txtReEnterPassword)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNewPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOldPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(137, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 194)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Credentials"
        '
        'btnUpdateCredentials
        '
        Me.btnUpdateCredentials.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnUpdateCredentials.ForeColor = System.Drawing.Color.White
        Me.btnUpdateCredentials.Location = New System.Drawing.Point(110, 153)
        Me.btnUpdateCredentials.Name = "btnUpdateCredentials"
        Me.btnUpdateCredentials.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateCredentials.TabIndex = 8
        Me.btnUpdateCredentials.Text = "Update"
        Me.btnUpdateCredentials.UseVisualStyleBackColor = False
        '
        'txtReEnterPassword
        '
        Me.txtReEnterPassword.Location = New System.Drawing.Point(291, 156)
        Me.txtReEnterPassword.Name = "txtReEnterPassword"
        Me.txtReEnterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtReEnterPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtReEnterPassword.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Re-Enter Password"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(291, 99)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPassword.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "New Password"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Enabled = False
        Me.txtOldPassword.Location = New System.Drawing.Point(291, 49)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtOldPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(288, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Old Password"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(84, 49)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UserName"
        '
        'pnlProfileInformation
        '
        Me.pnlProfileInformation.BackColor = System.Drawing.Color.White
        Me.pnlProfileInformation.Controls.Add(Me.GroupBox4)
        Me.pnlProfileInformation.Location = New System.Drawing.Point(735, 552)
        Me.pnlProfileInformation.Name = "pnlProfileInformation"
        Me.pnlProfileInformation.Size = New System.Drawing.Size(728, 497)
        Me.pnlProfileInformation.TabIndex = 14
        Me.pnlProfileInformation.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboGenderProfile)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtNumberProfile)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.btnProfile)
        Me.GroupBox4.Controls.Add(Me.txtEmailProfile)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtMiddleNameProfile)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtLastNameProfile)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtFirstNameProfile)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(30, 54)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(650, 375)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Profile Information"
        '
        'cboGenderProfile
        '
        Me.cboGenderProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGenderProfile.FormattingEnabled = True
        Me.cboGenderProfile.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGenderProfile.Location = New System.Drawing.Point(447, 216)
        Me.cboGenderProfile.Name = "cboGenderProfile"
        Me.cboGenderProfile.Size = New System.Drawing.Size(140, 21)
        Me.cboGenderProfile.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(444, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Gender"
        '
        'txtNumberProfile
        '
        Me.txtNumberProfile.Location = New System.Drawing.Point(110, 212)
        Me.txtNumberProfile.Name = "txtNumberProfile"
        Me.txtNumberProfile.Size = New System.Drawing.Size(140, 20)
        Me.txtNumberProfile.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(107, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Phone Number"
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnProfile.ForeColor = System.Drawing.Color.White
        Me.btnProfile.Location = New System.Drawing.Point(512, 297)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(75, 31)
        Me.btnProfile.TabIndex = 8
        Me.btnProfile.Text = "Update"
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'txtEmailProfile
        '
        Me.txtEmailProfile.Location = New System.Drawing.Point(274, 212)
        Me.txtEmailProfile.Name = "txtEmailProfile"
        Me.txtEmailProfile.Size = New System.Drawing.Size(140, 20)
        Me.txtEmailProfile.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(271, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Email"
        '
        'txtMiddleNameProfile
        '
        Me.txtMiddleNameProfile.Location = New System.Drawing.Point(274, 137)
        Me.txtMiddleNameProfile.Name = "txtMiddleNameProfile"
        Me.txtMiddleNameProfile.Size = New System.Drawing.Size(140, 20)
        Me.txtMiddleNameProfile.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(276, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Middle Name"
        '
        'txtLastNameProfile
        '
        Me.txtLastNameProfile.Enabled = False
        Me.txtLastNameProfile.Location = New System.Drawing.Point(447, 137)
        Me.txtLastNameProfile.Name = "txtLastNameProfile"
        Me.txtLastNameProfile.Size = New System.Drawing.Size(140, 20)
        Me.txtLastNameProfile.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(444, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Last Name"
        '
        'txtFirstNameProfile
        '
        Me.txtFirstNameProfile.Location = New System.Drawing.Point(110, 137)
        Me.txtFirstNameProfile.Name = "txtFirstNameProfile"
        Me.txtFirstNameProfile.Size = New System.Drawing.Size(140, 20)
        Me.txtFirstNameProfile.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(107, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "First Name"
        '
        'pnlPendingStudents
        '
        Me.pnlPendingStudents.BackColor = System.Drawing.Color.White
        Me.pnlPendingStudents.Controls.Add(Me.btnPrinfPending)
        Me.pnlPendingStudents.Controls.Add(Me.btnFilterPending)
        Me.pnlPendingStudents.Controls.Add(Me.txtFilterPending)
        Me.pnlPendingStudents.Controls.Add(Me.cboFilterPending)
        Me.pnlPendingStudents.Controls.Add(Me.dtgStudentPending)
        Me.pnlPendingStudents.Location = New System.Drawing.Point(956, 399)
        Me.pnlPendingStudents.Name = "pnlPendingStudents"
        Me.pnlPendingStudents.Size = New System.Drawing.Size(728, 497)
        Me.pnlPendingStudents.TabIndex = 15
        Me.pnlPendingStudents.Visible = False
        '
        'btnPrinfPending
        '
        Me.btnPrinfPending.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnPrinfPending.ForeColor = System.Drawing.Color.White
        Me.btnPrinfPending.Location = New System.Drawing.Point(631, 462)
        Me.btnPrinfPending.Name = "btnPrinfPending"
        Me.btnPrinfPending.Size = New System.Drawing.Size(75, 23)
        Me.btnPrinfPending.TabIndex = 5
        Me.btnPrinfPending.Text = "Print"
        Me.btnPrinfPending.UseVisualStyleBackColor = False
        '
        'btnFilterPending
        '
        Me.btnFilterPending.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnFilterPending.ForeColor = System.Drawing.Color.White
        Me.btnFilterPending.Location = New System.Drawing.Point(631, 43)
        Me.btnFilterPending.Name = "btnFilterPending"
        Me.btnFilterPending.Size = New System.Drawing.Size(75, 23)
        Me.btnFilterPending.TabIndex = 3
        Me.btnFilterPending.Text = "Filter"
        Me.btnFilterPending.UseVisualStyleBackColor = False
        '
        'txtFilterPending
        '
        Me.txtFilterPending.Location = New System.Drawing.Point(32, 43)
        Me.txtFilterPending.Name = "txtFilterPending"
        Me.txtFilterPending.Size = New System.Drawing.Size(466, 20)
        Me.txtFilterPending.TabIndex = 2
        '
        'cboFilterPending
        '
        Me.cboFilterPending.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterPending.FormattingEnabled = True
        Me.cboFilterPending.Items.AddRange(New Object() {"FirstName", "LastName", "Number", "StudentNumber", "Status", "Course", "Gender", "Email"})
        Me.cboFilterPending.Location = New System.Drawing.Point(504, 43)
        Me.cboFilterPending.Name = "cboFilterPending"
        Me.cboFilterPending.Size = New System.Drawing.Size(121, 21)
        Me.cboFilterPending.TabIndex = 1
        '
        'dtgStudentPending
        '
        Me.dtgStudentPending.AllowUserToAddRows = False
        Me.dtgStudentPending.AllowUserToDeleteRows = False
        Me.dtgStudentPending.BackgroundColor = System.Drawing.Color.White
        Me.dtgStudentPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgStudentPending.Location = New System.Drawing.Point(32, 83)
        Me.dtgStudentPending.Name = "dtgStudentPending"
        Me.dtgStudentPending.Size = New System.Drawing.Size(674, 371)
        Me.dtgStudentPending.TabIndex = 0
        '
        'btnStudentCount
        '
        Me.btnStudentCount.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnStudentCount.BackgroundImage = CType(resources.GetObject("btnStudentCount.BackgroundImage"), System.Drawing.Image)
        Me.btnStudentCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStudentCount.ForeColor = System.Drawing.Color.White
        Me.btnStudentCount.Location = New System.Drawing.Point(51, 86)
        Me.btnStudentCount.Name = "btnStudentCount"
        Me.btnStudentCount.Size = New System.Drawing.Size(181, 125)
        Me.btnStudentCount.TabIndex = 16
        Me.btnStudentCount.Text = "Student"
        Me.btnStudentCount.UseVisualStyleBackColor = False
        '
        'btnSubadminCount
        '
        Me.btnSubadminCount.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSubadminCount.ForeColor = System.Drawing.Color.White
        Me.btnSubadminCount.Location = New System.Drawing.Point(510, 85)
        Me.btnSubadminCount.Name = "btnSubadminCount"
        Me.btnSubadminCount.Size = New System.Drawing.Size(181, 125)
        Me.btnSubadminCount.TabIndex = 17
        Me.btnSubadminCount.Text = "Sub Admin"
        Me.btnSubadminCount.UseVisualStyleBackColor = False
        '
        'btnRecordCount
        '
        Me.btnRecordCount.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRecordCount.ForeColor = System.Drawing.Color.White
        Me.btnRecordCount.Location = New System.Drawing.Point(285, 86)
        Me.btnRecordCount.Name = "btnRecordCount"
        Me.btnRecordCount.Size = New System.Drawing.Size(181, 125)
        Me.btnRecordCount.TabIndex = 18
        Me.btnRecordCount.Text = "Record"
        Me.btnRecordCount.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        Me.Chart1.BorderlineColor = System.Drawing.Color.Black
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(51, 217)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(641, 251)
        Me.Chart1.TabIndex = 19
        Me.Chart1.Text = "Chart1"
        '
        'pnlDashboard
        '
        Me.pnlDashboard.BackColor = System.Drawing.Color.White
        Me.pnlDashboard.Controls.Add(Me.PictureBox4)
        Me.pnlDashboard.Controls.Add(Me.ptbimageprofilesubadmin)
        Me.pnlDashboard.Controls.Add(Me.PictureBox2)
        Me.pnlDashboard.Controls.Add(Me.Chart1)
        Me.pnlDashboard.Controls.Add(Me.btnSubadminCount)
        Me.pnlDashboard.Controls.Add(Me.btnRecordCount)
        Me.pnlDashboard.Controls.Add(Me.btnStudentCount)
        Me.pnlDashboard.Location = New System.Drawing.Point(222, 65)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(728, 497)
        Me.pnlDashboard.TabIndex = 20
        Me.pnlDashboard.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(299, 129)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(45, 36)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'ptbimageprofilesubadmin
        '
        Me.ptbimageprofilesubadmin.BackColor = System.Drawing.Color.White
        Me.ptbimageprofilesubadmin.Image = CType(resources.GetObject("ptbimageprofilesubadmin.Image"), System.Drawing.Image)
        Me.ptbimageprofilesubadmin.Location = New System.Drawing.Point(520, 128)
        Me.ptbimageprofilesubadmin.Name = "ptbimageprofilesubadmin"
        Me.ptbimageprofilesubadmin.Size = New System.Drawing.Size(45, 36)
        Me.ptbimageprofilesubadmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbimageprofilesubadmin.TabIndex = 20
        Me.ptbimageprofilesubadmin.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(66, 129)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'DashBoardAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(975, 571)
        Me.Controls.Add(Me.pnlPendingStudents)
        Me.Controls.Add(Me.pnlProfileInformation)
        Me.Controls.Add(Me.pnlSettings)
        Me.Controls.Add(Me.pnlViewSubadmin)
        Me.Controls.Add(Me.pnlViewStudent)
        Me.Controls.Add(Me.lblPanelname)
        Me.Controls.Add(Me.pnlViewRecord)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DashBoardAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashBoardAdmin"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlViewRecord.ResumeLayout(False)
        Me.pnlViewRecord.PerformLayout()
        CType(Me.dtgViewRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlViewSubadmin.ResumeLayout(False)
        Me.pnlViewSubadmin.PerformLayout()
        CType(Me.dtgListSubadmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlViewStudent.ResumeLayout(False)
        Me.pnlViewStudent.PerformLayout()
        CType(Me.dtgStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSettings.ResumeLayout(False)
        Me.gpbGeneratecode.ResumeLayout(False)
        Me.gpbGeneratecode.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlProfileInformation.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.pnlPendingStudents.ResumeLayout(False)
        Me.pnlPendingStudents.PerformLayout()
        CType(Me.dtgStudentPending, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDashboard.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbimageprofilesubadmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnViewStudent2 As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnViewSubAdmin2 As Button
    Friend WithEvents btnViewRecord2 As Button
    Friend WithEvents pnlViewRecord As Panel
    Friend WithEvents dtgViewRecord As DataGridView
    Friend WithEvents btnFilterRecord As Button
    Friend WithEvents txtFilterRecord As TextBox
    Friend WithEvents cboFilterRecord As ComboBox
    Friend WithEvents lblPanelname As Label
    Friend WithEvents btnPrintRecord As Button
    Friend WithEvents pnlViewSubadmin As Panel
    Friend WithEvents btnPrintSub As Button
    Friend WithEvents btnAddSub As Button
    Friend WithEvents btnFilterSub As Button
    Friend WithEvents txtFilterSub As TextBox
    Friend WithEvents cboFilterSub As ComboBox
    Friend WithEvents dtgListSubadmin As DataGridView
    Friend WithEvents pnlViewStudent As Panel
    Friend WithEvents btnPrintStudent As Button
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnFilterStudent As Button
    Friend WithEvents txtFilterStudent As TextBox
    Friend WithEvents cboFilterStudent As ComboBox
    Friend WithEvents dtgStudent As DataGridView
    Friend WithEvents btnHome As Button
    Friend WithEvents dtpRecord As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents pnlSettings As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gpbGeneratecode As GroupBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtReEnterPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOldPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdateCode As Button
    Friend WithEvents btnGenerateCode As Button
    Friend WithEvents btnUpdateCredentials As Button
    Friend WithEvents pnlProfileInformation As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtNumberProfile As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnProfile As Button
    Friend WithEvents txtEmailProfile As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMiddleNameProfile As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLastNameProfile As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFirstNameProfile As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cboGenderProfile As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlPendingStudents As Panel
    Friend WithEvents btnPrinfPending As Button
    Friend WithEvents btnFilterPending As Button
    Friend WithEvents txtFilterPending As TextBox
    Friend WithEvents cboFilterPending As ComboBox
    Friend WithEvents dtgStudentPending As DataGridView
    Friend WithEvents btnStudentCount As Button
    Friend WithEvents btnSubadminCount As Button
    Friend WithEvents btnRecordCount As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ptbimageprofilesubadmin As PictureBox
    Friend WithEvents btnCopy As Button
End Class

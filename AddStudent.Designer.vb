<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStudent))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtfName = New System.Windows.Forms.TextBox()
        Me.txtmName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtlName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtstudentNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtstudentEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtstudentMobile = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ptbStudent = New System.Windows.Forms.PictureBox()
        Me.btnImage = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnScanRfid = New System.Windows.Forms.Button()
        Me.txtFnameP1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMnameP1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLnameP1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMobileP1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEmailP1 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboGenderParent = New System.Windows.Forms.ComboBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboStudentStat = New System.Windows.Forms.ComboBox()
        Me.lblRfid = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.ptbStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name*"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(893, 476)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 45)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtfName
        '
        Me.txtfName.Enabled = False
        Me.txtfName.Location = New System.Drawing.Point(31, 68)
        Me.txtfName.Name = "txtfName"
        Me.txtfName.Size = New System.Drawing.Size(142, 20)
        Me.txtfName.TabIndex = 2
        '
        'txtmName
        '
        Me.txtmName.Enabled = False
        Me.txtmName.Location = New System.Drawing.Point(207, 68)
        Me.txtmName.Name = "txtmName"
        Me.txtmName.Size = New System.Drawing.Size(142, 20)
        Me.txtmName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Middle Name*"
        '
        'txtlName
        '
        Me.txtlName.Enabled = False
        Me.txtlName.Location = New System.Drawing.Point(387, 68)
        Me.txtlName.Name = "txtlName"
        Me.txtlName.Size = New System.Drawing.Size(142, 20)
        Me.txtlName.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(389, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name*"
        '
        'txtstudentNumber
        '
        Me.txtstudentNumber.Enabled = False
        Me.txtstudentNumber.Location = New System.Drawing.Point(387, 128)
        Me.txtstudentNumber.Name = "txtstudentNumber"
        Me.txtstudentNumber.Size = New System.Drawing.Size(142, 20)
        Me.txtstudentNumber.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(389, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Student#(19-xxxxxx)"
        '
        'txtstudentEmail
        '
        Me.txtstudentEmail.Enabled = False
        Me.txtstudentEmail.Location = New System.Drawing.Point(31, 128)
        Me.txtstudentEmail.Name = "txtstudentEmail"
        Me.txtstudentEmail.Size = New System.Drawing.Size(142, 20)
        Me.txtstudentEmail.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Email(Ex.Jayson@gmail.com)"
        '
        'txtstudentMobile
        '
        Me.txtstudentMobile.Enabled = False
        Me.txtstudentMobile.Location = New System.Drawing.Point(207, 128)
        Me.txtstudentMobile.Name = "txtstudentMobile"
        Me.txtstudentMobile.Size = New System.Drawing.Size(142, 20)
        Me.txtstudentMobile.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(209, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Number(Ex.09xxxxxxxx)"
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Enabled = False
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(202, 192)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(121, 21)
        Me.cboGender.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(204, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Gender"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(690, 475)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(96, 45)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSave.Enabled = False
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(791, 476)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 45)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'ptbStudent
        '
        Me.ptbStudent.BackColor = System.Drawing.Color.White
        Me.ptbStudent.Location = New System.Drawing.Point(790, 49)
        Me.ptbStudent.Name = "ptbStudent"
        Me.ptbStudent.Size = New System.Drawing.Size(194, 163)
        Me.ptbStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbStudent.TabIndex = 18
        Me.ptbStudent.TabStop = False
        '
        'btnImage
        '
        Me.btnImage.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnImage.Enabled = False
        Me.btnImage.ForeColor = System.Drawing.Color.White
        Me.btnImage.Location = New System.Drawing.Point(790, 212)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(194, 41)
        Me.btnImage.TabIndex = 19
        Me.btnImage.Text = "Image"
        Me.btnImage.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(577, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Year"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 177)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Course"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(52, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(227, 25)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Student Registration"
        '
        'btnScanRfid
        '
        Me.btnScanRfid.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnScanRfid.Enabled = False
        Me.btnScanRfid.ForeColor = System.Drawing.Color.White
        Me.btnScanRfid.Location = New System.Drawing.Point(847, 337)
        Me.btnScanRfid.Name = "btnScanRfid"
        Me.btnScanRfid.Size = New System.Drawing.Size(91, 69)
        Me.btnScanRfid.TabIndex = 27
        Me.btnScanRfid.Text = "Scan RFID*"
        Me.btnScanRfid.UseVisualStyleBackColor = False
        '
        'txtFnameP1
        '
        Me.txtFnameP1.Enabled = False
        Me.txtFnameP1.Location = New System.Drawing.Point(110, 59)
        Me.txtFnameP1.Name = "txtFnameP1"
        Me.txtFnameP1.Size = New System.Drawing.Size(142, 20)
        Me.txtFnameP1.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(112, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "First Name*"
        '
        'txtMnameP1
        '
        Me.txtMnameP1.Enabled = False
        Me.txtMnameP1.Location = New System.Drawing.Point(296, 59)
        Me.txtMnameP1.Name = "txtMnameP1"
        Me.txtMnameP1.Size = New System.Drawing.Size(142, 20)
        Me.txtMnameP1.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(303, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Middle Name*"
        '
        'txtLnameP1
        '
        Me.txtLnameP1.Enabled = False
        Me.txtLnameP1.Location = New System.Drawing.Point(464, 59)
        Me.txtLnameP1.Name = "txtLnameP1"
        Me.txtLnameP1.Size = New System.Drawing.Size(142, 20)
        Me.txtLnameP1.TabIndex = 35
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(466, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Last Name*"
        '
        'txtMobileP1
        '
        Me.txtMobileP1.Enabled = False
        Me.txtMobileP1.Location = New System.Drawing.Point(464, 126)
        Me.txtMobileP1.Name = "txtMobileP1"
        Me.txtMobileP1.Size = New System.Drawing.Size(142, 20)
        Me.txtMobileP1.TabIndex = 45
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(466, 109)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(125, 13)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = " Number(Ex.09xxxxxxxxx)"
        '
        'txtEmailP1
        '
        Me.txtEmailP1.Enabled = False
        Me.txtEmailP1.Location = New System.Drawing.Point(296, 126)
        Me.txtEmailP1.Name = "txtEmailP1"
        Me.txtEmailP1.Size = New System.Drawing.Size(142, 20)
        Me.txtEmailP1.TabIndex = 43
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(296, 109)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(144, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Email(Ex.Jayson@gmail.com)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboGenderParent)
        Me.GroupBox1.Controls.Add(Me.txtEmailP1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtMobileP1)
        Me.GroupBox1.Controls.Add(Me.txtFnameP1)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtMnameP1)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtLnameP1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(746, 170)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parent Information*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Gender"
        '
        'cboGenderParent
        '
        Me.cboGenderParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGenderParent.Enabled = False
        Me.cboGenderParent.FormattingEnabled = True
        Me.cboGenderParent.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGenderParent.Location = New System.Drawing.Point(110, 125)
        Me.cboGenderParent.Name = "cboGenderParent"
        Me.cboGenderParent.Size = New System.Drawing.Size(121, 21)
        Me.cboGenderParent.TabIndex = 46
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.Enabled = False
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"4th", "3rd", "2nd", "1st"})
        Me.cboYear.Location = New System.Drawing.Point(575, 128)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(121, 21)
        Me.cboYear.TabIndex = 51
        '
        'txtCourse
        '
        Me.txtCourse.Enabled = False
        Me.txtCourse.Location = New System.Drawing.Point(31, 191)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(142, 20)
        Me.txtCourse.TabIndex = 53
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cboStudentStat)
        Me.GroupBox2.Controls.Add(Me.txtCourse)
        Me.GroupBox2.Controls.Add(Me.cboGender)
        Me.GroupBox2.Controls.Add(Me.cboYear)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtfName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtmName)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtlName)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtstudentNumber)
        Me.GroupBox2.Controls.Add(Me.txtstudentMobile)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtstudentEmail)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(746, 228)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Information"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(583, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 13)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Student Status"
        '
        'cboStudentStat
        '
        Me.cboStudentStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStudentStat.Enabled = False
        Me.cboStudentStat.FormattingEnabled = True
        Me.cboStudentStat.Items.AddRange(New Object() {"Regular", "Irregular"})
        Me.cboStudentStat.Location = New System.Drawing.Point(575, 68)
        Me.cboStudentStat.Name = "cboStudentStat"
        Me.cboStudentStat.Size = New System.Drawing.Size(121, 21)
        Me.cboStudentStat.TabIndex = 54
        '
        'lblRfid
        '
        Me.lblRfid.AutoSize = True
        Me.lblRfid.Location = New System.Drawing.Point(847, 420)
        Me.lblRfid.Name = "lblRfid"
        Me.lblRfid.Size = New System.Drawing.Size(36, 13)
        Me.lblRfid.TabIndex = 55
        Me.lblRfid.Text = "no rfid"
        Me.lblRfid.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(587, 475)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 45)
        Me.btnDelete.TabIndex = 56
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'AddStudent
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1007, 530)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblRfid)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnScanRfid)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnImage)
        Me.Controls.Add(Me.ptbStudent)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddStudent"
        CType(Me.ptbStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents txtfName As TextBox
    Friend WithEvents txtmName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtlName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtstudentNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtstudentEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtstudentMobile As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ptbStudent As PictureBox
    Friend WithEvents btnImage As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents btnScanRfid As Button
    Friend WithEvents txtFnameP1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMnameP1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtLnameP1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtMobileP1 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtEmailP1 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboGenderParent As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cboStudentStat As ComboBox
    Friend WithEvents lblRfid As Label
    Friend WithEvents btnDelete As Button
End Class

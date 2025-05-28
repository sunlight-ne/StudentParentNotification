<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentInAndOut
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentInAndOut))
        Me.txtrfid = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.dtgListRecord = New System.Windows.Forms.DataGridView()
        Me.ptbProfile = New System.Windows.Forms.PictureBox()
        Me.btnrfid = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.lblstudentname = New System.Windows.Forms.Label()
        CType(Me.dtgListRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtrfid
        '
        Me.txtrfid.Location = New System.Drawing.Point(292, 253)
        Me.txtrfid.Name = "txtrfid"
        Me.txtrfid.Size = New System.Drawing.Size(100, 20)
        Me.txtrfid.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(964, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(88, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Go to Dashboard"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(1080, 9)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(24, 13)
        Me.LinkLabel2.TabIndex = 5
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Exit"
        '
        'dtgListRecord
        '
        Me.dtgListRecord.AllowUserToAddRows = False
        Me.dtgListRecord.AllowUserToDeleteRows = False
        Me.dtgListRecord.AllowUserToResizeRows = False
        Me.dtgListRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgListRecord.BackgroundColor = System.Drawing.Color.White
        Me.dtgListRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListRecord.Location = New System.Drawing.Point(597, 33)
        Me.dtgListRecord.Name = "dtgListRecord"
        Me.dtgListRecord.ReadOnly = True
        Me.dtgListRecord.Size = New System.Drawing.Size(512, 569)
        Me.dtgListRecord.TabIndex = 8
        '
        'ptbProfile
        '
        Me.ptbProfile.BackColor = System.Drawing.Color.LightGray
        Me.ptbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbProfile.Location = New System.Drawing.Point(31, 33)
        Me.ptbProfile.Name = "ptbProfile"
        Me.ptbProfile.Size = New System.Drawing.Size(503, 412)
        Me.ptbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbProfile.TabIndex = 0
        Me.ptbProfile.TabStop = False
        Me.ptbProfile.Tag = "No Image"
        '
        'btnrfid
        '
        Me.btnrfid.Location = New System.Drawing.Point(307, 279)
        Me.btnrfid.Name = "btnrfid"
        Me.btnrfid.Size = New System.Drawing.Size(75, 23)
        Me.btnrfid.TabIndex = 9
        Me.btnrfid.Text = "Scan"
        Me.btnrfid.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(222, 491)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 93)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "No Image"
        '
        'timer
        '
        '
        'lblstudentname
        '
        Me.lblstudentname.AutoSize = True
        Me.lblstudentname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstudentname.Location = New System.Drawing.Point(32, 5)
        Me.lblstudentname.Name = "lblstudentname"
        Me.lblstudentname.Size = New System.Drawing.Size(167, 25)
        Me.lblstudentname.TabIndex = 11
        Me.lblstudentname.Text = "Student Name "
        Me.lblstudentname.Visible = False
        '
        'StudentInAndOut
        '
        Me.AcceptButton = Me.btnrfid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1121, 614)
        Me.Controls.Add(Me.lblstudentname)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ptbProfile)
        Me.Controls.Add(Me.btnrfid)
        Me.Controls.Add(Me.txtrfid)
        Me.Controls.Add(Me.dtgListRecord)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StudentInAndOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentInAndOut"
        CType(Me.dtgListRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtrfid As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents dtgListRecord As DataGridView
    Friend WithEvents ptbProfile As PictureBox
    Friend WithEvents btnrfid As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents timer As Timer
    Friend WithEvents lblstudentname As Label
End Class

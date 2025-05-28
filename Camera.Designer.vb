<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Camera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Camera))
        Me.btnCaptured = New System.Windows.Forms.Button()
        Me.ptbCamera = New System.Windows.Forms.PictureBox()
        CType(Me.ptbCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCaptured
        '
        Me.btnCaptured.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCaptured.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaptured.ForeColor = System.Drawing.Color.White
        Me.btnCaptured.Location = New System.Drawing.Point(214, 329)
        Me.btnCaptured.Name = "btnCaptured"
        Me.btnCaptured.Size = New System.Drawing.Size(130, 53)
        Me.btnCaptured.TabIndex = 0
        Me.btnCaptured.Text = "Capture"
        Me.btnCaptured.UseVisualStyleBackColor = False
        '
        'ptbCamera
        '
        Me.ptbCamera.BackColor = System.Drawing.Color.White
        Me.ptbCamera.Location = New System.Drawing.Point(69, 40)
        Me.ptbCamera.Name = "ptbCamera"
        Me.ptbCamera.Size = New System.Drawing.Size(401, 283)
        Me.ptbCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbCamera.TabIndex = 1
        Me.ptbCamera.TabStop = False
        '
        'Camera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(552, 416)
        Me.Controls.Add(Me.ptbCamera)
        Me.Controls.Add(Me.btnCaptured)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Camera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Camera"
        CType(Me.ptbCamera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCaptured As Button
    Friend WithEvents ptbCamera As PictureBox
End Class

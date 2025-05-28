<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewRecord
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
        Me.btnPrintRecord = New System.Windows.Forms.Button()
        Me.btnFilterRecord = New System.Windows.Forms.Button()
        Me.txtFilterRecord = New System.Windows.Forms.TextBox()
        Me.cboFilterRecord = New System.Windows.Forms.ComboBox()
        Me.dtgListRecord = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dtgListRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrintRecord
        '
        Me.btnPrintRecord.Location = New System.Drawing.Point(27, 445)
        Me.btnPrintRecord.Name = "btnPrintRecord"
        Me.btnPrintRecord.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintRecord.TabIndex = 9
        Me.btnPrintRecord.Text = "Print"
        Me.btnPrintRecord.UseVisualStyleBackColor = True
        '
        'btnFilterRecord
        '
        Me.btnFilterRecord.Location = New System.Drawing.Point(626, 28)
        Me.btnFilterRecord.Name = "btnFilterRecord"
        Me.btnFilterRecord.Size = New System.Drawing.Size(75, 23)
        Me.btnFilterRecord.TabIndex = 8
        Me.btnFilterRecord.Text = "Filter"
        Me.btnFilterRecord.UseVisualStyleBackColor = True
        '
        'txtFilterRecord
        '
        Me.txtFilterRecord.Location = New System.Drawing.Point(27, 28)
        Me.txtFilterRecord.Name = "txtFilterRecord"
        Me.txtFilterRecord.Size = New System.Drawing.Size(466, 20)
        Me.txtFilterRecord.TabIndex = 7
        '
        'cboFilterRecord
        '
        Me.cboFilterRecord.FormattingEnabled = True
        Me.cboFilterRecord.Location = New System.Drawing.Point(499, 28)
        Me.cboFilterRecord.Name = "cboFilterRecord"
        Me.cboFilterRecord.Size = New System.Drawing.Size(121, 21)
        Me.cboFilterRecord.TabIndex = 6
        '
        'dtgListRecord
        '
        Me.dtgListRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListRecord.Location = New System.Drawing.Point(27, 68)
        Me.dtgListRecord.Name = "dtgListRecord"
        Me.dtgListRecord.Size = New System.Drawing.Size(674, 371)
        Me.dtgListRecord.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(626, 445)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ViewRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ClientSize = New System.Drawing.Size(728, 497)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrintRecord)
        Me.Controls.Add(Me.btnFilterRecord)
        Me.Controls.Add(Me.txtFilterRecord)
        Me.Controls.Add(Me.cboFilterRecord)
        Me.Controls.Add(Me.dtgListRecord)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ViewRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ViewRecord"
        CType(Me.dtgListRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrintRecord As Button
    Friend WithEvents btnFilterRecord As Button
    Friend WithEvents txtFilterRecord As TextBox
    Friend WithEvents cboFilterRecord As ComboBox
    Friend WithEvents dtgListRecord As DataGridView
    Friend WithEvents btnClose As Button
End Class

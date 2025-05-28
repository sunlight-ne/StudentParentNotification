Public Class ScanRfid
    Private parentForm As AddStudent
    Private Sub ScanRfid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  txtRfid.Focus()

    End Sub
    Private Sub ScanRfid_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtRfid.Focus()
    End Sub



    Public Sub New(parent As AddStudent)
        InitializeComponent()
        parentForm = parent
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        parentForm.rfid = txtRfid.Text
        txtRfid.Clear()
        parentForm.lblnorfid()


        Me.Close()

    End Sub
End Class
Imports System.Configuration
Imports CrystalDecisions.CrystalReports.Engine

Public Class Print
    Private mReportSource As ReportClass

    Private Sub ReprotViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Dim table As DataTable = RegionBusiness.RegionList()
        'Dim rpt As New RegionReport()
        'rpt.SetDataSource(table)
        'CrystalReportViewer1.ReportSource = ReportSource

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub New(report As ReportDocument)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CrystalReportViewer1.ReportSource = report
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class
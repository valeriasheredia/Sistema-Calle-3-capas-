Public Class frmReporte_por_Edad_1

    Public edad1 As Integer
    Public edad2 As Integer

    Private Sub frmReporte_por_Edad_1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim objedad As New Reporte_por_Edad_1
        objedad.SetParameterValue("@edad1", edad1)
        objedad.SetParameterValue("@edad2", edad2)
        CrystalReportViewer1.ReportSource = objedad
    End Sub
End Class
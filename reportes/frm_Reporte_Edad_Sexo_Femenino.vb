Public Class frm_Reporte_Edad_Sexo_Femenino

    Public edadfem1 As Integer
    Public edadfem2 As Integer

    Private Sub frm_Reporte_Edad_Sexo_Femenino_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim objedad As New Reporte_Edad_Sexo_Femenino
        objedad.SetParameterValue("@edadfem1", edadfem1)
        objedad.SetParameterValue("@edadfem2", edadfem2)
        CrystalReportViewer1.ReportSource = objedad
    End Sub
End Class
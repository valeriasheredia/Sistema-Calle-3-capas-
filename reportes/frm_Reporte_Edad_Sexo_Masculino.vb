Public Class frm_Reporte_Edad_Sexo_Masculino
    Public edadmas1 As Integer
    Public edadmas2 As Integer

    Private Sub frm_Reporte_Edad_Sexo_Masculino_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim objedad As New Reporte_Edad_Sexo_Masculino
        objedad.SetParameterValue("@edadmas1", edadmas1)
        objedad.SetParameterValue("@edadmas2", edadmas2)
        CrystalReportViewer1.ReportSource = objedad
    End Sub
End Class
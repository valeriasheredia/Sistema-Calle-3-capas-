Public Class frmImprimir

    Private Sub frmImprimir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboOpcionImpresion.SelectedIndex = 0
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False

    End Sub

    Private Sub btnImprimir_Click_1(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
     
        ' REPORTE GENERAL 
        If cboOpcionImpresion.SelectedIndex = 0 Then
            Dim reportedistancia1 As New frmDistancia1
            reportedistancia1.ShowDialog()
            Exit Sub
        End If

       

        'REPORTE POR SEXO FEMENINO
        If rbtFemenino.Checked = True Then
            Dim ReporteSexoFem1 As New frmSexo_Fem1
            'ReporteSexoFem1.sexofem = s1
            ReporteSexoFem1.ShowDialog()
            ' Exit Sub
        End If

        'REPORTE POR SEXO MASCULINO
        If rbtMasculino.Checked = True Then
            Dim ReporteSexoMas1 As New frmSexo_Mas1
            ReporteSexoMas1.ShowDialog()
            ' Exit Sub
        End If

        'REPORTE POR EDAD GENERAL
        If cboOpcionImpresion.SelectedIndex = 1 Then
            Dim e1 As Integer = txtDesde.Text
            Dim e2 As Integer = txtHasta.Text
            Dim ReporteEdad As New frmReporte_por_Edad_1
            ReporteEdad.edad1 = e1
            ReporteEdad.edad2 = e2
            ReporteEdad.ShowDialog()
            Exit Sub
        End If

        'REPORTE POR SEXO Y EDAD MASCULINO
        If cboOpcionImpresion.SelectedIndex = 3 And rbtMasculino.Checked = True Then

            Dim edadmas1 As Integer = txtDesde.Text
            Dim edadmas2 As Integer = txtHasta.Text

            Dim ReporteEdadSexoMas1 As New frm_Reporte_Edad_Sexo_Masculino
            ReporteEdadSexoMas1.edadmas1 = edadmas1
            ReporteEdadSexoMas1.edadmas2 = edadmas2
            ReporteEdadSexoMas1.Show()
            Exit Sub
        End If

        'REPORTE POR SEXO Y EDAD FEMENIMO
        If cboOpcionImpresion.SelectedIndex = 3 And rbtFemenino.Checked = True Then
            Dim edadfem1 As Integer = txtDesde.Text
            Dim edadfem2 As Integer = txtHasta.Text

            Dim ReporteEdadSexoFem1 As New frm_Reporte_Edad_Sexo_Femenino
            ReporteEdadSexoFem1.edadfem1 = edadfem1
            ReporteEdadSexoFem1.edadfem2 = edadfem2
            ReporteEdadSexoFem1.Show()
        End If

    End Sub

    Private Sub cboOpcionImpresion_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboOpcionImpresion.SelectedIndexChanged
        If cboOpcionImpresion.Text = "General" Then
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            rbtFemenino.Checked = False
            rbtMasculino.Checked = False
            txtDesde.Clear()
            txtHasta.Clear()
        End If
        If cboOpcionImpresion.Text = "Por Sexo" Then
            GroupBox2.Enabled = False
            GroupBox3.Enabled = True
            txtDesde.Clear()
            txtHasta.Clear()
        End If
        If cboOpcionImpresion.Text = "Por Edad" Then
            GroupBox2.Enabled = True
            GroupBox3.Enabled = False
            rbtFemenino.Checked = False
            rbtMasculino.Checked = False
        End If
        If cboOpcionImpresion.Text = "Por Sexo y Edad" Then
            GroupBox2.Enabled = True
            GroupBox3.Enabled = True
            rbtFemenino.Checked = False
            rbtMasculino.Checked = False
            txtDesde.Clear()
            txtHasta.Clear()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class

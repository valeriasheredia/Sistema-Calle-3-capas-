Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim moDataTable As New DataTable
        'Añadimos las columnas.
        moDataTable.Columns.Add(New DataColumn("Nombre", Type.GetType("System.String")))
        moDataTable.Columns.Add(New DataColumn("FNacimiento", Type.GetType("System.DateTime")))
        ' Añadimos los datos
        Dim lDataRow As DataRow = moDataTable.NewRow
        lDataRow.Item("Nombre") = "PEPE"
        lDataRow.Item("FNacimiento") = CDate("01/01/2001")
        moDataTable.Rows.Add(lDataRow)
        '
        lDataRow = moDataTable.NewRow
        lDataRow.Item("Nombre") = "JOSE"
        lDataRow.Item("FNacimiento") = CDate("02/02/2002")
        moDataTable.Rows.Add(lDataRow)
        '
        lDataRow = moDataTable.NewRow
        lDataRow.Item("Nombre") = "MANUEL"
        lDataRow.Item("FNacimiento") = CDate("03/03/2003")
        moDataTable.Rows.Add(lDataRow)
        '
        lDataRow = moDataTable.NewRow
        lDataRow.Item("Nombre") = "JAVIER"
        lDataRow.Item("FNacimiento") = CDate("04/04/2004")
        moDataTable.Rows.Add(lDataRow)
        Me.DataGridView1.DataSource = moDataTable

    End Sub

    Private Sub LP_NumeraFilas(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs)
        ' si la celda a pintar es cabecera de fila
        If e.ColumnIndex < 0 AndAlso e.RowIndex >= 0 Then
            ' calcular el número a pintar en la celda
            Dim nNumeroFila As Integer = e.RowIndex + 1
            ' crear un array con las coordenadas sobre las que aplicaremos los colores con fundido basadas en la posición y dimensión de la celda
            Dim aPuntos As Point() = New Point() {New Point(e.CellBounds.X, e.CellBounds.Y), New Point(e.CellBounds.X, e.CellBounds.Y + e.CellBounds.Height), New Point(e.CellBounds.X + e.CellBounds.Width, e.CellBounds.Y + e.CellBounds.Height), New Point(e.CellBounds.X + e.CellBounds.Width, e.CellBounds.Y)}
            Dim pgbBrush As PathGradientBrush
            Dim aColores As Color()
            ' crear el objeto brush con efecto de fundido utilizando una combinación de colores diferente en función de si la celda está o no seleccionada
            If (e.State And DataGridViewElementStates.Selected) = DataGridViewElementStates.Selected Then
                aColores = New Color() {Color.LightSeaGreen, Color.Beige, Color.DarkTurquoise, Color.Aquamarine}
                pgbBrush = New PathGradientBrush(aPuntos)
                pgbBrush.CenterColor = Color.LawnGreen
                pgbBrush.SurroundColors = aColores
            Else
                aColores = New Color() {Color.Aquamarine, Color.DarkTurquoise, Color.Beige, Color.LightSeaGreen}
                pgbBrush = New PathGradientBrush(aPuntos)
                pgbBrush.CenterColor = Color.Lavender
                pgbBrush.SurroundColors = aColores
            End If  ' aplicar el objeto brush con el efecto de colores fundidos y dibujar un borde para el rectángulo de la celda
            e.Graphics.FillRectangle(pgbBrush, e.CellBounds)
            e.Graphics.DrawRectangle(New Pen(Color.DarkMagenta, 3), e.CellBounds)
            ' crear la fuente a usar para dibujar el número
            Dim oFont As New Font("Comic Sans MS", 12, FontStyle.Italic)
            ' calcular el tamaño del texto
            Dim szTexto As Size = TextRenderer.MeasureText(nNumeroFila.ToString(), oFont)
            ' dibujar el número
            TextRenderer.DrawText(e.Graphics, nNumeroFila.ToString(), oFont, e.CellBounds, e.CellStyle.ForeColor)
            e.Handled = True
        End If
    End Sub


    Private Sub DataGridView1_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        LP_NumeraFilas(sender, e)
    End Sub
End Class

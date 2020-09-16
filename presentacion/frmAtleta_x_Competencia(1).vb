Public Class frmAtletas_x_Competencia

    Private dt As New DataTable

    'Private Sub mostrar()
    '    'Try
    '    '    Dim func As New fAtleta_x_Competencia
    '    '    dt = func.Ultima_Atleta_x_Competencia
    '    '    If dt.Rows.Count <> 0 Then
    '    '        dgvDataListado.DataSource = dt
    '    '        dgvDataListado.ColumnHeadersVisible = True
    '    '    Else
    '    '        dgvDataListado.DataSource = Nothing
    '    '        dgvDataListado.ColumnHeadersVisible = False
    '    '    End If
    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message)
    '    'End Try
    'End Sub

    Private Sub frmAtletas_x_Competencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'mostrar()
        dgvDataListado1.ColumnHeadersVisible = True
        dgvDataListado1.Columns("Id_Atleta").Visible = True
        'GroupBox5.Enabled = False 'DESACTIVA EL GROUPBOX DEL TIEMPO
        'btnActualizar1.Enabled = False 'DESACTIVA EL BOTON ACTUALIZAR
        'btnDarComienzo1.Enabled = False 'DESACTIVA EL BOTON DAR COMIENZO (HASTA QUE SE GUARDE EL LISTADO)

        dtpTiempo1.Value = Date.FromOADate(0)
        Codigo_Nuevo_Atleta_x_Competencia()
        Nuevo_Codigo_Resultado()
       
    End Sub

    'AGREGA ATLETAS AL DGVDATALISTADO 1
    Shared Sub AgregarRegistroAGrilla1(atleta As vAtleta, resul As vAtleta_x_Competencia)

        Dim Coleccion As DataGridViewSelectedRowCollection = frmAtleta.Datalistado.SelectedRows
        frmAtletas_x_Competencia.dgvDataListado1.Rows.Add(atleta.gnombre_apellido, _
                                                          atleta.gdni,
                                                          atleta.gid_atleta,
                                                          resul.gdorsal,
                                                          resul.grepresentacion)
    End Sub

    'AGREGA ATLETAS AL DGVDATALISTADO 2
    Shared Sub AgregarRegistroAGrilla2(atleta As vAtleta, resul As vAtleta_x_Competencia)

        Dim Coleccion As DataGridViewSelectedRowCollection = frmAtleta.Datalistado.SelectedRows
        frmAtletas_x_Competencia.dgvDataListado2.Rows.Add(atleta.gnombre_apellido, _
                                                          atleta.gdni,
                                                          atleta.gid_atleta,
                                                          resul.gdorsal,
                                                          resul.grepresentacion)
    End Sub

    'AGREGA ATLETAS AL DGVDATALISTADO 3
    Shared Sub AgregarRegistroAGrilla3(atleta As vAtleta, resul As vAtleta_x_Competencia)

        Dim Coleccion As DataGridViewSelectedRowCollection = frmAtleta.Datalistado.SelectedRows
        frmAtletas_x_Competencia.dgvDataListado3.Rows.Add(atleta.gnombre_apellido, _
                                                          atleta.gdni,
                                                          atleta.gid_atleta,
                                                          resul.gdorsal,
                                                          resul.grepresentacion)
    End Sub

    'ABRE EL FORMULARIO PARA SELECCIONAR EL JUEZ DE LA COMPETENCIA DE LA DISTANCIA 1
    Private Sub btnBuscarProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarJuez1.Click
        frmJuez.txtFlag.Text = "1"
        frmJuez.ShowDialog()
    End Sub


    'QUITA ATLETAS DEL DGVDATALISTADO 1
    Private Sub btnQuitarAtletas_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtletas1.Click
        dgvDataListado1.Rows.RemoveAt(dgvDataListado1.CurrentRow.Index)
    End Sub

    'QUITA ATLETAS DEL DGVDATALISTADO 2
    Private Sub btnQuitarAtleta2_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtleta2.Click
        dgvDataListado2.Rows.RemoveAt(dgvDataListado2.CurrentRow.Index)
    End Sub

    'QUITA ATLETAS DEL DGVDATALISTADO 3
    Private Sub btnQuitarAtleta3_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtleta3.Click
        dgvDataListado3.Rows.RemoveAt(dgvDataListado3.CurrentRow.Index)
    End Sub

    'ABRE EL FORMULARIO DE ATLETAS PARA AGREGARLOS AL DGVDATALISTADO 1
    Private Sub btnAgregarAtletas_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtletas.Click
        frmAtleta.ShowDialog()
    End Sub

    'ABRE EL FORMULARIO DE ATLETAS PARA AGREGARLOS AL DGVDATALISTADO 2
    Private Sub btnAgregarAtleta2_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta2.Click
        frmAtleta.ShowDialog()
    End Sub

    'ABRE EL FORMULARIO DE ATLETAS PARA AGREGARLOS AL DGVDATALISTADO 3
    Private Sub btnAgregarAtleta3_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta3.Click
        frmAtleta.ShowDialog()
    End Sub

    'GUARDA EL LISTADO DE ATLETAS PARTICIPANTES EN LA PRIMERA DISTANCIA (DGVDATALISTADO 1)
    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar1.Click

        If txtHora1.Text = "" Then
            MessageBox.Show("Ingrese la Hora de competencia.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtHora1.Focus()
            Exit Sub
        End If
        If txtDistancia1.Text = "" Then
            MessageBox.Show("Ingrese la Distancia a recorrer.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDistancia1.Focus()
            Exit Sub
        End If
        If txtNombreJuez1.Text = "" Then
            MessageBox.Show("Ingrese el Juez de la competencia.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnBuscarJuez1.Focus()
            Exit Sub
        End If

        If Me.dgvDataListado1.Rows.Count = 0 Then
            MessageBox.Show("Debe haber registros cargados para poder guardarlos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtletas.Focus()
            Return
        End If

        Dim resultado As New vResultado
        Dim func As New fResultado
        Dim atl_x_comp As New vAtleta_x_Competencia
        Dim func_atl_x_comp As New fAtleta_x_Competencia
        Try
            For Each rows As DataGridViewRow In Me.dgvDataListado1.Rows

                'RECORRE EL DATAGRID Y GUARDA EL NUEVO RESULTADO REGISTRADO(ESTE TIENE VALORES INICIALES. TIEMPO= 00:00:00 Y POSICION =0)
                resultado.gid_resultado = txtIdResultado1.Text
                rows.Cells(5).Value = func.Nuevo_Codigo_Resultado
                resultado.gtiempo = txtTiempo1.Text
                resultado.gposicion = txtPosicion1.Text
                resultado.gid_atleta = rows.Cells(2).Value
                func.insertar(resultado)

                'RECORRE EL DATAGRID Y GUARDA EN LA TABLA "ATLETAS_POR_COMPETENCIA"

                atl_x_comp.gid_atleta_x_competencia = txtIdAtleta_x_Competencia1.Text 'id_atleta_x_competencia
                atl_x_comp.gid_atleta = rows.Cells(2).Value 'id_atleta
                atl_x_comp.gdorsal = rows.Cells(3).Value 'dorsal
                atl_x_comp.grepresentacion = rows.Cells(4).Value 'representacion
                atl_x_comp.gid_competencia = txtIdCompetencia1.Text 'id_competencia
                atl_x_comp.gfecha = dtpFecha1.Text 'fecha
                atl_x_comp.ghora = txtHora1.Text 'hora
                atl_x_comp.gdistancia1 = txtDistancia1.Text 'distancia1
                atl_x_comp.gdistancia2 = txtDistancia2.Text 'distancia2
                atl_x_comp.gdistancia3 = txtDistancia3.Text 'distancia3
                atl_x_comp.gid_juez = txtIdJuez1.Text 'id_juez

                fun.insertar(atl_x_comp)

            Next
            MessageBox.Show("El listado de atletas ha sido guardado correctamente", "Guardando listado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Nuevo_Codigo_Resultado()
            Codigo_Nuevo_Atleta_x_Competencia()
            txtDistancia1.Clear()
            btnDarComienzo1.Enabled = True
            btnGuardar1.Enabled = False
        Catch ex As Exception
            MsgBox("No se pudo guardar la lista de atletas", MsgBoxStyle.Critical)
        End Try
    End Sub

    'GUARDA EL LISTADO DE ATLETAS PARTICIPANTES EN LA SEGUNDA DISTANCIA (DGVDATALISTADO 2)
    Private Sub btnGuardar2_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar2.Click
   
        If txtDistancia2.Text = "" Then
            MessageBox.Show("Ingrese la Distancia a recorrer.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDistancia2.Focus()
            Exit Sub
        End If
       
        If Me.dgvDataListado2.Rows.Count = 0 Then
            MessageBox.Show("Debe haber registros cargados para poder guardarlos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtletas.Focus()
            Return
        End If

        Dim resultado As New vResultado
        Dim func As New fResultado
        Dim atl_x_comp As New vAtleta_x_Competencia
        Dim func_atl_x_comp As New fAtleta_x_Competencia
        Try
            For Each rows As DataGridViewRow In Me.dgvDataListado2.Rows

                'RECORRE EL DATAGRID Y GUARDA EL NUEVO RESULTADO REGISTRADO(ESTE TIENE VALORES INICIALES. TIEMPO= 00:00:00 Y POSICION =0)
                resultado.gid_resultado = txtIdResultado2.Text
                rows.Cells(5).Value = func.Nuevo_Codigo_Resultado
                resultado.gtiempo = txtTiempo2.Text
                resultado.gposicion = txtPosicion2.Text
                resultado.gid_atleta = rows.Cells(2).Value
                func.insertar(resultado)

                'RECORRE EL DATAGRID Y GUARDA EN LA TABLA "ATLETAS_POR_COMPETENCIA"

                atl_x_comp.gid_atleta_x_competencia = txtIdAtleta_x_Competencia2.Text 'id_atleta_x_competencia
                atl_x_comp.gid_atleta = rows.Cells(2).Value 'id_atleta
                atl_x_comp.gdorsal = rows.Cells(3).Value 'dorsal
                atl_x_comp.grepresentacion = rows.Cells(4).Value 'representacion
                atl_x_comp.gid_competencia = txtIdCompetencia2.Text 'id_competencia
                atl_x_comp.gfecha = dtpFecha2.Text 'fecha
                atl_x_comp.ghora = txtHora2.Text 'hora
                atl_x_comp.gdistancia1 = txtDistancia1.Text 'distancia1
                atl_x_comp.gdistancia2 = txtDistancia2.Text 'distancia2
                atl_x_comp.gdistancia3 = txtDistancia3.Text 'distancia3
                atl_x_comp.gid_juez = txtIdJuez2.Text 'id_juez
                fun.insertar(atl_x_comp)
            Next
            MessageBox.Show("El listado de atletas ha sido guardado correctamente", "Guardando listado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Nuevo_Codigo_Resultado()
            Codigo_Nuevo_Atleta_x_Competencia()
            txtDistancia2.Clear()
        Catch ex As Exception
            MsgBox("No se pudo guardar la lista de atletas", MsgBoxStyle.Critical)
        End Try
    End Sub

    'GUARDA EL LISTADO DE ATLETAS PARTICIPANTES EN LA TERCERA DISTANCIA (DGVDATALISTADO 3)
    Private Sub btnGuardar3_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar3.Click

     
        If txtDistancia3.Text = "" Then
            MessageBox.Show("Ingrese la Distancia a recorrer.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDistancia3.Focus()
            Exit Sub
        End If
       
        If Me.dgvDataListado3.Rows.Count = 0 Then
            MessageBox.Show("Debe haber registros cargados para poder guardarlos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtletas.Focus()
            Return
        End If

        Dim resultado As New vResultado
        Dim func As New fResultado
        Dim atl_x_comp As New vAtleta_x_Competencia
        Dim func_atl_x_comp As New fAtleta_x_Competencia
        Try
            For Each rows As DataGridViewRow In Me.dgvDataListado3.Rows

                'RECORRE EL DATAGRID Y GUARDA EL NUEVO RESULTADO REGISTRADO(ESTE TIENE VALORES INICIALES. TIEMPO= 00:00:00 Y POSICION =0)
                resultado.gid_resultado = txtIdResultado1.Text
                rows.Cells(5).Value = func.Nuevo_Codigo_Resultado
                resultado.gtiempo = txtTiempo3.Text
                resultado.gposicion = txtPosicion3.Text
                resultado.gid_atleta = rows.Cells(2).Value
                func.insertar(resultado)

                'RECORRE EL DATAGRID Y GUARDA EN LA TABLA "ATLETAS_POR_COMPETENCIA"

                atl_x_comp.gid_atleta_x_competencia = txtIdAtleta_x_Competencia1.Text 'id_atleta_x_competencia
                atl_x_comp.gid_atleta = rows.Cells(2).Value 'id_atleta
                atl_x_comp.gdorsal = rows.Cells(3).Value 'dorsal
                atl_x_comp.grepresentacion = rows.Cells(4).Value 'representacion
                atl_x_comp.gid_competencia = txtIdCompetencia1.Text 'id_competencia
                atl_x_comp.gfecha = dtpFecha1.Text 'fecha
                atl_x_comp.ghora = txtHora1.Text 'hora
                atl_x_comp.gdistancia1 = txtDistancia1.Text 'distancia1
                atl_x_comp.gdistancia2 = txtDistancia2.Text 'distancia2
                atl_x_comp.gdistancia3 = txtDistancia3.Text 'distancia3
                atl_x_comp.gid_juez = txtIdJuez1.Text 'id_juez

                fun.insertar(atl_x_comp)

            Next
            MessageBox.Show("El listado de atletas ha sido guardado correctamente", "Guardando listado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Nuevo_Codigo_Resultado()
            Codigo_Nuevo_Atleta_x_Competencia()
            txtDistancia3.Clear()
        Catch ex As Exception
            MsgBox("No se pudo guardar la lista de atletas", MsgBoxStyle.Critical)
        End Try
    End Sub

    Dim func As New fResultado
    Sub Nuevo_Codigo_Resultado()
        txtIdResultado1.Text = func.Nuevo_Codigo_Resultado 'GENERA UN NUEVO CODIGO DE RESULTADO Y LO ASIGNA AL TXTIDRESULTADO1(TABPAGE1)
        cargartabpage2y3()
    End Sub

    Dim fun As New fAtleta_x_Competencia
    Sub Codigo_Nuevo_Atleta_x_Competencia()
        txtIdAtleta_x_Competencia1.Text = fun.Codigo_Nuevo_Atleta_x_Competencia 'GENERA UN NUEVO CODIGO DE RESULTADO_X_ATLETA Y LO ASIGNA AL TXTIDATLETA_X_COMPETENCIA1(TABPAGE1)
        cargartabpage2y3()
    End Sub

    Sub cargartabpage2y3()
        txtIdResultado2.Text = txtIdResultado1.Text 'ASIGNA EL VALOR DEL TXTIDRESULTADO1 AL TXTIDRESULTADO2(TABPAGE2)
        txtIdResultado3.Text = txtIdResultado1.Text 'ASIGNA EL VALOR DEL TXTIDRESULTADO1 AL TXTIDRESULTADO3(TABPAGE3)
        txtIdAtleta_x_Competencia2.Text = txtIdAtleta_x_Competencia1.Text 'ASIGNA EL VALOR DEL TXTIDATLETA_X_COMPETENCIA1 AL TXTIDATLETA_X_COMPETENCIA2(TABPAGE2)
        txtIdAtleta_x_Competencia3.Text = txtIdAtleta_x_Competencia1.Text 'ASIGNA EL VALOR DEL TXTIDATLETA_X_COMPETENCIA1 AL TXTIDATLETA_X_COMPETENCIA3(TABPAGE3)

    End Sub

    'ASIGNA LA FECHA A LOS TABPAGE2 Y TABPAGE3 
    Private Sub dtpFecha1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpFecha1.ValueChanged
        dtpFecha2.Text = dtpFecha1.Text
        dtpFecha3.Text = dtpFecha1.Text
    End Sub

    'ASIGNA LA HORA A LOS TABPAGE2 Y TABPAGE3 
    Private Sub txtHora1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHora1.TextChanged
        txtHora2.Text = txtHora1.Text
        txtHora3.Text = txtHora1.Text
    End Sub

    'ASIGNA EL IDJUEZ A LOS TABPAGE2 Y TABPAGE3 
    Private Sub txtIdJuez1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtIdJuez1.TextChanged
        txtIdJuez2.Text = txtIdJuez1.Text
        txtIdJuez3.Text = txtIdJuez1.Text
    End Sub


    ' CREACION DE CONSTANTES 
    Const COLUMNA_MEJOR_TIEMPO As Integer = 6
    Const COLUMNA_POSICION As Integer = 7

    ' BOTON AGREGAR TIEMPO
    Private Sub btnAgregarTiempo1_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTiempo1.Click

        'VALIDA HS VACIA (00:00:00)
        If dtpTiempo1.Value.ToString("HH:mm:ss") = "00:00:00" Or dtpTiempo1.Value.ToString("HH:mm:ss") = Nothing Then

            MessageBox.Show("Debe ingresar un tiempo para poder continuar")
            dtpTiempo1.Select()
            dtpTiempo1.Focus()
            Exit Sub
        End If
        'CONFIRMA INGRESO DE TIEMPO DEL ATLETA CON APELLIDO.....
        Dim filaActual = Me.dgvDataListado1.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el tiempo de: " & Environment.NewLine & CStr(filaActual.Cells(0).Value),
                           "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim valor As String = dtpTiempo1.Value.ToString("HH:mm:ss")
            CargarSiguienteCelda1(filaActual, valor)
            'limpiar el time picker
            dtpTiempo1.Value = Date.FromOADate(0)
        End If
        btnActualizar1.Enabled = True
        Ordenar()
    End Sub

    Private Sub CargarSiguienteCelda1(ByRef filaActual As DataGridViewRow, valorAponer As String)

        filaActual.Cells(COLUMNA_MEJOR_TIEMPO).Value = valorAponer
        If 6 = COLUMNA_MEJOR_TIEMPO Then
            Dim fila = dgvDataListado1.CurrentRow
            If fila IsNot Nothing Then
                Dim Tiempos As New List(Of TimeSpan)
                fila.Cells(COLUMNA_MEJOR_TIEMPO).Value = valorAponer
            End If
        End If
        Exit Sub
    End Sub

    Private Function ConvertirADate(valor As String)
        Dim nuevoTiempo As DateTime = DateTime.ParseExact("01/01/2001 " + valor.Trim(), "dd/MM/yyyy HH:mm:ss", Nothing)
        Return nuevoTiempo
    End Function

    Private Sub Ordenar()
        'ORDENA EL DATAGRID Y PONE LAS POSICIONES
        dgvDataListado1.Sort(dgvDataListado1.Columns(COLUMNA_MEJOR_TIEMPO), System.ComponentModel.ListSortDirection.Ascending)
        Dim cont As Integer
        cont = 0
        For Each rows As DataGridViewRow In Me.dgvDataListado1.Rows
            cont = cont + 1
            rows.Cells(COLUMNA_POSICION).Value = cont
        Next
    End Sub

    Private Sub btnSinTiempo1_Click(sender As System.Object, e As System.EventArgs) Handles btnSinTiempo1.Click
      
        Dim filaActual = Me.dgvDataListado1.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el tiempo de: " & Environment.NewLine & CStr(filaActual.Cells(0).Value),
                           "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim valor As String = btnSinTiempo1.Text
            CargarSiguienteCelda1(filaActual, valor)
            'limpiar el time picker
            dtpTiempo1.Value = Date.FromOADate(0)
        End If
        btnActualizar1.Enabled = True
    End Sub

    Private Sub CargarSiguienteCelda2(ByRef filaActual As DataGridViewRow, valorAponer As String)

        filaActual.Cells(COLUMNA_MEJOR_TIEMPO).Value = valorAponer
        If 6 = COLUMNA_MEJOR_TIEMPO Then
            Dim fila = dgvDataListado2.CurrentRow
            If fila IsNot Nothing Then
                Dim Tiempos As New List(Of TimeSpan)
                fila.Cells(COLUMNA_MEJOR_TIEMPO).Value = valorAponer
            End If
        End If
        Exit Sub
    End Sub

    Private Sub btnAgregarTiempo2_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTiempo2.Click
        'VALIDA HS VACIA (00:00:00)
        If dtpTiempo2.Value.ToString("HH:mm:ss") = "00:00:00" Or dtpTiempo2.Value.ToString("HH:mm:ss") = Nothing Then

            MessageBox.Show("Debe ingresar un tiempo para poder continuar")
            dtpTiempo2.Select()
            dtpTiempo2.Focus()
            Exit Sub
        End If
        'CONFIRMA INGRESO DE TIEMPO DEL ATLETA CON APELLIDO.....
        Dim filaActual = Me.dgvDataListado2.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el tiempo de: " & Environment.NewLine & CStr(filaActual.Cells(0).Value),
                           "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim valor As String = dtpTiempo2.Value.ToString("HH:mm:ss")
            CargarSiguienteCelda2(filaActual, valor)
            'limpiar el time picker
            dtpTiempo2.Value = Date.FromOADate(0)
        End If
        btnActualizar2.Enabled = True
        Ordenar2()
    End Sub

    Private Sub Ordenar2()
        'ORDENA EL DATAGRID Y PONE LAS POSICIONES
        dgvDataListado1.Sort(dgvDataListado1.Columns(COLUMNA_MEJOR_TIEMPO), System.ComponentModel.ListSortDirection.Ascending)
        Dim cont As Integer
        cont = 0
        For Each rows As DataGridViewRow In Me.dgvDataListado1.Rows
            cont = cont + 1
            rows.Cells(COLUMNA_POSICION).Value = cont
        Next
    End Sub

    Private Sub CargarSiguienteCelda3(ByRef filaActual As DataGridViewRow, valorAponer As String)

        filaActual.Cells(COLUMNA_MEJOR_TIEMPO).Value = valorAponer
        If 6 = COLUMNA_MEJOR_TIEMPO Then
            Dim fila = dgvDataListado3.CurrentRow
            If fila IsNot Nothing Then
                Dim Tiempos As New List(Of TimeSpan)
                fila.Cells(COLUMNA_MEJOR_TIEMPO).Value = valorAponer
            End If
        End If
        Exit Sub
    End Sub

    Private Sub btnAgregarTiempo3_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTiempo3.Click
        'VALIDA HS VACIA (00:00:00)
        If dtpTiempo3.Value.ToString("HH:mm:ss") = "00:00:00" Or dtpTiempo3.Value.ToString("HH:mm:ss") = Nothing Then

            MessageBox.Show("Debe ingresar un tiempo para poder continuar")
            dtpTiempo3.Select()
            dtpTiempo3.Focus()
            Exit Sub
        End If
        'CONFIRMA INGRESO DE TIEMPO DEL ATLETA CON APELLIDO.....
        Dim filaActual = Me.dgvDataListado3.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el tiempo de: " & Environment.NewLine & CStr(filaActual.Cells(0).Value),
                           "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim valor As String = dtpTiempo3.Value.ToString("HH:mm:ss")
            CargarSiguienteCelda3(filaActual, valor)
            'limpiar el time picker
            dtpTiempo3.Value = Date.FromOADate(0)
        End If
        btnActualizar3.Enabled = True
        Ordenar3()
    End Sub

    Private Sub Ordenar3()
        'ORDENA EL DATAGRID Y PONE LAS POSICIONES
        dgvDataListado1.Sort(dgvDataListado1.Columns(COLUMNA_MEJOR_TIEMPO), System.ComponentModel.ListSortDirection.Ascending)
        Dim cont As Integer
        cont = 0
        For Each rows As DataGridViewRow In Me.dgvDataListado1.Rows
            cont = cont + 1
            rows.Cells(COLUMNA_POSICION).Value = cont
        Next
    End Sub

    Private Sub btnSinTiempo2_Click(sender As System.Object, e As System.EventArgs) Handles btnSinTiempo2.Click
        Dim filaActual = Me.dgvDataListado2.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el tiempo de: " & Environment.NewLine & CStr(filaActual.Cells(0).Value),
                           "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim valor As String = btnSinTiempo2.Text
            CargarSiguienteCelda2(filaActual, valor)
            'limpiar el time picker
            dtpTiempo2.Value = Date.FromOADate(0)
        End If
        btnActualizar2.Enabled = True
    End Sub

    Private Sub btnSinTiempo3_Click(sender As System.Object, e As System.EventArgs) Handles btnSinTiempo3.Click
        Dim filaActual = Me.dgvDataListado3.SelectedRows(0)
        If MessageBox.Show("Confirma ingresar el tiempo de: " & Environment.NewLine & CStr(filaActual.Cells(0).Value),
                           "Confirmar acción", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim valor As String = btnSinTiempo3.Text
            CargarSiguienteCelda3(filaActual, valor)
            'limpiar el time picker
            dtpTiempo3.Value = Date.FromOADate(0)
        End If
        btnActualizar3.Enabled = True
    End Sub

End Class







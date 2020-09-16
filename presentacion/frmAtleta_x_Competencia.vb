

Public Class frmAtletas_x_Competencia

    Private dt As New DataTable
    Shared Property Resultado_Final As New vResultado
    Shared Property Funcion_Resultado As New fResultado
    Shared Property Atleta_Competencia_Final As New vAtleta_x_Competencia
    Shared Property Funcion_Atleta_Competencia As New fAtleta_x_Competencia

    Private Sub frmAtletas_x_Competencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'If dgvDataListado1.Rows.Count = 0 Then


        Me.dgvDataListado1.ClearSelection()
        'End If
        dgvDataListado1.Columns(2).Visible = False
        dgvDataListado1.Columns(6).Visible = False
        '  Me.dgvDataListado1.CurrentCell = Nothing
        dtpTiempo1.Enabled = False
        dtpTiempo2.Enabled = False
        dtpTiempo3.Enabled = False
        btnAgregarTiempo1.Enabled = False
        btnAgregarTiempo2.Enabled = False
        btnAgregarTiempo3.Enabled = False
        btnSinTiempo1.Enabled = False
        btnSinTiempo2.Enabled = False
        btnSinTiempo3.Enabled = False
        dgvDataListado1.ColumnHeadersVisible = True
        dgvDataListado2.ColumnHeadersVisible = True
        dgvDataListado3.ColumnHeadersVisible = True
        btnActualizar1.Enabled = False 'DESACTIVA EL BOTON ACTUALIZAR
        btnActualizar2.Enabled = False
        btnActualizar3.Enabled = False
        btnSalir1.Enabled = False
        btnSalir2.Enabled = False
        btnSalir3.Enabled = False
        btnImprimir1.Enabled = False 'DESACTIVA EL BOTON DAR COMIENZO (HASTA QUE SE GUARDE EL LISTADO)
        btnImprimir2.Enabled = False
        btnImprimir3.Enabled = False
        dtpTiempo1.Value = Date.FromOADate(0)
        dtpTiempo2.Value = Date.FromOADate(0)
        dtpTiempo3.Value = Date.FromOADate(0)
        Codigo_Nuevo_Atleta_x_Competencia()
        Nuevo_Codigo_Resultado()
        ' mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fAtleta_x_Competencia
            dt = func.mostrar

            If dt.Rows.Count <> 0 Then
                '  Datalistado.ClearSelection()
                dgvDataListado1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
                dgvDataListado1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
                dgvDataListado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
                dgvDataListado1.DataSource = dt
                dgvDataListado1.Columns(0).HeaderText = "Nombre y Apellido"
                ' dgvDataListado1.Columns(1).Visible = False
                dgvDataListado1.Columns(1).HeaderText = "Dni"

                dgvDataListado1.Columns(2).HeaderText = "id_atleta"
                'dgvDataListado1.Columns(3).Visible = False
                dgvDataListado1.Columns(3).HeaderText = "Edad"
                dgvDataListado1.Columns(4).HeaderText = "Dorsal"
                dgvDataListado1.Columns(5).HeaderText = "Representación"
                dgvDataListado1.Columns(6).HeaderText = "Id_Resultado"
                dgvDataListado1.Columns(7).HeaderText = "Tiempo"
                dgvDataListado1.Columns(8).HeaderText = "Posición"
                dgvDataListado1.Enabled = True
                dgvDataListado1.ColumnHeadersVisible = True
                lkDatosInexistentes1.Visible = False
            Else
                dgvDataListado1.DataSource = Nothing

                dgvDataListado1.ColumnHeadersVisible = False
                lkDatosInexistentes1.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'AGREGA ATLETAS AL DGVDATALISTADO 1
    Shared Sub AgregarRegistroAGrilla1(atleta As vAtleta, resul As vAtleta_x_Competencia)

        Dim Coleccion As DataGridViewSelectedRowCollection = frmAtleta.Datalistado.SelectedRows
        frmAtletas_x_Competencia.dgvDataListado1.Rows.Add(atleta.gnombre_apellido, _
                                                          atleta.gdni,
                                                          atleta.gid_atleta,
                                                          atleta.gedad,
                                                          resul.gdorsal,
                                                          resul.grepresentacion,
                                                          0,
                                                          "00:00:00",
                                                          0)
    End Sub

    'AGREGA ATLETAS AL DGVDATALISTADO 2
    Shared Sub AgregarRegistroAGrilla2(atleta As vAtleta, resul As vAtleta_x_Competencia)

        Dim Coleccion As DataGridViewSelectedRowCollection = frmAtleta.Datalistado.SelectedRows
        frmAtletas_x_Competencia.dgvDataListado2.Rows.Add(atleta.gnombre_apellido, _
                                                          atleta.gdni,
                                                          atleta.gid_atleta,
                                                          atleta.gedad,
                                                          resul.gdorsal,
                                                          resul.grepresentacion,
                                                          0,
                                                          "00:00:00",
                                                          0)
    End Sub

    'AGREGA ATLETAS AL DGVDATALISTADO 3
    Shared Sub AgregarRegistroAGrilla3(atleta As vAtleta, resul As vAtleta_x_Competencia)

        Dim Coleccion As DataGridViewSelectedRowCollection = frmAtleta.Datalistado.SelectedRows
        frmAtletas_x_Competencia.dgvDataListado3.Rows.Add(atleta.gnombre_apellido, _
                                                          atleta.gdni,
                                                          atleta.gid_atleta,
                                                          atleta.gedad,
                                                          resul.gdorsal,
                                                          resul.grepresentacion,
                                                          0,
                                                          "00:00:00",
                                                          0)
    End Sub

    'QUITA ATLETAS DEL DGVDATALISTADO 1
    Private Sub btnQuitarAtletas_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtletas1.Click
        If dgvDataListado1.Rows.Count <> 0 Then
            dgvDataListado1.Rows.RemoveAt(dgvDataListado1.CurrentRow.Index)
        Else
            MessageBox.Show("No existen Atletas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'ABRE EL FORMULARIO DE ATLETAS PARA AGREGARLOS AL DGVDATALISTADO 1
    Private Sub btnAgregarAtletas_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtletas1.Click
        frmAtleta.Show()

        frmAtleta.GroupBox3.Enabled = True
        frmAtleta.GroupBox1.Enabled = True
        frmAtleta.btnEditar.Enabled = False
        frmAtleta.btnGuardar.Enabled = True

    End Sub

    'GUARDA EL LISTADO DE ATLETAS PARTICIPANTES EN LA PRIMERA DISTANCIA (DGVDATALISTADO 1)
    '---------------------------BOTON GUARDAR 1 BIEN---------------------------------------
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
            MessageBox.Show("Debe haber atletas cargados para poder guardarlos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtletas1.Focus()
            Return
        End If
        txtDistancia2.Text = "0"
        txtDistancia3.Text = "0"
        Dim resultado As New vResultado
        Dim func As New fResultado
        Dim atl_x_comp As New vAtleta_x_Competencia
        Dim func_atl_x_comp As New fAtleta_x_Competencia
        '   Try
        For Each rows As DataGridViewRow In Me.dgvDataListado1.Rows
            'RECORRE EL DATAGRID Y GUARDA EL NUEVO RESULTADO REGISTRADO(ESTE TIENE VALORES INICIALES. TIEMPO= 00:00:00 Y POSICION =0)
            resultado.gid_resultado = txtIdResultado1.Text
            rows.Cells("Id_Resultado1").Value = func.Nuevo_Codigo_Resultado
            resultado.gtiempo = txtTiempo1.Text
            resultado.gposicion = txtPosicion1.Text
            func.insertar(resultado)

            'RECORRE EL DATAGRID Y GUARDA EN LA TABLA "ATLETAS_POR_COMPETENCIA"
            atl_x_comp.gid_atleta_x_competencia = txtId_Atleta_x_Competencia1.Text 'id_atleta_x_competencia
            atl_x_comp.gid_atleta = rows.Cells("Id_Atleta1").Value 'id_atleta
            atl_x_comp.gdorsal = rows.Cells(4).Value 'dorsal
            atl_x_comp.grepresentacion = rows.Cells(5).Value 'representacion
            atl_x_comp.gid_competencia = txtIdCompetencia1.Text 'id_competencia
            atl_x_comp.gfecha = dtpFecha1.Text 'fecha
            atl_x_comp.ghora = txtHora1.Text 'hora
            atl_x_comp.gdistancia1 = txtDistancia1.Text 'distancia1
            atl_x_comp.gdistancia2 = txtDistancia2.Text 'distancia2
            atl_x_comp.gdistancia3 = txtDistancia3.Text 'distancia3
            atl_x_comp.gid_juez = txtIdJuez1.Text 'id_juez
            rows.Cells("Id_Resultado1").Value = func.Nuevo_Codigo_Resultado
            atl_x_comp.gid_resultado = rows.Cells("Id_Resultado1").Value
            fun.insertar(atl_x_comp)

        Next

        MessageBox.Show("El listado de atletas ha sido guardado correctamente", "Guardando listado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Nuevo_Codigo_Resultado()
        Codigo_Nuevo_Atleta_x_Competencia()
        dtpTiempo1.Enabled = True
        btnAgregarTiempo1.Enabled = True
        btnSinTiempo1.Enabled = True
        btnAgregarAtletas1.Enabled = False
        btnQuitarAtletas1.Enabled = False
        btnGuardar1.Enabled = False
        txtHora1.Enabled = False
        txtDistancia1.Enabled = False
        dtpFecha1.Enabled = False

        ' Catch ex As Exception
        'MsgBox("No se pudo guardar la lista de atletas", MsgBoxStyle.Critical)
        ' End Try
        Me.dgvDataListado1.ClearSelection()
        Me.dgvDataListado1.Sort(Me.dgvDataListado1.Columns(4), System.ComponentModel.ListSortDirection.Ascending)
    End Sub


    '---------------------------------BOTON GUARDAR 2 FUNCIONA BIEN----------------------------------------------------
    Private Sub btnGuardar2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnGuardar2.Click
        If txtDistancia2.Text = 0 Then
            MessageBox.Show("Ingrese la Distancia a recorrer.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDistancia2.Focus()
            Exit Sub
        End If
        If Me.dgvDataListado2.Rows.Count = 0 Then
            MessageBox.Show("Debe haber registros cargados para poder guardarlos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtletas1.Focus()
            Return
        End If
        txtDistancia1.Text = "0"
        txtDistancia3.Text = "0"
        Dim resultado As New vResultado
        Dim func As New fResultado
        Dim atl_x_comp As New vAtleta_x_Competencia
        Dim func_atl_x_comp As New fAtleta_x_Competencia
        Try
            For Each rows As DataGridViewRow In Me.dgvDataListado2.Rows

                'RECORRE EL DATAGRID Y GUARDA EL NUEVO RESULTADO REGISTRADO(ESTE TIENE VALORES INICIALES. TIEMPO= 00:00:00 Y POSICION =0)
                resultado.gid_resultado = txtIdResultado2.Text
                rows.Cells("Id_Resultado2").Value = func.Nuevo_Codigo_Resultado
                resultado.gtiempo = txtTiempo2.Text
                resultado.gposicion = txtPosicion2.Text

                func.insertar(resultado)

                'RECORRE EL DATAGRID Y GUARDA EN LA TABLA "ATLETAS_POR_COMPETENCIA"
                atl_x_comp.gid_atleta_x_competencia = txtId_Atleta_x_Competencia2.Text 'id_atleta_x_competencia
                atl_x_comp.gid_atleta = rows.Cells("Id_Atleta2").Value 'id_atleta
                atl_x_comp.gdorsal = rows.Cells(4).Value 'dorsal
                atl_x_comp.grepresentacion = rows.Cells(5).Value 'representacion
                atl_x_comp.gid_competencia = txtIdCompetencia2.Text 'id_competencia
                atl_x_comp.gfecha = dtpFecha2.Text 'fecha
                atl_x_comp.ghora = txtHora2.Text 'hora
                atl_x_comp.gdistancia1 = txtDistancia1.Text 'distancia1
                atl_x_comp.gdistancia2 = txtDistancia2.Text 'distancia2
                atl_x_comp.gdistancia3 = txtDistancia3.Text 'distancia3
                atl_x_comp.gid_juez = txtIdJuez2.Text 'id_juez
                rows.Cells("Id_Resultado2").Value = func.Nuevo_Codigo_Resultado
                atl_x_comp.gid_resultado = rows.Cells("Id_Resultado2").Value
                fun.insertar(atl_x_comp)
            Next
            MessageBox.Show("El listado de atletas ha sido guardado correctamente", "Guardando listado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Nuevo_Codigo_Resultado()
            Codigo_Nuevo_Atleta_x_Competencia()
            dtpTiempo2.Enabled = True
            btnAgregarTiempo2.Enabled = True
            btnSinTiempo2.Enabled = True
            btnAgregarAtleta2.Enabled = False
            btnQuitarAtleta2.Enabled = False
            btnGuardar2.Enabled = False
            txtHora1.Enabled = False
            txtDistancia1.Enabled = False
            dtpFecha1.Enabled = False
        Catch ex As Exception
            MsgBox("No se pudo guardar la lista de atletas", MsgBoxStyle.Critical)
        End Try
    End Sub

    '--------------------------------------------BOTON GUARDAR 3 FUNCIONA BIEN----------------------------------------------
    Private Sub btnGuardar3_Click_1(sender As System.Object, e As System.EventArgs) Handles btnGuardar3.Click
        If txtDistancia3.Text = 0 Then
            MessageBox.Show("Ingrese la Distancia a recorrer.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDistancia3.Focus()
            Exit Sub
        End If
        If Me.dgvDataListado3.Rows.Count = 0 Then
            MessageBox.Show("Debe haber registros cargados para poder guardarlos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarAtleta3.Focus()
            Return
        End If
        txtDistancia1.Text = "0"
        txtDistancia2.Text = "0"
        Dim resultado As New vResultado
        Dim func As New fResultado
        Dim atl_x_comp As New vAtleta_x_Competencia
        Dim func_atl_x_comp As New fAtleta_x_Competencia
        Try
            For Each rows As DataGridViewRow In Me.dgvDataListado3.Rows
                'RECORRE EL DATAGRID Y GUARDA EL NUEVO RESULTADO REGISTRADO(ESTE TIENE VALORES INICIALES. TIEMPO= 00:00:00 Y POSICION =0)
                resultado.gid_resultado = txtIdResultado3.Text
                rows.Cells("Id_Resultado3").Value = func.Nuevo_Codigo_Resultado
                resultado.gtiempo = txtTiempo3.Text
                resultado.gposicion = txtPosicion3.Text
                func.insertar(resultado)
                'RECORRE EL DATAGRID Y GUARDA EN LA TABLA "ATLETAS_POR_COMPETENCIA"
                atl_x_comp.gid_atleta_x_competencia = txtId_Atleta_x_Competencia3.Text 'id_atleta_x_competencia
                atl_x_comp.gid_atleta = rows.Cells("Id_Atleta3").Value 'id_atleta
                atl_x_comp.gdorsal = rows.Cells(4).Value 'dorsal
                atl_x_comp.grepresentacion = rows.Cells(5).Value 'representacion
                atl_x_comp.gid_competencia = txtIdCompetencia3.Text 'id_competencia
                atl_x_comp.gfecha = dtpFecha3.Text 'fecha
                atl_x_comp.ghora = txtHora3.Text 'hora
                atl_x_comp.gdistancia1 = txtDistancia1.Text 'distancia1
                atl_x_comp.gdistancia2 = txtDistancia2.Text 'distancia2
                atl_x_comp.gdistancia3 = txtDistancia3.Text 'distancia3
                atl_x_comp.gid_juez = txtIdJuez3.Text 'id_juez
                rows.Cells("Id_Resultado3").Value = func.Nuevo_Codigo_Resultado
                atl_x_comp.gid_resultado = rows.Cells("Id_Resultado3").Value
                fun.insertar(atl_x_comp)
            Next
            MessageBox.Show("El listado de atletas ha sido guardado correctamente", "Guardando listado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Nuevo_Codigo_Resultado()
            Codigo_Nuevo_Atleta_x_Competencia()
            dtpTiempo3.Enabled = True
            btnAgregarTiempo3.Enabled = True
            btnSinTiempo3.Enabled = True
            btnAgregarAtleta3.Enabled = False
            btnQuitarAtleta3.Enabled = False
            btnGuardar3.Enabled = False
            txtHora1.Enabled = False
            txtDistancia1.Enabled = False
            dtpFecha1.Enabled = False
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
        txtId_Atleta_x_Competencia1.Text = fun.Codigo_Nuevo_Atleta_x_Competencia 'GENERA UN NUEVO CODIGO DE RESULTADO_X_ATLETA Y LO ASIGNA AL TXTIDATLETA_X_COMPETENCIA1(TABPAGE1)
        cargartabpage2y3()
    End Sub

    Sub cargartabpage2y3()
        txtIdResultado2.Text = txtIdResultado1.Text 'ASIGNA EL VALOR DEL TXTIDRESULTADO1 AL TXTIDRESULTADO2(TABPAGE2)
        txtIdResultado3.Text = txtIdResultado1.Text 'ASIGNA EL VALOR DEL TXTIDRESULTADO1 AL TXTIDRESULTADO3(TABPAGE3)
        txtId_Atleta_x_Competencia2.Text = txtId_Atleta_x_Competencia1.Text 'ASIGNA EL VALOR DEL TXTIDATLETA_X_COMPETENCIA1 AL TXTIDATLETA_X_COMPETENCIA2(TABPAGE2)
        txtId_Atleta_x_Competencia3.Text = txtId_Atleta_x_Competencia1.Text 'ASIGNA EL VALOR DEL TXTIDATLETA_X_COMPETENCIA1 AL TXTIDATLETA_X_COMPETENCIA3(TABPAGE3)
        txtNombreJuez2.Text = txtNombreJuez1.Text
        txtNombreJuez3.Text = txtNombreJuez1.Text
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
        'VALIDA LA HORA INGRESADA
        Select Case Len(txtHora1.Text)
            Case 5
                If Microsoft.VisualBasic.Right(txtHora1.Text, 2) > 59 Then
                    MsgBox("Debes ingresar los minutos entre el 00 al 59", , "")
                    txtHora1.Text = Microsoft.VisualBasic.Right(txtHora1.Text, Len(txtHora1.Text) - 2)
                Else
                    txtHora1.Text = txtHora1.Text & ""
                End If
            Case 2
                If Microsoft.VisualBasic.Left(txtHora1.Text, 2) > 23 Then
                    MsgBox("Debes ingresar la hora entre el 00 al 23", , "")
                    txtHora1.Text = Microsoft.VisualBasic.Left(txtHora1.Text, Len(txtHora1.Text) - 2)
                Else
                    txtHora1.Text = txtHora1.Text & ":"
                    Me.txtHora1.SelectionStart = 3
                End If
        End Select
    End Sub

    'ASIGNA EL IDJUEZ A LOS TABPAGE2 Y TABPAGE3 
    Private Sub txtIdJuez1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtIdJuez1.TextChanged
        txtIdJuez2.Text = txtIdJuez1.Text
        txtIdJuez3.Text = txtIdJuez1.Text
    End Sub

    ' CREACION DE CONSTANTES 
    Const COLUMNA_MEJOR_TIEMPO As Integer = 7
    Const COLUMNA_POSICION As Integer = 8
    ' BOTON AGREGAR TIEMPO


    Private Sub CargarSiguienteCelda1(ByRef filaActual As DataGridViewRow, valorAponer As String)

        If String.IsNullOrEmpty(CStr(filaActual.Cells(7).Value).Trim()) OrElse CStr(filaActual.Cells(7).Value).Trim() = "00:00:00" Then 'busca la primer posición vacía d las celdas 4,5,6
            filaActual.Cells(7).Value = valorAponer
        End If
    End Sub

    Private Sub btnAgregarTiempo1_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTiempo1.Click
        'VALIDA HS VACIA (00:00:00)
        If dtpTiempo1.Value.ToString("HH:mm:ss") = "00:00:00" Then
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

    Private Sub btnAgregarTiempo2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregarTiempo2.Click
        'VALIDA HS VACIA (00:00:00)
        If dtpTiempo2.Value.ToString("HH:mm:ss") = "00:00:00" Then
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

    Private Sub CargarSiguienteCelda2(ByRef filaActual As DataGridViewRow, valorAponer As String)
        If String.IsNullOrEmpty(CStr(filaActual.Cells(7).Value).Trim()) OrElse CStr(filaActual.Cells(7).Value).Trim() = "00:00:00" Then 'busca la primer posición vacía d las celdas 4,5,6
            filaActual.Cells(7).Value = valorAponer
        End If
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


    Private Sub Ordenar2()
        'ORDENA EL DATAGRID Y PONE LAS POSICIONES
        dgvDataListado2.Sort(dgvDataListado2.Columns(COLUMNA_MEJOR_TIEMPO), System.ComponentModel.ListSortDirection.Ascending)
        Dim cont As Integer
        cont = 0
        For Each rows As DataGridViewRow In Me.dgvDataListado2.Rows
            cont = cont + 1
            rows.Cells(COLUMNA_POSICION).Value = cont
        Next
    End Sub

    Private Sub CargarSiguienteCelda3(ByRef filaActual As DataGridViewRow, valorAponer As String)
        filaActual.Cells(COLUMNA_MEJOR_TIEMPO).Value = valorAponer
        If String.IsNullOrEmpty(CStr(filaActual.Cells(7).Value).Trim()) OrElse CStr(filaActual.Cells(7).Value).Trim() = "00:00:00" Then 'busca la primer posición vacía d las celdas 4,5,6
            filaActual.Cells(7).Value = valorAponer
        End If
    End Sub

    Private Sub Ordenar3()
        'ORDENA EL DATAGRID Y PONE LAS POSICIONES
        dgvDataListado3.Sort(dgvDataListado3.Columns(COLUMNA_MEJOR_TIEMPO), System.ComponentModel.ListSortDirection.Ascending)
        Dim cont As Integer
        cont = 0
        For Each rows As DataGridViewRow In Me.dgvDataListado3.Rows
            cont = cont + 1
            rows.Cells(COLUMNA_POSICION).Value = cont
        Next
    End Sub

    'ABRE EL FORMULARIO PARA SELECCIONAR EL JUEZ DE LA COMPETENCIA DE LA DISTANCIA 1
    Private Sub btnBuscarJuez1_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarJuez1.Click
        frmJuez.txtFlag.Text = "1"
        frmJuez.ShowDialog()
    End Sub

    Private Sub btnSinTiempo1_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSinTiempo1.Click
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

    '--------------------------------------------BOTON ACTUALIZAR FUNCIONA BIEN----------------------------------------
    Private Sub btnActualizar1_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar1.Click
        If dgvDataListado1.Rows.Count > 0 Then
            Try
                For i As Integer = 0 To dgvDataListado1.Rows.Count - 1
                    'ACTUALIZA LA TABLA RESULTADO
                    Resultado_Final.gid_resultado = dgvDataListado1.Rows(i).Cells("Id_Resultado1").Value
                    Resultado_Final.gtiempo = dgvDataListado1.Rows(i).Cells("Tiempo1").Value
                    Resultado_Final.gposicion = dgvDataListado1.Rows(i).Cells("Posicion1").Value

                    Funcion_Resultado.editar(Resultado_Final)

                    'ACTUALIZA LA TABLA ATLETAS POR COMPETENCIA
                    Atleta_Competencia_Final.gid_atleta = dgvDataListado1.Rows(i).Cells("Id_Atleta1").Value
                    Atleta_Competencia_Final.gid_resultado = dgvDataListado1.Rows(i).Cells("Id_Resultado1").Value
                    Atleta_Competencia_Final.gdorsal = dgvDataListado1.Rows(i).Cells("Dorsal1").Value
                    Atleta_Competencia_Final.grepresentacion = dgvDataListado1.Rows(i).Cells("Representa1").Value
                    Atleta_Competencia_Final.gid_competencia = txtIdCompetencia1.Text
                    Atleta_Competencia_Final.gfecha = dtpFecha1.Text
                    Atleta_Competencia_Final.ghora = txtHora1.Text
                    Atleta_Competencia_Final.gdistancia1 = txtDistancia1.Text
                    Atleta_Competencia_Final.gdistancia2 = txtDistancia2.Text
                    Atleta_Competencia_Final.gdistancia3 = txtDistancia3.Text
                    Atleta_Competencia_Final.gid_juez = txtIdJuez1.Text

                    Funcion_Atleta_Competencia.editar(Atleta_Competencia_Final)
                Next
                MessageBox.Show("Los Tiempos se han actualizado correctamente", "Actualizando Tiempos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnActualizar1.Enabled = False
            Catch ex As Exception
                MsgBox("Error al actualizar los datos de la Planilla")
            End Try
        End If
        btnImprimir1.Enabled = True
    End Sub

    Private Sub btnSalir1_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir1.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarJuez2_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarJuez2.Click
        frmJuez.txtFlag.Text = "1"
        frmJuez.ShowDialog()
    End Sub

    Private Sub btnAgregarAtleta2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta2.Click

        frmAtleta.Show()

        frmAtleta.GroupBox3.Enabled = True
        frmAtleta.GroupBox1.Enabled = False
        frmAtleta.btnEditar.Enabled = False
        frmAtleta.btnGuardar.Enabled = False
    End Sub

    Private Sub btnQuitarAtleta2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtleta2.Click
        If dgvDataListado1.Rows.Count <> 0 Then
            dgvDataListado2.Rows.RemoveAt(dgvDataListado2.CurrentRow.Index)
        Else
            MessageBox.Show("No existen Atletas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub btnSinTiempo2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSinTiempo2.Click
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

    '--------------------------------------------BOTON ACTUALIZAR FUNCIONA BIEN----------------------------------------
    Private Sub btnActualizar2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnActualizar2.Click
        If dgvDataListado2.Rows.Count > 0 Then
            Try
                For i As Integer = 0 To dgvDataListado2.Rows.Count - 1

                    'ACTUALIZA LA TABLA RESULTADO
                    Resultado_Final.gid_resultado = dgvDataListado2.Rows(i).Cells.Item("Id_Resultado2").Value
                    Resultado_Final.gtiempo = dgvDataListado2.Rows(i).Cells.Item("Tiempo2").Value
                    Resultado_Final.gposicion = dgvDataListado2.Rows(i).Cells.Item("Posicion2").Value


                    'ACTUALIZA LA TABLA ATLETAS POR COMPETENCIA

                    Atleta_Competencia_Final.gid_atleta = dgvDataListado2.Rows(i).Cells.Item("Id_Atleta2").Value
                    Atleta_Competencia_Final.gid_resultado = dgvDataListado2.Rows(i).Cells.Item("Id_Resultado2").Value
                    Atleta_Competencia_Final.gdorsal = dgvDataListado2.Rows(i).Cells.Item("Dorsal2").Value
                    Atleta_Competencia_Final.grepresentacion = dgvDataListado2.Rows(i).Cells.Item("Representa2").Value
                    Atleta_Competencia_Final.gid_competencia = txtIdCompetencia2.Text
                    Atleta_Competencia_Final.gfecha = dtpFecha2.Text
                    Atleta_Competencia_Final.ghora = txtHora2.Text
                    Atleta_Competencia_Final.gdistancia1 = txtDistancia1.Text
                    Atleta_Competencia_Final.gdistancia2 = txtDistancia2.Text
                    Atleta_Competencia_Final.gdistancia3 = txtDistancia3.Text
                    Atleta_Competencia_Final.gid_juez = txtIdJuez2.Text
                    Funcion_Resultado.editar(Resultado_Final)
                    Funcion_Atleta_Competencia.editar(Atleta_Competencia_Final)
                Next
                MessageBox.Show("Los Tiempos se han actualizado correctamente", "Actualizando Tiempos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnActualizar2.Enabled = False

            Catch ex As Exception
                MsgBox("Error al actualizar los datos de la Planilla")
            End Try
            btnImprimir2.Enabled = True
        End If
    End Sub

    Private Sub btnSalir2_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir2.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarJuez3_Click_1(sender As System.Object, e As System.EventArgs) Handles btnBuscarJuez3.Click
        frmJuez.txtFlag.Text = "1"
        frmJuez.ShowDialog()
    End Sub

    Private Sub btnAgregarAtleta3_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtleta3.Click
        frmAtleta.Show()

        frmAtleta.GroupBox3.Enabled = True
        frmAtleta.GroupBox1.Enabled = False
        frmAtleta.btnEditar.Enabled = False
        frmAtleta.btnGuardar.Enabled = False
    End Sub

    Private Sub btnQuitarAtleta3_Click_1(sender As System.Object, e As System.EventArgs) Handles btnQuitarAtleta3.Click
        If dgvDataListado3.Rows.Count <> 0 Then
            dgvDataListado3.Rows.RemoveAt(dgvDataListado3.CurrentRow.Index)
        Else
            MessageBox.Show("No existen Atletas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAgregarTiempo3_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregarTiempo3.Click
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

    Private Sub btnSinTiempo3_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSinTiempo3.Click
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

    '--------------------------------------------BOTON ACTUALIZAR FUNCIONA BIEN----------------------------------------
    Private Sub btnActualizar3_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar3.Click
        If dgvDataListado3.Rows.Count > 0 Then
            Try
                For i As Integer = 0 To dgvDataListado3.Rows.Count - 1

                    'ACTUALIZA LA TABLA RESULTADO
                    Resultado_Final.gid_resultado = dgvDataListado3.Rows(i).Cells.Item("Id_Resultado3").Value
                    Resultado_Final.gtiempo = dgvDataListado3.Rows(i).Cells.Item("Tiempo3").Value
                    Resultado_Final.gposicion = dgvDataListado3.Rows(i).Cells.Item("Posicion3").Value

                    'ACTUALIZA LA TABLA ATLETAS POR COMPETENCIA
                    Atleta_Competencia_Final.gid_atleta = dgvDataListado3.Rows(i).Cells.Item("Id_Atleta3").Value
                    Atleta_Competencia_Final.gid_resultado = dgvDataListado3.Rows(i).Cells.Item("Id_Resultado3").Value
                    Atleta_Competencia_Final.gdorsal = dgvDataListado3.Rows(i).Cells.Item("Dorsal3").Value
                    Atleta_Competencia_Final.grepresentacion = dgvDataListado3.Rows(i).Cells.Item("Representa3").Value
                    Atleta_Competencia_Final.gid_competencia = txtIdCompetencia3.Text
                    Atleta_Competencia_Final.gfecha = dtpFecha3.Text
                    Atleta_Competencia_Final.ghora = txtHora3.Text
                    Atleta_Competencia_Final.gdistancia1 = txtDistancia1.Text
                    Atleta_Competencia_Final.gdistancia2 = txtDistancia2.Text
                    Atleta_Competencia_Final.gdistancia3 = txtDistancia3.Text
                    Atleta_Competencia_Final.gid_juez = txtIdJuez3.Text

                    Funcion_Resultado.editar(Resultado_Final)
                    Funcion_Atleta_Competencia.editar(Atleta_Competencia_Final)
                Next

                MessageBox.Show("Los Tiempos se han actualizado correctamente", "Actualizando Tiempos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnActualizar3.Enabled = False

            Catch ex As Exception
                MsgBox("Error al actualizar los datos de la Planilla")
            End Try
            btnImprimir3.Enabled = True
        End If
    End Sub

    Private Sub btnImprimir1_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir1.Click
        Dim OpcionImpresion1 As New frmImprimir
        OpcionImpresion1.ShowDialog()
    End Sub

    Private Sub btnImprimir2_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir2.Click
        Dim OpcionImpresion2 As New frmImprimir
        OpcionImpresion2.ShowDialog()

        'Dim reportedistancia2 As New frmDistancia2
        'reportedistancia2.ShowDialog()
    End Sub

    Private Sub btnComenzar3_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir3.Click
        Dim OpcionImpresion3 As New frmImprimir
        OpcionImpresion3.ShowDialog()

        'Dim reportedistancia3 As New frmDistancia3
        'reportedistancia3.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class







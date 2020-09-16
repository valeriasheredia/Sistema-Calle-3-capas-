Public Class frmAtleta
    Private dt As New DataTable

    Shared Property AtletaSeleccionado1 As New vAtleta
    Shared Property AtletaDorsal1 As New vAtleta_x_Competencia
    Shared Property Tiempos1 As New vResultado

    Shared Property AtletaSeleccionado2 As New vAtleta
    Shared Property AtletaDorsal2 As New vAtleta_x_Competencia

    Shared Property AtletaSeleccionado3 As New vAtleta
    Shared Property AtletaDorsal3 As New vAtleta_x_Competencia

    Public Property Formulario As TipoFormulario

    Private Sub frmAtleta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        PrepararFormulario()
        Me.Datalistado.ClearSelection()
    End Sub

    'CARGA EN EL DATAGRIDVIEW EL LISTADO DE ATLETAS
    Private Sub mostrar()
        Try
            Dim func As New fAtleta
            dt = func.mostrar
            Datalistado.Columns.Item("Eliminar").Visible = False
            cboSexo.SelectedIndex = 0
            cboProvincia.SelectedIndex = 0

            If dt.Rows.Count <> 0 Then
                '  Datalistado.ClearSelection()
                Datalistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
                Datalistado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
                Datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
                Datalistado.DataSource = dt
                Datalistado.Columns(1).HeaderText = "Identificación"
                Datalistado.Columns(1).Visible = False
                Datalistado.Columns(2).HeaderText = "Nombre y Apellido"

                Datalistado.Columns(3).HeaderText = "Documento"
                Datalistado.Columns(4).HeaderText = "Fecha de Nacimiento"
                Datalistado.Columns(5).HeaderText = "Edad"
                Datalistado.Columns(6).HeaderText = "Sexo"
                Datalistado.Columns(7).HeaderText = "Provincia"
                Datalistado.Columns(8).HeaderText = "Teléfono"
                Datalistado.Columns(9).HeaderText = "Correo Electrónico"
                Datalistado.Columns(10).HeaderText = "Dirección"
                txtBuscar.Enabled = True
                Datalistado.ColumnHeadersVisible = True
                lkDatosInexistentes.Visible = False
            Else
                Datalistado.DataSource = Nothing
                txtBuscar.Enabled = False
                Datalistado.ColumnHeadersVisible = False
                lkDatosInexistentes.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ocultar_columnas()
        Datalistado.Columns(1).Visible = False
    End Sub


    ' INSERTA UN NUEVO ATLETA
    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If txtNombreApellido.Text = "" Then
            MsgBox("Complete el nombre y apellido del atleta")
            txtNombreApellido.Focus()
            Exit Sub
        End If
        'If txtDni.Text = "" Then
        '    MsgBox("Complete el campo del Dni del Atleta, éste no puede estar vacio")
        '    txtDni.Focus()
        '    Exit Sub
        'End If
        If txtEdad.Text = "" Then
            MsgBox("Complete el campo de la Edad del Atleta, éste no puede estar vacio")
            txtEdad.Focus()
            Exit Sub
        End If

        Try
            Dim dts As New vAtleta
            Dim func As New fAtleta
            dts.gnombre_apellido = txtNombreApellido.Text
            dts.gdni = txtDni.Text
            dts.gfecha_nacimiento = dtpFecha.Text
            dts.gedad = txtEdad.Text
            dts.gsexo = cboSexo.Text
            dts.gdireccion = txtDireccion.Text
            dts.gprovincia = cboProvincia.Text
            dts.gtelefono = txtTelefono.Text
            dts.gmail = txtCorreoElectronico.Text
            If func.insertar(dts) Then
                MessageBox.Show("Atleta registrado correctamente", "Guardando atleta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()
            Else
                MessageBox.Show("Atleta no registrado correctamente, intente de nuevo", "Guardando atleta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mostrar()
                limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' Else
        '   MessageBox.Show("Faltan ingresar algunos datos", "Guardando atleta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
    End Sub

    'LIMPIA CAMPOS DEL FORMULARIO
    Public Sub limpiar()
        txtEdad.Text = ""
        txtNombreApellido.Text = ""
        txtDni.Text = ""
        cboSexo.Text = ""
        cboProvincia.Text = ""
        txtTelefono.Text = ""
        txtCorreoElectronico.Text = ""
        txtDireccion.Text = ""
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()
        GroupBox1.Enabled = True
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
    End Sub

    'MODIFICA DATOS DEL ATLETA
    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Desea realmente editar los datos de atleta??", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            If txtNombreApellido.Text = "" Then
                MsgBox("Complete el nombre y apellido del atleta")
                txtNombreApellido.Focus()
                Exit Sub
            End If
            If txtDni.Text = "" Then
                MsgBox("Complete el campo del Dni del Atleta, éste no puede estar vacio")
                txtDni.Focus()
                Exit Sub
            End If
            If txtEdad.Text = "" Then
                MsgBox("Complete el campo de la Edad del Atleta, éste no puede estar vacio")
                txtEdad.Focus()
                Exit Sub
            End If
            Try
                Dim dts As New vAtleta
                Dim func As New fAtleta
                dts.gid_atleta = txtIdAtleta.Text
                dts.gnombre_apellido = txtNombreApellido.Text
                dts.gdni = txtDni.Text
                dts.gfecha_nacimiento = dtpFecha.Text
                dts.gedad = txtEdad.Text
                dts.gsexo = cboSexo.Text
                dts.gdireccion = txtDireccion.Text
                dts.gprovincia = cboProvincia.Text
                dts.gtelefono = txtTelefono.Text
                dts.gmail = txtCorreoElectronico.Text
                If func.editar(dts) Then
                    MessageBox.Show("Atleta modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Atleta no fue modificado, inténtelo de nuevo", "Modificando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Datalistado_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        frmAtletas_x_Competencia.txtIdJuez1.Text = Datalistado.SelectedCells.Item(1).Value
        frmAtletas_x_Competencia.txtNombreJuez1.Text = Datalistado.SelectedCells.Item(2).Value
    End Sub

    Private Sub PrepararFormulario()
        'Logica de los botones
        GroupBox3.Enabled = False
        Label1.Visible = False
        txtIdAtleta.Visible = False
        txtFlag.Visible = False
        btnAgregaraCompetencia.Enabled = True
        btnNuevo.Enabled = False
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
        txtNombreApellido.Focus()
        mostrar()
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpFecha.ValueChanged
        'Dim fechanac As Date = dtpFecha.Value.Date
        'txtEdad.Text = CalcularEdad(fechanac).ToString
    End Sub

    Private Function Buscar_Atleta_Dni(Grid As DataGridView, Col As String, SearchText As String) As DataGridViewRow
        Return Grid.Rows.Cast(Of DataGridViewRow)().
         FirstOrDefault(Function(r) Convert.ToString(r.Cells(3).Value).Equals(SearchText))
    End Function

    Private Sub btnBuscar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim Fila = Buscar_Atleta_Dni(Datalistado, "Código", txtBuscar.Text)
        If Fila Is Nothing Then
            MessageBox.Show("No se ha encontrado al Atleta")
            btnNuevo.Enabled = True
            Return
        End If
        Datalistado.ClearSelection()
        Datalistado.CurrentCell = Fila.Cells(3)
        Datalistado.Focus()
        Fila.Selected = True
    End Sub

    'ELIMINA UN ATLETA
    Private Sub btnEliminar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea eliminar el atleta seleccionado?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In Datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_atleta").Value)
                        Dim vdb As New vAtleta
                        Dim func As New fAtleta
                        vdb.gid_atleta = onekey
                        If func.eliminar(vdb) Then
                        Else
                           End If
                    End If
                Next
                MessageBox.Show("El atleta ha sido eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mostrar()
        End If
        limpiar()
    End Sub

    Private Sub ckbEliminar_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles ckbEliminar.CheckedChanged
        If ckbEliminar.CheckState = CheckState.Checked Then
            btnEliminar.Enabled = True
            Datalistado.Columns.Item("Eliminar").Visible = True
        Else
            Datalistado.Columns.Item("Eliminar").Visible = False
            btnEliminar.Enabled = False
        End If
    End Sub

    'HACIENDO CLICK EN EL DATAGRIDVIEW LLENA LOS TEXTBOX Y COMBOBOX PARA PODER SER EDITADOS
    Private Sub Datalistado_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datalistado.CellClick
        txtIdAtleta.Text = Datalistado.SelectedCells.Item(1).Value
        txtNombreApellido.Text = Datalistado.SelectedCells.Item(2).Value
        txtDni.Text = Datalistado.SelectedCells.Item(3).Value
        dtpFecha.Text = Datalistado.SelectedCells.Item(4).Value
        txtEdad.Text = Datalistado.SelectedCells.Item(5).Value
        cboSexo.Text = Datalistado.SelectedCells.Item(6).Value
        cboProvincia.Text = Datalistado.SelectedCells.Item(7).Value
        txtTelefono.Text = Datalistado.SelectedCells.Item(8).Value
        txtCorreoElectronico.Text = Datalistado.SelectedCells.Item(9).Value
        txtDireccion.Text = Datalistado.SelectedCells.Item(10).Value
        btnEditar.Enabled = True
        btnGuardar.Enabled = False
    End Sub

    Private Sub Datalistado_CellContentClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datalistado.CellContentClick
        If e.ColumnIndex = Me.Datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.Datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub


    'FUNCION QUE CALCULA LA EDAD
    Public Function CalcularEdad(ByVal nacimiento As Date) As String
        Dim edad As String = "0"
        If nacimiento.Month > Today.Month Then
            edad = DateDiff(DateInterval.Year, nacimiento, Date.Today).ToString - 1
        Else
            edad = DateDiff(DateInterval.Year, nacimiento, Date.Today).ToString
        End If
        Return edad
    End Function

    Private Sub btnCalcularEdad_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcularEdad.Click
        Dim fechanac As Date = dtpFecha.Value.Date
        txtEdad.Text = CalcularEdad(fechanac).ToString
        '  txtEdad.Enabled = False
    End Sub

    Private Sub txtEdad_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEdad.TextChanged
        If txtEdad.Text <> "" Then
            btnCalcularEdad.Enabled = False
        ElseIf txtEdad.Text = "" Then
            btnCalcularEdad.Enabled = True
        End If
    End Sub

    Private Sub btnAgregaraCompetencia_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregaraCompetencia.Click
        'AGREGA EL ATLETA AL DGVDATALISTADO 1 SI ESTA SELECCIONADO EL TABPAGE1(SELECTEDINDEX=0) (NOMBRE:DISTANCIA1)

        If txtIdAtleta.Text = "" Then
            MessageBox.Show("Debe seleccionar un Atleta del listado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            If txtDorsal.Text = "" Then
                MessageBox.Show("Debe ingresar el Dorsal del Atleta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtDorsal.Focus()
                Exit Sub
            End If

            Dim existe As Boolean = False
            For Each row As DataGridViewRow In frmAtletas_x_Competencia.dgvDataListado1.Rows
                If CStr(row.Cells("Dorsal1").Value) = txtDorsal.Text Then
                    existe = True
                    Exit For
                End If
            Next
            If existe Then
                MsgBox("El Dorsal ya fue designado a otro atleta, por favor elija otro")
            Else
                AtletaSeleccionado1.gid_atleta = txtIdAtleta.Text
                AtletaSeleccionado1.gnombre_apellido = txtNombreApellido.Text
                AtletaSeleccionado1.gdni = txtDni.Text
                AtletaSeleccionado1.gedad = txtEdad.Text

                AtletaDorsal1.gdorsal = txtDorsal.Text
                AtletaDorsal1.grepresentacion = txtRepresenta.Text
                If frmAtletas_x_Competencia.TabControl1.SelectedIndex = 0 Then
                    frmAtletas_x_Competencia.AgregarRegistroAGrilla1(AtletaSeleccionado1, AtletaDorsal1)
                End If
            End If
        End If
        
        '------------------------------------------------------------------------------------------------------------------
        If txtIdAtleta.Text = "" Then
            MessageBox.Show("Debe seleccionar un Atleta del listado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            If txtDorsal.Text = "" Then
                MessageBox.Show("Debe ingresar el Dorsal del Atleta..", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtDorsal.Focus()
                Exit Sub
            End If
            Dim existe As Boolean = False
            For Each row As DataGridViewRow In frmAtletas_x_Competencia.dgvDataListado2.Rows
                If CStr(row.Cells("Dorsal2").Value) = txtDorsal.Text Then
                    existe = True
                    Exit For
                End If
            Next
            If existe Then
                MsgBox("El Dorsal ya fue designado a otro atleta, por favor elija otro")
            Else
                AtletaSeleccionado2.gid_atleta = txtIdAtleta.Text
                AtletaSeleccionado2.gnombre_apellido = txtNombreApellido.Text
                AtletaSeleccionado2.gdni = txtDni.Text
                AtletaSeleccionado2.gedad = txtEdad.Text

                AtletaDorsal2.gdorsal = txtDorsal.Text
                AtletaDorsal2.grepresentacion = txtRepresenta.Text
                If frmAtletas_x_Competencia.TabControl1.SelectedIndex = 1 Then
                    frmAtletas_x_Competencia.AgregarRegistroAGrilla2(AtletaSeleccionado2, AtletaDorsal2)
                End If
            End If
        End If
        '----------------------------------------------------------------------------------------------------------------------

        If txtIdAtleta.Text = "" Then
            MessageBox.Show("Debe seleccionar un Atleta del listado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            If txtDorsal.Text = "" Then
                MessageBox.Show("Debe ingresar el Dorsal del Atleta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtDorsal.Focus()
                Exit Sub
            End If
            Dim existe As Boolean = False
            For Each row As DataGridViewRow In frmAtletas_x_Competencia.dgvDataListado3.Rows
                If CStr(row.Cells("Dorsal3").Value) = txtDorsal.Text Then
                    existe = True
                    Exit For
                End If
            Next
            If existe Then
                MsgBox("El Dorsal ya fue designado a otro atleta, por favor elija otro")
            Else
                AtletaSeleccionado3.gid_atleta = txtIdAtleta.Text
                AtletaSeleccionado3.gnombre_apellido = txtNombreApellido.Text
                AtletaSeleccionado3.gdni = txtDni.Text
                AtletaSeleccionado3.gedad = txtEdad.Text

                AtletaDorsal3.gdorsal = txtDorsal.Text
                AtletaDorsal3.grepresentacion = txtRepresenta.Text
                If frmAtletas_x_Competencia.TabControl1.SelectedIndex = 2 Then
                    frmAtletas_x_Competencia.AgregarRegistroAGrilla3(AtletaSeleccionado3, AtletaDorsal3)
                End If
            End If
        End If
        frmAtletas_x_Competencia.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        importarExcel(Datalistado)
    End Sub
End Class

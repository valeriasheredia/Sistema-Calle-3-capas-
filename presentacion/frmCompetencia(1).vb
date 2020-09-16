Public Class frmCompetencia

    Private dt As New DataTable

    Private Sub frmCompetencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrepararFormulario()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fCompetencia
            dt = func.mostrar
            Datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                Datalistado.DataSource = dt
               
                txtBuscar.Enabled = True
                Datalistado.ColumnHeadersVisible = True
                Datalistado.Columns(2).HeaderText = "Nombre"
                Datalistado.Columns(3).HeaderText = "Lugar"
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
        btnNuevo.Visible = True
        btnEditar.Enabled = False
        buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            dv.RowFilter = cboCampo.Text & " like '" & txtBuscar.Text & "% '"
            If dv.Count <> 0 Then
                lkDatosInexistentes.Visible = False
                Datalistado.DataSource = dv
                ocultar_columnas()
            Else
                lkDatosInexistentes.Visible = True
                Datalistado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        Datalistado.Columns(1).Visible = False
    End Sub

    Private Sub txtBuscar_TextChanged(sender As System.Object, e As System.EventArgs)
        buscar()
    End Sub


    Private Sub txtNombreCompetencia_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombreCompetencia.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre de la competencia")

        End If
    End Sub


    'Private Sub txtLugarCompetencia_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtLugarCompetencia.Validating
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.ErrorIcono.SetError(sender, "")
    '    Else
    '        Me.ErrorIcono.SetError(sender, "Ingrese el lugar de la competencia")
    '    End If
    'End Sub

    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtNombreCompetencia.Text = ""
        txtLugarCompetencia.Text = ""

    End Sub

    Sub PrepararFormulario()
        mostrar()
        Label1.Visible = False
        txtIdCompetencia.Visible = False
        btnEliminar.Enabled = False
        btnAgregarAtletas.Enabled = False
    End Sub

    Private Sub ckbEliminar_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles ckbEliminar.CheckedChanged
        If ckbEliminar.CheckState = CheckState.Checked Then
            Datalistado.Columns.Item("Eliminar").Visible = True
            btnEliminar.Enabled = True
        Else
            Datalistado.Columns.Item("Eliminar").Visible = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnNuevo_Click_1(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()
    End Sub

    Private Sub btnGuardar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If ValidateChildren() = True And txtNombreCompetencia.Text <> "" And txtLugarCompetencia.Text <> "" Then
            Try
                Dim dts As New vCompetencia
                Dim func As New fCompetencia

                dts.gnombre_competencia = txtNombreCompetencia.Text
                dts.glugar_competencia = txtLugarCompetencia.Text
                If func.insertar(dts) Then
                    MessageBox.Show("Competencia registrada correctamente", "Guardando competencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Competencia no registrada correctamente, intente de nuevo", "Guardando competencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Guardando competencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEditar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Desea realmente editar los datos de la competencia??", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            If Me.ValidateChildren = True And txtNombreCompetencia.Text <> "" And txtLugarCompetencia.Text <> "" Then
                Try
                    Dim dts As New vCompetencia
                    Dim func As New fCompetencia

                    dts.gid_competencia = txtIdCompetencia.Text
                    dts.gnombre_competencia = txtNombreCompetencia.Text
                    dts.glugar_competencia = txtLugarCompetencia.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Competencia modificada correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Competencia no fue modificada, inténtelo de nuevo", "Modificando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Faltan ingresar datos", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Datalistado_CellClick1(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datalistado.CellClick
        txtIdCompetencia.Text = Datalistado.SelectedCells.Item(1).Value
        txtNombreCompetencia.Text = Datalistado.SelectedCells.Item(2).Value
        txtLugarCompetencia.Text = Datalistado.SelectedCells.Item(3).Value
        btnEditar.Enabled = True
        btnGuardar.Enabled = False
        btnAgregarAtletas.Enabled = True
    End Sub

    Private Sub Datalistado_CellContentClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datalistado.CellContentClick
        If e.ColumnIndex = Me.Datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.Datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btnEliminar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea eliminar la competencia seleccionada?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In Datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_competencia").Value)
                        Dim vdb As New vCompetencia
                        Dim func As New fCompetencia
                        vdb.gid_competencia = onekey
                        If func.eliminar(vdb) Then
                        Else
                             End If
                    End If
                Next
                MessageBox.Show("La competencia ha sido eliminada", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btnAgregarAtletas_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregarAtletas.Click
        frmAtletas_x_Competencia.txtNombreCompetencia1.Text = txtNombreCompetencia.Text
        frmAtletas_x_Competencia.txtLugarCompetencia1.Text = txtLugarCompetencia.Text
        frmAtletas_x_Competencia.txtIdCompetencia1.Text = txtIdCompetencia.Text

        frmAtletas_x_Competencia.txtNombreCompetencia2.Text = txtNombreCompetencia.Text
        frmAtletas_x_Competencia.txtLugarCompetencia2.Text = txtLugarCompetencia.Text
        frmAtletas_x_Competencia.txtIdCompetencia2.Text = txtIdCompetencia.Text

        frmAtletas_x_Competencia.txtNombreCompetencia3.Text = txtNombreCompetencia.Text
        frmAtletas_x_Competencia.txtLugarCompetencia3.Text = txtLugarCompetencia.Text
        frmAtletas_x_Competencia.txtIdCompetencia3.Text = txtIdCompetencia.Text

        frmAtletas_x_Competencia.ShowDialog()
    End Sub
End Class
Public Class frmJuez
    Private dt As New DataTable

    Private Sub frmJuez_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fJuez
            dt = func.mostrar
            Datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                Datalistado.DataSource = dt
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
        btnNuevo.Visible = True
        btnEditar.Visible = False
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

    Private Sub txtBuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub txtNombreJuez_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombreJuez.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre y apellido del juez")
        End If
    End Sub

    Private Sub txtDni_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDni.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el dni del juez")
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        ' ValidateChildren() = True 'valida q todas las cajas de texto esten validadas
        If ValidateChildren() = True And txtNombreJuez.Text <> "" And txtDni.Text <> "" Then
            Try
                Dim dts As New vJuez
                Dim func As New fJuez
                dts.gnombre_apellido = txtNombreJuez.Text
                dts.gdni = txtDni.Text
                dts.gtelefono = txtTelefono.Text
                dts.gmail = txtMail.Text
                dts.gdireccion = txtDireccion.Text
                If func.insertar(dts) Then
                    MessageBox.Show("Juez registrado correctamente", "Guardando Juez", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Juez no registrado, intente de nuevo", "Guardando Juez", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Guardando Juez", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub limpiar()
        btnGuardar.Visible = True
        btnEditar.Visible = False
        txtNombreJuez.Text = ""
        txtDni.Text = ""
        txtTelefono.Text = ""
        txtMail.Text = ""
        txtDireccion.Text = ""
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
        mostrar()
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Desea realmente editar los datos del juez??", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            If Me.ValidateChildren = True And txtNombreJuez.Text <> "" And txtDni.Text <> "" Then
                Try
                    Dim dts As New vJuez
                    Dim func As New fJuez

                    dts.gid_juez = txtIdJuez.Text
                    dts.gnombre_apellido = txtNombreJuez.Text
                    dts.gdni = txtDni.Text
                    dts.gtelefono = txtTelefono.Text
                    dts.gmail = txtMail.Text
                    dts.gdireccion = txtDireccion.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Juez modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("El juez no fue modificado, inténtelo de nuevo", "Modificando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea eliminar el juez seleccionado?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In Datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_juez").Value)
                        Dim vdb As New vJuez
                        Dim func As New fJuez
                        vdb.gid_juez = onekey
                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("La competencia ha sido eliminada", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
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

    Private Sub ckbEliminar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbEliminar.CheckedChanged
        If ckbEliminar.CheckState = CheckState.Checked Then
            Datalistado.Columns.Item("Eliminar").Visible = True
        Else
            Datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub Datalistado_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datalistado.CellClick
        txtIdJuez.Text = Datalistado.SelectedCells.Item(1).Value
        txtNombreJuez.Text = Datalistado.SelectedCells.Item(2).Value
        txtDni.Text = Datalistado.SelectedCells.Item(3).Value
        txtTelefono.Text = Datalistado.SelectedCells.Item(4).Value
        txtMail.Text = Datalistado.SelectedCells.Item(5).Value
        txtDireccion.Text = Datalistado.SelectedCells.Item(6).Value
        btnEditar.Visible = True
        btnGuardar.Visible = False
    End Sub


    Private Sub Datalistado_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datalistado.CellContentClick
        If e.ColumnIndex = Me.Datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.Datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub Datalistado_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datalistado.CellDoubleClick
        If txtFlag.Text = "1" Then
            frmAtletas_x_Competencia.txtIdJuez1.Text = Datalistado.SelectedCells.Item(1).Value
            frmAtletas_x_Competencia.txtNombreJuez1.Text = Datalistado.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub

End Class
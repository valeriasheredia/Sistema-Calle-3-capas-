﻿Public Class frmUsuario
    Private dt As New DataTable

    Private Sub frmUsuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        PrepararFormulario()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fUsuario
            dt = func.mostrar
            Datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then

                Datalistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
                Datalistado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
                Datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
                Datalistado.DataSource = dt
                txtBuscar.Enabled = True
                Datalistado.ColumnHeadersVisible = True
                Datalistado.Columns(1).HeaderText = "Identificación"
                Datalistado.Columns(1).Visible = False
                Datalistado.Columns(2).HeaderText = "Nombre y Apellido"
                Datalistado.Columns(3).HeaderText = "Documento"
                Datalistado.Columns(4).HeaderText = "Teléfono"
                Datalistado.Columns(5).HeaderText = "Dirección"
                Datalistado.Columns(6).HeaderText = "Nombre de Usuario"
                Datalistado.Columns(7).HeaderText = "Contraseña"
                Datalistado.Columns(8).HeaderText = "Acceso"
                Datalistado.Columns(8).Visible = False
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
        btnNuevo.Enabled = True
        btnEditar.Enabled = False
    End Sub

    Private Sub ocultar_columnas()
        Datalistado.Columns(1).Visible = False
    End Sub

    Private Sub txtNombreUsuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre y apellido del usuario")
        End If
    End Sub

    Private Sub txtPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese una contraseña")
        End If
    End Sub

    Private Sub txtLogin_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese un nombre de usuario")
        End If
    End Sub

    Private Sub txtDni_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Dni del usuario")
        End If
    End Sub


    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Me.Width = 980
        limpiar()
        mostrar()
    End Sub

    Public Sub limpiar()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        txtNombreUsuario.Text = ""
        txtDni.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtLogin.Text = ""
        txtPassword.Text = ""
    End Sub

    ' llena con los datos del usuario cada textbox al hacer clic sobre el datagridview
    Private Sub Datalistado_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datalistado.CellClick
        txtIdUsuario.Text = Datalistado.SelectedCells.Item(1).Value
        txtNombreUsuario.Text = Datalistado.SelectedCells.Item(2).Value
        txtDni.Text = Datalistado.SelectedCells.Item(3).Value
        txtTelefono.Text = Datalistado.SelectedCells.Item(4).Value
        txtDireccion.Text = Datalistado.SelectedCells.Item(5).Value
        txtLogin.Text = Datalistado.SelectedCells.Item(6).Value
        txtPassword.Text = Datalistado.SelectedCells.Item(7).Value
        txtAcceso.Text = Datalistado.SelectedCells.Item(8).Value
        btnEditar.Enabled = True
        btnGuardar.Enabled = False
    End Sub

    Private Sub Datalistado_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datalistado.CellContentClick
        If e.ColumnIndex = Me.Datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.Datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub ckbEliminar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbEliminar.CheckedChanged
        If ckbEliminar.CheckState = CheckState.Checked Then
            Datalistado.Columns.Item("Eliminar").Visible = True
            btnEliminar.Enabled = True
        Else
            Datalistado.Columns.Item("Eliminar").Visible = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea eliminar el usuario seleccionado?", "Eliminando Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In Datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_usuario").Value)
                        Dim vdb As New vUsuario
                        Dim func As New fUsuario
                        vdb.gid_usuario = onekey
                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("El usuario ha sido eliminado", "Eliminando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
                mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminacion de registros", "Eliminando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mostrar()
        End If
        limpiar()
    End Sub

    Sub PrepararFormulario()
        ' Me.Width = 600
        mostrar()
        btnEliminar.Enabled = False
        Label1.Visible = False
        Acceso.Visible = False
        txtAcceso.Visible = False
        txtIdUsuario.Visible = False
    End Sub

    Private Function Buscar_Usuario_Dni(Grid As DataGridView, Col As String, SearchText As String) As DataGridViewRow
        Return Grid.Rows.Cast(Of DataGridViewRow)().
         FirstOrDefault(Function(r) Convert.ToString(r.Cells(3).Value).Equals(SearchText))
    End Function

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim Fila = Buscar_Usuario_Dni(Datalistado, "Dni", txtBuscar.Text)
        If Fila Is Nothing Then
            MessageBox.Show("No se ha encontrado al Usuario")
            btnNuevo.Enabled = True
            Return
        End If
        Datalistado.ClearSelection()
        Datalistado.CurrentCell = Fila.Cells(3)
        Datalistado.Focus()
        Fila.Selected = True
    End Sub

    Private Sub btnGuardar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If txtNombreUsuario.Text = "" Then
            MessageBox.Show("Complete el campo Nombre y Apellido del Usuario", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombreUsuario.Focus()
            Exit Sub
        End If

        If txtDni.Text = "" Then
            MessageBox.Show("Complete el campo Dni del Usuario", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDni.Focus()
            Exit Sub
        End If

        If txtLogin.Text = "" Then
            MessageBox.Show("Complete el campo Nombre de Usuario", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtLogin.Focus()
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MessageBox.Show("Complete el campo Contraseña del Usuario", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPassword.Focus()
            Exit Sub
        End If
        Try
            Dim dts As New vUsuario
            Dim func As New fUsuario
            dts.gnombre_apellido = txtNombreUsuario.Text
            dts.gdni = txtDni.Text
            dts.gtelefono = txtTelefono.Text
            dts.gdireccion = txtDireccion.Text
            dts.glogin = txtLogin.Text
            dts.gpassword = txtPassword.Text
            dts.gacceso = txtAcceso.Text
            If func.insertar(dts) Then
                MessageBox.Show("Usuario registrado correctamente", "Guardando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()
            Else
                MessageBox.Show("Usuario no registrado, intente de nuevo", "Guardando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mostrar()
                limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' Else
        ' MessageBox.Show("Faltan ingresar algunos datos", "Guardando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '  End If
    End Sub

    Private Sub btnEditar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Desea realmente editar los datos del Usuario??", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            If txtNombreUsuario.Text = "" Then
                MessageBox.Show("Complete el campo Nombre y Apellido del Usuario", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNombreUsuario.Focus()
                Exit Sub
            End If

            If txtDni.Text = "" Then
                MessageBox.Show("Complete el campo Dni del Usuario", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtDni.Focus()
                Exit Sub
            End If

            If txtNombreUsuario.Text = "" Then
                MessageBox.Show("Complete el campo Nombre de Usuario", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNombreUsuario.Focus()
                Exit Sub
            End If

            If txtPassword.Text = "" Then
                MessageBox.Show("Complete el campo Contraseña del Usuario", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPassword.Focus()
                Exit Sub
            End If
            Try
                Dim dts As New vUsuario
                Dim func As New fUsuario
                dts.gid_usuario = txtIdUsuario.Text
                dts.gnombre_apellido = txtNombreUsuario.Text
                dts.gdni = txtDni.Text
                dts.gtelefono = txtTelefono.Text
                dts.gdireccion = txtDireccion.Text
                dts.glogin = txtLogin.Text
                dts.gpassword = txtPassword.Text
                dts.gacceso = txtAcceso.Text
                If func.editar(dts) Then
                    MessageBox.Show("Usuario modificado correctamente", "Modificando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("El Usuario no fue modificado, inténtelo nuevamente", "Modificando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
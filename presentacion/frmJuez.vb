Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmJuez
    Public cn As SqlConnection
    Public cmd As SqlCommand
    Public adaptador As SqlDataAdapter
    Public conn As New conexion
    Private dt As New DataTable

    Private Sub frmJuez_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        mostrar()
        ' Me.Width = 599
        btnNuevo.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
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
    End Sub

    Private Sub ocultar_columnas()
        Datalistado.Columns(1).Visible = False
    End Sub

    Private Sub txtNombreJuez_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre y apellido del juez")
        End If
    End Sub

    Private Sub txtDni_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el dni del juez")
        End If
    End Sub

    Public Sub limpiar()
        'btnGuardar.Visible = True
        'btnEditar.Visible = False
        txtNombreJuez.Text = ""
        txtDni.Text = ""
        txtTelefono.Text = ""
        txtMail.Text = ""
        txtDireccion.Text = ""
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs)
        limpiar()
        mostrar()
    End Sub

   

    Private Sub Datalistado_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        'If e.ColumnIndex = Me.Datalistado.Columns.Item("Eliminar").Index Then
        '    Dim chkcell As DataGridViewCheckBoxCell = Me.Datalistado.Rows(e.RowIndex).Cells("Eliminar")
        '    chkcell.Value = Not chkcell.Value
        'End If
    End Sub


    Private Sub btnGuardar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

        If txtNombreJuez.Text = "" Then
            MessageBox.Show("Complete el campo Nombre y Apellido del juez", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If txtDni.Text = "" Then
            MessageBox.Show("Complete el campo Dni del juez", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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
    End Sub

    Private Function Buscar_Juez_Dni(Grid As DataGridView, Col As String, SearchText As String) As DataGridViewRow
        Return Grid.Rows.Cast(Of DataGridViewRow)().
         FirstOrDefault(Function(r) Convert.ToString(r.Cells(3).Value).Equals(SearchText))
    End Function

    Private Sub btnBuscar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim Fila = Buscar_Juez_Dni(Datalistado, "Dni", txtBuscar.Text)
        If Fila Is Nothing Then
            MessageBox.Show("No se ha encontrado al Juez")
            Return
        End If
        Datalistado.ClearSelection()
        Datalistado.CurrentCell = Fila.Cells(3)
        Datalistado.Focus()
        Fila.Selected = True
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Desea realmente editar los datos del juez??", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            If txtNombreJuez.Text = "" Then
                MessageBox.Show("Complete el campo Nombre y Apellido del juez", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If txtDni.Text = "" Then
                MessageBox.Show("Complete el campo Dni del juez", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
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
        End If
    End Sub

    Private Sub btnCancelar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Datalistado_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datalistado.CellClick
        txtIdJuez.Text = Datalistado.SelectedCells.Item(1).Value
        txtNombreJuez.Text = Datalistado.SelectedCells.Item(2).Value
        txtDni.Text = Datalistado.SelectedCells.Item(3).Value
        txtTelefono.Text = Datalistado.SelectedCells.Item(4).Value
        txtMail.Text = Datalistado.SelectedCells.Item(5).Value
        txtDireccion.Text = Datalistado.SelectedCells.Item(6).Value
        btnEditar.Enabled = True
        btnGuardar.Enabled = False
    End Sub

    Private Sub Datalistado_CellClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datalistado.CellContentClick
    
        If e.ColumnIndex = Me.Datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.Datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub Datalistado_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Datalistado.CellContentDoubleClick
        If txtFlag.Text = "1" Then
            frmAtletas_x_Competencia.txtIdJuez1.Text = Datalistado.SelectedCells.Item(1).Value
            frmAtletas_x_Competencia.txtNombreJuez1.Text = Datalistado.SelectedCells.Item(2).Value
            Me.Close()
        End If
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

    Private Sub btnEliminar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
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
                            MessageBox.Show("El juez ha sido eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btnNuevo_Click_1(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        btnEditar.Enabled = False
        btnGuardar.Enabled = True
    End Sub
End Class
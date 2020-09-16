Public Class frmLogin

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtNombreUsuario.Focus()
        lblHora.Text = TimeOfDay
        txtNombreUsuario.Focus()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim dts As New vUsuario
            Dim func As New fUsuario
            dts.glogin = txtNombreUsuario.Text
            dts.gpassword = txtContraseña.Text
            If func.validar_usuario(dts) = True Then
                frmInicio.ShowDialog()
                Me.Hide()
            Else
                MsgBox("Los datos son incorrectos, inténtelo de nuevo", MsgBoxStyle.Information, "Acceso denegado")
                txtNombreUsuario.Clear()
                txtContraseña.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeOfDay
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        If MsgBox("desea salir del programa...?", vbQuestion + vbYesNo, "salir") = vbYes Then
            Close()
        End If
    End Sub
End Class
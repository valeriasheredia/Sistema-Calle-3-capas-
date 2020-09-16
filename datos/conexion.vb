Imports System.Data.SqlClient

Public Class conexion
    Protected cnn As New SqlConnection
    Public idusuario As Integer

    Protected Function conectado()
        Try
            cnn = New SqlConnection("Data Source=VALE\VALEVALERIA;Initial Catalog=Sistema de Calle;Integrated Security=True")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class

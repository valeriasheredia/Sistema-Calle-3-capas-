Imports System.Data.SqlClient

Public Class fJuez
    Inherits conexion
    Dim cmd As SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_juez")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar(ByVal dts As vJuez) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_juez")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("nombre_apellido", dts.gnombre_apellido)
            cmd.Parameters.AddWithValue("dni", dts.gdni)
            cmd.Parameters.AddWithValue("telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("mail", dts.gmail)
            cmd.Parameters.AddWithValue("direccion", dts.gdireccion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar(ByVal dts As vJuez) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_juez")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("id_juez", dts.gid_juez)
            cmd.Parameters.AddWithValue("nombre_apellido", dts.gnombre_apellido)
            cmd.Parameters.AddWithValue("dni", dts.gdni)
            cmd.Parameters.AddWithValue("telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("mail", dts.gmail)
            cmd.Parameters.AddWithValue("direccion", dts.gdireccion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function eliminar(ByVal dts As vJuez) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_juez")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("id_juez", SqlDbType.Int).Value = dts.gid_juez
            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

End Class

Imports System.Data.SqlClient

Public Class fAtleta
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_atleta")
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

    Public Function insertar(ByVal dts As vAtleta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_atleta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre_apellido", dts.gnombre_apellido)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@fecha_nacimiento", dts.gfecha_nacimiento)
            cmd.Parameters.AddWithValue("@sexo", dts.gsexo)
            cmd.Parameters.AddWithValue("@provincia", dts.gprovincia)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@mail", dts.gmail)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
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

    Public Function editar(ByVal dts As vAtleta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_atleta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            ' envia los valores al procedimiento almacenado
            cmd.Parameters.AddWithValue("@id_atleta", dts.gid_atleta)
            cmd.Parameters.AddWithValue("@nombre_apellido", dts.gnombre_apellido)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@fecha_nacimiento", dts.gfecha_nacimiento)
            cmd.Parameters.AddWithValue("@sexo", dts.gsexo)
            cmd.Parameters.AddWithValue("@provincia", dts.gprovincia)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@mail", dts.gmail)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)

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

    Public Function eliminar(ByVal dts As vAtleta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_atleta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("id_atleta", SqlDbType.Int).Value = dts.gid_atleta

            If cmd.ExecuteNonQuery = True Then
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

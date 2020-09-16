Imports System.Data.SqlClient

Public Class fCompetencia
    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_competencia")
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

    Public Function insertar(ByVal dts As vCompetencia) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_competencia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre", dts.gnombre_competencia)
            cmd.Parameters.AddWithValue("@lugar", dts.glugar_competencia)
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

    Public Function editar(ByVal dts As vCompetencia) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_competencia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            ' envia los valores al procedimiento almacenado
            cmd.Parameters.AddWithValue("@id_competencia", dts.gid_competencia)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre_competencia)
            cmd.Parameters.AddWithValue("@lugar", dts.glugar_competencia)

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

    Public Function eliminar(ByVal dts As vCompetencia) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_competencia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("id_competencia", SqlDbType.Int).Value = dts.gid_competencia

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

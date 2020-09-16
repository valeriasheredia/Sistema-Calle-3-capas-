Imports System.Data.SqlClient

Public Class fAtleta_x_Competencia
    Inherits conexion
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("[Mostrar_atleta_por_competencia]")
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

    'Public Function insertar(ByVal dts As vAtleta_x_Competencia) As Boolean
    '    Try
    '        conectado()
    '        cmd = New SqlCommand("insertar_atleta_x_competencia")
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = cnn

    '        cmd.Parameters.AddWithValue("@id_atleta", dts.gid_atleta)
    '        cmd.Parameters.AddWithValue("@dorsal", dts.gdorsal)
    '        cmd.Parameters.AddWithValue("@representacion", dts.grepresentacion)
    '        cmd.Parameters.AddWithValue("@id_competencia", dts.gid_competencia)
    '        cmd.Parameters.AddWithValue("@fecha", dts.gfecha)
    '        cmd.Parameters.AddWithValue("@hora", dts.ghora)
    '        cmd.Parameters.AddWithValue("@distancia1", dts.gdistancia1)
    '        cmd.Parameters.AddWithValue("@distancia2", dts.gdistancia2)
    '        cmd.Parameters.AddWithValue("@distancia3", dts.gdistancia3)
    '        cmd.Parameters.AddWithValue("@id_juez", dts.gid_juez)
    '        If cmd.ExecuteNonQuery Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False
    '    Finally
    '        desconectado()
    '    End Try
    'End Function


    Public Sub insertar(ByVal rxc As vAtleta_x_Competencia)
        Try
            conectado()
            da = New SqlDataAdapter("insertar_atleta_x_competencia", cnn)

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@id_atleta", SqlDbType.Int).Value = rxc.gid_atleta
                .Add("@dorsal", SqlDbType.VarChar).Value = rxc.gdorsal
                .Add("@representacion", SqlDbType.VarChar).Value = rxc.grepresentacion
                .Add("@id_competencia", SqlDbType.Int).Value = rxc.gid_competencia
                .Add("@fecha", SqlDbType.Date).Value = rxc.gfecha
                .Add("@hora", SqlDbType.VarChar).Value = rxc.ghora
                .Add("@distancia1", SqlDbType.VarChar).Value = rxc.gdistancia1
                .Add("@distancia2", SqlDbType.VarChar).Value = rxc.gdistancia2
                .Add("@distancia3", SqlDbType.VarChar).Value = rxc.gdistancia3
                .Add("@id_juez", SqlDbType.Int).Value = rxc.gid_juez
                .Add("@id_resultado", SqlDbType.Int).Value = rxc.gid_resultado
            End With
            da.SelectCommand.ExecuteNonQuery()
            da.SelectCommand.CommandType = CommandType.Text
            da.SelectCommand.CommandText = "select @@IDENTITY"
            Dim ds As DataSet = New DataSet
            da.Fill(ds)
            rxc.gid_atleta_x_competencia = ds.Tables(0)(0)(0)
        Catch ex As Exception
            MsgBox("Error al registrar el nuevo atleta a la competencia", MsgBoxStyle.Critical)
        Finally
            desconectado()
        End Try
    End Sub

    Public Function Codigo_Nuevo_Atleta_x_Competencia() As String
        Try
            conectado()
            da = New SqlDataAdapter("Codigo_Nuevo_Atleta_x_Competencia", cnn)
            Return da.SelectCommand.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function editar(ByVal dts As vAtleta_x_Competencia) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_atleta_x_competencia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            ' envia los valores al procedimiento almacenado
            cmd.Parameters.AddWithValue("@id_atleta_x_competencia", dts.gid_atleta_x_competencia)
            cmd.Parameters.AddWithValue("@id_atleta", dts.gid_atleta)
            cmd.Parameters.AddWithValue("@dorsal", dts.gdorsal)
            cmd.Parameters.AddWithValue("@representacion", dts.grepresentacion)
            cmd.Parameters.AddWithValue("@id_competencia", dts.gid_competencia)
            cmd.Parameters.AddWithValue("@fecha", dts.gfecha)
            cmd.Parameters.AddWithValue("@hora", dts.ghora)
            cmd.Parameters.AddWithValue("@distancia1", dts.gdistancia1)
            cmd.Parameters.AddWithValue("@distancia2", dts.gdistancia2)
            cmd.Parameters.AddWithValue("@distancia3", dts.gdistancia3)
            cmd.Parameters.AddWithValue("@id_juez", dts.gid_juez)
            cmd.Parameters.AddWithValue("@id_resultado", dts.gid_resultado)
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

    Public Function eliminar(ByVal dts As vAtleta_x_Competencia) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_atleta_x_competencia")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("id_atleta_x_competencia", SqlDbType.Int).Value = dts.gid_atleta_x_competencia

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

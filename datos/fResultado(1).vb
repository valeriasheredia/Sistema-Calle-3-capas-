Imports System.Data.SqlClient

Public Class fResultado
    Inherits conexion

    Dim cmd As New SqlCommand
    Dim dt As New SqlDataAdapter
    Dim da As SqlDataAdapter

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_resultado")
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

    'Public Function insertar(ByVal dts As vResultado) As Boolean
    '    Try
    '        conectado()
    '        cmd = New SqlCommand("insertar_resultado")
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = cnn
    '        cmd.Parameters.AddWithValue("@tiempo", dts.gtiempo)
    '        cmd.Parameters.AddWithValue("@posicion", dts.gposicion)
    '        cmd.Parameters.AddWithValue("@id_atleta", dts.gid_atleta)
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

    Public Sub insertar(ByVal rxc As vResultado)
        Try
            conectado()
            da = New SqlDataAdapter("insertar_resultado", cnn)

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@id_resultado", SqlDbType.Int).Value = rxc.gid_resultado
                .Add("@tiempo", SqlDbType.VarChar).Value = rxc.gtiempo
                .Add("@posicion", SqlDbType.Int).Value = rxc.gposicion
                .Add("@id_atleta", SqlDbType.Int).Value = rxc.gid_atleta
            End With
            da.SelectCommand.ExecuteNonQuery()
            da.SelectCommand.CommandType = CommandType.Text
            da.SelectCommand.CommandText = "select @@IDENTITY"
            Dim ds As DataSet = New DataSet
            da.Fill(ds)
            rxc.gid_resultado = ds.Tables(0)(0)(0)
        Catch ex As Exception
            MsgBox("Error al registrar el nuevo resultado de la competencia", MsgBoxStyle.Critical)
        Finally
            desconectado()
        End Try
    End Sub

    Public Function editar(ByVal dts As vResultado) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_resultado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            ' envia los valores al procedimiento almacenado
            cmd.Parameters.AddWithValue("id_resultado", dts.gid_resultado)
            cmd.Parameters.AddWithValue("@tiempo", dts.gtiempo)
            cmd.Parameters.AddWithValue("@posicion", dts.gposicion)
            cmd.Parameters.AddWithValue("@id_atleta", dts.gid_atleta)
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

    Public Function eliminar(ByVal dts As vResultado) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_resultado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("id_resultado", SqlDbType.Int).Value = dts.gid_resultado
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

    Public Function Nuevo_Codigo_Resultado() As String
        Try
            conectado()
            da = New SqlDataAdapter("Nuevo_Codigo_Resultado", cnn)
            Return da.SelectCommand.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
End Class

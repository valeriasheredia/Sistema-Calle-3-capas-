﻿Imports System.Data.SqlClient

Public Class fUsuario
    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_usuario")
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

    Public Function insertar(ByVal dts As vusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre_apellido", dts.gnombre_apellido)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)
            cmd.Parameters.AddWithValue("@acceso", dts.gacceso)
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

    Public Function editar(ByVal dts As vusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            ' envia los valores al procedimiento almacenado
            cmd.Parameters.AddWithValue("id_usuario", dts.gid_usuario)
            cmd.Parameters.AddWithValue("@nombre_apellido", dts.gnombre_apellido)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)
            cmd.Parameters.AddWithValue("@acceso", dts.gacceso)
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

    Public Function eliminar(ByVal dts As vusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("id_usuario", SqlDbType.Int).Value = dts.gid_usuario

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

    Public Function validar_usuario(ByVal dts As vUsuario)
        Try
            conectado()
            cmd = New SqlCommand("validar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
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

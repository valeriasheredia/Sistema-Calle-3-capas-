Imports System.Data.SqlClient
Public Class fBackup
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function backupbase() As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Backup_Base")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
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
End Class

Public Class frmBackupBase

    Private Sub btnBackup_Click(sender As System.Object, e As System.EventArgs) Handles btnBackup.Click
        Try
            Dim func As New fBackup
            If func.backupbase Then
                MessageBox.Show("Backup generado satisfactoriamente", "Backup Base", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Backup no puede ser generado", "Backup Base", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
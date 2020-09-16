Imports System.Windows.Forms

Public Class frmInicio

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub AtletasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmAtleta.MdiParent = Me
        frmAtleta.Show()

    End Sub

    Private Sub CompetenciasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CompetenciasToolStripMenuItem.Click
        frmCompetencia.MdiParent = Me
        frmCompetencia.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmUsuario.MdiParent = Me
        frmUsuario.Show()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        frmBackupBase.MdiParent = Me
        frmBackupBase.Show()
    End Sub

    Private Sub NuevaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmCompetencia.MdiParent = Me
        frmCompetencia.Show()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InicioToolStripMenuItem.Click
        Dim nuevousuario As New frmUsuario
        nuevousuario.ShowDialog()
    End Sub

    Private Sub AtletasToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles AtletasToolStripMenuItem.Click
        Dim nuevoatleta As New frmAtleta
        nuevoatleta.ShowDialog()
    End Sub

    Private Sub JuecesToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles JuecesToolStripMenuItem.Click
        frmJuez.MdiParent = Me
        frmJuez.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("desea salir del programa...?", vbQuestion + vbYesNo, "salir") = vbYes Then
            Close()
        End If
    End Sub

    Private Sub frmInicio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                ctl.BackgroundImage = New Bitmap("E:\Sistema de Calle\logo corriendo.JPG")
            End If
        Next
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAcercade.ShowDialog()
    End Sub
End Class

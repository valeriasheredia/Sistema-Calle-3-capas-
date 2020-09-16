<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimir
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbtMasculino = New System.Windows.Forms.RadioButton()
        Me.rbtFemenino = New System.Windows.Forms.RadioButton()
        Me.cboOpcionImpresion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.cboOpcionImpresion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 266)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de Impresión"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtHasta)
        Me.GroupBox2.Controls.Add(Me.txtDesde)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 81)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Por Edad"
        '
        'txtHasta
        '
        Me.txtHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHasta.Location = New System.Drawing.Point(236, 21)
        Me.txtHasta.Multiline = True
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(58, 41)
        Me.txtHasta.TabIndex = 15
        Me.txtHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDesde
        '
        Me.txtDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesde.Location = New System.Drawing.Point(88, 21)
        Me.txtDesde.Multiline = True
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(58, 41)
        Me.txtDesde.TabIndex = 14
        Me.txtDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(173, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Desde"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbtMasculino)
        Me.GroupBox3.Controls.Add(Me.rbtFemenino)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(328, 91)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Por Sexo"
        '
        'rbtMasculino
        '
        Me.rbtMasculino.AutoSize = True
        Me.rbtMasculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMasculino.Location = New System.Drawing.Point(169, 36)
        Me.rbtMasculino.Name = "rbtMasculino"
        Me.rbtMasculino.Size = New System.Drawing.Size(114, 28)
        Me.rbtMasculino.TabIndex = 16
        Me.rbtMasculino.TabStop = True
        Me.rbtMasculino.Text = "Masculino"
        Me.rbtMasculino.UseVisualStyleBackColor = True
        '
        'rbtFemenino
        '
        Me.rbtFemenino.AutoSize = True
        Me.rbtFemenino.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFemenino.Location = New System.Drawing.Point(31, 36)
        Me.rbtFemenino.Name = "rbtFemenino"
        Me.rbtFemenino.Size = New System.Drawing.Size(115, 28)
        Me.rbtFemenino.TabIndex = 15
        Me.rbtFemenino.TabStop = True
        Me.rbtFemenino.Text = "Femenino"
        Me.rbtFemenino.UseVisualStyleBackColor = True
        '
        'cboOpcionImpresion
        '
        Me.cboOpcionImpresion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOpcionImpresion.FormattingEnabled = True
        Me.cboOpcionImpresion.Items.AddRange(New Object() {"General", "Por Edad", "Por Sexo", "Por Sexo y Edad"})
        Me.cboOpcionImpresion.Location = New System.Drawing.Point(168, 31)
        Me.cboOpcionImpresion.Name = "cboOpcionImpresion"
        Me.cboOpcionImpresion.Size = New System.Drawing.Size(180, 28)
        Me.cboOpcionImpresion.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Seleccionar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.Sistema_de_Calle.My.Resources.Resources.cancel
        Me.btnCancelar.Location = New System.Drawing.Point(328, 375)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(62, 47)
        Me.btnCancelar.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Sistema_de_Calle.My.Resources.Resources.print
        Me.btnImprimir.Location = New System.Drawing.Point(260, 375)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(62, 47)
        Me.btnImprimir.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Imprimir")
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Sistema_de_Calle.My.Resources.Resources.logo_corriendo
        Me.PictureBox1.Location = New System.Drawing.Point(24, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(366, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'frmImprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(415, 429)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Name = "frmImprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:.  Imprimir .:."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHasta As System.Windows.Forms.TextBox
    Friend WithEvents txtDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents cboOpcionImpresion As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

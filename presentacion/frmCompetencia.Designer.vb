<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompetencia
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboDistancias = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtLugarCompetencia = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtNombreCompetencia = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lkDatosInexistentes = New System.Windows.Forms.LinkLabel()
        Me.btnAgregarAtletas = New System.Windows.Forms.Button()
        Me.Datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.ckbEliminar = New System.Windows.Forms.CheckBox()
        Me.txtIdCompetencia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cboDistancias)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.txtLugarCompetencia)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.txtNombreCompetencia)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 260)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nueva Competencia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(366, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(366, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 15)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "*"
        '
        'cboDistancias
        '
        Me.cboDistancias.FormattingEnabled = True
        Me.cboDistancias.Items.AddRange(New Object() {"Una", "Dos", "Tres"})
        Me.cboDistancias.Location = New System.Drawing.Point(161, 128)
        Me.cboDistancias.Name = "cboDistancias"
        Me.cboDistancias.Size = New System.Drawing.Size(121, 23)
        Me.cboDistancias.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Distancias a registrar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.Sistema_de_Calle.My.Resources.Resources.cancel1
        Me.btnCancelar.Location = New System.Drawing.Point(317, 192)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(62, 47)
        Me.btnCancelar.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtLugarCompetencia
        '
        Me.txtLugarCompetencia.Location = New System.Drawing.Point(78, 78)
        Me.txtLugarCompetencia.Name = "txtLugarCompetencia"
        Me.txtLugarCompetencia.Size = New System.Drawing.Size(282, 21)
        Me.txtLugarCompetencia.TabIndex = 7
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Image = Global.Sistema_de_Calle.My.Resources.Resources.refresh
        Me.btnEditar.Location = New System.Drawing.Point(249, 192)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(62, 47)
        Me.btnEditar.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.btnEditar, "Actualizar")
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.Sistema_de_Calle.My.Resources.Resources.save_as
        Me.btnGuardar.Location = New System.Drawing.Point(181, 192)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(62, 47)
        Me.btnGuardar.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guardar")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtNombreCompetencia
        '
        Me.txtNombreCompetencia.Location = New System.Drawing.Point(81, 29)
        Me.txtNombreCompetencia.Name = "txtNombreCompetencia"
        Me.txtNombreCompetencia.Size = New System.Drawing.Size(279, 21)
        Me.txtNombreCompetencia.TabIndex = 1
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.Sistema_de_Calle.My.Resources.Resources.add1
        Me.btnNuevo.Location = New System.Drawing.Point(113, 192)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 47)
        Me.btnNuevo.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Nueva")
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Lugar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lkDatosInexistentes)
        Me.GroupBox2.Controls.Add(Me.btnAgregarAtletas)
        Me.GroupBox2.Controls.Add(Me.Datalistado)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.ckbEliminar)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(421, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 248)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Competencias"
        '
        'lkDatosInexistentes
        '
        Me.lkDatosInexistentes.AutoSize = True
        Me.lkDatosInexistentes.BackColor = System.Drawing.SystemColors.Control
        Me.lkDatosInexistentes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkDatosInexistentes.Location = New System.Drawing.Point(114, 149)
        Me.lkDatosInexistentes.Name = "lkDatosInexistentes"
        Me.lkDatosInexistentes.Size = New System.Drawing.Size(123, 16)
        Me.lkDatosInexistentes.TabIndex = 24
        Me.lkDatosInexistentes.TabStop = True
        Me.lkDatosInexistentes.Text = "Datos Inexistentes"
        '
        'btnAgregarAtletas
        '
        Me.btnAgregarAtletas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAtletas.Image = Global.Sistema_de_Calle.My.Resources.Resources.apply
        Me.btnAgregarAtletas.Location = New System.Drawing.Point(312, 190)
        Me.btnAgregarAtletas.Name = "btnAgregarAtletas"
        Me.btnAgregarAtletas.Size = New System.Drawing.Size(62, 47)
        Me.btnAgregarAtletas.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.btnAgregarAtletas, "Agregar Atletas")
        Me.btnAgregarAtletas.UseVisualStyleBackColor = True
        '
        'Datalistado
        '
        Me.Datalistado.AllowUserToAddRows = False
        Me.Datalistado.AllowUserToDeleteRows = False
        Me.Datalistado.BackgroundColor = System.Drawing.Color.LightCoral
        Me.Datalistado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.Datalistado.Location = New System.Drawing.Point(25, 58)
        Me.Datalistado.Name = "Datalistado"
        Me.Datalistado.ReadOnly = True
        Me.Datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datalistado.Size = New System.Drawing.Size(281, 179)
        Me.Datalistado.TabIndex = 23
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.Sistema_de_Calle.My.Resources.Resources.delete
        Me.btnEliminar.Location = New System.Drawing.Point(312, 10)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(62, 47)
        Me.btnEliminar.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Eliminar")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'ckbEliminar
        '
        Me.ckbEliminar.AutoSize = True
        Me.ckbEliminar.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbEliminar.Location = New System.Drawing.Point(233, 33)
        Me.ckbEliminar.Name = "ckbEliminar"
        Me.ckbEliminar.Size = New System.Drawing.Size(73, 19)
        Me.ckbEliminar.TabIndex = 32
        Me.ckbEliminar.Text = "Eliminar"
        Me.ckbEliminar.UseVisualStyleBackColor = True
        '
        'txtIdCompetencia
        '
        Me.txtIdCompetencia.Location = New System.Drawing.Point(240, 323)
        Me.txtIdCompetencia.Name = "txtIdCompetencia"
        Me.txtIdCompetencia.Size = New System.Drawing.Size(56, 20)
        Me.txtIdCompetencia.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 14)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "IdCompetencia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(285, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "* (Campos Obligatorios)"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Sistema_de_Calle.My.Resources.Resources.logo_corriendo
        Me.PictureBox1.Location = New System.Drawing.Point(421, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(379, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'frmCompetencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(819, 356)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtIdCompetencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCompetencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:. Competencias .:."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreCompetencia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lkDatosInexistentes As System.Windows.Forms.LinkLabel
    Friend WithEvents Datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtLugarCompetencia As System.Windows.Forms.TextBox
    Friend WithEvents cboDistancias As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnAgregarAtletas As System.Windows.Forms.Button
    Friend WithEvents txtIdCompetencia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents ckbEliminar As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

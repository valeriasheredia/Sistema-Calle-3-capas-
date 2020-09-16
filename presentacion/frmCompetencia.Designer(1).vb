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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtLugarCompetencia = New System.Windows.Forms.TextBox()
        Me.txtNombreCompetencia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdCompetencia = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnAgregarAtletas = New System.Windows.Forms.Button()
        Me.ckbEliminar = New System.Windows.Forms.CheckBox()
        Me.cboCampo = New System.Windows.Forms.ComboBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lkDatosInexistentes = New System.Windows.Forms.LinkLabel()
        Me.Datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtLugarCompetencia)
        Me.GroupBox1.Controls.Add(Me.txtNombreCompetencia)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 148)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Competencia"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(253, 105)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(172, 105)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(91, 105)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(10, 105)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nueva"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtLugarCompetencia
        '
        Me.txtLugarCompetencia.Location = New System.Drawing.Point(58, 66)
        Me.txtLugarCompetencia.Name = "txtLugarCompetencia"
        Me.txtLugarCompetencia.Size = New System.Drawing.Size(249, 20)
        Me.txtLugarCompetencia.TabIndex = 1
        '
        'txtNombreCompetencia
        '
        Me.txtNombreCompetencia.Location = New System.Drawing.Point(58, 29)
        Me.txtNombreCompetencia.Name = "txtNombreCompetencia"
        Me.txtNombreCompetencia.Size = New System.Drawing.Size(269, 20)
        Me.txtNombreCompetencia.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Lugar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Código"
        '
        'txtIdCompetencia
        '
        Me.txtIdCompetencia.Location = New System.Drawing.Point(25, 31)
        Me.txtIdCompetencia.Name = "txtIdCompetencia"
        Me.txtIdCompetencia.Size = New System.Drawing.Size(56, 20)
        Me.txtIdCompetencia.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.btnAgregarAtletas)
        Me.GroupBox2.Controls.Add(Me.ckbEliminar)
        Me.GroupBox2.Controls.Add(Me.cboCampo)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.lkDatosInexistentes)
        Me.GroupBox2.Controls.Add(Me.Datalistado)
        Me.GroupBox2.Location = New System.Drawing.Point(404, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 300)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(168, 19)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(157, 20)
        Me.txtBuscar.TabIndex = 20
        '
        'btnAgregarAtletas
        '
        Me.btnAgregarAtletas.Location = New System.Drawing.Point(280, 59)
        Me.btnAgregarAtletas.Name = "btnAgregarAtletas"
        Me.btnAgregarAtletas.Size = New System.Drawing.Size(73, 38)
        Me.btnAgregarAtletas.TabIndex = 25
        Me.btnAgregarAtletas.Text = "Agregar Atletas "
        Me.btnAgregarAtletas.UseVisualStyleBackColor = True
        '
        'ckbEliminar
        '
        Me.ckbEliminar.AutoSize = True
        Me.ckbEliminar.Location = New System.Drawing.Point(28, 77)
        Me.ckbEliminar.Name = "ckbEliminar"
        Me.ckbEliminar.Size = New System.Drawing.Size(62, 17)
        Me.ckbEliminar.TabIndex = 27
        Me.ckbEliminar.Text = "Eliminar"
        Me.ckbEliminar.UseVisualStyleBackColor = True
        '
        'cboCampo
        '
        Me.cboCampo.FormattingEnabled = True
        Me.cboCampo.Items.AddRange(New Object() {"nombre"})
        Me.cboCampo.Location = New System.Drawing.Point(26, 19)
        Me.cboCampo.Name = "cboCampo"
        Me.cboCampo.Size = New System.Drawing.Size(121, 21)
        Me.cboCampo.TabIndex = 19
        Me.cboCampo.Text = "nombre"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(96, 73)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 26
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lkDatosInexistentes
        '
        Me.lkDatosInexistentes.AutoSize = True
        Me.lkDatosInexistentes.Location = New System.Drawing.Point(151, 201)
        Me.lkDatosInexistentes.Name = "lkDatosInexistentes"
        Me.lkDatosInexistentes.Size = New System.Drawing.Size(94, 13)
        Me.lkDatosInexistentes.TabIndex = 24
        Me.lkDatosInexistentes.TabStop = True
        Me.lkDatosInexistentes.Text = "Datos Inexistentes"
        '
        'Datalistado
        '
        Me.Datalistado.AllowUserToAddRows = False
        Me.Datalistado.AllowUserToDeleteRows = False
        Me.Datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.Datalistado.Location = New System.Drawing.Point(26, 109)
        Me.Datalistado.Name = "Datalistado"
        Me.Datalistado.ReadOnly = True
        Me.Datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datalistado.Size = New System.Drawing.Size(327, 177)
        Me.Datalistado.TabIndex = 23
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'frmCompetencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 346)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdCompetencia)
        Me.Name = "frmCompetencia"
        Me.Text = ".:. Listado de Competencias .:."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLugarCompetencia As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreCompetencia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdCompetencia As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarAtletas As System.Windows.Forms.Button
    Friend WithEvents ckbEliminar As System.Windows.Forms.CheckBox
    Friend WithEvents cboCampo As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents lkDatosInexistentes As System.Windows.Forms.LinkLabel
    Friend WithEvents Datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEntidadesSincronizarOutlook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEntidadesSincronizarOutlook))
        Me.progressbarMain = New System.Windows.Forms.ProgressBar()
        Me.buttonSincronizar = New System.Windows.Forms.Button()
        Me.buttonEditar = New System.Windows.Forms.Button()
        Me.groupboxEntidadTipo = New System.Windows.Forms.GroupBox()
        Me.checkboxEntidadTipoOtro = New System.Windows.Forms.CheckBox()
        Me.checkboxEntidadTipoProveedor = New System.Windows.Forms.CheckBox()
        Me.checkboxEntidadTipoFamiliar = New System.Windows.Forms.CheckBox()
        Me.checkboxEntidadTipoAlumno = New System.Windows.Forms.CheckBox()
        Me.checkboxEntidadTipoDocente = New System.Windows.Forms.CheckBox()
        Me.checkboxEntidadTipoPersonalColegio = New System.Windows.Forms.CheckBox()
        Me.groupboxItemNoEncontrado = New System.Windows.Forms.GroupBox()
        Me.groupboxContactos = New System.Windows.Forms.GroupBox()
        Me.radiobuttonContactosBorrar = New System.Windows.Forms.RadioButton()
        Me.radiobuttonContactosIgnorar = New System.Windows.Forms.RadioButton()
        Me.groupboxGrupoContactos = New System.Windows.Forms.GroupBox()
        Me.radiobuttonGrupoContactosBorrar = New System.Windows.Forms.RadioButton()
        Me.radiobuttonGrupoContactosIgnorar = New System.Windows.Forms.RadioButton()
        Me.groupboxGruposACrear = New System.Windows.Forms.GroupBox()
        Me.checkboxCrearGruposCurso = New System.Windows.Forms.CheckBox()
        Me.checkboxCrearGruposNivel = New System.Windows.Forms.CheckBox()
        Me.checkboxCrearGruposEntidadTipo = New System.Windows.Forms.CheckBox()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.groupboxEntidadTipo.SuspendLayout()
        Me.groupboxItemNoEncontrado.SuspendLayout()
        Me.groupboxContactos.SuspendLayout()
        Me.groupboxGrupoContactos.SuspendLayout()
        Me.groupboxGruposACrear.SuspendLayout()
        Me.SuspendLayout()
        '
        'progressbarMain
        '
        Me.progressbarMain.Location = New System.Drawing.Point(9, 317)
        Me.progressbarMain.Name = "progressbarMain"
        Me.progressbarMain.Size = New System.Drawing.Size(329, 30)
        Me.progressbarMain.TabIndex = 5
        Me.progressbarMain.Visible = False
        '
        'buttonSincronizar
        '
        Me.buttonSincronizar.Location = New System.Drawing.Point(233, 267)
        Me.buttonSincronizar.Name = "buttonSincronizar"
        Me.buttonSincronizar.Size = New System.Drawing.Size(105, 32)
        Me.buttonSincronizar.TabIndex = 4
        Me.buttonSincronizar.Text = "Sincronizar"
        Me.buttonSincronizar.UseVisualStyleBackColor = True
        '
        'buttonEditar
        '
        Me.buttonEditar.Location = New System.Drawing.Point(9, 267)
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(105, 32)
        Me.buttonEditar.TabIndex = 3
        Me.buttonEditar.Text = "Editar"
        Me.buttonEditar.UseVisualStyleBackColor = True
        '
        'groupboxEntidadTipo
        '
        Me.groupboxEntidadTipo.Controls.Add(Me.checkboxEntidadTipoOtro)
        Me.groupboxEntidadTipo.Controls.Add(Me.checkboxEntidadTipoProveedor)
        Me.groupboxEntidadTipo.Controls.Add(Me.checkboxEntidadTipoFamiliar)
        Me.groupboxEntidadTipo.Controls.Add(Me.checkboxEntidadTipoAlumno)
        Me.groupboxEntidadTipo.Controls.Add(Me.checkboxEntidadTipoDocente)
        Me.groupboxEntidadTipo.Controls.Add(Me.checkboxEntidadTipoPersonalColegio)
        Me.groupboxEntidadTipo.Location = New System.Drawing.Point(12, 12)
        Me.groupboxEntidadTipo.Name = "groupboxEntidadTipo"
        Me.groupboxEntidadTipo.Size = New System.Drawing.Size(326, 75)
        Me.groupboxEntidadTipo.TabIndex = 0
        Me.groupboxEntidadTipo.TabStop = False
        Me.groupboxEntidadTipo.Text = "Tipos de Entidad:"
        '
        'checkboxEntidadTipoOtro
        '
        Me.checkboxEntidadTipoOtro.AutoSize = True
        Me.checkboxEntidadTipoOtro.Location = New System.Drawing.Point(204, 46)
        Me.checkboxEntidadTipoOtro.Name = "checkboxEntidadTipoOtro"
        Me.checkboxEntidadTipoOtro.Size = New System.Drawing.Size(46, 17)
        Me.checkboxEntidadTipoOtro.TabIndex = 5
        Me.checkboxEntidadTipoOtro.Text = "Otro"
        Me.checkboxEntidadTipoOtro.UseVisualStyleBackColor = True
        '
        'checkboxEntidadTipoProveedor
        '
        Me.checkboxEntidadTipoProveedor.AutoSize = True
        Me.checkboxEntidadTipoProveedor.Location = New System.Drawing.Point(123, 46)
        Me.checkboxEntidadTipoProveedor.Name = "checkboxEntidadTipoProveedor"
        Me.checkboxEntidadTipoProveedor.Size = New System.Drawing.Size(75, 17)
        Me.checkboxEntidadTipoProveedor.TabIndex = 4
        Me.checkboxEntidadTipoProveedor.Text = "Proveedor"
        Me.checkboxEntidadTipoProveedor.UseVisualStyleBackColor = True
        '
        'checkboxEntidadTipoFamiliar
        '
        Me.checkboxEntidadTipoFamiliar.AutoSize = True
        Me.checkboxEntidadTipoFamiliar.Location = New System.Drawing.Point(12, 46)
        Me.checkboxEntidadTipoFamiliar.Name = "checkboxEntidadTipoFamiliar"
        Me.checkboxEntidadTipoFamiliar.Size = New System.Drawing.Size(61, 17)
        Me.checkboxEntidadTipoFamiliar.TabIndex = 3
        Me.checkboxEntidadTipoFamiliar.Text = "Familiar"
        Me.checkboxEntidadTipoFamiliar.UseVisualStyleBackColor = True
        '
        'checkboxEntidadTipoAlumno
        '
        Me.checkboxEntidadTipoAlumno.AutoSize = True
        Me.checkboxEntidadTipoAlumno.Location = New System.Drawing.Point(204, 23)
        Me.checkboxEntidadTipoAlumno.Name = "checkboxEntidadTipoAlumno"
        Me.checkboxEntidadTipoAlumno.Size = New System.Drawing.Size(61, 17)
        Me.checkboxEntidadTipoAlumno.TabIndex = 2
        Me.checkboxEntidadTipoAlumno.Text = "Alumno"
        Me.checkboxEntidadTipoAlumno.UseVisualStyleBackColor = True
        '
        'checkboxEntidadTipoDocente
        '
        Me.checkboxEntidadTipoDocente.AutoSize = True
        Me.checkboxEntidadTipoDocente.Location = New System.Drawing.Point(123, 23)
        Me.checkboxEntidadTipoDocente.Name = "checkboxEntidadTipoDocente"
        Me.checkboxEntidadTipoDocente.Size = New System.Drawing.Size(67, 17)
        Me.checkboxEntidadTipoDocente.TabIndex = 1
        Me.checkboxEntidadTipoDocente.Text = "Docente"
        Me.checkboxEntidadTipoDocente.UseVisualStyleBackColor = True
        '
        'checkboxEntidadTipoPersonalColegio
        '
        Me.checkboxEntidadTipoPersonalColegio.AutoSize = True
        Me.checkboxEntidadTipoPersonalColegio.Location = New System.Drawing.Point(12, 23)
        Me.checkboxEntidadTipoPersonalColegio.Name = "checkboxEntidadTipoPersonalColegio"
        Me.checkboxEntidadTipoPersonalColegio.Size = New System.Drawing.Size(105, 17)
        Me.checkboxEntidadTipoPersonalColegio.TabIndex = 0
        Me.checkboxEntidadTipoPersonalColegio.Text = "Personal Colegio"
        Me.checkboxEntidadTipoPersonalColegio.UseVisualStyleBackColor = True
        '
        'groupboxItemNoEncontrado
        '
        Me.groupboxItemNoEncontrado.Controls.Add(Me.groupboxContactos)
        Me.groupboxItemNoEncontrado.Controls.Add(Me.groupboxGrupoContactos)
        Me.groupboxItemNoEncontrado.Location = New System.Drawing.Point(12, 103)
        Me.groupboxItemNoEncontrado.Name = "groupboxItemNoEncontrado"
        Me.groupboxItemNoEncontrado.Size = New System.Drawing.Size(329, 79)
        Me.groupboxItemNoEncontrado.TabIndex = 1
        Me.groupboxItemNoEncontrado.TabStop = False
        Me.groupboxItemNoEncontrado.Text = "Al encontrar un item en Outlook que no existe en el sistema:"
        '
        'groupboxContactos
        '
        Me.groupboxContactos.Controls.Add(Me.radiobuttonContactosBorrar)
        Me.groupboxContactos.Controls.Add(Me.radiobuttonContactosIgnorar)
        Me.groupboxContactos.Location = New System.Drawing.Point(169, 21)
        Me.groupboxContactos.Name = "groupboxContactos"
        Me.groupboxContactos.Size = New System.Drawing.Size(149, 49)
        Me.groupboxContactos.TabIndex = 1
        Me.groupboxContactos.TabStop = False
        Me.groupboxContactos.Text = "Contacto:"
        '
        'radiobuttonContactosBorrar
        '
        Me.radiobuttonContactosBorrar.AutoSize = True
        Me.radiobuttonContactosBorrar.Location = New System.Drawing.Point(86, 19)
        Me.radiobuttonContactosBorrar.Name = "radiobuttonContactosBorrar"
        Me.radiobuttonContactosBorrar.Size = New System.Drawing.Size(53, 17)
        Me.radiobuttonContactosBorrar.TabIndex = 1
        Me.radiobuttonContactosBorrar.TabStop = True
        Me.radiobuttonContactosBorrar.Text = "Borrar"
        Me.radiobuttonContactosBorrar.UseVisualStyleBackColor = True
        '
        'radiobuttonContactosIgnorar
        '
        Me.radiobuttonContactosIgnorar.AutoSize = True
        Me.radiobuttonContactosIgnorar.Location = New System.Drawing.Point(13, 19)
        Me.radiobuttonContactosIgnorar.Name = "radiobuttonContactosIgnorar"
        Me.radiobuttonContactosIgnorar.Size = New System.Drawing.Size(58, 17)
        Me.radiobuttonContactosIgnorar.TabIndex = 0
        Me.radiobuttonContactosIgnorar.TabStop = True
        Me.radiobuttonContactosIgnorar.Text = "Ignorar"
        Me.radiobuttonContactosIgnorar.UseVisualStyleBackColor = True
        '
        'groupboxGrupoContactos
        '
        Me.groupboxGrupoContactos.Controls.Add(Me.radiobuttonGrupoContactosBorrar)
        Me.groupboxGrupoContactos.Controls.Add(Me.radiobuttonGrupoContactosIgnorar)
        Me.groupboxGrupoContactos.Location = New System.Drawing.Point(10, 21)
        Me.groupboxGrupoContactos.Name = "groupboxGrupoContactos"
        Me.groupboxGrupoContactos.Size = New System.Drawing.Size(149, 49)
        Me.groupboxGrupoContactos.TabIndex = 0
        Me.groupboxGrupoContactos.TabStop = False
        Me.groupboxGrupoContactos.Text = "Grupo de Contactos:"
        '
        'radiobuttonGrupoContactosBorrar
        '
        Me.radiobuttonGrupoContactosBorrar.AutoSize = True
        Me.radiobuttonGrupoContactosBorrar.Location = New System.Drawing.Point(86, 19)
        Me.radiobuttonGrupoContactosBorrar.Name = "radiobuttonGrupoContactosBorrar"
        Me.radiobuttonGrupoContactosBorrar.Size = New System.Drawing.Size(53, 17)
        Me.radiobuttonGrupoContactosBorrar.TabIndex = 1
        Me.radiobuttonGrupoContactosBorrar.TabStop = True
        Me.radiobuttonGrupoContactosBorrar.Text = "Borrar"
        Me.radiobuttonGrupoContactosBorrar.UseVisualStyleBackColor = True
        '
        'radiobuttonGrupoContactosIgnorar
        '
        Me.radiobuttonGrupoContactosIgnorar.AutoSize = True
        Me.radiobuttonGrupoContactosIgnorar.Location = New System.Drawing.Point(13, 19)
        Me.radiobuttonGrupoContactosIgnorar.Name = "radiobuttonGrupoContactosIgnorar"
        Me.radiobuttonGrupoContactosIgnorar.Size = New System.Drawing.Size(58, 17)
        Me.radiobuttonGrupoContactosIgnorar.TabIndex = 0
        Me.radiobuttonGrupoContactosIgnorar.TabStop = True
        Me.radiobuttonGrupoContactosIgnorar.Text = "Ignorar"
        Me.radiobuttonGrupoContactosIgnorar.UseVisualStyleBackColor = True
        '
        'groupboxGruposACrear
        '
        Me.groupboxGruposACrear.Controls.Add(Me.checkboxCrearGruposCurso)
        Me.groupboxGruposACrear.Controls.Add(Me.checkboxCrearGruposNivel)
        Me.groupboxGruposACrear.Controls.Add(Me.checkboxCrearGruposEntidadTipo)
        Me.groupboxGruposACrear.Location = New System.Drawing.Point(12, 200)
        Me.groupboxGruposACrear.Name = "groupboxGruposACrear"
        Me.groupboxGruposACrear.Size = New System.Drawing.Size(326, 52)
        Me.groupboxGruposACrear.TabIndex = 2
        Me.groupboxGruposACrear.TabStop = False
        Me.groupboxGruposACrear.Text = "Crear Grupos de Contactos por:"
        '
        'checkboxCrearGruposCurso
        '
        Me.checkboxCrearGruposCurso.AutoSize = True
        Me.checkboxCrearGruposCurso.Location = New System.Drawing.Point(215, 23)
        Me.checkboxCrearGruposCurso.Name = "checkboxCrearGruposCurso"
        Me.checkboxCrearGruposCurso.Size = New System.Drawing.Size(58, 17)
        Me.checkboxCrearGruposCurso.TabIndex = 2
        Me.checkboxCrearGruposCurso.Text = "Cursos"
        Me.checkboxCrearGruposCurso.UseVisualStyleBackColor = True
        '
        'checkboxCrearGruposNivel
        '
        Me.checkboxCrearGruposNivel.AutoSize = True
        Me.checkboxCrearGruposNivel.Location = New System.Drawing.Point(134, 23)
        Me.checkboxCrearGruposNivel.Name = "checkboxCrearGruposNivel"
        Me.checkboxCrearGruposNivel.Size = New System.Drawing.Size(61, 17)
        Me.checkboxCrearGruposNivel.TabIndex = 1
        Me.checkboxCrearGruposNivel.Text = "Niveles"
        Me.checkboxCrearGruposNivel.UseVisualStyleBackColor = True
        '
        'checkboxCrearGruposEntidadTipo
        '
        Me.checkboxCrearGruposEntidadTipo.AutoSize = True
        Me.checkboxCrearGruposEntidadTipo.Location = New System.Drawing.Point(12, 23)
        Me.checkboxCrearGruposEntidadTipo.Name = "checkboxCrearGruposEntidadTipo"
        Me.checkboxCrearGruposEntidadTipo.Size = New System.Drawing.Size(106, 17)
        Me.checkboxCrearGruposEntidadTipo.TabIndex = 0
        Me.checkboxCrearGruposEntidadTipo.Text = "Tipos de Entidad"
        Me.checkboxCrearGruposEntidadTipo.UseVisualStyleBackColor = True
        '
        'labelStatus
        '
        Me.labelStatus.Location = New System.Drawing.Point(6, 350)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(332, 19)
        Me.labelStatus.TabIndex = 6
        Me.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.labelStatus.Visible = False
        '
        'formEntidadesSincronizarOutlook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 381)
        Me.Controls.Add(Me.labelStatus)
        Me.Controls.Add(Me.groupboxGruposACrear)
        Me.Controls.Add(Me.groupboxItemNoEncontrado)
        Me.Controls.Add(Me.groupboxEntidadTipo)
        Me.Controls.Add(Me.buttonEditar)
        Me.Controls.Add(Me.buttonSincronizar)
        Me.Controls.Add(Me.progressbarMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formEntidadesSincronizarOutlook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sincronizar Entidades con Contactos de Microsoft Outlook"
        Me.groupboxEntidadTipo.ResumeLayout(False)
        Me.groupboxEntidadTipo.PerformLayout()
        Me.groupboxItemNoEncontrado.ResumeLayout(False)
        Me.groupboxContactos.ResumeLayout(False)
        Me.groupboxContactos.PerformLayout()
        Me.groupboxGrupoContactos.ResumeLayout(False)
        Me.groupboxGrupoContactos.PerformLayout()
        Me.groupboxGruposACrear.ResumeLayout(False)
        Me.groupboxGruposACrear.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents progressbarMain As System.Windows.Forms.ProgressBar
    Friend WithEvents buttonSincronizar As System.Windows.Forms.Button
    Friend WithEvents buttonEditar As System.Windows.Forms.Button
    Friend WithEvents groupboxEntidadTipo As System.Windows.Forms.GroupBox
    Friend WithEvents checkboxEntidadTipoOtro As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxEntidadTipoProveedor As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxEntidadTipoFamiliar As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxEntidadTipoAlumno As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxEntidadTipoDocente As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxEntidadTipoPersonalColegio As System.Windows.Forms.CheckBox
    Friend WithEvents groupboxItemNoEncontrado As System.Windows.Forms.GroupBox
    Friend WithEvents groupboxContactos As System.Windows.Forms.GroupBox
    Friend WithEvents radiobuttonContactosBorrar As System.Windows.Forms.RadioButton
    Friend WithEvents radiobuttonContactosIgnorar As System.Windows.Forms.RadioButton
    Friend WithEvents groupboxGrupoContactos As System.Windows.Forms.GroupBox
    Friend WithEvents radiobuttonGrupoContactosBorrar As System.Windows.Forms.RadioButton
    Friend WithEvents radiobuttonGrupoContactosIgnorar As System.Windows.Forms.RadioButton
    Friend WithEvents groupboxGruposACrear As System.Windows.Forms.GroupBox
    Friend WithEvents checkboxCrearGruposEntidadTipo As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxCrearGruposNivel As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxCrearGruposCurso As System.Windows.Forms.CheckBox
    Friend WithEvents labelStatus As System.Windows.Forms.Label
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formComunicacionesEnviarMail
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
        Dim labelTipo As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.datagridviewEntidades = New System.Windows.Forms.DataGridView()
        Me.columnApellidoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEmail1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEmail2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comboboxComunicacion = New System.Windows.Forms.ComboBox()
        Me.labelComunicacion = New System.Windows.Forms.Label()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.buttonEnviar = New System.Windows.Forms.Button()
        Me.groupboxStatus = New System.Windows.Forms.GroupBox()
        Me.textboxStatus = New System.Windows.Forms.TextBox()
        Me.progressbarStatus = New System.Windows.Forms.ProgressBar()
        Me.buttonCancelar = New System.Windows.Forms.Button()
        Me.labelTipoProveedor = New System.Windows.Forms.Label()
        Me.labelTipoFamiliar = New System.Windows.Forms.Label()
        Me.labelTipoAlumno = New System.Windows.Forms.Label()
        Me.labelTipoDocente = New System.Windows.Forms.Label()
        Me.labelTipoPersonalColegio = New System.Windows.Forms.Label()
        Me.checkboxTipoAlumno = New System.Windows.Forms.CheckBox()
        Me.checkboxTipoDocente = New System.Windows.Forms.CheckBox()
        Me.checkboxTipoFamiliar = New System.Windows.Forms.CheckBox()
        Me.checkboxTipoPersonalColegio = New System.Windows.Forms.CheckBox()
        Me.checkboxTipoProveedor = New System.Windows.Forms.CheckBox()
        Me.labelTipoOtro = New System.Windows.Forms.Label()
        Me.checkboxTipoOtro = New System.Windows.Forms.CheckBox()
        Me.comboboxCantidad = New System.Windows.Forms.ComboBox()
        Me.labelCantidad = New System.Windows.Forms.Label()
        labelTipo = New System.Windows.Forms.Label()
        CType(Me.datagridviewEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusstripMain.SuspendLayout()
        Me.groupboxStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTipo
        '
        labelTipo.AutoSize = True
        labelTipo.Location = New System.Drawing.Point(12, 34)
        labelTipo.Name = "labelTipo"
        labelTipo.Size = New System.Drawing.Size(81, 13)
        labelTipo.TabIndex = 11
        labelTipo.Text = "Tipo Entidades:"
        '
        'datagridviewEntidades
        '
        Me.datagridviewEntidades.AllowUserToAddRows = False
        Me.datagridviewEntidades.AllowUserToDeleteRows = False
        Me.datagridviewEntidades.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewEntidades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewEntidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagridviewEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewEntidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnApellidoNombre, Me.columnEmail1, Me.columnEmail2})
        Me.datagridviewEntidades.Location = New System.Drawing.Point(12, 54)
        Me.datagridviewEntidades.MultiSelect = False
        Me.datagridviewEntidades.Name = "datagridviewEntidades"
        Me.datagridviewEntidades.ReadOnly = True
        Me.datagridviewEntidades.RowHeadersVisible = False
        Me.datagridviewEntidades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewEntidades.Size = New System.Drawing.Size(668, 429)
        Me.datagridviewEntidades.TabIndex = 5
        '
        'columnApellidoNombre
        '
        Me.columnApellidoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnApellidoNombre.DataPropertyName = "ApellidoNombre"
        Me.columnApellidoNombre.HeaderText = "Apellido y Nombre"
        Me.columnApellidoNombre.Name = "columnApellidoNombre"
        Me.columnApellidoNombre.ReadOnly = True
        Me.columnApellidoNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnApellidoNombre.Width = 88
        '
        'columnEmail1
        '
        Me.columnEmail1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnEmail1.DataPropertyName = "Email1"
        Me.columnEmail1.HeaderText = "e-Mail 1"
        Me.columnEmail1.Name = "columnEmail1"
        Me.columnEmail1.ReadOnly = True
        Me.columnEmail1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnEmail1.Width = 45
        '
        'columnEmail2
        '
        Me.columnEmail2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnEmail2.DataPropertyName = "Email2"
        Me.columnEmail2.HeaderText = "e-Mail 2"
        Me.columnEmail2.Name = "columnEmail2"
        Me.columnEmail2.ReadOnly = True
        Me.columnEmail2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnEmail2.Width = 45
        '
        'comboboxComunicacion
        '
        Me.comboboxComunicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxComunicacion.FormattingEnabled = True
        Me.comboboxComunicacion.Location = New System.Drawing.Point(93, 6)
        Me.comboboxComunicacion.Name = "comboboxComunicacion"
        Me.comboboxComunicacion.Size = New System.Drawing.Size(284, 21)
        Me.comboboxComunicacion.TabIndex = 1
        '
        'labelComunicacion
        '
        Me.labelComunicacion.AutoSize = True
        Me.labelComunicacion.Location = New System.Drawing.Point(12, 9)
        Me.labelComunicacion.Name = "labelComunicacion"
        Me.labelComunicacion.Size = New System.Drawing.Size(77, 13)
        Me.labelComunicacion.TabIndex = 0
        Me.labelComunicacion.Text = "Comunicación:"
        '
        'statusstripMain
        '
        Me.statusstripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 494)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(692, 22)
        Me.statusstripMain.TabIndex = 7
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(677, 17)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'buttonEnviar
        '
        Me.buttonEnviar.Location = New System.Drawing.Point(618, 5)
        Me.buttonEnviar.Name = "buttonEnviar"
        Me.buttonEnviar.Size = New System.Drawing.Size(62, 21)
        Me.buttonEnviar.TabIndex = 4
        Me.buttonEnviar.Text = "Enviar"
        Me.buttonEnviar.UseVisualStyleBackColor = True
        '
        'groupboxStatus
        '
        Me.groupboxStatus.Controls.Add(Me.textboxStatus)
        Me.groupboxStatus.Controls.Add(Me.progressbarStatus)
        Me.groupboxStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupboxStatus.Location = New System.Drawing.Point(12, 350)
        Me.groupboxStatus.Name = "groupboxStatus"
        Me.groupboxStatus.Size = New System.Drawing.Size(668, 132)
        Me.groupboxStatus.TabIndex = 6
        Me.groupboxStatus.TabStop = False
        Me.groupboxStatus.Text = "Estado del envío:"
        Me.groupboxStatus.Visible = False
        '
        'textboxStatus
        '
        Me.textboxStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxStatus.Location = New System.Drawing.Point(7, 54)
        Me.textboxStatus.MaxLength = 0
        Me.textboxStatus.Multiline = True
        Me.textboxStatus.Name = "textboxStatus"
        Me.textboxStatus.ReadOnly = True
        Me.textboxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxStatus.Size = New System.Drawing.Size(655, 71)
        Me.textboxStatus.TabIndex = 1
        '
        'progressbarStatus
        '
        Me.progressbarStatus.Location = New System.Drawing.Point(7, 21)
        Me.progressbarStatus.Name = "progressbarStatus"
        Me.progressbarStatus.Size = New System.Drawing.Size(656, 26)
        Me.progressbarStatus.TabIndex = 0
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Location = New System.Drawing.Point(618, 6)
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(62, 21)
        Me.buttonCancelar.TabIndex = 10
        Me.buttonCancelar.Text = "Cancelar"
        Me.buttonCancelar.UseVisualStyleBackColor = True
        '
        'labelTipoProveedor
        '
        Me.labelTipoProveedor.AutoSize = True
        Me.labelTipoProveedor.Location = New System.Drawing.Point(441, 33)
        Me.labelTipoProveedor.Name = "labelTipoProveedor"
        Me.labelTipoProveedor.Size = New System.Drawing.Size(56, 13)
        Me.labelTipoProveedor.TabIndex = 21
        Me.labelTipoProveedor.Text = "Proveedor"
        '
        'labelTipoFamiliar
        '
        Me.labelTipoFamiliar.AutoSize = True
        Me.labelTipoFamiliar.Location = New System.Drawing.Point(371, 33)
        Me.labelTipoFamiliar.Name = "labelTipoFamiliar"
        Me.labelTipoFamiliar.Size = New System.Drawing.Size(42, 13)
        Me.labelTipoFamiliar.TabIndex = 19
        Me.labelTipoFamiliar.Text = "Familiar"
        '
        'labelTipoAlumno
        '
        Me.labelTipoAlumno.AutoSize = True
        Me.labelTipoAlumno.Location = New System.Drawing.Point(301, 33)
        Me.labelTipoAlumno.Name = "labelTipoAlumno"
        Me.labelTipoAlumno.Size = New System.Drawing.Size(42, 13)
        Me.labelTipoAlumno.TabIndex = 17
        Me.labelTipoAlumno.Text = "Alumno"
        '
        'labelTipoDocente
        '
        Me.labelTipoDocente.AutoSize = True
        Me.labelTipoDocente.Location = New System.Drawing.Point(225, 33)
        Me.labelTipoDocente.Name = "labelTipoDocente"
        Me.labelTipoDocente.Size = New System.Drawing.Size(48, 13)
        Me.labelTipoDocente.TabIndex = 15
        Me.labelTipoDocente.Text = "Docente"
        '
        'labelTipoPersonalColegio
        '
        Me.labelTipoPersonalColegio.AutoSize = True
        Me.labelTipoPersonalColegio.Location = New System.Drawing.Point(111, 33)
        Me.labelTipoPersonalColegio.Name = "labelTipoPersonalColegio"
        Me.labelTipoPersonalColegio.Size = New System.Drawing.Size(86, 13)
        Me.labelTipoPersonalColegio.TabIndex = 13
        Me.labelTipoPersonalColegio.Text = "Personal Colegio"
        '
        'checkboxTipoAlumno
        '
        Me.checkboxTipoAlumno.AutoSize = True
        Me.checkboxTipoAlumno.Location = New System.Drawing.Point(286, 33)
        Me.checkboxTipoAlumno.Name = "checkboxTipoAlumno"
        Me.checkboxTipoAlumno.Size = New System.Drawing.Size(15, 14)
        Me.checkboxTipoAlumno.TabIndex = 16
        Me.checkboxTipoAlumno.UseVisualStyleBackColor = True
        '
        'checkboxTipoDocente
        '
        Me.checkboxTipoDocente.AutoSize = True
        Me.checkboxTipoDocente.Location = New System.Drawing.Point(210, 33)
        Me.checkboxTipoDocente.Name = "checkboxTipoDocente"
        Me.checkboxTipoDocente.Size = New System.Drawing.Size(15, 14)
        Me.checkboxTipoDocente.TabIndex = 14
        Me.checkboxTipoDocente.UseVisualStyleBackColor = True
        '
        'checkboxTipoFamiliar
        '
        Me.checkboxTipoFamiliar.AutoSize = True
        Me.checkboxTipoFamiliar.Location = New System.Drawing.Point(356, 33)
        Me.checkboxTipoFamiliar.Name = "checkboxTipoFamiliar"
        Me.checkboxTipoFamiliar.Size = New System.Drawing.Size(15, 14)
        Me.checkboxTipoFamiliar.TabIndex = 18
        Me.checkboxTipoFamiliar.UseVisualStyleBackColor = True
        '
        'checkboxTipoPersonalColegio
        '
        Me.checkboxTipoPersonalColegio.AutoSize = True
        Me.checkboxTipoPersonalColegio.Location = New System.Drawing.Point(96, 33)
        Me.checkboxTipoPersonalColegio.Name = "checkboxTipoPersonalColegio"
        Me.checkboxTipoPersonalColegio.Size = New System.Drawing.Size(15, 14)
        Me.checkboxTipoPersonalColegio.TabIndex = 12
        Me.checkboxTipoPersonalColegio.UseVisualStyleBackColor = True
        '
        'checkboxTipoProveedor
        '
        Me.checkboxTipoProveedor.AutoSize = True
        Me.checkboxTipoProveedor.Location = New System.Drawing.Point(426, 33)
        Me.checkboxTipoProveedor.Name = "checkboxTipoProveedor"
        Me.checkboxTipoProveedor.Size = New System.Drawing.Size(15, 14)
        Me.checkboxTipoProveedor.TabIndex = 20
        Me.checkboxTipoProveedor.UseVisualStyleBackColor = True
        '
        'labelTipoOtro
        '
        Me.labelTipoOtro.AutoSize = True
        Me.labelTipoOtro.Location = New System.Drawing.Point(518, 33)
        Me.labelTipoOtro.Name = "labelTipoOtro"
        Me.labelTipoOtro.Size = New System.Drawing.Size(27, 13)
        Me.labelTipoOtro.TabIndex = 23
        Me.labelTipoOtro.Text = "Otro"
        '
        'checkboxTipoOtro
        '
        Me.checkboxTipoOtro.AutoSize = True
        Me.checkboxTipoOtro.Location = New System.Drawing.Point(502, 33)
        Me.checkboxTipoOtro.Name = "checkboxTipoOtro"
        Me.checkboxTipoOtro.Size = New System.Drawing.Size(15, 14)
        Me.checkboxTipoOtro.TabIndex = 22
        Me.checkboxTipoOtro.UseVisualStyleBackColor = True
        '
        'comboboxCantidad
        '
        Me.comboboxCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCantidad.FormattingEnabled = True
        Me.comboboxCantidad.Location = New System.Drawing.Point(509, 6)
        Me.comboboxCantidad.Name = "comboboxCantidad"
        Me.comboboxCantidad.Size = New System.Drawing.Size(90, 21)
        Me.comboboxCantidad.TabIndex = 3
        '
        'labelCantidad
        '
        Me.labelCantidad.AutoSize = True
        Me.labelCantidad.Location = New System.Drawing.Point(401, 9)
        Me.labelCantidad.Name = "labelCantidad"
        Me.labelCantidad.Size = New System.Drawing.Size(102, 13)
        Me.labelCantidad.TabIndex = 2
        Me.labelCantidad.Text = "Cantidad de e-mails:"
        '
        'formComunicacionesEnviarMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 516)
        Me.Controls.Add(Me.labelTipoOtro)
        Me.Controls.Add(Me.checkboxTipoOtro)
        Me.Controls.Add(Me.labelTipoProveedor)
        Me.Controls.Add(Me.labelTipoFamiliar)
        Me.Controls.Add(Me.labelTipoAlumno)
        Me.Controls.Add(Me.labelTipoDocente)
        Me.Controls.Add(Me.labelTipoPersonalColegio)
        Me.Controls.Add(labelTipo)
        Me.Controls.Add(Me.checkboxTipoAlumno)
        Me.Controls.Add(Me.checkboxTipoDocente)
        Me.Controls.Add(Me.checkboxTipoFamiliar)
        Me.Controls.Add(Me.checkboxTipoPersonalColegio)
        Me.Controls.Add(Me.checkboxTipoProveedor)
        Me.Controls.Add(Me.labelCantidad)
        Me.Controls.Add(Me.comboboxCantidad)
        Me.Controls.Add(Me.comboboxComunicacion)
        Me.Controls.Add(Me.labelComunicacion)
        Me.Controls.Add(Me.statusstripMain)
        Me.Controls.Add(Me.buttonEnviar)
        Me.Controls.Add(Me.groupboxStatus)
        Me.Controls.Add(Me.datagridviewEntidades)
        Me.Controls.Add(Me.buttonCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "formComunicacionesEnviarMail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Enviar Comunicación por e-mail"
        CType(Me.datagridviewEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        Me.groupboxStatus.ResumeLayout(False)
        Me.groupboxStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datagridviewEntidades As System.Windows.Forms.DataGridView
    Friend WithEvents comboboxComunicacion As System.Windows.Forms.ComboBox
    Friend WithEvents labelComunicacion As System.Windows.Forms.Label
    Friend WithEvents statusstripMain As System.Windows.Forms.StatusStrip
    Friend WithEvents statuslabelMain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents buttonEnviar As System.Windows.Forms.Button
    Friend WithEvents groupboxStatus As System.Windows.Forms.GroupBox
    Friend WithEvents textboxStatus As System.Windows.Forms.TextBox
    Friend WithEvents progressbarStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents buttonCancelar As System.Windows.Forms.Button
    Friend WithEvents labelTipoProveedor As System.Windows.Forms.Label
    Friend WithEvents labelTipoFamiliar As System.Windows.Forms.Label
    Friend WithEvents labelTipoAlumno As System.Windows.Forms.Label
    Friend WithEvents labelTipoDocente As System.Windows.Forms.Label
    Friend WithEvents labelTipoPersonalColegio As System.Windows.Forms.Label
    Friend WithEvents checkboxTipoAlumno As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxTipoDocente As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxTipoFamiliar As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxTipoPersonalColegio As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxTipoProveedor As System.Windows.Forms.CheckBox
    Friend WithEvents labelTipoOtro As System.Windows.Forms.Label
    Friend WithEvents checkboxTipoOtro As System.Windows.Forms.CheckBox
    Friend WithEvents comboboxCantidad As System.Windows.Forms.ComboBox
    Friend WithEvents labelCantidad As System.Windows.Forms.Label
    Friend WithEvents columnApellidoNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnEmail1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnEmail2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

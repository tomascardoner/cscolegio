﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formGenerarLoteFacturas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                dbcColegio.Dispose()
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelPaso1 = New System.Windows.Forms.Panel()
        Me.lalbelPaso1Pie = New System.Windows.Forms.Label()
        Me.tabcontrolMain = New System.Windows.Forms.TabControl()
        Me.tabpageNivelesCursosAlumnos = New System.Windows.Forms.TabPage()
        Me.treeviewPaso1NivelCursoAlumno = New System.Windows.Forms.TreeView()
        Me.contextmenuNivelCursoAlumno = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuitemNivelCursoAlumnoMarcarTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemNivelCursoAlumnoDesmarcarTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabpagePadresAlumnos = New System.Windows.Forms.TabPage()
        Me.treeviewPaso1PadresAlumnos = New System.Windows.Forms.TreeView()
        Me.contextmenuPadreAlumno = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuitemPadreAlumnoMarcarTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemPadreAlumnoDesmarcarTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.pictureboxPaso1 = New System.Windows.Forms.PictureBox()
        Me.labelPaso1Titulo = New System.Windows.Forms.Label()
        Me.buttonPaso1Cancelar = New System.Windows.Forms.Button()
        Me.buttonPaso1Siguiente = New System.Windows.Forms.Button()
        Me.labelPaso1Mensaje = New System.Windows.Forms.Label()
        Me.panelPaso2 = New System.Windows.Forms.Panel()
        Me.buttonPaso2Print = New System.Windows.Forms.Button()
        Me.labelPaso2Pie = New System.Windows.Forms.Label()
        Me.datagridviewPaso2 = New System.Windows.Forms.DataGridView()
        Me.columnVerificacionIDEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnVerificacionApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnVerificacionNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCorreccionDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pictureboxPaso2 = New System.Windows.Forms.PictureBox()
        Me.labelPaso2Mensaje = New System.Windows.Forms.Label()
        Me.labelPaso2Titulo = New System.Windows.Forms.Label()
        Me.buttonPaso2Anterior = New System.Windows.Forms.Button()
        Me.buttonPaso2Siguiente = New System.Windows.Forms.Button()
        Me.panelPaso3 = New System.Windows.Forms.Panel()
        Me.datagridviewPaso4Detalle = New System.Windows.Forms.DataGridView()
        Me.columnDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnPrecioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datagridviewPaso4Cabecera = New System.Windows.Forms.DataGridView()
        Me.labelPaso3Pie = New System.Windows.Forms.Label()
        Me.pictureboxPaso3 = New System.Windows.Forms.PictureBox()
        Me.labelPaso3Mensaje = New System.Windows.Forms.Label()
        Me.labelPaso3Titulo = New System.Windows.Forms.Label()
        Me.buttonPaso3Anterior = New System.Windows.Forms.Button()
        Me.buttonPaso3Siguiente = New System.Windows.Forms.Button()
        Me.printdocumentPaso2 = New System.Drawing.Printing.PrintDocument()
        Me.columnComprobanteTipoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnPuntoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEntidadApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEntidadNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCUIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCategoriaIVANombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnImporteTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelPaso4 = New System.Windows.Forms.Panel()
        Me.pictureboxPaso4 = New System.Windows.Forms.PictureBox()
        Me.labelPaso4Mensaje = New System.Windows.Forms.Label()
        Me.labelPaso4Titulo = New System.Windows.Forms.Label()
        Me.buttonPaso4Anterior = New System.Windows.Forms.Button()
        Me.buttonPaso5Siguiente = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelPaso1.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageNivelesCursosAlumnos.SuspendLayout()
        Me.contextmenuNivelCursoAlumno.SuspendLayout()
        Me.tabpagePadresAlumnos.SuspendLayout()
        Me.contextmenuPadreAlumno.SuspendLayout()
        CType(Me.pictureboxPaso1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPaso2.SuspendLayout()
        CType(Me.datagridviewPaso2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureboxPaso2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPaso3.SuspendLayout()
        CType(Me.datagridviewPaso4Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridviewPaso4Cabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureboxPaso3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPaso4.SuspendLayout()
        CType(Me.pictureboxPaso4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelPaso1
        '
        Me.panelPaso1.Controls.Add(Me.lalbelPaso1Pie)
        Me.panelPaso1.Controls.Add(Me.tabcontrolMain)
        Me.panelPaso1.Controls.Add(Me.pictureboxPaso1)
        Me.panelPaso1.Controls.Add(Me.labelPaso1Titulo)
        Me.panelPaso1.Controls.Add(Me.buttonPaso1Cancelar)
        Me.panelPaso1.Controls.Add(Me.buttonPaso1Siguiente)
        Me.panelPaso1.Controls.Add(Me.labelPaso1Mensaje)
        Me.panelPaso1.Location = New System.Drawing.Point(12, 12)
        Me.panelPaso1.Name = "panelPaso1"
        Me.panelPaso1.Size = New System.Drawing.Size(611, 441)
        Me.panelPaso1.TabIndex = 0
        '
        'lalbelPaso1Pie
        '
        Me.lalbelPaso1Pie.AutoSize = True
        Me.lalbelPaso1Pie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lalbelPaso1Pie.Location = New System.Drawing.Point(7, 413)
        Me.lalbelPaso1Pie.Name = "lalbelPaso1Pie"
        Me.lalbelPaso1Pie.Size = New System.Drawing.Size(31, 16)
        Me.lalbelPaso1Pie.TabIndex = 3
        Me.lalbelPaso1Pie.Text = "Pie"
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageNivelesCursosAlumnos)
        Me.tabcontrolMain.Controls.Add(Me.tabpagePadresAlumnos)
        Me.tabcontrolMain.Location = New System.Drawing.Point(3, 84)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(605, 314)
        Me.tabcontrolMain.TabIndex = 2
        '
        'tabpageNivelesCursosAlumnos
        '
        Me.tabpageNivelesCursosAlumnos.Controls.Add(Me.treeviewPaso1NivelCursoAlumno)
        Me.tabpageNivelesCursosAlumnos.Location = New System.Drawing.Point(4, 25)
        Me.tabpageNivelesCursosAlumnos.Name = "tabpageNivelesCursosAlumnos"
        Me.tabpageNivelesCursosAlumnos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageNivelesCursosAlumnos.Size = New System.Drawing.Size(597, 285)
        Me.tabpageNivelesCursosAlumnos.TabIndex = 0
        Me.tabpageNivelesCursosAlumnos.Text = "Niveles - Cursos - Alumnos"
        Me.tabpageNivelesCursosAlumnos.UseVisualStyleBackColor = True
        '
        'treeviewPaso1NivelCursoAlumno
        '
        Me.treeviewPaso1NivelCursoAlumno.CheckBoxes = True
        Me.treeviewPaso1NivelCursoAlumno.ContextMenuStrip = Me.contextmenuNivelCursoAlumno
        Me.treeviewPaso1NivelCursoAlumno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeviewPaso1NivelCursoAlumno.Location = New System.Drawing.Point(3, 3)
        Me.treeviewPaso1NivelCursoAlumno.Name = "treeviewPaso1NivelCursoAlumno"
        Me.treeviewPaso1NivelCursoAlumno.Size = New System.Drawing.Size(591, 279)
        Me.treeviewPaso1NivelCursoAlumno.TabIndex = 0
        '
        'contextmenuNivelCursoAlumno
        '
        Me.contextmenuNivelCursoAlumno.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemNivelCursoAlumnoMarcarTodos, Me.menuitemNivelCursoAlumnoDesmarcarTodos})
        Me.contextmenuNivelCursoAlumno.Name = "contextmenuMain"
        Me.contextmenuNivelCursoAlumno.Size = New System.Drawing.Size(170, 48)
        '
        'menuitemNivelCursoAlumnoMarcarTodos
        '
        Me.menuitemNivelCursoAlumnoMarcarTodos.Name = "menuitemNivelCursoAlumnoMarcarTodos"
        Me.menuitemNivelCursoAlumnoMarcarTodos.Size = New System.Drawing.Size(169, 22)
        Me.menuitemNivelCursoAlumnoMarcarTodos.Text = "Marcar todos"
        '
        'menuitemNivelCursoAlumnoDesmarcarTodos
        '
        Me.menuitemNivelCursoAlumnoDesmarcarTodos.Name = "menuitemNivelCursoAlumnoDesmarcarTodos"
        Me.menuitemNivelCursoAlumnoDesmarcarTodos.Size = New System.Drawing.Size(169, 22)
        Me.menuitemNivelCursoAlumnoDesmarcarTodos.Text = "Desemarcar todos"
        '
        'tabpagePadresAlumnos
        '
        Me.tabpagePadresAlumnos.Controls.Add(Me.treeviewPaso1PadresAlumnos)
        Me.tabpagePadresAlumnos.Location = New System.Drawing.Point(4, 25)
        Me.tabpagePadresAlumnos.Name = "tabpagePadresAlumnos"
        Me.tabpagePadresAlumnos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpagePadresAlumnos.Size = New System.Drawing.Size(597, 285)
        Me.tabpagePadresAlumnos.TabIndex = 1
        Me.tabpagePadresAlumnos.Text = "Padres - Alumnos"
        Me.tabpagePadresAlumnos.UseVisualStyleBackColor = True
        '
        'treeviewPaso1PadresAlumnos
        '
        Me.treeviewPaso1PadresAlumnos.CheckBoxes = True
        Me.treeviewPaso1PadresAlumnos.ContextMenuStrip = Me.contextmenuPadreAlumno
        Me.treeviewPaso1PadresAlumnos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeviewPaso1PadresAlumnos.Location = New System.Drawing.Point(3, 3)
        Me.treeviewPaso1PadresAlumnos.Name = "treeviewPaso1PadresAlumnos"
        Me.treeviewPaso1PadresAlumnos.Size = New System.Drawing.Size(591, 279)
        Me.treeviewPaso1PadresAlumnos.TabIndex = 0
        '
        'contextmenuPadreAlumno
        '
        Me.contextmenuPadreAlumno.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemPadreAlumnoMarcarTodos, Me.menuitemPadreAlumnoDesmarcarTodos})
        Me.contextmenuPadreAlumno.Name = "contextmenuMain"
        Me.contextmenuPadreAlumno.Size = New System.Drawing.Size(170, 48)
        '
        'menuitemPadreAlumnoMarcarTodos
        '
        Me.menuitemPadreAlumnoMarcarTodos.Name = "menuitemPadreAlumnoMarcarTodos"
        Me.menuitemPadreAlumnoMarcarTodos.Size = New System.Drawing.Size(169, 22)
        Me.menuitemPadreAlumnoMarcarTodos.Text = "Marcar todos"
        '
        'menuitemPadreAlumnoDesmarcarTodos
        '
        Me.menuitemPadreAlumnoDesmarcarTodos.Name = "menuitemPadreAlumnoDesmarcarTodos"
        Me.menuitemPadreAlumnoDesmarcarTodos.Size = New System.Drawing.Size(169, 22)
        Me.menuitemPadreAlumnoDesmarcarTodos.Text = "Desemarcar todos"
        '
        'pictureboxPaso1
        '
        Me.pictureboxPaso1.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_COMPROBANTE_48
        Me.pictureboxPaso1.Location = New System.Drawing.Point(3, 20)
        Me.pictureboxPaso1.Name = "pictureboxPaso1"
        Me.pictureboxPaso1.Size = New System.Drawing.Size(48, 48)
        Me.pictureboxPaso1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureboxPaso1.TabIndex = 105
        Me.pictureboxPaso1.TabStop = False
        '
        'labelPaso1Titulo
        '
        Me.labelPaso1Titulo.AutoSize = True
        Me.labelPaso1Titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelPaso1Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPaso1Titulo.Location = New System.Drawing.Point(0, 0)
        Me.labelPaso1Titulo.Name = "labelPaso1Titulo"
        Me.labelPaso1Titulo.Size = New System.Drawing.Size(138, 17)
        Me.labelPaso1Titulo.TabIndex = 0
        Me.labelPaso1Titulo.Text = "Paso 1: Selección"
        '
        'buttonPaso1Cancelar
        '
        Me.buttonPaso1Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonPaso1Cancelar.Location = New System.Drawing.Point(387, 404)
        Me.buttonPaso1Cancelar.Name = "buttonPaso1Cancelar"
        Me.buttonPaso1Cancelar.Size = New System.Drawing.Size(75, 34)
        Me.buttonPaso1Cancelar.TabIndex = 4
        Me.buttonPaso1Cancelar.Text = "Cancelar"
        Me.buttonPaso1Cancelar.UseVisualStyleBackColor = True
        '
        'buttonPaso1Siguiente
        '
        Me.buttonPaso1Siguiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonPaso1Siguiente.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_MOVE_NEXT_24
        Me.buttonPaso1Siguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.buttonPaso1Siguiente.Location = New System.Drawing.Point(468, 404)
        Me.buttonPaso1Siguiente.Name = "buttonPaso1Siguiente"
        Me.buttonPaso1Siguiente.Size = New System.Drawing.Size(140, 34)
        Me.buttonPaso1Siguiente.TabIndex = 5
        Me.buttonPaso1Siguiente.Text = "Paso 2: Verificación"
        Me.buttonPaso1Siguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPaso1Siguiente.UseVisualStyleBackColor = True
        '
        'labelPaso1Mensaje
        '
        Me.labelPaso1Mensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelPaso1Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPaso1Mensaje.Location = New System.Drawing.Point(57, 20)
        Me.labelPaso1Mensaje.Name = "labelPaso1Mensaje"
        Me.labelPaso1Mensaje.Size = New System.Drawing.Size(551, 61)
        Me.labelPaso1Mensaje.TabIndex = 1
        Me.labelPaso1Mensaje.Text = "Este asistente le permitirá generar un lote de facturas para un período determina" & _
    "do. Seleccione lo que desee facturar o continúe sin cambiar nada para facturar a" & _
    " todas las entidades."
        '
        'panelPaso2
        '
        Me.panelPaso2.Controls.Add(Me.buttonPaso2Print)
        Me.panelPaso2.Controls.Add(Me.labelPaso2Pie)
        Me.panelPaso2.Controls.Add(Me.datagridviewPaso2)
        Me.panelPaso2.Controls.Add(Me.pictureboxPaso2)
        Me.panelPaso2.Controls.Add(Me.labelPaso2Mensaje)
        Me.panelPaso2.Controls.Add(Me.labelPaso2Titulo)
        Me.panelPaso2.Controls.Add(Me.buttonPaso2Anterior)
        Me.panelPaso2.Controls.Add(Me.buttonPaso2Siguiente)
        Me.panelPaso2.Location = New System.Drawing.Point(12, 12)
        Me.panelPaso2.Name = "panelPaso2"
        Me.panelPaso2.Size = New System.Drawing.Size(611, 441)
        Me.panelPaso2.TabIndex = 1
        '
        'buttonPaso2Print
        '
        Me.buttonPaso2Print.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_PRINT_24
        Me.buttonPaso2Print.Location = New System.Drawing.Point(282, 404)
        Me.buttonPaso2Print.Name = "buttonPaso2Print"
        Me.buttonPaso2Print.Size = New System.Drawing.Size(34, 34)
        Me.buttonPaso2Print.TabIndex = 4
        Me.buttonPaso2Print.UseVisualStyleBackColor = True
        '
        'labelPaso2Pie
        '
        Me.labelPaso2Pie.AutoSize = True
        Me.labelPaso2Pie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPaso2Pie.Location = New System.Drawing.Point(7, 413)
        Me.labelPaso2Pie.Name = "labelPaso2Pie"
        Me.labelPaso2Pie.Size = New System.Drawing.Size(31, 16)
        Me.labelPaso2Pie.TabIndex = 3
        Me.labelPaso2Pie.Text = "Pie"
        '
        'datagridviewPaso2
        '
        Me.datagridviewPaso2.AllowUserToAddRows = False
        Me.datagridviewPaso2.AllowUserToDeleteRows = False
        Me.datagridviewPaso2.AllowUserToOrderColumns = True
        Me.datagridviewPaso2.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewPaso2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.datagridviewPaso2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridviewPaso2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewPaso2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnVerificacionIDEntidad, Me.columnVerificacionApellido, Me.columnVerificacionNombre, Me.columnCorreccionDescripcion})
        Me.datagridviewPaso2.Location = New System.Drawing.Point(3, 84)
        Me.datagridviewPaso2.MultiSelect = False
        Me.datagridviewPaso2.Name = "datagridviewPaso2"
        Me.datagridviewPaso2.ReadOnly = True
        Me.datagridviewPaso2.RowHeadersVisible = False
        Me.datagridviewPaso2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewPaso2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewPaso2.Size = New System.Drawing.Size(605, 307)
        Me.datagridviewPaso2.TabIndex = 2
        '
        'columnVerificacionIDEntidad
        '
        Me.columnVerificacionIDEntidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnVerificacionIDEntidad.DataPropertyName = "IDEntidad"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.columnVerificacionIDEntidad.DefaultCellStyle = DataGridViewCellStyle11
        Me.columnVerificacionIDEntidad.HeaderText = "N° Entidad"
        Me.columnVerificacionIDEntidad.Name = "columnVerificacionIDEntidad"
        Me.columnVerificacionIDEntidad.ReadOnly = True
        Me.columnVerificacionIDEntidad.Width = 77
        '
        'columnVerificacionApellido
        '
        Me.columnVerificacionApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnVerificacionApellido.DataPropertyName = "Apellido"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnVerificacionApellido.DefaultCellStyle = DataGridViewCellStyle12
        Me.columnVerificacionApellido.HeaderText = "Apellido"
        Me.columnVerificacionApellido.Name = "columnVerificacionApellido"
        Me.columnVerificacionApellido.ReadOnly = True
        Me.columnVerificacionApellido.Width = 69
        '
        'columnVerificacionNombre
        '
        Me.columnVerificacionNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnVerificacionNombre.DataPropertyName = "Nombre"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnVerificacionNombre.DefaultCellStyle = DataGridViewCellStyle13
        Me.columnVerificacionNombre.HeaderText = "Nombre"
        Me.columnVerificacionNombre.Name = "columnVerificacionNombre"
        Me.columnVerificacionNombre.ReadOnly = True
        Me.columnVerificacionNombre.Width = 69
        '
        'columnCorreccionDescripcion
        '
        Me.columnCorreccionDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnCorreccionDescripcion.DataPropertyName = "CorreccionDescripcion"
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.columnCorreccionDescripcion.DefaultCellStyle = DataGridViewCellStyle14
        Me.columnCorreccionDescripcion.HeaderText = "Descripción del problema"
        Me.columnCorreccionDescripcion.Name = "columnCorreccionDescripcion"
        Me.columnCorreccionDescripcion.ReadOnly = True
        Me.columnCorreccionDescripcion.Width = 99
        '
        'pictureboxPaso2
        '
        Me.pictureboxPaso2.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_COMPROBANTE_48
        Me.pictureboxPaso2.Location = New System.Drawing.Point(3, 20)
        Me.pictureboxPaso2.Name = "pictureboxPaso2"
        Me.pictureboxPaso2.Size = New System.Drawing.Size(48, 48)
        Me.pictureboxPaso2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureboxPaso2.TabIndex = 107
        Me.pictureboxPaso2.TabStop = False
        '
        'labelPaso2Mensaje
        '
        Me.labelPaso2Mensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelPaso2Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPaso2Mensaje.Location = New System.Drawing.Point(57, 17)
        Me.labelPaso2Mensaje.Name = "labelPaso2Mensaje"
        Me.labelPaso2Mensaje.Size = New System.Drawing.Size(551, 51)
        Me.labelPaso2Mensaje.TabIndex = 1
        Me.labelPaso2Mensaje.Text = "Las siguientes Entidades tienen algún tipo de problema que hay que corregir."
        '
        'labelPaso2Titulo
        '
        Me.labelPaso2Titulo.AutoSize = True
        Me.labelPaso2Titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelPaso2Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPaso2Titulo.Location = New System.Drawing.Point(0, 0)
        Me.labelPaso2Titulo.Name = "labelPaso2Titulo"
        Me.labelPaso2Titulo.Size = New System.Drawing.Size(153, 17)
        Me.labelPaso2Titulo.TabIndex = 0
        Me.labelPaso2Titulo.Text = "Paso 2: Verificación"
        '
        'buttonPaso2Anterior
        '
        Me.buttonPaso2Anterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonPaso2Anterior.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_MOVE_PREVIOUS_24
        Me.buttonPaso2Anterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPaso2Anterior.Location = New System.Drawing.Point(322, 404)
        Me.buttonPaso2Anterior.Name = "buttonPaso2Anterior"
        Me.buttonPaso2Anterior.Size = New System.Drawing.Size(140, 34)
        Me.buttonPaso2Anterior.TabIndex = 5
        Me.buttonPaso2Anterior.Text = "Paso 1: Selección"
        Me.buttonPaso2Anterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.buttonPaso2Anterior.UseVisualStyleBackColor = True
        '
        'buttonPaso2Siguiente
        '
        Me.buttonPaso2Siguiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonPaso2Siguiente.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_MOVE_NEXT_24
        Me.buttonPaso2Siguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.buttonPaso2Siguiente.Location = New System.Drawing.Point(468, 404)
        Me.buttonPaso2Siguiente.Name = "buttonPaso2Siguiente"
        Me.buttonPaso2Siguiente.Size = New System.Drawing.Size(140, 34)
        Me.buttonPaso2Siguiente.TabIndex = 6
        Me.buttonPaso2Siguiente.Text = "Paso 3: Confirmación"
        Me.buttonPaso2Siguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPaso2Siguiente.UseVisualStyleBackColor = True
        '
        'panelPaso3
        '
        Me.panelPaso3.Controls.Add(Me.datagridviewPaso4Detalle)
        Me.panelPaso3.Controls.Add(Me.datagridviewPaso4Cabecera)
        Me.panelPaso3.Controls.Add(Me.labelPaso3Pie)
        Me.panelPaso3.Controls.Add(Me.pictureboxPaso3)
        Me.panelPaso3.Controls.Add(Me.labelPaso3Mensaje)
        Me.panelPaso3.Controls.Add(Me.labelPaso3Titulo)
        Me.panelPaso3.Controls.Add(Me.buttonPaso3Anterior)
        Me.panelPaso3.Controls.Add(Me.buttonPaso3Siguiente)
        Me.panelPaso3.Location = New System.Drawing.Point(12, 12)
        Me.panelPaso3.Name = "panelPaso3"
        Me.panelPaso3.Size = New System.Drawing.Size(611, 441)
        Me.panelPaso3.TabIndex = 2
        '
        'datagridviewPaso4Detalle
        '
        Me.datagridviewPaso4Detalle.AllowUserToAddRows = False
        Me.datagridviewPaso4Detalle.AllowUserToDeleteRows = False
        Me.datagridviewPaso4Detalle.AllowUserToResizeRows = False
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewPaso4Detalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.datagridviewPaso4Detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagridviewPaso4Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewPaso4Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnDescripcion, Me.columnPrecioTotal})
        Me.datagridviewPaso4Detalle.Location = New System.Drawing.Point(3, 298)
        Me.datagridviewPaso4Detalle.MultiSelect = False
        Me.datagridviewPaso4Detalle.Name = "datagridviewPaso4Detalle"
        Me.datagridviewPaso4Detalle.ReadOnly = True
        Me.datagridviewPaso4Detalle.RowHeadersVisible = False
        Me.datagridviewPaso4Detalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewPaso4Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewPaso4Detalle.Size = New System.Drawing.Size(605, 100)
        Me.datagridviewPaso4Detalle.TabIndex = 111
        '
        'columnDescripcion
        '
        Me.columnDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDescripcion.DataPropertyName = "Descripcion"
        Me.columnDescripcion.HeaderText = "Descripción"
        Me.columnDescripcion.Name = "columnDescripcion"
        Me.columnDescripcion.ReadOnly = True
        Me.columnDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnDescripcion.Width = 69
        '
        'columnPrecioTotal
        '
        Me.columnPrecioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnPrecioTotal.DataPropertyName = "PrecioTotal"
        DataGridViewCellStyle16.Format = "C2"
        DataGridViewCellStyle16.NullValue = "0"
        Me.columnPrecioTotal.DefaultCellStyle = DataGridViewCellStyle16
        Me.columnPrecioTotal.HeaderText = "Precio"
        Me.columnPrecioTotal.Name = "columnPrecioTotal"
        Me.columnPrecioTotal.ReadOnly = True
        Me.columnPrecioTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnPrecioTotal.Width = 43
        '
        'datagridviewPaso4Cabecera
        '
        Me.datagridviewPaso4Cabecera.AllowUserToAddRows = False
        Me.datagridviewPaso4Cabecera.AllowUserToDeleteRows = False
        Me.datagridviewPaso4Cabecera.AllowUserToResizeRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewPaso4Cabecera.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.datagridviewPaso4Cabecera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagridviewPaso4Cabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewPaso4Cabecera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnComprobanteTipoNombre, Me.columnPuntoVenta, Me.columnNumero, Me.columnEntidadApellido, Me.columnEntidadNombre, Me.columnCUIT, Me.columnCategoriaIVANombre, Me.columnImporteTotal})
        Me.datagridviewPaso4Cabecera.Location = New System.Drawing.Point(3, 84)
        Me.datagridviewPaso4Cabecera.MultiSelect = False
        Me.datagridviewPaso4Cabecera.Name = "datagridviewPaso4Cabecera"
        Me.datagridviewPaso4Cabecera.ReadOnly = True
        Me.datagridviewPaso4Cabecera.RowHeadersVisible = False
        Me.datagridviewPaso4Cabecera.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewPaso4Cabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewPaso4Cabecera.Size = New System.Drawing.Size(605, 208)
        Me.datagridviewPaso4Cabecera.TabIndex = 110
        '
        'labelPaso3Pie
        '
        Me.labelPaso3Pie.AutoSize = True
        Me.labelPaso3Pie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPaso3Pie.Location = New System.Drawing.Point(7, 413)
        Me.labelPaso3Pie.Name = "labelPaso3Pie"
        Me.labelPaso3Pie.Size = New System.Drawing.Size(31, 16)
        Me.labelPaso3Pie.TabIndex = 3
        Me.labelPaso3Pie.Text = "Pie"
        '
        'pictureboxPaso3
        '
        Me.pictureboxPaso3.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_COMPROBANTE_48
        Me.pictureboxPaso3.Location = New System.Drawing.Point(5, 20)
        Me.pictureboxPaso3.Name = "pictureboxPaso3"
        Me.pictureboxPaso3.Size = New System.Drawing.Size(48, 48)
        Me.pictureboxPaso3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureboxPaso3.TabIndex = 108
        Me.pictureboxPaso3.TabStop = False
        '
        'labelPaso3Mensaje
        '
        Me.labelPaso3Mensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelPaso3Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPaso3Mensaje.Location = New System.Drawing.Point(59, 20)
        Me.labelPaso3Mensaje.Name = "labelPaso3Mensaje"
        Me.labelPaso3Mensaje.Size = New System.Drawing.Size(549, 61)
        Me.labelPaso3Mensaje.TabIndex = 1
        Me.labelPaso3Mensaje.Text = "A continuación, se muestran las Facturas que se generarán con su correspondiente " & _
    "detalle."
        '
        'labelPaso3Titulo
        '
        Me.labelPaso3Titulo.AutoSize = True
        Me.labelPaso3Titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelPaso3Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPaso3Titulo.Location = New System.Drawing.Point(0, 0)
        Me.labelPaso3Titulo.Name = "labelPaso3Titulo"
        Me.labelPaso3Titulo.Size = New System.Drawing.Size(162, 17)
        Me.labelPaso3Titulo.TabIndex = 0
        Me.labelPaso3Titulo.Text = "Paso 3: Confirmación"
        '
        'buttonPaso3Anterior
        '
        Me.buttonPaso3Anterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonPaso3Anterior.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_MOVE_PREVIOUS_24
        Me.buttonPaso3Anterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPaso3Anterior.Location = New System.Drawing.Point(322, 404)
        Me.buttonPaso3Anterior.Name = "buttonPaso3Anterior"
        Me.buttonPaso3Anterior.Size = New System.Drawing.Size(140, 34)
        Me.buttonPaso3Anterior.TabIndex = 4
        Me.buttonPaso3Anterior.Text = "Paso 2: Verificación"
        Me.buttonPaso3Anterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.buttonPaso3Anterior.UseVisualStyleBackColor = True
        '
        'buttonPaso3Siguiente
        '
        Me.buttonPaso3Siguiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonPaso3Siguiente.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_MOVE_NEXT_24
        Me.buttonPaso3Siguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.buttonPaso3Siguiente.Location = New System.Drawing.Point(468, 404)
        Me.buttonPaso3Siguiente.Name = "buttonPaso3Siguiente"
        Me.buttonPaso3Siguiente.Size = New System.Drawing.Size(140, 34)
        Me.buttonPaso3Siguiente.TabIndex = 5
        Me.buttonPaso3Siguiente.Text = "Paso 4: Emisión"
        Me.buttonPaso3Siguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPaso3Siguiente.UseVisualStyleBackColor = True
        '
        'printdocumentPaso2
        '
        '
        'columnComprobanteTipoNombre
        '
        Me.columnComprobanteTipoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnComprobanteTipoNombre.DataPropertyName = "ComprobanteTipo.Nombre"
        Me.columnComprobanteTipoNombre.HeaderText = "Tipo"
        Me.columnComprobanteTipoNombre.Name = "columnComprobanteTipoNombre"
        Me.columnComprobanteTipoNombre.ReadOnly = True
        Me.columnComprobanteTipoNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnComprobanteTipoNombre.Width = 34
        '
        'columnPuntoVenta
        '
        Me.columnPuntoVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnPuntoVenta.DataPropertyName = "PuntoVenta"
        Me.columnPuntoVenta.HeaderText = "Punto Venta"
        Me.columnPuntoVenta.Name = "columnPuntoVenta"
        Me.columnPuntoVenta.ReadOnly = True
        Me.columnPuntoVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnPuntoVenta.Width = 72
        '
        'columnNumero
        '
        Me.columnNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnNumero.DataPropertyName = "Numero"
        Me.columnNumero.HeaderText = "Factura N°"
        Me.columnNumero.Name = "columnNumero"
        Me.columnNumero.ReadOnly = True
        Me.columnNumero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnNumero.Width = 64
        '
        'columnEntidadApellido
        '
        Me.columnEntidadApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnEntidadApellido.DataPropertyName = "EntidadApellido"
        Me.columnEntidadApellido.HeaderText = "Apellido"
        Me.columnEntidadApellido.Name = "columnEntidadApellido"
        Me.columnEntidadApellido.ReadOnly = True
        Me.columnEntidadApellido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnEntidadApellido.Width = 50
        '
        'columnEntidadNombre
        '
        Me.columnEntidadNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnEntidadNombre.DataPropertyName = "EntidadNombre"
        Me.columnEntidadNombre.HeaderText = "Nombre"
        Me.columnEntidadNombre.Name = "columnEntidadNombre"
        Me.columnEntidadNombre.ReadOnly = True
        Me.columnEntidadNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnEntidadNombre.Width = 50
        '
        'columnCUIT
        '
        Me.columnCUIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnCUIT.DataPropertyName = "CUIT"
        Me.columnCUIT.HeaderText = "CUIT"
        Me.columnCUIT.Name = "columnCUIT"
        Me.columnCUIT.ReadOnly = True
        Me.columnCUIT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnCUIT.Width = 38
        '
        'columnCategoriaIVANombre
        '
        Me.columnCategoriaIVANombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnCategoriaIVANombre.DataPropertyName = "CategoriaIVANombre"
        Me.columnCategoriaIVANombre.HeaderText = "IVA"
        Me.columnCategoriaIVANombre.Name = "columnCategoriaIVANombre"
        Me.columnCategoriaIVANombre.ReadOnly = True
        Me.columnCategoriaIVANombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnCategoriaIVANombre.Width = 30
        '
        'columnImporteTotal
        '
        Me.columnImporteTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnImporteTotal.DataPropertyName = "ImporteTotal"
        DataGridViewCellStyle18.Format = "C2"
        DataGridViewCellStyle18.NullValue = "0"
        Me.columnImporteTotal.DefaultCellStyle = DataGridViewCellStyle18
        Me.columnImporteTotal.HeaderText = "Importe"
        Me.columnImporteTotal.Name = "columnImporteTotal"
        Me.columnImporteTotal.ReadOnly = True
        Me.columnImporteTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnImporteTotal.Width = 48
        '
        'panelPaso4
        '
        Me.panelPaso4.Controls.Add(Me.DataGridView1)
        Me.panelPaso4.Controls.Add(Me.pictureboxPaso4)
        Me.panelPaso4.Controls.Add(Me.labelPaso4Mensaje)
        Me.panelPaso4.Controls.Add(Me.labelPaso4Titulo)
        Me.panelPaso4.Controls.Add(Me.buttonPaso4Anterior)
        Me.panelPaso4.Controls.Add(Me.buttonPaso5Siguiente)
        Me.panelPaso4.Location = New System.Drawing.Point(640, 12)
        Me.panelPaso4.Name = "panelPaso4"
        Me.panelPaso4.Size = New System.Drawing.Size(611, 441)
        Me.panelPaso4.TabIndex = 104
        '
        'pictureboxPaso4
        '
        Me.pictureboxPaso4.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_COMPROBANTE_48
        Me.pictureboxPaso4.Location = New System.Drawing.Point(3, 20)
        Me.pictureboxPaso4.Name = "pictureboxPaso4"
        Me.pictureboxPaso4.Size = New System.Drawing.Size(48, 48)
        Me.pictureboxPaso4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureboxPaso4.TabIndex = 110
        Me.pictureboxPaso4.TabStop = False
        '
        'labelPaso4Mensaje
        '
        Me.labelPaso4Mensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelPaso4Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPaso4Mensaje.Location = New System.Drawing.Point(57, 20)
        Me.labelPaso4Mensaje.Name = "labelPaso4Mensaje"
        Me.labelPaso4Mensaje.Size = New System.Drawing.Size(551, 61)
        Me.labelPaso4Mensaje.TabIndex = 109
        Me.labelPaso4Mensaje.Text = "Se han emitido las siguientes facturas. Se están transmitiendo a la AFIP para su " & _
    "aprobación final."
        '
        'labelPaso4Titulo
        '
        Me.labelPaso4Titulo.AutoSize = True
        Me.labelPaso4Titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelPaso4Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPaso4Titulo.Location = New System.Drawing.Point(0, 0)
        Me.labelPaso4Titulo.Name = "labelPaso4Titulo"
        Me.labelPaso4Titulo.Size = New System.Drawing.Size(156, 17)
        Me.labelPaso4Titulo.TabIndex = 106
        Me.labelPaso4Titulo.Text = "Paso 4: Transmisión"
        '
        'buttonPaso4Anterior
        '
        Me.buttonPaso4Anterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonPaso4Anterior.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_MOVE_PREVIOUS_24
        Me.buttonPaso4Anterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPaso4Anterior.Location = New System.Drawing.Point(322, 404)
        Me.buttonPaso4Anterior.Name = "buttonPaso4Anterior"
        Me.buttonPaso4Anterior.Size = New System.Drawing.Size(140, 34)
        Me.buttonPaso4Anterior.TabIndex = 99
        Me.buttonPaso4Anterior.Text = "Paso 4: Emisión"
        Me.buttonPaso4Anterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.buttonPaso4Anterior.UseVisualStyleBackColor = True
        '
        'buttonPaso5Siguiente
        '
        Me.buttonPaso5Siguiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonPaso5Siguiente.Image = Global.CSColegio.DesktopApplication.My.Resources.Resources.IMAGE_MOVE_NEXT_24
        Me.buttonPaso5Siguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.buttonPaso5Siguiente.Location = New System.Drawing.Point(468, 404)
        Me.buttonPaso5Siguiente.Name = "buttonPaso5Siguiente"
        Me.buttonPaso5Siguiente.Size = New System.Drawing.Size(140, 34)
        Me.buttonPaso5Siguiente.TabIndex = 98
        Me.buttonPaso5Siguiente.Text = "Paso 6: Envío Mails"
        Me.buttonPaso5Siguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPaso5Siguiente.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 84)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(605, 310)
        Me.DataGridView1.TabIndex = 111
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ComprobanteTipo.Nombre"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 34
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PuntoVenta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Punto Venta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 72
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Numero"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Factura N°"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 64
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EntidadApellido"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "EntidadNombre"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CUIT"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CUIT"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 38
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CategoriaIVANombre"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IVA"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 30
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ImporteTotal"
        DataGridViewCellStyle20.Format = "C2"
        DataGridViewCellStyle20.NullValue = "0"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn8.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 48
        '
        'formGenerarLoteFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 464)
        Me.Controls.Add(Me.panelPaso4)
        Me.Controls.Add(Me.panelPaso1)
        Me.Controls.Add(Me.panelPaso2)
        Me.Controls.Add(Me.panelPaso3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "formGenerarLoteFacturas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Generación de Lote de Facturas"
        Me.panelPaso1.ResumeLayout(False)
        Me.panelPaso1.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageNivelesCursosAlumnos.ResumeLayout(False)
        Me.contextmenuNivelCursoAlumno.ResumeLayout(False)
        Me.tabpagePadresAlumnos.ResumeLayout(False)
        Me.contextmenuPadreAlumno.ResumeLayout(False)
        CType(Me.pictureboxPaso1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPaso2.ResumeLayout(False)
        Me.panelPaso2.PerformLayout()
        CType(Me.datagridviewPaso2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureboxPaso2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPaso3.ResumeLayout(False)
        Me.panelPaso3.PerformLayout()
        CType(Me.datagridviewPaso4Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridviewPaso4Cabecera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureboxPaso3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPaso4.ResumeLayout(False)
        Me.panelPaso4.PerformLayout()
        CType(Me.pictureboxPaso4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelPaso1 As System.Windows.Forms.Panel
    Friend WithEvents labelPaso1Titulo As System.Windows.Forms.Label
    Friend WithEvents buttonPaso1Cancelar As System.Windows.Forms.Button
    Friend WithEvents buttonPaso1Siguiente As System.Windows.Forms.Button
    Friend WithEvents labelPaso1Mensaje As System.Windows.Forms.Label
    Friend WithEvents pictureboxPaso1 As System.Windows.Forms.PictureBox
    Friend WithEvents tabcontrolMain As System.Windows.Forms.TabControl
    Friend WithEvents tabpageNivelesCursosAlumnos As System.Windows.Forms.TabPage
    Friend WithEvents treeviewPaso1NivelCursoAlumno As System.Windows.Forms.TreeView
    Friend WithEvents tabpagePadresAlumnos As System.Windows.Forms.TabPage
    Friend WithEvents treeviewPaso1PadresAlumnos As System.Windows.Forms.TreeView
    Friend WithEvents lalbelPaso1Pie As System.Windows.Forms.Label
    Friend WithEvents contextmenuNivelCursoAlumno As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuitemNivelCursoAlumnoMarcarTodos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemNivelCursoAlumnoDesmarcarTodos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panelPaso2 As System.Windows.Forms.Panel
    Friend WithEvents pictureboxPaso2 As System.Windows.Forms.PictureBox
    Friend WithEvents labelPaso2Mensaje As System.Windows.Forms.Label
    Friend WithEvents labelPaso2Titulo As System.Windows.Forms.Label
    Friend WithEvents buttonPaso2Anterior As System.Windows.Forms.Button
    Friend WithEvents buttonPaso2Siguiente As System.Windows.Forms.Button
    Friend WithEvents datagridviewPaso2 As System.Windows.Forms.DataGridView
    Friend WithEvents contextmenuPadreAlumno As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuitemPadreAlumnoMarcarTodos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemPadreAlumnoDesmarcarTodos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents labelPaso2Pie As System.Windows.Forms.Label
    Friend WithEvents panelPaso3 As System.Windows.Forms.Panel
    Friend WithEvents labelPaso3Pie As System.Windows.Forms.Label
    Friend WithEvents pictureboxPaso3 As System.Windows.Forms.PictureBox
    Friend WithEvents labelPaso3Mensaje As System.Windows.Forms.Label
    Friend WithEvents labelPaso3Titulo As System.Windows.Forms.Label
    Friend WithEvents buttonPaso3Anterior As System.Windows.Forms.Button
    Friend WithEvents buttonPaso3Siguiente As System.Windows.Forms.Button
    Friend WithEvents printdocumentPaso2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents columnVerificacionIDEntidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnVerificacionApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnVerificacionNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCorreccionDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents buttonPaso2Print As System.Windows.Forms.Button
    Friend WithEvents datagridviewPaso4Detalle As System.Windows.Forms.DataGridView
    Friend WithEvents columnDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnPrecioTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datagridviewPaso4Cabecera As System.Windows.Forms.DataGridView
    Friend WithEvents columnComprobanteTipoNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnPuntoVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnEntidadApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnEntidadNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCUIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCategoriaIVANombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnImporteTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents panelPaso4 As System.Windows.Forms.Panel
    Friend WithEvents pictureboxPaso4 As System.Windows.Forms.PictureBox
    Friend WithEvents labelPaso4Mensaje As System.Windows.Forms.Label
    Friend WithEvents labelPaso4Titulo As System.Windows.Forms.Label
    Friend WithEvents buttonPaso4Anterior As System.Windows.Forms.Button
    Friend WithEvents buttonPaso5Siguiente As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

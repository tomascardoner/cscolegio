﻿Public Class formMDIMain

#Region "Declarations"
    Friend Form_ClientSize As Size
    Private AFIP_TicketAcceso_Homo As String
#End Region

#Region "Form stuff"
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cambio el puntero del mouse para indicar que la aplicación está iniciando
        Me.Cursor = Cursors.AppStarting

        ' Deshabilito el Form principal hasta que se cierre el SplashScreen
        Me.Enabled = False

        Me.Text = My.Application.Info.Title

        menuitemAyuda_AcercaDe.Text = "&Acerca de " & My.Application.Info.Title & "..."
    End Sub

    Private Sub formMDIMain_Resize() Handles Me.Resize
        'OBTENGO LAS MEDIDAS DEL CLIENT AREA DEL FORM MDI
        Form_ClientSize = New Size(Me.ClientSize.Width - toolstripMain.Width - My.Settings.MDIFormMargin, Me.ClientSize.Height - menustripMain.Height - statusstripMain.Height - My.Settings.MDIFormMargin)

        'HAGO UN RESIZE DE TODOS LOS CHILDS QUE ESTÉN ABIERTOS
        For Each FormCurrent As Form In Me.MdiChildren
            If FormCurrent.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable Then
                FormCurrent.Size = Form_ClientSize
            End If
        Next
    End Sub

    Private Sub MDIMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not (e.CloseReason = CloseReason.ApplicationExitCall Or e.CloseReason = CloseReason.TaskManagerClosing Or e.CloseReason = CloseReason.WindowsShutDown) Then
            If MsgBox("¿Desea salir de la aplicación?", CType(MsgBoxStyle.Information + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If
        End If
        TerminateApplication()
    End Sub
#End Region

#Region "Menu Archivo"
    Private Sub menuitemArchivo_Salir_Click() Handles menuitemArchivo_Salir.Click
        Me.Close()
    End Sub

    Private Sub UsuarioCerrarSesion() Handles menuitemArchivo_CerrarSesion.Click
        CerrarSesionUsuario()
    End Sub
#End Region

#Region "Menu Debug"
    Private Sub Debug_AFIPWSHomologacionLogin() Handles menuitemDebugAFIPWSHomologacionLogin.Click
        AFIP_TicketAcceso_Homo = CS_AFIP_WS.Login(CS_Parameter.GetString(Parametros.AFIP_WS_AA_HOMOLOGACION), "", CS_AFIP_WS.SERVICIO_FACTURACION_ELECTRONICA, My.Settings.AFIP_WS_Certificado_Homologacion, My.Settings.AFIP_WS_ClavePrivada)
    End Sub

    Private Sub Debug_AFIPWSHomologacionObtenerUltimoComprobante(sender As Object, e As EventArgs) Handles menuitemDebugAFIPWSHomologacionCompConsultar.Click
        Dim TipoComprobante As Short
        Dim PuntoVenta As Short

        If AFIP_TicketAcceso_Homo = "" Then
            MsgBox("No hay un Ticket de Acceso válido." & vbCrLf & "¿Ya inició sesión en AFIP?", vbExclamation, My.Application.Info.Title)
        Else
            TipoComprobante = CShort(InputBox("Ingrese el Código de Comprobante:", Me.menuitemDebugAFIPWSHomologacionCompConsultar.Text))
            PuntoVenta = CShort(InputBox("Ingrese el Punto de Venta:", Me.menuitemDebugAFIPWSHomologacionCompConsultar.Text))
            MsgBox("El Último Número de comprobante autorizado es: " & CS_AFIP_WS.FacturaElectronica_ConectarYObtenerUltimoNumeroComprobante(AFIP_TicketAcceso_Homo, CS_Parameter.GetString(Parametros.AFIP_WS_FE_HOMOLOGACION), "", CS_Parameter.GetString(Parametros.EMPRESA_CUIT), TipoComprobante, PuntoVenta))
        End If
    End Sub

    Private Sub menuitemShowTestForm_Click(sender As Object, e As EventArgs) Handles menuitemShowTestForm.Click
        formTest.Show()
    End Sub
#End Region

#Region "Menu Ventana"
    Private Sub menuitemVentana_MosaicoHorizontal_Click() Handles menuitemVentanaMosaicoHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub menuitemVentana_MosaicoVertical_Click() Handles menuitemVentanaMosaicoVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub menuitemVentana_Cascada_Click() Handles menuitemVentanaCascada.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub menuitemVentana_OrganizarIconos_Click() Handles menuitemVentanaOrganizarIconos.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub menuitemVentana_EncajarEnVentana_Click() Handles menuitemVentanaEncajarEnVentana.Click
        If Not Me.ActiveMdiChild Is Nothing Then
            Me.ActiveMdiChild.Left = 0
            Me.ActiveMdiChild.Top = 0
            Me.ActiveMdiChild.Size = Form_ClientSize
        End If
    End Sub

    Private Sub menuitemVentana_CerrarTodas_Click() Handles menuitemVentanaCerrarTodas.Click
        CS_Form.MDIChild_CloseAll(Me)
    End Sub
#End Region

#Region "Left Toolbar - Tablas"
    Private Function FormCABGenerico_CrearOMostrar(ByVal EntityNameSingular As String, ByVal EntityNamePlural As String) As formCABGenerico
        Dim FormCurrent As formCABGenerico

        FormCurrent = CType(CS_Form.MDIChild_GetInstance(Me, "formCABGenerico", EntityNamePlural), formCABGenerico)
        If FormCurrent Is Nothing Then
            Me.Cursor = Cursors.WaitCursor

            FormCurrent = New formCABGenerico()

            CS_Form.MDIChild_PositionAndSize(Me, CType(FormCurrent, Form), Form_ClientSize)
            FormCurrent.EntityNameSingular = EntityNameSingular
            FormCurrent.EntityNamePlural = EntityNamePlural
            Return FormCurrent

        Else
            If FormCurrent.WindowState = FormWindowState.Minimized Then
                FormCurrent.WindowState = FormWindowState.Normal
            End If
            FormCurrent.Focus()

            Return Nothing
        End If
    End Function

    Private Sub menuitemNivel_Click() Handles menuitemNivel.Click
        Dim formNiveles As formCABGenerico

        If Permisos.VerificarPermiso(Permisos.NIVEL) Then
            formNiveles = FormCABGenerico_CrearOMostrar("Nivel", "Niveles")
            If Not formNiveles Is Nothing Then
                With formNiveles
                    'AGREGO LAS COLUMNAS
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_TextBox("IDNivel", "ID", "IDNivel", DataGridViewContentAlignment.MiddleCenter))
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_TextBox("Nombre", "Nombre", "Nombre", DataGridViewContentAlignment.MiddleLeft))
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_CheckBox("Activo", "Activo", "Activo", DataGridViewContentAlignment.MiddleCenter, False, True, False, False))

                    .bindingsourceMain.DataSource = .dbcontext.Nivel.ToList
                    .Show()
                End With

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub menuitemAnio_Click() Handles menuitemAnio.Click
        Dim formAnios As formCABGenerico

        If Permisos.VerificarPermiso(Permisos.ANIO) Then
            formAnios = FormCABGenerico_CrearOMostrar("Año", "Años")
            If Not formAnios Is Nothing Then
                With formAnios
                    'AGREGO LOS FILTROS
                    'Dim toolstripFiltroNivel As ToolStrip = .AddToolbar("FiltroNivel")
                    'Dim labelFiltroNivel As New ToolStripLabel("Nivel:")
                    'toolstripFiltroNivel.Items.Add(labelFiltroNivel)
                    'Dim comboboxFiltroNivel As New ToolStripComboBox("comboboxFiltroNivel")
                    'comboboxFiltroNivel.DropDownStyle = ComboBoxStyle.DropDownList
                    'comboboxFiltroNivel.ComboBox.DataSource = .dbcontext.Nivel.ToList()
                    'comboboxFiltroNivel.ComboBox.ValueMember = "IDNivel"
                    'comboboxFiltroNivel.ComboBox.DisplayMember = "Nombre"
                    'toolstripFiltroNivel.Items.Add(comboboxFiltroNivel)

                    'AGREGO LAS COLUMNAS
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_TextBox("IDAnio", "Año", "IDAnio", DataGridViewContentAlignment.MiddleCenter))
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_ComboBox("IDNivel", "Nivel", "IDNivel", DataGridViewContentAlignment.MiddleCenter, .dbcontext.Nivel.ToList, "IDNivel", "Nombre"))
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_TextBox("Nombre", "Nombre", "Nombre", DataGridViewContentAlignment.MiddleLeft))
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_CheckBox("Activo", "Activo", "Activo", DataGridViewContentAlignment.MiddleCenter, False, True, False, False))

                    .bindingsourceMain.DataSource = .dbcontext.Anio.ToList
                    .Show()
                End With

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub menuitemTurno_Click() Handles menuitemTurno.Click
        Dim formTurnos As formCABGenerico

        If Permisos.VerificarPermiso(Permisos.TURNO) Then
            formTurnos = FormCABGenerico_CrearOMostrar("Turno", "Turnos")
            If Not formTurnos Is Nothing Then
                With formTurnos
                    'AGREGO LAS COLUMNAS
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_TextBox("IDTurno", "ID", "IDTurno", DataGridViewContentAlignment.MiddleCenter))
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_TextBox("Nombre", "Nombre", "Nombre", DataGridViewContentAlignment.MiddleLeft))
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_CheckBox("Activo", "Activo", "Activo", DataGridViewContentAlignment.MiddleCenter, False, True, False, False))

                    .bindingsourceMain.DataSource = .dbcontext.Turno.ToList
                    .Show()
                End With

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub menuitemCursos_Click() Handles menuitemCursos.Click
        Dim formCursos As formCABGenerico

        If Permisos.VerificarPermiso(Permisos.CURSO) Then
            formCursos = FormCABGenerico_CrearOMostrar("Curso", "Cursos")
            If Not formCursos Is Nothing Then
                With formCursos
                    'AGREGO LAS COLUMNAS
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_TextBox("IDCurso", "ID", "IDCurso", DataGridViewContentAlignment.MiddleCenter))
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_ComboBox("IDAnio", "Año", "IDAnio", DataGridViewContentAlignment.MiddleCenter, .dbcontext.Anio.ToList, "IDAnio", "Nombre"))
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_ComboBox("IDTurno", "Turno", "IDTurno", DataGridViewContentAlignment.MiddleCenter, .dbcontext.Turno.ToList, "IDTurno", "Nombre"))

                    .bindingsourceMain.DataSource = .dbcontext.Curso.ToList
                    .Show()
                End With

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub menuitemBanco_Click() Handles menuitemBanco.Click
        Dim formBancos As formCABGenerico

        If Permisos.VerificarPermiso(Permisos.BANCO) Then
            formBancos = FormCABGenerico_CrearOMostrar("Banco", "Bancos")
            If Not formBancos Is Nothing Then
                With formBancos
                    'AGREGO LAS COLUMNAS
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_TextBox("IDBanco", "ID", "IDBanco", DataGridViewContentAlignment.MiddleCenter))
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_TextBox("Nombre", "Nombre", "Nombre", DataGridViewContentAlignment.MiddleLeft))
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_CheckBox("Activo", "Activo", "Activo", DataGridViewContentAlignment.MiddleCenter, False, True, False, False))

                    .bindingsourceMain.DataSource = .dbcontext.Banco.ToList
                    .Show()
                End With

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub menuitemRelacionTipo_Click() Handles menuitemRelacionTipo.Click
        Dim formRelacionTipo As formCABGenerico

        If Permisos.VerificarPermiso(Permisos.RELACIONTIPO) Then
            formRelacionTipo = FormCABGenerico_CrearOMostrar("Tipo de Relación", "Tipos de Relación")
            If Not formRelacionTipo Is Nothing Then
                With formRelacionTipo
                    'AGREGO LAS COLUMNAS
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_TextBox("IDRelacionTipo", "ID", "IDRelacionTipo", DataGridViewContentAlignment.MiddleCenter))
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_TextBox("Nombre", "Nombre", "Nombre", DataGridViewContentAlignment.MiddleLeft))
                    .datagridviewMain.Columns.Add(CS_DataGridView.CreateColumn_CheckBox("Activo", "Activo", "Activo", DataGridViewContentAlignment.MiddleCenter, False, True, False, False))

                    .bindingsourceMain.DataSource = .dbcontext.RelacionTipo.ToList
                    .Show()
                End With

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub
#End Region

#Region "Left Toolbar - Entidades"
    Private Sub Entidades() Handles buttonEntidades.ButtonClick
        If Permisos.VerificarPermiso(Permisos.ENTIDAD) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSize(Me, CType(formEntidades, Form), Form_ClientSize)
            formEntidades.Show()
            If formEntidades.WindowState = FormWindowState.Minimized Then
                formEntidades.WindowState = FormWindowState.Normal
            End If
            formEntidades.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub EntidadesAñosLectivosYCursos(sender As Object, e As EventArgs) Handles menuitemEntidadesAniosLectivosYCursos.Click
        If Permisos.VerificarPermiso(Permisos.ENTIDADANIOLECTIVOCURSO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSize(Me, CType(formEntidadesAnioLectivoCurso, Form), Form_ClientSize)
            formEntidadesAnioLectivoCurso.Show()
            If formEntidadesAnioLectivoCurso.WindowState = FormWindowState.Minimized Then
                formEntidadesAnioLectivoCurso.WindowState = FormWindowState.Normal
            End If
            formEntidadesAnioLectivoCurso.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region

#Region "Left Toolbar - Comprobantes"
    Private Sub Comprobantes() Handles buttonComprobantes.ButtonClick
        If Permisos.VerificarPermiso(Permisos.COMPROBANTE) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSize(Me, CType(formComprobantes, Form), Form_ClientSize)
            formComprobantes.Show()
            If formComprobantes.WindowState = FormWindowState.Minimized Then
                formComprobantes.WindowState = FormWindowState.Normal
            End If
            formComprobantes.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ComprobantesGenerarLoteFacturas() Handles menuitemComprobantesGenerarLoteFacturas.Click
        If Permisos.VerificarPermiso(Permisos.COMPROBANTE_GENERARLOTE) Then
            Me.Cursor = Cursors.WaitCursor

            formComprobantesGenerarLote.MdiParent = Me
            CS_Form.CenterToParent(Me, CType(formComprobantesGenerarLote, Form))
            formComprobantesGenerarLote.Show()
            If formComprobantesGenerarLote.WindowState = FormWindowState.Minimized Then
                formComprobantesGenerarLote.WindowState = FormWindowState.Normal
            End If
            formComprobantesGenerarLote.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ComprobantesTransmitirAFIP(sender As Object, e As EventArgs) Handles menuitemComprobantesTransmitirAFIP.Click
        If Permisos.VerificarPermiso(Permisos.COMPROBANTE_TRANSMITIRAAFIP) Then
            Me.Cursor = Cursors.WaitCursor

            formComprobantesTransmitirAFIP.MdiParent = Me
            CS_Form.CenterToParent(Me, CType(formComprobantesTransmitirAFIP, Form))
            formComprobantesTransmitirAFIP.Show()
            If formComprobantesTransmitirAFIP.WindowState = FormWindowState.Minimized Then
                formComprobantesTransmitirAFIP.WindowState = FormWindowState.Normal
            End If
            formComprobantesTransmitirAFIP.Focus()

            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub ComprobantesEnviarMail(sender As Object, e As EventArgs) Handles menuitemComprobantesEnviarMail.Click
        If Permisos.VerificarPermiso(Permisos.COMPROBANTE_ENVIAREMAIL) Then
            Me.Cursor = Cursors.WaitCursor

            formComprobantesEnviarMail.MdiParent = Me
            CS_Form.CenterToParent(Me, CType(formComprobantesEnviarMail, Form))
            formComprobantesEnviarMail.Show()
            If formComprobantesEnviarMail.WindowState = FormWindowState.Minimized Then
                formComprobantesEnviarMail.WindowState = FormWindowState.Normal
            End If
            formComprobantesEnviarMail.Focus()

            Me.Cursor = Cursors.Default
        End If

    End Sub
#End Region

#Region "Left Toolbar - Reportes"
    Private Sub buttonReportes_Click(sender As Object, e As EventArgs) Handles buttonReportes.Click
        If Permisos.VerificarPermiso(Permisos.REPORTE) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSize(Me, CType(formReportes, Form), Form_ClientSize)
            formReportes.Show()
            If formReportes.WindowState = FormWindowState.Minimized Then
                formReportes.WindowState = FormWindowState.Normal
            End If
            formReportes.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub labelUsuarioNombre_DoubleClick() Handles labelUsuarioNombre.MouseDown
        CerrarSesionUsuario()
    End Sub
#End Region

#Region "Extra stuff"
    Private Sub CerrarSesionUsuario()
        If MsgBox("¿Desea cerrar la sesión del Usuario actual?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
            CS_Form.MDIChild_CloseAll(Me)
            labelUsuarioNombre.Image = Nothing
            labelUsuarioNombre.Text = ""
            pUsuario = Nothing
            If Not formLogin.ShowDialog(Me) = DialogResult.OK Then
                Application.Exit()
                My.Application.Log.WriteEntry("La Aplicación ha finalizado porque el Usuario no ha iniciado sesión.", TraceEventType.Warning)
                Exit Sub
            End If
            formLogin.Close()
            formLogin.Dispose()
        End If
    End Sub

#End Region

End Class
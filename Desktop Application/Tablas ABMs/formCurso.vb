﻿Public Class formCurso

#Region "Declarations"
    Private mdbContext As New CSColegioContext(True)
    Private mCursoActual As Curso

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDCurso As Byte)
        mIsLoading = True
        mEditMode = EditMode

        If IDCurso = 0 Then
            ' Es Nuevo
            mCursoActual = New Curso
            With mCursoActual
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Curso.Add(mCursoActual)
        Else
            mCursoActual = mdbContext.Curso.Find(IDCurso)
        End If

        Me.MdiParent = pFormMDIMain
        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()
        Me.Show()
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Focus()

        mIsLoading = False

        ChangeMode()
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Exit Sub
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        comboboxAnio.Enabled = mEditMode
        comboboxTurno.Enabled = mEditMode
        textboxDivision.ReadOnly = Not mEditMode
        comboboxCuotaTipo.Enabled = mEditMode
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        ' Cargo los ComboBox
        pFillAndRefreshLists.Anio(comboboxAnio, False, False, True)
        pFillAndRefreshLists.Turno(comboboxTurno, False, False)
        pFillAndRefreshLists.CuotaTipo(comboboxCuotaTipo, False, False)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.IMAGE_TABLAS_32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mCursoActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Mostrar y leer datos"
    Friend Sub SetDataFromObjectToControls()
        With mCursoActual
            If .IDCurso = 0 Then
                textboxIDCurso.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDCurso.Text = String.Format(.IDCurso.ToString, "G")
            End If
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxAnio, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .IDAnio)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxTurno, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .IDTurno, CByte(0))
            textboxDivision.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Division)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxCuotaTipo, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .IDCuotaTipo, CByte(0))
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mCursoActual
            .IDAnio = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxAnio.SelectedValue, 0).Value
            .IDTurno = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxTurno.SelectedValue, 0).Value
            .Division = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDivision.Text)
            .IDCuotaTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCuotaTipo.SelectedValue, 0).Value
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
        End With
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                If mEditMode Then
                    buttonGuardar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                If mEditMode Then
                    buttonCancelar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
        End Select
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxDivision.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub Editar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.CURSO_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub CerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub Guardar_Click() Handles buttonGuardar.Click
        If comboboxAnio.SelectedIndex = -1 Then
            MsgBox("Debe especificar el Año.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxAnio.Focus()
            Exit Sub
        End If
        If comboboxTurno.SelectedIndex = -1 Then
            MsgBox("Debe especificar el Turno.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxTurno.Focus()
            Exit Sub
        End If
        If comboboxCuotaTipo.SelectedIndex = -1 Then
            MsgBox("Debe especificar el Tipo de Cuota.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuotaTipo.Focus()
            Exit Sub
        End If
        If textboxDivision.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar la División.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxDivision.Focus()
            Exit Sub
        End If

        ' Generar el ID del Año nuevo
        If mCursoActual.IDCurso = 0 Then
            Using dbcMaxID As New CSColegioContext(True)
                If dbcMaxID.Curso.Count = 0 Then
                    mCursoActual.IDCurso = 1
                Else
                    mCursoActual.IDCurso = dbcMaxID.Curso.Max(Function(a) a.IDCurso) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mCursoActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mCursoActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista de Entidades para mostrar los cambios
                If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formCursos") Then
                    Dim formCursos As formCursos = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formCursos"), formCursos)
                    formCursos.RefreshData(mCursoActual.IDCurso)
                    formCursos = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Curso con el mismo Año, Turno y División.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Exit Sub
            End Try
        End If

        Me.Close()
    End Sub
#End Region

End Class
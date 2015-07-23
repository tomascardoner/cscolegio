﻿Imports System.Net.Mail

Module MiscFunctions
    Friend Sub PreviewCrystalReport(ByRef Reporte As CS_CrystalReport, ByVal WindowText As String)
        Dim VisorReporte As New formReportViewerCR

        formMDIMain.Cursor = Cursors.WaitCursor

        CS_Form.MDIChild_PositionAndSize(CType(formMDIMain, Form), CType(VisorReporte, Form), formMDIMain.Form_ClientSize)
        With VisorReporte
            .Text = WindowText
            .CRViewerMain.ReportSource = Reporte.ReportObject
            .Show()
            If .WindowState = FormWindowState.Minimized Then
                .WindowState = FormWindowState.Normal
            End If
            .Focus()
        End With

        formMDIMain.Cursor = Cursors.Default
    End Sub

    Friend Sub UserLoggedIn()
        LoadPermisos()

        formMDIMain.menuitemDebug.Visible = (pUsuario.IDUsuario = 1)

        Select Case pUsuario.Genero
            Case Constantes.GENERO_MASCULINO
                formMDIMain.labelUsuarioNombre.Image = My.Resources.Resources.IMAGE_USUARIO_HOMBRE_16
            Case Constantes.GENERO_MASCULINO
                formMDIMain.labelUsuarioNombre.Image = My.Resources.Resources.IMAGE_USUARIO_MUJER_16
            Case Else
                formMDIMain.labelUsuarioNombre.Text = pUsuario.Descripcion
        End Select

        My.Application.Log.WriteEntry(String.Format("El Usuario '{0}' ha iniciado sesión.", pUsuario.Nombre), TraceEventType.Information)
    End Sub

    Friend Function LoadParameters() As Boolean
        Try
            Using dbcontext As New CSColegioContext(True)
                pParametros = dbcontext.Parametro.ToList
            End Using
            Return True
        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al cargar los Parámetros desde la base de datos.")
            Return False
        End Try
    End Function

    Friend Function LoadPermisos() As Boolean
        Try
            Using dbcontext As New CSColegioContext(True)
                pPermisos = dbcontext.UsuarioGrupoPermiso.ToList
            End Using
            Return True
        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al cargar los Permisos del Usuario.")
            Return False
        End Try
    End Function

    Friend Function EnviarEmailPorNETClient(ByRef Titular As Entidad, ByVal Asunto As String, ByVal Cuerpo As String, ByRef Reporte As CS_CrystalReport, ByVal AdjuntoNombre As String) As Boolean
        Dim mail As New MailMessage()
        Dim smtp As New SmtpClient()

        ' Establezco los recipientes
        mail.From = New MailAddress(My.Settings.Email_Address, My.Settings.Email_DisplayName)
        If Not Titular.Email1 Is Nothing Then
            mail.To.Add(New MailAddress(Titular.Email1, Titular.ApellidoNombre))
        End If
        If Not Titular.Email2 Is Nothing Then
            mail.To.Add(New MailAddress(Titular.Email2, Titular.ApellidoNombre))
        End If

        ' Establezco el contenido
        mail.Subject = Asunto
        mail.Body = Cuerpo

        ' Establezco las opciones del Servidor SMTP
        smtp.Host = My.Settings.Email_SMTP_Server
        smtp.EnableSsl = My.Settings.Email_SMTP_UseSSL
        smtp.Port = My.Settings.Email_SMTP_Port
        smtp.Timeout = My.Settings.Email_SMTP_Timeout

        Dim Decrypter As New CS_Encrypt_TripleDES(Constantes.ENCRYPTION_PASSWORD)
        smtp.Credentials = New System.Net.NetworkCredential(My.Settings.Email_SMTP_Username, Decrypter.Decrypt(My.Settings.Email_SMTP_Password))
        Decrypter = Nothing

        ' Attachments
        mail.Attachments.Add(New System.Net.Mail.Attachment(Reporte.ReportObject.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat), AdjuntoNombre))

        ' Envío el e-mail
        Try
            smtp.Send(mail)
            Return True

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al enviar el e-mail.")
            Return False

        End Try
    End Function

    Friend Function EnviarEmailPorMSOutlook(ByRef Titular As Entidad, ByVal Asunto As String, ByVal Cuerpo As String, ByRef Reporte As CS_CrystalReport, ByVal AdjuntoNombre As String) As Boolean
        ' TODO - Completar rutina de envío de e-mails a través de Microsoft Outlook
        Return True
    End Function

    Friend Function EnviarEmailPorCrystalReportsMAPI(ByRef Titular As Entidad, ByVal Asunto As String, ByVal Cuerpo As String, ByRef Reporte As CS_CrystalReport, ByVal AdjuntoNombre As String) As Boolean
        'Preparo las opciones del mail
        Dim mailOpts As New CrystalDecisions.Shared.MicrosoftMailDestinationOptions
        If Not Titular.Email1 Is Nothing Then
            mailOpts.MailToList = Titular.Email1
        ElseIf Not Titular.Email2 Is Nothing Then
            mailOpts.MailToList = Titular.Email2
        End If
        mailOpts.MailSubject = Asunto
        mailOpts.MailMessage = Cuerpo

        'Ahora preparo las opciones de exportación
        Dim expopt As New CrystalDecisions.Shared.ExportOptions
        expopt.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.MicrosoftMail
        expopt.ExportDestinationOptions = mailOpts
        expopt.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat

        Try
            Reporte.ReportObject.Export(expopt)
            Return True

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al enviar el e-mail.")
            Return False

        End Try
    End Function
End Module

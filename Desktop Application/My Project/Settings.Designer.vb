﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public ReadOnly Property EnableVisualStyles() As Boolean
            Get
                Return CType(Me("EnableVisualStyles"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public ReadOnly Property MinimumSplashScreenDisplaySeconds() As Byte
            Get
                Return CType(Me("MinimumSplashScreenDisplaySeconds"),Byte)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property LastUserLoggedIn() As String
            Get
                Return CType(Me("LastUserLoggedIn"),String)
            End Get
            Set
                Me("LastUserLoggedIn") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public ReadOnly Property ShowLastUserLoggedIn() As Boolean
            Get
                Return CType(Me("ShowLastUserLoggedIn"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Microsoft Sans Serif, 11.25pt")>  _
        Public ReadOnly Property GridsAndListsFont() As Global.System.Drawing.Font
            Get
                Return CType(Me("GridsAndListsFont"),Global.System.Drawing.Font)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public ReadOnly Property SingleInstanceApplication() As Boolean
            Get
                Return CType(Me("SingleInstanceApplication"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public ReadOnly Property UseCustomDialogForErrorMessage() As Boolean
            Get
                Return CType(Me("UseCustomDialogForErrorMessage"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public ReadOnly Property LoteComprobantes_PreseleccionarTodos() As Boolean
            Get
                Return CType(Me("LoteComprobantes_PreseleccionarTodos"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public ReadOnly Property PermiteGenerarMatriculaMesDesde() As Byte
            Get
                Return CType(Me("PermiteGenerarMatriculaMesDesde"),Byte)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public ReadOnly Property IDPuntoVenta() As Byte
            Get
                Return CType(Me("IDPuntoVenta"),Byte)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Users\Tomas\Dropbox\Cardoner Sistemas\CS-Colegio\Reportes")>  _
        Public ReadOnly Property ReportsPath() As String
            Get
                Return CType(Me("ReportsPath"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public ReadOnly Property DecimalesEnImportes() As Byte
            Get
                Return CType(Me("DecimalesEnImportes"),Byte)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("NETCLIENT")>  _
        Public ReadOnly Property LoteComprobantes_EnviarEmail_Metodo() As String
            Get
                Return CType(Me("LoteComprobantes_EnviarEmail_Metodo"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("{0} N° {1}")>  _
        Public ReadOnly Property Comprobante_EnviarEmail_Subject() As String
            Get
                Return CType(Me("Comprobante_EnviarEmail_Subject"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Adjuntamos el Comprobante solicitado.{0}{0}Atentamente.")>  _
        Public ReadOnly Property Comprobante_EnvioEmail_Body() As String
            Get
                Return CType(Me("Comprobante_EnvioEmail_Body"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("%ApplicationFolder%\Intercambio\Salida")>  _
        Public ReadOnly Property Exchange_Outbound_Folder() As String
            Get
                Return CType(Me("Exchange_Outbound_Folder"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("PagoMisCuentas")>  _
        Public ReadOnly Property Exchange_Outbound_PagoMisCuentas_SubFolder() As String
            Get
                Return CType(Me("Exchange_Outbound_PagoMisCuentas_SubFolder"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\TEMP")>  _
        Public ReadOnly Property Exchange_Outbound_Santander_Piryp_Folder() As String
            Get
                Return CType(Me("Exchange_Outbound_Santander_Piryp_Folder"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property Comprobante_RequiereDomicilioCompleto() As Boolean
            Get
                Return CType(Me("Comprobante_RequiereDomicilioCompleto"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("RV: Mail delivery failed: returning message to sender")>  _
        Public ReadOnly Property Email_Delivery_Failed_Subject() As String
            Get
                Return CType(Me("Email_Delivery_Failed_Subject"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("550 Requested action not taken: mailbox unavailable")>  _
        Public ReadOnly Property Email_Delivery_Failed_ErrorText() As String
            Get
                Return CType(Me("Email_Delivery_Failed_ErrorText"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("The following address(es) failed:")>  _
        Public ReadOnly Property Email_Delivery_Failed_RejectedAddress_PreviousText() As String
            Get
                Return CType(Me("Email_Delivery_Failed_RejectedAddress_PreviousText"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Mailer-Daemon@orlando.dattaweb.com")>  _
        Public ReadOnly Property Email_Delivery_Failed_SenderAddress() As String
            Get
                Return CType(Me("Email_Delivery_Failed_SenderAddress"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public ReadOnly Property Outlook_ContactsSync_EntidadTipo_PersonalColegio() As Boolean
            Get
                Return CType(Me("Outlook_ContactsSync_EntidadTipo_PersonalColegio"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property Outlook_ContactsSync_EntidadTipo_Docente() As Boolean
            Get
                Return CType(Me("Outlook_ContactsSync_EntidadTipo_Docente"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property Outlook_ContactsSync_EntidadTipo_Alumno() As Boolean
            Get
                Return CType(Me("Outlook_ContactsSync_EntidadTipo_Alumno"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property Outlook_ContactsSync_EntidadTipo_Familiar() As Boolean
            Get
                Return CType(Me("Outlook_ContactsSync_EntidadTipo_Familiar"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property Outlook_ContactsSync_EntidadTipo_Proveedor() As Boolean
            Get
                Return CType(Me("Outlook_ContactsSync_EntidadTipo_Proveedor"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property Outlook_ContactsSync_EntidadTipo_Otro() As Boolean
            Get
                Return CType(Me("Outlook_ContactsSync_EntidadTipo_Otro"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public ReadOnly Property Outlook_ContactsSync_GrupoNoEncontrado_Borrar() As Boolean
            Get
                Return CType(Me("Outlook_ContactsSync_GrupoNoEncontrado_Borrar"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public ReadOnly Property Outlook_ContactsSync_ContactoNoEncontrado_Borrar() As Boolean
            Get
                Return CType(Me("Outlook_ContactsSync_ContactoNoEncontrado_Borrar"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public ReadOnly Property Outlook_ContactsSync_SincronizarGrupos_EntidadTipo() As Boolean
            Get
                Return CType(Me("Outlook_ContactsSync_SincronizarGrupos_EntidadTipo"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public ReadOnly Property Outlook_ContactsSync_SincronizarGrupos_NivelYCurso() As Boolean
            Get
                Return CType(Me("Outlook_ContactsSync_SincronizarGrupos_NivelYCurso"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Grupo: {0}")>  _
        Public ReadOnly Property Outlook_ContactsSync_GrupoNombre() As String
            Get
                Return CType(Me("Outlook_ContactsSync_GrupoNombre"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2018;2019")>  _
        Public ReadOnly Property Outlook_ContactsSync_AniosLectivos() As String
            Get
                Return CType(Me("Outlook_ContactsSync_AniosLectivos"),String)
            End Get
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.CSColegio.DesktopApplication.My.MySettings
            Get
                Return Global.CSColegio.DesktopApplication.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace

﻿Module Parametros

#Region "Constantes"

    'SISTEMA
    Friend Const INTERNET_PROXY As String = "INTERNET_PROXY"

    ' APLICACIÓN
    Friend Const APPLICATION_DATABASE_GUID As String = "APPLICATION_DATABASE_GUID"
    Friend Const LICENSE_COMPANY_NAME As String = "LICENSE_COMPANY_NAME"
    Friend Const USER_PASSWORD_MINIMUM_LENGHT As String = "USER_PASSWORD_MINIMUM_LENGHT"
    Friend Const USER_PASSWORD_SECURE_REQUIRED As String = "USER_PASSWORD_SECURE_REQUIRED"
    Friend Const EMAIL_VALIDATION_REGULAREXPRESSION As String = "EMAIL_VALIDATION_REGULAREXPRESSION"
    Friend Const ENTIDAD_VERIFICAR_EMAIL_AVISO As String = "ENTIDAD_VERIFICAR_EMAIL_AVISO"

    ' VALORES PREDETERMINADOS
    Friend Const DEFAULT_PROVINCIA_ID As String = "DEFAULT_PROVINCIA_ID"
    Friend Const DEFAULT_LOCALIDAD_ID As String = "DEFAULT_LOCALIDAD_ID"
    Friend Const DEFAULT_CODIGOPOSTAL As String = "DEFAULT_CODIGOPOSTAL"
    Friend Const DEFAULT_CATEGORIAIVA_ID As String = "DEFAULT_CATEGORIAIVA_ID"
    Friend Const DEFAULT_MONEDA_ID As String = "DEFAULT_MONEDA_ID"
    Friend Const DEFAULT_DOCUMENTOTIPO_ID As String = "DEFAULT_DOCUMENTOTIPO_ID"

    ' CUOTAS MENSUALES
    Friend Const CUOTA_MATRICULA_ARTICULO_ID As String = "CUOTA_MATRICULA_ARTICULO_ID"
    Friend Const CUOTA_MENSUAL_ARTICULO_ID As String = "CUOTA_MENSUAL_ARTICULO_ID"
    Friend Const CUOTA_MENSUAL_VENCIMIENTO1_DIA As String = "CUOTA_MENSUAL_VENCIMIENTO1_DIA"
    Friend Const CUOTA_MENSUAL_VENCIMIENTO2_DIA As String = "CUOTA_MENSUAL_VENCIMIENTO2_DIA"
    Friend Const CUOTA_MENSUAL_VENCIMIENTO3_DIA As String = "CUOTA_MENSUAL_VENCIMIENTO3_DIA"
    Friend Const CUOTA_MENSUAL_VENCIMIENTO_INTERES_REDONDEO As String = "CUOTA_MENSUAL_VENCIMIENTO_INTERES_REDONDEO"

    ' VARIOS
    Friend Const COMPROBANTE_ENTIDAD_MAYUSCULAS As String = "COMPROBANTE_ENTIDAD_MAYUSCULAS"
    Friend Const VENTA_INTERES_CALCULAR As String = "VENTA_INTERES_CALCULAR"
    Friend Const VENTA_INTERES_MENSUAL As String = "VENTA_INTERES_MENSUAL"
    Friend Const VENTA_INTERES_DIASTOLERANCIA As String = "VENTA_INTERES_DIASTOLERANCIA"
    Friend Const CONSUMIDORFINAL_DOCUMENTOTIPO_ID As String = "CONSUMIDORFINAL_DOCUMENTOTIPO_ID"
    Friend Const CONSUMIDORFINAL_DOCUMENTONUMERO As String = "CONSUMIDORFINAL_DOCUMENTONUMERO"
    Friend Const INTERES_TASA_NOMINAL_ANUAL As String = "INTERES_TASA_NOMINAL_ANUAL"
    Friend Const DOCUMENTOTIPO_CUIT_ID As String = "DOCUMENTOTIPO_CUIT_ID"
    Friend Const DOCUMENTOTIPO_CUIL_ID As String = "DOCUMENTOTIPO_CUIL_ID"

    ' AFIP WEB SERVICES
    Friend Const AFIP_WS_AA_HOMOLOGACION As String = "AFIP_WS_AA_HOMOLOGACION"
    Friend Const AFIP_WS_AA_PRODUCCION As String = "AFIP_WS_AA_PRODUCCION"
    Friend Const AFIP_WS_FE_HOMOLOGACION As String = "AFIP_WS_FE_HOMOLOGACION"
    Friend Const AFIP_WS_FE_PRODUCCION As String = "AFIP_WS_FE_PRODUCCION"

    ' EMPRESA
    Friend Const EMPRESA_CUIT As String = "EMPRESA_CUIT"
    Friend Const EMPRESA_RAZONSOCIAL As String = "EMPRESA_RAZONSOCIAL"
    Friend Const EMPRESA_DOMICILIOFISCAL_DIRECCION As String = "EMPRESA_DOMICILIOFISCAL_DIRECCION"
    Friend Const EMPRESA_DOMICILIOFISCAL_CODIGOPOSTAL As String = "EMPRESA_DOMICILIOFISCAL_CODIGOPOSTAL"
    Friend Const EMPRESA_DOMICILIOFISCAL_LOCALIDAD_ID As String = "EMPRESA_DOMICILIOFISCAL_LOCALIDAD_ID"
    Friend Const EMPRESA_DOMICILIOFISCAL_PROVINCIA_ID As String = "EMPRESA_DOMICILIOFISCAL_PROVINCIA_ID"
    Friend Const EMPRESA_CATEGORIAIVA_ID As String = "EMPRESA_CATEGORIAIVA_ID"
    Friend Const EMPRESA_IIBB_NUMERO As String = "EMPRESA_IIBB_NUMERO"
    Friend Const EMPRESA_INICIO_ACTIVIDAD As String = "EMPRESA_INICIO_ACTIVIDAD"
    Friend Const EMPRESA_PRISMA_NUMERO As String = "EMPRESA_PRISMA_NUMERO"

    ' BANCO SANTANDER
    Friend Const BANCOSANTANDER_ADDI_HABILITADO As String = "BANCOSANTANDER_ADDI_HABILITADO"
    Friend Const BANCOSANTANDER_ADDI_CODIGOEMPRESA As String = "BANCOSANTANDER_ADDI_CODIGOEMPRESA"
    Friend Const BANCOSANTANDER_ADDI_CODIGOSERVICIO As String = "BANCOSANTANDER_ADDI_CODIGOSERVICIO"
    Friend Const BANCOSANTANDER_ADDI_CODIGOCLIENTE_LONGITUD As String = "BANCOSANTANDER_ADDI_CODIGOCLIENTE_LONGITUD"
    Friend Const BANCOSANTANDER_ADDI_USUARIO As String = "BANCOSANTANDER_ADDI_USUARIO"
    Friend Const BANCOSANTANDER_ADDI_DIASPREVIOSVENCIMIENTO As String = "BANCOSANTANDER_ADDI_DIASPREVIOSVENCIMIENTO"
    Friend Const BANCOSANTANDER_PIRYP_NUMEROULTIMOENVIO As String = "BANCOSANTANDER_PIRYP_NUMEROULTIMOENVIO"
    Friend Const BANCOSANTANDER_PIRYP_NUMEROACUERDO As String = "BANCOSANTANDER_PIRYP_NUMEROACUERDO"

#End Region

    Friend Function LoadParameters() As Boolean
        Try
            Using dbcontext As New CSColegioContext(True)
                pParametros = dbcontext.Parametro.ToList
            End Using
            Return True
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al conectarse a la base de datos.")
            Return False
        End Try
    End Function

    Friend Function SaveParameter(parametro As Parametro) As Boolean
        Try
            Using dbcontext As New CSColegioContext(True)
                Dim parametroExistente As Parametro
                parametroExistente = dbcontext.Parametro.Find(parametro.IDParametro)
                If parametroExistente Is Nothing Then
                    dbcontext.Parametro.Append(parametro)
                Else
                    parametroExistente.Texto = parametro.Texto
                    parametroExistente.NumeroEntero = parametro.NumeroEntero
                    parametroExistente.NumeroDecimal = parametro.NumeroDecimal
                    parametroExistente.Moneda = parametro.Moneda
                    parametroExistente.FechaHora = parametro.FechaHora
                    parametroExistente.SiNo = parametro.SiNo
                    parametroExistente.Notas = parametro.Notas
                End If
                If dbcontext.ChangeTracker.HasChanges() Then
                    dbcontext.SaveChanges()
                End If
            End Using
            Return True
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al conectarse a la base de datos.")
            Return False
        End Try
    End Function

End Module

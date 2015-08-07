'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class ComprobanteTipo
    Public Property IDComprobanteTipo As Byte
    Public Property OperacionTipo As String
    Public Property Sigla As String
    Public Property Nombre As String
    Public Property Letra As String
    Public Property NombreConLetra As String
    Public Property NombreCompleto As String
    Public Property CodigoAFIP As Byte
    Public Property MovimientoTipo As String
    Public Property EmisionElectronica As Nullable(Of Boolean)
    Public Property UtilizaDetalle As Boolean
    Public Property UtilizaImpuesto As Boolean
    Public Property UtilizaAplicacion As Boolean
    Public Property UtilizaAsociacion As Boolean
    Public Property UtilizaMedioPago As Boolean
    Public Property ReporteNombre As String
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property ComprobanteTipoPuntoVenta As ICollection(Of ComprobanteTipoPuntoVenta) = New HashSet(Of ComprobanteTipoPuntoVenta)
    Public Overridable Property Comprobante As ICollection(Of Comprobante) = New HashSet(Of Comprobante)
    Public Overridable Property ComprobanteTipo_Asociantes As ICollection(Of ComprobanteTipo) = New HashSet(Of ComprobanteTipo)
    Public Overridable Property ComprobanteTipo_Asociados As ICollection(Of ComprobanteTipo) = New HashSet(Of ComprobanteTipo)

End Class

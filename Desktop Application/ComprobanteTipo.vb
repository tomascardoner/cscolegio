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
    Public Property CodigoAFIP As Byte
    Public Property EmisionElectronica As Nullable(Of Boolean)
    Public Property ReporteNombre As String
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Byte
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Byte
    Public Property FechaHoraModificacion As Date

    Public Overridable Property ComprobanteCabecera As ICollection(Of ComprobanteCabecera) = New HashSet(Of ComprobanteCabecera)
    Public Overridable Property ComprobanteTipoPuntoVenta As ICollection(Of ComprobanteTipoPuntoVenta) = New HashSet(Of ComprobanteTipoPuntoVenta)

End Class

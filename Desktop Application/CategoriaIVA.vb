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

Partial Public Class CategoriaIVA
    Public Property IDCategoriaIVA As Byte
    Public Property Nombre As String
    Public Property IDComprobanteTipo_Factura As Byte
    Public Property IDComprobanteTipo_NotaDebito As Byte
    Public Property IDComprobanteTipo_NotaCredito As Byte
    Public Property EsActivo As Boolean

    Public Overridable Property Entidad As ICollection(Of Entidad) = New HashSet(Of Entidad)
    Public Overridable Property Comprobante As ICollection(Of Comprobante) = New HashSet(Of Comprobante)
    Public Overridable Property ComprobanteTipo As ComprobanteTipo
    Public Overridable Property ComprobanteTipo1 As ComprobanteTipo
    Public Overridable Property ComprobanteTipo2 As ComprobanteTipo

End Class

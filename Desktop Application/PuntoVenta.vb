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

Partial Public Class PuntoVenta
    Public Property IDPuntoVenta As Byte
    Public Property Nombre As String
    Public Property Numero As String
    Public Property EsActivo As Boolean

    Public Overridable Property ComprobanteTipoPuntoVenta As ICollection(Of ComprobanteTipoPuntoVenta) = New HashSet(Of ComprobanteTipoPuntoVenta)

End Class

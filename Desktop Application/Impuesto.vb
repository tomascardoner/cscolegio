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

Partial Public Class Impuesto
    Public Property IDImpuesto As Short
    Public Property Nombre As String
    Public Property Alicuota As Nullable(Of Decimal)
    Public Property BaseImponible As String
    Public Property MinimoNoImponible As Nullable(Of Decimal)
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property ComprobanteImpuesto As ICollection(Of ComprobanteImpuesto) = New HashSet(Of ComprobanteImpuesto)
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario

End Class

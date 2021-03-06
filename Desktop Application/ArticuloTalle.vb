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

Partial Public Class ArticuloTalle
    Public Property IDArticulo As Short
    Public Property IDTalle As Byte
    Public Property Nombre As String
    Public Property StockMinimo As Nullable(Of Short)
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Articulo As Articulo
    Public Overridable Property ListaPrecioArticuloTalles As ICollection(Of ListaPrecioArticuloTalle) = New HashSet(Of ListaPrecioArticuloTalle)
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario

End Class

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

Partial Public Class ListaPrecio
    Public Property IDListaPrecio As Short
    Public Property Nombre As String
    Public Property VigenciaDesde As Nullable(Of Date)
    Public Property VigenciaHasta As Nullable(Of Date)
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property ListaPrecioArticulos As ICollection(Of ListaPrecioArticulo) = New HashSet(Of ListaPrecioArticulo)
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario

End Class

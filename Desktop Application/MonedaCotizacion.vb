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

Partial Public Class MonedaCotizacion
    Public Property IDMoneda As Short
    Public Property Fecha As Date
    Public Property CotizacionCompra As Decimal
    Public Property CotizacionVenta As Decimal
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Moneda As Moneda
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario

End Class

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

Partial Public Class Movimiento
    Public Property IDMovimiento As Integer
    Public Property Fecha As Date
    Public Property IDEntidad As Nullable(Of Integer)
    Public Property Importe As Decimal
    Public Property IDMedioPago As Byte
    Public Property MedioPagoNumero As String
    Public Property IDMovimiento_Categoria As Short
    Public Property IDMovimientoGrupo As Short
    Public Property IDUsuarioCreacion As Byte
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Byte
    Public Property FechaHoraModificacion As Date

    Public Overridable Property MedioPago As MedioPago
    Public Overridable Property MovimientoGrupo As MovimientoGrupo

End Class
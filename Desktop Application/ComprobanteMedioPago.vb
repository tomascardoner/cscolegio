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

Partial Public Class ComprobanteMedioPago
    Public Property IDComprobante As Integer
    Public Property Indice As Byte
    Public Property IDMedioPago As Byte
    Public Property IDCaja As Byte
    Public Property Importe As Decimal
    Public Property FechaHora As Nullable(Of Date)
    Public Property Numero As String
    Public Property IDBanco As Nullable(Of Short)
    Public Property Cuenta As String

    Public Overridable Property Comprobante As Comprobante
    Public Overridable Property MedioPago As MedioPago
    Public Overridable Property Caja As Caja
    Public Overridable Property Cheque_Egreso As ICollection(Of Cheque) = New HashSet(Of Cheque)
    Public Overridable Property Cheque_Ingreso As ICollection(Of Cheque) = New HashSet(Of Cheque)
    Public Overridable Property Banco As Banco

End Class

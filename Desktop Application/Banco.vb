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

Partial Public Class Banco
    Public Property IDBanco As Integer
    Public Property Nombre As String
    Public Property CUIT As String
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Byte
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Byte
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Cheque As ICollection(Of Cheque) = New HashSet(Of Cheque)

End Class
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

Partial Public Class EmailEnvio
    Public Property IDEmailEnvio As Integer
    Public Property EnvioTipo As String
    Public Property IDComprobante As Nullable(Of Integer)
    Public Property IDComunicacion As Nullable(Of Short)

    Public Overridable Property Comprobante As Comprobante
    Public Overridable Property Comunicacion As Comunicacion

End Class

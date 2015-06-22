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

Partial Public Class ComprobanteCabecera
    Public Property IDComprobante As Integer
    Public Property IDComprobanteTipo As Byte
    Public Property PuntoVenta As String
    Public Property Numero As String
    Public Property Fecha As Date
    Public Property FechaVencimiento As Date
    Public Property FechaServicioDesde As Nullable(Of Date)
    Public Property FechaServicioHasta As Nullable(Of Date)
    Public Property IDEntidad As Integer
    Public Property EntidadApellido As String
    Public Property EntidadNombre As String
    Public Property IDDocumentoTipo As Byte
    Public Property DocumentoNumero As String
    Public Property IDCategoriaIVA As Byte
    Public Property DomicilioCalle1 As String
    Public Property DomicilioNumero As String
    Public Property DomicilioPiso As String
    Public Property DomicilioDepartamento As String
    Public Property DomicilioCalle2 As String
    Public Property DomicilioCalle3 As String
    Public Property DomicilioCodigoPostal As String
    Public Property DomicilioIDProvincia As Nullable(Of Byte)
    Public Property DomicilioIDLocalidad As Nullable(Of Short)
    Public Property ImporteNeto As Decimal
    Public Property ImporteImpuesto As Decimal
    Public Property ImporteTotal As Decimal
    Public Property Notas As String
    Public Property CAE As String
    Public Property CAEVencimiento As Nullable(Of Date)
    Public Property IDComprobanteLote As Nullable(Of Integer)
    Public Property IDUsuarioCreacion As Byte
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Byte
    Public Property FechaHoraModificacion As Date
    Public Property IDUsuarioAnulacion As Nullable(Of Byte)
    Public Property FechaHoraAnulacion As Nullable(Of Date)
    Public Property IDUsuarioTransmision As Nullable(Of Byte)
    Public Property FechaHoraTransmision As Nullable(Of Date)

    Public Overridable Property CategoriaIVA As CategoriaIVA
    Public Overridable Property ComprobanteDetalle As ICollection(Of ComprobanteDetalle) = New HashSet(Of ComprobanteDetalle)
    Public Overridable Property ComprobanteImpuesto As ICollection(Of ComprobanteImpuesto) = New HashSet(Of ComprobanteImpuesto)
    Public Overridable Property ComprobanteTipo As ComprobanteTipo
    Public Overridable Property Entidad As Entidad
    Public Overridable Property Localidad As Localidad
    Public Overridable Property ComprobanteLote As ComprobanteLote

End Class
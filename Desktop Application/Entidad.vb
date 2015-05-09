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

Partial Public Class Entidad
    Public Property IDEntidad As Integer
    Public Property Apellido As String
    Public Property Nombre As String
    Public Property ApellidoNombre As String
    Public Property TipoPersonalColegio As Boolean
    Public Property TipoDocente As Boolean
    Public Property TipoAlumno As Boolean
    Public Property TipoFamiliar As Boolean
    Public Property TipoProveedor As Boolean
    Public Property IDDocumentoTipo As Nullable(Of Byte)
    Public Property DocumentoNumero As String
    Public Property Genero As String
    Public Property FechaNacimiento As Nullable(Of Date)
    Public Property CUIT_CUIL As String
    Public Property IDCategoriaIVA As Nullable(Of Byte)
    Public Property Telefono1 As String
    Public Property Telefono2 As String
    Public Property Telefono3 As String
    Public Property Email1 As String
    Public Property Email2 As String
    Public Property DomicilioCalle1 As String
    Public Property DomicilioNumero As String
    Public Property DomicilioPiso As String
    Public Property DomicilioDepartamento As String
    Public Property DomicilioCalle2 As String
    Public Property DomicilioCalle3 As String
    Public Property DomicilioCodigoPostal As String
    Public Property DomicilioIDProvincia As String
    Public Property DomicilioIDLocalidad As Nullable(Of Short)
    Public Property IDEntidadPadre As Nullable(Of Integer)
    Public Property IDEntidadMadre As Nullable(Of Integer)
    Public Property EntidadFactura As String
    Public Property EsActivo As Boolean
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Byte
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Byte
    Public Property FechaHoraModificacion As Date

    Public Overridable Property CategoriaIVA As CategoriaIVA
    Public Overridable Property DocumentoTipo As DocumentoTipo
    Public Overridable Property EntidadesPadres As ICollection(Of EntidadEntidad) = New HashSet(Of EntidadEntidad)
    Public Overridable Property EntidadesHijas As ICollection(Of EntidadEntidad) = New HashSet(Of EntidadEntidad)
    Public Overridable Property Localidad As Localidad
    Public Overridable Property ComprobanteCabecera As ICollection(Of ComprobanteCabecera) = New HashSet(Of ComprobanteCabecera)
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property EntidadMadreHijas As ICollection(Of Entidad) = New HashSet(Of Entidad)
    Public Overridable Property EntidadMadre As Entidad
    Public Overridable Property EntidadPadreHijas As ICollection(Of Entidad) = New HashSet(Of Entidad)
    Public Overridable Property EntidadPadre As Entidad
    Public Overridable Property AniosLectivosCursos As ICollection(Of AnioLectivoCurso) = New HashSet(Of AnioLectivoCurso)

End Class

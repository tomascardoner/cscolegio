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

Partial Public Class Curso
    Public Property IDCurso As Byte
    Public Property IDAnio As Byte
    Public Property IDTurno As Byte
    Public Property Division As String
    Public Property IDCuotaTipo As Byte
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Anio As Anio
    Public Overridable Property Turno As Turno
    Public Overridable Property AniosLectivosCursos As ICollection(Of AnioLectivoCurso) = New HashSet(Of AnioLectivoCurso)
    Public Overridable Property CuotaTipo As CuotaTipo
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario

End Class

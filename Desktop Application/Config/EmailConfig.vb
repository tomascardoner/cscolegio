﻿Public Class EmailConfig
    Public Property DisplayName As String
    Public Property Address As String
    Public Property ReplyToAddress As String
    Public Property Signature As String
    Public Property SmtpServer As String
    Public Property SmtpUserName As String
    Public Property SmtpPassword As String
    Public Property SmtpPort As Integer
    Public Property SmtpUseSsl As Boolean
    Public Property SmtpTimeout As Integer
    Public Property SendMaxPerHour As Integer
    Public Property DeliveryFailedSubject As String
    Public Property DeliveryFailedErrorText As String
    Public Property DeliveryFailedRejectedAddressPreviousText As String
    Public Property DeliveryFailedSenderAddress As String

    'Friend Property SmtpSslTypeValue() As AegisImplicitMail.SslMode
    '    Get
    '        Dim value As AegisImplicitMail.SslMode = CType([Enum].Parse(GetType(AegisImplicitMail.SslMode), SmtpSslType), AegisImplicitMail.SslMode)
    '        Return value
    '    End Get
    '    Set(value As AegisImplicitMail.SslMode)
    '        Dim enumDisplayStatus As Object = CType(value, AegisImplicitMail.SslMode)
    '        SmtpSslType = enumDisplayStatus.ToString()
    '    End Set
    'End Property
End Class
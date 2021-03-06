﻿Imports Microsoft.Office.Interop

Module EntidadesSincronizarOutlookGruposMiembrosABM
    Friend Function AgregarRecipienteYResolver(ByRef OutlookApplication As Outlook.Application, ByRef OutlookDistListItem As Outlook.DistListItem, ByVal RecipientName As String) As Boolean
        Dim OutlookRecipient As Outlook.Recipient = Nothing

        Try
            OutlookRecipient = OutlookApplication.Session.CreateRecipient(RecipientName)
            If OutlookRecipient.Resolve Then
                OutlookDistListItem.AddMember(OutlookRecipient)
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, String.Format("Error al agregar y resolver el Recipiente ({1}) al Grupo ({0}) en Microsoft Outlook.", OutlookDistListItem.DLName, RecipientName))
            Return False
        End Try
    End Function

    Friend Function BorrarRecipiente(ByRef OutlookRecipient As Outlook.Recipient, ByVal OutlookDistListItem As Outlook.DistListItem, ByVal DebugMessageReason As String) As Boolean
        Try
            Debug.Print(String.Format("Outlook Sync - Contacts Group Member - Delete - {0}: {1}", DebugMessageReason, OutlookRecipient.Name))
            OutlookDistListItem.RemoveMember(OutlookRecipient)
            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, String.Format("Error al borrar el Contacto ({1}) del Grupo ({0}) en Microsoft Outlook.", OutlookDistListItem.DLName, OutlookRecipient.Name))
            Return False
        End Try
    End Function
End Module

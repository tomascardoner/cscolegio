﻿Imports System.IO

Public Class formComprobantesTransmitirPagosEduc

#Region "Declarations"
    Private dbContext As New CSColegioContext(True)
    Private listComprobantes As List(Of GridDataRow)

    Private Class GridDataRow
        Public Property IDComprobante As Integer
        Public Property ComprobanteTipoNombre As String
        Public Property NumeroCompleto As String
        Public Property ApellidoNombre As String
        Public Property ImporteTotal As Decimal
    End Class
#End Region

#Region "Form stuff"
    Private Sub formComprobantesTransmitirPagomiscuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buttonExportar.Enabled = False
        pFillAndRefreshLists.ComprobanteLote(comboboxComprobanteLote, False, False)
    End Sub

    Private Sub formComprobantesTransmitirPagomiscuentas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        dbContext.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Private Sub RefreshData()
        Dim ComprobanteLoteActual As ComprobanteLote

        Me.Cursor = Cursors.WaitCursor

        Try

            If Not comboboxComprobanteLote.SelectedValue Is Nothing Then
                ComprobanteLoteActual = CType(comboboxComprobanteLote.SelectedItem, ComprobanteLote)

                listComprobantes = (From c In dbContext.Comprobante
                                    Join cl In dbContext.ComprobanteLote On c.IDComprobanteLote Equals cl.IDComprobanteLote
                                    Join ct In dbContext.ComprobanteTipo On c.IDComprobanteTipo Equals ct.IDComprobanteTipo
                                    Where c.IDComprobanteLote = ComprobanteLoteActual.IDComprobanteLote And ct.EmisionElectronica And c.CAE IsNot Nothing And c.IDUsuarioAnulacion Is Nothing
                                    Order By ct.Nombre, c.NumeroCompleto
                                    Select New GridDataRow With {.IDComprobante = c.IDComprobante, .ComprobanteTipoNombre = ct.Nombre, .NumeroCompleto = c.NumeroCompleto, .ApellidoNombre = c.ApellidoNombre, .ImporteTotal = c.ImporteTotal1}).ToList

                Select Case listComprobantes.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Comprobantes para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Comprobante.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Comprobantes.", listComprobantes.Count)
                End Select
            Else
                listComprobantes = Nothing
            End If

            datagridviewComprobantes.AutoGenerateColumns = False
            datagridviewComprobantes.DataSource = listComprobantes

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al obtener la lista de Comprobantes.")
        End Try

        Me.Cursor = Cursors.Default

        If listComprobantes Is Nothing Then
            buttonExportar.Enabled = False
        Else
            buttonExportar.Enabled = (listComprobantes.Count > 0)
        End If
    End Sub

#End Region

#Region "Controls behavior"
    Private Sub CambiarLote() Handles comboboxComprobanteLote.SelectedIndexChanged
        RefreshData()
    End Sub

    Private Sub buttonTransmitir_Click(sender As Object, e As EventArgs) Handles buttonExportar.Click
        If listComprobantes.Count > 0 Then
            If CS_Parameter_System.GetIntegerAsInteger(Parametros.EMPRESA_PAGOSEDUC_NUMERO) = 0 Then
                MsgBox("No está especificado el Número de Empresa otorgado por PRISMA.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Exit Sub
            End If

            ExportarComprobantes()
        End If
    End Sub
#End Region

#Region "Extra stuff"
    Private Function ExportarComprobantes() As Boolean
        Dim DetalleTextStream As String

        Dim ComprobanteActual As Comprobante
        Dim DetalleCount As Integer = 0
        Dim DetalleImporteTotal As Decimal = 0

        Dim FolderName As String = ""
        Dim FileName As String

        Dim CodigoEmpresa As Integer

        ' Obtengo y verifico si existe la carpeta de destino de los archivos a exportar
        Try
            FolderName = pGeneralConfig.ExchangeOutboundFolder
            If Not FolderName.EndsWith("\") Then
                FolderName &= "\"
            End If
            FolderName &= pGeneralConfig.ExchangeOutboundPagosEducSubFolder
            If Not FolderName.EndsWith("\") Then
                FolderName &= "\"
            End If
            If Not My.Computer.FileSystem.DirectoryExists(FolderName) Then
                My.Computer.FileSystem.CreateDirectory(FolderName)
            End If

        Catch avex As AccessViolationException
            MsgBox("La aplicación no tiene permisos para acceder o crear la carpeta especificada.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            Return False

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error el acceder o crear la carpeta especificada.")
        End Try

        CodigoEmpresa = CS_Parameter_System.GetIntegerAsInteger(Parametros.EMPRESA_PAGOSEDUC_NUMERO, 0)
        FileName = "FAC" & CodigoEmpresa.ToString.PadLeft(5, "0"c) & "." & DateTime.Today.ToString("ddMMyy")

        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Using outputFile As New StreamWriter(FolderName & FileName)

            For Each RowActual As DataGridViewRow In datagridviewComprobantes.Rows
                ComprobanteActual = dbContext.Comprobante.Find(CType(RowActual.DataBoundItem, GridDataRow).IDComprobante)

                If Not ComprobanteActual Is Nothing Then
                    ' Detalle
                    DetalleTextStream = "5"                                                                 ' Código de Registro
                    DetalleTextStream &= CodigoEmpresa.ToString.PadLeft(5, "0"c)                            ' Código de Entidad
                    DetalleTextStream &= ComprobanteActual.DocumentoNumero.PadRight(14, " "c)               ' Número de Referencia
                    DetalleTextStream &= ComprobanteActual.IDComprobante.ToString.PadRight(20, " "c)        ' Id. Factura
                    DetalleTextStream &= "0"                                                                ' Código de Moneda
                    DetalleTextStream &= ComprobanteActual.FechaVencimiento1.Value.ToString("yyyyMMdd")     ' Fecha 1er. vencimiento
                    DetalleTextStream &= ComprobanteActual.ImporteTotal1.ToString("000000000.00").Replace(My.Application.Culture.NumberFormat.NumberDecimalSeparator, "")   ' Importe 1er. vencimiento
                    If ComprobanteActual.ImporteTotal2.HasValue Then
                        DetalleTextStream &= ComprobanteActual.FechaVencimiento2.Value.ToString("yyyyMMdd")     ' Fecha 2do. vencimiento
                        DetalleTextStream &= ComprobanteActual.ImporteTotal2.Value.ToString("000000000.00").Replace(My.Application.Culture.NumberFormat.NumberDecimalSeparator, "")   ' Importe 2do. vencimiento
                    Else
                        DetalleTextStream &= StrDup(8, "0"c)                                                    ' Fecha 2do. vencimiento
                        DetalleTextStream &= StrDup(11, "0"c)                                                   ' Importe 2do. vencimiento
                    End If
                    If ComprobanteActual.ImporteTotal3.HasValue Then
                        DetalleTextStream &= ComprobanteActual.FechaVencimiento3.Value.ToString("yyyyMMdd")     ' Fecha 3er. vencimiento
                        DetalleTextStream &= ComprobanteActual.ImporteTotal3.Value.ToString("000000000.00").Replace(My.Application.Culture.NumberFormat.NumberDecimalSeparator, "")   ' Importe 3er. vencimiento
                    Else
                        DetalleTextStream &= StrDup(8, "0"c)                                                    ' Fecha 3er. vencimiento
                        DetalleTextStream &= StrDup(11, "0"c)                                                   ' Importe 3er. vencimiento
                    End If
                    DetalleTextStream &= StrDup(19, "0"c)                                                   ' Filler
                    DetalleTextStream &= ComprobanteActual.Entidad.DocumentoNumero.PadRight(19, " "c)       ' Número de Referencia anterior
                    DetalleTextStream &= (ComprobanteActual.ComprobanteTipo.NombreConLetra.ToUpper.Replace("""", "") & " " & ComprobanteActual.NumeroCompleto).PadRight(40, " "c) ' Mensaje Ticket
                    DetalleTextStream &= (ComprobanteActual.ComprobanteTipo.Sigla & ComprobanteActual.PuntoVenta & ComprobanteActual.Numero).PadRight(15, " "c) ' Mensaje Pantalla
                    DetalleTextStream &= StrDup(60, " "c)                                                   ' Código de barras
                    DetalleTextStream &= StrDup(29, "0"c)                                                   ' Filler
                    outputFile.WriteLine(DetalleTextStream)

                    DetalleCount += 1
                    DetalleImporteTotal += ComprobanteActual.ImporteTotal1
                End If
            Next
        End Using

        MsgBox(String.Format("Se ha generado exitosamente el archivo de intercambio con PAGOS Educ, conteniendo {0} Comprobantes.", DetalleCount), MsgBoxStyle.Information, My.Application.Info.Title)

        RefreshData()

        Me.Cursor = Cursors.Default

        Return True
    End Function

#End Region

End Class
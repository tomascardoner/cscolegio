﻿Public Class formComprobanteVerificaAFIP

#Region "Declarations"
    Private mResultadoConsultaComprobanteActual As CS_AFIP_WS.ResultadoConsultaComprobante
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByRef ParentForm As Form, ByRef ComprobanteActual As Comprobante, ByRef ResultadoConsultaComprobanteActual As CS_AFIP_WS.ResultadoConsultaComprobante)
        Dim ListViewItemNew As ListViewItem

        mResultadoConsultaComprobanteActual = ResultadoConsultaComprobanteActual

        With mResultadoConsultaComprobanteActual
            ' Tipo de Comprobante
            ListViewItemNew = New ListViewItem
            ListViewItemNew.Text = "Tipo de Comprobante:"
            ListViewItemNew.SubItems.Add(ComprobanteActual.ComprobanteTipo.CodigoAFIP.ToString)
            ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.TipoComprobante.ToString)
            listviewMain.Items.Add(ListViewItemNew)

            ' Punto de Venta
            ListViewItemNew = New ListViewItem
            ListViewItemNew.Text = "Punto de Venta:"
            ListViewItemNew.SubItems.Add(CShort(ComprobanteActual.PuntoVenta).ToString)
            ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.PuntoVenta.ToString)
            listviewMain.Items.Add(ListViewItemNew)

            ' Número de Comprobante
            ListViewItemNew = New ListViewItem
            ListViewItemNew.Text = "Número de Comprobante:"
            ListViewItemNew.SubItems.Add(CInt(ComprobanteActual.Numero).ToString)
            ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.ComprobanteDesde.ToString)
            listviewMain.Items.Add(ListViewItemNew)

            ' Concepto
            ListViewItemNew = New ListViewItem
            ListViewItemNew.Text = "Concepto:"
            ListViewItemNew.SubItems.Add(CInt(ComprobanteActual.IDConcepto).ToString)
            ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.Concepto.ToString)
            listviewMain.Items.Add(ListViewItemNew)

            ' Tipo de Documento
            ListViewItemNew = New ListViewItem
            ListViewItemNew.Text = "Tipo de Documento:"
            ListViewItemNew.SubItems.Add(CInt(ComprobanteActual.IDDocumentoTipo).ToString)
            ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.TipoDocumento.ToString)
            listviewMain.Items.Add(ListViewItemNew)

            ' Número de Documento
            ListViewItemNew = New ListViewItem
            ListViewItemNew.Text = "Número de Documento:"
            ListViewItemNew.SubItems.Add(CInt(ComprobanteActual.DocumentoNumero).ToString)
            ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.DocumentoNumero.ToString)
            listviewMain.Items.Add(ListViewItemNew)

            ' Fecha Comprobante
            ListViewItemNew = New ListViewItem
            ListViewItemNew.Text = "Fecha del Comprobante:"
            ListViewItemNew.SubItems.Add(ComprobanteActual.FechaEmision.ToShortDateString)
            ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.ComprobanteFecha.ToShortDateString)
            listviewMain.Items.Add(ListViewItemNew)

            ' Importe Total
            ListViewItemNew = New ListViewItem
            ListViewItemNew.Text = "Importe Total:"
            ListViewItemNew.SubItems.Add(ComprobanteActual.ImporteTotal.ToString("C"))
            ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.ImporteTotal.ToString("C"))
            listviewMain.Items.Add(ListViewItemNew)

            ' Importe Neto
            ListViewItemNew = New ListViewItem
            ListViewItemNew.Text = "Importe Neto:"
            ListViewItemNew.SubItems.Add(ComprobanteActual.ImporteSubtotal.ToString("C"))
            ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.ImporteNeto.ToString("C"))
            listviewMain.Items.Add(ListViewItemNew)

            ' Importe IVA
            ListViewItemNew = New ListViewItem
            ListViewItemNew.Text = "Importe Impuestos:"
            ListViewItemNew.SubItems.Add(ComprobanteActual.ImporteImpuesto.ToString("C"))
            ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.ImporteIVA.ToString("C"))
            listviewMain.Items.Add(ListViewItemNew)

            ' Fecha de Servicio Desde
            ListViewItemNew = New ListViewItem
            ListViewItemNew.Text = "Fecha del Servicio Desde:"
            ListViewItemNew.SubItems.Add(ComprobanteActual.FechaServicioDesde.Value.ToShortDateString)
            ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.FechaServicioDesde.ToShortDateString)
            listviewMain.Items.Add(ListViewItemNew)

            ' Fecha de Servicio Hasta
            ListViewItemNew = New ListViewItem
            ListViewItemNew.Text = "Fecha del Servicio Hasta:"
            ListViewItemNew.SubItems.Add(ComprobanteActual.FechaServicioHasta.Value.ToShortDateString)
            ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.FechaServicioHasta.ToShortDateString)
            listviewMain.Items.Add(ListViewItemNew)

            ' Fecha de Vencimiento (Pago)
            ListViewItemNew = New ListViewItem
            ListViewItemNew.Text = "Fecha de Vencimiento (Pago):"
            ListViewItemNew.SubItems.Add(ComprobanteActual.FechaVencimiento.Value.ToShortDateString)
            ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.FechaVencimientoPago.ToShortDateString)
            listviewMain.Items.Add(ListViewItemNew)

            ' CAE
            ListViewItemNew = New ListViewItem
            ListViewItemNew.Text = "C.A.E.:"
            ListViewItemNew.SubItems.Add(ComprobanteActual.CAE)
            ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.CodigoAutorizacion)
            listviewMain.Items.Add(ListViewItemNew)

            ' Fecha de Vencimiento (CAE)
            ListViewItemNew = New ListViewItem
            ListViewItemNew.Text = "Fecha de Vencimiento (CAE):"
            ListViewItemNew.SubItems.Add(ComprobanteActual.CAEVencimiento.Value.ToShortDateString)
            ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.FechaVencimiento.ToShortDateString)
            listviewMain.Items.Add(ListViewItemNew)

            '' Fecha/Hora de Transmisión
            'ListViewItemNew = New ListViewItem
            'ListViewItemNew.Text = "Fecha/Hora de Transmisión:"
            'ListViewItemNew.SubItems.Add(ComprobanteActual.FechaHoraTransmisionAFIP.Value.ToShortDateString & " " & ComprobanteActual.FechaHoraTransmisionAFIP.Value.ToShortTimeString)
            'ListViewItemNew.SubItems.Add(ResultadoConsultaComprobanteActual.FechaHoraProceso.ToShortDateString & " " & ResultadoConsultaComprobanteActual.FechaHoraProceso.ToShortTimeString)
            'listviewMain.Items.Add(ListViewItemNew)
        End With

        Me.MdiParent = formMDIMain
        CS_Form.CenterToParent(ParentForm, Me)
        Me.Show()
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Focus()
    End Sub
#End Region

End Class
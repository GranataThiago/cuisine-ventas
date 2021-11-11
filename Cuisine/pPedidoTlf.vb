Imports System.Data.Odbc
Public Class pPedidoTlf

    Public idPedido As Integer


    Private Sub cargarComidas()
        bandera = False
        bandera2 = False
        sql = "select nombre from comida"
        Call consultaGeneral()
        While rs.Read = True
            cboxComidas.Items.Add(rs(0))
        End While
    End Sub

    Private Sub cargarDetalle()
        If ds.Tables.Contains("detalle_pedido") Then
            ds.Tables.Remove("detalle_pedido")
        End If
        bandera = False
        bandera2 = False
        ds.Tables.Add("detalle_pedido")
        sql = " select c.nombre, c.precio, dt.cantidad, dt.cantidad * precio from detalle_pedido dt, comida c where dt.idComida = c.idComida and idPedido = '" & idPedido & "';"
        Call consultaGeneral()
        While rs.Read = True

        End While
        Call consultaGeneral()
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("detalle_pedido"))
        Me.dgvDetalle.DataSource = ds.Tables("detalle_pedido")
        Me.dgvDetalle.Columns("nombre").HeaderText = "Comida"
        Me.dgvDetalle.Columns("cantidad").HeaderText = "Cantidad"
        Me.dgvDetalle.Columns("precio").HeaderText = "Precio"
        Me.dgvDetalle.Columns("dt.cantidad * precio").HeaderText = "Precio final"
    End Sub

    Private Sub btnAgregarComida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarComida.Click
        sql = "insert into detalle_pedido values ('', '" & idPedido & "' ,'" & (cboxComidas.SelectedIndex + 1) & "', '" & nCantidad.Value & "')"
        Call Ejecutar(sql)
        If rs.Read = True Then

        End If
        cargarDetalle()
    End Sub

    Private Sub pPedidoTlf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblPedido.Text = "Crear Ticket Delivery " & idPedido & ""
        cargarComidas()

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        bandera = False
        bandera2 = False
        sql = "update pedido set direccion = '" & tboxDireccion.Text & "' where idPedido = '" & idPedido & "'"
        Call Ejecutar(sql)
        If rs.Read = True Then

        End If
        iTicketDelivery.idPedido = idPedido
        iTicketDelivery.Show()

    End Sub
End Class
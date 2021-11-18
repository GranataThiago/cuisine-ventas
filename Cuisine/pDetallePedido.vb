Imports System.Data.Odbc

Public Class pDetallePedido

    Public idPedido As Integer

    Private Sub cargarDetalle()
        If ds.Tables.Contains("detalle_ticket") Then
            ds.Tables.Remove("detalle_pedido")
        End If
        bandera = False
        bandera2 = False
        ds.Tables.Add("detalle_pedido")
        sql = " select c.nombre, c.precio, dt.cantidad, dt.cantidad * precio from detalle_ticket dt, comida c where dt.idComida = c.idComida and idTicket = '" & idPedido & "';"
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

    Private Sub pDetallePedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarDetalle()
        lblPedido.Text = "Ticket: " & idPedido & ""
    End Sub
End Class
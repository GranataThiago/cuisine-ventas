Imports System.Data.Odbc
Public Class pPedidos

    Private i As Integer
    Private idPedido As Integer

    Private Sub btnReservar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pReservarMesa.Show()
    End Sub

    Public Sub cargarPedidosActivos()
        If ds.Tables.Contains("pedido") Then
            ds.Tables.Remove("pedido")
        End If
        bandera = False
        bandera2 = False
        ds.Tables.Add("pedido")
        sql = "select p.idTicket, p.idPedido, pr.nombreApe, p.direccion from pedido p, persona pr, repartidor r where p.entregado = false and p.idRepartidor = r.idRepartidor and r.idPersona = pr.idPersona"
        Call consultaGeneral()
        While rs.Read = True

        End While
        Call consultaGeneral()
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("pedido"))
        Me.dgvPedidos.DataSource = ds.Tables("pedido")
        Me.dgvPedidos.Columns("idTicket").HeaderText = "ID Ticket"
        Me.dgvPedidos.Columns("idPedido").HeaderText = "ID Pedido"
        Me.dgvPedidos.Columns("nombreApe").HeaderText = "Repartidor"
        Me.dgvPedidos.Columns("direccion").HeaderText = "Dirección Entrega"
    End Sub

    Private Sub pPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarPedidosActivos()
    End Sub

    Private Sub btnEntregado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntregado.Click
        i = dgvPedidos.CurrentRow.Index
        idPedido = dgvPedidos.Item(0, i).Value.ToString()

        bandera = False
        bandera2 = False
        sql = "update pedido set entregado = true where idPedido = " & idPedido & ""
        Call Ejecutar(sql)
        If rs.Read = True Then

        End If
        cargarPedidosActivos()
    End Sub

    Private Sub btnMostrarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarPedido.Click
        i = dgvPedidos.CurrentRow.Index
        idPedido = dgvPedidos.Item(0, i).Value.ToString()
        pDetalleTicket.idTicket = idPedido
        pDetalleTicket.Show()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        i = dgvPedidos.CurrentRow.Index
        idPedido = dgvPedidos.Item(0, i).Value.ToString()

        sql = "delete from pedido where idPedido = " & idPedido
        Call Ejecutar(sql)
        cargarPedidosActivos()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
        pInicial.Show()
    End Sub

    Private Sub btnPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedido.Click
        pPedidoTlf.Show()

    End Sub
End Class
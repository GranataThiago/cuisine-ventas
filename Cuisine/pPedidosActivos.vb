Imports System.Data.Odbc
Public Class pPedidosActivos

    Private i As Integer
    Private idPedido As Integer

    Private Sub cargarPedidosActivos()
        If ds.Tables.Contains("pedido") Then
            ds.Tables.Remove("pedido")
        End If
        bandera = False
        bandera2 = False
        ds.Tables.Add("pedido")
        sql = "select p.idPedido, pr.nombreApe, p.direccion from pedido p, persona pr, repartidor r where p.entregado = false and p.idRepartidor = r.idRepartidor and r.idPersona = pr.idPersona"
        Call consultaGeneral()
        While rs.Read = True

        End While
        Call consultaGeneral()
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("pedido"))
        Me.dvgPedidosActivos.DataSource = ds.Tables("pedido")
        Me.dvgPedidosActivos.Columns("idPedido").HeaderText = "ID Pedido"
        Me.dvgPedidosActivos.Columns("nombreApe").HeaderText = "Repartidor"
        Me.dvgPedidosActivos.Columns("direccion").HeaderText = "Dirección Entrega"
    End Sub

    Private Sub pPedidosActivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarPedidosActivos()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        pPrincipal.Show()

    End Sub

    Private Sub btnMostrarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarPedido.Click
        i = dvgPedidosActivos.CurrentRow.Index
        idPedido = dvgPedidosActivos.Item(0, i).Value.ToString()
        pDetallePedido.idPedido = idPedido
        pDetallePedido.Show()
    End Sub

    Private Sub btnEntregado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntregado.Click
        i = dvgPedidosActivos.CurrentRow.Index
        idPedido = dvgPedidosActivos.Item(0, i).Value.ToString()

        bandera = False
        bandera2 = False
        sql = "update pedido set entregado = true where idPedido = " & idPedido & ""
        Call Ejecutar(sql)
        If rs.Read = True Then

        End If
        cargarPedidosActivos()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        i = dvgPedidosActivos.CurrentRow.Index
        idPedido = dvgPedidosActivos.Item(0, i).Value.ToString()

        sql = "delete from pedido where idPedido = " & idPedido
        Call Ejecutar(sql)
        cargarPedidosActivos()
    End Sub
End Class
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

    Private Sub cargarRepartidores()
        bandera = False
        bandera2 = False
        sql = "select nombreApe from persona p, repartidor r where p.idPersona = r.idPersona"
        Call consultaGeneral()
        While rs.Read = True
            cboxRepartidor.Items.Add(rs(0))
        End While
    End Sub

    Private Sub cargarDetalle()
        If ds.Tables.Contains("detalle_ticket") Then
            ds.Tables.Remove("detalle_ticket")
        End If
        bandera = False
        bandera2 = False
        ds.Tables.Add("detalle_ticket")
        sql = " select c.nombre, c.precio, dt.cantidad, dt.cantidad * precio from detalle_ticket dt, comida c where dt.idComida = c.idComida and idTicket = '" & idPedido & "';"
        Call consultaGeneral()
        While rs.Read = True

        End While
        Call consultaGeneral()
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("detalle_ticket"))
        Me.dgvDetalle.DataSource = ds.Tables("detalle_ticket")
        Me.dgvDetalle.Columns("nombre").HeaderText = "Comida"
        Me.dgvDetalle.Columns("cantidad").HeaderText = "Cantidad"
        Me.dgvDetalle.Columns("precio").HeaderText = "Precio"
        Me.dgvDetalle.Columns("dt.cantidad * precio").HeaderText = "Precio final"
    End Sub

    Private Sub btnAgregarComida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarComida.Click
        sql = "insert into detalle_ticket values ('', '" & idPedido & "' ,'" & (cboxComidas.SelectedIndex + 1) & "', '" & nCantidad.Value & "')"
        Call Ejecutar(sql)
        If rs.Read = True Then

        End If
        cargarDetalle()
    End Sub

    Private Sub pPedidoTlf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblPedido.Text = "Crear Ticket Delivery"
        cargarComidas()
        cargarRepartidores()
        btnAgregarComida.Enabled = False

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        iTicketMesa.idTicket = idPedido
        iTicketMesa.Show()
    End Sub

    Private Sub btnCrearTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearTicket.Click
        bandera = False
        bandera2 = False
        sql = "insert into ticket values('')"
        Call Ejecutar(sql)
        If rs.Read = False Then
            sql = "insert into pedido values('', (select max(idTicket) from ticket), '" & (cboxRepartidor.SelectedIndex + 1) & "', '" & tboxDireccion.Text & "', false)"
            Call Ejecutar(sql)
            If rs2.Read = False Then
                sql = "(select max(idTicket) from ticket)"
                Call Ejecutar2(sql)
                If rs3.Read = True Then
                    idPedido = rs3(0)
                    btnAgregarComida.Enabled = True
                End If
 
            End If
        End If

    End Sub
End Class
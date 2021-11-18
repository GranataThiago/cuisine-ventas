Imports System.Data.Odbc
Public Class pPrincipal

    Private i As Integer
    Private idTicket As Integer

    Private Sub conexionBase()
        Try
            cnn = New OdbcConnection("DSN=Cuisine")
            cnn.Open()
            MsgBox("Conexión satisfactoria", , "Cuisine Ventas")
        Catch ex As Exception
            MsgBox("La conexion ha fallado", , "Cuisine Ventas")
            Me.Close()

            Application.Exit()

            End

        End Try
    End Sub

    Private Sub cargarTickets()
        If ds.Tables.Contains("pedido_local") Then
            ds.Tables.Remove("pedido_local")
        End If
        bandera = False
        bandera2 = False
        ds.Tables.Add("pedido_local")
        sql = "select idTicket, idPedidoLocal, idMesa, metodoPago from pedido_local"
        Call consultaGeneral()
        While rs.Read = True

        End While
        Call consultaGeneral()
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("pedido_local"))
        Me.dgvMesas.DataSource = ds.Tables("pedido_local")
        Me.dgvMesas.Columns("idTicket").HeaderText = "Nro Ticket"
        Me.dgvMesas.Columns("idPedidoLocal").HeaderText = "Nro Pedido"
        Me.dgvMesas.Columns("idMesa").HeaderText = "Mesa Nro"
        Me.dgvMesas.Columns("metodoPago").HeaderText = "Metodo Pago"
    End Sub

    Private Sub cargarMesas()
        sql = "select idMesa from mesa"
        Call consultaGeneral()
        While rs.Read = True
            cboxMesas.Items.Add(rs(0))
        End While
    End Sub

    Private Sub pPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexionBase()
        cargarMesas()
        cargarTickets()

    End Sub

    Private Sub btnCrearTicket_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearTicket.Click
        bandera = False
        bandera2 = False

        sql = "insert into ticket values('')"
        Call Ejecutar(sql)
        If rs.Read = False Then
            sql = "insert into pedido_local values('', (select max(idTicket) from ticket), '" & cboxMesas.SelectedItem & "', '1', 'Efectivo')"
            Call Ejecutar(sql)
            If rs.Read = True Then

            End If
        End If

        cargarTickets()
    End Sub


    Private Sub btnDetalleTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalleTicket.Click
        i = dgvMesas.CurrentRow.Index
        idTicket = dgvMesas.Item(0, i).Value.ToString()
        pDetalleTicket.idTicket = idTicket

        pDetalleTicket.Show()

    End Sub

    Private Sub btnPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedido.Click
        pPedidoTlf.Show()
    End Sub

    Private Sub btnMostrarPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarPedidos.Click
        Me.Hide()
        pPedidosActivos.Show()

    End Sub

    Private Sub btnReservar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservar.Click
        pReservarMesa.Show()
    End Sub

    Private Sub btnMostrarReservas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarReservas.Click
        pMostrarReservas.show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pInicial.Show()

    End Sub

    Private Sub gboxTicket_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gboxTicket.Enter

    End Sub

    Private Sub cboxMesas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxMesas.SelectedIndexChanged

    End Sub

    Private Sub lblNroMesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNroMesa.Click

    End Sub

    Private Sub dgvMesas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMesas.CellContentClick

    End Sub
End Class

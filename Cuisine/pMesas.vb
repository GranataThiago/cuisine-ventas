Imports System.Data.Odbc
Public Class pMesas

    Private i As Integer
    Private idTicket As Integer

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
        bandera = False
        bandera2 = False
        sql = "select idMesa from mesa"
        Call consultaGeneral()
        While rs.Read = True
            cboxMesas.Items.Add(rs(0))
        End While
    End Sub

    Private Sub pMesas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnReservar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservar.Click
        pReservarMesa.Show()
    End Sub

    Private Sub btnMostrarReservas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarReservas.Click
        pMostrarReservas.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
        pInicial.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarTicket.Click
        i = dgvMesas.CurrentRow.Index
        idTicket = dgvMesas.Item(1, i).Value.ToString()

        sql = "delete from pedido_local where idPedidoLocal = " & idTicket
        Call Ejecutar(sql)
        cargarTickets()
    End Sub
End Class
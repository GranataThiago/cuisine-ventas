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


        End Try
    End Sub

    Private Sub cargarTickets()
        If ds.Tables.Contains("ticket") Then
            ds.Tables.Remove("ticket")
        End If
        bandera = False
        bandera2 = False
        ds.Tables.Add("ticket")
        sql = "select idTicket, idMesa, metodoPago from ticket"
        Call consultaGeneral()
        While rs.Read = True

        End While
        Call consultaGeneral()
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("ticket"))
        Me.dgvMesas.DataSource = ds.Tables("ticket")
        Me.dgvMesas.Columns("idTicket").HeaderText = "ID Ticket"
        Me.dgvMesas.Columns("idMesa").HeaderText = "ID Mesa"
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
        sql = "insert into ticket values('', '" & cboxMesas.SelectedItem & "', '1', 'Efectivo')"
        Call Ejecutar(sql)
        If rs.Read = True Then

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
End Class

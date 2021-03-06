Imports System.Data.Odbc
Public Class pDetalleTicket

    Public idTicket As Integer

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
        If ds.Tables.Contains("detalle_ticket") Then
            ds.Tables.Remove("detalle_ticket")
        End If
        bandera = False
        bandera2 = False
        ds.Tables.Add("detalle_ticket")
        sql = " select c.nombre, c.precio, dt.cantidad, dt.cantidad * precio from detalle_ticket dt, comida c where dt.idComida = c.idComida and idTicket = '" & idTicket & "';"
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

    Private Sub pDetalleTicket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarComidas()
        cargarDetalle()
        lblDetalleTicket.Text = "Ticket: " & idTicket & ""
    End Sub

    Private Sub btnAgregarComida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarComida.Click
        sql = "insert into detalle_ticket values ('', '" & idTicket & "', '" & (cboxComidas.SelectedIndex + 1) & "', '" & nCantidad.Value & "')"
        Call Ejecutar(sql)
        If rs.Read = True Then

        End If
        cargarDetalle()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarTicket.Click
        bandera = False
        bandera2 = False

        Call Ejecutar(sql)
        If rs.Read = True Then

        End If
        iTicketMesa.idTicket = idTicket
        iTicketMesa.Show()

    End Sub
End Class
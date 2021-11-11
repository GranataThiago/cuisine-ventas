Imports System.Data.Odbc
Public Class iTicketDelivery
    Public idPedido As Integer
    Private total As Integer

    Private Sub cargarPedido()
        If ds.Tables.Contains("detalle_pedido") Then
            ds.Tables.Remove("detalle_pedido")
        End If
        bandera = False
        bandera2 = False
        ds.Tables.Add("detalle_pedido")
        sql = " select c.nombre, c.precio, dt.cantidad, dt.cantidad * precio from detalle_pedido dt, comida c where dt.idComida = c.idComida and idPedido = '" & idPedido & "';"
        Call consultaGeneral()
        While rs.Read = True
            total += rs(3)
        End While
        Call consultaGeneral()
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("detalle_pedido"))
        Me.dgvDelivery.DataSource = ds.Tables("detalle_pedido")
        Me.dgvDelivery.Columns("nombre").HeaderText = "Comida"
        Me.dgvDelivery.Columns("cantidad").HeaderText = "Cantidad"
        Me.dgvDelivery.Columns("precio").HeaderText = "Precio"
        Me.dgvDelivery.Columns("dt.cantidad * precio").HeaderText = "Precio final"
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        btnCerrar.Hide()
        btnImprimir.Hide()
        PrintTicketDel.PrintAction = Printing.PrintAction.PrintToPrinter
        PrintTicketDel.Print()
        btnCerrar.Show()
    End Sub


    Private Sub iTicketDelivery_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarPedido()
        lblTotal.Text = "Total: " & total & ""
    End Sub
End Class
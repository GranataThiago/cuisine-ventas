Imports System.Data.Odbc
Public Class pMostrarReservas

    Private i As Integer
    Private idPedido As Integer


    Public Sub cargarReservas()
        If ds.Tables.Contains("reserva") Then
            ds.Tables.Remove("reserva")
        End If
        bandera = False
        bandera2 = False
        ds.Tables.Add("reserva")
        sql = "select r.idReserva, r.idMesa, p.nombreApe, r.fecha, h.hora from reserva r, persona p, cliente c, horario h where r.idCliente = c.idCliente AND c.idPersona = p.idPersona AND r.idHorario = h.idHorario"
        Call consultaGeneral()
        While rs.Read = True

        End While
        Call consultaGeneral()
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("reserva"))
        Me.dgvReservas.DataSource = ds.Tables("reserva")
        Me.dgvReservas.Columns("idReserva").HeaderText = "ID Reserva"
        Me.dgvReservas.Columns("idMesa").HeaderText = "ID Mesa"
        Me.dgvReservas.Columns("nombreApe").HeaderText = "Cliente"
        Me.dgvReservas.Columns("fecha").HeaderText = "Fecha"
        Me.dgvReservas.Columns("hora").HeaderText = "Hora"
    End Sub

    Private Sub pMostrarReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarReservas()
    End Sub

    Private Sub btnCancelarReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarReserva.Click
        bandera2 = False
        i = dgvReservas.CurrentRow.Index
        idPedido = dgvReservas.Item(0, i).Value.ToString()
        sql = "delete from reserva where idReserva = " & idPedido
        Call Ejecutar(sql)
        If rs2.Read = True Then

        End If
        cargarReservas()
    End Sub

    Private Sub btnModificarReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarReserva.Click
        i = dgvReservas.CurrentRow.Index
        idPedido = dgvReservas.Item(0, i).Value.ToString()
        pModificarReserva.idReserva = idPedido
        pModificarReserva.Show()



    End Sub
End Class
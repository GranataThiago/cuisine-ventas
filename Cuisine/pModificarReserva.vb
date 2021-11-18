Public Class pModificarReserva

    Public idReserva As Integer
    Private idMesa As Integer
    Private idHorario As Integer
    Private fechaSeleccionada As String

    Private Sub cargarMesas()
        bandera = False
        bandera2 = False
        sql = "select idMesa from mesa"
        Call consultaGeneral()
        While rs.Read = True
            cboxMesas.Items.Add(rs(0))
        End While
    End Sub

    Private Sub cargarHorarios()
        bandera = False
        bandera2 = False
        sql = "select hora from horario"
        Call consultaGeneral()
        While rs.Read = True
            cboxHorarios.Items.Add(rs(0))
        End While
    End Sub

    Private Sub cargarCliente()
        bandera = False
        bandera2 = False
        sql = "select p.nombreApe from reserva r, cliente c, persona p where r.idCliente = c.idCliente AND p.idPersona = c.idPersona"
        Call Ejecutar(sql)
        If rs.Read = True Then
            tboxNombre.Text = rs(0)
        End If
    End Sub

    Private Sub pModificarReserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarCliente()
        cargarHorarios()
        cargarMesas()

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        reservarMesa()
        Me.Close()
        pMostrarReservas.cargarReservas()
    End Sub


    Private Sub reservarMesa()
        bandera = False
        bandera2 = False
        idMesa = (cboxMesas.SelectedIndex + 1)
        idHorario = (cboxHorarios.SelectedIndex + 1)
        fechaSeleccionada = cFecha.SelectionRange.Start.Date.ToString("yyyy-MM-dd")

        sql = "select COUNT(*) from reserva where idHorario = " & idHorario & " AND fecha = '" & fechaSeleccionada & "' AND idReserva <> " & idReserva & ";"
        Call Ejecutar(sql)
        If rs.Read = True Then
            If rs(0) = 0 Then
                sql = "update reserva set fecha = '" & fechaSeleccionada & "', idMesa = " & idMesa & ", idHorario = " & idHorario & " where idReserva = " & idReserva
                Call Ejecutar(sql)
                If rs2.Read = True Then

                End If
                Me.Close()

            Else
                MsgBox("Esta combinación hora-fecha ya está seleccionada, por favor vuelva a intentarlo con otra combinación")
            End If
        End If
    End Sub
End Class
Public Class pReservarMesa

    Private idCliente As Integer
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

    Public Sub cargarClientes()
        cboxClientes.Items.Clear()
        bandera = False
        bandera2 = False
        sql = "select nombreApe from persona p, cliente c where p.idPersona = c.idPersona"
        Call consultaGeneral()
        While rs.Read = True
            cboxClientes.Items.Add(rs(0))
        End While
    End Sub

    Private Sub pReservarMesa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarClientes()
        cargarHorarios()
        cargarMesas()
    End Sub

    Private Sub btnAgregarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCliente.Click
        pAgregarCliente.Show()
    End Sub

    Private Sub btnReservar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservar.Click
        bandera = False
        bandera2 = False
        idCliente = (cboxClientes.SelectedIndex + 1)
        idMesa = (cboxMesas.SelectedIndex + 1)
        idHorario = (cboxHorarios.SelectedIndex + 1)
        fechaSeleccionada = cFecha.SelectionRange.Start.Date.ToString("yyyy-MM-dd")

        sql = "select COUNT(*) from reserva where idHorario = " & idHorario & " AND fecha = '" & fechaSeleccionada & "';"
        Call Ejecutar(sql)
        If rs.Read = True Then
            If rs(0) = 0 Then
                sql = "insert into reserva values('', " & idMesa & ", " & idCliente & ", '" & fechaSeleccionada & "' ," & idHorario & " )"
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
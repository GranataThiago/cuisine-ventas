Public Class pAgregarCliente

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        bandera = False
        bandera2 = False
        sql = "insert into persona values ('', '" & tboxNombre.Text & "', '" & tboxDireccion.Text & "', '" & tboxTelefono.Text & "', NULL)"
        Call Ejecutar(sql)
        If rs.Read = False Then
            sql = "insert into cliente values ('', (select max(idPersona) from persona))"
            Call Ejecutar(sql)
            If rs2.Read = True Then

            End If
        End If
        pReservarMesa.cargarClientes()
    End Sub


End Class
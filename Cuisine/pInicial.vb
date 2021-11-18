Imports System.Data.Odbc
Public Class pInicial


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

    Private Sub pobxMesas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pboxMesas.Click
        pMesas.Show()
        Me.Hide()

    End Sub

    Private Sub pInicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexionBase()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub pboxPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pboxPedidos.Click
        pPedidos.Show()
        Me.Hide()
    End Sub
End Class
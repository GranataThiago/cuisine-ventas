Imports System.Data.Odbc
Module cnxBd
    Public sql As String
    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs, rs2, rs3 As OdbcDataReader
    Public bandera, bandera2 As Boolean
    Public ds As New DataSet
    Public adp As New OdbcDataAdapter
    Public ds2 As New DataSet
    Public adp2 As New OdbcDataAdapter
    Public fechaCobros As Date


    Public Function Ejecutar(ByVal sql As String)
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        If (bandera = False) Then
            rs = cmd.ExecuteReader
            bandera = True
        ElseIf (bandera2 = False And bandera = True) Then
            rs2 = cmd.ExecuteReader
            bandera2 = True
        End If
        cmd.Dispose()
        Return 0

    End Function

    Public Sub consultaGeneral()
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        If bandera = False Then
            rs = cmd.ExecuteReader
            bandera = True
        Else
            rs2 = cmd.ExecuteReader
        End If
        cmd.Dispose()
    End Sub

    Public Function Ejecutar2(ByVal sql As String)
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text

        rs3 = cmd.ExecuteReader

        cmd.Dispose()
        Return 0

    End Function

End Module

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pPedidosActivos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblActivos = New System.Windows.Forms.Label()
        Me.dvgPedidosActivos = New System.Windows.Forms.DataGridView()
        Me.btnEntregado = New System.Windows.Forms.Button()
        Me.btnMostrarPedido = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.dvgPedidosActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblActivos
        '
        Me.lblActivos.AutoSize = True
        Me.lblActivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!)
        Me.lblActivos.Location = New System.Drawing.Point(227, 30)
        Me.lblActivos.Name = "lblActivos"
        Me.lblActivos.Size = New System.Drawing.Size(265, 39)
        Me.lblActivos.TabIndex = 3
        Me.lblActivos.Text = "Pedidos Activos"
        '
        'dvgPedidosActivos
        '
        Me.dvgPedidosActivos.AllowUserToAddRows = False
        Me.dvgPedidosActivos.AllowUserToDeleteRows = False
        Me.dvgPedidosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgPedidosActivos.Location = New System.Drawing.Point(41, 72)
        Me.dvgPedidosActivos.Name = "dvgPedidosActivos"
        Me.dvgPedidosActivos.Size = New System.Drawing.Size(650, 422)
        Me.dvgPedidosActivos.TabIndex = 4
        '
        'btnEntregado
        '
        Me.btnEntregado.Location = New System.Drawing.Point(214, 520)
        Me.btnEntregado.Name = "btnEntregado"
        Me.btnEntregado.Size = New System.Drawing.Size(111, 46)
        Me.btnEntregado.TabIndex = 5
        Me.btnEntregado.Text = "Marcar como entregado"
        Me.btnEntregado.UseVisualStyleBackColor = True
        '
        'btnMostrarPedido
        '
        Me.btnMostrarPedido.Location = New System.Drawing.Point(580, 520)
        Me.btnMostrarPedido.Name = "btnMostrarPedido"
        Me.btnMostrarPedido.Size = New System.Drawing.Size(111, 46)
        Me.btnMostrarPedido.TabIndex = 6
        Me.btnMostrarPedido.Text = "Mostrar pedido"
        Me.btnMostrarPedido.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(41, 520)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(111, 46)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(397, 520)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(111, 46)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar Pedido"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'pPedidosActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 578)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnMostrarPedido)
        Me.Controls.Add(Me.btnEntregado)
        Me.Controls.Add(Me.dvgPedidosActivos)
        Me.Controls.Add(Me.lblActivos)
        Me.Name = "pPedidosActivos"
        Me.Text = "Cuisine"
        CType(Me.dvgPedidosActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblActivos As System.Windows.Forms.Label
    Friend WithEvents dvgPedidosActivos As System.Windows.Forms.DataGridView
    Friend WithEvents btnEntregado As System.Windows.Forms.Button
    Friend WithEvents btnMostrarPedido As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pPedidoTlf
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
        Me.lblPedido = New System.Windows.Forms.Label()
        Me.nCantidad = New System.Windows.Forms.NumericUpDown()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnAgregarComida = New System.Windows.Forms.Button()
        Me.cboxComidas = New System.Windows.Forms.ComboBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.lblDirCliente = New System.Windows.Forms.Label()
        Me.tboxDireccion = New System.Windows.Forms.TextBox()
        CType(Me.nCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPedido
        '
        Me.lblPedido.AutoSize = True
        Me.lblPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!)
        Me.lblPedido.Location = New System.Drawing.Point(123, 22)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Size = New System.Drawing.Size(343, 39)
        Me.lblPedido.TabIndex = 4
        Me.lblPedido.Text = "Crear Ticket Delivery"
        '
        'nCantidad
        '
        Me.nCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.nCantidad.Location = New System.Drawing.Point(408, 360)
        Me.nCantidad.Name = "nCantidad"
        Me.nCantidad.Size = New System.Drawing.Size(132, 32)
        Me.nCantidad.TabIndex = 14
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(412, 340)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 13
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(414, 278)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(42, 13)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Comida"
        '
        'btnAgregarComida
        '
        Me.btnAgregarComida.Location = New System.Drawing.Point(408, 398)
        Me.btnAgregarComida.Name = "btnAgregarComida"
        Me.btnAgregarComida.Size = New System.Drawing.Size(132, 43)
        Me.btnAgregarComida.TabIndex = 11
        Me.btnAgregarComida.Text = "Agregar Comida"
        Me.btnAgregarComida.UseVisualStyleBackColor = True
        '
        'cboxComidas
        '
        Me.cboxComidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cboxComidas.FormattingEnabled = True
        Me.cboxComidas.Location = New System.Drawing.Point(408, 297)
        Me.cboxComidas.Name = "cboxComidas"
        Me.cboxComidas.Size = New System.Drawing.Size(132, 33)
        Me.cboxComidas.TabIndex = 10
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(106, 513)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(108, 43)
        Me.btnImprimir.TabIndex = 15
        Me.btnImprimir.Text = "Generar Ticket"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'dgvDetalle
        '
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(24, 84)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(290, 405)
        Me.dgvDetalle.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(374, 142)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 20)
        Me.TextBox1.TabIndex = 17
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(385, 126)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(79, 13)
        Me.lblNombreCliente.TabIndex = 18
        Me.lblNombreCliente.Text = "Nombre Cliente"
        '
        'lblDirCliente
        '
        Me.lblDirCliente.AutoSize = True
        Me.lblDirCliente.Location = New System.Drawing.Point(385, 205)
        Me.lblDirCliente.Name = "lblDirCliente"
        Me.lblDirCliente.Size = New System.Drawing.Size(107, 13)
        Me.lblDirCliente.TabIndex = 20
        Me.lblDirCliente.Text = "Direccion de Entrega"
        '
        'tboxDireccion
        '
        Me.tboxDireccion.Location = New System.Drawing.Point(374, 221)
        Me.tboxDireccion.Name = "tboxDireccion"
        Me.tboxDireccion.Size = New System.Drawing.Size(213, 20)
        Me.tboxDireccion.TabIndex = 19
        '
        'pPedidoTlf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 568)
        Me.Controls.Add(Me.lblDirCliente)
        Me.Controls.Add(Me.tboxDireccion)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.nCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnAgregarComida)
        Me.Controls.Add(Me.cboxComidas)
        Me.Controls.Add(Me.lblPedido)
        Me.Name = "pPedidoTlf"
        Me.Text = "Cuisine"
        CType(Me.nCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPedido As System.Windows.Forms.Label
    Friend WithEvents nCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnAgregarComida As System.Windows.Forms.Button
    Friend WithEvents cboxComidas As System.Windows.Forms.ComboBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
    Friend WithEvents lblDirCliente As System.Windows.Forms.Label
    Friend WithEvents tboxDireccion As System.Windows.Forms.TextBox
End Class

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
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.lblDirCliente = New System.Windows.Forms.Label()
        Me.tboxDireccion = New System.Windows.Forms.TextBox()
        Me.lblRepartidor = New System.Windows.Forms.Label()
        Me.cboxRepartidor = New System.Windows.Forms.ComboBox()
        Me.btnCrearTicket = New System.Windows.Forms.Button()
        Me.gboxTicket = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.nCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPedido
        '
        Me.lblPedido.AutoSize = True
        Me.lblPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!)
        Me.lblPedido.Location = New System.Drawing.Point(152, 34)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Size = New System.Drawing.Size(343, 39)
        Me.lblPedido.TabIndex = 4
        Me.lblPedido.Text = "Crear Ticket Delivery"
        '
        'nCantidad
        '
        Me.nCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.nCantidad.Location = New System.Drawing.Point(416, 417)
        Me.nCantidad.Name = "nCantidad"
        Me.nCantidad.Size = New System.Drawing.Size(132, 32)
        Me.nCantidad.TabIndex = 14
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(420, 397)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 13
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(422, 335)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(42, 13)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Comida"
        '
        'btnAgregarComida
        '
        Me.btnAgregarComida.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarComida.Location = New System.Drawing.Point(416, 455)
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
        Me.cboxComidas.Location = New System.Drawing.Point(416, 354)
        Me.cboxComidas.Name = "cboxComidas"
        Me.cboxComidas.Size = New System.Drawing.Size(132, 33)
        Me.cboxComidas.TabIndex = 10
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(24, 93)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(290, 405)
        Me.dgvDetalle.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(374, 130)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 20)
        Me.TextBox1.TabIndex = 17
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(385, 114)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(79, 13)
        Me.lblNombreCliente.TabIndex = 18
        Me.lblNombreCliente.Text = "Nombre Cliente"
        '
        'lblDirCliente
        '
        Me.lblDirCliente.AutoSize = True
        Me.lblDirCliente.Location = New System.Drawing.Point(385, 166)
        Me.lblDirCliente.Name = "lblDirCliente"
        Me.lblDirCliente.Size = New System.Drawing.Size(107, 13)
        Me.lblDirCliente.TabIndex = 20
        Me.lblDirCliente.Text = "Direccion de Entrega"
        '
        'tboxDireccion
        '
        Me.tboxDireccion.Location = New System.Drawing.Point(374, 182)
        Me.tboxDireccion.Name = "tboxDireccion"
        Me.tboxDireccion.Size = New System.Drawing.Size(213, 20)
        Me.tboxDireccion.TabIndex = 19
        '
        'lblRepartidor
        '
        Me.lblRepartidor.AutoSize = True
        Me.lblRepartidor.Location = New System.Drawing.Point(385, 224)
        Me.lblRepartidor.Name = "lblRepartidor"
        Me.lblRepartidor.Size = New System.Drawing.Size(110, 13)
        Me.lblRepartidor.TabIndex = 22
        Me.lblRepartidor.Text = "Repartidor encargado"
        '
        'cboxRepartidor
        '
        Me.cboxRepartidor.FormattingEnabled = True
        Me.cboxRepartidor.Location = New System.Drawing.Point(374, 241)
        Me.cboxRepartidor.Name = "cboxRepartidor"
        Me.cboxRepartidor.Size = New System.Drawing.Size(213, 21)
        Me.cboxRepartidor.TabIndex = 23
        '
        'btnCrearTicket
        '
        Me.btnCrearTicket.ForeColor = System.Drawing.Color.Black
        Me.btnCrearTicket.Location = New System.Drawing.Point(414, 273)
        Me.btnCrearTicket.Name = "btnCrearTicket"
        Me.btnCrearTicket.Size = New System.Drawing.Size(132, 43)
        Me.btnCrearTicket.TabIndex = 24
        Me.btnCrearTicket.Text = "Crear Ticket"
        Me.btnCrearTicket.UseVisualStyleBackColor = True
        '
        'gboxTicket
        '
        Me.gboxTicket.Location = New System.Drawing.Point(346, 93)
        Me.gboxTicket.Name = "gboxTicket"
        Me.gboxTicket.Size = New System.Drawing.Size(269, 239)
        Me.gboxTicket.TabIndex = 25
        Me.gboxTicket.TabStop = False
        Me.gboxTicket.Text = "Crear Ticket"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.flecha_hacia_atras__1_
        Me.PictureBox1.Location = New System.Drawing.Point(24, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 63)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'pPedidoTlf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(627, 568)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCrearTicket)
        Me.Controls.Add(Me.cboxRepartidor)
        Me.Controls.Add(Me.lblRepartidor)
        Me.Controls.Add(Me.lblDirCliente)
        Me.Controls.Add(Me.tboxDireccion)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.nCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnAgregarComida)
        Me.Controls.Add(Me.cboxComidas)
        Me.Controls.Add(Me.lblPedido)
        Me.Controls.Add(Me.gboxTicket)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Name = "pPedidoTlf"
        Me.Text = "Cuisine"
        CType(Me.nCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPedido As System.Windows.Forms.Label
    Friend WithEvents nCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnAgregarComida As System.Windows.Forms.Button
    Friend WithEvents cboxComidas As System.Windows.Forms.ComboBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
    Friend WithEvents lblDirCliente As System.Windows.Forms.Label
    Friend WithEvents tboxDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblRepartidor As System.Windows.Forms.Label
    Friend WithEvents cboxRepartidor As System.Windows.Forms.ComboBox
    Friend WithEvents btnCrearTicket As System.Windows.Forms.Button
    Friend WithEvents gboxTicket As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

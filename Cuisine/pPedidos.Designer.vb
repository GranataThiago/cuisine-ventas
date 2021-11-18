<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pPedidos
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
        Me.lblPedidosLocales = New System.Windows.Forms.Label()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEntregado = New System.Windows.Forms.Button()
        Me.btnMostrarPedido = New System.Windows.Forms.Button()
        Me.btnPedido = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPedidosLocales
        '
        Me.lblPedidosLocales.AutoSize = True
        Me.lblPedidosLocales.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.lblPedidosLocales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPedidosLocales.Location = New System.Drawing.Point(468, 49)
        Me.lblPedidosLocales.Name = "lblPedidosLocales"
        Me.lblPedidosLocales.Size = New System.Drawing.Size(365, 55)
        Me.lblPedidosLocales.TabIndex = 20
        Me.lblPedidosLocales.Text = "Pedidos Activos"
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowUserToAddRows = False
        Me.dgvPedidos.AllowUserToDeleteRows = False
        Me.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Location = New System.Drawing.Point(199, 125)
        Me.dgvPedidos.MultiSelect = False
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.ReadOnly = True
        Me.dgvPedidos.Size = New System.Drawing.Size(923, 415)
        Me.dgvPedidos.TabIndex = 21
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(945, 564)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(111, 46)
        Me.btnCancelar.TabIndex = 23
        Me.btnCancelar.Text = "Cancelar Pedido"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEntregado
        '
        Me.btnEntregado.Location = New System.Drawing.Point(713, 563)
        Me.btnEntregado.Name = "btnEntregado"
        Me.btnEntregado.Size = New System.Drawing.Size(111, 46)
        Me.btnEntregado.TabIndex = 24
        Me.btnEntregado.Text = "Marcar como entregado"
        Me.btnEntregado.UseVisualStyleBackColor = True
        '
        'btnMostrarPedido
        '
        Me.btnMostrarPedido.Location = New System.Drawing.Point(468, 563)
        Me.btnMostrarPedido.Name = "btnMostrarPedido"
        Me.btnMostrarPedido.Size = New System.Drawing.Size(111, 46)
        Me.btnMostrarPedido.TabIndex = 25
        Me.btnMostrarPedido.Text = "Mostrar pedido"
        Me.btnMostrarPedido.UseVisualStyleBackColor = True
        '
        'btnPedido
        '
        Me.btnPedido.Location = New System.Drawing.Point(246, 565)
        Me.btnPedido.Name = "btnPedido"
        Me.btnPedido.Size = New System.Drawing.Size(111, 43)
        Me.btnPedido.TabIndex = 26
        Me.btnPedido.Text = "Crear Pedido Tlf."
        Me.btnPedido.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.flecha_hacia_atras__1_
        Me.PictureBox1.Location = New System.Drawing.Point(30, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 63)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'pPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1283, 639)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPedido)
        Me.Controls.Add(Me.btnMostrarPedido)
        Me.Controls.Add(Me.btnEntregado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dgvPedidos)
        Me.Controls.Add(Me.lblPedidosLocales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "pPedidos"
        Me.Text = "Cuisine"
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPedidosLocales As System.Windows.Forms.Label
    Friend WithEvents dgvPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEntregado As System.Windows.Forms.Button
    Friend WithEvents btnMostrarPedido As System.Windows.Forms.Button
    Friend WithEvents btnPedido As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

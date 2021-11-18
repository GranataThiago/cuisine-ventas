<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pDetalleTicket
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
        Me.btnGenerarTicket = New System.Windows.Forms.Button()
        Me.lblDetalleTicket = New System.Windows.Forms.Label()
        Me.cboxComidas = New System.Windows.Forms.ComboBox()
        Me.btnAgregarComida = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.nCantidad = New System.Windows.Forms.NumericUpDown()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        CType(Me.nCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGenerarTicket
        '
        Me.btnGenerarTicket.Location = New System.Drawing.Point(121, 524)
        Me.btnGenerarTicket.Name = "btnGenerarTicket"
        Me.btnGenerarTicket.Size = New System.Drawing.Size(108, 43)
        Me.btnGenerarTicket.TabIndex = 2
        Me.btnGenerarTicket.Text = "Generar Ticket"
        Me.btnGenerarTicket.UseVisualStyleBackColor = True
        '
        'lblDetalleTicket
        '
        Me.lblDetalleTicket.AutoSize = True
        Me.lblDetalleTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!)
        Me.lblDetalleTicket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDetalleTicket.Location = New System.Drawing.Point(123, 32)
        Me.lblDetalleTicket.Name = "lblDetalleTicket"
        Me.lblDetalleTicket.Size = New System.Drawing.Size(130, 39)
        Me.lblDetalleTicket.TabIndex = 3
        Me.lblDetalleTicket.Text = "Ticket: "
        '
        'cboxComidas
        '
        Me.cboxComidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cboxComidas.FormattingEnabled = True
        Me.cboxComidas.Location = New System.Drawing.Point(342, 117)
        Me.cboxComidas.Name = "cboxComidas"
        Me.cboxComidas.Size = New System.Drawing.Size(132, 33)
        Me.cboxComidas.TabIndex = 5
        '
        'btnAgregarComida
        '
        Me.btnAgregarComida.Location = New System.Drawing.Point(342, 224)
        Me.btnAgregarComida.Name = "btnAgregarComida"
        Me.btnAgregarComida.Size = New System.Drawing.Size(132, 43)
        Me.btnAgregarComida.TabIndex = 6
        Me.btnAgregarComida.Text = "Agregar Comida"
        Me.btnAgregarComida.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(348, 98)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(42, 13)
        Me.lblNombre.TabIndex = 7
        Me.lblNombre.Text = "Comida"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCantidad.Location = New System.Drawing.Point(346, 160)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 8
        Me.lblCantidad.Text = "Cantidad"
        '
        'nCantidad
        '
        Me.nCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.nCantidad.Location = New System.Drawing.Point(342, 176)
        Me.nCantidad.Name = "nCantidad"
        Me.nCantidad.Size = New System.Drawing.Size(132, 32)
        Me.nCantidad.TabIndex = 9
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(12, 98)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(290, 402)
        Me.dgvDetalle.TabIndex = 10
        '
        'pDetalleTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(486, 595)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.nCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnAgregarComida)
        Me.Controls.Add(Me.cboxComidas)
        Me.Controls.Add(Me.lblDetalleTicket)
        Me.Controls.Add(Me.btnGenerarTicket)
        Me.Name = "pDetalleTicket"
        Me.Text = "Cuisine Ticket"
        CType(Me.nCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerarTicket As System.Windows.Forms.Button
    Friend WithEvents lblDetalleTicket As System.Windows.Forms.Label
    Friend WithEvents cboxComidas As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregarComida As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents nCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
End Class

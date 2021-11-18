<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pMesas
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
        Me.dgvMesas = New System.Windows.Forms.DataGridView()
        Me.btnMostrarReservas = New System.Windows.Forms.Button()
        Me.btnReservar = New System.Windows.Forms.Button()
        Me.lblNroMesa = New System.Windows.Forms.Label()
        Me.btnDetalleTicket = New System.Windows.Forms.Button()
        Me.cboxMesas = New System.Windows.Forms.ComboBox()
        Me.btnCrearTicket = New System.Windows.Forms.Button()
        Me.gboxTicket = New System.Windows.Forms.GroupBox()
        Me.lblPedidosLocales = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvMesas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMesas
        '
        Me.dgvMesas.AllowUserToAddRows = False
        Me.dgvMesas.AllowUserToDeleteRows = False
        Me.dgvMesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMesas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMesas.Location = New System.Drawing.Point(354, 147)
        Me.dgvMesas.MultiSelect = False
        Me.dgvMesas.Name = "dgvMesas"
        Me.dgvMesas.ReadOnly = True
        Me.dgvMesas.RowHeadersWidth = 128
        Me.dgvMesas.Size = New System.Drawing.Size(795, 423)
        Me.dgvMesas.TabIndex = 4
        '
        'btnMostrarReservas
        '
        Me.btnMostrarReservas.Location = New System.Drawing.Point(54, 426)
        Me.btnMostrarReservas.Name = "btnMostrarReservas"
        Me.btnMostrarReservas.Size = New System.Drawing.Size(221, 64)
        Me.btnMostrarReservas.TabIndex = 18
        Me.btnMostrarReservas.Text = "Mostrar Reservas"
        Me.btnMostrarReservas.UseVisualStyleBackColor = True
        '
        'btnReservar
        '
        Me.btnReservar.Location = New System.Drawing.Point(54, 506)
        Me.btnReservar.Name = "btnReservar"
        Me.btnReservar.Size = New System.Drawing.Size(221, 64)
        Me.btnReservar.TabIndex = 17
        Me.btnReservar.Text = "Reservar mesa"
        Me.btnReservar.UseVisualStyleBackColor = True
        '
        'lblNroMesa
        '
        Me.lblNroMesa.AutoSize = True
        Me.lblNroMesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblNroMesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNroMesa.Location = New System.Drawing.Point(50, 165)
        Me.lblNroMesa.Name = "lblNroMesa"
        Me.lblNroMesa.Size = New System.Drawing.Size(112, 22)
        Me.lblNroMesa.TabIndex = 15
        Me.lblNroMesa.Text = "Nro de Mesa"
        '
        'btnDetalleTicket
        '
        Me.btnDetalleTicket.Location = New System.Drawing.Point(54, 342)
        Me.btnDetalleTicket.Name = "btnDetalleTicket"
        Me.btnDetalleTicket.Size = New System.Drawing.Size(221, 64)
        Me.btnDetalleTicket.TabIndex = 14
        Me.btnDetalleTicket.Text = "Abrir Ticket"
        Me.btnDetalleTicket.UseVisualStyleBackColor = True
        '
        'cboxMesas
        '
        Me.cboxMesas.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxMesas.FormattingEnabled = True
        Me.cboxMesas.Location = New System.Drawing.Point(54, 190)
        Me.cboxMesas.Name = "cboxMesas"
        Me.cboxMesas.Size = New System.Drawing.Size(221, 41)
        Me.cboxMesas.TabIndex = 13
        '
        'btnCrearTicket
        '
        Me.btnCrearTicket.Location = New System.Drawing.Point(54, 254)
        Me.btnCrearTicket.Name = "btnCrearTicket"
        Me.btnCrearTicket.Size = New System.Drawing.Size(221, 64)
        Me.btnCrearTicket.TabIndex = 12
        Me.btnCrearTicket.Text = "Abrir Mesa"
        Me.btnCrearTicket.UseVisualStyleBackColor = True
        '
        'gboxTicket
        '
        Me.gboxTicket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gboxTicket.Location = New System.Drawing.Point(44, 148)
        Me.gboxTicket.Name = "gboxTicket"
        Me.gboxTicket.Size = New System.Drawing.Size(240, 182)
        Me.gboxTicket.TabIndex = 16
        Me.gboxTicket.TabStop = False
        Me.gboxTicket.Text = "Crear Ticket"
        '
        'lblPedidosLocales
        '
        Me.lblPedidosLocales.AutoSize = True
        Me.lblPedidosLocales.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.lblPedidosLocales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPedidosLocales.Location = New System.Drawing.Point(363, 51)
        Me.lblPedidosLocales.Name = "lblPedidosLocales"
        Me.lblPedidosLocales.Size = New System.Drawing.Size(665, 55)
        Me.lblPedidosLocales.TabIndex = 19
        Me.lblPedidosLocales.Text = "Gestión de Reservas y Mesas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.flecha_hacia_atras__1_
        Me.PictureBox1.Location = New System.Drawing.Point(44, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 63)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'pMesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1257, 621)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPedidosLocales)
        Me.Controls.Add(Me.btnMostrarReservas)
        Me.Controls.Add(Me.btnReservar)
        Me.Controls.Add(Me.lblNroMesa)
        Me.Controls.Add(Me.btnDetalleTicket)
        Me.Controls.Add(Me.cboxMesas)
        Me.Controls.Add(Me.btnCrearTicket)
        Me.Controls.Add(Me.gboxTicket)
        Me.Controls.Add(Me.dgvMesas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "pMesas"
        Me.Text = "Cuisine"
        CType(Me.dgvMesas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMesas As System.Windows.Forms.DataGridView
    Friend WithEvents btnMostrarReservas As System.Windows.Forms.Button
    Friend WithEvents btnReservar As System.Windows.Forms.Button
    Friend WithEvents lblNroMesa As System.Windows.Forms.Label
    Friend WithEvents btnDetalleTicket As System.Windows.Forms.Button
    Friend WithEvents cboxMesas As System.Windows.Forms.ComboBox
    Friend WithEvents btnCrearTicket As System.Windows.Forms.Button
    Friend WithEvents gboxTicket As System.Windows.Forms.GroupBox
    Friend WithEvents lblPedidosLocales As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pPrincipal
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
        Me.btnCrearTicket = New System.Windows.Forms.Button()
        Me.cboxMesas = New System.Windows.Forms.ComboBox()
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.dgvMesas = New System.Windows.Forms.DataGridView()
        Me.btnDetalleTicket = New System.Windows.Forms.Button()
        Me.btnPedido = New System.Windows.Forms.Button()
        Me.lblNroMesa = New System.Windows.Forms.Label()
        Me.btnMostrarPedidos = New System.Windows.Forms.Button()
        Me.gboxTicket = New System.Windows.Forms.GroupBox()
        CType(Me.dgvMesas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCrearTicket
        '
        Me.btnCrearTicket.Location = New System.Drawing.Point(22, 147)
        Me.btnCrearTicket.Name = "btnCrearTicket"
        Me.btnCrearTicket.Size = New System.Drawing.Size(181, 52)
        Me.btnCrearTicket.TabIndex = 0
        Me.btnCrearTicket.Text = "Crear Ticket"
        Me.btnCrearTicket.UseVisualStyleBackColor = True
        '
        'cboxMesas
        '
        Me.cboxMesas.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxMesas.FormattingEnabled = True
        Me.cboxMesas.Location = New System.Drawing.Point(22, 83)
        Me.cboxMesas.Name = "cboxMesas"
        Me.cboxMesas.Size = New System.Drawing.Size(181, 41)
        Me.cboxMesas.TabIndex = 1
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!)
        Me.lblTickets.Location = New System.Drawing.Point(377, 27)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(266, 39)
        Me.lblTickets.TabIndex = 2
        Me.lblTickets.Text = "Tickets Abiertos"
        '
        'dgvMesas
        '
        Me.dgvMesas.AllowUserToAddRows = False
        Me.dgvMesas.AllowUserToDeleteRows = False
        Me.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMesas.Location = New System.Drawing.Point(260, 83)
        Me.dgvMesas.MultiSelect = False
        Me.dgvMesas.Name = "dgvMesas"
        Me.dgvMesas.ReadOnly = True
        Me.dgvMesas.Size = New System.Drawing.Size(530, 368)
        Me.dgvMesas.TabIndex = 3
        '
        'btnDetalleTicket
        '
        Me.btnDetalleTicket.Location = New System.Drawing.Point(22, 230)
        Me.btnDetalleTicket.Name = "btnDetalleTicket"
        Me.btnDetalleTicket.Size = New System.Drawing.Size(181, 52)
        Me.btnDetalleTicket.TabIndex = 5
        Me.btnDetalleTicket.Text = "Abrir Ticket"
        Me.btnDetalleTicket.UseVisualStyleBackColor = True
        '
        'btnPedido
        '
        Me.btnPedido.Location = New System.Drawing.Point(22, 316)
        Me.btnPedido.Name = "btnPedido"
        Me.btnPedido.Size = New System.Drawing.Size(181, 52)
        Me.btnPedido.TabIndex = 6
        Me.btnPedido.Text = "Crear Pedido Tlf."
        Me.btnPedido.UseVisualStyleBackColor = True
        '
        'lblNroMesa
        '
        Me.lblNroMesa.AutoSize = True
        Me.lblNroMesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblNroMesa.Location = New System.Drawing.Point(18, 58)
        Me.lblNroMesa.Name = "lblNroMesa"
        Me.lblNroMesa.Size = New System.Drawing.Size(112, 22)
        Me.lblNroMesa.TabIndex = 7
        Me.lblNroMesa.Text = "Nro de Mesa"
        '
        'btnMostrarPedidos
        '
        Me.btnMostrarPedidos.Location = New System.Drawing.Point(22, 399)
        Me.btnMostrarPedidos.Name = "btnMostrarPedidos"
        Me.btnMostrarPedidos.Size = New System.Drawing.Size(181, 52)
        Me.btnMostrarPedidos.TabIndex = 8
        Me.btnMostrarPedidos.Text = "Mostrar Pedidos Activos"
        Me.btnMostrarPedidos.UseVisualStyleBackColor = True
        '
        'gboxTicket
        '
        Me.gboxTicket.Location = New System.Drawing.Point(12, 41)
        Me.gboxTicket.Name = "gboxTicket"
        Me.gboxTicket.Size = New System.Drawing.Size(200, 170)
        Me.gboxTicket.TabIndex = 9
        Me.gboxTicket.TabStop = False
        Me.gboxTicket.Text = "Crear Ticket"
        '
        'pPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 481)
        Me.Controls.Add(Me.btnMostrarPedidos)
        Me.Controls.Add(Me.lblNroMesa)
        Me.Controls.Add(Me.btnPedido)
        Me.Controls.Add(Me.btnDetalleTicket)
        Me.Controls.Add(Me.dgvMesas)
        Me.Controls.Add(Me.lblTickets)
        Me.Controls.Add(Me.cboxMesas)
        Me.Controls.Add(Me.btnCrearTicket)
        Me.Controls.Add(Me.gboxTicket)
        Me.Name = "pPrincipal"
        Me.Text = "Cuisine"
        CType(Me.dgvMesas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCrearTicket As System.Windows.Forms.Button
    Friend WithEvents cboxMesas As System.Windows.Forms.ComboBox
    Friend WithEvents lblTickets As System.Windows.Forms.Label
    Friend WithEvents dgvMesas As System.Windows.Forms.DataGridView
    Friend WithEvents btnDetalleTicket As System.Windows.Forms.Button
    Friend WithEvents btnPedido As System.Windows.Forms.Button
    Friend WithEvents lblNroMesa As System.Windows.Forms.Label
    Friend WithEvents btnMostrarPedidos As System.Windows.Forms.Button
    Friend WithEvents gboxTicket As System.Windows.Forms.GroupBox

End Class

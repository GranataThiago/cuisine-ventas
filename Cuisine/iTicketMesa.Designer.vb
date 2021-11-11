<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iTicketMesa
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(iTicketMesa))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dgvPedido = New System.Windows.Forms.DataGridView()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PrintTicketMesa = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(85, 26)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Cuisine"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Location = New System.Drawing.Point(12, 99)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(41, 5)
        Me.Panel3.TabIndex = 159
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(88, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(41, 5)
        Me.Panel1.TabIndex = 160
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(41, 5)
        Me.Panel2.TabIndex = 161
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Location = New System.Drawing.Point(163, 99)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(41, 5)
        Me.Panel4.TabIndex = 161
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DimGray
        Me.Panel5.Location = New System.Drawing.Point(335, 99)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(41, 5)
        Me.Panel5.TabIndex = 162
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DimGray
        Me.Panel6.Location = New System.Drawing.Point(238, 99)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(41, 5)
        Me.Panel6.TabIndex = 163
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblSucursal.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblSucursal.Location = New System.Drawing.Point(13, 41)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(175, 20)
        Me.lblSucursal.TabIndex = 164
        Me.lblSucursal.Text = "Sucursal Lope de Vega"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblFecha.Location = New System.Drawing.Point(13, 62)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(54, 20)
        Me.lblFecha.TabIndex = 165
        Me.lblFecha.Text = "Fecha"
        '
        'dgvPedido
        '
        Me.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedido.Location = New System.Drawing.Point(12, 122)
        Me.dgvPedido.Name = "dgvPedido"
        Me.dgvPedido.Size = New System.Drawing.Size(364, 399)
        Me.dgvPedido.TabIndex = 166
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblTotal.Location = New System.Drawing.Point(234, 549)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(61, 24)
        Me.lblTotal.TabIndex = 167
        Me.lblTotal.Text = "Total: "
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnImprimir.Location = New System.Drawing.Point(49, 587)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(80, 30)
        Me.btnImprimir.TabIndex = 168
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCerrar.Location = New System.Drawing.Point(184, 587)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(80, 30)
        Me.btnCerrar.TabIndex = 169
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PrintTicketMesa
        '
        Me.PrintTicketMesa.DocumentName = "document"
        Me.PrintTicketMesa.Form = Me
        Me.PrintTicketMesa.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintTicketMesa.PrinterSettings = CType(resources.GetObject("PrintTicketMesa.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintTicketMesa.PrintFileName = Nothing
        '
        'iTicketMesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(388, 642)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.dgvPedido)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblSucursal)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "iTicketMesa"
        Me.Text = "Ticket"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents dgvPedido As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents PrintTicketMesa As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iTicketDelivery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(iTicketDelivery))
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvDelivery = New System.Windows.Forms.DataGridView()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PrintTicketDel = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.dgvDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCerrar.Location = New System.Drawing.Point(228, 604)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(80, 30)
        Me.btnCerrar.TabIndex = 181
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnImprimir.Location = New System.Drawing.Point(96, 603)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(80, 30)
        Me.btnImprimir.TabIndex = 180
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblTotal.Location = New System.Drawing.Point(247, 566)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(61, 24)
        Me.lblTotal.TabIndex = 179
        Me.lblTotal.Text = "Total: "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Location = New System.Drawing.Point(96, 116)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(41, 5)
        Me.Panel2.TabIndex = 172
        '
        'dgvDelivery
        '
        Me.dgvDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDelivery.Location = New System.Drawing.Point(25, 139)
        Me.dgvDelivery.Name = "dgvDelivery"
        Me.dgvDelivery.Size = New System.Drawing.Size(364, 399)
        Me.dgvDelivery.TabIndex = 178
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblFecha.Location = New System.Drawing.Point(26, 79)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(54, 20)
        Me.lblFecha.TabIndex = 177
        Me.lblFecha.Text = "Fecha"
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblSucursal.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblSucursal.Location = New System.Drawing.Point(26, 58)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(175, 20)
        Me.lblSucursal.TabIndex = 176
        Me.lblSucursal.Text = "Sucursal Lope de Vega"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DimGray
        Me.Panel6.Location = New System.Drawing.Point(251, 116)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(41, 5)
        Me.Panel6.TabIndex = 175
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DimGray
        Me.Panel5.Location = New System.Drawing.Point(348, 116)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(41, 5)
        Me.Panel5.TabIndex = 174
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Location = New System.Drawing.Point(176, 116)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(41, 5)
        Me.Panel4.TabIndex = 173
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Location = New System.Drawing.Point(25, 116)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(41, 5)
        Me.Panel3.TabIndex = 171
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblTitulo.Location = New System.Drawing.Point(25, 26)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(85, 26)
        Me.lblTitulo.TabIndex = 170
        Me.lblTitulo.Text = "Cuisine"
        '
        'PrintTicketDel
        '
        Me.PrintTicketDel.DocumentName = "document"
        Me.PrintTicketDel.Form = Me
        Me.PrintTicketDel.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintTicketDel.PrinterSettings = CType(resources.GetObject("PrintTicketDel.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintTicketDel.PrintFileName = Nothing
        '
        'iTicketDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(412, 645)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvDelivery)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblSucursal)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "iTicketDelivery"
        Me.Text = "Form1"
        CType(Me.dgvDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvDelivery As System.Windows.Forms.DataGridView
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PrintTicketDel As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class

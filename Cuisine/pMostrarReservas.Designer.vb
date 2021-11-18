<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pMostrarReservas
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
        Me.dgvReservas = New System.Windows.Forms.DataGridView()
        Me.lblReservas = New System.Windows.Forms.Label()
        Me.btnCancelarReserva = New System.Windows.Forms.Button()
        Me.btnModificarReserva = New System.Windows.Forms.Button()
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReservas
        '
        Me.dgvReservas.AllowUserToAddRows = False
        Me.dgvReservas.AllowUserToDeleteRows = False
        Me.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservas.Location = New System.Drawing.Point(91, 112)
        Me.dgvReservas.MultiSelect = False
        Me.dgvReservas.Name = "dgvReservas"
        Me.dgvReservas.ReadOnly = True
        Me.dgvReservas.Size = New System.Drawing.Size(630, 368)
        Me.dgvReservas.TabIndex = 4
        '
        'lblReservas
        '
        Me.lblReservas.AutoSize = True
        Me.lblReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!)
        Me.lblReservas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblReservas.Location = New System.Drawing.Point(261, 47)
        Me.lblReservas.Name = "lblReservas"
        Me.lblReservas.Size = New System.Drawing.Size(284, 39)
        Me.lblReservas.TabIndex = 5
        Me.lblReservas.Text = "Reservas activas"
        '
        'btnCancelarReserva
        '
        Me.btnCancelarReserva.Location = New System.Drawing.Point(219, 503)
        Me.btnCancelarReserva.Name = "btnCancelarReserva"
        Me.btnCancelarReserva.Size = New System.Drawing.Size(145, 57)
        Me.btnCancelarReserva.TabIndex = 6
        Me.btnCancelarReserva.Text = "Cancelar reserva"
        Me.btnCancelarReserva.UseVisualStyleBackColor = True
        '
        'btnModificarReserva
        '
        Me.btnModificarReserva.Location = New System.Drawing.Point(432, 503)
        Me.btnModificarReserva.Name = "btnModificarReserva"
        Me.btnModificarReserva.Size = New System.Drawing.Size(145, 57)
        Me.btnModificarReserva.TabIndex = 7
        Me.btnModificarReserva.Text = "Modificar reserva"
        Me.btnModificarReserva.UseVisualStyleBackColor = True
        '
        'pMostrarReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(805, 582)
        Me.Controls.Add(Me.btnModificarReserva)
        Me.Controls.Add(Me.btnCancelarReserva)
        Me.Controls.Add(Me.lblReservas)
        Me.Controls.Add(Me.dgvReservas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "pMostrarReservas"
        Me.Text = "Cuisine"
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvReservas As System.Windows.Forms.DataGridView
    Friend WithEvents lblReservas As System.Windows.Forms.Label
    Friend WithEvents btnCancelarReserva As System.Windows.Forms.Button
    Friend WithEvents btnModificarReserva As System.Windows.Forms.Button
End Class

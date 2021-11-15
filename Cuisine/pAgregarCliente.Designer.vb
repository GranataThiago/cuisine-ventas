<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pAgregarCliente
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
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.tboxNombre = New System.Windows.Forms.TextBox()
        Me.tboxDireccion = New System.Windows.Forms.TextBox()
        Me.tboxTelefono = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTlf = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!)
        Me.lblTickets.Location = New System.Drawing.Point(92, 35)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(257, 39)
        Me.lblTickets.TabIndex = 3
        Me.lblTickets.Text = "Agregar Cliente"
        '
        'tboxNombre
        '
        Me.tboxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.tboxNombre.Location = New System.Drawing.Point(110, 126)
        Me.tboxNombre.Name = "tboxNombre"
        Me.tboxNombre.Size = New System.Drawing.Size(216, 27)
        Me.tboxNombre.TabIndex = 4
        '
        'tboxDireccion
        '
        Me.tboxDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.tboxDireccion.Location = New System.Drawing.Point(110, 192)
        Me.tboxDireccion.Name = "tboxDireccion"
        Me.tboxDireccion.Size = New System.Drawing.Size(216, 27)
        Me.tboxDireccion.TabIndex = 5
        '
        'tboxTelefono
        '
        Me.tboxTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.tboxTelefono.Location = New System.Drawing.Point(110, 257)
        Me.tboxTelefono.Name = "tboxTelefono"
        Me.tboxTelefono.Size = New System.Drawing.Size(216, 27)
        Me.tboxTelefono.TabIndex = 6
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(168, 350)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(99, 36)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar cliente"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(107, 110)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(78, 13)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Nombre cliente"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(107, 176)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 10
        Me.lblDireccion.Text = "Direccion"
        '
        'lblTlf
        '
        Me.lblTlf.AutoSize = True
        Me.lblTlf.Location = New System.Drawing.Point(107, 241)
        Me.lblTlf.Name = "lblTlf"
        Me.lblTlf.Size = New System.Drawing.Size(49, 13)
        Me.lblTlf.TabIndex = 11
        Me.lblTlf.Text = "Telefono"
        '
        'pAgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 426)
        Me.Controls.Add(Me.lblTlf)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.tboxTelefono)
        Me.Controls.Add(Me.tboxDireccion)
        Me.Controls.Add(Me.tboxNombre)
        Me.Controls.Add(Me.lblTickets)
        Me.Name = "pAgregarCliente"
        Me.Text = "Cuisine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTickets As System.Windows.Forms.Label
    Friend WithEvents tboxNombre As System.Windows.Forms.TextBox
    Friend WithEvents tboxDireccion As System.Windows.Forms.TextBox
    Friend WithEvents tboxTelefono As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblTlf As System.Windows.Forms.Label
End Class

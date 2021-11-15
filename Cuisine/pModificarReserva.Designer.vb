<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pModificarReserva
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
        Me.cFecha = New System.Windows.Forms.MonthCalendar()
        Me.cboxHorarios = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblModificar = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.tboxNombre = New System.Windows.Forms.TextBox()
        Me.cboxMesas = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cFecha
        '
        Me.cFecha.CalendarDimensions = New System.Drawing.Size(2, 1)
        Me.cFecha.Location = New System.Drawing.Point(30, 245)
        Me.cFecha.Name = "cFecha"
        Me.cFecha.TabIndex = 15
        '
        'cboxHorarios
        '
        Me.cboxHorarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxHorarios.FormattingEnabled = True
        Me.cboxHorarios.Location = New System.Drawing.Point(30, 192)
        Me.cboxHorarios.Name = "cboxHorarios"
        Me.cboxHorarios.Size = New System.Drawing.Size(231, 41)
        Me.cboxHorarios.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Horario"
        '
        'lblModificar
        '
        Me.lblModificar.AutoSize = True
        Me.lblModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!)
        Me.lblModificar.Location = New System.Drawing.Point(136, 31)
        Me.lblModificar.Name = "lblModificar"
        Me.lblModificar.Size = New System.Drawing.Size(298, 39)
        Me.lblModificar.TabIndex = 17
        Me.lblModificar.Text = "Modificar Reserva"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(203, 419)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(151, 59)
        Me.btnActualizar.TabIndex = 18
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'tboxNombre
        '
        Me.tboxNombre.Enabled = False
        Me.tboxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!)
        Me.tboxNombre.Location = New System.Drawing.Point(30, 107)
        Me.tboxNombre.Name = "tboxNombre"
        Me.tboxNombre.Size = New System.Drawing.Size(500, 39)
        Me.tboxNombre.TabIndex = 19
        '
        'cboxMesas
        '
        Me.cboxMesas.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxMesas.FormattingEnabled = True
        Me.cboxMesas.Location = New System.Drawing.Point(299, 192)
        Me.cboxMesas.Name = "cboxMesas"
        Me.cboxMesas.Size = New System.Drawing.Size(231, 41)
        Me.cboxMesas.TabIndex = 20
        '
        'pModificarReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 490)
        Me.Controls.Add(Me.cboxMesas)
        Me.Controls.Add(Me.tboxNombre)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.lblModificar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cFecha)
        Me.Controls.Add(Me.cboxHorarios)
        Me.Name = "pModificarReserva"
        Me.Text = "Cuisine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cFecha As System.Windows.Forms.MonthCalendar
    Friend WithEvents cboxHorarios As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblModificar As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents tboxNombre As System.Windows.Forms.TextBox
    Friend WithEvents cboxMesas As System.Windows.Forms.ComboBox
End Class

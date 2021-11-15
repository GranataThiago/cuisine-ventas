<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pReservarMesa
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
        Me.btnReservar = New System.Windows.Forms.Button()
        Me.lblReservar = New System.Windows.Forms.Label()
        Me.cboxClientes = New System.Windows.Forms.ComboBox()
        Me.cboxMesas = New System.Windows.Forms.ComboBox()
        Me.cboxHorarios = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.cFecha = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'btnReservar
        '
        Me.btnReservar.Location = New System.Drawing.Point(216, 541)
        Me.btnReservar.Name = "btnReservar"
        Me.btnReservar.Size = New System.Drawing.Size(151, 59)
        Me.btnReservar.TabIndex = 0
        Me.btnReservar.Text = "Realizar reserva"
        Me.btnReservar.UseVisualStyleBackColor = True
        '
        'lblReservar
        '
        Me.lblReservar.AutoSize = True
        Me.lblReservar.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!)
        Me.lblReservar.Location = New System.Drawing.Point(154, 27)
        Me.lblReservar.Name = "lblReservar"
        Me.lblReservar.Size = New System.Drawing.Size(254, 39)
        Me.lblReservar.TabIndex = 3
        Me.lblReservar.Text = "Reservar mesa"
        '
        'cboxClientes
        '
        Me.cboxClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxClientes.FormattingEnabled = True
        Me.cboxClientes.Location = New System.Drawing.Point(36, 143)
        Me.cboxClientes.Name = "cboxClientes"
        Me.cboxClientes.Size = New System.Drawing.Size(331, 41)
        Me.cboxClientes.TabIndex = 4
        '
        'cboxMesas
        '
        Me.cboxMesas.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxMesas.FormattingEnabled = True
        Me.cboxMesas.Location = New System.Drawing.Point(294, 239)
        Me.cboxMesas.Name = "cboxMesas"
        Me.cboxMesas.Size = New System.Drawing.Size(224, 41)
        Me.cboxMesas.TabIndex = 5
        '
        'cboxHorarios
        '
        Me.cboxHorarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxHorarios.FormattingEnabled = True
        Me.cboxHorarios.Location = New System.Drawing.Point(34, 241)
        Me.cboxHorarios.Name = "cboxHorarios"
        Me.cboxHorarios.Size = New System.Drawing.Size(242, 41)
        Me.cboxHorarios.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Mesa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Horario"
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Location = New System.Drawing.Point(392, 143)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(126, 41)
        Me.btnAgregarCliente.TabIndex = 10
        Me.btnAgregarCliente.Text = "Agregar cliente"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(43, 326)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 12
        Me.lblFecha.Text = "Fecha"
        '
        'cFecha
        '
        Me.cFecha.CalendarDimensions = New System.Drawing.Size(2, 1)
        Me.cFecha.Location = New System.Drawing.Point(36, 348)
        Me.cFecha.Name = "cFecha"
        Me.cFecha.TabIndex = 13
        '
        'pReservarMesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 624)
        Me.Controls.Add(Me.cFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboxHorarios)
        Me.Controls.Add(Me.cboxMesas)
        Me.Controls.Add(Me.cboxClientes)
        Me.Controls.Add(Me.lblReservar)
        Me.Controls.Add(Me.btnReservar)
        Me.Name = "pReservarMesa"
        Me.Text = "Cuisine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReservar As System.Windows.Forms.Button
    Friend WithEvents lblReservar As System.Windows.Forms.Label
    Friend WithEvents cboxClientes As System.Windows.Forms.ComboBox
    Friend WithEvents cboxMesas As System.Windows.Forms.ComboBox
    Friend WithEvents cboxHorarios As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarCliente As System.Windows.Forms.Button
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents cFecha As System.Windows.Forms.MonthCalendar
End Class

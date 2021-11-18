<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pInicial
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
        Me.lblReserva = New System.Windows.Forms.Label()
        Me.lblLocal = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pboxMesas = New System.Windows.Forms.PictureBox()
        Me.pboxPedidos = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxMesas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblReserva
        '
        Me.lblReserva.AutoSize = True
        Me.lblReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblReserva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblReserva.Location = New System.Drawing.Point(631, 425)
        Me.lblReserva.Name = "lblReserva"
        Me.lblReserva.Size = New System.Drawing.Size(188, 26)
        Me.lblReserva.TabIndex = 1
        Me.lblReserva.Text = "Gestionar pedidos"
        '
        'lblLocal
        '
        Me.lblLocal.AutoSize = True
        Me.lblLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblLocal.Location = New System.Drawing.Point(279, 425)
        Me.lblLocal.Name = "lblLocal"
        Me.lblLocal.Size = New System.Drawing.Size(177, 26)
        Me.lblLocal.TabIndex = 3
        Me.lblLocal.Text = "Gestionar mesas"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.Cuisine
        Me.PictureBox2.Location = New System.Drawing.Point(46, -17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1021, 217)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'pboxMesas
        '
        Me.pboxMesas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboxMesas.Image = Global.WindowsApplication1.My.Resources.Resources.restaurante__2_
        Me.pboxMesas.Location = New System.Drawing.Point(296, 273)
        Me.pboxMesas.Name = "pboxMesas"
        Me.pboxMesas.Size = New System.Drawing.Size(133, 135)
        Me.pboxMesas.TabIndex = 5
        Me.pboxMesas.TabStop = False
        '
        'pboxPedidos
        '
        Me.pboxPedidos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboxPedidos.Image = Global.WindowsApplication1.My.Resources.Resources.repartidor__2_
        Me.pboxPedidos.Location = New System.Drawing.Point(660, 273)
        Me.pboxPedidos.Name = "pboxPedidos"
        Me.pboxPedidos.Size = New System.Drawing.Size(133, 135)
        Me.pboxPedidos.TabIndex = 0
        Me.pboxPedidos.TabStop = False
        '
        'pInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1093, 585)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pboxMesas)
        Me.Controls.Add(Me.lblLocal)
        Me.Controls.Add(Me.lblReserva)
        Me.Controls.Add(Me.pboxPedidos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "pInicial"
        Me.Text = "Cuisine"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxMesas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pboxPedidos As System.Windows.Forms.PictureBox
    Friend WithEvents lblReserva As System.Windows.Forms.Label
    Friend WithEvents lblLocal As System.Windows.Forms.Label
    Friend WithEvents pboxMesas As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class

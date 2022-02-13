<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbCompra = New System.Windows.Forms.CheckBox()
        Me.cbVenta = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.txtVenta = New System.Windows.Forms.TextBox()
        Me.compraDolar = New System.Windows.Forms.RadioButton()
        Me.compraPM = New System.Windows.Forms.RadioButton()
        Me.compraEuro = New System.Windows.Forms.RadioButton()
        Me.compraCR = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ventaCR = New System.Windows.Forms.RadioButton()
        Me.ventaEuro = New System.Windows.Forms.RadioButton()
        Me.ventaPM = New System.Windows.Forms.RadioButton()
        Me.ventaDolar = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbVenta)
        Me.GroupBox1.Controls.Add(Me.cbCompra)
        Me.GroupBox1.Location = New System.Drawing.Point(132, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 219)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transacciones"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtVenta)
        Me.GroupBox2.Controls.Add(Me.txtCompra)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(446, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 226)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingrese Cantidad"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.compraCR)
        Me.GroupBox3.Controls.Add(Me.compraEuro)
        Me.GroupBox3.Controls.Add(Me.compraPM)
        Me.GroupBox3.Controls.Add(Me.compraDolar)
        Me.GroupBox3.Location = New System.Drawing.Point(132, 358)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(250, 336)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Compra"
        '
        'cbCompra
        '
        Me.cbCompra.AutoSize = True
        Me.cbCompra.Location = New System.Drawing.Point(69, 70)
        Me.cbCompra.Name = "cbCompra"
        Me.cbCompra.Size = New System.Drawing.Size(119, 29)
        Me.cbCompra.TabIndex = 0
        Me.cbCompra.Text = "Compra"
        Me.cbCompra.UseVisualStyleBackColor = True
        '
        'cbVenta
        '
        Me.cbVenta.AutoSize = True
        Me.cbVenta.Location = New System.Drawing.Point(69, 137)
        Me.cbVenta.Name = "cbVenta"
        Me.cbVenta.Size = New System.Drawing.Size(100, 29)
        Me.cbVenta.TabIndex = 1
        Me.cbVenta.Text = "Venta"
        Me.cbVenta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Venta"
        '
        'txtCompra
        '
        Me.txtCompra.Enabled = False
        Me.txtCompra.Location = New System.Drawing.Point(185, 80)
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(182, 31)
        Me.txtCompra.TabIndex = 2
        '
        'txtVenta
        '
        Me.txtVenta.Enabled = False
        Me.txtVenta.Location = New System.Drawing.Point(185, 164)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.Size = New System.Drawing.Size(182, 31)
        Me.txtVenta.TabIndex = 3
        '
        'compraDolar
        '
        Me.compraDolar.AutoSize = True
        Me.compraDolar.Location = New System.Drawing.Point(43, 58)
        Me.compraDolar.Name = "compraDolar"
        Me.compraDolar.Size = New System.Drawing.Size(94, 29)
        Me.compraDolar.TabIndex = 0
        Me.compraDolar.TabStop = True
        Me.compraDolar.Text = "Dolar"
        Me.compraDolar.UseVisualStyleBackColor = True
        '
        'compraPM
        '
        Me.compraPM.AutoSize = True
        Me.compraPM.Location = New System.Drawing.Point(43, 120)
        Me.compraPM.Name = "compraPM"
        Me.compraPM.Size = New System.Drawing.Size(191, 29)
        Me.compraPM.TabIndex = 1
        Me.compraPM.TabStop = True
        Me.compraPM.Text = "Peso Mexicano"
        Me.compraPM.UseVisualStyleBackColor = True
        '
        'compraEuro
        '
        Me.compraEuro.AutoSize = True
        Me.compraEuro.Location = New System.Drawing.Point(43, 180)
        Me.compraEuro.Name = "compraEuro"
        Me.compraEuro.Size = New System.Drawing.Size(88, 29)
        Me.compraEuro.TabIndex = 2
        Me.compraEuro.TabStop = True
        Me.compraEuro.Text = "Euro"
        Me.compraEuro.UseVisualStyleBackColor = True
        '
        'compraCR
        '
        Me.compraCR.AutoSize = True
        Me.compraCR.Location = New System.Drawing.Point(43, 240)
        Me.compraCR.Name = "compraCR"
        Me.compraCR.Size = New System.Drawing.Size(150, 29)
        Me.compraCR.TabIndex = 3
        Me.compraCR.TabStop = True
        Me.compraCR.Text = "Colonos Cr"
        Me.compraCR.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ventaCR)
        Me.GroupBox4.Controls.Add(Me.ventaEuro)
        Me.GroupBox4.Controls.Add(Me.ventaPM)
        Me.GroupBox4.Controls.Add(Me.ventaDolar)
        Me.GroupBox4.Location = New System.Drawing.Point(446, 358)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(252, 336)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Venta"
        '
        'ventaCR
        '
        Me.ventaCR.AutoSize = True
        Me.ventaCR.Location = New System.Drawing.Point(43, 240)
        Me.ventaCR.Name = "ventaCR"
        Me.ventaCR.Size = New System.Drawing.Size(150, 29)
        Me.ventaCR.TabIndex = 3
        Me.ventaCR.TabStop = True
        Me.ventaCR.Text = "Colonos Cr"
        Me.ventaCR.UseVisualStyleBackColor = True
        '
        'ventaEuro
        '
        Me.ventaEuro.AutoSize = True
        Me.ventaEuro.Location = New System.Drawing.Point(43, 180)
        Me.ventaEuro.Name = "ventaEuro"
        Me.ventaEuro.Size = New System.Drawing.Size(88, 29)
        Me.ventaEuro.TabIndex = 2
        Me.ventaEuro.TabStop = True
        Me.ventaEuro.Text = "Euro"
        Me.ventaEuro.UseVisualStyleBackColor = True
        '
        'ventaPM
        '
        Me.ventaPM.AutoSize = True
        Me.ventaPM.Location = New System.Drawing.Point(43, 120)
        Me.ventaPM.Name = "ventaPM"
        Me.ventaPM.Size = New System.Drawing.Size(191, 29)
        Me.ventaPM.TabIndex = 1
        Me.ventaPM.TabStop = True
        Me.ventaPM.Text = "Peso Mexicano"
        Me.ventaPM.UseVisualStyleBackColor = True
        '
        'ventaDolar
        '
        Me.ventaDolar.AutoSize = True
        Me.ventaDolar.Location = New System.Drawing.Point(43, 58)
        Me.ventaDolar.Name = "ventaDolar"
        Me.ventaDolar.Size = New System.Drawing.Size(94, 29)
        Me.ventaDolar.TabIndex = 0
        Me.ventaDolar.TabStop = True
        Me.ventaDolar.Text = "Dolar"
        Me.ventaDolar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(760, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 63)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(760, 490)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 63)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(760, 598)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 55)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 783)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbVenta As CheckBox
    Friend WithEvents cbCompra As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtVenta As TextBox
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents compraCR As RadioButton
    Friend WithEvents compraEuro As RadioButton
    Friend WithEvents compraPM As RadioButton
    Friend WithEvents compraDolar As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ventaCR As RadioButton
    Friend WithEvents ventaEuro As RadioButton
    Friend WithEvents ventaPM As RadioButton
    Friend WithEvents ventaDolar As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class

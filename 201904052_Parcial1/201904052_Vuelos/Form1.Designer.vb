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
        Me.rbAvioneta = New System.Windows.Forms.RadioButton()
        Me.rbJet = New System.Windows.Forms.RadioButton()
        Me.rbHelicoptero = New System.Windows.Forms.RadioButton()
        Me.rbCostaSur = New System.Windows.Forms.RadioButton()
        Me.rbIzabal = New System.Windows.Forms.RadioButton()
        Me.rbPeten = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbHelicoptero)
        Me.GroupBox1.Controls.Add(Me.rbJet)
        Me.GroupBox1.Controls.Add(Me.rbAvioneta)
        Me.GroupBox1.Location = New System.Drawing.Point(86, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aeronave"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbPeten)
        Me.GroupBox2.Controls.Add(Me.rbIzabal)
        Me.GroupBox2.Controls.Add(Me.rbCostaSur)
        Me.GroupBox2.Location = New System.Drawing.Point(86, 292)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 222)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Destino"
        '
        'rbAvioneta
        '
        Me.rbAvioneta.AutoSize = True
        Me.rbAvioneta.Location = New System.Drawing.Point(60, 44)
        Me.rbAvioneta.Name = "rbAvioneta"
        Me.rbAvioneta.Size = New System.Drawing.Size(133, 29)
        Me.rbAvioneta.TabIndex = 0
        Me.rbAvioneta.TabStop = True
        Me.rbAvioneta.Text = "Avioneta "
        Me.rbAvioneta.UseVisualStyleBackColor = True
        '
        'rbJet
        '
        Me.rbJet.AutoSize = True
        Me.rbJet.Location = New System.Drawing.Point(60, 103)
        Me.rbJet.Name = "rbJet"
        Me.rbJet.Size = New System.Drawing.Size(72, 29)
        Me.rbJet.TabIndex = 1
        Me.rbJet.TabStop = True
        Me.rbJet.Text = "Jet"
        Me.rbJet.UseVisualStyleBackColor = True
        '
        'rbHelicoptero
        '
        Me.rbHelicoptero.AutoSize = True
        Me.rbHelicoptero.Location = New System.Drawing.Point(60, 161)
        Me.rbHelicoptero.Name = "rbHelicoptero"
        Me.rbHelicoptero.Size = New System.Drawing.Size(152, 29)
        Me.rbHelicoptero.TabIndex = 2
        Me.rbHelicoptero.TabStop = True
        Me.rbHelicoptero.Text = "Helicóptero"
        Me.rbHelicoptero.UseVisualStyleBackColor = True
        '
        'rbCostaSur
        '
        Me.rbCostaSur.AutoSize = True
        Me.rbCostaSur.Location = New System.Drawing.Point(60, 46)
        Me.rbCostaSur.Name = "rbCostaSur"
        Me.rbCostaSur.Size = New System.Drawing.Size(138, 29)
        Me.rbCostaSur.TabIndex = 0
        Me.rbCostaSur.TabStop = True
        Me.rbCostaSur.Text = "Costa Sur"
        Me.rbCostaSur.UseVisualStyleBackColor = True
        '
        'rbIzabal
        '
        Me.rbIzabal.AutoSize = True
        Me.rbIzabal.Location = New System.Drawing.Point(60, 107)
        Me.rbIzabal.Name = "rbIzabal"
        Me.rbIzabal.Size = New System.Drawing.Size(100, 29)
        Me.rbIzabal.TabIndex = 1
        Me.rbIzabal.TabStop = True
        Me.rbIzabal.Text = "Izabal"
        Me.rbIzabal.UseVisualStyleBackColor = True
        '
        'rbPeten
        '
        Me.rbPeten.AutoSize = True
        Me.rbPeten.Location = New System.Drawing.Point(60, 164)
        Me.rbPeten.Name = "rbPeten"
        Me.rbPeten.Size = New System.Drawing.Size(99, 29)
        Me.rbPeten.TabIndex = 2
        Me.rbPeten.TabStop = True
        Me.rbPeten.Text = "Petén"
        Me.rbPeten.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(466, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad de Pasajeros"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(487, 109)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(196, 31)
        Me.txtCantidad.TabIndex = 3
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(519, 204)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(128, 58)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(519, 309)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(128, 58)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(519, 427)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(128, 58)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(765, 553)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbHelicoptero As RadioButton
    Friend WithEvents rbJet As RadioButton
    Friend WithEvents rbAvioneta As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbPeten As RadioButton
    Friend WithEvents rbIzabal As RadioButton
    Friend WithEvents rbCostaSur As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
End Class

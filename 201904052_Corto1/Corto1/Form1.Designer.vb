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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bt_limpiar = New System.Windows.Forms.Button()
        Me.bt_salir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cb_norte = New System.Windows.Forms.CheckBox()
        Me.cb_sur = New System.Windows.Forms.CheckBox()
        Me.cb_oriente = New System.Windows.Forms.CheckBox()
        Me.cb_occidente = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cb_seguroVehiculo = New System.Windows.Forms.CheckBox()
        Me.cb_seguroAccidente = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del mensajero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto del envío:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Región:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(342, 71)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(371, 31)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(342, 145)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(371, 31)
        Me.TextBox2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Monto del seguro respectivo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(114, 458)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Sueldo Final"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(114, 538)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(277, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Monto del seguro calculado"
        '
        'bt_limpiar
        '
        Me.bt_limpiar.Location = New System.Drawing.Point(213, 618)
        Me.bt_limpiar.Name = "bt_limpiar"
        Me.bt_limpiar.Size = New System.Drawing.Size(134, 39)
        Me.bt_limpiar.TabIndex = 12
        Me.bt_limpiar.Text = "Limpiar"
        Me.bt_limpiar.UseVisualStyleBackColor = True
        '
        'bt_salir
        '
        Me.bt_salir.Location = New System.Drawing.Point(618, 618)
        Me.bt_salir.Name = "bt_salir"
        Me.bt_salir.Size = New System.Drawing.Size(132, 39)
        Me.bt_salir.TabIndex = 13
        Me.bt_salir.Text = "Salir"
        Me.bt_salir.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(574, 373)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "0.0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(574, 458)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "0.0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(579, 538)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 25)
        Me.Label9.TabIndex = 16
        '
        'cb_norte
        '
        Me.cb_norte.AutoSize = True
        Me.cb_norte.Location = New System.Drawing.Point(264, 230)
        Me.cb_norte.Name = "cb_norte"
        Me.cb_norte.Size = New System.Drawing.Size(96, 29)
        Me.cb_norte.TabIndex = 17
        Me.cb_norte.Text = "Norte"
        Me.cb_norte.UseVisualStyleBackColor = True
        '
        'cb_sur
        '
        Me.cb_sur.AutoSize = True
        Me.cb_sur.Location = New System.Drawing.Point(420, 229)
        Me.cb_sur.Name = "cb_sur"
        Me.cb_sur.Size = New System.Drawing.Size(77, 29)
        Me.cb_sur.TabIndex = 18
        Me.cb_sur.Text = "Sur"
        Me.cb_sur.UseVisualStyleBackColor = True
        '
        'cb_oriente
        '
        Me.cb_oriente.AutoSize = True
        Me.cb_oriente.Location = New System.Drawing.Point(551, 229)
        Me.cb_oriente.Name = "cb_oriente"
        Me.cb_oriente.Size = New System.Drawing.Size(114, 29)
        Me.cb_oriente.TabIndex = 19
        Me.cb_oriente.Text = "Oriente"
        Me.cb_oriente.UseVisualStyleBackColor = True
        '
        'cb_occidente
        '
        Me.cb_occidente.AutoSize = True
        Me.cb_occidente.Location = New System.Drawing.Point(708, 229)
        Me.cb_occidente.Name = "cb_occidente"
        Me.cb_occidente.Size = New System.Drawing.Size(141, 29)
        Me.cb_occidente.TabIndex = 20
        Me.cb_occidente.Text = "Occidente"
        Me.cb_occidente.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(75, 297)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 25)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Seguro"
        '
        'cb_seguroVehiculo
        '
        Me.cb_seguroVehiculo.AutoSize = True
        Me.cb_seguroVehiculo.Location = New System.Drawing.Point(264, 297)
        Me.cb_seguroVehiculo.Name = "cb_seguroVehiculo"
        Me.cb_seguroVehiculo.Size = New System.Drawing.Size(259, 29)
        Me.cb_seguroVehiculo.TabIndex = 22
        Me.cb_seguroVehiculo.Text = "Seguro sobre vehículo"
        Me.cb_seguroVehiculo.UseVisualStyleBackColor = True
        '
        'cb_seguroAccidente
        '
        Me.cb_seguroAccidente.AutoSize = True
        Me.cb_seguroAccidente.Location = New System.Drawing.Point(567, 297)
        Me.cb_seguroAccidente.Name = "cb_seguroAccidente"
        Me.cb_seguroAccidente.Size = New System.Drawing.Size(272, 29)
        Me.cb_seguroAccidente.TabIndex = 23
        Me.cb_seguroAccidente.Text = "Seguro sobre accidente"
        Me.cb_seguroAccidente.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(433, 618)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 39)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(579, 538)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 25)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "0.0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(946, 701)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_seguroAccidente)
        Me.Controls.Add(Me.cb_seguroVehiculo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cb_occidente)
        Me.Controls.Add(Me.cb_oriente)
        Me.Controls.Add(Me.cb_sur)
        Me.Controls.Add(Me.cb_norte)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bt_salir)
        Me.Controls.Add(Me.bt_limpiar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents bt_limpiar As Button
    Friend WithEvents bt_salir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cb_norte As CheckBox
    Friend WithEvents cb_sur As CheckBox
    Friend WithEvents cb_oriente As CheckBox
    Friend WithEvents cb_occidente As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cb_seguroVehiculo As CheckBox
    Friend WithEvents cb_seguroAccidente As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
End Class

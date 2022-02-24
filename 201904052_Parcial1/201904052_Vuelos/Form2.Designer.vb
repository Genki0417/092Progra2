<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.subtotal = New System.Windows.Forms.Label()
        Me.descuento = New System.Windows.Forms.Label()
        Me.total_pagar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total a pagar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descuento"
        '
        'subtotal
        '
        Me.subtotal.AutoSize = True
        Me.subtotal.Location = New System.Drawing.Point(405, 88)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(42, 25)
        Me.subtotal.TabIndex = 3
        Me.subtotal.Text = "0.0"
        '
        'descuento
        '
        Me.descuento.AutoSize = True
        Me.descuento.Location = New System.Drawing.Point(405, 188)
        Me.descuento.Name = "descuento"
        Me.descuento.Size = New System.Drawing.Size(42, 25)
        Me.descuento.TabIndex = 4
        Me.descuento.Text = "0.0"
        '
        'total_pagar
        '
        Me.total_pagar.AutoSize = True
        Me.total_pagar.Location = New System.Drawing.Point(405, 299)
        Me.total_pagar.Name = "total_pagar"
        Me.total_pagar.Size = New System.Drawing.Size(42, 25)
        Me.total_pagar.TabIndex = 5
        Me.total_pagar.Text = "0.0"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(599, 447)
        Me.Controls.Add(Me.total_pagar)
        Me.Controls.Add(Me.descuento)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents subtotal As Label
    Friend WithEvents descuento As Label
    Friend WithEvents total_pagar As Label
End Class

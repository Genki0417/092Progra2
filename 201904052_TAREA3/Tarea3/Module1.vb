Module Module1
    Public Const tcDolar = 7.69
    Public Const tcPM = 0.38
    Public Const tcEuro = 7.89
    Public Const tcCCR = 0.012

    Public Const comisionCompra = 2.5 / 100
    Public Const comisionVenta = 3 / 100

    Dim Total_parcial = 0
    Dim Total
    Sub limpiar()
        Form1.txtCompra.Clear()
        Form1.txtVenta.Clear()
        Form1.cbCompra.Checked = False
        Form1.cbVenta.Checked = False

        Form2.Label1.Text = "limpiar"
    End Sub

    Function calcularCompra(cantidadCompra As Double, tipoCompra As Double) As Double
        If cantidadCompra > 0 Then
            Total_parcial = cantidadCompra * tipoCompra
            Total = Total_parcial * comisionCompra + Total_parcial
        End If

        Return Math.Round(Total, 2)
    End Function
End Module

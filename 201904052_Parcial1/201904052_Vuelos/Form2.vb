Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subtotal.Text = subtotal_pagar
        descuento.Text = descuento_vuelos
        total_pagar.Text = subtotal_pagar - descuento_vuelos
    End Sub
End Class
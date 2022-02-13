Public Class Form2
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.compraDolar.Checked Then
        End If
        Label1.Text = "la cantidad tu compra es:" + Str(calcularCompra(Form1.txtCompra.Text, tcDolar))
    End Sub
End Class
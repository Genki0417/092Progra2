﻿Public Class Form1

    Const precioArroz As Double = 2.0
    Const precioFrijol As Double = 1.75
    Const precioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim pagoSinIVA As Double = 0
    Dim valorIVA As Double = 0
    Dim pagoConIVA As Double = 0
    Dim descuento As Double = 0
    Dim pagoFinal As Double = 0

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        pagoSinIVA = (Val(txtArroz.Text) * precioArroz) + (Val(txtFrijol.Text) * precioFrijol) + (Val(txtAzucar.Text) * precioAzucar)
        valorIVA = pagoSinIVA * IVA
        pagoConIVA = pagoSinIVA + valorIVA
        descuento = pagoConIVA * 0.025
        pagoFinal = pagoConIVA - descuento

        lblR1.Text = pagoSinIVA
        lblR2.Text = valorIVA
        lblR3.Text = pagoConIVA
        lblR4.Text = descuento
        lblR5.Text = pagoFinal

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lblR1.Text = 0.0
        lblR2.Text = 0.0
        lblR3.Text = 0.0
        lblR4.Text = 0.0
        lblR5.Text = 0.0

        txtArroz.Text = 0.0
        txtAzucar.Text = 0.0
        txtFrijol.Text = 0.0

        pagoSinIVA = 0.0
        valorIVA = 0.0
        pagoConIVA = 0.0
        descuento = 0.0
        pagoFinal = 0.0

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class

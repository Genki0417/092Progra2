Public Class Form1
    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If rbAvioneta.Checked = False And rbJet.Checked = False And rbHelicoptero.Checked = False Then
            MsgBox("no has elegido Aeronave")
            End
        End If

        If rbCostaSur.Checked = False And rbIzabal.Checked = False And rbPeten.Checked = False Then
            MsgBox("no has elegido Destino")
            End
        End If

        If txtCantidad.Text = "" Then
            MsgBox("Ingrese una cantidad")
            End
        End If

        Dim aeronave As String
        Dim destino As String

        If rbAvioneta.Checked Then
            aeronave = "avioneta"
        ElseIf rbJet.Checked Then
            aeronave = "jet"
        Else
            aeronave = "helicoptero"
        End If


        If rbCostaSur.Checked Then
            destino = "costasur"
        ElseIf rbIzabal.Checked Then
            destino = "izabal"
        Else
            destino = "peten"
        End If


        calcular(aeronave, destino, Val(txtCantidad.Text))
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

    End Sub
End Class
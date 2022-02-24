Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cb_seguroAccidente.Checked Then
        End If
        Label7.Text = "Monto del seguro respectivo es:" + Str(SalarioBase * SeguroAccidente)

        If cb_seguroVehiculo.Checked Then
        End If
        Label7.Text = "Monto del seguro respectivo es:" + Str(SalarioBase * SeguroVehiculo)


        If cb_norte.Checked Then
        End If
        Label8.Text = "Sueldo final es:" + Str(SalarioBase + MontoNorte)

        If cb_sur.Checked Then
        End If
        Label8.Text = "Sueldo final es:" + Str(SalarioBase + MontoSur)

        If cb_oriente.Checked Then
        End If
        Label8.Text = "Sueldo final es:" + Str(SalarioBase + MontoOriente)

        If cb_occidente.Checked Then
        End If
        Label8.Text = "Sueldo final es:" + Str(SalarioBase + MontoOccidente)


        If cb_seguroAccidente.Checked Then
        End If
        Label9.Text = "Monto del seguro respectivo es:" + Str(SalarioBase * SeguroAccidente)

        If cb_seguroVehiculo.Checked Then
        End If
        Label9.Text = "Monto del seguro respectivo es:" + Str(SalarioBase * SeguroVehiculo)

    End Sub

    Private Sub bt_limpiar_Click(sender As Object, e As EventArgs) Handles bt_limpiar.Click
        TextBox1.Clear()
        TextBox2.Clear()
        cb_norte.Checked = False
        cb_sur.Checked = False
        cb_occidente.Checked = False
        cb_oriente.Checked = False
        cb_seguroAccidente.Checked = False
        cb_seguroVehiculo.Checked = False


    End Sub

    Private Sub bt_salir_Click(sender As Object, e As EventArgs) Handles bt_salir.Click
        End
    End Sub
End Class

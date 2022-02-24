Module Module1
    Public Const avioneta_costasur = 150
    Public Const avioneta_izabal = 175.99
    Public Const avioneta_peten = 250.99

    Public Const jet_costasur = 250.99
    Public Const jet_izabal = 325.99
    Public Const jet_peten = 450.99

    Public Const helicoptero_costasur = 125.99
    Public Const helicoptero_izabal = 175.99
    Public Const helicoptero_peten = 275.99

    Public subtotal_pagar = 0
    Public total = 0
    Public descuento_vuelos = 0

    Public Sub calcular(aeronave As String, destino As String, cantidad As Double)
        Select Case aeronave
            Case "avioneta"
                Select Case destino
                    Case "costasur"
                End Select
                subtotal_pagar = cantidad * avioneta_costasur
        End Select

        Select Case aeronave
            Case "avioneta"
                Select Case destino
                    Case "izabal"
                End Select
                subtotal_pagar = cantidad * avioneta_izabal
        End Select

        Select Case aeronave
            Case "avioneta"
                Select Case destino
                    Case "peten"
                End Select
                subtotal_pagar = cantidad * avioneta_peten
        End Select

        Select Case aeronave
            Case "jet"
                Select Case destino
                    Case "costasur"
                End Select
                subtotal_pagar = cantidad * jet_costasur
        End Select

        Select Case aeronave
            Case "jet"
                Select Case destino
                    Case "izabal"
                End Select
                subtotal_pagar = cantidad * jet_izabal
        End Select

        Select Case aeronave
            Case "jet"
                Select Case destino
                    Case "peten"
                End Select
                subtotal_pagar = cantidad * jet_peten
        End Select

        Select Case aeronave
            Case "helicoptero"
                Select Case destino
                    Case "costasur"
                End Select
                subtotal_pagar = cantidad * helicoptero_costasur
        End Select

        Select Case aeronave
            Case "helicoptero"
                Select Case destino
                    Case "izabal"
                End Select
                subtotal_pagar = cantidad * helicoptero_izabal
        End Select

        Select Case aeronave
            Case "helicoptero"
                Select Case destino
                    Case "peten"
                End Select
                subtotal_pagar = cantidad * helicoptero_peten
        End Select

        Select Case aeronave
            Case "jet"
                Select Case destino
                    Case "izabal"
                End Select
                descuento_vuelos = ((cantidad * jet_izabal) * 0.02) + cantidad
        End Select

        Select Case aeronave
            Case "jet"
                Select Case destino
                    Case "peten"
                End Select
                descuento_vuelos = ((cantidad * jet_peten) * 0.02) + cantidad
        End Select



    End Sub
End Module


Imports WinFormsApp.My.Resources

Public Class Form1
    Dim numCamiones As Integer
    Dim numCamionetas As Integer
    Dim numFurgonetas As Integer
    Dim saca As Integer = 0
    Dim vehiculoAcargar As Integer
    Dim pesoVehiculo As Integer
    Dim pesoTotal
    Dim numSacasTotal As Integer = 0
    Dim numSacasKg As Integer = 0
    Dim numCamionesFinal As Integer = 0
    Dim numCamionetasFinal As Integer = 0
    Dim numFurgonetasFinal As Integer = 0
    Dim Movimiento As Integer
    Private Sub sbSacas_Scroll(sender As Object, e As ScrollEventArgs) Handles sbSacas.Scroll
        lbSacaGb.Text = "Tamaño = " & sbSacas.Value & " kg"
    End Sub
    Private Sub btAniadir_Click(sender As Object, e As EventArgs) Handles btAniadir.Click
        saca = sbSacas.Value
        lbSaca.Text = "Saca = " & saca & " kg"
        gbSacas.Visible = False
        descargarSaca()
    End Sub
    Private Sub btElegirCamions_Click(sender As Object, e As EventArgs) Handles btElegirCamions.Click
        If mtbCamion.Text <= 8 And mtbCamion.Text >= 0 And Not (mtbCamioneta.Text.Equals("")) Then
            numCamiones = mtbCamion.Text
            If mtbCamioneta.Text <= 8 And mtbCamioneta.Text >= 0 And Not (mtbCamioneta.Text.Equals("")) Then
                numCamionetas = mtbCamioneta.Text
                If mtbFurgoneta.Text <= 8 And mtbFurgoneta.Text >= 0 And Not (mtbCamioneta.Text.Equals("")) Then
                    numFurgonetas = mtbFurgoneta.Text
                    MsgBox("Empieza el día")
                    gbCamiones.Visible = False
                    moverV()
                Else
                    MsgBox("El numero de furboneta tiene que de estar entre 0 y 8")
                End If
            Else
                MsgBox("El numero de camionetas tiene que de estar entre 0 y 8")
            End If
        Else
            MsgBox("El numero de camiones tiene que de estar entre 0 y 8")
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbSacas.Visible = False
        lbFecha.Text = lbFecha.Text + System.DateTime.Today
        cargandoSaca.Visible = False
    End Sub
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles MyBase.Closing
        terminarDia()
    End Sub

    Private Sub terminarDia()
        MsgBox("Fin" & vbNewLine & "Sacas exportadas = " & Fix((numSacasTotal / 2)) & vbNewLine & "Kg Sacas totales = " & numSacasKg & vbNewLine & "Numeros de caminones sacados = " & numCamionesFinal & vbNewLine & "Numeros de caminonetas sacados = " & numCamionetasFinal & vbNewLine & "Numeros de Furgonetas sacados = " & numFurgonetasFinal)
    End Sub

    Private Sub lbInform_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbInform.LinkClicked
        Dim BrowseProc As New Process
        BrowseProc.StartInfo.FileName = "http://google.com"
        BrowseProc.StartInfo.UseShellExecute = True
        BrowseProc.StartInfo.RedirectStandardOutput = False
        BrowseProc.Start()
        BrowseProc.Dispose()
    End Sub
    Private Sub moverV()
        If numCamiones > 0 Then
            vehiculo.Image = Resource1.camion
            vehiculoAcargar = 1
            Movimiento = 1
            tiempo.Enabled = True
            peso = 10000
        ElseIf numCamionetas > 0 Then
            vehiculo.Image = Resource1.camioneta
            vehiculoAcargar = 2
            Movimiento = 1
            tiempo.Enabled = True
            peso = 6000
        ElseIf numFurgonetas > 0 Then
            vehiculo.Image = Resource1.furgoneta
            vehiculoAcargar = 3
            Movimiento = 1
            tiempo.Enabled = True
            peso = 4000
        Else
            terminarDia()
            Me.Close()
        End If
    End Sub
    Private Sub tiempo_Tick(sender As Object, e As EventArgs) Handles tiempo.Tick
        If Movimiento = 1 Then
            If vehiculo.Left < 385 Then
                vehiculo.Left += 10
            Else
                tiempo.Enabled = False
                cargandoSaca.Visible = True
                timerTexto.Start()
                descargarSaca()
            End If
        Else
            If vehiculo.Left > 12 Then
                cargandoSaca.Visible = False
                timerTexto.Stop()
                vehiculo.Left -= 10
                pbSaca.Image = Resource1.saca
            Else
                tiempo.Enabled = False
                moverV()
            End If
        End If
    End Sub
    Dim peso As Integer
    Private Sub descargarSaca()
        While peso > 0 And gbSacas.Visible = False
            progressSaca.Minimum = 0
            progressSaca.Maximum = peso
            progressSaca.Value = 0
            If saca <= 0 Then
                gbSacas.Visible = True

            End If
            progressBarStart()
        End While
    End Sub
    Dim numbar As Integer
    Private Sub pala(pesoTemporal As Integer)
        If 3300 > pesoTemporal Then
            pbSaca.Image = Resource1.pala
        End If
    End Sub
    Private Sub progressBarStart()
        Dim pesoTemporal = peso - saca
        pala(pesoTemporal)
        If pesoTemporal < 0 Then
            peso = 0
            vehiculoCargado()
            MsgBox("Vehiculo no se puede llenar con esa saca, siguiente")
            Movimiento = 2
            tiempo.Enabled = True
        ElseIf pesoTemporal = 0 Then
            numSacasTotal += 1
            numSacasKg += saca
            For i = 0 To saca
                progressSaca.Increment(i)
                If i > progressSaca.Maximum Then
                    i = progressSaca.Maximum
                End If
            Next
            peso = 0
            saca = 0
            vehiculoCargado()
            MsgBox("Vehiculo lleno")
            Movimiento = 2
            tiempo.Enabled = True
        Else
            numSacasTotal += 1
            numSacasKg += saca
            For i = 0 To saca
                progressSaca.Increment(i)
                If i > progressSaca.Maximum Then
                    i = progressSaca.Maximum
                End If
            Next
            peso = peso - saca
            saca = 0
        End If
    End Sub
    Dim cambiocolor = True
    Private Sub timerTexto_Tick(sender As Object, e As EventArgs) Handles timerTexto.Tick
        If progressSaca.Value < progressSaca.Maximum Then
            If cambiocolor = True Then
                cargandoSaca.ForeColor = Color.White
                cambiocolor = False
            Else
                cambiocolor = True
                cargandoSaca.ForeColor = Color.Black
            End If
        End If
    End Sub
    Private Sub vehiculoCargado()
        If vehiculoAcargar = 1 Then
            numCamiones -= 1
            numCamionesFinal += 1
        ElseIf vehiculoAcargar = 2 Then
            numCamionetas -= 1
            numCamionetasFinal += 1
        ElseIf vehiculoAcargar = 3 Then
            numFurgonetas -= 1
            numFurgonetasFinal += 1
        End If
    End Sub
End Class

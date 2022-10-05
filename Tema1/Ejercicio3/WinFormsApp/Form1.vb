Public Class Form1
    Friend Sub moverEjercicio1()
        If GBButtons.Visible = True Then
            GBButtons.Visible = False
            GBEjer1.Visible = True
        ElseIf GBCilindro.Visible = True Then
            GBCilindro.Visible = False
            GBEjer1.Visible = True
        ElseIf GBEjer3.Visible = True Then
            GBEjer3.Visible = False
            GBEjer1.Visible = True
        End If
    End Sub
    Friend Sub moverEjercicio2()
        If GBButtons.Visible = True Then
            GBButtons.Visible = False
            GBCilindro.Visible = True
        ElseIf GBEjer1.Visible = True Then
            GBEjer1.Visible = False
            GBCilindro.Visible = True
        ElseIf GBEjer3.Visible = True Then
            GBEjer3.Visible = False
            GBCilindro.Visible = True
        End If
    End Sub
    Friend Sub moverEjercicio3()
        If GBButtons.Visible = True Then
            GBButtons.Visible = False
            GBEjer3.Visible = True
        ElseIf GBEjer1.Visible = True Then
            GBEjer1.Visible = False
            GBEjer3.Visible = True
        ElseIf GBCilindro.Visible = True Then
            GBCilindro.Visible = False
            GBEjer3.Visible = True
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.ExitThread()
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        moverEjercicio1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        moverEjercicio1()
    End Sub
    Dim Solucion As Int32
    Private Sub btAceptar1_Click(sender As Object, e As EventArgs) Handles btAceptar1.Click
        Solucion = (numtu.Text * litrosTu.Text) + (litrosTO.Text * numTo.Text)
        fin1.Text = "Las necesidades totales del combustible son de " & Solucion & " litros"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GBEjer1.Parent = Me
        GBButtons.Parent = Me
        GBCilindro.Parent = Me
        GBEjer3.Parent = Me
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem.Click
        moverEjercicio2()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        moverEjercicio2()
    End Sub
    Dim pi As Int32 = 3.141593
    Private Sub calcVol_Click(sender As Object, e As EventArgs) Handles calcVol.Click
        Dim radio = cilDia.Text / 2
        Dim calc = pi * (radio ^ 2) * cilAlt.Text
        fin2.Text = "El volumen del cilindro es de " & calc & " metros cubicos"
    End Sub

    Private Sub Ejercicio3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio3ToolStripMenuItem.Click
        moverEjercicio3()
    End Sub

    Private Sub calcpremed_Click(sender As Object, e As EventArgs) Handles calcpremed.Click
        Dim calc = (Integer.Parse(n1euros.Text) + Integer.Parse(n2euros.Text) + Integer.Parse(n3euros.Text)) / 3
        fin3.Text = "El precio medio del producto es de " & calc & " euros"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        moverEjercicio3()
    End Sub

End Class

Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Reflection.Metadata
Imports System.Threading

Public Class Form1
    Dim g As System.Drawing.Graphics
    Dim random As New Random
    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        l_Inicio.Visible = False
        g = Me.CreateGraphics()
        Dim color As New System.Drawing.Pen(System.Drawing.Color.Black)
        g.Clear(Me.BackColor)
        g.DrawEllipse(color, 55, 55, 90, 90)
        g.DrawEllipse(color, 60, 60, 80, 80)
        g.DrawEllipse(color, 65, 65, 70, 70)
        g.DrawEllipse(color, 70, 70, 60, 60)
        g.DrawEllipse(color, 75, 75, 50, 50)
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem.Click
        l_Inicio.Visible = False
        g = Me.CreateGraphics()
        g.Clear(Me.BackColor)
        For index = 1 To 12
            Dim color As New System.Drawing.Pen(System.Drawing.Color.FromArgb(random.Next(1, 255), random.Next(1, 255), random.Next(1, 255)))
            Dim p1 As New Point
            g.DrawLine(color, New Point(random.Next(1, Me.Size.Height), random.Next(1, Me.Size.Width)), New Point(random.Next(1, Me.Size.Height), random.Next(1, Me.Size.Width)))
        Next
    End Sub

    Private Sub Ejercicio3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio3ToolStripMenuItem.Click
        l_Inicio.Visible = False
        g.Clear(Me.BackColor)
        g = Me.CreateGraphics
        Dim x As Integer = Me.Size.Width / 2 - 10
        Dim y As Integer = Me.Size.Height / 2 - 10
        Dim ancho As Integer = 2
        Dim alto As Integer = 20
        Dim anguloInicial As Integer = 0
        Dim anguloFinal As Integer = 180
        Dim profundidad As Integer = 10
        Dim c As New System.Drawing.Pen(System.Drawing.Color.Black)
        For i = 0 To 9
            If i Mod 2 = 0 Then
                y = y - profundidad
                ancho = ancho + 2 * profundidad
                alto = alto + 2 * profundidad
                g.DrawArc(c, x, y, ancho, alto, anguloInicial, -anguloFinal)
            Else
                x = x - 2 * profundidad
                y = y - profundidad
                ancho = ancho + 2 * profundidad
                alto = alto + 2 * profundidad
                g.DrawArc(c, x, y, ancho, alto, anguloInicial, anguloFinal)
            End If
        Next
    End Sub

    Private Sub Ejercicio4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio4ToolStripMenuItem.Click
        g = Me.CreateGraphics
        l_Inicio.Visible = False
        g.Clear(Me.BackColor)
        Dim families = FontFamily.Families
        For index = 1 To 10
            Dim lBrush As New LinearGradientBrush(New Point(5, 15), New Point(30, 100), Color.Black, Color.Black)
            g.DrawString("HELLO", New Font(families(random.Next(0, families.Length)), random.Next(1, 70), FontStyle.Bold), lBrush, New Point(random.Next(8, Me.Size.Width), random.Next(8, Me.Size.Height)))
        Next
    End Sub

    Private Sub Ejercicio5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio5ToolStripMenuItem.Click
        g = Me.CreateGraphics
        l_Inicio.Visible = False
        g.Clear(Me.BackColor)
        Dim families = FontFamily.Families
        Dim color As Color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255))
        Dim nBrush As New SolidBrush(color)
        Dim strText As String = InputBox("introduce un texto ", "Texto")
        g.DrawString(strText, New Font(families(random.Next(0, families.Length)), random.Next(1, 70), FontStyle.Bold), nBrush, New Point(50, 50))
    End Sub

    Private Sub Ejercicio6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio6ToolStripMenuItem.Click
        g = Me.CreateGraphics
        l_Inicio.Visible = False
        g.Clear(Me.BackColor)
        Dim x As Integer = 40
        Dim y As Integer = 40
        Dim tamanio As Integer = 20
        Dim cnegro As New SolidBrush(Color.Black)
        Dim cwhite As New SolidBrush(Color.White)
        For i = 1 To 8
            For j = 1 To 8
                If (i + j) Mod 2 = 0 Then
                    g.FillRectangle(cnegro, x, y, tamanio, tamanio)
                Else
                    g.FillRectangle(cwhite, x, y, tamanio, tamanio)
                End If
                x += 20
            Next
            x = 40
            y += 20
        Next
    End Sub

    Private Sub Ejercicio7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio7ToolStripMenuItem.Click
        g = Me.CreateGraphics
        l_Inicio.Visible = False
        g.Clear(Me.BackColor)
        Dim color As New System.Drawing.Pen(System.Drawing.Color.Black)
        g.DrawRectangle(color, 60, 40, 50, 50)
        g.DrawRectangle(color, 50, 50, 50, 50)
        g.DrawLine(color, 100, 100, 110, 90)
        g.DrawLine(color, 60, 40, 50, 50)
        g.DrawLine(color, 110, 40, 100, 50)
    End Sub

    Private Sub Ejercicio8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio8ToolStripMenuItem.Click
        g = Me.CreateGraphics
        l_Inicio.Visible = False
        g.Clear(Me.BackColor)
        Dim x As Integer = 40
        Dim y As Integer = 40
        Dim numt As Integer = InputBox("Introduce el numero de triangulos")
        For index = 1 To numt
            Dim c As New SolidBrush(Color.FromArgb(random.Next(1, 255), random.Next(1, 255), random.Next(1, 255)))
            Dim p1 = New Point(y * index, x)
            Dim p2 = New Point((y * index + y), x)
            Dim p3 = New Point((y * index + (y / 2)), x + (x / 2))
            Dim pAll = New Point() {p1, p2, p3}
            g.FillPolygon(c, pAll, FillMode.Winding.Alternate)
        Next
    End Sub

    Private Sub Ejercicio9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio9ToolStripMenuItem.Click
        g = Me.CreateGraphics
        l_Inicio.Visible = False
        g.Clear(Me.BackColor)
        Dim x As Integer = InputBox("Introduce la x del circulo")
        Dim y As Integer = InputBox("Introduce la y del circulo")
        Dim r As Integer = InputBox("Introduce el radio del circulo")
        Dim c As New SolidBrush(Color.Black)
        g.FillEllipse(c, x, y, r * 2, r * 2)
        g.DrawString("Area:" & (3.14 * (r * r)), New Font("Arial", 10, FontStyle.Bold), c, New Point(y, x + (r * 2)))
        g.DrawString("Circurferencia:" & (3.14 * (r * 2)), New Font("Arial", 10, FontStyle.Bold), c, New Point(y, (x * 2) + 10))
        g.DrawString("Diametro:" & (r * 2), New Font("Arial", 10, FontStyle.Bold), c, New Point(y, (x * 2) + 20))
    End Sub
    Dim aux10 = True
    Private Sub Ejercicio10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio10ToolStripMenuItem.Click

        Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        g = Me.CreateGraphics
        l_Inicio.Visible = False
        g.Clear(Me.BackColor)
        Me.Location = New Point(0, 0)
        aux10 = False

        While True
            For index = 1 To 50
                Application.DoEvents()
                Threading.Thread.Sleep(400)
                Dim color As New System.Drawing.Pen(System.Drawing.Color.FromArgb(random.Next(1, 255), random.Next(1, 255), random.Next(1, 255)))
                g.DrawLine(color, New Point(random.Next(1, Me.Height), random.Next(1, Me.Width)), New Point(random.Next(1, Me.Height), random.Next(1, Me.Width)))
            Next
            g.Clear(Me.BackColor)
        End While
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If aux10 = False Then
            Me.Close()
        End If
    End Sub
End Class

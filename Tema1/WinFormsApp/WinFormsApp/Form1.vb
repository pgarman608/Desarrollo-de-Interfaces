Imports System.Drawing.Drawing2D
Imports System.Drawing.Text

Public Class Form1
    Dim g As System.Drawing.Graphics = Me.CreateGraphics
    Dim random As New Random
    Sub actividades(arg1 As Int32)
        l_Inicio.Visible = False
        If arg1 = 1 Then

        ElseIf arg1 = 2 Then

        ElseIf arg1 = 3 Then

        ElseIf arg1 = 4 Then

        ElseIf arg1 = 5 Then

        ElseIf arg1 = 6 Then

        ElseIf arg1 = 7 Then

        ElseIf arg1 = 8 Then

        ElseIf arg1 = 9 Then

        ElseIf arg1 = 10 Then

        End If
    End Sub
    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        l_Inicio.Visible = False
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
        Dim color As New System.Drawing.Pen(System.Drawing.Color.Black)
        g.DrawArc(color, 20, 40, 60, 80, 100, 120)
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
        g.DrawString(strText, New Font(families(random.Next(0, families.Length)), random.Next(1, 70), FontStyle.Bold), nBrush, 50, 50))
    End Sub
End Class

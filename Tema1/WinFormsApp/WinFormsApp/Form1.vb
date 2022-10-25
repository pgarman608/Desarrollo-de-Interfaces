Imports System.Net.Mime.MediaTypeNames
Public Class Form1
    Private Sub tiempoTSMItem_Click(sender As Object, e As EventArgs) Handles tiempoTSM.Click
        Dim tiempo As New Form2
        tiempo.MdiParent = Me
        tiempo.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
    Private Sub ElegirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles imagenesTSMI.Click
        Dim imagen As New Imagenes
        imagen.MdiParent = Me
        imagen.Show()
    End Sub
    Private Sub BarraTSIM_Click(sender As Object, e As EventArgs) Handles BarraTSIM.Click
        Dim barra As New Barra
        barra.MdiParent = Me
        barra.Show()
    End Sub

    Private Sub EditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorToolStripMenuItem.Click
        Dim editor As New Editor
        editor.MdiParent = Me
        editor.Show()
    End Sub
End Class

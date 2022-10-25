Public Class Barra
    Private Sub asciiScroll_Scroll(sender As Object, e As ScrollEventArgs) Handles asciiScroll.Scroll
        asciiScroll.Maximum = 255
        Dim aux As String = Convert.ToChar(asciiScroll.Value)
        charLabel.Text = aux
        valorLabel.Text = "Valor ASCII:" + asciiScroll.Value.ToString()
    End Sub
End Class
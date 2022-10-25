Imports WinFormsApp.My.Resources

Public Class Imagenes
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbPortatil.CheckedChanged
        imagen.Image = Resource1.portatil

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbSatelite.CheckedChanged
        imagen.Image = Resource1.satelite
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles btFotocopiadora.CheckedChanged
        imagen.Image = Resource1.Fotocopiadora
    End Sub
End Class
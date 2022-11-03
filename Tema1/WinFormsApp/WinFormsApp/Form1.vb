Imports Microsoft.Win32

Public Class Form1
    Dim numCamiones As Integer
    Dim numCamionetas As Integer
    Dim numFurgonetas As Integer
    Dim saca As Integer
    Dim empezarDia As Boolean = False

    Private Sub sbSacas_Scroll(sender As Object, e As ScrollEventArgs) Handles sbSacas.Scroll
        lbSacaGb.Text = "Tamaño = " & sbSacas.Value
    End Sub

    Private Sub btAniadir_Click(sender As Object, e As EventArgs) Handles btAniadir.Click
        saca = sbSacas.Value
    End Sub

    Private Sub btElegirCamions_Click(sender As Object, e As EventArgs) Handles btElegirCamions.Click
        If mtbCamion.Text <= 8 And mtbCamion.Text >= 0 Then
            numCamiones = mtbCamion.Text
            If mtbCamioneta.Text <= 8 And mtbCamioneta.Text >= 0 Then
                numCamionetas = mtbCamioneta.Text
                If mtbFurgoneta.Text <= 8 And mtbFurgoneta.Text >= 0 Then
                    numFurgonetas = mtbFurgoneta.Text
                    MsgBox("Empieza el día")
                    gbCamiones.Visible = False
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
        fecha.Text = fecha.Text + System.DateTime.Today

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles urlEmpresa.LinkClicked
        Dim BrowseProc As New Process
        BrowseProc.StartInfo.FileName = "http://google.com"
        BrowseProc.StartInfo.UseShellExecute = True
        BrowseProc.StartInfo.RedirectStandardOutput = False
        BrowseProc.Start()
        BrowseProc.Dispose()
    End Sub
End Class

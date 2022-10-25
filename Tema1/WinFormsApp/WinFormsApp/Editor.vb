Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class Editor
    Private Sub salirTM_Click(sender As Object, e As EventArgs) Handles salirTM.Click
        Me.Close()
    End Sub

    Private Sub salirIM_Click(sender As Object, e As EventArgs) Handles salirIM.Click
        Me.Close()
    End Sub

    Private Sub nuevoIM_Click(sender As Object, e As EventArgs) Handles nuevoIM.Click
        nuevo()
    End Sub
    Private Sub nuevoTM_Click(sender As Object, e As EventArgs) Handles nuevoTM.Click
        nuevo()
    End Sub
    Private Sub nuevo()
        If texto.Text.Length > 0 Then
            Dim entrada As Integer = MsgBox("Se eliminaran los datos escritos")
            If entrada = 1 Then
                texto.Text = ""
            End If
        End If
    End Sub

    Private Sub abrirIM_Click(sender As Object, e As EventArgs) Handles abrirIM.Click
        abrir()
    End Sub
    Private Sub abrirTM_Click(sender As Object, e As EventArgs) Handles abrirTM.Click
        abrir()
    End Sub
    Private Sub abrir()
        texto.Text = ""
        Me.cAbrir.Title = "Selecciona el archivo a abrir"
        Me.cAbrir.InitialDirectory = "C:\"
        Me.cAbrir.Filter = "Archivo de Texto(*.txt)|*.txt"
        Me.cAbrir.ValidateNames = True
        Me.cAbrir.ShowDialog()
        If Me.cAbrir.FileName.Length > 1 Then
            Dim leerArchivo As New IO.StreamReader(Me.cAbrir.FileName)
            Me.Text = Me.cAbrir.FileName
            texto.Text = leerArchivo.ReadToEnd()
        Else
            MsgBox("Archivo no contiene información")
        End If
    End Sub
    Private Sub guardarIM_Click(sender As Object, e As EventArgs) Handles guardarIM.Click
        guardar()
    End Sub
    Private Sub guardarTM_Click(sender As Object, e As EventArgs) Handles guardarTM.Click
        guardar()
    End Sub
    Private Sub guardar()
        Me.cGuardar.Title = "Guardar archivo  en..."
        Me.cGuardar.InitialDirectory = "C:\"
        Me.cGuardar.Filter = "Archivo de Texto(*.txt)|*.txt"
        Me.cGuardar.ValidateNames = True
        Me.cGuardar.ShowDialog()
        Dim guardar As IO.StreamWriter
        guardar = New IO.StreamWriter(Me.cGuardar.FileName)
        Me.Text = Me.cGuardar.FileName
        guardar.Write(texto.Text)
        guardar.Close()
    End Sub

    Private Sub fontIM_Click(sender As Object, e As EventArgs) Handles fontIM.Click
        fuente()
    End Sub
    Private Sub fontTM_Click(sender As Object, e As EventArgs) Handles fontTM.Click
        fuente()
    End Sub
    Private Sub fuente()
        Me.cFont.ShowDialog()
        texto.Font = cFont.Font
    End Sub

    Private Sub colorIM_Click(sender As Object, e As EventArgs) Handles colorIM.Click
        colorTexto()
    End Sub
    Private Sub colorTM_Click(sender As Object, e As EventArgs) Handles colorTM.Click
        colorTexto()
    End Sub
    Private Sub colorTexto()
        Me.cColor.ShowDialog()
        texto.ForeColor = cColor.Color
    End Sub

    Private Sub seleccionarTM_Click(sender As Object, e As EventArgs) Handles seleccionarTM.Click
        seleccionarTodo()
    End Sub
    Private Sub seleccionarIM_Click(sender As Object, e As EventArgs) Handles seleccionarIM.Click
        seleccionarTodo()
    End Sub
    Private Sub seleccionarTodo()
        Me.texto.SelectAll()
    End Sub

    Private Sub copiarTM_Click(sender As Object, e As EventArgs) Handles copiarTM.Click
        copiar()
    End Sub
    Private Sub copiarIM_Click(sender As Object, e As EventArgs) Handles copiarIM.Click
        copiar()
    End Sub
    Private Sub copiar()
        Me.texto.Copy()
    End Sub

    Private Sub pegarIM_Click(sender As Object, e As EventArgs) Handles pegarIM.Click
        pegar()
    End Sub
    Private Sub pegarTM_Click(sender As Object, e As EventArgs) Handles pegarTM.Click
        pegar()
    End Sub
    Private Sub pegar()
        Me.texto.Paste()
    End Sub

    Private Sub cortarTM_Click(sender As Object, e As EventArgs) Handles cortarTM.Click
        cortar()
    End Sub
    Private Sub cortarIM_Click(sender As Object, e As EventArgs) Handles cortarIM.Click
        cortar()
    End Sub
    Private Sub cortar()
        Me.texto.Cut()
    End Sub

    Private Sub texto_TextChanged(sender As Object, e As EventArgs) Handles texto.TextChanged
        Dim index As Integer = texto.SelectionStart
        Dim cl As Integer = texto.GetLineFromCharIndex(index)
        Dim cr As Integer = index - texto.GetFirstCharIndexFromLine(cl)
        position.Text = "Posicion: " & cl & " | " & cr
    End Sub

    Private Sub imprimirTSMI_Click(sender As Object, e As EventArgs) Handles imprimirTSMI.Click
        Me.PrintPreviewDialog1.Show()
    End Sub
End Class
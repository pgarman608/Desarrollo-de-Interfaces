<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.texto = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nuevoTM = New System.Windows.Forms.ToolStripMenuItem()
        Me.abrirTM = New System.Windows.Forms.ToolStripMenuItem()
        Me.guardarTM = New System.Windows.Forms.ToolStripMenuItem()
        Me.colorTM = New System.Windows.Forms.ToolStripMenuItem()
        Me.fontTM = New System.Windows.Forms.ToolStripMenuItem()
        Me.salirTM = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.seleccionarTM = New System.Windows.Forms.ToolStripMenuItem()
        Me.copiarTM = New System.Windows.Forms.ToolStripMenuItem()
        Me.pegarTM = New System.Windows.Forms.ToolStripMenuItem()
        Me.cortarTM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.nuevoIM = New System.Windows.Forms.ToolStripButton()
        Me.abrirIM = New System.Windows.Forms.ToolStripButton()
        Me.guardarIM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.fontIM = New System.Windows.Forms.ToolStripButton()
        Me.colorIM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.seleccionarIM = New System.Windows.Forms.ToolStripButton()
        Me.copiarIM = New System.Windows.Forms.ToolStripButton()
        Me.pegarIM = New System.Windows.Forms.ToolStripButton()
        Me.cortarIM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.salirIM = New System.Windows.Forms.ToolStripButton()
        Me.cAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.cGuardar = New System.Windows.Forms.SaveFileDialog()
        Me.cFont = New System.Windows.Forms.FontDialog()
        Me.cColor = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'texto
        '
        Me.texto.Location = New System.Drawing.Point(0, 52)
        Me.texto.Name = "texto"
        Me.texto.Size = New System.Drawing.Size(800, 400)
        Me.texto.TabIndex = 1
        Me.texto.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevoTM, Me.abrirTM, Me.guardarTM, Me.colorTM, Me.fontTM, Me.salirTM})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'nuevoTM
        '
        Me.nuevoTM.Name = "nuevoTM"
        Me.nuevoTM.Size = New System.Drawing.Size(180, 22)
        Me.nuevoTM.Text = "Nuevo"
        '
        'abrirTM
        '
        Me.abrirTM.Name = "abrirTM"
        Me.abrirTM.Size = New System.Drawing.Size(180, 22)
        Me.abrirTM.Text = "Abrir..."
        '
        'guardarTM
        '
        Me.guardarTM.Name = "guardarTM"
        Me.guardarTM.Size = New System.Drawing.Size(180, 22)
        Me.guardarTM.Text = "Guardar"
        '
        'colorTM
        '
        Me.colorTM.Name = "colorTM"
        Me.colorTM.Size = New System.Drawing.Size(180, 22)
        Me.colorTM.Text = "Color"
        '
        'fontTM
        '
        Me.fontTM.Name = "fontTM"
        Me.fontTM.Size = New System.Drawing.Size(180, 22)
        Me.fontTM.Text = "Fuente"
        '
        'salirTM
        '
        Me.salirTM.Name = "salirTM"
        Me.salirTM.Size = New System.Drawing.Size(180, 22)
        Me.salirTM.Text = "Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.seleccionarTM, Me.copiarTM, Me.pegarTM, Me.cortarTM})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'seleccionarTM
        '
        Me.seleccionarTM.Name = "seleccionarTM"
        Me.seleccionarTM.Size = New System.Drawing.Size(180, 22)
        Me.seleccionarTM.Text = "Seleccionar Todo"
        '
        'copiarTM
        '
        Me.copiarTM.Name = "copiarTM"
        Me.copiarTM.Size = New System.Drawing.Size(180, 22)
        Me.copiarTM.Text = "Copiar"
        '
        'pegarTM
        '
        Me.pegarTM.Name = "pegarTM"
        Me.pegarTM.Size = New System.Drawing.Size(180, 22)
        Me.pegarTM.Text = "Pegar"
        '
        'cortarTM
        '
        Me.cortarTM.Name = "cortarTM"
        Me.cortarTM.Size = New System.Drawing.Size(180, 22)
        Me.cortarTM.Text = "Cortar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevoIM, Me.abrirIM, Me.guardarIM, Me.ToolStripSeparator1, Me.fontIM, Me.colorIM, Me.ToolStripSeparator3, Me.seleccionarIM, Me.copiarIM, Me.pegarIM, Me.cortarIM, Me.ToolStripSeparator2, Me.salirIM})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'nuevoIM
        '
        Me.nuevoIM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.nuevoIM.Image = Global.WinFormsApp.My.Resources.Resource2.Nuevo
        Me.nuevoIM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.nuevoIM.Name = "nuevoIM"
        Me.nuevoIM.Size = New System.Drawing.Size(23, 22)
        Me.nuevoIM.Text = "Nuevo..."
        '
        'abrirIM
        '
        Me.abrirIM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.abrirIM.Image = Global.WinFormsApp.My.Resources.Resource2.Abrir
        Me.abrirIM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.abrirIM.Name = "abrirIM"
        Me.abrirIM.Size = New System.Drawing.Size(23, 22)
        Me.abrirIM.Text = "Abrir..."
        '
        'guardarIM
        '
        Me.guardarIM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.guardarIM.Image = Global.WinFormsApp.My.Resources.Resource2.Guardar
        Me.guardarIM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.guardarIM.Name = "guardarIM"
        Me.guardarIM.Size = New System.Drawing.Size(23, 22)
        Me.guardarIM.Text = "Guardar en..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'fontIM
        '
        Me.fontIM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.fontIM.Image = Global.WinFormsApp.My.Resources.Resource2.Font
        Me.fontIM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.fontIM.Name = "fontIM"
        Me.fontIM.Size = New System.Drawing.Size(23, 22)
        Me.fontIM.Text = "Fuente..."
        '
        'colorIM
        '
        Me.colorIM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.colorIM.Image = Global.WinFormsApp.My.Resources.Resource2.color
        Me.colorIM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.colorIM.Name = "colorIM"
        Me.colorIM.Size = New System.Drawing.Size(23, 22)
        Me.colorIM.Text = "Color..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'seleccionarIM
        '
        Me.seleccionarIM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.seleccionarIM.Image = Global.WinFormsApp.My.Resources.Resource2.Seleccionar
        Me.seleccionarIM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.seleccionarIM.Name = "seleccionarIM"
        Me.seleccionarIM.Size = New System.Drawing.Size(23, 22)
        Me.seleccionarIM.Text = "Seleccionar todo"
        '
        'copiarIM
        '
        Me.copiarIM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.copiarIM.Image = Global.WinFormsApp.My.Resources.Resource2.copiar
        Me.copiarIM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copiarIM.Name = "copiarIM"
        Me.copiarIM.Size = New System.Drawing.Size(23, 22)
        Me.copiarIM.Text = "Copiar"
        '
        'pegarIM
        '
        Me.pegarIM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.pegarIM.Image = Global.WinFormsApp.My.Resources.Resource2.pegar
        Me.pegarIM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pegarIM.Name = "pegarIM"
        Me.pegarIM.Size = New System.Drawing.Size(23, 22)
        Me.pegarIM.Text = "Pegar"
        '
        'cortarIM
        '
        Me.cortarIM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cortarIM.Image = Global.WinFormsApp.My.Resources.Resource2.Cortar
        Me.cortarIM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cortarIM.Name = "cortarIM"
        Me.cortarIM.Size = New System.Drawing.Size(23, 22)
        Me.cortarIM.Text = "Cortar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'salirIM
        '
        Me.salirIM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.salirIM.Image = Global.WinFormsApp.My.Resources.Resource2.salir
        Me.salirIM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.salirIM.Name = "salirIM"
        Me.salirIM.Size = New System.Drawing.Size(23, 22)
        Me.salirIM.Text = "Salir"
        '
        'cAbrir
        '
        Me.cAbrir.FileName = "cAbrir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.texto)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Editor de Texto+"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents texto As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents nuevoTM As ToolStripMenuItem
    Friend WithEvents abrirTM As ToolStripMenuItem
    Friend WithEvents guardarTM As ToolStripMenuItem
    Friend WithEvents colorTM As ToolStripMenuItem
    Friend WithEvents fontTM As ToolStripMenuItem
    Friend WithEvents salirTM As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents seleccionarTM As ToolStripMenuItem
    Friend WithEvents copiarTM As ToolStripMenuItem
    Friend WithEvents pegarTM As ToolStripMenuItem
    Friend WithEvents cortarTM As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents nuevoIM As ToolStripButton
    Friend WithEvents abrirIM As ToolStripButton
    Friend WithEvents guardarIM As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents fontIM As ToolStripButton
    Friend WithEvents colorIM As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents salirIM As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents seleccionarIM As ToolStripButton
    Friend WithEvents copiarIM As ToolStripButton
    Friend WithEvents pegarIM As ToolStripButton
    Friend WithEvents cortarIM As ToolStripButton
    Friend WithEvents cAbrir As OpenFileDialog
    Friend WithEvents cGuardar As SaveFileDialog
    Friend WithEvents cFont As FontDialog
    Friend WithEvents cColor As ColorDialog
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Me.gbCamiones = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtbCamion = New System.Windows.Forms.MaskedTextBox()
        Me.mtbFurgoneta = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCamioneta = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btElegirCamions = New System.Windows.Forms.Button()
        Me.gbSacas = New System.Windows.Forms.GroupBox()
        Me.btAniadir = New System.Windows.Forms.Button()
        Me.lbSacaGb = New System.Windows.Forms.Label()
        Me.sbSacas = New System.Windows.Forms.HScrollBar()
        Me.inform = New System.Windows.Forms.GroupBox()
        Me.lbInform = New System.Windows.Forms.LinkLabel()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.vehiculo = New System.Windows.Forms.PictureBox()
        Me.pbSaca = New System.Windows.Forms.PictureBox()
        Me.tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.lbSaca = New System.Windows.Forms.Label()
        Me.progressSaca = New System.Windows.Forms.ProgressBar()
        Me.timerTexto = New System.Windows.Forms.Timer(Me.components)
        Me.cargandoSaca = New System.Windows.Forms.Label()
        Me.gbCamiones.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSacas.SuspendLayout()
        Me.inform.SuspendLayout()
        CType(Me.vehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSaca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbCamiones
        '
        Me.gbCamiones.Controls.Add(Me.Label9)
        Me.gbCamiones.Controls.Add(Me.Label8)
        Me.gbCamiones.Controls.Add(Me.Label7)
        Me.gbCamiones.Controls.Add(Me.PictureBox3)
        Me.gbCamiones.Controls.Add(Me.PictureBox2)
        Me.gbCamiones.Controls.Add(Me.PictureBox1)
        Me.gbCamiones.Controls.Add(Me.Label6)
        Me.gbCamiones.Controls.Add(Me.Label5)
        Me.gbCamiones.Controls.Add(Me.Label4)
        Me.gbCamiones.Controls.Add(Me.mtbCamion)
        Me.gbCamiones.Controls.Add(Me.mtbFurgoneta)
        Me.gbCamiones.Controls.Add(Me.mtbCamioneta)
        Me.gbCamiones.Controls.Add(Me.Label3)
        Me.gbCamiones.Controls.Add(Me.Label2)
        Me.gbCamiones.Controls.Add(Me.Label1)
        Me.gbCamiones.Controls.Add(Me.btElegirCamions)
        Me.gbCamiones.Location = New System.Drawing.Point(12, 12)
        Me.gbCamiones.Name = "gbCamiones"
        Me.gbCamiones.Size = New System.Drawing.Size(294, 249)
        Me.gbCamiones.TabIndex = 0
        Me.gbCamiones.TabStop = False
        Me.gbCamiones.Text = "Elegir Nº Veiculos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(213, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Furgoneta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(87, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Camioneta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Camion"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WinFormsApp.My.Resources.Resource1.furgoneta
        Me.PictureBox3.Location = New System.Drawing.Point(213, 165)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(61, 61)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WinFormsApp.My.Resources.Resource1.camioneta
        Me.PictureBox2.Location = New System.Drawing.Point(87, 165)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(110, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WinFormsApp.My.Resources.Resource1.camion
        Me.PictureBox1.Location = New System.Drawing.Point(10, 165)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(145, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "1 Toneladas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "5 Toneladas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(145, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "10 Toneladas"
        '
        'mtbCamion
        '
        Me.mtbCamion.Location = New System.Drawing.Point(77, 37)
        Me.mtbCamion.Mask = "9"
        Me.mtbCamion.Name = "mtbCamion"
        Me.mtbCamion.Size = New System.Drawing.Size(62, 23)
        Me.mtbCamion.TabIndex = 6
        Me.mtbCamion.ValidatingType = GetType(Integer)
        '
        'mtbFurgoneta
        '
        Me.mtbFurgoneta.Location = New System.Drawing.Point(77, 106)
        Me.mtbFurgoneta.Mask = "9"
        Me.mtbFurgoneta.Name = "mtbFurgoneta"
        Me.mtbFurgoneta.Size = New System.Drawing.Size(62, 23)
        Me.mtbFurgoneta.TabIndex = 5
        Me.mtbFurgoneta.ValidatingType = GetType(Integer)
        '
        'mtbCamioneta
        '
        Me.mtbCamioneta.Location = New System.Drawing.Point(77, 70)
        Me.mtbCamioneta.Mask = "9"
        Me.mtbCamioneta.Name = "mtbCamioneta"
        Me.mtbCamioneta.Size = New System.Drawing.Size(62, 23)
        Me.mtbCamioneta.TabIndex = 4
        Me.mtbCamioneta.ValidatingType = GetType(Integer)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Furgoneta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Camioneta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Camion"
        '
        'btElegirCamions
        '
        Me.btElegirCamions.Location = New System.Drawing.Point(213, 127)
        Me.btElegirCamions.Name = "btElegirCamions"
        Me.btElegirCamions.Size = New System.Drawing.Size(75, 23)
        Me.btElegirCamions.TabIndex = 0
        Me.btElegirCamions.Text = "Elegir"
        Me.btElegirCamions.UseVisualStyleBackColor = True
        '
        'gbSacas
        '
        Me.gbSacas.Controls.Add(Me.btAniadir)
        Me.gbSacas.Controls.Add(Me.lbSacaGb)
        Me.gbSacas.Controls.Add(Me.sbSacas)
        Me.gbSacas.Location = New System.Drawing.Point(518, 12)
        Me.gbSacas.Name = "gbSacas"
        Me.gbSacas.Size = New System.Drawing.Size(281, 124)
        Me.gbSacas.TabIndex = 1
        Me.gbSacas.TabStop = False
        Me.gbSacas.Text = "Saca Nueva"
        '
        'btAniadir
        '
        Me.btAniadir.Location = New System.Drawing.Point(6, 95)
        Me.btAniadir.Name = "btAniadir"
        Me.btAniadir.Size = New System.Drawing.Size(75, 23)
        Me.btAniadir.TabIndex = 2
        Me.btAniadir.Text = "Añadir"
        Me.btAniadir.UseVisualStyleBackColor = True
        '
        'lbSacaGb
        '
        Me.lbSacaGb.AutoSize = True
        Me.lbSacaGb.Location = New System.Drawing.Point(91, 60)
        Me.lbSacaGb.Name = "lbSacaGb"
        Me.lbSacaGb.Size = New System.Drawing.Size(103, 15)
        Me.lbSacaGb.TabIndex = 1
        Me.lbSacaGb.Text = "Tamaño = 1000 kg"
        '
        'sbSacas
        '
        Me.sbSacas.Location = New System.Drawing.Point(6, 40)
        Me.sbSacas.Maximum = 3009
        Me.sbSacas.Minimum = 1000
        Me.sbSacas.Name = "sbSacas"
        Me.sbSacas.Size = New System.Drawing.Size(265, 17)
        Me.sbSacas.TabIndex = 0
        Me.sbSacas.Value = 1000
        '
        'inform
        '
        Me.inform.Controls.Add(Me.lbInform)
        Me.inform.Controls.Add(Me.lbFecha)
        Me.inform.Location = New System.Drawing.Point(312, 12)
        Me.inform.Name = "inform"
        Me.inform.Size = New System.Drawing.Size(200, 100)
        Me.inform.TabIndex = 2
        Me.inform.TabStop = False
        '
        'lbInform
        '
        Me.lbInform.AutoSize = True
        Me.lbInform.Location = New System.Drawing.Point(28, 60)
        Me.lbInform.Name = "lbInform"
        Me.lbInform.Size = New System.Drawing.Size(148, 15)
        Me.lbInform.TabIndex = 1
        Me.lbInform.TabStop = True
        Me.lbInform.Text = "Información de la empresa"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(6, 37)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(44, 15)
        Me.lbFecha.TabIndex = 0
        Me.lbFecha.Text = "Fecha: "
        '
        'vehiculo
        '
        Me.vehiculo.Location = New System.Drawing.Point(12, 336)
        Me.vehiculo.Name = "vehiculo"
        Me.vehiculo.Size = New System.Drawing.Size(100, 97)
        Me.vehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.vehiculo.TabIndex = 3
        Me.vehiculo.TabStop = False
        '
        'pbSaca
        '
        Me.pbSaca.Image = Global.WinFormsApp.My.Resources.Resource1.saca
        Me.pbSaca.Location = New System.Drawing.Point(340, 121)
        Me.pbSaca.Name = "pbSaca"
        Me.pbSaca.Size = New System.Drawing.Size(148, 140)
        Me.pbSaca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSaca.TabIndex = 4
        Me.pbSaca.TabStop = False
        '
        'tiempo
        '
        '
        'lbSaca
        '
        Me.lbSaca.AutoSize = True
        Me.lbSaca.Location = New System.Drawing.Point(340, 264)
        Me.lbSaca.Name = "lbSaca"
        Me.lbSaca.Size = New System.Drawing.Size(45, 15)
        Me.lbSaca.TabIndex = 5
        Me.lbSaca.Text = "Saca = "
        '
        'progressSaca
        '
        Me.progressSaca.Location = New System.Drawing.Point(340, 282)
        Me.progressSaca.Name = "progressSaca"
        Me.progressSaca.Size = New System.Drawing.Size(148, 23)
        Me.progressSaca.TabIndex = 6
        '
        'timerTexto
        '
        Me.timerTexto.Interval = 400
        '
        'cargandoSaca
        '
        Me.cargandoSaca.AutoSize = True
        Me.cargandoSaca.Location = New System.Drawing.Point(348, 308)
        Me.cargandoSaca.Name = "cargandoSaca"
        Me.cargandoSaca.Size = New System.Drawing.Size(120, 15)
        Me.cargandoSaca.TabIndex = 8
        Me.cargandoSaca.Text = "Atención: cargando…"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(811, 438)
        Me.Controls.Add(Me.cargandoSaca)
        Me.Controls.Add(Me.progressSaca)
        Me.Controls.Add(Me.lbSaca)
        Me.Controls.Add(Me.pbSaca)
        Me.Controls.Add(Me.vehiculo)
        Me.Controls.Add(Me.inform)
        Me.Controls.Add(Me.gbSacas)
        Me.Controls.Add(Me.gbCamiones)
        Me.Name = "Form1"
        Me.Text = "Distribuidor Arroz"
        Me.gbCamiones.ResumeLayout(False)
        Me.gbCamiones.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSacas.ResumeLayout(False)
        Me.gbSacas.PerformLayout()
        Me.inform.ResumeLayout(False)
        Me.inform.PerformLayout()
        CType(Me.vehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSaca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbCamiones As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btElegirCamions As Button
    Friend WithEvents mtbCamion As MaskedTextBox
    Friend WithEvents mtbFurgoneta As MaskedTextBox
    Friend WithEvents mtbCamioneta As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gbSacas As GroupBox
    Friend WithEvents sbSacas As HScrollBar
    Friend WithEvents btAniadir As Button
    Friend WithEvents lbSacaGb As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents inform As GroupBox
    Friend WithEvents lbInform As LinkLabel
    Friend WithEvents lbFecha As Label
    Friend WithEvents vehiculo As PictureBox
    Friend WithEvents pbSaca As PictureBox
    Friend WithEvents tiempo As Timer
    Friend WithEvents lbSaca As Label
    Friend WithEvents progressSaca As ProgressBar
    Friend WithEvents timerTexto As Timer
    Friend WithEvents cargandoSaca As Label
End Class

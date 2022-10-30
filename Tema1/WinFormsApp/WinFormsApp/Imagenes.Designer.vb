<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imagenes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btFotocopiadora = New System.Windows.Forms.RadioButton()
        Me.rbSatelite = New System.Windows.Forms.RadioButton()
        Me.rbPortatil = New System.Windows.Forms.RadioButton()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'imagen
        '
        Me.imagen.Location = New System.Drawing.Point(344, 87)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(114, 100)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 3
        Me.imagen.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btFotocopiadora)
        Me.GroupBox1.Controls.Add(Me.rbSatelite)
        Me.GroupBox1.Controls.Add(Me.rbPortatil)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 133)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Imagenes"
        '
        'btFotocopiadora
        '
        Me.btFotocopiadora.AutoSize = True
        Me.btFotocopiadora.Location = New System.Drawing.Point(10, 72)
        Me.btFotocopiadora.Name = "btFotocopiadora"
        Me.btFotocopiadora.Size = New System.Drawing.Size(102, 19)
        Me.btFotocopiadora.TabIndex = 2
        Me.btFotocopiadora.TabStop = True
        Me.btFotocopiadora.Text = "Fotocopiadora"
        Me.btFotocopiadora.UseVisualStyleBackColor = True
        '
        'rbSatelite
        '
        Me.rbSatelite.AutoSize = True
        Me.rbSatelite.Location = New System.Drawing.Point(10, 47)
        Me.rbSatelite.Name = "rbSatelite"
        Me.rbSatelite.Size = New System.Drawing.Size(63, 19)
        Me.rbSatelite.TabIndex = 1
        Me.rbSatelite.TabStop = True
        Me.rbSatelite.Text = "Satelite"
        Me.rbSatelite.UseVisualStyleBackColor = True
        '
        'rbPortatil
        '
        Me.rbPortatil.AutoSize = True
        Me.rbPortatil.Location = New System.Drawing.Point(10, 22)
        Me.rbPortatil.Name = "rbPortatil"
        Me.rbPortatil.Size = New System.Drawing.Size(63, 19)
        Me.rbPortatil.TabIndex = 0
        Me.rbPortatil.TabStop = True
        Me.rbPortatil.Text = "Portatil"
        Me.rbPortatil.UseVisualStyleBackColor = True
        '
        'Imagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 288)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.imagen)
        Me.Name = "Imagenes"
        Me.Text = "Imagenes"
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imagen As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btFotocopiadora As RadioButton
    Friend WithEvents rbSatelite As RadioButton
    Friend WithEvents rbPortatil As RadioButton
End Class

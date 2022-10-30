<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barra
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.charLabel = New System.Windows.Forms.Label()
        Me.valorLabel = New System.Windows.Forms.Label()
        Me.asciiScroll = New System.Windows.Forms.HScrollBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(259, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo ASCII"
        '
        'charLabel
        '
        Me.charLabel.AutoSize = True
        Me.charLabel.Location = New System.Drawing.Point(276, 88)
        Me.charLabel.Name = "charLabel"
        Me.charLabel.Size = New System.Drawing.Size(10, 15)
        Me.charLabel.TabIndex = 1
        Me.charLabel.Text = " "
        '
        'valorLabel
        '
        Me.valorLabel.AutoSize = True
        Me.valorLabel.Location = New System.Drawing.Point(245, 139)
        Me.valorLabel.Name = "valorLabel"
        Me.valorLabel.Size = New System.Drawing.Size(67, 15)
        Me.valorLabel.TabIndex = 2
        Me.valorLabel.Text = "Valor ASCII:"
        '
        'asciiScroll
        '
        Me.asciiScroll.Location = New System.Drawing.Point(67, 194)
        Me.asciiScroll.Maximum = 300
        Me.asciiScroll.Name = "asciiScroll"
        Me.asciiScroll.Size = New System.Drawing.Size(473, 17)
        Me.asciiScroll.TabIndex = 3
        Me.asciiScroll.Value = 1
        '
        'Barra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 338)
        Me.Controls.Add(Me.asciiScroll)
        Me.Controls.Add(Me.valorLabel)
        Me.Controls.Add(Me.charLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Barra"
        Me.Text = "Barra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents charLabel As Label
    Friend WithEvents valorLabel As Label
    Friend WithEvents asciiScroll As HScrollBar
End Class

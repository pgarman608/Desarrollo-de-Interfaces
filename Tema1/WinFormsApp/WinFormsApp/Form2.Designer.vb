﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.tiempoDTP = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelTiempo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tiempoDTP
        '
        Me.tiempoDTP.Location = New System.Drawing.Point(128, 60)
        Me.tiempoDTP.Name = "tiempoDTP"
        Me.tiempoDTP.Size = New System.Drawing.Size(236, 23)
        Me.tiempoDTP.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "La fecha nueva elegida:"
        '
        'labelTiempo
        '
        Me.labelTiempo.AutoSize = True
        Me.labelTiempo.Location = New System.Drawing.Point(128, 142)
        Me.labelTiempo.Name = "labelTiempo"
        Me.labelTiempo.Size = New System.Drawing.Size(10, 15)
        Me.labelTiempo.TabIndex = 2
        Me.labelTiempo.Text = " "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 307)
        Me.Controls.Add(Me.labelTiempo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tiempoDTP)
        Me.Name = "Form2"
        Me.Text = "Tiempo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tiempoDTP As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents labelTiempo As Label
End Class

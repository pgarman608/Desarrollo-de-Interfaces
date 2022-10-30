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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tiempoTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.imagenesTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraTSIM = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tiempoTSM, Me.imagenesTSMI, Me.BarraTSIM, Me.EditorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tiempoTSM
        '
        Me.tiempoTSM.Name = "tiempoTSM"
        Me.tiempoTSM.Size = New System.Drawing.Size(59, 20)
        Me.tiempoTSM.Text = "Tiempo"
        '
        'imagenesTSMI
        '
        Me.imagenesTSMI.Name = "imagenesTSMI"
        Me.imagenesTSMI.Size = New System.Drawing.Size(70, 20)
        Me.imagenesTSMI.Text = "Imagenes"
        '
        'BarraTSIM
        '
        Me.BarraTSIM.Name = "BarraTSIM"
        Me.BarraTSIM.Size = New System.Drawing.Size(46, 20)
        Me.BarraTSIM.Text = "Barra"
        '
        'EditorToolStripMenuItem
        '
        Me.EditorToolStripMenuItem.Name = "EditorToolStripMenuItem"
        Me.EditorToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.EditorToolStripMenuItem.Text = "Editor"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Ejercicio MDI"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tiempoTSM As ToolStripMenuItem
    Friend WithEvents imagenesTSMI As ToolStripMenuItem
    Friend WithEvents BarraTSIM As ToolStripMenuItem
    Friend WithEvents EditorToolStripMenuItem As ToolStripMenuItem
End Class

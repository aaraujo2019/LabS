<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPpal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPpal))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MuestrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecibirMuestrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesarMuestrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesarMuestrasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirEtiquetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BullonDoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenesDeTrabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MuestrasToolStripMenuItem, Me.OrdenesDeTrabajoToolStripMenuItem, Me.FinalizarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(983, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MuestrasToolStripMenuItem
        '
        Me.MuestrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecibirMuestrasToolStripMenuItem, Me.PesarMuestrasToolStripMenuItem, Me.PesarMuestrasToolStripMenuItem1, Me.ImprimirEtiquetasToolStripMenuItem, Me.ImprimirControlToolStripMenuItem, Me.BullonDoreToolStripMenuItem})
        Me.MuestrasToolStripMenuItem.Name = "MuestrasToolStripMenuItem"
        Me.MuestrasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.MuestrasToolStripMenuItem.Text = "Muestras"
        '
        'RecibirMuestrasToolStripMenuItem
        '
        Me.RecibirMuestrasToolStripMenuItem.Name = "RecibirMuestrasToolStripMenuItem"
        Me.RecibirMuestrasToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.RecibirMuestrasToolStripMenuItem.Text = "Recibir Muestras (Crear Orden)"
        '
        'PesarMuestrasToolStripMenuItem
        '
        Me.PesarMuestrasToolStripMenuItem.Name = "PesarMuestrasToolStripMenuItem"
        Me.PesarMuestrasToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.PesarMuestrasToolStripMenuItem.Text = "Pesar Muestras (Humedad)"
        '
        'PesarMuestrasToolStripMenuItem1
        '
        Me.PesarMuestrasToolStripMenuItem1.Name = "PesarMuestrasToolStripMenuItem1"
        Me.PesarMuestrasToolStripMenuItem1.Size = New System.Drawing.Size(236, 22)
        Me.PesarMuestrasToolStripMenuItem1.Text = "Pesar Muestras"
        '
        'ImprimirEtiquetasToolStripMenuItem
        '
        Me.ImprimirEtiquetasToolStripMenuItem.Name = "ImprimirEtiquetasToolStripMenuItem"
        Me.ImprimirEtiquetasToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ImprimirEtiquetasToolStripMenuItem.Text = "Imprimir Etiquetas"
        '
        'ImprimirControlToolStripMenuItem
        '
        Me.ImprimirControlToolStripMenuItem.Name = "ImprimirControlToolStripMenuItem"
        Me.ImprimirControlToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ImprimirControlToolStripMenuItem.Text = "Imprimir Control"
        '
        'BullonDoreToolStripMenuItem
        '
        Me.BullonDoreToolStripMenuItem.Name = "BullonDoreToolStripMenuItem"
        Me.BullonDoreToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.BullonDoreToolStripMenuItem.Text = "Bullon Dore"
        '
        'OrdenesDeTrabajoToolStripMenuItem
        '
        Me.OrdenesDeTrabajoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem})
        Me.OrdenesDeTrabajoToolStripMenuItem.Name = "OrdenesDeTrabajoToolStripMenuItem"
        Me.OrdenesDeTrabajoToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.OrdenesDeTrabajoToolStripMenuItem.Text = "Ordenes de Trabajo"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar Humedad"
        '
        'FinalizarToolStripMenuItem
        '
        Me.FinalizarToolStripMenuItem.Name = "FinalizarToolStripMenuItem"
        Me.FinalizarToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.FinalizarToolStripMenuItem.Text = "Sincronizar"
        '
        'FrmPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 603)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmPpal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laboratorio Zandor Capital"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MuestrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecibirMuestrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PesarMuestrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PesarMuestrasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirEtiquetasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenesDeTrabajoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinalizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BullonDoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

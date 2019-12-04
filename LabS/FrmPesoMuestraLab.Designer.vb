<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesoMuestraLab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPesoMuestraLab))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtDespacho = New System.Windows.Forms.TextBox()
        Me.DtFechaMuestra = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtonConFecha = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DtFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.DtFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBuscarMuestra = New System.Windows.Forms.PictureBox()
        Me.BtonGardar = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPSeco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMuestra = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblArea = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BtonConFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBuscarMuestra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtonGardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label11.Location = New System.Drawing.Point(610, 119)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Id Despacho"
        Me.Label11.Visible = False
        '
        'TxtDespacho
        '
        Me.TxtDespacho.BackColor = System.Drawing.Color.White
        Me.TxtDespacho.Enabled = False
        Me.TxtDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.TxtDespacho.Location = New System.Drawing.Point(372, 119)
        Me.TxtDespacho.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDespacho.Name = "TxtDespacho"
        Me.TxtDespacho.Size = New System.Drawing.Size(192, 32)
        Me.TxtDespacho.TabIndex = 74
        '
        'DtFechaMuestra
        '
        Me.DtFechaMuestra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaMuestra.Location = New System.Drawing.Point(14, 131)
        Me.DtFechaMuestra.Margin = New System.Windows.Forms.Padding(2)
        Me.DtFechaMuestra.Name = "DtFechaMuestra"
        Me.DtFechaMuestra.Size = New System.Drawing.Size(151, 20)
        Me.DtFechaMuestra.TabIndex = 73
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtonConFecha)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.DtFecha2)
        Me.GroupBox3.Controls.Add(Me.DtFecha1)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 288)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(685, 93)
        Me.GroupBox3.TabIndex = 72
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Consultar Por Fecha:"
        '
        'BtonConFecha
        '
        Me.BtonConFecha.Image = Global.LabS.My.Resources.Resources.microsoft_office_excel1
        Me.BtonConFecha.Location = New System.Drawing.Point(606, 17)
        Me.BtonConFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.BtonConFecha.Name = "BtonConFecha"
        Me.BtonConFecha.Size = New System.Drawing.Size(58, 59)
        Me.BtonConFecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtonConFecha.TabIndex = 4
        Me.BtonConFecha.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(234, 31)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Hasta:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Desde:"
        '
        'DtFecha2
        '
        Me.DtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha2.Location = New System.Drawing.Point(236, 47)
        Me.DtFecha2.Margin = New System.Windows.Forms.Padding(2)
        Me.DtFecha2.Name = "DtFecha2"
        Me.DtFecha2.Size = New System.Drawing.Size(151, 20)
        Me.DtFecha2.TabIndex = 1
        '
        'DtFecha1
        '
        Me.DtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha1.Location = New System.Drawing.Point(23, 47)
        Me.DtFecha1.Margin = New System.Windows.Forms.Padding(2)
        Me.DtFecha1.Name = "DtFecha1"
        Me.DtFecha1.Size = New System.Drawing.Size(151, 20)
        Me.DtFecha1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBuscarMuestra)
        Me.GroupBox1.Controls.Add(Me.BtonGardar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtPSeco)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtMuestra)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 170)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(685, 104)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Muestra"
        '
        'PictureBuscarMuestra
        '
        Me.PictureBuscarMuestra.Image = Global.LabS.My.Resources.Resources.buscar_buscar_ampliar_icono_6707_96
        Me.PictureBuscarMuestra.Location = New System.Drawing.Point(136, 45)
        Me.PictureBuscarMuestra.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBuscarMuestra.Name = "PictureBuscarMuestra"
        Me.PictureBuscarMuestra.Size = New System.Drawing.Size(26, 26)
        Me.PictureBuscarMuestra.TabIndex = 58
        Me.PictureBuscarMuestra.TabStop = False
        '
        'BtonGardar
        '
        Me.BtonGardar.Image = CType(resources.GetObject("BtonGardar.Image"), System.Drawing.Image)
        Me.BtonGardar.Location = New System.Drawing.Point(620, 30)
        Me.BtonGardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtonGardar.Name = "BtonGardar"
        Me.BtonGardar.Size = New System.Drawing.Size(44, 48)
        Me.BtonGardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtonGardar.TabIndex = 41
        Me.BtonGardar.TabStop = False
        Me.BtonGardar.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(238, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Peso Seco:"
        '
        'TxtPSeco
        '
        Me.TxtPSeco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPSeco.Location = New System.Drawing.Point(236, 45)
        Me.TxtPSeco.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPSeco.Name = "TxtPSeco"
        Me.TxtPSeco.Size = New System.Drawing.Size(98, 26)
        Me.TxtPSeco.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(16, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Muestra"
        '
        'TxtMuestra
        '
        Me.TxtMuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMuestra.Location = New System.Drawing.Point(19, 45)
        Me.TxtMuestra.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMuestra.Name = "TxtMuestra"
        Me.TxtMuestra.Size = New System.Drawing.Size(107, 26)
        Me.TxtMuestra.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(132, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(456, 27)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Laboratorio Quimico - Peso de Muestras"
        '
        'LblArea
        '
        Me.LblArea.AutoSize = True
        Me.LblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblArea.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblArea.Location = New System.Drawing.Point(148, 42)
        Me.LblArea.Name = "LblArea"
        Me.LblArea.Size = New System.Drawing.Size(71, 13)
        Me.LblArea.TabIndex = 66
        Me.LblArea.Text = "Laboratorio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Departamento:"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblUsuario.Location = New System.Drawing.Point(148, 16)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(71, 13)
        Me.LblUsuario.TabIndex = 64
        Me.LblUsuario.Text = "Laboratorio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Id. Usuario:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LblUsuario)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.LblArea)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(685, 64)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LabS.My.Resources.Resources.LogoGranColombiaGoldSmall
        Me.PictureBox1.Location = New System.Drawing.Point(506, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'FrmPesoMuestraLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(713, 395)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtDespacho)
        Me.Controls.Add(Me.DtFechaMuestra)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmPesoMuestraLab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peso de Muestras En Laboratorio Quimico"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.BtonConFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBuscarMuestra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtonGardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtDespacho As System.Windows.Forms.TextBox
    Friend WithEvents DtFechaMuestra As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtonConFecha As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DtFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBuscarMuestra As System.Windows.Forms.PictureBox
    Friend WithEvents BtonGardar As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPSeco As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtMuestra As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblArea As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

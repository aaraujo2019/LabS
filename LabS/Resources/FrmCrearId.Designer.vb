<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearId
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCrearId))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblArea = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblValor = New System.Windows.Forms.Label()
        Me.GroupBoxUbicacion = New System.Windows.Forms.GroupBox()
        Me.RbFinal = New System.Windows.Forms.RadioButton()
        Me.RbInicio = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbLetra = New System.Windows.Forms.ComboBox()
        Me.TxtVlorFinal = New System.Windows.Forms.MaskedTextBox()
        Me.TxtValorInicio = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DgResultado = New System.Windows.Forms.DataGridView()
        Me.BtnCargarExcel = New System.Windows.Forms.PictureBox()
        Me.txtruta = New System.Windows.Forms.TextBox()
        Me.CmdExaminar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxUbicacion.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCargarExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(290, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(244, 27)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Laboratorio Quimico"
        '
        'LblArea
        '
        Me.LblArea.AutoSize = True
        Me.LblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblArea.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblArea.Location = New System.Drawing.Point(272, 76)
        Me.LblArea.Name = "LblArea"
        Me.LblArea.Size = New System.Drawing.Size(71, 13)
        Me.LblArea.TabIndex = 64
        Me.LblArea.Text = "Laboratorio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(129, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Departamento:"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblUsuario.Location = New System.Drawing.Point(272, 50)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(71, 13)
        Me.LblUsuario.TabIndex = 62
        Me.LblUsuario.Text = "Laboratorio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Id. Usuario:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(46, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(822, 64)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LabS.My.Resources.Resources.LogoGranColombiaGoldSmall
        Me.PictureBox1.Location = New System.Drawing.Point(632, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 41)
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblValor)
        Me.GroupBox1.Controls.Add(Me.GroupBoxUbicacion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CmbLetra)
        Me.GroupBox1.Controls.Add(Me.TxtVlorFinal)
        Me.GroupBox1.Controls.Add(Me.TxtValorInicio)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 129)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(822, 147)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generar Consecutivos"
        '
        'LblValor
        '
        Me.LblValor.AutoSize = True
        Me.LblValor.Location = New System.Drawing.Point(736, 15)
        Me.LblValor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(39, 13)
        Me.LblValor.TabIndex = 72
        Me.LblValor.Text = "Label5"
        '
        'GroupBoxUbicacion
        '
        Me.GroupBoxUbicacion.Controls.Add(Me.RbFinal)
        Me.GroupBoxUbicacion.Controls.Add(Me.RbInicio)
        Me.GroupBoxUbicacion.Enabled = False
        Me.GroupBoxUbicacion.Location = New System.Drawing.Point(119, 54)
        Me.GroupBoxUbicacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBoxUbicacion.Name = "GroupBoxUbicacion"
        Me.GroupBoxUbicacion.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBoxUbicacion.Size = New System.Drawing.Size(101, 81)
        Me.GroupBoxUbicacion.TabIndex = 68
        Me.GroupBoxUbicacion.TabStop = False
        Me.GroupBoxUbicacion.Text = "Ubicacion Letra:"
        '
        'RbFinal
        '
        Me.RbFinal.AutoSize = True
        Me.RbFinal.Location = New System.Drawing.Point(14, 50)
        Me.RbFinal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RbFinal.Name = "RbFinal"
        Me.RbFinal.Size = New System.Drawing.Size(47, 17)
        Me.RbFinal.TabIndex = 73
        Me.RbFinal.Text = "Final"
        Me.RbFinal.UseVisualStyleBackColor = True
        '
        'RbInicio
        '
        Me.RbInicio.AutoSize = True
        Me.RbInicio.Checked = True
        Me.RbInicio.Location = New System.Drawing.Point(14, 26)
        Me.RbInicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RbInicio.Name = "RbInicio"
        Me.RbInicio.Size = New System.Drawing.Size(50, 17)
        Me.RbInicio.TabIndex = 72
        Me.RbInicio.TabStop = True
        Me.RbInicio.Text = "Inicio"
        Me.RbInicio.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Letra:"
        '
        'CmbLetra
        '
        Me.CmbLetra.FormattingEnabled = True
        Me.CmbLetra.Items.AddRange(New Object() {"NO", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.CmbLetra.Location = New System.Drawing.Point(57, 70)
        Me.CmbLetra.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmbLetra.Name = "CmbLetra"
        Me.CmbLetra.Size = New System.Drawing.Size(49, 21)
        Me.CmbLetra.TabIndex = 70
        Me.CmbLetra.Text = "NO"
        '
        'TxtVlorFinal
        '
        Me.TxtVlorFinal.Location = New System.Drawing.Point(434, 70)
        Me.TxtVlorFinal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtVlorFinal.Mask = "999999"
        Me.TxtVlorFinal.Name = "TxtVlorFinal"
        Me.TxtVlorFinal.Size = New System.Drawing.Size(116, 20)
        Me.TxtVlorFinal.TabIndex = 69
        '
        'TxtValorInicio
        '
        Me.TxtValorInicio.Location = New System.Drawing.Point(262, 70)
        Me.TxtValorInicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtValorInicio.Mask = "999999"
        Me.TxtValorInicio.Name = "TxtValorInicio"
        Me.TxtValorInicio.Size = New System.Drawing.Size(116, 20)
        Me.TxtValorInicio.TabIndex = 68
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.LabS.My.Resources.Resources.Fairytale_button_add
        Me.PictureBox2.Location = New System.Drawing.Point(576, 35)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 53)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(431, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Valor Inicial:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.DgResultado)
        Me.GroupBox3.Controls.Add(Me.BtnCargarExcel)
        Me.GroupBox3.Controls.Add(Me.txtruta)
        Me.GroupBox3.Controls.Add(Me.CmdExaminar)
        Me.GroupBox3.Location = New System.Drawing.Point(46, 294)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(822, 262)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Importar de Excel"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label6.Location = New System.Drawing.Point(68, 106)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(320, 13)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Luego seleccionas el archivo atravez del boton. y presiona cargar."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Location = New System.Drawing.Point(68, 89)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(421, 13)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Por favor crea una hoja de excel y que en la primera columna tenga los codigos a " & _
            "crear."
        '
        'DgResultado
        '
        Me.DgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgResultado.Location = New System.Drawing.Point(59, 124)
        Me.DgResultado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DgResultado.Name = "DgResultado"
        Me.DgResultado.RowTemplate.Height = 24
        Me.DgResultado.Size = New System.Drawing.Size(490, 122)
        Me.DgResultado.TabIndex = 74
        '
        'BtnCargarExcel
        '
        Me.BtnCargarExcel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BtnCargarExcel.Image = Global.LabS.My.Resources.Resources.Fairytale_button_add
        Me.BtnCargarExcel.Location = New System.Drawing.Point(578, 16)
        Me.BtnCargarExcel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnCargarExcel.Name = "BtnCargarExcel"
        Me.BtnCargarExcel.Size = New System.Drawing.Size(52, 53)
        Me.BtnCargarExcel.TabIndex = 73
        Me.BtnCargarExcel.TabStop = False
        '
        'txtruta
        '
        Me.txtruta.Location = New System.Drawing.Point(59, 51)
        Me.txtruta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(164, 20)
        Me.txtruta.TabIndex = 1
        '
        'CmdExaminar
        '
        Me.CmdExaminar.Location = New System.Drawing.Point(265, 51)
        Me.CmdExaminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmdExaminar.Name = "CmdExaminar"
        Me.CmdExaminar.Size = New System.Drawing.Size(109, 19)
        Me.CmdExaminar.TabIndex = 0
        Me.CmdExaminar.Text = "Examinar...."
        Me.CmdExaminar.UseVisualStyleBackColor = True
        '
        'FrmCrearId
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(924, 566)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LblArea)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmCrearId"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Id De Muestras."
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxUbicacion.ResumeLayout(False)
        Me.GroupBoxUbicacion.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DgResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCargarExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblArea As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtValorInicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBoxUbicacion As System.Windows.Forms.GroupBox
    Friend WithEvents RbFinal As System.Windows.Forms.RadioButton
    Friend WithEvents RbInicio As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbLetra As System.Windows.Forms.ComboBox
    Friend WithEvents TxtVlorFinal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblValor As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCargarExcel As System.Windows.Forms.PictureBox
    Friend WithEvents txtruta As System.Windows.Forms.TextBox
    Friend WithEvents CmdExaminar As System.Windows.Forms.Button
    Friend WithEvents DgResultado As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class

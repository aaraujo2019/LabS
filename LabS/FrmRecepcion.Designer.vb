<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecepcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecepcion))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblArea = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmdFinalizar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cmdpesarlote = New System.Windows.Forms.Button()
        Me.LblValor = New System.Windows.Forms.Label()
        Me.Txtfinal = New System.Windows.Forms.MaskedTextBox()
        Me.TxtInicio = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBoxUbicacion = New System.Windows.Forms.GroupBox()
        Me.RbFinal = New System.Windows.Forms.RadioButton()
        Me.RbInicio = New System.Windows.Forms.RadioButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.CmbLetra = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtDesde2 = New System.Windows.Forms.TextBox()
        Me.TxtHasta2 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtOtrasOrdenes = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtCajaHasta = New System.Windows.Forms.TextBox()
        Me.TxtCajadesde = New System.Windows.Forms.TextBox()
        Me.TxtHasta = New System.Windows.Forms.TextBox()
        Me.TxtDesde = New System.Windows.Forms.TextBox()
        Me.DtFechaCaja = New System.Windows.Forms.DateTimePicker()
        Me.CmdImprimir = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LblTotalMuestras = New System.Windows.Forms.Label()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TxtOrdenServicio = New System.Windows.Forms.TextBox()
        Me.TxtPreparacion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CmbTipoMuestra = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbArea = New System.Windows.Forms.ComboBox()
        Me.CmdExport = New System.Windows.Forms.Button()
        Me.CmdBorrar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblFechaDespacho = New System.Windows.Forms.Label()
        Me.LblIdDespacho = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cmdagregar = New System.Windows.Forms.Button()
        Me.DgMuestrasDespacho = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmbDespacho = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxUbicacion.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgMuestrasDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(302, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(244, 27)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Laboratorio Quimico"
        '
        'LblArea
        '
        Me.LblArea.AutoSize = True
        Me.LblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblArea.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblArea.Location = New System.Drawing.Point(243, 75)
        Me.LblArea.Name = "LblArea"
        Me.LblArea.Size = New System.Drawing.Size(71, 13)
        Me.LblArea.TabIndex = 58
        Me.LblArea.Text = "Laboratorio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(100, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Departamento:"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblUsuario.Location = New System.Drawing.Point(243, 49)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(71, 13)
        Me.LblUsuario.TabIndex = 56
        Me.LblUsuario.Text = "Laboratorio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Id. Usuario:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdFinalizar)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(876, 64)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Usuario:"
        '
        'CmdFinalizar
        '
        Me.CmdFinalizar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CmdFinalizar.Location = New System.Drawing.Point(747, 14)
        Me.CmdFinalizar.Name = "CmdFinalizar"
        Me.CmdFinalizar.Size = New System.Drawing.Size(75, 42)
        Me.CmdFinalizar.TabIndex = 62
        Me.CmdFinalizar.Text = "Finalizar Orden"
        Me.CmdFinalizar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LabS.My.Resources.Resources.LogoGranColombiaGoldSmall
        Me.PictureBox1.Location = New System.Drawing.Point(563, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmdpesarlote)
        Me.GroupBox1.Controls.Add(Me.LblValor)
        Me.GroupBox1.Controls.Add(Me.Txtfinal)
        Me.GroupBox1.Controls.Add(Me.TxtInicio)
        Me.GroupBox1.Controls.Add(Me.GroupBoxUbicacion)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.CmbLetra)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.LblTotalMuestras)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TxtOrdenServicio)
        Me.GroupBox1.Controls.Add(Me.TxtPreparacion)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.CmbTipoMuestra)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.CmbArea)
        Me.GroupBox1.Controls.Add(Me.CmdExport)
        Me.GroupBox1.Controls.Add(Me.CmdBorrar)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LblFechaDespacho)
        Me.GroupBox1.Controls.Add(Me.LblIdDespacho)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Cmdagregar)
        Me.GroupBox1.Controls.Add(Me.DgMuestrasDespacho)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtFecha)
        Me.GroupBox1.Controls.Add(Me.cmbDespacho)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(876, 442)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Muestras Despachadas:"
        '
        'Cmdpesarlote
        '
        Me.Cmdpesarlote.Enabled = False
        Me.Cmdpesarlote.Location = New System.Drawing.Point(432, 411)
        Me.Cmdpesarlote.Name = "Cmdpesarlote"
        Me.Cmdpesarlote.Size = New System.Drawing.Size(75, 23)
        Me.Cmdpesarlote.TabIndex = 81
        Me.Cmdpesarlote.Text = "Pesar Lote"
        Me.Cmdpesarlote.UseVisualStyleBackColor = True
        '
        'LblValor
        '
        Me.LblValor.AutoSize = True
        Me.LblValor.Location = New System.Drawing.Point(711, 130)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(45, 13)
        Me.LblValor.TabIndex = 79
        Me.LblValor.Text = "Label26"
        '
        'Txtfinal
        '
        Me.Txtfinal.Location = New System.Drawing.Point(404, 203)
        Me.Txtfinal.Mask = "99999999"
        Me.Txtfinal.Name = "Txtfinal"
        Me.Txtfinal.Size = New System.Drawing.Size(100, 20)
        Me.Txtfinal.TabIndex = 78
        '
        'TxtInicio
        '
        Me.TxtInicio.Location = New System.Drawing.Point(260, 203)
        Me.TxtInicio.Mask = "99999999"
        Me.TxtInicio.Name = "TxtInicio"
        Me.TxtInicio.Size = New System.Drawing.Size(100, 20)
        Me.TxtInicio.TabIndex = 77
        '
        'GroupBoxUbicacion
        '
        Me.GroupBoxUbicacion.Controls.Add(Me.RbFinal)
        Me.GroupBoxUbicacion.Controls.Add(Me.RbInicio)
        Me.GroupBoxUbicacion.Location = New System.Drawing.Point(154, 164)
        Me.GroupBoxUbicacion.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxUbicacion.Name = "GroupBoxUbicacion"
        Me.GroupBoxUbicacion.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxUbicacion.Size = New System.Drawing.Size(101, 81)
        Me.GroupBoxUbicacion.TabIndex = 72
        Me.GroupBoxUbicacion.TabStop = False
        Me.GroupBoxUbicacion.Text = "Ubicacion Letra:"
        '
        'RbFinal
        '
        Me.RbFinal.AutoSize = True
        Me.RbFinal.Location = New System.Drawing.Point(14, 50)
        Me.RbFinal.Margin = New System.Windows.Forms.Padding(2)
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
        Me.RbInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.RbInicio.Name = "RbInicio"
        Me.RbInicio.Size = New System.Drawing.Size(50, 17)
        Me.RbInicio.TabIndex = 72
        Me.RbInicio.TabStop = True
        Me.RbInicio.Text = "Inicio"
        Me.RbInicio.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(42, 170)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(34, 13)
        Me.Label25.TabIndex = 74
        Me.Label25.Text = "Letra:"
        '
        'CmbLetra
        '
        Me.CmbLetra.FormattingEnabled = True
        Me.CmbLetra.Items.AddRange(New Object() {"NO", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.CmbLetra.Location = New System.Drawing.Point(42, 186)
        Me.CmbLetra.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbLetra.Name = "CmbLetra"
        Me.CmbLetra.Size = New System.Drawing.Size(49, 21)
        Me.CmbLetra.TabIndex = 73
        Me.CmbLetra.Text = "NO"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtDesde2)
        Me.GroupBox3.Controls.Add(Me.TxtHasta2)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.TxtOtrasOrdenes)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.TxtCajaHasta)
        Me.GroupBox3.Controls.Add(Me.TxtCajadesde)
        Me.GroupBox3.Controls.Add(Me.TxtHasta)
        Me.GroupBox3.Controls.Add(Me.TxtDesde)
        Me.GroupBox3.Controls.Add(Me.DtFechaCaja)
        Me.GroupBox3.Controls.Add(Me.CmdImprimir)
        Me.GroupBox3.Location = New System.Drawing.Point(546, 249)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(291, 187)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Imprimir Etiqueta:"
        '
        'TxtDesde2
        '
        Me.TxtDesde2.Location = New System.Drawing.Point(65, 83)
        Me.TxtDesde2.Name = "TxtDesde2"
        Me.TxtDesde2.Size = New System.Drawing.Size(80, 20)
        Me.TxtDesde2.TabIndex = 50
        '
        'TxtHasta2
        '
        Me.TxtHasta2.Location = New System.Drawing.Point(165, 84)
        Me.TxtHasta2.Name = "TxtHasta2"
        Me.TxtHasta2.Size = New System.Drawing.Size(80, 20)
        Me.TxtHasta2.TabIndex = 49
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(3, 62)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 13)
        Me.Label24.TabIndex = 48
        Me.Label24.Text = "Muestras:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(4, 116)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 13)
        Me.Label23.TabIndex = 47
        Me.Label23.Text = "Cajas:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(14, 134)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 13)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Otras Ordenes:"
        '
        'TxtOtrasOrdenes
        '
        Me.TxtOtrasOrdenes.Location = New System.Drawing.Point(17, 152)
        Me.TxtOtrasOrdenes.Multiline = True
        Me.TxtOtrasOrdenes.Name = "TxtOtrasOrdenes"
        Me.TxtOtrasOrdenes.Size = New System.Drawing.Size(187, 29)
        Me.TxtOtrasOrdenes.TabIndex = 45
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label22.Location = New System.Drawing.Point(117, 119)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(22, 13)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "de:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label21.Location = New System.Drawing.Point(65, 42)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 13)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "Desde:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label20.Location = New System.Drawing.Point(162, 42)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 13)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Hasta:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Fecha:"
        '
        'TxtCajaHasta
        '
        Me.TxtCajaHasta.Location = New System.Drawing.Point(154, 112)
        Me.TxtCajaHasta.Name = "TxtCajaHasta"
        Me.TxtCajaHasta.Size = New System.Drawing.Size(50, 20)
        Me.TxtCajaHasta.TabIndex = 39
        '
        'TxtCajadesde
        '
        Me.TxtCajadesde.Location = New System.Drawing.Point(66, 112)
        Me.TxtCajadesde.Name = "TxtCajadesde"
        Me.TxtCajadesde.Size = New System.Drawing.Size(45, 20)
        Me.TxtCajadesde.TabIndex = 38
        '
        'TxtHasta
        '
        Me.TxtHasta.Location = New System.Drawing.Point(165, 58)
        Me.TxtHasta.Name = "TxtHasta"
        Me.TxtHasta.Size = New System.Drawing.Size(80, 20)
        Me.TxtHasta.TabIndex = 37
        '
        'TxtDesde
        '
        Me.TxtDesde.Location = New System.Drawing.Point(65, 58)
        Me.TxtDesde.Name = "TxtDesde"
        Me.TxtDesde.Size = New System.Drawing.Size(80, 20)
        Me.TxtDesde.TabIndex = 36
        '
        'DtFechaCaja
        '
        Me.DtFechaCaja.Location = New System.Drawing.Point(57, 19)
        Me.DtFechaCaja.Name = "DtFechaCaja"
        Me.DtFechaCaja.Size = New System.Drawing.Size(188, 20)
        Me.DtFechaCaja.TabIndex = 35
        Me.DtFechaCaja.Value = New Date(2015, 9, 1, 16, 50, 9, 0)
        '
        'CmdImprimir
        '
        Me.CmdImprimir.Location = New System.Drawing.Point(210, 162)
        Me.CmdImprimir.Name = "CmdImprimir"
        Me.CmdImprimir.Size = New System.Drawing.Size(75, 23)
        Me.CmdImprimir.TabIndex = 34
        Me.CmdImprimir.Text = "Imprimir"
        Me.CmdImprimir.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(40, 418)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Total de Muestras:"
        '
        'LblTotalMuestras
        '
        Me.LblTotalMuestras.AutoSize = True
        Me.LblTotalMuestras.Location = New System.Drawing.Point(205, 418)
        Me.LblTotalMuestras.Name = "LblTotalMuestras"
        Me.LblTotalMuestras.Size = New System.Drawing.Size(19, 13)
        Me.LblTotalMuestras.TabIndex = 35
        Me.LblTotalMuestras.Text = "----"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(747, 43)
        Me.cmdNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmdNuevo.TabIndex = 33
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(543, 87)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Elementos:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(402, 87)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Codigo de Servicio:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(258, 87)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Codigo de Preparacion:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(543, 103)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(103, 20)
        Me.TextBox1.TabIndex = 29
        '
        'TxtOrdenServicio
        '
        Me.TxtOrdenServicio.Location = New System.Drawing.Point(404, 105)
        Me.TxtOrdenServicio.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtOrdenServicio.Name = "TxtOrdenServicio"
        Me.TxtOrdenServicio.Size = New System.Drawing.Size(103, 20)
        Me.TxtOrdenServicio.TabIndex = 28
        '
        'TxtPreparacion
        '
        Me.TxtPreparacion.Location = New System.Drawing.Point(260, 105)
        Me.TxtPreparacion.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPreparacion.Name = "TxtPreparacion"
        Me.TxtPreparacion.Size = New System.Drawing.Size(103, 20)
        Me.TxtPreparacion.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(36, 87)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Tipo de Muestra:"
        '
        'CmbTipoMuestra
        '
        Me.CmbTipoMuestra.FormattingEnabled = True
        Me.CmbTipoMuestra.Location = New System.Drawing.Point(38, 103)
        Me.CmbTipoMuestra.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbTipoMuestra.Name = "CmbTipoMuestra"
        Me.CmbTipoMuestra.Size = New System.Drawing.Size(194, 21)
        Me.CmbTipoMuestra.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(543, 25)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Area:"
        '
        'CmbArea
        '
        Me.CmbArea.FormattingEnabled = True
        Me.CmbArea.Location = New System.Drawing.Point(543, 45)
        Me.CmbArea.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbArea.Name = "CmbArea"
        Me.CmbArea.Size = New System.Drawing.Size(158, 21)
        Me.CmbArea.TabIndex = 23
        '
        'CmdExport
        '
        Me.CmdExport.Location = New System.Drawing.Point(260, 411)
        Me.CmdExport.Name = "CmdExport"
        Me.CmdExport.Size = New System.Drawing.Size(75, 23)
        Me.CmdExport.TabIndex = 22
        Me.CmdExport.Text = "Exportar"
        Me.CmdExport.UseVisualStyleBackColor = True
        '
        'CmdBorrar
        '
        Me.CmdBorrar.Location = New System.Drawing.Point(344, 411)
        Me.CmdBorrar.Name = "CmdBorrar"
        Me.CmdBorrar.Size = New System.Drawing.Size(75, 23)
        Me.CmdBorrar.TabIndex = 21
        Me.CmdBorrar.Text = "Borrar"
        Me.CmdBorrar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(39, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 21)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Agregar Muestras:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(404, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Fecha de Despacho:"
        '
        'LblFechaDespacho
        '
        Me.LblFechaDespacho.AutoSize = True
        Me.LblFechaDespacho.Location = New System.Drawing.Point(404, 50)
        Me.LblFechaDespacho.Name = "LblFechaDespacho"
        Me.LblFechaDespacho.Size = New System.Drawing.Size(39, 13)
        Me.LblFechaDespacho.TabIndex = 18
        Me.LblFechaDespacho.Text = "Label9"
        '
        'LblIdDespacho
        '
        Me.LblIdDespacho.AutoSize = True
        Me.LblIdDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdDespacho.Location = New System.Drawing.Point(262, 42)
        Me.LblIdDespacho.Name = "LblIdDespacho"
        Me.LblIdDespacho.Size = New System.Drawing.Size(82, 20)
        Me.LblIdDespacho.TabIndex = 17
        Me.LblIdDespacho.Text = "Despacho"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(260, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Desde:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(540, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Comentarios:"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(543, 183)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(148, 40)
        Me.TxtObservaciones.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Listado de Muestras:"
        '
        'Cmdagregar
        '
        Me.Cmdagregar.Location = New System.Drawing.Point(747, 187)
        Me.Cmdagregar.Name = "Cmdagregar"
        Me.Cmdagregar.Size = New System.Drawing.Size(75, 23)
        Me.Cmdagregar.TabIndex = 10
        Me.Cmdagregar.Text = "Agregar"
        Me.Cmdagregar.UseVisualStyleBackColor = True
        '
        'DgMuestrasDespacho
        '
        Me.DgMuestrasDespacho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgMuestrasDespacho.Location = New System.Drawing.Point(43, 270)
        Me.DgMuestrasDespacho.Name = "DgMuestrasDespacho"
        Me.DgMuestrasDespacho.RowTemplate.Height = 24
        Me.DgMuestrasDespacho.Size = New System.Drawing.Size(485, 135)
        Me.DgMuestrasDespacho.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(405, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(663, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha de Muestreo:"
        '
        'DtFecha
        '
        Me.DtFecha.Location = New System.Drawing.Point(663, 103)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(200, 20)
        Me.DtFecha.TabIndex = 1
        '
        'cmbDespacho
        '
        Me.cmbDespacho.FormattingEnabled = True
        Me.cmbDespacho.Location = New System.Drawing.Point(45, 42)
        Me.cmbDespacho.Name = "cmbDespacho"
        Me.cmbDespacho.Size = New System.Drawing.Size(188, 21)
        Me.cmbDespacho.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ID Despacho:"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'FrmRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(913, 571)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LblArea)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmRecepcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepcion de Muestras"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxUbicacion.ResumeLayout(False)
        Me.GroupBoxUbicacion.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DgMuestrasDespacho, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CmdExport As System.Windows.Forms.Button
    Friend WithEvents CmdBorrar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblFechaDespacho As System.Windows.Forms.Label
    Friend WithEvents LblIdDespacho As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cmdagregar As System.Windows.Forms.Button
    Friend WithEvents DgMuestrasDespacho As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbDespacho As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbArea As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CmbTipoMuestra As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtOrdenServicio As System.Windows.Forms.TextBox
    Friend WithEvents TxtPreparacion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents CmdImprimir As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LblTotalMuestras As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtHasta As System.Windows.Forms.TextBox
    Friend WithEvents TxtDesde As System.Windows.Forms.TextBox
    Friend WithEvents DtFechaCaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtCajaHasta As System.Windows.Forms.TextBox
    Friend WithEvents TxtCajadesde As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtOtrasOrdenes As System.Windows.Forms.TextBox
    Friend WithEvents TxtDesde2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtHasta2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxUbicacion As System.Windows.Forms.GroupBox
    Friend WithEvents RbFinal As System.Windows.Forms.RadioButton
    Friend WithEvents RbInicio As System.Windows.Forms.RadioButton
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents CmbLetra As System.Windows.Forms.ComboBox
    Friend WithEvents Txtfinal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtInicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblValor As System.Windows.Forms.Label
    Friend WithEvents Cmdpesarlote As System.Windows.Forms.Button
    Friend WithEvents CmdFinalizar As System.Windows.Forms.Button
End Class

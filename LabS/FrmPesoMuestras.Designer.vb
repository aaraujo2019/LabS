<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesoMuestras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPesoMuestras))
        Me.LblPorHumedad = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBuscarMuestra = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPBandeja = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPSeco = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPHumedo = New System.Windows.Forms.TextBox()
        Me.TxtMuestra = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblArea = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbDespacho = New System.Windows.Forms.ComboBox()
        Me.DtFechaMuestra = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtDespacho = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtPrevio = New System.Windows.Forms.PictureBox()
        Me.lblphanterior = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblpsanterior = New System.Windows.Forms.Label()
        Me.lblmanterior = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblpbanterior = New System.Windows.Forms.Label()
        Me.lblphumanterior = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BgwBDu = New System.ComponentModel.BackgroundWorker()
        Me.BtnCargarEnBd = New System.Windows.Forms.PictureBox()
        Me.BtSiguiente = New System.Windows.Forms.PictureBox()
        Me.BtonGardar = New System.Windows.Forms.PictureBox()
        Me.BtonConFecha = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBuscarMuestra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BtPrevio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCargarEnBd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtSiguiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtonGardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtonConFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblPorHumedad
        '
        Me.LblPorHumedad.AutoSize = True
        Me.LblPorHumedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPorHumedad.Location = New System.Drawing.Point(665, 37)
        Me.LblPorHumedad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPorHumedad.Name = "LblPorHumedad"
        Me.LblPorHumedad.Size = New System.Drawing.Size(96, 26)
        Me.LblPorHumedad.TabIndex = 57
        Me.LblPorHumedad.Text = "0000000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(668, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "% de Humedad:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.PictureBuscarMuestra)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblPorHumedad)
        Me.GroupBox1.Controls.Add(Me.TxtPBandeja)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtPSeco)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtPHumedo)
        Me.GroupBox1.Controls.Add(Me.TxtMuestra)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 183)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(830, 94)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Muestra"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
        Me.Label10.Location = New System.Drawing.Point(766, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 26)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "%"
        '
        'PictureBuscarMuestra
        '
        Me.PictureBuscarMuestra.Image = Global.LabS.My.Resources.Resources.buscar_buscar_ampliar_icono_6707_96
        Me.PictureBuscarMuestra.Location = New System.Drawing.Point(133, 37)
        Me.PictureBuscarMuestra.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBuscarMuestra.Name = "PictureBuscarMuestra"
        Me.PictureBuscarMuestra.Size = New System.Drawing.Size(25, 25)
        Me.PictureBuscarMuestra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBuscarMuestra.TabIndex = 58
        Me.PictureBuscarMuestra.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(225, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Peso de Bandeja:"
        '
        'TxtPBandeja
        '
        Me.TxtPBandeja.Enabled = False
        Me.TxtPBandeja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPBandeja.Location = New System.Drawing.Point(227, 38)
        Me.TxtPBandeja.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPBandeja.Name = "TxtPBandeja"
        Me.TxtPBandeja.Size = New System.Drawing.Size(102, 26)
        Me.TxtPBandeja.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(523, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Peso Seco:"
        '
        'TxtPSeco
        '
        Me.TxtPSeco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPSeco.Location = New System.Drawing.Point(525, 38)
        Me.TxtPSeco.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPSeco.Name = "TxtPSeco"
        Me.TxtPSeco.Size = New System.Drawing.Size(98, 26)
        Me.TxtPSeco.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(367, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Peso Humedo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(16, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Muestra"
        '
        'TxtPHumedo
        '
        Me.TxtPHumedo.Enabled = False
        Me.TxtPHumedo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPHumedo.Location = New System.Drawing.Point(369, 38)
        Me.TxtPHumedo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPHumedo.Name = "TxtPHumedo"
        Me.TxtPHumedo.Size = New System.Drawing.Size(102, 26)
        Me.TxtPHumedo.TabIndex = 2
        '
        'TxtMuestra
        '
        Me.TxtMuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMuestra.Location = New System.Drawing.Point(18, 38)
        Me.TxtMuestra.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMuestra.Name = "TxtMuestra"
        Me.TxtMuestra.Size = New System.Drawing.Size(107, 26)
        Me.TxtMuestra.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(302, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(244, 27)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Laboratorio Quimico"
        '
        'LblArea
        '
        Me.LblArea.AutoSize = True
        Me.LblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblArea.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblArea.Location = New System.Drawing.Point(130, 49)
        Me.LblArea.Name = "LblArea"
        Me.LblArea.Size = New System.Drawing.Size(71, 13)
        Me.LblArea.TabIndex = 52
        Me.LblArea.Text = "Laboratorio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Departamento:"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblUsuario.Location = New System.Drawing.Point(130, 22)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(71, 13)
        Me.LblUsuario.TabIndex = 50
        Me.LblUsuario.Text = "Laboratorio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Id. Usuario:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.cmbDespacho)
        Me.GroupBox2.Controls.Add(Me.DtFechaMuestra)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LblUsuario)
        Me.GroupBox2.Controls.Add(Me.LblArea)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(830, 106)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Usuario:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(633, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(149, 13)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "Seleccione Orden de Trabajo:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LabS.My.Resources.Resources.LogoGranColombiaGoldSmall
        Me.PictureBox1.Location = New System.Drawing.Point(632, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'cmbDespacho
        '
        Me.cmbDespacho.FormattingEnabled = True
        Me.cmbDespacho.Location = New System.Drawing.Point(632, 79)
        Me.cmbDespacho.Name = "cmbDespacho"
        Me.cmbDespacho.Size = New System.Drawing.Size(158, 21)
        Me.cmbDespacho.TabIndex = 62
        '
        'DtFechaMuestra
        '
        Me.DtFechaMuestra.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtFechaMuestra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaMuestra.Location = New System.Drawing.Point(133, 75)
        Me.DtFechaMuestra.Margin = New System.Windows.Forms.Padding(2)
        Me.DtFechaMuestra.Name = "DtFechaMuestra"
        Me.DtFechaMuestra.Size = New System.Drawing.Size(122, 20)
        Me.DtFechaMuestra.TabIndex = 59
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(28, 79)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 65
        Me.Label19.Text = "Fecha:"
        '
        'TxtDespacho
        '
        Me.TxtDespacho.BackColor = System.Drawing.Color.White
        Me.TxtDespacho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDespacho.Enabled = False
        Me.TxtDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDespacho.Location = New System.Drawing.Point(644, 155)
        Me.TxtDespacho.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDespacho.Name = "TxtDespacho"
        Me.TxtDespacho.Size = New System.Drawing.Size(158, 25)
        Me.TxtDespacho.TabIndex = 61
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.BtPrevio)
        Me.GroupBox3.Controls.Add(Me.lblphanterior)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.lblpsanterior)
        Me.GroupBox3.Controls.Add(Me.lblmanterior)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.lblpbanterior)
        Me.GroupBox3.Controls.Add(Me.lblphumanterior)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 281)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(830, 119)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Muestra Anterior:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label12.Location = New System.Drawing.Point(780, 53)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 25)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(666, 36)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "%Humedad:"
        '
        'BtPrevio
        '
        Me.BtPrevio.Image = Global.LabS.My.Resources.Resources.previo1
        Me.BtPrevio.Location = New System.Drawing.Point(756, -19)
        Me.BtPrevio.Margin = New System.Windows.Forms.Padding(2)
        Me.BtPrevio.Name = "BtPrevio"
        Me.BtPrevio.Size = New System.Drawing.Size(24, 13)
        Me.BtPrevio.TabIndex = 59
        Me.BtPrevio.TabStop = False
        '
        'lblphanterior
        '
        Me.lblphanterior.AutoSize = True
        Me.lblphanterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphanterior.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblphanterior.Location = New System.Drawing.Point(666, 53)
        Me.lblphanterior.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblphanterior.Name = "lblphanterior"
        Me.lblphanterior.Size = New System.Drawing.Size(96, 25)
        Me.lblphanterior.TabIndex = 67
        Me.lblphanterior.Text = "0000000"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label16.Location = New System.Drawing.Point(509, 36)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "Peso Seco:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label17.Location = New System.Drawing.Point(353, 36)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 13)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Peso Humedo:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label18.Location = New System.Drawing.Point(189, 36)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 13)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "Peso de Bandeja:"
        '
        'lblpsanterior
        '
        Me.lblpsanterior.AutoSize = True
        Me.lblpsanterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpsanterior.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblpsanterior.Location = New System.Drawing.Point(507, 53)
        Me.lblpsanterior.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpsanterior.Name = "lblpsanterior"
        Me.lblpsanterior.Size = New System.Drawing.Size(96, 25)
        Me.lblpsanterior.TabIndex = 61
        Me.lblpsanterior.Text = "0000000"
        '
        'lblmanterior
        '
        Me.lblmanterior.AutoSize = True
        Me.lblmanterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmanterior.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblmanterior.Location = New System.Drawing.Point(26, 53)
        Me.lblmanterior.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblmanterior.Name = "lblmanterior"
        Me.lblmanterior.Size = New System.Drawing.Size(96, 25)
        Me.lblmanterior.TabIndex = 60
        Me.lblmanterior.Text = "0000000"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(23, 36)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Muestra:"
        '
        'lblpbanterior
        '
        Me.lblpbanterior.AutoSize = True
        Me.lblpbanterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpbanterior.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblpbanterior.Location = New System.Drawing.Point(187, 53)
        Me.lblpbanterior.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpbanterior.Name = "lblpbanterior"
        Me.lblpbanterior.Size = New System.Drawing.Size(96, 25)
        Me.lblpbanterior.TabIndex = 59
        Me.lblpbanterior.Text = "0000000"
        '
        'lblphumanterior
        '
        Me.lblphumanterior.AutoSize = True
        Me.lblphumanterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphumanterior.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblphumanterior.Location = New System.Drawing.Point(351, 53)
        Me.lblphumanterior.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblphumanterior.Name = "lblphumanterior"
        Me.lblphumanterior.Size = New System.Drawing.Size(96, 25)
        Me.lblphumanterior.TabIndex = 58
        Me.lblphumanterior.Text = "0000000"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(686, 401)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Exportar a BD"
        '
        'BgwBDu
        '
        '
        'BtnCargarEnBd
        '
        Me.BtnCargarEnBd.Image = Global.LabS.My.Resources.Resources.CargarEnBD
        Me.BtnCargarEnBd.Location = New System.Drawing.Point(696, 417)
        Me.BtnCargarEnBd.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCargarEnBd.Name = "BtnCargarEnBd"
        Me.BtnCargarEnBd.Size = New System.Drawing.Size(54, 57)
        Me.BtnCargarEnBd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCargarEnBd.TabIndex = 60
        Me.BtnCargarEnBd.TabStop = False
        '
        'BtSiguiente
        '
        Me.BtSiguiente.Image = Global.LabS.My.Resources.Resources._next
        Me.BtSiguiente.Location = New System.Drawing.Point(796, 437)
        Me.BtSiguiente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtSiguiente.Name = "BtSiguiente"
        Me.BtSiguiente.Size = New System.Drawing.Size(24, 19)
        Me.BtSiguiente.TabIndex = 59
        Me.BtSiguiente.TabStop = False
        '
        'BtonGardar
        '
        Me.BtonGardar.Image = CType(resources.GetObject("BtonGardar.Image"), System.Drawing.Image)
        Me.BtonGardar.Location = New System.Drawing.Point(552, 417)
        Me.BtonGardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtonGardar.Name = "BtonGardar"
        Me.BtonGardar.Size = New System.Drawing.Size(55, 55)
        Me.BtonGardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtonGardar.TabIndex = 41
        Me.BtonGardar.TabStop = False
        '
        'BtonConFecha
        '
        Me.BtonConFecha.Image = Global.LabS.My.Resources.Resources.microsoft_office_excel1
        Me.BtonConFecha.Location = New System.Drawing.Point(623, 417)
        Me.BtonConFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.BtonConFecha.Name = "BtonConFecha"
        Me.BtonConFecha.Size = New System.Drawing.Size(53, 55)
        Me.BtonConFecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtonConFecha.TabIndex = 4
        Me.BtonConFecha.TabStop = False
        '
        'FrmPesoMuestras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(864, 491)
        Me.Controls.Add(Me.TxtDespacho)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnCargarEnBd)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtSiguiente)
        Me.Controls.Add(Me.BtonGardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtonConFecha)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmPesoMuestras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peso de Muestras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBuscarMuestra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.BtPrevio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCargarEnBd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtSiguiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtonGardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtonConFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblPorHumedad As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtonGardar As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPBandeja As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPSeco As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPHumedo As System.Windows.Forms.TextBox
    Friend WithEvents TxtMuestra As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblArea As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBuscarMuestra As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtonConFecha As System.Windows.Forms.PictureBox
    Friend WithEvents DtFechaMuestra As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtDespacho As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblpsanterior As System.Windows.Forms.Label
    Friend WithEvents lblmanterior As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblpbanterior As System.Windows.Forms.Label
    Friend WithEvents lblphumanterior As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblphanterior As System.Windows.Forms.Label
    Friend WithEvents BtSiguiente As System.Windows.Forms.PictureBox
    Friend WithEvents BtPrevio As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCargarEnBd As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BgwBDu As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmbDespacho As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class

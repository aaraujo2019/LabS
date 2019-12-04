
'Imports LabS.FrmRecepcion
Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.SqlClient
'Imports Z_Lab.FrmPrincipal
Imports System.Drawing.Text
Imports System.Drawing.Printing
Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports LabS.FrmRecepcion
Imports System.Windows.Forms
Imports System.Configuration

Public Class FrmRecepcion

    Private WithEvents printDocument As New Printing.PrintDocument()
    Dim WithEvents documento As Printing.PrintDocument
    Private WithEvents PrintDoc As PrintDocument
    Private fuente As Font
    ' Dim Cn As New SqlConnection("Server=mercurio\gcg;uid=sa;pwd=BdZandor123*;database=ZandorCapital")
    Dim CnSql As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("StringConexion").ToString())
    Dim Cn As New OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\DbZandor\DbZandor.accdb; Persist Security Info=False;")
    Private dt As DataTable
    Private dtenvios As DataTable
    Dim Da As New OleDb.OleDbDataAdapter
    ' Dim Cmd As New SqlCommand
    Dim cmd As New System.Data.OleDb.OleDbCommand
    Dim Dataset As DataSet
    Dim cnStr As String
    Dim conn As New ADODB.Connection()
    Dim rsarea As New ADODB.Recordset()
    Dim rsmuestras As New ADODB.Recordset
    Dim rsdespachos As New ADODB.Recordset
    Dim rsdespachomuestras As New ADODB.Recordset
    Dim rscantidadmuestras As New ADODB.Recordset
    Dim rstBusqueda As New ADODB.Recordset()
    Dim rstlabsumit As New ADODB.Recordset()
    Dim total_envios As Double
    Dim rsmuestra As New ADODB.Recordset()

    Private Sub Cmdagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmdagregar.Click
        If cmbDespacho.Text = "" Or cmbDespacho.Text = "Seleccione" Or IsNothing(cmbDespacho.SelectedItem) Then
            MsgBox("Por Favor Seleccione Id de despacho para poder asignar las muestras.")
            Exit Sub
        End If

        Dim sqlConnectiondb As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\DbZandor\DbZandor.accdb; Persist Security Info=False;")
        Dim cmd As New System.Data.OleDb.OleDbCommand
        cmd.CommandType = System.Data.CommandType.Text
        Dim valor, ordenmuestra As Integer

        ordenmuestra = CInt(LblTotalMuestras.Text)
        valor = CInt((TxtInicio.Text))
        While valor <= CInt(Txtfinal.Text)
            LblValor.Refresh()
            ordenmuestra = ordenmuestra + 1
            If CmbLetra.Text = "NO" Then
                LblValor.Text = CStr(valor)
            ElseIf CmbLetra.Text <> "NO" And RbInicio.Checked = True Then
                LblValor.Text = CmbLetra.Text & CStr(valor)
            ElseIf CmbLetra.Text <> "NO" And RbFinal.Checked = True Then
                LblValor.Text = CStr(valor) & CmbLetra.Text
            End If
            BuscarMuestra()
            cmd.CommandText = "INSERT INTO Lab_muestras (Muestra,IdDespacho , OrdenLab, TipoMuestra , CodPreparacion , CodServicio , fecha ) VALUES ( '" & (LblValor.Text) & "' , '" & (cmbDespacho.Text) & "' , '" & (ordenmuestra) & "' ,'" & (CmbTipoMuestra.Text) & "' , '" & (TxtPreparacion.Text) & "' , '" & (TxtOrdenServicio.Text) & "' , '" & CDate(DtFecha.Text) & "' )"
            cmd.Connection = sqlConnectiondb
            sqlConnectiondb.Open()
            cmd.ExecuteNonQuery()
            sqlConnectiondb.Close()
            'LblValor.Text = CStr(valor)
            valor = valor + 1
            ' cmd.Parameters.AddWithValue("@IdDespacho", cmbDespacho.Text)
            ' cmd.Parameters.AddWithValue("@Fecha", CDate(DtFecha.Text))
            ' cmd.Parameters.AddWithValue("@Muestra", Convert.ToString(CmbArea.Text))
        End While
        Llenar_DataGridViewDgSamplesDay()
        Llenar_TotalMuestras()
    End Sub

    Private Sub BuscarMuestra()
        cnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Public\DbZandor\DbZandor.accdb"
        conn.Open(cnStr)
        rsmuestra = conn.Execute("SELECT * FROM Lab_Muestras WHERE (Muestra = '" & (LblValor.Text) & "') and (IdDespacho = '" & (cmbDespacho.Text) & "')")
        If rsmuestra.EOF = False Then
            MsgBox("la muestra:" & LblValor.Text & "ya se encuentra en la orden.")
            conn.Close()
        End If
        conn.Close()
    End Sub

    Private Sub cmbDespacho_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDespacho.SelectedIndexChanged
        LblIdDespacho.Text = cmbDespacho.Text
        cargarDespacho()
        Llenar_DataGridViewDgSamplesDay()
        Llenar_TotalMuestras()
    End Sub

    Private Sub Llenar_TotalMuestras()
        Dim registros As Decimal

        For Each dRow As DataGridViewRow In DgMuestrasDespacho.Rows
            If (dRow.Cells.Item("Muestra").Value) IsNot Nothing Then
                If IsDBNull(dRow.Cells.Item("Muestra").Value) Then
                Else
                    registros = registros + 1
                End If
            End If
        Next dRow

        LblTotalMuestras.Text = CStr(Format(registros, "0"))
        Me.DgMuestrasDespacho.ReadOnly = False
    End Sub

    Private Sub cargar_Clientes()
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT      *   FROM RfProyecto  ORDER BY IdProyecto"
            .Connection = Cn
        End With
        Da.SelectCommand = cmd
        dtenvios = New DataTable
        Da.Fill(dtenvios)

        With CmbArea
            .DataSource = dtenvios
            .DisplayMember = "IdProyecto"
            .ValueMember = "IdProyecto"
            .SelectedValue = 0
        End With
        'total_envios = dtenvios.
        total_envios = dtenvios.Rows.Count
    End Sub

    Private Sub cargar_lista_ordenes()
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT  Lab_Orden.Fecha, * FROM Lab_Orden ORDER BY Lab_Orden.Consec DESC "
            .Connection = Cn
        End With
        Da.SelectCommand = cmd
        dtenvios = New DataTable
        Da.Fill(dtenvios)

        With cmbDespacho
            .DataSource = dtenvios
            .DisplayMember = "IdDespacho"
            .ValueMember = "IdDespacho"
            .SelectedValue = 0
            .Text = "Seleccione"
        End With

        total_envios = dtenvios.Rows.Count
    End Sub

    Private Sub cargararea()
        ' cnStr = "Provider=SQLNCLI10;Initial Catalog=ZandorCapital;Data Source=mercurio; User ID=sa;Password=BdZandor123*;"
        cnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Public\DbZandor\DbZandor.accdb"
        conn.Open(cnStr)
        rsarea = conn.Execute("SELECT * FROM usuario WHERE (IdUsusario = '" & (LblUsuario.Text) & "')")
        If rsarea.EOF = True Then
            Me.LblArea.Text = "NO"
        Else
            Me.LblArea.Text = CStr((rsarea.Fields("Area").Value))
        End If
        conn.Close()
    End Sub

    Private Sub cargar_TipoMuestras()
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM RfTipoMuestra"
            .Connection = Cn
        End With

        Da.SelectCommand = cmd
        dt = New DataTable
        Da.Fill(dt)

        With CmbTipoMuestra
            .DataSource = dt
            .DisplayMember = "IdTipoMuestra"
            .ValueMember = "IdTipoMuestra"
            .SelectedValue = 1
            .Text = "ROCA"
        End With
    End Sub

    Private Sub Llenar_DataGridViewDgSamplesDay()
        Cn.Open()
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter
        Dim sql As String
        sql = " SELECT IdDespacho, Muestra , TipoMuestra ,CodPreparacion ,CodServicio, OrdenLab  FROM Lab_Muestras  WHERE IdDespacho = '" & (LblIdDespacho.Text) & "' order by OrdenLab"
        da.SelectCommand = New OleDb.OleDbCommand(sql, Cn)
        da.Fill(ds)
        Cn.Close()

        Dim dt As DataTable = ds.Tables(0)
        DgMuestrasDespacho.DataSource = dt
        DgMuestrasDespacho.AutoResizeColumns()
        Me.DgMuestrasDespacho.Columns("IdDespacho").Visible = False
        ' DgMuestrasDespacho.Columns("Consec").Visible = False
        ' DgMuestrasDespacho.Columns("IdDespacho").HeaderText = "Muestra"
        ' DgMuestrasDespacho.Columns("Muestra").HeaderText = "Muestra"
        ' DgMuestrasDespacho.Columns("Consec").HeaderText = "Hora Final"
        ' DgMuestrasDespacho.Columns("CodigoServicio").HeaderText = "Codigo de Servicio"
        ' DgMuestrasDespacho.Columns("Elementos").HeaderText = "Elementos"
        Me.DgMuestrasDespacho.ReadOnly = False
    End Sub

    Private Sub cargarDespacho()
        cnStr = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\DbZandor\DbZandor.accdb; Persist Security Info=False;"
        conn.Open(cnStr)
        rsdespachos = conn.Execute(" SELECT * FROM   Lab_Orden WHERE (IdDespacho = '" & (LblIdDespacho.Text) & "')      ")
        If rsdespachos.EOF <> True Then
            'DtFecha.Value = CDate(rsdespachos.Fields("Fecha").Value)
            LblFechaDespacho.Text = CStr(rsdespachos.Fields("Fecha").Value)
            If IsDBNull(rsdespachos.Fields("Comentarios").Value) Then
                TxtObservaciones.Text = ""
            Else
                TxtObservaciones.Text = CStr(rsdespachos.Fields("Comentarios").Value)
            End If
        End If
        conn.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FrmRecepcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.LblUsuario.Text = FrmPrincipal.LblUserName.Text
        ' Me.LblUserName.Text = Login.TxtUsuario.Text
        documento = New Printing.PrintDocument
        cargar_lista_ordenes()
        cargar_Clientes()
        ' cargar_MuestrasFinal()
        'cargar_Muestrasinicio()
        cargar_TipoMuestras()
    End Sub

    Private Sub CmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBorrar.Click
        If MsgBox("Esta Seguro Que Desea Eliminar Las Muestras del Despacho?", vbYesNo, "") = vbYes Then
            Dim sqlConnectiondb As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\DbZandor\DbZandor.accdb; Persist Security Info=False;")
            Dim cmd As New System.Data.OleDb.OleDbCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "delete from Lab_Muestras WHERE IdDespacho = @IdDespacho"
            'cmd.Parameters.AddWithValue("@area", "")
            ' cmd.Parameters.AddWithValue("@OrdenLab", 0)
            cmd.Parameters.AddWithValue("@IdDespacho", LblIdDespacho.Text)
            ' cmd.Parameters.AddWithValue("@TipoMuestra", "")
            'cmd.Parameters.AddWithValue("@CodPreparacion", "")
            ' cmd.Parameters.AddWithValue("@CodServicio", TxtOrdenServicio.Text)
            cmd.Connection = sqlConnectiondb
            sqlConnectiondb.Open()
            cmd.ExecuteNonQuery()
            sqlConnectiondb.Close()
            Llenar_DataGridViewDgSamplesDay()
            Llenar_TotalMuestras()
        End If
    End Sub

    Private Sub DtFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtFecha.ValueChanged

    End Sub

    Private Sub CmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExport.Click
        If cmbDespacho.Text = "" Then
            MsgBox("Por Favor Realice Busqueda de una muestra o de un despacho")
        Else
            cnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Public\DbZandor\DbZandor.accdb"
            conn.Open(cnStr)
            ''" & Format(fecha1, "dd/mm/yyyy") & "'
            rsmuestra = conn.Execute(" SELECT * FROM Lab_Muestras  WHERE IdDespacho= '" & (cmbDespacho.Text) & "'  order by OrdenLab")
            Dim objExcel As Microsoft.Office.Interop.Excel.Application
            objExcel = New Microsoft.Office.Interop.Excel.Application
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            objExcel.Workbooks.Open("C:\Users\Public\DbZandor\consultas\GZC_ReporteRecepcion.xlsx")
            Dim recorrido As Integer
            recorrido = 8
            objExcel.Visible = False
            Do While Not rsmuestra.EOF
                With objExcel
                    hoja = CType(.Sheets("Recepcion"), Microsoft.Office.Interop.Excel.Worksheet)
                    If recorrido = 8 Then
                        hoja.Cells(2, 3) = CStr((rsmuestra.Fields("IdDespacho").Value))
                        hoja.Cells(3, 3) = CStr((rsmuestra.Fields("Area").Value))
                        'hoja.Cells(1, 3) = CStr((rsmuestra.Fields("fecha").Value))
                    End If
                    ' hoja.Cells(recorrido, 1) = CStr((rsmuestra.Fields("fecha").Value))
                    hoja.Cells(recorrido, 1) = CStr((rsmuestra.Fields("muestra").Value))
                    hoja.Cells(recorrido, 2) = CStr((rsmuestra.Fields("TipoMuestra").Value))
                    hoja.Cells(recorrido, 3) = CStr((rsmuestra.Fields("CodPreparacion").Value))
                    hoja.Cells(recorrido, 4) = CStr((rsmuestra.Fields("CodServicio").Value))
                    hoja.Cells(4, 3) = CStr(recorrido - 7)
                    recorrido = recorrido + 1
                End With
                rsmuestra.MoveNext()
            Loop
            objExcel.Visible = True
            conn.Close()
        End If
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim sqlConnectiondb As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\DbZandor\DbZandor.accdb; Persist Security Info=False;")
        Dim cmd As New System.Data.OleDb.OleDbCommand
        cmd.CommandType = System.Data.CommandType.Text
        Dim mc As MatchCollection = Regex.Matches("Zandor Capital", "\w+")
        Dim iniciales As String = String.Empty
        For Each m As Match In mc
            iniciales &= m.Value.ToUpper.Chars(0)
        Next
        total_envios = cmbDespacho.Items.Count
        ' consulta sql si editar es falso 
        cmd.CommandText = "INSERT INTO Lab_Orden (  IdDespacho, Fecha, Departamento, Usuario) VALUES ( @IdDespacho , @Fecha, @Departamento , @Usuario)"
        cmd.Parameters.AddWithValue("@IdDespacho", iniciales + "-00" + CStr(total_envios + 1))
        LblIdDespacho.Text = iniciales + "-" + CStr(total_envios + 1)
        cmd.Parameters.AddWithValue("@Fecha", CDate(DtFecha.Text))
        cmd.Parameters.AddWithValue("@Departamento", Convert.ToString(CmbArea.Text))
        cmd.Parameters.AddWithValue("@Usuario", Convert.ToString(LblUsuario.Text))
        cmd.Connection = sqlConnectiondb
        sqlConnectiondb.Open()
        cmd.ExecuteNonQuery()
        sqlConnectiondb.Close()
        cargar_lista_ordenes()
        ' MsgBox(iniciales + "-000" + CStr(total_envios + 1))
    End Sub

    Private Sub CmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdImprimir.Click
        InitializePrintPreviewDialog()
        'printDocument.DocumentName = "C:\Users\Public\DbZandor\LogoGranColombiaGoldSmall.jpeg"
        Me.PrintPreviewDialog1.Document = documento
        AddHandler printDocument.EndPrint, AddressOf DocumentOnEndPrint
        Me.PrintPreviewDialog1.ShowDialog()
        RemoveHandler printDocument.EndPrint, AddressOf DocumentOnEndPrint
    End Sub

    Private Sub InitializePrintPreviewDialog()
        ' Inicializa el cuadro de diálogo PrintPreview.
        Me.PrintPreviewDialog1 = New PrintPreviewDialog()
        Me.PrintPreviewDialog1.ClientSize = New Size(400, 300)
        Me.PrintPreviewDialog1.Location = New Point(50, 50)
        Me.PrintPreviewDialog1.MinimumSize = New Size(37, 25)
        Me.PrintPreviewDialog1.UseAntiAlias = True
    End Sub
    Private Sub DocumentOnEndPrint(ByVal sender As Object, ByVal e As Printing.PrintEventArgs)

        If (e.PrintAction = Printing.PrintAction.PrintToPreview) Then
            ' La operación es de la vista previa del documento.
            ' Abandonamos el procedimiento.
            Return
        End If

        ' Cerramos el cuadro de diálogo de vista previa.
        PrintPreviewDialog1.Dispose()

        If (e.Cancel) Then
            ' Se ha cancelado la impresión.
            ' Abandonamos el procedimiento
            Return
        End If

        MessageBox.Show("Ha finalizado la impresión.")
        ' Ejecutar aquí el código de actualización de la base de datos.
        '
    End Sub

    Private Sub documento_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles documento.PrintPage
        Dim subString As String = Microsoft.VisualBasic.Left(LblFechaDespacho.Text, 5)
        e.Graphics.DrawString("Zandor Capital", New Font("Engravers MT", 14, FontStyle.Bold), Brushes.Black, 20, 3)
        Dim newImage As Image = Image.FromFile("C:\Users\Public\DbZandor\LogoGranColombiaGoldSmall.jpg")
        e.Graphics.DrawImage(newImage, 270, 5, 70, 30)
        Dim rect As New Rectangle(5, 40, 370, 250)
        'rect = New Rectangle(10, 150, 50, 20)
        e.Graphics.DrawRectangle(Pens.Black, rect)
        'e.Graphics.DrawString(cmbDespacho.Text, fuente, Brushes.Black, 45, 13)
        'e.Graphics.DrawString(CmbArea.Text, fuente, Brushes.Black, 45, 30)
        ' e.Graphics.DrawString(CmbTipoMuestra.Text, fuente, Brushes.Black, 45, 50)
        ' e.Graphics.DrawString(LblFechaDespacho.Text, fuente, Brushes.Black, 45, 70)
        'e.Graphics.DrawString(LblTotalMuestras.Text, fuente, Brushes.Black, 45, 90)
        ' e.Graphics.DrawString(CmbTipoMuestra.Text, fuente, Brushes.Black, 45, 110)
        e.Graphics.DrawString("No. de Orden:", New Font("Albertus Extra Bold", 14, FontStyle.Bold), Brushes.Black, 5, 50)
        e.Graphics.DrawString(cmbDespacho.Text, New Font("Arial", 13, FontStyle.Bold), Brushes.Black, 200, 55)
        e.Graphics.DrawString("-----------------------------------------------------------------------", New Font("Arial", 3, FontStyle.Bold), Brushes.Black, 200, 70)

        e.Graphics.DrawString("Otras Ordenes:", New Font("Albertus Extra Bold", 14, FontStyle.Bold), Brushes.Gray, 5, 90)
        e.Graphics.DrawString(TxtOtrasOrdenes.Text, New Font("Arial", 13, FontStyle.Bold), Brushes.Black, 200, 95)
        e.Graphics.DrawString("-----------------------------------------------------------------------", New Font("Arial", 3, FontStyle.Bold), Brushes.Black, 200, 110)

        e.Graphics.DrawString("Cliente:", New Font("Albertus Extra Bold", 11, FontStyle.Bold), Brushes.Black, 5, 130)
        e.Graphics.DrawString(CmbArea.Text, New Font("Arial", 13, FontStyle.Bold), Brushes.Black, 200, 135)
        e.Graphics.DrawString("-----------------------------------------------------------------------", New Font("Arial", 3, FontStyle.Bold), Brushes.Black, 200, 150)

        'e.Graphics.DrawString("Tipo de Muestra:", New Font("Albertus Extra Bold", 14, FontStyle.Bold), Brushes.Black, 5, 130)
        'e.Graphics.DrawString(CmbTipoMuestra.Text, New Font("Arial", 13, FontStyle.Bold), Brushes.Black, 200, 135)
        'e.Graphics.DrawString("-----------------------------------------------------------------------", New Font("Arial", 3, FontStyle.Bold), Brushes.Black, 200, 150)

        e.Graphics.DrawString("Intervalo:", New Font("Albertus Extra Bold", 14, FontStyle.Bold), Brushes.Black, 5, 170)
        e.Graphics.DrawString("Desde:", New Font("Albertus Extra Bold", 7, FontStyle.Bold), Brushes.Gray, 180, 165)
        e.Graphics.DrawString("Hasta:", New Font("Albertus Extra Bold", 7, FontStyle.Bold), Brushes.Gray, 270, 165)
        e.Graphics.DrawString("@", New Font("Albertus Extra Bold", 7, FontStyle.Bold), Brushes.Gray, 260, 165)

        e.Graphics.DrawString(TxtDesde.Text, New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 180, 175)
        e.Graphics.DrawString(TxtHasta.Text, New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 270, 175)

        e.Graphics.DrawString(TxtDesde2.Text, New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 180, 200)
        e.Graphics.DrawString(TxtHasta2.Text, New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 270, 200)
        ' e.Graphics.DrawString("-----------------------------------------------------------------------", New Font("Arial", 3, FontStyle.Bold), Brushes.Black, 200, 205)
        'Dim docToPrint As New Printing.PrintDocument
        ' PrintPreviewDialog1.Document = docToPrint
        'docToPrint.Print()

        e.Graphics.DrawString("# de Caja:", New Font("Albertus Extra Bold", 14, FontStyle.Bold), Brushes.Black, 5, 250)
        e.Graphics.DrawString(TxtCajadesde.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 20, 270)
        e.Graphics.DrawString("De:", New Font("Albertus Extra Bold", 7, FontStyle.Bold), Brushes.Gray, 35, 270)
        e.Graphics.DrawString(TxtCajaHasta.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 270)
        ' e.Graphics.DrawString("-----------------------------------------------------------------------", New Font("Arial", 3, FontStyle.Bold), Brushes.Black, 200, 270)

        'e.Graphics.DrawString("#:", New Font("Albertus Extra Bold", 8, FontStyle.Bold), Brushes.Black, 200, 205)
        ' e.Graphics.DrawString("De:", New Font("Albertus Extra Bold", 8, FontStyle.Bold), Brushes.Black, 270, 205)
        ' e.Graphics.DrawString("@", New Font("Albertus Extra Bold", 7, FontStyle.Bold), Brushes.Black, 260, 205)

        'ggg
        e.Graphics.DrawString("Fecha:", New Font("Albertus Extra Bold", 14, FontStyle.Bold), Brushes.Black, 200, 250)
        ' e.Graphics.DrawString(Microsoft.VisualBasic.Leftcdate((DtFechaCaja.Text, 10)), New Font("Arial", 13, FontStyle.Bold), Brushes.Black, 200, 135)
        e.Graphics.DrawString(CStr(CDate(DtFechaCaja.Text)), New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 200, 270)
        '  e.Graphics.DrawString("-----------------------------------------------------------------------", New Font("Arial", 3, FontStyle.Bold), Brushes.Black, 200, 260)
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDesde.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub CmbLetra_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbLetra.SelectedIndexChanged
        If CmbLetra.Text <> "NO" Then
            GroupBoxUbicacion.Enabled = True
        Else
            GroupBoxUbicacion.Enabled = False
        End If
    End Sub

    Private Sub Cmdpesarlote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmdpesarlote.Click
        My.Forms.FrmPesoMuestras.ShowDialog()
    End Sub

    Private Sub CmbTipoMuestra_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTipoMuestra.SelectedIndexChanged

    End Sub
End Class
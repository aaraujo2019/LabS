'Option Explicit On
'Option Strict On
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient


Public Class FrmPesoMuestras
    Dim Cn As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("StringConexion").ToString())
    Dim Cnt = New OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\DbZandor\DbZandor.accdb;Persist Security Info=False;")
    Private dt As DataTable
    Dim Da As New SqlDataAdapter
    Dim Cmd As New SqlCommand
    Dim cmd1 As New OleDb.OleDbCommand
    Dim Dataset As DataSet
    Dim cnStr As String
    Dim conn As New ADODB.Connection()
    Dim rsarea As New ADODB.Recordset()
    Dim rsmuestra As New ADODB.Recordset()
    Dim rspeso As New ADODB.Recordset()
    Dim d1 As New OleDb.OleDbDataAdapter
    Dim Da1 As New OleDb.OleDbDataAdapter
    Private dtenvios As DataTable

    Private Sub FrmLabPreparacion_Load(sender As Object, e As EventArgs)

        Me.TxtDespacho.Text = FrmRecepcion.cmbDespacho.Text
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Lab_Muestras WHERE IdDespacho = '" & TxtDespacho.Text & "'  order by OrdenLab"
            .Connection = Cn
        End With

        Da.SelectCommand = Cmd
        dt = New DataTable
        Da.Fill(dt)

        If dt.Rows.Count > 0 Then
            TxtMuestra.Text = dt.Rows(0)(0).ToString()
            BuscarMuestra()
        Else
            MsgBox("La muestra no existe")
            TxtPBandeja.Clear()
            TxtPHumedo.Clear()
            TxtPSeco.Clear()
            TxtPBandeja.Enabled = False
            TxtPHumedo.Enabled = False
            LblPorHumedad.Text = "00000"
            TxtDespacho.Text = ""
        End If
    End Sub
    Private Sub TxtMuestra_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            BuscarMuestra()
        End If
    End Sub

    Private Sub actualizarfinal()
        Dim porchumedad As Double
        Dim Cmd As New SqlCommand

        If IsNumeric(TxtPHumedo.Text) And IsNumeric(TxtPBandeja.Text) And IsNumeric(TxtPSeco.Text) Then
            porchumedad = 100 * ((CDbl(TxtPHumedo.Text) - CDbl(TxtPBandeja.Text)) - (CDbl(TxtPSeco.Text) - CDbl(TxtPBandeja.Text))) / (CDbl(TxtPHumedo.Text) - CDbl(TxtPBandeja.Text))
            LblPorHumedad.Text = CStr(porchumedad)
        Else
            porchumedad = 0
        End If

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "UPDATE Lab_Muestras SET PesoHumedoMuestra= '" & (TxtPHumedo.Text) & "', PesoSecoMuestra= '" & (TxtPSeco.Text) & "' , PesoBandejaMuestra= '" & (TxtPBandeja.Text) & "' ,fecha= '" & DtFechaMuestra.Value & "' , PorcHumedad= '" & porchumedad & "'  WHERE muestra = '" & TxtMuestra.Text & "'"
            .Connection = Cn
        End With
        Cmd.ExecuteNonQuery()
    End Sub

    Private Sub picturebox6_enfoque(sender As Object, e As EventArgs) Handles PictureBuscarMuestra.MouseHover
        PictureBuscarMuestra.BorderStyle = BorderStyle.Fixed3D
        Me.ToolTip1.SetToolTip(PictureBuscarMuestra, "Buscar la Muestra")
    End Sub
    Private Sub picturebox5_quitarenfoque(sender As Object, e As EventArgs) Handles BtonGardar.MouseLeave
        BtonGardar.BorderStyle = BorderStyle.FixedSingle
    End Sub
    Private Sub picturebox5_enfoque(sender As Object, e As EventArgs) Handles BtonGardar.MouseHover
        BtonGardar.BorderStyle = BorderStyle.Fixed3D
        Me.ToolTip1.SetToolTip(BtonGardar, "Guarda Cambios")
    End Sub
    Private Sub picturebox6_quitarenfoque(sender As Object, e As EventArgs) Handles PictureBuscarMuestra.MouseLeave
        PictureBuscarMuestra.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub pictureboxExcel_quitarenfoque(sender As Object, e As EventArgs) Handles BtonConFecha.MouseLeave
        BtonConFecha.BorderStyle = BorderStyle.FixedSingle
    End Sub
    Private Sub pictureboxExcel_enfoque(sender As Object, e As EventArgs) Handles BtonConFecha.MouseHover
        BtonConFecha.BorderStyle = BorderStyle.Fixed3D
        Me.ToolTip1.SetToolTip(BtonConFecha, "Exportar a excel")
    End Sub

    Private Sub pictureboxAnterior_enfoque(sender As Object, e As EventArgs) Handles BtPrevio.MouseHover
        BtPrevio.BorderStyle = BorderStyle.Fixed3D
        Me.ToolTip1.SetToolTip(BtPrevio, "Muestra anterior")
    End Sub
    Private Sub pictureboxAnterior_quitarenfoque(sender As Object, e As EventArgs) Handles BtPrevio.MouseLeave
        BtPrevio.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub pictureboxSiguiente_enfoque(sender As Object, e As EventArgs) Handles BtSiguiente.MouseHover
        BtSiguiente.BorderStyle = BorderStyle.Fixed3D
        Me.ToolTip1.SetToolTip(BtSiguiente, "Muestra Siguiente")
    End Sub
    Private Sub pictureboxSiguiente_quitarenfoque(sender As Object, e As EventArgs) Handles BtSiguiente.MouseLeave
        BtSiguiente.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub pictureboxExportar_enfoque(sender As Object, e As EventArgs) Handles BtnCargarEnBd.MouseHover
        BtnCargarEnBd.BorderStyle = BorderStyle.Fixed3D
        Me.ToolTip1.SetToolTip(BtnCargarEnBd, "Exportar despacho a Base de Datos")
    End Sub
    Private Sub pictureboxExportar_quitarenfoque(sender As Object, e As EventArgs) Handles BtnCargarEnBd.MouseLeave
        BtnCargarEnBd.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Protected Sub txtBOX1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtPBandeja.TextChanged
        If Microsoft.VisualBasic.Left(TxtPBandeja.Text, 3) = "S S" And Microsoft.VisualBasic.Right(TxtPBandeja.Text, 1) = "g" Then
            Dim texto As String
            texto = Replace(TxtPBandeja.Text, " ", "")
            texto = Replace(texto, "S", "")
            texto = Replace(texto, "g", "")
            texto = Replace(texto, "  ", "")
            TxtPBandeja.Text = texto
            If IsNumeric(TxtPBandeja.Text) Then
                TxtPHumedo.Focus()
            Else
                MsgBox("Por Favor vuelve a Ingresar el Peso de la Bandeja")
                TxtPBandeja.Clear()
                Exit Sub
                TxtPBandeja.Focus()
            End If
        End If
    End Sub

    Protected Sub TxtPHumedo_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtPHumedo.TextChanged
        If Microsoft.VisualBasic.Left(TxtPHumedo.Text, 3) = "S S" And Microsoft.VisualBasic.Right(TxtPHumedo.Text, 1) = "g" Then
            Dim texto As String
            texto = Replace(TxtPHumedo.Text, " ", "")
            texto = Replace(texto, "S", "")
            texto = Replace(texto, "g", "")
            texto = Replace(texto, "  ", "")
            TxtPHumedo.Text = texto

            If IsNumeric(TxtPHumedo.Text) Then
                TxtPBandeja.Focus()
            Else
                MsgBox("Por Favor vuelve a Ingresar el Peso de la Muestra Humeda")
                TxtPHumedo.Clear()
                Exit Sub
                TxtPHumedo.Focus()
            End If

            ' S = Microsoft.VisualBasic.Left(TxtPHumedo.Text, Len(TxtPHumedo.Text) - 2)
            ' S = S.Trim()
            ' MsgBox(S)
            ' S = Microsoft.VisualBasic.Right(S, Len(S) - 11)
            actualizarfinal()
            BuscarSiguiente()
        End If
    End Sub

    Protected Sub TxtPSeco_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtPSeco.TextChanged
        If Microsoft.VisualBasic.Left(TxtPSeco.Text, 3) = "S S" And Microsoft.VisualBasic.Right(TxtPSeco.Text, 1) = "g" Then
            Dim texto As String
            texto = Replace(TxtPSeco.Text, " ", "")
            texto = Replace(texto, "S", "")
            texto = Replace(texto, "g", "")
            texto = Replace(texto, "  ", "")
            TxtPSeco.Text = texto

            If IsNumeric(TxtPSeco.Text) Then
                TxtPSeco.Focus()
            Else
                MsgBox("Por Favor vuelve a Ingresar el Peso de la Muestra Seca")
                TxtPSeco.Clear()
                Exit Sub
                TxtPSeco.Focus()
            End If

            actualizarfinal()
            BuscarSiguiente()
            TxtPSeco.Focus()
        End If
    End Sub

    Private Sub MostrarAnterior()
        lblmanterior.Text = TxtMuestra.Text
        lblpbanterior.Text = TxtPBandeja.Text
        lblphumanterior.Text = TxtPHumedo.Text
        lblpsanterior.Text = TxtPSeco.Text
        lblphanterior.Text = CStr(Math.Round(CDbl(LblPorHumedad.Text), 2))
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBuscarMuestra.Click
        BuscarMuestra()
    End Sub

    Private Sub BtonGardar_Click(sender As Object, e As EventArgs) Handles BtonGardar.Click
        actualizarfinal()
        MsgBox("Actualizado")
    End Sub

    Private Sub Guardarpeso()
        'Dim porchumedad As Double
        If TxtMuestra.Text = "" Or TxtPBandeja.Text = "" Or TxtPHumedo.Text = "" Then
            MsgBox("Por Favor Diligencie los campos obligatorios.")
            Exit Sub
        End If

        Try
            Dim Cn As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("StringConexion").ToString())
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE Lab_Muestras SET PesoBandejaMuestra = @PesoBandejaMuestra, PesoHumedoMuestra= @PesoHumedoMuestra, PesoSecoMuestra = @PesoSecoMuestra , fecha=@fecha WHERE  Muestra = @Muestra"
            cmd.Parameters.AddWithValue("@Muestra", (TxtMuestra.Text))
            cmd.Parameters.AddWithValue("@PesoBandejaMuestra", (TxtPBandeja.Text))
            cmd.Parameters.AddWithValue("@PesoHumedoMuestra", (TxtPHumedo.Text))
            cmd.Parameters.AddWithValue("@PesoSecoMuestra", (TxtPSeco.Text))
            cmd.Parameters.AddWithValue("@fecha", Convert.ToDateTime(DtFechaMuestra.Text))
            cmd.Connection = Cn
            cmd.ExecuteNonQuery()
            TxtPBandeja.Enabled = False
            TxtPHumedo.Enabled = False
            MsgBox("Guardado")

        Catch ex As Exception
            ' Handle the exception.
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BuscarMuestra()

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Lab_Muestras WHERE Muestra = '" & (TxtMuestra.Text) & "' and IdDespacho = '" & (cmbDespacho.Text) & "'"
            .Connection = Cn
        End With

        Da.SelectCommand = Cmd
        dt = New DataTable
        Da.Fill(dt)

        If dt.Rows.Count > 0 Then
            If dt.Rows(0)(4).ToString() IsNot String.Empty Then
                Me.TxtPBandeja.Text = dt.Rows(0)(4).ToString()
            Else
                TxtPBandeja.Clear()
            End If
            If dt.Rows(0)(2).ToString() IsNot String.Empty Then
                Me.TxtPHumedo.Text = dt.Rows(0)(2).ToString()
            Else
                TxtPHumedo.Clear()
            End If
            If dt.Rows(0)(2).ToString() IsNot String.Empty Then
                Me.TxtPSeco.Text = dt.Rows(0)(3).ToString()
            Else
                TxtPSeco.Clear()
            End If
            If dt.Rows(0)(6).ToString() IsNot String.Empty Then
                'Format(LblPorHumedad, "0.00")
                Me.LblPorHumedad.Text = CStr(Math.Round(CDbl(dt.Rows(0)(6).ToString()), 2))
            Else
                LblPorHumedad.Text = "00000"
            End If

            If dt.Rows(0)(9).ToString() IsNot String.Empty Then
                'Format(LblPorHumedad, "0.00")
                Me.TxtDespacho.Text = dt.Rows(0)(9).ToString()
                TxtDespacho.BackColor = Color.White
            End If

            If dt.Rows(0)(9).ToString() = "0" Then
                MsgBox("No es posible continuar si la muestra no es asociada a un Idlab")
                TxtPBandeja.Clear()
                TxtPHumedo.Clear()
                TxtPSeco.Clear()
                TxtDespacho.BackColor = Color.YellowGreen
                LblPorHumedad.Text = "0000"
                TxtPBandeja.Enabled = False
                TxtPHumedo.Enabled = False
                TxtPSeco.Enabled = False
                conn.Close()
                Exit Sub
            End If

            TxtPBandeja.Enabled = True
            TxtPHumedo.Enabled = True
        Else
            MsgBox("La muestra no existe")
            TxtPBandeja.Clear()
            TxtPHumedo.Clear()
            TxtPSeco.Clear()
            TxtPBandeja.Enabled = False
            TxtPHumedo.Enabled = False
            LblPorHumedad.Text = "00000"
            TxtDespacho.Text = ""
        End If
    End Sub

    Private Sub BuscarSiguiente()
        Dim band As Boolean
        band = True

        lblmanterior.Text = TxtMuestra.Text
        lblpbanterior.Text = TxtPBandeja.Text
        lblphumanterior.Text = TxtPHumedo.Text
        lblpsanterior.Text = TxtPSeco.Text
        'lblphanterior.Text = LblPorHumedad.Text
        lblphanterior.Text = CStr(Math.Round(CDbl(LblPorHumedad.Text), 2))

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Lab_muestras WHERE IdDespacho= '" & (TxtDespacho.Text) & "'  order by OrdenLab"
            .Connection = Cn
        End With

        Da.SelectCommand = Cmd
        dt = New DataTable
        Da.Fill(dt)

        If dt.Rows.Count > 0 Then
            For index = 0 To dt.Rows.Count
                If dt.Rows(0)(0).ToString() = TxtMuestra.Text Then
                    index += index

                    If index = dt.Rows.Count Then
                        MsgBox("Fin")
                        conn.Close()
                        band = False
                        Exit For
                    Else
                        TxtMuestra.Text = dt.Rows(0)(0).ToString()
                        conn.Close()
                        BuscarMuestra()
                        band = False
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub ConsultaFecha()

        If TxtDespacho.Text = "" Then
            MsgBox("Por Favor Realice Busqueda de una muestra o de un despacho")
        Else

            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM Lab_Muestras WHERE IdDespacho= '" & (TxtDespacho.Text) & "'  order by OrdenLab"
                .Connection = Cn
            End With

            Da.SelectCommand = Cmd
            dt = New DataTable
            Da.Fill(dt)

            Dim objExcel As Microsoft.Office.Interop.Excel.Application
            objExcel = New Microsoft.Office.Interop.Excel.Application
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            objExcel.Workbooks.Open("C:\Users\Public\DbZandor\consultas\GZC_ConsultaMuestras.xlsx")
            Dim recorrido As Integer
            recorrido = 13
            objExcel.Visible = False

            If dt.Rows.Count > 0 Then
                For index = 0 To dt.Rows.Count
                    With objExcel
                        hoja = CType(.Sheets("Muestras"), Microsoft.Office.Interop.Excel.Worksheet)

                        If recorrido = 13 Then
                            hoja.Cells(8, 3) = dt.Rows(0)(9).ToString()
                            hoja.Cells(6, 1) = dt.Rows(0)(5).ToString()
                        End If

                        If dt.Rows(0)(1).ToString() IsNot String.Empty Then
                            hoja.Cells(recorrido, 1) = dt.Rows(0)(1).ToString()
                        End If

                        hoja.Cells(recorrido, 2) = dt.Rows(0)(0).ToString()
                        If dt.Rows(0)(4).ToString() IsNot String.Empty Then
                            hoja.Cells(recorrido, 3) = dt.Rows(0)(4).ToString()
                        End If

                        If dt.Rows(0)(2).ToString() IsNot String.Empty Then
                            hoja.Cells(recorrido, 4) = dt.Rows(0)(2).ToString()
                        End If

                        If dt.Rows(0)(3).ToString() IsNot String.Empty Then
                            hoja.Cells(recorrido, 5) = dt.Rows(0)(3).ToString()
                        End If

                        If dt.Rows(0)(6).ToString() IsNot String.Empty Then
                            hoja.Cells(recorrido, 6) = dt.Rows(0)(6).ToString()
                        End If

                        recorrido = recorrido + 1
                    End With
                Next

                objExcel.Visible = True
            End If
        End If
    End Sub

    Private Sub BtonConFecha_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtonConFecha.Click
        ConsultaFecha()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As Object, ByVal e As EventArgs)
        actualizarfinal()
    End Sub

    Private Sub Button1_Click_2(ByVal sender As Object, ByVal e As EventArgs)
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Lab_muestras WHERE IdDespacho= '" & (TxtDespacho.Text) & "') order by OrdenLab"
            .Connection = Cn
        End With

        Da.SelectCommand = Cmd
        dt = New DataTable
        Da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Me.LblArea.Text = dt.Rows(0)(5).ToString()
        Else
            Me.LblArea.Text = "NO"
        End If
    End Sub

    Private Sub FrmPesoMuestras_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        cargar_lista_ordenes()
    End Sub

    Private Sub BtnCargarEnBd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCargarEnBd.Click
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Lab_muestras WHERE IdDespacho= '" & TxtDespacho.Text & "' order by OrdenLab"
            .Connection = Cn
        End With

        Da.SelectCommand = Cmd
        dt = New DataTable
        Da.Fill(dt)

        If dt.Rows.Count > 0 Then
            cargarenbd()
        Else
            borrarenBD()
            cargarenbd()
        End If

        MsgBox("OK")
    End Sub

    Private Sub cargar_lista_ordenes()
        Dim oledbcommand1 As OleDb.OleDbCommand = Me.cmd1
        oledbcommand1.CommandType = CommandType.Text
        oledbcommand1.CommandText = "SELECT Lab_Orden.IdDespacho  FROM Lab_Orden ORDER BY Lab_Orden.Consec DESC "
        oledbcommand1.Connection = Me.Cnt
        oledbcommand1 = Nothing

        Me.Da1.SelectCommand = Me.cmd1
        Me.dtenvios = New DataTable()
        Me.Da1.Fill(Me.dtenvios)

        With cmbDespacho
            .DataSource = dtenvios
            .DisplayMember = "IdDespacho"
            .ValueMember = "IdDespacho"
            .SelectedValue = 0
            .Text = "Seleccione"
        End With

    End Sub

    Sub cargarenbd()
        Dim sqlConnectiondb As New OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\DbZandor\DbZandor.accdb; Persist Security Info=False;")
        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Lab_Muestras where IdDespacho = '" & TxtDespacho.Text & "'"
        cmd.Connection = sqlConnectiondb
        sqlConnectiondb.Open()
        Dim resultados As OleDb.OleDbDataReader
        resultados = cmd.ExecuteReader
        ' conexion SQL
        Dim cmdSQL As New SqlCommand
        cmdSQL.CommandType = CommandType.Text
        cmdSQL.CommandText = "insert  into Lab_Muestras (Muestra , Fecha , PesoHumedoMuestra , PesoSecoMuestra , PesoBandejaMuestra , Area , PorcHumedad , OrdenLab , OrdenDespacho , IdDespacho , TipoMuestra , CodPreparacion , CodServicio , PesoMuestra) Values (@Muestra ,  @Fecha , @PesoHumedoMuestra , @PesoSecoMuestra , @PesoBandejaMuestra , @Area , @PorcHumedad , @OrdenLab , @OrdenDespacho , @IdDespacho , @TipoMuestra , @CodPreparacion , @CodServicio , @PesoMuestra)  "
        cmdSQL.Connection = Cn
        Cn.Open()

        While resultados.Read
            Try
                cmdSQL.Parameters.AddWithValue("@Muestra", resultados.Item("Muestra"))
                cmdSQL.Parameters.AddWithValue("@Fecha", resultados.Item("Fecha"))
                cmdSQL.Parameters.AddWithValue("@PesoHumedoMuestra", resultados.Item("PesoHumedoMuestra"))
                cmdSQL.Parameters.AddWithValue("@PesoSecoMuestra", resultados.Item("PesoSecoMuestra"))
                cmdSQL.Parameters.AddWithValue("@PesoBandejaMuestra", resultados.Item("PesoBandejaMuestra"))
                cmdSQL.Parameters.AddWithValue("@Area", resultados.Item("Area"))
                cmdSQL.Parameters.AddWithValue("@OrdenLab", resultados.Item("OrdenLab"))
                cmdSQL.Parameters.AddWithValue("@PorcHumedad", resultados.Item("PorcHumedad"))
                cmdSQL.Parameters.AddWithValue("@OrdenDespacho", resultados.Item("OrdenDespacho"))
                cmdSQL.Parameters.AddWithValue("@IdDespacho", resultados.Item("IdDespacho"))
                cmdSQL.Parameters.AddWithValue("@TipoMuestra", resultados.Item("TipoMuestra"))
                cmdSQL.Parameters.AddWithValue("@CodPreparacion", resultados.Item("CodPreparacion"))
                cmdSQL.Parameters.AddWithValue("@CodServicio", resultados.Item("CodServicio"))
                cmdSQL.Parameters.AddWithValue("@PesoMuestra", resultados.Item("PesoMuestra"))

                cmdSQL.ExecuteNonQuery()
                cmdSQL.Parameters.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End While
        sqlConnectiondb.Close()
        Cn.Close()
    End Sub

    Sub borrarenBD()
        Dim cmdSQL As New SqlCommand
        cmdSQL.CommandType = CommandType.Text
        cmdSQL.CommandText = "DELETE FROM Lab_Muestras WHERE IdDespacho = '" & TxtDespacho.Text & "' "
        cmdSQL.Connection = Cn
        Cn.Open()
        cmdSQL.ExecuteNonQuery()
        Cn.Close()
    End Sub

    Private Sub frmPrincipal_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.BgwBDu.RunWorkerAsync(2000)
        e.Cancel = False
        'Dim x As Integer

        ' x = msgbox("estas seguro de cerrar", MsgBoxStyle.OkCancel, "cerrar")

        ' If x = 2 Then
        'e.Cancel = True
        'End If

    End Sub

    Private Sub BgwBDu_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgwBDu.DoWork
        Try
            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM Lab_muestras WHERE IdDespacho= '" & TxtDespacho.Text & "' order by OrdenLab"
                .Connection = Cn
            End With

            Da.SelectCommand = Cmd
            dt = New DataTable
            Da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cargarenbd()
            Else
                borrarenBD()
                cargarenbd()
            End If
        Catch Exp As Exception
            MessageBox.Show(Exp.Message, ". Error en el servidor.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cn.Close()
        End Try
    End Sub
End Class

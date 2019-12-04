Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Data.OleDb
Public Class FrmCrearId
    Dim cnStr As String
    Dim conn As New ADODB.Connection()
    Dim rsmuestra As New ADODB.Recordset()

    Private Sub FrmCrearId_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub picturebox6_enfoque(sender As System.Object, e As System.EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        ' Me.ToolTip1.SetToolTip(BtonGardar, "Guarda Cambios")
    End Sub
    Private Sub PictureBox2_quitarenfoque(sender As System.Object, e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub CmdCrear_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

        Dim valor As Integer
        valor = TxtValorInicio.Text
        While valor <= CInt(TxtVlorFinal.Text)
            LblValor.Text = CStr(valor)
            valor = valor + 1
        End While
        buscardisponibilidad()

        'TxtValorInicio.Text = CDbl(TxtValorInicio.Text) + 1
        'MaskedTextBox1
    End Sub
    Protected Sub txtBOX1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim KeyAscii As Integer
        If (KeyAscii <= Asc("0") Or KeyAscii > Asc("9")) And KeyAscii <> 8 Then
            KeyAscii = 0
        Else
            MsgBox("NO")
        End If
    End Sub
    Private Sub Text1_KeyPress(KeyAscii As Integer)
        If (KeyAscii <= Asc("0") Or KeyAscii > Asc("9")) And KeyAscii <> 8 Then
            KeyAscii = 0
        Else

        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbLetra.SelectedIndexChanged
        If CmbLetra.Text <> "NO" Then
            GroupBoxUbicacion.Enabled = True
        Else
            GroupBoxUbicacion.Enabled = False
        End If
    End Sub

    Public Sub buscardisponibilidad()
        cnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Public\DbZandor\DbZandor.accdb"
        conn.Open(cnStr)
        ''" & Format(fecha1, "dd/mm/yyyy") & "'
        If CmbLetra.Text = "NO" Then
            rsmuestra = conn.Execute(" SELECT * FROM         Lab_Muestras  WHERE muestra>= '" & (TxtValorInicio.Text) & "'   and  muestra <= '" & (TxtVlorFinal.Text) & "'   order by OrdenLab    ")
        ElseIf CmbLetra.Text <> "NO" And RbInicio.Checked = True Then
            rsmuestra = conn.Execute(" SELECT * FROM         Lab_Muestras  WHERE muestra>= '" & (CmbLetra.Text) & "' & '" & (TxtValorInicio.Text) & "'   and  muestra <= '" & (CmbLetra.Text) & "' & '" & (TxtVlorFinal.Text) & "'   order by OrdenLab    ")
        ElseIf CmbLetra.Text <> "NO" And RbFinal.Checked = True Then
            rsmuestra = conn.Execute(" SELECT * FROM         Lab_Muestras  WHERE muestra>=  '" & (TxtValorInicio.Text) & "' & '" & (CmbLetra.Text) & "'  and  muestra <= '" & (TxtVlorFinal.Text) & "'  & '" & (CmbLetra.Text) & "'   order by OrdenLab    ")
        End If

        If (rsmuestra.EOF = True) And (rsmuestra.BOF = True) Then
            MsgBox("   si se puede ingresar")
            Dim valor As Integer
            valor = TxtValorInicio.Text
            While valor <= CInt(TxtVlorFinal.Text)
                Dim sqlConnectiondb As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\DbZandor\DbZandor.accdb; Persist Security Info=False;")
                Dim cmd As New System.Data.OleDb.OleDbCommand
                cmd.CommandType = System.Data.CommandType.Text
                cmd.CommandText = "INSERT INTO Lab_Muestras(Muestra)values(@Muestra)"

                If CmbLetra.Text = "NO" Then
                    cmd.Parameters.AddWithValue("@Muestra", CStr(valor))
                ElseIf CmbLetra.Text <> "NO" And RbInicio.Checked = True Then
                    cmd.Parameters.AddWithValue("@Muestra", CmbLetra.Text & CStr(valor))
                ElseIf CmbLetra.Text <> "NO" And RbFinal.Checked = True Then
                    cmd.Parameters.AddWithValue("@Muestra", CStr(valor) & CmbLetra.Text)

                End If
                cmd.Connection = sqlConnectiondb
                sqlConnectiondb.Open()
                cmd.ExecuteNonQuery()
                sqlConnectiondb.Close()
                LblValor.Text = CStr(valor)
                valor = valor + 1
            End While
        Else
            MsgBox("No se puede ingresar una de las muestras del Rango ya existen.")
        End If
        conn.Close()
    End Sub

    Private Sub CmdExaminar_Click(sender As System.Object, e As System.EventArgs) Handles CmdExaminar.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Todos los archivos (*.xls)|*.xls"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

            If .ShowDialog = Windows.Forms.DialogResult.OK Then


                txtruta.Text = .FileName
            End If
        End With
        If txtruta.Text = "" Then

        Else
            Try
                Dim nombreHoja As String = ObtenerNombrePrimeraHoja(txtruta.Text)
                ' MessageBox.Show(nombreHoja)
                Cargar(DgResultado, txtruta.Text, nombreHoja)

            Catch ex As OleDbException
                MessageBox.Show(ex.Message)
            End Try

        End If
        'AVERIGUAR NOMBRE DE HOJA
    End Sub

    Private Function ObtenerNombrePrimeraHoja(ByVal rutaLibro As String) As String
        Dim app As Excel.Application = Nothing
        Try
            app = New Excel.Application()
            Dim wb As Excel.Workbook = app.Workbooks.Open(rutaLibro)
            Dim ws As Excel.Worksheet = CType(wb.Worksheets.Item(1), Excel.Worksheet)
            Dim name As String = ws.Name
            ws = Nothing
            wb.Close()
            wb = Nothing
            Return name
        Catch ex As Exception
            Throw
        Finally
            If (Not app Is Nothing) Then _
                app.Quit()
            Runtime.InteropServices.Marshal.ReleaseComObject(app)
            app = Nothing
        End Try
    End Function

    Sub Cargar( _
ByVal dgView As DataGridView, _
ByVal SLibro As String, _
ByVal sHoja As String)

        'HDR=YES : Con encabezado  
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                           "Data Source=" & SLibro & ";" & _
                           "Extended Properties=""Excel 8.0;HDR=YES"""
        Try
            ' cadena de conexión  
            Dim cn As New OleDbConnection(cs)

            If Not System.IO.File.Exists(SLibro) Then
                MsgBox("No se encontró el Libro: " & _
                        SLibro, MsgBoxStyle.Critical, _
                        "Ruta inválida")
                Exit Sub
            End If

            ' se conecta con la hoja sheet 1  
            Dim dAdapter As New OleDbDataAdapter("Select * From [" & sHoja & "$]", cs)

            Dim datos As New DataSet

            ' agrega los datos  
            dAdapter.Fill(datos)

            With DgResultado
                ' llena el DataGridView  
                .DataSource = datos.Tables(0)

            End With
        Catch oMsg As Exception
            MsgBox(oMsg.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BtnCargarExcel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCargarExcel.Click
        Dim AppExcel As Excel.Application
        Dim LibroExcel As Excel.Workbook
        Dim HojaExcel As Excel.Worksheet
        Dim celda As String

        cnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Public\DbZandor\DbZandor.accdb"
        Dim FicheroExcel As String
            Dim NombreHoja As String
        Dim sqlConnectiondb As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\DbZandor\DbZandor.accdb; Persist Security Info=False;")
        Dim cmd As New System.Data.OleDb.OleDbCommand
            cmd.CommandType = System.Data.CommandType.Text
            FicheroExcel = txtruta.Text
            NombreHoja = ObtenerNombrePrimeraHoja(txtruta.Text)
            AppExcel = New Excel.Application
            LibroExcel = AppExcel.Workbooks.Open(FicheroExcel)
            HojaExcel = CType(LibroExcel.Sheets(NombreHoja), Excel.Worksheet)
            Dim limite As Integer
            limite = 200
        For i As Integer = 1 To 10000
            Try
                celda = "A" & i
                conn.Open(cnStr)
                Dim samples As String
                samples = Convert.ToString(HojaExcel.Range("A" & i).Value)
                cmd.CommandText = "INSERT INTO Lab_Muestras (Muestra )VALUES('" & samples & "'  )"
                If (HojaExcel.Range("A" & i).Value) = Nothing Then
                    sqlConnectiondb.Close()
                    conn.Close()
                    MsgBox("Importacion Finalizada")
                    Exit For
                End If
                cmd.Connection = sqlConnectiondb
                sqlConnectiondb.Open()
                cmd.ExecuteNonQuery()
                sqlConnectiondb.Close()
                conn.Close()

            Catch ex As Exception
                conn.Close()
                ' Handle the exception.
                MessageBox.Show("Error", Me.Text, _
      MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Next


    End Sub

 
End Class
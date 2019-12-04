
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class FrmPesoMuestraLab
    Private dt As DataTable
    Dim Da As New SqlDataAdapter
    Public Cmd As New SqlCommand
    Dim Dataset As DataSet
    Dim cnStr As String
    Dim conn As New ADODB.Connection()
    Dim rsarea As New ADODB.Recordset()
    Dim rsmuestra As New ADODB.Recordset()
    Dim rspeso As New ADODB.Recordset()
    Dim d1 As New OleDb.OleDbDataAdapter
    Dim Cn As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("StringConexion").ToString())


    Private Sub PictureBuscarMuestra_Click(sender As System.Object, e As System.EventArgs) Handles PictureBuscarMuestra.Click
        BuscarMuestra()
    End Sub


    Private Sub BuscarMuestra()
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Lab_Muestras WHERE (Muestra = '" & (TxtMuestra.Text) & "')"
            .Connection = Cn
        End With

        Da.SelectCommand = Cmd
        dt = New DataTable
        Da.Fill(dt)

        If dt.Rows.Count > 0 Then
            If dt.Rows(0)(13).ToString IsNot String.Empty Then
                Me.TxtPSeco.Text = dt.Rows(0)(13).ToString
            Else
                TxtPSeco.Clear()
            End If

            If dt.Rows(0)(9).ToString IsNot String.Empty Then
                'Format(LblPorHumedad, "0.00")
                Me.TxtDespacho.Text = dt.Rows(0)(9).ToString IsNot String.Empty
            Else
                TxtDespacho.Text = "00000"
            End If
        Else
            MsgBox("La muestra no existe")
            TxtPSeco.Clear()
        End If
    End Sub

    Private Sub BuscarSiguiente()
        Dim band As Boolean
        band = True

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Lab_muestras WHERE IdDespacho= '" & (TxtDespacho.Text) & "' order by OrdenLab"
            .Connection = Cn
        End With

        Da.SelectCommand = Cmd
        dt = New DataTable
        Da.Fill(dt)

        If dt.Rows.Count > 0 Then
            For index = 0 To dt.Rows.Count
                If dt.Rows(index)(0).ToString() = TxtMuestra.Text Then
                    index += 1
                    If index = dt.Rows.Count Then
                        MsgBox("Fin")
                        band = False
                        Exit For
                    Else
                        TxtMuestra.Text = dt.Rows(index)(0).ToString()
                        conn.Close()
                        BuscarMuestra()
                        band = False
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub actualizarfinal()
        Dim Cmd As New SqlCommand
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "UPDATE Lab_Muestras SET PesoMuestra = '" & (TxtPSeco.Text) & "',fecha= '" & DtFechaMuestra.Value & "' WHERE muestra = '" & TxtMuestra.Text & "'"
            .Connection = Cn
        End With

        Cmd.ExecuteNonQuery()
    End Sub

    Private Sub ConsultaFecha()
        If TxtDespacho.Text = "" Then
            MsgBox("Por Favor Realice Busqueda de una muestra o de un despacho")
        Else
            Dim fecha1 As Date
            Dim fecha2 As DateTime
            fecha1 = CDate(DtFecha1.Value)
            fecha2 = (DtFecha2.Value)

            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM Lab_Muestras WHERE IdDespacho= '" & (TxtDespacho.Text) & "' order by OrdenLab"
                .Connection = Cn
            End With

            Da.SelectCommand = Cmd
            dt = New DataTable
            Da.Fill(dt)

            Dim objExcel As Microsoft.Office.Interop.Excel.Application
            objExcel = New Microsoft.Office.Interop.Excel.Application
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            objExcel.Workbooks.Open("C:\Users\Public\DbZandor\consultas\GZC_ConsultaMuestras_Peso.xlsx")
            Dim recorrido As Integer
            recorrido = 13
            objExcel.Visible = False

            If dt.Rows.Count > 0 Then
                For index = 0 To dt.Rows.Count
                    With objExcel
                        hoja = CType(.Sheets("Muestras"), Microsoft.Office.Interop.Excel.Worksheet)
                        If recorrido = 13 Then
                            hoja.Cells(8, 3) = dt.Rows(0)(9).ToString
                            hoja.Cells(5, 3) = dt.Rows(0)(5).ToString
                        End If

                        If dt.Rows(0)(1).ToString IsNot String.Empty Then
                            hoja.Cells(recorrido, 1) = dt.Rows(0)(1).ToString
                        End If

                        hoja.Cells(recorrido, 2) = dt.Rows(0)(0).ToString
                        If dt.Rows(0)(13).ToString IsNot String.Empty Then
                            hoja.Cells(recorrido, 3) = dt.Rows(0)(13).ToString
                        End If
                        recorrido = recorrido + 1
                    End With
                Next

                objExcel.Visible = True
            End If
        End If
    End Sub

    Private Sub TxtPSeco_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtPSeco.TextChanged
        If Microsoft.VisualBasic.Left(TxtPSeco.Text, 3) = "S S" And Microsoft.VisualBasic.Right(TxtPSeco.Text, 1) = "g" Then
            Dim texto As String
            texto = Replace(TxtPSeco.Text, " ", "")
            texto = Replace(texto, "S", "")
            texto = Replace(texto, "g", "")
            texto = Replace(texto, "  ", "")
            TxtPSeco.Text = texto
            actualizarfinal()
            BuscarSiguiente()
            TxtPSeco.Focus()
        End If
    End Sub

    Private Sub BtonConFecha_Click(sender As System.Object, e As System.EventArgs) Handles BtonConFecha.Click
        ConsultaFecha()
    End Sub

    Private Sub BtonGardar_Click(sender As System.Object, e As System.EventArgs) Handles BtonGardar.Click

    End Sub
End Class
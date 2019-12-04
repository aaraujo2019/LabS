Imports System.Configuration
Imports System.Data.SqlClient
Public Class FrmConsultarOrdenes
    Dim cnStr As String
    Dim conn As New ADODB.Connection()
    Dim rsmuestra As New ADODB.Recordset()
    Dim Cmd As New SqlCommand
    Dim Da As New SqlDataAdapter
    Private dDatos As DataTable

    Private Sub FrmConsultarOrdenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub TxtName_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtId.KeyPress
    '    Dim resultado = String.Concat("ZC-00", TxtId.Text)
    '    TxtOrdenId.Text = String.Concat("ZC-00", TxtId.Text)
    'End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If TxtOrdenId.Text = "" Then
            MsgBox("Por Favor Realice Busqueda de un despacho")
        Else
            Dim Cn As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("StringConexion").ToString())

            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM Lab_Muestras  WHERE IdDespacho= '" & (TxtOrdenId.Text) & "'  order by OrdenLab"
                .Connection = Cn
            End With

            Da.SelectCommand = Cmd
            dDatos = New DataTable
            Da.Fill(dDatos)

            Dim objExcel As Microsoft.Office.Interop.Excel.Application
            objExcel = New Microsoft.Office.Interop.Excel.Application
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            objExcel.Workbooks.Open("C:\Users\Public\DbZandor\consultas\GZC_ConsultaMuestras.xlsx")
            Dim recorrido As Integer
            recorrido = 13
            objExcel.Visible = False

            For index = 0 To dDatos.Rows.Count
                With objExcel
                    hoja = CType(.Sheets("Muestras"), Microsoft.Office.Interop.Excel.Worksheet)
                    If recorrido = 13 Then
                        hoja.Cells(8, 3) = dDatos.Rows(index)(9).ToString()
                        hoja.Cells(5, 3) = dDatos.Rows(index)(5).ToString()
                    End If

                    If dDatos.Rows(0)(1).ToString() IsNot String.Empty Then
                        hoja.Cells(recorrido, 1) = dDatos.Rows(index)(1).ToString()
                    End If

                    hoja.Cells(recorrido, 2) = dDatos.Rows(index)(0).ToString()
                    If dDatos.Rows(index)(4).ToString() IsNot String.Empty Then
                        hoja.Cells(recorrido, 3) = dDatos.Rows(index)(4).ToString()
                    End If

                    If dDatos.Rows(index)(2).ToString() IsNot String.Empty Then
                        hoja.Cells(recorrido, 4) = dDatos.Rows(index)(2).ToString()
                    End If

                    If dDatos.Rows(index)(3).ToString() IsNot String.Empty Then
                        hoja.Cells(recorrido, 5) = dDatos.Rows(index)(3).ToString()
                    End If

                    If dDatos.Rows(index)(6).ToString() IsNot String.Empty Then
                        hoja.Cells(recorrido, 6) = dDatos.Rows(index)(6).ToString()
                    End If
                    recorrido = recorrido + 1
                End With
            Next

            objExcel.Visible = True
        End If
    End Sub

    Private Sub BtonConFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtonConFecha.Click
        Dim fecha1 As DateTime
        Dim fecha2 As DateTime
        fecha1 = (DtFecha1.Value)
        fecha2 = (DtFecha2.Value)

        Dim Cn As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("StringConexion").ToString())

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Lab_Muestras WHERE fecha>= '" & Format(fecha1, "yyyy/MM/dd") & "' order by IdDespacho"
            .Connection = Cn
        End With

        Da.SelectCommand = Cmd
        dDatos = New DataTable
        Da.Fill(dDatos)

        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        objExcel = New Microsoft.Office.Interop.Excel.Application
        Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
        objExcel.Workbooks.Open("C:\Users\Public\DbZandor\consultas\GZC_ConsultaMuestras_Peso.xlsx")
        Dim recorrido As Integer
        recorrido = 13
        objExcel.Visible = False

        For index = 0 To dDatos.Rows.Count
            With objExcel
                hoja = CType(.Sheets("Muestras"), Microsoft.Office.Interop.Excel.Worksheet)
                If recorrido = 13 Then
                    hoja.Cells(5, 3) = dDatos.Rows(index)(5).ToString()
                End If

                If dDatos.Rows(0)(1).ToString() IsNot String.Empty Then
                    hoja.Cells(recorrido, 1) = dDatos.Rows(index)(1).ToString()
                End If

                hoja.Cells(recorrido, 2) = dDatos.Rows(index)(0).ToString()
                hoja.Cells(recorrido, 3) = dDatos.Rows(index)(9).ToString()
                hoja.Cells(recorrido, 4) = dDatos.Rows(index)(5).ToString()

                If dDatos.Rows(index)(4).ToString() IsNot String.Empty Then
                    hoja.Cells(recorrido, 5) = dDatos.Rows(index)(4).ToString()
                End If

                If dDatos.Rows(index)(2).ToString() IsNot String.Empty Then
                    hoja.Cells(recorrido, 6) = dDatos.Rows(index)(2).ToString()
                End If

                If dDatos.Rows(index)(3).ToString() IsNot String.Empty Then
                    hoja.Cells(recorrido, 7) = dDatos.Rows(index)(3).ToString()
                End If

                If dDatos.Rows(index)(6).ToString() IsNot String.Empty Then
                    hoja.Cells(recorrido, 8) = dDatos.Rows(index)(6).ToString()
                End If
                recorrido = recorrido + 1
            End With
        Next

        objExcel.Visible = True
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TxtId_Leave(sender As Object, e As EventArgs) Handles TxtId.Leave
        Dim resultado = String.Concat("ZC-00", TxtId.Text)
        TxtOrdenId.Text = String.Concat("ZC-00", TxtId.Text)
    End Sub
End Class
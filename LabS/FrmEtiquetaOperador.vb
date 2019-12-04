Option Explicit On
Option Strict On
'Imports Z_Lab.FrmPrincipal
Imports System.Drawing.Printing

Public Class FrmEtiquetaOperador
    Private WithEvents printDocument As New Printing.PrintDocument()
    Dim WithEvents documento As Printing.PrintDocument
    Private WithEvents PrintDoc As PrintDocument
    Private fuente As Font

    Private Sub CmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdImprimir.Click
        InitializePrintPreviewDialog()
        'printDocument.DocumentName = "C:\Users\Public\DbZandor\LogoGranColombiaGoldSmall.jpeg"
        Me.PrintPreviewDialog1.Document = documento
        AddHandler PrintDocument.EndPrint, AddressOf DocumentOnEndPrint
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
            '
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


    Private Sub printDocument_PrintPage(ByVal sender As Object,
                                    ByVal e As Printing.PrintPageEventArgs) _
                                Handles documento.PrintPage
    End Sub

    Private Sub documento_PrintPage2(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles documento.PrintPage
        Dim subString As String = Microsoft.VisualBasic.Left(DtFechaCaja.Text, 5)
        e.Graphics.DrawString("Zandor Capital", New Font("Engravers MT", 14, FontStyle.Bold), Brushes.Black, 20, 3)
        Dim newImage As Image = Image.FromFile("C:\Users\Public\DbZandor\LogoGranColombiaGoldSmall.jpg")
        e.Graphics.DrawImage(newImage, 270, 5, 70, 30)
        Dim rect As New Rectangle(5, 40, 370, 250)
        'rect = New Rectangle(10, 150, 50, 20)
        e.Graphics.DrawRectangle(Pens.Black, rect)
        'e.Graphics.DrawString(cmbDespacho.Text, fuente, Brushes.Black, 45, 13)
        'e.Graphics.DrawString(CmbArea.Text, fuente, Brushes.Black, 45, 30)
        'e.Graphics.DrawString(CmbTipoMuestra.Text, fuente, Brushes.Black, 45, 50)
        'e.Graphics.DrawString(LblFechaDespacho.Text, fuente, Brushes.Black, 45, 70)
        'e.Graphics.DrawString(LblTotalMuestras.Text, fuente, Brushes.Black, 45, 90)
        'e.Graphics.DrawString(CmbTipoMuestra.Text, fuente, Brushes.Black, 45, 110)
        e.Graphics.DrawString("Fecha:", New Font("Albertus Extra Bold", 14, FontStyle.Bold), Brushes.Black, 5, 50)
        If ChkIn.Checked = True Then
            e.Graphics.DrawString(CStr(CDate(DtFechaCaja.Text)), New Font("Arial", 13, FontStyle.Bold), Brushes.Black, 200, 55)
        Else

        End If

        e.Graphics.DrawString("-----------------------------------------------------------------------", New Font("Arial", 3, FontStyle.Bold), Brushes.Black, 200, 70)
        e.Graphics.DrawString("Turno", New Font("Albertus Extra Bold", 14, FontStyle.Bold), Brushes.Gray, 5, 90)
        e.Graphics.DrawString(CmbTurno.Text, New Font("Arial", 13, FontStyle.Bold), Brushes.Black, 200, 95)
        e.Graphics.DrawString("-----------------------------------------------------------------------", New Font("Arial", 3, FontStyle.Bold), Brushes.Black, 200, 110)

        e.Graphics.DrawString("Muestra:", New Font("Albertus Extra Bold", 14, FontStyle.Bold), Brushes.Black, 5, 210)
        e.Graphics.DrawString(TxtMuestra.Text, New Font("Arial", 13, FontStyle.Bold), Brushes.Black, 200, 210)
        e.Graphics.DrawString("-----------------------------------------------------------------------", New Font("Arial", 3, FontStyle.Bold), Brushes.Black, 200, 150)

        e.Graphics.DrawString("Ubicacion:", New Font("Albertus Extra Bold", 14, FontStyle.Bold), Brushes.Black, 5, 170)
        e.Graphics.DrawString(TxtUbicacion.Text, New Font("Arial", 13, FontStyle.Bold), Brushes.Black, 200, 170)
        e.Graphics.DrawString("-----------------------------------------------------------------------", New Font("Arial", 3, FontStyle.Bold), Brushes.Black, 200, 150)

        'e.Graphics.DrawString("Tipo de Muestra:", New Font("Albertus Extra Bold", 14, FontStyle.Bold), Brushes.Black, 5, 130)
        'e.Graphics.DrawString(CmbTipoMuestra.Text, New Font("Arial", 13, FontStyle.Bold), Brushes.Black, 200, 135)
        'e.Graphics.DrawString("-----------------------------------------------------------------------", New Font("Arial", 3, FontStyle.Bold), Brushes.Black, 200, 150)

        e.Graphics.DrawString("Operador:", New Font("Albertus Extra Bold", 14, FontStyle.Bold), Brushes.Black, 5, 130)
        'e.Graphics.DrawString("Desde:", New Font("Albertus Extra Bold", 7, FontStyle.Bold), Brushes.Gray, 180, 165)
        ' e.Graphics.DrawString("Hasta:", New Font("Albertus Extra Bold", 7, FontStyle.Bold), Brushes.Gray, 270, 165)
        ' e.Graphics.DrawString("@", New Font("Albertus Extra Bold", 7, FontStyle.Bold), Brushes.Gray, 260, 165)

        e.Graphics.DrawString(TxtOperador.Text, New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 180, 130)
        ' e.Graphics.DrawString(TxtHasta.Text, New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 270, 175)

        'e.Graphics.DrawString(TxtMuestra.Text, New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 180, 200)
        ' e.Graphics.DrawString(TxtHasta2.Text, New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 270, 200)
        ' e.Graphics.DrawString("-----------------------------------------------------------------------", New Font("Arial", 3, FontStyle.Bold), Brushes.Black, 200, 205)
        'Dim docToPrint As New Printing.PrintDocument
        ' PrintPreviewDialog1.Document = docToPrint
        'docToPrint.Print()

        'e.Graphics.DrawString("# de Caja:", New Font("Albertus Extra Bold", 14, FontStyle.Bold), Brushes.Black, 5, 250)
        'e.Graphics.DrawString(TxtOperador.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 20, 270)
        'e.Graphics.DrawString("De:", New Font("Albertus Extra Bold", 7, FontStyle.Bold), Brushes.Gray, 35, 270)
        ' e.Graphics.DrawString(TxtCajaHasta.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 270)
        ' e.Graphics.DrawString("-----------------------------------------------------------------------", New Font("Arial", 3, FontStyle.Bold), Brushes.Black, 200, 270)

        'e.Graphics.DrawString("#:", New Font("Albertus Extra Bold", 8, FontStyle.Bold), Brushes.Black, 200, 205)
        ' e.Graphics.DrawString("De:", New Font("Albertus Extra Bold", 8, FontStyle.Bold), Brushes.Black, 270, 205)
        ' e.Graphics.DrawString("@", New Font("Albertus Extra Bold", 7, FontStyle.Bold), Brushes.Black, 260, 205)

        'e.Graphics.DrawString("Fecha:", New Font("Albertus Extra Bold", 14, FontStyle.Bold), Brushes.Black, 200, 250)
        ' e.Graphics.DrawString(Microsoft.VisualBasic.Leftcdate((DtFechaCaja.Text, 10)), New Font("Arial", 13, FontStyle.Bold), Brushes.Black, 200, 135)
        'e.Graphics.DrawString(CStr(CDate(DtFechaCaja.Text)), New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 200, 270)
        '  e.Graphics.DrawString("-----------------------------------------------------------------------", New Font("Arial", 3, FontStyle.Bold), Brushes.Black, 200, 260)
    End Sub

    Private Sub FrmEtiquetaOperador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        documento = New Printing.PrintDocument
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub ChkIn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkIn.CheckedChanged
        If ChkIn.Checked = True Then
            DtFechaCaja.Enabled = True
        Else
            DtFechaCaja.Enabled = False
        End If
    End Sub
End Class
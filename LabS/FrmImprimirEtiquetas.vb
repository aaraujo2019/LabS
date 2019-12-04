Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Font
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing.Text
Imports System.Drawing.Printing



Public Class FrmImprimirEtiquetas
    Private prtDoc As PrintDocument
    Private WithEvents printDocument As New Printing.PrintDocument()
    Dim WithEvents documento As Printing.PrintDocument
    Private WithEvents PrintDoc As PrintDocument
    Private fuente As Font
    Private directorioFuentes As String
    Private Sub FrmImprimirEtiquetas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        directorioFuentes = "C:\Users\Public\DbZandor\"
        'directorioFuentes = "C:\Windows\Fonts\"
        'Inicializamos la Fuente.
        documento = New Printing.PrintDocument
    End Sub


    Private Sub GenerarFactura()
        prtDoc = New PrintDocument
        If prtDoc Is Nothing Then
            prtDoc = New PrintDocument
            AddHandler prtDoc.PrintPage, AddressOf prt_PrintPage
        End If
        prtDoc.DocumentName = "Barcode-Lab"
        Dim Alto As Integer = 130
        Dim Tamaño As New Printing.PaperSize("Factura", 250, Alto)
        prtDoc.DefaultPageSettings.PaperSize = Tamaño
        prtDoc.PrinterSettings.DefaultPageSettings.Margins.Top = 5
        prtDoc.PrinterSettings.DefaultPageSettings.Margins.Bottom = 5
        prtDoc.PrinterSettings.DefaultPageSettings.Margins.Left = 5
        prtDoc.PrinterSettings.DefaultPageSettings.Margins.Right = 5
        AddHandler prtDoc.PrintPage, AddressOf prt_PrintPage
        prtDoc.Print()
    End Sub



    Private Sub prt_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        If prtDoc Is Nothing Then
            prtDoc = New System.Drawing.Printing.PrintDocument
            AddHandler prtDoc.PrintPage, AddressOf prt_PrintPage
        End If

        ' la configuración a usar en la impresión
        ' prtDoc.DefaultPageSettings.PaperSize.Height = 300
        ' prtDoc.DefaultPageSettings.PaperSize.Width = 200
        e.PageSettings.Margins.Right = 5
        e.PageSettings.Margins.Left = 5
        Dim fontTitulo As New Font("Arial", 10, FontStyle.Bold)
        Dim fontEncabezado As New Font("Arial", 8, FontStyle.Bold)
        Dim fontCuerpo As New Font("Arial", 9, FontStyle.Regular)
        Dim fontPie As New Font("Arial", 10, FontStyle.Bold)
        Dim xPoint As New Point
        Dim xSize As New Size(80, 50)
        Dim FormatoCentro As New StringFormat
        FormatoCentro.Alignment = StringAlignment.Center
        Dim FormatoIzquierda As New StringFormat
        FormatoIzquierda.Alignment = StringAlignment.Far
        Dim FormatoDerecha As New StringFormat
        FormatoDerecha.Alignment = StringAlignment.Near
        Dim Renglon1 As New Rectangle(New Point(5, 10), New Size(210, 16))
        Dim Renglon2 As New Rectangle(New Point(10, 23), New Size(210, 23))
        Dim Renglon2_1 As New Rectangle(New Point(120, 23), New Size(210, 23))
        'muestra
        'Dim Renglon3 As New Rectangle(New Point(20, 46), New Size(210, 41))
        'Dim Renglon3_1 As New Rectangle(New Point(130, 46), New Size(210, 41))
        Dim Renglon4 As New Rectangle(New Point(10, 34), New Size(210, 34))
        Dim Renglon4_1 As New Rectangle(New Point(120, 34), New Size(210, 34))
        e.Graphics.DrawString("Zandor Capital - Lab. Segovia", fontTitulo, Brushes.Black, Renglon1, FormatoDerecha)
        'e.Graphics.DrawRectangle(Pens.Black, Renglon1)
        e.Graphics.DrawString("Orden de Lab.:    ", fontCuerpo, Brushes.Black, Renglon2, FormatoDerecha)
        e.Graphics.DrawString(TxtOrden.Text, fontEncabezado, Brushes.Black, Renglon2_1, FormatoDerecha)

        'muestra
        ' e.Graphics.DrawString("Muestra.:    ", fontCuerpo, Brushes.Black, Renglon3, FormatoDerecha)
        'e.Graphics.DrawString(txtcodigo.Text, fontEncabezado, Brushes.Black, Renglon3_1, FormatoDerecha)

        e.Graphics.DrawString("Fecha.:    ", fontCuerpo, Brushes.Black, Renglon4, FormatoDerecha)
        e.Graphics.DrawString(CStr(DtFecha.Text), fontEncabezado, Brushes.Black, Renglon4_1, FormatoDerecha)

        'e.Graphics.DrawRectangle(Pens.Black, Renglon2)
        Dim newImage As Image = Image.FromFile("C:\Users\Public\DbZandor\CodigoBarras\" + txtcodigo.Text + ".png")
        e.Graphics.DrawImage(newImage, 55, 50, 130, 75)
        ' e.Graphics.DrawImage(PicodigoBarra, fontEncabezado, Brushes.Black, Renglon2, FormatoIzquierda)
        'e.Graphics.DrawRectangle(Pens.Black, Renglon3)
        'For n As Integer = 0 To 10
        '    xPoint.Y = 50 + (n * 15)
        '    Renglon3 = New Rectangle(xPoint, xSize)
        '    e.Graphics.DrawString("Item " & n, fontCuerpo, Brushes.Black, vRectangulo, FormatoIzquierda)
        'Next

    End Sub


    Private Sub generar2()
        Dim barcode As New BarcodeLib.Barcode.Linear()
        barcode.Type = BarcodeLib.Barcode.BarcodeType.CODE128
        ' barcode.Type = BarcodeType.CODE128
        barcode.Data = txtcodigo.Text

        ' Barcode Text Settings
        barcode.ShowText = True
        barcode.TextFont = New Drawing.Font("Arial", 12.0F, Drawing.FontStyle.Regular)
        'barcode.TextMargin = 6

        ' barcode.UOM = uni.PIXEL
        ' barcode.UOM = UnitOfMeasure.PIXEL
        barcode.UOM = BarcodeLib.Barcode.UnitOfMeasure.PIXEL
        barcode.BarWidth = 1
        barcode.BarHeight = 65
        barcode.LeftMargin = 1
        barcode.RightMargin = 1
        barcode.TopMargin = 1
        barcode.BottomMargin = 1
        barcode.ImageFormat = System.Drawing.Imaging.ImageFormat.Png

        ' more barcode settings here
        ' save barcode image into your system
        barcode.drawBarcode("C:\Users\Public\DbZandor\CodigoBarras\" + txtcodigo.Text + ".png")
        'barcode.drawBarcode("c://barcode.png")
        'MsgBox("ok")
        'directorioFuentes = "C:\Users\Public\DbZandor\"
    End Sub
    Private Sub generaretiqueta()
        If txtcodigo.Text = "" Then
            MsgBox("por favor ingrese un codigo")
        End If
        generar2()
        PicodigoBarra.Image = Image.FromFile("C:\Users\Public\DbZandor\CodigoBarras\" + txtcodigo.Text + ".png")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        generaretiqueta()
    End Sub
    Private Sub InitializePrintPreviewDialog()
        ' Inicializa el cuadro de diálogo PrintPreview.
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Location = New Point(50, 50)
        PrintPreviewDialog1.MinimumSize = New Size(37, 25)
        PrintPreviewDialog1.UseAntiAlias = True
    End Sub


    Private Function GetFormImage(ByVal include_borders As Boolean) As Bitmap
        ' Make the bitmap.
        Dim wid As Integer = Me.Width
        Dim hgt As Integer = Me.Height
        Dim bm As New Bitmap(wid, hgt)

        ' Draw the form onto the bitmap.
        Me.DrawToBitmap(bm, New Rectangle(0, 0, wid, hgt))

        ' If we want the borders, return the bitmap.
        If include_borders Then Return bm

        ' Make a smaller bitmap without borders.
        wid = Me.ClientSize.Width
        hgt = Me.ClientSize.Height
        Dim bm2 As New Bitmap(wid, hgt)

        ' Get the offset from the window's corner to its client
        ' area's corner.
        Dim pt As New Point(0, 0)
        pt = PointToScreen(pt)
        Dim dx As Integer = pt.X - Me.Left
        Dim dy As Integer = pt.Y - Me.Top

        ' Copy the part of the original bitmap that we want
        ' into the bitmap.
        Dim gr As Graphics = Graphics.FromImage(bm2)
        gr.DrawImage(bm, 0, 0, New Rectangle(dx, dy, wid, hgt), _
            GraphicsUnit.Pixel)
        Return bm2
    End Function

    Private Sub imprimir()
        generar2()
        PicodigoBarra.Image = Image.FromFile("C:\Users\Public\DbZandor\CodigoBarras\" + txtcodigo.Text + ".png")
        PrintDocument1.Print()
    End Sub

    Private Sub CmdImprimirVarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdImprimirVarios.Click
        imprimirserie()
    End Sub

    Public Sub imprimirserie()
        Dim valor As Integer
        valor = TxtValorInicio.Text
        While valor <= CInt(TxtVlorFinal.Text)
            If GroupBoxUbicacion.Enabled = True Then
                If RbInicio.Checked = True Then
                    LblValor.Text = CmbLetra.Text + CStr(valor)
                    txtcodigo.Text = CmbLetra.Text + CStr(valor)
                Else
                    LblValor.Text = CStr(valor) + CmbLetra.Text
                    txtcodigo.Text = CStr(valor) + CmbLetra.Text
                End If
            Else
                LblValor.Text = CStr(valor)
                txtcodigo.Text = CStr(valor)
            End If
            generaretiqueta()
            Me.Refresh()
            GenerarFactura()
            ' PrintPreviewDialog1.Update()
            System.Threading.Thread.Sleep(100)
            valor = valor + 1
        End While
    End Sub

    Private Sub CmbLetra_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbLetra.SelectedIndexChanged
        If CmbLetra.Text <> "NO" Then
            GroupBoxUbicacion.Enabled = True
        Else
            GroupBoxUbicacion.Enabled = False
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(PicodigoBarra.Image, 10, 20, 900, 920) 'PB1 ES EL NOMBRE DEL PICTUREBOX
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GenerarFactura()
    End Sub
End Class
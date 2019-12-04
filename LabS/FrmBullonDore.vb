Imports System.Configuration
Imports System.Data.SqlClient
Public Class FrmBullonDore
    Dim Cn As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("StringConexion").ToString())
    Private dt As DataTable
    Dim Da As New SqlDataAdapter
    Dim Cmd As New SqlCommand
    Dim cmd1 As New System.Data.OleDb.OleDbCommand
    Dim Dataset As DataSet
    Dim cnStr As String
    Dim conn As New ADODB.Connection()
    Dim rsarea As New ADODB.Recordset()
    Dim rsmuestra As New ADODB.Recordset()
    Dim rspeso As New ADODB.Recordset()
    Dim d1 As New OleDb.OleDbDataAdapter
    Dim Da1 As New OleDb.OleDbDataAdapter
    Private dtenvios As DataTable

    Private Sub FrmBullonDore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar_lista_ordenes()
    End Sub

    Private Sub cargar_lista_ordenes()
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT TOP (100) PERCENT IdDespacho, TipoMuestra FROM dbo.Lab_Muestras GROUP BY IdDespacho, TipoMuestra HAVING (TipoMuestra = N'BULLON') ORDER BY IdDespacho  "
            .Connection = Cn
        End With
        Da.SelectCommand = Cmd
        dtenvios = New DataTable
        Da.Fill(dtenvios)

        With cmbDespacho
            .DataSource = dtenvios
            .DisplayMember = "IdDespacho"
            .ValueMember = "IdDespacho"
            .SelectedValue = 0
            .Text = "Seleccione"
        End With
    End Sub

    Private Sub TxtPBandeja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPeso1.TextChanged
        If Microsoft.VisualBasic.Left(TxtPeso1.Text, 3) = "S S" And Microsoft.VisualBasic.Right(TxtPeso1.Text, 1) = "g" Then
            Dim texto As String
            texto = Replace(TxtPeso1.Text, " ", "")
            texto = Replace(texto, "S", "")
            texto = Replace(texto, "g", "")
            texto = Replace(texto, "  ", "")
            TxtPeso1.Text = texto
            If IsNumeric(TxtPeso1.Text) Then
                TxtPeso1.Focus()
            Else
                MsgBox("Por Favor vuelve a Ingresar el Peso de la Bandeja")
                TxtPeso1.Clear()
                Exit Sub
                TxtPeso1.Focus()
            End If

        End If
    End Sub

    Private Sub PictureBuscarMuestra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBuscarMuestra.Click
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Lab_Muestras WHERE (Muestra = '" & (TxtMuestra.Text) & "' and IdDespacho = '" & (cmbDespacho.Text) & "')"
            .Connection = Cn
        End With

        Da.SelectCommand = Cmd
        dtenvios = New DataTable
        Da.Fill(dtenvios)

        If dtenvios.Rows.Count > 0 Then

            If dtenvios.Rows(0)(2).ToString() IsNot String.Empty Then
                TxtPeso1.Text = dtenvios.Rows(0)(2).ToString()
                'Me.TxtPeso1.Text = CStr((rsmuestra.Fields("PesoHumedoMuestra").Value))
            Else
                TxtPeso1.Clear()
            End If

            If dtenvios.Rows(0)(2).ToString IsNot String.Empty Then
                TxtPeso2.Text = dtenvios.Rows(0)(3).ToString()
                'Me.TxtPeso2.Text = CStr((rsmuestra.Fields("PesoSecoMuestra").Value))
            Else
                TxtPeso2.Clear()
            End If


            If dtenvios.Rows(0)(9).ToString IsNot String.Empty Then
                TxtDespacho.Text = dtenvios.Rows(0)(9).ToString()
                'Me.TxtDespacho.Text = CStr(rsmuestra.Fields("IdDespacho").Value)
                TxtDespacho.BackColor = Color.White
            End If

        Else
            MsgBox("La muestra no existe")
            TxtPeso1.Clear()
            TxtPeso2.Clear()
        End If

    End Sub

    Private Sub TxtPeso2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPeso2.TextChanged
        If Microsoft.VisualBasic.Left(TxtPeso2.Text, 3) = "S S" And Microsoft.VisualBasic.Right(TxtPeso2.Text, 1) = "g" Then
            Dim texto As String
            texto = Replace(TxtPeso2.Text, " ", "")
            texto = Replace(texto, "S", "")
            texto = Replace(texto, "g", "")
            texto = Replace(texto, "  ", "")
            TxtPeso2.Text = texto
            If IsNumeric(TxtPeso2.Text) Then
                TxtPeso2.Focus()
            Else
                MsgBox("Por Favor vuelve a Ingresar el Peso de la Bandeja")
                TxtPeso2.Clear()
                Exit Sub
                TxtPeso2.Focus()
            End If
        End If
    End Sub

    Private Sub BtonGardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtonGardar.Click
        Dim sqlConnectiondb As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("StringConexion").ToString())
        Cmd.CommandType = System.Data.CommandType.Text
        Cmd.CommandText = "UPDATE  Lab_Muestras SET PesoHumedoMuestra= '" & (TxtPeso1.Text) & "', PesoSecoMuestra= '" & (TxtPeso2.Text) & "' WHERE muestra = '" & TxtMuestra.Text & "'  "
        Cmd.Connection = sqlConnectiondb
        sqlConnectiondb.Open()
        Cmd.ExecuteNonQuery()
        sqlConnectiondb.Close()
        MsgBox("Actualizado")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
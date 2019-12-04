Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class FrmPpal
    Dim cnStr As String
    Dim conn As New ADODB.Connection()
    Dim rsmuestra As New ADODB.Recordset()
    Dim rsdespacho As New ADODB.Recordset()

    Dim Cn As New SqlConnection(ConfigurationManager.ConnectionStrings.Item("StringConexion").ToString())
    Dim dt As DataTable
    Dim Da As New SqlDataAdapter
    Dim CmdAlv As New SqlCommand

    Private Sub PesarMuestrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PesarMuestrasToolStripMenuItem.Click
        My.Forms.FrmPesoMuestras.ShowDialog()
    End Sub

    Private Sub FrmPpal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub

    Private Sub RecibirMuestrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibirMuestrasToolStripMenuItem.Click
        My.Forms.FrmRecepcion.ShowDialog()
    End Sub

    Private Sub CrearIdMuestrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.FrmCrearId.ShowDialog()
    End Sub

    Private Sub PesarMuestrasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PesarMuestrasToolStripMenuItem1.Click
        My.Forms.FrmPesoMuestraLab.ShowDialog()
    End Sub

    Private Sub ImprimirEtiquetasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirEtiquetasToolStripMenuItem.Click
        My.Forms.FrmImprimirEtiquetas.ShowDialog()
    End Sub

    Private Sub PruebaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        My.Forms.FrmConsultarOrdenes.ShowDialog()
    End Sub

    Private Sub FinalizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinalizarToolStripMenuItem.Click
        Dim orden As String

        With CmdAlv
            .CommandType = CommandType.Text
            .CommandText = "SELECT top 10 Lab_Muestras.IdDespacho FROM Lab_Muestras GROUP BY Lab_Muestras.IdDespacho HAVING (((Lab_Muestras.IdDespacho)<>'0'))"
            .Connection = Cn
        End With

        Da.SelectCommand = CmdAlv
        dt = New DataTable
        Da.Fill(dt)

        'cnStr = "Provider=SQLNCLI10;Initial Catalog=PlantaBeneficio;Data Source=mercurio; User ID=sa;Password=BdZandor123*;"
        'conn.Open(cnStr)
        'rsdespacho = conn.Execute("SELECT top 10 Lab_Muestras.IdDespacho FROM Lab_Muestras GROUP BY Lab_Muestras.IdDespacho HAVING (((Lab_Muestras.IdDespacho)<>'0'))")

        '------------- acces
        Dim sqlConnectiondb As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Public\DbZandor\DbZandor.accdb; Persist Security Info=False;")
        Dim cmd As New System.Data.OleDb.OleDbCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "SELECT Lab_Muestras.IdDespacho FROM Lab_Muestras GROUP BY Lab_Muestras.IdDespacho HAVING Lab_Muestras.IdDespacho <>'0'"
        'cmd.CommandText = "SELECT * FROM Lab_Muestras where (Lab_Muestras.IdDespacho)<> '0'  "
        cmd.Connection = sqlConnectiondb
        sqlConnectiondb.Open()
        Dim resultados As OleDb.OleDbDataReader
        'obtener resultados en datareader
        resultados = cmd.ExecuteReader
        'resultados.Item("PesoHumedoMuestra")

        While resultados.Read
            Try
                orden = (resultados.Item("IdDespacho"))
                rsmuestra = conn.Execute("SELECT * FROM Lab_Muestras WHERE (IdDespacho = '" & orden & "')")

                If rsmuestra.EOF = True Then
                    '  resultados.Item("OrdenLab")
                    cargarenbd(orden)
                Else
                    borrarenBD(orden)
                    cargarenbd(orden)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End While

        MsgBox("OK")
        sqlConnectiondb.Close()
        conn.Close()
    End Sub

    Sub cargarenbd(ByVal IdOrden As String)
        Dim sqlConnectiondb As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\DbZandor\DbZandor.accdb; Persist Security Info=False;")
        Dim cmd As New System.Data.OleDb.OleDbCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "SELECT * FROM Lab_Muestras where IdDespacho = '" & IdOrden & "'"
        'cmd.CommandText = "SELECT * FROM Lab_Muestras where (Lab_Muestras.IdDespacho)<> '0'"
        cmd.Connection = sqlConnectiondb
        sqlConnectiondb.Open()
        Dim resultados As OleDb.OleDbDataReader
        'obtener resultados en datareader
        resultados = cmd.ExecuteReader

        'cmd.ExecuteNonQuery()
        ' conexion SQL
        Dim cmdSQL As New System.Data.SqlClient.SqlCommand
        cmdSQL.CommandType = System.Data.CommandType.Text
        cmdSQL.CommandText = "insert  into Lab_Muestras (Muestra , Fecha , PesoHumedoMuestra , PesoSecoMuestra , PesoBandejaMuestra , Area , PorcHumedad , OrdenLab , OrdenDespacho , IdDespacho , TipoMuestra , CodPreparacion , CodServicio , PesoMuestra) Values (@Muestra ,  @Fecha , @PesoHumedoMuestra , @PesoSecoMuestra , @PesoBandejaMuestra , @Area , @PorcHumedad , @OrdenLab , @OrdenDespacho , @IdDespacho , @TipoMuestra , @CodPreparacion , @CodServicio , @PesoMuestra)  "

        cmdSQL.Connection = Cn

        Cn.Open()
        While resultados.Read
            Try
                ' cmd.Parameters.AddWithValue("@IdDespacho", Convert.ToString(cmbDespacho.Text))
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
                ' comandosql.Parameters.Add("@valor2",
                ' resultados.Item("apellidos"))
                ' comandosql.Parameters.Add("@valor3", resultados.Item("nombres"))
                cmdSQL.ExecuteNonQuery()
                cmdSQL.Parameters.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End While

        sqlConnectiondb.Close()
        Cn.Close()
    End Sub

    Sub borrarenBD(ByVal IdOrden As String)
        Dim cmdSQL As New System.Data.SqlClient.SqlCommand
        cmdSQL.CommandType = System.Data.CommandType.Text
        cmdSQL.CommandText = "DELETE FROM Lab_Muestras WHERE IdDespacho = '" & IdOrden & "' "
        cmdSQL.Connection = Cn
        Cn.Open()
        cmdSQL.ExecuteNonQuery()
        Cn.Close()
    End Sub

    Private Sub BgwBDu_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub ImprimirControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirControlToolStripMenuItem.Click
        My.Forms.FrmEtiquetaOperador.ShowDialog()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub BullonDoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BullonDoreToolStripMenuItem.Click
        My.Forms.FrmBullonDore.ShowDialog()
    End Sub
End Class

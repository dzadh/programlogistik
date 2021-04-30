Imports MySql.Data.MySqlClient
Public Class pilihPermintaanPembelianDialog
    Dim DataSetPP As New DataSet
    Dim conn As New MySqlConnection
    Dim dataSetPPDetail As New DataSet
    Public selectedNota As String
    Public nomorInNota(10) As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim cs As String
        KeyPreview = True
        Dim database As String = "dblogistik"
        Dim username As String = "root"
        Dim host As String = "localhost"
        Dim password As String = ""
        cs = "Database=" & database & ";Data Source=" & host & ";User Id=" & username & ";Password=" & password & ";Convert Zero Datetime=True"
        conn.ConnectionString = cs
        Try
            conn.Open()
            'Console.WriteLine("connection open")
        Catch ex As Exception
            'Console.WriteLine("error : " & ex.ToString)
            MsgBox("err : " & ex.ToString)
        End Try
        ' Add any initialization after the InitializeComponent() call.

        Dim sql As String = "SELECT nota, bagian FROM pp_header"
        Try
            Dim daa As New MySqlDataAdapter(sql, conn)
            daa.Fill(dataSetPP, "singo")
            dgv_pilihppheader.DataSource = DataSetPP.Tables("singo")
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            MsgBox("error : " & ex.ToString)
        End Try

    End Sub

    Private Sub dgv_pilihPPheader_changeSelected(sender As Object, e As EventArgs) Handles dgv_pilihppheader.SelectionChanged
        dgv_pilihPPdetail.Rows.Clear()
        Dim cmd As New MySqlCommand("select nomor, kode_brg, nama, satuan,qty, sisa from pp_detail where nota = '" & dgv_pilihppheader.CurrentRow.Cells(0).Value.ToString & "'", conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        Dim i As Int16 = 0
        While reader.Read
            'dgv_pilihPPdetail.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5))
            dgv_pilihPPdetail.Rows.Add()
            dgv_pilihPPdetail.Rows(i).Cells(1).Value = reader.GetString(0)
            dgv_pilihPPdetail.Rows(i).Cells(2).Value = reader.GetString(1)
            dgv_pilihPPdetail.Rows(i).Cells(3).Value = reader.GetString(2)
            dgv_pilihPPdetail.Rows(i).Cells(4).Value = reader.GetString(3)
            dgv_pilihPPdetail.Rows(i).Cells(5).Value = reader.GetString(4)
            dgv_pilihPPdetail.Rows(i).Cells(6).Value = reader.GetString(5)
            i += 1
        End While
        reader.Close()
        dgv_pilihPPdetail.Refresh()
    End Sub

    Private Sub pilihPermintaanPembelianDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_pilihPPdetail.DataSource = dataSetPPDetail.Tables("detail_pp")
        dgv_pilihPPdetail.Columns(2).ReadOnly = False
    End Sub

    Private Sub b_cancel_Click(sender As Object, e As EventArgs) Handles b_cancel.Click
        Me.Close()
    End Sub

    Private Sub dgv_pilihPPdetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pilihPPdetail.CellContentClick

    End Sub

    Private Sub b_pilih_Click(sender As Object, e As EventArgs) Handles b_pilih.Click
        Dim x As Int16 = 0
        For i As Int16 = 0 To dgv_pilihPPdetail.Rows.Count - 1
            'Console.WriteLine(dgv_pilihPPdetail.Rows(i).Cells(0).Value)
            If dgv_pilihPPdetail.Rows(i).Cells(0).Value = True Then
                'Console.WriteLine(dgv_pilihppheader.CurrentRow.Cells(0).Value.ToString & ", nomor : " & dgv_pilihPPdetail.Rows(i).Cells(1).Value.ToString & ", nama : " & dgv_pilihPPdetail.Rows(i).Cells(3).Value.ToString)
                nomorInNota(x) = dgv_pilihPPdetail.Rows(i).Cells(1).Value.ToString
                x += 1
            End If
        Next
        selectedNota = dgv_pilihppheader.CurrentRow.Cells(0).Value.ToString
        Me.Close()
    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class pilihPurchaseOrderDialog
    Dim dataSetPo As New DataSet
    Dim conn As New MySqlConnection
    Public selectedNota As String
    Public selectedBagian As String
    Public selectedSupplier As String
    'Public nomorInNota(10) As String
    Public noInNota As New List(Of String)
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

        Dim sql As String = "select nota, nama, bagian from po_header"
        Try
            Dim daa As New MySqlDataAdapter(sql, conn)
            daa.Fill(dataSetPo, "singo")
            dgv_pilihpoheader.DataSource = dataSetPo.Tables("singo")
        Catch ex As ArgumentNullException
            Console.WriteLine("error : " & ex.ToString)
        Catch ex As Exception
            Console.WriteLine("error initial dgv header : " & ex.ToString)
        End Try
        AddHandler dgv_pilihpoheader.SelectionChanged, AddressOf dgv_pilihpoheader_changeselected
    End Sub
    Private Sub pilihPurchaseOrderDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub b_cancel_Click(sender As Object, e As EventArgs) Handles b_cancel.Click
        Me.Close()
    End Sub

    Private Sub dgv_pilihpoheader_changeselected(sender As Object, e As EventArgs)
        dgv_pilihpodetail.Rows.Clear()
        Dim cmd As New MySqlCommand("select nomor, kode_brg, nama, satuan, qty, sisa from po_detail where nota = '" & dgv_pilihpoheader.CurrentRow.Cells(0).Value.ToString & "'", conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        Dim i As Int16 = 0
        While reader.Read
            dgv_pilihpodetail.Rows.Add()
            dgv_pilihpodetail.Rows(i).Cells(1).Value = reader.GetString(0)
            dgv_pilihpodetail.Rows(i).Cells(2).Value = reader.GetString(1)
            dgv_pilihpodetail.Rows(i).Cells(3).Value = reader.GetString(2)
            dgv_pilihpodetail.Rows(i).Cells(4).Value = reader.GetString(3)
            dgv_pilihpodetail.Rows(i).Cells(5).Value = reader.GetString(4)
            dgv_pilihpodetail.Rows(i).Cells(6).Value = reader.GetString(5)
            i += 1
        End While
        reader.Close()
        dgv_pilihpodetail.Refresh()
    End Sub

    Private Sub tb_nomorPO_textChanged(sender As Object, e As EventArgs) Handles tb_nomorPO.TextChanged
        RemoveHandler dgv_pilihpoheader.SelectionChanged, AddressOf dgv_pilihpoheader_changeselected
        Try
            Dim quer As String = "select nota, nama, bagian from po_header where nota like '%" & tb_nomorPO.Text & "%'"
            Console.WriteLine(quer)
            dataSetPo.Clear()
            Dim da As New MySqlDataAdapter(quer, conn)
            da.Fill(dataSetPo, "singo")
            dgv_pilihpoheader.Refresh()
        Catch ex As Exception
            Console.WriteLine("error cari by nomor PO : " & ex.ToString)
        End Try
        AddHandler dgv_pilihpoheader.SelectionChanged, AddressOf dgv_pilihpoheader_changeselected
    End Sub

    Private Sub b_pilih_Click(sender As Object, e As EventArgs) Handles b_pilih.Click
        Dim x As Int16 = 0
        For i As Int16 = 0 To dgv_pilihpodetail.Rows.Count - 1
            If dgv_pilihpodetail.Rows(i).Cells(0).Value = True Then
                noInNota.Add(dgv_pilihpodetail.Rows(i).Cells(1).Value.ToString)
            End If
        Next
        selectedNota = dgv_pilihpoheader.CurrentRow.Cells(0).Value.ToString
        selectedSupplier = dgv_pilihpoheader.CurrentRow.Cells(1).Value.ToString
        selectedBagian = dgv_pilihpoheader.CurrentRow.Cells(2).Value.ToString
        Me.Close()
    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class dialogPP
    Dim conn As New MySqlConnection
    Dim a As New AutoCompleteStringCollection
    Dim autoBagian As New AutoCompleteStringCollection
    Dim autoSatuan As New AutoCompleteStringCollection
    Dim lastEditedCellRow As Int16
    Dim lastEditedCellColumn As Int16
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
            Console.WriteLine("connection open")
        Catch ex As Exception
            Console.WriteLine("error : " & ex.ToString)
            MsgBox("err : " & ex.ToString)
        End Try
        'autocom namabarang
        Dim cmd As New MySqlCommand("SELECT KODE_BRG, NAMA FROM Barang", conn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        For i As Integer = 0 To dt.Rows.Count - 1
            a.Add(dt.Rows(i)("Nama"))
        Next

        'autocombagian
        Dim cmda As New MySqlCommand("select bagian from tblbagian", conn)
        Dim daa As New MySqlDataAdapter(cmda)
        Dim dtt As New DataTable
        daa.Fill(dtt)
        For i As Integer = 0 To dtt.Rows.Count - 1
            autoBagian.Add(dtt.Rows(i)("Bagian"))
        Next

        'autocomSatuan
        Dim cmdd As New MySqlCommand("SELECT DISTINCT SATUAN FROM `barang`", conn)
        Dim daaa As New MySqlDataAdapter(cmdd)
        Dim dttt As New DataTable
        daaa.Fill(dttt)
        For i As Integer = 0 To dttt.Rows.Count - 1
            autoSatuan.Add(dttt.Rows(i)("Satuan"))
        Next
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub dialogPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgv_rincianBrgPP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_rincianBrgPP.CellDoubleClick
        Console.WriteLine(e.ColumnIndex.ToString)
    End Sub

    Private Sub b_cancel_Click(sender As Object, e As EventArgs) Handles b_cancel.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgv_rincianBrgPP.EditingControlShowing
        'Console.WriteLine(dgv_rincianBrgPP.CurrentCell)
        Dim titleText As String = dgv_rincianBrgPP.Columns(2).HeaderText
        If dgv_rincianBrgPP.CurrentCell.ColumnIndex = 2 Then
            Dim autoText As TextBox = TryCast(e.Control, TextBox)
            If autoText IsNot Nothing Then
                autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                autoText.AutoCompleteCustomSource = a
            End If
            AddHandler dgv_rincianBrgPP.CellEndEdit, AddressOf fillKodeBarang
        ElseIf dgv_rincianBrgPP.CurrentCell.ColumnIndex = 3 Then
            Dim text As TextBox = TryCast(e.Control, TextBox)
            text.AutoCompleteCustomSource = autoSatuan
            text.AutoCompleteSource = AutoCompleteSource.CustomSource
            text.AutoCompleteMode = AutoCompleteMode.Suggest
        Else
            Dim text As TextBox = TryCast(e.Control, TextBox)
            text.AutoCompleteCustomSource = Nothing
            text.AutoCompleteSource = AutoCompleteSource.None
            text.AutoCompleteMode = AutoCompleteMode.None
        End If
    End Sub

    Private Sub YourDGV_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_rincianBrgPP.CurrentCellDirtyStateChanged
        If (dgv_rincianBrgPP.CurrentCell.ColumnIndex = 2) Then
            If dgv_rincianBrgPP.CommitEdit(DataGridViewDataErrorContexts.Commit) Then
                lastEditedCellRow = dgv_rincianBrgPP.CurrentCell.RowIndex
                lastEditedCellColumn = dgv_rincianBrgPP.CurrentCell.ColumnIndex
            End If
        End If
    End Sub

    Private Sub editedCell(sel As DataGridViewTextBoxCell)
        'Console.WriteLine(sel.RowIndex & " " & sel.ColumnIndex)
        Dim cmd As New MySqlCommand("select kode_brg from barang where nama =")
    End Sub

    Private Sub fillKodeBarang()
        Console.WriteLine(lastEditedCellRow & "  " & lastEditedCellColumn)
        Dim cmd As New MySqlCommand("select kode_brg from barang where nama = '" & dgv_rincianBrgPP.Rows(lastEditedCellRow).Cells(lastEditedCellColumn).Value.ToString & "'", conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        While reader.Read
            dgv_rincianBrgPP.Rows(lastEditedCellRow).Cells(lastEditedCellColumn - 1).Value = reader.GetString(0)
        End While
        dgv_rincianBrgPP.Rows(lastEditedCellRow).Cells(0).Value = lastEditedCellRow + 1
        reader.Close()
    End Sub

    Private Sub b_simpan_Click(sender As Object, e As EventArgs) Handles b_simpan.Click
        Dim rowCount As Int16 = dgv_rincianBrgPP.RowCount
        Dim columnCount As Int16 = dgv_rincianBrgPP.ColumnCount
        Dim nota As String = tb_nomorPP.Text
        Dim query As String = "INSERT INTO `pp_header`(`Nota`, `Tanggal`, `Bagian`, `Catatan`, `Status`, `UserID`) VALUES (" & nota & "," & dp_tglPermitaalPembelian.Value.ToString("yyyy-MM-dd") & ",[value-3],[value-4],[value-5],[value-6])"
        For i = 0 To rowCount - 2
            Console.WriteLine(dgv_rincianBrgPP.Rows(i).Cells(1).Value.ToString & "  " & dgv_rincianBrgPP.Rows(i).Cells(2).Value.ToString)
        Next
    End Sub
End Class
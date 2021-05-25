Imports MySql.Data.MySqlClient
''' <summary>
''' undone : buat bukti terima barang : auto nomer btb
'''         
''' </summary>
Public Class dialogBtb
    Dim conn As New MySqlConnection
    Dim autoBarang As New AutoCompleteStringCollection
    Dim autoSupplier As New AutoCompleteStringCollection
    Public nomorBuktiTerimaBarang As String
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

        Dim cmd As New MySqlCommand("SELECT KODE_BRG, NAMA FROM Barang", conn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        'Console.WriteLine("heyy yoo : " & dt.Rows(1)("nama"))
        For i As Integer = 0 To dt.Rows.Count - 1
            'Console.WriteLine(dt.Rows(i)("nama"))
            autoBarang.Add(dt.Rows(i)("nama").ToString)
        Next

        Dim cmdd As New MySqlCommand("SELECT nama FROM `supplier`", conn)
        Dim daa As New MySqlDataAdapter(cmdd)
        Dim namaSupplierDataTable As New DataTable
        daa.Fill(namaSupplierDataTable)
        For i As Integer = 0 To namaSupplierDataTable.Rows.Count - 1
            'Console.WriteLine(namaSupplierDataTable.Rows(i)("nama"))
            autoSupplier.Add(namaSupplierDataTable.Rows(i)("NAMA"))
        Next

        tb_supplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tb_supplier.AutoCompleteSource = AutoCompleteSource.CustomSource
        tb_supplier.AutoCompleteCustomSource = autoSupplier
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub dialogBtb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(nomorBuktiTerimaBarang) Then
            'Console.WriteLine("Tambah bukti terima barang")
            tb_notabtb.Text = "0000TB0001"
            tb_notabtb.Enabled = False
        Else
            l_judulDialog.Text = "Edit Bukti Terima Barang"
            Dim quer As String = "select nopp, nopo, tanggal, nama, catatan from btb_header where nota = '" & nomorBuktiTerimaBarang & "'"
            Console.WriteLine(quer)
            Try
                Dim cmd As New MySqlCommand(quer, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader
                While reader.Read
                    tb_notabtb.Text = nomorBuktiTerimaBarang
                    tb_noPP.Text = reader.GetString(0)
                    tb_noPurchaseOrder.Text = reader.GetString(1)
                    dp_tanggalbtb.Value = reader.GetString(2)
                    tb_supplier.Text = reader.GetString(3)
                    tb_keterangan.Text = reader.GetString(4)
                End While
                reader.Close()
            Catch ex As Exception
                Console.WriteLine("error : " & ex.ToString)
            End Try

            Dim quer_isi As String = "SELECT Kode_Brg, Nama, Satuan, Qty, HargaBeli, Jumlah, NoPP FROM `btb_detail` WHERE Nota = '" & nomorBuktiTerimaBarang & "'"
            Try
                Dim cmd_isi As New MySqlCommand(quer_isi, conn)
                Dim pembaca As MySqlDataReader = cmd_isi.ExecuteReader
                While pembaca.Read
                    dgv_dialogbtb.Rows.Add(pembaca.GetString(0), pembaca.GetString(1), pembaca.GetString(2), pembaca.GetString(3), pembaca.GetString(4), pembaca.GetString(5), pembaca.GetString(6))
                End While
                pembaca.Close()
            Catch ex As Exception
                Console.WriteLine("error : " & ex.ToString)
                MsgBox("error : \n" & ex.ToString)
            End Try

            b_pilihPO.Enabled = False
            tb_notabtb.Enabled = False
            Console.WriteLine(nomorBuktiTerimaBarang)
        End If
    End Sub

    Private Sub close_dialog(sender As Object, e As EventArgs) Handles b_cancel.Click
        Me.Close()
    End Sub



    Private Sub dialogbtb_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            'Console.WriteLine("esc pressed")
            Me.Close()
        End If
    End Sub

    Private Sub dgv_dialogbtb_EditingControlShowing(sender As System.Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgv_dialogbtb.EditingControlShowing
        If dgv_dialogbtb.CurrentCell.ColumnIndex = 1 Then
            Dim autoText As TextBox = TryCast(e.Control, TextBox)
            If autoText IsNot Nothing Then
                autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                autoText.AutoCompleteCustomSource = autoBarang
            End If
            AddHandler dgv_dialogbtb.CellEndEdit, AddressOf autofillKodebarangDanSatuan
        Else
            Dim text As TextBox = TryCast(e.Control, TextBox)
            text.AutoCompleteMode = AutoCompleteMode.None
            text.AutoCompleteSource = AutoCompleteSource.None
            text.AutoCompleteCustomSource = Nothing
        End If
    End Sub

    Private Sub autofillKodebarangDanSatuan()
        Dim quer As String = "select kode_brg, satuan from barang where nama = '" & dgv_dialogbtb.CurrentRow.Cells(1).Value.ToString & "'"
        'Console.WriteLine(quer)
        Try
            Dim cmd As New MySqlCommand(quer, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            While reader.Read
                dgv_dialogbtb.CurrentRow.Cells(0).Value = reader.GetString(0)
                dgv_dialogbtb.CurrentRow.Cells(2).Value = reader.GetString(1)
            End While
        Catch ex As Exception
            Console.WriteLine("error : " & ex.ToString)
        End Try
    End Sub

    Private Sub b_save_Click(sender As Object, e As EventArgs) Handles b_save.Click
        Dim notabtb = tb_notabtb.Text
        Dim noPo = tb_noPurchaseOrder.Text
        Dim noPp = tb_noPP.Text
        Dim tanggal = dp_tanggalbtb.Value.ToString("yyyy-MM-dd")
        Dim supplier = tb_supplier.Text
        Dim keterangan = tb_keterangan.Text
    End Sub
End Class
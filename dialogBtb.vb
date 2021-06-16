Imports MySql.Data.MySqlClient
''' <summary>
''' undone : buat bukti terima barang : auto nomer btb
'''         - save btb userid, group, subgroup, ordere, sisa belum konek sama PO po sisa belum konek PP
'''         - HAPUS ROWS
''' </summary>
Public Class dialogBtb
    Dim conn As New MySqlConnection
    Dim autoBarang As New AutoCompleteStringCollection
    Dim autoSupplier As New AutoCompleteStringCollection
    Public nomorBuktiTerimaBarang As String
    Dim kodeSupplier As String
    Dim alamatSupplier As String

    Dim diaPilOr As pilihPurchaseOrderDialog
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
            Dim quer As String = "select nopp, nopo, tanggal, nama, catatan, bagian, telpon from btb_header where nota = '" & nomorBuktiTerimaBarang & "'"
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
                    tb_bagian.Text = reader.GetString(5)
                    tb_telp.Text = reader.GetString(6)
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
            tb_bagian.Enabled = False
            tb_supplier.Enabled = False
            tb_noPP.Enabled = False
            dp_tanggalbtb.Enabled = False
            tb_telp.Enabled = False
            tb_noPurchaseOrder.Enabled = False
            Console.WriteLine(nomorBuktiTerimaBarang)
        End If
        'Console.WriteLine(TimeOfDay.ToString("h:mm:ss"))
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
            reader.Close()
        Catch ex As Exception
            Console.WriteLine("error autofill barang : " & ex.ToString)
        End Try
    End Sub

    Private Sub autoFillDetailSupplier() Handles tb_supplier.LostFocus
        Dim quer As String = "select telpon,kode_supl, alamat from supplier where nama like '%" & tb_supplier.Text & "%'"
        Console.WriteLine(quer)
        Dim cmd As New MySqlCommand(quer, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        Try
            While reader.Read
                If String.IsNullOrEmpty(reader.GetString(0)) = 0 Then
                    tb_telp.Text = reader.GetString(0)
                End If
                kodeSupplier = reader.GetString(1)
                alamatSupplier = reader.GetString(2)
            End While
            reader.Close()
        Catch ex As Exception
            Console.WriteLine("error autofill supplier : " & ex.ToString)
            reader.Close()
        End Try
    End Sub

    Private Sub b_save_Click(sender As Object, e As EventArgs) Handles b_save.Click
        Dim notabtb = tb_notabtb.Text
        Dim noPo = tb_noPurchaseOrder.Text
        Dim noPp = tb_noPP.Text
        Dim tanggal = dp_tanggalbtb.Value.ToString("yyyy-MM-dd")
        Dim supplier = tb_supplier.Text
        Dim keterangan = tb_keterangan.Text
        Dim telp = tb_telp.Text
        Dim bagian = tb_bagian.Text
        Dim userId = "singo"
        Dim status = "quo"
        Dim ordere = 101
        Dim sisa = 101

        Dim quer_insert As String = "INSERT INTO `btb_header`(`Nota`, `Tanggal`, `NoPP`, `NoPO`, `Bagian`, `Kode_supl`, `Nama`, `Alamat`, `Telpon`, `NoSJ`, `Catatan`, `UserID`, `Status`) VALUES ('" & notabtb & "','" & tanggal & "','" & noPp & "','" & noPo & "','" & bagian & "','" & kodeSupplier & "','" & supplier & "','" & alamatSupplier & "','" & telp & "','SJ12','" & keterangan & "','" & userId & "','" & status & "')"
        Console.WriteLine(quer_insert)
        Dim cmd_inserbtbheader As New MySqlCommand
        Dim tr As MySqlTransaction
        tr = conn.BeginTransaction
        Try
            cmd_inserbtbheader.Connection = conn
            cmd_inserbtbheader.CommandText = quer_insert
            cmd_inserbtbheader.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("error insert btb header :" & ex.ToString)
        End Try

        Dim cmd_btbdetail As New MySqlCommand
        cmd_btbdetail.Connection = conn
        For i As Int16 = 0 To dgv_dialogbtb.RowCount - 2
            Try
                Dim no_barang = dgv_dialogbtb.Rows(i).Cells(0).Value.ToString
                Dim nama_barang = dgv_dialogbtb.Rows(i).Cells(1).Value.ToString
                Dim satuan = dgv_dialogbtb.Rows(i).Cells(2).Value.ToString
                Dim terima = dgv_dialogbtb.Rows(i).Cells(3).Value.ToString
                Dim harga = dgv_dialogbtb.Rows(i).Cells(4).Value.ToString
                Dim jumlah = dgv_dialogbtb.Rows(i).Cells(5).Value.ToString
                Dim time = TimeOfDay.ToString("h:mm:ss")
                'Dim ordere = 1

                Dim quer_btbdetail As String = "INSERT INTO `btb_detail`(`Nota`, `Tanggal`, `NoPP`, `NoPO`, `Bagian`, `Kode_supl`, `Suplier`, `Nomor`, `Kode_Brg`, `Nama`, `Satuan`, `HargaBeli`, `Ordere`, `PO_Qty`, `Qty`, `Sisa`, `Jumlah`, `Keterangan`, `groupe`, `subgroup`, `UserID`, `Jam`) VALUES ('" & notabtb & "','" & tanggal & "','" & noPp & "','" & noPo & "','" & bagian & "','" & kodeSupplier & "','" & supplier & "','" & i + 1 & "','" & no_barang & "','" & nama_barang & "','" & satuan & "','" & harga & "','" & ordere & "','" & ordere & "','" & terima & "','" & sisa & "','" & jumlah & "','" & keterangan & "','','','" & userId & "','" & time & "')"
                Console.WriteLine("query btb detail : " & quer_btbdetail)
                cmd_btbdetail.CommandText = quer_btbdetail
                cmd_btbdetail.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine("error insert btb detail : " & ex.ToString)
            End Try
        Next
        tr.Commit()
        Me.Close()
    End Sub

    Private Sub b_pilihPO_Click(sender As Object, e As EventArgs) Handles b_pilihPO.Click
        diaPilOr = New pilihPurchaseOrderDialog
        diaPilOr.Show()
        AddHandler diaPilOr.FormClosed, AddressOf diaPilOR_formClosed
    End Sub

    Private Sub diaPilOR_formClosed()
        'tb_bagian.Text = diapilpil.selectedBagian
        'Dim quer As String = "select kode_brg, nama, satuan, qty from pp_detail where nota = '" & diapilpil.selectedNota & "' and ( "
        'For x As Int16 = 0 To diapilpil.noInNota.Count - 1
        '    If x = 0 Then
        '        quer += "nomor = '" & diapilpil.noInNota.Item(x) & "' "
        '    Else
        '        quer += "or nomor = '" & diapilpil.noInNota.Item(x) & "' "
        '    End If
        'Next
        'quer += ")"
        tb_bagian.Text = diaPilOr.selectedBagian
        tb_noPP.Text = diaPilOr.selectedNota
        tb_supplier.Text = diaPilOr.selectedSupplier
        Dim quer As String = "select kode_brg, nama, satuan, harga, qty,nopp from po_detail where nota = '" & diaPilOr.selectedNota & "' and ("
        For i As Int16 = 0 To diaPilOr.noInNota.Count - 1
            If i = 0 Then
                quer += "nomor = '" & diaPilOr.noInNota.Item(i) & "'"
            Else
                quer += "or nomor = '" & diaPilOr.noInNota.Item(i) & "'"
            End If
        Next
        quer += ")"
        Console.WriteLine(quer)
        Try
            Dim cmd As MySqlCommand = New MySqlCommand(quer, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            Dim i As Int16 = dgv_dialogbtb.RowCount - 1
            While reader.Read
                dgv_dialogbtb.Rows.Add()
                'dgv_dialogbtb.Rows(i).Cells(0).Value = i + 1
                dgv_dialogbtb.Rows(i).Cells(0).Value = reader.GetString(0)
                dgv_dialogbtb.Rows(i).Cells(1).Value = reader.GetString(1)
                dgv_dialogbtb.Rows(i).Cells(2).Value = reader.GetString(2)
                'dgv_dialogbtb.Rows(i).Cells(3).Value = reader.GetString(3)
                dgv_dialogbtb.Rows(i).Cells(4).Value = reader.GetString(3)
                dgv_dialogbtb.Rows(i).Cells(6).Value = reader.GetString(5)
                i += 1
            End While
            reader.Close()
        Catch ex As Exception
            Console.WriteLine("error diapilor form close : " & ex.ToString)
        End Try
        'Try
        '    Dim cmd As MySqlCommand = New MySqlCommand(quer, conn)
        '    Dim reader As MySqlDataReader = cmd.ExecuteReader
        '    Dim i As Int16 = dgv_purchaseOrder.RowCount - 1
        '    While reader.Read
        '        dgv_purchaseOrder.Rows.Add()
        '        dgv_purchaseOrder.Rows(i).Cells(0).Value = i + 1
        '        dgv_purchaseOrder.Rows(i).Cells(1).Value = reader.GetString(0)
        '        dgv_purchaseOrder.Rows(i).Cells(2).Value = reader.GetString(1)
        '        dgv_purchaseOrder.Rows(i).Cells(3).Value = reader.GetString(2)
        '        dgv_purchaseOrder.Rows(i).Cells(4).Value = reader.GetString(3)
        '        dgv_purchaseOrder.Rows(i).Cells(6).Value = diapilpil.selectedNota
        '        i += 1
        '    End While
        '    reader.Close()
        'Catch ex As Exception
        '    Console.WriteLine("error diapilpp form close: " & ex.ToString)
        'End Try
    End Sub
End Class
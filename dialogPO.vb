Imports MySql.Data.MySqlClient

''' <summary>
''' undone YET: Nomor PO buat PO, cara bayar
'''             po_header:  tdisksen, tdiskrp,tppnsen, tppnRP,grandtotal, user, status, item, keterangan
'''             po_detail:  currency, ordere (apaitu ordere?), jumlahHarga, sisa, groupe, subgroup, statusID, flag, userid, jam
'''             sisa barang yang udah di buat PO
'''             PO selesai, PP selesai pas ngapain
'''             
''' </summary>
Public Class dialogPO
    Dim conn As New MySqlConnection
    Dim autoSupplier As New AutoCompleteStringCollection
    Dim autoBarang As New AutoCompleteStringCollection
    Public nomorPurchaseOrder As String
    Dim lastEditedCellRow As Int16
    Dim lastEditedCellColumn As Int16
    Dim lastEditHargaSatuanRow As Int16
    Dim lasEditHargaSatuanCell As Int16
    Dim grandTotal As Double
    Dim totalHarga As Double
    Dim totalPajak As Double
    Public selectedNota As String
    Public tppnsen As Int16
    Dim stat As Boolean

    'Dim diaPilPP As New pilihPermintaanPembelianDialog
    'Dim diapilobj As New Object
    Dim diapilpil As pilihPermintaanPembelianDialog

    Public Property dgv_rincianBrgPP As Object
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(nomorPurchaseOrder) Then
            tb_nomorPO.Text = "1010000"
            tb_nomorPO.Enabled = False
            stat = True
        Else
            tb_nomorPO.Text = nomorPurchaseOrder
            tb_nomorPO.Enabled = False
            Dim quer As String = "SELECT Nota, Tanggal, Bagian ,Nama ,Total ,TPPNsen, TPPNRp, GTotal, keterangan FROM `po_header` WHERE Nota ='" & nomorPurchaseOrder & "'"
            Console.WriteLine(quer)
            Dim cmd As New MySqlCommand(quer, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            While reader.Read
                tb_nomorPO.Text = reader.GetString(0)
                dp_tanggalPO.Text = reader.GetString(1)
                tb_bagian.Text = reader.GetString(2)
                tb_supplier.Text = reader.GetString(3)
                tb_totalHarga.Text = reader.GetString(4)
                tppnsen = reader.GetString(5)
                tb_pajak.Text = reader.GetString(6)
                tb_grandTotal.Text = reader.GetString(7)
                tb_keterangan.Text = reader.GetString(8)
            End While
            tb_nomorPO.Enabled = False
            reader.Close()

            Dim quer_isi As String = "SELECT Nomor, Kode_Brg, Nama, Satuan, Qty, Harga, NoPP FROM `po_detail` WHERE Nota = '" & nomorPurchaseOrder & "' ORDER BY `Nomor` ASC"
            'Console.WriteLine(quer_isi)
            Dim cmd_isi As New MySqlCommand(quer_isi, conn)
            Dim pembaca As MySqlDataReader = cmd_isi.ExecuteReader

            While pembaca.Read
                dgv_purchaseOrder.Rows.Add(pembaca.GetString(0), pembaca.GetString(1), pembaca.GetString(2), pembaca.GetString(3), pembaca.GetString(4), pembaca.GetString(5), pembaca.GetString(6), tppnsen)
            End While
            pembaca.Close()
            stat = False
        End If
    End Sub

    Private Sub b_cancel_Click(sender As Object, e As EventArgs) Handles b_cancel.Click
        Me.Close()
    End Sub
    Private Sub dialogPO_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            'Console.WriteLine("esc pressed")
            Me.Close()
        End If
    End Sub


    Private Sub DataGridView1_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgv_purchaseOrder.EditingControlShowing
        'Console.WriteLine(dgv_rincianBrgPP.CurrentCell)
        Dim titleText As String = dgv_purchaseOrder.Columns(2).HeaderText
        If dgv_purchaseOrder.CurrentCell.ColumnIndex = 2 Then
            Dim autoText As TextBox = TryCast(e.Control, TextBox)
            If autoText IsNot Nothing Then
                autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                autoText.AutoCompleteCustomSource = autoBarang
            End If
            AddHandler dgv_purchaseOrder.CellEndEdit, AddressOf fillKodeBarang
        ElseIf dgv_purchaseOrder.CurrentCell.ColumnIndex = 5 Then
            AddHandler dgv_purchaseOrder.CellEndEdit, AddressOf hargaSatuanFill
        Else
            Dim text As TextBox = TryCast(e.Control, TextBox)
            text.AutoCompleteCustomSource = Nothing
            text.AutoCompleteSource = AutoCompleteSource.None
            text.AutoCompleteMode = AutoCompleteMode.None
        End If
    End Sub

    ' HAPUS ROW TENGAH, YANG BAWAH NOMOR TETAP, KALAU DI EDIT ERROR
    Private Sub YourDGV_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_purchaseOrder.CurrentCellDirtyStateChanged
        If (dgv_purchaseOrder.CurrentCell.ColumnIndex = 2) Then
            If dgv_purchaseOrder.CommitEdit(DataGridViewDataErrorContexts.Commit) Then
                lastEditedCellRow = dgv_purchaseOrder.CurrentCell.RowIndex
                lastEditedCellColumn = dgv_purchaseOrder.CurrentCell.ColumnIndex
            End If
        End If
        If (dgv_purchaseOrder.CurrentCell.ColumnIndex = 5) Then
            If dgv_purchaseOrder.CommitEdit(DataGridViewDataErrorContexts.Commit) Then
                lastEditHargaSatuanRow = dgv_purchaseOrder.CurrentCell.RowIndex
                lasEditHargaSatuanCell = dgv_purchaseOrder.CurrentCell.ColumnIndex
            End If
        End If
    End Sub

    Private Sub hargaSatuanFill()
        Dim harga As Double
        totalHarga = 0
        totalPajak = 0
        grandTotal = 0
        For x As Int16 = 0 To dgv_purchaseOrder.Rows.Count - 2
            Try
                harga = dgv_purchaseOrder.Rows(x).Cells(5).Value * Convert.ToDecimal(dgv_purchaseOrder.Rows(x).Cells(4).Value)
                totalHarga += harga
                totalPajak += harga * Convert.ToDouble(dgv_purchaseOrder.Rows(x).Cells(7).Value) / 100
            Catch ex As Exception
                harga = dgv_purchaseOrder.Rows(x).Cells(5).Value * Convert.ToDecimal(dgv_purchaseOrder.Rows(x).Cells(4).Value)
                totalHarga += harga
                Console.WriteLine("err : " & ex.ToString)
            End Try
        Next
        tb_pajak.Text = totalPajak
        tb_totalHarga.Text = totalHarga
        tb_grandTotal.Text = totalPajak + totalHarga
    End Sub

    Private Sub fillKodeBarang()
        Try
            Dim cmd As New MySqlCommand("select kode_brg, satuan from barang where nama = """ & dgv_purchaseOrder.Rows(lastEditedCellRow).Cells(lastEditedCellColumn).Value.ToString & """", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            While reader.Read
                dgv_purchaseOrder.Rows(lastEditedCellRow).Cells(lastEditedCellColumn - 1).Value = reader.GetString(0)
                dgv_purchaseOrder.Rows(lastEditedCellRow).Cells(lastEditedCellColumn + 1).Value = reader.GetString(1)
                'Console.WriteLine(reader.GetString(1))
            End While
            dgv_purchaseOrder.Rows(lastEditedCellRow).Cells(0).Value = lastEditedCellRow + 1
            'dgv_purchaseOrder.Rows(lastEditedCellRow).Cells(0).Value = lastEditedCellRow + 2
            reader.Close()
        Catch exc As MySqlException
            'MsgBox("err : " & exc.ToString)
            Dim cmdd As New MySqlCommand("select kode_brg, satuan from barang where nama = '" & dgv_purchaseOrder.Rows(lastEditedCellRow).Cells(lastEditedCellColumn).Value.ToString & "'", conn)
            Console.WriteLine(cmdd)
            Dim reader As MySqlDataReader = cmdd.ExecuteReader
            While reader.Read
                dgv_purchaseOrder.Rows(lastEditedCellRow).Cells(lastEditedCellColumn - 1).Value = reader.GetString(0)
                dgv_purchaseOrder.Rows(lastEditedCellRow).Cells(lastEditedCellColumn + 1).Value = reader.GetString(1)
            End While
            dgv_purchaseOrder.Rows(lastEditedCellRow).Cells(0).Value = lastEditedCellRow + 1
            reader.Close()
        Catch ex As Exception
            MsgBox("error : masukan nama barang dengan benar")
            Console.WriteLine("er" & ex.GetType.ToString)
            dgv_purchaseOrder.Rows(lastEditedCellRow).Cells(lastEditedCellColumn).Value = "NULL"
        End Try
    End Sub

    Private Sub dgv_purchaseOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_purchaseOrder.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = 7 Then
                'Try
                '    Console.WriteLine("hey yoo row :" & e.RowIndex & " " & dgv_purchaseOrder.CurrentRow.Cells(2).Value.ToString)
                'Catch ex As Exception
                '    Console.WriteLine("data kosong")
                'End Try
                dgv_purchaseOrder.Rows.RemoveAt(e.RowIndex)
            ElseIf e.ColumnIndex = 8 Then
                Console.WriteLine("suppose to hapus row")
                dgv_purchaseOrder.Rows.RemoveAt(e.RowIndex)
                hargaSatuanFill()
            End If
        End If
    End Sub

    Private Sub dgv_purchaseOrder_rowcontchange(sender As Object, e As EventArgs) Handles dgv_purchaseOrder.RowsRemoved
        For i As Int16 = 0 To dgv_purchaseOrder.Rows.Count - 2
            'Console.WriteLine(" test """ & i & """ ska")
            dgv_purchaseOrder.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles b_pilihpp.Click
        diapilpil = New pilihPermintaanPembelianDialog
        diapilpil.Show()
        AddHandler diapilpil.FormClosed, AddressOf diapilppFormCloses
    End Sub

    Private Sub diapilppFormCloses()
        'Console.WriteLine(diapilpil.selectedNota & " " & diapilpil.noInNota.Count)
        tb_bagian.Text = diapilpil.selectedBagian
        Dim quer As String = "select kode_brg, nama, satuan, qty from pp_detail where nota = '" & diapilpil.selectedNota & "' and ( "
        'For Each noUrut As String In diapilpil.noInNota
        '    Console.WriteLine(noUrut)
        '    quer += "and nomor = '" & noUrut & "'"
        'Next
        For x As Int16 = 0 To diapilpil.noInNota.Count - 1
            If x = 0 Then
                quer += "nomor = '" & diapilpil.noInNota.Item(x) & "' "
            Else
                quer += "or nomor = '" & diapilpil.noInNota.Item(x) & "' "
            End If
        Next
        quer += ")"
        Dim cmd As MySqlCommand = New MySqlCommand(quer, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        Try
            Dim i As Int16 = dgv_purchaseOrder.RowCount - 1
            While reader.Read
                dgv_purchaseOrder.Rows.Add()
                dgv_purchaseOrder.Rows(i).Cells(0).Value = i + 1
                dgv_purchaseOrder.Rows(i).Cells(1).Value = reader.GetString(0)
                dgv_purchaseOrder.Rows(i).Cells(2).Value = reader.GetString(1)
                dgv_purchaseOrder.Rows(i).Cells(3).Value = reader.GetString(2)
                dgv_purchaseOrder.Rows(i).Cells(4).Value = reader.GetString(3)
                dgv_purchaseOrder.Rows(i).Cells(6).Value = diapilpil.selectedNota
                'dgv_purchaseOrder.Rows.Add(i + 1, reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3))
                i += 1
            End While
            reader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            reader.Close()
        End Try
    End Sub

    Private Sub b_save_Click(sender As Object, e As EventArgs) Handles b_save.Click
        Dim rowCount As Int16 = dgv_purchaseOrder.Rows.Count
        Dim namaSupplier As String = tb_supplier.Text
        Dim kode_supl As String
        Dim alamat As String
        Dim telp As String
        Dim fax As String
        Dim contact, npwp As String
        Dim hari As Integer
        Dim jatuhTempo As Date = dp_tanggalPO.Value.AddDays(hari)
        Dim caraBayar As String = "kredit"
        Dim item As Int16 = 0
        Dim tdiskSen = 0
        Dim tdiskRp = 0
        Dim TPPNsen = dgv_purchaseOrder.Rows(0).Cells(7).Value
        Dim TPPNRp = tb_pajak.Text
        Dim sTotalHarga = 0
        Dim keterangan As String = tb_keterangan.Text
        Dim status = 1
        Dim user = "singo"

        If stat Then
            Dim cmd_supplier As New MySqlCommand("select kode_supl, alamat, telpon, fax, contact, npwp, hari from supplier where nama = '" & namaSupplier & "'", conn)
            Dim reader As MySqlDataReader = cmd_supplier.ExecuteReader
            Try
                While reader.Read
                    kode_supl = reader.GetString(0)
                    alamat = reader.GetString(1)
                    telp = reader.GetString(2)
                    fax = reader.GetString(3)
                    contact = reader.GetString(4)
                    npwp = reader.GetString(5)
                    hari = reader.GetString(6)
                End While
                reader.Close()
            Catch ex As Exception 'DURUNG JELAS PALING NULL REFRENCE -> BUAT YANG NULL REFENCE KASIH NULL AJA
                Console.WriteLine(ex.ToString)
                'MsgBox("err : " & ex.ToString)
                reader.Close()
                'MsgBox("err : " & ex.ToString)
            End Try
            Dim quer_poheader As String = "INSERT INTO `po_header`(`Nota`, `Tanggal`, `NoPP`, `CaraBayar`, `Bagian`, `Kode_Supl`, `Nama`, `alamat`, `Telp`, `Fax`, `Attn`, `NPWP`, `Hari`, `JthTempo`, `Item`, `Total`, `TDiskSen`, `TDiskRp`, `STotal`, `TPPNsen`, `TPPNRp`, `GTotal`, `Keterangan`, `Status`, `UserID`) VALUES ('" & tb_nomorPO.Text & "','" & dp_tanggalPO.Value.ToString("yyyy-MM-dd") & "','" & diapilpil.selectedNota & "','" & caraBayar & "','" & tb_bagian.Text & "','" & kode_supl & "','" & namaSupplier & "','" & alamat & "','" & telp & "','" & fax & "','" & contact & "','" & npwp & "','" & hari & "','" & jatuhTempo.ToString("yyyy-MM-dd") & "','" & item & "','" & tb_totalHarga.Text & "','" & tdiskSen & "','" & tdiskRp & "','" & sTotalHarga & "','" & TPPNsen & "','" & TPPNRp & "','" & tb_grandTotal.Text & "','" & keterangan & "','" & status & "','" & user & "')"
            '.WriteLine(quer_poheader)
            Dim cmd_poheader As New MySqlCommand
            Dim tr As MySqlTransaction
            tr = conn.BeginTransaction

            Try
                cmd_poheader.Connection = conn
                cmd_poheader.CommandText = quer_poheader
                cmd_poheader.ExecuteNonQuery()
            Catch ex As Exception
                'MsgBox("err : " & ex.ToString)
                Console.WriteLine("err : " & ex.ToString)
            End Try

            Dim cmd_podetail As New MySqlCommand
            For i As Int16 = 0 To rowCount - 2
                Try
                    Dim noseri = 0
                    Dim currency = "Rp"
                    Dim jumlahHarga As Double = 0.0
                    Dim ordere As Double = 0.0
                    Dim sisa = 0
                    Dim groupe As String = ""
                    Dim subgroup As String = "subgroup"
                    Dim statusid As String = ""
                    Dim flag = 0
                    Dim jam = ""
                    Dim userid As String = "singo"
                    'Console.WriteLine(dgv_purchaseOrder.Rows(i).Cells("No").Value & " " & dgv_purchaseOrder.Rows(i).Cells(1).Value & " " & dgv_purchaseOrder.Rows(i).Cells(2).Value)
                    Dim quer_podetail As String = "INSERT INTO `po_detail`(`Nota`, `Tanggal`, `NoPP`, `Kode_supl`, `SNama`, `Bagian`, `Nomor`, `Kode_Brg`, `Nama`, `Satuan`, `noseri`, `Curr`, `Harga`, `Qty`, `Jumlah`, `ordere`, `Sisa`, `Groupe`, `Subgroup`, `StatusD`, `Flag`, `UserID`, `Jam`) VALUES ('" & tb_nomorPO.Text & "','" & dp_tanggalPO.Value.ToString("yyyy-MM-dd") & "','" & dgv_purchaseOrder.Rows(i).Cells("no_pp").Value & "','" & kode_supl & "','" & namaSupplier & "','" & tb_bagian.Text & "','" & i + 1 & "','" & dgv_purchaseOrder.Rows(i).Cells("kode_brg").Value & "','" & dgv_purchaseOrder.Rows(i).Cells("nama_barang").Value & "','" & dgv_purchaseOrder.Rows(i).Cells("unit").Value & "','" & noseri & "','" & currency & "','" & dgv_purchaseOrder.Rows(i).Cells("harga").Value & "','" & dgv_purchaseOrder.Rows(i).Cells("jumlah").Value & "','" & jumlahHarga & "','" & ordere & "','" & sisa & "','" & groupe & "','" & subgroup & "','" & statusid & "','" & flag & "','" & userid & "', '" & jam & "')"
                    Console.WriteLine(quer_podetail)
                    cmd_podetail.Connection = conn
                    cmd_podetail.CommandText = quer_podetail
                    cmd_podetail.ExecuteNonQuery()
                    MsgBox("data berhasil disimpan..")
                Catch ex As Exception
                    Console.WriteLine(ex.ToString)
                    MsgBox("err : " & ex.ToString)
                End Try
            Next

            tr.Commit()
        Else
            '==================================== EDIT PO ===========================================
            Dim cmd_hpsisi As New MySqlCommand("DELETE FROM `po_detail` WHERE Nota = '" & tb_nomorPO.Text & "'", conn)
            Try
                cmd_hpsisi.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine(ex.ToString)
            End Try
            Dim cmd_supplier As New MySqlCommand("select kode_supl, alamat, telpon, fax, contact, npwp, hari from supplier where nama = '" & namaSupplier & "'", conn)
            Dim reader As MySqlDataReader = cmd_supplier.ExecuteReader
            Try
                While reader.Read
                    kode_supl = reader.GetString(0)
                    alamat = reader.GetString(1)
                    telp = reader.GetString(2)
                    fax = reader.GetString(3)
                    contact = reader.GetString(4)
                    npwp = reader.GetString(5)
                    hari = reader.GetString(6)
                End While
                reader.Close()
            Catch ex As Exception 'DURUNG JELAS PALING NULL REFRENCE -> BUAT YANG NULL REFENCE KASIH NULL AJA
                Console.WriteLine(ex.ToString)
                'MsgBox("err : " & ex.ToString)
                reader.Close()
            End Try
            'Dim quer_poheader As String = "INSERT INTO `po_header`(`Nota`, `Tanggal`, `NoPP`, `CaraBayar`, `Bagian`, `Kode_Supl`, `Nama`, `alamat`, `Telp`, `Fax`, `Attn`, `NPWP`, `Hari`, `JthTempo`, `Item`, `Total`, `TDiskSen`, `TDiskRp`, `STotal`, `TPPNsen`, `TPPNRp`, `GTotal`, `Keterangan`, `Status`, `UserID`) VALUES ('" & tb_nomorPO.Text & "','" & dp_tanggalPO.Value.ToString("yyyy-MM-dd") & "','" & diapilpil.selectedNota & "','" & caraBayar & "','" & tb_bagian.Text & "','" & kode_supl & "','" & namaSupplier & "','" & alamat & "','" & telp & "','" & fax & "','" & contact & "','" & npwp & "','" & hari & "','" & jatuhTempo.ToString("yyyy-MM-dd") & "','" & item & "','" & tb_totalHarga.Text & "','" & tdiskSen & "','" & tdiskRp & "','" & sTotalHarga & "','" & TPPNsen & "','" & TPPNRp & "','" & tb_grandTotal.Text & "','" & keterangan & "','" & status & "','" & user & "')"
            Dim quer_poheader As String = "UPDATE `po_header` SET `Tanggal`='" & dp_tanggalPO.Value.ToString("yyyy-MM-dd") & "',`NoPP`='" & tb_nomorPO.Text & "',`CaraBayar`='" & caraBayar & "',`Bagian`='" & tb_bagian.Text & "',`Kode_Supl`='" & kode_supl & "',`Nama`='" & namaSupplier & "',`alamat`='" & alamat & "',`Telp`='" & telp & "',`Fax`='" & fax & "',`Attn`='" & contact & "',`NPWP`='" & npwp & "',`Hari`='" & hari & "',`JthTempo`='" & jatuhTempo & "',`Item`='" & item & "',`Total`='" & totalHarga & "',`TDiskSen`='" & tdiskSen & "',`TDiskRp`='" & tdiskRp & "',`STotal`='" & sTotalHarga & "',`TPPNsen`='" & TPPNsen & "',`TPPNRp`='" & TPPNRp & "',`GTotal`='" & grandTotal & "',`Keterangan`='" & keterangan & "',`Status`='" & status & "',`UserID`='" & user & "' WHERE nota = '" & tb_nomorPO.Text & "'"
            '.WriteLine(quer_poheader)
            Dim cmd_poheader As New MySqlCommand
            Dim tr As MySqlTransaction
            tr = conn.BeginTransaction

            Try
                cmd_poheader.Connection = conn
                cmd_poheader.CommandText = quer_poheader
                cmd_poheader.ExecuteNonQuery()
            Catch ex As Exception
                'MsgBox("err : " & ex.ToString)
                Console.WriteLine("err : " & ex.ToString)
            End Try
            Dim cmd_podetail As New MySqlCommand
            For i As Int16 = 0 To rowCount - 2
                Try
                    Dim noseri = 0
                    Dim currency = "Rp"
                    Dim jumlahHarga As Double = 0.0
                    Dim ordere As Double = 0.0
                    Dim sisa = 0
                    Dim groupe As String = ""
                    Dim subgroup As String = "subgroup"
                    Dim statusid As String = ""
                    Dim flag = 0
                    Dim jam = ""
                    Dim userid As String = "singo"
                    'Console.WriteLine(dgv_purchaseOrder.Rows(i).Cells("No").Value & " " & dgv_purchaseOrder.Rows(i).Cells(1).Value & " " & dgv_purchaseOrder.Rows(i).Cells(2).Value)
                    Dim quer_podetail As String = "INSERT INTO `po_detail`(`Nota`, `Tanggal`, `NoPP`, `Kode_supl`, `SNama`, `Bagian`, `Nomor`, `Kode_Brg`, `Nama`, `Satuan`, `noseri`, `Curr`, `Harga`, `Qty`, `Jumlah`, `ordere`, `Sisa`, `Groupe`, `Subgroup`, `StatusD`, `Flag`, `UserID`, `Jam`) VALUES ('" & tb_nomorPO.Text & "','" & dp_tanggalPO.Value.ToString("yyyy-MM-dd") & "','" & dgv_purchaseOrder.Rows(i).Cells("no_pp").Value & "','" & kode_supl & "','" & namaSupplier & "','" & tb_bagian.Text & "','" & i + 1 & "','" & dgv_purchaseOrder.Rows(i).Cells("kode_brg").Value & "','" & dgv_purchaseOrder.Rows(i).Cells("nama_barang").Value & "','" & dgv_purchaseOrder.Rows(i).Cells("unit").Value & "','" & noseri & "','" & currency & "','" & dgv_purchaseOrder.Rows(i).Cells("harga").Value & "','" & dgv_purchaseOrder.Rows(i).Cells("jumlah").Value & "','" & jumlahHarga & "','" & ordere & "','" & sisa & "','" & groupe & "','" & subgroup & "','" & statusid & "','" & flag & "','" & userid & "', '" & jam & "')"
                    'Dim quer_podetail As String = "UPDATE `po_detail` SET `Tanggal`='" & dp_tanggalPO.Value.ToString("yyyy-MM-dd") & "',`NoPP`='" & dgv_purchaseOrder.Rows(i).Cells("no_pp").Value & "',`Kode_supl`='" & kode_supl & "',`SNama`='" & namaSupplier & "',`Bagian`='" & tb_bagian.Text & "',`Kode_Brg`='" & dgv_purchaseOrder.Rows(i).Cells("kode_brg").Value & "',`Nama`='" & dgv_purchaseOrder.Rows(i).Cells("nama_barang").Value & "',`Satuan`='" & dgv_purchaseOrder.Rows(i).Cells("unit").Value & "',`noseri`='" & noseri & "',`Curr`='" & currency & "',`Harga`='" & dgv_purchaseOrder.Rows(i).Cells("harga").Value & "',`Qty`='" & dgv_purchaseOrder.Rows(i).Cells("jumlah").Value & "',`Jumlah`='" & jumlahHarga & "',`ordere`='" & ordere & "',`Sisa`='" & sisa & "',`Groupe`='" & groupe & "',`Subgroup`='" & subgroup & "',`StatusD`='" & statusid & "',`Flag`='" & flag & "',`UserID`='" & userid & "',`Jam`='' WHERE nota = '" & tb_nomorPO.Text & "' and nomor = '" & dgv_purchaseOrder.Rows(i).Cells(0).Value & "'"

                    Console.WriteLine(quer_podetail)
                    cmd_podetail.Connection = conn
                    cmd_podetail.CommandText = quer_podetail
                    cmd_podetail.ExecuteNonQuery()
                    MsgBox("data berhasil di update")
                Catch ex As Exception
                    Console.WriteLine(ex.ToString)
                    MsgBox("err : " & ex.ToString)
                End Try
            Next
            tr.Commit()
        End If
        Me.Close()
    End Sub


End Class
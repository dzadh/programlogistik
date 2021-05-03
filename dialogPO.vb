Imports MySql.Data.MySqlClient
Public Class dialogPO
    Dim conn As New MySqlConnection
    Dim autoSupplier As New AutoCompleteStringCollection
    Dim autoBarang As New AutoCompleteStringCollection
    Public nomorPurchaseOrder As String
    Dim lastEditedCellRow As Int16
    Dim lastEditedCellColumn As Int16
    Public selectedNota As String
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
        Else
            Console.WriteLine("singo")
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
            reader.Close()
            'MsgBox("err : " & ex.ToString)
        End Try
        Dim quer_poheader As String = "INSERT INTO `po_header`(`Nota`, `Tanggal`, `NoPP`, `CaraBayar`, `Bagian`, `Kode_Supl`, `Nama`, `alamat`, `Telp`, `Fax`, `Attn`, `NPWP`, `Hari`, `JthTempo`, `Item`, `Total`, `TDiskSen`, `TDiskRp`, `STotal`, `TPPNsen`, `TPPNRp`, `GTotal`, `Keterangan`, `Status`, `UserID`)_
        VALUES ('" & tb_nomorPO.Text & "','" & dp_tanggalPO.Text & "','" & selectedNota & "',[value-4],[value-5],[value-6],[value-7],[value-8],[value-9],[value-10],[value-11],[value-12],[value-13],[value-14],[value-15],[value-16],[value-17],[value-18],[value-19],[value-20],[value-21],[value-22],[value-23],[value-24],[value-25])"


        For i As Int16 = 0 To rowCount
            Try

            Catch ex As Exception

            End Try
        Next
    End Sub


End Class
Imports MySql.Data.MySqlClient
Imports PlaceHoldingTextBox1

Public Class home
    Dim da As MySqlDataAdapter
    Private tabcount As Int16 = 1
    Private conn As New MySqlConnection
    Public currentCellValue As String
    Public dss As New DataSet
    Public dataSetBarang As New DataSet
    Public datasetSupplier As New DataSet
    Public dataSetPP As New DataSet
    Public datasetPo As New DataSet
    Public datasetBTB As New DataSet

    Dim tb_searchbarangbyname As New TextBox
    Dim tb_searchbarangByNomor As New TextBox
    Dim tb_cariNamaDivisi As New TextBox
    Dim tb_cariNamaSupplier As New TextBox

    Public Sub b_addtab_Click(sender As Object, e As EventArgs)
        Dim newtab As New TabPage
        Dim newtextbox As New TextBox
        Dim newbutt As New Button
        Dim editButton As New Button
        newtab.Name = "New Tab " & tabcount.ToString
        newtab.Text = "New Tab " & tabcount.ToString
        newbutt.Name = "newtab" & tabcount.ToString
        newbutt.Text = "Close Newtab" & tabcount.ToString
        newbutt.Location = New Point(20, 30)
        newbutt.AutoSize = True

        newtextbox.Text = "New textbox on new tab " & tabcount.ToString
        tabcount += 1
        AddHandler newbutt.Click, AddressOf newbutt_click
        Me.TabControl1.Controls.Add(newtab)
        newtab.Controls.Add(newtextbox)
        newtab.Controls.Add(newbutt)
        Me.TabControl1.SelectedIndex = Me.TabControl1.TabCount - 1
    End Sub

    Private Sub newbutt_click(sender As Object, e As EventArgs)
        Me.TabControl1.TabPages.Remove(TabControl1.SelectedTab)
        'Console.WriteLine(sender.ToString() & "\n")
    End Sub

    Public Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cs As String
        Dim database As String = "dblogistik"
        Dim username As String = "root"
        Dim host As String = "localhost"
        Dim password As String = ""
        cs = "Database=" & database & ";Data Source=" & host & ";User Id=" & username & ";Password=" & password & ";Convert Zero Datetime=True"
        conn.ConnectionString = cs
        Try
            conn.Open()
            'MsgBox("connection success")
            l_statusdb.Text = "Connected"
            'Console.WriteLine(conn.State)
        Catch ex As Exception
            MsgBox("connection failed " & ex.ToString)
        End Try

        'Dim sql As String = "SELECT * FROM `pp_header` WHERE Tanggal BETWEEN '2021-02-1' AND '2021-02-27'"
        Dim sql As String = "SELECT * FROM pp_header"
        Try
            Dim daa As New MySqlDataAdapter(sql, conn)
            daa.Fill(dataSetPP, "singo")
            Me.DataGridView1.DataSource = dataSetPP.Tables("singo")
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            MsgBox("error : " & ex.ToString)
        End Try

        'ambil data table po header
        sql = "SELECT * FROM po_header WHERE Tanggal BETWEEN '2021-01-1' AND '2021-02-27'"
        'sql = "SELECT * FROM po_header"

        Try
            Dim da_po As New MySqlDataAdapter(sql, conn)
            da_po.Fill(datasetPo, "tabel_po")
            Me.DataGridView2.DataSource = datasetPo.Tables("tabel_po")
        Catch ex As Exception
            Console.WriteLine("error : " & ex.ToString)
            MsgBox("error : " & ex.ToString)
        End Try

        sql = "SELECT * FROM `btb_header`"
        Try
            Dim da_btb As New MySqlDataAdapter(sql, conn)
            da_btb.Fill(datasetBTB, "dataset_btb")
            Me.DataGridView3.DataSource = datasetBTB.Tables("dataset_btb")
        Catch ex As Exception
            Console.WriteLine("error : " & ex.ToString)
            MsgBox("error : " & ex.ToString)
        End Try

    End Sub

    'suppose to be tabcontrolex1
    'Private Sub b_tambahtab2_Click(sender As Object, e As EventArgs) Handles b_tambahtab2.Click
    '    Dim newtab As New TabPage
    '    Dim newtextbox As New TextBox
    '    Dim newbutt As New Button
    '    newtab.Name = "New Tab " & tabcount.ToString
    '    newtab.Text = "Tambah PP " & tabcount.ToString & "     "
    '    newbutt.Name = "newtab" & tabcount.ToString
    '    newbutt.Text = "Close Newtab" & tabcount.ToString
    '    newbutt.Location = New Point(20, 30)
    '    newbutt.AutoSize = True
    '    newtextbox.Text = "New textbox on new tab " & tabcount.ToString
    '    tabcount += 1
    '    AddHandler newbutt.Click, AddressOf newbutt_click
    '    Me.TabControl1.Controls.Add(newtab)
    '    newtab.Controls.Add(newtextbox)
    '    newtab.Controls.Add(newbutt)
    '    Me.TabControl1.SelectedIndex = Me.TabControl1.TabCount - 1
    'End Sub
    ' end of suppose to be tabcontrolex1

    '=============================== TAB ADATA BAGIAN ========================================
    Friend Sub DataBagianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBagianToolStripMenuItem.Click
        Dim newtab As New TabPage
        Dim newtextbox As New TextBox
        Dim newbutt As New Button
        Dim editButton As New Button
        'Dim dgv_databagian As New DataGridView
        Dim tambahButton As New Button
        Dim hapusButton As New Button
        Dim ukuran As New Size(75, 39)

        dgv_databagian.RowHeadersVisible = False

        newtab.Name = "TabelBagian"
        newtab.Text = "Tabel Bagian"
        newbutt.Name = "newtab" & tabcount.ToString
        newbutt.Text = "Tutup Tab"
        newbutt.Location = New Point(210, 562)
        newbutt.Size = ukuran
        newbutt.Anchor = AnchorStyles.Bottom + AnchorStyles.Left
        newbutt.AutoSize = True

        editButton.Name = "editButton"
        editButton.Location = New Point(372, 562)
        editButton.Size = ukuran
        editButton.Anchor = AnchorStyles.Bottom + AnchorStyles.Left
        editButton.Text = "Edit"

        tambahButton.Name = "tambahButton"
        tambahButton.Location = New Point(291, 562)
        tambahButton.Size = ukuran
        tambahButton.Anchor = AnchorStyles.Bottom + AnchorStyles.Left
        tambahButton.Text = "Tambah"

        hapusButton.Name = "hapusButton"
        hapusButton.Location = New Point(453, 562)
        hapusButton.Anchor = AnchorStyles.Bottom + AnchorStyles.Left
        hapusButton.Size = ukuran
        hapusButton.Text = "Hapus"

        Dim searchLabel As New Label
        searchLabel.Text = "PENCARIAN"
        searchLabel.Location = New Point(17, 17)
        searchLabel.Size = New Size(93, 18)
        searchLabel.Font = New Font("Microsoft Sans Serif", 11.25)

        Dim cariNamaDivisi_label As New Label
        cariNamaDivisi_label.Text = "Nama Divisi"
        cariNamaDivisi_label.Location = New Point(18, 45)
        cariNamaDivisi_label.Size = New Size(100, 13)

        tb_cariNamaDivisi.Location = New Point(20, 62)
        tb_cariNamaDivisi.Size = New Size(163, 24)
        tb_cariNamaDivisi.Font = New Font("Microsoft Sans Serif", 11)


        'dgv_databagian.Location = New Point(6, 6)
        'dgv_databagian.Size = New Size(803, 290)
        'dgv_databagian.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_databagian.Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
        'dgv_databagian.ReadOnly = True
        tabcount += 1
        AddHandler newbutt.Click, AddressOf newbutt_click
        Me.TabControl1.Controls.Add(newtab)
        'add to windows
        'newtab.Controls.Add(newtextbox)
        newtab.Controls.Add(newbutt)
        newtab.Controls.Add(dgv_databagian)
        newtab.Controls.Add(editButton)
        newtab.Controls.Add(tambahButton)
        newtab.Controls.Add(hapusButton)
        newtab.Controls.Add(searchLabel)
        newtab.Controls.Add(cariNamaDivisi_label)
        newtab.Controls.Add(tb_cariNamaDivisi)

        Me.TabControl1.SelectedIndex = Me.TabControl1.TabCount - 1
        Dim Sql As String = "SELECT * FROM `tblbagian`"
        Try
            dss.Clear()
            Dim da_po As New MySqlDataAdapter(Sql, conn)
            da_po.Fill(dss, "tabel_po")
            dgv_databagian.DataSource = dss.Tables("tabel_po")
        Catch ex As Exception
            Console.WriteLine("error : " & ex.ToString)
        End Try
        'AddHandler dgv_databagian.SelectionChanged, Sub() currentCellValue = dgv_databagian.CurrentRow.Cells(1).Value.ToString

        AddHandler editButton.Click, AddressOf editButtonClicked
        AddHandler tambahButton.Click, AddressOf tambahButtonClicked
        AddHandler hapusButton.Click, AddressOf hapusButtonClicked
        AddHandler tb_cariNamaDivisi.TextChanged, AddressOf cariNamaDivisi
    End Sub

    Private Sub hapusButtonClicked()
        'Console.WriteLine("Hapus button clicked")
        currentCellValue = dgv_databagian.CurrentRow.Cells(1).Value.ToString
        Dim bagian As String = dgv_databagian.CurrentRow.Cells(0).Value.ToString
        Dim result1 As DialogResult = MsgBox("Apakah anda yakin akan menghapus bagian " & bagian & "?", MsgBoxStyle.OkCancel)
        Dim sql As String
        Console.WriteLine(result1)
        If result1 Then
            sql = "DELETE FROM tblbagian WHERE kode = '" & currentCellValue & "' AND Bagian = '" & bagian & "'"

            Dim cmd As New MySqlCommand
            Dim tr As MySqlTransaction
            tr = conn.BeginTransaction
            Try
                cmd.Connection = conn
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
                tr.Commit()
                MsgBox("Data berhasil dihapus..")
            Catch ex As Exception
                Console.WriteLine("Error : " & ex.ToString)
                MsgBox("Data gagal dihapus : " & ex.ToString)
            End Try

        End If

    End Sub

    Private Sub editButtonClicked()
        currentCellValue = dgv_databagian.CurrentRow.Cells(1).Value.ToString
        Dim dia As New dialog_editbagian With {.kodeBagian = currentCellValue}
        Console.WriteLine()
        dia.Show()
        AddHandler dia.Disposed, AddressOf diadispose
        ' dgv_databagian.Rows.Clear()

    End Sub

    Private Sub diadispose()
        Console.WriteLine("dia disposed")
        updateDataSource()
    End Sub

    Private Sub tambahButtonClicked()
        Dim dia As New dialog_editbagian
        dia.Show()
    End Sub

    Private Sub updateDataSource()
        Dim sql As String = "SELECT * FROM tblbagian"
        Try
            Dim da_po As New MySqlDataAdapter(sql, conn)
            dss.Tables("tabel_po").Clear()
            da_po.Fill(dss, "tabel_po")
            dgv_databagian.Refresh()
        Catch ex As Exception
            MsgBox("error : " & ex.ToString)
            Console.WriteLine("error : " & ex.ToString)
        End Try
    End Sub

    Private Sub cariNamaDivisi()
        Dim quer As String = "SELECT *  FROM `tblbagian` WHERE `Bagian` LIKE '%" & tb_cariNamaDivisi.Text & "%' ORDER BY `kode` ASC"
        Try
            dss.Clear()
            Dim da_bagian As New MySqlDataAdapter(quer, conn)
            da_bagian.Fill(dss, "tabel_po")
            dgv_databagian.Refresh()
        Catch ex As Exception
            Console.WriteLine("err : " & ex.ToString)
            MsgBox(ex.ToString)
        End Try
    End Sub
    '============================== END OF TAB DATA BAGIAN ================================

    '============================== DAFTAR BARANG ===========================================
    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        Dim tabDataBarang As New TabPage
        Dim closeButton As New Button
        Dim tambahBarang As New Button
        Dim editBarang As New Button
        Dim hapusBarang As New Button
        Dim ukuran As New Size(75, 39)

        dgv_databarang.RowHeadersVisible = False

        tabDataBarang.Name = "tabelBarang"
        tabDataBarang.Text = "Tabel Barang"
        tabDataBarang.UseVisualStyleBackColor = True
        dgv_databarang.Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top


        Dim pencarianLabel As New Label
        pencarianLabel.Text = "PENCARIAN"
        pencarianLabel.Location = New Point(17, 17)
        pencarianLabel.Size = New Size(93, 18)
        pencarianLabel.Font = New Font("Microsoft Sans Serif", 11.25)

        Dim l_searchbyname As New Label
        l_searchbyname.Text = "Nama Barang"
        l_searchbyname.Location = New Point(18, 45)
        l_searchbyname.Size = New Size(100, 13)


        tb_searchbarangbyname.Location = New Point(20, 62)
        tb_searchbarangbyname.Size = New Size(163, 24)
        tb_searchbarangbyname.Font = New Font("Microsoft Sans Serif", 11)

        Dim l_searchbynomorbarang As New Label
        l_searchbynomorbarang.Text = "Nomor Barang"
        l_searchbynomorbarang.Location = New Point(18, 95)
        l_searchbynomorbarang.Size = New Size(100, 13)

        tb_searchbarangByNomor.Location = New Point(20, 113)
        tb_searchbarangByNomor.Size = New Size(163, 24)
        tb_searchbarangByNomor.Font = New Font("Microsoft Sans Serif", 11)

        Dim b_caribarang As New Button
        b_caribarang.Text = "Cari"
        b_caribarang.Location = New Point(108, 143)
        b_caribarang.Size = New Size(75, 23)

        closeButton.Name = "closeButton"
        closeButton.Text = "Tutup Tab"
        closeButton.Location = New Point(210, 562)
        closeButton.Size = ukuran
        closeButton.Anchor = AnchorStyles.Bottom + AnchorStyles.Left

        tambahBarang.Name = "tambahBarang"
        tambahBarang.Text = "Tambah Barang"
        tambahBarang.Location = New Point(291, 562)
        tambahBarang.Size = ukuran
        tambahBarang.Anchor = AnchorStyles.Bottom + AnchorStyles.Left

        editBarang.Name = "editBarang"
        editBarang.Text = "Edit Barang"
        editBarang.Location = New Point(372, 562)
        editBarang.Size = ukuran
        editBarang.Anchor = AnchorStyles.Bottom + AnchorStyles.Left

        hapusBarang.Name = "hapusBarang"
        hapusBarang.Text = "Hapus Barang"
        hapusBarang.Location = New Point(453, 562)
        hapusBarang.Size = ukuran
        hapusBarang.Anchor = AnchorStyles.Bottom + AnchorStyles.Left

        Me.TabControl1.TabPages.Add(tabDataBarang)
        Me.TabControl1.SelectedIndex = TabControl1.TabCount - 1
        tabDataBarang.Controls.Add(closeButton)
        tabDataBarang.Controls.Add(tambahBarang)
        tabDataBarang.Controls.Add(editBarang)
        tabDataBarang.Controls.Add(hapusBarang)
        tabDataBarang.Controls.Add(dgv_databarang)
        tabDataBarang.Controls.Add(pencarianLabel)
        tabDataBarang.Controls.Add(l_searchbyname)
        tabDataBarang.Controls.Add(tb_searchbarangbyname)
        tabDataBarang.Controls.Add(l_searchbynomorbarang)
        tabDataBarang.Controls.Add(tb_searchbarangByNomor)
        tabDataBarang.Controls.Add(b_caribarang)

        'Dim sql As String = "SELECT KODE_BRG, NAMA,SATUAN,Stock,rak,TglBeli,HargaBeli,HargaPokok,RpJumlah FROM `barang`"
        Dim sql As String = "SELECT * FROM barang"
        Try
            dataSetBarang.Clear()
            Dim da_databarang As New MySqlDataAdapter(sql, conn)
            da_databarang.Fill(dataSetBarang, "tabel_barang")
            dgv_databarang.DataSource = dataSetBarang.Tables("tabel_barang")
        Catch ex As Exception
            Console.WriteLine("error : " & ex.ToString)
            MsgBox("error : " & ex.ToString)
        End Try

        AddHandler closeButton.Click, AddressOf closeTabDataBarang
        AddHandler tambahBarang.Click, AddressOf tambahBarang_Clicked
        AddHandler editBarang.Click, AddressOf editBarang_Clicked
        AddHandler hapusBarang.Click, AddressOf hapusBarang_clicked
        AddHandler b_caribarang.Click, AddressOf cariBarang
    End Sub

    Private Sub closeTabDataBarang()
        Me.TabControl1.TabPages.Remove(Me.TabControl1.SelectedTab)
    End Sub

    Private Sub tambahBarang_Clicked()
        Dim diabar As New dialogEditBarang
        diabar.Show()
        'Console.WriteLine("tambah barang clicked")
        AddHandler diabar.Disposed, AddressOf diabarDisposed
    End Sub

    Private Sub editBarang_Clicked()
        Dim diabar As New dialogEditBarang With {.kodeBarang = dgv_databarang.CurrentRow.Cells(0).Value.ToString}
        diabar.Show()
        AddHandler diabar.Disposed, AddressOf diabarDisposed
        'Console.WriteLine("edit barang clicked")
    End Sub

    Private Sub hapusBarang_clicked()
        'Console.WriteLine("hapus barang clicked")
        Dim namabar = dgv_databarang.CurrentRow.Cells(2).Value.ToString
        Dim kodebar = dgv_databarang.CurrentRow.Cells(0).Value.ToString
        Dim DialogResult As DialogResult = MsgBox("Apakah anda yakin akan menghapus " & namabar & "?", MsgBoxStyle.OkCancel)
        Dim sql As String
        'Console.WriteLine(DialogResult)
        If DialogResult = 1 Then
            sql = "DELETE FROM `barang` WHERE `KODE_BRG`='" & kodebar & "'"
            Try
                Dim cmd As New MySqlCommand
                Dim tr As MySqlTransaction
                tr = conn.BeginTransaction
                cmd.Connection = conn
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
                tr.Commit()
                MsgBox("data berhasil dihapus..")
                diabarDisposed()

            Catch ex As Exception
                Console.WriteLine("err : " & ex.ToString)
                MsgBox("data gagal dihapus : " & ex.ToString)
            End Try
        End If
    End Sub

    Private Sub diabarDisposed()
        updateDatabarangDataSource()
    End Sub

    Private Sub updateDatabarangDataSource()
        Dim sql As String = "SELECT * FROM barang"
        Try
            Dim da_po As New MySqlDataAdapter(sql, conn)
            dataSetBarang.Clear()
            da_po.Fill(dataSetBarang, "tabel_barang")
            dgv_databarang.Refresh()
        Catch ex As Exception
            Console.WriteLine("err : " & ex.ToString)
            MsgBox("err : " & ex.ToString)
        End Try
    End Sub

    Private Sub cariBarang()
        Dim quer As String
        Console.WriteLine(String.IsNullOrEmpty(tb_searchbarangbyname.Text) & " " & String.IsNullOrEmpty(tb_searchbarangByNomor.Text))

        If String.IsNullOrEmpty(tb_searchbarangbyname.Text) = False And String.IsNullOrEmpty(tb_searchbarangByNomor.Text) = True Then
            quer = "select * from barang where nama like '%" & tb_searchbarangbyname.Text & "%'"
        ElseIf String.IsNullOrEmpty(tb_searchbarangByNomor.Text) = False And String.IsNullOrEmpty(tb_searchbarangbyname.Text) = True Then
            quer = "select * from barang where kode_brg like '%" & tb_searchbarangByNomor.Text & "%'"
        Else
            quer = "select * from barang where nama like  '%" & tb_searchbarangbyname.Text & "%' or kode_brg like '%" & tb_searchbarangByNomor.Text & "%'"
        End If
        Console.WriteLine(quer)
        Try
            Dim da_barang As New MySqlDataAdapter(quer, conn)
            dataSetBarang.Clear()
            da_barang.Fill(dataSetBarang, "tabel_barang")
            dgv_databarang.Refresh()
        Catch ex As Exception
            Console.WriteLine("err : " & ex.ToString)
            MsgBox("err : " & ex.ToString)
        End Try

    End Sub

    '==================================== END OF DAFTAR BARANG =================================

    '==================================== TAB DAFTAR SUPPLIER ====================================

    Private Sub DataSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSupplierToolStripMenuItem.Click
        Dim tabDataSupplier As New TabPage
        Dim closeDataSupplier As New Button
        Dim tambahSupplier As New Button
        Dim editSupplier As New Button
        Dim hapusSupplier As New Button
        Dim ukuran As New Size(75, 39)

        dgv_datasupplier.RowHeadersVisible = False

        tabDataSupplier.Name = "tableSupplier"
        tabDataSupplier.Text = "Tabel Supplier"
        dgv_datasupplier.Anchor = AnchorStyles.Bottom + AnchorStyles.Top + AnchorStyles.Left + AnchorStyles.Right

        closeDataSupplier.Name = "closeDataSupplier"
        closeDataSupplier.Text = "Tutup tab"
        closeDataSupplier.Location = New Point(210, 562)
        closeDataSupplier.Size = ukuran
        closeDataSupplier.Anchor = AnchorStyles.Bottom + AnchorStyles.Left

        tambahSupplier.Name = "tambahSupplier"
        tambahSupplier.Text = "Tambah Supplier"
        tambahSupplier.Location = New Point(291, 562)
        tambahSupplier.Size = ukuran
        tambahSupplier.Anchor = AnchorStyles.Bottom + AnchorStyles.Left

        editSupplier.Name = "editSupplier"
        editSupplier.Text = "Edit Supplier"
        editSupplier.Location = New Point(372, 562)
        editSupplier.Size = ukuran
        editSupplier.Anchor = AnchorStyles.Bottom + AnchorStyles.Left

        hapusSupplier.Name = "hapusSupplier"
        hapusSupplier.Text = "Hapus Supplier"
        hapusSupplier.Location = New Point(453, 562)
        hapusSupplier.Size = ukuran
        hapusSupplier.Anchor = AnchorStyles.Bottom + AnchorStyles.Left

        Dim l_pencarian As New Label
        l_pencarian.Text = "PENCARIAN"
        l_pencarian.Location = New Point(17, 17)
        l_pencarian.Size = New Size(93, 18)
        l_pencarian.Font = New Font("microsoft sans serif", 11.25)

        Dim l_cariNamaSupplier As New Label
        l_cariNamaSupplier.Text = "Nama Supplier"
        l_cariNamaSupplier.Location = New Point(18, 45)
        l_cariNamaSupplier.Size = New Size(100, 13)


        tb_cariNamaSupplier.Location = New Point(20, 62)
        tb_cariNamaSupplier.Size = New Size(163, 24)
        tb_cariNamaSupplier.Font = New Font("microsoft sans serif", 11)

        Me.TabControl1.TabPages.Add(tabDataSupplier)
        Me.TabControl1.SelectedIndex = TabControl1.TabCount - 1

        tabDataSupplier.Controls.Add(dgv_datasupplier)
        tabDataSupplier.Controls.Add(closeDataSupplier)
        tabDataSupplier.Controls.Add(tambahSupplier)
        tabDataSupplier.Controls.Add(editSupplier)
        tabDataSupplier.Controls.Add(hapusSupplier)
        tabDataSupplier.Controls.Add(l_pencarian)
        tabDataSupplier.Controls.Add(l_cariNamaSupplier)
        tabDataSupplier.Controls.Add(tb_cariNamaSupplier)

        Dim sql As String = "SELECT * FROM supplier"
        Try
            datasetSupplier.Clear()
            Dim da_supplier As New MySqlDataAdapter(sql, conn)
            da_supplier.Fill(datasetSupplier, "data_supplier")
            dgv_datasupplier.DataSource = datasetSupplier.Tables("data_supplier")
        Catch ex As Exception
            Console.WriteLine("error :" & ex.ToString)
            MsgBox("error : " & ex.ToString)
        End Try

        AddHandler closeDataSupplier.Click, AddressOf tutupDaftarSupplier
        AddHandler tambahSupplier.Click, AddressOf tambahSupplier_clicked
        AddHandler editSupplier.Click, AddressOf editSupplier_clicked
        AddHandler hapusSupplier.Click, AddressOf hapusSupplier_clicked
        AddHandler tb_cariNamaSupplier.TextChanged, AddressOf cariNamaSuppier

    End Sub

    Private Sub tutupDaftarSupplier()
        Me.TabControl1.TabPages.Remove(Me.TabControl1.SelectedTab)
    End Sub

    Private Sub tambahSupplier_clicked()
        'Console.WriteLine("tambah supplier")
        Dim diasupp As New dialogSupplier
        diasupp.Show()
        AddHandler diasupp.Disposed, AddressOf diasuppDisposed
    End Sub

    Private Sub editSupplier_clicked()
        'Console.WriteLine("edit supplier")
        Dim diasupp As New dialogSupplier With {.kodeSupplier = dgv_datasupplier.CurrentRow.Cells(0).Value.ToString}
        diasupp.Show()
        AddHandler diasupp.Disposed, AddressOf diasuppDisposed
    End Sub

    Private Sub hapusSupplier_clicked() 'BELUM MENGHPUS MASIH DI COMMENT
        Dim namaSupp = dgv_datasupplier.CurrentRow.Cells(1).Value.ToString
        Dim kodeSupp = dgv_datasupplier.CurrentRow.Cells(0).Value.ToString
        Dim DialogResult As DialogResult = MsgBox("Apakah anda yakin akan menghapus " & namaSupp & "?", MsgBoxStyle.OkCancel)
        'Console.WriteLine(DialogResult)
        Dim sql As String
        If DialogResult = 1 Then
            sql = "DELETE FROM `supplier` WHERE `KODE_SUPL`='" & kodeSupp & "'"
            Try
                'Dim cmd As New MySqlCommand
                'Dim tr As MySqlTransaction
                'tr = conn.BeginTransaction
                'cmd.Connection = conn
                'cmd.CommandText = sql
                'cmd.ExecuteNonQuery()
                'tr.Commit()
                MsgBox("data berhasil dihapus..")
                diasuppDisposed()
            Catch ex As Exception
                Console.WriteLine("err : " & ex.ToString)
                MsgBox("data gagal dihapus : " & ex.ToString)
            End Try
        End If
    End Sub

    Private Sub diasuppDisposed()
        Dim sql As String = "SELECT * FROM supplier"
        Try
            datasetSupplier.Clear()
            Dim da_supplier As New MySqlDataAdapter(sql, conn)
            da_supplier.Fill(datasetSupplier, "data_supplier")
            dgv_datasupplier.Refresh()
        Catch ex As Exception
            Console.WriteLine("err : " & ex.ToString)
            MsgBox("err : " & ex.ToString)
        End Try
    End Sub

    Private Sub cariNamaSuppier()
        'Console.WriteLine("cari nama supplier")
        Dim quer As String = "SELECT *  FROM `supplier` WHERE `NAMA` LIKE '%" & tb_cariNamaSupplier.Text & "%'"
        Try
            datasetSupplier.Clear()
            Dim da_supplier As New MySqlDataAdapter(quer, conn)
            da_supplier.Fill(datasetSupplier, "data_supplier")
            dgv_datasupplier.Refresh()
        Catch ex As Exception
            Console.WriteLine("error : " & ex.ToString)
            MsgBox(ex.ToString)
        End Try
    End Sub
    '=========================================== END OF DAFTAR SUPPLIER ===================================

    '============================================== TAB PP START : DATAGRIDVIEW1 ==========================================
    Private Sub cb_filterTanggal_CheckedChanged(sender As Object, e As EventArgs) Handles cb_filterTanggal.CheckedChanged
        If cb_filterTanggal.Checked Then
            gb_filterTanggal.Visible = True
        Else
            gb_filterTanggal.Visible = False
        End If
    End Sub

    Private Sub tb_searchbyNomorNota(sender As Object, e As EventArgs) Handles tb_searchppbynota.TextChanged
        If cb_filterTanggal.Checked Then
            dataSetPP.Tables("singo").DefaultView.RowFilter = "Nota LIKE '*" & tb_searchppbynota.Text & "*'"
            DataGridView1.Refresh()
        Else
            If String.IsNullOrEmpty(tb_searchppbybagian.Text) Then
                dataSetPP.Clear()
                Dim sql As String = "SELECT * FROM `pp_header` WHERE Nota LIKE '%" & tb_searchppbynota.Text & "%'"
                'Console.WriteLine(sql)
                Dim daa As New MySqlDataAdapter(sql, conn)
                daa.Fill(dataSetPP, "singo")
                DataGridView1.Refresh()
            Else
                dataSetPP.Tables("singo").DefaultView.RowFilter = "Nota LIKE '*" & tb_searchppbynota.Text & "*'"
                DataGridView1.Refresh()
            End If
        End If
    End Sub

    Private Sub searchPPbyBagian(sender As Object, e As EventArgs) Handles tb_searchppbybagian.TextChanged
        If cb_filterTanggal.Checked Then
            dataSetPP.Tables("singo").DefaultView.RowFilter = "Bagian Like '*" & tb_searchppbybagian.Text & "*'"
            DataGridView1.Refresh()
        Else
            If String.IsNullOrEmpty(tb_searchppbynota.Text) Then
                dataSetPP.Clear()
                Dim query As String = "SELECT * FROM pp_header WHERE Bagian LIKE '%" & tb_searchppbybagian.Text & "%'"
                'Console.WriteLine(query)
                Dim da As New MySqlDataAdapter(query, conn)
                da.Fill(dataSetPP, "singo")
                DataGridView1.Refresh()
            Else
                dataSetPP.Tables("singo").DefaultView.RowFilter = "Bagian LIKE '*" & tb_searchppbybagian.Text & "*'"
                DataGridView1.Refresh()
            End If
        End If
    End Sub

    Private Sub dp_filtermulai_ValueChanged(sender As Object, e As EventArgs) Handles dp_filterDateStart.ValueChanged
        'Console.WriteLine(dp_filterDateStart.Value.ToString("yyyy-MM-dd"))
        If cb_filterTanggal.Checked Then
            dataSetPP.Clear()
            Dim query As String = "SELECT * FROM `pp_header` WHERE Tanggal BETWEEN '" & dp_filterDateStart.Value.ToString("yyyy-MM-dd") & "' AND '" & dp_filterDateEnd.Value.ToString("yyyy-MM-dd") & "'"
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(dataSetPP, "singo")
            DataGridView1.Refresh()
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dp_filterDateEnd.ValueChanged
        If cb_filterTanggal.Checked Then
            dataSetPP.Clear()
            Dim query As String = "SELECT * FROM `pp_header` WHERE Tanggal BETWEEN '" & dp_filterDateStart.Value.ToString("yyyy-MM-dd") & "' AND '" & dp_filterDateEnd.Value.ToString("yyyy-MM-dd") & "'"
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(dataSetPP, "singo")
            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub datagridView_KeyDown(sender As Object, x As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If x.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(x.RowIndex)
            'Console.WriteLine(row.Cells(0).Value.ToString)
            'txtID.Text = row.Cells(0).Value.ToString
            'txtName.Text = row.Cells(1).Value.ToString
            'txtCountry.Text = row.Cells(2).Value.ToString
        End If
    End Sub

    Private Sub b_buatPP_Click(sender As Object, e As EventArgs) Handles b_buatPP.Click
        Dim diaPP As New dialogPP
        diaPP.Show()

    End Sub

    Private Sub b_ubahPP_Click(sender As Object, e As EventArgs) Handles b_ubahPP.Click 'todo : eksep tidak ada row yang dipilih
        Dim diaPP As New dialogPP With {.nomorNota = DataGridView1.CurrentRow.Cells(0).Value.ToString}
        diaPP.Show()
    End Sub

    Private Sub b_hapusPP_Click(sender As Object, e As EventArgs) Handles b_hapusPP.Click

        Dim dialog_result As DialogResult = MsgBox("Apakah anda yakin menghapus PP nomor " & DataGridView1.CurrentRow.Cells(0).Value.ToString & " ?", MsgBoxStyle.OkCancel)
        If dialog_result = 1 Then
            Dim quer As String = "DELETE FROM `pp_header` WHERE Nota = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"
            Try
                Dim cmd As New MySqlCommand
                Dim tr As MySqlTransaction
                tr = conn.BeginTransaction
                cmd.Connection = conn
                cmd.CommandText = quer
                cmd.ExecuteNonQuery()
                cmd.CommandText = "DELETE FROM `pp_detail` WHERE Nota = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"
                cmd.ExecuteNonQuery()
                tr.Commit()
                MsgBox("Data berhasil dihapus")
            Catch ex As Exception
                MsgBox("Data gagal dihapus : " & ex.ToString)
                Console.WriteLine("data gagal dihapus " & ex.ToString)
            End Try
        End If
    End Sub

    '============================================== END OF TAB PP =======================================

    '============================================ TAB PO START ===========================================
    Private Sub cb_filterTanggalPo_CheckedChanged(sender As Object, e As EventArgs) Handles cb_filterTanggalPo.CheckedChanged
        If cb_filterTanggalPo.Checked Then
            gb_filterTglPo.Visible = True
        Else
            gb_filterTglPo.Visible = False
        End If
    End Sub

    Private Sub dp_filterTanggalPo_ValChanged(sender As Object, e As EventArgs) Handles dp_filterTglPOStart.ValueChanged

        If cb_filterTanggalPo.Checked Then
            datasetPo.Clear()
            Dim query As String = " SELECT * FROM po_header WHERE tanggal BETWEEN '" & dp_filterTglPOStart.Value.ToString("yyyy-MM-dd") & "' AND '" & dp_filterTglPOEnd.Value.ToString("yyyy-MM-dd") & "' "
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(datasetPo, "tabel_po")
            DataGridView2.Refresh()
        End If
    End Sub

    Private Sub dp_filterTglPOEnd_ValueChanged(sender As Object, e As EventArgs) Handles dp_filterTglPOEnd.ValueChanged
        If cb_filterTanggalPo.Checked Then
            datasetPo.Clear()
            Dim query As String = "SELECT * FROM po_header WHERE tanggal BETWEEN '" & dp_filterTglPOStart.Value.ToString("yyyy-MM-dd") & "' AND '" & dp_filterTglPOEnd.Value.ToString("yyy-MM-dd") & "'"
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(datasetPo, "tabel_po")
            DataGridView2.Refresh()
        End If
    End Sub

    Private Sub tb_searchPoByNomorNota_TextChanged(sender As Object, e As EventArgs) Handles tb_searchPoByNomorNota.TextChanged
        'If cb_filterTanggal.Checked Then
        '    dataSetPP.Tables("singo").DefaultView.RowFilter = "Nota LIKE '*" & tb_searchppbynota.Text & "*'"
        '    DataGridView1.Refresh()
        'Else
        '    If String.IsNullOrEmpty(tb_searchppbybagian.Text) Then
        '        dataSetPP.Clear()
        '        Dim sql As String = "SELECT * FROM `pp_header` WHERE Nota LIKE '%" & tb_searchppbynota.Text & "%'"
        '        'Console.WriteLine(sql)
        '        Dim daa As New MySqlDataAdapter(sql, conn)
        '        daa.Fill(dataSetPP, "singo")
        '        DataGridView1.Refresh()
        '    Else
        '        dataSetPP.Tables("singo").DefaultView.RowFilter = "Nota LIKE '*" & tb_searchppbynota.Text & "*'"
        '        DataGridView1.Refresh()
        '    End If
        'End If
        If cb_filterTanggalPo.Checked Then
            datasetPo.Tables("tabel_po").DefaultView.RowFilter = "Nota LIKE '*" & tb_searchPoByNomorNota.Text & "*'"
            DataGridView2.Refresh()
        Else
            datasetPo.Clear()
            Dim quer As String = "SELECT * FROM po_header WHERE Nota LIKE '%" & tb_searchPoByNomorNota.Text & "%'"
            Dim da As New MySqlDataAdapter(quer, conn)
            da.Fill(datasetPo, "tabel_po")
            DataGridView2.Refresh()
        End If
    End Sub



    Private Sub b_buatPO_Click(sender As Object, e As EventArgs) Handles b_buatPO.Click
        'Console.WriteLine("buat po clicked")
        Dim diapo As New dialogPO
        diapo.Show()
    End Sub

    Private Sub b_ubahPo_Click(sender As Object, e As EventArgs) Handles b_ubahPo.Click
        'Console.WriteLine("ubah po clicked")
        Dim diapo As New dialogPO With {.nomorPurchaseOrder = DataGridView2.CurrentRow.Cells(0).Value.ToString}
        diapo.Show()
    End Sub

    Private Sub b_hapusPo_Click(sender As Object, e As EventArgs) Handles b_hapusPo.Click

        Dim dialog_result As DialogResult = MsgBox("Apakah anda yakin menghapus PO nomot " & DataGridView2.CurrentRow.Cells(0).Value.ToString & "?", MsgBoxStyle.OkCancel)

        If dialog_result = 1 Then
            Dim quer As String = "DELETE FROM po_header WHERE nota ='" & DataGridView2.CurrentRow.Cells(0).Value.ToString & "'"
            Dim quer_detail As String = "DELETE FROM `po_detail` WHERE Nota = '" & DataGridView2.CurrentRow.Cells(0).Value.ToString & "'"
            Dim cmd As New MySqlCommand(quer, conn)
            Dim cmdd As New MySqlCommand(quer_detail, conn)
            Try
                cmd.ExecuteNonQuery()
                cmdd.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine("error hapus po : " & ex.ToString)
            End Try
        End If
        DataGridView2.Refresh()
    End Sub



    '=========================================== END OF TAB PO ==========================================

    '============================================== TAB BTB =============================================

    Private Sub tb_cariNomorNotaBTB_TextChanged(sender As Object, e As EventArgs) Handles tb_cariNomorNotaBTB.TextChanged
        If cb_filterTanggalBTB.Checked Then
            'dataSetPP.Tables("singo").DefaultView.RowFilter = "Bagian Like '*" & tb_searchppbybagian.Text & "*'"
            'DataGridView1.Refresh()
            datasetBTB.Tables("dataset_btb").DefaultView.RowFilter = "nota like '*" & tb_cariNomorNotaBTB.Text & "*'"
            DataGridView3.Refresh()
        Else
            Dim quer As String = "SELECT *  FROM `btb_header` WHERE `Nota` LIKE '%" & tb_cariNomorNotaBTB.Text & "%'"
            Try
                datasetBTB.Clear()
                Dim da_btb As New MySqlDataAdapter(quer, conn)
                da_btb.Fill(datasetBTB, "dataset_btb")
                DataGridView3.Refresh()
            Catch ex As Exception
                Console.WriteLine("error : " & ex.ToString)
                MsgBox("error : " & ex.ToString)
            End Try
        End If
    End Sub

    Private Sub cb_filterTanggalBTB_CheckedChanged(sender As Object, e As EventArgs) Handles cb_filterTanggalBTB.CheckedChanged
        If cb_filterTanggalBTB.Checked Then
            gb_filterTglBtb.Visible = True
        Else
            gb_filterTglBtb.Visible = False
        End If
    End Sub

    Private Sub dp_filterbtbstart_ValueChanged(sender As Object, e As EventArgs) Handles dp_filterbtbstart.ValueChanged
        If cb_filterTanggalBTB.Checked Then
            datasetBTB.Clear()
            Dim quer As String = "SELECT *  FROM `btb_header` WHERE `Tanggal` BETWEEN '" & dp_filterbtbstart.Value.ToString("yyyy-MM-dd") & "' AND '" & dp_filterbtbend.Value.ToString("yyyy-MM-dd") & "'"
            Try
                Dim da As New MySqlDataAdapter(quer, conn)
                da.Fill(datasetBTB, "dataset_btb")
                DataGridView3.Refresh()
            Catch ex As Exception
                Console.WriteLine("error : " & ex.ToString)
                MsgBox("error : " & ex.ToString)
            End Try
        End If
    End Sub

    Private Sub dp_filterbtbend_ValueChanged(sender As Object, e As EventArgs) Handles dp_filterbtbend.ValueChanged
        If cb_filterTanggalBTB.Checked Then
            datasetBTB.Clear()
            Dim quer As String = "select * from btb_header where tanggal between '" & dp_filterbtbstart.Value.ToString("yyyy-MM-dd") & "' and '" & dp_filterbtbend.Value.ToString("yyyy-MM-dd") & "' "
            Try
                Dim da As New MySqlDataAdapter(quer, conn)
                da.Fill(datasetBTB, "dataset_btb")
                DataGridView3.Refresh()
            Catch ex As Exception
                Console.WriteLine("error : " & ex.ToString)
                MsgBox("error : " & ex.ToString)
            End Try
        End If
    End Sub

    Private Sub cb_cariNamaSupplier(sender As Object, e As EventArgs) Handles tb_caribtbNamaSupplier.TextChanged
        If cb_filterTanggalBTB.Checked Then
            'dataSetPP.Tables("singo").DefaultView.RowFilter = "Bagian Like '*" & tb_searchppbybagian.Text & "*'"
            'DataGridView1.Refresh()
            datasetBTB.Tables("dataset_btb").DefaultView.RowFilter = "NAMA LIKE '*" & tb_caribtbNamaSupplier.Text & "*'"
            DataGridView3.Refresh()
        Else
            Dim quer As String = "SELECT *  FROM `btb_header` WHERE `Nama` LIKE '%" & tb_caribtbNamaSupplier.Text & "%'"
            Try
                datasetBTB.Clear()
                Dim da_btb As New MySqlDataAdapter(quer, conn)
                da_btb.Fill(datasetBTB, "dataset_btb")
            Catch ex As Exception
                Console.WriteLine("error : " & ex.ToString)
                MsgBox("error : " & ex.ToString)
            End Try
            DataGridView3.Refresh()
        End If
    End Sub

    Private Sub b_buatbtb_Click(sender As Object, e As EventArgs) Handles b_buatbtb.Click
        Dim diabtb As New dialogBtb
        diabtb.Show()
    End Sub

    Private Sub b_editbtb_click(sender As Object, e As EventArgs) Handles b_ubahbtb.Click
        Dim diabtb As New dialogBtb With {.nomorBuktiTerimaBarang = DataGridView3.CurrentRow.Cells(0).Value.ToString}
        diabtb.Show()
    End Sub

    Private Sub b_hapusbtb_click(sender As Object, e As EventArgs) Handles b_hapusbtb.Click
        'Dim dialog_result As DialogResult = MsgBox("Apakah anda yakin menghapus PO nomot " & DataGridView2.CurrentRow.Cells(0).Value.ToString & "?", MsgBoxStyle.OkCancel)
        Dim dialog_result As DialogResult = MsgBox("Apakah anda yakin menghapus BTB nomor " & DataGridView3.CurrentRow.Cells(0).Value.ToString & "?", MsgBoxStyle.OkCancel)
        Dim quer As String = "DELETE FROM `btb_header` WHERE Nota = '" & DataGridView3.CurrentRow.Cells(0).Value.ToString & "'"
        Dim quer_detail As String = "delete from btb_detail where nota = '" & DataGridView3.CurrentRow.Cells(0).Value.ToString & "'"
        Console.WriteLine(quer)
        Console.WriteLine(quer_detail)
        Dim cmd As New MySqlCommand(quer, conn)
        Dim cmdd As New MySqlCommand(quer_detail, conn)
        If dialog_result = 1 Then

            Try
                cmd.ExecuteNonQuery()
                cmdd.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine("error hapus btb :" & ex.ToString)
            End Try
        End If
        DataGridView3.Refresh()
    End Sub
    '=========================================== END OF TAB BTB =========================================
End Class

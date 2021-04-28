Imports MySql.Data.MySqlClient
Public Class dialogPP
    Dim conn As New MySqlConnection
    Dim a As New AutoCompleteStringCollection
    Dim autoBagian As New AutoCompleteStringCollection
    Dim autoSatuan As New AutoCompleteStringCollection
    Dim lastEditedCellRow As Int16
    Dim lastEditedCellColumn As Int16
    Public nomorNota As String
    Dim stat As Boolean
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
        'Console.WriteLine(dtt.Columns(0).ColumnName)
        For i As Integer = 0 To dtt.Rows.Count - 1
            autoBagian.Add(dtt.Rows(i)("Bagian"))
        Next

        'autocomSatuan
        Dim cmd_autosatuan As New MySqlCommand("select distinct satuan from barang", conn)
        Dim da_autosatuan As New MySqlDataAdapter(cmd_autosatuan)
        Dim dt_autosatuan As New DataTable
        da_autosatuan.Fill(dt_autosatuan)
        For i As Integer = 0 To dt_autosatuan.Rows.Count - 1
            autoSatuan.Add(dt_autosatuan.Rows(i)("satuan").ToString)
        Next

        tb_bagian.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tb_bagian.AutoCompleteSource = AutoCompleteSource.CustomSource
        tb_bagian.AutoCompleteCustomSource = autoBagian

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub dialogPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(nomorNota) Then
            l_title.Text = "Tambah Permintaan Pembelian"

            'createNomerPP:iyaa sabar,nanti buat fungsi
            tb_nomorPP.Text = "0000000"
            tb_nomorPP.Enabled = False
            stat = True
        Else
            stat = False
            l_title.Text = "Edit Permintaan Pembelian"
            Dim cmd As New MySqlCommand("select nomor, kode_brg, nama, satuan, qty, bagian, keterangan, tanggal, nota from pp_detail where nota = '" & nomorNota & "'", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            Dim x As Int16 = 0
            Console.WriteLine("hey yoo")
            While reader.Read
                'dgv_rincianBrgPP.Rows(x).Cells(0).Value = reader.GetString(0)
                'dgv_rincianBrgPP.Rows(x).Cells(1).Value = reader.GetString(1)
                'dgv_rincianBrgPP.Rows(x).Cells(2).Value = reader.GetString(2)
                'dgv_rincianBrgPP.Rows(x).Cells(3).Value = reader.GetString(3)
                'dgv_rincianBrgPP.Rows(x).Cells(4).Value = reader.GetString(4)
                'dgv_rincianBrgPP.Rows(x).Cells(5).Value = reader.GetString(5)
                'dgv_rincianBrgPP.Rows(x).Cells(6).Value = reader.GetString(6)
                dgv_rincianBrgPP.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6))
                x += 1
                ' Console.WriteLine(x)
            End While
            tb_bagian.Text = reader.GetString(5)
            tb_nomorPP.Text = reader.GetString(8)
            dp_tglPermitaalPembelian.Value = reader.GetString(7)
            tb_nomorPP.Enabled = False
            reader.Close()


        End If

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
                autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                autoText.AutoCompleteCustomSource = a
            End If
            AddHandler dgv_rincianBrgPP.CellEndEdit, AddressOf fillKodeBarang
        ElseIf dgv_rincianBrgPP.CurrentCell.ColumnIndex = 3 Then
            Dim text1 As TextBox = TryCast(e.Control, TextBox)
            text1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            text1.AutoCompleteSource = AutoCompleteSource.CustomSource
            text1.AutoCompleteCustomSource = autoSatuan

        ElseIf dgv_rincianBrgPP.CurrentCell.ColumnIndex = 5 Then
            Dim text2 As TextBox = TryCast(e.Control, TextBox)
            text2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            text2.AutoCompleteSource = AutoCompleteSource.CustomSource
            text2.AutoCompleteCustomSource = autoBagian
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
        Try
            Dim cmd As New MySqlCommand("select kode_brg from barang where nama = '" & dgv_rincianBrgPP.Rows(lastEditedCellRow).Cells(lastEditedCellColumn).Value.ToString & "'", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            While reader.Read
                dgv_rincianBrgPP.Rows(lastEditedCellRow).Cells(lastEditedCellColumn - 1).Value = reader.GetString(0)
            End While
            dgv_rincianBrgPP.Rows(lastEditedCellRow).Cells(0).Value = lastEditedCellRow + 1
            reader.Close()
        Catch ex As Exception
            MsgBox("error : masukan nama barang dengan benar")
            dgv_rincianBrgPP.Rows(lastEditedCellRow).Cells(lastEditedCellColumn).Value = "NULL"
        End Try

    End Sub

    Private Sub b_simpan_Click(sender As Object, e As EventArgs) Handles b_simpan.Click 'ADD EKSEPSI KALAU KOLOM KETERANGAN TIDAK DIISI
        If stat Then
            Dim rowCount As Int16 = dgv_rincianBrgPP.RowCount
            Dim columnCount As Int16 = dgv_rincianBrgPP.ColumnCount
            Dim nota As String = tb_nomorPP.Text
            Dim query As String = "INSERT INTO `pp_header`(`Nota`, `Tanggal`, `Bagian`, `Catatan`, `Status`, `UserID`) VALUES ('" & nota & "','" & dp_tglPermitaalPembelian.Value.ToString("yyyy-MM-dd") & "','" & tb_bagian.Text.ToString & "','Ini catatan','0','singo')"
            Dim cmd As New MySqlCommand
            Dim tr As MySqlTransaction
            tr = conn.BeginTransaction
            Console.WriteLine(query)
            Try
                cmd.Connection = conn
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Data gagal disimpan, err : " & ex.ToString)
            End Try

            For i = 0 To rowCount - 2
                Dim nomor = dgv_rincianBrgPP.Rows(i).Cells(0).Value.ToString
                Dim kodeBar = dgv_rincianBrgPP.Rows(i).Cells(1).Value.ToString
                Dim nama = dgv_rincianBrgPP.Rows(i).Cells(2).Value.ToString
                Dim santuan = dgv_rincianBrgPP.Rows(i).Cells(3).Value.ToString
                Dim stkmin = 101
                Dim stock = 101
                Dim qty = dgv_rincianBrgPP.Rows(i).Cells(4).Value.ToString
                Dim sisa = dgv_rincianBrgPP.Rows(i).Cells(4).Value.ToString
                Dim ket As String = ""
                Try
                    ket = dgv_rincianBrgPP.Rows(i).Cells(6).Value.ToString
                Catch ex As Exception
                    dgv_rincianBrgPP.Rows(i).Cells(6).Value = "NULL"
                End Try

                Dim flag = 0
                Dim userid = "singo"
                Console.WriteLine(dgv_rincianBrgPP.Rows(i).Cells(1).Value.ToString & "  " & dgv_rincianBrgPP.Rows(i).Cells(2).Value.ToString)
                Dim quer As String = "INSERT INTO `pp_detail`(`Nota`, `Tanggal`, `Bagian`, `Nomor`, `Kode_Brg`, `Nama`, `Satuan`, `StkMin`, `Stock`, `Qty`, `Sisa`, `Keterangan`, `Flag`, `UserID`, `Jam`) VALUES ('" & nota & "','" & dp_tglPermitaalPembelian.Value.ToString("yyyy-MM-dd") & "','" & dgv_rincianBrgPP.Rows(i).Cells(5).Value.ToString & "','" & nomor & "','" & kodeBar & "','" & nama & "','" & santuan & "'," & stkmin & "," & stock & "," & qty & "," & sisa & ",'" & ket & "'," & flag & ",'" & userid & "','""')"
                Console.WriteLine(quer)
                Dim cmdd As New MySqlCommand
                Try
                    cmdd.Connection = conn
                    cmdd.CommandText = quer
                    cmdd.ExecuteNonQuery()
                    Console.WriteLine("data berhasil di simpan")
                Catch ex As Exception
                    Console.WriteLine("err " & ex.ToString)
                    MsgBox("err : " & ex.ToString)
                End Try
            Next

            tr.Commit()
            MsgBox("data berhasil disimpan")
        Else
            ' UPDATE PP
            Dim rowCount As Int16 = dgv_rincianBrgPP.RowCount
            Dim columnCount As Int16 = dgv_rincianBrgPP.ColumnCount
            Dim nota As String = tb_nomorPP.Text
            Dim query As String = "UPDATE `pp_header` SET `Nota` = '" & nota & "', `Tanggal` = '" & dp_tglPermitaalPembelian.Value.ToString("yyyy-MM-dd") & "', `Bagian` = '" & tb_bagian.Text.ToString & "', `Catatan` = 'Ini catatan', `Status` = '0', `UserID`='singo' WHERE nota = '" & nota & "'"
            Dim cmd As New MySqlCommand
            Dim tr As MySqlTransaction
            tr = conn.BeginTransaction
            Console.WriteLine(query)
            Try
                cmd.Connection = conn
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Data gagal disimpan, err : " & ex.ToString)
            End Try

            For i = 0 To rowCount - 2
                Dim nomor = dgv_rincianBrgPP.Rows(i).Cells(0).Value.ToString
                Dim kodeBar = dgv_rincianBrgPP.Rows(i).Cells(1).Value.ToString
                Dim nama = dgv_rincianBrgPP.Rows(i).Cells(2).Value.ToString
                Dim santuan = dgv_rincianBrgPP.Rows(i).Cells(3).Value.ToString
                Dim stkmin = 101
                Dim stock = 101
                Dim qty = dgv_rincianBrgPP.Rows(i).Cells(4).Value.ToString
                Dim sisa = dgv_rincianBrgPP.Rows(i).Cells(4).Value.ToString
                Dim ket As String = ""
                Try
                    ket = dgv_rincianBrgPP.Rows(i).Cells(6).Value.ToString
                Catch ex As Exception
                    dgv_rincianBrgPP.Rows(i).Cells(6).Value = "NULL"
                End Try

                Dim flag = 0
                Dim userid = "singo"
                Console.WriteLine(dgv_rincianBrgPP.Rows(i).Cells(1).Value.ToString & "  " & dgv_rincianBrgPP.Rows(i).Cells(2).Value.ToString)
                Dim quer As String = "UPDATE `pp_detail`  SET `Nota` = '" & nota & "', `Tanggal` = '" & dp_tglPermitaalPembelian.Value.ToString("yyyy-MM-dd") & "', `Bagian` = '" & dgv_rincianBrgPP.Rows(i).Cells(5).Value.ToString & "' , `Nomor` = '" & nomor & "', `Kode_Brg` = '" & kodeBar & "', `Nama` = '" & nama & "', `Satuan` = '" & santuan & "', `StkMin`=" & stkmin & ", `Stock`=" & stock & ", `Qty`=" & qty & ", `Sisa`=" & sisa & ", `Keterangan`='" & ket & "', `Flag`=" & flag & ", `UserID`='" & userid & "', `Jam`='""' WHERE nota = '" & nota & "' AND nomor = '" & nomor & "'"
                Console.WriteLine(quer)
                Dim cmdd As New MySqlCommand
                Try
                    cmdd.Connection = conn
                    cmdd.CommandText = quer
                    cmdd.ExecuteNonQuery()
                    Console.WriteLine("data berhasil di simpan")
                Catch ex As Exception
                    Console.WriteLine("err " & ex.ToString)
                    MsgBox("err : " & ex.ToString)
                End Try
            Next

            tr.Commit()
            MsgBox("data berhasil disimpan")
        End If
        Me.Dispose()
        Me.Close()
    End Sub
End Class
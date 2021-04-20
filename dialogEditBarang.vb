Imports MySql.Data.MySqlClient
Public Class dialogEditBarang
    Private conn As New MySqlConnection
    Public kodeBarang As String
    Private stat As New Boolean
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

        ' Add any initialization after the InitializeComponent() call. 
    End Sub

    Private Sub dialogEditBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("dialog edit barang")
        If String.IsNullOrEmpty(kodeBarang) Then
            l_editDataBarang.Text = "Tambah Barang"
        Else
            stat = True
            l_editDataBarang.Text = "Edit Barang " & kodeBarang
            Dim sql As String = "SELECT KODE_BRG, Barcode, NAMA, SATUAN, GROUPE, SubGroup, SNama, PakaiAcc, Rak, StkMin, StkMax, HargaBeli, HargaPokok,Stock,RpJumlah,TglBeli,TglPakai,ImgFile,Keterangan FROM `barang` WHERE KODE_BRG='" & kodeBarang & "'"
            Try
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader
                While reader.Read
                    tb_kodebarang.Text = reader.GetString(0)
                    tb_barcode.Text = reader.GetString(1)
                    tb_namabarang.Text = reader.GetString(2)
                    tb_satuan.Text = reader.GetString(3)
                    tb_group.Text = reader.GetString(4)
                    tb_subgroup.Text = reader.GetString(5)
                    tb_sname.Text = reader.GetString(6)
                    tb_pakaiacc.Text = reader.GetString(7)
                    tb_rak.Text = reader.GetString(8)
                    tb_stockmin.Text = reader.GetString(9)
                    tb_stockmax.Text = reader.GetString(10)
                    tbhargabeli.Text = reader.GetString(11)
                    tb_hargapokok.Text = reader.GetString(12)
                    tb_stock.Text = reader.GetString(13)
                    tb_rp_jumlah.Text = reader.GetString(14)
                    DateTimePicker1.Text = reader.GetString(15)
                    DateTimePicker2.Text = reader.GetString(16)
                    tb_keterangan.Text = reader.GetString(17)
                End While
                reader.Close()
            Catch ex As Exception
                Console.WriteLine("error : " & ex.ToString)
                MsgBox("err : " & ex.ToString)
            End Try

        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Console.WriteLine("esc pressed")
            Me.Close()
        End If
    End Sub

    Private Sub b_cancel_Click(sender As Object, e As EventArgs) Handles b_cancel.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub b_save_Click(sender As Object, e As EventArgs) Handles b_save.Click
        Dim sql As String
        Dim kodebar = tb_kodebarang.Text
        Dim barcode = tb_barcode.Text
        Dim nama = tb_namabarang.Text
        Dim satuan = tb_satuan.Text
        Dim group = tb_group.Text
        Dim subgroup = tb_subgroup.Text
        Dim sname = tb_sname.Text
        Dim pakaiacc = tb_pakaiacc.Text
        Dim rak = tb_rak.Text
        Dim stk_min = tb_stockmin.Text
        Dim stk_max = tb_stockmax.Text
        Dim hargabeli = tb_hargapokok.Text
        Dim hargapakai = tb_hargapokok.Text
        Dim stock = tb_stock.Text
        Dim rpjumlah = tb_rp_jumlah.Text
        Dim tglbeli = DateTimePicker1.Text
        Dim tglpakai = DateTimePicker2.Text
        Dim keterangan = tb_keterangan.Text

        If stat Then
            sql = "UPDATE `barang` SET `KODE_BRG`='" & kodebar & "',`Barcode`='" & barcode & "',`NAMA`='" & nama & "',`SATUAN`='" & satuan & "',`GROUPE`='" & group & "',`SubGroup`='" & subgroup & "',`SNama`='" & sname & "',`PakaiAcc`='" & pakaiacc & "',`Rak`='" & rak & "',`StkMin`='" & stk_min & "',`StkMax`='" & stk_max & "',`HargaBeli`='" & hargabeli & "',`HargaPokok`='" & hargapakai & "',`Stock`='" & stock & "',`RpJumlah`='" & rpjumlah & "',`TglBeli`='" & tglbeli & "',`TglPakai`='" & tglpakai & "',`ImgFile`='',`Keterangan`='" & keterangan & "' WHERE KODE_BRG ='" & kodeBarang & "'"
        Else
            sql = "INSERT INTO `barang` SET `KODE_BRG`='" & kodebar & "',`Barcode`='" & barcode & "',`NAMA`='" & nama & "',`SATUAN`='" & satuan & "',`GROUPE`='" & group & "',`SubGroup`='" & subgroup & "',`SNama`='" & sname & "',`PakaiAcc`='" & pakaiacc & "',`Rak`='" & rak & "',`StkMin`='" & stk_min & "',`StkMax`='" & stk_max & "',`HargaBeli`='" & hargabeli & "',`HargaPokok`='" & hargapakai & "',`Stock`='" & stock & "',`RpJumlah`='" & rpjumlah & "',`TglBeli`='" & tglbeli & "',`TglPakai`='" & tglpakai & "',`ImgFile`='',`Keterangan`='" & keterangan & "'"
        End If

        Console.WriteLine(sql)
        Dim cmd As New MySqlCommand
        Dim tr As MySqlTransaction
        tr = conn.BeginTransaction
        Try
            cmd.Connection = conn
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            tr.Commit()
            MsgBox("Data berhasil disimpan")
        Catch ex As Exception
            Console.WriteLine("err : " & ex.ToString)
            MsgBox("data gagal disimpan")
        End Try

        Me.Dispose()
        Me.Close()
    End Sub


End Class
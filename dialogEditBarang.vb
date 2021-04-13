Imports MySql.Data.MySqlClient
Public Class dialogEditBarang
    Private conn As New MySqlConnection
    Public kodeBarang As String
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
                    rp_jumlah.Text = reader.GetString(14)
                    tb_tglbeli.Text = reader.GetString(15)
                    tgl_pakai.Text = reader.GetString(16)
                    tb_keterangan.Text = reader.GetString(17)
                End While
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
End Class
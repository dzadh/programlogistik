Imports MySql.Data.MySqlClient
Public Class dialogSupplier
    Public kodeSupplier As String
    Private stat As Boolean
    Private conn As New MySqlConnection
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim cs As String
        KeyPreview = True
        Dim database As String = "dblogistik"
        Dim username As String = "root"
        Dim host As String = "localhost"
        Dim password As String = ""
        cs = "Database=" & database & ";Data Source=" & host & ";User Id=" & username & ";Password=" & password & ""
        conn.ConnectionString = cs
        Try
            conn.Open()
            'MsgBox("connection success")
            Console.WriteLine(conn.State)
        Catch ex As Exception
            MsgBox("connection failed " & ex.ToString)
        End Try
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub dialogSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(kodeSupplier) Then
            l_title.Text = "Tambah Supplier"
            stat = False
        Else
            l_title.Text = "Edit Supplier " & kodeSupplier
            stat = True
            Dim sql As String = "SELECT * FROM `supplier` WHERE KODE_SUPL='" & kodeSupplier & "'"
            Try
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read
                    tb_kodesupplier.Text = reader.GetString(0)
                    tb_nama.Text = reader.GetString(1)
                    tb_kontak.Text = reader.GetString(2)
                    tb_alamat.Text = reader.GetString(3)
                    tb_telpon.Text = reader.GetString(4)
                    tb_fax.Text = reader.GetString(5)
                    tb_email.Text = reader.GetString(6)
                    tb_npwp.Text = reader.GetString(6)
                    tb_hari.Text = reader.GetString(7)
                    tb_bank.Text = reader.GetString(8)
                    tb_rekening.Text = reader.GetString(9)
                    tb_atasNama.Text = reader.GetString(10)
                    tb_splok.Text = reader.GetString(11)
                End While
                reader.Close()

            Catch ex As Exception

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
        Me.Close()
    End Sub

    Private Sub b_simpan_Click(sender As Object, e As EventArgs) Handles b_simpan.Click
        Dim sql As String
        Dim kodesupp = tb_kodesupplier.Text
        Dim nama = tb_nama.Text
        Dim kontak = tb_kontak.Text
        Dim alamat = tb_alamat.Text
        Dim telpon = tb_alamat.Text
        Dim fax = tb_fax.Text
        Dim email = tb_email.Text
        Dim npwp = tb_npwp.Text
        Dim hari = tb_bank.Text
        Dim bank = tb_bank.Text
        Dim rekening = tb_rekening.Text
        Dim atasNama = tb_atasNama.Text
        Dim splok = tb_splok.Text
        If stat Then
            sql = "UPDATE `supplier` SET `KODE_SUPL`='" & kodesupp & "',`NAMA`='" & nama & "',`CONTACT`='" & kontak & "',`ALAMAT`='" & alamat & "',`TELPON`='" & telpon & "',`FAX`='" & fax & "',`email`='" & email & "',`NPWP`='" & npwp & "',`Hari`='" & hari & "',`Bank`='" & bank & "',`Rekening`='" & rekening & "',`Atasnama`='" & atasNama & "',`Splok`='" & splok & "' WHERE `KODE_SUPL`='" & kodesupp & "'"
        Else
            sql = "INSERT INTO `supplier` SET `KODE_SUPL`='" & kodesupp & "',`NAMA`='" & nama & "',`CONTACT`='" & kontak & "',`ALAMAT`='" & alamat & "',`TELPON`='" & telpon & "',`FAX`='" & fax & "',`email`='" & email & "',`NPWP`='" & npwp & "',`Hari`='" & hari & "',`Bank`='" & bank & "',`Rekening`='" & rekening & "',`Atasnama`='" & atasNama & "',`Splok`='" & splok & "'"
        End If
        Dim cmd As New MySqlCommand
        Dim tr As MySqlTransaction
        tr = conn.BeginTransaction
        Try
            cmd.Connection = conn
            cmd.CommandText = Sql
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
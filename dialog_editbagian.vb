Imports MySql.Data.MySqlClient
Public Class dialog_editbagian
    Public kodeBagian As String
    Private stat As New Boolean
    Private conn As New MySqlConnection
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim cs As String
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
    Private Sub dialog_editbagian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(kodeBagian) Then
            Console.WriteLine("string kososng")
            Label1.Text = "Tambah Data Bagian"
            stat = False
        Else
            Label1.Text = "Edit Data " & kodeBagian
            Dim sql As String = "SELECT * FROM tblbagian WHERE kode ='" & kodeBagian & "'"
            Console.WriteLine(sql)
            stat = True
            Try
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    tb_namabagian.Text = reader.GetString(0)
                    tb_kodebagian.Text = reader.GetString(1)
                    tb_groupbagian.Text = reader.GetString(2)
                    tb_divisi.Text = reader.GetString(3)
                    tb_tujuan.Text = reader.GetString(4)
                    tb_FEL.Text = reader.GetString(5)
                End While
                reader.Close()
            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub b_save_Click(sender As Object, e As EventArgs) Handles b_save.Click
        Dim nambag = tb_namabagian.Text
        Dim kodebag = tb_kodebagian.Text
        Dim groupbag = tb_groupbagian.Text
        Dim divisi = tb_divisi.Text
        Dim tujuan = tb_tujuan.Text
        Dim fel = tb_FEL.Text
        Dim sql As String
        If stat Then
            sql = "UPDATE `tblbagian` SET `Bagian`='" & nambag & "',`kode`='" & kodebag & "',`Groupe`='" & groupbag & "',`Devisi`='" & divisi & "',`Tujuan`='" & tujuan & "',`FEL`='" & fel & "' WHERE kode='" & kodebag & "'"
        Else
            sql = "INSERT INTO `tblbagian` SET `Bagian`='" & nambag & "',`kode`='" & kodebag & "',`Groupe`='" & groupbag & "',`Devisi`='" & divisi & "',`Tujuan`='" & tujuan & "',`FEL`='" & fel & "'"
        End If

        Console.WriteLine(sql)
        Dim cmd As New MySqlCommand
        Dim tr As MySqlTransaction
        tr = conn.BeginTransaction()
        Try
            cmd.Connection = conn
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            tr.Commit()
            MsgBox("Data berhasil disimpan..")

        Catch ex As Exception
            Console.WriteLine("Error : " & ex.ToString)
            MsgBox("Data gagal disimpan : " & ex.ToString)
        End Try
        Me.Dispose()
        Me.Close()
    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class dialogEditBarang
    Private conn As New MySqlConnection
    Public kodeBarang As String
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
            Console.WriteLine("connection open")
        Catch ex As Exception
            Console.WriteLine("error : " & ex.ToString)
        End Try

        ' Add any initialization after the InitializeComponent() call. 
    End Sub
    Private Sub dialogEditBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("dialog edit barang")
        If String.IsNullOrEmpty(kodeBarang) Then
            l_editDataBarang.Text = "Tambah Barang"
        Else
            l_editDataBarang.Text = "Edit Barang " & kodeBarang
        End If
    End Sub
End Class
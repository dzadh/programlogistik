Imports MySql.Data.MySqlClient
Public Class dialogPP
    Dim conn As New MySqlConnection
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
    Private Sub dialogPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgv_rincianBrgPP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_rincianBrgPP.CellDoubleClick
        Console.WriteLine(e.ColumnIndex.ToString)
    End Sub

    Private Sub b_cancel_Click(sender As Object, e As EventArgs) Handles b_cancel.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgv_rincianBrgPP.EditingControlShowing
        Dim cmd As New MySqlCommand("SELECT KODE_BRG, NAMA FROM Barang", conn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Dim a As New AutoCompleteStringCollection
        For i As Integer = 0 To dt.Rows.Count - 1
            a.Add(dt.Rows(i)("Nama"))
        Next
        Dim titleText As String = dgv_rincianBrgPP.Columns(2).HeaderText
        If titleText.Equals("Nama") Then
            Dim autoText As TextBox = TryCast(e.Control, TextBox)
            If autoText IsNot Nothing Then
                autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                autoText.AutoCompleteCustomSource = a
            End If
        End If
        editedCell(dgv_rincianBrgPP.CurrentCell)
    End Sub

    'Private Sub YourDGV_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_rincianBrgPP.CurrentCellDirtyStateChanged
    '    If (dgv_rincianBrgPP.CurrentCell.ColumnIndex = 2) Then
    '        If dgv_rincianBrgPP.CommitEdit(DataGridViewDataErrorContexts.Commit) Then
    '            Console.WriteLine(dgv_rincianBrgPP.CurrentCell.Value.ToString)
    '        End If

    '    End If
    '    Console.WriteLine(dgv_rincianBrgPP.CurrentRow.Cells(2).Value.ToString)
    'End Sub

    Private Sub editedCell(sel As DataGridViewTextBoxCell)
        Console.WriteLine(sel.Value.ToString)
        Dim cmd As New MySqlCommand("select kode_brg from barang where nama = '" & sel.Value.ToString & "'")
    End Sub

End Class
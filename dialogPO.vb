Imports MySql.Data.MySqlClient
Public Class dialogPO
    Dim conn As New MySqlConnection
    Dim autoSupplier As New AutoCompleteStringCollection
    Dim autoBarang As New AutoCompleteStringCollection
    Public nomorPurchaseOrder As String
    Dim lastEditedCellRow As Int16
    Dim lastEditedCellColumn As Int16
    Public selectedNota As String
    Dim diaPilPP As New pilihPermintaanPembelianDialog
    'Dim diapilobj As New Object
    Dim diapilpil As Object

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
                Try
                    Console.WriteLine("hey yoo row :" & e.RowIndex & " " & dgv_purchaseOrder.CurrentRow.Cells(2).Value.ToString)
                Catch ex As Exception
                    Console.WriteLine("data kosong")
                End Try
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
        Console.WriteLine(diapilpil.selectedNota & " " & diapilpil.nomorInNota(0))
    End Sub

End Class
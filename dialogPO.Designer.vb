<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogPO
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.l_supplier = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_nomorPO = New System.Windows.Forms.TextBox()
        Me.dp_tanggalPO = New System.Windows.Forms.DateTimePicker()
        Me.l_tanggalPO = New System.Windows.Forms.Label()
        Me.dgv_purchaseOrder = New System.Windows.Forms.DataGridView()
        Me.b_cancel = New System.Windows.Forms.Button()
        Me.b_save = New System.Windows.Forms.Button()
        Me.tb_supplier = New System.Windows.Forms.TextBox()
        Me.b_pilihpp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_bagian = New System.Windows.Forms.TextBox()
        Me.l_totalharga = New System.Windows.Forms.Label()
        Me.l_pajak = New System.Windows.Forms.Label()
        Me.tb_pajak = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_totalHarga = New System.Windows.Forms.TextBox()
        Me.tb_grandTotal = New System.Windows.Forms.TextBox()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_brg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_pp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ppn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgv_purchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'l_supplier
        '
        Me.l_supplier.AutoSize = True
        Me.l_supplier.Location = New System.Drawing.Point(22, 54)
        Me.l_supplier.Name = "l_supplier"
        Me.l_supplier.Size = New System.Drawing.Size(45, 13)
        Me.l_supplier.TabIndex = 0
        Me.l_supplier.Text = "Supplier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(576, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "No Purchase Order"
        '
        'tb_nomorPO
        '
        Me.tb_nomorPO.Location = New System.Drawing.Point(690, 47)
        Me.tb_nomorPO.Name = "tb_nomorPO"
        Me.tb_nomorPO.Size = New System.Drawing.Size(125, 20)
        Me.tb_nomorPO.TabIndex = 3
        '
        'dp_tanggalPO
        '
        Me.dp_tanggalPO.CustomFormat = "dd/MM/yyyy"
        Me.dp_tanggalPO.Enabled = False
        Me.dp_tanggalPO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dp_tanggalPO.Location = New System.Drawing.Point(690, 73)
        Me.dp_tanggalPO.Name = "dp_tanggalPO"
        Me.dp_tanggalPO.Size = New System.Drawing.Size(125, 20)
        Me.dp_tanggalPO.TabIndex = 4
        '
        'l_tanggalPO
        '
        Me.l_tanggalPO.AutoSize = True
        Me.l_tanggalPO.Location = New System.Drawing.Point(576, 79)
        Me.l_tanggalPO.Name = "l_tanggalPO"
        Me.l_tanggalPO.Size = New System.Drawing.Size(46, 13)
        Me.l_tanggalPO.TabIndex = 5
        Me.l_tanggalPO.Text = "Tanggal"
        '
        'dgv_purchaseOrder
        '
        Me.dgv_purchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_purchaseOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.kode_brg, Me.nama_barang, Me.unit, Me.jumlah, Me.harga_satuan, Me.no_pp, Me.ppn, Me.hapus})
        Me.dgv_purchaseOrder.Location = New System.Drawing.Point(25, 127)
        Me.dgv_purchaseOrder.Name = "dgv_purchaseOrder"
        Me.dgv_purchaseOrder.RowHeadersVisible = False
        Me.dgv_purchaseOrder.Size = New System.Drawing.Size(790, 253)
        Me.dgv_purchaseOrder.TabIndex = 6
        '
        'b_cancel
        '
        Me.b_cancel.Location = New System.Drawing.Point(740, 506)
        Me.b_cancel.Name = "b_cancel"
        Me.b_cancel.Size = New System.Drawing.Size(75, 23)
        Me.b_cancel.TabIndex = 7
        Me.b_cancel.Text = "Cancel"
        Me.b_cancel.UseVisualStyleBackColor = True
        '
        'b_save
        '
        Me.b_save.Location = New System.Drawing.Point(658, 506)
        Me.b_save.Name = "b_save"
        Me.b_save.Size = New System.Drawing.Size(75, 23)
        Me.b_save.TabIndex = 7
        Me.b_save.Text = "Save"
        Me.b_save.UseVisualStyleBackColor = True
        '
        'tb_supplier
        '
        Me.tb_supplier.Location = New System.Drawing.Point(25, 70)
        Me.tb_supplier.Name = "tb_supplier"
        Me.tb_supplier.Size = New System.Drawing.Size(222, 20)
        Me.tb_supplier.TabIndex = 8
        '
        'b_pilihpp
        '
        Me.b_pilihpp.AutoSize = True
        Me.b_pilihpp.Location = New System.Drawing.Point(25, 96)
        Me.b_pilihpp.Name = "b_pilihpp"
        Me.b_pilihpp.Size = New System.Drawing.Size(144, 23)
        Me.b_pilihpp.TabIndex = 9
        Me.b_pilihpp.Text = "Pilih Permintaan Pembelian"
        Me.b_pilihpp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(576, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Bagian"
        '
        'tb_bagian
        '
        Me.tb_bagian.Location = New System.Drawing.Point(690, 98)
        Me.tb_bagian.Name = "tb_bagian"
        Me.tb_bagian.Size = New System.Drawing.Size(125, 20)
        Me.tb_bagian.TabIndex = 11
        '
        'l_totalharga
        '
        Me.l_totalharga.AutoSize = True
        Me.l_totalharga.Location = New System.Drawing.Point(597, 435)
        Me.l_totalharga.Name = "l_totalharga"
        Me.l_totalharga.Size = New System.Drawing.Size(63, 13)
        Me.l_totalharga.TabIndex = 12
        Me.l_totalharga.Text = "Total Harga"
        '
        'l_pajak
        '
        Me.l_pajak.AutoSize = True
        Me.l_pajak.Location = New System.Drawing.Point(597, 412)
        Me.l_pajak.Name = "l_pajak"
        Me.l_pajak.Size = New System.Drawing.Size(34, 13)
        Me.l_pajak.TabIndex = 13
        Me.l_pajak.Text = "Pajak"
        '
        'tb_pajak
        '
        Me.tb_pajak.Location = New System.Drawing.Point(679, 404)
        Me.tb_pajak.Name = "tb_pajak"
        Me.tb_pajak.Size = New System.Drawing.Size(136, 20)
        Me.tb_pajak.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(597, 461)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Grand Total"
        '
        'tb_totalHarga
        '
        Me.tb_totalHarga.Location = New System.Drawing.Point(679, 432)
        Me.tb_totalHarga.Name = "tb_totalHarga"
        Me.tb_totalHarga.Size = New System.Drawing.Size(136, 20)
        Me.tb_totalHarga.TabIndex = 16
        '
        'tb_grandTotal
        '
        Me.tb_grandTotal.Location = New System.Drawing.Point(679, 461)
        Me.tb_grandTotal.Name = "tb_grandTotal"
        Me.tb_grandTotal.Size = New System.Drawing.Size(136, 20)
        Me.tb_grandTotal.TabIndex = 17
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.Width = 46
        '
        'kode_brg
        '
        Me.kode_brg.HeaderText = "Kode Barang"
        Me.kode_brg.Name = "kode_brg"
        '
        'nama_barang
        '
        Me.nama_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_barang.HeaderText = "Nama Barang"
        Me.nama_barang.Name = "nama_barang"
        '
        'unit
        '
        Me.unit.HeaderText = "Unit"
        Me.unit.Name = "unit"
        Me.unit.Width = 50
        '
        'jumlah
        '
        Me.jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Width = 65
        '
        'harga_satuan
        '
        Me.harga_satuan.HeaderText = "Harga Satuan"
        Me.harga_satuan.Name = "harga_satuan"
        '
        'no_pp
        '
        Me.no_pp.HeaderText = "No PP"
        Me.no_pp.Name = "no_pp"
        Me.no_pp.Width = 75
        '
        'ppn
        '
        Me.ppn.HeaderText = "ppn (dalam %)"
        Me.ppn.Name = "ppn"
        Me.ppn.Width = 98
        '
        'hapus
        '
        Me.hapus.HeaderText = "hapus"
        Me.hapus.Name = "hapus"
        Me.hapus.Text = ""
        Me.hapus.ToolTipText = "hapus"
        Me.hapus.Width = 50
        '
        'dialogPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 546)
        Me.Controls.Add(Me.tb_grandTotal)
        Me.Controls.Add(Me.tb_totalHarga)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_pajak)
        Me.Controls.Add(Me.l_pajak)
        Me.Controls.Add(Me.l_totalharga)
        Me.Controls.Add(Me.tb_bagian)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.b_pilihpp)
        Me.Controls.Add(Me.tb_supplier)
        Me.Controls.Add(Me.b_save)
        Me.Controls.Add(Me.b_cancel)
        Me.Controls.Add(Me.dgv_purchaseOrder)
        Me.Controls.Add(Me.l_tanggalPO)
        Me.Controls.Add(Me.dp_tanggalPO)
        Me.Controls.Add(Me.tb_nomorPO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.l_supplier)
        Me.Name = "dialogPO"
        Me.Text = " "
        CType(Me.dgv_purchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents l_supplier As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_nomorPO As TextBox
    Friend WithEvents dp_tanggalPO As DateTimePicker
    Friend WithEvents l_tanggalPO As Label
    Friend WithEvents dgv_purchaseOrder As DataGridView
    Friend WithEvents b_cancel As Button
    Friend WithEvents b_save As Button
    Friend WithEvents tb_supplier As TextBox
    Friend WithEvents b_pilihpp As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_bagian As TextBox
    Friend WithEvents l_totalharga As Label
    Friend WithEvents l_pajak As Label
    Friend WithEvents tb_pajak As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_totalHarga As TextBox
    Friend WithEvents tb_grandTotal As TextBox
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents kode_brg As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents unit As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents harga_satuan As DataGridViewTextBoxColumn
    Friend WithEvents no_pp As DataGridViewTextBoxColumn
    Friend WithEvents ppn As DataGridViewTextBoxColumn
    Friend WithEvents hapus As DataGridViewButtonColumn
End Class

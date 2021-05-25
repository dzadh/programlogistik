<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogBtb
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
        Me.l_judulDialog = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_notabtb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_noPurchaseOrder = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_noPP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_supplier = New System.Windows.Forms.TextBox()
        Me.b_pilihPO = New System.Windows.Forms.Button()
        Me.dgv_dialogbtb = New System.Windows.Forms.DataGridView()
        Me.noBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.terima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noPp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_save = New System.Windows.Forms.Button()
        Me.b_cancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dp_tanggalbtb = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_keterangan = New System.Windows.Forms.TextBox()
        CType(Me.dgv_dialogbtb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'l_judulDialog
        '
        Me.l_judulDialog.AutoSize = True
        Me.l_judulDialog.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_judulDialog.Location = New System.Drawing.Point(312, 9)
        Me.l_judulDialog.Name = "l_judulDialog"
        Me.l_judulDialog.Size = New System.Drawing.Size(216, 18)
        Me.l_judulDialog.TabIndex = 0
        Me.l_judulDialog.Text = "Tambah Bukti Terima Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(672, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nota"
        '
        'tb_notabtb
        '
        Me.tb_notabtb.Location = New System.Drawing.Point(715, 47)
        Me.tb_notabtb.Name = "tb_notabtb"
        Me.tb_notabtb.Size = New System.Drawing.Size(132, 20)
        Me.tb_notabtb.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(606, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No. purchase order"
        '
        'tb_noPurchaseOrder
        '
        Me.tb_noPurchaseOrder.Location = New System.Drawing.Point(715, 71)
        Me.tb_noPurchaseOrder.Name = "tb_noPurchaseOrder"
        Me.tb_noPurchaseOrder.Size = New System.Drawing.Size(132, 20)
        Me.tb_noPurchaseOrder.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(574, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "No. permintaan pembelian"
        '
        'tb_noPP
        '
        Me.tb_noPP.Location = New System.Drawing.Point(715, 95)
        Me.tb_noPP.Name = "tb_noPP"
        Me.tb_noPP.Size = New System.Drawing.Size(132, 20)
        Me.tb_noPP.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Supplier"
        '
        'tb_supplier
        '
        Me.tb_supplier.Location = New System.Drawing.Point(16, 71)
        Me.tb_supplier.Name = "tb_supplier"
        Me.tb_supplier.Size = New System.Drawing.Size(233, 20)
        Me.tb_supplier.TabIndex = 8
        '
        'b_pilihPO
        '
        Me.b_pilihPO.Location = New System.Drawing.Point(16, 94)
        Me.b_pilihPO.Name = "b_pilihPO"
        Me.b_pilihPO.Size = New System.Drawing.Size(94, 23)
        Me.b_pilihPO.TabIndex = 9
        Me.b_pilihPO.Text = "Pilih PO"
        Me.b_pilihPO.UseVisualStyleBackColor = True
        '
        'dgv_dialogbtb
        '
        Me.dgv_dialogbtb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dialogbtb.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noBarang, Me.namaBarang, Me.unit, Me.terima, Me.harga, Me.jumlah, Me.noPp})
        Me.dgv_dialogbtb.Location = New System.Drawing.Point(16, 148)
        Me.dgv_dialogbtb.Name = "dgv_dialogbtb"
        Me.dgv_dialogbtb.RowHeadersVisible = False
        Me.dgv_dialogbtb.Size = New System.Drawing.Size(831, 299)
        Me.dgv_dialogbtb.TabIndex = 10
        '
        'noBarang
        '
        Me.noBarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.noBarang.HeaderText = "No. Barang"
        Me.noBarang.Name = "noBarang"
        Me.noBarang.Width = 86
        '
        'namaBarang
        '
        Me.namaBarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.namaBarang.HeaderText = "Nama Barang"
        Me.namaBarang.Name = "namaBarang"
        '
        'unit
        '
        Me.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.unit.HeaderText = "Unit"
        Me.unit.Name = "unit"
        Me.unit.Width = 51
        '
        'terima
        '
        Me.terima.HeaderText = "Terima"
        Me.terima.Name = "terima"
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        '
        'noPp
        '
        Me.noPp.HeaderText = "No. PP"
        Me.noPp.Name = "noPp"
        '
        'b_save
        '
        Me.b_save.Location = New System.Drawing.Point(691, 466)
        Me.b_save.Name = "b_save"
        Me.b_save.Size = New System.Drawing.Size(75, 23)
        Me.b_save.TabIndex = 11
        Me.b_save.Text = "Simpan"
        Me.b_save.UseVisualStyleBackColor = True
        '
        'b_cancel
        '
        Me.b_cancel.Location = New System.Drawing.Point(772, 466)
        Me.b_cancel.Name = "b_cancel"
        Me.b_cancel.Size = New System.Drawing.Size(75, 23)
        Me.b_cancel.TabIndex = 11
        Me.b_cancel.Text = "Cancel"
        Me.b_cancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(656, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tanggal"
        '
        'dp_tanggalbtb
        '
        Me.dp_tanggalbtb.CustomFormat = "dd-MM-yyyy"
        Me.dp_tanggalbtb.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dp_tanggalbtb.Location = New System.Drawing.Point(715, 121)
        Me.dp_tanggalbtb.Name = "dp_tanggalbtb"
        Me.dp_tanggalbtb.Size = New System.Drawing.Size(132, 20)
        Me.dp_tanggalbtb.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 450)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Keterangan :"
        '
        'tb_keterangan
        '
        Me.tb_keterangan.Location = New System.Drawing.Point(16, 466)
        Me.tb_keterangan.Name = "tb_keterangan"
        Me.tb_keterangan.Size = New System.Drawing.Size(285, 20)
        Me.tb_keterangan.TabIndex = 15
        '
        'dialogBtb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 498)
        Me.Controls.Add(Me.tb_keterangan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dp_tanggalbtb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.b_cancel)
        Me.Controls.Add(Me.b_save)
        Me.Controls.Add(Me.dgv_dialogbtb)
        Me.Controls.Add(Me.b_pilihPO)
        Me.Controls.Add(Me.tb_supplier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_noPP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_noPurchaseOrder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_notabtb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.l_judulDialog)
        Me.Name = "dialogBtb"
        Me.Text = "dialogBtb"
        CType(Me.dgv_dialogbtb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents l_judulDialog As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_notabtb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_noPurchaseOrder As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_noPP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_supplier As TextBox
    Friend WithEvents b_pilihPO As Button
    Friend WithEvents dgv_dialogbtb As DataGridView
    Friend WithEvents b_save As Button
    Friend WithEvents b_cancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dp_tanggalbtb As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_keterangan As TextBox
    Friend WithEvents noBarang As DataGridViewTextBoxColumn
    Friend WithEvents namaBarang As DataGridViewTextBoxColumn
    Friend WithEvents unit As DataGridViewTextBoxColumn
    Friend WithEvents terima As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents noPp As DataGridViewTextBoxColumn
End Class

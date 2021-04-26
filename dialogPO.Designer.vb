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
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_brg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_pp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pilihPP = New System.Windows.Forms.DataGridViewButtonColumn()
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
        Me.Label1.Location = New System.Drawing.Point(647, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "No Purchase Order"
        '
        'tb_nomorPO
        '
        Me.tb_nomorPO.Location = New System.Drawing.Point(650, 29)
        Me.tb_nomorPO.Name = "tb_nomorPO"
        Me.tb_nomorPO.Size = New System.Drawing.Size(125, 20)
        Me.tb_nomorPO.TabIndex = 3
        '
        'dp_tanggalPO
        '
        Me.dp_tanggalPO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dp_tanggalPO.Location = New System.Drawing.Point(650, 71)
        Me.dp_tanggalPO.Name = "dp_tanggalPO"
        Me.dp_tanggalPO.Size = New System.Drawing.Size(125, 20)
        Me.dp_tanggalPO.TabIndex = 4
        '
        'l_tanggalPO
        '
        Me.l_tanggalPO.AutoSize = True
        Me.l_tanggalPO.Location = New System.Drawing.Point(647, 55)
        Me.l_tanggalPO.Name = "l_tanggalPO"
        Me.l_tanggalPO.Size = New System.Drawing.Size(46, 13)
        Me.l_tanggalPO.TabIndex = 5
        Me.l_tanggalPO.Text = "Tanggal"
        '
        'dgv_purchaseOrder
        '
        Me.dgv_purchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_purchaseOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.kode_brg, Me.nama_barang, Me.unit, Me.jumlah, Me.harga_satuan, Me.no_pp, Me.pilihPP})
        Me.dgv_purchaseOrder.Location = New System.Drawing.Point(25, 114)
        Me.dgv_purchaseOrder.Name = "dgv_purchaseOrder"
        Me.dgv_purchaseOrder.Size = New System.Drawing.Size(750, 266)
        Me.dgv_purchaseOrder.TabIndex = 6
        '
        'b_cancel
        '
        Me.b_cancel.Location = New System.Drawing.Point(700, 402)
        Me.b_cancel.Name = "b_cancel"
        Me.b_cancel.Size = New System.Drawing.Size(75, 23)
        Me.b_cancel.TabIndex = 7
        Me.b_cancel.Text = "Cancel"
        Me.b_cancel.UseVisualStyleBackColor = True
        '
        'b_save
        '
        Me.b_save.Location = New System.Drawing.Point(618, 402)
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
        Me.tb_supplier.Size = New System.Drawing.Size(309, 20)
        Me.tb_supplier.TabIndex = 8
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
        'pilihPP
        '
        Me.pilihPP.HeaderText = ""
        Me.pilihPP.Name = "pilihPP"
        Me.pilihPP.Width = 75
        '
        'dialogPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 437)
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
        Me.Text = "Dialog PO"
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
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents kode_brg As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents unit As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents harga_satuan As DataGridViewTextBoxColumn
    Friend WithEvents no_pp As DataGridViewTextBoxColumn
    Friend WithEvents pilihPP As DataGridViewButtonColumn
End Class

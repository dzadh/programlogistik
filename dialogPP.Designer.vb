<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogPP
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
        Me.tb_nomorPP = New System.Windows.Forms.TextBox()
        Me.l_nomorPP = New System.Windows.Forms.Label()
        Me.dgv_rincianBrgPP = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kode_BRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bagian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dp_tglPermitaalPembelian = New System.Windows.Forms.DateTimePicker()
        Me.l_rincianBarang = New System.Windows.Forms.Label()
        Me.b_simpan = New System.Windows.Forms.Button()
        Me.b_cancel = New System.Windows.Forms.Button()
        Me.l_bagian = New System.Windows.Forms.Label()
        Me.tb_bagian = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgv_rincianBrgPP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_nomorPP
        '
        Me.tb_nomorPP.Location = New System.Drawing.Point(660, 59)
        Me.tb_nomorPP.Name = "tb_nomorPP"
        Me.tb_nomorPP.Size = New System.Drawing.Size(112, 20)
        Me.tb_nomorPP.TabIndex = 0
        '
        'l_nomorPP
        '
        Me.l_nomorPP.AutoSize = True
        Me.l_nomorPP.Location = New System.Drawing.Point(557, 62)
        Me.l_nomorPP.Name = "l_nomorPP"
        Me.l_nomorPP.Size = New System.Drawing.Size(61, 13)
        Me.l_nomorPP.TabIndex = 1
        Me.l_nomorPP.Text = "Nomor PP :"
        '
        'dgv_rincianBrgPP
        '
        Me.dgv_rincianBrgPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_rincianBrgPP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Kode_BRG, Me.Nama, Me.Satuan, Me.Qty, Me.Bagian, Me.Keterangan})
        Me.dgv_rincianBrgPP.Location = New System.Drawing.Point(12, 128)
        Me.dgv_rincianBrgPP.Name = "dgv_rincianBrgPP"
        Me.dgv_rincianBrgPP.Size = New System.Drawing.Size(760, 227)
        Me.dgv_rincianBrgPP.TabIndex = 2
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.Width = 45
        '
        'Kode_BRG
        '
        Me.Kode_BRG.HeaderText = "Kode_BRG"
        Me.Kode_BRG.Name = "Kode_BRG"
        Me.Kode_BRG.Width = 75
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama"
        Me.Nama.Name = "Nama"
        Me.Nama.Width = 237
        '
        'Satuan
        '
        Me.Satuan.HeaderText = "Satuan"
        Me.Satuan.Name = "Satuan"
        Me.Satuan.Width = 50
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 35
        '
        'Bagian
        '
        Me.Bagian.HeaderText = "Bagian"
        Me.Bagian.Name = "Bagian"
        Me.Bagian.Width = 75
        '
        'Keterangan
        '
        Me.Keterangan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(557, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tgl. Permintaan :"
        '
        'dp_tglPermitaalPembelian
        '
        Me.dp_tglPermitaalPembelian.CustomFormat = "dd-MM-yyyy"
        Me.dp_tglPermitaalPembelian.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dp_tglPermitaalPembelian.Location = New System.Drawing.Point(660, 92)
        Me.dp_tglPermitaalPembelian.Name = "dp_tglPermitaalPembelian"
        Me.dp_tglPermitaalPembelian.Size = New System.Drawing.Size(112, 20)
        Me.dp_tglPermitaalPembelian.TabIndex = 4
        '
        'l_rincianBarang
        '
        Me.l_rincianBarang.AutoSize = True
        Me.l_rincianBarang.Location = New System.Drawing.Point(13, 112)
        Me.l_rincianBarang.Name = "l_rincianBarang"
        Me.l_rincianBarang.Size = New System.Drawing.Size(82, 13)
        Me.l_rincianBarang.TabIndex = 5
        Me.l_rincianBarang.Text = "Rincial Barang :"
        '
        'b_simpan
        '
        Me.b_simpan.Location = New System.Drawing.Point(605, 376)
        Me.b_simpan.Name = "b_simpan"
        Me.b_simpan.Size = New System.Drawing.Size(75, 23)
        Me.b_simpan.TabIndex = 6
        Me.b_simpan.Text = "Simpan"
        Me.b_simpan.UseVisualStyleBackColor = True
        '
        'b_cancel
        '
        Me.b_cancel.Location = New System.Drawing.Point(697, 376)
        Me.b_cancel.Name = "b_cancel"
        Me.b_cancel.Size = New System.Drawing.Size(75, 23)
        Me.b_cancel.TabIndex = 6
        Me.b_cancel.Text = "Cancel"
        Me.b_cancel.UseVisualStyleBackColor = True
        '
        'l_bagian
        '
        Me.l_bagian.AutoSize = True
        Me.l_bagian.Location = New System.Drawing.Point(13, 66)
        Me.l_bagian.Name = "l_bagian"
        Me.l_bagian.Size = New System.Drawing.Size(40, 13)
        Me.l_bagian.TabIndex = 7
        Me.l_bagian.Text = "Bagian"
        '
        'tb_bagian
        '
        Me.tb_bagian.Location = New System.Drawing.Point(16, 83)
        Me.tb_bagian.Name = "tb_bagian"
        Me.tb_bagian.Size = New System.Drawing.Size(117, 20)
        Me.tb_bagian.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(271, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tambah Permintaan Pembelian"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dialogPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 413)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_bagian)
        Me.Controls.Add(Me.l_bagian)
        Me.Controls.Add(Me.b_cancel)
        Me.Controls.Add(Me.b_simpan)
        Me.Controls.Add(Me.l_rincianBarang)
        Me.Controls.Add(Me.dp_tglPermitaalPembelian)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_rincianBrgPP)
        Me.Controls.Add(Me.l_nomorPP)
        Me.Controls.Add(Me.tb_nomorPP)
        Me.Name = "dialogPP"
        Me.Text = "dialogPP"
        CType(Me.dgv_rincianBrgPP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_nomorPP As TextBox
    Friend WithEvents l_nomorPP As Label
    Friend WithEvents dgv_rincianBrgPP As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dp_tglPermitaalPembelian As DateTimePicker
    Friend WithEvents l_rincianBarang As Label
    Friend WithEvents b_simpan As Button
    Friend WithEvents b_cancel As Button
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Kode_BRG As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Satuan As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Bagian As DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As DataGridViewTextBoxColumn
    Friend WithEvents l_bagian As Label
    Friend WithEvents tb_bagian As TextBox
    Friend WithEvents Label2 As Label
End Class

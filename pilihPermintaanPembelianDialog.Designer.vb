<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pilihPermintaanPembelianDialog
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
        Me.dgv_pilihppheader = New System.Windows.Forms.DataGridView()
        Me.b_pilih = New System.Windows.Forms.Button()
        Me.b_cancel = New System.Windows.Forms.Button()
        Me.l_tanggal = New System.Windows.Forms.Label()
        Me.dp_pilihppTglStart = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.l_sampai = New System.Windows.Forms.Label()
        Me.l_nomorPP = New System.Windows.Forms.Label()
        Me.tb_nomorPP = New System.Windows.Forms.TextBox()
        Me.dgv_pilihPPdetail = New System.Windows.Forms.DataGridView()
        Me.pilih = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sisa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_pilihppheader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_pilihPPdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_pilihppheader
        '
        Me.dgv_pilihppheader.AllowUserToResizeColumns = False
        Me.dgv_pilihppheader.AllowUserToResizeRows = False
        Me.dgv_pilihppheader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pilihppheader.Location = New System.Drawing.Point(15, 72)
        Me.dgv_pilihppheader.Name = "dgv_pilihppheader"
        Me.dgv_pilihppheader.ReadOnly = True
        Me.dgv_pilihppheader.RowHeadersVisible = False
        Me.dgv_pilihppheader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_pilihppheader.Size = New System.Drawing.Size(221, 235)
        Me.dgv_pilihppheader.TabIndex = 0
        '
        'b_pilih
        '
        Me.b_pilih.Location = New System.Drawing.Point(507, 321)
        Me.b_pilih.Name = "b_pilih"
        Me.b_pilih.Size = New System.Drawing.Size(75, 23)
        Me.b_pilih.TabIndex = 1
        Me.b_pilih.Text = "Pilih"
        Me.b_pilih.UseVisualStyleBackColor = True
        '
        'b_cancel
        '
        Me.b_cancel.Location = New System.Drawing.Point(587, 321)
        Me.b_cancel.Name = "b_cancel"
        Me.b_cancel.Size = New System.Drawing.Size(75, 23)
        Me.b_cancel.TabIndex = 1
        Me.b_cancel.Text = "Cancel"
        Me.b_cancel.UseVisualStyleBackColor = True
        '
        'l_tanggal
        '
        Me.l_tanggal.AutoSize = True
        Me.l_tanggal.Location = New System.Drawing.Point(12, 15)
        Me.l_tanggal.Name = "l_tanggal"
        Me.l_tanggal.Size = New System.Drawing.Size(46, 13)
        Me.l_tanggal.TabIndex = 2
        Me.l_tanggal.Text = "Tanggal"
        '
        'dp_pilihppTglStart
        '
        Me.dp_pilihppTglStart.CustomFormat = "dd/MM/yyyy"
        Me.dp_pilihppTglStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dp_pilihppTglStart.Location = New System.Drawing.Point(82, 9)
        Me.dp_pilihppTglStart.Name = "dp_pilihppTglStart"
        Me.dp_pilihppTglStart.Size = New System.Drawing.Size(125, 20)
        Me.dp_pilihppTglStart.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(268, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(125, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'l_sampai
        '
        Me.l_sampai.AutoSize = True
        Me.l_sampai.Location = New System.Drawing.Point(218, 13)
        Me.l_sampai.Name = "l_sampai"
        Me.l_sampai.Size = New System.Drawing.Size(40, 13)
        Me.l_sampai.TabIndex = 4
        Me.l_sampai.Text = "sampai"
        '
        'l_nomorPP
        '
        Me.l_nomorPP.AutoSize = True
        Me.l_nomorPP.Location = New System.Drawing.Point(15, 44)
        Me.l_nomorPP.Name = "l_nomorPP"
        Me.l_nomorPP.Size = New System.Drawing.Size(55, 13)
        Me.l_nomorPP.TabIndex = 6
        Me.l_nomorPP.Text = "Nomor PP"
        '
        'tb_nomorPP
        '
        Me.tb_nomorPP.Location = New System.Drawing.Point(82, 44)
        Me.tb_nomorPP.Name = "tb_nomorPP"
        Me.tb_nomorPP.Size = New System.Drawing.Size(311, 20)
        Me.tb_nomorPP.TabIndex = 7
        '
        'dgv_pilihPPdetail
        '
        Me.dgv_pilihPPdetail.AllowUserToResizeRows = False
        Me.dgv_pilihPPdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pilihPPdetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pilih, Me.nomor, Me.kode_barang, Me.nama, Me.satuan, Me.qty, Me.sisa})
        Me.dgv_pilihPPdetail.Location = New System.Drawing.Point(268, 72)
        Me.dgv_pilihPPdetail.Name = "dgv_pilihPPdetail"
        Me.dgv_pilihPPdetail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgv_pilihPPdetail.RowHeadersVisible = False
        Me.dgv_pilihPPdetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_pilihPPdetail.Size = New System.Drawing.Size(600, 235)
        Me.dgv_pilihPPdetail.TabIndex = 8
        '
        'pilih
        '
        Me.pilih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.pilih.HeaderText = "Pilih"
        Me.pilih.Name = "pilih"
        Me.pilih.Width = 32
        '
        'nomor
        '
        Me.nomor.HeaderText = "Nomor"
        Me.nomor.Name = "nomor"
        Me.nomor.ReadOnly = True
        Me.nomor.Width = 75
        '
        'kode_barang
        '
        Me.kode_barang.HeaderText = "Kode BRG"
        Me.kode_barang.Name = "kode_barang"
        Me.kode_barang.ReadOnly = True
        Me.kode_barang.Width = 85
        '
        'nama
        '
        Me.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama.HeaderText = "Nama"
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        '
        'satuan
        '
        Me.satuan.HeaderText = "Satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.ReadOnly = True
        Me.satuan.Width = 55
        '
        'qty
        '
        Me.qty.HeaderText = "qty"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.Width = 55
        '
        'sisa
        '
        Me.sisa.HeaderText = "sisa"
        Me.sisa.Name = "sisa"
        Me.sisa.ReadOnly = True
        Me.sisa.Width = 50
        '
        'pilihPermintaanPembelianDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 356)
        Me.Controls.Add(Me.dgv_pilihPPdetail)
        Me.Controls.Add(Me.tb_nomorPP)
        Me.Controls.Add(Me.l_nomorPP)
        Me.Controls.Add(Me.l_sampai)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.dp_pilihppTglStart)
        Me.Controls.Add(Me.l_tanggal)
        Me.Controls.Add(Me.b_cancel)
        Me.Controls.Add(Me.b_pilih)
        Me.Controls.Add(Me.dgv_pilihppheader)
        Me.Name = "pilihPermintaanPembelianDialog"
        Me.Text = "pilihPermintaanPembelianDialog"
        CType(Me.dgv_pilihppheader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_pilihPPdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_pilihppheader As DataGridView
    Friend WithEvents b_pilih As Button
    Friend WithEvents b_cancel As Button
    Friend WithEvents l_tanggal As Label
    Friend WithEvents dp_pilihppTglStart As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents l_sampai As Label
    Friend WithEvents l_nomorPP As Label
    Friend WithEvents tb_nomorPP As TextBox
    Friend WithEvents dgv_pilihPPdetail As DataGridView
    Friend WithEvents pilih As DataGridViewCheckBoxColumn
    Friend WithEvents nomor As DataGridViewTextBoxColumn
    Friend WithEvents kode_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents satuan As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents sisa As DataGridViewTextBoxColumn
End Class

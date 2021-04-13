<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogEditBarang
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
        Me.l_editDataBarang = New System.Windows.Forms.Label()
        Me.l_kodebarang = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.l_namabarang = New System.Windows.Forms.Label()
        Me.l_satuan = New System.Windows.Forms.Label()
        Me.l_group = New System.Windows.Forms.Label()
        Me.l_subgroup = New System.Windows.Forms.Label()
        Me.l_pakaiacc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l_sname = New System.Windows.Forms.Label()
        Me.l_stokmin = New System.Windows.Forms.Label()
        Me.l_stokmax = New System.Windows.Forms.Label()
        Me.l_hargabeli = New System.Windows.Forms.Label()
        Me.l_hargapokok = New System.Windows.Forms.Label()
        Me.l_stock = New System.Windows.Forms.Label()
        Me.l_rpjumlah = New System.Windows.Forms.Label()
        Me.l_tglbeli = New System.Windows.Forms.Label()
        Me.l_tglpakai = New System.Windows.Forms.Label()
        Me.l_imgfile = New System.Windows.Forms.Label()
        Me.l_keterangan = New System.Windows.Forms.Label()
        Me.tb_kodebarang = New System.Windows.Forms.TextBox()
        Me.tb_barcode = New System.Windows.Forms.TextBox()
        Me.tb_namabarang = New System.Windows.Forms.TextBox()
        Me.tb_satuan = New System.Windows.Forms.TextBox()
        Me.tb_group = New System.Windows.Forms.TextBox()
        Me.tb_subgroup = New System.Windows.Forms.TextBox()
        Me.tb_sname = New System.Windows.Forms.TextBox()
        Me.tb_pakaiacc = New System.Windows.Forms.TextBox()
        Me.tb_rak = New System.Windows.Forms.TextBox()
        Me.tb_stockmin = New System.Windows.Forms.TextBox()
        Me.tb_stockmax = New System.Windows.Forms.TextBox()
        Me.tbhargabeli = New System.Windows.Forms.TextBox()
        Me.tb_hargapokok = New System.Windows.Forms.TextBox()
        Me.tb_stock = New System.Windows.Forms.TextBox()
        Me.rp_jumlah = New System.Windows.Forms.TextBox()
        Me.tb_tglbeli = New System.Windows.Forms.TextBox()
        Me.tgl_pakai = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tb_keterangan = New System.Windows.Forms.TextBox()
        Me.b_save = New System.Windows.Forms.Button()
        Me.b_cancel = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'l_editDataBarang
        '
        Me.l_editDataBarang.AutoSize = True
        Me.l_editDataBarang.Location = New System.Drawing.Point(267, 9)
        Me.l_editDataBarang.Name = "l_editDataBarang"
        Me.l_editDataBarang.Size = New System.Drawing.Size(87, 13)
        Me.l_editDataBarang.TabIndex = 0
        Me.l_editDataBarang.Text = "Edit Data barang"
        '
        'l_kodebarang
        '
        Me.l_kodebarang.AutoSize = True
        Me.l_kodebarang.Location = New System.Drawing.Point(28, 68)
        Me.l_kodebarang.Name = "l_kodebarang"
        Me.l_kodebarang.Size = New System.Drawing.Size(69, 13)
        Me.l_kodebarang.TabIndex = 1
        Me.l_kodebarang.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Barcode"
        '
        'l_namabarang
        '
        Me.l_namabarang.AutoSize = True
        Me.l_namabarang.Location = New System.Drawing.Point(28, 124)
        Me.l_namabarang.Name = "l_namabarang"
        Me.l_namabarang.Size = New System.Drawing.Size(72, 13)
        Me.l_namabarang.TabIndex = 3
        Me.l_namabarang.Text = "Nama Barang"
        '
        'l_satuan
        '
        Me.l_satuan.AutoSize = True
        Me.l_satuan.Location = New System.Drawing.Point(28, 151)
        Me.l_satuan.Name = "l_satuan"
        Me.l_satuan.Size = New System.Drawing.Size(41, 13)
        Me.l_satuan.TabIndex = 4
        Me.l_satuan.Text = "Satuan"
        '
        'l_group
        '
        Me.l_group.AutoSize = True
        Me.l_group.Location = New System.Drawing.Point(28, 177)
        Me.l_group.Name = "l_group"
        Me.l_group.Size = New System.Drawing.Size(36, 13)
        Me.l_group.TabIndex = 5
        Me.l_group.Text = "Group"
        '
        'l_subgroup
        '
        Me.l_subgroup.AutoSize = True
        Me.l_subgroup.Location = New System.Drawing.Point(27, 203)
        Me.l_subgroup.Name = "l_subgroup"
        Me.l_subgroup.Size = New System.Drawing.Size(53, 13)
        Me.l_subgroup.TabIndex = 6
        Me.l_subgroup.Text = "Subgroup"
        '
        'l_pakaiacc
        '
        Me.l_pakaiacc.AutoSize = True
        Me.l_pakaiacc.Location = New System.Drawing.Point(27, 258)
        Me.l_pakaiacc.Name = "l_pakaiacc"
        Me.l_pakaiacc.Size = New System.Drawing.Size(56, 13)
        Me.l_pakaiacc.TabIndex = 7
        Me.l_pakaiacc.Text = "Pakai Acc"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Rak"
        '
        'l_sname
        '
        Me.l_sname.AutoSize = True
        Me.l_sname.Location = New System.Drawing.Point(28, 231)
        Me.l_sname.Name = "l_sname"
        Me.l_sname.Size = New System.Drawing.Size(42, 13)
        Me.l_sname.TabIndex = 9
        Me.l_sname.Text = "SName"
        '
        'l_stokmin
        '
        Me.l_stokmin.AutoSize = True
        Me.l_stokmin.Location = New System.Drawing.Point(28, 309)
        Me.l_stokmin.Name = "l_stokmin"
        Me.l_stokmin.Size = New System.Drawing.Size(49, 13)
        Me.l_stokmin.TabIndex = 10
        Me.l_stokmin.Text = "Stok Min"
        '
        'l_stokmax
        '
        Me.l_stokmax.AutoSize = True
        Me.l_stokmax.Location = New System.Drawing.Point(27, 336)
        Me.l_stokmax.Name = "l_stokmax"
        Me.l_stokmax.Size = New System.Drawing.Size(52, 13)
        Me.l_stokmax.TabIndex = 11
        Me.l_stokmax.Text = "Stok Max"
        '
        'l_hargabeli
        '
        Me.l_hargabeli.AutoSize = True
        Me.l_hargabeli.Location = New System.Drawing.Point(345, 68)
        Me.l_hargabeli.Name = "l_hargabeli"
        Me.l_hargabeli.Size = New System.Drawing.Size(56, 13)
        Me.l_hargabeli.TabIndex = 12
        Me.l_hargabeli.Text = "Harga Beli"
        '
        'l_hargapokok
        '
        Me.l_hargapokok.AutoSize = True
        Me.l_hargapokok.Location = New System.Drawing.Point(345, 97)
        Me.l_hargapokok.Name = "l_hargapokok"
        Me.l_hargapokok.Size = New System.Drawing.Size(70, 13)
        Me.l_hargapokok.TabIndex = 13
        Me.l_hargapokok.Text = "Harga Pokok"
        '
        'l_stock
        '
        Me.l_stock.AutoSize = True
        Me.l_stock.Location = New System.Drawing.Point(345, 124)
        Me.l_stock.Name = "l_stock"
        Me.l_stock.Size = New System.Drawing.Size(35, 13)
        Me.l_stock.TabIndex = 14
        Me.l_stock.Text = "Stock"
        '
        'l_rpjumlah
        '
        Me.l_rpjumlah.AutoSize = True
        Me.l_rpjumlah.Location = New System.Drawing.Point(345, 151)
        Me.l_rpjumlah.Name = "l_rpjumlah"
        Me.l_rpjumlah.Size = New System.Drawing.Size(57, 13)
        Me.l_rpjumlah.TabIndex = 15
        Me.l_rpjumlah.Text = "Rp Jumlah"
        '
        'l_tglbeli
        '
        Me.l_tglbeli.AutoSize = True
        Me.l_tglbeli.Location = New System.Drawing.Point(345, 177)
        Me.l_tglbeli.Name = "l_tglbeli"
        Me.l_tglbeli.Size = New System.Drawing.Size(66, 13)
        Me.l_tglbeli.TabIndex = 16
        Me.l_tglbeli.Text = "Tanggal Beli"
        '
        'l_tglpakai
        '
        Me.l_tglpakai.AutoSize = True
        Me.l_tglpakai.Location = New System.Drawing.Point(345, 203)
        Me.l_tglpakai.Name = "l_tglpakai"
        Me.l_tglpakai.Size = New System.Drawing.Size(76, 13)
        Me.l_tglpakai.TabIndex = 17
        Me.l_tglpakai.Text = "Tanggal Pakai"
        '
        'l_imgfile
        '
        Me.l_imgfile.AutoSize = True
        Me.l_imgfile.Location = New System.Drawing.Point(348, 231)
        Me.l_imgfile.Name = "l_imgfile"
        Me.l_imgfile.Size = New System.Drawing.Size(44, 13)
        Me.l_imgfile.TabIndex = 18
        Me.l_imgfile.Text = "Gambar"
        '
        'l_keterangan
        '
        Me.l_keterangan.AutoSize = True
        Me.l_keterangan.Location = New System.Drawing.Point(345, 339)
        Me.l_keterangan.Name = "l_keterangan"
        Me.l_keterangan.Size = New System.Drawing.Size(62, 13)
        Me.l_keterangan.TabIndex = 19
        Me.l_keterangan.Text = "Keterangan"
        '
        'tb_kodebarang
        '
        Me.tb_kodebarang.Location = New System.Drawing.Point(133, 68)
        Me.tb_kodebarang.Name = "tb_kodebarang"
        Me.tb_kodebarang.Size = New System.Drawing.Size(189, 20)
        Me.tb_kodebarang.TabIndex = 20
        '
        'tb_barcode
        '
        Me.tb_barcode.Location = New System.Drawing.Point(133, 97)
        Me.tb_barcode.Name = "tb_barcode"
        Me.tb_barcode.Size = New System.Drawing.Size(189, 20)
        Me.tb_barcode.TabIndex = 21
        '
        'tb_namabarang
        '
        Me.tb_namabarang.Location = New System.Drawing.Point(133, 124)
        Me.tb_namabarang.Name = "tb_namabarang"
        Me.tb_namabarang.Size = New System.Drawing.Size(189, 20)
        Me.tb_namabarang.TabIndex = 21
        '
        'tb_satuan
        '
        Me.tb_satuan.Location = New System.Drawing.Point(133, 151)
        Me.tb_satuan.Name = "tb_satuan"
        Me.tb_satuan.Size = New System.Drawing.Size(189, 20)
        Me.tb_satuan.TabIndex = 21
        '
        'tb_group
        '
        Me.tb_group.Location = New System.Drawing.Point(133, 177)
        Me.tb_group.Name = "tb_group"
        Me.tb_group.Size = New System.Drawing.Size(189, 20)
        Me.tb_group.TabIndex = 21
        '
        'tb_subgroup
        '
        Me.tb_subgroup.Location = New System.Drawing.Point(133, 203)
        Me.tb_subgroup.Name = "tb_subgroup"
        Me.tb_subgroup.Size = New System.Drawing.Size(189, 20)
        Me.tb_subgroup.TabIndex = 21
        '
        'tb_sname
        '
        Me.tb_sname.Location = New System.Drawing.Point(133, 231)
        Me.tb_sname.Name = "tb_sname"
        Me.tb_sname.Size = New System.Drawing.Size(189, 20)
        Me.tb_sname.TabIndex = 21
        '
        'tb_pakaiacc
        '
        Me.tb_pakaiacc.Location = New System.Drawing.Point(133, 258)
        Me.tb_pakaiacc.Name = "tb_pakaiacc"
        Me.tb_pakaiacc.Size = New System.Drawing.Size(189, 20)
        Me.tb_pakaiacc.TabIndex = 21
        '
        'tb_rak
        '
        Me.tb_rak.Location = New System.Drawing.Point(133, 282)
        Me.tb_rak.Name = "tb_rak"
        Me.tb_rak.Size = New System.Drawing.Size(189, 20)
        Me.tb_rak.TabIndex = 21
        '
        'tb_stockmin
        '
        Me.tb_stockmin.Location = New System.Drawing.Point(133, 309)
        Me.tb_stockmin.Name = "tb_stockmin"
        Me.tb_stockmin.Size = New System.Drawing.Size(189, 20)
        Me.tb_stockmin.TabIndex = 21
        '
        'tb_stockmax
        '
        Me.tb_stockmax.Location = New System.Drawing.Point(133, 336)
        Me.tb_stockmax.Name = "tb_stockmax"
        Me.tb_stockmax.Size = New System.Drawing.Size(189, 20)
        Me.tb_stockmax.TabIndex = 21
        '
        'tbhargabeli
        '
        Me.tbhargabeli.Location = New System.Drawing.Point(453, 68)
        Me.tbhargabeli.Name = "tbhargabeli"
        Me.tbhargabeli.Size = New System.Drawing.Size(189, 20)
        Me.tbhargabeli.TabIndex = 21
        '
        'tb_hargapokok
        '
        Me.tb_hargapokok.Location = New System.Drawing.Point(453, 97)
        Me.tb_hargapokok.Name = "tb_hargapokok"
        Me.tb_hargapokok.Size = New System.Drawing.Size(189, 20)
        Me.tb_hargapokok.TabIndex = 21
        '
        'tb_stock
        '
        Me.tb_stock.Location = New System.Drawing.Point(453, 124)
        Me.tb_stock.Name = "tb_stock"
        Me.tb_stock.Size = New System.Drawing.Size(189, 20)
        Me.tb_stock.TabIndex = 21
        '
        'rp_jumlah
        '
        Me.rp_jumlah.Location = New System.Drawing.Point(453, 150)
        Me.rp_jumlah.Name = "rp_jumlah"
        Me.rp_jumlah.Size = New System.Drawing.Size(189, 20)
        Me.rp_jumlah.TabIndex = 21
        '
        'tb_tglbeli
        '
        Me.tb_tglbeli.Location = New System.Drawing.Point(453, 177)
        Me.tb_tglbeli.Name = "tb_tglbeli"
        Me.tb_tglbeli.Size = New System.Drawing.Size(189, 20)
        Me.tb_tglbeli.TabIndex = 21
        '
        'tgl_pakai
        '
        Me.tgl_pakai.Location = New System.Drawing.Point(453, 203)
        Me.tgl_pakai.Name = "tgl_pakai"
        Me.tgl_pakai.Size = New System.Drawing.Size(189, 20)
        Me.tgl_pakai.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(453, 231)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 91)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'tb_keterangan
        '
        Me.tb_keterangan.Location = New System.Drawing.Point(453, 339)
        Me.tb_keterangan.Name = "tb_keterangan"
        Me.tb_keterangan.Size = New System.Drawing.Size(189, 20)
        Me.tb_keterangan.TabIndex = 21
        '
        'b_save
        '
        Me.b_save.Location = New System.Drawing.Point(453, 406)
        Me.b_save.Name = "b_save"
        Me.b_save.Size = New System.Drawing.Size(75, 23)
        Me.b_save.TabIndex = 23
        Me.b_save.Text = "Save"
        Me.b_save.UseVisualStyleBackColor = True
        '
        'b_cancel
        '
        Me.b_cancel.Location = New System.Drawing.Point(551, 406)
        Me.b_cancel.Name = "b_cancel"
        Me.b_cancel.Size = New System.Drawing.Size(75, 23)
        Me.b_cancel.TabIndex = 23
        Me.b_cancel.Text = "Cancel"
        Me.b_cancel.UseVisualStyleBackColor = True
        '
        'dialogEditBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 455)
        Me.Controls.Add(Me.b_cancel)
        Me.Controls.Add(Me.b_save)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tb_keterangan)
        Me.Controls.Add(Me.tgl_pakai)
        Me.Controls.Add(Me.tb_tglbeli)
        Me.Controls.Add(Me.rp_jumlah)
        Me.Controls.Add(Me.tb_stock)
        Me.Controls.Add(Me.tb_hargapokok)
        Me.Controls.Add(Me.tbhargabeli)
        Me.Controls.Add(Me.tb_stockmax)
        Me.Controls.Add(Me.tb_stockmin)
        Me.Controls.Add(Me.tb_rak)
        Me.Controls.Add(Me.tb_pakaiacc)
        Me.Controls.Add(Me.tb_sname)
        Me.Controls.Add(Me.tb_subgroup)
        Me.Controls.Add(Me.tb_group)
        Me.Controls.Add(Me.tb_satuan)
        Me.Controls.Add(Me.tb_namabarang)
        Me.Controls.Add(Me.tb_barcode)
        Me.Controls.Add(Me.tb_kodebarang)
        Me.Controls.Add(Me.l_keterangan)
        Me.Controls.Add(Me.l_imgfile)
        Me.Controls.Add(Me.l_tglpakai)
        Me.Controls.Add(Me.l_tglbeli)
        Me.Controls.Add(Me.l_rpjumlah)
        Me.Controls.Add(Me.l_stock)
        Me.Controls.Add(Me.l_hargapokok)
        Me.Controls.Add(Me.l_hargabeli)
        Me.Controls.Add(Me.l_stokmax)
        Me.Controls.Add(Me.l_stokmin)
        Me.Controls.Add(Me.l_sname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.l_pakaiacc)
        Me.Controls.Add(Me.l_subgroup)
        Me.Controls.Add(Me.l_group)
        Me.Controls.Add(Me.l_satuan)
        Me.Controls.Add(Me.l_namabarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.l_kodebarang)
        Me.Controls.Add(Me.l_editDataBarang)
        Me.Name = "dialogEditBarang"
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents l_editDataBarang As Label
    Friend WithEvents l_kodebarang As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents l_namabarang As Label
    Friend WithEvents l_satuan As Label
    Friend WithEvents l_group As Label
    Friend WithEvents l_subgroup As Label
    Friend WithEvents l_pakaiacc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents l_sname As Label
    Friend WithEvents l_stokmin As Label
    Friend WithEvents l_stokmax As Label
    Friend WithEvents l_hargabeli As Label
    Friend WithEvents l_hargapokok As Label
    Friend WithEvents l_stock As Label
    Friend WithEvents l_rpjumlah As Label
    Friend WithEvents l_tglbeli As Label
    Friend WithEvents l_tglpakai As Label
    Friend WithEvents l_imgfile As Label
    Friend WithEvents l_keterangan As Label
    Friend WithEvents tb_kodebarang As TextBox
    Friend WithEvents tb_barcode As TextBox
    Friend WithEvents tb_namabarang As TextBox
    Friend WithEvents tb_satuan As TextBox
    Friend WithEvents tb_group As TextBox
    Friend WithEvents tb_subgroup As TextBox
    Friend WithEvents tb_sname As TextBox
    Friend WithEvents tb_pakaiacc As TextBox
    Friend WithEvents tb_rak As TextBox
    Friend WithEvents tb_stockmin As TextBox
    Friend WithEvents tb_stockmax As TextBox
    Friend WithEvents tbhargabeli As TextBox
    Friend WithEvents tb_hargapokok As TextBox
    Friend WithEvents tb_stock As TextBox
    Friend WithEvents rp_jumlah As TextBox
    Friend WithEvents tb_tglbeli As TextBox
    Friend WithEvents tgl_pakai As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tb_keterangan As TextBox
    Friend WithEvents b_save As Button
    Friend WithEvents b_cancel As Button
End Class

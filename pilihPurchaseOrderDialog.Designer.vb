<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pilihPurchaseOrderDialog
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
        Me.dgv_pilihpodetail = New System.Windows.Forms.DataGridView()
        Me.pilih = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sisa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_nomorPO = New System.Windows.Forms.TextBox()
        Me.l_nomorPO = New System.Windows.Forms.Label()
        Me.l_sampai = New System.Windows.Forms.Label()
        Me.dp_pilihPoEnd = New System.Windows.Forms.DateTimePicker()
        Me.dp_pilihpoTglStart = New System.Windows.Forms.DateTimePicker()
        Me.l_tanggal = New System.Windows.Forms.Label()
        Me.b_cancel = New System.Windows.Forms.Button()
        Me.b_pilih = New System.Windows.Forms.Button()
        Me.dgv_pilihpoheader = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_pilihpodetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_pilihpoheader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_pilihpodetail
        '
        Me.dgv_pilihpodetail.AllowUserToResizeRows = False
        Me.dgv_pilihpodetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pilihpodetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pilih, Me.nomor, Me.kode_barang, Me.nama, Me.satuan, Me.qty, Me.sisa})
        Me.dgv_pilihpodetail.Location = New System.Drawing.Point(260, 73)
        Me.dgv_pilihpodetail.Name = "dgv_pilihpodetail"
        Me.dgv_pilihpodetail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgv_pilihpodetail.RowHeadersVisible = False
        Me.dgv_pilihpodetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_pilihpodetail.Size = New System.Drawing.Size(600, 235)
        Me.dgv_pilihpodetail.TabIndex = 18
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
        'tb_nomorPO
        '
        Me.tb_nomorPO.Location = New System.Drawing.Point(74, 45)
        Me.tb_nomorPO.Name = "tb_nomorPO"
        Me.tb_nomorPO.Size = New System.Drawing.Size(311, 20)
        Me.tb_nomorPO.TabIndex = 17
        '
        'l_nomorPO
        '
        Me.l_nomorPO.AutoSize = True
        Me.l_nomorPO.Location = New System.Drawing.Point(7, 48)
        Me.l_nomorPO.Name = "l_nomorPO"
        Me.l_nomorPO.Size = New System.Drawing.Size(56, 13)
        Me.l_nomorPO.TabIndex = 16
        Me.l_nomorPO.Text = "Nomor PO"
        '
        'l_sampai
        '
        Me.l_sampai.AutoSize = True
        Me.l_sampai.Location = New System.Drawing.Point(210, 14)
        Me.l_sampai.Name = "l_sampai"
        Me.l_sampai.Size = New System.Drawing.Size(40, 13)
        Me.l_sampai.TabIndex = 15
        Me.l_sampai.Text = "sampai"
        '
        'dp_pilihPoEnd
        '
        Me.dp_pilihPoEnd.CustomFormat = "dd/MM/yyyy"
        Me.dp_pilihPoEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dp_pilihPoEnd.Location = New System.Drawing.Point(260, 9)
        Me.dp_pilihPoEnd.Name = "dp_pilihPoEnd"
        Me.dp_pilihPoEnd.Size = New System.Drawing.Size(125, 20)
        Me.dp_pilihPoEnd.TabIndex = 13
        '
        'dp_pilihpoTglStart
        '
        Me.dp_pilihpoTglStart.CustomFormat = "dd/MM/yyyy"
        Me.dp_pilihpoTglStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dp_pilihpoTglStart.Location = New System.Drawing.Point(74, 10)
        Me.dp_pilihpoTglStart.Name = "dp_pilihpoTglStart"
        Me.dp_pilihpoTglStart.Size = New System.Drawing.Size(125, 20)
        Me.dp_pilihpoTglStart.TabIndex = 14
        '
        'l_tanggal
        '
        Me.l_tanggal.AutoSize = True
        Me.l_tanggal.Location = New System.Drawing.Point(7, 14)
        Me.l_tanggal.Name = "l_tanggal"
        Me.l_tanggal.Size = New System.Drawing.Size(46, 13)
        Me.l_tanggal.TabIndex = 12
        Me.l_tanggal.Text = "Tanggal"
        '
        'b_cancel
        '
        Me.b_cancel.Location = New System.Drawing.Point(785, 318)
        Me.b_cancel.Name = "b_cancel"
        Me.b_cancel.Size = New System.Drawing.Size(75, 23)
        Me.b_cancel.TabIndex = 10
        Me.b_cancel.Text = "Cancel"
        Me.b_cancel.UseVisualStyleBackColor = True
        '
        'b_pilih
        '
        Me.b_pilih.Location = New System.Drawing.Point(705, 318)
        Me.b_pilih.Name = "b_pilih"
        Me.b_pilih.Size = New System.Drawing.Size(75, 23)
        Me.b_pilih.TabIndex = 11
        Me.b_pilih.Text = "Pilih"
        Me.b_pilih.UseVisualStyleBackColor = True
        '
        'dgv_pilihpoheader
        '
        Me.dgv_pilihpoheader.AllowUserToResizeColumns = False
        Me.dgv_pilihpoheader.AllowUserToResizeRows = False
        Me.dgv_pilihpoheader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pilihpoheader.Location = New System.Drawing.Point(7, 73)
        Me.dgv_pilihpoheader.Name = "dgv_pilihpoheader"
        Me.dgv_pilihpoheader.ReadOnly = True
        Me.dgv_pilihpoheader.RowHeadersVisible = False
        Me.dgv_pilihpoheader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_pilihpoheader.Size = New System.Drawing.Size(221, 235)
        Me.dgv_pilihpoheader.TabIndex = 9
        '
        'pilihPurchaseOrderDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 351)
        Me.Controls.Add(Me.dgv_pilihpodetail)
        Me.Controls.Add(Me.tb_nomorPO)
        Me.Controls.Add(Me.l_nomorPO)
        Me.Controls.Add(Me.l_sampai)
        Me.Controls.Add(Me.dp_pilihPoEnd)
        Me.Controls.Add(Me.dp_pilihpoTglStart)
        Me.Controls.Add(Me.l_tanggal)
        Me.Controls.Add(Me.b_cancel)
        Me.Controls.Add(Me.b_pilih)
        Me.Controls.Add(Me.dgv_pilihpoheader)
        Me.Name = "pilihPurchaseOrderDialog"
        Me.Text = "Pilih Purchase Order"
        CType(Me.dgv_pilihpodetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_pilihpoheader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_pilihpodetail As DataGridView
    Friend WithEvents pilih As DataGridViewCheckBoxColumn
    Friend WithEvents nomor As DataGridViewTextBoxColumn
    Friend WithEvents kode_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents satuan As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents sisa As DataGridViewTextBoxColumn
    Friend WithEvents tb_nomorPO As TextBox
    Friend WithEvents l_nomorPO As Label
    Friend WithEvents l_sampai As Label
    Friend WithEvents dp_pilihPoEnd As DateTimePicker
    Friend WithEvents dp_pilihpoTglStart As DateTimePicker
    Friend WithEvents l_tanggal As Label
    Friend WithEvents b_cancel As Button
    Friend WithEvents b_pilih As Button
    Friend WithEvents dgv_pilihpoheader As DataGridView
End Class

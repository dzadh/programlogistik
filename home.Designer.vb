﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.l_statusdb = New System.Windows.Forms.Label()
        Me.l_status = New System.Windows.Forms.Label()
        Me.b_tambahtab2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gb_filterTanggal = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dp_filtermulai = New System.Windows.Forms.DateTimePicker()
        Me.cb_filterTanggal = New System.Windows.Forms.CheckBox()
        Me.l_bagian = New System.Windows.Forms.Label()
        Me.l_nomorNota = New System.Windows.Forms.Label()
        Me.tb_searchppbynota = New System.Windows.Forms.TextBox()
        Me.tb_searchppbybagian = New System.Windows.Forms.TextBox()
        Me.l_pencarian = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.dgv_databagian = New System.Windows.Forms.DataGridView()
        Me.dgv_databarang = New System.Windows.Forms.DataGridView()
        Me.dgv_datasupplier = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBagianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gb_filterTanggal.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_databagian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_databarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_datasupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'l_statusdb
        '
        Me.l_statusdb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_statusdb.AutoSize = True
        Me.l_statusdb.Location = New System.Drawing.Point(1205, 9)
        Me.l_statusdb.Name = "l_statusdb"
        Me.l_statusdb.Size = New System.Drawing.Size(73, 13)
        Me.l_statusdb.TabIndex = 2
        Me.l_statusdb.Text = "Disconnected"
        '
        'l_status
        '
        Me.l_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_status.AutoSize = True
        Me.l_status.Location = New System.Drawing.Point(1156, 9)
        Me.l_status.Name = "l_status"
        Me.l_status.Size = New System.Drawing.Size(43, 13)
        Me.l_status.TabIndex = 3
        Me.l_status.Text = "Status :"
        '
        'b_tambahtab2
        '
        Me.b_tambahtab2.Location = New System.Drawing.Point(30, 411)
        Me.b_tambahtab2.Name = "b_tambahtab2"
        Me.b_tambahtab2.Size = New System.Drawing.Size(75, 23)
        Me.b_tambahtab2.TabIndex = 5
        Me.b_tambahtab2.Text = "buat pp"
        Me.b_tambahtab2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ItemSize = New System.Drawing.Size(149, 26)
        Me.TabControl1.Location = New System.Drawing.Point(30, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1308, 641)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gb_filterTanggal)
        Me.TabPage1.Controls.Add(Me.cb_filterTanggal)
        Me.TabPage1.Controls.Add(Me.l_bagian)
        Me.TabPage1.Controls.Add(Me.l_nomorNota)
        Me.TabPage1.Controls.Add(Me.tb_searchppbynota)
        Me.TabPage1.Controls.Add(Me.tb_searchppbybagian)
        Me.TabPage1.Controls.Add(Me.l_pencarian)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1300, 607)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Daftar Permintaan Pembelian"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gb_filterTanggal
        '
        Me.gb_filterTanggal.Controls.Add(Me.DateTimePicker1)
        Me.gb_filterTanggal.Controls.Add(Me.Label2)
        Me.gb_filterTanggal.Controls.Add(Me.Label1)
        Me.gb_filterTanggal.Controls.Add(Me.dp_filtermulai)
        Me.gb_filterTanggal.Location = New System.Drawing.Point(21, 217)
        Me.gb_filterTanggal.Name = "gb_filterTanggal"
        Me.gb_filterTanggal.Size = New System.Drawing.Size(170, 100)
        Me.gb_filterTanggal.TabIndex = 6
        Me.gb_filterTanggal.TabStop = False
        Me.gb_filterTanggal.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(5, 70)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(159, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "sampai dengan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mulai"
        '
        'dp_filtermulai
        '
        Me.dp_filtermulai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dp_filtermulai.Location = New System.Drawing.Point(5, 29)
        Me.dp_filtermulai.Name = "dp_filtermulai"
        Me.dp_filtermulai.Size = New System.Drawing.Size(157, 20)
        Me.dp_filtermulai.TabIndex = 0
        Me.dp_filtermulai.Value = New Date(2021, 4, 1, 0, 0, 0, 0)
        '
        'cb_filterTanggal
        '
        Me.cb_filterTanggal.AutoSize = True
        Me.cb_filterTanggal.Location = New System.Drawing.Point(21, 194)
        Me.cb_filterTanggal.Name = "cb_filterTanggal"
        Me.cb_filterTanggal.Size = New System.Drawing.Size(90, 17)
        Me.cb_filterTanggal.TabIndex = 5
        Me.cb_filterTanggal.Text = "Filter Tanggal"
        Me.cb_filterTanggal.UseVisualStyleBackColor = True
        '
        'l_bagian
        '
        Me.l_bagian.AutoSize = True
        Me.l_bagian.Location = New System.Drawing.Point(17, 95)
        Me.l_bagian.Name = "l_bagian"
        Me.l_bagian.Size = New System.Drawing.Size(40, 13)
        Me.l_bagian.TabIndex = 4
        Me.l_bagian.Text = "Bagian"
        '
        'l_nomorNota
        '
        Me.l_nomorNota.AutoSize = True
        Me.l_nomorNota.Location = New System.Drawing.Point(18, 45)
        Me.l_nomorNota.Name = "l_nomorNota"
        Me.l_nomorNota.Size = New System.Drawing.Size(64, 13)
        Me.l_nomorNota.TabIndex = 3
        Me.l_nomorNota.Text = "Nomor Nota"
        '
        'tb_searchppbynota
        '
        Me.tb_searchppbynota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_searchppbynota.Location = New System.Drawing.Point(20, 62)
        Me.tb_searchppbynota.Name = "tb_searchppbynota"
        Me.tb_searchppbynota.Size = New System.Drawing.Size(163, 24)
        Me.tb_searchppbynota.TabIndex = 2
        '
        'tb_searchppbybagian
        '
        Me.tb_searchppbybagian.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_searchppbybagian.Location = New System.Drawing.Point(20, 113)
        Me.tb_searchppbybagian.Name = "tb_searchppbybagian"
        Me.tb_searchppbybagian.Size = New System.Drawing.Size(163, 24)
        Me.tb_searchppbybagian.TabIndex = 2
        '
        'l_pencarian
        '
        Me.l_pencarian.AutoSize = True
        Me.l_pencarian.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_pencarian.Location = New System.Drawing.Point(17, 17)
        Me.l_pencarian.Name = "l_pencarian"
        Me.l_pencarian.Size = New System.Drawing.Size(93, 18)
        Me.l_pencarian.TabIndex = 1
        Me.l_pencarian.Text = "PENCARIAN"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(210, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1120, 539)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1300, 607)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Daftar PO"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1288, 562)
        Me.DataGridView2.TabIndex = 0
        '
        'dgv_databagian
        '
        Me.dgv_databagian.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.dgv_databagian.Location = New System.Drawing.Point(6, 6)
        Me.dgv_databagian.Name = "dgv_databagian"
        Me.dgv_databagian.ReadOnly = True
        Me.dgv_databagian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_databagian.Size = New System.Drawing.Size(803, 290)
        Me.dgv_databagian.TabIndex = 0
        '
        'dgv_databarang
        '
        Me.dgv_databarang.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv_databarang.Location = New System.Drawing.Point(6, 6)
        Me.dgv_databarang.Name = "dgv_databarang"
        Me.dgv_databarang.ReadOnly = True
        Me.dgv_databarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_databarang.Size = New System.Drawing.Size(803, 290)
        Me.dgv_databarang.TabIndex = 0
        '
        'dgv_datasupplier
        '
        Me.dgv_datasupplier.Location = New System.Drawing.Point(7, 0)
        Me.dgv_datasupplier.Name = "dgv_datasupplier"
        Me.dgv_datasupplier.ReadOnly = True
        Me.dgv_datasupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_datasupplier.Size = New System.Drawing.Size(803, 290)
        Me.dgv_datasupplier.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1364, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBagianToolStripMenuItem, Me.DataToolStripMenuItem, Me.DataBarangToolStripMenuItem, Me.DataSupplierToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'DataBagianToolStripMenuItem
        '
        Me.DataBagianToolStripMenuItem.Name = "DataBagianToolStripMenuItem"
        Me.DataBagianToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DataBagianToolStripMenuItem.Text = "Data Bagian"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DataToolStripMenuItem.Text = "Data Divisi"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DataBarangToolStripMenuItem.Text = "Data Barang"
        '
        'DataSupplierToolStripMenuItem
        '
        Me.DataSupplierToolStripMenuItem.Name = "DataSupplierToolStripMenuItem"
        Me.DataSupplierToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DataSupplierToolStripMenuItem.Text = "Data Supplier"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 749)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.b_tambahtab2)
        Me.Controls.Add(Me.l_status)
        Me.Controls.Add(Me.l_statusdb)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "home"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.gb_filterTanggal.ResumeLayout(False)
        Me.gb_filterTanggal.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_databagian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_databarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_datasupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents l_statusdb As Label
    Friend WithEvents l_status As Label
    Friend WithEvents b_tambahtab2 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents dgv_databagian As DataGridView
    Friend WithEvents dgv_databarang As DataGridView
    Friend WithEvents dgv_datasupplier As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBagianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents l_pencarian As Label
    Friend WithEvents tb_searchppbynota As TextBox
    Friend WithEvents tb_searchppbybagian As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents gb_filterTanggal As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dp_filtermulai As DateTimePicker
    Friend WithEvents cb_filterTanggal As CheckBox
    Friend WithEvents l_bagian As Label
    Friend WithEvents l_nomorNota As Label
End Class

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
        Me.b_save = New System.Windows.Forms.Button()
        Me.b_cancel = New System.Windows.Forms.Button()
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
        Me.Label1.Location = New System.Drawing.Point(672, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nota"
        '
        'tb_notabtb
        '
        Me.tb_notabtb.Location = New System.Drawing.Point(715, 49)
        Me.tb_notabtb.Name = "tb_notabtb"
        Me.tb_notabtb.Size = New System.Drawing.Size(132, 20)
        Me.tb_notabtb.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(606, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "no. purchase order"
        '
        'tb_noPurchaseOrder
        '
        Me.tb_noPurchaseOrder.Location = New System.Drawing.Point(715, 78)
        Me.tb_noPurchaseOrder.Name = "tb_noPurchaseOrder"
        Me.tb_noPurchaseOrder.Size = New System.Drawing.Size(132, 20)
        Me.tb_noPurchaseOrder.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(574, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "no. permintaan pembelian"
        '
        'tb_noPP
        '
        Me.tb_noPP.Location = New System.Drawing.Point(715, 104)
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
        Me.b_pilihPO.Location = New System.Drawing.Point(16, 98)
        Me.b_pilihPO.Name = "b_pilihPO"
        Me.b_pilihPO.Size = New System.Drawing.Size(94, 23)
        Me.b_pilihPO.TabIndex = 9
        Me.b_pilihPO.Text = "Pilih PO"
        Me.b_pilihPO.UseVisualStyleBackColor = True
        '
        'dgv_dialogbtb
        '
        Me.dgv_dialogbtb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dialogbtb.Location = New System.Drawing.Point(16, 130)
        Me.dgv_dialogbtb.Name = "dgv_dialogbtb"
        Me.dgv_dialogbtb.Size = New System.Drawing.Size(831, 260)
        Me.dgv_dialogbtb.TabIndex = 10
        '
        'b_save
        '
        Me.b_save.Location = New System.Drawing.Point(691, 409)
        Me.b_save.Name = "b_save"
        Me.b_save.Size = New System.Drawing.Size(75, 23)
        Me.b_save.TabIndex = 11
        Me.b_save.Text = "Simpan"
        Me.b_save.UseVisualStyleBackColor = True
        '
        'b_cancel
        '
        Me.b_cancel.Location = New System.Drawing.Point(772, 409)
        Me.b_cancel.Name = "b_cancel"
        Me.b_cancel.Size = New System.Drawing.Size(75, 23)
        Me.b_cancel.TabIndex = 11
        Me.b_cancel.Text = "Cancel"
        Me.b_cancel.UseVisualStyleBackColor = True
        '
        'dialogBtb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 444)
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
End Class

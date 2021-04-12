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
        Me.l_kodebarang.Location = New System.Drawing.Point(13, 48)
        Me.l_kodebarang.Name = "l_kodebarang"
        Me.l_kodebarang.Size = New System.Drawing.Size(69, 13)
        Me.l_kodebarang.TabIndex = 1
        Me.l_kodebarang.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Barcode"
        '
        'l_namabarang
        '
        Me.l_namabarang.AutoSize = True
        Me.l_namabarang.Location = New System.Drawing.Point(13, 97)
        Me.l_namabarang.Name = "l_namabarang"
        Me.l_namabarang.Size = New System.Drawing.Size(72, 13)
        Me.l_namabarang.TabIndex = 3
        Me.l_namabarang.Text = "Nama Barang"
        '
        'l_satuan
        '
        Me.l_satuan.AutoSize = True
        Me.l_satuan.Location = New System.Drawing.Point(13, 121)
        Me.l_satuan.Name = "l_satuan"
        Me.l_satuan.Size = New System.Drawing.Size(41, 13)
        Me.l_satuan.TabIndex = 4
        Me.l_satuan.Text = "Satuan"
        '
        'l_group
        '
        Me.l_group.AutoSize = True
        Me.l_group.Location = New System.Drawing.Point(13, 149)
        Me.l_group.Name = "l_group"
        Me.l_group.Size = New System.Drawing.Size(36, 13)
        Me.l_group.TabIndex = 5
        Me.l_group.Text = "Group"
        '
        'l_subgroup
        '
        Me.l_subgroup.AutoSize = True
        Me.l_subgroup.Location = New System.Drawing.Point(12, 174)
        Me.l_subgroup.Name = "l_subgroup"
        Me.l_subgroup.Size = New System.Drawing.Size(53, 13)
        Me.l_subgroup.TabIndex = 6
        Me.l_subgroup.Text = "Subgroup"
        '
        'l_pakaiacc
        '
        Me.l_pakaiacc.AutoSize = True
        Me.l_pakaiacc.Location = New System.Drawing.Point(12, 201)
        Me.l_pakaiacc.Name = "l_pakaiacc"
        Me.l_pakaiacc.Size = New System.Drawing.Size(56, 13)
        Me.l_pakaiacc.TabIndex = 7
        Me.l_pakaiacc.Text = "Pakai Acc"
        '
        'dialogEditBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 455)
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
End Class

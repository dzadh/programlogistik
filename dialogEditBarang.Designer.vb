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
        Me.SuspendLayout()
        '
        'l_editDataBarang
        '
        Me.l_editDataBarang.AutoSize = True
        Me.l_editDataBarang.Location = New System.Drawing.Point(260, 9)
        Me.l_editDataBarang.Name = "l_editDataBarang"
        Me.l_editDataBarang.Size = New System.Drawing.Size(87, 13)
        Me.l_editDataBarang.TabIndex = 0
        Me.l_editDataBarang.Text = "Edit Data barang"
        '
        'dialogEditBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 365)
        Me.Controls.Add(Me.l_editDataBarang)
        Me.Name = "dialogEditBarang"
        Me.Text = "dialogEditBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents l_editDataBarang As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ordDet_a202479
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ordDet_a202479))
        Me.lbl_header1 = New System.Windows.Forms.Label()
        Me.grd_ordDet = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.grd_ordDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_header1
        '
        Me.lbl_header1.AutoSize = True
        Me.lbl_header1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbl_header1.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header1.ForeColor = System.Drawing.Color.White
        Me.lbl_header1.Location = New System.Drawing.Point(12, 32)
        Me.lbl_header1.Name = "lbl_header1"
        Me.lbl_header1.Size = New System.Drawing.Size(399, 50)
        Me.lbl_header1.TabIndex = 67
        Me.lbl_header1.Text = "Order Details"
        '
        'grd_ordDet
        '
        Me.grd_ordDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_ordDet.Location = New System.Drawing.Point(12, 125)
        Me.grd_ordDet.Name = "grd_ordDet"
        Me.grd_ordDet.Size = New System.Drawing.Size(546, 157)
        Me.grd_ordDet.TabIndex = 69
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prj_EverythingTerry_a202479.My.Resources.Resources.wallpaperflare_com_wallpaper__2_
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(915, 121)
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'btn_back
        '
        Me.btn_back.ForeColor = System.Drawing.Color.Crimson
        Me.btn_back.Location = New System.Drawing.Point(483, 304)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 70
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_ordDet_a202479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(572, 339)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_ordDet)
        Me.Controls.Add(Me.lbl_header1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_ordDet_a202479"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Details"
        CType(Me.grd_ordDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_header1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grd_ordDet As DataGridView
    Friend WithEvents btn_back As Button
End Class

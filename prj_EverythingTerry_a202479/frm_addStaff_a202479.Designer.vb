<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addStaff_a202479
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_addStaff_a202479))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_product_id = New System.Windows.Forms.Label()
        Me.txt_position = New System.Windows.Forms.TextBox()
        Me.txt_staff_name = New System.Windows.Forms.TextBox()
        Me.txt_staff_id = New System.Windows.Forms.TextBox()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.lbl_header1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.ForeColor = System.Drawing.Color.Crimson
        Me.btn_back.Location = New System.Drawing.Point(377, 455)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 90
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Green
        Me.btn_insert.ForeColor = System.Drawing.Color.White
        Me.btn_insert.Location = New System.Drawing.Point(32, 397)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(387, 37)
        Me.btn_insert.TabIndex = 89
        Me.btn_insert.Text = "INSERT NEW STAFF"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(225, 354)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(44, 13)
        Me.lbl_price.TabIndex = 86
        Me.lbl_price.Text = "Position"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Staff Name"
        '
        'lbl_product_id
        '
        Me.lbl_product_id.AutoSize = True
        Me.lbl_product_id.Location = New System.Drawing.Point(29, 354)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(43, 13)
        Me.lbl_product_id.TabIndex = 84
        Me.lbl_product_id.Text = "Staff ID"
        '
        'txt_position
        '
        Me.txt_position.Location = New System.Drawing.Point(228, 371)
        Me.txt_position.Name = "txt_position"
        Me.txt_position.Size = New System.Drawing.Size(191, 20)
        Me.txt_position.TabIndex = 83
        '
        'txt_staff_name
        '
        Me.txt_staff_name.Location = New System.Drawing.Point(32, 330)
        Me.txt_staff_name.Name = "txt_staff_name"
        Me.txt_staff_name.Size = New System.Drawing.Size(387, 20)
        Me.txt_staff_name.TabIndex = 82
        '
        'txt_staff_id
        '
        Me.txt_staff_id.Location = New System.Drawing.Point(32, 371)
        Me.txt_staff_id.Name = "txt_staff_id"
        Me.txt_staff_id.Size = New System.Drawing.Size(191, 20)
        Me.txt_staff_id.TabIndex = 81
        '
        'grd_staff
        '
        Me.grd_staff.AllowUserToAddRows = False
        Me.grd_staff.AllowUserToDeleteRows = False
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(12, 124)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.ReadOnly = True
        Me.grd_staff.Size = New System.Drawing.Size(450, 175)
        Me.grd_staff.TabIndex = 80
        '
        'lbl_header1
        '
        Me.lbl_header1.AutoSize = True
        Me.lbl_header1.BackColor = System.Drawing.Color.Khaki
        Me.lbl_header1.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header1.ForeColor = System.Drawing.Color.White
        Me.lbl_header1.Location = New System.Drawing.Point(11, 30)
        Me.lbl_header1.Name = "lbl_header1"
        Me.lbl_header1.Size = New System.Drawing.Size(283, 50)
        Me.lbl_header1.TabIndex = 79
        Me.lbl_header1.Text = "Add Staff"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prj_EverythingTerry_a202479.My.Resources.Resources.wallpaperflare_com_wallpaper__2_
        Me.PictureBox1.Location = New System.Drawing.Point(-22, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(858, 121)
        Me.PictureBox1.TabIndex = 78
        Me.PictureBox1.TabStop = False
        '
        'frm_addStaff_a202479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(474, 490)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_product_id)
        Me.Controls.Add(Me.txt_position)
        Me.Controls.Add(Me.txt_staff_name)
        Me.Controls.Add(Me.txt_staff_id)
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.lbl_header1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_addStaff_a202479"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD STAFF"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents lbl_price As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_product_id As Label
    Friend WithEvents txt_position As TextBox
    Friend WithEvents txt_staff_name As TextBox
    Friend WithEvents txt_staff_id As TextBox
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents lbl_header1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

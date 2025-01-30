<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staffManager_a202479
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_staffManager_a202479))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
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
        Me.btn_back.Location = New System.Drawing.Point(338, 509)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 64
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Green
        Me.btn_insert.ForeColor = System.Drawing.Color.White
        Me.btn_insert.Location = New System.Drawing.Point(39, 457)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(374, 37)
        Me.btn_insert.TabIndex = 63
        Me.btn_insert.Text = "INSERT NEW STAFF"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(235, 414)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(178, 37)
        Me.btn_delete.TabIndex = 62
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.ForeColor = System.Drawing.Color.Green
        Me.btn_update.Location = New System.Drawing.Point(39, 414)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(178, 37)
        Me.btn_update.TabIndex = 61
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(232, 355)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(44, 13)
        Me.lbl_price.TabIndex = 54
        Me.lbl_price.Text = "Position"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Staff Name"
        '
        'lbl_product_id
        '
        Me.lbl_product_id.AutoSize = True
        Me.lbl_product_id.Location = New System.Drawing.Point(36, 355)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(43, 13)
        Me.lbl_product_id.TabIndex = 52
        Me.lbl_product_id.Text = "Staff ID"
        '
        'txt_position
        '
        Me.txt_position.Location = New System.Drawing.Point(235, 372)
        Me.txt_position.Name = "txt_position"
        Me.txt_position.Size = New System.Drawing.Size(178, 20)
        Me.txt_position.TabIndex = 51
        '
        'txt_staff_name
        '
        Me.txt_staff_name.Location = New System.Drawing.Point(39, 331)
        Me.txt_staff_name.Name = "txt_staff_name"
        Me.txt_staff_name.Size = New System.Drawing.Size(374, 20)
        Me.txt_staff_name.TabIndex = 49
        '
        'txt_staff_id
        '
        Me.txt_staff_id.Location = New System.Drawing.Point(39, 372)
        Me.txt_staff_id.Name = "txt_staff_id"
        Me.txt_staff_id.Size = New System.Drawing.Size(178, 20)
        Me.txt_staff_id.TabIndex = 48
        '
        'grd_staff
        '
        Me.grd_staff.AllowUserToAddRows = False
        Me.grd_staff.AllowUserToDeleteRows = False
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(12, 124)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.ReadOnly = True
        Me.grd_staff.Size = New System.Drawing.Size(441, 175)
        Me.grd_staff.TabIndex = 47
        '
        'lbl_header1
        '
        Me.lbl_header1.AutoSize = True
        Me.lbl_header1.BackColor = System.Drawing.Color.Khaki
        Me.lbl_header1.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header1.ForeColor = System.Drawing.Color.White
        Me.lbl_header1.Location = New System.Drawing.Point(12, 30)
        Me.lbl_header1.Name = "lbl_header1"
        Me.lbl_header1.Size = New System.Drawing.Size(399, 50)
        Me.lbl_header1.TabIndex = 46
        Me.lbl_header1.Text = "Staff Manager"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prj_EverythingTerry_a202479.My.Resources.Resources.wallpaperflare_com_wallpaper__2_
        Me.PictureBox1.Location = New System.Drawing.Point(-21, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(858, 121)
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'frm_staffManager_a202479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(466, 541)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
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
        Me.Name = "frm_staffManager_a202479"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STAFF MANAGER"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
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

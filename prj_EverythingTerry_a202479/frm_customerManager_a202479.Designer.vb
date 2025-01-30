<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customerManager_a202479
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_customerManager_a202479))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_product_id = New System.Windows.Forms.Label()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.txt_customer_name = New System.Windows.Forms.TextBox()
        Me.txt_customer_id = New System.Windows.Forms.TextBox()
        Me.grd_cust = New System.Windows.Forms.DataGridView()
        Me.lbl_header1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grd_cust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.ForeColor = System.Drawing.Color.Crimson
        Me.btn_back.Location = New System.Drawing.Point(351, 499)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 77
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Green
        Me.btn_insert.ForeColor = System.Drawing.Color.White
        Me.btn_insert.Location = New System.Drawing.Point(76, 456)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(350, 37)
        Me.btn_insert.TabIndex = 76
        Me.btn_insert.Text = "INSERT NEW STAFF"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(260, 413)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(166, 37)
        Me.btn_delete.TabIndex = 75
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.ForeColor = System.Drawing.Color.Green
        Me.btn_update.Location = New System.Drawing.Point(76, 413)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(166, 37)
        Me.btn_update.TabIndex = 74
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.ForeColor = System.Drawing.Color.White
        Me.lbl_price.Location = New System.Drawing.Point(257, 357)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(78, 13)
        Me.lbl_price.TabIndex = 73
        Me.lbl_price.Text = "Phone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(73, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Customer Name"
        '
        'lbl_product_id
        '
        Me.lbl_product_id.AutoSize = True
        Me.lbl_product_id.ForeColor = System.Drawing.Color.White
        Me.lbl_product_id.Location = New System.Drawing.Point(73, 356)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(65, 13)
        Me.lbl_product_id.TabIndex = 71
        Me.lbl_product_id.Text = "Customer ID"
        '
        'txt_phone
        '
        Me.txt_phone.Location = New System.Drawing.Point(260, 373)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(166, 20)
        Me.txt_phone.TabIndex = 70
        '
        'txt_customer_name
        '
        Me.txt_customer_name.Location = New System.Drawing.Point(76, 332)
        Me.txt_customer_name.Name = "txt_customer_name"
        Me.txt_customer_name.Size = New System.Drawing.Size(350, 20)
        Me.txt_customer_name.TabIndex = 69
        '
        'txt_customer_id
        '
        Me.txt_customer_id.Location = New System.Drawing.Point(76, 373)
        Me.txt_customer_id.Name = "txt_customer_id"
        Me.txt_customer_id.Size = New System.Drawing.Size(166, 20)
        Me.txt_customer_id.TabIndex = 68
        '
        'grd_cust
        '
        Me.grd_cust.AllowUserToAddRows = False
        Me.grd_cust.AllowUserToDeleteRows = False
        Me.grd_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_cust.Location = New System.Drawing.Point(76, 127)
        Me.grd_cust.Name = "grd_cust"
        Me.grd_cust.ReadOnly = True
        Me.grd_cust.Size = New System.Drawing.Size(350, 175)
        Me.grd_cust.TabIndex = 67
        '
        'lbl_header1
        '
        Me.lbl_header1.AutoSize = True
        Me.lbl_header1.BackColor = System.Drawing.Color.SeaGreen
        Me.lbl_header1.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header1.ForeColor = System.Drawing.Color.White
        Me.lbl_header1.Location = New System.Drawing.Point(12, 33)
        Me.lbl_header1.Name = "lbl_header1"
        Me.lbl_header1.Size = New System.Drawing.Size(486, 50)
        Me.lbl_header1.TabIndex = 66
        Me.lbl_header1.Text = "Customer Manager"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prj_EverythingTerry_a202479.My.Resources.Resources.wallpaperflare_com_wallpaper__2_
        Me.PictureBox1.Location = New System.Drawing.Point(-21, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(858, 121)
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'frm_customerManager_a202479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(510, 541)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_product_id)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.txt_customer_name)
        Me.Controls.Add(Me.txt_customer_id)
        Me.Controls.Add(Me.grd_cust)
        Me.Controls.Add(Me.lbl_header1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_customerManager_a202479"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUSTOMER MANAGER"
        CType(Me.grd_cust, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents txt_customer_name As TextBox
    Friend WithEvents txt_customer_id As TextBox
    Friend WithEvents grd_cust As DataGridView
    Friend WithEvents lbl_header1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

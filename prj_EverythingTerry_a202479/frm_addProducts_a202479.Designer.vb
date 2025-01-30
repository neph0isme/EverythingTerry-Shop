<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addProducts_a202479
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_addProducts_a202479))
        Me.lbl_header1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.lbl_rating = New System.Windows.Forms.Label()
        Me.txt_rating = New System.Windows.Forms.TextBox()
        Me.lbl_qty = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_series = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_product_id = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_series = New System.Windows.Forms.TextBox()
        Me.txt_product_name = New System.Windows.Forms.TextBox()
        Me.txt_product_id = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.pic_prod = New System.Windows.Forms.PictureBox()
        Me.btn_selectPic = New System.Windows.Forms.Button()
        Me.lbl_selectPic = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_imgName = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_header1
        '
        Me.lbl_header1.AutoSize = True
        Me.lbl_header1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lbl_header1.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header1.ForeColor = System.Drawing.Color.White
        Me.lbl_header1.Location = New System.Drawing.Point(19, 23)
        Me.lbl_header1.Name = "lbl_header1"
        Me.lbl_header1.Size = New System.Drawing.Size(428, 50)
        Me.lbl_header1.TabIndex = 14
        Me.lbl_header1.Text = "Insert Product"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prj_EverythingTerry_a202479.My.Resources.Resources.wallpaperflare_com_wallpaper__2_
        Me.PictureBox1.Location = New System.Drawing.Point(-14, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(858, 112)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'grd_products
        '
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(12, 127)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.Size = New System.Drawing.Size(776, 175)
        Me.grd_products.TabIndex = 15
        '
        'cmb_type
        '
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(28, 464)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(178, 21)
        Me.cmb_type.TabIndex = 56
        '
        'lbl_rating
        '
        Me.lbl_rating.AutoSize = True
        Me.lbl_rating.Location = New System.Drawing.Point(26, 489)
        Me.lbl_rating.Name = "lbl_rating"
        Me.lbl_rating.Size = New System.Drawing.Size(117, 13)
        Me.lbl_rating.TabIndex = 55
        Me.lbl_rating.Text = "Ratings( Out of 5 Stars)"
        '
        'txt_rating
        '
        Me.txt_rating.Location = New System.Drawing.Point(28, 505)
        Me.txt_rating.Name = "txt_rating"
        Me.txt_rating.Size = New System.Drawing.Size(178, 20)
        Me.txt_rating.TabIndex = 54
        '
        'lbl_qty
        '
        Me.lbl_qty.AutoSize = True
        Me.lbl_qty.Location = New System.Drawing.Point(210, 405)
        Me.lbl_qty.Name = "lbl_qty"
        Me.lbl_qty.Size = New System.Drawing.Size(46, 13)
        Me.lbl_qty.TabIndex = 53
        Me.lbl_qty.Text = "Quantity"
        '
        'txt_qty
        '
        Me.txt_qty.Location = New System.Drawing.Point(213, 421)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(178, 20)
        Me.txt_qty.TabIndex = 52
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Location = New System.Drawing.Point(25, 449)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(62, 13)
        Me.lbl_type.TabIndex = 51
        Me.lbl_type.Text = "Cover Type"
        '
        'lbl_series
        '
        Me.lbl_series.AutoSize = True
        Me.lbl_series.Location = New System.Drawing.Point(209, 364)
        Me.lbl_series.Name = "lbl_series"
        Me.lbl_series.Size = New System.Drawing.Size(36, 13)
        Me.lbl_series.TabIndex = 50
        Me.lbl_series.Text = "Series"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(24, 407)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(57, 13)
        Me.lbl_price.TabIndex = 49
        Me.lbl_price.Text = "Price (RM)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Product Name"
        '
        'lbl_product_id
        '
        Me.lbl_product_id.AutoSize = True
        Me.lbl_product_id.Location = New System.Drawing.Point(25, 364)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(58, 13)
        Me.lbl_product_id.TabIndex = 47
        Me.lbl_product_id.Text = "Product ID"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(27, 423)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(178, 20)
        Me.txt_price.TabIndex = 46
        '
        'txt_series
        '
        Me.txt_series.Location = New System.Drawing.Point(211, 380)
        Me.txt_series.Name = "txt_series"
        Me.txt_series.Size = New System.Drawing.Size(178, 20)
        Me.txt_series.TabIndex = 45
        '
        'txt_product_name
        '
        Me.txt_product_name.Location = New System.Drawing.Point(27, 341)
        Me.txt_product_name.Name = "txt_product_name"
        Me.txt_product_name.Size = New System.Drawing.Size(362, 20)
        Me.txt_product_name.TabIndex = 44
        '
        'txt_product_id
        '
        Me.txt_product_id.Location = New System.Drawing.Point(27, 380)
        Me.txt_product_id.Name = "txt_product_id"
        Me.txt_product_id.Size = New System.Drawing.Size(178, 20)
        Me.txt_product_id.TabIndex = 43
        '
        'btn_back
        '
        Me.btn_back.ForeColor = System.Drawing.Color.Crimson
        Me.btn_back.Location = New System.Drawing.Point(713, 544)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 57
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'pic_prod
        '
        Me.pic_prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pic_prod.Location = New System.Drawing.Point(425, 311)
        Me.pic_prod.Name = "pic_prod"
        Me.pic_prod.Size = New System.Drawing.Size(271, 214)
        Me.pic_prod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_prod.TabIndex = 58
        Me.pic_prod.TabStop = False
        '
        'btn_selectPic
        '
        Me.btn_selectPic.ForeColor = System.Drawing.Color.Green
        Me.btn_selectPic.Location = New System.Drawing.Point(213, 464)
        Me.btn_selectPic.Name = "btn_selectPic"
        Me.btn_selectPic.Size = New System.Drawing.Size(178, 23)
        Me.btn_selectPic.TabIndex = 59
        Me.btn_selectPic.Text = "UPLOAD"
        Me.btn_selectPic.UseVisualStyleBackColor = True
        '
        'lbl_selectPic
        '
        Me.lbl_selectPic.AutoSize = True
        Me.lbl_selectPic.Location = New System.Drawing.Point(212, 449)
        Me.lbl_selectPic.Name = "lbl_selectPic"
        Me.lbl_selectPic.Size = New System.Drawing.Size(73, 13)
        Me.lbl_selectPic.TabIndex = 60
        Me.lbl_selectPic.Text = "Select Picture"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Green
        Me.btn_insert.ForeColor = System.Drawing.Color.White
        Me.btn_insert.Location = New System.Drawing.Point(215, 502)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(178, 23)
        Me.btn_insert.TabIndex = 61
        Me.btn_insert.Text = "INSERT PRODUCT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_imgName
        '
        Me.txt_imgName.Location = New System.Drawing.Point(425, 531)
        Me.txt_imgName.Name = "txt_imgName"
        Me.txt_imgName.Size = New System.Drawing.Size(271, 20)
        Me.txt_imgName.TabIndex = 62
        '
        'frm_addProducts_a202479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 579)
        Me.Controls.Add(Me.txt_imgName)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.lbl_selectPic)
        Me.Controls.Add(Me.btn_selectPic)
        Me.Controls.Add(Me.pic_prod)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.lbl_rating)
        Me.Controls.Add(Me.txt_rating)
        Me.Controls.Add(Me.lbl_qty)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_series)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_product_id)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_series)
        Me.Controls.Add(Me.txt_product_name)
        Me.Controls.Add(Me.txt_product_id)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.lbl_header1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_addProducts_a202479"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD PRODUCTS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_header1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents lbl_rating As Label
    Friend WithEvents txt_rating As TextBox
    Friend WithEvents lbl_qty As Label
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_series As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_product_id As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_series As TextBox
    Friend WithEvents txt_product_name As TextBox
    Friend WithEvents txt_product_id As TextBox
    Friend WithEvents btn_back As Button
    Friend WithEvents pic_prod As PictureBox
    Friend WithEvents btn_selectPic As Button
    Friend WithEvents lbl_selectPic As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_imgName As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_products_a202479
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_products_a202479))
        Me.lbl_header1 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_product_id = New System.Windows.Forms.TextBox()
        Me.lst_product_id = New System.Windows.Forms.ListBox()
        Me.txt_product_name = New System.Windows.Forms.TextBox()
        Me.txt_series = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.lbl_product_id = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_series = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.lbl_qty = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.lbl_rating = New System.Windows.Forms.Label()
        Me.txt_rating = New System.Windows.Forms.TextBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_header1
        '
        Me.lbl_header1.AutoSize = True
        Me.lbl_header1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lbl_header1.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header1.ForeColor = System.Drawing.Color.White
        Me.lbl_header1.Location = New System.Drawing.Point(21, 33)
        Me.lbl_header1.Name = "lbl_header1"
        Me.lbl_header1.Size = New System.Drawing.Size(254, 50)
        Me.lbl_header1.TabIndex = 0
        Me.lbl_header1.Text = "Products"
        '
        'btn_back
        '
        Me.btn_back.ForeColor = System.Drawing.Color.Crimson
        Me.btn_back.Location = New System.Drawing.Point(663, 438)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 4
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'txt_product_id
        '
        Me.txt_product_id.Location = New System.Drawing.Point(321, 164)
        Me.txt_product_id.Name = "txt_product_id"
        Me.txt_product_id.Size = New System.Drawing.Size(178, 20)
        Me.txt_product_id.TabIndex = 7
        '
        'lst_product_id
        '
        Me.lst_product_id.FormattingEnabled = True
        Me.lst_product_id.Location = New System.Drawing.Point(22, 126)
        Me.lst_product_id.Name = "lst_product_id"
        Me.lst_product_id.Size = New System.Drawing.Size(133, 316)
        Me.lst_product_id.TabIndex = 8
        '
        'txt_product_name
        '
        Me.txt_product_name.Location = New System.Drawing.Point(321, 202)
        Me.txt_product_name.Name = "txt_product_name"
        Me.txt_product_name.Size = New System.Drawing.Size(178, 20)
        Me.txt_product_name.TabIndex = 11
        '
        'txt_series
        '
        Me.txt_series.Location = New System.Drawing.Point(321, 254)
        Me.txt_series.Name = "txt_series"
        Me.txt_series.Size = New System.Drawing.Size(178, 20)
        Me.txt_series.TabIndex = 12
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(321, 228)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(178, 20)
        Me.txt_price.TabIndex = 13
        '
        'lbl_product_id
        '
        Me.lbl_product_id.AutoSize = True
        Me.lbl_product_id.ForeColor = System.Drawing.Color.Black
        Me.lbl_product_id.Location = New System.Drawing.Point(197, 167)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(58, 13)
        Me.lbl_product_id.TabIndex = 14
        Me.lbl_product_id.Text = "Product ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(198, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Product Name"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.ForeColor = System.Drawing.Color.Black
        Me.lbl_price.Location = New System.Drawing.Point(198, 231)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(57, 13)
        Me.lbl_price.TabIndex = 16
        Me.lbl_price.Text = "Price (RM)"
        '
        'lbl_series
        '
        Me.lbl_series.AutoSize = True
        Me.lbl_series.ForeColor = System.Drawing.Color.Black
        Me.lbl_series.Location = New System.Drawing.Point(198, 257)
        Me.lbl_series.Name = "lbl_series"
        Me.lbl_series.Size = New System.Drawing.Size(36, 13)
        Me.lbl_series.TabIndex = 17
        Me.lbl_series.Text = "Series"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.ForeColor = System.Drawing.Color.Black
        Me.lbl_type.Location = New System.Drawing.Point(198, 292)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(62, 13)
        Me.lbl_type.TabIndex = 19
        Me.lbl_type.Text = "Cover Type"
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(321, 289)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(178, 20)
        Me.txt_type.TabIndex = 18
        '
        'lbl_qty
        '
        Me.lbl_qty.AutoSize = True
        Me.lbl_qty.ForeColor = System.Drawing.Color.Black
        Me.lbl_qty.Location = New System.Drawing.Point(198, 331)
        Me.lbl_qty.Name = "lbl_qty"
        Me.lbl_qty.Size = New System.Drawing.Size(46, 13)
        Me.lbl_qty.TabIndex = 21
        Me.lbl_qty.Text = "Quantity"
        '
        'txt_qty
        '
        Me.txt_qty.Location = New System.Drawing.Point(321, 328)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(178, 20)
        Me.txt_qty.TabIndex = 20
        '
        'lbl_rating
        '
        Me.lbl_rating.AutoSize = True
        Me.lbl_rating.ForeColor = System.Drawing.Color.Black
        Me.lbl_rating.Location = New System.Drawing.Point(198, 371)
        Me.lbl_rating.Name = "lbl_rating"
        Me.lbl_rating.Size = New System.Drawing.Size(117, 13)
        Me.lbl_rating.TabIndex = 23
        Me.lbl_rating.Text = "Ratings( Out of 5 Stars)"
        '
        'txt_rating
        '
        Me.txt_rating.Location = New System.Drawing.Point(321, 368)
        Me.txt_rating.Name = "txt_rating"
        Me.txt_rating.Size = New System.Drawing.Size(178, 20)
        Me.txt_rating.TabIndex = 22
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(546, 132)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(192, 300)
        Me.pic_product.TabIndex = 5
        Me.pic_product.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prj_EverythingTerry_a202479.My.Resources.Resources.wallpaperflare_com_wallpaper__2_
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(858, 116)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frm_products_a202479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(762, 473)
        Me.Controls.Add(Me.lbl_rating)
        Me.Controls.Add(Me.txt_rating)
        Me.Controls.Add(Me.lbl_qty)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.lbl_series)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_product_id)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_series)
        Me.Controls.Add(Me.txt_product_name)
        Me.Controls.Add(Me.lst_product_id)
        Me.Controls.Add(Me.txt_product_id)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_header1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_products_a202479"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTS"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_header1 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_product_id As TextBox
    Friend WithEvents lst_product_id As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_product_name As TextBox
    Friend WithEvents txt_series As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents lbl_product_id As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_series As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents txt_type As TextBox
    Friend WithEvents lbl_qty As Label
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents lbl_rating As Label
    Friend WithEvents txt_rating As TextBox
End Class

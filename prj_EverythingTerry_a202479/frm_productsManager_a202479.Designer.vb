<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productsManager_a202479
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productsManager_a202479))
        Me.grd_products = New System.Windows.Forms.DataGridView()
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
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.lbl_header1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pic_prod = New System.Windows.Forms.PictureBox()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_products
        '
        Me.grd_products.AllowUserToAddRows = False
        Me.grd_products.AllowUserToDeleteRows = False
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(12, 118)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.Size = New System.Drawing.Size(776, 175)
        Me.grd_products.TabIndex = 13
        '
        'lbl_rating
        '
        Me.lbl_rating.AutoSize = True
        Me.lbl_rating.Location = New System.Drawing.Point(232, 484)
        Me.lbl_rating.Name = "lbl_rating"
        Me.lbl_rating.Size = New System.Drawing.Size(117, 13)
        Me.lbl_rating.TabIndex = 37
        Me.lbl_rating.Text = "Ratings( Out of 5 Stars)"
        '
        'txt_rating
        '
        Me.txt_rating.Location = New System.Drawing.Point(235, 500)
        Me.txt_rating.Name = "txt_rating"
        Me.txt_rating.Size = New System.Drawing.Size(178, 20)
        Me.txt_rating.TabIndex = 36
        '
        'lbl_qty
        '
        Me.lbl_qty.AutoSize = True
        Me.lbl_qty.Location = New System.Drawing.Point(36, 484)
        Me.lbl_qty.Name = "lbl_qty"
        Me.lbl_qty.Size = New System.Drawing.Size(46, 13)
        Me.lbl_qty.TabIndex = 35
        Me.lbl_qty.Text = "Quantity"
        '
        'txt_qty
        '
        Me.txt_qty.Location = New System.Drawing.Point(39, 500)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(178, 20)
        Me.txt_qty.TabIndex = 34
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Location = New System.Drawing.Point(232, 429)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(62, 13)
        Me.lbl_type.TabIndex = 33
        Me.lbl_type.Text = "Cover Type"
        '
        'lbl_series
        '
        Me.lbl_series.AutoSize = True
        Me.lbl_series.Location = New System.Drawing.Point(36, 429)
        Me.lbl_series.Name = "lbl_series"
        Me.lbl_series.Size = New System.Drawing.Size(36, 13)
        Me.lbl_series.TabIndex = 31
        Me.lbl_series.Text = "Series"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(232, 374)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(57, 13)
        Me.lbl_price.TabIndex = 30
        Me.lbl_price.Text = "Price (RM)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Product Name"
        '
        'lbl_product_id
        '
        Me.lbl_product_id.AutoSize = True
        Me.lbl_product_id.Location = New System.Drawing.Point(36, 374)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(58, 13)
        Me.lbl_product_id.TabIndex = 28
        Me.lbl_product_id.Text = "Product ID"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(235, 391)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(178, 20)
        Me.txt_price.TabIndex = 27
        '
        'txt_series
        '
        Me.txt_series.Location = New System.Drawing.Point(39, 445)
        Me.txt_series.Name = "txt_series"
        Me.txt_series.Size = New System.Drawing.Size(178, 20)
        Me.txt_series.TabIndex = 26
        '
        'txt_product_name
        '
        Me.txt_product_name.Location = New System.Drawing.Point(39, 340)
        Me.txt_product_name.Name = "txt_product_name"
        Me.txt_product_name.Size = New System.Drawing.Size(374, 20)
        Me.txt_product_name.TabIndex = 25
        '
        'txt_product_id
        '
        Me.txt_product_id.Location = New System.Drawing.Point(39, 391)
        Me.txt_product_id.Name = "txt_product_id"
        Me.txt_product_id.Size = New System.Drawing.Size(178, 20)
        Me.txt_product_id.TabIndex = 24
        '
        'btn_update
        '
        Me.btn_update.ForeColor = System.Drawing.Color.Green
        Me.btn_update.Location = New System.Drawing.Point(650, 358)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(138, 37)
        Me.btn_update.TabIndex = 38
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(650, 401)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(138, 37)
        Me.btn_delete.TabIndex = 39
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(650, 444)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 37)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "INSERT NEW PRODUCT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.ForeColor = System.Drawing.Color.Crimson
        Me.btn_back.Location = New System.Drawing.Point(713, 585)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 41
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'cmb_type
        '
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(235, 445)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(178, 21)
        Me.cmb_type.TabIndex = 42
        '
        'lbl_header1
        '
        Me.lbl_header1.AutoSize = True
        Me.lbl_header1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lbl_header1.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header1.ForeColor = System.Drawing.Color.White
        Me.lbl_header1.Location = New System.Drawing.Point(12, 24)
        Me.lbl_header1.Name = "lbl_header1"
        Me.lbl_header1.Size = New System.Drawing.Size(486, 50)
        Me.lbl_header1.TabIndex = 12
        Me.lbl_header1.Text = "Products Manager"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prj_EverythingTerry_a202479.My.Resources.Resources.wallpaperflare_com_wallpaper__2_
        Me.PictureBox1.Location = New System.Drawing.Point(-21, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(858, 112)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'pic_prod
        '
        Me.pic_prod.Location = New System.Drawing.Point(451, 308)
        Me.pic_prod.Name = "pic_prod"
        Me.pic_prod.Size = New System.Drawing.Size(193, 300)
        Me.pic_prod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_prod.TabIndex = 44
        Me.pic_prod.TabStop = False
        '
        'frm_productsManager_a202479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 630)
        Me.Controls.Add(Me.pic_prod)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
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
        Me.Name = "frm_productsManager_a202479"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTS MANAGER"
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_products As DataGridView
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
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_header1 As Label
    Friend WithEvents pic_prod As PictureBox
End Class

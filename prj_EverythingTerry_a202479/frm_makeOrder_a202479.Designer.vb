<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeOrder_a202479
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeOrder_a202479))
        Me.lbl_header1 = New System.Windows.Forms.Label()
        Me.lst_productID = New System.Windows.Forms.ListBox()
        Me.lbl_staffID = New System.Windows.Forms.Label()
        Me.lbl_qty = New System.Windows.Forms.Label()
        Me.lbl_custID = New System.Windows.Forms.Label()
        Me.lbl_series = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_series = New System.Windows.Forms.TextBox()
        Me.txt_product_name = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.btn_atc = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.lbl_totalText = New System.Windows.Forms.Label()
        Me.lbl_totalNum = New System.Windows.Forms.Label()
        Me.cmb_staffID = New System.Windows.Forms.ComboBox()
        Me.cmb_custID = New System.Windows.Forms.ComboBox()
        Me.nud_qty = New System.Windows.Forms.NumericUpDown()
        Me.pic_prod = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_prod, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_header1.Size = New System.Drawing.Size(167, 50)
        Me.lbl_header1.TabIndex = 67
        Me.lbl_header1.Text = "Order"
        '
        'lst_productID
        '
        Me.lst_productID.FormattingEnabled = True
        Me.lst_productID.Location = New System.Drawing.Point(12, 118)
        Me.lst_productID.Name = "lst_productID"
        Me.lst_productID.Size = New System.Drawing.Size(154, 407)
        Me.lst_productID.TabIndex = 69
        '
        'lbl_staffID
        '
        Me.lbl_staffID.AutoSize = True
        Me.lbl_staffID.ForeColor = System.Drawing.Color.White
        Me.lbl_staffID.Location = New System.Drawing.Point(295, 229)
        Me.lbl_staffID.Name = "lbl_staffID"
        Me.lbl_staffID.Size = New System.Drawing.Size(43, 13)
        Me.lbl_staffID.TabIndex = 83
        Me.lbl_staffID.Text = "Staff ID"
        '
        'lbl_qty
        '
        Me.lbl_qty.AutoSize = True
        Me.lbl_qty.ForeColor = System.Drawing.Color.White
        Me.lbl_qty.Location = New System.Drawing.Point(295, 203)
        Me.lbl_qty.Name = "lbl_qty"
        Me.lbl_qty.Size = New System.Drawing.Size(46, 13)
        Me.lbl_qty.TabIndex = 81
        Me.lbl_qty.Text = "Quantity"
        '
        'lbl_custID
        '
        Me.lbl_custID.AutoSize = True
        Me.lbl_custID.ForeColor = System.Drawing.Color.White
        Me.lbl_custID.Location = New System.Drawing.Point(295, 255)
        Me.lbl_custID.Name = "lbl_custID"
        Me.lbl_custID.Size = New System.Drawing.Size(65, 13)
        Me.lbl_custID.TabIndex = 79
        Me.lbl_custID.Text = "Customer ID"
        '
        'lbl_series
        '
        Me.lbl_series.AutoSize = True
        Me.lbl_series.ForeColor = System.Drawing.Color.White
        Me.lbl_series.Location = New System.Drawing.Point(295, 177)
        Me.lbl_series.Name = "lbl_series"
        Me.lbl_series.Size = New System.Drawing.Size(36, 13)
        Me.lbl_series.TabIndex = 77
        Me.lbl_series.Text = "Series"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.ForeColor = System.Drawing.Color.White
        Me.lbl_price.Location = New System.Drawing.Point(295, 151)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(57, 13)
        Me.lbl_price.TabIndex = 76
        Me.lbl_price.Text = "Price (RM)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(295, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Product Name"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(418, 148)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(178, 20)
        Me.txt_price.TabIndex = 73
        '
        'txt_series
        '
        Me.txt_series.Location = New System.Drawing.Point(418, 174)
        Me.txt_series.Name = "txt_series"
        Me.txt_series.Size = New System.Drawing.Size(178, 20)
        Me.txt_series.TabIndex = 72
        '
        'txt_product_name
        '
        Me.txt_product_name.Location = New System.Drawing.Point(418, 122)
        Me.txt_product_name.Name = "txt_product_name"
        Me.txt_product_name.Size = New System.Drawing.Size(178, 20)
        Me.txt_product_name.TabIndex = 71
        '
        'btn_back
        '
        Me.btn_back.ForeColor = System.Drawing.Color.Crimson
        Me.btn_back.Location = New System.Drawing.Point(839, 535)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 84
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AllowUserToDeleteRows = False
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(172, 278)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.ReadOnly = True
        Me.grd_order.Size = New System.Drawing.Size(544, 150)
        Me.grd_order.TabIndex = 85
        '
        'btn_atc
        '
        Me.btn_atc.BackColor = System.Drawing.Color.Lime
        Me.btn_atc.ForeColor = System.Drawing.Color.White
        Me.btn_atc.Location = New System.Drawing.Point(298, 434)
        Me.btn_atc.Name = "btn_atc"
        Me.btn_atc.Size = New System.Drawing.Size(139, 23)
        Me.btn_atc.TabIndex = 86
        Me.btn_atc.Text = "Add To Cart"
        Me.btn_atc.UseVisualStyleBackColor = False
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.Red
        Me.btn_reset.ForeColor = System.Drawing.Color.White
        Me.btn_reset.Location = New System.Drawing.Point(457, 434)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(139, 23)
        Me.btn_reset.TabIndex = 87
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_confirm
        '
        Me.btn_confirm.Location = New System.Drawing.Point(295, 502)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(301, 23)
        Me.btn_confirm.TabIndex = 88
        Me.btn_confirm.Text = "Confirm Order"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'lbl_totalText
        '
        Me.lbl_totalText.AutoSize = True
        Me.lbl_totalText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalText.ForeColor = System.Drawing.Color.White
        Me.lbl_totalText.Location = New System.Drawing.Point(356, 473)
        Me.lbl_totalText.Name = "lbl_totalText"
        Me.lbl_totalText.Size = New System.Drawing.Size(91, 20)
        Me.lbl_totalText.TabIndex = 89
        Me.lbl_totalText.Text = "Total : RM"
        '
        'lbl_totalNum
        '
        Me.lbl_totalNum.AutoSize = True
        Me.lbl_totalNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalNum.ForeColor = System.Drawing.Color.White
        Me.lbl_totalNum.Location = New System.Drawing.Point(453, 473)
        Me.lbl_totalNum.Name = "lbl_totalNum"
        Me.lbl_totalNum.Size = New System.Drawing.Size(81, 20)
        Me.lbl_totalNum.TabIndex = 90
        Me.lbl_totalNum.Text = "totalNum"
        '
        'cmb_staffID
        '
        Me.cmb_staffID.FormattingEnabled = True
        Me.cmb_staffID.Location = New System.Drawing.Point(418, 226)
        Me.cmb_staffID.Name = "cmb_staffID"
        Me.cmb_staffID.Size = New System.Drawing.Size(178, 21)
        Me.cmb_staffID.TabIndex = 91
        '
        'cmb_custID
        '
        Me.cmb_custID.FormattingEnabled = True
        Me.cmb_custID.Location = New System.Drawing.Point(418, 251)
        Me.cmb_custID.Name = "cmb_custID"
        Me.cmb_custID.Size = New System.Drawing.Size(178, 21)
        Me.cmb_custID.TabIndex = 92
        '
        'nud_qty
        '
        Me.nud_qty.Location = New System.Drawing.Point(418, 200)
        Me.nud_qty.Name = "nud_qty"
        Me.nud_qty.Size = New System.Drawing.Size(178, 20)
        Me.nud_qty.TabIndex = 93
        '
        'pic_prod
        '
        Me.pic_prod.Location = New System.Drawing.Point(722, 174)
        Me.pic_prod.Name = "pic_prod"
        Me.pic_prod.Size = New System.Drawing.Size(192, 300)
        Me.pic_prod.TabIndex = 94
        Me.pic_prod.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(938, 113)
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'frm_makeOrder_a202479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(929, 570)
        Me.Controls.Add(Me.pic_prod)
        Me.Controls.Add(Me.nud_qty)
        Me.Controls.Add(Me.cmb_custID)
        Me.Controls.Add(Me.cmb_staffID)
        Me.Controls.Add(Me.lbl_totalNum)
        Me.Controls.Add(Me.lbl_totalText)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_atc)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_staffID)
        Me.Controls.Add(Me.lbl_qty)
        Me.Controls.Add(Me.lbl_custID)
        Me.Controls.Add(Me.lbl_series)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_series)
        Me.Controls.Add(Me.txt_product_name)
        Me.Controls.Add(Me.lst_productID)
        Me.Controls.Add(Me.lbl_header1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_makeOrder_a202479"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ORDER"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_prod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_header1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lst_productID As ListBox
    Friend WithEvents lbl_staffID As Label
    Friend WithEvents lbl_qty As Label
    Friend WithEvents lbl_custID As Label
    Friend WithEvents lbl_series As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_series As TextBox
    Friend WithEvents txt_product_name As TextBox
    Friend WithEvents btn_back As Button
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents btn_atc As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_confirm As Button
    Friend WithEvents lbl_totalText As Label
    Friend WithEvents lbl_totalNum As Label
    Friend WithEvents cmb_staffID As ComboBox
    Friend WithEvents cmb_custID As ComboBox
    Friend WithEvents nud_qty As NumericUpDown
    Friend WithEvents pic_prod As PictureBox
End Class

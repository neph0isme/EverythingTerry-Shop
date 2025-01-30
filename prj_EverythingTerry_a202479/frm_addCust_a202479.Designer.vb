<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addCust_a202479
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_addCust_a202479))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_custName = New System.Windows.Forms.Label()
        Me.lbl_customer_id = New System.Windows.Forms.Label()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.txt_cust_name = New System.Windows.Forms.TextBox()
        Me.txt_cust_id = New System.Windows.Forms.TextBox()
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
        Me.btn_back.Location = New System.Drawing.Point(382, 456)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 101
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Green
        Me.btn_insert.ForeColor = System.Drawing.Color.White
        Me.btn_insert.Location = New System.Drawing.Point(37, 398)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(387, 37)
        Me.btn_insert.TabIndex = 100
        Me.btn_insert.Text = "INSERT NEW CUSTOMER"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(230, 355)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(78, 13)
        Me.lbl_price.TabIndex = 99
        Me.lbl_price.Text = "Phone Number"
        '
        'lbl_custName
        '
        Me.lbl_custName.AutoSize = True
        Me.lbl_custName.Location = New System.Drawing.Point(34, 315)
        Me.lbl_custName.Name = "lbl_custName"
        Me.lbl_custName.Size = New System.Drawing.Size(82, 13)
        Me.lbl_custName.TabIndex = 98
        Me.lbl_custName.Text = "Customer Name"
        '
        'lbl_customer_id
        '
        Me.lbl_customer_id.AutoSize = True
        Me.lbl_customer_id.Location = New System.Drawing.Point(34, 355)
        Me.lbl_customer_id.Name = "lbl_customer_id"
        Me.lbl_customer_id.Size = New System.Drawing.Size(65, 13)
        Me.lbl_customer_id.TabIndex = 97
        Me.lbl_customer_id.Text = "Customer ID"
        '
        'txt_number
        '
        Me.txt_number.Location = New System.Drawing.Point(233, 372)
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(191, 20)
        Me.txt_number.TabIndex = 96
        '
        'txt_cust_name
        '
        Me.txt_cust_name.Location = New System.Drawing.Point(37, 331)
        Me.txt_cust_name.Name = "txt_cust_name"
        Me.txt_cust_name.Size = New System.Drawing.Size(387, 20)
        Me.txt_cust_name.TabIndex = 95
        '
        'txt_cust_id
        '
        Me.txt_cust_id.Location = New System.Drawing.Point(37, 372)
        Me.txt_cust_id.Name = "txt_cust_id"
        Me.txt_cust_id.Size = New System.Drawing.Size(191, 20)
        Me.txt_cust_id.TabIndex = 94
        '
        'grd_cust
        '
        Me.grd_cust.AllowUserToAddRows = False
        Me.grd_cust.AllowUserToDeleteRows = False
        Me.grd_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_cust.Location = New System.Drawing.Point(17, 125)
        Me.grd_cust.Name = "grd_cust"
        Me.grd_cust.ReadOnly = True
        Me.grd_cust.Size = New System.Drawing.Size(450, 175)
        Me.grd_cust.TabIndex = 93
        '
        'lbl_header1
        '
        Me.lbl_header1.AutoSize = True
        Me.lbl_header1.BackColor = System.Drawing.Color.SeaGreen
        Me.lbl_header1.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header1.ForeColor = System.Drawing.Color.White
        Me.lbl_header1.Location = New System.Drawing.Point(16, 31)
        Me.lbl_header1.Name = "lbl_header1"
        Me.lbl_header1.Size = New System.Drawing.Size(370, 50)
        Me.lbl_header1.TabIndex = 92
        Me.lbl_header1.Text = "Add Customer"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prj_EverythingTerry_a202479.My.Resources.Resources.wallpaperflare_com_wallpaper__2_
        Me.PictureBox1.Location = New System.Drawing.Point(-17, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(858, 121)
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'frm_addCust_a202479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(485, 489)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_custName)
        Me.Controls.Add(Me.lbl_customer_id)
        Me.Controls.Add(Me.txt_number)
        Me.Controls.Add(Me.txt_cust_name)
        Me.Controls.Add(Me.txt_cust_id)
        Me.Controls.Add(Me.grd_cust)
        Me.Controls.Add(Me.lbl_header1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_addCust_a202479"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD CUSTOMER"
        CType(Me.grd_cust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_custName As Label
    Friend WithEvents lbl_customer_id As Label
    Friend WithEvents txt_number As TextBox
    Friend WithEvents txt_cust_name As TextBox
    Friend WithEvents txt_cust_id As TextBox
    Friend WithEvents grd_cust As DataGridView
    Friend WithEvents lbl_header1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

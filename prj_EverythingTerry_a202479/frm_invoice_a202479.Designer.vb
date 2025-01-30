<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_invoice_a202479
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_invoice_a202479))
        Me.lbl_header1 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lst_orderID = New System.Windows.Forms.ListBox()
        Me.lbl_headerOrder = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_shopName = New System.Windows.Forms.Label()
        Me.lbl_order_id = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.lbl_staff_id = New System.Windows.Forms.Label()
        Me.lbl_cust_id = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.lbl_staffName = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_header1
        '
        Me.lbl_header1.AutoSize = True
        Me.lbl_header1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbl_header1.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header1.ForeColor = System.Drawing.Color.White
        Me.lbl_header1.Location = New System.Drawing.Point(27, 33)
        Me.lbl_header1.Name = "lbl_header1"
        Me.lbl_header1.Size = New System.Drawing.Size(225, 50)
        Me.lbl_header1.TabIndex = 69
        Me.lbl_header1.Text = "Invoice"
        '
        'btn_back
        '
        Me.btn_back.ForeColor = System.Drawing.Color.Crimson
        Me.btn_back.Location = New System.Drawing.Point(638, 685)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 85
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'lst_orderID
        '
        Me.lst_orderID.FormattingEnabled = True
        Me.lst_orderID.Location = New System.Drawing.Point(12, 276)
        Me.lst_orderID.Name = "lst_orderID"
        Me.lst_orderID.Size = New System.Drawing.Size(154, 251)
        Me.lst_orderID.TabIndex = 86
        '
        'lbl_headerOrder
        '
        Me.lbl_headerOrder.AutoSize = True
        Me.lbl_headerOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_headerOrder.ForeColor = System.Drawing.Color.White
        Me.lbl_headerOrder.Location = New System.Drawing.Point(12, 248)
        Me.lbl_headerOrder.Name = "lbl_headerOrder"
        Me.lbl_headerOrder.Size = New System.Drawing.Size(107, 25)
        Me.lbl_headerOrder.TabIndex = 87
        Me.lbl_headerOrder.Text = "Order ID:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.lbl_total)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_shopName)
        Me.Panel1.Controls.Add(Me.lbl_order_id)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.grd_order)
        Me.Panel1.Controls.Add(Me.lbl_staff_id)
        Me.Panel1.Controls.Add(Me.lbl_cust_id)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.lbl_phone)
        Me.Panel1.Controls.Add(Me.lbl_staffName)
        Me.Panel1.Controls.Add(Me.lbl_name)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(186, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 557)
        Me.Panel1.TabIndex = 101
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.White
        Me.lbl_total.Location = New System.Drawing.Point(442, 521)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(51, 13)
        Me.lbl_total.TabIndex = 23
        Me.lbl_total.Text = "<<total>>"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(371, 521)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "TOTAL: RM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(220, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "INVOICE"
        '
        'lbl_shopName
        '
        Me.lbl_shopName.AutoSize = True
        Me.lbl_shopName.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_shopName.ForeColor = System.Drawing.Color.White
        Me.lbl_shopName.Location = New System.Drawing.Point(127, 33)
        Me.lbl_shopName.Name = "lbl_shopName"
        Me.lbl_shopName.Size = New System.Drawing.Size(268, 29)
        Me.lbl_shopName.TabIndex = 20
        Me.lbl_shopName.Text = "EverythingTerry"
        '
        'lbl_order_id
        '
        Me.lbl_order_id.AutoSize = True
        Me.lbl_order_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_id.ForeColor = System.Drawing.Color.White
        Me.lbl_order_id.Location = New System.Drawing.Point(435, 271)
        Me.lbl_order_id.Name = "lbl_order_id"
        Me.lbl_order_id.Size = New System.Drawing.Size(69, 13)
        Me.lbl_order_id.TabIndex = 19
        Me.lbl_order_id.Text = "<<order_id>>"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(366, 271)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "ORDER ID:"
        '
        'grd_order
        '
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(40, 296)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.RowHeadersWidth = 51
        Me.grd_order.Size = New System.Drawing.Size(453, 212)
        Me.grd_order.TabIndex = 17
        '
        'lbl_staff_id
        '
        Me.lbl_staff_id.AutoSize = True
        Me.lbl_staff_id.ForeColor = System.Drawing.Color.White
        Me.lbl_staff_id.Location = New System.Drawing.Point(158, 271)
        Me.lbl_staff_id.Name = "lbl_staff_id"
        Me.lbl_staff_id.Size = New System.Drawing.Size(65, 13)
        Me.lbl_staff_id.TabIndex = 15
        Me.lbl_staff_id.Text = "<<staff_id>>"
        '
        'lbl_cust_id
        '
        Me.lbl_cust_id.AutoSize = True
        Me.lbl_cust_id.ForeColor = System.Drawing.Color.White
        Me.lbl_cust_id.Location = New System.Drawing.Point(158, 219)
        Me.lbl_cust_id.Name = "lbl_cust_id"
        Me.lbl_cust_id.Size = New System.Drawing.Size(65, 13)
        Me.lbl_cust_id.TabIndex = 14
        Me.lbl_cust_id.Text = "<<cust_id>>"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(37, 271)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 13)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "STAFF ID:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(37, 219)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 13)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "CUSTOMER  ID:"
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.ForeColor = System.Drawing.Color.White
        Me.lbl_phone.Location = New System.Drawing.Point(158, 206)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(61, 13)
        Me.lbl_phone.TabIndex = 10
        Me.lbl_phone.Text = "<<phone>>"
        '
        'lbl_staffName
        '
        Me.lbl_staffName.AutoSize = True
        Me.lbl_staffName.ForeColor = System.Drawing.Color.White
        Me.lbl_staffName.Location = New System.Drawing.Point(158, 258)
        Me.lbl_staffName.Name = "lbl_staffName"
        Me.lbl_staffName.Size = New System.Drawing.Size(83, 13)
        Me.lbl_staffName.TabIndex = 9
        Me.lbl_staffName.Text = "<<staff_name>>"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(158, 193)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(57, 13)
        Me.lbl_name.TabIndex = 8
        Me.lbl_name.Text = "<<name>>"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(37, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "PHONE NUMBER:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(37, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "STAFF NAME:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(37, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "CUSTOMER  NAME:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(145, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "EMAIL: customer-service@EverythingTerry.com"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(192, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "CONTACT: +60123456789"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(192, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "46000 BANGI, SELANGOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(145, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "BLOK K12A, KOLEJ BURHANUDDIN HELMI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(233, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "K12A-201"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-6, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(986, 113)
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'frm_invoice_a202479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(738, 722)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_headerOrder)
        Me.Controls.Add(Me.lst_orderID)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_header1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_invoice_a202479"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVOICE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_header1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_back As Button
    Friend WithEvents lst_orderID As ListBox
    Friend WithEvents lbl_headerOrder As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_order_id As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents lbl_staff_id As Label
    Friend WithEvents lbl_cust_id As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbl_phone As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_shopName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_staffName As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label12 As Label
End Class

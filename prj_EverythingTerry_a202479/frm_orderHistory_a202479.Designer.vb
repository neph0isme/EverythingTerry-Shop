<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_orderHistory_a202479
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orderHistory_a202479))
        Me.lbl_header1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lst_orderID = New System.Windows.Forms.ListBox()
        Me.lbl_staffID = New System.Windows.Forms.Label()
        Me.cmb_staffID = New System.Windows.Forms.ComboBox()
        Me.cmb_custID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_stfName = New System.Windows.Forms.TextBox()
        Me.txt_custName = New System.Windows.Forms.TextBox()
        Me.txt_position = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Num = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.lbl_txtTotal = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_header1
        '
        Me.lbl_header1.AutoSize = True
        Me.lbl_header1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbl_header1.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header1.ForeColor = System.Drawing.Color.White
        Me.lbl_header1.Location = New System.Drawing.Point(12, 34)
        Me.lbl_header1.Name = "lbl_header1"
        Me.lbl_header1.Size = New System.Drawing.Size(399, 50)
        Me.lbl_header1.TabIndex = 71
        Me.lbl_header1.Text = "Order History"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-16, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(986, 113)
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'lst_orderID
        '
        Me.lst_orderID.FormattingEnabled = True
        Me.lst_orderID.Location = New System.Drawing.Point(12, 131)
        Me.lst_orderID.Name = "lst_orderID"
        Me.lst_orderID.Size = New System.Drawing.Size(123, 472)
        Me.lst_orderID.TabIndex = 87
        '
        'lbl_staffID
        '
        Me.lbl_staffID.AutoSize = True
        Me.lbl_staffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffID.ForeColor = System.Drawing.Color.White
        Me.lbl_staffID.Location = New System.Drawing.Point(141, 134)
        Me.lbl_staffID.Name = "lbl_staffID"
        Me.lbl_staffID.Size = New System.Drawing.Size(56, 18)
        Me.lbl_staffID.TabIndex = 88
        Me.lbl_staffID.Text = "Staff ID"
        '
        'cmb_staffID
        '
        Me.cmb_staffID.FormattingEnabled = True
        Me.cmb_staffID.Location = New System.Drawing.Point(145, 155)
        Me.cmb_staffID.Name = "cmb_staffID"
        Me.cmb_staffID.Size = New System.Drawing.Size(194, 21)
        Me.cmb_staffID.TabIndex = 89
        '
        'cmb_custID
        '
        Me.cmb_custID.FormattingEnabled = True
        Me.cmb_custID.Location = New System.Drawing.Point(397, 155)
        Me.cmb_custID.Name = "cmb_custID"
        Me.cmb_custID.Size = New System.Drawing.Size(194, 21)
        Me.cmb_custID.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(393, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 18)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(394, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 18)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Customer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(141, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Staff Name"
        '
        'txt_stfName
        '
        Me.txt_stfName.Location = New System.Drawing.Point(145, 219)
        Me.txt_stfName.Name = "txt_stfName"
        Me.txt_stfName.Size = New System.Drawing.Size(194, 20)
        Me.txt_stfName.TabIndex = 94
        '
        'txt_custName
        '
        Me.txt_custName.Location = New System.Drawing.Point(397, 219)
        Me.txt_custName.Name = "txt_custName"
        Me.txt_custName.Size = New System.Drawing.Size(194, 20)
        Me.txt_custName.TabIndex = 95
        '
        'txt_position
        '
        Me.txt_position.Location = New System.Drawing.Point(145, 282)
        Me.txt_position.Name = "txt_position"
        Me.txt_position.Size = New System.Drawing.Size(194, 20)
        Me.txt_position.TabIndex = 97
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(142, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Position"
        '
        'txt_Num
        '
        Me.txt_Num.Location = New System.Drawing.Point(397, 282)
        Me.txt_Num.Name = "txt_Num"
        Me.txt_Num.Size = New System.Drawing.Size(194, 20)
        Me.txt_Num.TabIndex = 99
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(394, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 18)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Phone Number"
        '
        'grd_order
        '
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(144, 318)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.Size = New System.Drawing.Size(447, 183)
        Me.grd_order.TabIndex = 100
        '
        'lbl_txtTotal
        '
        Me.lbl_txtTotal.AutoSize = True
        Me.lbl_txtTotal.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbl_txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_txtTotal.ForeColor = System.Drawing.Color.White
        Me.lbl_txtTotal.Location = New System.Drawing.Point(313, 514)
        Me.lbl_txtTotal.Name = "lbl_txtTotal"
        Me.lbl_txtTotal.Size = New System.Drawing.Size(81, 20)
        Me.lbl_txtTotal.TabIndex = 101
        Me.lbl_txtTotal.Text = "Total : RM"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.White
        Me.lbl_total.Location = New System.Drawing.Point(410, 514)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(18, 20)
        Me.lbl_total.TabIndex = 102
        Me.lbl_total.Text = "0"
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.Red
        Me.btn_refresh.ForeColor = System.Drawing.Color.White
        Me.btn_refresh.Location = New System.Drawing.Point(145, 550)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(446, 23)
        Me.btn_refresh.TabIndex = 103
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.ForeColor = System.Drawing.Color.Crimson
        Me.btn_back.Location = New System.Drawing.Point(516, 580)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 104
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_orderHistory_a202479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(610, 641)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_txtTotal)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.txt_Num)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_position)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_custName)
        Me.Controls.Add(Me.txt_stfName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_custID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_staffID)
        Me.Controls.Add(Me.lbl_staffID)
        Me.Controls.Add(Me.lst_orderID)
        Me.Controls.Add(Me.lbl_header1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_orderHistory_a202479"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order History"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_header1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lst_orderID As ListBox
    Friend WithEvents lbl_staffID As Label
    Friend WithEvents cmb_staffID As ComboBox
    Friend WithEvents cmb_custID As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_stfName As TextBox
    Friend WithEvents txt_custName As TextBox
    Friend WithEvents txt_position As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Num As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents lbl_txtTotal As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_back As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customer_a202479
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_customer_a202479))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_number = New System.Windows.Forms.Label()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.lbl_staff_name = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lst_cust_id = New System.Windows.Forms.ListBox()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.ForeColor = System.Drawing.Color.Crimson
        Me.btn_back.Location = New System.Drawing.Point(269, 346)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 2
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'lbl_number
        '
        Me.lbl_number.AutoSize = True
        Me.lbl_number.ForeColor = System.Drawing.Color.White
        Me.lbl_number.Location = New System.Drawing.Point(143, 218)
        Me.lbl_number.Name = "lbl_number"
        Me.lbl_number.Size = New System.Drawing.Size(78, 13)
        Me.lbl_number.TabIndex = 18
        Me.lbl_number.Text = "Phone Number"
        '
        'txt_num
        '
        Me.txt_num.Location = New System.Drawing.Point(146, 234)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(198, 20)
        Me.txt_num.TabIndex = 17
        '
        'lbl_staff_name
        '
        Me.lbl_staff_name.AutoSize = True
        Me.lbl_staff_name.ForeColor = System.Drawing.Color.White
        Me.lbl_staff_name.Location = New System.Drawing.Point(143, 158)
        Me.lbl_staff_name.Name = "lbl_staff_name"
        Me.lbl_staff_name.Size = New System.Drawing.Size(35, 13)
        Me.lbl_staff_name.TabIndex = 16
        Me.lbl_staff_name.Text = "Name"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(146, 174)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(198, 20)
        Me.txt_name.TabIndex = 15
        '
        'lst_cust_id
        '
        Me.lst_cust_id.FormattingEnabled = True
        Me.lst_cust_id.Location = New System.Drawing.Point(13, 105)
        Me.lst_cust_id.Name = "lst_cust_id"
        Me.lst_cust_id.Size = New System.Drawing.Size(127, 264)
        Me.lst_cust_id.TabIndex = 13
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.BackColor = System.Drawing.Color.SeaGreen
        Me.lbl_staff.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff.ForeColor = System.Drawing.Color.White
        Me.lbl_staff.Location = New System.Drawing.Point(13, 33)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(254, 50)
        Me.lbl_staff.TabIndex = 11
        Me.lbl_staff.Text = "Customer"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.prj_EverythingTerry_a202479.My.Resources.Resources.wallpaperflare1
        Me.PictureBox2.Location = New System.Drawing.Point(-3, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(807, 100)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'frm_customer_a202479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(383, 387)
        Me.Controls.Add(Me.lbl_number)
        Me.Controls.Add(Me.txt_num)
        Me.Controls.Add(Me.lbl_staff_name)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lst_cust_id)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_back)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_customer_a202479"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUSTOMER"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_number As Label
    Friend WithEvents txt_num As TextBox
    Friend WithEvents lbl_staff_name As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lst_cust_id As ListBox
    Friend WithEvents lbl_staff As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class

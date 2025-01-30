<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staff_a202479
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_staff_a202479))
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lst_staff_id = New System.Windows.Forms.ListBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_staff_name = New System.Windows.Forms.Label()
        Me.lbl_position = New System.Windows.Forms.Label()
        Me.txt_position = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.BackColor = System.Drawing.Color.Khaki
        Me.lbl_staff.Font = New System.Drawing.Font("OCR A Extended", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff.ForeColor = System.Drawing.Color.White
        Me.lbl_staff.Location = New System.Drawing.Point(12, 33)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(167, 50)
        Me.lbl_staff.TabIndex = 1
        Me.lbl_staff.Text = "Staff"
        '
        'btn_exit
        '
        Me.btn_exit.ForeColor = System.Drawing.Color.Crimson
        Me.btn_exit.Location = New System.Drawing.Point(268, 346)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 4
        Me.btn_exit.Text = "BACK"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'lst_staff_id
        '
        Me.lst_staff_id.FormattingEnabled = True
        Me.lst_staff_id.Location = New System.Drawing.Point(12, 105)
        Me.lst_staff_id.Name = "lst_staff_id"
        Me.lst_staff_id.Size = New System.Drawing.Size(127, 264)
        Me.lst_staff_id.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.prj_EverythingTerry_a202479.My.Resources.Resources.wallpaperflare1
        Me.PictureBox2.Location = New System.Drawing.Point(-4, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(807, 100)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(145, 184)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(198, 20)
        Me.txt_name.TabIndex = 7
        '
        'lbl_staff_name
        '
        Me.lbl_staff_name.AutoSize = True
        Me.lbl_staff_name.Location = New System.Drawing.Point(142, 168)
        Me.lbl_staff_name.Name = "lbl_staff_name"
        Me.lbl_staff_name.Size = New System.Drawing.Size(35, 13)
        Me.lbl_staff_name.TabIndex = 8
        Me.lbl_staff_name.Text = "Name"
        '
        'lbl_position
        '
        Me.lbl_position.AutoSize = True
        Me.lbl_position.Location = New System.Drawing.Point(142, 228)
        Me.lbl_position.Name = "lbl_position"
        Me.lbl_position.Size = New System.Drawing.Size(44, 13)
        Me.lbl_position.TabIndex = 10
        Me.lbl_position.Text = "Position"
        '
        'txt_position
        '
        Me.txt_position.Location = New System.Drawing.Point(145, 244)
        Me.txt_position.Name = "txt_position"
        Me.txt_position.Size = New System.Drawing.Size(198, 20)
        Me.txt_position.TabIndex = 9
        '
        'frm_staff_a202479
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(373, 399)
        Me.Controls.Add(Me.lbl_position)
        Me.Controls.Add(Me.txt_position)
        Me.Controls.Add(Me.lbl_staff_name)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lst_staff_id)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_staff_a202479"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STAFF"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_staff As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents lst_staff_id As ListBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_staff_name As Label
    Friend WithEvents lbl_position As Label
    Friend WithEvents txt_position As TextBox
End Class

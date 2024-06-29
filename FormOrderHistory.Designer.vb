<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrderHistory
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVOrderHistory = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonShop = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelWelcomeHistory = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GoBack = New System.Windows.Forms.PictureBox()
        Me.ButtonSignOut = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DGVOrderHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GoBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Castellar", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(130, 130)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "APHRODITE"
        '
        'DGVOrderHistory
        '
        Me.DGVOrderHistory.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.DGVOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOrderHistory.Location = New System.Drawing.Point(356, 315)
        Me.DGVOrderHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVOrderHistory.Name = "DGVOrderHistory"
        Me.DGVOrderHistory.Size = New System.Drawing.Size(757, 335)
        Me.DGVOrderHistory.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(350, 277)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 31)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Order History"
        '
        'ButtonShop
        '
        Me.ButtonShop.BackColor = System.Drawing.Color.Transparent
        Me.ButtonShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonShop.ForeColor = System.Drawing.Color.Black
        Me.ButtonShop.Location = New System.Drawing.Point(55, 589)
        Me.ButtonShop.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonShop.Name = "ButtonShop"
        Me.ButtonShop.Size = New System.Drawing.Size(208, 61)
        Me.ButtonShop.TabIndex = 14
        Me.ButtonShop.Text = "Shop More"
        Me.ButtonShop.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(52, 174)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "HOME  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(114, 174)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ORDER HISTORY"
        '
        'LabelWelcomeHistory
        '
        Me.LabelWelcomeHistory.AutoSize = True
        Me.LabelWelcomeHistory.BackColor = System.Drawing.Color.LightGray
        Me.LabelWelcomeHistory.Font = New System.Drawing.Font("Garamond", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWelcomeHistory.Location = New System.Drawing.Point(374, 110)
        Me.LabelWelcomeHistory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelWelcomeHistory.Name = "LabelWelcomeHistory"
        Me.LabelWelcomeHistory.Size = New System.Drawing.Size(83, 43)
        Me.LabelWelcomeHistory.TabIndex = 18
        Me.LabelWelcomeHistory.Text = "Hi, "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(378, 188)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Here is the list of your Order History."
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Aphrodite.My.Resources.Resources.Untitled_design__27_
        Me.PictureBox2.Location = New System.Drawing.Point(265, -63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(964, 558)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aphrodite.My.Resources.Resources.APHRODITE__3_
        Me.PictureBox1.Location = New System.Drawing.Point(55, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GoBack
        '
        Me.GoBack.Image = Global.Aphrodite.My.Resources.Resources.go_back_2
        Me.GoBack.Location = New System.Drawing.Point(47, 13)
        Me.GoBack.Name = "GoBack"
        Me.GoBack.Size = New System.Drawing.Size(59, 53)
        Me.GoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GoBack.TabIndex = 30
        Me.GoBack.TabStop = False
        '
        'ButtonSignOut
        '
        Me.ButtonSignOut.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonSignOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSignOut.Location = New System.Drawing.Point(1077, 13)
        Me.ButtonSignOut.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSignOut.Name = "ButtonSignOut"
        Me.ButtonSignOut.Size = New System.Drawing.Size(99, 43)
        Me.ButtonSignOut.TabIndex = 31
        Me.ButtonSignOut.Text = "Sign Out"
        Me.ButtonSignOut.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(353, 62)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 17)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "ORDER HISTORY"
        '
        'FormOrderHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1204, 663)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonSignOut)
        Me.Controls.Add(Me.GoBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelWelcomeHistory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonShop)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGVOrderHistory)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormOrderHistory"
        Me.Text = "FormOrderHistory"
        CType(Me.DGVOrderHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GoBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DGVOrderHistory As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonShop As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelWelcomeHistory As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GoBack As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonSignOut As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class

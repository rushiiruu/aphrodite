<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDistributorTransferDelivery
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
        Me.DGVTransferDelivery = New System.Windows.Forms.DataGridView()
        Me.ButtonConfirmDelivery = New System.Windows.Forms.Button()
        Me.LabelWelcomeMerch = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonSignOut = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DGVTransferDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVTransferDelivery
        '
        Me.DGVTransferDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTransferDelivery.Location = New System.Drawing.Point(354, 314)
        Me.DGVTransferDelivery.Name = "DGVTransferDelivery"
        Me.DGVTransferDelivery.RowTemplate.Height = 24
        Me.DGVTransferDelivery.Size = New System.Drawing.Size(765, 318)
        Me.DGVTransferDelivery.TabIndex = 0
        '
        'ButtonConfirmDelivery
        '
        Me.ButtonConfirmDelivery.BackColor = System.Drawing.Color.Transparent
        Me.ButtonConfirmDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConfirmDelivery.ForeColor = System.Drawing.Color.Black
        Me.ButtonConfirmDelivery.Location = New System.Drawing.Point(46, 577)
        Me.ButtonConfirmDelivery.Name = "ButtonConfirmDelivery"
        Me.ButtonConfirmDelivery.Size = New System.Drawing.Size(174, 55)
        Me.ButtonConfirmDelivery.TabIndex = 2
        Me.ButtonConfirmDelivery.Text = "Confirm Delivery"
        Me.ButtonConfirmDelivery.UseVisualStyleBackColor = False
        '
        'LabelWelcomeMerch
        '
        Me.LabelWelcomeMerch.AutoSize = True
        Me.LabelWelcomeMerch.BackColor = System.Drawing.Color.LightGray
        Me.LabelWelcomeMerch.Font = New System.Drawing.Font("Garamond", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWelcomeMerch.Location = New System.Drawing.Point(372, 105)
        Me.LabelWelcomeMerch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelWelcomeMerch.Name = "LabelWelcomeMerch"
        Me.LabelWelcomeMerch.Size = New System.Drawing.Size(83, 43)
        Me.LabelWelcomeMerch.TabIndex = 42
        Me.LabelWelcomeMerch.Text = "Hi, "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(348, 280)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(280, 31)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Transfer Confirmation"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button1.Location = New System.Drawing.Point(1024, 6)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 28)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Sign Out"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(351, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "DELIVERY CONFIRMATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Castellar", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(121, 125)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "APHRODITE"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Aphrodite.My.Resources.Resources.Untitled_design__27_
        Me.PictureBox2.Location = New System.Drawing.Point(265, -69)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(964, 558)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aphrodite.My.Resources.Resources.APHRODITE__3_
        Me.PictureBox1.Location = New System.Drawing.Point(46, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'ButtonSignOut
        '
        Me.ButtonSignOut.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonSignOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSignOut.Location = New System.Drawing.Point(1065, 11)
        Me.ButtonSignOut.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSignOut.Name = "ButtonSignOut"
        Me.ButtonSignOut.Size = New System.Drawing.Size(99, 43)
        Me.ButtonSignOut.TabIndex = 54
        Me.ButtonSignOut.Text = "Sign Out"
        Me.ButtonSignOut.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(376, 178)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(475, 20)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Please confirm if you have successfully delivered the products."
        '
        'FormDistributorTransferDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1204, 663)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonSignOut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGVTransferDelivery)
        Me.Controls.Add(Me.LabelWelcomeMerch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonConfirmDelivery)
        Me.Name = "FormDistributorTransferDelivery"
        Me.Text = "FormDistributor"
        CType(Me.DGVTransferDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVTransferDelivery As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonConfirmDelivery As System.Windows.Forms.Button
    Friend WithEvents LabelWelcomeMerch As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonSignOut As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

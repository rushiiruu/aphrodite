<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductList
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
        Me.DGVProduct = New System.Windows.Forms.DataGridView()
        Me.ButtonAddCart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonQuantity = New System.Windows.Forms.NumericUpDown()
        Me.DGVUserCart = New System.Windows.Forms.DataGridView()
        Me.JewelryLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.ButtonCheckout = New System.Windows.Forms.Button()
        Me.LabelBranch = New System.Windows.Forms.Label()
        Me.DropdownBranchLocation = New System.Windows.Forms.ComboBox()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelTotalPrice = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonSignOut = New System.Windows.Forms.Button()
        Me.GoBack = New System.Windows.Forms.PictureBox()
        CType(Me.DGVProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVUserCart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GoBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVProduct
        '
        Me.DGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProduct.Location = New System.Drawing.Point(555, 58)
        Me.DGVProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVProduct.Name = "DGVProduct"
        Me.DGVProduct.Size = New System.Drawing.Size(938, 340)
        Me.DGVProduct.TabIndex = 0
        '
        'ButtonAddCart
        '
        Me.ButtonAddCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCart.Location = New System.Drawing.Point(310, 350)
        Me.ButtonAddCart.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAddCart.Name = "ButtonAddCart"
        Me.ButtonAddCart.Size = New System.Drawing.Size(148, 28)
        Me.ButtonAddCart.TabIndex = 1
        Me.ButtonAddCart.Text = "Add to Cart"
        Me.ButtonAddCart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 350)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Quantity"
        '
        'ButtonQuantity
        '
        Me.ButtonQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuantity.Location = New System.Drawing.Point(142, 350)
        Me.ButtonQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ButtonQuantity.Name = "ButtonQuantity"
        Me.ButtonQuantity.Size = New System.Drawing.Size(160, 27)
        Me.ButtonQuantity.TabIndex = 4
        Me.ButtonQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DGVUserCart
        '
        Me.DGVUserCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUserCart.Location = New System.Drawing.Point(556, 440)
        Me.DGVUserCart.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVUserCart.Name = "DGVUserCart"
        Me.DGVUserCart.Size = New System.Drawing.Size(633, 285)
        Me.DGVUserCart.TabIndex = 5
        '
        'JewelryLabel
        '
        Me.JewelryLabel.AutoSize = True
        Me.JewelryLabel.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JewelryLabel.Location = New System.Drawing.Point(64, 279)
        Me.JewelryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.JewelryLabel.Name = "JewelryLabel"
        Me.JewelryLabel.Size = New System.Drawing.Size(154, 27)
        Me.JewelryLabel.TabIndex = 6
        Me.JewelryLabel.Text = "Jewelry Name"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLabel.Location = New System.Drawing.Point(68, 316)
        Me.PriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(48, 20)
        Me.PriceLabel.TabIndex = 7
        Me.PriceLabel.Text = "Price"
        '
        'ButtonCheckout
        '
        Me.ButtonCheckout.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCheckout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonCheckout.Location = New System.Drawing.Point(69, 478)
        Me.ButtonCheckout.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCheckout.Name = "ButtonCheckout"
        Me.ButtonCheckout.Size = New System.Drawing.Size(389, 59)
        Me.ButtonCheckout.TabIndex = 8
        Me.ButtonCheckout.Text = "Checkout"
        Me.ButtonCheckout.UseVisualStyleBackColor = False
        '
        'LabelBranch
        '
        Me.LabelBranch.AutoSize = True
        Me.LabelBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBranch.Location = New System.Drawing.Point(65, 390)
        Me.LabelBranch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBranch.Name = "LabelBranch"
        Me.LabelBranch.Size = New System.Drawing.Size(130, 20)
        Me.LabelBranch.TabIndex = 9
        Me.LabelBranch.Text = "Choose Branch:"
        '
        'DropdownBranchLocation
        '
        Me.DropdownBranchLocation.DisplayMember = "Otin"
        Me.DropdownBranchLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropdownBranchLocation.FormattingEnabled = True
        Me.DropdownBranchLocation.Location = New System.Drawing.Point(203, 387)
        Me.DropdownBranchLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.DropdownBranchLocation.Name = "DropdownBranchLocation"
        Me.DropdownBranchLocation.Size = New System.Drawing.Size(160, 28)
        Me.DropdownBranchLocation.TabIndex = 10
        Me.DropdownBranchLocation.ValueMember = "Otin"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(68, 440)
        Me.LabelTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(51, 20)
        Me.LabelTotal.TabIndex = 11
        Me.LabelTotal.Text = "Total:"
        '
        'LabelTotalPrice
        '
        Me.LabelTotalPrice.AutoSize = True
        Me.LabelTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalPrice.Location = New System.Drawing.Point(127, 440)
        Me.LabelTotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTotalPrice.Name = "LabelTotalPrice"
        Me.LabelTotalPrice.Size = New System.Drawing.Size(27, 20)
        Me.LabelTotalPrice.TabIndex = 13
        Me.LabelTotalPrice.Text = "$0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(57, 150)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "ORDER PRODUCT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Castellar", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(141, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "APHRODITE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(549, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 31)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Product List"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(549, 405)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 31)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Cart"
        '
        'ButtonRemove
        '
        Me.ButtonRemove.BackColor = System.Drawing.SystemColors.ControlText
        Me.ButtonRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonRemove.Location = New System.Drawing.Point(1196, 668)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(186, 56)
        Me.ButtonRemove.TabIndex = 24
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aphrodite.My.Resources.Resources.APHRODITE__3_
        Me.PictureBox1.Location = New System.Drawing.Point(66, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'ButtonSignOut
        '
        Me.ButtonSignOut.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonSignOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSignOut.Location = New System.Drawing.Point(1394, 7)
        Me.ButtonSignOut.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSignOut.Name = "ButtonSignOut"
        Me.ButtonSignOut.Size = New System.Drawing.Size(99, 43)
        Me.ButtonSignOut.TabIndex = 25
        Me.ButtonSignOut.Text = "Sign Out"
        Me.ButtonSignOut.UseVisualStyleBackColor = False
        '
        'GoBack
        '
        Me.GoBack.Image = Global.Aphrodite.My.Resources.Resources.go_back_2
        Me.GoBack.Location = New System.Drawing.Point(60, 7)
        Me.GoBack.Name = "GoBack"
        Me.GoBack.Size = New System.Drawing.Size(59, 53)
        Me.GoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GoBack.TabIndex = 31
        Me.GoBack.TabStop = False
        '
        'FormProductList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1651, 738)
        Me.Controls.Add(Me.GoBack)
        Me.Controls.Add(Me.ButtonSignOut)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelTotalPrice)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.DropdownBranchLocation)
        Me.Controls.Add(Me.LabelBranch)
        Me.Controls.Add(Me.ButtonCheckout)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.JewelryLabel)
        Me.Controls.Add(Me.DGVUserCart)
        Me.Controls.Add(Me.ButtonQuantity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonAddCart)
        Me.Controls.Add(Me.DGVProduct)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormProductList"
        Me.Text = "FormProductList"
        CType(Me.DGVProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVUserCart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GoBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVProduct As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonAddCart As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents DGVUserCart As System.Windows.Forms.DataGridView
    Friend WithEvents JewelryLabel As System.Windows.Forms.Label
    Friend WithEvents PriceLabel As System.Windows.Forms.Label
    Friend WithEvents ButtonCheckout As System.Windows.Forms.Button
    Friend WithEvents LabelBranch As System.Windows.Forms.Label
    Friend WithEvents DropdownBranchLocation As System.Windows.Forms.ComboBox
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents LabelTotalPrice As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonRemove As System.Windows.Forms.Button
    Friend WithEvents ButtonSignOut As System.Windows.Forms.Button
    Friend WithEvents GoBack As System.Windows.Forms.PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrderList
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
        Me.DGVOrderList = New System.Windows.Forms.DataGridView()
        Me.ButtonApprove = New System.Windows.Forms.Button()
        Me.DGVProductStockList = New System.Windows.Forms.DataGridView()
        Me.DGVProductItem = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonSignOut = New System.Windows.Forms.Button()
        Me.GoBack = New System.Windows.Forms.PictureBox()
        CType(Me.DGVOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVProductStockList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVProductItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GoBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVOrderList
        '
        Me.DGVOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOrderList.Location = New System.Drawing.Point(248, 74)
        Me.DGVOrderList.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVOrderList.Name = "DGVOrderList"
        Me.DGVOrderList.Size = New System.Drawing.Size(679, 640)
        Me.DGVOrderList.TabIndex = 0
        '
        'ButtonApprove
        '
        Me.ButtonApprove.BackColor = System.Drawing.Color.Transparent
        Me.ButtonApprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonApprove.ForeColor = System.Drawing.Color.Black
        Me.ButtonApprove.Location = New System.Drawing.Point(35, 646)
        Me.ButtonApprove.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonApprove.Name = "ButtonApprove"
        Me.ButtonApprove.Size = New System.Drawing.Size(183, 68)
        Me.ButtonApprove.TabIndex = 1
        Me.ButtonApprove.Text = "Approve"
        Me.ButtonApprove.UseVisualStyleBackColor = False
        '
        'DGVProductStockList
        '
        Me.DGVProductStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductStockList.Location = New System.Drawing.Point(949, 74)
        Me.DGVProductStockList.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVProductStockList.Name = "DGVProductStockList"
        Me.DGVProductStockList.Size = New System.Drawing.Size(625, 304)
        Me.DGVProductStockList.TabIndex = 2
        '
        'DGVProductItem
        '
        Me.DGVProductItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductItem.Location = New System.Drawing.Point(949, 433)
        Me.DGVProductItem.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVProductItem.Name = "DGVProductItem"
        Me.DGVProductItem.Size = New System.Drawing.Size(625, 281)
        Me.DGVProductItem.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(32, 165)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "ORDER PRODUCT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Castellar", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(110, 123)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "APHRODITE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(242, 39)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 31)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Order List"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(943, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 31)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Order Product Item"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(943, 398)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(209, 31)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Order Line Item"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aphrodite.My.Resources.Resources.APHRODITE__3_
        Me.PictureBox1.Location = New System.Drawing.Point(35, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'ButtonSignOut
        '
        Me.ButtonSignOut.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonSignOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSignOut.Location = New System.Drawing.Point(1475, 13)
        Me.ButtonSignOut.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSignOut.Name = "ButtonSignOut"
        Me.ButtonSignOut.Size = New System.Drawing.Size(99, 43)
        Me.ButtonSignOut.TabIndex = 29
        Me.ButtonSignOut.Text = "Sign Out"
        Me.ButtonSignOut.UseVisualStyleBackColor = False
        '
        'GoBack
        '
        Me.GoBack.Image = Global.Aphrodite.My.Resources.Resources.go_back_2
        Me.GoBack.Location = New System.Drawing.Point(35, 17)
        Me.GoBack.Name = "GoBack"
        Me.GoBack.Size = New System.Drawing.Size(59, 53)
        Me.GoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GoBack.TabIndex = 32
        Me.GoBack.TabStop = False
        '
        'FormOrderList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1924, 740)
        Me.Controls.Add(Me.GoBack)
        Me.Controls.Add(Me.ButtonSignOut)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonApprove)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DGVProductItem)
        Me.Controls.Add(Me.DGVProductStockList)
        Me.Controls.Add(Me.DGVOrderList)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormOrderList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "z"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVProductStockList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVProductItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GoBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVOrderList As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonApprove As System.Windows.Forms.Button
    Friend WithEvents DGVProductStockList As System.Windows.Forms.DataGridView
    Friend WithEvents DGVProductItem As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonSignOut As System.Windows.Forms.Button
    Friend WithEvents GoBack As System.Windows.Forms.PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserPayment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DropdownPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.RBOnline = New System.Windows.Forms.RadioButton()
        Me.RBFacetoFace = New System.Windows.Forms.RadioButton()
        Me.ButtonConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 142)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose your Payment Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 186)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Choose your Payment Method:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Payment Method"
        '
        'DropdownPaymentMethod
        '
        Me.DropdownPaymentMethod.FormattingEnabled = True
        Me.DropdownPaymentMethod.Location = New System.Drawing.Point(360, 182)
        Me.DropdownPaymentMethod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DropdownPaymentMethod.Name = "DropdownPaymentMethod"
        Me.DropdownPaymentMethod.Size = New System.Drawing.Size(196, 24)
        Me.DropdownPaymentMethod.TabIndex = 4
        '
        'RBOnline
        '
        Me.RBOnline.AutoSize = True
        Me.RBOnline.Location = New System.Drawing.Point(348, 140)
        Me.RBOnline.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RBOnline.Name = "RBOnline"
        Me.RBOnline.Size = New System.Drawing.Size(70, 21)
        Me.RBOnline.TabIndex = 5
        Me.RBOnline.TabStop = True
        Me.RBOnline.Text = "Online"
        Me.RBOnline.UseVisualStyleBackColor = True
        '
        'RBFacetoFace
        '
        Me.RBFacetoFace.AutoSize = True
        Me.RBFacetoFace.Location = New System.Drawing.Point(437, 140)
        Me.RBFacetoFace.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RBFacetoFace.Name = "RBFacetoFace"
        Me.RBFacetoFace.Size = New System.Drawing.Size(113, 21)
        Me.RBFacetoFace.TabIndex = 6
        Me.RBFacetoFace.TabStop = True
        Me.RBFacetoFace.Text = "Face-to-Face"
        Me.RBFacetoFace.UseVisualStyleBackColor = True
        '
        'ButtonConfirm
        '
        Me.ButtonConfirm.Location = New System.Drawing.Point(253, 337)
        Me.ButtonConfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonConfirm.Name = "ButtonConfirm"
        Me.ButtonConfirm.Size = New System.Drawing.Size(155, 39)
        Me.ButtonConfirm.TabIndex = 7
        Me.ButtonConfirm.Text = "Confirm"
        Me.ButtonConfirm.UseVisualStyleBackColor = True
        '
        'FormUserPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 448)
        Me.Controls.Add(Me.ButtonConfirm)
        Me.Controls.Add(Me.RBFacetoFace)
        Me.Controls.Add(Me.RBOnline)
        Me.Controls.Add(Me.DropdownPaymentMethod)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormUserPayment"
        Me.Text = "FormUserPayment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DropdownPaymentMethod As System.Windows.Forms.ComboBox
    Friend WithEvents RBOnline As System.Windows.Forms.RadioButton
    Friend WithEvents RBFacetoFace As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonConfirm As System.Windows.Forms.Button
End Class

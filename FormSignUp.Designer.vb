<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSignUp
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Passwork = New System.Windows.Forms.Label()
        Me.TBFirstName = New System.Windows.Forms.TextBox()
        Me.TBLastName = New System.Windows.Forms.TextBox()
        Me.DateDOB = New System.Windows.Forms.DateTimePicker()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonSignUp = New System.Windows.Forms.Button()
        Me.LinkLogin = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(486, 170)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(486, 217)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(486, 367)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date of Birth"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(486, 264)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email"
        '
        'Passwork
        '
        Me.Passwork.AutoSize = true
        Me.Passwork.Font = New System.Drawing.Font("Georgia", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Passwork.Location = New System.Drawing.Point(486, 311)
        Me.Passwork.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Passwork.Name = "Passwork"
        Me.Passwork.Size = New System.Drawing.Size(71, 18)
        Me.Passwork.TabIndex = 5
        Me.Passwork.Text = "Password"
        '
        'TBFirstName
        '
        Me.TBFirstName.BackColor = System.Drawing.Color.Gainsboro
        Me.TBFirstName.Location = New System.Drawing.Point(489, 191)
        Me.TBFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.TBFirstName.Name = "TBFirstName"
        Me.TBFirstName.Size = New System.Drawing.Size(348, 22)
        Me.TBFirstName.TabIndex = 7
        '
        'TBLastName
        '
        Me.TBLastName.BackColor = System.Drawing.Color.Gainsboro
        Me.TBLastName.Location = New System.Drawing.Point(489, 238)
        Me.TBLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.TBLastName.Name = "TBLastName"
        Me.TBLastName.Size = New System.Drawing.Size(348, 22)
        Me.TBLastName.TabIndex = 8
        '
        'DateDOB
        '
        Me.DateDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDOB.Location = New System.Drawing.Point(489, 388)
        Me.DateDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.DateDOB.Name = "DateDOB"
        Me.DateDOB.Size = New System.Drawing.Size(133, 22)
        Me.DateDOB.TabIndex = 11
        '
        'TBEmail
        '
        Me.TBEmail.BackColor = System.Drawing.Color.Gainsboro
        Me.TBEmail.Location = New System.Drawing.Point(489, 285)
        Me.TBEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(348, 22)
        Me.TBEmail.TabIndex = 9
        '
        'TBPassword
        '
        Me.TBPassword.BackColor = System.Drawing.Color.Gainsboro
        Me.TBPassword.Location = New System.Drawing.Point(489, 332)
        Me.TBPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPassword.Size = New System.Drawing.Size(348, 22)
        Me.TBPassword.TabIndex = 10
        Me.TBPassword.UseSystemPasswordChar = true
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Garamond", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(602, 31)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Already have an account?"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Garamond", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(483, 90)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(287, 31)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Welcome to Aphrodite!"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(486, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Register your account"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aphrodite.My.Resources.Resources._2e00ae77e7095480ea69fb1f4c21c9f5
        Me.PictureBox1.Location = New System.Drawing.Point(-7, -49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(410, 601)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = false
        '
        'ButtonSignUp
        '
        Me.ButtonSignUp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonSignUp.ForeColor = System.Drawing.Color.Black
        Me.ButtonSignUp.Location = New System.Drawing.Point(712, 373)
        Me.ButtonSignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSignUp.Name = "ButtonSignUp"
        Me.ButtonSignUp.Size = New System.Drawing.Size(125, 57)
        Me.ButtonSignUp.TabIndex = 12
        Me.ButtonSignUp.Text = "Sign Up"
        Me.ButtonSignUp.UseVisualStyleBackColor = false
        '
        'LinkLogin
        '
        Me.LinkLogin.ActiveLinkColor = System.Drawing.SystemColors.Desktop
        Me.LinkLogin.AutoSize = true
        Me.LinkLogin.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LinkLogin.LinkColor = System.Drawing.Color.Black
        Me.LinkLogin.Location = New System.Drawing.Point(790, 31)
        Me.LinkLogin.Name = "LinkLogin"
        Me.LinkLogin.Size = New System.Drawing.Size(47, 17)
        Me.LinkLogin.TabIndex = 18
        Me.LinkLogin.TabStop = true
        Me.LinkLogin.Text = "Log in"
        '
        'FormSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(903, 480)
        Me.Controls.Add(Me.LinkLogin)
        Me.Controls.Add(Me.ButtonSignUp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TBPassword)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.DateDOB)
        Me.Controls.Add(Me.TBLastName)
        Me.Controls.Add(Me.TBFirstName)
        Me.Controls.Add(Me.Passwork)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Passwork As System.Windows.Forms.Label
    Friend WithEvents TBFirstName As System.Windows.Forms.TextBox
    Friend WithEvents TBLastName As System.Windows.Forms.TextBox
    Friend WithEvents TBEmail As System.Windows.Forms.TextBox
    Friend WithEvents TBPassword As System.Windows.Forms.TextBox
    Friend WithEvents DateDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonSignUp As System.Windows.Forms.Button
    Friend WithEvents LinkLogin As System.Windows.Forms.LinkLabel
End Class

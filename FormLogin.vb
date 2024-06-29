Imports IBM.Data.DB2

Class FormLogin

    Private conn As DB2Connection

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New DB2Connection("server=localhost;database=aphrdite;" + "uid=db2admin;password=db2admin;")
        conn.Open()
    End Sub

    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click

        Dim VStr As String
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader

        Dim input As String = TBEmail.Text.Trim() ' Assuming TextBox1 contains the input
        Dim password As String = TBPassword.Text

        If IsValidEmail(input) Then
            Try
                VStr = "SELECT customer_id, email, password FROM customer where email='" & input & "'AND password='" & password & "'"
                VCmd = New DB2Command(VStr, conn)
                VRdr = VCmd.ExecuteReader()


                If VRdr.HasRows Then
                    VRdr.Read()

                    Dim ID = VRdr.GetString(0)
                    SessionID.SessionID = ID

                    FormCustomerMenu.Show()
                    Me.Hide()

                    TBEmail.Clear()
                    TBPassword.Clear()

                    Exit Sub
                Else
                    MsgBox("Customer account not found! Please check your login credentials.")

                End If
                VRdr.Close()
            Catch ex As Exception
                ' Handle the exception here
            End Try

        ElseIf IsEmployee(input) Then
            Try
                VStr = "SELECT employee_id, password, employee_type FROM employee where employee_id='" & input & "'AND password='" & password & "'"
                VCmd = New DB2Command(VStr, conn)
                VRdr = VCmd.ExecuteReader()

                If VRdr.HasRows Then
                    VRdr.Read()

                    Dim EmployeeType = VRdr.GetString(2)

                    Dim ID = VRdr.GetString(0)
                    SessionID.SessionID = ID

                    If EmployeeType = "B" Or EmployeeType = "b" Then
                        FormEmployeeMenu.Show()
                        Me.Hide()
                    ElseIf EmployeeType = "D" Or EmployeeType = "d" Then
                        FormDistributorTransferDelivery.Show()
                        Me.Hide()
                    Else
                        MsgBox("Employee Type Invalid Contact Maintaince for help")
                    End If
                    TBEmail.Clear()
                    TBPassword.Clear()
                    Exit Sub
                Else
                    MsgBox("Employee account not found! Please check your login credentials.")

                End If

                VRdr.Close()
            Catch ex As Exception
                ' Handle the exception here
            End Try
        Else
            MessageBox.Show("Invalid input. Please enter an email or a numeric ID.")
        End If
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex("^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")
        Return emailRegex.IsMatch(email)
    End Function

    Private Function IsEmployee(value As String) As Boolean
        Dim numericRegex As New System.Text.RegularExpressions.Regex("^\d{6}$")
        Return numericRegex.IsMatch(value)
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LabelSignUP.LinkClicked
        FormSignUp.Show()
        Me.Hide()
    End Sub

    Private Sub LabelSignUP_MouseHover(sender As Object, e As EventArgs) Handles LabelSignUP.MouseHover
        LabelSignUP.LinkColor = Color.Gray

    End Sub

    Private Sub LabelSignUP_MouseLeave(sender As Object, e As EventArgs) Handles LabelSignUP.MouseLeave
        LabelSignUP.LinkColor = Color.Black
    End Sub

    Private Sub TBEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBEmail.KeyPress, TBPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            LogInButton.PerformClick()
        End If
    End Sub

End Class



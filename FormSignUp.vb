Imports IBM.Data.DB2
Imports System.Text.RegularExpressions

Public Class FormSignUp

    Private DBConn As Common.DbConnection

    Private CustomerID
    Private First_Name
    Private Last_Name
    Private DoB As Date
    Private Email
    Private Password
    Private Age
    Private btnEnabled As Boolean

    Private VBQuery



    Private Sub CustomerSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ButtonSignUp.Enabled = False
        DBConn = New DB2Connection("server=localhost;database=aphrdite;" + "uid=db2admin;password=db2admin;")
        DBConn.Open()

    End Sub


    Private Sub TBEmail_TextChanged(sender As Object, e As EventArgs) Handles TBEmail.TextChanged
        Dim allTextBoxesHaveText As Boolean = True

        ' Check if any of the TextBoxes are empty
        If String.IsNullOrWhiteSpace(TBFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(TBLastName.Text) OrElse
           String.IsNullOrWhiteSpace(TBEmail.Text) OrElse
           String.IsNullOrWhiteSpace(TBPassword.Text) Then
            allTextBoxesHaveText = False
        End If

        ' Enable or disable the button based on the condition
        ButtonSignUp.Enabled = allTextBoxesHaveText
    End Sub

    Private Sub TBFirstName_TextChanged(sender As Object, e As EventArgs) Handles TBFirstName.TextChanged
        Dim allTextBoxesHaveText As Boolean = True

        ' Check if any of the TextBoxes are empty
        If String.IsNullOrWhiteSpace(TBFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(TBLastName.Text) OrElse
           String.IsNullOrWhiteSpace(TBEmail.Text) OrElse
           String.IsNullOrWhiteSpace(TBPassword.Text) Then
            allTextBoxesHaveText = False
        End If

        ' Enable or disable the button based on the condition
        ButtonSignUp.Enabled = allTextBoxesHaveText
    End Sub

    Private Function GenerateCustomerId() As String
        Dim CustomerID As Integer

        Dim VStr As String
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader

        Try
            VStr = "SELECT CUSTOMER_ID FROM CUSTOMER ORDER BY CUSTOMER_ID DESC LIMIT 1"
            VCmd = New DB2Command(VStr, DBConn)
            VRdr = VCmd.ExecuteReader()

            If VRdr.HasRows Then
                VRdr.Read()
                CustomerID = VRdr.GetString(0) + 1
            Else
                CustomerID = 10000

            End If

            VRdr.Close()
        Catch ex As Exception
            ' Handle the exception here
        End Try

        Return CustomerID
    End Function

    Private Sub TBPassword_TextChanged(sender As Object, e As EventArgs) Handles TBPassword.TextChanged

        Dim allTextBoxesHaveText As Boolean = True

        ' Check if any of the TextBoxes are empty
        If String.IsNullOrWhiteSpace(TBFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(TBLastName.Text) OrElse
           String.IsNullOrWhiteSpace(TBEmail.Text) OrElse
           String.IsNullOrWhiteSpace(TBPassword.Text) Then
            allTextBoxesHaveText = False
        End If

        ' Enable or disable the button based on the condition
        ButtonSignUp.Enabled = allTextBoxesHaveText
    End Sub

    Private Sub TBLastName_TextChanged(sender As Object, e As EventArgs) Handles TBLastName.TextChanged
        Dim allTextBoxesHaveText As Boolean = True

        ' Check if any of the TextBoxes are empty
        If String.IsNullOrWhiteSpace(TBFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(TBLastName.Text) OrElse
           String.IsNullOrWhiteSpace(TBEmail.Text) OrElse
           String.IsNullOrWhiteSpace(TBPassword.Text) Then
            allTextBoxesHaveText = False
        End If

        ' Enable or disable the button based on the condition
        ButtonSignUp.Enabled = allTextBoxesHaveText
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub ButtonSignUp_Click(sender As Object, e As EventArgs) Handles ButtonSignUp.Click

        First_Name = TBFirstName.Text
        Last_Name = TBLastName.Text
        Email = TBEmail.Text
        Password = TBPassword.Text
        DoB = DateTime.Parse(DateDOB.Text)
        Age = DateTime.Now.Year - DoB.Year


        Dim VCommand As DB2Command '

        If DateTime.Now.Month < DoB.Month OrElse (DateTime.Now.Month = DoB.Month AndAlso DateTime.Now.Day < DoB.Day) Then
            Age -= 1
        End If

        If Age < 18 Then
            MsgBox("You have to be 18 years old or above to proceed.")
            Me.Close()
            FormLogin.Show()
            Exit Sub
        End If

        If Password.Length < 8 Or Password.Length > 15 Then
            MsgBox("Password must be between 8 and 15 characters long.")
            TBPassword.Focus()
            Exit Sub
        End If

        Dim tempCustID As Integer = GenerateCustomerId()


        VBQuery = "INSERT INTO customer (CUSTOMER_ID, LAST_NAME, FIRST_NAME, DATE_OF_BIRTH, AGE, EMAIL, PASSWORD) VALUES ('" & tempCustID & "', '" & Last_Name & "', '" & First_Name & "', '" & DoB.ToString("yyyy-MM-dd") & "', " & Age & ", '" & Email & "', '" & Password & "')"

        VCommand = New DB2Command(VBQuery, DBConn)
        VCommand.ExecuteNonQuery()

        MsgBox("Successfully signed up!")
        Me.Hide()
        FormLogin.Show()


    End Sub

    Private Sub LinkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLogin.LinkClicked
        Me.Close()
        FormLogin.Show()
    End Sub

    Private Sub LinkLogin_MouseHover(sender As Object, e As EventArgs) Handles LinkLogin.MouseHover
        LinkLogin.LinkColor = Color.Gray

    End Sub

    Private Sub LabelSignUP_MouseLeave(sender As Object, e As EventArgs) Handles LinkLogin.MouseLeave
        LinkLogin.LinkColor = Color.Black
    End Sub
End Class
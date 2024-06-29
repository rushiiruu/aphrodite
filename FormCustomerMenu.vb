Imports IBM.Data.DB2
Public Class FormCustomerMenu
    Private conn As Common.DbConnection

    Private Sub FormCustomerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New DB2Connection("server=localhost;database=aphrdite;" + "uid=db2admin;password=db2admin;")
        conn.Open()

        Dim query As String = "SELECT first_name, last_name FROM customer where customer_id='" & SessionID.SessionID & "'"
        Dim cmd As New DB2Command(query, conn)

        Dim reader As DB2DataReader = cmd.ExecuteReader()


        If reader.HasRows Then
            reader.Read()

            Dim Name = reader.GetString(0) + " " + reader.GetString(1) + "!"

            LabelWelcome.Text = "Welcome, " + Name

        End If

    End Sub

    Private Sub ButtonShop_Click(sender As Object, e As EventArgs) Handles ButtonShop.Click
        FormProductList.Show()
        Me.Close()
    End Sub

    Private Sub ButtonShop_MouseHover(sender As Object, e As EventArgs) Handles ButtonShop.MouseHover
        ButtonShop.ForeColor = Color.Black
        ButtonShop.BackColor = Color.White
    End Sub

    Private Sub ButtonShop_MouseLeave(sender As Object, e As EventArgs) Handles ButtonShop.MouseLeave
        ButtonShop.ForeColor = Color.White
        ButtonShop.BackColor = Color.Black
    End Sub

    Private Sub ButtonOrderHistory_Click(sender As Object, e As EventArgs) Handles ButtonOrderHistory.Click

        Me.Close()
        FormOrderHistory.Show()

    End Sub


    Private Sub ButtonSignOut_Click(sender As Object, e As EventArgs) Handles ButtonSignOut.Click

        FormLogin.Show()
        SessionID.SessionID = 0
        Me.Close()
    End Sub




    Private Sub ButtonOrderConfirm_Click(sender As Object, e As EventArgs) Handles ButtonOrderConfirm.Click
        FormCustomerMerchandise.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonOrderConfirm_MouseHover(sender As Object, e As EventArgs) Handles ButtonOrderConfirm.MouseHover
        ButtonSignOut.ForeColor = Color.White
        ButtonSignOut.BackColor = Color.Black
    End Sub

    Private Sub ButtonOrderConfirm_MouseLeave(sender As Object, e As EventArgs) Handles ButtonOrderConfirm.MouseLeave
        ButtonOrderConfirm.ForeColor = Color.Black
        ButtonOrderConfirm.BackColor = Color.White
    End Sub

End Class
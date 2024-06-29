Imports IBM.Data.DB2

Public Class FormEmployeeMenu

    Private conn As Common.DbConnection

    Private Sub FormEmployeeMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn = New DB2Connection("server=localhost;database=aphrdite;uid=db2admin;password=db2admin;")
            conn.Open()

            Dim query As String = "SELECT first_name, last_name FROM employee WHERE employee_id='" & SessionID.SessionID & "'"
            Using cmd As New DB2Command(query, conn)
                Using reader As DB2DataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        Dim name As String = reader.GetString(0) & " " & reader.GetString(1) & "!"
                        LabelWelcome.Text = "Welcome, " & name
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try

    End Sub


    Private Sub TransDelivery_Click(sender As Object, e As EventArgs) Handles TransDelivery.Click

        FormEmployeeTransferDelivery.Show()
        Me.Hide()

    End Sub

    Private Sub ButtonOrderHistory_Click(sender As Object, e As EventArgs) Handles ButtonOrderHistory.Click
        FormOrderList.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonOrderHistory_MouseHover(sender As Object, e As EventArgs) Handles ButtonOrderHistory.MouseHover
        ButtonOrderHistory.ForeColor = Color.White
        ButtonOrderHistory.BackColor = Color.Black
    End Sub

    Private Sub ButtonOrderHistory_MouseLeave(sender As Object, e As EventArgs)
        ButtonOrderHistory.ForeColor = Color.Black
        ButtonOrderHistory.BackColor = Color.White
    End Sub

    Private Sub PrepOrder_MouseHover(sender As Object, e As EventArgs) Handles PrepOrder.MouseHover
        PrepOrder.ForeColor = Color.Black
        PrepOrder.BackColor = Color.White
    End Sub

    Private Sub PrepOrder_MouseLeave(sender As Object, e As EventArgs) Handles PrepOrder.MouseLeave
        PrepOrder.ForeColor = Color.White
        PrepOrder.BackColor = Color.Black
    End Sub

    Private Sub TransDelivery_MouseHover(sender As Object, e As EventArgs) Handles TransDelivery.MouseHover
        TransDelivery.ForeColor = Color.Black
        TransDelivery.BackColor = Color.White
    End Sub

    Private Sub TransDelivery_MouseLeave(sender As Object, e As EventArgs) Handles TransDelivery.MouseLeave
        TransDelivery.ForeColor = Color.White
        TransDelivery.BackColor = Color.Black
    End Sub

    Private Sub Merch_MouseHover(sender As Object, e As EventArgs) Handles Merch.MouseHover
        Merch.ForeColor = Color.Black
        Merch.BackColor = Color.White
    End Sub

    Private Sub Merch_MouseLeave(sender As Object, e As EventArgs) Handles Merch.MouseLeave
        Merch.ForeColor = Color.White
        Merch.BackColor = Color.Black
    End Sub

    Private Sub ButtonSO_Click(sender As Object, e As EventArgs)
        FormLogin.Show()
        SessionID.SessionID = 0
        Me.Close()
    End Sub

    Private Sub ButtonSO_MouseHover(sender As Object, e As EventArgs) Handles ButtonSO.MouseHover
        ButtonSO.ForeColor = Color.White
        ButtonSO.BackColor = Color.Black
    End Sub

    Private Sub ButtonSO_MouseLeave(sender As Object, e As EventArgs) Handles ButtonSO.MouseLeave
        ButtonSO.ForeColor = Color.Black
        ButtonSO.BackColor = Color.White
    End Sub

    Private Sub Merch_Click_1(sender As Object, e As EventArgs) Handles Merch.Click
        FormEmployeeMerchandise.Show()
        Me.Hide()
    End Sub

    Private Sub PrepOrder_Click_1(sender As Object, e As EventArgs) Handles PrepOrder.Click
        FormEmployeePrepareOrder.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonOrderHistory_Click_1(sender As Object, e As EventArgs) Handles ButtonOrderHistory.Click

    End Sub

    Private Sub TransDelivery_Click_1(sender As Object, e As EventArgs) Handles TransDelivery.Click

    End Sub

    Private Sub ButtonSO_Click_1(sender As Object, e As EventArgs) Handles ButtonSO.Click
        FormLogin.Show()
        SessionID.SessionID = 0
        Me.Close()
    End Sub
End Class
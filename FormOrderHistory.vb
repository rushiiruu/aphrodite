Imports IBM.Data.DB2

Public Class FormOrderHistory
    Private conn As Common.DbConnection
    Private toolTip As New ToolTip()

    Private Sub FormOrderHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toolTip.SetToolTip(Me.GoBack, "Go back to the previous page")
        Dim conn As DB2Connection = Nothing

        Try
            conn = New DB2Connection("server=localhost;database=aphrdite;uid=db2admin;password=db2admin;")
            conn.Open()

            ' First query: Order history
            Dim orderQuery As String = "SELECT order.orno, order.total_price, branch.country, order.date_purchased, order.status FROM order INNER JOIN branch ON order.order_branch = branch.branch_id WHERE customer_id='" & SessionID.SessionID & "' ORDER BY orno DESC"
            Using orderCmd As New DB2Command(orderQuery, conn)
                Using orderReader As DB2DataReader = orderCmd.ExecuteReader()
                    If orderReader.HasRows Then
                        With Me.DGVOrderHistory
                            .ColumnCount = 5
                            .Columns(0).Name = "Order No"
                            .Columns(1).Name = "Total Price"
                            .Columns(2).Name = "Order Branch"
                            .Columns(3).Name = "Date Purchased"
                            .Columns(4).Name = "Status"
                        End With

                        While orderReader.Read()
                            Dim row As String() = {
                                orderReader.GetString(0),
                                orderReader.GetString(1),
                                orderReader.GetString(2),
                                orderReader.GetString(3),
                                orderReader.GetString(4)
                            }
                            Me.DGVOrderHistory.Rows.Add(row)
                        End While
                    End If
                End Using
            End Using

            ' Second query: Customer name
            Dim customerQuery As String = "SELECT first_name, last_name FROM customer WHERE customer_id='" & SessionID.SessionID & "'"
            Using customerCmd As New DB2Command(customerQuery, conn)
                Using customerReader As DB2DataReader = customerCmd.ExecuteReader()
                    If customerReader.HasRows Then
                        customerReader.Read()
                        Dim name As String = customerReader.GetString(0) + " " + customerReader.GetString(1) + "!"
                        LabelWelcomeHistory.Text = "Welcome, " + name
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        FormCustomerMenu.Show()
    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.ForeColor = Color.Gray
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Black
    End Sub

    Private Sub ButtonShop_Click(sender As Object, e As EventArgs) Handles ButtonShop.Click
        FormProductList.Show()
        Me.Close()
    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Label2.ForeColor = Color.Gray
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Black
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        Me.Close()
        FormCustomerMenu.Show()
    End Sub

    Private Sub ButtonSignOut_Click(sender As Object, e As EventArgs) Handles ButtonSignOut.Click
        FormLogin.Show()
        SessionID.SessionID = 0
        Me.Close()
    End Sub

End Class
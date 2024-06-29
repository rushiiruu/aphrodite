Imports IBM.Data.DB2
Public Class FormEmployeePrepareOrder

    Private conn As Common.DbConnection
    Private OrderID As Integer
    Private toolTip As New ToolTip()

    Private Sub FormEmployeePrepareOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        ButtonPrepare.Enabled = False
        toolTip.SetToolTip(Me.GoBack, "Go back to the previous page")
        Try
            conn = New DB2Connection("server=localhost;database=aphrdite;uid=db2admin;password=db2admin;")
            conn.Open()

            getOrders()
            Dim query As String = "SELECT first_name, last_name FROM employee WHERE employee_id='" & SessionID.SessionID & "'"
            Using cmd As New DB2Command(query, conn)
                Using reader As DB2DataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        Dim name As String = reader.GetString(0) & " " & reader.GetString(1) & "!"
                        LabelWelcomeMerch.Text = "Welcome, " & name
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn IsNot Nothing Then
            End If
        End Try
    End Sub




    Private Function getOrders()
        Dim query As String = "SELECT ORNO, TOTAL_PRICE, DATE_PURCHASED, CUSTOMER_ID, STATUS FROM ORDER where order_branch = (SELECT BRANCH_ID FROM EMPLOYEE where employee_id = '" & SessionID.SessionID & "') and status = 'shipping'"


        Dim cmd As New DB2Command(query, conn)

        Dim reader As DB2DataReader = cmd.ExecuteReader()

        With Me.DGVOrderList
            .ColumnCount = 5
            .Columns(0).Name = "Order No"
            .Columns(1).Name = "Total Price"
            .Columns(2).Name = "Date Purchased"
            .Columns(3).Name = "Customer ID"
            .Columns(4).Name = "Status"
        End With
        If reader.HasRows Then

            While reader.Read()
                Dim Row = New String() {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)}
                Me.DGVOrderList.Rows.Add(Row)
            End While

        End If


        Return 0
    End Function


    Private Sub DGVTransferDelivery_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOrderList.CellClick
        ButtonPrepare.Enabled = True
        With Me.DGVOrderList.CurrentRow
            OrderID = .Cells(0).Value
        End With

    End Sub

    Private Sub ButtonPrepare_Click(sender As Object, e As EventArgs) Handles ButtonPrepare.Click
        Dim query As String = "UPDATE order SET status = 'ready for pickup' WHERE ORNo = '" & OrderID & "'"
        Dim cmd As New DB2Command(query, conn)
        cmd.ExecuteNonQuery()

        DGVOrderList.Rows.Clear()
        getOrders()

    End Sub

    Private Sub ButtonSignOut_Click(sender As Object, e As EventArgs) Handles ButtonSignOut.Click

        FormLogin.Show()
        SessionID.SessionID = 0
        Me.Close()
    End Sub

    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        Me.Close()
        FormEmployeeMenu.Show()
    End Sub

End Class
Imports IBM.Data.DB2
Public Class FormEmployeeMerchandise
    Private conn As Common.DbConnection
    Private total As Integer
    Private ORNo As Integer
    Private CustID As Integer
    Private toolTip As New ToolTip()

    Private Sub FormEmployeeMerchandise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonConfirm.Enabled = False
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
        Dim query As String = "SELECT ORNo, Total_Price, Date_Purchased, Customer_ID FROM order Where status = 'ready for pickup' and order_branch = ( SELECT Branch_ID from Employee Where employee_id = '" & SessionID.SessionID & "') "
        Dim cmd As New DB2Command(query, conn)
        Dim reader As DB2DataReader = cmd.ExecuteReader()


        With Me.DGVOrderList
            .ColumnCount = 4
            .Columns(0).Name = "Transfer Order ID"
            .Columns(1).Name = "Total Price"
            .Columns(2).Name = "Date Purchased"
            .Columns(3).Name = "Customer ID"
        End With

        While reader.Read()
            Dim Row = New String() {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)}
            Me.DGVOrderList.Rows.Add(Row)
        End While


        Return 0
    End Function

    Private Function GenerateID() As String
        Dim CustomerID As Integer

        Dim VStr As String
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader

        Try
            VStr = "SELECT merchandise_no FROM merchandise ORDER BY merchandise_no DESC LIMIT 1"
            VCmd = New DB2Command(VStr, conn)
            VRdr = VCmd.ExecuteReader()

            If VRdr.HasRows Then
                VRdr.Read()
                CustomerID = VRdr.GetString(0) + 1
            Else
                CustomerID = 1

            End If

            VRdr.Close()
        Catch ex As Exception
            ' Handle the exception here
        End Try

        Return CustomerID
    End Function

    Private Sub DGVTransferDelivery_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOrderList.CellClick
        ButtonConfirm.Enabled = True
        With Me.DGVOrderList.CurrentRow
            ORNo = .Cells(0).Value
            total = .Cells(1).Value
            CustID = .Cells(3).Value
        End With

    End Sub

    Private Sub ButtonConfirm_Click(sender As Object, e As EventArgs) Handles ButtonConfirm.Click
        Dim MerchNo = GenerateID()
        Dim Date_Received As Date = Date.Now()

        Dim Query As String = "INSERT INTO merchandise VALUES ('" & MerchNo & "', '" & total & "', '" & Date_Received.ToString("MM/dd/yyyy") & "', '" & ORNo & "', '" & SessionID.SessionID & "', '" & CustID & "')"
        Dim cmd As New DB2Command(Query, conn)
        cmd.ExecuteNonQuery()

        Query = "UPDATE payment set dateofpayment = '" & Date_Received.ToString("MM/dd/yyyy") & "', amountpaid = '" & total & "', CUSTOMERID = '" & CustID & "' , Employeeid = '" & SessionID.SessionID & "' WHERE PAYMENTMETHOD = 'Face-to-Face' "
        cmd.CommandText = Query
        cmd.ExecuteNonQuery()

        Query = "UPDATE order SET status = 'claimed' WHERE ORNo = '" & ORNo & "'"
        cmd.CommandText = Query
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
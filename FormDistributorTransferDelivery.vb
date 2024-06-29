Imports IBM.Data.DB2
Public Class FormDistributorTransferDelivery

    Private transfer_id As Integer
    Private conn As Common.DbConnection
    Private toolTip As New ToolTip()

    Private Sub FormDistributorTransferDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ButtonConfirmDelivery.Enabled = False

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
        Dim query As String = "SELECT t1.transfer_order_id, t1.date_requested, t1.status, b.country FROM transfer_order t1 JOIN employee e on t1.branch_employee_id = e.employee_id JOIN branch b on e.branch_id = b.branch_id WHERE t1.status = 'pending' ORDER BY t1.transfer_order_id ASC"


        Dim cmd As New DB2Command(query, conn)

        Dim reader As DB2DataReader = cmd.ExecuteReader()


        With Me.DGVTransferDelivery
            .ColumnCount = 4
            .Columns(0).Name = "Transfer Order ID"
            .Columns(1).Name = "Date Requested"
            .Columns(2).Name = "Status"
            .Columns(3).Name = "Branch"
        End With

        While reader.Read()
            Dim Row = New String() {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)}
            Me.DGVTransferDelivery.Rows.Add(Row)
        End While

        Return 0
    End Function

    Private Sub ButtonConfirmDelivery_Click(sender As Object, e As EventArgs) Handles ButtonConfirmDelivery.Click

        '' Update Status
        Dim query As String = "UPDATE transfer_order SET status = 'delivered' WHERE transfer_order_id = '" & transfer_id & "'"
        Dim cmd As New DB2Command(query, conn)
        cmd.ExecuteNonQuery()


        '' Create new transfer delivery
        Dim ID As Integer = generateTransferDeliveryID()
        Dim DateOfDelivery As Date = Date.Now()



        query = "INSERT INTO transfer_delivery (TRANSFER_Delivery_ID, DATE_OF_DELIVERY, TRANSFER_ORDER_ID, DISTRIBUTOR_EMP_ID) values('" & ID & "', '" & DateOfDelivery.ToString("MM/dd/yyyy") & "','" & transfer_id & "','" & SessionID.SessionID & "')"
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        DGVTransferDelivery.Rows.Clear()
        getOrders()
    End Sub


    Private Sub DGVTransferDelivery_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTransferDelivery.CellClick
        ButtonConfirmDelivery.Enabled = True

        With Me.DGVTransferDelivery.CurrentRow
            transfer_id = .Cells(0).Value
        End With
    End Sub

    Private Function generateTransferDeliveryID()
        Dim TransferDeliveryID As Integer

        Dim VStr As String
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader

        Try
            VStr = "SELECT transfer_delivery_id FROM transfer_delivery ORDER BY transfer_delivery_id DESC LIMIT 1"
            VCmd = New DB2Command(VStr, conn)
            VRdr = VCmd.ExecuteReader()

            If VRdr.HasRows Then
                VRdr.Read()
                TransferDeliveryID = VRdr.GetString(0) + 1
            Else
                TransferDeliveryID = 100

            End If

            VRdr.Close()
        Catch ex As Exception
            ' Handle the exception here
        End Try

        Return TransferDeliveryID
    End Function


    Private Sub ButtonSignOut_Click(sender As Object, e As EventArgs) Handles ButtonSignOut.Click
        FormLogin.Show()
        SessionID.SessionID = 0
        Me.Close()
    End Sub

    Private Sub GoBack_Click(sender As Object, e As EventArgs)
        Me.Close()
        FormEmployeeMenu.Show()
    End Sub


End Class
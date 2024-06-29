Imports IBM.Data.DB2
Public Class FormEmployeeTransferDelivery
    Private transfer_id As Integer
    Private transfer_order_id As Integer
    Private conn As DB2Connection
    Private toolTip As New ToolTip()

    Private Sub FormEmployeeTransferDelivery_Load(sender As Object, e As EventArgs) Handles Me.Load
        ButtonReceiveDelivery.Enabled = False
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


    Private Sub ButtonReceiveDelivery_Click(sender As Object, e As EventArgs) Handles ButtonReceiveDelivery.Click

        ''Update transfer order
        Dim query As String = "UPDATE transfer_order SET status = 'received' WHERE transfer_order_id = '" & transfer_order_id & "'"
        Dim cmd As New DB2Command(query, conn)
        cmd.ExecuteNonQuery()

        '' Update transfer delivery
        query = "UPDATE transfer_delivery SET Branch_emp_id = '" & SessionID.SessionID & "' WHERE transfer_order_id = '" & transfer_order_id & "'"
        Dim transferCMD As New DB2Command(query, conn)
        transferCMD.ExecuteNonQuery()

        DGVTransferDelivery.Rows.Clear()
        getOrders()

    End Sub

    Private Sub DGVTransferDelivery_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTransferDelivery.CellClick
        ButtonReceiveDelivery.Enabled = True
        With Me.DGVTransferDelivery.CurrentRow
            transfer_id = .Cells(0).Value
            transfer_order_id = .Cells(2).Value
        End With

    End Sub

    Private Function getOrders()
        Dim query As String = "SELECT td.transfer_delivery_id, td.date_of_delivery,td.transfer_order_id,td.distributor_emp_id FROM transfer_delivery td JOIN transfer_order to on td.transfer_order_id = to.transfer_order_id where td.branch_emp_id IS NULL AND (select branch_id from employee where employee_id = to.branch_employee_id) = (select branch_id from employee where employee_id = '" & SessionID.SessionID & "')"
        Dim cmd As New DB2Command(query, conn)

        Dim reader As DB2DataReader = cmd.ExecuteReader()

        With Me.DGVTransferDelivery
            .ColumnCount = 4
            .Columns(0).Name = "Transfer Delivery ID"
            .Columns(1).Name = "Date of Delivery"
            .Columns(2).Name = "Transfer Order ID"
            .Columns(3).Name = "Distributor Employee ID"
        End With

        While reader.Read()
            Dim Row = New String() {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)}
            Me.DGVTransferDelivery.Rows.Add(Row)
        End While




        Return 0
    End Function

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
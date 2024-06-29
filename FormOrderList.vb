Imports IBM.Data.DB2

Public Class FormOrderList
    Private conn As DB2Connection
    Private OrNo As Integer

    Private Sub FormOrderList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ButtonApprove.Enabled = False

        Try
            conn = New DB2Connection("server=localhost;database=aphrdite;" + "uid=db2admin;password=db2admin;")
            conn.Open()
            With Me.DGVOrderList
                .ColumnCount = 5
                .Columns(0).Name = "Order No"
                .Columns(1).Name = "Total Price"
                .Columns(2).Name = "Date Purchased"
                .Columns(3).Name = "Customer ID"
                .Columns(4).Name = "Status"
            End With

            getOrders()



            With Me.DGVProductStockList
                .ColumnCount = 3
                .Columns(0).Name = "Product ID"
                .Columns(1).Name = "Product Name"
                .Columns(2).Name = "Product Stock"
            End With
            Me.DGVProductStockList.Columns("Product Name").Width = 250

            With Me.DGVProductItem
                .ColumnCount = 3
                .Columns(0).Name = "Quantity"
                .Columns(1).Name = "Product ID"
                .Columns(2).Name = "Order No"
            End With



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub




    Private Sub ButtonApprove_Click(sender As Object, e As EventArgs) Handles ButtonApprove.Click

        Dim query As String = "UPDATE order SET status = 'shipping' WHERE OrNo = '" & OrNo & "'"
        Dim cmd As New DB2Command(query, conn)
        cmd.ExecuteNonQuery()

        Dim dateRequested As Date = Date.Now()


        Dim tempTransferOrderID As Integer = generateTransferOrderID()

        query = "INSERT INTO transfer_order (TRANSFER_ORDER_ID, DATE_REQUESTED, BRANCH_EMPLOYEE_ID) values('" & tempTransferOrderID & "', '" & dateRequested.ToString("MM/dd/yyyy") & "','" & SessionID.SessionID & "')"
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        Try
            For Each row As DataGridViewRow In DGVProductItem.Rows
                If row.Cells(0).Value IsNot Nothing Then

                    Dim Quantity As Integer = row.Cells(0).Value
                    Dim Prod_ID As Integer = row.Cells(1).Value

                    query = "INSERT INTO transfer_item (Quantity, Product_ID, transfer_order_id ) VALUES ('" & Quantity & "', '" & Prod_ID & "', '" & tempTransferOrderID & "')"
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()


                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

        query = "UPDATE payment SET employeeid = '" & SessionID.SessionID & "' WHERE OrNo = '" & OrNo & "' and paymentmethod = 'Online'"
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        DGVOrderList.Rows.Clear()
        reset()
        getOrders()

    End Sub

    Private isProductItemPopulated As Boolean = False
    Private isProductStockListPopulated As Boolean = False

    Private Sub DGVOrderList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOrderList.CellClick

        ButtonApprove.Enabled = True
        If Not isProductItemPopulated Then

            With Me.DGVOrderList.CurrentRow
                OrNo = .Cells(0).Value
            End With


            Dim query As String = "SELECT quantity, product_id, orno from product_item where orno = '" & OrNo & "'"
            Dim cmd As New DB2Command(query, conn)
            Dim reader As DB2DataReader = cmd.ExecuteReader()

            Me.DGVProductItem.Rows.Clear()

            While reader.Read()
                Dim Row As String() = {reader.GetString(0), reader.GetString(1), reader.GetString(2)}
                Me.DGVProductItem.Rows.Add(Row)
            End While

            reader.Close()
            isProductItemPopulated = True
        End If

        If Not isProductStockListPopulated Then
            With Me.DGVOrderList.CurrentRow
                OrNo = .Cells(0).Value
            End With

            Dim query As String = "SELECT product_id, prod_name, prod_stock from product where product_id in (SELECT product_id from product_item where orno = '" & OrNo & "')"
            Dim cmd As New DB2Command(query, conn)
            Dim reader As DB2DataReader = cmd.ExecuteReader()

            Me.DGVProductStockList.Rows.Clear()

            While reader.Read()
                Dim Row As String() = {reader.GetString(0), reader.GetString(1), reader.GetString(2)}
                Me.DGVProductStockList.Rows.Add(Row)
            End While

            reader.Close()
            isProductStockListPopulated = True

        End If






    End Sub


    Private Function getOrders()

        Dim Vstr As String = "SELECT ORNO, TOTAL_PRICE, DATE_PURCHASED, CUSTOMER_ID, STATUS FROM ORDER where order_branch = (SELECT BRANCH_ID FROM EMPLOYEE where employee_id = '" & SessionID.SessionID & "') and status = 'pending'"
        Dim VRow As String()
        Dim VCmd As DB2Command
        Dim VRd As DB2DataReader

        VCmd = New DB2Command(Vstr, conn)
        VRd = VCmd.ExecuteReader
        While VRd.Read
            VRow = New String() {VRd.GetString(0), VRd.GetString(1), VRd.GetString(2), VRd.GetString(3), VRd.GetString(4)}
            Me.DGVOrderList.Rows.Add(VRow)
        End While
        VRd.Close()

        Return 0
    End Function

    Private Function reset()
        Me.DGVProductItem.Rows.Clear()
        Me.DGVProductStockList.Rows.Clear()
        isProductStockListPopulated = False
        isProductItemPopulated = False

        Return 0
    End Function

    Private Function generateTransferOrderID()
        Dim TransferOrderID As Integer

        Dim VStr As String
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader

        Try
            VStr = "SELECT transfer_order_id FROM transfer_order ORDER BY transfer_order_id DESC LIMIT 1"
            VCmd = New DB2Command(VStr, conn)
            VRdr = VCmd.ExecuteReader()

            If VRdr.HasRows Then
                VRdr.Read()
                TransferOrderID = VRdr.GetString(0) + 1
            Else
                TransferOrderID = 1000

            End If

            VRdr.Close()
        Catch ex As Exception
            ' Handle the exception here
        End Try

        Return TransferOrderID
    End Function

    Private Sub ButtonSignOut_Click(sender As Object, e As EventArgs) Handles ButtonSignOut.Click
        FormLogin.Show()
        SessionID.SessionID = 0
        Me.Close()
    End Sub

    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        FormEmployeeMenu.Show()
        Me.Close()
    End Sub
End Class
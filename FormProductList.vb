Imports IBM.Data.DB2

Public Class FormProductList
    Private conn As DB2Connection

    Public sum As Integer
    Public BranchID As Integer
    Private ProductID As Integer
    Private toolTip As New ToolTip()

    Private Sub FormProductList_Load(sender As Object, e As EventArgs) Handles Me.Load
        toolTip.SetToolTip(Me.GoBack, "Go back to the previous page")

        ButtonCheckout.Enabled = False

        ButtonQuantity.Enabled = False

        Dim Vstr As String = "SELECT PRODUCT_ID, PROD_NAME, PROD_PRICE, PROD_TYPE, PROD_MATERIAL, PROD_STOCK, PROD_DESC from product"
        Dim VRow As String()
        Dim VCmd As DB2Command
        Dim VRd As DB2DataReader
        Try
            conn = New DB2Connection("server=localhost;database=aphrdite;" + "uid=db2admin;password=db2admin;")
            conn.Open()
            With Me.DGVProduct
                .ColumnCount = 7
                .Columns(0).Name = "Product ID"
                .Columns(1).Name = "Product Name"
                .Columns(2).Name = "Product Price"
                .Columns(3).Name = "Product Type"
                .Columns(4).Name = "Product Material"
                .Columns(5).Name = "Product Stock"
                .Columns(6).Name = "Product Description"
            End With
            Me.DGVProduct.Columns("Product Name").Width = 250
            Me.DGVProduct.Columns("Product Description").Width = 500
            VCmd = New DB2Command(Vstr, conn)
            VRd = VCmd.ExecuteReader
            While VRd.Read
                VRow = New String() {VRd.GetString(0), VRd.GetString(1), VRd.GetString(2), VRd.GetString(3), VRd.GetString(4), VRd.GetString(5), VRd.GetString(6)}
                Me.DGVProduct.Rows.Add(VRow)
            End While
            VRd.Close()


            With Me.DGVUserCart
                .ColumnCount = 5
                .Columns(0).Name = "Product ID"
                .Columns(1).Name = "Product Name"
                .Columns(2).Name = "Price"
                .Columns(3).Name = "Quantity"
                .Columns(4).Name = "Subtotal"
            End With
            Me.DGVUserCart.Columns("Product Name").Width = 150
            Me.DGVUserCart.Columns("Product ID").Width = 0

            Dim query As String = "SELECT country from Branch"
            Dim cmd As New DB2Command(query, conn)
            Dim reader As DB2DataReader = cmd.ExecuteReader()

            While reader.Read()
                DropdownBranchLocation.Items.Add(reader.GetString(0))
            End While
            reader.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub DGVProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProduct.CellClick
        ButtonQuantity.Enabled = True

        With Me.DGVProduct.CurrentRow
            ProductID = .Cells(0).Value
            JewelryLabel.Text = .Cells(1).Value
            PriceLabel.Text = "$" + .Cells(2).Value
        End With

    End Sub



    Private Sub ButtonAddCart_Click(sender As Object, e As EventArgs) Handles ButtonAddCart.Click

        Dim VRow As String()

        Dim RowPrice = PriceLabel.Text ' multiply with quantity later'
        Dim RowQuantity = ButtonQuantity.Value

        'IF EXISTING ITEM, INCREMENT THE QUANTITY INSTEAD'
        Dim existingRow As DataGridViewRow = DGVUserCart.Rows.Cast(Of DataGridViewRow)().
                                        FirstOrDefault(Function(r) r.Cells(0).Value = ProductID)


        'temporarily store the stock of the item and check if it runs out'

        If existingRow Is Nothing Then
            ' Item does not exist in the cart, add a new row
            VRow = {ProductID, JewelryLabel.Text, RowPrice.Substring(1).ToString(), RowQuantity.ToString(), RowPrice.Substring(1) * RowQuantity}
            Me.DGVUserCart.Rows.Add(VRow)
        Else
            ' Item already exists in the cart, increment the quantity and update the total
            existingRow.Cells(3).Value = CInt(existingRow.Cells(3).Value) + RowQuantity
            existingRow.Cells(4).Value = CDec(existingRow.Cells(3).Value) * CInt(existingRow.Cells(2).Value)
        End If

        sum = 0

        For Each row As DataGridViewRow In DGVUserCart.Rows
            If row.Cells(4).Value IsNot Nothing AndAlso IsNumeric(row.Cells(4).Value) Then
                sum += CDec(row.Cells(4).Value)
            End If
        Next

        LabelTotalPrice.Text = "$" + sum.ToString()

        ButtonQuantity.Value = ButtonQuantity.Minimum

    End Sub


    Private Sub ButtonCheckout_Click(sender As Object, e As EventArgs) Handles ButtonCheckout.Click

        Dim tempOrNo As Integer = GenerateOrderNo()
        Dim tempCustID As Integer = SessionID.SessionID





        Dim date_purchased = Date.Now()
        ' fix date format
        Dim OrderQuery As String = "INSERT INTO order (ORNo, TOTAL_PRICE, DATE_PURCHASED, CUSTOMER_ID, ORDER_BRANCH) VALUES ('" & tempOrNo & "', '" & sum & "', '" & date_purchased.ToString("yyyy-MM-dd") & "', '" & tempCustID & "', " & BranchID & ")"
        Dim OrderCMD As New DB2Command(Orderquery, conn)
        OrderCMD.ExecuteNonQuery()


        Try
            For Each row As DataGridViewRow In DGVUserCart.Rows
                If row.Cells(0).Value IsNot Nothing Then

                    Dim Quantity As Integer = row.Cells(3).Value
                    Dim Prod_ID As Integer = row.Cells(0).Value

                    Dim Query As String = "INSERT INTO product_item (Quantity, Product_ID, ORNo) VALUES ('" & Quantity & "', '" & Prod_ID & "', '" & tempOrNo & "')"
                    Dim cmd As New DB2Command(Query, conn)
                    cmd.ExecuteNonQuery()

                    OrderQuery = "UPDATE product SET prod_stock = prod_stock - '" & Quantity & "' where product_id = '" & Prod_ID & "'"
                    OrderCMD.CommandText = OrderQuery
                    OrderCMD.ExecuteNonQuery()

                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try



        FormUserPayment.Show()

    End Sub

    Private Function GenerateOrderNo() As String
        Dim CustomerID As Integer

        Dim VStr As String
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader

        Try
            VStr = "SELECT orno FROM order ORDER BY orno DESC LIMIT 1"
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

    Private Sub JewelryLabel_Click(sender As Object, e As EventArgs) Handles JewelryLabel.Click

    End Sub

    Private Sub DropdownBranchLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropdownBranchLocation.SelectedIndexChanged

        Dim country = DropdownBranchLocation.SelectedItem.ToString()

        Dim query As String = "SELECT branch_id from Branch where country = '" & country & "'"
        Dim cmd As New DB2Command(query, conn)
        Dim reader As DB2DataReader = cmd.ExecuteReader()

        While reader.Read
            BranchID = reader.GetString(0)
        End While

        ButtonCheckout.Enabled = (DGVUserCart.Rows.Count > 0 AndAlso BranchID <> 0)
    End Sub

    Private Sub ButtonBackMenu_Click(sender As Object, e As EventArgs)

        Me.Close()
        FormCustomerMenu.Show()

    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        If DGVUserCart.SelectedRows.Count > 0 Then
            DGVUserCart.Rows.Remove(DGVUserCart.SelectedRows(0))
        End If
        sum = 0
        For Each row As DataGridViewRow In DGVUserCart.Rows
            If row.Cells(4).Value IsNot Nothing AndAlso IsNumeric(row.Cells(4).Value) Then
                sum += CDec(row.Cells(4).Value)
            End If
        Next

        LabelTotalPrice.Text = "$" + sum.ToString()
    End Sub

    Private Sub DGVUserCart_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUserCart.CellContentClick
        DGVUserCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub ButtonSignOut_Click(sender As Object, e As EventArgs) Handles ButtonSignOut.Click
        FormLogin.Show()
        SessionID.SessionID = 0
        Me.Close()
    End Sub


    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        FormCustomerMenu.Show()
        SessionID.SessionID = 0
        Me.Close()
    End Sub

End Class
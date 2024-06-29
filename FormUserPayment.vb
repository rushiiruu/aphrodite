Imports IBM.Data.DB2
Public Class FormUserPayment

    Private type As Integer
    Private conn As Common.DbConnection

    Private Sub FormUserPayment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim Query As String

        Query = "DELETE FROM order WHERE ORNo = (SELECT ORNo FROM order ORDER BY ORNo DESC LIMIT 1)"
        Dim CMD As New DB2Command(Query, conn)
        CMD.ExecuteNonQuery()

    End Sub


    Private Sub FormUserPayment_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn = New DB2Connection("server=localhost;database=aphrdite;" + "uid=db2admin;password=db2admin;")
        conn.Open()

    End Sub


    Private Sub ButtonConfirm_Click(sender As Object, e As EventArgs) Handles ButtonConfirm.Click


        MsgBox("Your transaction is successful!")


        ' Redirect to user order history
        FormProductList.Close()
        Me.Hide()
        FormOrderHistory.Show()
        FormOrderHistory.DGVOrderHistory.Sort(FormOrderHistory.DGVOrderHistory.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        FormOrderHistory.DGVOrderHistory.Focus()

        ' Create payment



        Dim Query As String


        Dim tempCheckID As Integer = generateCheckID()
        Dim paymentType = DropdownPaymentMethod.SelectedItem.ToString()




        ' If online
        If (type = 0) Then

            Dim paymentDate = Date.Now()

            ' Get Order
            Query = "SELECT ORNo, total_price FROM order WHERE customer_ID='" & SessionID.SessionID & "' ORDER BY ORNo DESC LIMIT 1"
            Dim OrderCMD As New DB2Command(Query, conn)
            Dim reader As DB2DataReader = OrderCMD.ExecuteReader()

            reader.Read()
            Dim orderNo = reader.GetString(0)
            Dim orderTotal = reader.GetString(1)

            ' Create Payment
            Query = "INSERT INTO payment (checkID, paymentMethod, paymentType, AmountPaid, DateOfPayment, customerId, ORNo) VALUES ('" & tempCheckID & "', '" & RBOnline.Text & "', '" & paymentType & "', '" & orderTotal & "', '" & paymentDate.ToString("yyyy-MM-dd") & "', '" & SessionID.SessionID & "', '" & orderNo & "')"
            Dim cmd As New DB2Command(Query, conn)
            cmd.ExecuteNonQuery()

            ' If face-to-face
        ElseIf (type = 1) Then

            ' Get Order
            Query = "SELECT ORNo FROM order WHERE customer_ID='" & SessionID.SessionID & "' ORDER BY ORNo DESC LIMIT 1"
            Dim OrderCMD As New DB2Command(Query, conn)
            Dim reader As DB2DataReader = OrderCMD.ExecuteReader()

            reader.Read()
            Dim orderNo = reader.GetString(0)

            Query = "INSERT INTO payment (checkID, paymentMethod, paymentType, customerId, ORNo) VALUES ('" & tempCheckID & "',  'Face-to-Face', '" & paymentType & "','" & SessionID.SessionID & "', '" & orderNo & "')"
            Dim cmd As New DB2Command(Query, conn)
            cmd.ExecuteNonQuery()



        End If







    End Sub


    Private Sub RBOnline_CheckedChanged(sender As Object, e As EventArgs) Handles RBOnline.CheckedChanged
        type = 0

        DropdownPaymentMethod.Items.Clear()

        DropdownPaymentMethod.Items.Add("Credit")
        DropdownPaymentMethod.Items.Add("Bank Transfer")
    End Sub

    Private Sub RBFacetoFace_CheckedChanged(sender As Object, e As EventArgs) Handles RBFacetoFace.CheckedChanged
        type = 1

        DropdownPaymentMethod.Items.Clear()

        DropdownPaymentMethod.Items.Add("Cash")
        DropdownPaymentMethod.Items.Add("Credit")
        DropdownPaymentMethod.Items.Add("Bank Transfer")
    End Sub

    Private Function generateCheckID()
        Dim checkID As Integer

        Dim VStr As String
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader

        Try
            VStr = "SELECT checkID FROM payment ORDER BY checkID DESC LIMIT 1"
            VCmd = New DB2Command(VStr, conn)
            VRdr = VCmd.ExecuteReader()

            If VRdr.HasRows Then
                VRdr.Read()
                checkID = VRdr.GetString(0) + 1
            Else
                checkID = 10

            End If

            VRdr.Close()
        Catch ex As Exception
            ' Handle the exception here
        End Try

        Return checkID

    End Function
End Class
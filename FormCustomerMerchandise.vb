Imports IBM.Data.DB2

Public Class FormCustomerMerchandise
    Private conn As DB2Connection
    Private ORNo As Integer

    Private toolTip As New ToolTip()

    Private Sub FormCustomerMerchandise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonConfirm.Enabled = False
        toolTip.SetToolTip(Me.GoBack, "Go back to the previous page")
        Try
            conn = New DB2Connection("server=localhost;database=aphrdite;uid=db2admin;password=db2admin;")
            conn.Open()

            getOrders()

            Dim query As String = "SELECT first_name, last_name FROM customer WHERE customer_id='" & SessionID.SessionID & "'"
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
        Dim query As String = "SELECT ORNo, Total_Price, Date_Purchased FROM order Where status = 'claimed'"
        Dim cmd As New DB2Command(query, conn)
        Dim reader As DB2DataReader = cmd.ExecuteReader()

        If reader.HasRows Then

            With Me.DGVOrderList
                .ColumnCount = 3
                .Columns(0).Name = "Order ID"
                .Columns(1).Name = "Total Price"
                .Columns(2).Name = "Date Purchased"

            End With

            While reader.Read()
                Dim Row = New String() {reader.GetString(0), reader.GetString(1), reader.GetString(2)}
                Me.DGVOrderList.Rows.Add(Row)
            End While

        End If


        Return 0
    End Function

    Private Sub DGVTransferDelivery_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOrderList.CellClick
        ButtonConfirm.Enabled = True
        With Me.DGVOrderList.CurrentRow
            ORNo = .Cells(0).Value
        End With

    End Sub

    Private Sub ButtonConfirm_Click(sender As Object, e As EventArgs) Handles ButtonConfirm.Click
        Dim Query As String = "UPDATE order SET status = 'received' WHERE ORNo = '" & ORNo & "'"
        Dim cmd As New DB2Command(Query, conn)
        cmd.ExecuteNonQuery()


        DGVOrderList.Rows.Clear()
        getOrders()

    End Sub

    Private Sub ButtonSignOut_Click(sender As Object, e As EventArgs) Handles ButtonSignOut.Click
        FormLogin.Show()
        SessionID.SessionID = 0
        Me.Close()
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub ButtonOrderHistory_Click(sender As Object, e As EventArgs) Handles ButtonOrderHistory.Click
        Me.Close()
        FormOrderHistory.Show()
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        Me.Close()
        FormCustomerMenu.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
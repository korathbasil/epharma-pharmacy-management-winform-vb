Imports MySql.Data.MySqlClient

Module SalesModule
    Public Sub CheckoutSale(total As Integer)
        Dim Cmd = New MySqlCommand("insert into sales (amount) values (@Total)", Form1.DbConnection)
        Cmd.Parameters.AddWithValue("@Total", total)

        Try
            Form1.DbConnection.Open()
            Cmd.ExecuteNonQuery()
            Form1.DbConnection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub
End Module

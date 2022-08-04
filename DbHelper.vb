Imports MySql.Data.MySqlClient

Module DbHelper
    Sub CreateTables()
        Dim UsersTableSchema = "create table if not exists users (id int not null auto_increment primary key, name varchar(25) not null, username varchar(25) not null, password varchar(20) not null, is_admin bool not null )"
        Dim MedicineTableSchema = "create table if not exists medicines (id int not null auto_increment primary key, name varchar(50) not null, formula varchar(25) not null, company varchar(25), price int, stock int)"
        Dim SalesTableSchema = "create table if not exists sales(id int not null auto_increment primary key,date datetime default now(), amount int not null)"
        Try
            Form1.DbConnection.Open()
            Dim cmd = New MySqlCommand(UsersTableSchema, Form1.DbConnection)
            Dim Cmd2 = New MySqlCommand(MedicineTableSchema, Form1.DbConnection)
            Dim Cmd3 = New MySqlCommand(SalesTableSchema, Form1.DbConnection)
            cmd.ExecuteNonQuery()
            Cmd2.ExecuteNonQuery()
            Cmd3.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
            Form1.DbConnection.Dispose()
        End Try
    End Sub
End Module

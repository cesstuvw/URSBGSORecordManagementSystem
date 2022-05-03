Imports MySql.Data.MySqlClient

Module ModuleDB
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Sub OpenCon()
        con.ConnectionString = My.Settings.ursbgso_dbConnectionString
        con.Open()
        cmd.Connection = con
    End Sub
End Module

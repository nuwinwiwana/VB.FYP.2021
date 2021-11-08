Imports System.Data.OleDb
Module dbconnection
    Public con As OleDbConnection = connect()
    Public cmd As New OleDbCommand
    Public sql As String
    Public result As Integer
    Public da As New OleDbDataAdapter
    Public dt As New DataTable

    Public Function connect() As OleDbConnection

        'Return New MySqlConnection("user id=root;server=192.168.254.1;persistsecurityinfo=True;database=dbtbi;SslMode=none")

        Return New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\enrollmentdb.accdb")

    End Function
End Module

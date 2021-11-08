Imports System.Data.OleDb

Public Class frmmanagestudent
    Public myConnToAccess As OleDbConnection
    Dim mySQLCommand As OleDbCommand
    Dim mySQLStrg As String
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection
    Private Sub frmmanagestudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutoFill("SELECT studid,Lastname from tblstudents", TextBox1)
        AutoFill("SELECT Subject from tblsubject", TextBox2)

        mySelectQuery("SELECT * from tblsub")
        LoadData(DataGridView1, "student")

        ' mySelectQuery("SELECT studid , Lastname & ' ' &  Firstname & ', ' & MI as Fullname from tblstudents where =" & TextBox1 .text & ")

        'fillcombo(ComboBox1, "Fullname", "studid")

        ' mySelectQuery("SELECT SubjectID , Subject from tblsubject")
        'fillcombo(ComboBox2, "Subject", "SubjectID")

        'mySelectQuery("SELECT * from tblsub")
        'LoadData(DataGridView1, "student")

        ' myConnToAccess = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\enrollmentdb.accdb")

        '    myConnToAccess = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Clive\Documents\Visual Studio 2008\clive projects\TableRecordsinCombobox\TableRecordsinCombobox\bin\Debug\Datalist.accdb")
        'myConnToAccess.Open()
        'ds = New DataSet
        'tables = ds.Tables
        'da = New OleDbDataAdapter("SELECT * from tblstudents", myConnToAccess)
        'da.Fill(ds, "tblstudents")
        'Dim view1 As New DataView(tables(0))
        'With ComboBox1
        '    .DataSource = ds.Tables("tblstudents")
        '    .DisplayMember = "Lastname"
        '    .ValueMember = "ID"
        '    .SelectedIndex = 0
        '    .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        '    .AutoCompleteSource = AutoCompleteSource.ListItems
        'End With

        'con.Open()

        'Try
        '    dbcmd = New OleDbCommand("SELECT * FROM tblsubject WHERE Lastname='" & ComboBox1.Text & "'", con)
        '    Dim DbReader As OleDbDataReader
        '    DbReader = dbcmd.ExecuteReader

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try


        'con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'con.Open()

        'Try
        '    dbcmd = New OleDbCommand("SELECT * FROM tblsubject WHERE Lastname='" & ComboBox1.Text & "'", con)
        '    Dim DbReader As OleDbDataReader
        '    DbReader = dbcmd.ExecuteReader

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try


        'con.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        mySelectQuery("SELECT Subject_Price from tblsubject")
        Dim Price = getsvalue()
        'Checkresult("add")
        myInsert("INSERT INTO tblsub(studid,Subject, Subject_Price) VALUES ( '" & TextBox1.Text & "', '" & TextBox2.Text & "', " & Price & " )")


        mySelectQuery("SELECT * from tblsub")
        LoadData(DataGridView1, "student")
        'mySelectQuery("SELECT * from tblsub WHERE studid='" & TextBox2.ToString & "'")
        'LoadData(DataGridView1, "student")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim SelectedRow = DataGridView1.SelectedRows(0).Cells(0).Value
        myDelete("DELETE * FROM tblsub WHERE ID=" & SelectedRow)
        mySelectQuery("SELECT * from tblsub")
        LoadData(DataGridView1, "student")

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' mySelectQuery("SELECT * from tblsub WHERE studid='" & ComboBox1.SelectedValue.ToString() & "'")
        ' LoadData(DataGridView1, "student")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        'mySelectQuery("SELECT studid  from tblstudents Where='" & TextBox1.Text & "'")


    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
       
    End Sub
End Class
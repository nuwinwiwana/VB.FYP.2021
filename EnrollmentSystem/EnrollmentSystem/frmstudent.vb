
Public Class frmstudent
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer
    Dim Fname As String
    Dim Lname As String
    Dim stud As Integer
    Dim table As New DataTable
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Me.Close()

        txtfname.Text = Nothing
        txtlname.Text = Nothing
        txtmname.Text = Nothing
        txtcnumber.Text = Nothing
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub frmstudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mySelectQuery("SELECT * from tblstudents")
        LoadData(DataGridView1, "student")
        Checkresult("ORAutoMax")
       
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim SelectedRow = DataGridView1.SelectedRows(0).Cells(0).Value
        myDelete("DELETE * FROM tblstudents WHERE id=" & SelectedRow)
         mySelectQuery("SELECT * from tblstudents")
        LoadData(DataGridView1, "student")
        Checkresult("delete")
        ' txtidno.Text = (txtidno.Text) - Val(1)

        txtfname.Text = Nothing
        txtlname.Text = Nothing
        txtmname.Text = Nothing
        txtcnumber.Text = Nothing
        txtadd.Text = Nothing
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        txtlname.Text = DataGridView1.CurrentRow.Cells("Lastname").Value.ToString()
        txtfname.Text = DataGridView1.CurrentRow.Cells("Firstname").Value.ToString()
        txtmname.Text = DataGridView1.CurrentRow.Cells("MI").Value.ToString()
        txtadd.Text = DataGridView1.CurrentRow.Cells("Address").Value.ToString()
        txtcnumber.Text = DataGridView1.CurrentRow.Cells("Cnumber").Value.ToString()

      
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SelectedRow = DataGridView1.SelectedRows(0).Cells(0).Value

        myUpdate("UPDATE tblstudents SET StudID='" & txtidno.Text & "',Lastname='" & txtlname.Text & "',Firstname='" & txtfname.Text & "',MI='" & txtmname.Text & "',Address='" & txtadd.Text & "',Cnumber='" & txtcnumber.Text & "' WHERE ID = " & SelectedRow)
        mySelectQuery("SELECT * from tblstudents")
        LoadData(DataGridView1, "student")
        Checkresult("delete")
        'Checkresult("ORAutoMax")

        txtfname.Text = Nothing
        txtlname.Text = Nothing
        txtmname.Text = Nothing
        txtcnumber.Text = Nothing
        txtadd.Text = Nothing
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'adding data sa database
        myInsert("INSERT INTO  tblstudents(StudID,Lastname,Firstname,MI,Address,Cnumber) VALUES ('" & txtidno.Text & "', '" & txtlname.Text & "','" & txtfname.Text & "', '" & txtmname.Text & "', '" & txtadd.Text & "','" & txtcnumber.Text & "'  )")
        txtidno.Text = (txtidno.Text) + Val(1)
        ' Checkresult("ORAutoMax")
        'Checkresult("add")
        'load yung data sa dataridview
        mySelectQuery("SELECT * from tblstudents")
        LoadData(DataGridView1, "student")

        txtfname.Text = Nothing
        txtlname.Text = Nothing
        txtmname.Text = Nothing
        txtcnumber.Text = Nothing
        txtadd.Text = Nothing
    End Sub
End Class
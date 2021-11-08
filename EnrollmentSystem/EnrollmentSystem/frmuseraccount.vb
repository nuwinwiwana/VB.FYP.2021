Public Class frmuseraccount

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ' mySelectQuery("SELECT Username,Password FROM tbluser WHERE Username =" & TextBox1.Text & " AND Password=" & TextBox2.Text & "")
        myInsert("INSERT INTO  tbluser(User_Username,User_Password) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "')")
        mySelectQuery("SELECT ID,User_Username,User_Password from tbluser")
        LoadData(DataGridView1, "student")
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing

    End Sub

    Private Sub frmuseraccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mySelectQuery("SELECT * from tbluser")

        LoadData(DataGridView1, "student")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim SelectedRow = DataGridView1.SelectedRows(0).Cells(0).Value
        myDelete("DELETE * FROM tbluser WHERE id=" & SelectedRow)
        mySelectQuery("SELECT * from tbluser")

        LoadData(DataGridView1, "student")
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SelectedRow = DataGridView1.SelectedRows(0).Cells(0).Value

        myUpdate("UPDATE tbluser SET User_Username='" & TextBox1.Text & "',User_Password='" & TextBox2.Text & "' WHERE ID =" & SelectedRow)
        mySelectQuery("SELECT * from tbluser")
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        TextBox1.Text = DataGridView1.CurrentRow.Cells("User_Username").Value.ToString()
        TextBox2.Text = DataGridView1.CurrentRow.Cells("User_Password").Value.ToString()
    End Sub

End Class
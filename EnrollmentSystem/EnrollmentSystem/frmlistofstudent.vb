Public Class frmlistofstudent

    Private Sub frmlistofstudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mySelectQuery("SELECT * from tblstudents")
        LoadData(DataGridView1, "student")
    End Sub
End Class
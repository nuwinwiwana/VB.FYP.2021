Imports System.Data.OleDb

Public Class FrmSubject
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        'save("INSERT INTO  tblsubject(Sub_Year) VALUES ('" & txtyr.Text & "' )")

        myInsert("INSERT INTO  tblsubject(Subject,Description,Unit,Sub_Year,Schedule,Subject_Price) VALUES ('" & txtsub.Text & "','" & txtdesc.Text & "','" & txtUnit.Text & "','" & txtyr.Text & "','" & txtSched.Text & "','" & txtprice.Text & "' )")
        mySelectQuery("SELECT * from tblsubject")
        LoadData(DataGridView1, "student")
        ' Checkresult("add")
        '
        'LoadData("SELECT * FROM tblsubject")
        txtsub.Text = Nothing
        txtdesc.Text = Nothing
        txtUnit.Text = Nothing
        txtyr.Text = Nothing
        txtSched.Text = Nothing

    End Sub

    Private Sub FrmSubject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mySelectQuery("SELECT * from tblsubject")
        LoadData(DataGridView1, "student")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim SelectedRow = DataGridView1.SelectedRows(0).Cells(0).Value
        myDelete("DELETE * FROM tblsubject WHERE SubjectID=" & SelectedRow)
        mySelectQuery("SELECT * from tblsubject")
        LoadData(DataGridView1, "student")
        'loaddata("SELECT * FROM tblsubject")
        txtsub.Text = Nothing
        txtdesc.Text = Nothing
        txtUnit.Text = Nothing
        txtyr.Text = Nothing
        txtSched.Text = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SelectedRow = DataGridView1.SelectedRows(0).Cells(0).Value

        myUpdate("UPDATE tblsubject SET Subject='" & txtsub.Text & "',Description='" & txtdesc.Text & "',Unit='" & txtUnit.Text & "',Sub_Year='" & txtyr.Text & "',Schedule='" & txtSched.Text & "',Subject_Price='" & txtprice.Text & "' WHERE SubjectID = " & SelectedRow)
        mySelectQuery("SELECT * from subject")
        LoadData(DataGridView1, "student")
        'loaddata("SELECT * FROM tblsubject")
        'Checkresult("update")
        txtsub.Text = Nothing
        txtdesc.Text = Nothing
        txtUnit.Text = Nothing
        txtyr.Text = Nothing
        txtSched.Text = Nothing
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtsub.Text = DataGridView1.CurrentRow.Cells("Subject").Value.ToString()
        txtdesc.Text = DataGridView1.CurrentRow.Cells("Description").Value.ToString()
        txtUnit.Text = DataGridView1.CurrentRow.Cells("Unit").Value.ToString()
        txtyr.Text = DataGridView1.CurrentRow.Cells("Sub_Year").Value.ToString()
        txtSched.Text = DataGridView1.CurrentRow.Cells("Schedule").Value.ToString()
    End Sub

   
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtsub.Text = Nothing
        txtdesc.Text = Nothing
        txtUnit.Text = Nothing
        txtyr.Text = Nothing
        txtSched.Text = Nothing
    End Sub
End Class
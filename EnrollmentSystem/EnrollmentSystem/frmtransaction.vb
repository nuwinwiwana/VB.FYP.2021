Public Class frmtransaction

    Private Sub frmtransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' mySelectQuery("SELECT DISTINCT studid, Subject FROM tblsub")
        ' fillcombo(cbboxstudname, "Subject", "studid")
        AutoFill("SELECT DISTINCT studid FROM tblsub", txtsearch)
    End Sub

   
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmfee.TextChanged
        txtamounttopay.Text = Val(txtsubfee.Text) + Val(txtcomlabfee.Text) + Val(txtsportsfee.Text) + Val(txtcomlabfee.Text) + Val(txtlibraryfee.Text) + Val(txtclinicfee.Text) + Val(txtcomlabfee.Text) + Val(txtmfee.Text) + Val(txtcomlabfee.Text)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamountrec.TextChanged
        txtchange.Text = Val(txtamountrec.Text) - Val(txtamounttopay.Text)
    End Sub

    Private Sub cbboxstudname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbboxstudname_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'mySelectQuery("SELECT  ID,Subject,Sub_Price from tblsubject")
        'LoadData(DataGridView1, "student")

        'mySelectQuery("SELECT  ID, Subject,Subject_Price from tblsub WHERE studid='" & txtsearch.Text & "'")
        'LoadData(DataGridView1, "student")

        'Dim total = 0
        'For Each row As DataGridViewRow In DataGridView1.Rows
        '    total += row.Cells("Subject_Price").Value
        'Next

        'txtsubfee.Text = total

    End Sub

    Private Sub cbboxstudname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'mySelectQuery("SELECT  ID, Subject,Sub_Price from tblsubject WHERE ID=" & cbboxstudname.SelectedValue.ToString())
        'LoadData(DataGridView1, "student")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        myInsert("INSERT INTO tbltransaction(Fullname,Subjectfee,Comlabfee,Sportsfee,Libra_fee,Clinicfee,MiscFee,Amounttopay,AmountR,Amount_Change) VALUES ('" & txtsearch.Text & "','" & txtsubfee.Text & "','" & txtcomlabfee.Text & "','" & txtsportsfee.Text & "','" & txtlibraryfee.Text & "','" & txtclinicfee.Text & "','" & txtmfee.Text & "','" & txtamounttopay.Text & "','" & txtamountrec.Text & "','" & txtchange.Text & "' )")
        Checkresult("add")
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        mySelectQuery("SELECT  ID, Subject,Subject_Price from tblsub WHERE studid='" & txtsearch.Text & "'")
        LoadData(DataGridView1, "student")

        Dim total = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            total += row.Cells("Subject_Price").Value
        Next

        txtsubfee.Text = total
    End Sub
End Class
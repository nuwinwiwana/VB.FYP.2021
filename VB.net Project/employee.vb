Public Class employee
    Dim sql As String

    Private Sub employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnterprisedbDataSet1.tblemployee' table. You can move, or remove it, as needed.
        Me.TblemployeeTableAdapter.Fill(Me.EnterprisedbDataSet1.tblemployee)

        Timer1.Start()
        'jokenselect("SELECT EMPID AS [EMPLOYEE ID],(LNAME & ', ' &  FNAME   ) AS [EMPLOYEE NAME],GENDER,AGE,BDAY AS [BIRTHDAY],BPLACE AS [BIRTH PALCE],SP_ADDRESS AS [ADDRESS] FROM tblemployee where ASSIGN = NO")
        'filltable(dtgEmplist, "EmpInfo")
        load_basic_info()

        'jokenselect("SELECT tblemployee.*, tblempbackgrd.* FROM tblempbackgrd INNER JOIN tblemployee ON tblempbackgrd.EMPID = tblemployee.EMPID where WORKSTATUS = 'Active'")
        'filltable(DataGridView1, "EmpPic")

    End Sub

    Public Sub load_basic_info()
        jokenselect("SELECT COUNT(*) FROM tblemployee")
        filltotal_employee()

        jokenselect("SELECT COUNT(*) FROM tblemployee where WORKSTATUS = 'Active'")
        Filltotal_activeemployee()
        jokenselect("SELECT COUNT(*) FROM tblemployee where WORKSTATUS = 'Inactive'")
        Filltotal_inactiveemployee()
        jokenselect("SELECT COUNT(*) FROM tblemployee where ASSIGN = YES") 'where STATUS = ACTIVE Filltotal_onduty()
        '

    End Sub



    Private Sub NewEmployeeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewEmployeeBtn.Click
        newemployee.Show()
        Me.Close()

    End Sub


    Private Sub dtgEmplist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        newemployee.Show()
        newemployee.EmployeeIDTB.Text = DataGridView1.CurrentRow.Cells(0).Value

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TimeLabel.Text = TimeOfDay
        DateLabel.Text = Today
    End Sub

    Private Sub DeavtivateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeavtivateBtn.Click
        If lblEMployeeID.Text = "EMployeeID" Then
            MsgBox("Please Select employee to Deactivate!")
        Else
            jokenupdate("UPDATE tblemployee set WORKSTATUS='Inactive' where ID=" & Val(lblEMployeeID.Text) & " ")
            Call employee_Load(sender, e)
            lblEMployeeID.Text = "EMployeeID"
        End If

    End Sub



    Private Sub TXTSEARCH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTSEARCH.TextChanged
        jokenselect("SELECT tblemployee.*, tblempbackgrd.* FROM tblempbackgrd INNER JOIN tblemployee ON tblempbackgrd.EMPID = tblemployee.EMPID WHERE tblemployee.EMPID LIKE '%" & TXTSEARCH.Text & "%' OR LNAME LIKE '%" & TXTSEARCH.Text & "%' OR FNAME LIKE '%" & TXTSEARCH.Text & "%' AND ASSIGN = NO")
        filltable(DataGridView1, "EmpPic")
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        lblEMployeeID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
    End Sub
End Class
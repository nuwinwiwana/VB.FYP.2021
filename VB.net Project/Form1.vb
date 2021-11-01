Public Class Form1
    Private Sub EmployeeBtn_Click(sender As Object, e As EventArgs) Handles EmployeeBtn.Click
        employee.Show()
    End Sub

    Private Sub PayrollBtn_Click(sender As Object, e As EventArgs) Handles PayrollBtn.Click
        payroll.Show()
    End Sub

    Private Sub ReportBtn_Click(sender As Object, e As EventArgs) Handles ReportBtn.Click
        report.Show()
    End Sub

    Private Sub SettingBtn_Click(sender As Object, e As EventArgs) Handles SettingBtn.Click
        Utilities.Show()
    End Sub
End Class

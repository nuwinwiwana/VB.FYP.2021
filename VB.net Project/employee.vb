Public Class employee
    Private Sub employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabel.Text = TimeOfDay
        DateLabel.Text = Today
    End Sub

    Private Sub NewEmployeeBtn_Click(sender As Object, e As EventArgs) Handles NewEmployeeBtn.Click
        newemployee.Show()
        Me.Close()
    End Sub


End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmployeeBtn = New System.Windows.Forms.Button()
        Me.PayrollBtn = New System.Windows.Forms.Button()
        Me.ReportBtn = New System.Windows.Forms.Button()
        Me.SettingBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SettingBtn)
        Me.Panel1.Controls.Add(Me.ReportBtn)
        Me.Panel1.Controls.Add(Me.PayrollBtn)
        Me.Panel1.Controls.Add(Me.EmployeeBtn)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(157, 612)
        Me.Panel1.TabIndex = 0
        '
        'EmployeeBtn
        '
        Me.EmployeeBtn.Location = New System.Drawing.Point(13, 19)
        Me.EmployeeBtn.Name = "EmployeeBtn"
        Me.EmployeeBtn.Size = New System.Drawing.Size(128, 50)
        Me.EmployeeBtn.TabIndex = 0
        Me.EmployeeBtn.Text = "Employee"
        Me.EmployeeBtn.UseVisualStyleBackColor = True
        '
        'PayrollBtn
        '
        Me.PayrollBtn.Location = New System.Drawing.Point(13, 96)
        Me.PayrollBtn.Name = "PayrollBtn"
        Me.PayrollBtn.Size = New System.Drawing.Size(128, 50)
        Me.PayrollBtn.TabIndex = 1
        Me.PayrollBtn.Text = "Payroll"
        Me.PayrollBtn.UseVisualStyleBackColor = True
        '
        'ReportBtn
        '
        Me.ReportBtn.Location = New System.Drawing.Point(13, 175)
        Me.ReportBtn.Name = "ReportBtn"
        Me.ReportBtn.Size = New System.Drawing.Size(128, 50)
        Me.ReportBtn.TabIndex = 2
        Me.ReportBtn.Text = "Report"
        Me.ReportBtn.UseVisualStyleBackColor = True
        '
        'SettingBtn
        '
        Me.SettingBtn.Location = New System.Drawing.Point(13, 257)
        Me.SettingBtn.Name = "SettingBtn"
        Me.SettingBtn.Size = New System.Drawing.Size(128, 50)
        Me.SettingBtn.TabIndex = 3
        Me.SettingBtn.Text = "Setting"
        Me.SettingBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 636)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SettingBtn As Button
    Friend WithEvents ReportBtn As Button
    Friend WithEvents PayrollBtn As Button
    Friend WithEvents EmployeeBtn As Button
End Class

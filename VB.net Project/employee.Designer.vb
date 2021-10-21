<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employee
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NewEmployeeBtn = New System.Windows.Forms.Button()
        Me.DeavtivateBtn = New System.Windows.Forms.Button()
        Me.OnDutyLabel = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TotalEmployeeLabel = New System.Windows.Forms.Label()
        Me.ActiveLabel = New System.Windows.Forms.Label()
        Me.InactiveLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.OnDutyLabel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateLabel)
        Me.GroupBox1.Controls.Add(Me.TimeLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 141)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(20, 30)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(92, 29)
        Me.TimeLabel.TabIndex = 0
        Me.TimeLabel.Text = "Label1"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(20, 83)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(92, 29)
        Me.DateLabel.TabIndex = 1
        Me.DateLabel.Text = "Label2"
        '
        'Timer1
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DeavtivateBtn)
        Me.GroupBox2.Controls.Add(Me.NewEmployeeBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(337, 140)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'NewEmployeeBtn
        '
        Me.NewEmployeeBtn.Location = New System.Drawing.Point(7, 12)
        Me.NewEmployeeBtn.Name = "NewEmployeeBtn"
        Me.NewEmployeeBtn.Size = New System.Drawing.Size(324, 43)
        Me.NewEmployeeBtn.TabIndex = 0
        Me.NewEmployeeBtn.Text = "Add New Employee"
        Me.NewEmployeeBtn.UseVisualStyleBackColor = True
        '
        'DeavtivateBtn
        '
        Me.DeavtivateBtn.Location = New System.Drawing.Point(7, 91)
        Me.DeavtivateBtn.Name = "DeavtivateBtn"
        Me.DeavtivateBtn.Size = New System.Drawing.Size(324, 43)
        Me.DeavtivateBtn.TabIndex = 1
        Me.DeavtivateBtn.Text = "Deactivate"
        Me.DeavtivateBtn.UseVisualStyleBackColor = True
        '
        'OnDutyLabel
        '
        Me.OnDutyLabel.Controls.Add(Me.Label11)
        Me.OnDutyLabel.Controls.Add(Me.InactiveLabel)
        Me.OnDutyLabel.Controls.Add(Me.ActiveLabel)
        Me.OnDutyLabel.Controls.Add(Me.TotalEmployeeLabel)
        Me.OnDutyLabel.Controls.Add(Me.Label8)
        Me.OnDutyLabel.Controls.Add(Me.Label7)
        Me.OnDutyLabel.Controls.Add(Me.Label6)
        Me.OnDutyLabel.Controls.Add(Me.Label5)
        Me.OnDutyLabel.Controls.Add(Me.Label4)
        Me.OnDutyLabel.Controls.Add(Me.Label3)
        Me.OnDutyLabel.Controls.Add(Me.Label2)
        Me.OnDutyLabel.Controls.Add(Me.Label1)
        Me.OnDutyLabel.Location = New System.Drawing.Point(13, 316)
        Me.OnDutyLabel.Name = "OnDutyLabel"
        Me.OnDutyLabel.Size = New System.Drawing.Size(337, 302)
        Me.OnDutyLabel.TabIndex = 2
        Me.OnDutyLabel.TabStop = False
        Me.OnDutyLabel.Text = "Employee Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Employee"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Active Employee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Inactive Employee"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "On-Duty"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(232, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(232, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(232, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(232, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = ":"
        '
        'TotalEmployeeLabel
        '
        Me.TotalEmployeeLabel.AutoSize = True
        Me.TotalEmployeeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalEmployeeLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TotalEmployeeLabel.Location = New System.Drawing.Point(256, 39)
        Me.TotalEmployeeLabel.Name = "TotalEmployeeLabel"
        Me.TotalEmployeeLabel.Size = New System.Drawing.Size(23, 25)
        Me.TotalEmployeeLabel.TabIndex = 8
        Me.TotalEmployeeLabel.Text = "0"
        '
        'ActiveLabel
        '
        Me.ActiveLabel.AutoSize = True
        Me.ActiveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ActiveLabel.Location = New System.Drawing.Point(256, 82)
        Me.ActiveLabel.Name = "ActiveLabel"
        Me.ActiveLabel.Size = New System.Drawing.Size(23, 25)
        Me.ActiveLabel.TabIndex = 9
        Me.ActiveLabel.Text = "0"
        '
        'InactiveLabel
        '
        Me.InactiveLabel.AutoSize = True
        Me.InactiveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InactiveLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.InactiveLabel.Location = New System.Drawing.Point(256, 128)
        Me.InactiveLabel.Name = "InactiveLabel"
        Me.InactiveLabel.Size = New System.Drawing.Size(23, 25)
        Me.InactiveLabel.TabIndex = 10
        Me.InactiveLabel.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(256, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 25)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "0"
        '
        'employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 630)
        Me.Controls.Add(Me.OnDutyLabel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "employee"
        Me.Text = "employee"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.OnDutyLabel.ResumeLayout(False)
        Me.OnDutyLabel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateLabel As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DeavtivateBtn As Button
    Friend WithEvents NewEmployeeBtn As Button
    Friend WithEvents OnDutyLabel As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents InactiveLabel As Label
    Friend WithEvents ActiveLabel As Label
    Friend WithEvents TotalEmployeeLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

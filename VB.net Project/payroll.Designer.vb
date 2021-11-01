<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payroll
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenListBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.payEmpID = New System.Windows.Forms.TextBox()
        Me.payEmpName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblpayrolid = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNoHoursWork = New System.Windows.Forms.TextBox()
        Me.txtAllowances = New System.Windows.Forms.TextBox()
        Me.txtAdjustments = New System.Windows.Forms.TextBox()
        Me.GrossSalary = New System.Windows.Forms.TextBox()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtbasicPay = New System.Windows.Forms.TextBox()
        Me.txtHourlyRate = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.IncomeTaxTB = New System.Windows.Forms.TextBox()
        Me.EPFTB = New System.Windows.Forms.TextBox()
        Me.SOCSOTB = New System.Windows.Forms.TextBox()
        Me.txttotalDeductions = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtNetIncome = New System.Windows.Forms.TextBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 36)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Payroll"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1101, 64)
        Me.Panel2.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(17, 102)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(180, 22)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Period Start:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(203, 102)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(196, 22)
        Me.DateTimePicker2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Period End:"
        '
        'OpenListBtn
        '
        Me.OpenListBtn.Location = New System.Drawing.Point(405, 76)
        Me.OpenListBtn.Name = "OpenListBtn"
        Me.OpenListBtn.Size = New System.Drawing.Size(126, 48)
        Me.OpenListBtn.TabIndex = 11
        Me.OpenListBtn.Text = "Open List"
        Me.OpenListBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Employee ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Fullname:"
        '
        'payEmpID
        '
        Me.payEmpID.BackColor = System.Drawing.SystemColors.Menu
        Me.payEmpID.Location = New System.Drawing.Point(17, 187)
        Me.payEmpID.Name = "payEmpID"
        Me.payEmpID.ReadOnly = True
        Me.payEmpID.Size = New System.Drawing.Size(180, 22)
        Me.payEmpID.TabIndex = 14
        '
        'payEmpName
        '
        Me.payEmpName.BackColor = System.Drawing.SystemColors.Menu
        Me.payEmpName.Location = New System.Drawing.Point(204, 186)
        Me.payEmpName.Name = "payEmpName"
        Me.payEmpName.ReadOnly = True
        Me.payEmpName.Size = New System.Drawing.Size(327, 22)
        Me.payEmpName.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(571, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Payroll ID:"
        '
        'lblpayrolid
        '
        Me.lblpayrolid.AutoSize = True
        Me.lblpayrolid.Location = New System.Drawing.Point(649, 106)
        Me.lblpayrolid.Name = "lblpayrolid"
        Me.lblpayrolid.Size = New System.Drawing.Size(0, 17)
        Me.lblpayrolid.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "No. Hours Worked"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Allowances"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Adjustments"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(304, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Basic Pay"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(304, 331)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Total Salary"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(142, 247)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(142, 288)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(142, 332)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(12, 17)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(394, 247)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(12, 17)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(394, 332)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(12, 17)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = ":"
        '
        'txtNoHoursWork
        '
        Me.txtNoHoursWork.Location = New System.Drawing.Point(169, 247)
        Me.txtNoHoursWork.Name = "txtNoHoursWork"
        Me.txtNoHoursWork.Size = New System.Drawing.Size(100, 22)
        Me.txtNoHoursWork.TabIndex = 28
        '
        'txtAllowances
        '
        Me.txtAllowances.Location = New System.Drawing.Point(169, 285)
        Me.txtAllowances.Name = "txtAllowances"
        Me.txtAllowances.Size = New System.Drawing.Size(100, 22)
        Me.txtAllowances.TabIndex = 29
        '
        'txtAdjustments
        '
        Me.txtAdjustments.Location = New System.Drawing.Point(169, 329)
        Me.txtAdjustments.Name = "txtAdjustments"
        Me.txtAdjustments.Size = New System.Drawing.Size(100, 22)
        Me.txtAdjustments.TabIndex = 30
        '
        'GrossSalary
        '
        Me.GrossSalary.BackColor = System.Drawing.SystemColors.Menu
        Me.GrossSalary.Location = New System.Drawing.Point(412, 244)
        Me.GrossSalary.Name = "GrossSalary"
        Me.GrossSalary.ReadOnly = True
        Me.GrossSalary.Size = New System.Drawing.Size(100, 22)
        Me.GrossSalary.TabIndex = 31
        '
        'txtGrossPay
        '
        Me.txtGrossPay.BackColor = System.Drawing.SystemColors.Menu
        Me.txtGrossPay.Location = New System.Drawing.Point(412, 329)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.ReadOnly = True
        Me.txtGrossPay.Size = New System.Drawing.Size(100, 22)
        Me.txtGrossPay.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHourlyRate)
        Me.GroupBox1.Controls.Add(Me.txtbasicPay)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(574, 244)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 107)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Income"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(24, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 17)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Baisc Pay"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(27, 71)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 17)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Hourly Rate"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(116, 71)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(12, 17)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = ":"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(116, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(12, 17)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = ":"
        '
        'txtbasicPay
        '
        Me.txtbasicPay.BackColor = System.Drawing.SystemColors.Menu
        Me.txtbasicPay.Location = New System.Drawing.Point(135, 33)
        Me.txtbasicPay.Name = "txtbasicPay"
        Me.txtbasicPay.ReadOnly = True
        Me.txtbasicPay.Size = New System.Drawing.Size(121, 22)
        Me.txtbasicPay.TabIndex = 36
        '
        'txtHourlyRate
        '
        Me.txtHourlyRate.BackColor = System.Drawing.SystemColors.Menu
        Me.txtHourlyRate.Location = New System.Drawing.Point(134, 68)
        Me.txtHourlyRate.Name = "txtHourlyRate"
        Me.txtHourlyRate.ReadOnly = True
        Me.txtHourlyRate.Size = New System.Drawing.Size(122, 22)
        Me.txtHourlyRate.TabIndex = 37
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.txttotalDeductions)
        Me.GroupBox2.Controls.Add(Me.SOCSOTB)
        Me.GroupBox2.Controls.Add(Me.EPFTB)
        Me.GroupBox2.Controls.Add(Me.IncomeTaxTB)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 379)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(508, 169)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DEDUCTIONS"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(22, 38)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 17)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Income Tax"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(22, 73)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(34, 17)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "EPF"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(250, 38)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(57, 17)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "SOCSO"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(108, 38)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(15, 20)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = ":"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(107, 70)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(15, 20)
        Me.Label26.TabIndex = 36
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(335, 35)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(15, 20)
        Me.Label27.TabIndex = 37
        Me.Label27.Text = ":"
        '
        'IncomeTaxTB
        '
        Me.IncomeTaxTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncomeTaxTB.Location = New System.Drawing.Point(129, 38)
        Me.IncomeTaxTB.Name = "IncomeTaxTB"
        Me.IncomeTaxTB.ReadOnly = True
        Me.IncomeTaxTB.Size = New System.Drawing.Size(100, 22)
        Me.IncomeTaxTB.TabIndex = 39
        '
        'EPFTB
        '
        Me.EPFTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EPFTB.Location = New System.Drawing.Point(129, 70)
        Me.EPFTB.Name = "EPFTB"
        Me.EPFTB.ReadOnly = True
        Me.EPFTB.Size = New System.Drawing.Size(100, 22)
        Me.EPFTB.TabIndex = 40
        '
        'SOCSOTB
        '
        Me.SOCSOTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SOCSOTB.Location = New System.Drawing.Point(356, 35)
        Me.SOCSOTB.Name = "SOCSOTB"
        Me.SOCSOTB.ReadOnly = True
        Me.SOCSOTB.Size = New System.Drawing.Size(100, 22)
        Me.SOCSOTB.TabIndex = 41
        '
        'txttotalDeductions
        '
        Me.txttotalDeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalDeductions.Location = New System.Drawing.Point(356, 120)
        Me.txttotalDeductions.Name = "txttotalDeductions"
        Me.txttotalDeductions.ReadOnly = True
        Me.txttotalDeductions.Size = New System.Drawing.Size(100, 27)
        Me.txttotalDeductions.TabIndex = 42
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(168, 123)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(183, 20)
        Me.Label29.TabIndex = 43
        Me.Label29.Text = "TOTAL DEDUCTION : "
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(550, 409)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(212, 25)
        Me.Label30.TabIndex = 35
        Me.Label30.Text = "Net Pay for the Period: "
        '
        'txtNetIncome
        '
        Me.txtNetIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetIncome.Location = New System.Drawing.Point(761, 406)
        Me.txtNetIncome.Name = "txtNetIncome"
        Me.txtNetIncome.ReadOnly = True
        Me.txtNetIncome.Size = New System.Drawing.Size(152, 30)
        Me.txtNetIncome.TabIndex = 36
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(646, 497)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(130, 50)
        Me.SaveBtn.TabIndex = 37
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(793, 499)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(130, 50)
        Me.CancelBtn.TabIndex = 38
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 574)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.txtNetIncome)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.GrossSalary)
        Me.Controls.Add(Me.txtAdjustments)
        Me.Controls.Add(Me.txtAllowances)
        Me.Controls.Add(Me.txtNoHoursWork)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblpayrolid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.payEmpName)
        Me.Controls.Add(Me.payEmpID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OpenListBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "payroll"
        Me.Text = "payroll"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenListBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents payEmpID As TextBox
    Friend WithEvents payEmpName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblpayrolid As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtNoHoursWork As TextBox
    Friend WithEvents txtAllowances As TextBox
    Friend WithEvents txtAdjustments As TextBox
    Friend WithEvents GrossSalary As TextBox
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtHourlyRate As TextBox
    Friend WithEvents txtbasicPay As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txttotalDeductions As TextBox
    Friend WithEvents SOCSOTB As TextBox
    Friend WithEvents EPFTB As TextBox
    Friend WithEvents IncomeTaxTB As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtNetIncome As TextBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents CancelBtn As Button
End Class

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
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DeavtivateBtn = New System.Windows.Forms.Button()
        Me.NewEmployeeBtn = New System.Windows.Forms.Button()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.OnDutyLabel = New System.Windows.Forms.Label()
        Me.InactiveLabel = New System.Windows.Forms.Label()
        Me.ActiveLabel = New System.Windows.Forms.Label()
        Me.TotalEmployeeLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblEMployeeID = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.EnterprisedbDataSet1 = New VB.net_Project.enterprisedbDataSet1()
        Me.TblemployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblemployeeTableAdapter = New VB.net_Project.enterprisedbDataSet1TableAdapters.tblemployeeTableAdapter()
        Me.EMPIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FULLNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HIREDDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.EnterprisedbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblemployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateLabel)
        Me.GroupBox1.Controls.Add(Me.TimeLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 141)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
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
        'Timer1
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DeavtivateBtn)
        Me.GroupBox2.Controls.Add(Me.NewEmployeeBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(337, 140)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
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
        'NewEmployeeBtn
        '
        Me.NewEmployeeBtn.Location = New System.Drawing.Point(7, 12)
        Me.NewEmployeeBtn.Name = "NewEmployeeBtn"
        Me.NewEmployeeBtn.Size = New System.Drawing.Size(324, 43)
        Me.NewEmployeeBtn.TabIndex = 0
        Me.NewEmployeeBtn.Text = "Add New Employee"
        Me.NewEmployeeBtn.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.OnDutyLabel)
        Me.GroupBox.Controls.Add(Me.InactiveLabel)
        Me.GroupBox.Controls.Add(Me.ActiveLabel)
        Me.GroupBox.Controls.Add(Me.TotalEmployeeLabel)
        Me.GroupBox.Controls.Add(Me.Label8)
        Me.GroupBox.Controls.Add(Me.Label7)
        Me.GroupBox.Controls.Add(Me.Label6)
        Me.GroupBox.Controls.Add(Me.Label5)
        Me.GroupBox.Controls.Add(Me.Label4)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Location = New System.Drawing.Point(13, 356)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(337, 262)
        Me.GroupBox.TabIndex = 2
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Employee Details"
        '
        'OnDutyLabel
        '
        Me.OnDutyLabel.AutoSize = True
        Me.OnDutyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnDutyLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OnDutyLabel.Location = New System.Drawing.Point(256, 176)
        Me.OnDutyLabel.Name = "OnDutyLabel"
        Me.OnDutyLabel.Size = New System.Drawing.Size(23, 25)
        Me.OnDutyLabel.TabIndex = 11
        Me.OnDutyLabel.Text = "0"
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPIDDataGridViewTextBoxColumn, Me.FULLNAMEDataGridViewTextBoxColumn, Me.GENDERDataGridViewTextBoxColumn, Me.HIREDDATEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblemployeeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(356, 164)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(778, 454)
        Me.DataGridView1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Location = New System.Drawing.Point(357, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 36)
        Me.Panel1.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(316, 22)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Gender"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(430, 22)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Date Hired"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(55, 19)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 17)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Employee ID"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(183, 19)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 17)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Fullname"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1147, 64)
        Me.Panel2.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(322, 36)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Employee Information"
        '
        'lblEMployeeID
        '
        Me.lblEMployeeID.AutoSize = True
        Me.lblEMployeeID.Location = New System.Drawing.Point(673, 97)
        Me.lblEMployeeID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEMployeeID.Name = "lblEMployeeID"
        Me.lblEMployeeID.Size = New System.Drawing.Size(83, 17)
        Me.lblEMployeeID.TabIndex = 19
        Me.lblEMployeeID.Text = "EMployeeID"
        Me.lblEMployeeID.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(466, 73)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 17)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "(Fullname)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(357, 67)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 25)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Search :"
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.Location = New System.Drawing.Point(358, 93)
        Me.TXTSEARCH.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(305, 22)
        Me.TXTSEARCH.TabIndex = 16
        '
        'EnterprisedbDataSet1
        '
        Me.EnterprisedbDataSet1.DataSetName = "enterprisedbDataSet1"
        Me.EnterprisedbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblemployeeBindingSource
        '
        Me.TblemployeeBindingSource.DataMember = "tblemployee"
        Me.TblemployeeBindingSource.DataSource = Me.EnterprisedbDataSet1
        '
        'TblemployeeTableAdapter
        '
        Me.TblemployeeTableAdapter.ClearBeforeFill = True
        '
        'EMPIDDataGridViewTextBoxColumn
        '
        Me.EMPIDDataGridViewTextBoxColumn.DataPropertyName = "EMPID"
        Me.EMPIDDataGridViewTextBoxColumn.HeaderText = "EMPID"
        Me.EMPIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EMPIDDataGridViewTextBoxColumn.Name = "EMPIDDataGridViewTextBoxColumn"
        Me.EMPIDDataGridViewTextBoxColumn.Width = 125
        '
        'FULLNAMEDataGridViewTextBoxColumn
        '
        Me.FULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "FULLNAME"
        Me.FULLNAMEDataGridViewTextBoxColumn.HeaderText = "FULLNAME"
        Me.FULLNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FULLNAMEDataGridViewTextBoxColumn.Name = "FULLNAMEDataGridViewTextBoxColumn"
        Me.FULLNAMEDataGridViewTextBoxColumn.Width = 125
        '
        'GENDERDataGridViewTextBoxColumn
        '
        Me.GENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.HeaderText = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GENDERDataGridViewTextBoxColumn.Name = "GENDERDataGridViewTextBoxColumn"
        Me.GENDERDataGridViewTextBoxColumn.Width = 125
        '
        'HIREDDATEDataGridViewTextBoxColumn
        '
        Me.HIREDDATEDataGridViewTextBoxColumn.DataPropertyName = "HIREDDATE"
        Me.HIREDDATEDataGridViewTextBoxColumn.HeaderText = "HIREDDATE"
        Me.HIREDDATEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HIREDDATEDataGridViewTextBoxColumn.Name = "HIREDDATEDataGridViewTextBoxColumn"
        Me.HIREDDATEDataGridViewTextBoxColumn.Width = 125
        '
        'employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 630)
        Me.Controls.Add(Me.lblEMployeeID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TXTSEARCH)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "employee"
        Me.Text = "employee"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.EnterprisedbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblemployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateLabel As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DeavtivateBtn As Button
    Friend WithEvents NewEmployeeBtn As Button
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents OnDutyLabel As Label
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblEMployeeID As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TXTSEARCH As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents EnterprisedbDataSet1 As enterprisedbDataSet1
    Friend WithEvents TblemployeeBindingSource As BindingSource
    Friend WithEvents TblemployeeTableAdapter As enterprisedbDataSet1TableAdapters.tblemployeeTableAdapter
    Friend WithEvents EMPIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FULLNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GENDERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HIREDDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

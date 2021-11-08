<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnlogin = New System.Windows.Forms.ToolStripDropDownButton()
        Me.txtLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnstudent = New System.Windows.Forms.ToolStripButton()
        Me.btnlis = New System.Windows.Forms.ToolStripButton()
        Me.btnsubject = New System.Windows.Forms.ToolStripButton()
        Me.btnmStudent = New System.Windows.Forms.ToolStripButton()
        Me.btntrans = New System.Windows.Forms.ToolStripButton()
        Me.btnuser = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnlogin, Me.btnstudent, Me.btnlis, Me.btnsubject, Me.btnmStudent, Me.btntrans, Me.btnuser})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1368, 79)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnlogin
        '
        Me.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlogin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtLogin, Me.txtLogout, Me.ExitToolStripMenuItem})
        Me.btnlogin.Image = CType(resources.GetObject("btnlogin.Image"), System.Drawing.Image)
        Me.btnlogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnlogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(66, 76)
        Me.btnlogin.Text = "Home"
        Me.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'txtLogin
        '
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(139, 26)
        Me.txtLogin.Text = "Login"
        '
        'txtLogout
        '
        Me.txtLogout.Name = "txtLogout"
        Me.txtLogout.Size = New System.Drawing.Size(139, 26)
        Me.txtLogout.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnstudent
        '
        Me.btnstudent.Image = CType(resources.GetObject("btnstudent.Image"), System.Drawing.Image)
        Me.btnstudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnstudent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnstudent.Name = "btnstudent"
        Me.btnstudent.Size = New System.Drawing.Size(64, 76)
        Me.btnstudent.Text = "Student"
        Me.btnstudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnlis
        '
        Me.btnlis.Image = CType(resources.GetObject("btnlis.Image"), System.Drawing.Image)
        Me.btnlis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnlis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnlis.Name = "btnlis"
        Me.btnlis.Size = New System.Drawing.Size(108, 76)
        Me.btnlis.Text = "List of Student"
        Me.btnlis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnsubject
        '
        Me.btnsubject.Image = CType(resources.GetObject("btnsubject.Image"), System.Drawing.Image)
        Me.btnsubject.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnsubject.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsubject.Name = "btnsubject"
        Me.btnsubject.Size = New System.Drawing.Size(62, 76)
        Me.btnsubject.Text = "Subject"
        Me.btnsubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnmStudent
        '
        Me.btnmStudent.Image = CType(resources.GetObject("btnmStudent.Image"), System.Drawing.Image)
        Me.btnmStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnmStudent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnmStudent.Name = "btnmStudent"
        Me.btnmStudent.Size = New System.Drawing.Size(122, 76)
        Me.btnmStudent.Text = "Manage Student"
        Me.btnmStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btntrans
        '
        Me.btntrans.Image = CType(resources.GetObject("btntrans.Image"), System.Drawing.Image)
        Me.btntrans.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btntrans.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btntrans.Name = "btntrans"
        Me.btntrans.Size = New System.Drawing.Size(88, 76)
        Me.btntrans.Text = "Transaction"
        Me.btntrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnuser
        '
        Me.btnuser.Image = CType(resources.GetObject("btnuser.Image"), System.Drawing.Image)
        Me.btnuser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnuser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(100, 76)
        Me.btnuser.Text = "User Account"
        Me.btnuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EnrollmentSystem.My.Resources.Resources.utm_photo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1368, 594)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnstudent As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnlis As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnsubject As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnmStudent As System.Windows.Forms.ToolStripButton
    Friend WithEvents btntrans As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnuser As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnlogin As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents txtLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

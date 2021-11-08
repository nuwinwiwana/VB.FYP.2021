Imports System.Data.OleDb
Module Crud
    Dim dbReader As OleDbDataReader
    Public autoor As Integer
    Public DbDataReader As OleDbDataReader
    Public Function myInsert(ByVal sql As String) As Boolean
        If ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        con.Close()
        Return True
    End Function
    Public Function myDelete(ByVal sql As String) As Boolean
        If ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        con.Close()
        Return True
    End Function
    Public Function myUpdate(ByVal sql As String) As Boolean
        If ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        con.Close()
        Return True
    End Function
    Public Sub mySelectQuery(ByVal sql As String)
        If ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        con.Close()
        da.Dispose()
    End Sub
    Public Sub LoadData(ByVal dgv As DataGridView, ByVal str As String)
        If ConnectionState.Open Then
            con.Close()
        End If
        dt = New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        'Dim Counter = 1
        'Dim MaxPoints = 100

        'If ConnectionState.Open Then
        '    con.Close()
        'End If
        'Try

        '    con.Open()
        '    dbReader = cmd.ExecuteReader()
        '    obj.Rows.Clear()

        '    Do While dbReader.Read = True
        '        Select Case caseswitch
        '            Case "student"
        '                obj.Rows.Add(dbReader(0), dbReader(1), dbReader(2), dbReader(3), dbReader(4), dbReader(5))
        '        End Select
        '    Loop

        'Catch ex As Exception
        'End Try
        ' con.Close()
    End Sub
    Public Sub fillcombo(ByVal combo As ComboBox, ByVal member As String, ByVal idparam As String)
        Dim Publictable As New DataTable
        Try

            da.SelectCommand = cmd
            da.Fill(Publictable)
            With combo
                .datasource = Publictable
                .displaymember = member
                .ValueMember = idparam
                .SelectedIndex = -1
                .AutoCompleteSource = AutoCompleteSource.ListItems
                .AutoCompleteMode = AutoCompleteMode.Suggest
            End With
            da.Dispose()

        Catch ex As Exception

        End Try

    End Sub
    Public Function getsvalue()
        Dim Result = Nothing
        Dim table As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(table)
            Result = table.Rows(0).Item(0)
        Catch ex As Exception
            Debug.WriteLine("getsvalue ===================>" & ex.Message)
        End Try

        Return Result
    End Function
    'Public Sub Checkresult(ByVal CaseResult As String)

    '    Dim table As New DataTable
    '    Try
    '        da.SelectCommand = cmd
    '        da.Fill(table)

    '        If table.Rows.Count >= 0 Then

    '            Select Case CaseResult
    '                Case "Login"
    '                    If frmlogin.TextBox1.Text = table.Rows(0).Item("User_Username") And frmlogin.TextBox2.Text = table.Rows(0).Item("User_Password") Then

    '                    MessageBox.Show("You are now login")
    '                    MainForm.txtLogin.Visible = False
    '                    MainForm.txtLogout.Visible = True
    '                    frmlogin.Close()
    '                    MainForm.btnlis.Enabled = True
    '                    MainForm.btnmStudent.Enabled = True
    '                    MainForm.btnsubject.Enabled = True
    '                    MainForm.btntrans.Enabled = True
    '                    MainForm.btnuser.Enabled = True
    '                    MainForm.btnstudent.Enabled = True
    '                      Else
    '                    MessageBox.Show("Invalid Username And Password")
    '                     End If


    '                Case "add"
    '                     MessageBox.Show("Data Has Been Added")
    '                    autoor = table.Rows(0).Item(0) + 1
    '                    frmstudent.txtidno.Text = autoor

    '                Case "Update"
    '                    MessageBox.Show("Data Has Been Updated")
    '                Case "DELETE"
    '                    MessageBox.Show("Data Has Been Deleted")

    '                Case "ORAutoMax"

    '                    autoor = table.Rows(1).Item(1) + 1
    '                    frmstudent.txtidno.Text = autoor

    '            End Select

    '        Else

    '            Select Case CaseResult
    '                Case "Login"

    '                Case "add"
    '                    MessageBox.Show("No Data Has Been Added")
    '                Case "update"
    '                    MessageBox.Show("No Data Has Been Updated")
    '                Case "delete"
    '                    MessageBox.Show("No Data Has Been Deleted")

    '            End Select
    '        End If

    '    Catch ex As Exception

    '    End Try

    'End Sub
    Public Sub Checkresult(ByVal CaseResult As String)

        Dim table As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(table)

            If table.Rows.Count > 0 Then

                Select Case CaseResult

                   

                    'Case "ORAutoMax"

                    '    autoor = table.Rows(1).Item(1) + 1
                    '    frmstudent.txtidno.Text = autoor
                    Case "Login"
                        MessageBox.Show("You are now login")
                        MainForm.txtLogin.Visible = False
                        MainForm.txtLogout.Visible = True
                        frmlogin.Close()
                        MainForm.btnlis.Enabled = True
                        MainForm.btnmStudent.Enabled = True
                        MainForm.btnsubject.Enabled = True
                        MainForm.btntrans.Enabled = True
                        MainForm.btnuser.Enabled = True
                        MainForm.btnstudent.Enabled = True
                       
                End Select

            Else
                Select Case CaseResult

                    Case "Update"
                        MessageBox.Show("Data Has Been Updated")
                    Case "DELETE"
                        MessageBox.Show("Data Has Been Deleted")

                    Case "Login"
                        MsgBox("Please Contact our Boss!")
                End Select
            End If

        Catch ex As Exception

        End Try
        con.Close()
    End Sub
    Sub AutoFill(ByVal Qry As String, ByVal TxtResult As TextBox)
        Dim dbreader As OleDbDataReader
        Dim cmd As New OleDbCommand

        Dim QryRes As New AutoCompleteStringCollection
        TxtResult.AutoCompleteCustomSource.Clear()

        con = connect()
        con.Open()
        With cmd
            .Connection = con
            .CommandText = Qry
        End With

        dbreader = cmd.ExecuteReader
        While dbreader.Read
            QryRes.Add(dbreader.GetValue(0))
        End While

        TxtResult.AutoCompleteMode = AutoCompleteMode.Suggest
        TxtResult.AutoCompleteSource = AutoCompleteSource.CustomSource
        TxtResult.AutoCompleteCustomSource = QryRes

        con.Close()
    End Sub 
End Module

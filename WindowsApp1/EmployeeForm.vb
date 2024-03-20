Imports NarsilWorks.DevLibData
Imports NarsilWorks.DevLib
Imports NarsilWorks.DevLibWinForms
Imports SpreadsheetLight
Imports Excel = Microsoft.Office.Interop.Excel
Imports DocumentFormat.OpenXml.InkML
Imports System.Windows.Forms

Public Class EmployeeForm
    Private m_IsLoading As Boolean = False
    Private m_IsEditing As Boolean = False
    Private dtm As DataManager
    Private m_MainConnStr As String = String.Empty
    Private m_InitialConnStr As String = ""
    Private m_dtdoor As DataTable

    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Initialize()

        Call RefreshList()

        SaveButton.Enabled = False
        CancelButton.Enabled = False
        DeleteButton.Enabled = False
    End Sub

    Private Sub RefreshList()
        Try
            Using m_Dmgr As New DataManager(m_ConStr)
                m_dtdoor = m_Dmgr.GetDataTable("SELECT EmployeeKey, UserName, FirstName, LastName, Email FROM dbo.tcoEmployee")
                DataGridView1.DataSource = m_dtdoor
                m_dtdoor.Dispose()
            End Using
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub


    'Private Sub LoadReasonType()
    '    Try
    '        Using m_Dmgr As New DataManager(m_ConStr)
    '            m_dtdoor = m_Dmgr.GetDataTable("SELECT EmployeeKey, UserName, FirstName, LastName, Email FROM dbo.tcoEmployee")
    '            DataGridView1.DataSource = m_dtdoor
    '            m_dtdoor.Dispose()
    '        End Using
    '    Catch ex As Exception
    '        MsgBox("Error")
    '    End Try
    'End Sub


    Private Sub Import_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Dim ofd As New OpenFileDialog
        Dim UserName As String
        Dim FirstName As String
        Dim LastName As String
        Dim Email As String
        Dim EmployeeKey As Integer = 0
        ofd.Filter = "Excel 2007 files *.xlsx|*.xlsx"
        If ofd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                Using sl = New SpreadsheetLight.SLDocument(ofd.FileName)
                    Dim ws As SpreadsheetLight.SLWorksheetStatistics = sl.GetWorksheetStatistics()
                    Dim m_MaxRows = ws.NumberOfRows
                    Using m_Dmgr As New DataManager(m_ConStr)
                        For ix As Integer = 2 To m_MaxRows
                            UserName = Trim(sl.GetCellValueAsString(ix, 1))
                            FirstName = Trim(sl.GetCellValueAsString(ix, 2))
                            LastName = Trim(sl.GetCellValueAsString(ix, 3))
                            Email = Trim(sl.GetCellValueAsString(ix, 4))
                            Dim m_existing As Boolean = False
                            If UserName <> "" Then
                                m_existing = m_Dmgr.GetCount("dbo.tcoEmployee WHERE UserName = @p1", UserName)
                                If Not m_existing Then
                                    EmployeeKey = m_Dmgr.GetValue("EXEC ssh_getnextnumberapps @p1", 0, "EmployeeKey")
                                    Dim q As New QueryBuilder("tcoEmployee")
                                    q.CommandType = QueryBuilder.CommandQuery.cqINSERT
                                    q.AddFieldValuePair("EmployeeKey", EmployeeKey, True)
                                    q.AddFieldValuePair("UserName", UserName, True)
                                    q.AddFieldValuePair("FirstName", FirstName, True)
                                    q.AddFieldValuePair("LastName", LastName, True)
                                    q.AddFieldValuePair("Email", Email, True)
                                    m_Dmgr.ExecuteNonQuery(q.GetQuery)
                                End If
                            End If
                        Next
                        Call RefreshList()
                        m_Dmgr.Dispose()
                        MsgBox("Import Success")
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error Import")
            End Try

        End If
    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        Try
            Dim sfd As New SaveFileDialog
            sfd.Filter = "Excel 2007 files (*.xlsx)|*.xlsx"
            If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then

                Using sl = New SpreadsheetLight.SLDocument()
                    Dim m_Dmgr As New DataManager(m_ConStr)
                    Dim dataTable As DataTable = m_Dmgr.GetDataTable("SELECT EmployeeKey, UserName, FirstName, LastName, Email FROM dbo.tcoEmployee")

                    For col As Integer = 0 To dataTable.Columns.Count - 1
                        sl.SetCellValue(1, col + 1, dataTable.Columns(col).ColumnName)
                    Next

                    For row As Integer = 0 To dataTable.Rows.Count - 1
                        For col As Integer = 0 To dataTable.Columns.Count - 1
                            sl.SetCellValue(row + 2, col + 1, dataTable.Rows(row)(col).ToString())
                        Next
                    Next

                    sl.SaveAs(sfd.FileName)
                    MessageBox.Show("Export Successful")
                End Using

            End If
        Catch ex As Exception
            MsgBox("Error Export")
        End Try
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        SaveButton.Enabled = False
        CancelButton.Enabled = False
        DeleteButton.Enabled = False
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        SaveButton.Enabled = True
        CancelButton.Enabled = True
        DeleteButton.Enabled = True
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        'If MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "Delete Item") = MsgBoxResult.Yes Then
        '    Using m_DMgr As New DataManager(m_MainConnStr)
        '        Try
        '            'check if already used
        '            If DataGridView1.SelectedRows.Count > 0 Then
        '                Dim dgvr As DataGridViewRow = DataGridView1.SelectedRows(0)

        '                Dim m_IsExisting As Boolean = m_DMgr.GetCount("dbo.tcoEmployee WHERE UserName = @p1", UserName)
        '                If m_IsExisting = True Then
        '                    MsgBox("Reason code already used in the database!", MsgBoxStyle.Exclamation, "Error")
        '                    Exit Try
        '                End If

        '                'Delete Reason
        '                'm_DMgr.ExecuteNonQuery("DELETE FROM  tsoReasonCode WHERE ReasonKey= '" & dgvr.Cells("ReasonKey").Value & "'")
        '                m_DMgr.ExecuteNonQuery("dbo.tcoEmployee WHERE UserName = @p1", dgvr.Cells("ReasonKey").Value)

        '                Call RefreshList()
        '                MsgBox("The record was deleted successfully!", MsgBoxStyle.Information, "Success")
        '            End If

        '        Catch ex As Exception
        '            MsgBox("Could not delete the selected record.", MsgBoxStyle.Critical, "Error")
        '        End Try
        '    End Using
        'End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

    End Sub

    'Private Sub SearchEmployeeKey_TextChanged(sender As Object, e As EventArgs)
    '    Using m_Dmgr As New DataManager(m_ConStr)
    '        Try
    '            m_dtdoor = m_Dmgr.GetDataTable("SELECT * FROM dbo.tcoEmployee WHERE EmployeeKey LIKE '%" & SearchEmployeeKey.Text & "%'")
    '            DataGridView1.DataSource = m_dtdoor
    '        Catch ex As Exception
    '            MsgBox("Error")
    '        End Try
    '    End Using
    'End Sub

    'Private Sub SearchUserName_TextChanged(sender As Object, e As EventArgs)
    '    Using m_Dmgr As New DataManager(m_ConStr)
    '        Try
    '            m_dtdoor = m_Dmgr.GetDataTable("SELECT * FROM dbo.tcoEmployee WHERE UserName LIKE '%" & SearchUserName.Text & "%'")
    '            DataGridView1.DataSource = m_dtdoor
    '        Catch ex As Exception
    '            MsgBox("Error")
    '        End Try
    '    End Using
    'End Sub

    'Private Sub SearchFirstName_TextChanged(sender As Object, e As EventArgs)
    '    Using m_Dmgr As New DataManager(m_ConStr)
    '        Try
    '            m_dtdoor = m_Dmgr.GetDataTable("SELECT * FROM dbo.tcoEmployee WHERE FirstName LIKE '%" & SearchFirstName.Text & "%'")
    '            DataGridView1.DataSource = m_dtdoor
    '        Catch ex As Exception
    '            MsgBox("Error")
    '        End Try
    '    End Using
    'End Sub

    'Private Sub SearchLastName_TextChanged(sender As Object, e As EventArgs)
    '    Using m_Dmgr As New DataManager(m_ConStr)
    '        Try
    '            m_dtdoor = m_Dmgr.GetDataTable("SELECT * FROM dbo.tcoEmployee WHERE LastName LIKE '%" & SearchLastName.Text & "%'")
    '            DataGridView1.DataSource = m_dtdoor
    '        Catch ex As Exception
    '            MsgBox("Error")
    '        End Try
    '    End Using
    'End Sub

    'Private Sub SearchEmail_TextChanged(sender As Object, e As EventArgs)
    '    Using m_Dmgr As New DataManager(m_ConStr)
    '        Try
    '            m_dtdoor = m_Dmgr.GetDataTable("SELECT * FROM dbo.tcoEmployee WHERE Email LIKE '%" & SearchEmail.Text & "%'")
    '            DataGridView1.DataSource = m_dtdoor
    '        Catch ex As Exception
    '            MsgBox("Error")
    '        End Try
    '    End Using
    'End Sub

    Private Sub SearchAll_TextChanged(sender As Object, e As EventArgs) Handles SearchAll.TextChanged
        Using m_Dmgr As New DataManager(m_ConStr)
            Try
                m_dtdoor = m_Dmgr.GetDataTable("SELECT * FROM dbo.tcoEmployee WHERE CONCAT(EmployeeKey, UserName, FirstName, LastName, Email) LIKE '%" & SearchAll.Text & "%'")
                DataGridView1.DataSource = m_dtdoor
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End Using
    End Sub

End Class
Imports NarsilWorks.DevLib
Imports NarsilWorks.DevLibData
Imports NarsilWorks.DevLibWinForms
Imports DocumentFormat.OpenXml.InkML
Imports DocumentFormat.OpenXml.Wordprocessing
Imports System.Windows.Forms

Public Class ShippingForm
    Private m_IsLoading As Boolean = False
    Private m_IsEditing As Boolean = False
    Private dtm As DataManager
    Private m_MainConnStr As String = String.Empty
    Private m_InitialConnStr As String = ""
    Private m_dtdoor As DataTable

    Private Sub ShippingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Initialize()

        Call RefreshList()
    End Sub

    Private Sub RefreshList()
        Using dtm As New DataManager(m_ConStr)
            Try
                m_dtdoor = dtm.GetDataTable("SELECT DoorKey, DoorID, DoorName, Description FROM dbo.tcoDoor")
                DataGridView1.DataSource = m_dtdoor
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End Using
    End Sub

    Private Sub ImportButton_Click(sender As Object, e As EventArgs)
        Dim ofd As New OpenFileDialog
        Dim DoorKey As Integer = 0
        Dim DoorID As String
        Dim DoorName As String
        Dim Description As String
        ofd.Filter = "Excel 2007 files *.xlsx|*.xlsx"
        If ofd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                Using sl = New SpreadsheetLight.SLDocument(ofd.FileName)
                    Dim ws As SpreadsheetLight.SLWorksheetStatistics = sl.GetWorksheetStatistics()
                    Dim m_MaxRows = ws.NumberOfRows

                    Using m_Dmgr As New DataManager(m_ConStr)
                        For ix As Integer = 2 To m_MaxRows
                            DoorID = Trim(sl.GetCellValueAsString(ix, 1))
                            DoorName = Trim(sl.GetCellValueAsString(ix, 2))
                            Description = Trim(sl.GetCellValueAsString(ix, 3))
                            Dim m_existing As Boolean = False
                            If DoorID <> "" Then
                                m_existing = m_Dmgr.GetCount("dbo.tcoDoor WHERE DoorID = @p1", DoorID)
                                If Not m_existing Then
                                    DoorKey = m_Dmgr.GetValue("EXEC ssh_getnextnumberapps @p1", 0, "DoorKey")
                                    Dim q As New QueryBuilder("tcoDoor")
                                    q.CommandType = QueryBuilder.CommandQuery.cqINSERT
                                    q.AddFieldValuePair("DoorKey", DoorKey, True)
                                    q.AddFieldValuePair("DoorID", DoorID, True)
                                    q.AddFieldValuePair("DoorName", DoorName, True)
                                    q.AddFieldValuePair("Description", Description, True)
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

    Private Sub ExportButton_Click(sender As Object, e As EventArgs)
        Try
            Dim sfd As New SaveFileDialog
            sfd.Filter = "Excel 2007 files (*.xlsx)|*.xlsx"
            If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then

                Using sl = New SpreadsheetLight.SLDocument()
                    Dim m_Dmgr As New DataManager(m_ConStr)
                    Dim dataTable As DataTable = m_Dmgr.GetDataTable("SELECT DoorKey, DoorID, DoorName, Description FROM dbo.tcoDoor")

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

    Private Sub AddButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub SearchAll_TextChanged(sender As Object, e As EventArgs)
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
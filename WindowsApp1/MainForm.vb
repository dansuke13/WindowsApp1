Imports NarsilWorks.DevLib
Imports NarsilWorks.DevLibData
Imports McKenzie.Permissions.Zeus
Imports System.Collections.ObjectModel
Imports NarsilWorks.DevLibWinForms
Public Class MainForm


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        Try
            If g_EmployeeForm Is Nothing Then
                g_EmployeeForm = New EmployeeForm
            End If
            If g_EmployeeForm IsNot Nothing Then
                If g_EmployeeForm.IsDisposed Then
                    g_EmployeeForm = New EmployeeForm
                End If
                g_EmployeeForm.MdiParent = Me
                g_EmployeeForm.Show()
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub ShippingsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ShippingsToolStripMenuItem.Click
        Try
            If g_ShippingForm Is Nothing Then
                g_ShippingForm = New ShippingForm
            End If
            If g_ShippingForm IsNot Nothing Then
                If g_ShippingForm.IsDisposed Then
                    g_ShippingForm = New ShippingForm
                End If
                g_ShippingForm.MdiParent = Me
                g_ShippingForm.Show()
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class

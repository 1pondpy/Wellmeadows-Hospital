Imports System.Configuration
Imports System.Data.SqlClient

Public Class Staff_StaffAllocation

    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub StaffAllocationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffAllocationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StaffAllocationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")
    End Sub

    Private Sub Staff_StaffAllocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.StaffAllocation' table. You can move, or remove it, as needed.
        Me.StaffAllocationTableAdapter.Fill(Me.WellmeadowsDBDataSet.StaffAllocation)

    End Sub

    Private Sub SearchStaffAllocation_Click(sender As Object, e As EventArgs) Handles SearchStaffAllocation.Click
        Dim sForm As Staff_SearchStaffName
        sForm = New Staff_SearchStaffName()
        sForm.ShowDialog()
        StaffIDTextBox.Text = sForm.StaffID
        Label1.Text = sForm.StaffName
    End Sub

    Private Sub SearchWardAllo_Click(sender As Object, e As EventArgs) Handles SearchWardAllo.Click
        Dim sForm As Ward_SearchWard
        sForm = New Ward_SearchWard()
        sForm.ShowDialog()
        WardTextBox.Text = sForm.WardID
        Label2.Text = sForm.WardName
    End Sub

    Private Sub SearchWeekAllo_Click(sender As Object, e As EventArgs) Handles SearchWeekAllo.Click
        Dim sForm As Ward_SearchWeek
        sForm = New Ward_SearchWeek()
        sForm.ShowDialog()
        WeekTextBox.Text = sForm.WeekID
        Label3.Text = sForm.WeekStartDate
    End Sub


End Class
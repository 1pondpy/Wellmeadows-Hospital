Imports System.Configuration
Imports System.Data.SqlClient

Public Class Staff_AddStaffWorkExp

    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub StaffWorkExpBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffWorkExpBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StaffWorkExpBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")
    End Sub

    Private Sub Staff_AddStaffWorkExp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.StaffWorkExp' table. You can move, or remove it, as needed.
        Me.StaffWorkExpTableAdapter.Fill(Me.WellmeadowsDBDataSet.StaffWorkExp)

    End Sub

    Private Sub SearchStaffWorkExp_Click(sender As Object, e As EventArgs) Handles SearchStaffWorkExp.Click
        Dim sForm As Staff_SearchStaffName
        sForm = New Staff_SearchStaffName()
        sForm.ShowDialog()
        StaffIDTextBox.Text = sForm.StaffID
        Label1.Text = sForm.StaffName
    End Sub
End Class
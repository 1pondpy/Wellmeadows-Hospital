Imports System.Configuration
Imports System.Data.SqlClient
Public Class Staff_AddStaffQual

    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString


    Private Sub StaffQualificationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffQualificationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StaffQualificationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")
    End Sub

    Private Sub Staff_AddStaffQual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.QualView' table. You can move, or remove it, as needed.
        Me.QualViewTableAdapter.Fill(Me.WellmeadowsDBDataSet.QualView)
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.WellmeadowsDBDataSet.Staff)
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.StaffQualification' table. You can move, or remove it, as needed.
        Me.StaffQualificationTableAdapter.Fill(Me.WellmeadowsDBDataSet.StaffQualification)

    End Sub

    Private Sub SearchStaffQual_Click(sender As Object, e As EventArgs) Handles SearchStaffQual.Click
        Dim sForm As Staff_SearchStaffName
        sForm = New Staff_SearchStaffName()
        sForm.ShowDialog()
        StaffIDTextBox.Text = sForm.StaffID
        Label1.Text = sForm.StaffName

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
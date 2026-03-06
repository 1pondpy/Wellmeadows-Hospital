Public Class Clinic_AddClinic
    Private Sub ClinicBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClinicBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClinicBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")
    End Sub

    Private Sub Clinic_AddClinic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.Clinic' table. You can move, or remove it, as needed.
        Me.ClinicTableAdapter.Fill(Me.WellmeadowsDBDataSet.Clinic)

    End Sub
End Class
Public Class LD_AddLocalDoctor
    Private Sub LocalDoctorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LocalDoctorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LocalDoctorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")

    End Sub

    Private Sub LD_AddLocalDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.LocalDoctor' table. You can move, or remove it, as needed.
        Me.LocalDoctorTableAdapter.Fill(Me.WellmeadowsDBDataSet.LocalDoctor)

    End Sub

    Private Sub SearchStaffQual_Click(sender As Object, e As EventArgs) Handles SearchStaffQual.Click
        Dim sForm As Clinic_SearchClinic
        sForm = New Clinic_SearchClinic()
        sForm.ShowDialog()
        ClinicNoTextBox.Text = sForm.ClinicNo
        Label1.Text = sForm.ClinicName
    End Sub
End Class
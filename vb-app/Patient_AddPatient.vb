Public Class Patient_AddPatient
    Private Sub PatientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PatientBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")
    End Sub

    Private Sub Patient_AddPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.Patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me.WellmeadowsDBDataSet.Patient)

    End Sub

    Private Sub SearchStaffQual_Click(sender As Object, e As EventArgs) Handles SearchStaffQual.Click
        Dim sForm As LD_SearchLD
        sForm = New LD_SearchLD()
        sForm.ShowDialog()
        LDTextbox.Text = sForm.LocalDoctorID
        Label1.Text = sForm.LDName
    End Sub

End Class
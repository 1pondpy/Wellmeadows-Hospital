Public Class Patient_Insurance
    Private Sub PatientInsuranceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PatientInsuranceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PatientInsuranceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")
    End Sub

    Private Sub Patient_Insurance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.PatientInsurance' table. You can move, or remove it, as needed.
        Me.PatientInsuranceTableAdapter.Fill(Me.WellmeadowsDBDataSet.PatientInsurance)

    End Sub

    Private Sub AddPatient_Click(sender As Object, e As EventArgs) Handles AddPatient.Click
        Dim sForm As Patient_SearchPatientName
        sForm = New Patient_SearchPatientName()
        sForm.ShowDialog()
        PatientIDTextBox.Text = sForm.PatientID
        Label1.Text = sForm.PatientName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sForm As Insurance_Search
        sForm = New Insurance_Search()
        sForm.ShowDialog()
        InsuranceIDTextBox.Text = sForm.InsuranceID
        Label2.Text = sForm.InsuranceName
    End Sub
End Class
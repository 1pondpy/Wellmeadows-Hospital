Public Class Patient_NextOfKin
    Private Sub NextOfKinBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles NextOfKinBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NextOfKinBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")
    End Sub

    Private Sub Patient_NextOfKin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.NextOfKin' table. You can move, or remove it, as needed.
        Me.NextOfKinTableAdapter.Fill(Me.WellmeadowsDBDataSet.NextOfKin)

    End Sub

    Private Sub SearchStaffQual_Click(sender As Object, e As EventArgs) Handles SearchStaffQual.Click
        Dim sForm As Patient_SearchPatientName
        sForm = New Patient_SearchPatientName()
        sForm.ShowDialog()
        PatientIDTextBox.Text = sForm.PatientID
        Label1.Text = sForm.PatientName
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
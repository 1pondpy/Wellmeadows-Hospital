Public Class Patient_MedRecord
    Private Sub MedRecordBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MedRecordBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MedRecordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")
    End Sub

    Private Sub Patient_MedRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' โหลดข้อมูล
        Me.MedRecordTableAdapter.Fill(Me.WellmeadowsDBDataSet.MedRecord)

    End Sub

    Private Sub MedRecordDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)

        e.ThrowException = False
    End Sub



    Private Sub SearchPatient_Click(sender As Object, e As EventArgs) Handles SearchPatient.Click
        Dim sForm As Patient_SearchPatientName
        sForm = New Patient_SearchPatientName()
        sForm.ShowDialog()
        PatientIDTextBox.Text = sForm.PatientID
        Label2.Text = sForm.PatientName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sForm As Supplies_SearchPharmaName
        sForm = New Supplies_SearchPharmaName()
        sForm.ShowDialog()
        DrugIDTextBox.Text = sForm.DrugID
        Label3.Text = sForm.DrugName
    End Sub

End Class
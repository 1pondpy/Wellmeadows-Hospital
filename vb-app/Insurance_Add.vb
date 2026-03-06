Public Class Insurance_Add
    Private Sub InsuranceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InsuranceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InsuranceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")

    End Sub

    Private Sub Insurance_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.Insurance' table. You can move, or remove it, as needed.
        Me.InsuranceTableAdapter.Fill(Me.WellmeadowsDBDataSet.Insurance)

    End Sub
End Class
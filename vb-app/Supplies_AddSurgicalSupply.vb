Public Class Supplies_AddSurgicalSupply
    Private Sub SurgicalSupplyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SurgicalSupplyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SurgicalSupplyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บักทึกแล้ว")
    End Sub

    Private Sub Supplies_AddSurgicalSupply_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.SurgicalSupply' table. You can move, or remove it, as needed.
        Me.SurgicalSupplyTableAdapter.Fill(Me.WellmeadowsDBDataSet.SurgicalSupply)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sForm As Supplies_SearchSupplierName
        sForm = New Supplies_SearchSupplierName()
        sForm.ShowDialog()
        SupplierIDTextBox.Text = sForm.SupplierID
        Label2.Text = sForm.SupplierName
    End Sub
End Class
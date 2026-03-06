Public Class Supplies_AddNonSurgicalSupply
    Private Sub NonSurgicalSupplyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles NonSurgicalSupplyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NonSurgicalSupplyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บักทึกแล้ว")
    End Sub

    Private Sub Supplies_AddNonSurgicalSupply_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.NonSurgicalSupply' table. You can move, or remove it, as needed.
        Me.NonSurgicalSupplyTableAdapter.Fill(Me.WellmeadowsDBDataSet.NonSurgicalSupply)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sForm As Supplies_SearchSupplierName
        sForm = New Supplies_SearchSupplierName()
        sForm.ShowDialog()
        SupplierIDTextBox.Text = sForm.SupplierID
        Label2.Text = sForm.SupplierName
    End Sub
End Class
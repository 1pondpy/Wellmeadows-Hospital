Public Class Supplies_AddPharmaceutical

    Private Sub Supplies_AddPharmaceutical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.PharmaSupply' table. You can move, or remove it, as needed.
        Me.PharmaSupplyTableAdapter.Fill(Me.WellmeadowsDBDataSet.PharmaSupply)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sForm As Supplies_SearchSupplierName
        sForm = New Supplies_SearchSupplierName()
        sForm.ShowDialog()
        SupplierIDTextBox.Text = sForm.SupplierID
        Label2.Text = sForm.SupplierName
    End Sub

    Private Sub PharmaSupplyBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles PharmaSupplyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PharmaSupplyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")
    End Sub
End Class
Public Class Patient_AddBed
    Private Sub BedBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BedBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BedBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")
    End Sub

    Private Sub Patient_AddBed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.Bed' table. You can move, or remove it, as needed.
        Me.BedTableAdapter.Fill(Me.WellmeadowsDBDataSet.Bed)

    End Sub
End Class
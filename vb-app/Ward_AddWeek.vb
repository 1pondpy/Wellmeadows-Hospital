Public Class Ward_AddWeek
    Private Sub WeekBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WeekBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WeekBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")
    End Sub

    Private Sub Ward_AddWeek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.Week' table. You can move, or remove it, as needed.
        Me.WeekTableAdapter.Fill(Me.WellmeadowsDBDataSet.Week)

    End Sub
End Class
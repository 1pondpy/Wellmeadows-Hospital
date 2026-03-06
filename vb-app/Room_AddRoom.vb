Public Class Room_AddRoom
    Private Sub RoomBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RoomBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RoomBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")
    End Sub

    Private Sub Room_AddRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.Room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me.WellmeadowsDBDataSet.Room)

    End Sub
End Class
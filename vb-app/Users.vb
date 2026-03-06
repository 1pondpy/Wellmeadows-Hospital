Public Class Users

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.WellmeadowsDBDataSet.Users)

    End Sub


    Private Sub UsersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")
    End Sub


    Private Sub SearchStaffQual_Click_1(sender As Object, e As EventArgs) Handles SearchStaffQual.Click
        Dim sForm As Staff_SearchStaffName
        sForm = New Staff_SearchStaffName()
        sForm.ShowDialog()
        StaffIDTextBox.Text = sForm.StaffID
        Label2.Text = sForm.StaffName
    End Sub
End Class
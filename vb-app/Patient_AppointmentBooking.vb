Public Class Patient_AppointmentBooking

    Private Sub Patient_AppointmentBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WellmeadowsDBDataSet.Appointment' table. You can move, or remove it, as needed.
        Me.AppointmentTableAdapter.Fill(Me.WellmeadowsDBDataSet.Appointment)
    End Sub



    Private Sub AppointmentBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles AppointmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")
    End Sub


    Private Sub SearchRoom_Click_1(sender As Object, e As EventArgs) Handles SearchRoom.Click
        Dim sForm As Room_SearchRoom
        sForm = New Room_SearchRoom()
        sForm.ShowDialog()
        RoomIDTextBox.Text = sForm.RoomID
        Label3.Text = sForm.RoomType
    End Sub

    Private Sub SearchPatient_Click_1(sender As Object, e As EventArgs) Handles SearchPatient.Click
        Dim sForm As Patient_SearchPatientName
        sForm = New Patient_SearchPatientName()
        sForm.ShowDialog()
        PatientIDTextBox.Text = sForm.PatientID
        Label2.Text = sForm.PatientName
    End Sub

    Private Sub SearchStaff_Click(sender As Object, e As EventArgs) Handles SearchStaff.Click
        Dim sForm As Staff_SearchStaffName
        sForm = New Staff_SearchStaffName()
        sForm.ShowDialog()
        StaffIDTextBox.Text = sForm.StaffID
        Label1.Text = sForm.StaffName
    End Sub
End Class
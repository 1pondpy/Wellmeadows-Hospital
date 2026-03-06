Imports System.Configuration
Imports System.Data.SqlClient

Public Class Patient_SearchOutpatientName
    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString
    Dim tablePatient As New DataTable

    Public PatientName As String
    Public PatientID As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim keyword As String = TextBox1.Text.Trim()

        Dim sql As String =
            "SELECT a.AppointmentID, p.PatientID,
                    (p.FirstName + ' ' + p.LastName) AS FullName, p.Phone, p.Sex,
                    a.Date, a.Time, r.RoomID, r.RoomNo, r.RoomType,
                    a.ConsultantStaffID, (s.FirstName + ' ' + s.LastName) AS ConsultantStaffFullName
             FROM dbo.Patient p, dbo.Appointment a, dbo.Staff s, dbo.Room r
             WHERE (p.FirstName + ' ' + p.LastName) LIKE @q AND p.PatientID = a.PatientID AND a.RoomID = r.RoomID AND a.ConsultantStaffID = s.StaffID;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.Add("@q", SqlDbType.NVarChar, 100).Value = "%" & keyword & "%"

                Using da As New SqlDataAdapter(cmd)
                    tablePatient.Clear()                 ' เคลียร์ผลเดิมก่อน
                    da.Fill(tablePatient)
                End Using
            End Using
        End Using

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = tablePatient
        DataGridView1.Refresh()

        If tablePatient.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบรายการที่ตรงกับคำค้นหา")
        End If
    End Sub

    Private Sub Patient_SearchOutpatientName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DataGridView1
            .ReadOnly = True
            .EditMode = DataGridViewEditMode.EditProgrammatically
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
    End Sub
End Class
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Patient_SearchInpatientName
    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString
    Dim tablePatient As New DataTable

    Public PatientName As String
    Public PatientID As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim keyword As String = TextBox1.Text.Trim()

        Dim sql As String =
            "SELECT i.InpatientID, p.PatientID,
                    (p.FirstName + ' ' + p.LastName) AS FullName,
                    p.Phone, p.Sex, i.DateWaitingList, i.ExpectedDayStay, i.DatePlaced, i.DateLeave, i.DateActualLeave, b.BedNo, w.WardID, w.WardName
             FROM dbo.Patient p, dbo.Inpatient i, dbo.Bed b, dbo.Ward w
             WHERE (p.FirstName + ' ' + p.LastName) LIKE @q AND p.PatientID = i.InpatientID AND i.BedID = b.BedID AND i.WardID = w.WardID;"

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

    Private Sub Patient_SearchInpatientName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Patient_SearchPatientNextOfKin
    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString
    Dim tablePatient As New DataTable



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim keyword As String = TextBox1.Text.Trim()

        Dim sql As String =
        "SELECT 
            p.PatientID,
            CONCAT(p.FirstName, ' ', p.LastName)       AS FullName,
            p.Phone                                    AS PatientPhone,
            n.NextOfKinID,
            CONCAT(n.FirstName, ' ', n.LastName)       AS NextOfKinFullName,
            n.Phone                                    AS NextOfKinPhone,
            n.Relationship
        FROM dbo.Patient p
        INNER JOIN dbo.NextOfKin n
            ON n.PatientID = p.PatientID              -- ✅ แก้จุดนี้
        WHERE CONCAT(p.FirstName, ' ', p.LastName) LIKE @q
        ORDER BY p.PatientID, n.NextOfKinID;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.Add("@q", SqlDbType.NVarChar, 100).Value = "%" & keyword & "%"
                Using da As New SqlDataAdapter(cmd)
                    tablePatient.Clear()
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

End Class
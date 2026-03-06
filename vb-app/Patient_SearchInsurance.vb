Imports System.Configuration
Imports System.Data.SqlClient

Public Class Patient_SearchInsurance
    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString

    Dim tableResult As New DataTable



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim keyword As String = TextBox1.Text.Trim()

        ' หมายเหตุ:
        ' - โครงนี้ใช้ได้ทั้งกรณีมีแค่ PatientInsurance(Notes) อย่างเดียว
        ' - ถ้าไม่ได้มี IsPrimary/StartDate/EndDate ก็ไม่เป็นไร คิวรีนี้ไม่อ้างถึง
        Dim sql As String =
            "SELECT p.PatientID,
                    (p.FirstName + ' ' + p.LastName) AS FullName,
                    COALESCE(i.InsuranceName, 'No Insurance') AS InsuranceName, IsPrimary,
                    pi.Notes
             FROM dbo.Patient p
             LEFT JOIN dbo.PatientInsurance pi ON pi.PatientID = p.PatientID
             LEFT JOIN dbo.Insurance i ON i.InsuranceID = pi.InsuranceID
             WHERE (p.FirstName + ' ' + p.LastName) LIKE @q
             ORDER BY FullName, InsuranceName;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.Add("@q", SqlDbType.NVarChar, 100).Value = "%" & keyword & "%"

                Using da As New SqlDataAdapter(cmd)
                    tableResult.Clear()
                    da.Fill(tableResult)
                End Using
            End Using
        End Using

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = tableResult
        DataGridView1.Refresh()

        If tableResult.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบรายการที่ตรงกับคำค้นหา")
        End If

        If DataGridView1.Columns.Contains("IsPrimary") Then
            DataGridView1.Columns("IsPrimary").ReadOnly = True
        End If

        ApplyGridSettings()
    End Sub


    ' แนะนำตั้งค่ากริดให้อ่านอย่างเดียว + เลือกทั้งแถว
    Private Sub ApplyGridSettings()
        With DataGridView1
            .ReadOnly = True
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
    End Sub

End Class

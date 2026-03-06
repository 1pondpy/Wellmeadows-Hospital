Imports System.Configuration
Imports System.Data.SqlClient
Imports WellmeadowsHospital.WellmeadowsDBDataSet

Public Class Clinic_SearchClinic
    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString
    Dim tablePatient As New DataTable

    Public ClinicNo As String
    Public ClinicName As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim keyword As String = TextBox1.Text.Trim()

        Dim sql As String =
            "SELECT *
             FROM dbo.Clinic
             WHERE ClinicName LIKE @q;"

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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
    Handles DataGridView1.CellContentClick, DataGridView1.CellClick, DataGridView1.CellDoubleClick

        If e.RowIndex < 0 Then Return

        ClinicNo = DataGridView1.Rows(e.RowIndex).Cells("ClinicNo").Value.ToString()
        ClinicName = DataGridView1.Rows(e.RowIndex).Cells("ClinicName").Value.ToString()

        ' เพิ่มบรรทัดนี้ (ไม่บังคับ แต่ช่วยให้หน้าเรียกใช้งานรู้ว่าเลือกแล้ว)
        Me.DialogResult = DialogResult.OK

        Me.Close()
    End Sub
End Class
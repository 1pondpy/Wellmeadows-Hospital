Imports System.Configuration
Imports System.Data.SqlClient

Public Class LD_SearchLD

    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString

    Dim tableStaff As New DataTable

    Public LDName As String
    Public LocalDoctorID As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim keyword As String = TextBox1.Text.Trim()

        Dim sql As String =
        "SELECT LocalDoctoriD, FirstName + ' ' + LastName AS FullName, Address, Phone, ClinicNo
             FROM dbo.LocalDoctor
             WHERE (FirstName + ' ' + LastName) LIKE @q;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.Add("@q", SqlDbType.NVarChar, 100).Value = "%" & keyword & "%"

                Using da As New SqlDataAdapter(cmd)
                    tableStaff.Clear()                 ' เคลียร์ผลเดิมก่อน
                    da.Fill(tableStaff)
                End Using
            End Using
        End Using

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = tableStaff
        DataGridView1.Refresh()

        If tableStaff.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบรายการที่ตรงกับคำค้นหา")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Return
        LocalDoctorID = DataGridView1.Rows(e.RowIndex).Cells("LocalDoctorID").Value.ToString()
        LDName = DataGridView1.Rows(e.RowIndex).Cells("FullName").Value.ToString()
        Me.Close()
    End Sub
End Class
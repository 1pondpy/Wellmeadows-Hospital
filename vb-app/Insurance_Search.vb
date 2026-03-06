Imports System.Configuration
Imports System.Data.SqlClient

Public Class Insurance_Search

    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString

    Dim tableStaff As New DataTable

    Public InsuranceID As String
    Public InsuranceName As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim keyword As String = TextBox1.Text.Trim()

        Dim sql As String =
            "SELECT *
             FROM dbo.Insurance
             WHERE InsuranceName LIKE @q;"

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
        InsuranceID = DataGridView1.Rows(e.RowIndex).Cells("InsuranceID").Value.ToString()
        InsuranceName = DataGridView1.Rows(e.RowIndex).Cells("InsuranceName").Value.ToString()
        Me.Close()
    End Sub
End Class
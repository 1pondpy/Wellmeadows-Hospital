Imports System.Configuration
Imports System.Data.SqlClient

Public Class Supplies_SearchNonSurSupplyName
    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString
    Dim table As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim keyword As String = TextBox1.Text.Trim()

        Dim sql As String =
            "SELECT dbo.NonSurgicalSupply.*, dbo.Supplier.SupplierName, dbo.Supplier.Phone
            FROM dbo.NonSurgicalSupply INNER JOIN dbo.Supplier ON dbo.NonSurgicalSupply.SupplierID = dbo.Supplier.SupplierID
             WHERE dbo.NonSurgicalSupply.NonSurName LIKE @q;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.Add("@q", SqlDbType.NVarChar, 100).Value = "%" & keyword & "%"

                Using da As New SqlDataAdapter(cmd)
                    table.Clear()                 ' เคลียร์ผลเดิมก่อน
                    da.Fill(table)
                End Using
            End Using
        End Using

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = table
        DataGridView1.Refresh()

        If table.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบรายการที่ตรงกับคำค้นหา")
        End If
    End Sub
End Class
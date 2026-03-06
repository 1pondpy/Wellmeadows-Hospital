Imports System.Configuration
Imports System.Data.SqlClient

Public Class Supplies_SearchSupplierName

    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString

    Private table As New DataTable

    ' === ค่าที่จะส่งกลับไปยังฟอร์มที่เรียก ===
    Public Property SupplierID As Integer
    Public Property SupplierName As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim keyword As String = TextBox1.Text.Trim()

        Dim sql As String =
            "SELECT *
               FROM dbo.Supplier
              WHERE SupplierName LIKE @q
              ORDER BY SupplierName;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.Add("@q", SqlDbType.NVarChar, 100).Value = "%" & keyword & "%"
                Using da As New SqlDataAdapter(cmd)
                    table.Clear()
                    da.Fill(table)
                End Using
            End Using
        End Using

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = table

        If table.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบรายการที่ตรงกับคำค้นหา")
        End If
    End Sub

    ' ดับเบิลคลิกเพื่อเลือก
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Then Return
        SupplierID = DataGridView1.Rows(e.RowIndex).Cells("SupplierID").Value.ToString()
        SupplierName = DataGridView1.Rows(e.RowIndex).Cells("SupplierName").Value.ToString()
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class

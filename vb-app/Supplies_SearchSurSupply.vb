Imports System.Data.SqlClient

Public Class Supplies_SearchSurSupply
    Private connectionString As String = "Data Source=PondpySoLovely\WELLMEADOWS;Initial Catalog=WellmeadowsDB;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim tablePharma As New DataTable

    Public DrugName As String
    Public DrugID As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim keyword As String = TextBox1.Text.Trim()

        Dim sql As String =
            "SELECT * FROM SurgicalSupply
             WHERE SurName LIKE @q;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.Add("@q", SqlDbType.NVarChar, 100).Value = "%" & keyword & "%"

                Using da As New SqlDataAdapter(cmd)
                    tablePharma.Clear()                 ' เคลียร์ผลเดิมก่อน
                    da.Fill(tablePharma)
                End Using
            End Using
        End Using

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = tablePharma
        DataGridView1.Refresh()

        If tablePharma.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบรายการที่ตรงกับคำค้นหา")
        End If
    End Sub
End Class